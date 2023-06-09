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
    public partial class ObrazacZaPrigovoreFrm : Form
    {
        public ObrazacZaPrigovoreFrm()
        {
            InitializeComponent();
        }

        private object GetObrazac()
        {
            using (var context = new PI2306_DBEntities())
            {
                return context.Povratna_informacija_obrazac.ToList();
            }
        }

        private object GetZavrsenObrazac()
        {
            using (var context = new PI2306_DBEntities())
            {
                return context.Prihvati_prigovor.ToList();
            }
        }

        private void ObrazacZaPrigovoreFrm_Load(object sender, EventArgs e)
        {
            dataGridViewObrazac.DataSource = GetObrazac();
            dataGridViewObrazac.Columns["pi_obrazac_id"].Visible = false;
            dataGridViewObrazac.Columns["korisnik_id"].Visible = false;
            dataGridViewObrazac.Columns["Prihvati_prigovor"].Visible = false;

            dataGridViewZavrseniObrazac.DataSource = GetZavrsenObrazac();
            dataGridViewZavrseniObrazac.Columns["prihvati_prigovor_id"].Visible = false;
            dataGridViewZavrseniObrazac.Columns["korisnik_id"].Visible = false;
            dataGridViewZavrseniObrazac.Columns["Korisnik"].Visible = false;
            dataGridViewZavrseniObrazac.Columns["Povratna_informacija_obrazac"].Visible = false;
        }

        private void ButtonZatvoriObrazac_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonKreirajObrazac_Click(object sender, EventArgs e)
        {
            NoviObrazacFrm forma = new NoviObrazacFrm();
            forma.ShowDialog();
            dataGridViewObrazac.DataSource = GetObrazac();
        }
    }
}
