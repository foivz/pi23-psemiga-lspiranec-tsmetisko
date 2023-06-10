namespace Projekt_Rent_A_Field
{
    partial class KorisnikOpremaCjenikFrm
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
            this.dataGridViewKOprema = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKOprema)).BeginInit();
            this.SuspendLayout();
            // 
            // ZatvoriOpremuButton
            // 
            this.ZatvoriOpremuButton.Location = new System.Drawing.Point(199, 231);
            this.ZatvoriOpremuButton.Name = "ZatvoriOpremuButton";
            this.ZatvoriOpremuButton.Size = new System.Drawing.Size(75, 23);
            this.ZatvoriOpremuButton.TabIndex = 11;
            this.ZatvoriOpremuButton.Text = "Zatvori";
            this.ZatvoriOpremuButton.UseVisualStyleBackColor = true;
            this.ZatvoriOpremuButton.Click += new System.EventHandler(this.ZatvoriOpremuButton_Click);
            // 
            // dataGridViewKOprema
            // 
            this.dataGridViewKOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKOprema.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewKOprema.Name = "dataGridViewKOprema";
            this.dataGridViewKOprema.Size = new System.Drawing.Size(439, 213);
            this.dataGridViewKOprema.TabIndex = 10;
            // 
            // KorisnikOpremaCjenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(469, 263);
            this.Controls.Add(this.ZatvoriOpremuButton);
            this.Controls.Add(this.dataGridViewKOprema);
            this.Name = "KorisnikOpremaCjenik";
            this.Text = "Cjenik za sportsku opremu";
            this.Load += new System.EventHandler(this.KorisnikOpremaCjenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKOprema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ZatvoriOpremuButton;
        private System.Windows.Forms.DataGridView dataGridViewKOprema;
    }
}