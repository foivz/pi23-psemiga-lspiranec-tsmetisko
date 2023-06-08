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
                            select new { t.ime_prezime, rt.datum, rt.vrijeme_od, rt.duljina_rezervacije, rt.placeno, rt.cijena };

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
                            select new { so.ime, ro.datum, ro.vrijeme_od, ro.duljina_rezervacije, ro.placeno, ro.cijena };

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
                            select new { sp.naziv, sp.adresa, rp.datum, rp.vrijeme_od, rp.duljina_rezervacije, rp.placeno, rp.cijena };

                dgvRezervacijeProstora.DataSource = query.ToList();
            }
        }
    }
}
