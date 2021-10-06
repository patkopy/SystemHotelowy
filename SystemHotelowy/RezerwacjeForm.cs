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
    public partial class RezerwacjeForm : Form
    {
        Rezerwacje model = new Rezerwacje();
        Pokoje modelPokoje = new Pokoje();

        public RezerwacjeForm()
        {
            InitializeComponent();
        }

        public RezerwacjeForm(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }

        private void RezerwacjeForm_Load(object sender, EventArgs e)
        {
            Wyczysc();
            WyswietlanieZawartosciTabeliRezerwacjeWszystkie();
            textBoxIdRezerwacji.Enabled = false;
            textBoxIdPracownika.Enabled = false;
            textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
            WyswietlanieZawartosciTabeliPokoje();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxIdKlienta.Text != "" && textBoxIdPokoju.Text != "" && textBoxIloscOsob.Text != "" && textBoxIdPracownika.Text != "")
            {
                model.IdKlienta = Convert.ToInt32(textBoxIdKlienta.Text.Trim());
                model.IdPokoju = Convert.ToInt32(textBoxIdPokoju.Text.Trim());
                model.DataOd = Convert.ToDateTime(dateTimePickerDataOd.Text.Trim());
                model.DataDo = Convert.ToDateTime(dateTimePickerDataDo.Text.Trim());
                model.LiczbaOsob = Convert.ToInt32(textBoxIloscOsob.Text.Trim());
                model.CzyAktywna = Convert.ToBoolean(checkBoxCzyAktywna.Checked);
                model.IdPracownika = Convert.ToInt32(textBoxIdPracownika.Text.Trim());

                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    if (model.IdRezerwacji == 0)
                        db.Rezerwacje.Add(model);
                    else
                        db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                Wyczysc();
                WyswietlanieZawartosciTabeliRezerwacjeWszystkie();
                checkBoxCzyAktywna.Checked = false;
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
            WyswietlanieZawartosciTabeliRezerwacjeWszystkie();
            textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
            checkBoxCzyAktywna.Checked = false;
            WyswietlanieZawartosciTabeliPokoje();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Na pewno usunąć tę rezerwację?", "Usuwanie rezerwacji", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using(INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Rezerwacje.Attach(model);
                    db.Rezerwacje.Remove(model);
                    db.SaveChanges();
                    WyswietlanieZawartosciTabeliRezerwacjeWszystkie();
                    Wyczysc();
                    textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
                    checkBoxCzyAktywna.Checked = false;
                    MessageBox.Show("Usunięto pomyślnie", "Komunikat");
                }
            }
        }

        void Wyczysc()
        {
            textBoxIdRezerwacji.Text = textBoxIdKlienta.Text = textBoxIdPokoju.Text = textBoxIloscOsob.Text = textBoxIdPracownika.Text = textBoxNazwisko.Text = textBoxNrTel.Text = "";
            buttonDodaj.Text = "Dodaj";
            buttonUsun.Enabled = false;
            model.IdRezerwacji = 0;
            dateTimePickerDataOd.Value = DateTime.Now;
            dateTimePickerDataDo.Value = DateTime.Now;
        }

        void WyswietlanieZawartosciTabeliRezerwacjeAktualne()
        {
            dataGridViewRezerwacje.AutoGenerateColumns = false;
            using(INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                dataGridViewRezerwacje.DataSource = db.Rezerwacje.Where(x => x.CzyAktywna == true).OrderByDescending(a => a.DataOd).ToList();
            }
        }

        void WyswietlanieZawartosciTabeliRezerwacjeWszystkie()
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
                model.IdRezerwacji = Convert.ToInt32(dataGridViewRezerwacje.CurrentRow.Cells["IdRezerwacji"].Value);
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    model = db.Rezerwacje.Where(x => x.IdRezerwacji == model.IdRezerwacji).FirstOrDefault();
                    textBoxIdRezerwacji.Text = model.IdRezerwacji.ToString();
                    textBoxIdKlienta.Text = model.IdKlienta.ToString();
                    textBoxIdPokoju.Text = model.IdPokoju.ToString();
                    dateTimePickerDataOd.Text = model.DataOd.ToShortDateString();
                    dateTimePickerDataDo.Text = model.DataDo.ToShortDateString();
                    textBoxIloscOsob.Text = model.LiczbaOsob.ToString();
                    if (model.CzyAktywna == true)
                        checkBoxCzyAktywna.Checked = true;
                    else
                        checkBoxCzyAktywna.Checked = false;
                    textBoxIdPracownika.Text = model.IdPracownika.ToString();
                }
                buttonDodaj.Text = "Aktualizuj";
                buttonUsun.Enabled = true;
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

        void WyswietlanieZawartosciTabeliPokoje()
        {
            dataGridViewPokoje.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                dataGridViewPokoje.DataSource = db.Pokoje.ToList();
                for (int i = 0; i < db.Pokoje.ToList().Count(); i++)
                {
                    dataGridViewPokoje.Rows[i].Cells["CzyWolny"].Style.ForeColor = Color.White;
                    if ((dataGridViewPokoje.Rows[i].Cells["CzyWolny"].Value).ToString() == "True")
                        dataGridViewPokoje.Rows[i].Cells["CzyWolny"].Style.BackColor = Color.FromArgb(2, 138, 15);
                    else
                        dataGridViewPokoje.Rows[i].Cells["CzyWolny"].Style.BackColor = Color.FromArgb(191, 31, 47);
                }
                for (int j = 0; j < db.Pokoje.ToList().Count(); j++)
                {
                    dataGridViewPokoje.Rows[j].Cells["CzyPosprzatany"].Style.ForeColor = Color.White;
                    if ((dataGridViewPokoje.Rows[j].Cells["CzyPosprzatany"].Value).ToString() == "True")
                        dataGridViewPokoje.Rows[j].Cells["CzyPosprzatany"].Style.BackColor = Color.FromArgb(2, 138, 15);
                    else
                        dataGridViewPokoje.Rows[j].Cells["CzyPosprzatany"].Style.BackColor = Color.FromArgb(191, 31, 47);
                }
            }
        }

        void WyswietlanieZawartosciTabeliPokojePoDatach()
        {
            dataGridViewPokoje.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                if (dateTimePickerDataOd.Text != "" && dateTimePickerDataDo.Text != "" && textBoxIloscOsob.Text != "")
                {
                    var datastart = Convert.ToDateTime(dateTimePickerDataOd.Text);
                    var datakoniec = Convert.ToDateTime(dateTimePickerDataDo.Text);
                    var liczbaosob = Convert.ToInt32(textBoxIloscOsob.Text);
                    var query = from Pokoje p in db.Pokoje
                                join Rezerwacje r in db.Rezerwacje on p.IdPokoju equals r.IdPokoju into ps
                                from Pokoje in ps.DefaultIfEmpty()
                                where p.LiczbaMiejsc >= liczbaosob && p.CzyWolny == true
                                select new { p.IdPokoju, p.CenaZaDobe, p.CzyPosprzatany, p.CzyWolny, p.LiczbaMiejsc, p.Numer };
                    var exceptquery = from Pokoje p in db.Pokoje
                                      join Rezerwacje r in db.Rezerwacje on p.IdPokoju equals r.IdPokoju
                                      where !(r.DataDo <= datastart || r.DataOd >= datakoniec)
                                      select new { p.IdPokoju, p.CenaZaDobe, p.CzyPosprzatany, p.CzyWolny, p.LiczbaMiejsc, p.Numer };
                    var results = query.Except(exceptquery).OrderBy(x => x.LiczbaMiejsc).ToList();
                    dataGridViewPokoje.DataSource = results;
                }
            }
        }
        private void dataGridViewPokoje_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewPokoje.CurrentRow.Index != -1)
            {
                modelPokoje.IdPokoju = Convert.ToInt32(dataGridViewPokoje.CurrentRow.Cells["PokojeIdPokoju"].Value);
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    modelPokoje = db.Pokoje.Where(x => x.IdPokoju == modelPokoje.IdPokoju).FirstOrDefault();
                    textBoxIdPokoju.Text = modelPokoje.IdPokoju.ToString();
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

        private void buttonSprawdzPokoje_Click(object sender, EventArgs e)
        {
            WyswietlanieZawartosciTabeliPokojePoDatach();
        }

        private void buttonWyswietlWszystkieRezerwacje_Click(object sender, EventArgs e)
        {
            WyswietlanieZawartosciTabeliRezerwacjeWszystkie();
        }

        private void buttonWyswietlAktualneRezerwacje_Click(object sender, EventArgs e)
        {
            WyswietlanieZawartosciTabeliRezerwacjeAktualne();
        }
    }
}
