using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication.Server
{
    internal class Question
    {
        internal string QuestionSubject { get; private set; }
        internal string[] AnswersArray { get; private set; }
        internal int CorrectAnswerIndex { get; private set; }

        internal Question(string i_Question, string[] i_PossibleAnswers, int i_CorrectAnswerIndex)
        {
            AnswersArray = new string[4];
            QuestionSubject = i_Question;
            CorrectAnswerIndex = i_CorrectAnswerIndex;
            i_PossibleAnswers.CopyTo(AnswersArray, 0);
        }
    }
}
