namespace Opdracht17Dario
{
    partial class FrmOpdracht17Dario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpdracht17Dario));
            this.LblGetal = new System.Windows.Forms.Label();
            this.TxtGetal = new System.Windows.Forms.TextBox();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.LblResultaat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblGetal
            // 
            this.LblGetal.AutoSize = true;
            this.LblGetal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGetal.Location = new System.Drawing.Point(48, 46);
            this.LblGetal.Name = "LblGetal";
            this.LblGetal.Size = new System.Drawing.Size(56, 25);
            this.LblGetal.TabIndex = 0;
            this.LblGetal.Text = "Getal";
            // 
            // TxtGetal
            // 
            this.TxtGetal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGetal.Location = new System.Drawing.Point(48, 74);
            this.TxtGetal.Name = "TxtGetal";
            this.TxtGetal.Size = new System.Drawing.Size(100, 32);
            this.TxtGetal.TabIndex = 1;
            this.TxtGetal.Text = "1";
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(48, 157);
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(376, 32);
            this.TxtResultaat.TabIndex = 3;
            // 
            // LblResultaat
            // 
            this.LblResultaat.AutoSize = true;
            this.LblResultaat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResultaat.Location = new System.Drawing.Point(48, 129);
            this.LblResultaat.Name = "LblResultaat";
            this.LblResultaat.Size = new System.Drawing.Size(88, 25);
            this.LblResultaat.TabIndex = 2;
            this.LblResultaat.Text = "Resultaat";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(48, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Bereken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(190, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Wissen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(332, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "&Sluiten";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmOpdracht17Dario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 326);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.LblResultaat);
            this.Controls.Add(this.TxtGetal);
            this.Controls.Add(this.LblGetal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpdracht17Dario";
            this.Text = "Faculteitsberekening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblGetal;
        private TextBox TxtGetal;
        private TextBox TxtResultaat;
        private Label LblResultaat;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}