namespace Projekt_Rent_A_Field
{
    partial class Naslovna
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
            this.buttonPopisRezervacija = new System.Windows.Forms.Button();
            this.buttonPristupCjeniku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPopisRezervacija
            // 
            this.buttonPopisRezervacija.Location = new System.Drawing.Point(225, 192);
            this.buttonPopisRezervacija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPopisRezervacija.Name = "buttonPopisRezervacija";
            this.buttonPopisRezervacija.Size = new System.Drawing.Size(134, 64);
            this.buttonPopisRezervacija.TabIndex = 0;
            this.buttonPopisRezervacija.Text = "Popis rezervacija";
            this.buttonPopisRezervacija.UseVisualStyleBackColor = true;
            this.buttonPopisRezervacija.Click += new System.EventHandler(this.buttonPopisRezervacija_Click);
            // 
            // buttonPristupCjeniku
            // 
            this.buttonPristupCjeniku.Location = new System.Drawing.Point(403, 192);
            this.buttonPristupCjeniku.Name = "buttonPristupCjeniku";
            this.buttonPristupCjeniku.Size = new System.Drawing.Size(75, 23);
            this.buttonPristupCjeniku.TabIndex = 1;
            this.buttonPristupCjeniku.Text = "Cjenik";
            this.buttonPristupCjeniku.UseVisualStyleBackColor = true;
            this.buttonPristupCjeniku.Click += new System.EventHandler(this.buttonPristupCjeniku_Click);
            // 
            // Naslovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonPristupCjeniku);
            this.Controls.Add(this.buttonPopisRezervacija);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Naslovna";
            this.Text = "Naslovna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPopisRezervacija;
        private System.Windows.Forms.Button buttonPristupCjeniku;
    }
}