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
    public partial class MenuGastronomia : Form
    {
        public MenuGastronomia()
        {
            InitializeComponent();
        }
        public MenuGastronomia(string zalogowany)
        {
            InitializeComponent();
            labelZalogowany.Text = zalogowany;
        }
        private void MenuGastronomia_Load(object sender, EventArgs e)
        {

        }
        private void buttonDania_Click(object sender, EventArgs e)
        {
            DaniaForm NowaDania = new DaniaForm(labelZalogowany.Text);
            NowaDania.Show();
        }

        private void buttonRachunkiZaDania_Click(object sender, EventArgs e)
        {
            RachunkiZaDaniaForm NowaRachunkiZaDania = new RachunkiZaDaniaForm(labelZalogowany.Text);
            NowaRachunkiZaDania.Show();
        }
    }
}
