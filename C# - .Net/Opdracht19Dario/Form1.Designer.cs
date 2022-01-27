namespace Opdracht19Dario
{
    partial class FrmOpdracht19Dario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpdracht19Dario));
            this.LblTitelAantalPers = new System.Windows.Forms.Label();
            this.TxtAantalPersonen = new System.Windows.Forms.TextBox();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnBerekenen = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitelAantalPers
            // 
            this.LblTitelAantalPers.AutoSize = true;
            this.LblTitelAantalPers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitelAantalPers.Location = new System.Drawing.Point(38, 39);
            this.LblTitelAantalPers.Name = "LblTitelAantalPers";
            this.LblTitelAantalPers.Size = new System.Drawing.Size(150, 25);
            this.LblTitelAantalPers.TabIndex = 0;
            this.LblTitelAantalPers.Text = "Aantal personen";
            // 
            // TxtAantalPersonen
            // 
            this.TxtAantalPersonen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAantalPersonen.Location = new System.Drawing.Point(38, 67);
            this.TxtAantalPersonen.Name = "TxtAantalPersonen";
            this.TxtAantalPersonen.Size = new System.Drawing.Size(100, 32);
            this.TxtAantalPersonen.TabIndex = 1;
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(38, 146);
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(473, 32);
            this.TxtResultaat.TabIndex = 2;
            // 
            // BtnBerekenen
            // 
            this.BtnBerekenen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBerekenen.Location = new System.Drawing.Point(38, 216);
            this.BtnBerekenen.Name = "BtnBerekenen";
            this.BtnBerekenen.Size = new System.Drawing.Size(137, 42);
            this.BtnBerekenen.TabIndex = 3;
            this.BtnBerekenen.Text = "&Berekenen";
            this.BtnBerekenen.UseVisualStyleBackColor = true;
            this.BtnBerekenen.Click += new System.EventHandler(this.BtnBerekenen_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(205, 216);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(137, 42);
            this.BtnWissen.TabIndex = 4;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(374, 216);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(137, 42);
            this.BtnSluiten.TabIndex = 5;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmOpdracht19Dario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 328);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBerekenen);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.TxtAantalPersonen);
            this.Controls.Add(this.LblTitelAantalPers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpdracht19Dario";
            this.Text = "Berekening van de kans op een \"dubbel\"feest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblTitelAantalPers;
        private TextBox TxtAantalPersonen;
        private TextBox TxtResultaat;
        private Button BtnBerekenen;
        private Button BtnWissen;
        private Button BtnSluiten;
    }
}