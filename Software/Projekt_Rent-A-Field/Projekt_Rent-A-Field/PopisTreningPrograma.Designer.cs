namespace Projekt_Rent_A_Field
{
    partial class PopisTreningPrograma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIzadi = new System.Windows.Forms.Button();
            this.btnPrikaziPojedinosti = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVlastiti = new System.Windows.Forms.Button();
            this.buttonOsvjezi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzadi
            // 
            this.btnIzadi.Location = new System.Drawing.Point(12, 39);
            this.btnIzadi.Name = "btnIzadi";
            this.btnIzadi.Size = new System.Drawing.Size(148, 36);
            this.btnIzadi.TabIndex = 5;
            this.btnIzadi.Text = "Izađi iz prikaza";
            this.btnIzadi.UseVisualStyleBackColor = true;
            this.btnIzadi.Click += new System.EventHandler(this.btnIzadi_Click);
            // 
            // btnPrikaziPojedinosti
            // 
            this.btnPrikaziPojedinosti.Location = new System.Drawing.Point(12, 350);
            this.btnPrikaziPojedinosti.Name = "btnPrikaziPojedinosti";
            this.btnPrikaziPojedinosti.Size = new System.Drawing.Size(148, 48);
            this.btnPrikaziPojedinosti.TabIndex = 4;
            this.btnPrikaziPojedinosti.Text = "Prikazi pojedinosti";
            this.btnPrikaziPojedinosti.UseVisualStyleBackColor = true;
            this.btnPrikaziPojedinosti.Click += new System.EventHandler(this.btnPrikaziPojedinosti_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(587, 263);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnVlastiti
            // 
            this.btnVlastiti.Location = new System.Drawing.Point(239, 350);
            this.btnVlastiti.Name = "btnVlastiti";
            this.btnVlastiti.Size = new System.Drawing.Size(148, 48);
            this.btnVlastiti.TabIndex = 6;
            this.btnVlastiti.Text = "Izradi vlastiti";
            this.btnVlastiti.UseVisualStyleBackColor = true;
            this.btnVlastiti.Click += new System.EventHandler(this.btnVlastiti_Click);
            // 
            // buttonOsvjezi
            // 
            this.buttonOsvjezi.Location = new System.Drawing.Point(451, 350);
            this.buttonOsvjezi.Name = "buttonOsvjezi";
            this.buttonOsvjezi.Size = new System.Drawing.Size(148, 48);
            this.buttonOsvjezi.TabIndex = 7;
            this.buttonOsvjezi.Text = "Osvježi prikaz";
            this.buttonOsvjezi.UseVisualStyleBackColor = true;
            this.buttonOsvjezi.Click += new System.EventHandler(this.buttonOsvjezi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(499, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // PopisTreningPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(611, 437);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonOsvjezi);
            this.Controls.Add(this.btnVlastiti);
            this.Controls.Add(this.btnIzadi);
            this.Controls.Add(this.btnPrikaziPojedinosti);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PopisTreningPrograma";
            this.Text = "PopisTreningPrograma";
            this.Load += new System.EventHandler(this.PopisTreningPrograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzadi;
        private System.Windows.Forms.Button btnPrikaziPojedinosti;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVlastiti;
        private System.Windows.Forms.Button buttonOsvjezi;
        private System.Windows.Forms.TextBox textBox1;
    }
}