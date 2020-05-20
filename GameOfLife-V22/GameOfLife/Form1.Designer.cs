namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CavecheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PatternComboBox = new System.Windows.Forms.ComboBox();
            this.RandomMapcheckBox = new System.Windows.Forms.CheckBox();
            this.ErasecheckBox = new System.Windows.Forms.CheckBox();
            this.DrawcheckBox = new System.Windows.Forms.CheckBox();
            this.MapSizetrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GridFlag = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapSizetrackBar)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 800);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PlayButton
            // 
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.Location = new System.Drawing.Point(3, 11);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(107, 23);
            this.PlayButton.TabIndex = 4;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click_1);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(3, 40);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(107, 23);
            this.PauseButton.TabIndex = 6;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Generation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "00000";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.ResetButton);
            this.panel2.Controls.Add(this.PlayButton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.PauseButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(822, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 125);
            this.panel2.TabIndex = 9;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(3, 69);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(107, 23);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.CavecheckBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.PatternComboBox);
            this.panel3.Controls.Add(this.RandomMapcheckBox);
            this.panel3.Location = new System.Drawing.Point(822, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 95);
            this.panel3.TabIndex = 10;
            // 
            // CavecheckBox
            // 
            this.CavecheckBox.AutoSize = true;
            this.CavecheckBox.Location = new System.Drawing.Point(3, 27);
            this.CavecheckBox.Name = "CavecheckBox";
            this.CavecheckBox.Size = new System.Drawing.Size(84, 17);
            this.CavecheckBox.TabIndex = 5;
            this.CavecheckBox.Text = "Cave/Island";
            this.CavecheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Pattern";
            // 
            // PatternComboBox
            // 
            this.PatternComboBox.FormattingEnabled = true;
            this.PatternComboBox.Items.AddRange(new object[] {
            "Glider",
            "LWSS",
            "10 Cell Row",
            "Tumbler",
            "Gosip Glider Gun",
            "Flower",
            "R-pentomino",
            "Diehard",
            "Acorn"});
            this.PatternComboBox.Location = new System.Drawing.Point(3, 63);
            this.PatternComboBox.Name = "PatternComboBox";
            this.PatternComboBox.Size = new System.Drawing.Size(107, 21);
            this.PatternComboBox.TabIndex = 3;
            this.PatternComboBox.SelectedIndexChanged += new System.EventHandler(this.PatterncomboBox_SelectedIndexChanged);
            // 
            // RandomMapcheckBox
            // 
            this.RandomMapcheckBox.AutoSize = true;
            this.RandomMapcheckBox.Location = new System.Drawing.Point(3, 3);
            this.RandomMapcheckBox.Name = "RandomMapcheckBox";
            this.RandomMapcheckBox.Size = new System.Drawing.Size(89, 17);
            this.RandomMapcheckBox.TabIndex = 0;
            this.RandomMapcheckBox.Text = "Random map";
            this.RandomMapcheckBox.UseVisualStyleBackColor = true;
            // 
            // ErasecheckBox
            // 
            this.ErasecheckBox.AutoSize = true;
            this.ErasecheckBox.Location = new System.Drawing.Point(57, 3);
            this.ErasecheckBox.Name = "ErasecheckBox";
            this.ErasecheckBox.Size = new System.Drawing.Size(53, 17);
            this.ErasecheckBox.TabIndex = 2;
            this.ErasecheckBox.Text = "Erase";
            this.ErasecheckBox.UseVisualStyleBackColor = true;
            this.ErasecheckBox.CheckedChanged += new System.EventHandler(this.ErasecheckBox_CheckedChanged);
            // 
            // DrawcheckBox
            // 
            this.DrawcheckBox.AutoSize = true;
            this.DrawcheckBox.Location = new System.Drawing.Point(3, 3);
            this.DrawcheckBox.Name = "DrawcheckBox";
            this.DrawcheckBox.Size = new System.Drawing.Size(51, 17);
            this.DrawcheckBox.TabIndex = 1;
            this.DrawcheckBox.Text = "Draw";
            this.DrawcheckBox.UseVisualStyleBackColor = true;
            this.DrawcheckBox.CheckedChanged += new System.EventHandler(this.DrawcheckBox_CheckedChanged);
            // 
            // MapSizetrackBar
            // 
            this.MapSizetrackBar.AllowDrop = true;
            this.MapSizetrackBar.Location = new System.Drawing.Point(6, 42);
            this.MapSizetrackBar.Maximum = 32;
            this.MapSizetrackBar.Minimum = 5;
            this.MapSizetrackBar.Name = "MapSizetrackBar";
            this.MapSizetrackBar.Size = new System.Drawing.Size(107, 45);
            this.MapSizetrackBar.TabIndex = 3;
            this.MapSizetrackBar.Value = 5;
            this.MapSizetrackBar.Scroll += new System.EventHandler(this.MapSizetrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "0";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tile Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Map  Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.GridFlag);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.MapSizetrackBar);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(822, 272);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(116, 133);
            this.panel4.TabIndex = 11;
            // 
            // GridFlag
            // 
            this.GridFlag.AutoSize = true;
            this.GridFlag.Location = new System.Drawing.Point(9, 94);
            this.GridFlag.Name = "GridFlag";
            this.GridFlag.Size = new System.Drawing.Size(89, 17);
            this.GridFlag.TabIndex = 15;
            this.GridFlag.Text = "Grid ON/OFF";
            this.GridFlag.UseVisualStyleBackColor = true;
            this.GridFlag.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.DrawcheckBox);
            this.panel5.Controls.Add(this.ErasecheckBox);
            this.panel5.Location = new System.Drawing.Point(822, 143);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(116, 22);
            this.panel5.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(944, 826);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Game of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapSizetrackBar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox RandomMapcheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox DrawcheckBox;
        private System.Windows.Forms.CheckBox ErasecheckBox;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TrackBar MapSizetrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox GridFlag;
        private System.Windows.Forms.ComboBox PatternComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox CavecheckBox;
        private System.Windows.Forms.Timer timer2;
    }
}

