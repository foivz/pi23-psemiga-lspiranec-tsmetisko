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
    public partial class DodajOpremuFrm : Form
    {
        public DodajOpremuFrm()
        {
            InitializeComponent();
        }

        private void DodajOpremuFrm_Load(object sender, EventArgs e)
        {

        }

        private void buttonDodajOpremu_Click(object sender, EventArgs e)
        {
            using (var context = new PI2306_DBEntities())
            {
                Sportska_oprema novi = new Sportska_oprema();
                novi.ime = textBoxImeOpreme.Text;
                novi.cijena = double.Parse(textBoxCijenaOpreme.Text);

                context.Sportska_oprema.Add(novi);
                context.SaveChanges();

            }
            Close();
        }

        private void buttonOdustaniOprema_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
