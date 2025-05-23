#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.Windows.Forms;
using System.IO;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace CustomConfiguration_2015
{
    public partial class Form1 : SfForm
    {
#if NETCORE
        private string configPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\..\config.xml";
#else
        private string configPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\config.xml";
#endif

        public Form1()
        {
            InitializeComponent();
            try
            {
#if NETCORE
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\..\\\logo.ico")));
#else
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\\logo.ico")));
#endif
                this.Icon = ico;
            }
            catch
            { }
            Customization();
            Event();
        }

        /// <summary>
        /// Methods to handle Events
        /// </summary>
        public void Event()
        {
            //File
            this.barItem1.Click += File_Click;
            this.barItem2.Click += File_Click;
            this.barItem3.Click += File_Click;
            this.barItem7.Click += File_Click;
            this.barItem8.Click += File_Click;
            //Edit
            this.barItem9.Click += Edit_Click;
            this.barItem10.Click += Edit_Click;
            this.barItem11.Click += Edit_Click;
            this.barItem12.Click += Edit_Click;
            this.barItem13.Click += Edit_Click;
            this.barItem14.Click += Edit_Click;
            //Search
            this.barItem15.Click += BarItem15_Click;
            this.barItem16.Click += BarItem15_Click;
            this.barItem17.Click += BarItem15_Click;
            //EditControl
            this.editControl1.KeyDown += Editcontrol_KeyDown;

            //Status bar
            this.f1print.Click += F1help_Click;
            this.f2save.Click += F2save_Click;
            this.f3open.Click += F3open_Click;
        }

       

        /// <summary>
        /// Get the Caption Icon
        /// </summary>
        /// <param name="bitmapName"></param>
        /// <returns></returns>
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }


        #region  Color Customization
        public void Customization()
        {
            this.editControl1.Configurator.Open(configPath);
#if NETCORE
            this.editControl1.LoadFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\..\Test Files\Content.cpp");
#else
            this.editControl1.LoadFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\Content.cpp");
#endif

            IBackgroundFormat format =
             editControl1.RegisterBackColorFormat(Color.Red, ColorTranslator.FromHtml("#99c9ef"));
            this.editControl1.SetSelectionBackColor(format);
            this.xpToolBar2.BackColor = ColorTranslator.FromHtml("#b4b3b4");
            this.editControl1.SelectionTextColor = ColorTranslator.FromHtml("#b4b3b4");
            this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#0000b0"));
            this.editControl1.SelectionMarginBackgroundColor = ColorTranslator.FromHtml("#0000b0");
            this.editControl1.ShowUserMargin = false;
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.ShowSelectionMargin = false;
            this.editControl1.UseXPStyle = false;
            this.editControl1.ShowOutliningCollapsers = false;
            this.xpToolBar2.Size = new Size(this.xpToolBar2.Width, 10);
            this.editControl1.ScrollVisualStyle = ScrollBarCustomDrawStyles.Office2016;
            this.editControl1.SaveOnClose = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.bar1.DrawBackground += Bar1_DrawBackground;
            this.mainFrameBarManager1.MetroColor = ColorTranslator.FromHtml("#00b000");
            this.parentBarItem1.MetroColor= ColorTranslator.FromHtml("#00b000");
            this.mainFrameBarManager1.MetroBackColor = ColorTranslator.FromHtml("#b4b3b4");
            this.parentBarItem1.MetroBackColor = ColorTranslator.FromHtml("#b4b3b4");
            this.editControl1.ShowLineNumbers = false;
            this.Style.Border.Color= ColorTranslator.FromHtml("#3d8bc8");
        }

        #region Events
        /// <summary>
        /// Handles file item click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void File_Click(object sender, System.EventArgs e)
        {
            BarItem mi = sender as BarItem;
            switch (mi.Text)
            {
                case "New":
                    this.editControl1.NewFile();
                    break;
                case "Open...":
                    this.editControl1.InsertFile();
                    break;
                case "Save":
                    this.editControl1.SaveModified();
                    break;
                case "Print":
                    this.editControl1.Print();
                    break;
                case "Quit":
                    this.Close();
                    break;
            }
        }
        /// <summary>
        /// Edit handles the Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit_Click(object sender, System.EventArgs e)
        {
            BarItem mi = sender as BarItem;
            switch (mi.Text)
            {
                case "Undo":
                    this.editControl1.Undo();
                    break;
                case "Redo":
                    this.editControl1.Redo();
                    break;
                case "Paste":
                    this.editControl1.Paste();
                    break;
                case "Cut":
                    this.editControl1.Cut();
                    break;
                case "Copy":
                    this.editControl1.Copy();
                    break;
                case "Clear":
                    this.editControl1.DeleteAll();
                    break;
            }
        }
        /// <summary>
        /// Handles the Edit Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarItem15_Click(object sender, System.EventArgs e)
        {
            BarItem mi = sender as BarItem;
            switch (mi.Text)
            {
                case "Find":
                    this.editControl1.ShowFindDialog();
                    break;
                case "Replace..":
                    this.editControl1.ShowReplaceDialog();
                    break;
                case "Go to line number..":
                    this.editControl1.ShowGoToDialog();
                    break;
            }
        }
        /// <summary>
        /// Handles key down event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Editcontrol_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
              if(e.KeyData == Keys.F3)
            {
                this.editControl1.InsertFile();
            }
            if (e.KeyData == Keys.F1)
            {
                this.editControl1.Print();
            }
            else if(e.KeyData == Keys.F2)
            {
                this.editControl1.Save();
            }
        }

        /// <summary>
        /// Handle to open new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F3open_Click(object sender, EventArgs e)
        {
            this.editControl1.InsertFile();
        }

        /// <summary>
        /// Handles to save  modified item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F2save_Click(object sender, EventArgs e)
        {
            this.editControl1.SaveModified();
        }

        /// <summary>
        /// Handles to print document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F1help_Click(object sender, EventArgs e)
        {
            this.editControl1.Print();
        }

        #endregion

        /// <summary>
        /// Draw background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bar1_DrawBackground(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(ColorTranslator.FromHtml("#b4b3b4")), e.ClipRectangle);
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
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}
