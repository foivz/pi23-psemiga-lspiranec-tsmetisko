namespace Projekt_Rent_A_Field
{
    partial class AzurirajProstorFrm
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
            this.ButtonOdustaniAProstor = new System.Windows.Forms.Button();
            this.ButtonAzurirajProstor = new System.Windows.Forms.Button();
            this.textBoxCijenaPoSatuProstorA = new System.Windows.Forms.TextBox();
            this.textBoxAdresaProstorA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNazivProstorA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(154, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Cijena je izražena kao eur/h ";
            // 
            // ButtonOdustaniAProstor
            // 
            this.ButtonOdustaniAProstor.Location = new System.Drawing.Point(191, 144);
            this.ButtonOdustaniAProstor.Name = "ButtonOdustaniAProstor";
            this.ButtonOdustaniAProstor.Size = new System.Drawing.Size(75, 23);
            this.ButtonOdustaniAProstor.TabIndex = 34;
            this.ButtonOdustaniAProstor.Text = "Odustani";
            this.ButtonOdustaniAProstor.UseVisualStyleBackColor = true;
            this.ButtonOdustaniAProstor.Click += new System.EventHandler(this.ButtonOdustaniAProstor_Click);
            // 
            // ButtonAzurirajProstor
            // 
            this.ButtonAzurirajProstor.Location = new System.Drawing.Point(65, 144);
            this.ButtonAzurirajProstor.Name = "ButtonAzurirajProstor";
            this.ButtonAzurirajProstor.Size = new System.Drawing.Size(75, 23);
            this.ButtonAzurirajProstor.TabIndex = 33;
            this.ButtonAzurirajProstor.Text = "Ažuriraj";
            this.ButtonAzurirajProstor.UseVisualStyleBackColor = true;
            this.ButtonAzurirajProstor.Click += new System.EventHandler(this.ButtonAzurirajProstor_Click);
            // 
            // textBoxCijenaPoSatuProstorA
            // 
            this.textBoxCijenaPoSatuProstorA.Location = new System.Drawing.Point(135, 87);
            this.textBoxCijenaPoSatuProstorA.Name = "textBoxCijenaPoSatuProstorA";
            this.textBoxCijenaPoSatuProstorA.Size = new System.Drawing.Size(173, 20);
            this.textBoxCijenaPoSatuProstorA.TabIndex = 32;
            // 
            // textBoxAdresaProstorA
            // 
            this.textBoxAdresaProstorA.Location = new System.Drawing.Point(135, 46);
            this.textBoxAdresaProstorA.Name = "textBoxAdresaProstorA";
            this.textBoxAdresaProstorA.Size = new System.Drawing.Size(173, 20);
            this.textBoxAdresaProstorA.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cijena po satu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Adresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Naziv:";
            // 
            // textBoxNazivProstorA
            // 
            this.textBoxNazivProstorA.Location = new System.Drawing.Point(135, 6);
            this.textBoxNazivProstorA.Name = "textBoxNazivProstorA";
            this.textBoxNazivProstorA.Size = new System.Drawing.Size(173, 20);
            this.textBoxNazivProstorA.TabIndex = 27;
            // 
            // AzurirajProstorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(332, 181);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonOdustaniAProstor);
            this.Controls.Add(this.ButtonAzurirajProstor);
            this.Controls.Add(this.textBoxCijenaPoSatuProstorA);
            this.Controls.Add(this.textBoxAdresaProstorA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNazivProstorA);
            this.Name = "AzurirajProstorFrm";
            this.Text = "AzurirajProstorFrm";
            this.Load += new System.EventHandler(this.AzurirajProstorFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonOdustaniAProstor;
        private System.Windows.Forms.Button ButtonAzurirajProstor;
        private System.Windows.Forms.TextBox textBoxCijenaPoSatuProstorA;
        private System.Windows.Forms.TextBox textBoxAdresaProstorA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazivProstorA;
    }
}