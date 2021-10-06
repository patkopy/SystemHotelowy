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
    public partial class KlienciForm : Form
    {
        Klienci modelKlienci = new Klienci();
        public KlienciForm()
        {
            InitializeComponent();
        }

        private void KlienciForm_Load(object sender, EventArgs e)
        {
            Wyczysc();
            WyswietlanieZawartosciTabeliKlienci();
            textBoxIdKlienta.Enabled = false;
        }

        public KlienciForm(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxImie.Text != "" && textBoxNazwisko.Text != "" && textBoxPesel.Text != "" && textBoxMiasto.Text != "" && textBoxAdres.Text != "" && textBoxNrTel.Text != "" && textBoxEmail.Text != "")
            {
                modelKlienci.Imie = Convert.ToString(textBoxImie.Text.Trim());
                modelKlienci.Nazwisko = Convert.ToString(textBoxNazwisko.Text.Trim());
                modelKlienci.Pesel = Convert.ToString(textBoxPesel.Text.Trim());
                modelKlienci.Miasto = Convert.ToString(textBoxMiasto.Text.Trim());
                modelKlienci.Adres = Convert.ToString(textBoxAdres.Text.Trim());
                modelKlienci.NrTel = Convert.ToString(textBoxNrTel.Text.Trim());
                modelKlienci.Email = Convert.ToString(textBoxEmail.Text.Trim());

                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    if (modelKlienci.IdKlienta == 0)
                        db.Klienci.Add(modelKlienci);
                    else
                        db.Entry(modelKlienci).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                Wyczysc();
                WyswietlanieZawartosciTabeliKlienci();
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
            WyswietlanieZawartosciTabeliKlienci();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Na pewno usunąć tego klienta?", "Usuwanie klienta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    var entry = db.Entry(modelKlienci);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Klienci.Attach(modelKlienci);
                    db.Klienci.Remove(modelKlienci);
                    db.SaveChanges();
                    WyswietlanieZawartosciTabeliKlienci();
                    Wyczysc();
                    MessageBox.Show("Usunięto pomyślnie","Komunikat");
                }
            }
        }

        void Wyczysc()
        {
            textBoxIdKlienta.Text = textBoxImie.Text = textBoxNazwisko.Text = textBoxPesel.Text = textBoxMiasto.Text = textBoxAdres.Text = textBoxNrTel.Text = textBoxEmail.Text = "";
            buttonDodaj.Text = "Dodaj";
            buttonUsun.Enabled = false;
        }

        void WyswietlanieZawartosciTabeliKlienci()
        {
            dataGridViewKlienci.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                dataGridViewKlienci.DataSource = db.Klienci.ToList();
            }
        }

        private void dataGridViewKlienci_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewKlienci.CurrentRow.Index != -1)
            {
                modelKlienci.IdKlienta = Convert.ToInt32(dataGridViewKlienci.CurrentRow.Cells["IdKlienta"].Value);
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    modelKlienci = db.Klienci.Where(x => x.IdKlienta == modelKlienci.IdKlienta).FirstOrDefault();
                    textBoxIdKlienta.Text = modelKlienci.IdKlienta.ToString();
                    textBoxImie.Text = modelKlienci.Imie.ToString();
                    textBoxNazwisko.Text = modelKlienci.Nazwisko.ToString();
                    textBoxPesel.Text = modelKlienci.Pesel.ToString();
                    textBoxMiasto.Text = modelKlienci.Miasto.ToString();
                    textBoxAdres.Text = modelKlienci.Adres.ToString();
                    textBoxNrTel.Text = modelKlienci.NrTel.ToString();
                    textBoxEmail.Text = modelKlienci.Email.ToString();
                }
                buttonDodaj.Text = "Aktualizuj";
                buttonUsun.Enabled = true;
            }
        }

        private void buttonSzukajKlienta_Click(object sender, EventArgs e)
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
                
                List<Klienci> query = (from Klienci k in db.Klienci
                         where k.Pesel == pesel || k.NrTel == nrtel || k.Email == email || k.Nazwisko == nazwisko || k.Adres == adres || k.Miasto == miasto || k.Imie == imie
                         select k).OrderBy(a => a.Nazwisko).ToList();
                if (query.Count > 0)
                {
                    dataGridViewKlienci.DataSource = query;
                }
                else
                {
                    MessageBox.Show("Dodaj nowego klienta", "Brak klienta", MessageBoxButtons.OK);
                }
            }
        }
    }
}
