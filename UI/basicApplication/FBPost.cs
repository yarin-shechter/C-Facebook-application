using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using UI;
using Utils;

namespace FacebookApplication.UI
{
    internal partial class FBPost : UserControl, IColorable
    {
        private readonly Post r_UserPost = null;
        private readonly GlowMaker r_FBPostGlowMaker;
        private bool m_IsLiked = false;
        private string m_LikesText;
        private string m_CommentsText;
        public Color Color
        {
            get => this.BackColor;
            set => this.BackColor = value;
        }

        internal FBPost(Post i_UserPost)
        {
            InitializeComponent();
            r_UserPost = i_UserPost;
            populatePostData();
            r_FBPostGlowMaker = new GlowMaker(this, Color.FromArgb(59, 89, 152));
        }

        private void populatePostData()
        {
            try
            {
                m_LikesText = string.Format("Liked by {0} people", r_UserPost.LikedBy.Count);
                m_CommentsText = string.Format("{0} comments", r_UserPost.Comments.Count);

                this.authorNameTextBox.Text = r_UserPost.From.Name;
                this.authorPicBox.ImageLocation = r_UserPost.From.PictureSqaureURL;
                this.postMetadataTextBox.Text = string.Format("{0}", r_UserPost.UpdateTime);
                this.likedByTextBox.Text = string.Format("{0}, {1}", m_LikesText, m_CommentsText);
                this.contentTextBox.Text = r_UserPost.Message;
                this.attachedPicBox.ImageLocation = r_UserPost.PictureURL;
                if (contentTextBox.Text.Length == 0)
                {
                    removeContentTextBox();
                }

                if (r_UserPost.Type != Post.eType.photo)
                {
                    removeImageControl();
                }
            }
            catch { }
        }

        private void removeContentTextBox()
        {
            int textBoxHeight = contentTextBox.Size.Height;

            contentTextBox.Dispose();
            attachedPicBox.Location = new Point(attachedPicBox.Location.X, attachedPicBox.Location.Y - textBoxHeight);
            likedByTextBox.Location = new Point(likedByTextBox.Location.X, likedByTextBox.Location.Y - textBoxHeight);
            likeButton.Location = new Point(likeButton.Location.X, likeButton.Location.Y - textBoxHeight);
            commentButton.Location = new Point(commentButton.Location.X, commentButton.Location.Y - textBoxHeight);
            postDivider.Location = new Point(postDivider.Location.X, postDivider.Location.Y - textBoxHeight);
        }

        private void removeImageControl()
        {
            int pictureBoxHeight = attachedPicBox.Size.Height;

            attachedPicBox.Dispose();
            likedByTextBox.Location = new Point(likedByTextBox.Location.X, likedByTextBox.Location.Y - pictureBoxHeight);
            likeButton.Location = new Point(likeButton.Location.X, likeButton.Location.Y - pictureBoxHeight);
            commentButton.Location = new Point(commentButton.Location.X, commentButton.Location.Y - pictureBoxHeight);
            postDivider.Location = new Point(postDivider.Location.X, postDivider.Location.Y - pictureBoxHeight);
        }

        private void likePost()
        {
            try
            {
                r_UserPost.Like();
            }
            catch (Exception ex) { }
            finally
            {
                if (!m_IsLiked)
                {
                    likeButton.Text = "Unlike";
                    m_LikesText = string.Format("Liked by You, and {0} other people", r_UserPost.LikedBy.Count);
                    likedByTextBox.Text = string.Format("{0}, {1}", m_LikesText, m_CommentsText);
                }
                else
                {
                    likeButton.Text = "Like";
                    m_LikesText = string.Format("Liked by {0} people", r_UserPost.LikedBy.Count);
                    likedByTextBox.Text = string.Format("{0}, {1}", m_LikesText, m_CommentsText);
                }

                m_IsLiked = !m_IsLiked;
            }
        }

        private void publishPostComment()
        {
            string commentText = showCommentDialog("Please type your comment:", "Add a comment");

            try
            {
                Comment newComment = r_UserPost.Comment(commentText);
                r_UserPost.Comments.Add(new Comment());
            }
            catch (Exception ex) { }
            finally
            {
                if (commentText.Length > 0)
                {
                    m_CommentsText = string.Format("{0} comments", r_UserPost.Comments.Count + 1);
                    likedByTextBox.Text = string.Format("{0}, {1}", m_LikesText, m_CommentsText);
                }
            }
        }

        private static string showCommentDialog(string text, string caption)
        {
            Form commentPrompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label commentLabel = new Label() { Left = 50, Top = 20, Width = 300, Text = text };
            TextBox commentTextBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmationButton = new Button() { Text = "Publish", Left = 350, Width = 100, Top = 75, DialogResult = DialogResult.OK };

            confirmationButton.Click += (sender, e) => { commentPrompt.Close(); };
            commentTextBox.Multiline = true;
            commentPrompt.Controls.Add(commentTextBox);
            commentPrompt.Controls.Add(confirmationButton);
            commentPrompt.Controls.Add(commentLabel);
            commentPrompt.AcceptButton = confirmationButton;

            return commentPrompt.ShowDialog() == DialogResult.OK ? commentTextBox.Text : "";
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            likePost();
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            publishPostComment();
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            r_FBPostGlowMaker.MakeObjectGlow();
        }
    }
}
