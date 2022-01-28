namespace Opdracht21Dario
{
    partial class FrmOpdracht21Dario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpdracht21Dario));
            this.LblTitelMaxWaarde = new System.Windows.Forms.Label();
            this.TxtMaxWaarde = new System.Windows.Forms.TextBox();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnOptellen = new System.Windows.Forms.Button();
            this.BtnVermenigvuldigen = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitelMaxWaarde
            // 
            this.LblTitelMaxWaarde.AutoSize = true;
            this.LblTitelMaxWaarde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitelMaxWaarde.Location = new System.Drawing.Point(726, 45);
            this.LblTitelMaxWaarde.Name = "LblTitelMaxWaarde";
            this.LblTitelMaxWaarde.Size = new System.Drawing.Size(99, 21);
            this.LblTitelMaxWaarde.TabIndex = 0;
            this.LblTitelMaxWaarde.Text = "Maxwaarde";
            // 
            // TxtMaxWaarde
            // 
            this.TxtMaxWaarde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtMaxWaarde.Location = new System.Drawing.Point(726, 69);
            this.TxtMaxWaarde.Name = "TxtMaxWaarde";
            this.TxtMaxWaarde.Size = new System.Drawing.Size(99, 29);
            this.TxtMaxWaarde.TabIndex = 1;
            this.TxtMaxWaarde.Text = "10";
            this.TxtMaxWaarde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(32, 45);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(660, 345);
            this.TxtResultaat.TabIndex = 2;
            // 
            // BtnOptellen
            // 
            this.BtnOptellen.Cursor = System.Windows.Forms.Cursors.Cross;
            this.BtnOptellen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnOptellen.Location = new System.Drawing.Point(698, 188);
            this.BtnOptellen.Name = "BtnOptellen";
            this.BtnOptellen.Size = new System.Drawing.Size(166, 46);
            this.BtnOptellen.TabIndex = 3;
            this.BtnOptellen.Text = "&Optellen";
            this.BtnOptellen.UseVisualStyleBackColor = true;
            this.BtnOptellen.Click += new System.EventHandler(this.BtnOptellen_Click);
            // 
            // BtnVermenigvuldigen
            // 
            this.BtnVermenigvuldigen.Cursor = System.Windows.Forms.Cursors.Cross;
            this.BtnVermenigvuldigen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVermenigvuldigen.Location = new System.Drawing.Point(698, 240);
            this.BtnVermenigvuldigen.Name = "BtnVermenigvuldigen";
            this.BtnVermenigvuldigen.Size = new System.Drawing.Size(166, 46);
            this.BtnVermenigvuldigen.TabIndex = 4;
            this.BtnVermenigvuldigen.Text = "&Vermenigvuldigen";
            this.BtnVermenigvuldigen.UseVisualStyleBackColor = true;
            this.BtnVermenigvuldigen.Click += new System.EventHandler(this.BtnVermenigvuldigen_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.Cursor = System.Windows.Forms.Cursors.Cross;
            this.BtnWissen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(698, 292);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(166, 46);
            this.BtnWissen.TabIndex = 5;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.Cursor = System.Windows.Forms.Cursors.Cross;
            this.BtnSluiten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(698, 344);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(166, 46);
            this.BtnSluiten.TabIndex = 6;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmOpdracht21Dario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 413);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnVermenigvuldigen);
            this.Controls.Add(this.BtnOptellen);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.TxtMaxWaarde);
            this.Controls.Add(this.LblTitelMaxWaarde);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpdracht21Dario";
            this.Text = "Tabel met optellingen of vermenigvuldigingen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblTitelMaxWaarde;
        private TextBox TxtMaxWaarde;
        private TextBox TxtResultaat;
        private Button BtnOptellen;
        private Button BtnVermenigvuldigen;
        private Button BtnWissen;
        private Button BtnSluiten;
    }
}