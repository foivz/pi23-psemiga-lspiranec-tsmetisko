namespace Projekt_Rent_A_Field
{
    partial class KorisnikProstorCjenikFrm
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
            this.dataGridViewKProstor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKProstor)).BeginInit();
            this.SuspendLayout();
            // 
            // ZatvoriProstorButton
            // 
            this.ZatvoriProstorButton.Location = new System.Drawing.Point(195, 231);
            this.ZatvoriProstorButton.Name = "ZatvoriProstorButton";
            this.ZatvoriProstorButton.Size = new System.Drawing.Size(75, 23);
            this.ZatvoriProstorButton.TabIndex = 16;
            this.ZatvoriProstorButton.Text = "Zatvori";
            this.ZatvoriProstorButton.UseVisualStyleBackColor = true;
            this.ZatvoriProstorButton.Click += new System.EventHandler(this.ZatvoriProstorButton_Click);
            // 
            // dataGridViewKProstor
            // 
            this.dataGridViewKProstor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKProstor.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewKProstor.Name = "dataGridViewKProstor";
            this.dataGridViewKProstor.Size = new System.Drawing.Size(439, 213);
            this.dataGridViewKProstor.TabIndex = 15;
            // 
            // KorisnikProstorCjenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(470, 265);
            this.Controls.Add(this.ZatvoriProstorButton);
            this.Controls.Add(this.dataGridViewKProstor);
            this.Name = "KorisnikProstorCjenik";
            this.Text = "Korisnik cjenik";
            this.Load += new System.EventHandler(this.KorisnikProstorCjenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKProstor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ZatvoriProstorButton;
        private System.Windows.Forms.DataGridView dataGridViewKProstor;
    }
}