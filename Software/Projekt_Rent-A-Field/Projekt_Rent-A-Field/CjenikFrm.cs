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

        private void OpremaCjenikButton_Click(object sender, EventArgs e)
        {
            SportskaOpremaCjenikFrm sportskaOpremaForm = new SportskaOpremaCjenikFrm();
            sportskaOpremaForm.Show();
        }

        private void ProstorCjenikButton_Click(object sender, EventArgs e)
        {
            SportskiProstorCjenikFrm sportskiProstorForm = new SportskiProstorCjenikFrm();
            sportskiProstorForm.Show();
        }

        private void TreneriCjenikButton_Click(object sender, EventArgs e)
        {
            TreneriCjenikFrm treneriCjenikFrm = new TreneriCjenikFrm();
            treneriCjenikFrm.Show();
        }

        private void ZatvoriCjenikButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
