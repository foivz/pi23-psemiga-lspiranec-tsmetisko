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
    public partial class NoviObrazacFrm : Form
    {
        public NoviObrazacFrm()
        {
            InitializeComponent();
        }

        private void ButtonOdustaniObrazac_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonPodnesiObrazac_Click(object sender, EventArgs e)
        {
            using (var context = new PI2306_DBEntities())
            {
                Povratna_informacija_obrazac novi = new Povratna_informacija_obrazac();
                novi.tekst = TextBoxObrazacNovi.Text;
                novi.datum = dateTimePickerObrazacNovi.Value;

                context.Povratna_informacija_obrazac.Add(novi);
                context.SaveChanges();

            }
            Close();
        }
    }
}
