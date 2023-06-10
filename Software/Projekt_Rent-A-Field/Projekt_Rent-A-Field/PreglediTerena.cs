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
    public partial class PreglediTerena : Form
    {
        List<Rezervacija_prostora> listaRezervacija = new List<Rezervacija_prostora>();
        List<Sportski_prostor> listaProstora = new List<Sportski_prostor>();
        public PreglediTerena()
        {
            InitializeComponent();
            dgvProstori.DataSource = PrikaziProstore();
            dgvProstori.Columns["Sportski_prostor_id"].Visible = false;
            dgvProstori.Columns["adresa"].Visible = false;
            dgvProstori.Columns["cijena"].Visible = false;
            dgvProstori.Columns["Rezervacija_prostora"].Visible = false;
        }
        public List<Sportski_prostor> PrikaziProstore()
        {

            using (var context = new PI2306_DBEntities())
            {

                var query = from s in context.Sportski_prostor
                            select s;


                listaProstora = query.ToList();
                return listaProstora;
            }
        }
        public List<Rezervacija_prostora> PrikaziRezervacije()
        {

            using (var context = new PI2306_DBEntities())
            {

                var query = from rp in context.Rezervacija_prostora
                            select rp;

                listaRezervacija = query.ToList();
                return listaRezervacija;
            }
        }

        private void btnDostupnost_Click(object sender, EventArgs e)
        {
            DateTime odabraniDatum = dtpDatumDostupnosti.Value.Date;
            string vrijemeOd = txtVrijemeDostupnosti.Text;
            List<Sportski_prostor> listaProstora = PrikaziProstore();
            List<Rezervacija_prostora> listaRezervacija = PrikaziRezervacije();
            List<Sportski_prostor> slobodniProstori = new List<Sportski_prostor>();

            foreach (Rezervacija_prostora item2 in listaRezervacija.ToList())
            {
                if (vrijemeOd == item2.vrijeme_od && odabraniDatum == item2.datum)
                {
                    foreach (Sportski_prostor item3 in listaProstora.ToList())
                    {
                        if (item2.sportski_prostor_id == item3.sportski_prostor_id)
                        {
                            listaProstora.Remove(item3);
                        }
                    }
                }
            }

            dgvProstori.DataSource = listaProstora.ToList();
        }

        private void btnSve_Click(object sender, EventArgs e)
        {
            dgvProstori.DataSource = PrikaziProstore();
            dgvProstori.Columns["Sportski_prostor_id"].Visible = false;
            dgvProstori.Columns["adresa"].Visible = false;
            dgvProstori.Columns["cijena"].Visible = false;
            dgvProstori.Columns["Rezervacija_prostora"].Visible = false;
        }

        private void dgvProstori_SelectionChanged(object sender, EventArgs e)
        {
            Sportski_prostor odabrani = dgvProstori.CurrentRow.DataBoundItem as Sportski_prostor;
            if (odabrani != null)
            {
                txtNaziv.Text = odabrani.naziv.ToString();
                txtAdresa.Text = odabrani.adresa.ToString();
                txtCijena.Text = odabrani.cijena.ToString();
                txtNaziv.Enabled = false;
                txtAdresa.Enabled = false;
                txtCijena.Enabled = false;
            }
        }
    }
}
