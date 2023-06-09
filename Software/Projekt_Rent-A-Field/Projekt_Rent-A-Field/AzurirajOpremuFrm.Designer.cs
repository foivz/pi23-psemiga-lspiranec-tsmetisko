namespace Projekt_Rent_A_Field
{
    partial class AzurirajOpremuFrm
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
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOdustaniOprema = new System.Windows.Forms.Button();
            this.buttonAzurirajOpremu = new System.Windows.Forms.Button();
            this.textBoxCijenaOpreme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImeOpreme = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cijena je izražena kao eur/h ";
            // 
            // buttonOdustaniOprema
            // 
            this.buttonOdustaniOprema.Location = new System.Drawing.Point(156, 111);
            this.buttonOdustaniOprema.Name = "buttonOdustaniOprema";
            this.buttonOdustaniOprema.Size = new System.Drawing.Size(75, 23);
            this.buttonOdustaniOprema.TabIndex = 28;
            this.buttonOdustaniOprema.Text = "Odustani";
            this.buttonOdustaniOprema.UseVisualStyleBackColor = true;
            this.buttonOdustaniOprema.Click += new System.EventHandler(this.buttonOdustaniOprema_Click);
            // 
            // buttonAzurirajOpremu
            // 
            this.buttonAzurirajOpremu.Location = new System.Drawing.Point(16, 111);
            this.buttonAzurirajOpremu.Name = "buttonAzurirajOpremu";
            this.buttonAzurirajOpremu.Size = new System.Drawing.Size(75, 23);
            this.buttonAzurirajOpremu.TabIndex = 27;
            this.buttonAzurirajOpremu.Text = "Ažuriraj";
            this.buttonAzurirajOpremu.UseVisualStyleBackColor = true;
            this.buttonAzurirajOpremu.Click += new System.EventHandler(this.buttonAzurirajOpremu_Click);
            // 
            // textBoxCijenaOpreme
            // 
            this.textBoxCijenaOpreme.Location = new System.Drawing.Point(58, 50);
            this.textBoxCijenaOpreme.Name = "textBoxCijenaOpreme";
            this.textBoxCijenaOpreme.Size = new System.Drawing.Size(173, 20);
            this.textBoxCijenaOpreme.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cijena:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ime:";
            // 
            // textBoxImeOpreme
            // 
            this.textBoxImeOpreme.Location = new System.Drawing.Point(58, 9);
            this.textBoxImeOpreme.Name = "textBoxImeOpreme";
            this.textBoxImeOpreme.Size = new System.Drawing.Size(173, 20);
            this.textBoxImeOpreme.TabIndex = 23;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\david\\Desktop\\Novo Dokument programa Microsoft Word.htm";
            // 
            // AzurirajOpremuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(250, 147);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonOdustaniOprema);
            this.Controls.Add(this.buttonAzurirajOpremu);
            this.Controls.Add(this.textBoxCijenaOpreme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxImeOpreme);
            this.Name = "AzurirajOpremuFrm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "AzurirajOpremuFrm";
            this.Load += new System.EventHandler(this.AzurirajOpremuFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOdustaniOprema;
        private System.Windows.Forms.Button buttonAzurirajOpremu;
        private System.Windows.Forms.TextBox textBoxCijenaOpreme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImeOpreme;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}