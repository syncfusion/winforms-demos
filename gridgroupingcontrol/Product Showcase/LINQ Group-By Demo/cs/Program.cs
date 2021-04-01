# region Directives

using System;
using System.IO;
using System.Windows.Forms;

#endregion

namespace LinqGroupBy
{
    static class Program
    {
        # region Variable Declaration

        // The following sample assumes that you installed the DATA sample 
        // project and that Northwind.MDF is in that Data directory.
        private const string sqlServerInstance = @".\SQLEXPRESS";

        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        #endregion
    }
}
