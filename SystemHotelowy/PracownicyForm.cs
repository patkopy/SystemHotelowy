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
    public partial class PracownicyForm : Form
    {
        Pracownicy modelPracownicy = new Pracownicy();
        public PracownicyForm()
        {
            InitializeComponent();
        }
        public PracownicyForm(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }
        private void PracownicyForm_Load(object sender, EventArgs e)
        {
            Wyczysc();
            WyswietlanieZawartosciTabeliPracownicy();
            textBoxIdPracownika.Enabled = false;
        }
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxImie.Text != "" && textBoxNazwisko.Text != "" && textBoxPesel.Text != "" && textBoxMiasto.Text != "" && textBoxAdres.Text != "" && textBoxNrTel.Text != "" && textBoxEmail.Text != "" && textBoxPensja.Text != "" && textBoxStanowisko.Text != "")
            {
                modelPracownicy.Imie = Convert.ToString(textBoxImie.Text.Trim());
                modelPracownicy.Nazwisko = Convert.ToString(textBoxNazwisko.Text.Trim());
                modelPracownicy.Pesel = Convert.ToString(textBoxPesel.Text.Trim());
                modelPracownicy.Miasto = Convert.ToString(textBoxMiasto.Text.Trim());
                modelPracownicy.Adres = Convert.ToString(textBoxAdres.Text.Trim());
                modelPracownicy.NrTel = Convert.ToString(textBoxNrTel.Text.Trim());
                modelPracownicy.Email = Convert.ToString(textBoxEmail.Text.Trim());
                modelPracownicy.DataZatrudnienia = Convert.ToDateTime(dateTimePickerDataZatrudnienia.Text.Trim());
                modelPracownicy.Pensja = Convert.ToDouble(textBoxPensja.Text.Trim());
                modelPracownicy.Stanowisko = Convert.ToString(textBoxStanowisko.Text.Trim());

                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    if (modelPracownicy.IdPracownika == 0)
                        db.Pracownicy.Add(modelPracownicy);
                    else
                        db.Entry(modelPracownicy).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                Wyczysc();
                WyswietlanieZawartosciTabeliPracownicy();
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
            WyswietlanieZawartosciTabeliPracownicy();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Na pewno usunąć tego pracownika?", "Usuwanie pracownika", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    var entry = db.Entry(modelPracownicy);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Pracownicy.Attach(modelPracownicy);
                    db.Pracownicy.Remove(modelPracownicy);
                    db.SaveChanges();
                    WyswietlanieZawartosciTabeliPracownicy();
                    Wyczysc();
                    MessageBox.Show("Usunięto pomyślnie", "Komunikat");
                }
            }
        }

        void Wyczysc()
        {
            textBoxIdPracownika.Text = textBoxImie.Text = textBoxNazwisko.Text = textBoxPesel.Text = textBoxMiasto.Text = textBoxAdres.Text = textBoxNrTel.Text = textBoxEmail.Text = textBoxPensja.Text = textBoxStanowisko.Text = "";
            buttonDodaj.Text = "Dodaj";
            buttonUsun.Enabled = false;
            modelPracownicy.IdPracownika = 0;
            dateTimePickerDataZatrudnienia.Value = DateTime.Now;
        }

        void WyswietlanieZawartosciTabeliPracownicy()
        {
            dataGridViewPracownicy.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                dataGridViewPracownicy.DataSource = db.Pracownicy.ToList();
            }
        }

        private void dataGridViewPracownicy_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewPracownicy.CurrentRow.Index != -1)
            {
                modelPracownicy.IdPracownika = Convert.ToInt32(dataGridViewPracownicy.CurrentRow.Cells["IdPracownika"].Value);
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    modelPracownicy = db.Pracownicy.Where(x => x.IdPracownika == modelPracownicy.IdPracownika).FirstOrDefault();
                    textBoxIdPracownika.Text = modelPracownicy.IdPracownika.ToString();
                    textBoxImie.Text = modelPracownicy.Imie.ToString();
                    textBoxNazwisko.Text = modelPracownicy.Nazwisko.ToString();
                    textBoxPesel.Text = modelPracownicy.Pesel.ToString();
                    textBoxMiasto.Text = modelPracownicy.Miasto.ToString();
                    textBoxAdres.Text = modelPracownicy.Adres.ToString();
                    textBoxNrTel.Text = modelPracownicy.NrTel.ToString();
                    textBoxEmail.Text = modelPracownicy.Email.ToString();
                    dateTimePickerDataZatrudnienia.Text = modelPracownicy.DataZatrudnienia.ToShortDateString();
                    textBoxPensja.Text = modelPracownicy.Pensja.ToString();
                    textBoxStanowisko.Text = modelPracownicy.Stanowisko.ToString();
                }
                buttonDodaj.Text = "Aktualizuj";
                buttonUsun.Enabled = true;
            }
        }

        private void buttonSzukajPracownika_Click(object sender, EventArgs e)
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                string imie = textBoxImie.Text.ToString();
                string nazwisko = textBoxNazwisko.Text.ToString();
                string pesel = textBoxPesel.Text.ToString();
                string miasto = textBoxMiasto.Text.ToString();
                string adres = textBoxAdres.Text.ToString();
                string nrtel = textBoxNrTel.Text.ToString();
                string email = textBoxEmail.Text.ToString();
                DateTime data = (Convert.ToDateTime(dateTimePickerDataZatrudnienia.Text)).Date;
                double pensja;
                if(textBoxPensja.Text == "")
                {
                    pensja = 0;
                }
                else
                    pensja = Convert.ToDouble(textBoxPensja.Text);

                string stanowisko = textBoxStanowisko.Text.ToString();

                List<Pracownicy> query = (from Pracownicy p in db.Pracownicy
                         where p.Pesel == pesel || p.NrTel == nrtel || p.Email == email || p.Nazwisko == nazwisko || p.Stanowisko == stanowisko || p.Adres == adres || p.Miasto == miasto || p.Imie == imie || p.DataZatrudnienia == data || p.Pensja == pensja
                         select p).ToList();
                if (query.Count > 0)
                {
                    dataGridViewPracownicy.DataSource = query;
                }
                else
                {
                    MessageBox.Show("Dodaj nowego pracownika", "Brak pracownika", MessageBoxButtons.OK);
                }
            }
        }
    }
}
