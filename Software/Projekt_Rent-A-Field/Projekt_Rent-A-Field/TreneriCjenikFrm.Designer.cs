namespace Projekt_Rent_A_Field
{
    partial class TreneriCjenikFrm
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
            this.dataGridViewTreneri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreneri)).BeginInit();
            this.SuspendLayout();
            // 
            // ZatvoriProstorButton
            // 
            this.ZatvoriProstorButton.Location = new System.Drawing.Point(376, 270);
            this.ZatvoriProstorButton.Name = "ZatvoriProstorButton";
            this.ZatvoriProstorButton.Size = new System.Drawing.Size(75, 23);
            this.ZatvoriProstorButton.TabIndex = 19;
            this.ZatvoriProstorButton.Text = "Zatvori";
            this.ZatvoriProstorButton.UseVisualStyleBackColor = true;
            // 
            // ObrisiProstorButton
            // 
            this.ObrisiProstorButton.Location = new System.Drawing.Point(274, 231);
            this.ObrisiProstorButton.Name = "ObrisiProstorButton";
            this.ObrisiProstorButton.Size = new System.Drawing.Size(75, 23);
            this.ObrisiProstorButton.TabIndex = 18;
            this.ObrisiProstorButton.Text = "Obrisi";
            this.ObrisiProstorButton.UseVisualStyleBackColor = true;
            // 
            // AzurirajProstorButton
            // 
            this.AzurirajProstorButton.Location = new System.Drawing.Point(193, 231);
            this.AzurirajProstorButton.Name = "AzurirajProstorButton";
            this.AzurirajProstorButton.Size = new System.Drawing.Size(75, 23);
            this.AzurirajProstorButton.TabIndex = 17;
            this.AzurirajProstorButton.Text = "Ažuriraj";
            this.AzurirajProstorButton.UseVisualStyleBackColor = true;
            // 
            // DodajProstorButton
            // 
            this.DodajProstorButton.Location = new System.Drawing.Point(112, 231);
            this.DodajProstorButton.Name = "DodajProstorButton";
            this.DodajProstorButton.Size = new System.Drawing.Size(75, 23);
            this.DodajProstorButton.TabIndex = 16;
            this.DodajProstorButton.Text = "Dodaj";
            this.DodajProstorButton.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTreneri
            // 
            this.dataGridViewTreneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTreneri.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTreneri.Name = "dataGridViewTreneri";
            this.dataGridViewTreneri.Size = new System.Drawing.Size(439, 213);
            this.dataGridViewTreneri.TabIndex = 15;
            // 
            // TreneriCjenikFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 300);
            this.Controls.Add(this.ZatvoriProstorButton);
            this.Controls.Add(this.ObrisiProstorButton);
            this.Controls.Add(this.AzurirajProstorButton);
            this.Controls.Add(this.DodajProstorButton);
            this.Controls.Add(this.dataGridViewTreneri);
            this.Name = "TreneriCjenikFrm";
            this.Text = "Treneri cjenik";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreneri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ZatvoriProstorButton;
        private System.Windows.Forms.Button ObrisiProstorButton;
        private System.Windows.Forms.Button AzurirajProstorButton;
        private System.Windows.Forms.Button DodajProstorButton;
        private System.Windows.Forms.DataGridView dataGridViewTreneri;
    }
}