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
    public partial class SportskiProstorCjenikFrm : Form
    {
        public SportskiProstorCjenikFrm()
        {
            InitializeComponent();
        }

        private object GetProstor()
        {
            using (var context = new PI2306_DBEntities())
            {
                return context.Sportski_prostor.ToList();
            }
        }

        private void SportskiProstorCjenikFrm_Load(object sender, EventArgs e)
        {
            dataGridViewProstor.DataSource = GetProstor();
            dataGridViewProstor.Columns["sportski_prostor_id"].Visible = false;
            dataGridViewProstor.Columns["Rezervacija_prostora"].Visible = false;
        }

        private void ObrisiProstorButton_Click(object sender, EventArgs e)
        {
            Sportski_prostor odabranoo = dataGridViewProstor.CurrentRow.DataBoundItem as Sportski_prostor;
            using (var context = new PI2306_DBEntities())
            {
                context.Sportski_prostor.Attach(odabranoo);
                context.Sportski_prostor.Remove(odabranoo);
                context.SaveChanges();
            }
            dataGridViewProstor.DataSource = GetProstor();
        }

        private void DodajProstorButton_Click(object sender, EventArgs e)
        {
            DodajProstorFrm forma = new DodajProstorFrm();
            forma.ShowDialog();
            dataGridViewProstor.DataSource = GetProstor();
        }

        private void AzurirajProstorButton_Click(object sender, EventArgs e)
        {
            Sportski_prostor odabraniProstor = dataGridViewProstor.CurrentRow.DataBoundItem as Sportski_prostor;
            if (odabraniProstor != null)
            {
                AzurirajProstorFrm forma = new AzurirajProstorFrm(odabraniProstor);
                forma.ShowDialog();
                dataGridViewProstor.DataSource = GetProstor();
            }
        }

        private void ZatvoriProstorButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
