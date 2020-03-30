namespace AusschaltenPC
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHerunterfahren = new System.Windows.Forms.Button();
            this.btnWinterschlaf = new System.Windows.Forms.Button();
            this.nudTag = new System.Windows.Forms.NumericUpDown();
            this.nudStunde = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStunde = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.btnAbbrechenHerunterfahren = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTimerValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStunde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHerunterfahren
            // 
            this.btnHerunterfahren.Location = new System.Drawing.Point(15, 76);
            this.btnHerunterfahren.Name = "btnHerunterfahren";
            this.btnHerunterfahren.Size = new System.Drawing.Size(92, 23);
            this.btnHerunterfahren.TabIndex = 0;
            this.btnHerunterfahren.Text = "Herunterfahren";
            this.btnHerunterfahren.UseVisualStyleBackColor = true;
            this.btnHerunterfahren.Click += new System.EventHandler(this.BtnHerunterfahren_Click);
            // 
            // btnWinterschlaf
            // 
            this.btnWinterschlaf.Location = new System.Drawing.Point(15, 146);
            this.btnWinterschlaf.Name = "btnWinterschlaf";
            this.btnWinterschlaf.Size = new System.Drawing.Size(92, 23);
            this.btnWinterschlaf.TabIndex = 1;
            this.btnWinterschlaf.Text = "Winterschlaf";
            this.btnWinterschlaf.UseVisualStyleBackColor = true;
            this.btnWinterschlaf.Click += new System.EventHandler(this.BtnWinterschlaf_Click);
            // 
            // nudTag
            // 
            this.nudTag.Location = new System.Drawing.Point(47, 12);
            this.nudTag.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudTag.Name = "nudTag";
            this.nudTag.Size = new System.Drawing.Size(47, 20);
            this.nudTag.TabIndex = 2;
            this.nudTag.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // nudStunde
            // 
            this.nudStunde.Location = new System.Drawing.Point(180, 12);
            this.nudStunde.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudStunde.Name = "nudStunde";
            this.nudStunde.Size = new System.Drawing.Size(47, 20);
            this.nudStunde.TabIndex = 2;
            this.nudStunde.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(311, 12);
            this.nudMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(47, 20);
            this.nudMinute.TabIndex = 2;
            this.nudMinute.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tag:";
            // 
            // lblStunde
            // 
            this.lblStunde.AutoSize = true;
            this.lblStunde.Location = new System.Drawing.Point(130, 14);
            this.lblStunde.Name = "lblStunde";
            this.lblStunde.Size = new System.Drawing.Size(44, 13);
            this.lblStunde.TabIndex = 3;
            this.lblStunde.Text = "Stunde:";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(263, 14);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(42, 13);
            this.lblMinute.TabIndex = 3;
            this.lblMinute.Text = "Minute:";
            // 
            // btnAbbrechenHerunterfahren
            // 
            this.btnAbbrechenHerunterfahren.Enabled = false;
            this.btnAbbrechenHerunterfahren.Location = new System.Drawing.Point(113, 76);
            this.btnAbbrechenHerunterfahren.Name = "btnAbbrechenHerunterfahren";
            this.btnAbbrechenHerunterfahren.Size = new System.Drawing.Size(92, 23);
            this.btnAbbrechenHerunterfahren.TabIndex = 0;
            this.btnAbbrechenHerunterfahren.Text = "Abbrechen";
            this.btnAbbrechenHerunterfahren.UseVisualStyleBackColor = true;
            this.btnAbbrechenHerunterfahren.Click += new System.EventHandler(this.BtnHerunterfahren_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(12, 47);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(97, 13);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "Herunterfahrenzeit:";
            // 
            // lblTimerValue
            // 
            this.lblTimerValue.AutoSize = true;
            this.lblTimerValue.Location = new System.Drawing.Point(115, 47);
            this.lblTimerValue.Name = "lblTimerValue";
            this.lblTimerValue.Size = new System.Drawing.Size(10, 13);
            this.lblTimerValue.TabIndex = 3;
            this.lblTimerValue.Text = "-";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(370, 187);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblStunde);
            this.Controls.Add(this.lblTimerValue);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.nudStunde);
            this.Controls.Add(this.nudTag);
            this.Controls.Add(this.btnWinterschlaf);
            this.Controls.Add(this.btnAbbrechenHerunterfahren);
            this.Controls.Add(this.btnHerunterfahren);
            this.Name = "frmMain";
            this.Text = "AusschaltenPC";
            ((System.ComponentModel.ISupportInitialize)(this.nudTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStunde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHerunterfahren;
        private System.Windows.Forms.Button btnWinterschlaf;
        private System.Windows.Forms.NumericUpDown nudTag;
        private System.Windows.Forms.NumericUpDown nudStunde;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStunde;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Button btnAbbrechenHerunterfahren;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTimerValue;
    }
}

