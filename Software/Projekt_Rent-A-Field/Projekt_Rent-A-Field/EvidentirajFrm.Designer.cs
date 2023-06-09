namespace Projekt_Rent_A_Field
{
    partial class EvidentirajFrm
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
            this.radioButtonOdbaci = new System.Windows.Forms.RadioButton();
            this.radioButtonPrihvati = new System.Windows.Forms.RadioButton();
            this.buttonPohraniEvidencija = new System.Windows.Forms.Button();
            this.textBoxOdogovrEvidentiraj = new System.Windows.Forms.TextBox();
            this.ButtonOdustaniEvidentiraj = new System.Windows.Forms.Button();
            this.dateTimePickerEvidentiraj = new System.Windows.Forms.DateTimePicker();
            this.TextBoxEvidentirajStari = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButtonOdbaci
            // 
            this.radioButtonOdbaci.AutoSize = true;
            this.radioButtonOdbaci.ForeColor = System.Drawing.Color.White;
            this.radioButtonOdbaci.Location = new System.Drawing.Point(174, 177);
            this.radioButtonOdbaci.Name = "radioButtonOdbaci";
            this.radioButtonOdbaci.Size = new System.Drawing.Size(67, 17);
            this.radioButtonOdbaci.TabIndex = 17;
            this.radioButtonOdbaci.TabStop = true;
            this.radioButtonOdbaci.Text = "Odbijeno";
            this.radioButtonOdbaci.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrihvati
            // 
            this.radioButtonPrihvati.AutoSize = true;
            this.radioButtonPrihvati.ForeColor = System.Drawing.Color.White;
            this.radioButtonPrihvati.Location = new System.Drawing.Point(174, 154);
            this.radioButtonPrihvati.Name = "radioButtonPrihvati";
            this.radioButtonPrihvati.Size = new System.Drawing.Size(79, 17);
            this.radioButtonPrihvati.TabIndex = 16;
            this.radioButtonPrihvati.TabStop = true;
            this.radioButtonPrihvati.Text = "Prihvaćeno";
            this.radioButtonPrihvati.UseVisualStyleBackColor = true;
            // 
            // buttonPohraniEvidencija
            // 
            this.buttonPohraniEvidencija.Location = new System.Drawing.Point(12, 319);
            this.buttonPohraniEvidencija.Name = "buttonPohraniEvidencija";
            this.buttonPohraniEvidencija.Size = new System.Drawing.Size(117, 23);
            this.buttonPohraniEvidencija.TabIndex = 15;
            this.buttonPohraniEvidencija.Text = "Pohrani";
            this.buttonPohraniEvidencija.UseVisualStyleBackColor = true;
            this.buttonPohraniEvidencija.Click += new System.EventHandler(this.buttonPohraniEvidencija_Click);
            // 
            // textBoxOdogovrEvidentiraj
            // 
            this.textBoxOdogovrEvidentiraj.Location = new System.Drawing.Point(13, 201);
            this.textBoxOdogovrEvidentiraj.Multiline = true;
            this.textBoxOdogovrEvidentiraj.Name = "textBoxOdogovrEvidentiraj";
            this.textBoxOdogovrEvidentiraj.Size = new System.Drawing.Size(398, 112);
            this.textBoxOdogovrEvidentiraj.TabIndex = 14;
            // 
            // ButtonOdustaniEvidentiraj
            // 
            this.ButtonOdustaniEvidentiraj.Location = new System.Drawing.Point(294, 319);
            this.ButtonOdustaniEvidentiraj.Name = "ButtonOdustaniEvidentiraj";
            this.ButtonOdustaniEvidentiraj.Size = new System.Drawing.Size(117, 23);
            this.ButtonOdustaniEvidentiraj.TabIndex = 13;
            this.ButtonOdustaniEvidentiraj.Text = "Odustani";
            this.ButtonOdustaniEvidentiraj.UseVisualStyleBackColor = true;
            this.ButtonOdustaniEvidentiraj.Click += new System.EventHandler(this.ButtonOdustaniEvidentiraj_Click);
            // 
            // dateTimePickerEvidentiraj
            // 
            this.dateTimePickerEvidentiraj.Location = new System.Drawing.Point(147, 128);
            this.dateTimePickerEvidentiraj.Name = "dateTimePickerEvidentiraj";
            this.dateTimePickerEvidentiraj.Size = new System.Drawing.Size(139, 20);
            this.dateTimePickerEvidentiraj.TabIndex = 12;
            // 
            // TextBoxEvidentirajStari
            // 
            this.TextBoxEvidentirajStari.Location = new System.Drawing.Point(12, 12);
            this.TextBoxEvidentirajStari.Multiline = true;
            this.TextBoxEvidentirajStari.Name = "TextBoxEvidentirajStari";
            this.TextBoxEvidentirajStari.Size = new System.Drawing.Size(399, 110);
            this.TextBoxEvidentirajStari.TabIndex = 11;
            // 
            // EvidentirajFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(427, 352);
            this.Controls.Add(this.radioButtonOdbaci);
            this.Controls.Add(this.radioButtonPrihvati);
            this.Controls.Add(this.buttonPohraniEvidencija);
            this.Controls.Add(this.textBoxOdogovrEvidentiraj);
            this.Controls.Add(this.ButtonOdustaniEvidentiraj);
            this.Controls.Add(this.dateTimePickerEvidentiraj);
            this.Controls.Add(this.TextBoxEvidentirajStari);
            this.Name = "EvidentirajFrm";
            this.Text = "Evidentiraj";
            this.Load += new System.EventHandler(this.EvidentirajFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonOdbaci;
        private System.Windows.Forms.RadioButton radioButtonPrihvati;
        private System.Windows.Forms.Button buttonPohraniEvidencija;
        private System.Windows.Forms.TextBox textBoxOdogovrEvidentiraj;
        private System.Windows.Forms.Button ButtonOdustaniEvidentiraj;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvidentiraj;
        private System.Windows.Forms.TextBox TextBoxEvidentirajStari;
    }
}