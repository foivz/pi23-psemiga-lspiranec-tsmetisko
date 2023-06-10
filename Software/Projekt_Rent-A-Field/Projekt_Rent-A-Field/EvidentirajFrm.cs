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
    public partial class EvidentirajFrm : Form
    {
        private Povratna_informacija_obrazac odabraniObrazac;
        private DataGridView dataGridViewZavrseniObrasci;
        public EvidentirajFrm(Povratna_informacija_obrazac obrazac, DataGridView zavrseniObrasciDataGridView)
        {
            InitializeComponent();
            odabraniObrazac = obrazac;
            dataGridViewZavrseniObrasci = zavrseniObrasciDataGridView;
        }

        private void EvidentirajFrm_Load(object sender, EventArgs e)
        {
            if (odabraniObrazac != null)
            {

                TextBoxEvidentirajStari.Text = odabraniObrazac.tekst;
                dateTimePickerEvidentiraj.Value = odabraniObrazac.datum ?? DateTime.Now;


                TextBoxEvidentirajStari.ReadOnly = true;
                dateTimePickerEvidentiraj.Enabled = false;
            }

        }


        private void buttonPohraniEvidencija_Click(object sender, EventArgs e)
        {
            Prihvati_prigovor noviPrihvat = new Prihvati_prigovor();
            noviPrihvat.korisnik_id = odabraniObrazac.korisnik_id;
            noviPrihvat.pi_obrazac_id = odabraniObrazac.pi_obrazac_id;
            noviPrihvat.prihvaceno = radioButtonPrihvati.Checked ? 1 : 0;
            noviPrihvat.komentar = textBoxOdogovrEvidentiraj.Text;

            using (var context = new PI2306_DBEntities())
            {
                context.Prihvati_prigovor.Add(noviPrihvat);
                context.SaveChanges();
            }


            MessageBox.Show("Podaci su uspješno pohranjeni!");

            this.Close();
        }

        private object GetNoviObrazac()
        {
            using (var context = new PI2306_DBEntities())
            {
                return context.Prihvati_prigovor.ToList();
            }
        }

        private void ButtonOdustaniEvidentiraj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
