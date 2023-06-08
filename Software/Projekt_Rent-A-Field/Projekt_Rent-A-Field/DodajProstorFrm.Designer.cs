namespace Projekt_Rent_A_Field
{
    partial class DodajProstorFrm
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
            this.ButtonOdustaniProstor = new System.Windows.Forms.Button();
            this.ButtonDodajProstor = new System.Windows.Forms.Button();
            this.textBoxCijenaPoSatuProstor = new System.Windows.Forms.TextBox();
            this.textBoxAdresaProstor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNazivProstor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cijena je izražena kao eur/h ";
            // 
            // ButtonOdustaniProstor
            // 
            this.ButtonOdustaniProstor.Location = new System.Drawing.Point(191, 144);
            this.ButtonOdustaniProstor.Name = "ButtonOdustaniProstor";
            this.ButtonOdustaniProstor.Size = new System.Drawing.Size(75, 23);
            this.ButtonOdustaniProstor.TabIndex = 25;
            this.ButtonOdustaniProstor.Text = "Odustani";
            this.ButtonOdustaniProstor.UseVisualStyleBackColor = true;
            this.ButtonOdustaniProstor.Click += new System.EventHandler(this.ButtonOdustaniProstor_Click);
            // 
            // ButtonDodajProstor
            // 
            this.ButtonDodajProstor.Location = new System.Drawing.Point(65, 144);
            this.ButtonDodajProstor.Name = "ButtonDodajProstor";
            this.ButtonDodajProstor.Size = new System.Drawing.Size(75, 23);
            this.ButtonDodajProstor.TabIndex = 24;
            this.ButtonDodajProstor.Text = "Dodaj";
            this.ButtonDodajProstor.UseVisualStyleBackColor = true;
            this.ButtonDodajProstor.Click += new System.EventHandler(this.ButtonDodajProstor_Click);
            // 
            // textBoxCijenaPoSatuProstor
            // 
            this.textBoxCijenaPoSatuProstor.Location = new System.Drawing.Point(135, 87);
            this.textBoxCijenaPoSatuProstor.Name = "textBoxCijenaPoSatuProstor";
            this.textBoxCijenaPoSatuProstor.Size = new System.Drawing.Size(173, 20);
            this.textBoxCijenaPoSatuProstor.TabIndex = 23;
            // 
            // textBoxAdresaProstor
            // 
            this.textBoxAdresaProstor.Location = new System.Drawing.Point(135, 46);
            this.textBoxAdresaProstor.Name = "textBoxAdresaProstor";
            this.textBoxAdresaProstor.Size = new System.Drawing.Size(173, 20);
            this.textBoxAdresaProstor.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cijena po satu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Adresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Naziv:";
            // 
            // textBoxNazivProstor
            // 
            this.textBoxNazivProstor.Location = new System.Drawing.Point(135, 6);
            this.textBoxNazivProstor.Name = "textBoxNazivProstor";
            this.textBoxNazivProstor.Size = new System.Drawing.Size(173, 20);
            this.textBoxNazivProstor.TabIndex = 18;
            // 
            // DodajProstorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 183);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonOdustaniProstor);
            this.Controls.Add(this.ButtonDodajProstor);
            this.Controls.Add(this.textBoxCijenaPoSatuProstor);
            this.Controls.Add(this.textBoxAdresaProstor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNazivProstor);
            this.Name = "DodajProstorFrm";
            this.Text = "DodajProstorFrm";
            this.Load += new System.EventHandler(this.DodajProstorFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonOdustaniProstor;
        private System.Windows.Forms.Button ButtonDodajProstor;
        private System.Windows.Forms.TextBox textBoxCijenaPoSatuProstor;
        private System.Windows.Forms.TextBox textBoxAdresaProstor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazivProstor;
    }
}