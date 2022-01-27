namespace Opdracht5Dario
{
    partial class FrmOpdracht5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpdracht5));
            this.LblNormaal = new System.Windows.Forms.Label();
            this.LblKorting = new System.Windows.Forms.Label();
            this.LblStudent = new System.Windows.Forms.Label();
            this.LblPrijs = new System.Windows.Forms.Label();
            this.TxtNormaal = new System.Windows.Forms.TextBox();
            this.TxtKorting = new System.Windows.Forms.TextBox();
            this.TxtStudent = new System.Windows.Forms.TextBox();
            this.TxtPrijs = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNormaal
            // 
            this.LblNormaal.AutoSize = true;
            this.LblNormaal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNormaal.Location = new System.Drawing.Point(12, 9);
            this.LblNormaal.Name = "LblNormaal";
            this.LblNormaal.Size = new System.Drawing.Size(160, 30);
            this.LblNormaal.TabIndex = 0;
            this.LblNormaal.Text = "Normaal Tarief:";
            this.LblNormaal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblKorting
            // 
            this.LblKorting.AutoSize = true;
            this.LblKorting.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblKorting.Location = new System.Drawing.Point(25, 61);
            this.LblKorting.Name = "LblKorting";
            this.LblKorting.Size = new System.Drawing.Size(147, 30);
            this.LblKorting.TabIndex = 1;
            this.LblKorting.Text = "Kortingstarief:";
            this.LblKorting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblStudent
            // 
            this.LblStudent.AutoSize = true;
            this.LblStudent.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStudent.Location = new System.Drawing.Point(13, 117);
            this.LblStudent.Name = "LblStudent";
            this.LblStudent.Size = new System.Drawing.Size(159, 30);
            this.LblStudent.TabIndex = 2;
            this.LblStudent.Text = "Studentenkaart";
            this.LblStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPrijs
            // 
            this.LblPrijs.AutoSize = true;
            this.LblPrijs.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPrijs.Location = new System.Drawing.Point(115, 173);
            this.LblPrijs.Name = "LblPrijs";
            this.LblPrijs.Size = new System.Drawing.Size(57, 30);
            this.LblPrijs.TabIndex = 3;
            this.LblPrijs.Text = "Prijs:";
            this.LblPrijs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtNormaal
            // 
            this.TxtNormaal.Location = new System.Drawing.Point(178, 9);
            this.TxtNormaal.Multiline = true;
            this.TxtNormaal.Name = "TxtNormaal";
            this.TxtNormaal.Size = new System.Drawing.Size(100, 30);
            this.TxtNormaal.TabIndex = 4;
            // 
            // TxtKorting
            // 
            this.TxtKorting.Location = new System.Drawing.Point(178, 61);
            this.TxtKorting.Multiline = true;
            this.TxtKorting.Name = "TxtKorting";
            this.TxtKorting.Size = new System.Drawing.Size(100, 30);
            this.TxtKorting.TabIndex = 5;
            // 
            // TxtStudent
            // 
            this.TxtStudent.Location = new System.Drawing.Point(178, 117);
            this.TxtStudent.Multiline = true;
            this.TxtStudent.Name = "TxtStudent";
            this.TxtStudent.Size = new System.Drawing.Size(100, 30);
            this.TxtStudent.TabIndex = 6;
            // 
            // TxtPrijs
            // 
            this.TxtPrijs.Enabled = false;
            this.TxtPrijs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPrijs.Location = new System.Drawing.Point(178, 173);
            this.TxtPrijs.Multiline = true;
            this.TxtPrijs.Name = "TxtPrijs";
            this.TxtPrijs.Size = new System.Drawing.Size(100, 30);
            this.TxtPrijs.TabIndex = 7;
            // 
            // BtnBereken
            // 
            this.BtnBereken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBereken.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBereken.Location = new System.Drawing.Point(324, 9);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(113, 30);
            this.BtnBereken.TabIndex = 8;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWissen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(324, 65);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(113, 30);
            this.BtnWissen.TabIndex = 9;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnAfsluiten
            // 
            this.BtnAfsluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAfsluiten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAfsluiten.Location = new System.Drawing.Point(324, 121);
            this.BtnAfsluiten.Name = "BtnAfsluiten";
            this.BtnAfsluiten.Size = new System.Drawing.Size(113, 30);
            this.BtnAfsluiten.TabIndex = 10;
            this.BtnAfsluiten.Text = "&Afsluiten";
            this.BtnAfsluiten.UseVisualStyleBackColor = true;
            this.BtnAfsluiten.Click += new System.EventHandler(this.BtnAfsluiten_Click);
            // 
            // FrmOpdracht5
            // 
            this.AcceptButton = this.BtnBereken;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 223);
            this.Controls.Add(this.BtnAfsluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtPrijs);
            this.Controls.Add(this.TxtStudent);
            this.Controls.Add(this.TxtKorting);
            this.Controls.Add(this.TxtNormaal);
            this.Controls.Add(this.LblPrijs);
            this.Controls.Add(this.LblStudent);
            this.Controls.Add(this.LblKorting);
            this.Controls.Add(this.LblNormaal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpdracht5";
            this.Text = "Film tickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblNormaal;
        private Label LblKorting;
        private Label LblStudent;
        private Label LblPrijs;
        private TextBox TxtNormaal;
        private TextBox TxtKorting;
        private TextBox TxtStudent;
        private TextBox TxtPrijs;
        private Button BtnBereken;
        private Button BtnWissen;
        private Button BtnAfsluiten;
    }
}