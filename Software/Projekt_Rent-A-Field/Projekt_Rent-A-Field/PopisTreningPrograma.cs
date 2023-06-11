using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Rent_A_Field
{
    public partial class PopisTreningPrograma : Form
    {
        int korisnikID;
        public PopisTreningPrograma(int korID)
        {
            InitializeComponent();
            korisnikID = korID;
        }

        private void PopisTreningPrograma_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PrikaziPrograme();
            dataGridView1.Columns["trening_program_id"].Visible = false;
            dataGridView1.Columns["korisnik_id"].Visible = false;
            dataGridView1.Columns["Korisnik"].Visible = false;
            textBox1.Text = korisnikID.ToString();
            textBox1.Enabled = false;
        }
        private List<Trening_program> PrikaziPrograme()
        {
            using (var context = new PI2306_DBEntities())
            {
                var query = from tp in context.Trening_program
                            select tp;

                return query.ToList();
            }
        }

        private void btnIzadi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrikaziPojedinosti_Click(object sender, EventArgs e)
        {
            Trening_program odabrani = dataGridView1.CurrentRow.DataBoundItem as Trening_program;
            PojedinacanTreningProgram ptp = new PojedinacanTreningProgram(odabrani);
            ptp.Show();
        }

        private void btnVlastiti_Click(object sender, EventArgs e)
        {
            TreningProgram tp = new TreningProgram(korisnikID);
            tp.Show();
            PrikaziSve();
        }
        private void PrikaziSve()
        {
            using (var context = new PI2306_DBEntities())
            {

                var query = from tp in context.Trening_program
                            select tp;

                dataGridView1.DataSource = query.ToList();

            }
            dataGridView1.Columns["trening_program_id"].Visible = false;
            dataGridView1.Columns["korisnik_id"].Visible = false;
            dataGridView1.Columns["Korisnik"].Visible = false;
        }

        private void buttonOsvjezi_Click(object sender, EventArgs e)
        {
            PrikaziSve();
        }
    }
}
