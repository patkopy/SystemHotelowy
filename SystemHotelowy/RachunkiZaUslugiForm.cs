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
    public partial class RachunkiZaUslugiForm : Form
    {
        RachunkiZaUslugi modelRachunkiZaUslugi = new RachunkiZaUslugi();
        Uslugi modelUslugi = new Uslugi();
        public RachunkiZaUslugiForm()
        {
            InitializeComponent();
        }

        public RachunkiZaUslugiForm(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }
        private void RachunkiZaUslugiForm_Load(object sender, EventArgs e)
        {
            Wyczysc();
            WyswietlanieZawartosciTabeliRachunkiZaUslugi();
            textBoxIdRachunkuZaUsluge.Enabled = false;
            textBoxIdUslugi.Enabled = false;
            textBoxIdPracownika.Enabled = false;
            textBoxIdKlienta.Enabled = false;
            textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
            WyswietlanieZawartosciTabeliUslugi();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxIdKlienta.Text != "" && textBoxIdUslugi.Text != "" && textBoxKwota.Text != "" && textBoxIdPracownika.Text != "")
            {
                modelRachunkiZaUslugi.IdKlienta = Convert.ToInt32(textBoxIdKlienta.Text.Trim());
                modelRachunkiZaUslugi.IdUslugi = Convert.ToInt32(textBoxIdUslugi.Text.Trim());
                modelRachunkiZaUslugi.Kwota = Convert.ToDouble(textBoxKwota.Text.Trim());
                modelRachunkiZaUslugi.TerminZaplaty = Convert.ToDateTime(dateTimePickerTerminZaplaty.Text.Trim());
                modelRachunkiZaUslugi.CzyZaplacono = Convert.ToBoolean(checkBoxCzyZaplacono.Checked);
                modelRachunkiZaUslugi.IdPracownika = Convert.ToInt32(textBoxIdPracownika.Text.Trim());

                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    if (modelRachunkiZaUslugi.IdRachunkuZaUsluge == 0)
                        db.RachunkiZaUslugi.Add(modelRachunkiZaUslugi);
                    else
                        db.Entry(modelRachunkiZaUslugi).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                Wyczysc();
                WyswietlanieZawartosciTabeliRachunkiZaUslugi();
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
            WyswietlanieZawartosciTabeliRachunkiZaUslugi();
            textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
            checkBoxCzyZaplacono.Checked = false;
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Na pewno usunąć ten rachunek za usługę?", "Usuwanie rachunku za usługę", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    var entry = db.Entry(modelRachunkiZaUslugi);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.RachunkiZaUslugi.Attach(modelRachunkiZaUslugi);
                    db.RachunkiZaUslugi.Remove(modelRachunkiZaUslugi);
                    db.SaveChanges();
                    WyswietlanieZawartosciTabeliRachunkiZaUslugi();
                    Wyczysc();
                    textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
                    checkBoxCzyZaplacono.Checked = false;
                    MessageBox.Show("Usunięto pomyślnie", "Komunikat");
                }
            }
        }

        void Wyczysc()
        {
            textBoxIdRachunkuZaUsluge.Text = textBoxIdKlienta.Text = textBoxIdUslugi.Text = textBoxKwota.Text = textBoxIdPracownika.Text = textBoxNazwisko.Text = textBoxNrTel.Text = "";
            buttonDodaj.Text = "Dodaj";
            buttonUsun.Enabled = false;
            modelRachunkiZaUslugi.IdRachunkuZaUsluge = 0;
            dateTimePickerTerminZaplaty.Value = DateTime.Now;
            WyswietlanieZawartosciTabeliUslugi();
        }

        void WyswietlanieZawartosciTabeliRachunkiZaUslugi()
        {
            dataGridViewRachunkiZaUslugi.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                dataGridViewRachunkiZaUslugi.DataSource = db.RachunkiZaUslugi.OrderByDescending(a => a.TerminZaplaty).ToList();
            }
        }

        private void dataGridViewRachunkiZaUslugi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewRachunkiZaUslugi.CurrentRow.Index != -1)
            {
                modelRachunkiZaUslugi.IdRachunkuZaUsluge = Convert.ToInt32(dataGridViewRachunkiZaUslugi.CurrentRow.Cells["IdRachunkuZaUsluge"].Value);
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    modelRachunkiZaUslugi = db.RachunkiZaUslugi.Where(x => x.IdRachunkuZaUsluge == modelRachunkiZaUslugi.IdRachunkuZaUsluge).FirstOrDefault();
                    textBoxIdRachunkuZaUsluge.Text = modelRachunkiZaUslugi.IdRachunkuZaUsluge.ToString();
                    textBoxIdKlienta.Text = modelRachunkiZaUslugi.IdKlienta.ToString();
                    textBoxIdUslugi.Text = modelRachunkiZaUslugi.IdUslugi.ToString();
                    textBoxKwota.Text = modelRachunkiZaUslugi.Kwota.ToString();
                    dateTimePickerTerminZaplaty.Text = modelRachunkiZaUslugi.TerminZaplaty.ToShortDateString();
                    if (modelRachunkiZaUslugi.CzyZaplacono == true)
                        checkBoxCzyZaplacono.Checked = true;
                    else
                        checkBoxCzyZaplacono.Checked = false;
                    textBoxIdPracownika.Text = modelRachunkiZaUslugi.IdPracownika.ToString();
                }
                buttonDodaj.Text = "Aktualizuj";
                buttonUsun.Enabled = true;
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

        void WyswietlanieZawartosciTabeliUslugi()
        {
            dataGridViewUslugi.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                dataGridViewUslugi.DataSource = db.Uslugi.OrderBy(a => a.Nazwa).ToList();
            }
        }

        private void dataGridViewUslugi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewUslugi.CurrentRow.Index != -1)
            {
                modelUslugi.IdUslugi = Convert.ToInt32(dataGridViewUslugi.CurrentRow.Cells["UslugiIdUslugi"].Value);
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    modelUslugi = db.Uslugi.Where(x => x.IdUslugi == modelUslugi.IdUslugi).FirstOrDefault();
                    textBoxIdUslugi.Text = modelUslugi.IdUslugi.ToString();
                    textBoxKwota.Text = modelUslugi.Cena.ToString();
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
    }
}
