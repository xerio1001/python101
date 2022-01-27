namespace Opdracht14Dario
{
    partial class FrmOpdracht14Dario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpdracht14Dario));
            this.LblTitelGebDatum = new System.Windows.Forms.Label();
            this.TxtGebDatum = new System.Windows.Forms.TextBox();
            this.BtnBerkenen = new System.Windows.Forms.Button();
            this.GroupBoxData = new System.Windows.Forms.GroupBox();
            this.TxtDagen = new System.Windows.Forms.TextBox();
            this.LblDagen = new System.Windows.Forms.Label();
            this.TxtMaanden = new System.Windows.Forms.TextBox();
            this.LblMaanden = new System.Windows.Forms.Label();
            this.TxtJaren = new System.Windows.Forms.TextBox();
            this.LblJaren = new System.Windows.Forms.Label();
            this.LblHuidigeDatum = new System.Windows.Forms.Label();
            this.TimerDatum = new System.Windows.Forms.Timer(this.components);
            this.GroupBoxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitelGebDatum
            // 
            this.LblTitelGebDatum.AutoSize = true;
            this.LblTitelGebDatum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitelGebDatum.Location = new System.Drawing.Point(52, 79);
            this.LblTitelGebDatum.Name = "LblTitelGebDatum";
            this.LblTitelGebDatum.Size = new System.Drawing.Size(149, 25);
            this.LblTitelGebDatum.TabIndex = 0;
            this.LblTitelGebDatum.Text = "Geboortedatum:";
            // 
            // TxtGebDatum
            // 
            this.TxtGebDatum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGebDatum.Location = new System.Drawing.Point(203, 76);
            this.TxtGebDatum.Name = "TxtGebDatum";
            this.TxtGebDatum.Size = new System.Drawing.Size(199, 32);
            this.TxtGebDatum.TabIndex = 1;
            // 
            // BtnBerkenen
            // 
            this.BtnBerkenen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBerkenen.Location = new System.Drawing.Point(489, 76);
            this.BtnBerkenen.Name = "BtnBerkenen";
            this.BtnBerkenen.Size = new System.Drawing.Size(110, 32);
            this.BtnBerkenen.TabIndex = 2;
            this.BtnBerkenen.Text = "&Bereken";
            this.BtnBerkenen.UseVisualStyleBackColor = true;
            this.BtnBerkenen.Click += new System.EventHandler(this.BtnBerkenen_Click);
            // 
            // GroupBoxData
            // 
            this.GroupBoxData.Controls.Add(this.TxtDagen);
            this.GroupBoxData.Controls.Add(this.LblDagen);
            this.GroupBoxData.Controls.Add(this.TxtMaanden);
            this.GroupBoxData.Controls.Add(this.LblMaanden);
            this.GroupBoxData.Controls.Add(this.TxtJaren);
            this.GroupBoxData.Controls.Add(this.LblJaren);
            this.GroupBoxData.Location = new System.Drawing.Point(52, 125);
            this.GroupBoxData.Name = "GroupBoxData";
            this.GroupBoxData.Size = new System.Drawing.Size(547, 227);
            this.GroupBoxData.TabIndex = 3;
            this.GroupBoxData.TabStop = false;
            this.GroupBoxData.Text = "groupBox1";
            // 
            // TxtDagen
            // 
            this.TxtDagen.Enabled = false;
            this.TxtDagen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDagen.Location = new System.Drawing.Point(155, 107);
            this.TxtDagen.Name = "TxtDagen";
            this.TxtDagen.Size = new System.Drawing.Size(151, 32);
            this.TxtDagen.TabIndex = 8;
            // 
            // LblDagen
            // 
            this.LblDagen.AutoSize = true;
            this.LblDagen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDagen.Location = new System.Drawing.Point(78, 110);
            this.LblDagen.Name = "LblDagen";
            this.LblDagen.Size = new System.Drawing.Size(71, 25);
            this.LblDagen.TabIndex = 7;
            this.LblDagen.Text = "Dagen:";
            // 
            // TxtMaanden
            // 
            this.TxtMaanden.Enabled = false;
            this.TxtMaanden.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtMaanden.Location = new System.Drawing.Point(155, 69);
            this.TxtMaanden.Name = "TxtMaanden";
            this.TxtMaanden.Size = new System.Drawing.Size(151, 32);
            this.TxtMaanden.TabIndex = 6;
            // 
            // LblMaanden
            // 
            this.LblMaanden.AutoSize = true;
            this.LblMaanden.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMaanden.Location = new System.Drawing.Point(53, 72);
            this.LblMaanden.Name = "LblMaanden";
            this.LblMaanden.Size = new System.Drawing.Size(96, 25);
            this.LblMaanden.TabIndex = 5;
            this.LblMaanden.Text = "Maanden:";
            // 
            // TxtJaren
            // 
            this.TxtJaren.Enabled = false;
            this.TxtJaren.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtJaren.Location = new System.Drawing.Point(155, 31);
            this.TxtJaren.Name = "TxtJaren";
            this.TxtJaren.Size = new System.Drawing.Size(151, 32);
            this.TxtJaren.TabIndex = 4;
            // 
            // LblJaren
            // 
            this.LblJaren.AutoSize = true;
            this.LblJaren.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblJaren.Location = new System.Drawing.Point(88, 34);
            this.LblJaren.Name = "LblJaren";
            this.LblJaren.Size = new System.Drawing.Size(61, 25);
            this.LblJaren.TabIndex = 0;
            this.LblJaren.Text = "Jaren:";
            // 
            // LblHuidigeDatum
            // 
            this.LblHuidigeDatum.AutoSize = true;
            this.LblHuidigeDatum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblHuidigeDatum.Location = new System.Drawing.Point(519, 25);
            this.LblHuidigeDatum.Name = "LblHuidigeDatum";
            this.LblHuidigeDatum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblHuidigeDatum.Size = new System.Drawing.Size(94, 25);
            this.LblHuidigeDatum.TabIndex = 4;
            this.LblHuidigeDatum.Text = "HH:mm:ss";
            this.LblHuidigeDatum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimerDatum
            // 
            this.TimerDatum.Tick += new System.EventHandler(this.TimerDatum_Tick);
            // 
            // FrmOpdracht14Dario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 368);
            this.Controls.Add(this.LblHuidigeDatum);
            this.Controls.Add(this.GroupBoxData);
            this.Controls.Add(this.BtnBerkenen);
            this.Controls.Add(this.TxtGebDatum);
            this.Controls.Add(this.LblTitelGebDatum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpdracht14Dario";
            this.Text = "Leeftijd in jaren, maanden en dagen";
            this.GroupBoxData.ResumeLayout(false);
            this.GroupBoxData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblTitelGebDatum;
        private TextBox TxtGebDatum;
        private Button BtnBerkenen;
        private GroupBox GroupBoxData;
        private TextBox TxtJaren;
        private Label LblJaren;
        private TextBox TxtDagen;
        private Label LblDagen;
        private TextBox TxtMaanden;
        private Label LblMaanden;
        private Label LblHuidigeDatum;
        private System.Windows.Forms.Timer TimerDatum;
    }
}