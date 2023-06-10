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
    public partial class GeneriranjeFrm : Form
    {
        private List<string> namesInDataGridViewTim1;
        private List<string> namesInDataGridViewTim2;
        public GeneriranjeFrm()
        {
            InitializeComponent();
            namesInDataGridViewTim1 = new List<string>();
            namesInDataGridViewTim2 = new List<string>();
        }

        private void buttonGeneriranje_Click(object sender, EventArgs e)
        {
            namesInDataGridViewTim1.Clear();
            namesInDataGridViewTim2.Clear();

            string name1 = textBoxIme1.Text;
            string name2 = textBoxIme2.Text;
            string name3 = textBoxIme3.Text;
            string name4 = textBoxIme4.Text;
            string name5 = textBoxIme5.Text;
            string name6 = textBoxIme6.Text;
            string name7 = textBoxIme7.Text;
            string name8 = textBoxIme8.Text;
            string name9 = textBoxIme9.Text;
            string name10 = textBoxIme10.Text;
            string name11 = textBoxIme11.Text;
            string name12 = textBoxIme12.Text;

            List<string> allNames = new List<string> { name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12 };

            Random random = new Random();
            List<string> shuffledNames = allNames.OrderBy(x => random.Next()).ToList();
            int halfCount = allNames.Count / 2;
            namesInDataGridViewTim1 = shuffledNames.Take(halfCount).ToList();
            namesInDataGridViewTim2 = shuffledNames.Skip(halfCount).ToList();

            PopulateDataGridView(dataGridViewTim1, namesInDataGridViewTim1);
            PopulateDataGridView(dataGridViewTim2, namesInDataGridViewTim2);
        }

        private void PopulateDataGridView(DataGridView dataGridView, List<string> names)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add("Ime", "ime");
            dataGridView.Columns["Ime"].DataPropertyName = "Ime";

            foreach (string name in names)
            {
                dataGridView.Rows.Add(name);
            }
        }

        private void buttonZatvoriGeneriranje_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
