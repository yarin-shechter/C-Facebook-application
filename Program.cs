using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookApplication.HW2_additions;
using FacebookApplication.UI;
using UI;
namespace FacebookApplication
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new UIManager();
        }
    }
}
