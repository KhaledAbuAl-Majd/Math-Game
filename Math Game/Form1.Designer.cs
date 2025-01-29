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
            this.nudTimePerQuestion = new System.Windows.Forms.NumericUpDown();
            this.lbsProgressBar = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.nudRounds = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.tabPlay = new System.Windows.Forms.TabPage();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimePerQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabStart.Controls.Add(this.pictureBox5);
            this.tabStart.Controls.Add(this.pictureBox4);
            this.tabStart.Controls.Add(this.nudTimePerQuestion);
            this.tabStart.Controls.Add(this.lbsProgressBar);
            this.tabStart.Controls.Add(this.progressBar1);
            this.tabStart.Controls.Add(this.btnStart);
            this.tabStart.Controls.Add(this.pictureBox3);
            this.tabStart.Controls.Add(this.pictureBox2);
            this.tabStart.Controls.Add(this.pictureBox1);
            this.tabStart.Controls.Add(this.nudRounds);
            this.tabStart.Controls.Add(this.label4);
            this.tabStart.Controls.Add(this.label3);
            this.tabStart.Controls.Add(this.label2);
            this.tabStart.Controls.Add(this.cbOperator);
            this.tabStart.Controls.Add(this.label1);
            this.tabStart.Controls.Add(this.cbLevel);
            resources.ApplyResources(this.tabStart, "tabStart");
            this.tabStart.Name = "tabStart";
            // 
            // nudTimePerQuestion
            // 
            resources.ApplyResources(this.nudTimePerQuestion, "nudTimePerQuestion");
            this.nudTimePerQuestion.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudTimePerQuestion.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTimePerQuestion.Name = "nudTimePerQuestion";
            this.nudTimePerQuestion.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTimePerQuestion.ValueChanged += new System.EventHandler(this.nudTimePerQuestion_ValueChanged);
            this.nudTimePerQuestion.Validating += new System.ComponentModel.CancelEventHandler(this.nudTimePerQuestion_Validating);
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Name = "label2";
            // 
            // cbOperator
            // 
            this.cbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Math_Game.Properties.Resources.MathGenius__3_;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Math_Game.Properties.Resources._3198228_40273;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::Math_Game.Properties.Resources.start__1_;
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Name = "btnStart";
            this.toolTip1.SetToolTip(this.btnStart, resources.GetString("btnStart.ToolTip"));
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
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
            this.pictureBox2.Image = global::Math_Game.Properties.Resources._24644996_Tiny_students_with_huge_sign_pi_flat_vector_illustration;
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
            // frmMathGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMathGame";
            this.Load += new System.EventHandler(this.frmMathGame_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabStart.ResumeLayout(false);
            this.tabStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimePerQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudRounds;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label ProgressBarValue;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbsProgressBar;
        private System.Windows.Forms.NumericUpDown nudTimePerQuestion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

