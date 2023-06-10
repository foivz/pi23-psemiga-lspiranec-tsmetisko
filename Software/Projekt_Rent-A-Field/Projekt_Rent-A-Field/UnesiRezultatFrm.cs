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
    public partial class UnesiRezultatFrm : Form
    {
        private Rezervacija_prostora rezervacijaProstora;
        public TextBox textBoxTerminIdForm;
        public UnesiRezultatFrm(Rezervacija_prostora rezervacijaProstora)
        {
            InitializeComponent();
            this.rezervacijaProstora = rezervacijaProstora;
            textBoxTerminIdForm = new TextBox();
        }

        private void buttonOdustaniUnosRezultata_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UnesiRezultatFrm_Load(object sender, EventArgs e)
        {
            textBoxTerminId.Text = rezervacijaProstora.rezervacija_prostora_id.ToString();
            textBoxTerminId.Enabled = false;
        }

        private void buttonSpremiUnosRezultata_Click(object sender, EventArgs e)
        {
            using (var context = new PI2306_DBEntities())
            {
                int rezervacijaProstoraId = Convert.ToInt32(textBoxTerminId.Text);

                Rezultat novi = new Rezultat();
                novi.rezervacija_prostora_id = rezervacijaProstoraId;
                novi.sport = textBoxSport.Text;
                novi.rezultat1 = textBoxRezultat.Text;

                context.Rezultats.Add(novi);
                context.SaveChanges();
            }

            MessageBox.Show("Rezultat je uspješno spremljen!");
            this.Close();
        }
    }
}
