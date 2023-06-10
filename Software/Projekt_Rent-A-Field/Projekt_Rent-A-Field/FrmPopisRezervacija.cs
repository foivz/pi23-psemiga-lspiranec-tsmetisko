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
    public partial class FrmPopisRezervacija : Form
    {
        public FrmPopisRezervacija()
        {
            InitializeComponent();
        }

        private void FrmPopisRezervacija_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            DohvatiRezervacijeTrenera();
            DohvatiRezervacijeOpreme();
            DohvatiRezervacijeProstora();
        }

        private void DohvatiRezervacijeTrenera()
        {
            using (var context = new PI2306_DBEntities())
            {
                var query = from rt in context.Rezervacija_trenera
                            from t in context.Treners
                            where rt.korisnik_id == 1
                            where rt.trener_id == t.trener_id
                            select new { rt.rezervacija_trenera_id, t.ime_prezime, rt.datum, rt.vrijeme_od, rt.duljina_rezervacije, rt.placeno, rt.cijena };

                dgvRezervacijeTrenera.DataSource = query.ToList();
            }
        }

        private void DohvatiRezervacijeOpreme()
        {
            using (var context = new PI2306_DBEntities())
            {
                var query = from ro in context.Rezervacija_opreme
                            from so in context.Sportska_oprema
                            where ro.korisnik_id == 1
                            where ro.sportska_oprema_id == so.sportska_oprema_id
                            select new { ro.rezervacija_sportske_opreme_id, so.ime, ro.datum, ro.vrijeme_od, ro.duljina_rezervacije, ro.placeno, ro.cijena };

                dgvRezervacijeOpreme.DataSource = query.ToList();
            }
        }

        private void DohvatiRezervacijeProstora()
        {
            using (var context = new PI2306_DBEntities())
            {
                var query = from rp in context.Rezervacija_prostora
                            from sp in context.Sportski_prostor
                            where rp.korisnik_id == 1
                            where rp.sportski_prostor_id == sp.sportski_prostor_id
                            select new { rp.rezervacija_prostora_id, sp.naziv, sp.adresa, rp.datum, rp.vrijeme_od, rp.duljina_rezervacije, rp.placeno, rp.cijena };

                dgvRezervacijeProstora.DataSource = query.ToList();
            }
        }

        private void btnRezervirajProstor_Click(object sender, EventArgs e)
        {
            RezervacijaSportskogProstoraFrm rezervirajProstor = new RezervacijaSportskogProstoraFrm();
            rezervirajProstor.ShowDialog();
            Osvjezi();
        }

        private void btnRezervirajTrenera_Click(object sender, EventArgs e)
        {
            RezervacijaTreneraFrm rezervirajTrenera = new RezervacijaTreneraFrm();
            rezervirajTrenera.ShowDialog();
            Osvjezi();
        }

        private void btnRezervirajDodatnuSportskuOpremu_Click(object sender, EventArgs e)
        {
            RezervacijaSportskeOpremeFrm rezervirajOpremu = new RezervacijaSportskeOpremeFrm();
            rezervirajOpremu.ShowDialog();
            Osvjezi();
        }

        private void btnPlatiProstor_Click(object sender, EventArgs e)
        {
            int rezID = int.Parse(dgvRezervacijeProstora.CurrentRow.Cells[0].Value.ToString());
            PlacanjeProstoraOnline platiProstor = new PlacanjeProstoraOnline(rezID);
            platiProstor.ShowDialog();
            Osvjezi();
        }

        private void btnPlatiTrenera_Click(object sender, EventArgs e)
        {
            int rezID = int.Parse(dgvRezervacijeTrenera.CurrentRow.Cells[0].Value.ToString());
            PlacanjeTreneraOnline platiTrenera = new PlacanjeTreneraOnline(rezID);
            platiTrenera.ShowDialog();
            Osvjezi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rezID = int.Parse(dgvRezervacijeOpreme.CurrentRow.Cells[0].Value.ToString());
            PlacanjeOpremeOnline platiOpremu = new PlacanjeOpremeOnline(rezID);
            platiOpremu.ShowDialog();
            Osvjezi();
        }

        private void btnObrisiProstor_Click(object sender, EventArgs e)
        {
            int odabraniProstor = (int)dgvRezervacijeProstora.CurrentRow.Cells[0].Value;
            DateTime trenutnoVrijeme = DateTime.Today;

            //if (odabraniProstor != null)
            //{
                using (var context = new PI2306_DBEntities())
                {
                    var query = from rp in context.Rezervacija_prostora
                                where rp.rezervacija_prostora_id == odabraniProstor
                                select rp;
                Rezervacija_prostora prostor = query.FirstOrDefault();

                    context.Rezervacija_prostora.Attach(prostor);
                    if (prostor.datum > trenutnoVrijeme || prostor.placeno == 1)
                    {
                        context.Rezervacija_prostora.Remove(prostor);
                        context.SaveChanges();
                        MessageBox.Show("Uspješno obrisana rezervacija");
                    }
                    else
                    {
                        MessageBox.Show("Rezervaciju možete otkazati najkasnije dan prije početka termina ili ukoliko je ona plaćena.");
                    }
                }
            //}
            Osvjezi();
        }

        private void btnObrisiTrenera_Click(object sender, EventArgs e)
        {
            int odabraniTrener = (int)dgvRezervacijeTrenera.CurrentRow.Cells[0].Value;
            DateTime trenutnoVrijeme = DateTime.Today;

            using (var context = new PI2306_DBEntities())
            {
                var query = from rt in context.Rezervacija_trenera
                            where rt.rezervacija_trenera_id == odabraniTrener
                            select rt;
                Rezervacija_trenera trener = query.FirstOrDefault();

                context.Rezervacija_trenera.Attach(trener);
                if (trener.datum > trenutnoVrijeme || trener.placeno == 1)
                {
                    context.Rezervacija_trenera.Remove(trener);
                    context.SaveChanges();
                    MessageBox.Show("Uspješno obrisana rezervacija");
                }
                else
                {
                    MessageBox.Show("Rezervaciju možete otkazati najkasnije dan prije početka termina ili ukoliko je ona plaćena.");
                }
            }

            Osvjezi();
        }

        private void btnObrisiOpremu_Click(object sender, EventArgs e)
        {
            int odabranaOprema = (int)dgvRezervacijeOpreme.CurrentRow.Cells[0].Value;
            DateTime trenutnoVrijeme = DateTime.Today;

            using (var context = new PI2306_DBEntities())
            {
                var query = from ro in context.Rezervacija_opreme
                            where ro.rezervacija_sportske_opreme_id == odabranaOprema
                            select ro;
                Rezervacija_opreme oprema = query.FirstOrDefault();

                context.Rezervacija_opreme.Attach(oprema);
                if (oprema.datum > trenutnoVrijeme || oprema.placeno == 1)
                {
                    context.Rezervacija_opreme.Remove(oprema);
                    context.SaveChanges();
                    MessageBox.Show("Uspješno obrisana rezervacija");
                }
                else
                {
                    MessageBox.Show("Rezervaciju možete otkazati najkasnije dan prije početka termina ili ukoliko je ona plaćena.");
                }
            }

            Osvjezi();
        }
    }
}
