namespace Projekt_Rent_A_Field
{
    partial class NaslovnaZaposlenik
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
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSortiranjePrigovora = new System.Windows.Forms.Button();
            this.buttonUrediCjenik = new System.Windows.Forms.Button();
            this.btnDostupnost = new System.Windows.Forms.Button();
            this.btnPopisTreningPrograma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pregled događaja";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("MV Boli", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(260, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(444, 87);
            this.label4.TabIndex = 35;
            this.label4.Text = "Rent-A-Field";
            // 
            // buttonSortiranjePrigovora
            // 
            this.buttonSortiranjePrigovora.Location = new System.Drawing.Point(389, 118);
            this.buttonSortiranjePrigovora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSortiranjePrigovora.Name = "buttonSortiranjePrigovora";
            this.buttonSortiranjePrigovora.Size = new System.Drawing.Size(201, 28);
            this.buttonSortiranjePrigovora.TabIndex = 39;
            this.buttonSortiranjePrigovora.Text = "Sortiranje prigovora";
            this.buttonSortiranjePrigovora.UseVisualStyleBackColor = true;
            this.buttonSortiranjePrigovora.Click += new System.EventHandler(this.buttonSortiranjePrigovora_Click);
            // 
            // buttonUrediCjenik
            // 
            this.buttonUrediCjenik.Location = new System.Drawing.Point(389, 155);
            this.buttonUrediCjenik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUrediCjenik.Name = "buttonUrediCjenik";
            this.buttonUrediCjenik.Size = new System.Drawing.Size(201, 28);
            this.buttonUrediCjenik.TabIndex = 40;
            this.buttonUrediCjenik.Text = "Uredi cjenik";
            this.buttonUrediCjenik.UseVisualStyleBackColor = true;
            this.buttonUrediCjenik.Click += new System.EventHandler(this.buttonUrediCjenik_Click);
            // 
            // btnDostupnost
            // 
            this.btnDostupnost.Location = new System.Drawing.Point(389, 263);
            this.btnDostupnost.Margin = new System.Windows.Forms.Padding(4);
            this.btnDostupnost.Name = "btnDostupnost";
            this.btnDostupnost.Size = new System.Drawing.Size(201, 28);
            this.btnDostupnost.TabIndex = 42;
            this.btnDostupnost.Text = "Dostupnost sportskih prostora";
            this.btnDostupnost.UseVisualStyleBackColor = true;
            this.btnDostupnost.Click += new System.EventHandler(this.btnDostupnost_Click);
            // 
            // btnPopisTreningPrograma
            // 
            this.btnPopisTreningPrograma.Location = new System.Drawing.Point(389, 227);
            this.btnPopisTreningPrograma.Margin = new System.Windows.Forms.Padding(4);
            this.btnPopisTreningPrograma.Name = "btnPopisTreningPrograma";
            this.btnPopisTreningPrograma.Size = new System.Drawing.Size(201, 28);
            this.btnPopisTreningPrograma.TabIndex = 41;
            this.btnPopisTreningPrograma.Text = "Popis trening programa";
            this.btnPopisTreningPrograma.UseVisualStyleBackColor = true;
            this.btnPopisTreningPrograma.Click += new System.EventHandler(this.btnPopisTreningPrograma_Click);
            // 
            // NaslovnaZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnDostupnost);
            this.Controls.Add(this.btnPopisTreningPrograma);
            this.Controls.Add(this.buttonUrediCjenik);
            this.Controls.Add(this.buttonSortiranjePrigovora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NaslovnaZaposlenik";
            this.Text = "Naslovna zaposlenik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSortiranjePrigovora;
        private System.Windows.Forms.Button buttonUrediCjenik;
        private System.Windows.Forms.Button btnDostupnost;
        private System.Windows.Forms.Button btnPopisTreningPrograma;
    }
}