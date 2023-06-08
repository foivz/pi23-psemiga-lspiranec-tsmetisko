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
            this.SuspendLayout();
            // 
            // buttonPopisRezervacija
            // 
            this.buttonPopisRezervacija.Location = new System.Drawing.Point(300, 236);
            this.buttonPopisRezervacija.Name = "buttonPopisRezervacija";
            this.buttonPopisRezervacija.Size = new System.Drawing.Size(179, 79);
            this.buttonPopisRezervacija.TabIndex = 0;
            this.buttonPopisRezervacija.Text = "Popis rezervacija";
            this.buttonPopisRezervacija.UseVisualStyleBackColor = true;
            // 
            // Naslovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPopisRezervacija);
            this.Name = "Naslovna";
            this.Text = "Naslovna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPopisRezervacija;
    }
}