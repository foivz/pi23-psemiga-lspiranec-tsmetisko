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
    public partial class SortiranjeObrazacaFrm : Form
    {
        public SortiranjeObrazacaFrm()
        {
            InitializeComponent();
        }

        private object GetStariObrazac()
        {
            using (var context = new PI2306_DBEntities())
            {
                return context.Povratna_informacija_obrazac.ToList();
            }
        }

        public object GetNoviObrazac()
        {
            using (var context = new PI2306_DBEntities())
            {
                return context.Prihvati_prigovor.ToList();
            }
        }

        public void Osvjezi()
        {
            dataGridViewZaPregled.DataSource = GetStariObrazac();
            dataGridViewZaPregled.Columns["pi_obrazac_id"].Visible = false;
            dataGridViewZaPregled.Columns["korisnik_id"].Visible = false;
            dataGridViewZaPregled.Columns["Prihvati_prigovor"].Visible = false;
            dataGridViewZaPregled.Columns["Korisnik"].Visible = false;

            dataGridViewZavrseniObrasci.DataSource = GetNoviObrazac();
            dataGridViewZavrseniObrasci.Columns["prihvati_prigovor_id"].Visible = false;
            dataGridViewZavrseniObrasci.Columns["korisnik_id"].Visible = false;
            dataGridViewZavrseniObrasci.Columns["Korisnik"].Visible = false;
            dataGridViewZavrseniObrasci.Columns["Povratna_informacija_obrazac"].Visible = false;

        }

        private void SortiranjeObrazacaFrm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void ButtonEvidentiraj_Click(object sender, EventArgs e)
        {
            Povratna_informacija_obrazac odabraniObrazac = dataGridViewZaPregled.CurrentRow?.DataBoundItem as Povratna_informacija_obrazac;

            if (odabraniObrazac != null)
            {
                EvidentirajFrm formaEvidentiraj = new EvidentirajFrm(odabraniObrazac, dataGridViewZavrseniObrasci);
                formaEvidentiraj.ShowDialog();
            }
            Osvjezi();
        }

        private void ButtonobrisiZavrsene_Click(object sender, EventArgs e)
        {
            Prihvati_prigovor odabran = dataGridViewZavrseniObrasci.CurrentRow.DataBoundItem as Prihvati_prigovor;
            using (var context = new PI2306_DBEntities())
            {
                context.Prihvati_prigovor.Attach(odabran);
                context.Prihvati_prigovor.Remove(odabran);
                context.SaveChanges();
            }
            dataGridViewZavrseniObrasci.DataSource = GetNoviObrazac();
        }

        private void ButtonZatvoriEvidenciju_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
