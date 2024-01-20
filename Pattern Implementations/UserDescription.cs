using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication.HW2_additions
{
    class UserDescription
    {
        public string About { get; set; } = "Say something about yourself...";
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string CurrentWorkplace { get; set; } = "Where do you currently work?";
        public string Hobbies { get; set; } = "What are your hobbies?";
        internal UserDescription(User i_LoggedInUser)
        {
            this.Birthday = i_LoggedInUser.Birthday;
            this.Gender = i_LoggedInUser.Gender.ToString();
        }
    }
}
