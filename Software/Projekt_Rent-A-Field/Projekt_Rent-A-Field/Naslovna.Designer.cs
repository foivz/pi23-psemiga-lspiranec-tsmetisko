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
            this.label4 = new System.Windows.Forms.Label();
            this.buttonKreirajPrigovor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPopisRezervacija
            // 
            this.buttonPopisRezervacija.Location = new System.Drawing.Point(151, 113);
            this.buttonPopisRezervacija.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPopisRezervacija.Name = "buttonPopisRezervacija";
            this.buttonPopisRezervacija.Size = new System.Drawing.Size(293, 24);
            this.buttonPopisRezervacija.TabIndex = 0;
            this.buttonPopisRezervacija.Text = "Popis rezervacija";
            this.buttonPopisRezervacija.UseVisualStyleBackColor = true;
            this.buttonPopisRezervacija.Click += new System.EventHandler(this.buttonPopisRezervacija_Click);
            // 
            // buttonPristupCjeniku
            // 
            this.buttonPristupCjeniku.Location = new System.Drawing.Point(152, 229);
            this.buttonPristupCjeniku.Name = "buttonPristupCjeniku";
            this.buttonPristupCjeniku.Size = new System.Drawing.Size(292, 23);
            this.buttonPristupCjeniku.TabIndex = 1;
            this.buttonPristupCjeniku.Text = "Cjenik";
            this.buttonPristupCjeniku.UseVisualStyleBackColor = true;
            this.buttonPristupCjeniku.Click += new System.EventHandler(this.buttonPristupCjeniku_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("MV Boli", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(120, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 70);
            this.label4.TabIndex = 34;
            this.label4.Text = "Rent-A-Field";
            // 
            // buttonKreirajPrigovor
            // 
            this.buttonKreirajPrigovor.Location = new System.Drawing.Point(152, 142);
            this.buttonKreirajPrigovor.Name = "buttonKreirajPrigovor";
            this.buttonKreirajPrigovor.Size = new System.Drawing.Size(292, 23);
            this.buttonKreirajPrigovor.TabIndex = 35;
            this.buttonKreirajPrigovor.Text = "Kreiraj prigovor";
            this.buttonKreirajPrigovor.UseVisualStyleBackColor = true;
            this.buttonKreirajPrigovor.Click += new System.EventHandler(this.buttonKreirajPrigovor_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Evidentiraj rezultat";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(152, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(292, 23);
            this.button3.TabIndex = 37;
            this.button3.Text = "Generiraj tim";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Naslovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonKreirajPrigovor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonPristupCjeniku);
            this.Controls.Add(this.buttonPopisRezervacija);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Naslovna";
            this.Text = "Naslovna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPopisRezervacija;
        private System.Windows.Forms.Button buttonPristupCjeniku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonKreirajPrigovor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}