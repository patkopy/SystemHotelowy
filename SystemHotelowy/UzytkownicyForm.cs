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
    public partial class UzytkownicyForm : Form
    {
        Uzytkownicy modelUzytkownicy = new Uzytkownicy();

        public UzytkownicyForm()
        {
            InitializeComponent();
        }

        private void UzytkownicyForm_Load(object sender, EventArgs e)
        {
            Wyczysc();
            WyswietlanieZawartosciTabeliUzytkownicy();
            textBoxIdUzytkownika.Enabled = false;
        }

        public UzytkownicyForm(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxIdPracownika.Text != "" && textBoxLogin.Text != "" && textBoxHaslo.Text != "")
            {
                modelUzytkownicy.IdPracownika = Convert.ToInt32(textBoxIdPracownika.Text.Trim());
                modelUzytkownicy.Login = Convert.ToString(textBoxLogin.Text.Trim());
                modelUzytkownicy.Haslo = Convert.ToString(textBoxHaslo.Text.Trim());

                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    if (modelUzytkownicy.IdUzytkownika == 0)
                        db.Uzytkownicy.Add(modelUzytkownicy);
                    else
                        db.Entry(modelUzytkownicy).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                Wyczysc();
                WyswietlanieZawartosciTabeliUzytkownicy();
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
            WyswietlanieZawartosciTabeliUzytkownicy();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Na pewno usunąć tego użytkownika?", "Usuwanie użytkownika", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    var entry = db.Entry(modelUzytkownicy);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Uzytkownicy.Attach(modelUzytkownicy);
                    db.Uzytkownicy.Remove(modelUzytkownicy);
                    db.SaveChanges();
                    WyswietlanieZawartosciTabeliUzytkownicy();
                    Wyczysc();
                    MessageBox.Show("Usunięto pomyślnie", "Komunikat");
                }
            }
        }

        void Wyczysc()
        {
            textBoxIdUzytkownika.Text = textBoxIdPracownika.Text = textBoxLogin.Text = textBoxHaslo.Text = textBoxNrTel.Text = textBoxNazwisko.Text = "";
            buttonDodaj.Text = "Dodaj";
            buttonUsun.Enabled = false;
            modelUzytkownicy.IdUzytkownika = 0;
        }

        private void dataGridViewUzytkownicy_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewUzytkownicy.Columns[e.ColumnIndex].Name == "Haslo" && e.Value != null)
            {
                dataGridViewUzytkownicy.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        void WyswietlanieZawartosciTabeliUzytkownicy()
        {
            dataGridViewUzytkownicy.AutoGenerateColumns = false;
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                dataGridViewUzytkownicy.DataSource = db.Uzytkownicy.ToList();
            }
        }

        private void dataGridViewKlienci_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewUzytkownicy.CurrentRow.Index != -1)
            {
                modelUzytkownicy.IdUzytkownika = Convert.ToInt32(dataGridViewUzytkownicy.CurrentRow.Cells["IdUzytkownika"].Value);
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    modelUzytkownicy = db.Uzytkownicy.Where(x => x.IdUzytkownika == modelUzytkownicy.IdUzytkownika).FirstOrDefault();
                    textBoxIdUzytkownika.Text = modelUzytkownicy.IdUzytkownika.ToString();
                    textBoxIdPracownika.Text = modelUzytkownicy.IdPracownika.ToString();
                    textBoxLogin.Text = modelUzytkownicy.Login.ToString();
                    textBoxHaslo.Text = modelUzytkownicy.Haslo.ToString();
                }
                buttonDodaj.Text = "Aktualizuj";
                buttonUsun.Enabled = true;
            }
        }

        public int SzukajIdPracownika()
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                string nazwisko = textBoxNazwisko.Text.ToString();
                string nrtel = textBoxNrTel.Text.ToString();
                int query = 0;
                query = (from Pracownicy p in db.Pracownicy
                         where p.Nazwisko == nazwisko && p.NrTel == nrtel
                         select p.IdPracownika).DefaultIfEmpty().First();
                return query;
            }
        }

        private void buttonSzukajPracownika_Click(object sender, EventArgs e)
        {
            if (SzukajIdPracownika() > 0)
            {
                textBoxIdPracownika.Text = SzukajIdPracownika().ToString();
            }
            else
            {
                if (MessageBox.Show("Czy chcesz dodać nowego pracownika?", "Brak pracownika", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new PracownicyForm(labelZalogowany.Text).Show();
                }
            }
        }
    }
}
