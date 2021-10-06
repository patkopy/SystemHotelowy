using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHotelowy
{
    public partial class OblozenieObiektuForm : Form
    {
        public OblozenieObiektuForm()
        {
            InitializeComponent();
        }
        public OblozenieObiektuForm(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }
        private void OblozenieObiektuForm_Load(object sender, EventArgs e)
        {
            WypelnienieComboBox();
            WyswietlanieZawartosciChart();
        }

        void WypelnienieComboBox()
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                var query = from Meldunki m in db.Meldunki
                            group m by m.DataOd.Year into pogrupowane
                            orderby pogrupowane.Key
                            select pogrupowane.Key;
                var results = query.ToList();
                comboBoxRok.DataSource = results;
            }
        }
        void WyswietlanieZawartosciChart()
        {
            chartOblozenieObiektu.Series["Obłożenie obiektu"].IsValueShownAsLabel = true;
            if (comboBoxRok.SelectedItem != null)
            {
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    DateTime rok = Convert.ToDateTime(comboBoxRok.SelectedItem.ToString() + "-01-01");
                    var meldunkiTab = db.Meldunki
                                      .Where(x => x.DataOd.Year == rok.Year)
                                      .GroupBy(s => new { miesiac = s.DataOd.Month })
                                      .Select(x => new { count = x.Count(), x.Key.miesiac })
                                      .ToArray();

                    for (int i = 0; i < meldunkiTab.Count(); i++)
                    {
                        chartOblozenieObiektu.Series["Obłożenie obiektu"].Points.AddXY(meldunkiTab[i].miesiac, meldunkiTab[i].count);
                    }
                }
            }
        }

        private void buttonWyswietl_Click(object sender, EventArgs e)
        {
            chartOblozenieObiektu.Series["Obłożenie obiektu"].Points.Clear();
            WyswietlanieZawartosciChart();
        }
    }
}
