namespace Opdracht9Dario
{
    partial class FrmCursusGeld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursusGeld));
            this.LblJaar = new System.Windows.Forms.Label();
            this.LblLesuren = new System.Windows.Forms.Label();
            this.LblCursusGeld = new System.Windows.Forms.Label();
            this.TxtJaar = new System.Windows.Forms.TextBox();
            this.TxtLesuren = new System.Windows.Forms.TextBox();
            this.TxtCursusGeld = new System.Windows.Forms.TextBox();
            this.BtnTestNumeriek = new System.Windows.Forms.Button();
            this.BtnBerkenen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.LblNumeriek = new System.Windows.Forms.Label();
            this.Lblschrikkeljaar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblJaar
            // 
            this.LblJaar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblJaar.Location = new System.Drawing.Point(40, 43);
            this.LblJaar.Name = "LblJaar";
            this.LblJaar.Size = new System.Drawing.Size(155, 30);
            this.LblJaar.TabIndex = 0;
            this.LblJaar.Text = "Jaar:";
            this.LblJaar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblLesuren
            // 
            this.LblLesuren.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLesuren.Location = new System.Drawing.Point(40, 90);
            this.LblLesuren.Name = "LblLesuren";
            this.LblLesuren.Size = new System.Drawing.Size(155, 30);
            this.LblLesuren.TabIndex = 1;
            this.LblLesuren.Text = "Aantal lesuren:";
            this.LblLesuren.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCursusGeld
            // 
            this.LblCursusGeld.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCursusGeld.Location = new System.Drawing.Point(40, 139);
            this.LblCursusGeld.Name = "LblCursusGeld";
            this.LblCursusGeld.Size = new System.Drawing.Size(155, 30);
            this.LblCursusGeld.TabIndex = 2;
            this.LblCursusGeld.Text = "Cursusgeld:";
            this.LblCursusGeld.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtJaar
            // 
            this.TxtJaar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtJaar.Location = new System.Drawing.Point(209, 43);
            this.TxtJaar.Multiline = true;
            this.TxtJaar.Name = "TxtJaar";
            this.TxtJaar.Size = new System.Drawing.Size(130, 30);
            this.TxtJaar.TabIndex = 3;
            this.TxtJaar.TextChanged += new System.EventHandler(this.TxtJaar_TextChanged);
            // 
            // TxtLesuren
            // 
            this.TxtLesuren.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtLesuren.Location = new System.Drawing.Point(209, 90);
            this.TxtLesuren.Multiline = true;
            this.TxtLesuren.Name = "TxtLesuren";
            this.TxtLesuren.Size = new System.Drawing.Size(79, 30);
            this.TxtLesuren.TabIndex = 4;
            // 
            // TxtCursusGeld
            // 
            this.TxtCursusGeld.Enabled = false;
            this.TxtCursusGeld.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCursusGeld.Location = new System.Drawing.Point(209, 139);
            this.TxtCursusGeld.Multiline = true;
            this.TxtCursusGeld.Name = "TxtCursusGeld";
            this.TxtCursusGeld.Size = new System.Drawing.Size(130, 30);
            this.TxtCursusGeld.TabIndex = 5;
            // 
            // BtnTestNumeriek
            // 
            this.BtnTestNumeriek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTestNumeriek.Location = new System.Drawing.Point(60, 198);
            this.BtnTestNumeriek.Name = "BtnTestNumeriek";
            this.BtnTestNumeriek.Size = new System.Drawing.Size(130, 30);
            this.BtnTestNumeriek.TabIndex = 6;
            this.BtnTestNumeriek.Text = "&Test numeriek";
            this.BtnTestNumeriek.UseVisualStyleBackColor = true;
            this.BtnTestNumeriek.Click += new System.EventHandler(this.BtnTestNumeriek_Click);
            // 
            // BtnBerkenen
            // 
            this.BtnBerkenen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBerkenen.Location = new System.Drawing.Point(209, 198);
            this.BtnBerkenen.Name = "BtnBerkenen";
            this.BtnBerkenen.Size = new System.Drawing.Size(130, 30);
            this.BtnBerkenen.TabIndex = 7;
            this.BtnBerkenen.Text = "&Berekenen";
            this.BtnBerkenen.UseVisualStyleBackColor = true;
            this.BtnBerkenen.Click += new System.EventHandler(this.BtnBerkenen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(359, 198);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(130, 30);
            this.BtnSluiten.TabIndex = 8;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // LblNumeriek
            // 
            this.LblNumeriek.AutoSize = true;
            this.LblNumeriek.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNumeriek.Location = new System.Drawing.Point(359, 90);
            this.LblNumeriek.Name = "LblNumeriek";
            this.LblNumeriek.Size = new System.Drawing.Size(114, 25);
            this.LblNumeriek.TabIndex = 9;
            this.LblNumeriek.Text = "Is numeriek!";
            this.LblNumeriek.Visible = false;
            // 
            // Lblschrikkeljaar
            // 
            this.Lblschrikkeljaar.AutoSize = true;
            this.Lblschrikkeljaar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lblschrikkeljaar.Location = new System.Drawing.Point(359, 43);
            this.Lblschrikkeljaar.Name = "Lblschrikkeljaar";
            this.Lblschrikkeljaar.Size = new System.Drawing.Size(176, 25);
            this.Lblschrikkeljaar.TabIndex = 10;
            this.Lblschrikkeljaar.Text = "Is een schrikkeljaar!";
            this.Lblschrikkeljaar.Visible = false;
            // 
            // FrmCursusGeld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 256);
            this.Controls.Add(this.Lblschrikkeljaar);
            this.Controls.Add(this.LblNumeriek);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnBerkenen);
            this.Controls.Add(this.BtnTestNumeriek);
            this.Controls.Add(this.TxtCursusGeld);
            this.Controls.Add(this.TxtLesuren);
            this.Controls.Add(this.TxtJaar);
            this.Controls.Add(this.LblCursusGeld);
            this.Controls.Add(this.LblLesuren);
            this.Controls.Add(this.LblJaar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCursusGeld";
            this.Text = "Cursus geld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblJaar;
        private Label LblLesuren;
        private Label LblCursusGeld;
        private TextBox TxtJaar;
        private TextBox TxtLesuren;
        private TextBox TxtCursusGeld;
        private Button BtnTestNumeriek;
        private Button BtnBerkenen;
        private Button BtnSluiten;
        private Label LblNumeriek;
        private Label Lblschrikkeljaar;
    }
}