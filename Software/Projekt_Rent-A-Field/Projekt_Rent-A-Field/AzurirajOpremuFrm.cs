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
    public partial class AzurirajOpremuFrm : Form
    {
        private Sportska_oprema odabranaOprema;
        public AzurirajOpremuFrm(Sportska_oprema odabranaOprema)
        {
            InitializeComponent();
            this.odabranaOprema = odabranaOprema;
        }

        private void AzurirajOpremuFrm_Load(object sender, EventArgs e)
        {
            if (odabranaOprema != null)
            {
                textBoxImeOpreme.Text = odabranaOprema.ime;
                textBoxCijenaOpreme.Text = odabranaOprema.cijena.ToString();
            }
        }

        private void buttonAzurirajOpremu_Click(object sender, EventArgs e)
        {
            if (odabranaOprema != null)
            {
                using (var context = new PI2306_DBEntities())
                {
                    Sportska_oprema sportska_Oprema = context.Sportska_oprema.Find(odabranaOprema.sportska_oprema_id);
                    if (sportska_Oprema != null)
                    {
                        sportska_Oprema.ime = textBoxImeOpreme.Text;
                        sportska_Oprema.cijena = double.Parse(textBoxCijenaOpreme.Text);

                        context.SaveChanges();
                        MessageBox.Show("Podaci opreme su ažurirani.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Odabrana oprema ne postoji u bazi podataka.");
                    }
                }
            }
        }

        private void buttonOdustaniOprema_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
