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
    public partial class NaslovnaZaposlenik : Form
    {
        int korisnikID;
        public NaslovnaZaposlenik(int korID)
        {
            InitializeComponent();
            korisnikID = korID;
        }

        private void buttonSortiranjePrigovora_Click(object sender, EventArgs e)
        {
            SortiranjeObrazacaFrm forma = new SortiranjeObrazacaFrm();
            forma.ShowDialog();
        }

        private void buttonUrediCjenik_Click(object sender, EventArgs e)
        {
            CjenikZaposlenikFrm forma = new CjenikZaposlenikFrm();
            forma.ShowDialog();
        }

        private void btnPopisTreningPrograma_Click(object sender, EventArgs e)
        {
            PopisTreningPrograma ptp = new PopisTreningPrograma(korisnikID);
            ptp.Show();
        }

        private void btnDostupnost_Click(object sender, EventArgs e)
        {
            PreglediTerena pt = new PreglediTerena();
            pt.Show();
        }

        private void btnDogadaji_Click(object sender, EventArgs e)
        {
            PregledDogadajaZaposlenikForm form = new PregledDogadajaZaposlenikForm();
            form.ShowDialog();
        }

        private void btnSportskiProstori_Click(object sender, EventArgs e)
        {
            PregledSportskihProstoraFrm form = new PregledSportskihProstoraFrm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NaslovnaZaposlenik_Load(object sender, EventArgs e)
        {
            textBoxKorisnik.Text = korisnikID.ToString();
            textBoxKorisnik.Enabled = false;
        }
    }
}
