namespace Projekt_Rent_A_Field
{
    partial class RezervacijaSportskeOpremeFrm
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.txtDuljinaRezervacije = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVrijemeOd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatumRezervacije = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSportskaOprema = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportskaOprema)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.ForeColor = System.Drawing.Color.Black;
            this.btnOdustani.Location = new System.Drawing.Point(290, 436);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(113, 46);
            this.btnOdustani.TabIndex = 19;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.ForeColor = System.Drawing.Color.Black;
            this.btnRezerviraj.Location = new System.Drawing.Point(116, 436);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(113, 46);
            this.btnRezerviraj.TabIndex = 18;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // txtDuljinaRezervacije
            // 
            this.txtDuljinaRezervacije.Location = new System.Drawing.Point(380, 363);
            this.txtDuljinaRezervacije.Name = "txtDuljinaRezervacije";
            this.txtDuljinaRezervacije.Size = new System.Drawing.Size(100, 22);
            this.txtDuljinaRezervacije.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Duljina rezervacije (sati):";
            // 
            // txtVrijemeOd
            // 
            this.txtVrijemeOd.Location = new System.Drawing.Point(78, 363);
            this.txtVrijemeOd.Name = "txtVrijemeOd";
            this.txtVrijemeOd.Size = new System.Drawing.Size(100, 22);
            this.txtVrijemeOd.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Od (sati):";
            // 
            // dtpDatumRezervacije
            // 
            this.dtpDatumRezervacije.Location = new System.Drawing.Point(280, 319);
            this.dtpDatumRezervacije.Name = "dtpDatumRezervacije";
            this.dtpDatumRezervacije.Size = new System.Drawing.Size(200, 22);
            this.dtpDatumRezervacije.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Odaberite datum za koji želite rezervirati:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sportska oprema:";
            // 
            // dgvSportskaOprema
            // 
            this.dgvSportskaOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSportskaOprema.Location = new System.Drawing.Point(12, 27);
            this.dgvSportskaOprema.Name = "dgvSportskaOprema";
            this.dgvSportskaOprema.RowHeadersWidth = 51;
            this.dgvSportskaOprema.RowTemplate.Height = 24;
            this.dgvSportskaOprema.Size = new System.Drawing.Size(468, 275);
            this.dgvSportskaOprema.TabIndex = 20;
            // 
            // RezervacijaSportskeOpremeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 494);
            this.Controls.Add(this.dgvSportskaOprema);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.txtDuljinaRezervacije);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVrijemeOd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatumRezervacije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RezervacijaSportskeOpremeFrm";
            this.Text = "Rezervacija sportske opreme";
            this.Load += new System.EventHandler(this.RezervacijaSportskeOpremeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportskaOprema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.TextBox txtDuljinaRezervacije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVrijemeOd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatumRezervacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSportskaOprema;
    }
}