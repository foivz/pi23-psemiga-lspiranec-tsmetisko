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
    public partial class SportskaOpremaCjenikFrm : Form
    {
        public SportskaOpremaCjenikFrm()
        {
            InitializeComponent();
        }

        private void SportskaOpremaCjenikFrm_Load(object sender, EventArgs e)
        {
            dataGridViewOprema.DataSource = GetOprema();
            dataGridViewOprema.Columns["sportska_oprema_id"].Visible = false;
            dataGridViewOprema.Columns["Rezervacija_opreme"].Visible = false;
        }

        private object GetOprema()
        {
            using (var context = new PI2306_DBEntities())
            {
                return context.Sportska_oprema.ToList();
            }
        }

        private void ObrisiOpremuButton_Click(object sender, EventArgs e)
        {
            Sportska_oprema odabrana = dataGridViewOprema.CurrentRow.DataBoundItem as Sportska_oprema;
            using (var context = new PI2306_DBEntities())
            {
                context.Sportska_oprema.Attach(odabrana);
                context.Sportska_oprema.Remove(odabrana);
                context.SaveChanges();
            }
            dataGridViewOprema.DataSource = GetOprema();
        }

        private void DodajOpremuButton_Click(object sender, EventArgs e)
        {
            DodajOpremuFrm forma = new DodajOpremuFrm();
            forma.ShowDialog();
            dataGridViewOprema.DataSource = GetOprema();
        }

        private void AzurirajOpremuButton_Click(object sender, EventArgs e)
        {
            Sportska_oprema odabranaOprema = dataGridViewOprema.CurrentRow.DataBoundItem as Sportska_oprema;
            if (odabranaOprema != null)
            {
                AzurirajOpremuFrm forma = new AzurirajOpremuFrm(odabranaOprema);
                forma.ShowDialog();
                dataGridViewOprema.DataSource = GetOprema();
            }
        }

        private void ZatvoriOpremuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
