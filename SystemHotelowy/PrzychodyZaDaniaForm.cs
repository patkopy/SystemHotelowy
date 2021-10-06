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
    public partial class PrzychodyZaDaniaForm : Form
    {
        public PrzychodyZaDaniaForm()
        {
            InitializeComponent();
        }

        public PrzychodyZaDaniaForm(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }

        private void PrzychodyZaDaniaForm_Load(object sender, EventArgs e)
        {
            WypelnienieComboBox();
            WyswietlanieZawartosciChart();
        }

        void WypelnienieComboBox()
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                var query = from RachunkiZaDania r in db.RachunkiZaDania
                            group r by r.TerminZaplaty.Year into pogrupowane
                            orderby pogrupowane.Key
                            select pogrupowane.Key;
                var results = query.ToList();
                comboBoxRok.DataSource = results;
            }
        }

        void WyswietlanieZawartosciChart()
        {
            chartPrzychodyZaDania.Series["Przychody za dania"].IsValueShownAsLabel = true;
            if (comboBoxRok.SelectedItem != null)
            {
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    DateTime rok = Convert.ToDateTime(comboBoxRok.SelectedItem.ToString() + "-01-01");
                    var rachunkizadania = db.RachunkiZaDania
                        .Where(x => x.TerminZaplaty.Year == rok.Year)
                        .GroupBy(s => new { miesiac = s.TerminZaplaty.Month })
                        .Select(x => new { suma = x.Sum(a => a.Kwota), x.Key.miesiac })
                        .ToArray();

                    for (int i = 0; i < rachunkizadania.Count(); i++)
                    {
                        chartPrzychodyZaDania.Series["Przychody za dania"].Points.AddXY(rachunkizadania[i].miesiac, rachunkizadania[i].suma);
                    }
                }
            }
        }

        private void buttonWyswietl_Click(object sender, EventArgs e)
        {
            chartPrzychodyZaDania.Series["Przychody za dania"].Points.Clear();
            WyswietlanieZawartosciChart();
        }
    }
}
