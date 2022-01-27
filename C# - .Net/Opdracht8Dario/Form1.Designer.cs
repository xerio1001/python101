namespace Opdracht6Dario
{
    partial class FrmOpdracht6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpdracht6));
            this.LblPersoneel = new System.Windows.Forms.Label();
            this.LblUurloon = new System.Windows.Forms.Label();
            this.LblUren = new System.Windows.Forms.Label();
            this.TxtPersoneel = new System.Windows.Forms.TextBox();
            this.TxtUurloon = new System.Windows.Forms.TextBox();
            this.TxtUren = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.TxtReultaat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblPersoneel
            // 
            this.LblPersoneel.AutoSize = true;
            this.LblPersoneel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPersoneel.Location = new System.Drawing.Point(29, 40);
            this.LblPersoneel.Name = "LblPersoneel";
            this.LblPersoneel.Size = new System.Drawing.Size(144, 30);
            this.LblPersoneel.TabIndex = 0;
            this.LblPersoneel.Text = "Personeelslid:";
            this.LblPersoneel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblUurloon
            // 
            this.LblUurloon.AutoSize = true;
            this.LblUurloon.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUurloon.Location = new System.Drawing.Point(77, 87);
            this.LblUurloon.Name = "LblUurloon";
            this.LblUurloon.Size = new System.Drawing.Size(96, 30);
            this.LblUurloon.TabIndex = 1;
            this.LblUurloon.Text = "Uurloon:";
            this.LblUurloon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblUren
            // 
            this.LblUren.AutoSize = true;
            this.LblUren.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUren.Location = new System.Drawing.Point(12, 135);
            this.LblUren.Name = "LblUren";
            this.LblUren.Size = new System.Drawing.Size(161, 30);
            this.LblUren.TabIndex = 2;
            this.LblUren.Text = "Gewerkte uren:";
            this.LblUren.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtPersoneel
            // 
            this.TxtPersoneel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPersoneel.Location = new System.Drawing.Point(179, 40);
            this.TxtPersoneel.Multiline = true;
            this.TxtPersoneel.Name = "TxtPersoneel";
            this.TxtPersoneel.Size = new System.Drawing.Size(218, 30);
            this.TxtPersoneel.TabIndex = 3;
            // 
            // TxtUurloon
            // 
            this.TxtUurloon.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUurloon.Location = new System.Drawing.Point(179, 87);
            this.TxtUurloon.Multiline = true;
            this.TxtUurloon.Name = "TxtUurloon";
            this.TxtUurloon.Size = new System.Drawing.Size(218, 30);
            this.TxtUurloon.TabIndex = 4;
            // 
            // TxtUren
            // 
            this.TxtUren.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUren.Location = new System.Drawing.Point(179, 135);
            this.TxtUren.Multiline = true;
            this.TxtUren.Name = "TxtUren";
            this.TxtUren.Size = new System.Drawing.Size(218, 30);
            this.TxtUren.TabIndex = 5;
            // 
            // BtnBereken
            // 
            this.BtnBereken.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBereken.Location = new System.Drawing.Point(431, 40);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(75, 30);
            this.BtnBereken.TabIndex = 6;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(431, 87);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(75, 30);
            this.BtnWissen.TabIndex = 7;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(431, 135);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(75, 30);
            this.BtnSluiten.TabIndex = 8;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // TxtReultaat
            // 
            this.TxtReultaat.Enabled = false;
            this.TxtReultaat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtReultaat.Location = new System.Drawing.Point(12, 216);
            this.TxtReultaat.Multiline = true;
            this.TxtReultaat.Name = "TxtReultaat";
            this.TxtReultaat.Size = new System.Drawing.Size(494, 193);
            this.TxtReultaat.TabIndex = 9;
            // 
            // FrmOpdracht6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 434);
            this.Controls.Add(this.TxtReultaat);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtUren);
            this.Controls.Add(this.TxtUurloon);
            this.Controls.Add(this.TxtPersoneel);
            this.Controls.Add(this.LblUren);
            this.Controls.Add(this.LblUurloon);
            this.Controls.Add(this.LblPersoneel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpdracht6";
            this.Text = "Weddeberekening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblPersoneel;
        private Label LblUurloon;
        private Label LblUren;
        private TextBox TxtPersoneel;
        private TextBox TxtUurloon;
        private TextBox TxtUren;
        private Button BtnBereken;
        private Button BtnWissen;
        private Button BtnSluiten;
        private TextBox TxtReultaat;
    }
}