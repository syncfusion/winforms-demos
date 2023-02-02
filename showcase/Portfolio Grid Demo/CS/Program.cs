#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
# region Directives

#define SharedPortfolioManagerDB

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
#endregion

namespace PortfolioManager
{
    static class Program
    {
        #region Connection String
        //Connection string that attached DB to local SQL Express

        //  public readonly static string connString = "Network Address= Samples.syncfusion.com,49489;initial catalog= PortfolioManagerDB; User ID=DemoUser;password=pass@word1;persist security info=True;packet size=4096;Pooling=true";
#if SharedPortfolioManagerDB
        public readonly static string connString = "Data Source="+FindFile("PortfolioManagerDB.sdf");
#else
        private const string sqlServerInstance = @".\SQLEXPRESS";
        public readonly static string connString = "AttachDBFileName='" + FindFile("PortfolioManagerDB.mdf") + "';Server='" + sqlServerInstance + "';user instance=true;Integrated Security=SSPI;Connection Timeout=60";
#endif
        #endregion

        # region Method

        private static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Common\Data\" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return new FileInfo(fileName).FullName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return fileName;
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PortfolioManager());
        }
        #endregion
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
