namespace Projekt_Rent_A_Field
{
    partial class SportskaOpremaCjenikFrm
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
            this.ZatvoriOpremuButton = new System.Windows.Forms.Button();
            this.ObrisiOpremuButton = new System.Windows.Forms.Button();
            this.AzurirajOpremuButton = new System.Windows.Forms.Button();
            this.DodajOpremuButton = new System.Windows.Forms.Button();
            this.dataGridViewOprema = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOprema)).BeginInit();
            this.SuspendLayout();
            // 
            // ZatvoriOpremuButton
            // 
            this.ZatvoriOpremuButton.Location = new System.Drawing.Point(376, 270);
            this.ZatvoriOpremuButton.Name = "ZatvoriOpremuButton";
            this.ZatvoriOpremuButton.Size = new System.Drawing.Size(75, 23);
            this.ZatvoriOpremuButton.TabIndex = 9;
            this.ZatvoriOpremuButton.Text = "Zatvori";
            this.ZatvoriOpremuButton.UseVisualStyleBackColor = true;
            this.ZatvoriOpremuButton.Click += new System.EventHandler(this.ZatvoriOpremuButton_Click);
            // 
            // ObrisiOpremuButton
            // 
            this.ObrisiOpremuButton.Location = new System.Drawing.Point(274, 231);
            this.ObrisiOpremuButton.Name = "ObrisiOpremuButton";
            this.ObrisiOpremuButton.Size = new System.Drawing.Size(75, 23);
            this.ObrisiOpremuButton.TabIndex = 8;
            this.ObrisiOpremuButton.Text = "Obrisi";
            this.ObrisiOpremuButton.UseVisualStyleBackColor = true;
            this.ObrisiOpremuButton.Click += new System.EventHandler(this.ObrisiOpremuButton_Click);
            // 
            // AzurirajOpremuButton
            // 
            this.AzurirajOpremuButton.Location = new System.Drawing.Point(193, 231);
            this.AzurirajOpremuButton.Name = "AzurirajOpremuButton";
            this.AzurirajOpremuButton.Size = new System.Drawing.Size(75, 23);
            this.AzurirajOpremuButton.TabIndex = 7;
            this.AzurirajOpremuButton.Text = "Ažuriraj";
            this.AzurirajOpremuButton.UseVisualStyleBackColor = true;
            this.AzurirajOpremuButton.Click += new System.EventHandler(this.AzurirajOpremuButton_Click);
            // 
            // DodajOpremuButton
            // 
            this.DodajOpremuButton.Location = new System.Drawing.Point(112, 231);
            this.DodajOpremuButton.Name = "DodajOpremuButton";
            this.DodajOpremuButton.Size = new System.Drawing.Size(75, 23);
            this.DodajOpremuButton.TabIndex = 6;
            this.DodajOpremuButton.Text = "Dodaj";
            this.DodajOpremuButton.UseVisualStyleBackColor = true;
            this.DodajOpremuButton.Click += new System.EventHandler(this.DodajOpremuButton_Click);
            // 
            // dataGridViewOprema
            // 
            this.dataGridViewOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOprema.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOprema.Name = "dataGridViewOprema";
            this.dataGridViewOprema.Size = new System.Drawing.Size(439, 213);
            this.dataGridViewOprema.TabIndex = 5;
            // 
            // SportskaOpremaCjenikFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(464, 304);
            this.Controls.Add(this.ZatvoriOpremuButton);
            this.Controls.Add(this.ObrisiOpremuButton);
            this.Controls.Add(this.AzurirajOpremuButton);
            this.Controls.Add(this.DodajOpremuButton);
            this.Controls.Add(this.dataGridViewOprema);
            this.Name = "SportskaOpremaCjenikFrm";
            this.Text = "Sportska oprema";
            this.Load += new System.EventHandler(this.SportskaOpremaCjenikFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOprema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ZatvoriOpremuButton;
        private System.Windows.Forms.Button ObrisiOpremuButton;
        private System.Windows.Forms.Button AzurirajOpremuButton;
        private System.Windows.Forms.Button DodajOpremuButton;
        private System.Windows.Forms.DataGridView dataGridViewOprema;
    }
}