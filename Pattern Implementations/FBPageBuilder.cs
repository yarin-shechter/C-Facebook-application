using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Windows.Forms;
using FacebookApplication.UI;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication.HW2_additions
{
    abstract class FBPageBuilder : IFBPageBuilder
    {
        protected TableLayoutPanel m_ConstructedFBPage;
        public TableLayoutPanel ConstructedPage => this.m_ConstructedFBPage;

        internal FBPageBuilder()
        {
            this.m_ConstructedFBPage = new TableLayoutPanel();
            initFBPageProperties();
        }

        private void initFBPageProperties()
        {
            this.m_ConstructedFBPage.AutoScroll = true;
            this.m_ConstructedFBPage.ColumnCount = 3;
            this.m_ConstructedFBPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.m_ConstructedFBPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.m_ConstructedFBPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.m_ConstructedFBPage.Location = new System.Drawing.Point(1, 46);
            this.m_ConstructedFBPage.Name = "componentList";
            this.m_ConstructedFBPage.RowCount = 1;
            this.m_ConstructedFBPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_ConstructedFBPage.Size = new System.Drawing.Size(1280, 1152);
            this.m_ConstructedFBPage.TabIndex = 1;
        }

        public void BuildPhotoGrid()
        {
            PhotoGrid photoGrid = new PhotoGrid();

            photoGrid.Anchor = AnchorStyles.Top;
            this.m_ConstructedFBPage.Controls.Add(photoGrid, 2, 0);
        }

        protected void InitPostFeed(eFeedType i_FeedType)
        {
            PostFeed postFeed = new PostFeed(i_FeedType);

            postFeed.Anchor = AnchorStyles.Top;
            this.m_ConstructedFBPage.Controls.Add(postFeed, 1, 0);
        }

        public abstract void BuildPostFeed();

        public abstract void BuildSideBar();
    }
}

