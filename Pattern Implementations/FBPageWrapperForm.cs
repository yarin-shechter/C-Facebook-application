using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookApplication.Observer_Pattern;
using FacebookApplication.UI;

namespace FacebookApplication.HW2_additions
{
    public partial class FBPageWrapperForm : Form, IHomeButtonObserver, ILogoutButtonObserver, IProfileButtonObserver, IFriendsTriviaButtonObserver, IBlastFromThePastButtonObserver
    {
        private TopBar m_TopBar;
        private TableLayoutPanel m_ComponentList;
        public event Action HomeButtonClicked;
        public event Action ProfileButtonClicked;
        public event Action LogoutButtonClicked;
        public event Action BlastFromThePastButtonClicked;
        public event Action FriendsTriviaButtonClicked;

        public FBPageWrapperForm()
        {
            InitializeComponent();
            designForm();
            initTopBar();
        }

        private void initTopBar()
        {
            this.m_TopBar.loadUserData();
            subscribeToTopBarUpdates();
        }

        private void subscribeToTopBarUpdates()
        {
            this.m_TopBar.AddHomeButtonObserver(this);
            this.m_TopBar.AddProfileButtonObserver(this);
            this.m_TopBar.AddLogoutButtonObserver(this);
            this.m_TopBar.AddBlastFromThePastButtonObserver(this);
            this.m_TopBar.AddFriendsTriviaButtonObserver(this);
        }

        internal void setFBPage(TableLayoutPanel i_FBPageToSet)
        {
            this.Controls.Remove(this.m_ComponentList);
            this.m_ComponentList = i_FBPageToSet;
            this.Controls.Add(this.m_ComponentList);
        }

        public void ReportHomeButtonClicked()
        {
            OnHomeButtonClicked();
        }

        public void ReportProfileButtonClicked()
        {
            OnProfileButtonClicked();
        }

        public void ReportLogoutButtonClicked()
        {
            OnLogoutButtonClicked();
        }

        public void ReportBlastFromThePastButtonClicked()
        {
            OnBlastFromThePastButtonClick();
        }

        public void ReportFriendsTriviaButtonClicked()
        {
            OnFriendsTriviaClicked();
        }

        protected virtual void OnHomeButtonClicked()
        {
            if (HomeButtonClicked != null)
            {
                HomeButtonClicked.Invoke();
            }
        }
        protected virtual void OnProfileButtonClicked()
        {
            if (ProfileButtonClicked != null)
            {
                ProfileButtonClicked.Invoke();
            }
        }

        protected virtual void OnLogoutButtonClicked()
        {
            if (LogoutButtonClicked != null)
            {
                LogoutButtonClicked.Invoke();
            }
        }

        protected virtual void OnBlastFromThePastButtonClick()
        {
            if (BlastFromThePastButtonClicked != null)
            {
                BlastFromThePastButtonClicked.Invoke();
            }
        }

        protected virtual void OnFriendsTriviaClicked()
        {
            if (FriendsTriviaButtonClicked != null)
            {
                FriendsTriviaButtonClicked.Invoke();
            }
        }

        private void designForm()
        {
            this.m_TopBar = new TopBar();
            this.m_ComponentList = new TableLayoutPanel();
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1280, 844);
            this.Controls.Add(this.m_TopBar);
            this.Controls.Add(this.m_ComponentList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FBPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Application | Home";
            this.ResumeLayout(false);
            this.m_TopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_TopBar.Location = new System.Drawing.Point(-5, 0);
            this.m_TopBar.Name = "m_TopBar";
            this.m_TopBar.Size = new System.Drawing.Size(1280, 40);
            this.m_TopBar.TabIndex = 0;
            this.Controls.Add(m_TopBar);
        }
    }
}
