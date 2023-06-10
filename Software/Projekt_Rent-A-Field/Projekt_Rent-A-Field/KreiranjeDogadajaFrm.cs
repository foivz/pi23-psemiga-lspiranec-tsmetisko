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
    public partial class KreiranjeDogadajaFrm : Form
    {
        public KreiranjeDogadajaFrm()
        {
            InitializeComponent();
        }

        private void KreiranjeDogadajaFrm_Load(object sender, EventArgs e)
        {
            PopuniSportskeProstore();
        }

        private object PopuniSportskeProstore()
        {
            using (var context = new PI2306_DBEntities())
            {
                comboBox1.DataSource = context.Sportski_prostor.ToList();
            }
            return comboBox1.DataSource;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var context = new PI2306_DBEntities())
            {
                string naziv = txtNaziv.Text;
                string opis = txtOpis.Text;
                int max = int.Parse(txtMAXbr.Text);

                Dogadaj dogadaj = new Dogadaj()
                {
                    naziv = naziv,
                    opis = opis,
                    max_broj_sudionika = max
                };

                context.Dogadajs.Add(dogadaj);

                DateTime datum = dateTimePickerDatum.Value.Date;
                string vrijeme = txtVrijemeOd.Text;
                int duljina = int.Parse(txtDuljina.Text);
                Sportski_prostor odabrani = comboBox1.SelectedItem as Sportski_prostor;

                Rezervacija_prostora rezervacija_prostora = new Rezervacija_prostora()
                {
                    sportski_prostor_id = odabrani.sportski_prostor_id,
                    datum = datum,
                    vrijeme_od = vrijeme,
                    duljina_rezervacije = duljina,
                    dogadaj_id = dogadaj.dogadaj_id
                };
                context.Rezervacija_prostora.Add(rezervacija_prostora);
                context.SaveChanges();
            }
            Close();
        }
}
}
