namespace Opdracht1Dario
{
    partial class FrmOmzetten
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOmzetten));
            this.LblEuro = new System.Windows.Forms.Label();
            this.LblBef = new System.Windows.Forms.Label();
            this.TxtEuro = new System.Windows.Forms.TextBox();
            this.TxtBEF = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnLegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEuro
            // 
            this.LblEuro.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEuro.Location = new System.Drawing.Point(23, 26);
            this.LblEuro.Name = "LblEuro";
            this.LblEuro.Size = new System.Drawing.Size(150, 20);
            this.LblEuro.TabIndex = 0;
            this.LblEuro.Text = "Bedrag in euro:";
            // 
            // LblBef
            // 
            this.LblBef.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblBef.Location = new System.Drawing.Point(23, 54);
            this.LblBef.Name = "LblBef";
            this.LblBef.Size = new System.Drawing.Size(150, 20);
            this.LblBef.TabIndex = 1;
            this.LblBef.Text = "Bedrag in BEF:";
            // 
            // TxtEuro
            // 
            this.TxtEuro.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtEuro.Location = new System.Drawing.Point(171, 23);
            this.TxtEuro.Name = "TxtEuro";
            this.TxtEuro.Size = new System.Drawing.Size(120, 23);
            this.TxtEuro.TabIndex = 2;
            // 
            // TxtBEF
            // 
            this.TxtBEF.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBEF.Location = new System.Drawing.Point(171, 51);
            this.TxtBEF.Name = "TxtBEF";
            this.TxtBEF.Size = new System.Drawing.Size(120, 23);
            this.TxtBEF.TabIndex = 3;
            // 
            // BtnBereken
            // 
            this.BtnBereken.Location = new System.Drawing.Point(23, 85);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(75, 23);
            this.BtnBereken.TabIndex = 4;
            this.BtnBereken.Text = "Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnLegen
            // 
            this.BtnLegen.Location = new System.Drawing.Point(171, 85);
            this.BtnLegen.Name = "BtnLegen";
            this.BtnLegen.Size = new System.Drawing.Size(75, 23);
            this.BtnLegen.TabIndex = 5;
            this.BtnLegen.Text = "Legen";
            this.BtnLegen.UseVisualStyleBackColor = true;
            this.BtnLegen.Click += new System.EventHandler(this.BtnLegen_Click);
            // 
            // FrmOmzetten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 131);
            this.Controls.Add(this.BtnLegen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtBEF);
            this.Controls.Add(this.TxtEuro);
            this.Controls.Add(this.LblBef);
            this.Controls.Add(this.LblEuro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOmzetten";
            this.Text = "Euro omzetten naar BEF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblEuro;
        private Label LblBef;
        private TextBox TxtEuro;
        private TextBox TxtBEF;
        private Button BtnBereken;
        private Button BtnLegen;
    }
}