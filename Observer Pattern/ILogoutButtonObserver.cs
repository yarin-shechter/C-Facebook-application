using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication.Observer_Pattern
{
    internal interface ILogoutButtonObserver
    {
        void ReportLogoutButtonClicked();
    }
}
