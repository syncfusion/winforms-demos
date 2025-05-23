#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.HighContrastTheme.WinForms;
using Syncfusion.Licensing;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Themes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TabSplitterContainer_2005
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            SkinManager.LoadAssembly(typeof(Office2019Theme).Assembly);
            SkinManager.LoadAssembly(typeof(HighContrastTheme).Assembly);
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2016Theme).Assembly);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }

    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {

        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}