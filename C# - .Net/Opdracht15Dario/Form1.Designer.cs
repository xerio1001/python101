namespace Opdracht15Dario
{
    partial class FrmOpdracht15Dario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpdracht15Dario));
            this.TxtNaam = new System.Windows.Forms.TextBox();
            this.LblNaam = new System.Windows.Forms.Label();
            this.LblSeconden = new System.Windows.Forms.Label();
            this.TxtSeconden = new System.Windows.Forms.TextBox();
            this.LblOutput = new System.Windows.Forms.Label();
            this.BtnToevoegen = new System.Windows.Forms.Button();
            this.LblBackgroundTop = new System.Windows.Forms.Label();
            this.BtnSnelste = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNaam
            // 
            this.TxtNaam.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNaam.Location = new System.Drawing.Point(256, 41);
            this.TxtNaam.Name = "TxtNaam";
            this.TxtNaam.Size = new System.Drawing.Size(244, 32);
            this.TxtNaam.TabIndex = 0;
            // 
            // LblNaam
            // 
            this.LblNaam.AutoSize = true;
            this.LblNaam.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNaam.Location = new System.Drawing.Point(132, 44);
            this.LblNaam.Name = "LblNaam";
            this.LblNaam.Size = new System.Drawing.Size(118, 25);
            this.LblNaam.TabIndex = 1;
            this.LblNaam.Text = "Naam atleet:";
            // 
            // LblSeconden
            // 
            this.LblSeconden.AutoSize = true;
            this.LblSeconden.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSeconden.Location = new System.Drawing.Point(41, 100);
            this.LblSeconden.Name = "LblSeconden";
            this.LblSeconden.Size = new System.Drawing.Size(209, 25);
            this.LblSeconden.TabIndex = 2;
            this.LblSeconden.Text = "Totaal aantal seconden:";
            // 
            // TxtSeconden
            // 
            this.TxtSeconden.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSeconden.Location = new System.Drawing.Point(256, 97);
            this.TxtSeconden.Name = "TxtSeconden";
            this.TxtSeconden.Size = new System.Drawing.Size(244, 32);
            this.TxtSeconden.TabIndex = 3;
            // 
            // LblOutput
            // 
            this.LblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOutput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOutput.Location = new System.Drawing.Point(27, 182);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(334, 228);
            this.LblOutput.TabIndex = 4;
            // 
            // BtnToevoegen
            // 
            this.BtnToevoegen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnToevoegen.Location = new System.Drawing.Point(381, 260);
            this.BtnToevoegen.Name = "BtnToevoegen";
            this.BtnToevoegen.Size = new System.Drawing.Size(141, 33);
            this.BtnToevoegen.TabIndex = 5;
            this.BtnToevoegen.Text = "&Voeg toe";
            this.BtnToevoegen.UseVisualStyleBackColor = true;
            this.BtnToevoegen.Click += new System.EventHandler(this.BtnToevoegen_Click);
            // 
            // LblBackgroundTop
            // 
            this.LblBackgroundTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblBackgroundTop.Location = new System.Drawing.Point(27, 9);
            this.LblBackgroundTop.Name = "LblBackgroundTop";
            this.LblBackgroundTop.Size = new System.Drawing.Size(495, 159);
            this.LblBackgroundTop.TabIndex = 6;
            // 
            // BtnSnelste
            // 
            this.BtnSnelste.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSnelste.Location = new System.Drawing.Point(381, 299);
            this.BtnSnelste.Name = "BtnSnelste";
            this.BtnSnelste.Size = new System.Drawing.Size(141, 33);
            this.BtnSnelste.TabIndex = 7;
            this.BtnSnelste.Text = "Sn&elste atleet";
            this.BtnSnelste.UseVisualStyleBackColor = true;
            this.BtnSnelste.Click += new System.EventHandler(this.BtnSnelste_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(381, 338);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(141, 33);
            this.BtnWissen.TabIndex = 8;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(381, 377);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(141, 33);
            this.BtnSluiten.TabIndex = 9;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmOpdracht15Dario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 439);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnSnelste);
            this.Controls.Add(this.BtnToevoegen);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.TxtSeconden);
            this.Controls.Add(this.LblSeconden);
            this.Controls.Add(this.LblNaam);
            this.Controls.Add(this.TxtNaam);
            this.Controls.Add(this.LblBackgroundTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpdracht15Dario";
            this.Text = "Snelste Atleet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtNaam;
        private Label LblNaam;
        private Label LblSeconden;
        private TextBox TxtSeconden;
        private Label LblOutput;
        private Button BtnToevoegen;
        private Label LblBackgroundTop;
        private Button BtnSnelste;
        private Button BtnWissen;
        private Button BtnSluiten;
    }
}