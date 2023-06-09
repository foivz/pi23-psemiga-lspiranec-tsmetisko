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
    public partial class RezervacijaSportskeOpremeFrm : Form
    {
        public RezervacijaSportskeOpremeFrm()
        {
            InitializeComponent();
        }

        private void RezervacijaSportskeOpremeFrm_Load(object sender, EventArgs e)
        {
            PrikaziSportskuOpremu();
        }

        private void PrikaziSportskuOpremu()
        {
            using (var context = new PI2306_DBEntities())
            {
                var query = from so in context.Sportska_oprema
                            select so;

                dgvSportskaOprema.DataSource = query.ToList();
                dgvSportskaOprema.Columns["Rezervacija_opreme"].Visible = false;
                dgvSportskaOprema.Columns["sportska_oprema_id"].Visible = false;
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            if (txtVrijemeOd.Text != "" && txtDuljinaRezervacije.Text != "") {
                using (var context = new PI2306_DBEntities())
                {
                    DateTime datum = dtpDatumRezervacije.Value.Date;
                    string vrijemeOd = txtVrijemeOd.Text;
                    int duljinaRezervacije = int.Parse(txtDuljinaRezervacije.Text);

                    float cijenaOpreme = float.Parse(dgvSportskaOprema.CurrentRow.Cells[2].Value.ToString());
                    float cijena = duljinaRezervacije * cijenaOpreme;


                    Rezervacija_opreme rezervacijaOpreme = new Rezervacija_opreme()
                    {
                        sportska_oprema_id = int.Parse(dgvSportskaOprema.CurrentRow.Cells[0].Value.ToString()),
                        korisnik_id = 1,
                        datum = datum,
                        vrijeme_od = vrijemeOd,
                        duljina_rezervacije = duljinaRezervacije,
                        placeno = 0,
                        cijena = cijena
                    };

                    context.Rezervacija_opreme.Add(rezervacijaOpreme);
                    context.SaveChanges();
                    MessageBox.Show("Uspješna rezervacija!");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Molimo unesite vrijeme za koje želite rezervirati dodatku sportsku opremu.");
            }
        }
    }
}
