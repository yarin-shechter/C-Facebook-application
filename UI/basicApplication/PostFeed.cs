using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookApplication.Iterator_Pattern;
using FacebookWrapper.ObjectModel;
using Utils;
using FacebookApplication.Server;

namespace FacebookApplication.UI
{
    internal partial class PostFeed : UserControl
    {
        private int m_PostDisplayBuffer = 3;
        private PostAggregate m_PostAggregate = null;
        private IPostIterator m_PostsIterator = null;
        internal PostFeed(eFeedType i_FeedType)
        {
            InitializeComponent();
            Anchor = AnchorStyles.Top;
            initializePosts(i_FeedType);
            this.displayPosts();
        }

        private void initializePosts(eFeedType i_FeedType)
        {
            DataFetcher fetcher = DataFetcher.Instance;
            FacebookObjectCollection<Post> posts = i_FeedType == eFeedType.NewsFeed ?
                fetcher.GetUserNewsFeedPosts() : fetcher.GetUserWallPosts();
            this.m_PostAggregate = new PostAggregate(posts);
            this.m_PostsIterator = this.m_PostAggregate.GetPostIterator();
        }

        private void displayPosts()
        {
            int i = 0;
            while(this.m_PostsIterator.MoveNext() && i < this.m_PostDisplayBuffer)
            {
                this.addPost(this.m_PostsIterator.GetCurrent());
                i++;
            }
        }

        private void addPost(Post i_PostObject)
        {
            FBPost newPost = new FBPost(i_PostObject);
            int postListNewHeight = this.postList.Size.Height + newPost.Size.Height;

            this.postList.Size = new Size(this.postList.Size.Width, postListNewHeight);
            this.postList.Controls.Add(newPost);
        }

        private void loadMoreButton_Click(object sender, EventArgs e)
        {
            this.displayPosts();
        }
    }
}
