namespace TargetHearRateCalc_Class_Method
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblHearRateTarget = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtIntensity = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblMaxHr = new System.Windows.Forms.Label();
            this.lblMxHR = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(106, 38);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age:";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(69, 78);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(66, 13);
            this.lblPercent.TabIndex = 1;
            this.lblPercent.Text = "Intensity (%):";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(418, 43);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(137, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Targeted Hear Rate (BPM):";
            // 
            // lblHearRateTarget
            // 
            this.lblHearRateTarget.AutoSize = true;
            this.lblHearRateTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHearRateTarget.Location = new System.Drawing.Point(410, 74);
            this.lblHearRateTarget.Name = "lblHearRateTarget";
            this.lblHearRateTarget.Size = new System.Drawing.Size(105, 55);
            this.lblHearRateTarget.TabIndex = 3;
            this.lblHearRateTarget.Text = "???";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(166, 34);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(168, 20);
            this.txtAge.TabIndex = 0;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(166, 144);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(168, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtIntensity
            // 
            this.txtIntensity.Location = new System.Drawing.Point(166, 74);
            this.txtIntensity.Name = "txtIntensity";
            this.txtIntensity.Size = new System.Drawing.Size(168, 20);
            this.txtIntensity.TabIndex = 1;
            this.txtIntensity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntensity_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem3.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(363, 154);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(24, 13);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "text";
            // 
            // lblMaxHr
            // 
            this.lblMaxHr.AutoSize = true;
            this.lblMaxHr.Location = new System.Drawing.Point(578, 43);
            this.lblMaxHr.Name = "lblMaxHr";
            this.lblMaxHr.Size = new System.Drawing.Size(109, 13);
            this.lblMaxHr.TabIndex = 10;
            this.lblMaxHr.Text = "Maximum Heart Rate:";
            // 
            // lblMxHR
            // 
            this.lblMxHR.AutoSize = true;
            this.lblMxHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMxHR.Location = new System.Drawing.Point(571, 74);
            this.lblMxHR.Name = "lblMxHR";
            this.lblMxHR.Size = new System.Drawing.Size(105, 55);
            this.lblMxHR.TabIndex = 11;
            this.lblMxHR.Text = "???";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 261);
            this.Controls.Add(this.lblMxHR);
            this.Controls.Add(this.lblMaxHr);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtIntensity);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblHearRateTarget);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Workout Heart Rate Calculator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblHearRateTarget;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtIntensity;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblMaxHr;
        private System.Windows.Forms.Label lblMxHR;
    }
}

