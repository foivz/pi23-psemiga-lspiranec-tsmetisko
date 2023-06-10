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
    public partial class PregledSportskihProstoraFrm : Form
    {
        public PregledSportskihProstoraFrm()
        {
            InitializeComponent();
        }

        private void PregledSportskihProstoraFrm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            using (var context = new PI2306_DBEntities())
            {
                dgvSportskiProstori.DataSource = context.Sportski_prostor.ToList();
            }
            dgvSportskiProstori.Columns["sportski_prostor_id"].Visible = false;
            dgvSportskiProstori.Columns["Rezervacija_prostora"].Visible = false;

        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodavanjeSportskogProstoraFrm dodaj = new DodavanjeSportskogProstoraFrm();
            dodaj.ShowDialog();
            Osvjezi();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Sportski_prostor odabrani = dgvSportskiProstori.CurrentRow.DataBoundItem as Sportski_prostor;
            AzuriranjeSportskihProstoraFrm from = new AzuriranjeSportskihProstoraFrm(odabrani);
            from.ShowDialog();
            Osvjezi();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Sportski_prostor odabrani = dgvSportskiProstori.CurrentRow.DataBoundItem as Sportski_prostor;

            using (var context = new PI2306_DBEntities())
            {
                context.Sportski_prostor.Attach(odabrani);
                context.Sportski_prostor.Remove(odabrani);
                context.SaveChanges();
            }
            Osvjezi();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
