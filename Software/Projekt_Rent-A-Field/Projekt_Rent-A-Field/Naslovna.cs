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
    public partial class Naslovna : Form
    {
        public Naslovna()
        {
            InitializeComponent();
        }

        private void buttonPopisRezervacija_Click(object sender, EventArgs e)
        {
            FrmPopisRezervacija frmPopisRezervacija = new FrmPopisRezervacija();
            frmPopisRezervacija.ShowDialog();
        }

        private void buttonPristupCjeniku_Click(object sender, EventArgs e)
        {
            CjenikFrm cjenikfrm = new CjenikFrm();
            cjenikfrm.ShowDialog();
        }

        private void buttonKreirajPrigovor_Click(object sender, EventArgs e)
        {
            ObrazacZaPrigovoreFrm forma = new ObrazacZaPrigovoreFrm();
            forma.ShowDialog();
        }

        private void buttonSortiranjePrigovora_Click(object sender, EventArgs e)
        {
            SortiranjeObrazacaFrm forma = new SortiranjeObrazacaFrm();
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GeneriranjeFrm forma = new GeneriranjeFrm();
            forma.ShowDialog();
        }
    }
}
