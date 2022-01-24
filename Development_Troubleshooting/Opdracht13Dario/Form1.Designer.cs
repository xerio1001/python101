namespace Opdracht13Dario
{
    partial class Opdracht13Dario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opdracht13Dario));
            this.LblTitelBelasting = new System.Windows.Forms.Label();
            this.LblUitkomstBelastingen = new System.Windows.Forms.Label();
            this.TrackbarInkomen = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.salarisToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarInkomen)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitelBelasting
            // 
            this.LblTitelBelasting.AutoSize = true;
            this.LblTitelBelasting.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitelBelasting.Location = new System.Drawing.Point(84, 25);
            this.LblTitelBelasting.Name = "LblTitelBelasting";
            this.LblTitelBelasting.Size = new System.Drawing.Size(105, 30);
            this.LblTitelBelasting.TabIndex = 0;
            this.LblTitelBelasting.Text = "Belasting:";
            // 
            // LblUitkomstBelastingen
            // 
            this.LblUitkomstBelastingen.AutoSize = true;
            this.LblUitkomstBelastingen.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUitkomstBelastingen.Location = new System.Drawing.Point(181, 26);
            this.LblUitkomstBelastingen.Name = "LblUitkomstBelastingen";
            this.LblUitkomstBelastingen.Size = new System.Drawing.Size(25, 30);
            this.LblUitkomstBelastingen.TabIndex = 1;
            this.LblUitkomstBelastingen.Text = "0";
            // 
            // TrackbarInkomen
            // 
            this.TrackbarInkomen.LargeChange = 1000;
            this.TrackbarInkomen.Location = new System.Drawing.Point(84, 116);
            this.TrackbarInkomen.Maximum = 100000;
            this.TrackbarInkomen.Name = "TrackbarInkomen";
            this.TrackbarInkomen.Size = new System.Drawing.Size(530, 45);
            this.TrackbarInkomen.TabIndex = 2;
            this.TrackbarInkomen.Tag = "";
            this.TrackbarInkomen.Value = 1000;
            this.TrackbarInkomen.Scroll += new System.EventHandler(this.TrackbarInkomen_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(84, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(321, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "50 000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(580, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "100 000";
            // 
            // Opdracht13Dario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrackbarInkomen);
            this.Controls.Add(this.LblUitkomstBelastingen);
            this.Controls.Add(this.LblTitelBelasting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Opdracht13Dario";
            this.Text = "Belasting berekenen";
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarInkomen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblTitelBelasting;
        private Label LblUitkomstBelastingen;
        private TrackBar TrackbarInkomen;
        private Label label1;
        private ToolTip salarisToolTip;
        private Label label2;
        private Label label3;
    }
}