using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Rent_A_Field
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private int ProvjeriUnose(string imePrezime, string email, string brojMobitela, string korIme, string lozinka)
        {
            if (string.IsNullOrEmpty(imePrezime) || string.IsNullOrWhiteSpace(imePrezime) || string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrEmpty(brojMobitela) || string.IsNullOrWhiteSpace(brojMobitela) || string.IsNullOrEmpty(korIme) || string.IsNullOrWhiteSpace(korIme) ||
                string.IsNullOrEmpty(lozinka) || string.IsNullOrWhiteSpace(lozinka))
            {
                return -1;
            }
            else if (!ProvjeraImenaPrezimena(imePrezime))
            {
                return -2;
            }
            else if (!ProvjeraMobitela(brojMobitela))
            {
                return -3;
            }
            else if (!ProvjeraEmaila(email))
            {
                return -4;
            }
            else
            {
                return 1;
            }
        }
        private bool ProvjeraImenaPrezimena(string unos)
        {
            string uzorak = @"^(([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,})(([ ]|[-])([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,}))?)$";
            if (!Regex.Match(unos, uzorak).Success) return false; else return true;

        }

        private bool ProvjeraMobitela(string unos)
        {
            string uzorak = @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$";
            if (!Regex.Match(unos, uzorak).Success) return false; else return true;
        }

        private bool ProvjeraEmaila(string unos)
        {
            string uzorak = @"^([A-Z,a-z,ČĆŽĐŠčćžđš][a-z,A-Z,0-9,ČĆŽĐŠčćžđš,_,-,.]{2,}@[a-z]{2,}[.][a-z][a-z]{1,})$";
            if (!Regex.Match(unos, uzorak).Success) return false; else return true;
        }

        public int Genereriraj()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 1000);
            return randomNumber;
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            using (var context = new PI2306_DBEntities())
            {
                int korisnik_id = Genereriraj();
                string imePrezime = txtImePrezime.Text;
                string email = txtEmail.Text;
                string brojMobitela = txtBrojMobitela.Text;
                string korIme = txtKorIme.Text;
                string lozinka = txtLozinka.Text;
                Korisnik korisnik = new Korisnik()
                {
                    korisnik_id = korisnik_id,
                    ime_prezime = imePrezime,
                    email = email,
                    broj_mobitela = brojMobitela,
                    korisnicko_ime = korIme,
                    lozinka = lozinka,
                    uloga_id = 2
                };
                int uspjesno = ProvjeriUnose(imePrezime, email, brojMobitela, korIme, lozinka);
                string poruka = "";
                switch (uspjesno)
                {
                    case -1:
                        poruka = "Niste popunili sva polja!";
                        break;
                    case -2:
                        poruka = "Ime i prezime su pogrešnog formata!";
                        break;
                    case -3:
                        poruka = "Broj mobitela je pogrešnog formata!";
                        break;
                    case -4:
                        poruka = "Email je pogrešnog formata!";
                        break;
                    case 1:
                        try
                        {
                            context.Korisniks.Add(korisnik);
                            context.SaveChanges();
                        }
                        catch (DbEntityValidationException ex)
                        {
                            foreach (var eve in ex.EntityValidationErrors)
                            {
                                Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                    eve.Entry.Entity.GetType().Name, eve.Entry.State);
                                foreach (var ve in eve.ValidationErrors)
                                {
                                    Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                        ve.PropertyName, ve.ErrorMessage);
                                }
                            }
                            throw;
                        }

                        context.SaveChanges();
                        GeneriranjeQR generiranje = new GeneriranjeQR(email, lozinka);
                        generiranje.Show();

                        break;
                }
                if (uspjesno != 1)
                {
                    MessageBox.Show(poruka);
                }
            }
        }
    }
}
