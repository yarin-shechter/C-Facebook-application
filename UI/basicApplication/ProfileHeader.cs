using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;

namespace FacebookApplication.UI
{

    internal partial class ProfileHeader : UserControl, IColorable
    {
        private bool m_IsEditing = false;
        private readonly GlowMaker r_ProfileHeaderGlowMaker;
        public Color Color
        {
            get => this.BackColor;
            set => this.BackColor = value;
        }
        
        internal ProfileHeader()
        {
            InitializeComponent();
            initializeData();
            r_ProfileHeaderGlowMaker = new GlowMaker(this, Color.FromArgb(59, 89, 152));
        }

        private void initializeData()
        {
            DataFetcher fetcher = DataFetcher.Instance;

            if (fetcher != null)
            {
                this.coverPicBox.ImageLocation = fetcher.GetUserCoverPhotoURL();
                this.profilePicBox.ImageLocation = fetcher.GetUserProfilePicURL();
                this.userFullName.Text = fetcher.GetUserFullName();
                this.userDescriptionBindingSource.DataSource = fetcher.getUserDescription();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (!m_IsEditing)
            {
                this.startEditing();
            }
            else
            {
                this.doneEditing();
            }

        }

        private void startEditing()
        {
            m_IsEditing = true;
            this.editButton.Text = "Done";
            foreach (Control c in this.descriptionPanel.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).ReadOnly = false;
                    (c as TextBox).BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }
        private void doneEditing()
        {
            m_IsEditing = false;
            this.editButton.Text = "Edit";
            foreach (Control c in this.descriptionPanel.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).ReadOnly = true;
                    (c as TextBox).BorderStyle = BorderStyle.None;
                }
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            r_ProfileHeaderGlowMaker.MakeObjectGlow();
        }
    }
}
