using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookApplication.UI;

namespace FacebookApplication.HW2_additions
{
    static class FBPageBuilderFactory
    {
        internal static IFBPageBuilder CreateFBPageBuilder(eFBPageType i_TypeOfPageToCreate)
        {
            IFBPageBuilder pageBuilder;

            switch (i_TypeOfPageToCreate)
            {
                case eFBPageType.HomePage:
                    pageBuilder = new HomePageBuilder();
                    break;
                case eFBPageType.ProfilePage:
                    pageBuilder = new ProfilePageBuilder();
                    break;
                default:
                    pageBuilder = new HomePageBuilder();
                    break;
            }

            return pageBuilder;
        }
    }
}
