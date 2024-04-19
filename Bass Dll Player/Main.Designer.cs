namespace Bass_Dll_PitchShift
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.labelTranspose = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxLeft = new System.Windows.Forms.CheckBox();
            this.checkBoxRight = new System.Windows.Forms.CheckBox();
            this.checkBoxCenter = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.trackBarPosition = new System.Windows.Forms.TrackBar();
            this.checkBoxEqOn = new System.Windows.Forms.CheckBox();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBarTranspose = new System.Windows.Forms.TrackBar();
            this.labelGain = new System.Windows.Forms.Label();
            this.labelFreq = new System.Windows.Forms.Label();
            this.trackBarGain = new System.Windows.Forms.TrackBar();
            this.trackBarFreq = new System.Windows.Forms.TrackBar();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karaokeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.monoStereoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pitchShiftToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.playPauseStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highPassEqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acordesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTranspose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPlay.Location = new System.Drawing.Point(12, 47);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(70, 25);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonStop.Location = new System.Drawing.Point(12, 84);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(70, 25);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonOpen.Location = new System.Drawing.Point(12, 9);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(70, 25);
            this.buttonOpen.TabIndex = 10;
            this.buttonOpen.Text = "Open File";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // labelTranspose
            // 
            this.labelTranspose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTranspose.AutoSize = true;
            this.labelTranspose.Location = new System.Drawing.Point(213, 65);
            this.labelTranspose.Name = "labelTranspose";
            this.labelTranspose.Size = new System.Drawing.Size(57, 13);
            this.labelTranspose.TabIndex = 16;
            this.labelTranspose.Text = "Transpose";
            // 
            // labelSpeed
            // 
            this.labelSpeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelSpeed.Location = new System.Drawing.Point(597, 50);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(38, 13);
            this.labelSpeed.TabIndex = 40;
            this.labelSpeed.Text = "Speed";
            this.labelSpeed.Click += new System.EventHandler(this.label9_Click);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBarSpeed.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarSpeed.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarSpeed.Location = new System.Drawing.Point(504, 69);
            this.trackBarSpeed.Maximum = 30;
            this.trackBarSpeed.Minimum = -30;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(230, 45);
            this.trackBarSpeed.SmallChange = 20;
            this.trackBarSpeed.TabIndex = 24;
            this.trackBarSpeed.Tag = "";
            this.trackBarSpeed.TickFrequency = 10;
            this.toolTip1.SetToolTip(this.trackBarSpeed, "Change Speed of music playing");
            this.trackBarSpeed.Value = 1;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBoxLeft
            // 
            this.checkBoxLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxLeft.AutoSize = true;
            this.checkBoxLeft.Location = new System.Drawing.Point(903, 30);
            this.checkBoxLeft.Name = "checkBoxLeft";
            this.checkBoxLeft.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLeft.TabIndex = 41;
            this.toolTip1.SetToolTip(this.checkBoxLeft, "Mono using Left channel");
            this.checkBoxLeft.UseVisualStyleBackColor = true;
            this.checkBoxLeft.CheckedChanged += new System.EventHandler(this.checkBoxLeft_CheckedChanged);
            // 
            // checkBoxRight
            // 
            this.checkBoxRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRight.AutoSize = true;
            this.checkBoxRight.Location = new System.Drawing.Point(945, 30);
            this.checkBoxRight.Name = "checkBoxRight";
            this.checkBoxRight.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRight.TabIndex = 42;
            this.toolTip1.SetToolTip(this.checkBoxRight, "Mono using Right channel");
            this.checkBoxRight.UseVisualStyleBackColor = true;
            this.checkBoxRight.CheckedChanged += new System.EventHandler(this.checkBoxRight_CheckedChanged);
            // 
            // checkBoxCenter
            // 
            this.checkBoxCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCenter.AutoSize = true;
            this.checkBoxCenter.Checked = true;
            this.checkBoxCenter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCenter.Location = new System.Drawing.Point(924, 30);
            this.checkBoxCenter.Name = "checkBoxCenter";
            this.checkBoxCenter.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCenter.TabIndex = 43;
            this.toolTip1.SetToolTip(this.checkBoxCenter, "Stereo");
            this.checkBoxCenter.UseVisualStyleBackColor = true;
            this.checkBoxCenter.CheckedChanged += new System.EventHandler(this.checkBoxCenter_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(900, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "L      c      R";
            // 
            // labelBalance
            // 
            this.labelBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(908, 8);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(46, 13);
            this.labelBalance.TabIndex = 45;
            this.labelBalance.Text = "Balance";
            // 
            // trackBarPosition
            // 
            this.trackBarPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarPosition.Location = new System.Drawing.Point(125, 17);
            this.trackBarPosition.Maximum = 100;
            this.trackBarPosition.Name = "trackBarPosition";
            this.trackBarPosition.Size = new System.Drawing.Size(609, 45);
            this.trackBarPosition.SmallChange = 2;
            this.trackBarPosition.TabIndex = 46;
            this.trackBarPosition.Scroll += new System.EventHandler(this.trackBarPosition_Scroll);
            // 
            // checkBoxEqOn
            // 
            this.checkBoxEqOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEqOn.AutoSize = true;
            this.checkBoxEqOn.Location = new System.Drawing.Point(750, 7);
            this.checkBoxEqOn.Name = "checkBoxEqOn";
            this.checkBoxEqOn.Size = new System.Drawing.Size(92, 17);
            this.checkBoxEqOn.TabIndex = 47;
            this.checkBoxEqOn.Text = "Equalizer OFF";
            this.checkBoxEqOn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip1.SetToolTip(this.checkBoxEqOn, "Select your frequency and make Gain changes.");
            this.checkBoxEqOn.UseVisualStyleBackColor = true;
            this.checkBoxEqOn.CheckedChanged += new System.EventHandler(this.checkBoxEq_CheckedChanged);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBarVolume.Location = new System.Drawing.Point(870, 81);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(126, 45);
            this.trackBarVolume.TabIndex = 48;
            this.trackBarVolume.TickFrequency = 20;
            this.toolTip1.SetToolTip(this.trackBarVolume, "Set music volume");
            this.trackBarVolume.Value = 30;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(911, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Volume";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.checkBoxEqOn);
            this.panel1.Controls.Add(this.labelGain);
            this.panel1.Controls.Add(this.trackBarTranspose);
            this.panel1.Controls.Add(this.trackBarFreq);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.labelFreq);
            this.panel1.Controls.Add(this.buttonPlay);
            this.panel1.Controls.Add(this.trackBarGain);
            this.panel1.Controls.Add(this.trackBarSpeed);
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Controls.Add(this.labelSpeed);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.labelBalance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBoxLeft);
            this.panel1.Controls.Add(this.labelTranspose);
            this.panel1.Controls.Add(this.trackBarVolume);
            this.panel1.Controls.Add(this.checkBoxCenter);
            this.panel1.Controls.Add(this.trackBarPosition);
            this.panel1.Controls.Add(this.checkBoxRight);
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 129);
            this.panel1.TabIndex = 54;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPlayer_Paint);
            // 
            // trackBarTranspose
            // 
            this.trackBarTranspose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBarTranspose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarTranspose.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarTranspose.Location = new System.Drawing.Point(125, 81);
            this.trackBarTranspose.Maximum = 6;
            this.trackBarTranspose.Minimum = -6;
            this.trackBarTranspose.Name = "trackBarTranspose";
            this.trackBarTranspose.Size = new System.Drawing.Size(230, 45);
            this.trackBarTranspose.TabIndex = 57;
            this.trackBarTranspose.Tag = "";
            this.toolTip1.SetToolTip(this.trackBarTranspose, "Transpose music pitch");
            this.trackBarTranspose.Scroll += new System.EventHandler(this.trackBarTransp2_Scroll);
            // 
            // labelGain
            // 
            this.labelGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGain.AutoSize = true;
            this.labelGain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelGain.Location = new System.Drawing.Point(747, 28);
            this.labelGain.Name = "labelGain";
            this.labelGain.Size = new System.Drawing.Size(100, 13);
            this.labelGain.TabIndex = 54;
            this.labelGain.Text = "Boost :                    ";
            // 
            // labelFreq
            // 
            this.labelFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFreq.AutoSize = true;
            this.labelFreq.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelFreq.Location = new System.Drawing.Point(747, 64);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(129, 13);
            this.labelFreq.TabIndex = 53;
            this.labelFreq.Text = "Frequency :                      ";
            // 
            // trackBarGain
            // 
            this.trackBarGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGain.Location = new System.Drawing.Point(744, 38);
            this.trackBarGain.Maximum = 15;
            this.trackBarGain.Minimum = -15;
            this.trackBarGain.Name = "trackBarGain";
            this.trackBarGain.Size = new System.Drawing.Size(104, 45);
            this.trackBarGain.TabIndex = 52;
            this.trackBarGain.TickFrequency = 5;
            this.toolTip1.SetToolTip(this.trackBarGain, "Gain for EQ frequency");
            this.trackBarGain.Scroll += new System.EventHandler(this.trackBarGain_Scroll);
            // 
            // trackBarFreq
            // 
            this.trackBarFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarFreq.Location = new System.Drawing.Point(744, 80);
            this.trackBarFreq.Maximum = 4000;
            this.trackBarFreq.Minimum = 120;
            this.trackBarFreq.Name = "trackBarFreq";
            this.trackBarFreq.Size = new System.Drawing.Size(104, 45);
            this.trackBarFreq.TabIndex = 51;
            this.trackBarFreq.TickFrequency = 20;
            this.toolTip1.SetToolTip(this.trackBarFreq, "Select frequency then \"use\" Gain");
            this.trackBarFreq.Value = 1000;
            this.trackBarFreq.Scroll += new System.EventHandler(this.trackBarFreq_Scroll);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // karaokeToolStripMenuItem
            // 
            this.karaokeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equalizerToolStripMenuItem1,
            this.monoStereoToolStripMenuItem,
            this.speedToolStripMenuItem1,
            this.pitchShiftToolStripMenuItem1,
            this.playPauseStopToolStripMenuItem,
            this.highPassEqToolStripMenuItem});
            this.karaokeToolStripMenuItem.Name = "karaokeToolStripMenuItem";
            this.karaokeToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.karaokeToolStripMenuItem.Text = "Effects";
            this.karaokeToolStripMenuItem.Click += new System.EventHandler(this.karaokeToolStripMenuItem_Click);
            // 
            // equalizerToolStripMenuItem1
            // 
            this.equalizerToolStripMenuItem1.Name = "equalizerToolStripMenuItem1";
            this.equalizerToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.equalizerToolStripMenuItem1.Text = "Equalizer";
            this.equalizerToolStripMenuItem1.Click += new System.EventHandler(this.equalizerToolStripMenuItem1_Click);
            // 
            // monoStereoToolStripMenuItem
            // 
            this.monoStereoToolStripMenuItem.Name = "monoStereoToolStripMenuItem";
            this.monoStereoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.monoStereoToolStripMenuItem.Text = "Mono/Stereo";
            this.monoStereoToolStripMenuItem.Click += new System.EventHandler(this.monoStereoToolStripMenuItem_Click);
            // 
            // speedToolStripMenuItem1
            // 
            this.speedToolStripMenuItem1.Name = "speedToolStripMenuItem1";
            this.speedToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.speedToolStripMenuItem1.Text = "Speed";
            this.speedToolStripMenuItem1.Click += new System.EventHandler(this.speedToolStripMenuItem1_Click);
            // 
            // pitchShiftToolStripMenuItem1
            // 
            this.pitchShiftToolStripMenuItem1.Name = "pitchShiftToolStripMenuItem1";
            this.pitchShiftToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.pitchShiftToolStripMenuItem1.Text = "PitchShift";
            this.pitchShiftToolStripMenuItem1.Click += new System.EventHandler(this.pitchShiftToolStripMenuItem1_Click);
            // 
            // playPauseStopToolStripMenuItem
            // 
            this.playPauseStopToolStripMenuItem.Name = "playPauseStopToolStripMenuItem";
            this.playPauseStopToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.playPauseStopToolStripMenuItem.Text = "PlayPauseStop";
            this.playPauseStopToolStripMenuItem.Click += new System.EventHandler(this.playPauseStopToolStripMenuItem_Click);
            // 
            // highPassEqToolStripMenuItem
            // 
            this.highPassEqToolStripMenuItem.Name = "highPassEqToolStripMenuItem";
            this.highPassEqToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.highPassEqToolStripMenuItem.Text = "HighPass Eq";
            this.highPassEqToolStripMenuItem.Click += new System.EventHandler(this.highPassEqToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.karaokeToolStripMenuItem,
            this.acordesToolStripMenuItem,
            this.ajudasToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 53;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // acordesToolStripMenuItem
            // 
            this.acordesToolStripMenuItem.Name = "acordesToolStripMenuItem";
            this.acordesToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.acordesToolStripMenuItem.Text = "Chords";
            this.acordesToolStripMenuItem.Click += new System.EventHandler(this.acordesToolStripMenuItem_Click);
            // 
            // ajudasToolStripMenuItem
            // 
            this.ajudasToolStripMenuItem.Name = "ajudasToolStripMenuItem";
            this.ajudasToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.ajudasToolStripMenuItem.Text = "Help";
            this.ajudasToolStripMenuItem.Click += new System.EventHandler(this.ajudasToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1008, 329);
            this.richTextBox1.TabIndex = 55;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1008, 476);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1024, 300);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Transcriber v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTranspose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelTranspose;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxLeft;
        private System.Windows.Forms.CheckBox checkBoxRight;
        private System.Windows.Forms.CheckBox checkBoxCenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TrackBar trackBarPosition;
        private System.Windows.Forms.CheckBox checkBoxEqOn;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFreq;
        private System.Windows.Forms.TrackBar trackBarGain;
        private System.Windows.Forms.TrackBar trackBarFreq;
        private System.Windows.Forms.Label labelGain;
        private System.Windows.Forms.TrackBar trackBarTranspose;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karaokeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem monoStereoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pitchShiftToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acordesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem ajudasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playPauseStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highPassEqToolStripMenuItem;
    }
}