namespace Opdracht2Dario
{
    partial class Opdracht2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opdracht2));
            this.LblStraal = new System.Windows.Forms.Label();
            this.LblOppervalkte = new System.Windows.Forms.Label();
            this.LblOmtrek = new System.Windows.Forms.Label();
            this.TxtStraal = new System.Windows.Forms.TextBox();
            this.TxtOppervlakte = new System.Windows.Forms.TextBox();
            this.TxtOmtrek = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnLegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblStraal
            // 
            this.LblStraal.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblStraal.Location = new System.Drawing.Point(26, 9);
            this.LblStraal.Name = "LblStraal";
            this.LblStraal.Size = new System.Drawing.Size(200, 30);
            this.LblStraal.TabIndex = 0;
            this.LblStraal.Text = " Straal (In cm)";
            this.LblStraal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblOppervalkte
            // 
            this.LblOppervalkte.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblOppervalkte.Location = new System.Drawing.Point(26, 45);
            this.LblOppervalkte.Name = "LblOppervalkte";
            this.LblOppervalkte.Size = new System.Drawing.Size(200, 30);
            this.LblOppervalkte.TabIndex = 1;
            this.LblOppervalkte.Text = "Oppervlakte (cm²)";
            this.LblOppervalkte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblOmtrek
            // 
            this.LblOmtrek.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblOmtrek.Location = new System.Drawing.Point(26, 80);
            this.LblOmtrek.Name = "LblOmtrek";
            this.LblOmtrek.Size = new System.Drawing.Size(200, 30);
            this.LblOmtrek.TabIndex = 2;
            this.LblOmtrek.Text = "Omtrek (in cm)";
            this.LblOmtrek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtStraal
            // 
            this.TxtStraal.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TxtStraal.Location = new System.Drawing.Point(232, 9);
            this.TxtStraal.Multiline = true;
            this.TxtStraal.Name = "TxtStraal";
            this.TxtStraal.Size = new System.Drawing.Size(120, 30);
            this.TxtStraal.TabIndex = 3;
            this.TxtStraal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtOppervlakte
            // 
            this.TxtOppervlakte.Enabled = false;
            this.TxtOppervlakte.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TxtOppervlakte.Location = new System.Drawing.Point(232, 45);
            this.TxtOppervlakte.Multiline = true;
            this.TxtOppervlakte.Name = "TxtOppervlakte";
            this.TxtOppervlakte.Size = new System.Drawing.Size(120, 30);
            this.TxtOppervlakte.TabIndex = 4;
            this.TxtOppervlakte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtOmtrek
            // 
            this.TxtOmtrek.Enabled = false;
            this.TxtOmtrek.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TxtOmtrek.Location = new System.Drawing.Point(232, 80);
            this.TxtOmtrek.Multiline = true;
            this.TxtOmtrek.Name = "TxtOmtrek";
            this.TxtOmtrek.Size = new System.Drawing.Size(120, 30);
            this.TxtOmtrek.TabIndex = 5;
            this.TxtOmtrek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnBereken
            // 
            this.BtnBereken.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBereken.Location = new System.Drawing.Point(26, 122);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(120, 40);
            this.BtnBereken.TabIndex = 6;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnLegen
            // 
            this.BtnLegen.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLegen.Location = new System.Drawing.Point(232, 122);
            this.BtnLegen.Name = "BtnLegen";
            this.BtnLegen.Size = new System.Drawing.Size(120, 40);
            this.BtnLegen.TabIndex = 7;
            this.BtnLegen.Text = "&Legen";
            this.BtnLegen.UseVisualStyleBackColor = true;
            this.BtnLegen.Click += new System.EventHandler(this.BtnLegen_Click);
            // 
            // Opdracht2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 174);
            this.Controls.Add(this.BtnLegen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtOmtrek);
            this.Controls.Add(this.TxtOppervlakte);
            this.Controls.Add(this.TxtStraal);
            this.Controls.Add(this.LblOmtrek);
            this.Controls.Add(this.LblOppervalkte);
            this.Controls.Add(this.LblStraal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Opdracht2";
            this.Text = "Cirkel omtrek en oppervlakte berekenen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblStraal;
        private Label LblOppervalkte;
        private Label LblOmtrek;
        private TextBox TxtStraal;
        private TextBox TxtOppervlakte;
        private TextBox TxtOmtrek;
        private Button BtnBereken;
        private Button BtnLegen;
    }
}