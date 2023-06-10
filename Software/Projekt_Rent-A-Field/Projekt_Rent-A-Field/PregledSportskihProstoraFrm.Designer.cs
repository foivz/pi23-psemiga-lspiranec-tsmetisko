namespace Projekt_Rent_A_Field
{
    partial class PregledSportskihProstoraFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvSportskiProstori = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportskiProstori)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sportski prostori:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(249, 280);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(194, 36);
            this.btnOdustani.TabIndex = 10;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(249, 238);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(194, 36);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(12, 280);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(194, 36);
            this.btnAzuriraj.TabIndex = 8;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 238);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(194, 36);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvSportskiProstori
            // 
            this.dgvSportskiProstori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSportskiProstori.Location = new System.Drawing.Point(12, 36);
            this.dgvSportskiProstori.Name = "dgvSportskiProstori";
            this.dgvSportskiProstori.Size = new System.Drawing.Size(431, 196);
            this.dgvSportskiProstori.TabIndex = 6;
            // 
            // PregledSportskihProstoraFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(480, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvSportskiProstori);
            this.Name = "PregledSportskihProstoraFrm";
            this.Text = "PregledSportskihProstoraFrm";
            this.Load += new System.EventHandler(this.PregledSportskihProstoraFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportskiProstori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvSportskiProstori;
    }
}