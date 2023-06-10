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
    public partial class EvidencijaTerminaFrm : Form
    {
        private int korisnikID;
        public EvidencijaTerminaFrm(int korisnikID)
        {
            InitializeComponent();
            this.korisnikID = korisnikID;
        }

        private object GetEvidencijaProstora()
        {
            using (var context = new PI2306_DBEntities())
            {
                var rezultat = context.Rezervacija_prostora
                        .Where(r => r.korisnik_id == korisnikID)
                        .ToList();
                return rezultat;
            }

        }
        private object GetRezultati()
        {
            using (var context = new PI2306_DBEntities())
            {
                return context.Rezultats.ToList();
            }

        }

        private void EvidencijaTerminaFrm_Load(object sender, EventArgs e)
        {
            dataGridViewEvidentirajRezultat.DataSource = GetEvidencijaProstora();

            dataGridViewEvidentirajRezultat.Columns["sportski_prostor_id"].Visible = false;
            dataGridViewEvidentirajRezultat.Columns["placeno"].Visible = false;
            dataGridViewEvidentirajRezultat.Columns["cijena"].Visible = false;
            dataGridViewEvidentirajRezultat.Columns["dogadaj_id"].Visible = false;
            dataGridViewEvidentirajRezultat.Columns["Dogadaj"].Visible = false;
            dataGridViewEvidentirajRezultat.Columns["Korisnik"].Visible = false;
            dataGridViewEvidentirajRezultat.Columns["Sportski_prostor"].Visible = false;
            dataGridViewEvidentirajRezultat.Columns["duljina_rezervacije"].Visible = false;
            dataGridViewEvidentirajRezultat.Columns["vrijeme_od"].Visible = false;
            dataGridViewEvidentirajRezultat.Columns["Rezultats"].Visible = false;

        }

        private void buttonEvidentirajRezultat_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvidentirajRezultat.SelectedRows.Count > 0)
            {
                var rezervacijaProstora = (Rezervacija_prostora)dataGridViewEvidentirajRezultat.SelectedRows[0].DataBoundItem;

                UnesiRezultatFrm forma = new UnesiRezultatFrm(rezervacijaProstora);
                forma.textBoxTerminIdForm.Text = rezervacijaProstora.rezervacija_prostora_id.ToString();
                forma.textBoxTerminIdForm.Enabled = false;

                forma.ShowDialog();

                dataGridViewEvidentirajRezultat.DataSource = GetEvidencijaProstora();
            }
            else
            {
                MessageBox.Show("Odaberite rezervaciju za koju želite unijeti rezultat!");
            }
        }

        private void dataGridViewEvidentirajRezultat_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected)
                return;

            if (e.Row.Index >= 0 && e.Row.Index < dataGridViewEvidentirajRezultat.Rows.Count)
            {
                DataGridViewRow selectedRow = e.Row;
                int rezervacijaProstoraId = (int)selectedRow.Cells["rezervacija_prostora_id"].Value;

                using (var context = new PI2306_DBEntities())
                {
                    var rezultat = context.Rezultats
                        .Where(r => r.rezervacija_prostora_id == rezervacijaProstoraId)
                        .Select(r => new
                        {
                            r.rezultat_id,
                            r.sport,
                            r.rezultat1,
                            r.rezervacija_prostora_id,
                        })
                        .ToList();


                    if (rezultat != null && rezultat.Count > 0)
                    {
                        dataGridViewPrikaziRezultat.DataSource = rezultat;
                    }
                    else
                    {
                        if (dataGridViewPrikaziRezultat.DataSource != null)
                        {
                            dataGridViewPrikaziRezultat.DataSource = null;
                        }
                    }
                }
            }
        }

        private void buttonZatvoriEvidencijuRezultat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
