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
    public partial class KorisnikTreneriCjenikFrm : Form
    {
        public KorisnikTreneriCjenikFrm()
        {
            InitializeComponent();
        }

        private void KorisnikTreneriCjenikFrm_Load(object sender, EventArgs e)
        {
            dataGridViewKTreneri.DataSource = GetTreneri();
            dataGridViewKTreneri.Columns["datum_rodenja"].Visible = false;
            dataGridViewKTreneri.Columns["Rezervacija_trenera"].Visible = false;
        }

        private object GetTreneri()
        {
            using (var context = new PI2306_DBEntities())
            {
                return context.Treners.ToList();
            }
        }

        private void ZatvoriKProstorButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
