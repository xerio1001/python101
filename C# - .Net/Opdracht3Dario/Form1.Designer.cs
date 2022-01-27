namespace Opdracht3Dario
{
    partial class Form1
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
            this.LblGetal1 = new System.Windows.Forms.Label();
            this.LblGetal2 = new System.Windows.Forms.Label();
            this.TxtGetal1 = new System.Windows.Forms.TextBox();
            this.TxtGetal2 = new System.Windows.Forms.TextBox();
            this.LblResultaat = new System.Windows.Forms.Label();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnMaal = new System.Windows.Forms.Button();
            this.BtnDelen = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblGetal1
            // 
            this.LblGetal1.AutoSize = true;
            this.LblGetal1.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblGetal1.Location = new System.Drawing.Point(25, 25);
            this.LblGetal1.Name = "LblGetal1";
            this.LblGetal1.Size = new System.Drawing.Size(89, 25);
            this.LblGetal1.TabIndex = 0;
            this.LblGetal1.Text = "Getal 1:";
            this.LblGetal1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblGetal2
            // 
            this.LblGetal2.AutoSize = true;
            this.LblGetal2.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblGetal2.Location = new System.Drawing.Point(25, 73);
            this.LblGetal2.Name = "LblGetal2";
            this.LblGetal2.Size = new System.Drawing.Size(89, 25);
            this.LblGetal2.TabIndex = 1;
            this.LblGetal2.Text = "Getal 2:";
            this.LblGetal2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtGetal1
            // 
            this.TxtGetal1.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtGetal1.Location = new System.Drawing.Point(121, 12);
            this.TxtGetal1.Name = "TxtGetal1";
            this.TxtGetal1.Size = new System.Drawing.Size(130, 38);
            this.TxtGetal1.TabIndex = 2;
            // 
            // TxtGetal2
            // 
            this.TxtGetal2.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtGetal2.Location = new System.Drawing.Point(121, 60);
            this.TxtGetal2.Name = "TxtGetal2";
            this.TxtGetal2.Size = new System.Drawing.Size(130, 38);
            this.TxtGetal2.TabIndex = 3;
            // 
            // LblResultaat
            // 
            this.LblResultaat.AutoSize = true;
            this.LblResultaat.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblResultaat.Location = new System.Drawing.Point(12, 144);
            this.LblResultaat.Name = "LblResultaat";
            this.LblResultaat.Size = new System.Drawing.Size(102, 25);
            this.LblResultaat.TabIndex = 4;
            this.LblResultaat.Text = "Reultaat:";
            this.LblResultaat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(121, 131);
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(130, 38);
            this.TxtResultaat.TabIndex = 5;
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnReset.Location = new System.Drawing.Point(303, 137);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(88, 32);
            this.BtnReset.TabIndex = 6;
            this.BtnReset.Text = "&Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPlus.Location = new System.Drawing.Point(314, 23);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Padding = new System.Windows.Forms.Padding(1);
            this.BtnPlus.Size = new System.Drawing.Size(23, 27);
            this.BtnPlus.TabIndex = 7;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnMaal
            // 
            this.BtnMaal.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMaal.Location = new System.Drawing.Point(355, 23);
            this.BtnMaal.Name = "BtnMaal";
            this.BtnMaal.Padding = new System.Windows.Forms.Padding(1);
            this.BtnMaal.Size = new System.Drawing.Size(23, 27);
            this.BtnMaal.TabIndex = 8;
            this.BtnMaal.Text = "X";
            this.BtnMaal.UseVisualStyleBackColor = true;
            this.BtnMaal.Click += new System.EventHandler(this.BtnMaal_Click);
            // 
            // BtnDelen
            // 
            this.BtnDelen.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDelen.Location = new System.Drawing.Point(355, 71);
            this.BtnDelen.Name = "BtnDelen";
            this.BtnDelen.Padding = new System.Windows.Forms.Padding(1);
            this.BtnDelen.Size = new System.Drawing.Size(23, 27);
            this.BtnDelen.TabIndex = 10;
            this.BtnDelen.Text = "/";
            this.BtnDelen.UseVisualStyleBackColor = true;
            this.BtnDelen.Click += new System.EventHandler(this.BtnDelen_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMin.Location = new System.Drawing.Point(314, 71);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Padding = new System.Windows.Forms.Padding(1);
            this.BtnMin.Size = new System.Drawing.Size(23, 27);
            this.BtnMin.TabIndex = 9;
            this.BtnMin.Text = "-";
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 194);
            this.Controls.Add(this.BtnDelen);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.BtnMaal);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.LblResultaat);
            this.Controls.Add(this.TxtGetal2);
            this.Controls.Add(this.TxtGetal1);
            this.Controls.Add(this.LblGetal2);
            this.Controls.Add(this.LblGetal1);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblGetal1;
        private Label LblGetal2;
        private TextBox TxtGetal1;
        private TextBox TxtGetal2;
        private Label LblResultaat;
        private TextBox TxtResultaat;
        private Button BtnReset;
        private Button BtnPlus;
        private Button BtnMaal;
        private Button BtnDelen;
        private Button BtnMin;
    }
}