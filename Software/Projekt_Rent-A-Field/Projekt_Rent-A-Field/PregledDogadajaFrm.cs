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
    public partial class PregledDogadajaFrm : Form
    {
        public PregledDogadajaFrm()
        {
            InitializeComponent();
        }

        private void PregledDogadajaFrm_Load(object sender, EventArgs e)
        {
            PopuniSportskeProstore();
        }

        private void PrikaziSve()
        {
            using (var context = new PI2306_DBEntities())
            {

                var query = from rp in context.Rezervacija_prostora
                            from d in context.Dogadajs
                            from sp in context.Sportski_prostor
                            where rp.dogadaj_id == d.dogadaj_id
                            where rp.sportski_prostor_id == sp.sportski_prostor_id
                            select new
                            {
                                Datum = rp.datum,
                                Pocetak = rp.vrijeme_od,
                                Duljina = rp.duljina_rezervacije,
                                Naziv_dogadaja = d.naziv,
                                Opis = d.opis,
                                Max_br_sudionika = d.max_broj_sudionika,
                                Naziv_Sportskog_prostora = sp.naziv,
                                Adresa = sp.adresa,
                                Cijena = sp.cijena
                            };

                dgvRezervacija.DataSource = query.ToList();

            }
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
                                select new
                                {
                                    Datum = rp.datum,
                                    Pocetak = rp.vrijeme_od,
                                    Duljina = rp.duljina_rezervacije,
                                    Naziv_dogadaja = d.naziv,
                                    Opis = d.opis,
                                    Max_br_sudionika = d.max_broj_sudionika,
                                    Naziv_Sportskog_prostora = sp.naziv,
                                    Adresa = sp.adresa,
                                    Cijena = sp.cijena
                                };

                    dgvRezervacija.DataSource = query.ToList();
                }
                else
                {
                    dgvRezervacija.DataSource = null;
                }


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
                                select new
                                {
                                    Datum = rp.datum,
                                    Pocetak = rp.vrijeme_od,
                                    Duljina = rp.duljina_rezervacije,
                                    Naziv_dogadaja = d.naziv,
                                    Opis = d.opis,
                                    Max_br_sudionika = d.max_broj_sudionika,
                                    Naziv_Sportskog_prostora = sp.naziv,
                                    Adresa = sp.adresa,
                                    Cijena = sp.cijena
                                };

                    dgvRezervacija.DataSource = query.ToList();
                }
                else
                {
                    dgvRezervacija.DataSource = null;
                }


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

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            PrikaziSve();
        }

        private void btnDatum_Click(object sender, EventArgs e)
        {
            PrikaziPoDatumu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrikaziPoProstoru();
        }
    }
}
