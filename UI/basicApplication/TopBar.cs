using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookApplication.Observer_Pattern;
using FacebookWrapper;
using Utils;

namespace FacebookApplication.UI
{
    internal partial class TopBar : UserControl, IColorable
    {
        
        private readonly GlowMaker r_TopBarGlowMaker;
        private readonly List<IHomeButtonObserver> r_HomeButtonObservers = new List<IHomeButtonObserver>();
        private readonly List<IProfileButtonObserver> r_ProfileButtonObservers = new List<IProfileButtonObserver>();
        private readonly List<ILogoutButtonObserver> r_LogoutButtonObservers = new List<ILogoutButtonObserver>();
        private readonly List<IFriendsTriviaButtonObserver> r_FriendsTriviaButtonObservers =
            new List<IFriendsTriviaButtonObserver>();
        private readonly List<IBlastFromThePastButtonObserver> r_BlastFromThePastButtonObservers =
            new List<IBlastFromThePastButtonObserver>();
        public Color Color
        {
            get => this.BackColor;
            set => this.BackColor = value;
        }

        internal TopBar()
        {
            InitializeComponent();
            r_TopBarGlowMaker = new GlowMaker(this, Color.White);
        }

        internal void loadUserData()
        {
            DataFetcher fetcher = DataFetcher.Instance;

            if (fetcher != null)
            {
                this.profileButton.Text = fetcher.GetUserFullName();
                this.profilePicBox.ImageLocation = fetcher.GetUserProfilePicURL();
            }
        }

        private void facebookLogoPicture_Click(object sender, EventArgs e)
        {
            this.notifyAllHomeButtonObservers();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.notifyAllHomeButtonObservers();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            this.notifyAllProfileButtonObservers();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.notifyAllLogoutButtonObservers();
        }

        private void blastFromThePastButton_Click(object sender, EventArgs e)
        {
            this.notifyAllBlastFromThePastButtonObservers();
        }

        private void friendsTriviaButton_Click(object sender, EventArgs e)
        {
            this.notifyAllFriendsTriviaButtonObservers();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.r_TopBarGlowMaker.MakeObjectGlow();
        }

        internal void AddHomeButtonObserver(IHomeButtonObserver i_ObserverToAdd)
        {
            this.r_HomeButtonObservers.Add(i_ObserverToAdd);
        }

        internal void RemoveHomeButtonObserver(IHomeButtonObserver i_ObserverToAdd)
        {
            this.r_HomeButtonObservers.Remove(i_ObserverToAdd);
        }

        private void notifyAllHomeButtonObservers()
        {
            foreach (IHomeButtonObserver observer in this.r_HomeButtonObservers)
            {
                observer.ReportHomeButtonClicked();
            }
        }

        internal void AddProfileButtonObserver(IProfileButtonObserver i_ObserverToAdd)
        {
            this.r_ProfileButtonObservers.Add(i_ObserverToAdd);
        }

        internal void RemoveProfileButtonObserver(IProfileButtonObserver i_ObserverToAdd)
        {
            this.r_ProfileButtonObservers.Remove(i_ObserverToAdd);
        }

        private void notifyAllProfileButtonObservers()
        {
            foreach (IProfileButtonObserver observer in this.r_ProfileButtonObservers)
            {
                observer.ReportProfileButtonClicked();
            }
        }

        internal void AddLogoutButtonObserver(ILogoutButtonObserver i_ObserverToAdd)
        {
            this.r_LogoutButtonObservers.Add(i_ObserverToAdd);
        }

        internal void RemoveLogoutButtonObserver(ILogoutButtonObserver i_ObserverToAdd)
        {
            this.r_LogoutButtonObservers.Remove(i_ObserverToAdd);
        }

        private void notifyAllLogoutButtonObservers()
        {
            foreach (ILogoutButtonObserver observer in this.r_LogoutButtonObservers)
            {
                observer.ReportLogoutButtonClicked();
            }
        }

        internal void AddFriendsTriviaButtonObserver(IFriendsTriviaButtonObserver i_ObserverToAdd)
        {
            this.r_FriendsTriviaButtonObservers.Add(i_ObserverToAdd);
        }

        internal void RemoveFriendsTriviaButtonObserver(IFriendsTriviaButtonObserver i_ObserverToAdd)
        {
            this.r_FriendsTriviaButtonObservers.Remove(i_ObserverToAdd);
        }

        private void notifyAllFriendsTriviaButtonObservers()
        {
            foreach (IFriendsTriviaButtonObserver observer in this.r_FriendsTriviaButtonObservers)
            {
                observer.ReportFriendsTriviaButtonClicked();
            }
        }

        internal void AddBlastFromThePastButtonObserver(IBlastFromThePastButtonObserver i_ObserverToAdd)
        {
            this.r_BlastFromThePastButtonObservers.Add(i_ObserverToAdd);
        }

        internal void RemoveBlastFromThePastButtonObserver(IBlastFromThePastButtonObserver i_ObserverToAdd)
        {
            this.r_BlastFromThePastButtonObservers.Remove(i_ObserverToAdd);
        }

        private void notifyAllBlastFromThePastButtonObservers()
        {
            foreach (IBlastFromThePastButtonObserver observer in this.r_BlastFromThePastButtonObservers)
            {
                observer.ReportBlastFromThePastButtonClicked();
            }
        }
    }
}
