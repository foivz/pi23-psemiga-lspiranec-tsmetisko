using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Projekt_Rent_A_Field
{
    public partial class PojedinacanTreningProgram : Form
    {
        Trening_program ptp;
        public PojedinacanTreningProgram(Trening_program pojedinacan)
        {
            InitializeComponent();
            ptp = pojedinacan;
        }

        private void PojedinacanTreningProgram_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = ptp.naziv;
            txtTip.Text = ptp.tip_programa;
            txtOpis.Text = ptp.opis;
            txtNaziv.Enabled = false;
            txtTip.Enabled = false;
            txtOpis.Enabled = false;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
