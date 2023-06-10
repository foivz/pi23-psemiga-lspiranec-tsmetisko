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
    public partial class DodavanjeSportskogProstoraFrm : Form
    {
        public DodavanjeSportskogProstoraFrm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (var context = new PI2306_DBEntities())
            {
                string naziv = txtNaziv.Text;
                string adresa = txtAdresa.Text;
                float cijena = float.Parse(txtCijena.Text);

                Sportski_prostor sportski_prostor = new Sportski_prostor()
                {
                    naziv = naziv,
                    adresa = adresa,
                    cijena = cijena
                };

                context.Sportski_prostor.Add(sportski_prostor);
                context.SaveChanges();
            }
            Close();
            MessageBox.Show("Uspjesno dodavanje prostora!");
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
