using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookApplication.UI;

namespace FacebookApplication.HW2_additions
{
    class ProfilePageBuilder : FBPageBuilder
    {
        public override void BuildPostFeed()
        {
            this.InitPostFeed(eFeedType.UserTimeLine);
        }

        public override void BuildSideBar()
        {
            ProfileHeader header = new ProfileHeader();

            header.Anchor = AnchorStyles.Top;
            this.m_ConstructedFBPage.Controls.Add(header, 0, 0);
        }
    }
}
