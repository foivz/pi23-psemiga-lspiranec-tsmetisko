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
    public partial class KorisnikOpremaCjenikFrm : Form
    {
        public KorisnikOpremaCjenikFrm()
        {
            InitializeComponent();
        }

        private void KorisnikOpremaCjenik_Load(object sender, EventArgs e)
        {
            dataGridViewKOprema.DataSource = GetOprema();
            dataGridViewKOprema.Columns["sportska_oprema_id"].Visible = false;
            dataGridViewKOprema.Columns["Rezervacija_opreme"].Visible = false;
        }

        private object GetOprema()
        {
            using (var context = new PI2306_DBEntities())
            {
                return context.Sportska_oprema.ToList();
            }
        }

        private void ZatvoriOpremuButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
