#region Copyright Syncfusion Inc. 2001-2018.
//-------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="syncfusion">
//  Copyright (c) Syncfusion Inc. 2001 - 2019. All rights reserved.
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
// </copyright>
//-------------------------------------------------------------------------------------------------
#endregion

namespace CustomizationDemo
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using Syncfusion.Licensing;

    /// <summary>
    /// Represents a class that is used to invoke main method.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

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

                return File.ReadAllText(licenseKeyFile);
            }

            return string.Empty;
        }
    }
}
