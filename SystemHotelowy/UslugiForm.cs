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
    public partial class UslugiForm : Form
    {
        Uslugi modelUslugi = new Uslugi();

        public UslugiForm()
        {
            InitializeComponent();
        }

        private void UslugiForm_Load(object sender, EventArgs e)
        {
            Wyczysc();
            WyswietlanieZawartosciTabeliUslugi();
            textBoxIdUslugi.Enabled = false;
        }

        public UslugiForm(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxNazwa.Text != "" && textBoxCena.Text != "")
            {
                modelUslugi.Nazwa = Convert.ToString(textBoxNazwa.Text.Trim());
                modelUslugi.Cena = Convert.ToDouble(textBoxCena.Text.Trim());

                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    if (modelUslugi.IdUslugi == 0)
                        db.Uslugi.Add(modelUslugi);
                    else
                        db.Entry(modelUslugi).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                Wyczysc();
                WyswietlanieZawartosciTabeliUslugi();
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
            WyswietlanieZawartosciTabeliUslugi();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Na pewno usunąć tę usługę?", "Usuwanie usługi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    var entry = db.Entry(modelUslugi);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Uslugi.Attach(modelUslugi);
                    db.Uslugi.Remove(modelUslugi);
                    db.SaveChanges();
                    WyswietlanieZawartosciTabeliUslugi();
                    Wyczysc();
                    MessageBox.Show("Usunięto pomyślnie", "Komunikat");
                }
            }
        }

        void Wyczysc()
        {
            textBoxIdUslugi.Text = textBoxNazwa.Text = textBoxCena.Text = "";
            buttonDodaj.Text = "Dodaj";
            buttonUsun.Enabled = false;
            modelUslugi.IdUslugi = 0;
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
                modelUslugi.IdUslugi = Convert.ToInt32(dataGridViewUslugi.CurrentRow.Cells["IdUslugi"].Value);
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    modelUslugi = db.Uslugi.Where(x => x.IdUslugi == modelUslugi.IdUslugi).FirstOrDefault();
                    textBoxIdUslugi.Text = modelUslugi.IdUslugi.ToString();
                    textBoxNazwa.Text = modelUslugi.Nazwa.ToString();
                    textBoxCena.Text = modelUslugi.Cena.ToString();
                }
                buttonDodaj.Text = "Aktualizuj";
                buttonUsun.Enabled = true;
            }
        }
    }
}
