namespace Opdracht4Dario
{
    partial class Opdracht4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opdracht4));
            this.LblNummer = new System.Windows.Forms.Label();
            this.TxtNummer = new System.Windows.Forms.TextBox();
            this.BtnControle = new System.Windows.Forms.Button();
            this.LblGeldig = new System.Windows.Forms.Label();
            this.TxtGeldig = new System.Windows.Forms.TextBox();
            this.BtnLegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNummer
            // 
            this.LblNummer.AutoSize = true;
            this.LblNummer.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNummer.Location = new System.Drawing.Point(52, 18);
            this.LblNummer.Name = "LblNummer";
            this.LblNummer.Size = new System.Drawing.Size(172, 30);
            this.LblNummer.TabIndex = 0;
            this.LblNummer.Text = "Uw nummer: BE:";
            // 
            // TxtNummer
            // 
            this.TxtNummer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNummer.Location = new System.Drawing.Point(229, 12);
            this.TxtNummer.Name = "TxtNummer";
            this.TxtNummer.Size = new System.Drawing.Size(265, 36);
            this.TxtNummer.TabIndex = 1;
            // 
            // BtnControle
            // 
            this.BtnControle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnControle.Location = new System.Drawing.Point(229, 98);
            this.BtnControle.Name = "BtnControle";
            this.BtnControle.Size = new System.Drawing.Size(143, 36);
            this.BtnControle.TabIndex = 2;
            this.BtnControle.Text = "&Controleer";
            this.BtnControle.UseVisualStyleBackColor = true;
            this.BtnControle.Click += new System.EventHandler(this.BtnControle_Click);
            // 
            // LblGeldig
            // 
            this.LblGeldig.AutoSize = true;
            this.LblGeldig.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblGeldig.Location = new System.Drawing.Point(135, 60);
            this.LblGeldig.Name = "LblGeldig";
            this.LblGeldig.Size = new System.Drawing.Size(89, 30);
            this.LblGeldig.TabIndex = 3;
            this.LblGeldig.Text = "Geldig?:";
            // 
            // TxtGeldig
            // 
            this.TxtGeldig.Enabled = false;
            this.TxtGeldig.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGeldig.Location = new System.Drawing.Point(229, 54);
            this.TxtGeldig.Name = "TxtGeldig";
            this.TxtGeldig.Size = new System.Drawing.Size(100, 36);
            this.TxtGeldig.TabIndex = 4;
            // 
            // BtnLegen
            // 
            this.BtnLegen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLegen.Location = new System.Drawing.Point(139, 98);
            this.BtnLegen.Name = "BtnLegen";
            this.BtnLegen.Size = new System.Drawing.Size(85, 36);
            this.BtnLegen.TabIndex = 5;
            this.BtnLegen.Text = "&Legen";
            this.BtnLegen.UseVisualStyleBackColor = true;
            this.BtnLegen.Click += new System.EventHandler(this.BtnLegen_Click);
            // 
            // Opdracht4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 144);
            this.Controls.Add(this.BtnLegen);
            this.Controls.Add(this.TxtGeldig);
            this.Controls.Add(this.LblGeldig);
            this.Controls.Add(this.BtnControle);
            this.Controls.Add(this.TxtNummer);
            this.Controls.Add(this.LblNummer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Opdracht4";
            this.Text = "Controle ondernemingsnummer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblNummer;
        private TextBox TxtNummer;
        private Button BtnControle;
        private Label LblGeldig;
        private TextBox TxtGeldig;
        private Button BtnLegen;
    }
}