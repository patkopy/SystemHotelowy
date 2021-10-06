using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHotelowy
{
    public partial class RachunkiZaDaniaForm : Form
    {
        RachunkiZaDania modelRachunkiZaDania = new RachunkiZaDania();
        Dania modelDania = new Dania();

        public RachunkiZaDaniaForm()
        {
            InitializeComponent();
        }

        public RachunkiZaDaniaForm(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }

        private void RachunkiZaDaniaForm_Load(object sender, EventArgs e)
        {
            Wyczysc();
            WyswietlanieZawartosciTabeliRachunkiZaDania();
            textBoxIdRachunkuZaDanie.Enabled = false;
            textBoxIdDania.Enabled = false;
            textBoxIdPracownika.Enabled = false;
            textBoxIdKlienta.Enabled = false;
            textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
            WyswietlanieZawartosciTabeliDania();
            WyswietlanieZawartosciTabeliTyp();
            comboBoxTyp.SelectedItem = null;
            comboBoxTyp.SelectedText = "Wybierz";
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxIdKlienta.Text != "" && textBoxIdDania.Text != "" && textBoxKwota.Text != "" && textBoxKwota.Text != "" && textBoxLiczbaDan.Text != "" && textBoxIdPracownika.Text != "")
            {
                modelRachunkiZaDania.IdKlienta = Convert.ToInt32(textBoxIdKlienta.Text.Trim());
                modelRachunkiZaDania.IdDania = Convert.ToInt32(textBoxIdDania.Text.Trim());
                modelRachunkiZaDania.Kwota = Convert.ToDouble(textBoxKwota.Text.Trim()) * Convert.ToInt32(textBoxLiczbaDan.Text.Trim());
                modelRachunkiZaDania.TerminZaplaty = Convert.ToDateTime(dateTimePickerTerminZaplaty.Text.Trim());
                modelRachunkiZaDania.CzyZaplacono = Convert.ToBoolean(checkBoxCzyZaplacono.Checked);
                modelRachunkiZaDania.IdPracownika = Convert.ToInt32(textBoxIdPracownika.Text.Trim());

                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    if (modelRachunkiZaDania.IdRachunkuZaDanie == 0)
                        db.RachunkiZaDania.Add(modelRachunkiZaDania);
                    else
                        db.Entry(modelRachunkiZaDania).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                Wyczysc();
                WyswietlanieZawartosciTabeliRachunkiZaDania();
                checkBoxCzyZaplacono.Checked = false;
                textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
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
            WyswietlanieZawartosciTabeliRachunkiZaDania();
            textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
            checkBoxCzyZaplacono.Checked = false;
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Na pewno usunąć ten rachunek za danie?", "Usuwanie rachunku za danie", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    var entry = db.Entry(modelRachunkiZaDania);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.RachunkiZaDania.Attach(modelRachunkiZaDania);
                    db.RachunkiZaDania.Remove(modelRachunkiZaDania);
                    db.SaveChanges();
                    WyswietlanieZawartosciTabeliRachunkiZaDania();
                    Wyczysc();
                    textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
                    checkBoxCzyZaplacono.Checked = false;
                    MessageBox.Show("Usunięto pomyślnie", "Komunikat");
                }
            }
        }

        void Wyczysc()
        {
            textBoxIdRachunkuZaDanie.Text = textBoxIdKlienta.Text = textBoxIdDania.Text = textBoxKwota.Text = textBoxLiczbaDan.Text = textBoxIdPracownika.Text = textBoxNazwisko.Text = textBoxNrTel.Text = "";
            buttonDodaj.Text = "Dodaj";
            buttonUsun.Enabled = false;
            modelRachunkiZaDania.IdRachunkuZaDanie = 0;
            dateTimePickerTerminZaplaty.Value = DateTime.Now;
            comboBoxTyp.ResetText();
            comboBoxTyp.SelectedItem = null;
            comboBoxTyp.SelectedText = "Wybierz";
            textBoxLiczbaDan.Enabled = true;
            WyswietlanieZawartosciTabeliDania();
        }

        void WyswietlanieZawartosciTabeliRachunkiZaDania()
        {
            dataGridViewRachunkiZaDania.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                dataGridViewRachunkiZaDania.DataSource = db.RachunkiZaDania.OrderByDescending(a => a.TerminZaplaty).ToList();
            }
        }

        private void dataGridViewRachunkiZaDania_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewRachunkiZaDania.CurrentRow.Index != -1)
            {
                modelRachunkiZaDania.IdRachunkuZaDanie = Convert.ToInt32(dataGridViewRachunkiZaDania.CurrentRow.Cells["IdRachunkuZaDanie"].Value);
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    modelRachunkiZaDania = db.RachunkiZaDania.Where(x => x.IdRachunkuZaDanie == modelRachunkiZaDania.IdRachunkuZaDanie).FirstOrDefault();
                    textBoxIdRachunkuZaDanie.Text = modelRachunkiZaDania.IdRachunkuZaDanie.ToString();
                    textBoxIdKlienta.Text = modelRachunkiZaDania.IdKlienta.ToString();
                    textBoxIdDania.Text = modelRachunkiZaDania.IdDania.ToString();
                    textBoxKwota.Text = modelRachunkiZaDania.Kwota.ToString();
                    dateTimePickerTerminZaplaty.Text = modelRachunkiZaDania.TerminZaplaty.ToShortDateString();
                    if (modelRachunkiZaDania.CzyZaplacono == true)
                        checkBoxCzyZaplacono.Checked = true;
                    else
                        checkBoxCzyZaplacono.Checked = false;
                    textBoxIdPracownika.Text = modelRachunkiZaDania.IdPracownika.ToString();
                }
                buttonDodaj.Text = "Aktualizuj";
                buttonUsun.Enabled = true;
                textBoxLiczbaDan.Enabled = false;

                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    double query = (from Dania d in db.Dania
                                 where d.IdDania == modelRachunkiZaDania.IdDania
                                 select d.Cena).First();
                    textBoxLiczbaDan.Text = (modelRachunkiZaDania.Kwota/query).ToString();
                }
            }
        }

        private void buttonSzukajKlienta_Click(object sender, EventArgs e)
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                string nazwisko = textBoxNazwisko.Text.ToString();
                string nrtel = textBoxNrTel.Text.ToString();
                int query = 0;
                query = (from Klienci k in db.Klienci
                         where k.Nazwisko == nazwisko && k.NrTel == nrtel
                         select k.IdKlienta).DefaultIfEmpty().First();

                if (query > 0)
                {
                    textBoxIdKlienta.Text = query.ToString();
                }
                else
                {
                    if (MessageBox.Show("Czy chcesz dodać nowego klienta?", "Brak klienta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        new KlienciForm(labelZalogowany.Text).Show();
                    }
                }
            }
        }

        public int SzukajIdPracownika()
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                string login = labelZalogowany.Text.ToString();
                int query = 0;
                query = (from Uzytkownicy u in db.Uzytkownicy
                         where u.Login == login
                         select u.IdPracownika).DefaultIfEmpty().First();
                return query;
            }
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
                modelDania.IdDania = Convert.ToInt32(dataGridViewDania.CurrentRow.Cells["DaniaIdDania"].Value);
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    modelDania = db.Dania.Where(x => x.IdDania == modelDania.IdDania).FirstOrDefault();
                    textBoxIdDania.Text = modelDania.IdDania.ToString();
                    comboBoxTyp.SelectedItem = modelDania.Typ.ToString();
                    textBoxKwota.Text = modelDania.Cena.ToString();
                }
            }
        }

        void WyswietlanieZawartosciTabeliTyp()
        {
            dataGridViewDania.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                var xd = db.Dania;
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
            dataGridViewDania.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                dataGridViewDania.DataSource = db.Dania.Where(x => x.Typ == comboBoxTyp.SelectedItem.ToString()).ToList();
            }
        }

    }
}