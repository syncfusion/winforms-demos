using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace TabSplitterContainer_2005
{
    public partial class Main : MetroForm
    {
        SplitWindowForm window1 = null, window2 = null;

        public Main()
        {
            InitializeComponent();                   
            this.MinimumSize = this.Size;            
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            window1 = new SplitWindowForm("Window1.xaml", "Code1.rtf");
            window1.MdiParent = this;          
            window1.Show();
            window2 = new SplitWindowForm("Window2.xaml", "Code2.rtf");
            window2.MdiParent = this;           
            window2.Show();           
        }
       
        private void UpdateTabPageStyleforOffice2016Themes()
        {
            if (this.window1.SplitView.Style == TabSplitterContainerStyle.Office2016Colorful)
            {
                window1.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Colorful.png"));
                window2.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Colorful.png"));
                this.mainFrameBarManager1.Style = VisualStyle.Office2016Colorful;
                this.CaptionBarColor = ColorTranslator.FromHtml("#0173c7");
                this.CaptionForeColor = ColorTranslator.FromHtml("#FFFFFF");
                this.ShowIcon = false;
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");                            
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
                this.window2.SplitView.Style = TabSplitterContainerStyle.Office2016Colorful;
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.tabbedMDIManager1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
                this.window2.richtextBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window1.richtextBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window2.richtextBox.ForeColor = ColorTranslator.FromHtml("#262626");
                this.window1.richtextBox.ForeColor = ColorTranslator.FromHtml("#262626");                
            }
            else if (this.window1.SplitView.Style == TabSplitterContainerStyle.Office2016White)
            {
                window1.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "White.png"));
                window2.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "White.png"));
                this.ShowIcon = false;
                this.mainFrameBarManager1.Style = VisualStyle.Office2016White;
                this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");             
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
                this.window2.SplitView.Style = TabSplitterContainerStyle.Office2016White;
                this.window2.xamlPage.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.window2.xamlPage.ForeColor = ColorTranslator.FromHtml("#262626");                
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.tabbedMDIManager1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
            }
            else if (this.window1.SplitView.Style == TabSplitterContainerStyle.Office2016DarkGray)
            {
                window1.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Dark Gray.png"));
                window2.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Dark Gray.png"));
                this.ShowIcon = false;
                this.mainFrameBarManager1.Style = VisualStyle.Office2016DarkGray;
                this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");       
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
                this.window2.SplitView.Style = TabSplitterContainerStyle.Office2016DarkGray;
                this.tabbedMDIManager1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016DarkGray);
                this.BorderColor = ColorTranslator.FromHtml("#444444");
                if(this.window1.SplitView.Enabled == false || this.window2.SplitView.Enabled == false)
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
            else if (this.window1.SplitView.Style == TabSplitterContainerStyle.Office2016Black)
            {
                window1.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Black.png"));
                window2.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Black.png"));
                this.ShowIcon = false;
                this.mainFrameBarManager1.Style = VisualStyle.Office2016Black;
                this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.window1.pictureBox.BackColor = ColorTranslator.FromHtml("#262626");
                this.window1.richtextBox.BackColor = ColorTranslator.FromHtml("#262626");                
                this.window2.pictureBox.BackColor = ColorTranslator.FromHtml("#262626");
                this.window2.richtextBox.BackColor = ColorTranslator.FromHtml("#262626");                
                this.window1.designpage.BackColor = ColorTranslator.FromHtml("#262626");
                this.window1.designpage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.window1.xamlPage.BackColor = ColorTranslator.FromHtml("#262626");
                this.window1.xamlPage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.window2.SplitView.Style = TabSplitterContainerStyle.Office2016Black;
                this.window2.designpage.BackColor = ColorTranslator.FromHtml("#262626");
                this.window2.designpage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.window2.xamlPage.BackColor = ColorTranslator.FromHtml("#262626");
                this.window2.xamlPage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.tabbedMDIManager1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Black);
                this.BorderColor = ColorTranslator.FromHtml("#363636");
                if(this.window1.SplitView.Enabled == false || this.window2.SplitView.Enabled == false)
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
            else
            {
                window1.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Designer1.png"));
                window2.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Designer2.png"));
                this.mainFrameBarManager1.Style = VisualStyle.Metro;
                this.ShowIcon = true;
                this.CaptionBarColor = Color.White;
                this.CaptionForeColor = Color.FromArgb(52, 52, 52);
                this.BackColor = Color.White;
                this.ForeColor = SystemColors.ControlText;
                this.window1.pictureBox.BackColor = Color.White;
                this.window1.richtextBox.BackColor = Color.White;
                this.window1.richtextBox.ForeColor = SystemColors.ControlText;
                this.window2.pictureBox.BackColor = Color.White;
                this.window2.richtextBox.BackColor = Color.White;
                this.window2.richtextBox.ForeColor = SystemColors.ControlText;
                this.window2.SplitView.Style = TabSplitterContainerStyle.Default;
                this.window1.designpage.BackColor = Color.White;
                this.window1.designpage.ForeColor = SystemColors.ControlText;
                this.window1.xamlPage.BackColor = Color.White;
                this.window1.xamlPage.ForeColor = SystemColors.ControlText;
                this.window2.designpage.BackColor = Color.White;
                this.window2.designpage.ForeColor = SystemColors.ControlText;
                this.window2.xamlPage.BackColor = Color.White;
                this.window2.xamlPage.ForeColor = SystemColors.ControlText;
                this.tabbedMDIManager1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
                this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
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
            this.tabbedMDIManager1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabbedMDIManager1.NeedUpdateHostedForm = false;
            this.tabbedMDIManager1.UseIconsInTabs = false;
            this.tabbedMDIManager1.TabControlAdded += new Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventHandler(this.tabbedMDIManager1_TabControlAdded);
            //Initial Settings
            this.ActivateMdiChild(window1);
            this.tabbedMDIManager1.CloseButtonToolTip = "Close";
            this.window1.SplitView.Style = Syncfusion.Windows.Forms.Tools.TabSplitterContainerStyle.Office2016Colorful;
            this.UpdateTabPageStyleforOffice2016Themes();
        }
    }
}