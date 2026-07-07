#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Licensing;

namespace LocalizationDemo
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
            string targetPath = Application.StartupPath + "\\";
#if NETCORE
            string sourceFile = Application.StartupPath.Split("\\bin")[0] + "\\de-DE\\run.bat";
#else
            string sourceFile = Path.GetFullPath("..\\..\\de-DE\\run.bat");
#endif
            if (!File.Exists(targetPath + "\\run.bat"))
            {
                File.Copy(sourceFile, targetPath + "\\run.bat");
            }
            ProcessStartInfo pstart = new ProcessStartInfo("run.bat");
            pstart.UseShellExecute = false;
            //Hide DOS window
            pstart.CreateNoWindow = true;
            Process.Start(pstart);
                        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    static class DemoCommon
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
                if (!File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}