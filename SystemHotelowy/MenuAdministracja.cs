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
    public partial class MenuAdministracja : Form
    {
        public MenuAdministracja()
        {
            InitializeComponent();
        }
        public MenuAdministracja(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }
        private void MenuAdministracja_Load(object sender, EventArgs e)
        {

        }

        private void buttonUzytkownicy_Click(object sender, EventArgs e)
        {
            UzytkownicyForm nowaUzytkownicy = new UzytkownicyForm(labelZalogowany.Text);
            nowaUzytkownicy.Show();
        }

        private void buttonPracownicy_Click(object sender, EventArgs e)
        {
            PracownicyForm nowaPracownicy = new PracownicyForm(labelZalogowany.Text);
            nowaPracownicy.Show();
        }

        private void buttonStatystyki_Click(object sender, EventArgs e)
        {
            MenuStatystyki nowaMenuStatystyki = new MenuStatystyki(labelZalogowany.Text);
            nowaMenuStatystyki.Show();
        }
    }
}
