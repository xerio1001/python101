namespace Opdracht16Dario
{
    partial class FrmOpdracht16Dario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpdracht16Dario));
            this.LblGetal = new System.Windows.Forms.Label();
            this.TxtGetal = new System.Windows.Forms.TextBox();
            this.LblResultaat = new System.Windows.Forms.Label();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblGetal
            // 
            this.LblGetal.AutoSize = true;
            this.LblGetal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGetal.Location = new System.Drawing.Point(75, 35);
            this.LblGetal.Name = "LblGetal";
            this.LblGetal.Size = new System.Drawing.Size(56, 25);
            this.LblGetal.TabIndex = 0;
            this.LblGetal.Text = "Getal";
            // 
            // TxtGetal
            // 
            this.TxtGetal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGetal.Location = new System.Drawing.Point(75, 62);
            this.TxtGetal.Name = "TxtGetal";
            this.TxtGetal.Size = new System.Drawing.Size(100, 32);
            this.TxtGetal.TabIndex = 1;
            this.TxtGetal.Text = "1";
            this.TxtGetal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblResultaat
            // 
            this.LblResultaat.AutoSize = true;
            this.LblResultaat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResultaat.Location = new System.Drawing.Point(75, 118);
            this.LblResultaat.Name = "LblResultaat";
            this.LblResultaat.Size = new System.Drawing.Size(88, 25);
            this.LblResultaat.TabIndex = 2;
            this.LblResultaat.Text = "Resultaat";
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.AllowDrop = true;
            this.TxtResultaat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtResultaat.Cursor = System.Windows.Forms.Cursors.No;
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(75, 146);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(467, 255);
            this.TxtResultaat.TabIndex = 3;
            // 
            // BtnBereken
            // 
            this.BtnBereken.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBereken.Location = new System.Drawing.Point(561, 275);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(100, 38);
            this.BtnBereken.TabIndex = 4;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(561, 319);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(100, 38);
            this.BtnWissen.TabIndex = 5;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(561, 363);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(100, 38);
            this.BtnSluiten.TabIndex = 6;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmOpdracht16Dario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 416);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.LblResultaat);
            this.Controls.Add(this.TxtGetal);
            this.Controls.Add(this.LblGetal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpdracht16Dario";
            this.Text = "Machtsverheffing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblGetal;
        private TextBox TxtGetal;
        private Label LblResultaat;
        private TextBox TxtResultaat;
        private Button BtnBereken;
        private Button BtnWissen;
        private Button BtnSluiten;
    }
}