using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication.Server
{
    internal static class PossibleAnswers
    {
        internal static Dictionary<eQuestionSubject, Delegate> Answers { get; private set; }

        static PossibleAnswers()
        {
            Answers = new Dictionary<eQuestionSubject, Delegate>()
            {
                { eQuestionSubject.Birthday, new Func<User, Tuple<string[], int>>(GenerateBirthdayAnswers) },
                { eQuestionSubject.About, new Func<User, Tuple<string[], int>>(GenerateHometownAnswers) },
                { eQuestionSubject.NumberOfPosts, new Func<User, Tuple<string[], int>>(GeneratePostsCountAnswers) },
                { eQuestionSubject.FriendsCount, new Func<User, Tuple<string[], int>>(GenerateFriendsCountAnswers) }
            };
        }

        internal static Tuple<string[], int> GenerateBirthdayAnswers(User i_QuestionUser)
        {
            Tuple<object[], int> answersTuple = generateAnswersArray(i_QuestionUser, "Birthday");
            string[] answers = new string[4];

            for (int i = 0; i < answers.Length; i++)
            {
                answers[i] = (string)answersTuple.Item1[i];
            }

            return new Tuple<string[], int>(answers, answersTuple.Item2);
        }

        internal static Tuple<string[], int> GenerateHometownAnswers(User i_QuestionUser)
        {
            Tuple<object[], int> answersTuple = generateAnswersArray(i_QuestionUser, "About");
            string[] answers = new string[4];

            for (int i = 0; i < answers.Length; i++)
            {
                answers[i] = (answersTuple.Item1[i] != null) ? 
                    answersTuple.Item1[i].ToString() : string.Empty;
            }

            return new Tuple<string[], int>(answers, answersTuple.Item2);
        }

        internal static Tuple<string[], int> GeneratePostsCountAnswers(User i_QuestionUser)
        {
            Tuple<object[], int> answersTuple = generateAnswersArray(i_QuestionUser, "Posts");
            string[] answers = new string[4];

            for (int i = 0; i < answers.Length; i++)
            {
                answers[i] = (answersTuple.Item1[i] != null) ? 
                    (answersTuple.Item1[i] as FacebookObjectCollection<Post>).Count.ToString() : string.Empty;
            }

            return new Tuple<string[], int>(answers, answersTuple.Item2);
        }

        internal static Tuple<string[], int> GenerateFriendsCountAnswers(User i_QuestionUser)
        {
            Tuple<object[], int> answersTuple = generateAnswersArray(i_QuestionUser, "Friends");
            string[] answers = new string[4];

            for (int i = 0; i < answers.Length; i++)
            {
                answers[i] = (answersTuple.Item1[i] != null) ?
                    (answersTuple.Item1[i] as FacebookObjectCollection<User>).Count.ToString() : string.Empty;
            }

            return new Tuple<string[], int>(answers, answersTuple.Item2);
        }

        private static Tuple<object[], int> generateAnswersArray(User i_User, string i_PropertyName)
        {
            User[] randomFriends = getThreeRandomFriends(i_User);
            List<object> answers = new List<object>();
            object userValue = i_User.GetType().GetProperty(i_PropertyName).GetValue(i_User, null);
            object[] shuffledArray = null;
            int correctAnswerIndex = -1;

            answers.Add(userValue);
            foreach (User friend in randomFriends)
            {
                object friendValue = friend.GetType().GetProperty(i_PropertyName).GetValue(friend, null);
                answers.Add(friendValue);
            }

            shuffledArray = shuffleArrayList(answers.ToArray());
            correctAnswerIndex = Array.IndexOf(shuffledArray, userValue);

            return new Tuple<object[], int>(shuffledArray, correctAnswerIndex);
        }

        private static User[] getThreeRandomFriends(User i_User)
        {
            User[] result = new User[3];
            FacebookObjectCollection<User> userFriends = i_User.Friends;
            Random randomGenerator = new Random();

            for (int i = 0; i < result.Length; i++)
            {
                int randomIndex = randomGenerator.Next(userFriends.Count);
                result[i] = userFriends[randomIndex];
            }

            return result;
        }

        private static object[] shuffleArrayList(object[] i_Array)
        {
            Random randomGenerator = new Random();

            return i_Array.OrderBy(x => randomGenerator.Next()).ToArray();
        }
    }
}
