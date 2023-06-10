namespace Projekt_Rent_A_Field
{
    partial class PreglediTerena
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
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSve = new System.Windows.Forms.Button();
            this.btnDostupnost = new System.Windows.Forms.Button();
            this.txtVrijemeDostupnosti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatumDostupnosti = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProstori = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProstori)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(80, 451);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(85, 22);
            this.txtCijena.TabIndex = 35;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(80, 422);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(252, 22);
            this.txtAdresa.TabIndex = 34;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(80, 389);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(252, 22);
            this.txtNaziv.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Cijena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Adresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Naziv:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "informacije o odabranom prostoru:\r\n";
            // 
            // btnSve
            // 
            this.btnSve.ForeColor = System.Drawing.Color.Black;
            this.btnSve.Location = new System.Drawing.Point(12, 263);
            this.btnSve.Name = "btnSve";
            this.btnSve.Size = new System.Drawing.Size(436, 64);
            this.btnSve.TabIndex = 28;
            this.btnSve.Text = "Prikazi sve";
            this.btnSve.UseVisualStyleBackColor = true;
            this.btnSve.Click += new System.EventHandler(this.btnSve_Click);
            // 
            // btnDostupnost
            // 
            this.btnDostupnost.ForeColor = System.Drawing.Color.Black;
            this.btnDostupnost.Location = new System.Drawing.Point(272, 182);
            this.btnDostupnost.Name = "btnDostupnost";
            this.btnDostupnost.Size = new System.Drawing.Size(164, 47);
            this.btnDostupnost.TabIndex = 27;
            this.btnDostupnost.Text = "Provjeri dostupnost";
            this.btnDostupnost.UseVisualStyleBackColor = true;
            this.btnDostupnost.Click += new System.EventHandler(this.btnDostupnost_Click);
            // 
            // txtVrijemeDostupnosti
            // 
            this.txtVrijemeDostupnosti.Location = new System.Drawing.Point(272, 135);
            this.txtVrijemeDostupnosti.Name = "txtVrijemeDostupnosti";
            this.txtVrijemeDostupnosti.Size = new System.Drawing.Size(164, 22);
            this.txtVrijemeDostupnosti.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Od (sati):";
            // 
            // dtpDatumDostupnosti
            // 
            this.dtpDatumDostupnosti.Location = new System.Drawing.Point(272, 69);
            this.dtpDatumDostupnosti.Name = "dtpDatumDostupnosti";
            this.dtpDatumDostupnosti.Size = new System.Drawing.Size(164, 22);
            this.dtpDatumDostupnosti.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Odaberite datum za koji\r\nželite provjeriti dostupnost:\r\n";
            // 
            // dgvProstori
            // 
            this.dgvProstori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProstori.Location = new System.Drawing.Point(12, 23);
            this.dgvProstori.Name = "dgvProstori";
            this.dgvProstori.RowHeadersWidth = 51;
            this.dgvProstori.RowTemplate.Height = 24;
            this.dgvProstori.Size = new System.Drawing.Size(243, 225);
            this.dgvProstori.TabIndex = 22;
            this.dgvProstori.SelectionChanged += new System.EventHandler(this.dgvProstori_SelectionChanged);
            // 
            // PreglediTerena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(475, 519);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSve);
            this.Controls.Add(this.btnDostupnost);
            this.Controls.Add(this.txtVrijemeDostupnosti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatumDostupnosti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProstori);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PreglediTerena";
            this.Text = "PreglediTerena";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProstori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSve;
        private System.Windows.Forms.Button btnDostupnost;
        private System.Windows.Forms.TextBox txtVrijemeDostupnosti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatumDostupnosti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProstori;
    }
}