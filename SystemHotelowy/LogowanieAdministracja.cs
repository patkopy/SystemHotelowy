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
    public partial class LogowanieAdministracja : Form
    {
        public LogowanieAdministracja()
        {
            InitializeComponent();
        }

        private void LogowanieAdministracja_Load(object sender, EventArgs e)
        {
            textBoxHaslo.PasswordChar = '*';
        }

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                string login = textBoxLogin.Text.ToString();
                string haslo = textBoxHaslo.Text.ToString();

                var query = (from Uzytkownicy u in db.Uzytkownicy
                             join Pracownicy p in db.Pracownicy on u.IdPracownika equals p.IdPracownika
                             where u.Login == login && u.Haslo == haslo && p.Stanowisko == "Administrator"
                             select u.IdUzytkownika).ToList();

                if (query.Count > 0)
                {
                    Hide();
                    MenuAdministracja menu = new MenuAdministracja(textBoxLogin.Text);
                    menu.Show();
                }
                else
                    MessageBox.Show("Niepoprawny login lub hasło", "Błąd");
            }
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}