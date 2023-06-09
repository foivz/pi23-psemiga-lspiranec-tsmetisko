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
    public partial class RezervacijaTreneraFrm : Form
    {
        public RezervacijaTreneraFrm()
        {
            InitializeComponent();
        }

        private void RezervacijaTreneraFrm_Load(object sender, EventArgs e)
        {
            dgvPopisTrenera.DataSource = PrikaziTrenere();
            dgvPopisTrenera.Columns["Rezervacija_trenera"].Visible = false;
            dgvPopisTrenera.Columns["datum_rodenja"].Visible = false;
            dgvPopisTrenera.Columns["trener_id"].Visible = false;
        }

        private List<Trener> PrikaziTrenere()
        {
            using (var context = new PI2306_DBEntities())
            {
                var query = from t in context.Treners
                            select t;

                return query.ToList();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            using (var context = new PI2306_DBEntities())
            {
                DateTime datum = dtpRezervacijaTrenera.Value.Date;
                string vrijemeOd = txtVrijemeOd.Text;
                int duljinaRezervacije = int.Parse(txtDuljinaRezervacije.Text);

                float cijenaPoSatu = float.Parse(dgvPopisTrenera.CurrentRow.Cells[4].Value.ToString());
                float cijena = cijenaPoSatu * duljinaRezervacije;

                Rezervacija_trenera rezervacijaTrenera = new Rezervacija_trenera()
                {
                    trener_id = int.Parse(dgvPopisTrenera.CurrentRow.Cells[0].Value.ToString()),
                    korisnik_id = 1,
                    datum = datum,
                    vrijeme_od = vrijemeOd,
                    duljina_rezervacije = duljinaRezervacije,
                    placeno = 0,
                    cijena = cijena
                };

                if (ProvjeraDostupnostiTrenera((int)rezervacijaTrenera.trener_id, (DateTime)rezervacijaTrenera.datum, rezervacijaTrenera.vrijeme_od, (int)rezervacijaTrenera.duljina_rezervacije))
                {
                    context.Rezervacija_trenera.Add(rezervacijaTrenera);
                    context.SaveChanges();
                    MessageBox.Show("Uspješna rezervacija!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Odabrani trener je zauzet u tom periodu.");
                }
            }
        }

        private bool ProvjeraDostupnostiTrenera(int trener_id, DateTime datum, string vrijemeOd, int duljinaRezervacije)
        {
            bool slobodan = true;
            int vrijeme = int.Parse(vrijemeOd);
            int vrijemeKraj = vrijeme + duljinaRezervacije;
            List<Rezervacija_trenera> listaRezervacija = DohvatiRezervacijeTrenera();

            foreach (Rezervacija_trenera item in listaRezervacija)
            {
                if (item.trener_id == trener_id && item.datum == datum)
                {
                    int itemVrijemeOd = int.Parse(item.vrijeme_od);
                    int itemVrijemeKraj = (int)(itemVrijemeOd + item.duljina_rezervacije);
                    if (vrijeme > itemVrijemeOd && vrijeme < itemVrijemeKraj)
                    {
                        slobodan = false;
                    }
                    if (vrijeme == itemVrijemeOd)
                    {
                        slobodan = false;
                    }
                    if (vrijemeKraj > itemVrijemeOd && vrijemeKraj < itemVrijemeKraj)
                    {
                        slobodan = false;
                    }
                }
            }

            return slobodan;
        }

        private List<Rezervacija_trenera> DohvatiRezervacijeTrenera()
        {
            using (var context = new PI2306_DBEntities())
            {
                var query = from rt in context.Rezervacija_trenera
                            select rt;

                return query.ToList();
            }
        }
    }
}
