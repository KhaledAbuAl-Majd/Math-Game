namespace Math_Game
{
    partial class frmMathGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMathGame));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStart = new System.Windows.Forms.TabPage();
            this.lbsProgressBar = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudRounds = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.tabPlay = new System.Windows.Forms.TabPage();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabStart);
            this.tabControl1.Controls.Add(this.tabPlay);
            this.tabControl1.Controls.Add(this.tabResult);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // tabStart
            // 
            this.tabStart.BackColor = System.Drawing.Color.White;
            this.tabStart.Controls.Add(this.lbsProgressBar);
            this.tabStart.Controls.Add(this.progressBar1);
            this.tabStart.Controls.Add(this.button1);
            this.tabStart.Controls.Add(this.pictureBox3);
            this.tabStart.Controls.Add(this.pictureBox2);
            this.tabStart.Controls.Add(this.pictureBox1);
            this.tabStart.Controls.Add(this.nudRounds);
            this.tabStart.Controls.Add(this.label4);
            this.tabStart.Controls.Add(this.label3);
            this.tabStart.Controls.Add(this.cmGender);
            this.tabStart.Controls.Add(this.label2);
            this.tabStart.Controls.Add(this.cbOperator);
            this.tabStart.Controls.Add(this.label1);
            this.tabStart.Controls.Add(this.cbLevel);
            resources.ApplyResources(this.tabStart, "tabStart");
            this.tabStart.Name = "tabStart";
            // 
            // lbsProgressBar
            // 
            resources.ApplyResources(this.lbsProgressBar, "lbsProgressBar");
            this.lbsProgressBar.ForeColor = System.Drawing.Color.Green;
            this.lbsProgressBar.Name = "lbsProgressBar";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Math_Game.Properties.Resources.start__1_;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Math_Game.Properties.Resources.welcome_back;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Math_Game.Properties.Resources._25539879_5evt_7hel_220316;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Math_Game.Properties.Resources._25539879_5evt_7hel_220316;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // nudRounds
            // 
            resources.ApplyResources(this.nudRounds, "nudRounds");
            this.nudRounds.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRounds.Name = "nudRounds";
            this.nudRounds.ValueChanged += new System.EventHandler(this.nudRounds_ValueChanged);
            this.nudRounds.Validating += new System.ComponentModel.CancelEventHandler(this.nudRounds_Validating);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Name = "label3";
            // 
            // cmGender
            // 
            resources.ApplyResources(this.cmGender, "cmGender");
            this.cmGender.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmGender.FormattingEnabled = true;
            this.cmGender.Items.AddRange(new object[] {
            resources.GetString("cmGender.Items"),
            resources.GetString("cmGender.Items1")});
            this.cmGender.Name = "cmGender";
            this.cmGender.SelectedIndexChanged += new System.EventHandler(this.cmGender_SelectedIndexChanged);
            this.cmGender.Validating += new System.ComponentModel.CancelEventHandler(this.cmGender_Validating);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Name = "label2";
            // 
            // cbOperator
            // 
            resources.ApplyResources(this.cbOperator, "cbOperator");
            this.cbOperator.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            resources.GetString("cbOperator.Items"),
            resources.GetString("cbOperator.Items1"),
            resources.GetString("cbOperator.Items2"),
            resources.GetString("cbOperator.Items3"),
            resources.GetString("cbOperator.Items4")});
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.SelectedIndexChanged += new System.EventHandler(this.cbOperator_SelectedIndexChanged);
            this.cbOperator.Validating += new System.ComponentModel.CancelEventHandler(this.cbOperator_Validating);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Name = "label1";
            // 
            // cbLevel
            // 
            resources.ApplyResources(this.cbLevel, "cbLevel");
            this.cbLevel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            resources.GetString("cbLevel.Items"),
            resources.GetString("cbLevel.Items1"),
            resources.GetString("cbLevel.Items2"),
            resources.GetString("cbLevel.Items3")});
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            this.cbLevel.Validating += new System.ComponentModel.CancelEventHandler(this.cbLevel_Validating);
            // 
            // tabPlay
            // 
            resources.ApplyResources(this.tabPlay, "tabPlay");
            this.tabPlay.Name = "tabPlay";
            this.tabPlay.UseVisualStyleBackColor = true;
            // 
            // tabResult
            // 
            resources.ApplyResources(this.tabResult, "tabResult");
            this.tabResult.Name = "tabResult";
            this.tabResult.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMathGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMathGame";
            this.tabControl1.ResumeLayout(false);
            this.tabStart.ResumeLayout(false);
            this.tabStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStart;
        private System.Windows.Forms.TabPage tabPlay;
        private System.Windows.Forms.TabPage tabResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmGender;
        private System.Windows.Forms.NumericUpDown nudRounds;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label ProgressBarValue;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbsProgressBar;
    }
}

