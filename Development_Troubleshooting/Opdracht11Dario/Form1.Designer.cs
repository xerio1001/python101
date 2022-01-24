namespace Opdracht11Dario
{
    partial class Opdracht11Dario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opdracht11Dario));
            this.LblMaintitel = new System.Windows.Forms.Label();
            this.TxtInputGetal = new System.Windows.Forms.TextBox();
            this.TxtGewonnen = new System.Windows.Forms.TextBox();
            this.TxtAantalGeraden = new System.Windows.Forms.TextBox();
            this.BtnEvalueer = new System.Windows.Forms.Button();
            this.BtnNieuw = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMaintitel
            // 
            this.LblMaintitel.AutoSize = true;
            this.LblMaintitel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMaintitel.Location = new System.Drawing.Point(32, 46);
            this.LblMaintitel.Name = "LblMaintitel";
            this.LblMaintitel.Size = new System.Drawing.Size(278, 25);
            this.LblMaintitel.TabIndex = 0;
            this.LblMaintitel.Text = "Geef een getal tussen 1 en 100: ";
            // 
            // TxtInputGetal
            // 
            this.TxtInputGetal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtInputGetal.Location = new System.Drawing.Point(309, 43);
            this.TxtInputGetal.Name = "TxtInputGetal";
            this.TxtInputGetal.Size = new System.Drawing.Size(57, 32);
            this.TxtInputGetal.TabIndex = 1;
            this.TxtInputGetal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtGewonnen
            // 
            this.TxtGewonnen.Enabled = false;
            this.TxtGewonnen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGewonnen.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtGewonnen.Location = new System.Drawing.Point(32, 138);
            this.TxtGewonnen.Name = "TxtGewonnen";
            this.TxtGewonnen.Size = new System.Drawing.Size(334, 32);
            this.TxtGewonnen.TabIndex = 2;
            this.TxtGewonnen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtAantalGeraden
            // 
            this.TxtAantalGeraden.Enabled = false;
            this.TxtAantalGeraden.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAantalGeraden.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtAantalGeraden.Location = new System.Drawing.Point(32, 176);
            this.TxtAantalGeraden.Name = "TxtAantalGeraden";
            this.TxtAantalGeraden.Size = new System.Drawing.Size(334, 32);
            this.TxtAantalGeraden.TabIndex = 3;
            this.TxtAantalGeraden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnEvalueer
            // 
            this.BtnEvalueer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEvalueer.Location = new System.Drawing.Point(384, 43);
            this.BtnEvalueer.Name = "BtnEvalueer";
            this.BtnEvalueer.Size = new System.Drawing.Size(132, 36);
            this.BtnEvalueer.TabIndex = 4;
            this.BtnEvalueer.Text = "Ev&alueer";
            this.BtnEvalueer.UseVisualStyleBackColor = true;
            this.BtnEvalueer.Click += new System.EventHandler(this.BtnEvalueer_Click);
            // 
            // BtnNieuw
            // 
            this.BtnNieuw.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnNieuw.Location = new System.Drawing.Point(384, 85);
            this.BtnNieuw.Name = "BtnNieuw";
            this.BtnNieuw.Size = new System.Drawing.Size(132, 36);
            this.BtnNieuw.TabIndex = 5;
            this.BtnNieuw.Text = "&Nieuw spel";
            this.BtnNieuw.UseVisualStyleBackColor = true;
            this.BtnNieuw.Click += new System.EventHandler(this.BtnNieuw_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(384, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Einde";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Opdracht11Dario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 226);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnNieuw);
            this.Controls.Add(this.BtnEvalueer);
            this.Controls.Add(this.TxtAantalGeraden);
            this.Controls.Add(this.TxtGewonnen);
            this.Controls.Add(this.TxtInputGetal);
            this.Controls.Add(this.LblMaintitel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Opdracht11Dario";
            this.Text = "Raadspel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblMaintitel;
        private TextBox TxtInputGetal;
        private TextBox TxtGewonnen;
        private TextBox TxtAantalGeraden;
        private Button BtnEvalueer;
        private Button BtnNieuw;
        private Button button1;
    }
}