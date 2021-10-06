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
    public partial class PokojeForm : Form
    {
        Pokoje modelPokoje = new Pokoje();
        public PokojeForm()
        {
            InitializeComponent();
        }

        private void PokojeForm_Load(object sender, EventArgs e)
        {
            Wyczysc();
            textBoxIdPokoju.Enabled = false;
            WyswietlanieZawartosciTabeliPokoje();
        }

        public PokojeForm(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxNumer.Text != "" && textBoxLiczbaMiejsc.Text != "" && textBoxCena.Text != "")
            {
                modelPokoje.Numer = Convert.ToInt32(textBoxNumer.Text.Trim());
                modelPokoje.LiczbaMiejsc = Convert.ToInt32(textBoxLiczbaMiejsc.Text.Trim());
                modelPokoje.CenaZaDobe = Convert.ToDouble(textBoxCena.Text.Trim());
                modelPokoje.CzyWolny = Convert.ToBoolean(checkBoxCzyWolny.Checked);
                modelPokoje.CzyPosprzatany = Convert.ToBoolean(checkBoxCzyPosprzatany.Checked);

                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    if (modelPokoje.IdPokoju == 0)
                        db.Pokoje.Add(modelPokoje);
                    else
                        db.Entry(modelPokoje).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                Wyczysc();
                WyswietlanieZawartosciTabeliPokoje();
                checkBoxCzyWolny.Checked = false;
                checkBoxCzyPosprzatany.Checked = false;
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
            WyswietlanieZawartosciTabeliPokoje();
            checkBoxCzyWolny.Checked = false;
            checkBoxCzyPosprzatany.Checked = false;
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Na pewno usunąć ten pokój?", "Usuwanie pokoju", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    var entry = db.Entry(modelPokoje);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Pokoje.Attach(modelPokoje);
                    db.Pokoje.Remove(modelPokoje);
                    db.SaveChanges();
                    WyswietlanieZawartosciTabeliPokoje();
                    Wyczysc();
                    checkBoxCzyWolny.Checked = false;
                    checkBoxCzyPosprzatany.Checked = false;
                    MessageBox.Show("Usunięto pomyślnie", "Komunikat");
                }
            }
        }

        void Wyczysc()
        {
            textBoxIdPokoju.Text = textBoxNumer.Text = textBoxLiczbaMiejsc.Text = textBoxCena.Text = "";
            buttonDodaj.Text = "Dodaj";
            buttonUsun.Enabled = false;
            modelPokoje.IdPokoju = 0;
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
        private void dataGridViewPokoje_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewPokoje.CurrentRow.Index != -1)
            {
                modelPokoje.IdPokoju = Convert.ToInt32(dataGridViewPokoje.CurrentRow.Cells["IdPokoju"].Value);
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    modelPokoje = db.Pokoje.Where(x => x.IdPokoju == modelPokoje.IdPokoju).FirstOrDefault();
                    textBoxIdPokoju.Text = modelPokoje.IdPokoju.ToString();
                    textBoxNumer.Text = modelPokoje.Numer.ToString();
                    textBoxLiczbaMiejsc.Text = modelPokoje.LiczbaMiejsc.ToString();
                    textBoxCena.Text = modelPokoje.CenaZaDobe.ToString();

                    if (modelPokoje.CzyWolny == true)
                        checkBoxCzyWolny.Checked = true;
                    else
                        checkBoxCzyWolny.Checked = false;

                    if (modelPokoje.CzyPosprzatany == true)
                        checkBoxCzyPosprzatany.Checked = true;
                    else
                        checkBoxCzyPosprzatany.Checked = false;
                }
                buttonDodaj.Text = "Aktualizuj";
                buttonUsun.Enabled = true;
            }
        }

        private void buttonSzukajPokoju_Click(object sender, EventArgs e)
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                int liczbamiejsc = Convert.ToInt32(textBoxLiczbaMiejsc.Text);

                List<Pokoje> query = (from Pokoje p in db.Pokoje
                         where p.LiczbaMiejsc == liczbamiejsc
                         select p).DefaultIfEmpty().ToList();
                if (query != null)
                {
                    dataGridViewPokoje.DataSource = query;
                }
            }
        }

        private void buttonWyswietlWolnePokoje_Click(object sender, EventArgs e)
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                List<Pokoje> query = (from Pokoje p in db.Pokoje
                                      where p.CzyWolny == true
                                      select p).DefaultIfEmpty().ToList();
                if (query != null)
                {
                    dataGridViewPokoje.DataSource = query;
                }
            }
        }

        private void buttonWyswietlWszystkiePokoje_Click(object sender, EventArgs e)
        {
            WyswietlanieZawartosciTabeliPokoje();
        }
    }
}
