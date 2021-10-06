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
    public partial class MenuStatystyki : Form
    {
        public MenuStatystyki()
        {
            InitializeComponent();
        }
        public MenuStatystyki(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }

        private void MenuStatystyki_Load(object sender, EventArgs e)
        {

        }
        private void buttonOblozenieObiektu_Click(object sender, EventArgs e)
        {
            OblozenieObiektuForm nowaOblozenieObiektu = new OblozenieObiektuForm(labelZalogowany.Text);
            nowaOblozenieObiektu.Show();
        }

        private void buttonPrzychodyZaPobyt_Click(object sender, EventArgs e)
        {
            PrzychodyZaPobytForm nowaPrzychodyZaPobyt = new PrzychodyZaPobytForm(labelZalogowany.Text);
            nowaPrzychodyZaPobyt.Show();
        }

        private void buttonPrzychodyZaUslugi_Click(object sender, EventArgs e)
        {
            PrzychodyZaUslugiForm nowaPrzychodyZaUslugi = new PrzychodyZaUslugiForm(labelZalogowany.Text);
            nowaPrzychodyZaUslugi.Show();
        }

        private void buttonPrzychodyZaDania_Click(object sender, EventArgs e)
        {
            PrzychodyZaDaniaForm nowaPrzychodyZaDania = new PrzychodyZaDaniaForm(labelZalogowany.Text);
            nowaPrzychodyZaDania.Show();
        }

        private void buttonPrzychodyCalosciowe_Click(object sender, EventArgs e)
        {
            PrzychodyZaWszystkoForm nowaPrzychodyZaWszystko = new PrzychodyZaWszystkoForm(labelZalogowany.Text);
            nowaPrzychodyZaWszystko.Show();
        }
    }
}
