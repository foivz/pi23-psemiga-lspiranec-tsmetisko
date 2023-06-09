namespace Projekt_Rent_A_Field
{
    partial class SportskiProstorCjenikFrm
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
            this.ZatvoriProstorButton = new System.Windows.Forms.Button();
            this.ObrisiProstorButton = new System.Windows.Forms.Button();
            this.AzurirajProstorButton = new System.Windows.Forms.Button();
            this.DodajProstorButton = new System.Windows.Forms.Button();
            this.dataGridViewProstor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProstor)).BeginInit();
            this.SuspendLayout();
            // 
            // ZatvoriProstorButton
            // 
            this.ZatvoriProstorButton.Location = new System.Drawing.Point(376, 270);
            this.ZatvoriProstorButton.Name = "ZatvoriProstorButton";
            this.ZatvoriProstorButton.Size = new System.Drawing.Size(75, 23);
            this.ZatvoriProstorButton.TabIndex = 14;
            this.ZatvoriProstorButton.Text = "Zatvori";
            this.ZatvoriProstorButton.UseVisualStyleBackColor = true;
            this.ZatvoriProstorButton.Click += new System.EventHandler(this.ZatvoriProstorButton_Click);
            // 
            // ObrisiProstorButton
            // 
            this.ObrisiProstorButton.Location = new System.Drawing.Point(274, 231);
            this.ObrisiProstorButton.Name = "ObrisiProstorButton";
            this.ObrisiProstorButton.Size = new System.Drawing.Size(75, 23);
            this.ObrisiProstorButton.TabIndex = 13;
            this.ObrisiProstorButton.Text = "Obrisi";
            this.ObrisiProstorButton.UseVisualStyleBackColor = true;
            this.ObrisiProstorButton.Click += new System.EventHandler(this.ObrisiProstorButton_Click);
            // 
            // AzurirajProstorButton
            // 
            this.AzurirajProstorButton.Location = new System.Drawing.Point(193, 231);
            this.AzurirajProstorButton.Name = "AzurirajProstorButton";
            this.AzurirajProstorButton.Size = new System.Drawing.Size(75, 23);
            this.AzurirajProstorButton.TabIndex = 12;
            this.AzurirajProstorButton.Text = "Azuriraj";
            this.AzurirajProstorButton.UseVisualStyleBackColor = true;
            this.AzurirajProstorButton.Click += new System.EventHandler(this.AzurirajProstorButton_Click);
            // 
            // DodajProstorButton
            // 
            this.DodajProstorButton.Location = new System.Drawing.Point(112, 231);
            this.DodajProstorButton.Name = "DodajProstorButton";
            this.DodajProstorButton.Size = new System.Drawing.Size(75, 23);
            this.DodajProstorButton.TabIndex = 11;
            this.DodajProstorButton.Text = "Dodaj";
            this.DodajProstorButton.UseVisualStyleBackColor = true;
            this.DodajProstorButton.Click += new System.EventHandler(this.DodajProstorButton_Click);
            // 
            // dataGridViewProstor
            // 
            this.dataGridViewProstor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProstor.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProstor.Name = "dataGridViewProstor";
            this.dataGridViewProstor.Size = new System.Drawing.Size(439, 213);
            this.dataGridViewProstor.TabIndex = 10;
            // 
            // SportskiProstorCjenikFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(466, 301);
            this.Controls.Add(this.ZatvoriProstorButton);
            this.Controls.Add(this.ObrisiProstorButton);
            this.Controls.Add(this.AzurirajProstorButton);
            this.Controls.Add(this.DodajProstorButton);
            this.Controls.Add(this.dataGridViewProstor);
            this.Name = "SportskiProstorCjenikFrm";
            this.Text = "Sportski prostor";
            this.Load += new System.EventHandler(this.SportskiProstorCjenikFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProstor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ZatvoriProstorButton;
        private System.Windows.Forms.Button ObrisiProstorButton;
        private System.Windows.Forms.Button AzurirajProstorButton;
        private System.Windows.Forms.Button DodajProstorButton;
        private System.Windows.Forms.DataGridView dataGridViewProstor;
    }
}