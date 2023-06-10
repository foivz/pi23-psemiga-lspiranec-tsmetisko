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
    public partial class AzuriranjeSportskihProstoraFrm : Form
    {
        private Sportski_prostor odabrani;
        public AzuriranjeSportskihProstoraFrm(Sportski_prostor sportski_prostor)
        {
            InitializeComponent();
            odabrani = sportski_prostor;
        }

        private void AzuriranjeSportskihProstoraFrm_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = odabrani.naziv;
            txtAdresa.Text = odabrani.adresa;
            txtCijena.Text = odabrani.cijena.ToString();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            using (var context = new PI2306_DBEntities())
            {
                string naziv = txtNaziv.Text;
                string adresa = txtAdresa.Text;
                float cijena = float.Parse(txtCijena.Text);

                context.Sportski_prostor.Attach(odabrani);

                odabrani.naziv = naziv;
                odabrani.adresa = adresa;
                odabrani.cijena = cijena;

                context.SaveChanges();
            }
            Close();
            MessageBox.Show("Uspjesno azuriranje!");
        }
    }
}
