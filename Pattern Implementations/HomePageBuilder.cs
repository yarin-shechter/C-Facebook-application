using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookApplication.UI;

namespace FacebookApplication.HW2_additions
{
    internal class HomePageBuilder : FBPageBuilder
    {
        public override void BuildPostFeed()
        {
            this.InitPostFeed(eFeedType.NewsFeed);
        }

        public override void BuildSideBar()
        {
            FriendsSidebar friendsSidebar = new FriendsSidebar();

            friendsSidebar.Anchor = AnchorStyles.Top;
            this.m_ConstructedFBPage.Controls.Add(friendsSidebar, 0, 0);
        }
    }
}
