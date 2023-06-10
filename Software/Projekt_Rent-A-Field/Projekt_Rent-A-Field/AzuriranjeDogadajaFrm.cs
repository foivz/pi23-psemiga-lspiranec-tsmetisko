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
    public partial class AzuriranjeDogadajaFrm : Form
    {
        private Dogadaj odabrani;
        public AzuriranjeDogadajaFrm(Dogadaj dogadaj)
        {
            InitializeComponent();
            odabrani = dogadaj;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var context = new PI2306_DBEntities())
            {
                string naziv = txtNaziv.Text;
                string opis = txtOpis.Text;
                int max = int.Parse(txtMAXbr.Text);

                context.Dogadajs.Attach(odabrani);

                odabrani.naziv = naziv;
                odabrani.opis = opis;
                odabrani.max_broj_sudionika = max;

                foreach (var item in context.Rezervacija_prostora)
                {
                    if (odabrani.dogadaj_id == item.dogadaj_id)
                    {
                        DateTime datum = dateTimePickerDatum.Value.Date;
                        string vrijeme = txtVrijemeOd.Text;
                        int duljina = int.Parse(txtDuljina.Text);

                        Sportski_prostor odabrani2 = comboBox1.SelectedItem as Sportski_prostor;

                        context.Rezervacija_prostora.Attach(item);

                        item.sportski_prostor_id = odabrani2.sportski_prostor_id;
                        item.datum = datum;
                        item.vrijeme_od = vrijeme;
                        item.duljina_rezervacije = duljina;

                    }
                }

                context.SaveChanges();
            }
            Close();
        }

        private void FrmAzuriranjeDogadaja_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = odabrani.naziv;
            txtOpis.Text = odabrani.opis;
            txtMAXbr.Text = odabrani.max_broj_sudionika.ToString();
            PopuniSportskeProstore();
            using (var context = new PI2306_DBEntities())
            {
                context.Dogadajs.Attach(odabrani);
                foreach (var item in context.Rezervacija_prostora)
                {
                    if (odabrani.dogadaj_id == item.dogadaj_id)
                    {
                        context.Rezervacija_prostora.Attach(item);
                        dateTimePickerDatum.Value = item.datum.Value;
                        txtVrijemeOd.Text = item.vrijeme_od;
                        txtDuljina.Text = item.duljina_rezervacije.ToString();
                        foreach (var item2 in context.Sportski_prostor)
                        {
                            if (item.sportski_prostor_id == item2.sportski_prostor_id)
                            {
                                comboBox1.Text = item2.naziv;
                            }

                        }
                    }

                }
                context.SaveChanges();
            }

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
    }
}
