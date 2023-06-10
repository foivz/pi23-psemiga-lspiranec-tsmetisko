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
    public partial class CjenikFrm : Form
    {
        public CjenikFrm()
        {
            InitializeComponent();
        }

        private void ZatvoriCjenikButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpremaCjenikButton_Click(object sender, EventArgs e)
        {
            KorisnikOpremaCjenikFrm forma = new KorisnikOpremaCjenikFrm();
            forma.ShowDialog();
        }

        private void ProstorCjenikButton_Click(object sender, EventArgs e)
        {
            KorisnikProstorCjenikFrm forma = new KorisnikProstorCjenikFrm();
            forma.ShowDialog();
            
        }

        private void TreneriCjenikButton_Click(object sender, EventArgs e)
        {
            KorisnikTreneriCjenikFrm forma = new KorisnikTreneriCjenikFrm();
            forma.ShowDialog();
        }
    }
}
