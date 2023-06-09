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
    public partial class RezervacijaSportskogProstoraFrm : Form
    {
        public RezervacijaSportskogProstoraFrm()
        {
            InitializeComponent();
        }

        private void RezervacijaSportskogProstoraFrm_Load(object sender, EventArgs e)
        {
            dgvPopisProstora.DataSource = DohvatiProstore();
            dgvPopisProstora.Columns["Rezervacija_prostora"].Visible = false;
            dgvPopisProstora.Columns["sportski_prostor_id"].Visible = false;
        }

        private List<Sportski_prostor> DohvatiProstore()
        {
            using (var context = new PI2306_DBEntities())
            {
                var query = from sp in context.Sportski_prostor
                            select sp;

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
                DateTime datum = dtpRezervacijaProstora.Value.Date;
                string vrijemeOd = txtVrijemeOd.Text;
                int duljinaRezervacije = int.Parse(txtDuljinaRezervacije.Text);

                float cijenaPoSatu = int.Parse(dgvPopisProstora.CurrentRow.Cells[3].Value.ToString());
                float cijena = cijenaPoSatu * duljinaRezervacije;

                Rezervacija_prostora rezervacijaProstora = new Rezervacija_prostora()
                {
                    sportski_prostor_id = int.Parse(dgvPopisProstora.CurrentRow.Cells[0].Value.ToString()),
                    korisnik_id = 1,
                    datum = datum,
                    vrijeme_od = vrijemeOd,
                    duljina_rezervacije = duljinaRezervacije,
                    placeno = 0,
                    cijena = cijena
                };

                if (ProvjeraDostupnostiProstora((int)rezervacijaProstora.sportski_prostor_id, (DateTime)rezervacijaProstora.datum, rezervacijaProstora.vrijeme_od, (int)rezervacijaProstora.duljina_rezervacije))
                {
                    context.Rezervacija_prostora.Add(rezervacijaProstora);
                    context.SaveChanges();
                    MessageBox.Show("Uspješna rezervacija!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Odabrani prostor je zauzet u odabanom vremenu!");
                }
            }
        }

        private bool ProvjeraDostupnostiProstora(int sportski_prostor_id, DateTime datum, string vrijemeOd, int duljinaRezervacije)
        {
            bool slobodan = true;
            int vrijeme = int.Parse(vrijemeOd);
            int vrijemeKraj = vrijeme + duljinaRezervacije;
            List<Rezervacija_prostora> listaRezervacija = DohvatiRezervacijaProstora();

            foreach (Rezervacija_prostora item in listaRezervacija)
            {
                if (item.sportski_prostor_id == sportski_prostor_id && item.datum == datum)
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

        private List<Rezervacija_prostora> DohvatiRezervacijaProstora()
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
