using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Rent_A_Field
{
    public partial class Prijava : Form
    {
        bool PrikaziLozinku = false;
        bool Autentifican = false;
        public Prijava()
        {
            InitializeComponent();
            txtLozinka.PasswordChar = '•';
            labelRegistracija.BackColor = Color.CadetBlue;
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string lozinka = txtLozinka.Text;
            List<Korisnik> listaKorisnika = DohvatiSveKorisnike();
            bool pronaden = false;
            foreach (Korisnik item in listaKorisnika)
            {
                if (item.email == email && item.lozinka == lozinka)
                {
                    pronaden = true;
                }
            }
            if (pronaden)
            {
                MessageBox.Show("uspjesno");
                //TreningProgram tren = new TreningProgram();
                //tren.Show();
            }
            else
            {
                MessageBox.Show("greska");
            }
        }
        private List<Korisnik> DohvatiSveKorisnike()
        {
            using (var context = new PI2306_DBEntities())
            {
                var query = from k in context.Korisniks
                            select k;

                return query.ToList();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtLozinka.PasswordChar = '\0';
                PrikaziLozinku = true;
            }
            else
            {
                txtLozinka.PasswordChar = '•';
                PrikaziLozinku = false;
            }
        }

        private void labelRegistracija_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.Show();
        }
    }
}
