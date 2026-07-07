#region Copyright Syncfusion Inc. 2001 - 2007
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.ComponentModel;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using Syncfusion.Licensing;

namespace Syncfusion.Windows.Forms.Diagram.Samples.Printing
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Properties

        
         string FileName
        {
            get
            { 
                return this.fileName;
            }
            set
            {
                this.fileName = value;
                this.Text = Path.GetFileNameWithoutExtension(this.fileName);
            }
        }

        public bool HasFileName
        {
            get
            {
                return (this.fileName != null && this.fileName.Length > 0);
            }
        }

        #endregion

        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.diagram1.Model = this.model1;

            // Load Palette

        }

        #region MAIN
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new MainForm());
        }

        #endregion

        #region Event Handlers

        #region Form Load

        private void MainForm_Load(object sender, EventArgs e)
        {
#if !NETCORE
            this.diagram1.LoadXml(@"..\..\..\..\..\..\common\Data\Diagram\xml\SDLC.xml");
#else
            this.diagram1.LoadXml(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\SDLC.xml");
#endif
            this.diagram1.Model.LogicalSize = new SizeF(this.diagram1.View.ClientRectangle.Width + 16, this.diagram1.View.ClientRectangle.Height + 16);
#region PropertyEditor Color Settings
            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.LightGray;
            this.diagram1.View.Grid.VerticalSpacing = 15;
            this.diagram1.View.Grid.HorizontalSpacing = 15;
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.View.HandleRenderer.HandleColor = Color.BlanchedAlmond;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.Orange;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.View.SelectionList.Clear();
#endregion

            foreach (Node n in this.diagram1.Model.Nodes)
            {
                n.EditStyle.AllowSelect = false;
            }
            this.diagram1.AllowDrop = false;
        }
#endregion

#region File Event Handler
        private void FileItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            switch (toolStripMenuItem.Tag.ToString())
            {
                case "Header Footer":
                    {
                        if (this.diagram1 != null && this.diagram1.Model != null)
                        {
                            HeaderFooterDialog dlgHF = new HeaderFooterDialog();
                            dlgHF.Header = this.diagram1.Model.HeaderFooterData.Header;
                            dlgHF.Footer = this.diagram1.Model.HeaderFooterData.Footer;
                            dlgHF.MeasurementUnits = this.diagram1.Model.MeasurementUnits;
                            if (dlgHF.ShowDialog() == DialogResult.OK)
                            {
                                this.diagram1.Model.HeaderFooterData.Header = dlgHF.Header;
                                this.diagram1.Model.HeaderFooterData.Footer = dlgHF.Footer;
                            }
                        }
                    }
                    break;
                case "Page Borders":
                    {
                        if (this.diagram1 != null && this.diagram1.View != null)
                        {
                            PageBorderDialog borderDialog = new PageBorderDialog();
                            borderDialog.PageBorderStyle = this.diagram1.View.PageBorderStyle;
                            if (borderDialog.ShowDialog() == DialogResult.OK)
                            {
                                this.diagram1.View.PageBorderStyle = borderDialog.PageBorderStyle;
                            }
                        }
                    }
                    break;
                case "Page Setup":
                    {
                        if (this.diagram1 != null && this.diagram1.Model != null)
                        {
                            PageSetupDialog dlgPrintSetup = new PageSetupDialog(diagram1.View);

                            // Made to make values more user friendly 
                            dlgPrintSetup.PrintSettings = this.diagram1.View.PageSettings;
                            dlgPrintSetup.PrintZoom = this.diagram1.View.PrintZoom;

                            if (dlgPrintSetup.ShowDialog() == DialogResult.OK)
                            {
                                this.diagram1.View.PageSettings = dlgPrintSetup.PrintSettings;
                                this.diagram1.View.PrintZoom = dlgPrintSetup.PrintZoom;
                                this.diagram1.View.RefreshPageSettings();
                            }
                        }
                    }
                    break;
                case "Print Preview":
                    {
                        this.PrintPreview();
                    }
                    break;
                case "Print":
                    {
                        this.Print();
                    }
                    break;


            }


        }

        public void PrintPreview()
        {
            if (this.diagram1 != null)
            {
                PrintDocument printDoc = this.diagram1.CreatePrintDocument();
                PrintPreviewDialog printPreviewDlg = new PrintPreviewDialog();

                printDoc.PrinterSettings.FromPage = 0;
                printDoc.PrinterSettings.ToPage = 0;
                printDoc.PrinterSettings.PrintRange = PrintRange.AllPages;

                printPreviewDlg.Document = printDoc;
                printPreviewDlg.ShowDialog(this);
            }
        }

        public void Print()
        {
            if (this.diagram1 != null)
            {
                PrintDocument printDoc = this.diagram1.CreatePrintDocument();
                PrintDialog printDlg = new PrintDialog();
                printDlg.Document = printDoc;

                printDlg.AllowSomePages = true;

                if (printDlg.ShowDialog(this) == DialogResult.OK)
                {
                    printDoc.PrinterSettings = printDlg.PrinterSettings;
                    printDoc.Print();
                }
            }

        }
#endregion
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
