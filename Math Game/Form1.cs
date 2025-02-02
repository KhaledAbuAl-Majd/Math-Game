using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Math_Game.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Math_Game
{
    public partial class frmMathGame : Form
    {
        public frmMathGame()
        {
            InitializeComponent();
        }
   
        stGame Game;
        stQuestion Question;
        enum enLevel { EASY,MEDIUM,HARD,MIX};
        enum enOperator {Add,Subtract,Multiplay, Divide,Mix}

        enum enGameMode {Start,Play,Stop,Reset}
        struct stQuestion
        {
            public float Number1;
            public float Number2;
            public enOperator Operator;
            public enLevel Level;
            public float RightAnswer;
            public Nullable<float> PlayAnswer;
        }
        struct stGame
        {
            public enLevel Level;
            public enOperator Operator;
            public enGameMode GameMode;
            public sbyte TimePerQuestion;     
            public sbyte Rounds;
            public sbyte CurrentRound;
            public sbyte GameTime;
            public sbyte TimeLeft;
            public bool IsGameOver;
            public sbyte RightAnswers;
            public enResumeMode ResumeMode;
        }  

        void ComboBoxValidating_ErrorProvider(object sender, CancelEventArgs e, string Message)
        {
            if (string.IsNullOrEmpty(((ComboBox)sender).Text))
            {
                e.Cancel = true;
                ((ComboBox)sender).Focus();
                errorProvider1.SetError((ComboBox)sender, Message);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError((ComboBox)sender, "");
            }
        }

        void NumericUpDownValidating_ErrorProvider(object sender, CancelEventArgs e, string Message)
        {
            if (((NumericUpDown)sender).Value == 0)
            {
                e.Cancel = true;
                ((NumericUpDown)sender).Focus();
                errorProvider1.SetError((NumericUpDown)sender, Message);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError((NumericUpDown)sender, "");
            }
        }

        float CalculateProgressParValue(sbyte ItemNumber = 4)
        {         
            sbyte CompleteItemNumber = 0;

            if (!string.IsNullOrEmpty(cbLevel.Text))
                CompleteItemNumber++;

            if (!string.IsNullOrEmpty(cbOperator.Text))
                CompleteItemNumber++;

            if (nudTimePerQuestion.Value > 0)
                CompleteItemNumber++;           

            if (nudRounds.Value > 0)
                CompleteItemNumber++;

            return ((float)CompleteItemNumber / ItemNumber) * 100;
        }

        void changeProgressBarValue()
        {
            sbyte Value = Convert.ToSByte(CalculateProgressParValue());

            if (progressBar1.Value <= progressBar1.Maximum)
            {
                progressBar1.Value = Value;
                lbsProgressBar.Text = progressBar1.Value.ToString() + "%";
            }        
        }

        void GenerateNumbers(short MinumumNumber, short MaximumNumber,sbyte Divide_MinumuNumber,sbyte Divide_MaximumNumber)
        {
            Random rand = new Random();

            Question.Number2 = rand.Next(MinumumNumber,MaximumNumber);

            if (Question.Operator != enOperator.Divide)
                Question.Number1 = rand.Next(MinumumNumber,MaximumNumber);
            else
                Question.Number1 = Question.Number2 * rand.Next(Divide_MinumuNumber, Divide_MaximumNumber);

            //this to solve Fraction Problem
        }

        void MakeNumbersByLevel()
        {
            Question.Level = Game.Level;

            Random rand = new Random();

            if (Question.Level == enLevel.MIX)
            {
                Question.Level = (enLevel)rand.Next(3);
            }

            switch (Question.Level)
            {
                case enLevel.EASY:

                    GenerateNumbers(1, 21, 1, 3);
                    break;

                case enLevel.MEDIUM:

                    GenerateNumbers(21, 51, 1, 6);
                    break;

                case enLevel.HARD:

                    GenerateNumbers(51, 101, 1, 11);
                    break;
            }
        }

        void ChangeOperatorImage(Image image)
        {
            pbOperator.Image = image;
        }

        void ChangeNumbersLabel()
        {
            lblNumber1.Text = Question.Number1.ToString();
            lblNumber2.Text = Question.Number2.ToString();
        }

        void ChangeRoundLable()
        {
            lblRound.Text = Game.CurrentRound + "/" + Game.Rounds;
        }

        void ChangeLevelLabel()
        {
            lblLevel.Text = Game.Level.ToString();
        }

        void ChangeOperatorLabel(Label label)
        {
            switch (Game.Operator)
            {
                case enOperator.Add:
                    label.Text = "+";
                    break;

                case enOperator.Subtract:
                    label.Text = "-";
                    break;

                case enOperator.Multiplay:
                    label.Text = "*";
                    break;

                case enOperator.Divide:
                    label.Text = "/";
                    break;

                case enOperator.Mix:
                    label.Text = "MIX";
                    break;
            }
        }

        void ChangeGameTimeLabel()
        {
            lblGameTime.Text = Game.GameTime.ToString();
        }

        void ChangeTimeLeftLabel()
        {
            lblTimeLeft.Text = Game.TimeLeft.ToString();
        }
        void ChangeQuestionToUser(Image image)
        {
            ChangeNumbersLabel();
            ChangeOperatorImage(image);
        }

        void ChangeRightAndPlayerAnswerLabel()
        {
            lblRightAnswers.Text = Question.RightAnswer.ToString();
            lblPlayerAnswer.Text = Question.PlayAnswer.ToString();
        }

        void MakeQuestion()
        {
            Question.Operator = Game.Operator;

            if (Question.Operator == enOperator.Mix)
            {
                Random rand = new Random();

                Question.Operator = (enOperator)rand.Next(4);
            }

            MakeNumbersByLevel();

            switch (Question.Operator)
            {
                case enOperator.Add:
                    ChangeQuestionToUser(Resources.add);
                    Question.RightAnswer = Question.Number1 + Question.Number2;
                    break;

                case enOperator.Subtract:
                    ChangeQuestionToUser(Resources.minus);
                    Question.RightAnswer = Question.Number1 - Question.Number2;
                    break;

                case enOperator.Multiplay:
                    ChangeQuestionToUser(Resources.Multiply);
                    Question.RightAnswer = Question.Number1 * Question.Number2;
                    break;

                case enOperator.Divide:
                    ChangeQuestionToUser(Resources.divide);
                    Question.RightAnswer = Question.Number1 / Question.Number2;
                    break;
            }
        }

        void CheckGameOver()
        {
            if (Game.Rounds == Game.CurrentRound) 
                GameOver();
        }

        void NextQuestion()
        {
            CheckGameOver();

            if (Game.IsGameOver)
                return;
           
            AnswerTurn();
            Game.CurrentRound++;
            ChangeRoundLable();
            MakeQuestion();
            txtAnswer.Clear();     
        }

        void RightAnswerMessage()
        {
            MessageBox.Show("Right Answer,Bravooo", "Answer Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        void WrongAnswerMessage()
        {
            MessageBox.Show("Wrong Answer,Go On!", "Answer Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void StopTimer()
        {
            timer1.Stop();
        }

        void NextRoundTurn(bool IsGameOver = false)
        {
            StopTimer();

            if (IsGameOver)
            {
                btnNextRound.Enabled = false;
                this.AcceptButton = btnPlay_Stop_Reset;
            }
            else
            {
                btnNextRound.Enabled = true;
                this.AcceptButton = btnNextRound;
            }

            txtAnswer.Enabled = false;
            btnCheckAsnwer.Enabled = false;
            btnDonotKnow.Enabled = false;

        }

        void Reset_StartTimer()
        {
            ResetTime();
            ChangeTimeLeftLabel();
            Resume_StartTimer();
            ChangeGameTimeLabel();
        }

        void Resume_StartTimer()
        {
            timer1.Start();
        }

        void AnswerTurn()
        {
            Resume_StartTimer();
            txtAnswer.Enabled = true;
            btnCheckAsnwer.Enabled = true;
            btnDonotKnow.Enabled = true;
            btnNextRound.Enabled = false;
            txtAnswer.Focus();
            this.AcceptButton = btnCheckAsnwer;
        }

        void ResetTime()
        {
            Game.TimeLeft = Game.GameTime;
        }

        void GameOverMessage()
        {
            MessageBox.Show("Game Over", "Game Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void GameOver()
        {
            Game.IsGameOver = true;
            GameOverMessage();
            NextRoundTurn(Game.IsGameOver);
            Game.GameMode = enGameMode.Reset;
            ChangePlay_Stop_ResetButtonImageAndToolTip(3, "Press To Reset");
            btnResult.Enabled = true;
        }

        void CheckAnswer()
        {
            NextRoundTurn();

            if (Question.PlayAnswer == Question.RightAnswer)
            {
                Game.RightAnswers++;
                RightAnswerMessage();
            }
            else
            {
                WrongAnswerMessage(); 
            }

            ChangeRightAndPlayerAnswerLabel();
        }

        void CheckAnswerButton()
        {

            if (Game.IsGameOver|| string.IsNullOrWhiteSpace(txtAnswer.Text))
                return;

            try
            {
                Question.PlayAnswer = Convert.ToSingle(txtAnswer.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Only Numbers , '+','-'","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            CheckAnswer();          
            CheckGameOver();
        }

        void DonotKnow()
        {
            Question.PlayAnswer = null;
            ChangeRightAndPlayerAnswerLabel();
            NextRoundTurn();
            CheckGameOver();
        }

        void ChangePlay_Stop_ResetButtonImageAndToolTip(sbyte ImageIndex,string Message)
        {
            btnPlay_Stop_Reset.ImageIndex = ImageIndex;
            toolTip1.SetToolTip(btnPlay_Stop_Reset, Message);
        }

        void Play()
        {     
            Game.GameTime = Convert.ToSByte(Game.Rounds * Game.TimePerQuestion);
            Reset_StartTimer();
            Game.IsGameOver = false;
            NextQuestion();
            Game.GameMode = enGameMode.Play;
            ChangePlay_Stop_ResetButtonImageAndToolTip(1, "Press To Stop");
            ChangeLevelLabel();
            ChangeOperatorLabel(lblOperator);     
        }

        enum enResumeMode {AnswerTurn,NextRoundTurn }

        void Stop()
        {
            Game.GameMode = enGameMode.Stop;
            StopTimer();

            if (btnNextRound.Enabled)
            {
                btnNextRound.Enabled = false; 
                Game.ResumeMode = enResumeMode.NextRoundTurn;
            }
            else
            {
                NextRoundTurn(true);
                Game.ResumeMode = enResumeMode.AnswerTurn;
            }

            ChangePlay_Stop_ResetButtonImageAndToolTip(0, "Press To Resume");
            this.AcceptButton = btnPlay_Stop_Reset;
        }

        void ResetLabels()
        {
            lblRound.Text = "?";
            lblLevel.Text = "?";
            lblOperator.Text = "?";
            lblGameTime.Text = "?";
            lblTimeLeft.Text = "?";
            lblRightAnswers.Text =null;
            lblPlayerAnswer.Text = null;
            txtAnswer.Clear();
            lblNumber1.Text = "0";
            lblNumber2.Text = "0";
            pbOperator.Image = Resources.question_mark_96;
        }

        void ResetVariablesValue()
        {
            Game.CurrentRound = 0;
            Game.RightAnswers = 0;

        }

        void Reset()
        {
            ResetLabels();
            ResetVariablesValue();
            Game.GameMode = enGameMode.Start;
            ChangePlay_Stop_ResetButtonImageAndToolTip(0, "Press To Play");
            Game.IsGameOver = true; 
            NextRoundTurn(true);
            btnResult.Enabled = false;
           
        }

        void Resume()
        { 
            Game.GameMode = enGameMode.Play;

            if (Game.ResumeMode == enResumeMode.NextRoundTurn)
                btnNextRound.Enabled = true;
            else
                AnswerTurn();

            ChangePlay_Stop_ResetButtonImageAndToolTip(1, "Press To Stop!");
        }

        void GoToStartPage()
        {
            tabControl1.SelectedIndex = 0;
            this.AcceptButton = btnStart;
        }

        void GoToPlayPage()
        {
            tabControl1.SelectedIndex = 1;
            this.AcceptButton = btnPlay_Stop_Reset;
        }
        
        void CreateResults()
        {
            lblResultRound.Text = Game.Rounds.ToString();
            lblResultLevel.Text = Game.Level.ToString();
            ChangeOperatorLabel(lblResultOperator);
            //lblResultOperator.Text = Game.Operator.ToString();
            lblResultWinTime.Text = Game.RightAnswers.ToString();
            lblResultFailTime.Text = (Game.Rounds - Game.RightAnswers).ToString();
        }

        void GoToResultPage()
        {
            CreateResults();
            tabControl1.SelectedIndex = 2;
            this.AcceptButton = btnBackToPlayPage;
        }

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game.Level = (enLevel)((ComboBox)sender).SelectedIndex;
            changeProgressBarValue();
        }

        private void cbLevel_Validating(object sender, CancelEventArgs e)
        {
            ComboBoxValidating_ErrorProvider(sender, e, "Level Should have a Value!");
        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game.Operator = (enOperator)((ComboBox)sender).SelectedIndex;
            changeProgressBarValue();
        }

        private void cbOperator_Validating(object sender, CancelEventArgs e)
        {
            ComboBoxValidating_ErrorProvider(sender, e, "Operator should have a Value1");
        }

        private void nudRounds_ValueChanged(object sender, EventArgs e)
        {
            Game.Rounds = Convert.ToSByte(nudRounds.Value);
            changeProgressBarValue();
        }

        private void nudRounds_Validating(object sender, CancelEventArgs e)
        {
            NumericUpDownValidating_ErrorProvider(sender, e, "Rounds should be a positive number!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            GoToPlayPage();
            Reset();
        }

        private void nudTimePerQuestion_ValueChanged(object sender, EventArgs e)
        {
            Game.TimePerQuestion = Convert.ToSByte(nudTimePerQuestion.Value);
            changeProgressBarValue();
        }

        private void nudTimePerQuestion_Validating(object sender, CancelEventArgs e)
        {
            NumericUpDownValidating_ErrorProvider(sender, e, "Time/Question Should be From 5 ,To 20!");
        }

        private void frmMathGame_Load(object sender, EventArgs e)
        {
            nudTimePerQuestion.Value = 10;
            changeProgressBarValue();
            tabControl1.ItemSize = new Size(0, 1);

        }

        private void btnPlayAndStop_Click(object sender, EventArgs e)
        {
            switch (Game.GameMode)
            {
                case enGameMode.Start:
                    Play();
                    break;

                case enGameMode.Play:
                    Stop();
                    break;

                case enGameMode.Stop:
                    Resume();
                    break;

                case enGameMode.Reset:
                    Reset();
                    break;
            }

           
        }

        private void btnCheckAsnwer_Click(object sender, EventArgs e)
        {
            CheckAnswerButton();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Game.TimeLeft--;

            if (Game.TimeLeft >= 0)
                ChangeTimeLeftLabel();


            if (Game.TimeLeft == 0)
            {
                if (Game.ResumeMode == enResumeMode.AnswerTurn)
                {
                    DonotKnow();
                    GameOver();
                }
                else
                    GameOver();
            }
        }

        private void btnNextRound_Click(object sender, EventArgs e)
        {

            NextQuestion();
        }

        private void btnDonotKnow_Click(object sender, EventArgs e)
        {
            DonotKnow();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure You Want To go back\nYou Will Lose Your Progress!","Confirm"
                ,MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2)
                == DialogResult.OK)
            {

                GoToStartPage();
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            GoToResultPage();
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                if (txtAnswer.Text.Length!=0 && !(txtAnswer.Text[0] == '-' || txtAnswer.Text[0] == '+'))
                {
                    txtAnswer.Text = txtAnswer.Text.Remove(txtAnswer.TextLength-1);
                    e.Handled = true;
                }
            }          
            
        }

        private void btnBackToPlayPage_Click(object sender, EventArgs e)
        {
            GoToPlayPage();
        }

        private void btnBackToStartPage_Click(object sender, EventArgs e)
        {
            GoToStartPage();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are you Sure You Want To Leave","Confirm",MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
