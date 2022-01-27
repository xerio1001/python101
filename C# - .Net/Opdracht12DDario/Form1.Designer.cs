namespace Opdracht12DDario
{
    partial class Opdracht12Dario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opdracht12Dario));
            this.RadJongen = new System.Windows.Forms.RadioButton();
            this.RadMeisje = new System.Windows.Forms.RadioButton();
            this.LblTitelGeslacht = new System.Windows.Forms.Label();
            this.TxtLengteVader = new System.Windows.Forms.TextBox();
            this.LblLengteVader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLengteMoeder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtVerwachtLenMeisje = new System.Windows.Forms.TextBox();
            this.TxtVerwachtLenJongen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RadJongen
            // 
            this.RadJongen.AutoSize = true;
            this.RadJongen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadJongen.Location = new System.Drawing.Point(180, 62);
            this.RadJongen.Name = "RadJongen";
            this.RadJongen.Size = new System.Drawing.Size(91, 29);
            this.RadJongen.TabIndex = 0;
            this.RadJongen.Text = "Jongen";
            this.RadJongen.UseVisualStyleBackColor = true;
            this.RadJongen.CheckedChanged += new System.EventHandler(this.RadJongen_CheckedChanged);
            // 
            // RadMeisje
            // 
            this.RadMeisje.AutoSize = true;
            this.RadMeisje.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadMeisje.Location = new System.Drawing.Point(277, 62);
            this.RadMeisje.Name = "RadMeisje";
            this.RadMeisje.Size = new System.Drawing.Size(85, 29);
            this.RadMeisje.TabIndex = 1;
            this.RadMeisje.Text = "Meisje";
            this.RadMeisje.UseVisualStyleBackColor = true;
            this.RadMeisje.CheckedChanged += new System.EventHandler(this.RadMeisje_CheckedChanged);
            // 
            // LblTitelGeslacht
            // 
            this.LblTitelGeslacht.AutoSize = true;
            this.LblTitelGeslacht.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitelGeslacht.Location = new System.Drawing.Point(225, 22);
            this.LblTitelGeslacht.Name = "LblTitelGeslacht";
            this.LblTitelGeslacht.Size = new System.Drawing.Size(84, 25);
            this.LblTitelGeslacht.TabIndex = 2;
            this.LblTitelGeslacht.Text = "Geslacht";
            // 
            // TxtLengteVader
            // 
            this.TxtLengteVader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtLengteVader.Location = new System.Drawing.Point(279, 126);
            this.TxtLengteVader.Name = "TxtLengteVader";
            this.TxtLengteVader.Size = new System.Drawing.Size(130, 32);
            this.TxtLengteVader.TabIndex = 3;
            // 
            // LblLengteVader
            // 
            this.LblLengteVader.AutoSize = true;
            this.LblLengteVader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLengteVader.Location = new System.Drawing.Point(148, 133);
            this.LblLengteVader.Name = "LblLengteVader";
            this.LblLengteVader.Size = new System.Drawing.Size(125, 25);
            this.LblLengteVader.TabIndex = 4;
            this.LblLengteVader.Text = "Lengte vader:";
            this.LblLengteVader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lengte moeder:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtLengteMoeder
            // 
            this.TxtLengteMoeder.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtLengteMoeder.Location = new System.Drawing.Point(279, 175);
            this.TxtLengteMoeder.Name = "TxtLengteMoeder";
            this.TxtLengteMoeder.Size = new System.Drawing.Size(130, 32);
            this.TxtLengteMoeder.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Verwachte lengte van jongen:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Verwachte lengte van meisje:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtVerwachtLenMeisje
            // 
            this.TxtVerwachtLenMeisje.Enabled = false;
            this.TxtVerwachtLenMeisje.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtVerwachtLenMeisje.Location = new System.Drawing.Point(279, 288);
            this.TxtVerwachtLenMeisje.Name = "TxtVerwachtLenMeisje";
            this.TxtVerwachtLenMeisje.Size = new System.Drawing.Size(130, 32);
            this.TxtVerwachtLenMeisje.TabIndex = 10;
            // 
            // TxtVerwachtLenJongen
            // 
            this.TxtVerwachtLenJongen.Enabled = false;
            this.TxtVerwachtLenJongen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtVerwachtLenJongen.Location = new System.Drawing.Point(279, 239);
            this.TxtVerwachtLenJongen.Name = "TxtVerwachtLenJongen";
            this.TxtVerwachtLenJongen.Size = new System.Drawing.Size(130, 32);
            this.TxtVerwachtLenJongen.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(451, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "&Berekenen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(451, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "&Sluiten";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Opdracht12Dario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 362);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtVerwachtLenMeisje);
            this.Controls.Add(this.TxtVerwachtLenJongen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtLengteMoeder);
            this.Controls.Add(this.LblLengteVader);
            this.Controls.Add(this.TxtLengteVader);
            this.Controls.Add(this.LblTitelGeslacht);
            this.Controls.Add(this.RadMeisje);
            this.Controls.Add(this.RadJongen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Opdracht12Dario";
            this.Text = "Verwachte Lengte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton RadJongen;
        private RadioButton RadMeisje;
        private Label LblTitelGeslacht;
        private TextBox TxtLengteVader;
        private Label LblLengteVader;
        private Label label1;
        private TextBox TxtLengteMoeder;
        private Label label3;
        private Label label2;
        private TextBox TxtVerwachtLenMeisje;
        private TextBox TxtVerwachtLenJongen;
        private Button button1;
        private Button button2;
    }
}