namespace Projekt_Rent_A_Field
{
    partial class KorisnikTreneriCjenikFrm
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
            this.ZatvoriKProstorButton = new System.Windows.Forms.Button();
            this.dataGridViewKTreneri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKTreneri)).BeginInit();
            this.SuspendLayout();
            // 
            // ZatvoriKProstorButton
            // 
            this.ZatvoriKProstorButton.Location = new System.Drawing.Point(189, 231);
            this.ZatvoriKProstorButton.Name = "ZatvoriKProstorButton";
            this.ZatvoriKProstorButton.Size = new System.Drawing.Size(75, 23);
            this.ZatvoriKProstorButton.TabIndex = 21;
            this.ZatvoriKProstorButton.Text = "Zatvori";
            this.ZatvoriKProstorButton.UseVisualStyleBackColor = true;
            this.ZatvoriKProstorButton.Click += new System.EventHandler(this.ZatvoriKProstorButton_Click);
            // 
            // dataGridViewKTreneri
            // 
            this.dataGridViewKTreneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKTreneri.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewKTreneri.Name = "dataGridViewKTreneri";
            this.dataGridViewKTreneri.Size = new System.Drawing.Size(439, 213);
            this.dataGridViewKTreneri.TabIndex = 20;
            // 
            // KorisnikTreneriCjenikFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(470, 260);
            this.Controls.Add(this.ZatvoriKProstorButton);
            this.Controls.Add(this.dataGridViewKTreneri);
            this.Name = "KorisnikTreneriCjenikFrm";
            this.Text = "KorisnikTreneriCjenikFrm";
            this.Load += new System.EventHandler(this.KorisnikTreneriCjenikFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKTreneri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ZatvoriKProstorButton;
        private System.Windows.Forms.DataGridView dataGridViewKTreneri;
    }
}