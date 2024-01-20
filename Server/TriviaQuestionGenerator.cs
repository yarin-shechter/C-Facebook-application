using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using Utils;

namespace FacebookApplication.Server
{
    internal class TriviaQuestionGenerator
    {
        private readonly User r_FriendToAskQuestionAbout = null;

        internal User SelectedFriend => r_FriendToAskQuestionAbout;

        internal TriviaQuestionGenerator()
        {
            r_FriendToAskQuestionAbout = getRandomFriend(DataFetcher.Instance.GetUser());
        }

        internal Question GetQuestion()
        {
            eQuestionSubject randomSubject = getRandomQuestionSubject();
            string questionSubject = getParsedQuestion(randomSubject);
            string[] answersArray = getAnswers(randomSubject, out int correctAnswerIndex);

            return new Question(questionSubject, answersArray, correctAnswerIndex);
        }

        private eQuestionSubject getRandomQuestionSubject()
        {
            Random randomGenerator = new Random();
            Array possibleSubjects = Enum.GetValues(typeof(eQuestionSubject));
            int randomIndex = randomGenerator.Next(possibleSubjects.Length);

            return (eQuestionSubject)possibleSubjects.GetValue(randomIndex);
        }

        private string getParsedQuestion(eQuestionSubject i_Subject)
        {
            string question = PossibleQuestions.Questions[i_Subject];
            
            return string.Format(question, r_FriendToAskQuestionAbout.Name);
        }

        private string[] getAnswers(eQuestionSubject i_Subject, out int i_CorrectAnswerIndex)
        {
            Tuple<string[], int> generatedAnswers = 
                (Tuple<string[], int>)PossibleAnswers.Answers[i_Subject].DynamicInvoke(r_FriendToAskQuestionAbout);
            string[] possibleAnswers = generatedAnswers.Item1;

            i_CorrectAnswerIndex = generatedAnswers.Item2;

            return possibleAnswers;
        }

        private User getRandomFriend(User i_LoggedInUser)
        {
            FacebookObjectCollection<User> friendList = i_LoggedInUser.Friends;
            Random randomGenerator = new Random();
            int randomFriendIndex = randomGenerator.Next(0, friendList.Count);
            User randomFriend = null;

            if (friendList != null)
            {
                randomFriend = friendList.ElementAt(randomFriendIndex);
            }

            return randomFriend;
        }
    }
}
