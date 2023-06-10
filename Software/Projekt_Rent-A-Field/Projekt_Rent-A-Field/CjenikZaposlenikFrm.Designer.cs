namespace Projekt_Rent_A_Field
{
    partial class CjenikZaposlenikFrm
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
            this.TreneriCjenikButton = new System.Windows.Forms.Button();
            this.ZatvoriCjenikButton = new System.Windows.Forms.Button();
            this.ProstorCjenikButton = new System.Windows.Forms.Button();
            this.OpremaCjenikButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TreneriCjenikButton
            // 
            this.TreneriCjenikButton.Location = new System.Drawing.Point(12, 112);
            this.TreneriCjenikButton.Name = "TreneriCjenikButton";
            this.TreneriCjenikButton.Size = new System.Drawing.Size(173, 44);
            this.TreneriCjenikButton.TabIndex = 11;
            this.TreneriCjenikButton.Text = "Treneri";
            this.TreneriCjenikButton.UseVisualStyleBackColor = true;
            this.TreneriCjenikButton.Click += new System.EventHandler(this.TreneriCjenikButton_Click);
            // 
            // ZatvoriCjenikButton
            // 
            this.ZatvoriCjenikButton.Location = new System.Drawing.Point(56, 185);
            this.ZatvoriCjenikButton.Name = "ZatvoriCjenikButton";
            this.ZatvoriCjenikButton.Size = new System.Drawing.Size(75, 23);
            this.ZatvoriCjenikButton.TabIndex = 10;
            this.ZatvoriCjenikButton.Text = "Zatvori";
            this.ZatvoriCjenikButton.UseVisualStyleBackColor = true;
            this.ZatvoriCjenikButton.Click += new System.EventHandler(this.ZatvoriCjenikButton_Click);
            // 
            // ProstorCjenikButton
            // 
            this.ProstorCjenikButton.Location = new System.Drawing.Point(12, 62);
            this.ProstorCjenikButton.Name = "ProstorCjenikButton";
            this.ProstorCjenikButton.Size = new System.Drawing.Size(173, 44);
            this.ProstorCjenikButton.TabIndex = 9;
            this.ProstorCjenikButton.Text = "Sportski prostor";
            this.ProstorCjenikButton.UseVisualStyleBackColor = true;
            this.ProstorCjenikButton.Click += new System.EventHandler(this.ProstorCjenikButton_Click);
            // 
            // OpremaCjenikButton
            // 
            this.OpremaCjenikButton.Location = new System.Drawing.Point(12, 12);
            this.OpremaCjenikButton.Name = "OpremaCjenikButton";
            this.OpremaCjenikButton.Size = new System.Drawing.Size(173, 44);
            this.OpremaCjenikButton.TabIndex = 8;
            this.OpremaCjenikButton.Text = "Sportska oprema";
            this.OpremaCjenikButton.UseVisualStyleBackColor = true;
            this.OpremaCjenikButton.Click += new System.EventHandler(this.OpremaCjenikButton_Click);
            // 
            // CjenikZaposlenikFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(204, 223);
            this.Controls.Add(this.TreneriCjenikButton);
            this.Controls.Add(this.ZatvoriCjenikButton);
            this.Controls.Add(this.ProstorCjenikButton);
            this.Controls.Add(this.OpremaCjenikButton);
            this.Name = "CjenikZaposlenikFrm";
            this.Text = "Cjenik zaposlenik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TreneriCjenikButton;
        private System.Windows.Forms.Button ZatvoriCjenikButton;
        private System.Windows.Forms.Button ProstorCjenikButton;
        private System.Windows.Forms.Button OpremaCjenikButton;
    }
}