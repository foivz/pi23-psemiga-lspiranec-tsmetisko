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

            dgvRezervacijeProstora.DataSource = DohvatiRezervacijeProstora();
            dgvRezervacijeProstora.Columns["Korisnik"].Visible = false;
            dgvRezervacijeProstora.Columns["Dogadaj"].Visible = false;
            dgvRezervacijeProstora.Columns["Rezultat"].Visible = false;
            dgvRezervacijeProstora.Columns["Sportski_prostor"].Visible = false;
            dgvRezervacijeProstora.Columns["korisnik_id"].Visible = false;
            dgvRezervacijeProstora.Columns["rezervacija_prostora_id"].Visible = false;
            dgvRezervacijeProstora.Columns["dogadaj_id"].Visible = false;
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

        private List<Rezervacija_prostora> DohvatiRezervacijeProstora()
        {
            using (var context = new PI2306_DBEntities())
            {
                var query = from rp in context.Rezervacija_prostora
                            select rp;

                return query.ToList();
            }
        }
    }
}
