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
    public partial class KorisnikProstorCjenikFrm : Form
    {
        public KorisnikProstorCjenikFrm()
        {
            InitializeComponent();
        }

        private object GetProstor()
        {
            using (var context = new PI2306_DBEntities())
            {
                return context.Sportski_prostor.ToList();
            }
        }

        private void KorisnikProstorCjenik_Load(object sender, EventArgs e)
        {
            dataGridViewKProstor.DataSource = GetProstor();
            dataGridViewKProstor.Columns["sportski_prostor_id"].Visible = false;
            dataGridViewKProstor.Columns["Rezervacija_prostora"].Visible = false;
        }

        private void ZatvoriProstorButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
