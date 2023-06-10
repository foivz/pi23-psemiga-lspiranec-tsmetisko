namespace Projekt_Rent_A_Field
{
    partial class UnesiRezultatFrm
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
            this.textBoxTerminId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOdustaniUnosRezultata = new System.Windows.Forms.Button();
            this.buttonSpremiUnosRezultata = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            this.textBoxSport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTerminId
            // 
            this.textBoxTerminId.Location = new System.Drawing.Point(64, 6);
            this.textBoxTerminId.Multiline = true;
            this.textBoxTerminId.Name = "textBoxTerminId";
            this.textBoxTerminId.Size = new System.Drawing.Size(230, 27);
            this.textBoxTerminId.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Termin:";
            // 
            // buttonOdustaniUnosRezultata
            // 
            this.buttonOdustaniUnosRezultata.Location = new System.Drawing.Point(219, 157);
            this.buttonOdustaniUnosRezultata.Name = "buttonOdustaniUnosRezultata";
            this.buttonOdustaniUnosRezultata.Size = new System.Drawing.Size(75, 23);
            this.buttonOdustaniUnosRezultata.TabIndex = 17;
            this.buttonOdustaniUnosRezultata.Text = "Odustani";
            this.buttonOdustaniUnosRezultata.UseVisualStyleBackColor = true;
            this.buttonOdustaniUnosRezultata.Click += new System.EventHandler(this.buttonOdustaniUnosRezultata_Click);
            // 
            // buttonSpremiUnosRezultata
            // 
            this.buttonSpremiUnosRezultata.Location = new System.Drawing.Point(15, 157);
            this.buttonSpremiUnosRezultata.Name = "buttonSpremiUnosRezultata";
            this.buttonSpremiUnosRezultata.Size = new System.Drawing.Size(75, 23);
            this.buttonSpremiUnosRezultata.TabIndex = 16;
            this.buttonSpremiUnosRezultata.Text = "Spremi";
            this.buttonSpremiUnosRezultata.UseVisualStyleBackColor = true;
            this.buttonSpremiUnosRezultata.Click += new System.EventHandler(this.buttonSpremiUnosRezultata_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Rezultat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sport:";
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(64, 100);
            this.textBoxRezultat.Multiline = true;
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(230, 27);
            this.textBoxRezultat.TabIndex = 13;
            // 
            // textBoxSport
            // 
            this.textBoxSport.Location = new System.Drawing.Point(64, 53);
            this.textBoxSport.Multiline = true;
            this.textBoxSport.Name = "textBoxSport";
            this.textBoxSport.Size = new System.Drawing.Size(230, 27);
            this.textBoxSport.TabIndex = 12;
            // 
            // UnesiRezultatFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(309, 190);
            this.Controls.Add(this.textBoxTerminId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonOdustaniUnosRezultata);
            this.Controls.Add(this.buttonSpremiUnosRezultata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.textBoxSport);
            this.Name = "UnesiRezultatFrm";
            this.Text = "UnesiRezultatFrm";
            this.Load += new System.EventHandler(this.UnesiRezultatFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTerminId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOdustaniUnosRezultata;
        private System.Windows.Forms.Button buttonSpremiUnosRezultata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRezultat;
        private System.Windows.Forms.TextBox textBoxSport;
    }
}