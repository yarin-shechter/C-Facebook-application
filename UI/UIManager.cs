using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FacebookApplication;
using FacebookApplication.BlastFromThePast;
using FacebookApplication.HW2_additions;
using FacebookApplication.UI;
using Utils;
using System.Threading;

namespace UI
{
    internal class UIManager
    {
        private readonly string r_AppId = "862923930831396";
        private readonly string[] r_AppPermissions = new string[] { "public_profile", "email", "user_birthday", "user_friends", "user_gender", "user_hometown", "user_photos", "user_posts" };
        private readonly AppSettingsManager r_AppSettings = null;
        internal User User { get; private set; }
        internal FBPageWrapperForm CurrentPage { get; private set; }

        internal UIManager()
        {
            this.r_AppSettings = AppSettingsManager.LoadSettingsFromFile();
            initApplication();
        }

        private void initApplication()
        {
            LoginResult loginResult = null;

            loginResult = !r_AppSettings.RememberUser ?
                handleLoginProcess() :
                FacebookService.Connect(r_AppSettings.LastAccessToken);
            if (loginResult != null)
            {
                handleLoginResult(loginResult, r_AppSettings.RememberUser);
                r_AppSettings.SaveSettingsToFile();
                initFBPageWrapper();
                new Thread(() => setFBPage(eFBPageType.HomePage)).Start();
                this.CurrentPage.ShowDialog();
            }
        }

        private LoginResult handleLoginProcess()
        {
            LoginPageForm loginPageForm = new LoginPageForm(this.r_AppId, this.r_AppPermissions);
            LoginResult loginResult = loginPageForm.DisplayLoginDialog();
            bool isRememberUserChecked = loginPageForm.RememberUserCheckBox;

            handleLoginResult(loginResult, isRememberUserChecked);

            return loginResult;
        }

        private void handleLoginResult(LoginResult i_Result, bool i_RememberUser)
        {
            if(i_Result != null)
            {
                User = i_Result.LoggedInUser;
                r_AppSettings.LastAccessToken = i_Result.AccessToken;
                r_AppSettings.RememberUser = i_RememberUser;
                initDataFetcherInstance(User);
            }
        }

        private void initDataFetcherInstance(User i_User)
        {
            DataFetcher.InitializeInstance(i_User);
        }

        private void initFBPageWrapper()
        {
            CurrentPage = new FBPageWrapperForm();
            CurrentPage.HomeButtonClicked += currentPage_HomeButtonClicked;
            CurrentPage.ProfileButtonClicked += currentPage_ProfileButtonClicked;
            CurrentPage.LogoutButtonClicked += currentPage_LogoutButtonClicked;
            CurrentPage.BlastFromThePastButtonClicked += currentPage_BlastFromThePastButtonClicked;
            CurrentPage.FriendsTriviaButtonClicked += currentPage_FriendsTriviaButtonClicked;
        }

        private void setFBPage(eFBPageType i_PageTypeToSet)
        {
            TableLayoutPanel composedPage = FBPageComposer.ComposeFBPage(i_PageTypeToSet);

            CurrentPage.Invoke(new Action(() => CurrentPage.setFBPage(composedPage)));
            CurrentPage.Invoke(new Action(() => CurrentPage.Refresh()));
        }
       
        private void currentPage_HomeButtonClicked()
        {
            new Thread(() => setFBPage(eFBPageType.HomePage)).Start();
            CurrentPage.Text = "Facebook Application | Home";
        }

        private void currentPage_ProfileButtonClicked()
        {
            new Thread(() => setFBPage(eFBPageType.ProfilePage)).Start();
            CurrentPage.Text = string.Format("Facebook Application | {0}'s Profile", User.FirstName);
        }

        private void currentPage_LogoutButtonClicked()
        {
            FacebookService.Logout(null);
            this.CurrentPage.Hide();
            this.CurrentPage.Close();
            AppSettingsManager.ClearAppSettings();
            r_AppSettings.RememberUser = false;
            initApplication();
        }

        private void currentPage_BlastFromThePastButtonClicked()
        {
            BlastFromThePastManager.InitiateBlastFromThePast(this.User, this.CurrentPage);
        }

        private void currentPage_FriendsTriviaButtonClicked()
        {
            FriendsTriviaForm triviaFormForm = new FriendsTriviaForm();

            triviaFormForm.ShowDialog();
        }
    }
}
