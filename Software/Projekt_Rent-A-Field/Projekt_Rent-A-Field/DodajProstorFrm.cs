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
    public partial class DodajProstorFrm : Form
    {
        public DodajProstorFrm()
        {
            InitializeComponent();
        }

        private void DodajProstorFrm_Load(object sender, EventArgs e)
        {
            using (var context = new PI2306_DBEntities())
            {
                Sportski_prostor novi = new Sportski_prostor();
                novi.naziv = textBoxNazivProstor.Text;
                novi.adresa = textBoxAdresaProstor.Text;
                novi.cijena = double.Parse(textBoxCijenaPoSatuProstor.Text);

                context.Sportski_prostor.Add(novi);
                context.SaveChanges();

            }
            Close();
        }

        private void ButtonDodajProstor_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOdustaniProstor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
