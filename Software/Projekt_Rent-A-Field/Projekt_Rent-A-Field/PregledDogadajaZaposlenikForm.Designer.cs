namespace Projekt_Rent_A_Field
{
    partial class PregledDogadajaZaposlenikForm
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
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPoProstoru = new System.Windows.Forms.Button();
            this.cmbProstor = new System.Windows.Forms.ComboBox();
            this.btnDatum = new System.Windows.Forms.Button();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.dgvRezervacija = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacija)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(93, 302);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(75, 48);
            this.btnAzuriraj.TabIndex = 27;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(174, 302);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 48);
            this.btnIzbrisi.TabIndex = 26;
            this.btnIzbrisi.Text = "Izbrisi";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 302);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 48);
            this.btnDodaj.TabIndex = 25;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPoProstoru
            // 
            this.btnPoProstoru.Location = new System.Drawing.Point(604, 19);
            this.btnPoProstoru.Name = "btnPoProstoru";
            this.btnPoProstoru.Size = new System.Drawing.Size(132, 20);
            this.btnPoProstoru.TabIndex = 24;
            this.btnPoProstoru.Text = "Prikazi po prostoru";
            this.btnPoProstoru.UseVisualStyleBackColor = true;
            this.btnPoProstoru.Click += new System.EventHandler(this.btnPoProstoru_Click);
            // 
            // cmbProstor
            // 
            this.cmbProstor.FormattingEnabled = true;
            this.cmbProstor.Location = new System.Drawing.Point(398, 18);
            this.cmbProstor.Name = "cmbProstor";
            this.cmbProstor.Size = new System.Drawing.Size(198, 21);
            this.cmbProstor.TabIndex = 23;
            // 
            // btnDatum
            // 
            this.btnDatum.Location = new System.Drawing.Point(165, 19);
            this.btnDatum.Name = "btnDatum";
            this.btnDatum.Size = new System.Drawing.Size(132, 20);
            this.btnDatum.TabIndex = 22;
            this.btnDatum.Text = "Prikazi po datumu";
            this.btnDatum.UseVisualStyleBackColor = true;
            this.btnDatum.Click += new System.EventHandler(this.btnDatum_Click);
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Location = new System.Drawing.Point(12, 272);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(132, 20);
            this.btnPrikaziSve.TabIndex = 21;
            this.btnPrikaziSve.Text = "Prikazi sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = true;
            this.btnPrikaziSve.Click += new System.EventHandler(this.btnPrikaziSve_Click);
            // 
            // dgvRezervacija
            // 
            this.dgvRezervacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacija.Location = new System.Drawing.Point(12, 45);
            this.dgvRezervacija.Name = "dgvRezervacija";
            this.dgvRezervacija.Size = new System.Drawing.Size(724, 221);
            this.dgvRezervacija.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // PregledDogadajaZaposlenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnPoProstoru);
            this.Controls.Add(this.cmbProstor);
            this.Controls.Add(this.btnDatum);
            this.Controls.Add(this.btnPrikaziSve);
            this.Controls.Add(this.dgvRezervacija);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "PregledDogadajaZaposlenikForm";
            this.Text = "PregledDogadajaZaposlenikForm";
            this.Load += new System.EventHandler(this.PregledDogadajaZaposlenikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacija)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPoProstoru;
        private System.Windows.Forms.ComboBox cmbProstor;
        private System.Windows.Forms.Button btnDatum;
        private System.Windows.Forms.Button btnPrikaziSve;
        private System.Windows.Forms.DataGridView dgvRezervacija;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}