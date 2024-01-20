using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookApplication.Server;
using Utils;

namespace FacebookApplication.UI
{
    internal partial class FriendsTriviaForm : Form
    {
        private Question m_Question = null;

        internal FriendsTriviaForm()
        {
            InitializeComponent();
            populateQuestionData();
        }

        private void populateQuestionData()
        {
            TriviaQuestionGenerator questionGenerator = new TriviaQuestionGenerator();

            m_Question = questionGenerator.GetQuestion();
            friendsProfilePicBox.ImageLocation = DataFetcher.Instance.GetUserProfilePicURL(questionGenerator.SelectedFriend);
            questionLabel.Text = m_Question.QuestionSubject;
            populateAnswersButtons();
        }

        private void populateAnswersButtons()
        {
            int answerIndex = 0;

            foreach(Button optionButton in answersPanel.Controls)
            {
                optionButton.Text = m_Question.AnswersArray[answerIndex];
                answerIndex++; 
            }
        }

        private void showResult(Button i_ClickedButton, int i_AnswerIndex)
        {
            i_ClickedButton.BackColor = (i_AnswerIndex == m_Question.CorrectAnswerIndex) ?
                Color.LightGreen : Color.Crimson;
            answersPanel.Controls[m_Question.CorrectAnswerIndex].BackColor = Color.LightGreen;
            foreach(Button button in answersPanel.Controls)
            {
                button.Enabled = false;
            }
        }

        private void optionButton1_Click(object sender, EventArgs e)
        {
            showResult(sender as Button, answersPanel.Controls.GetChildIndex(sender as Button));
        }

        private void optionButton2_Click(object sender, EventArgs e)
        {
            showResult(sender as Button, answersPanel.Controls.GetChildIndex(sender as Button));
        }

        private void optionButton3_Click(object sender, EventArgs e)
        {
            showResult(sender as Button, answersPanel.Controls.GetChildIndex(sender as Button));
        }

        private void optionButton4_Click(object sender, EventArgs e)
        {
            showResult(sender as Button, answersPanel.Controls.GetChildIndex(sender as Button));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
