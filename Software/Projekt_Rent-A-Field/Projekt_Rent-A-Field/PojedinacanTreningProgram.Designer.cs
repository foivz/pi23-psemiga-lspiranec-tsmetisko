﻿namespace Projekt_Rent_A_Field
{
    partial class PojedinacanTreningProgram
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Preuzmi program";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(12, 183);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(99, 28);
            this.btnNazad.TabIndex = 14;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(126, 107);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(229, 155);
            this.txtOpis.TabIndex = 13;
            this.txtOpis.Text = "";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(130, 68);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(225, 22);
            this.txtNaziv.TabIndex = 12;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(130, 27);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(225, 22);
            this.txtTip.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tip programa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Opis programa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Naziv:";
            // 
            // PojedinacanTreningProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PojedinacanTreningProgram";
            this.Text = "PojedinacanTreningProgram";
            this.Load += new System.EventHandler(this.PojedinacanTreningProgram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}