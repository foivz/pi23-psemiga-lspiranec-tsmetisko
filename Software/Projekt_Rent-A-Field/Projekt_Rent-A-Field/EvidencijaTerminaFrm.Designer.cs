namespace Projekt_Rent_A_Field
{
    partial class EvidencijaTerminaFrm
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
            this.buttonZatvoriEvidencijuRezultat = new System.Windows.Forms.Button();
            this.buttonEvidentirajRezultat = new System.Windows.Forms.Button();
            this.dataGridViewPrikaziRezultat = new System.Windows.Forms.DataGridView();
            this.dataGridViewEvidentirajRezultat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrikaziRezultat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvidentirajRezultat)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonZatvoriEvidencijuRezultat
            // 
            this.buttonZatvoriEvidencijuRezultat.Location = new System.Drawing.Point(666, 273);
            this.buttonZatvoriEvidencijuRezultat.Name = "buttonZatvoriEvidencijuRezultat";
            this.buttonZatvoriEvidencijuRezultat.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvoriEvidencijuRezultat.TabIndex = 7;
            this.buttonZatvoriEvidencijuRezultat.Text = "Zatvori";
            this.buttonZatvoriEvidencijuRezultat.UseVisualStyleBackColor = true;
            // 
            // buttonEvidentirajRezultat
            // 
            this.buttonEvidentirajRezultat.Location = new System.Drawing.Point(12, 269);
            this.buttonEvidentirajRezultat.Name = "buttonEvidentirajRezultat";
            this.buttonEvidentirajRezultat.Size = new System.Drawing.Size(105, 27);
            this.buttonEvidentirajRezultat.TabIndex = 6;
            this.buttonEvidentirajRezultat.Text = "Evidentiraj";
            this.buttonEvidentirajRezultat.UseVisualStyleBackColor = true;
            this.buttonEvidentirajRezultat.Click += new System.EventHandler(this.buttonEvidentirajRezultat_Click);
            // 
            // dataGridViewPrikaziRezultat
            // 
            this.dataGridViewPrikaziRezultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrikaziRezultat.Location = new System.Drawing.Point(378, 13);
            this.dataGridViewPrikaziRezultat.Name = "dataGridViewPrikaziRezultat";
            this.dataGridViewPrikaziRezultat.Size = new System.Drawing.Size(363, 236);
            this.dataGridViewPrikaziRezultat.TabIndex = 5;
            // 
            // dataGridViewEvidentirajRezultat
            // 
            this.dataGridViewEvidentirajRezultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvidentirajRezultat.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEvidentirajRezultat.Name = "dataGridViewEvidentirajRezultat";
            this.dataGridViewEvidentirajRezultat.Size = new System.Drawing.Size(360, 237);
            this.dataGridViewEvidentirajRezultat.TabIndex = 4;
            // 
            // EvidencijaTerminaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(752, 308);
            this.Controls.Add(this.buttonZatvoriEvidencijuRezultat);
            this.Controls.Add(this.buttonEvidentirajRezultat);
            this.Controls.Add(this.dataGridViewPrikaziRezultat);
            this.Controls.Add(this.dataGridViewEvidentirajRezultat);
            this.Name = "EvidencijaTerminaFrm";
            this.Text = "EvidencijaTerminaFrm";
            this.Load += new System.EventHandler(this.EvidencijaTerminaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrikaziRezultat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvidentirajRezultat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonZatvoriEvidencijuRezultat;
        private System.Windows.Forms.Button buttonEvidentirajRezultat;
        private System.Windows.Forms.DataGridView dataGridViewPrikaziRezultat;
        private System.Windows.Forms.DataGridView dataGridViewEvidentirajRezultat;
    }
}