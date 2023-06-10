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
    public partial class PopisTreningPrograma : Form
    {
        public PopisTreningPrograma()
        {
            InitializeComponent();
        }

        private void PopisTreningPrograma_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PrikaziPrograme();
            dataGridView1.Columns["trening_program_id"].Visible = false;
            dataGridView1.Columns["korisnik_id"].Visible = false;
            dataGridView1.Columns["Korisnik"].Visible = false;
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
            TreningProgram tp = new TreningProgram();
            tp.Show();

        }
    }
}
