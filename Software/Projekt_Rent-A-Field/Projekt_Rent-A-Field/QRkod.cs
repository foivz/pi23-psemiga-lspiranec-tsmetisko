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
    public partial class QRkod : Form
    {
        string lozinka;
        string email;
        public QRkod(string mail, string loZ)
        {
            InitializeComponent();
            email = mail;
            lozinka = loZ;
        }

        private void QRkod_Load(object sender, EventArgs e)
        {
            textBox1.Text = "email:" + email + " lozinka:" + lozinka;
            textBox1.Enabled = false;
        }

        private void btnGeneriraj_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(textBox1.Text, 70);
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveFileDialog.FileName);
                    MessageBox.Show("Uspješno ste spremili QR kod");
                }
            }
        }
    }
}
