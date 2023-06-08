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
    public partial class TreneriCjenikFrm : Form
    {
        public TreneriCjenikFrm()
        {
            InitializeComponent();
        }

        private void TreneriCjenikFrm_Load(object sender, EventArgs e)
        {
            dataGridViewTreneri.DataSource = GetTreneri();
            dataGridViewTreneri.Columns["datum_rodenja"].Visible = false;
            dataGridViewTreneri.Columns["Rezervacija_trenera"].Visible = false;
        }

        private object GetTreneri()
        {
            using (var context = new PI2306_DBEntities())
            {
                return context.Treners.ToList();
            }
        }

        private void DodajProstorButton_Click(object sender, EventArgs e)
        {
            DodajTreneraFrm forma = new DodajTreneraFrm();
            forma.ShowDialog();
            dataGridViewTreneri.DataSource = GetTreneri();
        }

        private void ObrisiProstorButton_Click(object sender, EventArgs e)
        {
            Trener odabrani = dataGridViewTreneri.CurrentRow.DataBoundItem as Trener;
            using (var context = new PI2306_DBEntities())
            {
                context.Treners.Attach(odabrani);
                context.Treners.Remove(odabrani);
                context.SaveChanges();
            }
            dataGridViewTreneri.DataSource = GetTreneri();
        }

        private void AzurirajProstorButton_Click(object sender, EventArgs e)
        {
            Trener odabraniTrener = dataGridViewTreneri.CurrentRow.DataBoundItem as Trener;
            if (odabraniTrener != null)
            {
                AzurirajTreneraFrm forma = new AzurirajTreneraFrm(odabraniTrener);
                forma.ShowDialog();
                dataGridViewTreneri.DataSource = GetTreneri();
            }
        }

        private void ZatvoriProstorButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
