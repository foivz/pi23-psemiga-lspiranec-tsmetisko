namespace Projekt_Rent_A_Field
{
    partial class AzurirajTreneraFrm
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
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOdustaniTrener = new System.Windows.Forms.Button();
            this.buttonAzurirajTrenera = new System.Windows.Forms.Button();
            this.textBoxCijenaPoSatu = new System.Windows.Forms.TextBox();
            this.textBoxPodrucjeInteresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImePrezime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(154, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cijena je izražena kao eur/h ";
            // 
            // buttonOdustaniTrener
            // 
            this.buttonOdustaniTrener.Location = new System.Drawing.Point(191, 144);
            this.buttonOdustaniTrener.Name = "buttonOdustaniTrener";
            this.buttonOdustaniTrener.Size = new System.Drawing.Size(75, 23);
            this.buttonOdustaniTrener.TabIndex = 25;
            this.buttonOdustaniTrener.Text = "Odustani";
            this.buttonOdustaniTrener.UseVisualStyleBackColor = true;
            this.buttonOdustaniTrener.Click += new System.EventHandler(this.buttonOdustaniTrener_Click);
            // 
            // buttonAzurirajTrenera
            // 
            this.buttonAzurirajTrenera.Location = new System.Drawing.Point(65, 144);
            this.buttonAzurirajTrenera.Name = "buttonAzurirajTrenera";
            this.buttonAzurirajTrenera.Size = new System.Drawing.Size(75, 23);
            this.buttonAzurirajTrenera.TabIndex = 24;
            this.buttonAzurirajTrenera.Text = "Ažuriraj";
            this.buttonAzurirajTrenera.UseVisualStyleBackColor = true;
            this.buttonAzurirajTrenera.Click += new System.EventHandler(this.buttonAzurirajTrenera_Click);
            // 
            // textBoxCijenaPoSatu
            // 
            this.textBoxCijenaPoSatu.Location = new System.Drawing.Point(135, 87);
            this.textBoxCijenaPoSatu.Name = "textBoxCijenaPoSatu";
            this.textBoxCijenaPoSatu.Size = new System.Drawing.Size(173, 20);
            this.textBoxCijenaPoSatu.TabIndex = 23;
            // 
            // textBoxPodrucjeInteresa
            // 
            this.textBoxPodrucjeInteresa.Location = new System.Drawing.Point(135, 46);
            this.textBoxPodrucjeInteresa.Name = "textBoxPodrucjeInteresa";
            this.textBoxPodrucjeInteresa.Size = new System.Drawing.Size(173, 20);
            this.textBoxPodrucjeInteresa.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cijena po satu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Područje interesa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ime i Prezime:";
            // 
            // textBoxImePrezime
            // 
            this.textBoxImePrezime.Location = new System.Drawing.Point(135, 6);
            this.textBoxImePrezime.Name = "textBoxImePrezime";
            this.textBoxImePrezime.Size = new System.Drawing.Size(173, 20);
            this.textBoxImePrezime.TabIndex = 18;
            // 
            // AzurirajTreneraFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(325, 182);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonOdustaniTrener);
            this.Controls.Add(this.buttonAzurirajTrenera);
            this.Controls.Add(this.textBoxCijenaPoSatu);
            this.Controls.Add(this.textBoxPodrucjeInteresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxImePrezime);
            this.Name = "AzurirajTreneraFrm";
            this.Text = "Azuriraj trenera";
            this.Load += new System.EventHandler(this.AzurirajTreneraFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOdustaniTrener;
        private System.Windows.Forms.Button buttonAzurirajTrenera;
        private System.Windows.Forms.TextBox textBoxCijenaPoSatu;
        private System.Windows.Forms.TextBox textBoxPodrucjeInteresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImePrezime;
    }
}