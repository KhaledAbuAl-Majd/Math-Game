﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class frmMathGame : Form
    {
        public frmMathGame()
        {
            InitializeComponent();
        }
   
        stGameStatus GameStatus;
        enum enLevel { Easy,Midium,Hard,Mix};
        enum enOperator {Add,Subtract,Multiplay, Divide,Mix}
        struct stGameStatus
        {
            public enLevel Level;
            public enOperator Operator;
            public sbyte TimePerQuestion;     
            public sbyte Rounds;
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

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameStatus.Level = (enLevel)((ComboBox)sender).SelectedIndex;
            changeProgressBarValue();
        }

        private void cbLevel_Validating(object sender, CancelEventArgs e)
        {
            ComboBoxValidating_ErrorProvider(sender, e, "Level Should have a Value!");
        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameStatus.Operator = (enOperator)((ComboBox)sender).SelectedIndex;
            changeProgressBarValue();
        }

        private void cbOperator_Validating(object sender, CancelEventArgs e)
        {
            ComboBoxValidating_ErrorProvider(sender, e, "Operator should have a Value1");
        }

        private void nudRounds_ValueChanged(object sender, EventArgs e)
        {
            GameStatus.Rounds = Convert.ToSByte(nudRounds.Value);
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

            tabControl1.SelectedIndex = 1;
        }

        private void nudTimePerQuestion_ValueChanged(object sender, EventArgs e)
        {
            GameStatus.TimePerQuestion = Convert.ToSByte(nudTimePerQuestion.Value);
            changeProgressBarValue();
        }

        private void nudTimePerQuestion_Validating(object sender, CancelEventArgs e)
        {
            NumericUpDownValidating_ErrorProvider(sender, e, "Time/Question Should be From 5 ,To 20!");
        }

        private void frmMathGame_Load(object sender, EventArgs e)
        {
            changeProgressBarValue();
        }
    }
}
