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
    public partial class SprzatanieForm : Form
    {
        Pokoje modelPokoje = new Pokoje();

        public SprzatanieForm()
        {
            InitializeComponent();
        }

        public SprzatanieForm(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }

        private void SprzatanieForm_Load(object sender, EventArgs e)
        {
            Wyczysc();
            WyswietlanieZawartosciTabeliPokoje();
        }

        private void buttonAktualizuj_Click(object sender, EventArgs e)
        {
            modelPokoje.CzyPosprzatany = Convert.ToBoolean(checkBoxCzyPosprzatany.Checked);
            if (textBoxNumer.Text != "")
            {
                using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
                {
                    db.Entry(modelPokoje).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                Wyczysc();
                WyswietlanieZawartosciTabeliPokoje();
                checkBoxCzyPosprzatany.Checked = false;
                MessageBox.Show("Zaktualizowano pomyślnie", "Komunikat");
            }
            else MessageBox.Show("Wypełnij wszystkie pola!", "Błąd");
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            Wyczysc();
            WyswietlanieZawartosciTabeliPokoje();
            checkBoxCzyPosprzatany.Checked = false;
        }

        void Wyczysc()
        {
            textBoxNumer.Text = "";
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
                    if ((dataGridViewPokoje.Rows[i].Cells["CzyWolny"].Value).ToString() == "True")
                        dataGridViewPokoje.Rows[i].Cells["CzyWolny"].Style.BackColor = Color.Green;
                    else
                        dataGridViewPokoje.Rows[i].Cells["CzyWolny"].Style.BackColor = Color.Red;
                }
                for (int j = 0; j < db.Pokoje.ToList().Count(); j++)
                {
                    if ((dataGridViewPokoje.Rows[j].Cells["CzyPosprzatany"].Value).ToString() == "True")
                        dataGridViewPokoje.Rows[j].Cells["CzyPosprzatany"].Style.BackColor = Color.Green;
                    else
                        dataGridViewPokoje.Rows[j].Cells["CzyPosprzatany"].Style.BackColor = Color.Red;
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
                    textBoxNumer.Text = modelPokoje.Numer.ToString();
                    if (modelPokoje.CzyPosprzatany == true)
                        checkBoxCzyPosprzatany.Checked = true;
                    else
                        checkBoxCzyPosprzatany.Checked = false;
                }
            }
        }
    }
}
