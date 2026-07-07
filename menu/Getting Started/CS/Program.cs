using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.HighContrastTheme.WinForms;
using Syncfusion.Licensing;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Themes;

namespace GettingStartedDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2016Theme).Assembly);
            SkinManager.LoadAssembly(typeof(Office2019Theme).Assembly);
            SkinManager.LoadAssembly(typeof(HighContrastTheme).Assembly);
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
