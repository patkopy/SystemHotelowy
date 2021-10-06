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
    public partial class DaniaForm : Form
    {
        Dania modelDania = new Dania();
        public DaniaForm()
        {
            InitializeComponent();
        }

        private void DaniaForm_Load(object sender, EventArgs e)
        {
            Wyczysc();
            WyswietlanieZawartosciTabeliDania();
            textBoxIdDania.Enabled = false;
            WyswietlanieZawartosciTabeliTyp();
            comboBoxTyp.SelectedItem = null;
            comboBoxTyp.SelectedText = "Wybierz";
        }
        public DaniaForm(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxNazwa.Text != "" && textBoxCena.Text != "" && textBoxOpis.Text != "")
            {
                modelDania.Typ = Convert.ToString(comboBoxTyp.SelectedItem);
                modelDania.Nazwa = Convert.ToString(textBoxNazwa.Text.Trim());
                modelDania.Cena = Convert.ToDouble(textBoxCena.Text.Trim());
                modelDania.Opis = Convert.ToString(textBoxOpis.Text.Trim());

                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    if (modelDania.IdDania == 0)
                        db.Dania.Add(modelDania);
                    else
                        db.Entry(modelDania).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                Wyczysc();
                WyswietlanieZawartosciTabeliDania();
                MessageBox.Show("Dodano pomyślnie", "Komunikat");
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd");
            }
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            Wyczysc();
            WyswietlanieZawartosciTabeliDania();
        }
    

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Na pewno usunąć te danie?", "Usuwanie dania", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    var entry = db.Entry(modelDania);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Dania.Attach(modelDania);
                    db.Dania.Remove(modelDania);
                    db.SaveChanges();
                    WyswietlanieZawartosciTabeliDania();
                    Wyczysc();
                    MessageBox.Show("Usunięto pomyślnie", "Komunikat");
                }
            }
        }

        void Wyczysc()
        {
            textBoxIdDania.Text = textBoxNazwa.Text = textBoxCena.Text = textBoxOpis.Text = "";
            buttonDodaj.Text = "Dodaj";
            buttonUsun.Enabled = false;
            modelDania.IdDania = 0;
            comboBoxTyp.SelectedItem = null;
        }

        void WyswietlanieZawartosciTabeliDania()
        {
            dataGridViewDania.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                dataGridViewDania.DataSource = db.Dania.OrderBy(a => a.Nazwa).ToList();
            }
        }

        private void dataGridViewDania_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewDania.CurrentRow.Index != -1)
            {
                modelDania.IdDania = Convert.ToInt32(dataGridViewDania.CurrentRow.Cells["IdDania"].Value);
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    modelDania = db.Dania.Where(x => x.IdDania == modelDania.IdDania).FirstOrDefault();
                    textBoxIdDania.Text = modelDania.IdDania.ToString();
                    comboBoxTyp.SelectedItem = modelDania.Typ.ToString();
                    textBoxNazwa.Text = modelDania.Nazwa.ToString();
                    textBoxCena.Text = modelDania.Cena.ToString();
                    textBoxOpis.Text = modelDania.Opis.ToString();
                }
                buttonDodaj.Text = "Aktualizuj";
                buttonUsun.Enabled = true;
            }
        }

        void WyswietlanieZawartosciTabeliTyp()
        {
            dataGridViewDania.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                var query = from Dania d in db.Dania
                            group d by d.Typ into pogrupowane
                            orderby pogrupowane.Key
                            select pogrupowane.Key;
                var results = query.ToList();
                comboBoxTyp.DataSource = results;
            }
        }

        private void buttonSzukajDania_Click(object sender, EventArgs e)
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                string nazwa = textBoxNazwa.Text.ToString();
                string typ = "Typ";
                if(comboBoxTyp.SelectedItem != null)
                {
                    typ = comboBoxTyp.SelectedItem.ToString();
                }
                else
                {
                    comboBoxTyp.SelectedItem = "Typ";
                }

                List<Dania> query = (from Dania d in db.Dania
                         where (d.Nazwa == nazwa && d.Typ == typ) || d.Typ == typ || d.Nazwa == nazwa
                         select d).OrderBy(a => a.Nazwa).ToList();

                dataGridViewDania.DataSource = query;

                if(dataGridViewDania.RowCount == 0)
                {
                    dataGridViewDania.DataSource = db.Dania.ToList();
                    MessageBox.Show("Dodaj nowe danie", "Brak dania", MessageBoxButtons.OK);
                }
            }
        }
    }
}
