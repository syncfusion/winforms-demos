#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Licensing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlAdv_2005
{
    using Syncfusion.Licensing;
    public partial class Form1 : SfForm
    {

        #region Constructor

        public Form1()
        {
            InitializeComponent();
            SkinManager.SetVisualStyle(this, "Office2019Colorful");
            this.tabControlAdv1.SelectedIndexChanged += TabControlAdv1_SelectedIndexChanged;
            this.comboBoxAdv1.SelectedIndexChanged += ComboBoxAdv1_SelectedIndexChanged;
            this.panel1.SizeChanged += Panel1_SizeChanged;
            this.tabControlAdv1.TabPages[3].Image = imageList1.Images[0];
            this.tabControlAdv2.TabPages[2].Image = imageList1.Images[0];
            this.tabControlAdv3.TabPages[4].Image = imageList1.Images[0];
            this.tabControlAdv2.ImageAlignmentR = RelativeImageAlignment.RightOfText;
            this.tabControlAdv3.ImageAlignmentR = RelativeImageAlignment.AboveText;
            this.tabControlAdv2.ShowToolTips = true;
            this.tabControlAdv2.ShowSuperToolTips = true;
            this.tabControlAdv3.AdjustTopGap = 20;
            this.tabControlAdv3.LabelEdit = true;
            tabPageAdv32.Image = Image.FromFile(@"Data/behaviour.gif");
            this.tabControlAdv3.SelectedIndexChanging += TabControlAdv3_SelectedIndexChanging;
            this.tabControlAdv2.SelectedIndexChanged += TabControlAdv3_SelectedIndexChanged;
            
            this.tabControlAdv1.UserMoveTabs = true;
            this.comboBoxAdv1.SelectedIndex = 0;

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
        }

        #endregion

        #region Events

        private void Panel1_SizeChanged(object sender, EventArgs e)
        {
            this.comboBoxAdv1.Location = new Point(this.panel1.Width - comboBoxAdv1.Width - 50, (this.panel1.Height - this.comboBoxAdv1.Height) / 2);
            this.autoLabel1.Location = new Point(this.panel1.Width - autoLabel1.Width - this.comboBoxAdv1.Width - 60, (this.panel1.Height - this.autoLabel1.Height) / 2);
        }

        private void ComboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2019Colorful"))
            {
                SkinManager.SetVisualStyle(this, "Office2019Colorful");
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("HighContrastBlack"))
            {
                SkinManager.SetVisualStyle(this, "HighContrastBlack");
            }
            UpdateVisualStyle(this.comboBoxAdv1.SelectedItem.ToString());

        }

        private void UpdateVisualStyle(string themename)
        {
            if(themename == "Office2019Colorful")
            {
                this.BackColor = Color.White;
                this.panel1.BackColor = Color.White;
                foreach(TabPageAdv tabpage in this.tabControlAdv1.TabPages)
                { 
                    if(tabpage != null)
                        tabpage.BackColor  = Color.White;
                }
                foreach (TabPageAdv tabpage in this.tabControlAdv2.TabPages)
                {
                    if (tabpage != null)
                        tabpage.BackColor = Color.White;
                }
                foreach (TabPageAdv tabpage in this.tabControlAdv3.TabPages)
                {
                    if (tabpage != null)
                        tabpage.BackColor = Color.White;
                }
                foreach (TabPageAdv tabpage in this.PrimitivesTabControl.TabPages)
                {
                    if (tabpage != null)
                        tabpage.BackColor = Color.White;
                }

            }
            else
            {
                this.BackColor = Color.Black;
                this.panel1.BackColor = Color.Black;
                foreach (TabPageAdv tabpage in this.tabControlAdv1.TabPages)
                {
                    tabpage.BackColor = Color.Black;
                }
                foreach (TabPageAdv tabpage in this.tabControlAdv2.TabPages)
                {
                    if (tabpage != null)
                        tabpage.BackColor = Color.Black;
                }
                foreach (TabPageAdv tabpage in this.tabControlAdv3.TabPages)
                {
                    if (tabpage != null)
                        tabpage.BackColor = Color.Black;
                }
                foreach (TabPageAdv tabpage in this.PrimitivesTabControl.TabPages)
                {
                    if (tabpage != null)
                        tabpage.BackColor = Color.Black;
                }
            }
        }

        private void TabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.tabControlAdv1.SelectedTab.Text == "Disable Inactive Image")
            {
                this.tabControlAdv1.DisableInactivePageImage = true;
            }
            else
            {
                this.tabControlAdv1.DisableInactivePageImage = false;
            }
        }
        private void TabControlAdv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControlAdv2.CloseTabOnMiddleClick = false;
            this.tabControlAdv2.TabGap = 0;
            this.tabControlAdv2.AdjustTopGap = 0;
            if (tabControlAdv2.SelectedTab.Text == "Close Tab Middle Click")
            {
                tabControlAdv2.CloseTabOnMiddleClick = true;
            }
            else if (tabControlAdv2.SelectedTab.Text == "Tab Gap")
            {
                this.tabControlAdv2.TabGap = 20;
            }
            else if (tabControlAdv2.SelectedTab.Text == "Top Gap")
            {
                this.tabControlAdv2.AdjustTopGap = 20;
            }

        }

        private void TabControlAdv3_SelectedIndexChanging(object sender, SelectedIndexChangingEventArgs args)
        {
            this.tabControlAdv3.ShowTabCloseButton = false;
            this.tabControlAdv3.RightToLeft = RightToLeft.No;
            if ((sender as TabControlAdv).TabPages[args.NewSelectedIndex].Text == "Tab Close Button")
            {
                this.tabControlAdv3.ShowTabCloseButton = true;
            }
            else if (args.NewSelectedIndex == 2)
            {
                this.tabControlAdv3.RightToLeft = RightToLeft.Yes;
            }
        }

        private void contextMenuStripEx1_Opening(object sender, CancelEventArgs e)
        {
            if (tabControlAdv1.SelectedTab.Text=="Custom ContextMenu")
            {
                contextMenuStripEx1.Style = ContextMenuStripEx.ContextMenuStyle.Office2016Colorful;
                contextMenuStripEx1.Show();
            }
            else
                e.Cancel = true;
        }

        private void addTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPageAdv tabPage = new TabPageAdv("New Tab");
            tabControlAdv1.TabPages.Add(tabPage);
        }

        #endregion

        #region Methods

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
            SkinManager.LoadAssembly(typeof(Syncfusion.HighContrastTheme.WinForms.HighContrastTheme).Assembly);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /// <summary>
        /// Gets the icon file
        /// </summary>
        /// <param name="bitmapName">Icon name</param>
        /// <returns>Icon path</returns>
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

        #endregion
    }
}
