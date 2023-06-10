namespace Projekt_Rent_A_Field
{
    partial class PregledDogadajaFrm
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
            this.btnPoProstoru = new System.Windows.Forms.Button();
            this.cmbProstor = new System.Windows.Forms.ComboBox();
            this.btnDatum = new System.Windows.Forms.Button();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.dgvRezervacija = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacija)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPoProstoru
            // 
            this.btnPoProstoru.Location = new System.Drawing.Point(604, 15);
            this.btnPoProstoru.Name = "btnPoProstoru";
            this.btnPoProstoru.Size = new System.Drawing.Size(132, 20);
            this.btnPoProstoru.TabIndex = 15;
            this.btnPoProstoru.Text = "Prikazi po prostoru";
            this.btnPoProstoru.UseVisualStyleBackColor = true;
            // 
            // cmbProstor
            // 
            this.cmbProstor.FormattingEnabled = true;
            this.cmbProstor.Location = new System.Drawing.Point(398, 14);
            this.cmbProstor.Name = "cmbProstor";
            this.cmbProstor.Size = new System.Drawing.Size(198, 21);
            this.cmbProstor.TabIndex = 14;
            // 
            // btnDatum
            // 
            this.btnDatum.Location = new System.Drawing.Point(165, 15);
            this.btnDatum.Name = "btnDatum";
            this.btnDatum.Size = new System.Drawing.Size(132, 20);
            this.btnDatum.TabIndex = 13;
            this.btnDatum.Text = "Prikazi po datumu";
            this.btnDatum.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Location = new System.Drawing.Point(12, 268);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(132, 20);
            this.btnPrikaziSve.TabIndex = 12;
            this.btnPrikaziSve.Text = "Prikazi sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = true;
            // 
            // dgvRezervacija
            // 
            this.dgvRezervacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacija.Location = new System.Drawing.Point(12, 41);
            this.dgvRezervacija.Name = "dgvRezervacija";
            this.dgvRezervacija.Size = new System.Drawing.Size(724, 221);
            this.dgvRezervacija.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // PregledDogadajaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(760, 301);
            this.Controls.Add(this.btnPoProstoru);
            this.Controls.Add(this.cmbProstor);
            this.Controls.Add(this.btnDatum);
            this.Controls.Add(this.btnPrikaziSve);
            this.Controls.Add(this.dgvRezervacija);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "PregledDogadajaFrm";
            this.Text = "PregledDogadajaFrm";
            this.Load += new System.EventHandler(this.PregledDogadajaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacija)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPoProstoru;
        private System.Windows.Forms.ComboBox cmbProstor;
        private System.Windows.Forms.Button btnDatum;
        private System.Windows.Forms.Button btnPrikaziSve;
        private System.Windows.Forms.DataGridView dgvRezervacija;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}