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
    public partial class Naslovna : Form
    {
        int korisnikID;
        int uloga;

        public Naslovna(int korID, int ulogaKorisnika)
        {
            InitializeComponent();
            korisnikID = korID;
            uloga = ulogaKorisnika;
        }

        private void buttonPopisRezervacija_Click(object sender, EventArgs e)
        {
            FrmPopisRezervacija frmPopisRezervacija = new FrmPopisRezervacija(korisnikID);
            frmPopisRezervacija.ShowDialog();
        }

        private void buttonPristupCjeniku_Click(object sender, EventArgs e)
        {
            CjenikFrm cjenikfrm = new CjenikFrm();
            cjenikfrm.ShowDialog();
        }

        private void buttonKreirajPrigovor_Click(object sender, EventArgs e)
        {
            ObrazacZaPrigovoreFrm forma = new ObrazacZaPrigovoreFrm(korisnikID);
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GeneriranjeFrm forma = new GeneriranjeFrm();
            forma.ShowDialog();
        }

        private void btnPopisTreningPrograma_Click(object sender, EventArgs e)
        {
            PopisTreningPrograma ptp = new PopisTreningPrograma();
            ptp.Show();
        }

        private void btnDostupnost_Click(object sender, EventArgs e)
        {
            PreglediTerena pt = new PreglediTerena();
            pt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EvidencijaTerminaFrm forma = new EvidencijaTerminaFrm(korisnikID);
            forma.ShowDialog();

        }

        private void btnKreirajDogadaj_Click(object sender, EventArgs e)
        {
            KreiranjeDogadajaFrm form = new KreiranjeDogadajaFrm();
            form.ShowDialog();
        }

        private void btnPregledDogadaja_Click(object sender, EventArgs e)
        {
            PregledDogadajaFrm form = new PregledDogadajaFrm();
            form.ShowDialog();
        }
    }
}
