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
    public partial class MenuGlowne : Form
    {
        public MenuGlowne()
        {
            InitializeComponent();
        }

        private void buttonRecepcja_Click(object sender, EventArgs e)
        {
            LogowanieRecepcja logujRecepcja = new LogowanieRecepcja();
            logujRecepcja.Show();

        }

        private void MenuGlowne_Load(object sender, EventArgs e)
        {
            ZmianaStatusuPokoju();
            ZmianaStatusuRezerwacji();
            ZmianaStatusuMeldunku();
        }

        public void ZmianaStatusuPokoju()
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                var dzis = DateTime.Now.Date;
                List<Pokoje> querydzis = (from Pokoje p in db.Pokoje
                                          join Rezerwacje r in db.Rezerwacje on p.IdPokoju equals r.IdPokoju
                                          where r.DataOd < dzis && r.DataDo > dzis
                                          select p).ToList();

                foreach (Pokoje p in querydzis)
                {
                    p.CzyWolny = true;
                }

                List<Pokoje> queryrezerwacja = (from Pokoje p in db.Pokoje
                                                join Rezerwacje r in db.Rezerwacje on p.IdPokoju equals r.IdPokoju
                                                where r.DataOd <= dzis && r.DataDo >= dzis
                                                select p).ToList();

                foreach (Pokoje p in queryrezerwacja)
                {
                    p.CzyWolny = false;
                }
                db.SaveChanges();
            }
        }

        public void ZmianaStatusuRezerwacji()
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                var dzis = DateTime.Now.Date;
                List<Rezerwacje> querydzis = (from Rezerwacje r in db.Rezerwacje
                                              where r.DataDo < dzis
                                              select r).ToList();

                foreach (Rezerwacje r in querydzis)
                {
                    r.CzyAktywna = false;
                }
                db.SaveChanges();
            }
        }
        public void ZmianaStatusuMeldunku()
        {
            using (INZ2020HotelePKEntities db = new INZ2020HotelePKEntities())
            {
                var dzis = DateTime.Now.Date;
                List<Meldunki> querydzis = (from Meldunki r in db.Meldunki
                                              where r.DataDo < dzis
                                              select r).ToList();

                foreach (Meldunki r in querydzis)
                {
                    r.CzyAktywny = false;
                }
                db.SaveChanges();
            }
        }
        private void buttonGastronomia_Click(object sender, EventArgs e)
        {
            LogowanieGastronomia logujGastronomia = new LogowanieGastronomia();
            logujGastronomia.Show();
        }

        private void buttonAdministracja_Click(object sender, EventArgs e)
        {
            LogowanieAdministracja logujAdministracja = new LogowanieAdministracja();
            logujAdministracja.Show();
        }

        private void buttonSprzatanie_Click(object sender, EventArgs e)
        {
            LogowanieSprzatanie logujSprzatanie = new LogowanieSprzatanie();
            logujSprzatanie.Show();
        }
    }
}