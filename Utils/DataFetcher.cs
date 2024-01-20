using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookApplication.HW2_additions;
using FacebookWrapper.ObjectModel;
namespace Utils
{
    internal class DataFetcher
    {
        private User m_LoggedInUser;
        private UserDescription m_UserDescription;
        internal static DataFetcher Instance { get; } = new DataFetcher();

        private DataFetcher() { }

        internal static void InitializeInstance(User i_UserObject)
        {
            Instance.m_LoggedInUser = i_UserObject;
            Instance.m_UserDescription = new UserDescription(Instance.m_LoggedInUser);
        }

        internal FacebookObjectCollection<Event> GetUserEventList()
        {
            return m_LoggedInUser.Events;
        }

        internal User GetUser()
        {
            return m_LoggedInUser;
        }

        internal string GetUserFullName()
        {
            return m_LoggedInUser.Name;
        }

        internal string GetUserProfilePicURL()
        {
            return m_LoggedInUser.PictureNormalURL;
        }

        internal string GetUserProfilePicURL(User i_User)
        {
            return i_User.PictureNormalURL;
        }

        internal UserDescription getUserDescription()
        {
            return this.m_UserDescription;
        }

        internal FacebookObjectCollection<Post> GetUserWallPosts()
        {
            return m_LoggedInUser.WallPosts;
        }

        internal FacebookObjectCollection<Post> GetUserNewsFeedPosts()
        {
            return m_LoggedInUser.NewsFeed;
        }

        internal FacebookObjectCollection<Album> GetUserAlbums()
        {
            return m_LoggedInUser.Albums;
        }

        internal string GetUserCoverPhotoURL()
        {
            return m_LoggedInUser.PhotosTaggedIn[0].PictureNormalURL;
        }

        internal FacebookObjectCollection<User> GetUserFriends()
        {
            return m_LoggedInUser.Friends;
        }
    }
}
