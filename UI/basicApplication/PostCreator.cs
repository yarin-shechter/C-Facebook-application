using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Utils;

namespace FacebookApplication.UI
{
    internal partial class PostCreator : UserControl, IColorable
    {
        private DataFetcher m_Fetcher = null;
        private readonly GlowMaker r_PostCreatorGlowMaker;
        public Color Color
        {
            get => this.BackColor;
            set => this.BackColor = value;
        }

        internal PostCreator()
        {
            InitializeComponent();
            populateFieldsWithUserData();
            r_PostCreatorGlowMaker = new GlowMaker(this, Color.FromArgb(59, 89, 152));
        }

        private void populateFieldsWithUserData()
        {
            this.m_Fetcher = DataFetcher.Instance;
            try
            {
                postAuthorPicBox.ImageLocation = this.m_Fetcher.GetUserProfilePicURL();
                publishAsTextBox.Text = string.Format("Posting as {0}", this.m_Fetcher.GetUserFullName());
            }
            catch (Exception ex) { }
        }

        private void publishButton_Click(object sender, EventArgs e)
        {
            publishNewPost();
        }

        private void publishNewPost()
        {
            string postText = postContent.Text;
            User postAuthor = this.m_Fetcher.GetUser();

            try
            {
                if (postText.Length > 0)
                {
                    postAuthor.PostStatus(postText);
                }
            }
            catch (Exception e)
            {
            }
            finally
            {
                postContent.Text = string.Empty;
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            r_PostCreatorGlowMaker.MakeObjectGlow();
        }
    }
}
