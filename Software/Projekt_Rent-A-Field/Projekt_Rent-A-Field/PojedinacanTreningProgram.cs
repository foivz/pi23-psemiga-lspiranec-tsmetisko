using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
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
        public static string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\file.txt";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Spremi();
        }
        public void Spremi()
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to save file?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (txtNaziv.Text != null && txtOpis.Text != null && txtTip.Text != null)
                    {
                        spremi(txtNaziv.Text, txtOpis.Text, txtTip.Text);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }
        public void spremi(string naziv, string opis, string tip)
        {
            string Msg = naziv + ";" + opis + ";" + tip;

            // Save File to .txt
            FileStream fParameter = new FileStream(dirParameter, FileMode.Create, FileAccess.Write);
            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            m_WriterParameter.Write(Msg);
            m_WriterParameter.Flush();
            m_WriterParameter.Close();
        }
    }
}
