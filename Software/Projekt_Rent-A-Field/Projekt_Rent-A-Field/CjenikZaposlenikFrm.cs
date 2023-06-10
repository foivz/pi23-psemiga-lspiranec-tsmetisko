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
    public partial class CjenikZaposlenikFrm : Form
    {
        public CjenikZaposlenikFrm()
        {
            InitializeComponent();
        }

        private void OpremaCjenikButton_Click(object sender, EventArgs e)
        {
            SportskaOpremaCjenikFrm forma = new SportskaOpremaCjenikFrm();
            forma.ShowDialog();
        }

        private void ProstorCjenikButton_Click(object sender, EventArgs e)
        {
            SportskiProstorCjenikFrm forma = new SportskiProstorCjenikFrm();
            forma.ShowDialog();
        }

        private void TreneriCjenikButton_Click(object sender, EventArgs e)
        {
            TreneriCjenikFrm forma = new TreneriCjenikFrm();
            forma.ShowDialog();
        }
    }
}
