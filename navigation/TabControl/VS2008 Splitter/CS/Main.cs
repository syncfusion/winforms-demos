#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;

namespace TabSplitterContainer_2005
{
    public partial class Main : SfForm
    {
        SplitWindowForm window1 = null, window2 = null;

        public Main()
        {
            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = this.Size;
            
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            window1 = new SplitWindowForm("Window1.xaml", "Code1.rtf");
            window1.MdiParent = this;
            window1.Show();
            window2 = new SplitWindowForm("Window2.xaml", "Code2.rtf");
            window2.MdiParent = this;
            window2.Show();
            this.comboBoxAdv1.SelectedIndexChanged += ComboBoxAdv1_SelectedIndexChanged;
            this.panel1.SizeChanged += Panel1_SizeChanged;
            

        }
       
        private void Panel1_SizeChanged(object sender, EventArgs e)
        {
            this.comboBoxAdv1.Location = new Point(this.panel1.Width - this.comboBoxAdv1.Width - 20, (this.panel1.Height - this.comboBoxAdv1.Height) / 2);
        }

        private void ComboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkinManager.SetVisualStyle(this, comboBoxAdv1.SelectedItem.ToString());
           
            if (this.comboBoxAdv1.SelectedItem.ToString() == "Default")
            { 
                this.comboBoxAdv1.Style = VisualStyle.Office2016White;
                this.tabbedMDIManager1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRenderer2D);
                this.window1.SplitView.Style = Syncfusion.Windows.Forms.Tools.TabSplitterContainerStyle.Default;
                this.window2.SplitView.Style = Syncfusion.Windows.Forms.Tools.TabSplitterContainerStyle.Default;
            }
            UpdateTabPageStyleforOffice2016Themes();
        }

        private void UpdateTabPageStyleforOffice2016Themes()
        {
            if (this.comboBoxAdv1.SelectedItem.ToString() == "Office2016Colorful")
            {
                window1.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Colorful.png"));
                window2.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Colorful.png"));
                this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window1.pictureBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window2.pictureBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window1.designpage.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window1.designpage.ForeColor = ColorTranslator.FromHtml("#262626");
                this.window1.xamlPage.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window1.xamlPage.ForeColor = ColorTranslator.FromHtml("#262626");
                this.window2.designpage.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window2.designpage.ForeColor = ColorTranslator.FromHtml("#262626");
                this.window2.xamlPage.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window2.xamlPage.ForeColor = ColorTranslator.FromHtml("#262626");
                this.window2.richtextBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window1.richtextBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window2.richtextBox.ForeColor = ColorTranslator.FromHtml("#262626");
                this.window1.richtextBox.ForeColor = ColorTranslator.FromHtml("#262626");
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Office2016White")
            {
               
                window1.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "White.png"));
                window2.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "White.png"));
                this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window1.pictureBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window1.richtextBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window1.richtextBox.ForeColor = ColorTranslator.FromHtml("#262626");
                this.window2.pictureBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window2.richtextBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window2.richtextBox.ForeColor = ColorTranslator.FromHtml("#262626");
                this.window1.designpage.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window1.designpage.ForeColor = ColorTranslator.FromHtml("#262626");
                this.window1.xamlPage.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window1.xamlPage.ForeColor = ColorTranslator.FromHtml("#262626");
                this.window2.designpage.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window2.designpage.ForeColor = ColorTranslator.FromHtml("#262626");
                this.window2.xamlPage.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window2.xamlPage.ForeColor = ColorTranslator.FromHtml("#262626");
                 
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Office2016DarkGray")
            {
                window1.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Dark Gray.png"));
                window2.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Dark Gray.png"));
                this.panel1.BackColor = ColorTranslator.FromHtml("#666666");
                this.window1.pictureBox.BackColor = ColorTranslator.FromHtml("#666666");
                this.window1.richtextBox.BackColor = ColorTranslator.FromHtml("#666666");
                this.window2.pictureBox.BackColor = ColorTranslator.FromHtml("#666666");
                this.window2.richtextBox.BackColor = ColorTranslator.FromHtml("#666666");
                this.window1.designpage.BackColor = ColorTranslator.FromHtml("#666666");
                this.window1.designpage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.window1.xamlPage.BackColor = ColorTranslator.FromHtml("#666666");
                this.window1.xamlPage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.window2.designpage.BackColor = ColorTranslator.FromHtml("#666666");
                this.window2.designpage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.window2.xamlPage.BackColor = ColorTranslator.FromHtml("#666666");
                this.window2.xamlPage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                if (this.window1.SplitView.Enabled == false || this.window2.SplitView.Enabled == false)
                {
                    this.window1.richtextBox.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.window2.richtextBox.ForeColor = ColorTranslator.FromHtml("#262626");
                }
                else
                {
                    this.window1.richtextBox.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.window2.richtextBox.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                }
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Office2016Black")
            {
                window1.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Black.png"));
                window2.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Black.png"));
                this.panel1.BackColor = ColorTranslator.FromHtml("#262626");
                this.window1.pictureBox.BackColor = ColorTranslator.FromHtml("#262626");
                this.window1.richtextBox.BackColor = ColorTranslator.FromHtml("#262626");
                this.window2.pictureBox.BackColor = ColorTranslator.FromHtml("#262626");
                this.window2.richtextBox.BackColor = ColorTranslator.FromHtml("#262626");
                this.window1.designpage.BackColor = ColorTranslator.FromHtml("#262626");
                this.window1.designpage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.window1.xamlPage.BackColor = ColorTranslator.FromHtml("#262626");
                this.window1.xamlPage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.window2.designpage.BackColor = ColorTranslator.FromHtml("#262626");
                this.window2.designpage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.window2.xamlPage.BackColor = ColorTranslator.FromHtml("#262626");
                this.window2.xamlPage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                if (this.window1.SplitView.Enabled == false || this.window2.SplitView.Enabled == false)
                {
                    this.window1.richtextBox.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.window2.richtextBox.ForeColor = ColorTranslator.FromHtml("#262626");
                }
                else
                {
                    this.window1.richtextBox.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.window2.richtextBox.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                }
                this.panel1.Invalidate();

            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Office2019Colorful")
            {
                window1.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Colorful.png"));
                window2.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Colorful.png"));
                this.panel1.BackColor = ColorTranslator.FromHtml("#f3f3f3");
                this.window1.pictureBox.BackColor = ColorTranslator.FromHtml("#f3f3f3");
                this.window2.pictureBox.BackColor = ColorTranslator.FromHtml("#f3f3f3");
                this.window1.designpage.BackColor = ColorTranslator.FromHtml("#f3f3f3");
                this.window1.designpage.ForeColor = ColorTranslator.FromHtml("#444444");
                this.window1.xamlPage.BackColor = ColorTranslator.FromHtml("#f3f3f3");
                this.window1.xamlPage.ForeColor = ColorTranslator.FromHtml("#444444");
                this.window2.designpage.BackColor = ColorTranslator.FromHtml("#f3f3f3");
                this.window2.designpage.ForeColor = ColorTranslator.FromHtml("#444444");
                this.window2.xamlPage.BackColor = ColorTranslator.FromHtml("#f3f3f3");
                this.window2.xamlPage.ForeColor = ColorTranslator.FromHtml("#444444");
                this.window2.richtextBox.BackColor = ColorTranslator.FromHtml("#f3f3f3");
                this.window1.richtextBox.BackColor = ColorTranslator.FromHtml("#f3f3f3");
                this.window2.richtextBox.ForeColor = ColorTranslator.FromHtml("#444444");
                this.window1.richtextBox.ForeColor = ColorTranslator.FromHtml("#444444");
                this.panel1.Invalidate();
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "HighContrastBlack")
            {
                window1.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Black.png"));
                window2.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Black.png"));
                this.panel1.BackColor = ColorTranslator.FromHtml("#000000");
                this.window1.pictureBox.BackColor = ColorTranslator.FromHtml("#000000");
                this.window1.richtextBox.BackColor = ColorTranslator.FromHtml("#000000");
                this.window2.pictureBox.BackColor = ColorTranslator.FromHtml("#000000");
                this.window2.richtextBox.BackColor = ColorTranslator.FromHtml("#000000");
                this.window1.designpage.BackColor = ColorTranslator.FromHtml("#000000");
                this.window1.designpage.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                this.window1.xamlPage.BackColor = ColorTranslator.FromHtml("#000000");
                this.window1.xamlPage.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                this.window2.designpage.BackColor = ColorTranslator.FromHtml("#000000");
                this.window2.designpage.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                this.window2.xamlPage.BackColor = ColorTranslator.FromHtml("#000000");
                this.window2.xamlPage.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                if (this.window1.SplitView.Enabled == false || this.window2.SplitView.Enabled == false)
                {
                    this.window1.richtextBox.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.window2.richtextBox.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                }
                else
                {
                    this.window1.richtextBox.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.window2.richtextBox.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                }
                 

            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Default")
            {
                this.ThemeName = "";
                window1.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Designer1.png"));
                window2.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Designer2.png"));
                this.window1.SplitView.Style = TabSplitterContainerStyle.Default;
                this.window2.SplitView.Style = TabSplitterContainerStyle.Default;
                this.panel1.BackColor = ColorTranslator.FromHtml("#f2f2f2");
                this.window1.pictureBox.BackColor = Color.White;
                this.window1.richtextBox.BackColor = Color.White;
                this.window1.richtextBox.ForeColor = SystemColors.ControlText;
                this.window2.pictureBox.BackColor = Color.White;
                this.window2.richtextBox.BackColor = Color.White;
                this.window2.richtextBox.ForeColor = SystemColors.ControlText;
                this.window1.designpage.BackColor = Color.White;
                this.window1.designpage.ForeColor = SystemColors.ControlText;
                this.window1.xamlPage.BackColor = Color.White;
                this.window1.xamlPage.ForeColor = SystemColors.ControlText;
                this.window2.designpage.BackColor = Color.White;
                this.window2.designpage.ForeColor = SystemColors.ControlText;
                this.window2.xamlPage.BackColor = Color.White;
                this.window2.xamlPage.ForeColor = SystemColors.ControlText;
                
            }
        }
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

        void tabbedMDIManager1_TabControlAdded(object sender, TabbedMDITabControlEventArgs args)
        {
            if (args.TabControl != null)
                args.TabControl.BorderVisible = true;
        }

        public SplitWindowForm ActiveWindow
        {
            get
            {
                if (this.ActiveMdiChild != null)
                    return (SplitWindowForm)this.ActiveMdiChild;
                else
                    return null;
            }
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.tabbedMDIManager1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabbedMDIManager1.NeedUpdateHostedForm = false;
            this.tabbedMDIManager1.UseIconsInTabs = false;
            this.tabbedMDIManager1.TabControlAdded += new Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventHandler(this.tabbedMDIManager1_TabControlAdded);
            //Initial Settings
            this.ActivateMdiChild(window1);
            this.tabbedMDIManager1.CloseButtonToolTip = "Close";
            SkinManager.SetVisualStyle(this, "Office2019Colorful");
            UpdateTabPageStyleforOffice2016Themes();
           

        }
    }
}