#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace MarketSimulation
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static int NumberOfRows = 100;  // How many orders in grid.
        public static int TimerUpdate = 200;   // How often market data gets updated

        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
#if SyncfusionFramework2_0
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
#endif
            OrderAgreementQueuerC form = new OrderAgreementQueuerC();
            form.Load += new EventHandler(form_Load);

            Application.Run(form);
        }

        static void form_Load(object sender, EventArgs e)
        {
            QuoteManagerC.Manager.Subscribe(TypeSystemC.Symbols);
			
        }
    }
}