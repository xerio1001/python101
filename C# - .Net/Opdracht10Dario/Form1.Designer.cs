namespace Opdracht7Dario
{
    partial class FrmOpdracht7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpdracht7));
            this.LblBestemming = new System.Windows.Forms.Label();
            this.LblBasisVlucht = new System.Windows.Forms.Label();
            this.LblKlasse = new System.Windows.Forms.Label();
            this.LblBasisPrijs = new System.Windows.Forms.Label();
            this.LblKortingPercentage = new System.Windows.Forms.Label();
            this.LblAantalPersonen = new System.Windows.Forms.Label();
            this.LblDagen = new System.Windows.Forms.Label();
            this.TxtBestemming = new System.Windows.Forms.TextBox();
            this.TxtBasisVlucht = new System.Windows.Forms.TextBox();
            this.TxtBasisPrijs = new System.Windows.Forms.TextBox();
            this.TxtKlasse = new System.Windows.Forms.TextBox();
            this.TxtKortingsPercentage = new System.Windows.Forms.TextBox();
            this.TxtAantalPersonen = new System.Windows.Forms.TextBox();
            this.TxtAantalDagen = new System.Windows.Forms.TextBox();
            this.BtnBerkenen = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblBestemming
            // 
            this.LblBestemming.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBestemming.Location = new System.Drawing.Point(12, 35);
            this.LblBestemming.Name = "LblBestemming";
            this.LblBestemming.Size = new System.Drawing.Size(210, 30);
            this.LblBestemming.TabIndex = 0;
            this.LblBestemming.Text = "Bestemming";
            this.LblBestemming.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblBasisVlucht
            // 
            this.LblBasisVlucht.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBasisVlucht.Location = new System.Drawing.Point(12, 73);
            this.LblBasisVlucht.Name = "LblBasisVlucht";
            this.LblBasisVlucht.Size = new System.Drawing.Size(210, 30);
            this.LblBasisVlucht.TabIndex = 1;
            this.LblBasisVlucht.Text = "Basisvlucht prijs";
            this.LblBasisVlucht.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblKlasse
            // 
            this.LblKlasse.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblKlasse.Location = new System.Drawing.Point(12, 111);
            this.LblKlasse.Name = "LblKlasse";
            this.LblKlasse.Size = new System.Drawing.Size(210, 30);
            this.LblKlasse.TabIndex = 2;
            this.LblKlasse.Text = "Vluchtklasse (1, 2 of 3)";
            this.LblKlasse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblBasisPrijs
            // 
            this.LblBasisPrijs.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBasisPrijs.Location = new System.Drawing.Point(12, 149);
            this.LblBasisPrijs.Name = "LblBasisPrijs";
            this.LblBasisPrijs.Size = new System.Drawing.Size(210, 30);
            this.LblBasisPrijs.TabIndex = 3;
            this.LblBasisPrijs.Text = "Basisprijs per dag";
            this.LblBasisPrijs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblKortingPercentage
            // 
            this.LblKortingPercentage.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblKortingPercentage.Location = new System.Drawing.Point(12, 265);
            this.LblKortingPercentage.Name = "LblKortingPercentage";
            this.LblKortingPercentage.Size = new System.Drawing.Size(210, 30);
            this.LblKortingPercentage.TabIndex = 4;
            this.LblKortingPercentage.Text = "Kortingpercentage";
            this.LblKortingPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblAantalPersonen
            // 
            this.LblAantalPersonen.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAantalPersonen.Location = new System.Drawing.Point(12, 226);
            this.LblAantalPersonen.Name = "LblAantalPersonen";
            this.LblAantalPersonen.Size = new System.Drawing.Size(210, 30);
            this.LblAantalPersonen.TabIndex = 5;
            this.LblAantalPersonen.Text = "Aantal personen";
            this.LblAantalPersonen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDagen
            // 
            this.LblDagen.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDagen.Location = new System.Drawing.Point(12, 188);
            this.LblDagen.Name = "LblDagen";
            this.LblDagen.Size = new System.Drawing.Size(210, 30);
            this.LblDagen.TabIndex = 6;
            this.LblDagen.Text = "Aantal dagen";
            this.LblDagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBestemming
            // 
            this.TxtBestemming.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBestemming.Location = new System.Drawing.Point(228, 35);
            this.TxtBestemming.Multiline = true;
            this.TxtBestemming.Name = "TxtBestemming";
            this.TxtBestemming.Size = new System.Drawing.Size(157, 30);
            this.TxtBestemming.TabIndex = 7;
            this.TxtBestemming.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBasisVlucht
            // 
            this.TxtBasisVlucht.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBasisVlucht.Location = new System.Drawing.Point(228, 73);
            this.TxtBasisVlucht.Multiline = true;
            this.TxtBasisVlucht.Name = "TxtBasisVlucht";
            this.TxtBasisVlucht.Size = new System.Drawing.Size(157, 30);
            this.TxtBasisVlucht.TabIndex = 8;
            this.TxtBasisVlucht.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBasisPrijs
            // 
            this.TxtBasisPrijs.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBasisPrijs.Location = new System.Drawing.Point(228, 149);
            this.TxtBasisPrijs.Multiline = true;
            this.TxtBasisPrijs.Name = "TxtBasisPrijs";
            this.TxtBasisPrijs.Size = new System.Drawing.Size(157, 30);
            this.TxtBasisPrijs.TabIndex = 10;
            this.TxtBasisPrijs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtKlasse
            // 
            this.TxtKlasse.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtKlasse.Location = new System.Drawing.Point(228, 111);
            this.TxtKlasse.Multiline = true;
            this.TxtKlasse.Name = "TxtKlasse";
            this.TxtKlasse.Size = new System.Drawing.Size(157, 30);
            this.TxtKlasse.TabIndex = 9;
            this.TxtKlasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtKlasse.Click += new System.EventHandler(this.TxtKlasse_Click);
            // 
            // TxtKortingsPercentage
            // 
            this.TxtKortingsPercentage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtKortingsPercentage.Location = new System.Drawing.Point(228, 265);
            this.TxtKortingsPercentage.Multiline = true;
            this.TxtKortingsPercentage.Name = "TxtKortingsPercentage";
            this.TxtKortingsPercentage.Size = new System.Drawing.Size(157, 30);
            this.TxtKortingsPercentage.TabIndex = 13;
            this.TxtKortingsPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtAantalPersonen
            // 
            this.TxtAantalPersonen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAantalPersonen.Location = new System.Drawing.Point(228, 226);
            this.TxtAantalPersonen.Multiline = true;
            this.TxtAantalPersonen.Name = "TxtAantalPersonen";
            this.TxtAantalPersonen.Size = new System.Drawing.Size(157, 30);
            this.TxtAantalPersonen.TabIndex = 12;
            this.TxtAantalPersonen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtAantalDagen
            // 
            this.TxtAantalDagen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAantalDagen.Location = new System.Drawing.Point(228, 188);
            this.TxtAantalDagen.Multiline = true;
            this.TxtAantalDagen.Name = "TxtAantalDagen";
            this.TxtAantalDagen.Size = new System.Drawing.Size(157, 30);
            this.TxtAantalDagen.TabIndex = 11;
            this.TxtAantalDagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnBerkenen
            // 
            this.BtnBerkenen.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBerkenen.Location = new System.Drawing.Point(524, 149);
            this.BtnBerkenen.Name = "BtnBerkenen";
            this.BtnBerkenen.Size = new System.Drawing.Size(104, 38);
            this.BtnBerkenen.TabIndex = 15;
            this.BtnBerkenen.Text = "&Berkenen";
            this.BtnBerkenen.UseVisualStyleBackColor = true;
            this.BtnBerkenen.Click += new System.EventHandler(this.BtnBerkenen_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(524, 193);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(104, 38);
            this.BtnWissen.TabIndex = 16;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(524, 237);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(104, 38);
            this.BtnSluiten.TabIndex = 17;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(52, 340);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(576, 247);
            this.TxtResultaat.TabIndex = 18;
            // 
            // FrmOpdracht7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 599);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBerkenen);
            this.Controls.Add(this.TxtKortingsPercentage);
            this.Controls.Add(this.TxtAantalPersonen);
            this.Controls.Add(this.TxtAantalDagen);
            this.Controls.Add(this.TxtBasisPrijs);
            this.Controls.Add(this.TxtKlasse);
            this.Controls.Add(this.TxtBasisVlucht);
            this.Controls.Add(this.TxtBestemming);
            this.Controls.Add(this.LblDagen);
            this.Controls.Add(this.LblAantalPersonen);
            this.Controls.Add(this.LblKortingPercentage);
            this.Controls.Add(this.LblBasisPrijs);
            this.Controls.Add(this.LblKlasse);
            this.Controls.Add(this.LblBasisVlucht);
            this.Controls.Add(this.LblBestemming);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpdracht7";
            this.Text = "Berekening reiskosten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblBestemming;
        private Label LblBasisVlucht;
        private Label LblKlasse;
        private Label LblBasisPrijs;
        private Label LblKortingPercentage;
        private Label LblAantalPersonen;
        private Label LblDagen;
        private TextBox TxtBestemming;
        private TextBox TxtBasisVlucht;
        private TextBox TxtBasisPrijs;
        private TextBox TxtKlasse;
        private TextBox TxtKortingsPercentage;
        private TextBox TxtAantalPersonen;
        private TextBox TxtAantalDagen;
        private Button BtnBerkenen;
        private Button BtnWissen;
        private Button BtnSluiten;
        private TextBox TxtResultaat;
    }
}