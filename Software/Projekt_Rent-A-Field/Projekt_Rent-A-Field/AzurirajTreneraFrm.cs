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
    public partial class AzurirajTreneraFrm : Form
    {
        private Trener odabraniTrener;
        public AzurirajTreneraFrm(Trener trener)
        {
            InitializeComponent();
            odabraniTrener = trener;
        }

        private void AzurirajTreneraFrm_Load(object sender, EventArgs e)
        {
            if (odabraniTrener != null)
            {
                textBoxImePrezime.Text = odabraniTrener.ime_prezime;
                textBoxPodrucjeInteresa.Text = odabraniTrener.podrucje_interesa;
                textBoxCijenaPoSatu.Text = odabraniTrener.cijena_po_satu.ToString();
            }
        }

        private void buttonAzurirajTrenera_Click(object sender, EventArgs e)
        {
            if (odabraniTrener != null)
            {
                using (var context = new PI2306_DBEntities())
                {
                    Trener trener = context.Treners.Find(odabraniTrener.trener_id);
                    if (trener != null)
                    {
                        trener.ime_prezime = textBoxImePrezime.Text;
                        trener.podrucje_interesa = textBoxPodrucjeInteresa.Text;
                        trener.cijena_po_satu = double.Parse(textBoxCijenaPoSatu.Text);

                        context.SaveChanges();
                        MessageBox.Show("Podaci trenera su ažurirani.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Odabrani trener ne postoji u bazi podataka.");
                    }
                }
            }
        }

        private void buttonOdustaniTrener_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
