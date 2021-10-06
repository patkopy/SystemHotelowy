using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHotelowy
{
    public partial class RachunkiZaPobytForm : Form
    {
        RachunkiZaPobyt modelRachunkiZaPobyt = new RachunkiZaPobyt();
        Meldunki modelMeldunki = new Meldunki();

        public RachunkiZaPobytForm()
        {
            InitializeComponent();
        }

        public RachunkiZaPobytForm(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }

        private void RachunkiZaPobytForm_Load(object sender, EventArgs e)
        {
            Wyczysc();
            WyswietlanieZawartosciTabeliRachunkiZaPobyt();
            textBoxIdRachunkuZaPobyt.Enabled = false;
            textBoxIdMeldunku.Enabled = false;
            textBoxIdPracownika.Enabled = false;
            textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
            WyswietlanieZawartosciTabeliMeldunki();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxIdMeldunku.Text != "" && textBoxKwota.Text != "" && textBoxIdPracownika.Text != "")
            {
                modelRachunkiZaPobyt.IdMeldunku = Convert.ToInt32(textBoxIdMeldunku.Text.Trim());
                modelRachunkiZaPobyt.Kwota = Convert.ToDouble(textBoxKwota.Text.Trim());
                modelRachunkiZaPobyt.TerminZaplaty = Convert.ToDateTime(dateTimePickerTerminZaplaty.Text.Trim());
                modelRachunkiZaPobyt.CzyZaplacono = Convert.ToBoolean(checkBoxCzyZaplacono.Checked);
                modelRachunkiZaPobyt.IdPracownika = Convert.ToInt32(textBoxIdPracownika.Text.Trim());

                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    if (modelRachunkiZaPobyt.IdRachunkuZaPobyt == 0)
                        db.RachunkiZaPobyt.Add(modelRachunkiZaPobyt);
                    else
                        db.Entry(modelRachunkiZaPobyt).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                Wyczysc();
                WyswietlanieZawartosciTabeliRachunkiZaPobyt();
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
            WyswietlanieZawartosciTabeliRachunkiZaPobyt();
            textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
            checkBoxCzyZaplacono.Checked = false;
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Na pewno usunąć ten rachunek za pobyt?", "Usuwanie rachunku za pobyt", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    var entry = db.Entry(modelRachunkiZaPobyt);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.RachunkiZaPobyt.Attach(modelRachunkiZaPobyt);
                    db.RachunkiZaPobyt.Remove(modelRachunkiZaPobyt);
                    db.SaveChanges();
                    WyswietlanieZawartosciTabeliRachunkiZaPobyt();
                    Wyczysc();
                    textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
                    checkBoxCzyZaplacono.Checked = false;
                    MessageBox.Show("Usunięto pomyślnie", "Komunikat");
                }
            }
        }

        void Wyczysc()
        {
            textBoxIdRachunkuZaPobyt.Text = textBoxIdMeldunku.Text = textBoxKwota.Text = textBoxIdPracownika.Text = textBoxNazwisko.Text = textBoxNrTel.Text = "";
            buttonDodaj.Text = "Dodaj";
            buttonUsun.Enabled = false;
            modelRachunkiZaPobyt.IdRachunkuZaPobyt = 0;
            dateTimePickerTerminZaplaty.Value = DateTime.Now;
            WyswietlanieZawartosciTabeliMeldunki();
        }

        void WyswietlanieZawartosciTabeliRachunkiZaPobyt()
        {
            dataGridViewRachunkiZaPobyt.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                dataGridViewRachunkiZaPobyt.DataSource = db.RachunkiZaPobyt.OrderByDescending(a => a.TerminZaplaty).ToList();
            }
        }

        private void dataGridViewRachunkiZaPobyt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewRachunkiZaPobyt.CurrentRow.Index != -1)
            {
                modelRachunkiZaPobyt.IdRachunkuZaPobyt = Convert.ToInt32(dataGridViewRachunkiZaPobyt.CurrentRow.Cells["IdRachunkuZaPobyt"].Value);
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    modelRachunkiZaPobyt = db.RachunkiZaPobyt.Where(x => x.IdRachunkuZaPobyt == modelRachunkiZaPobyt.IdRachunkuZaPobyt).FirstOrDefault();
                    textBoxIdRachunkuZaPobyt.Text = modelRachunkiZaPobyt.IdRachunkuZaPobyt.ToString();
                    textBoxIdMeldunku.Text = modelRachunkiZaPobyt.IdMeldunku.ToString();
                    textBoxKwota.Text = modelRachunkiZaPobyt.Kwota.ToString();
                    dateTimePickerTerminZaplaty.Text = modelRachunkiZaPobyt.TerminZaplaty.ToShortDateString();
                    if (modelRachunkiZaPobyt.CzyZaplacono == true)
                        checkBoxCzyZaplacono.Checked = true;
                    else
                        checkBoxCzyZaplacono.Checked = false;
                    textBoxIdPracownika.Text = modelRachunkiZaPobyt.IdPracownika.ToString();
                }
                buttonDodaj.Text = "Aktualizuj";
                buttonUsun.Enabled = true;
            }
        }

        private void buttonSzukajMeldunkuKlienta_Click(object sender, EventArgs e)
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                string nazwisko = textBoxNazwisko.Text.ToString();
                string nrtel = textBoxNrTel.Text.ToString();
                List<Meldunki> query = (from Meldunki m in db.Meldunki
                             join Rezerwacje r in db.Rezerwacje on m.IdRezerwacji equals r.IdRezerwacji
                             join Klienci k in db.Klienci on r.IdKlienta equals k.IdKlienta
                             where (k.Nazwisko == nazwisko && k.NrTel == nrtel) || k.Nazwisko == nazwisko || k.NrTel == nrtel
                             select m).DefaultIfEmpty().ToList();

                if (query != null)
                {
                    dataGridViewMeldunki.DataSource = query;
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

        void WyswietlanieZawartosciTabeliMeldunki()
        {
            dataGridViewMeldunki.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                dataGridViewMeldunki.DataSource = db.Meldunki.OrderByDescending(a => a.DataOd).ToList();
            }
        }

        private void dataGridViewMeldunki_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewMeldunki.CurrentRow.Index != -1)
            {
                modelMeldunki.IdMeldunku = Convert.ToInt32(dataGridViewMeldunki.CurrentRow.Cells["MeldunkiIdMeldunku"].Value);
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    modelMeldunki = db.Meldunki.Where(x => x.IdMeldunku == modelMeldunki.IdMeldunku).FirstOrDefault();
                    textBoxIdMeldunku.Text = modelMeldunki.IdMeldunku.ToString();
                    textBoxKwota.Text = LiczNaleznoscZaPokoj().ToString();
                }
            }
        }

        public int ZnajdzPokoj()
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                int meldunek = Convert.ToInt32(textBoxIdMeldunku.Text);
                int query = (from Meldunki m in db.Meldunki
                             join Rezerwacje r in db.Rezerwacje on m.IdRezerwacji equals r.IdRezerwacji
                             where m.IdMeldunku == meldunek
                            select r.IdPokoju).First();
                return query;
            }
        }
        public double LiczCeneZaPokoj()
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                int pokoj = ZnajdzPokoj();
                double query = (from Pokoje p in db.Pokoje
                             where p.IdPokoju == pokoj
                             select p.CenaZaDobe/p.LiczbaMiejsc).First();
                return query;
            }
        }
        public double LiczNaleznoscZaPokoj()
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                double cenazapokoj = LiczCeneZaPokoj();
                int meldunek = Convert.ToInt32((textBoxIdMeldunku.Text));
                double query = (from Meldunki m in db.Meldunki
                                where m.IdMeldunku == meldunek
                                select m.LiczbaDob*m.LiczbaOsob*cenazapokoj).First();
                return query;
            }
        }
    }
}
