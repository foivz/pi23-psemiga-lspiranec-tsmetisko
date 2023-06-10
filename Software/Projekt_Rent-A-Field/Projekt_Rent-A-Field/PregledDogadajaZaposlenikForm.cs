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
    public partial class PregledDogadajaZaposlenikForm : Form
    {
        public PregledDogadajaZaposlenikForm()
        {
            InitializeComponent();
        }

        private void PregledDogadajaZaposlenikForm_Load(object sender, EventArgs e)
        {
            PopuniSportskeProstore();
        }

        private void PrikaziSve()
        {
            using (var context = new PI2306_DBEntities())
            {

                var query = from d in context.Dogadajs
                            select d;

                dgvRezervacija.DataSource = query.ToList();

            }
            dgvRezervacija.Columns["Rezervacija_prostora"].Visible = false;
        }

        private void PrikaziPoDatumu()
        {
            DateTime odabranidatum = dateTimePicker1.Value.Date;
            using (var context = new PI2306_DBEntities())
            {
                if (odabranidatum != null)
                {
                    var query = from rp in context.Rezervacija_prostora
                                from d in context.Dogadajs
                                from sp in context.Sportski_prostor
                                where rp.dogadaj_id == d.dogadaj_id
                                where rp.sportski_prostor_id == sp.sportski_prostor_id
                                where rp.datum == odabranidatum
                                select d;

                    dgvRezervacija.DataSource = query.ToList();
                }

                else
                {
                    dgvRezervacija.DataSource = null;
                }
                dgvRezervacija.Columns["Rezervacija_prostora"].Visible = false;

            }
        }

        private void PrikaziPoProstoru()
        {
            Sportski_prostor odabrani = cmbProstor.SelectedItem as Sportski_prostor;
            using (var context = new PI2306_DBEntities())
            {
                if (odabrani != null)
                {
                    var query = from rp in context.Rezervacija_prostora
                                from d in context.Dogadajs
                                from sp in context.Sportski_prostor
                                where rp.dogadaj_id == d.dogadaj_id
                                where rp.sportski_prostor_id == sp.sportski_prostor_id
                                where sp.naziv == odabrani.naziv
                                select d;

                    dgvRezervacija.DataSource = query.ToList();
                }
                else
                {
                    dgvRezervacija.DataSource = null;
                }
                dgvRezervacija.Columns["Rezervacija_prostora"].Visible = false;

            }
        }

        private object PopuniSportskeProstore()
        {
            using (var context = new PI2306_DBEntities())
            {
                cmbProstor.DataSource = context.Sportski_prostor.ToList();
            }
            return cmbProstor.DataSource;
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        { 
            KreiranjeDogadajaFrm form = new KreiranjeDogadajaFrm();
            form.ShowDialog();
            PrikaziSve();

        }

        private void btnDatum_Click(object sender, EventArgs e)
        {
            PrikaziPoDatumu();
        }

        private void btnPoProstoru_Click(object sender, EventArgs e)
        {

            PrikaziPoProstoru();

        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            PrikaziSve();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            Dogadaj odabrani = dgvRezervacija.CurrentRow.DataBoundItem as Dogadaj;

            using (var context = new PI2306_DBEntities())
            {
                context.Dogadajs.Attach(odabrani);
                context.Dogadajs.Remove(odabrani);
                foreach (var item in context.Rezervacija_prostora)
                {
                    if (odabrani.dogadaj_id == item.dogadaj_id)
                    {
                        context.Rezervacija_prostora.Attach(item);
                        context.Rezervacija_prostora.Remove(item);
                    }
                }
                context.SaveChanges();
            }
            PrikaziSve();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Dogadaj odabrani = dgvRezervacija.CurrentRow.DataBoundItem as Dogadaj;
            AzuriranjeDogadajaFrm frm = new AzuriranjeDogadajaFrm(odabrani);
            frm.ShowDialog();
            PrikaziSve();
        }
    }
}
