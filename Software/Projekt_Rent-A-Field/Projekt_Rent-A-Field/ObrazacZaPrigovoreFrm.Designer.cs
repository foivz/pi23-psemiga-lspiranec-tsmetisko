namespace Projekt_Rent_A_Field
{
    partial class ObrazacZaPrigovoreFrm
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
            this.dataGridViewZavrseniObrazac = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewObrazac = new System.Windows.Forms.DataGridView();
            this.ButtonZatvoriObrazac = new System.Windows.Forms.Button();
            this.ButtonKreirajObrazac = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZavrseniObrazac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObrazac)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewZavrseniObrazac
            // 
            this.dataGridViewZavrseniObrazac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZavrseniObrazac.Location = new System.Drawing.Point(12, 203);
            this.dataGridViewZavrseniObrazac.Name = "dataGridViewZavrseniObrazac";
            this.dataGridViewZavrseniObrazac.Size = new System.Drawing.Size(425, 160);
            this.dataGridViewZavrseniObrazac.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(187, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Završeni obrasci";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(193, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kreirani obrasci";
            // 
            // dataGridViewObrazac
            // 
            this.dataGridViewObrazac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObrazac.Location = new System.Drawing.Point(12, 24);
            this.dataGridViewObrazac.Name = "dataGridViewObrazac";
            this.dataGridViewObrazac.Size = new System.Drawing.Size(425, 160);
            this.dataGridViewObrazac.TabIndex = 8;
            // 
            // ButtonZatvoriObrazac
            // 
            this.ButtonZatvoriObrazac.Location = new System.Drawing.Point(346, 405);
            this.ButtonZatvoriObrazac.Name = "ButtonZatvoriObrazac";
            this.ButtonZatvoriObrazac.Size = new System.Drawing.Size(75, 23);
            this.ButtonZatvoriObrazac.TabIndex = 7;
            this.ButtonZatvoriObrazac.Text = "Zatvori";
            this.ButtonZatvoriObrazac.UseVisualStyleBackColor = true;
            this.ButtonZatvoriObrazac.Click += new System.EventHandler(this.ButtonZatvoriObrazac_Click);
            // 
            // ButtonKreirajObrazac
            // 
            this.ButtonKreirajObrazac.Location = new System.Drawing.Point(165, 369);
            this.ButtonKreirajObrazac.Name = "ButtonKreirajObrazac";
            this.ButtonKreirajObrazac.Size = new System.Drawing.Size(121, 40);
            this.ButtonKreirajObrazac.TabIndex = 6;
            this.ButtonKreirajObrazac.Text = "Kreiraj novi obrazac";
            this.ButtonKreirajObrazac.UseVisualStyleBackColor = true;
            this.ButtonKreirajObrazac.Click += new System.EventHandler(this.ButtonKreirajObrazac_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\david\\source\\repos\\pi23-psemiga-lspiranec-tsmetisko\\Software\\Projekt_Ren" +
    "t-A-Field\\Projekt_Rent-A-Field\\Resources\\Obrazac za prigovore.chm";
            // 
            // ObrazacZaPrigovoreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(448, 433);
            this.Controls.Add(this.dataGridViewZavrseniObrazac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewObrazac);
            this.Controls.Add(this.ButtonZatvoriObrazac);
            this.Controls.Add(this.ButtonKreirajObrazac);
            this.Name = "ObrazacZaPrigovoreFrm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "ObrazacZaPrigovoreFrm";
            this.Load += new System.EventHandler(this.ObrazacZaPrigovoreFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZavrseniObrazac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObrazac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZavrseniObrazac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewObrazac;
        private System.Windows.Forms.Button ButtonZatvoriObrazac;
        private System.Windows.Forms.Button ButtonKreirajObrazac;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}