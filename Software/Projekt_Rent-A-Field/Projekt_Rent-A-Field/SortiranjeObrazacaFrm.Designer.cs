namespace Projekt_Rent_A_Field
{
    partial class SortiranjeObrazacaFrm
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
            this.ButtonobrisiZavrsene = new System.Windows.Forms.Button();
            this.ButtonZatvoriEvidenciju = new System.Windows.Forms.Button();
            this.ButtonEvidentiraj = new System.Windows.Forms.Button();
            this.dataGridViewZavrseniObrasci = new System.Windows.Forms.DataGridView();
            this.dataGridViewZaPregled = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZavrseniObrasci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaPregled)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonobrisiZavrsene
            // 
            this.ButtonobrisiZavrsene.Location = new System.Drawing.Point(42, 269);
            this.ButtonobrisiZavrsene.Name = "ButtonobrisiZavrsene";
            this.ButtonobrisiZavrsene.Size = new System.Drawing.Size(75, 23);
            this.ButtonobrisiZavrsene.TabIndex = 13;
            this.ButtonobrisiZavrsene.Text = "Brisi";
            this.ButtonobrisiZavrsene.UseVisualStyleBackColor = true;
            this.ButtonobrisiZavrsene.Click += new System.EventHandler(this.ButtonobrisiZavrsene_Click);
            // 
            // ButtonZatvoriEvidenciju
            // 
            this.ButtonZatvoriEvidenciju.Location = new System.Drawing.Point(515, 281);
            this.ButtonZatvoriEvidenciju.Name = "ButtonZatvoriEvidenciju";
            this.ButtonZatvoriEvidenciju.Size = new System.Drawing.Size(75, 23);
            this.ButtonZatvoriEvidenciju.TabIndex = 12;
            this.ButtonZatvoriEvidenciju.Text = "Zatvori";
            this.ButtonZatvoriEvidenciju.UseVisualStyleBackColor = true;
            this.ButtonZatvoriEvidenciju.Click += new System.EventHandler(this.ButtonZatvoriEvidenciju_Click);
            // 
            // ButtonEvidentiraj
            // 
            this.ButtonEvidentiraj.Location = new System.Drawing.Point(253, 263);
            this.ButtonEvidentiraj.Name = "ButtonEvidentiraj";
            this.ButtonEvidentiraj.Size = new System.Drawing.Size(97, 30);
            this.ButtonEvidentiraj.TabIndex = 11;
            this.ButtonEvidentiraj.Text = "Evidentiraj";
            this.ButtonEvidentiraj.UseVisualStyleBackColor = true;
            this.ButtonEvidentiraj.Click += new System.EventHandler(this.ButtonEvidentiraj_Click);
            // 
            // dataGridViewZavrseniObrasci
            // 
            this.dataGridViewZavrseniObrasci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZavrseniObrasci.Location = new System.Drawing.Point(318, 25);
            this.dataGridViewZavrseniObrasci.Name = "dataGridViewZavrseniObrasci";
            this.dataGridViewZavrseniObrasci.Size = new System.Drawing.Size(272, 216);
            this.dataGridViewZavrseniObrasci.TabIndex = 10;
            // 
            // dataGridViewZaPregled
            // 
            this.dataGridViewZaPregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZaPregled.Location = new System.Drawing.Point(10, 25);
            this.dataGridViewZaPregled.Name = "dataGridViewZaPregled";
            this.dataGridViewZaPregled.Size = new System.Drawing.Size(272, 216);
            this.dataGridViewZaPregled.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(419, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Završeni obrasci";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Obrasci za pregled";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\david\\source\\repos\\pi23-psemiga-lspiranec-tsmetisko\\Software\\Projekt_Ren" +
    "t-A-Field\\Projekt_Rent-A-Field\\Resources\\SortiranjeObrazacaProjekt.chm";
            // 
            // SortiranjeObrazacaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(600, 311);
            this.Controls.Add(this.ButtonobrisiZavrsene);
            this.Controls.Add(this.ButtonZatvoriEvidenciju);
            this.Controls.Add(this.ButtonEvidentiraj);
            this.Controls.Add(this.dataGridViewZavrseniObrasci);
            this.Controls.Add(this.dataGridViewZaPregled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SortiranjeObrazacaFrm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Sortiranje obrazaca";
            this.Load += new System.EventHandler(this.SortiranjeObrazacaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZavrseniObrasci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaPregled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonobrisiZavrsene;
        private System.Windows.Forms.Button ButtonZatvoriEvidenciju;
        private System.Windows.Forms.Button ButtonEvidentiraj;
        public System.Windows.Forms.DataGridView dataGridViewZavrseniObrasci;
        private System.Windows.Forms.DataGridView dataGridViewZaPregled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}