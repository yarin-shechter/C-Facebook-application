using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApplication.HW2_additions
{
    internal interface IFBPageBuilder
    {
        TableLayoutPanel ConstructedPage { get; }
        void BuildPhotoGrid();
        void BuildPostFeed();
        void BuildSideBar();
    }
}
