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
    public partial class PrzychodyZaUslugiForm : Form
    {
        public PrzychodyZaUslugiForm()
        {
            InitializeComponent();
        }

        public PrzychodyZaUslugiForm(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }

        private void PrzychodyZaUslugiForm_Load(object sender, EventArgs e)
        {
            WypelnienieComboBox();
            WyswietlanieZawartosciChart();
        }

        void WypelnienieComboBox()
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                var query = from RachunkiZaUslugi r in db.RachunkiZaUslugi
                            group r by r.TerminZaplaty.Year into pogrupowane
                            orderby pogrupowane.Key
                            select pogrupowane.Key;
                var results = query.ToList();
                comboBoxRok.DataSource = results;
            }
        }

        void WyswietlanieZawartosciChart()
        {
            chartPrzychodyZaUslugi.Series["Przychody za usługi"].IsValueShownAsLabel = true;

            if (comboBoxRok.SelectedItem != null)
            {
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    DateTime rok = Convert.ToDateTime(comboBoxRok.SelectedItem.ToString() + "-01-01");
                    var rachunkizauslugi = db.RachunkiZaUslugi
                        .Where(x => x.TerminZaplaty.Year == rok.Year)
                        .GroupBy(s => new { miesiac = s.TerminZaplaty.Month })
                        .Select(x => new { suma = x.Sum(a => a.Kwota), x.Key.miesiac })
                        .ToArray();

                    for (int i = 0; i < rachunkizauslugi.Count(); i++)
                    {
                        chartPrzychodyZaUslugi.Series["Przychody za usługi"].Points.AddXY(rachunkizauslugi[i].miesiac, rachunkizauslugi[i].suma);
                    }
                }
            }
        }

        private void buttonWyswietl_Click(object sender, EventArgs e)
        {
            chartPrzychodyZaUslugi.Series["Przychody za usługi"].Points.Clear();
            WyswietlanieZawartosciChart();
        }
    }
}
