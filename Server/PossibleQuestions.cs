using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication.Server
{
    static class PossibleQuestions
    {
        internal static Dictionary<eQuestionSubject, string> Questions { get; private set; }

        static PossibleQuestions() {
            Questions = new Dictionary<eQuestionSubject, string>()
            {
                { eQuestionSubject.Birthday, "What is {0}'s birthday?" },
                { eQuestionSubject.About, "Which description best suits {0}?" },
                { eQuestionSubject.NumberOfPosts, "How much posts has {0} posted through the years?" },
                { eQuestionSubject.FriendsCount, "What is the number of friends that {0} has on Facebook?" }
            };
        }
    }
}
