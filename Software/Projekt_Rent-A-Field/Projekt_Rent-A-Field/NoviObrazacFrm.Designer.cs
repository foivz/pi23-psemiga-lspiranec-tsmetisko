namespace Projekt_Rent_A_Field
{
    partial class NoviObrazacFrm
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
            this.ButtonOdustaniObrazac = new System.Windows.Forms.Button();
            this.ButtonPodnesiObrazac = new System.Windows.Forms.Button();
            this.dateTimePickerObrazacNovi = new System.Windows.Forms.DateTimePicker();
            this.TextBoxObrazacNovi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonOdustaniObrazac
            // 
            this.ButtonOdustaniObrazac.Location = new System.Drawing.Point(294, 245);
            this.ButtonOdustaniObrazac.Name = "ButtonOdustaniObrazac";
            this.ButtonOdustaniObrazac.Size = new System.Drawing.Size(117, 23);
            this.ButtonOdustaniObrazac.TabIndex = 7;
            this.ButtonOdustaniObrazac.Text = "Odustani";
            this.ButtonOdustaniObrazac.UseVisualStyleBackColor = true;
            this.ButtonOdustaniObrazac.Click += new System.EventHandler(this.ButtonOdustaniObrazac_Click);
            // 
            // ButtonPodnesiObrazac
            // 
            this.ButtonPodnesiObrazac.Location = new System.Drawing.Point(294, 216);
            this.ButtonPodnesiObrazac.Name = "ButtonPodnesiObrazac";
            this.ButtonPodnesiObrazac.Size = new System.Drawing.Size(117, 23);
            this.ButtonPodnesiObrazac.TabIndex = 6;
            this.ButtonPodnesiObrazac.Text = "Podnesi";
            this.ButtonPodnesiObrazac.UseVisualStyleBackColor = true;
            this.ButtonPodnesiObrazac.Click += new System.EventHandler(this.ButtonPodnesiObrazac_Click);
            // 
            // dateTimePickerObrazacNovi
            // 
            this.dateTimePickerObrazacNovi.Location = new System.Drawing.Point(12, 219);
            this.dateTimePickerObrazacNovi.Name = "dateTimePickerObrazacNovi";
            this.dateTimePickerObrazacNovi.Size = new System.Drawing.Size(139, 20);
            this.dateTimePickerObrazacNovi.TabIndex = 5;
            // 
            // TextBoxObrazacNovi
            // 
            this.TextBoxObrazacNovi.Location = new System.Drawing.Point(12, 12);
            this.TextBoxObrazacNovi.Multiline = true;
            this.TextBoxObrazacNovi.Name = "TextBoxObrazacNovi";
            this.TextBoxObrazacNovi.Size = new System.Drawing.Size(399, 200);
            this.TextBoxObrazacNovi.TabIndex = 4;
            // 
            // NoviObrazacFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(419, 278);
            this.Controls.Add(this.ButtonOdustaniObrazac);
            this.Controls.Add(this.ButtonPodnesiObrazac);
            this.Controls.Add(this.dateTimePickerObrazacNovi);
            this.Controls.Add(this.TextBoxObrazacNovi);
            this.Name = "NoviObrazacFrm";
            this.Text = "Novi obrazac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonOdustaniObrazac;
        private System.Windows.Forms.Button ButtonPodnesiObrazac;
        private System.Windows.Forms.DateTimePicker dateTimePickerObrazacNovi;
        private System.Windows.Forms.TextBox TextBoxObrazacNovi;
    }
}