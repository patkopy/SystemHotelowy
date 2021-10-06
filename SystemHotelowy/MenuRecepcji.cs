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
    public partial class MenuRecepcji : Form
    {
        public MenuRecepcji()
        {
            InitializeComponent();
        }
        public MenuRecepcji(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }
        private void buttonRezerwacje_Click(object sender, EventArgs e)
        {
            RezerwacjeForm NowaRezerwacje = new RezerwacjeForm(labelZalogowany.Text);
            NowaRezerwacje.Show();
        }

        private void buttonMeldunki_Click(object sender, EventArgs e)
        {
            MeldunkiForm NowaMeldunki = new MeldunkiForm(labelZalogowany.Text);
            NowaMeldunki.Show();
        }

        private void buttonKlienci_Click(object sender, EventArgs e)
        {
            KlienciForm NowaKlienci = new KlienciForm(labelZalogowany.Text);
            NowaKlienci.Show();
        }

        private void MenuRecepcji_Load(object sender, EventArgs e)
        {

        }

        private void buttonUslugi_Click(object sender, EventArgs e)
        {
            UslugiForm NowaUslugi = new UslugiForm(labelZalogowany.Text);
            NowaUslugi.Show();
        }

        private void buttonPokoje_Click(object sender, EventArgs e)
        {
            PokojeForm NowaPokoje = new PokojeForm(labelZalogowany.Text);
            NowaPokoje.Show();
        }

        private void buttonRachunkiZaPobyt_Click(object sender, EventArgs e)
        {
            RachunkiZaPobytForm NowaRachunkiZaPobyt = new RachunkiZaPobytForm(labelZalogowany.Text);
            NowaRachunkiZaPobyt.Show();
        }

        private void buttonRachunkiZaUslugi_Click(object sender, EventArgs e)
        {
            RachunkiZaUslugiForm NowaRachunkiZaUslugi = new RachunkiZaUslugiForm(labelZalogowany.Text);
            NowaRachunkiZaUslugi.Show();
        }
    }
}
