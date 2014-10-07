namespace PixelTrack_Desktop
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWIMAGEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblWidthInPixels = new System.Windows.Forms.Label();
            this.lblHeightInPixels = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHashcode = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblHue = new System.Windows.Forms.Label();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.lblSaturation = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.numericUpDownYStart = new System.Windows.Forms.NumericUpDown();
            this.lblR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownXStart = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownYLimit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownXLimit = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPixelsAvailable = new System.Windows.Forms.Label();
            this.listColors = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTarget = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblRawFormat = new System.Windows.Forms.Label();
            this.pIXELSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEARCHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostCommonColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knownColorsOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXLimit)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTarget)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(611, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.pIXELSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPENToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWIMAGEToolStripMenuItem});
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.oPENToolStripMenuItem.Text = "Open";
            // 
            // nEWIMAGEToolStripMenuItem
            // 
            this.nEWIMAGEToolStripMenuItem.Name = "nEWIMAGEToolStripMenuItem";
            this.nEWIMAGEToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.nEWIMAGEToolStripMenuItem.Text = "Image";
            this.nEWIMAGEToolStripMenuItem.Click += new System.EventHandler(this.nEWIMAGEToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(455, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblWidthInPixels);
            this.groupBox2.Controls.Add(this.lblHeightInPixels);
            this.groupBox2.Location = new System.Drawing.Point(461, 500);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(74, 80);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size in pixels";
            // 
            // lblWidthInPixels
            // 
            this.lblWidthInPixels.AutoSize = true;
            this.lblWidthInPixels.Location = new System.Drawing.Point(6, 54);
            this.lblWidthInPixels.Name = "lblWidthInPixels";
            this.lblWidthInPixels.Size = new System.Drawing.Size(21, 13);
            this.lblWidthInPixels.TabIndex = 9;
            this.lblWidthInPixels.Text = "W:";
            // 
            // lblHeightInPixels
            // 
            this.lblHeightInPixels.AutoSize = true;
            this.lblHeightInPixels.Location = new System.Drawing.Point(6, 37);
            this.lblHeightInPixels.Name = "lblHeightInPixels";
            this.lblHeightInPixels.Size = new System.Drawing.Size(18, 13);
            this.lblHeightInPixels.TabIndex = 0;
            this.lblHeightInPixels.Text = "H:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Controls.Add(this.lblHashcode);
            this.groupBox3.Controls.Add(this.lblA);
            this.groupBox3.Controls.Add(this.lblHue);
            this.groupBox3.Controls.Add(this.lblBrightness);
            this.groupBox3.Controls.Add(this.lblSaturation);
            this.groupBox3.Controls.Add(this.lblG);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblB);
            this.groupBox3.Controls.Add(this.numericUpDownYStart);
            this.groupBox3.Controls.Add(this.lblR);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numericUpDownXStart);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.numericUpDownYLimit);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numericUpDownXLimit);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lblPixelsAvailable);
            this.groupBox3.Location = new System.Drawing.Point(12, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 133);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colors";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(227, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(143, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Name";
            // 
            // lblHashcode
            // 
            this.lblHashcode.AutoSize = true;
            this.lblHashcode.Location = new System.Drawing.Point(143, 116);
            this.lblHashcode.Name = "lblHashcode";
            this.lblHashcode.Size = new System.Drawing.Size(56, 13);
            this.lblHashcode.TabIndex = 26;
            this.lblHashcode.Text = "Hashcode";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(143, 90);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 25;
            this.lblA.Text = "A";
            // 
            // lblHue
            // 
            this.lblHue.AutoSize = true;
            this.lblHue.Location = new System.Drawing.Point(67, 90);
            this.lblHue.Name = "lblHue";
            this.lblHue.Size = new System.Drawing.Size(15, 13);
            this.lblHue.TabIndex = 24;
            this.lblHue.Text = "H";
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Location = new System.Drawing.Point(67, 103);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(14, 13);
            this.lblBrightness.TabIndex = 23;
            this.lblBrightness.Text = "B";
            // 
            // lblSaturation
            // 
            this.lblSaturation.AutoSize = true;
            this.lblSaturation.Location = new System.Drawing.Point(67, 116);
            this.lblSaturation.Name = "lblSaturation";
            this.lblSaturation.Size = new System.Drawing.Size(14, 13);
            this.lblSaturation.TabIndex = 22;
            this.lblSaturation.Text = "S";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(11, 103);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(15, 13);
            this.lblG.TabIndex = 21;
            this.lblG.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Y Start";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(11, 116);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 19;
            this.lblB.Text = "B";
            // 
            // numericUpDownYStart
            // 
            this.numericUpDownYStart.Location = new System.Drawing.Point(55, 66);
            this.numericUpDownYStart.Name = "numericUpDownYStart";
            this.numericUpDownYStart.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownYStart.TabIndex = 16;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(11, 90);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(15, 13);
            this.lblR.TabIndex = 19;
            this.lblR.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "X Start";
            // 
            // numericUpDownXStart
            // 
            this.numericUpDownXStart.Location = new System.Drawing.Point(55, 42);
            this.numericUpDownXStart.Name = "numericUpDownXStart";
            this.numericUpDownXStart.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownXStart.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Y Limit";
            // 
            // numericUpDownYLimit
            // 
            this.numericUpDownYLimit.Location = new System.Drawing.Point(163, 66);
            this.numericUpDownYLimit.Name = "numericUpDownYLimit";
            this.numericUpDownYLimit.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownYLimit.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "X Limit";
            // 
            // numericUpDownXLimit
            // 
            this.numericUpDownXLimit.Location = new System.Drawing.Point(163, 42);
            this.numericUpDownXLimit.Name = "numericUpDownXLimit";
            this.numericUpDownXLimit.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownXLimit.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Evaluate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPixelsAvailable
            // 
            this.lblPixelsAvailable.AutoSize = true;
            this.lblPixelsAvailable.Location = new System.Drawing.Point(6, 19);
            this.lblPixelsAvailable.Name = "lblPixelsAvailable";
            this.lblPixelsAvailable.Size = new System.Drawing.Size(0, 13);
            this.lblPixelsAvailable.TabIndex = 0;
            // 
            // listColors
            // 
            this.listColors.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listColors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listColors.Location = new System.Drawing.Point(12, 27);
            this.listColors.MultiSelect = false;
            this.listColors.Name = "listColors";
            this.listColors.Size = new System.Drawing.Size(588, 301);
            this.listColors.TabIndex = 0;
            this.listColors.UseCompatibleStateImageBehavior = false;
            this.listColors.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listColors_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ColumnHeadfer";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 333);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(587, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBoxTarget);
            this.groupBox6.Location = new System.Drawing.Point(326, 362);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(123, 133);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Target";
            // 
            // pictureBoxTarget
            // 
            this.pictureBoxTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTarget.Location = new System.Drawing.Point(7, 19);
            this.pictureBoxTarget.Name = "pictureBoxTarget";
            this.pictureBoxTarget.Size = new System.Drawing.Size(110, 108);
            this.pictureBoxTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTarget.TabIndex = 3;
            this.pictureBoxTarget.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblRawFormat);
            this.groupBox4.Location = new System.Drawing.Point(546, 500);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(53, 80);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Raw Format";
            // 
            // lblRawFormat
            // 
            this.lblRawFormat.AutoSize = true;
            this.lblRawFormat.Location = new System.Drawing.Point(6, 38);
            this.lblRawFormat.Name = "lblRawFormat";
            this.lblRawFormat.Size = new System.Drawing.Size(14, 13);
            this.lblRawFormat.TabIndex = 0;
            this.lblRawFormat.Text = "*.";
            // 
            // pIXELSToolStripMenuItem
            // 
            this.pIXELSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sEARCHToolStripMenuItem});
            this.pIXELSToolStripMenuItem.Name = "pIXELSToolStripMenuItem";
            this.pIXELSToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.pIXELSToolStripMenuItem.Text = "PIXELS";
            // 
            // sEARCHToolStripMenuItem
            // 
            this.sEARCHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostCommonColorsToolStripMenuItem,
            this.knownColorsOnlyToolStripMenuItem});
            this.sEARCHToolStripMenuItem.Name = "sEARCHToolStripMenuItem";
            this.sEARCHToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sEARCHToolStripMenuItem.Text = "Find From List";
            // 
            // mostCommonColorsToolStripMenuItem
            // 
            this.mostCommonColorsToolStripMenuItem.Name = "mostCommonColorsToolStripMenuItem";
            this.mostCommonColorsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.mostCommonColorsToolStripMenuItem.Text = "Most Common Colors";
            // 
            // knownColorsOnlyToolStripMenuItem
            // 
            this.knownColorsOnlyToolStripMenuItem.Name = "knownColorsOnlyToolStripMenuItem";
            this.knownColorsOnlyToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.knownColorsOnlyToolStripMenuItem.Text = "Known Colors Only";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 609);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listColors);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pixel Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXLimit)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTarget)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWIMAGEToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblWidthInPixels;
        private System.Windows.Forms.Label lblHeightInPixels;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPixelsAvailable;
        private System.Windows.Forms.ListView listColors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownYLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownXLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownYStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownXStart;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblHue;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.Label lblSaturation;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblHashcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBoxTarget;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblRawFormat;
        private System.Windows.Forms.ToolStripMenuItem pIXELSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEARCHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostCommonColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knownColorsOnlyToolStripMenuItem;
    }
}

