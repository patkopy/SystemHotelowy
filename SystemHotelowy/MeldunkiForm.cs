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
    public partial class MeldunkiForm : Form
    {
        Meldunki modelMeldunki = new Meldunki();
        Rezerwacje modelRezerwacje = new Rezerwacje();

        public MeldunkiForm()
        {
            InitializeComponent();
        }

        private void MeldunkiForm_Load(object sender, EventArgs e)
        {
            Wyczysc();
            WyswietlanieZawartosciTabeliMeldunkiAktualne();
            textBoxIdMeldunku.Enabled = false;
            textBoxIdRezerwacji.Enabled = false;
            textBoxIdPracownika.Enabled = false;
            textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
            WyswietlanieZawartosciTabeliRezerwacje();
        }
        public MeldunkiForm(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxIdRezerwacji.Text != "" && textBoxLiczbaOsob.Text != "" && textBoxIdPracownika.Text != "")
            {
                modelMeldunki.IdRezerwacji = Convert.ToInt32(textBoxIdRezerwacji.Text.Trim());
                modelMeldunki.DataOd = Convert.ToDateTime(dateTimePickerDataOd.Text.Trim());
                modelMeldunki.DataDo = Convert.ToDateTime(dateTimePickerDataDo.Text.Trim());
                modelMeldunki.LiczbaOsob = Convert.ToInt32(textBoxLiczbaOsob.Text.Trim());
                modelMeldunki.CzyAktywny = Convert.ToBoolean(checkBoxCzyAktywny.Checked);
                var LiczbaDob = (modelMeldunki.DataDo - modelMeldunki.DataOd).Days;
                modelMeldunki.LiczbaDob = LiczbaDob;
                modelMeldunki.IdPracownika = Convert.ToInt32(textBoxIdPracownika.Text.Trim());

                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    if (modelMeldunki.IdMeldunku == 0)
                        db.Meldunki.Add(modelMeldunki);
                    else
                        db.Entry(modelMeldunki).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                Wyczysc();
                WyswietlanieZawartosciTabeliMeldunkiAktualne();
                checkBoxCzyAktywny.Checked = false;
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
            WyswietlanieZawartosciTabeliMeldunkiAktualne();
            textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
            checkBoxCzyAktywny.Checked = false;
            WyswietlanieZawartosciTabeliRezerwacje();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Na pewno usunąć ten meldunek?", "Usuwanie meldunku", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    var entry = db.Entry(modelMeldunki);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Meldunki.Attach(modelMeldunki);
                    db.Meldunki.Remove(modelMeldunki);
                    db.SaveChanges();
                    WyswietlanieZawartosciTabeliMeldunkiAktualne();
                    Wyczysc();
                    textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
                    checkBoxCzyAktywny.Checked = false;
                    MessageBox.Show("Usunięto pomyślnie", "Komunikat");
                }
            }
        }

        void Wyczysc()
        {
            textBoxIdMeldunku.Text = textBoxIdRezerwacji.Text = textBoxLiczbaOsob.Text = textBoxIdPracownika.Text = textBoxNazwisko.Text = textBoxNrTel.Text = "";
            buttonDodaj.Text = "Dodaj";
            buttonUsun.Enabled = false;
            modelMeldunki.IdMeldunku = 0;
            dateTimePickerDataOd.Value = DateTime.Now;
            dateTimePickerDataDo.Value = DateTime.Now;
        }

        void WyswietlanieZawartosciTabeliMeldunkiWszystkie()
        {
            dataGridViewMeldunki.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                dataGridViewMeldunki.DataSource = db.Meldunki.OrderByDescending(a => a.DataOd).ToList();
            }
        }
        void WyswietlanieZawartosciTabeliMeldunkiAktualne()
        {
            dataGridViewRezerwacje.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                dataGridViewMeldunki.AutoGenerateColumns = false;
                dataGridViewMeldunki.DataSource = db.Meldunki.Where(x => x.CzyAktywny == true).OrderBy(a => a.DataOd).ToList();
            }
        }

        private void dataGridViewMeldunki_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewMeldunki.CurrentRow.Index != -1)
            {
                modelMeldunki.IdMeldunku = Convert.ToInt32(dataGridViewMeldunki.CurrentRow.Cells["IdMeldunku"].Value);
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    modelMeldunki = db.Meldunki.Where(x => x.IdMeldunku == modelMeldunki.IdMeldunku).FirstOrDefault();
                    textBoxIdMeldunku.Text = modelMeldunki.IdMeldunku.ToString();
                    textBoxIdRezerwacji.Text = modelMeldunki.IdRezerwacji.ToString();
                    dateTimePickerDataOd.Text = modelMeldunki.DataOd.ToShortDateString();
                    dateTimePickerDataDo.Text = modelMeldunki.DataDo.ToShortDateString();
                    textBoxLiczbaOsob.Text = modelMeldunki.LiczbaOsob.ToString();
                    if (modelMeldunki.CzyAktywny == true)
                        checkBoxCzyAktywny.Checked = true;
                    else
                        checkBoxCzyAktywny.Checked = false;          
                    textBoxIdPracownika.Text = modelMeldunki.IdPracownika.ToString();
                }
                buttonDodaj.Text = "Aktualizuj";
                buttonUsun.Enabled = true;
            }
        }
        void WyswietlanieZawartosciTabeliRezerwacje()
        {
            dataGridViewRezerwacje.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                dataGridViewRezerwacje.DataSource = db.Rezerwacje.OrderByDescending(a => a.DataOd).ToList();
            }
        }
        private void dataGridViewRezerwacje_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewRezerwacje.CurrentRow.Index != -1)
            {
                modelRezerwacje.IdRezerwacji = Convert.ToInt32(dataGridViewRezerwacje.CurrentRow.Cells["RezerwacjeIdRezerwacji"].Value);
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    modelRezerwacje = db.Rezerwacje.Where(x => x.IdRezerwacji == modelRezerwacje.IdRezerwacji).FirstOrDefault();
                    textBoxIdRezerwacji.Text = modelRezerwacje.IdRezerwacji.ToString();
                    dateTimePickerDataOd.Text = modelRezerwacje.DataOd.ToShortDateString();
                    dateTimePickerDataDo.Text = modelRezerwacje.DataDo.ToShortDateString();
                    textBoxLiczbaOsob.Text = modelRezerwacje.LiczbaOsob.ToString();
                    checkBoxCzyAktywny.Checked = true;
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

        private void buttonSzukajRezerwacjiKlienta_Click(object sender, EventArgs e)
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                string nazwisko = textBoxNazwisko.Text.ToString();
                string nrtel = textBoxNrTel.Text.ToString();
                int query = 0;
                query = (from Klienci k in db.Klienci
                         where (k.Nazwisko == nazwisko && k.NrTel == nrtel) || k.NrTel == nrtel || k.Nazwisko == nazwisko
                         select k.IdKlienta).DefaultIfEmpty().First();
                if (query > 0)
                {
                    dataGridViewRezerwacje.DataSource = db.Rezerwacje.Where(x => x.IdKlienta == query).ToList();
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

        private void buttonWyswietlWszystkieMeldunki_Click(object sender, EventArgs e)
        {
            WyswietlanieZawartosciTabeliMeldunkiWszystkie();
        }

        private void buttonWyswietlAktualneMeldunki_Click(object sender, EventArgs e)
        {
            WyswietlanieZawartosciTabeliMeldunkiAktualne();
        }
    }
}
