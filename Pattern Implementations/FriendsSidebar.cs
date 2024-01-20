using System;
using System.Drawing;
using System.Windows.Forms;
using Utils;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication.HW2_additions
{
    public partial class FriendsSidebar : UserControl, IColorable
    {
        private readonly GlowMaker r_FriendsSideBarGlowMaker;
        public Color Color
        {
            get => this.BackColor;
            set => this.BackColor = value;
        }

        public FriendsSidebar()
        {
            InitializeComponent();

            DataFetcher fetcher = DataFetcher.Instance;
            FacebookObjectCollection<User> userFriendsList = fetcher.GetUserFriends();

            initFriendsList(userFriendsList);
            initBirthdays(userFriendsList);
            r_FriendsSideBarGlowMaker = new GlowMaker(this, Color.FromArgb(59, 89, 152));
        }
        private void initFriendsList(FacebookObjectCollection<User> i_FriendsList)
        {
            for (int i = 0; i < i_FriendsList.Count && i < 3; i++)
            {
                addFriendToList(i_FriendsList[i], i);
                i++;
            }
        }
        private void initBirthdays(FacebookObjectCollection<User> i_FriendsList)
        {
            for (int i = 0; i < i_FriendsList.Count && i < 3; i++)
            {
                addFriendBirthdayToList(i_FriendsList[i], i);
                i++;
            }
        }
        private void addFriendToList(User i_Friend, int i_RowNumber)
        {
            PictureBox profilePic = new PictureBox();
            Label friendsName = new Label();

            profilePic.ImageLocation = i_Friend.PictureSqaureURL;
            friendsName.Text = string.Format("{0} {1}", i_Friend.FirstName, i_Friend.LastName);
            friendsName.Font = new Font("Arial", 12, FontStyle.Regular);
            friendsName.TextAlign = ContentAlignment.MiddleLeft;
            friendsName.Width = 110;
            friendsName.Height = 50;
            this.friendsLayoutPanel.Controls.Add(profilePic, 0, i_RowNumber);
            this.friendsLayoutPanel.Controls.Add(friendsName, 1, i_RowNumber);
        }

        private void addFriendBirthdayToList(User i_Friend, int i_RowNumber)
        {
            PictureBox profilePic = new PictureBox();
            Label friendsBirthday = new Label();

            profilePic.ImageLocation = i_Friend.PictureSqaureURL;
            friendsBirthday.Text = string.Format("{0} {1}: {2}", i_Friend.FirstName, i_Friend.LastName, i_Friend.Birthday);
            friendsBirthday.Font = new Font("Arial", 12, FontStyle.Regular);
            friendsBirthday.TextAlign = ContentAlignment.MiddleLeft;
            friendsBirthday.Width = 250;
            friendsBirthday.Height = 50;
            this.birthdaysLayout.Controls.Add(profilePic, 0, i_RowNumber);
            this.birthdaysLayout.Controls.Add(friendsBirthday, 1, i_RowNumber);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            r_FriendsSideBarGlowMaker.MakeObjectGlow();
        }
    }
}
