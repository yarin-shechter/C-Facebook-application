using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookApplication.UI;

namespace FacebookApplication.HW2_additions
{
    static class FBPageComposer
    {
        internal static TableLayoutPanel ComposeFBPage(eFBPageType i_TypeOfPageToCompose)
        {
            IFBPageBuilder pageBuilder = FBPageBuilderFactory.CreateFBPageBuilder(i_TypeOfPageToCompose);

            Thread t1 = new Thread(() => pageBuilder.BuildPostFeed());
            Thread t2 = new Thread(() => pageBuilder.BuildPhotoGrid());
            Thread t3 = new Thread(() => pageBuilder.BuildSideBar());
            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join();
            t2.Join();
            t3.Join();

            return pageBuilder.ConstructedPage;
        }
    }
}
