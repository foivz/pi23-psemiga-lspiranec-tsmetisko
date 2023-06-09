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
    public partial class TreningProgram : Form
    {
        public TreningProgram()
        {
            InitializeComponent();
            cmbTip.Items.Add("Plesni");
            cmbTip.Items.Add("Fitness");
            cmbTip.Items.Add("Sportski");
            cmbTip.Items.Add("Za djecu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TreningProgram_Load(object sender, EventArgs e)
        {
            txtVlasnik.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new PI2306_DBEntities())
            {
                string naziv = txtNaziv.Text;
                string opis = txtOpis.Text;
                int korisnik_id = 1;
                var tip_programa = this.cmbTip.GetItemText(this.cmbTip.SelectedItem);

                Trening_program trening_Program = new Trening_program()
                {
                    naziv = naziv,
                    opis = opis,
                    korisnik_id = korisnik_id,
                    tip_programa = tip_programa
                };

                if (string.IsNullOrEmpty(naziv) || string.IsNullOrEmpty(opis) || string.IsNullOrEmpty(tip_programa))
                {
                    MessageBox.Show("Niste popunili sve podatke");
                }
                else
                {
                    context.Trening_program.Add(trening_Program);
                    context.SaveChanges();
                    MessageBox.Show("Uspješno dodan trening!");
                    Close();
                }

            }
        }
    }
}
