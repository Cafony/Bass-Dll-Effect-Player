namespace Bass_Dll_Player
{
    partial class equalizer
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarFreq = new System.Windows.Forms.TrackBar();
            this.labelFreq = new System.Windows.Forms.Label();
            this.trackBarGain = new System.Windows.Forms.TrackBar();
            this.labelGain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGain)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(147, 120);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(104, 23);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play PeakEQ";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPeakEQ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "EQUALIZER";
            // 
            // trackBarFreq
            // 
            this.trackBarFreq.Location = new System.Drawing.Point(137, 172);
            this.trackBarFreq.Maximum = 4000;
            this.trackBarFreq.Minimum = 200;
            this.trackBarFreq.Name = "trackBarFreq";
            this.trackBarFreq.Size = new System.Drawing.Size(179, 45);
            this.trackBarFreq.SmallChange = 100;
            this.trackBarFreq.TabIndex = 12;
            this.trackBarFreq.TickFrequency = 100;
            this.trackBarFreq.Value = 1500;
            this.trackBarFreq.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelFreq
            // 
            this.labelFreq.AutoSize = true;
            this.labelFreq.Location = new System.Drawing.Point(144, 156);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(31, 13);
            this.labelFreq.TabIndex = 13;
            this.labelFreq.Text = "Freq:";
            // 
            // trackBarGain
            // 
            this.trackBarGain.Location = new System.Drawing.Point(137, 227);
            this.trackBarGain.Maximum = 15;
            this.trackBarGain.Minimum = -15;
            this.trackBarGain.Name = "trackBarGain";
            this.trackBarGain.Size = new System.Drawing.Size(179, 45);
            this.trackBarGain.SmallChange = 100;
            this.trackBarGain.TabIndex = 14;
            this.trackBarGain.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // labelGain
            // 
            this.labelGain.AutoSize = true;
            this.labelGain.Location = new System.Drawing.Point(144, 211);
            this.labelGain.Name = "labelGain";
            this.labelGain.Size = new System.Drawing.Size(32, 13);
            this.labelGain.TabIndex = 15;
            this.labelGain.Text = "Gain:";
            // 
            // equalizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 431);
            this.Controls.Add(this.labelGain);
            this.Controls.Add(this.trackBarGain);
            this.Controls.Add(this.labelFreq);
            this.Controls.Add(this.trackBarFreq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPlay);
            this.Name = "equalizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "equalizer";
            this.Load += new System.EventHandler(this.equalizer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarFreq;
        private System.Windows.Forms.Label labelFreq;
        private System.Windows.Forms.TrackBar trackBarGain;
        private System.Windows.Forms.Label labelGain;
    }
}