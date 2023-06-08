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
    public partial class AzurirajProstorFrm : Form
    {
        private Sportski_prostor odabraniProstor;
        public AzurirajProstorFrm(Sportski_prostor odabraniProstor)
        {
            InitializeComponent();
            this.odabraniProstor = odabraniProstor;
        }

        private void AzurirajProstorFrm_Load(object sender, EventArgs e)
        {
            if (odabraniProstor != null)
            {
                textBoxNazivProstorA.Text = odabraniProstor.naziv;
                textBoxAdresaProstorA.Text = odabraniProstor.adresa;
                textBoxCijenaPoSatuProstorA.Text = odabraniProstor.cijena.ToString();
            }
        }

        private void ButtonAzurirajProstor_Click(object sender, EventArgs e)
        {
            if (odabraniProstor != null)
            {
                using (var context = new PI2306_DBEntities())
                {
                    Sportski_prostor sportski_Prostor = context.Sportski_prostor.Find(odabraniProstor.sportski_prostor_id);
                    if (sportski_Prostor != null)
                    {
                        sportski_Prostor.naziv = textBoxNazivProstorA.Text;
                        sportski_Prostor.adresa = textBoxAdresaProstorA.Text;
                        sportski_Prostor.cijena = double.Parse(textBoxCijenaPoSatuProstorA.Text);

                        context.SaveChanges();
                        MessageBox.Show("Podaci sportskog prostora su ažurirani.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Odabrani sportski prostor ne postoji u bazi podataka.");
                    }
                }
            }
        }

        private void ButtonOdustaniAProstor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
