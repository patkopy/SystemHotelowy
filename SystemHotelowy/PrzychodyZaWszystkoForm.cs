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
    public partial class PrzychodyZaWszystkoForm : Form
    {
        public PrzychodyZaWszystkoForm()
        {
            InitializeComponent();
        }

        public PrzychodyZaWszystkoForm(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }

        private void PrzychodyZaWszystkoForm_Load(object sender, EventArgs e)
        {
            WypelnienieComboBox();
            WyswietlanieZawartosciChart();
        }

        void WypelnienieComboBox()
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                var query = from RachunkiZaPobyt r in db.RachunkiZaPobyt
                            group r by r.TerminZaplaty.Year into pogrupowane
                            orderby pogrupowane.Key
                            select pogrupowane.Key;
                var results = query.ToList();
                comboBoxRok.DataSource = results;
            }
        }

        void WyswietlanieZawartosciChart()
        {
            chartPrzychodyZaWszystko.Series["Przychody całkowite"].IsValueShownAsLabel = true;
            if (comboBoxRok.SelectedItem != null)
            {
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    DateTime rok = Convert.ToDateTime(comboBoxRok.SelectedItem.ToString() + "-01-01");
                    var rachunkizapobyt = db.RachunkiZaPobyt
                        .Where(x => x.TerminZaplaty.Year == rok.Year)
                        .GroupBy(s => new { miesiac = s.TerminZaplaty.Month })
                        .Select(x => new { suma = x.Sum(a => a.Kwota), x.Key.miesiac })
                        .ToArray();
                    var rachunkizauslugi = db.RachunkiZaUslugi
                        .Where(x => x.TerminZaplaty.Year == rok.Year)
                        .GroupBy(s => new { miesiac = s.TerminZaplaty.Month })
                        .Select(x => new { suma = x.Sum(a => a.Kwota), x.Key.miesiac })
                        .ToArray();
                    var rachunkizadania = db.RachunkiZaDania
                        .Where(x => x.TerminZaplaty.Year == rok.Year)
                        .GroupBy(s => new { miesiac = s.TerminZaplaty.Month })
                        .Select(x => new { suma = x.Sum(a => a.Kwota), x.Key.miesiac })
                        .ToArray();

                    try
                    {
                        for (int i = 0; i < rachunkizapobyt.Count(); i++)
                        {
                            chartPrzychodyZaWszystko.Series["Przychody całkowite"].Points.AddXY(rachunkizapobyt[i].miesiac, rachunkizapobyt[i].suma + rachunkizauslugi[i].suma + rachunkizadania[i].suma);
                        }
                    }
                    catch(IndexOutOfRangeException)
                    {
                        MessageBox.Show("Brak danych dla wszystkich miesięcy. Zmień rok lub dodaj przynajmniej jeden rachunek każdego typu w każdym miesiącu wybranego roku.");
                    }
                }
            }
        }

        private void buttonWyswietl_Click(object sender, EventArgs e)
        {
            chartPrzychodyZaWszystko.Series["Przychody całkowite"].Points.Clear();
            WyswietlanieZawartosciChart();
        }
    }
}
