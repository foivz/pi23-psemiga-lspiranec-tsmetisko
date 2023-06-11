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
    public partial class GeneriranjeQR : Form
    {
        string lozinka;
        string email;
        public GeneriranjeQR(string email_, string lozinka_)
        {
            InitializeComponent();
            email = email_;
            lozinka = lozinka_;
        }

        private void btnGeneriraj_Click(object sender, EventArgs e)
        {
            QRkod QRkod = new QRkod(email, lozinka);
            QRkod.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prijava prijava = new Prijava();
            prijava.Show();
        }
    }
}
