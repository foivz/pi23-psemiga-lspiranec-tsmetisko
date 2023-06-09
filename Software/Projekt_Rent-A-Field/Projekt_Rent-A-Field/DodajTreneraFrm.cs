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
    public partial class DodajTreneraFrm : Form
    {
        public DodajTreneraFrm()
        {
            InitializeComponent();
        }

        private void DodajTreneraFrm_Load(object sender, EventArgs e)
        {

        }

        private void buttonDodajTrenera_Click(object sender, EventArgs e)
        {
            using (var context = new PI2306_DBEntities())
            {
                Trener novi = new Trener();
                novi.ime_prezime = textBoxImePrezime.Text;
                novi.podrucje_interesa = textBoxPodrucjeInteresa.Text;
                novi.cijena_po_satu = double.Parse(textBoxCijenaPoSatu.Text);

                context.Treners.Add(novi);
                context.SaveChanges();

            }
            Close();
        }

        private void buttonOdustaniTrener_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
