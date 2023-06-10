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
    public partial class PlacanjeProstoraOnline : Form
    {
        int rezervacijaId;

        public PlacanjeProstoraOnline(int rezID)
        {
            InitializeComponent();
            rezervacijaId = rezID;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPlati_Click(object sender, EventArgs e)
        {
            if (txtIme.Text != "" && txtPrezime.Text != "" && txtEmail.Text.Contains("@") && txtBrojMobitela.Text != "" && txtAdresa.Text != "" && txtGrad.Text != "" && txtPostanskiBroj.Text != "" && txtDrzava.Text != "" && txtBrojKartice.Text.Length == 16 && txtDatumIsteka.Text.Contains("/") && txtCVC.Text.Length == 3)
            {
                ProvediPlacanje(rezervacijaId);
                Close();
                MessageBox.Show("Plaćanje uspješno provedeno!");
            }
            else
            {
                MessageBox.Show("Pogrešno ste ispunili obrazac.");
            }
        }

        private void ProvediPlacanje(int rezervacijaId)
        {
            using (var context = new PI2306_DBEntities())
            {
                var query = from rp in context.Rezervacija_prostora
                            where rp.rezervacija_prostora_id == rezervacijaId
                            select rp;

                Rezervacija_prostora rezervacijaProstora = query.FirstOrDefault();
                rezervacijaProstora.placeno = 1;
                context.SaveChanges();
            }
        }
    }
}
