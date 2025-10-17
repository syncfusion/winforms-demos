#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

namespace GridListControlSample
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;

    using Syncfusion.Windows.Forms.Grid;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.Windows.Forms;
    using DemoCommon.Grid;

    public class ListBoxSample3 : GridDemoForm
    {
        #region "API Definition"

        private GridListControl ListBox1 = new GridListControl();
        private TextBox textBox1 = new TextBox();
        private ComboBoxAdv selectionComboBox = new ComboBoxAdv();
        private ComboBoxAdv visualStylesComboBox = new ComboBoxAdv();
        private Label selectionModeLabel = new Label();
        private Label visualStylesLabel = new Label();
        private int widthListBox = 455;
        private int heightListBox = 800;

        #endregion

        #region "Constructor"

        public ListBoxSample3()
        {
            #region Form and control settings

            this.AutoScaleBaseSize = new Size(5, 13);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 330);
            this.Text = "Getting Started";

            ListBox1.Location = new Point(32, 30);
            ListBox1.Name = "ListBox1";
            ListBox1.TabIndex = 2;
            ListBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            ListBox1.Grid.DefaultGridBorderStyle = GridBorderStyle.Solid;
            ListBox1.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            ListBox1.Grid.PrepareViewStyleInfo += OnGrid_PrepareViewStyleInfo;

            this.selectionModeLabel.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.selectionModeLabel.Name = "selectionModeLabel";
            this.selectionModeLabel.Text = "Selection Mode ";
            this.selectionModeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, FontStyle.Bold);
            this.selectionModeLabel.Size = new System.Drawing.Size(100, 21);
            this.selectionModeLabel.Location = new Point(520, 90);
            selectionComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            this.selectionComboBox.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.selectionComboBox.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.selectionComboBox.Name = "selectionComboBox";
            this.selectionComboBox.Size = new System.Drawing.Size(150, 21);
            this.selectionComboBox.TabIndex = 1;
            this.selectionComboBox.Location = new Point(521, 110);
            this.selectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectionComboBox.Items.Add("Single");
            selectionComboBox.Items.Add("Simple Multiple");
            selectionComboBox.Items.Add("Extended Multiple");
            selectionComboBox.Text = "Single";

            this.selectionComboBox.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChanged);

            this.visualStylesLabel.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.visualStylesLabel.Name = "visualStylesLabel";
            this.visualStylesLabel.Size = new System.Drawing.Size(150, 21);
            this.visualStylesLabel.Text = "Visual Style ";
            this.visualStylesLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, FontStyle.Bold);
            this.visualStylesLabel.Location = new Point(520, 30);

            this.visualStylesComboBox.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.visualStylesComboBox.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.visualStylesComboBox.Name = "visualStylesComboBox";
            this.visualStylesComboBox.Size = new System.Drawing.Size(150, 21);
            this.visualStylesComboBox.TabIndex = 0;
            this.visualStylesComboBox.Location = new Point(521, 50);
            this.visualStylesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            visualStylesComboBox.Items.Add("Metro");
            visualStylesComboBox.Items.Add("Office2007Blue");
            visualStylesComboBox.Items.Add("Office2007Black");
            visualStylesComboBox.Items.Add("Office2007Silver");
            visualStylesComboBox.Items.Add("Office2010Blue");
            visualStylesComboBox.Items.Add("Office2010Black");
            visualStylesComboBox.Items.Add("Office2010Silver");
            visualStylesComboBox.Items.Add("Office2016Black");
            visualStylesComboBox.Items.Add("Office2016White");
            visualStylesComboBox.Items.Add("Office2016DarkGray");
            visualStylesComboBox.Items.Add("Office2016Colorful");
            visualStylesComboBox.Text = "Metro";
            visualStylesComboBox.SelectedIndexChanged += OnVisualStylesComboBox_SelectedIndexChanged;

            heightListBox = 15 * (ListBox1.ItemHeight + 1);


            ListBox1.Size = new Size(widthListBox, heightListBox);
            //this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(239)))));
            textBox1.Location = new Point(521, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 24);
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.Controls.AddRange(new Control[] { ListBox1, textBox1, selectionComboBox });

            // Populates the list box using DataSource. 
            // DisplayMember is used to display just the long name of each state.
            ArrayList USStates = new ArrayList();
            USStates.Add(new USState("Alaska", "AK", 1));
            USStates.Add(new USState("Arizona", "AZ", 2));
            USStates.Add(new USState("Arkansas", "AK", 3));
            USStates.Add(new USState("California", "CA", 4));
            USStates.Add(new USState("Colorado", "CO", 5));
            USStates.Add(new USState("Connecticut", "CT", 6));
            USStates.Add(new USState("Delaware", "DE", 3));
            USStates.Add(new USState("Florida", "FL", 4));
            USStates.Add(new USState("Georgia", "GA", 1));
            USStates.Add(new USState("Hawaii", "HI", 0));
            USStates.Add(new USState("Idaho", "ID", 3));
            USStates.Add(new USState("Illinois", "IL", 2));
            USStates.Add(new USState("Indiana", "IN", 6));
            USStates.Add(new USState("Iowa", "IA", 5));
            USStates.Add(new USState("Kansas", "KA", 5));
            USStates.Add(new USState("Kentucky", "KY", 4));
            USStates.Add(new USState("Louisiana", "LA", 3));
            USStates.Add(new USState("Maine", "ME", 0));
            USStates.Add(new USState("Maryland", "MD", 0));
            USStates.Add(new USState("Massachusetts", "MA", 2));
            USStates.Add(new USState("Michigan", "MI", 1));
            USStates.Add(new USState("Minnesota", "MN", 6));
            USStates.Add(new USState("Mississippi", "MS", 5));
            USStates.Add(new USState("Missouri", "MO", 2));
            USStates.Add(new USState("Montana", "MT", 1));
            USStates.Add(new USState("Nebraska", "NE", 4));
            USStates.Add(new USState("Nevada", "NV", 0));
            USStates.Add(new USState("New Hampshire", "NH", 3));
            USStates.Add(new USState("New Jersey", "NJ", 3));
            USStates.Add(new USState("New Mexico", "NM", 2));
            USStates.Add(new USState("New York", "NY", 5));
            USStates.Add(new USState("North Carolina", "NC", 4));
            USStates.Add(new USState("North Dakota", "ND", 4));
            USStates.Add(new USState("Ohio", "OH", 1));
            USStates.Add(new USState("Oklahoma", "OK", 2));
            USStates.Add(new USState("Oregon", "OR", 5));
            USStates.Add(new USState("Pennsylvania", "PA", 0));
            USStates.Add(new USState("Rhode Island", "RI", 6));
            USStates.Add(new USState("South Carolina", "SC", 5));
            USStates.Add(new USState("South Dakota", "SD", 4));
            USStates.Add(new USState("Tennessee", "TN", 3));
            USStates.Add(new USState("Texas", "TX", 2));
            USStates.Add(new USState("Utah", "UT", 0));
            USStates.Add(new USState("Vermont", "VT", 1));
            USStates.Add(new USState("Virginia", "VA", 0));
            USStates.Add(new USState("Washington", "WA", 2));
            USStates.Add(new USState("West Virginia", "WV", 0));
            USStates.Add(new USState("Wisconsin", "WI", 3));
            USStates.Add(new USState("Wyoming", "WY", 5));



            ImageList imageList2 = new ImageList();
            imageList2.ImageSize = new Size(15, 15);
            try
            {
                imageList2.Images.Add(new Bitmap(FindImageFile(@"Common\Images\Grid\GridListControlDemo\ImageList\add2.png")));
                imageList2.Images.Add(new Bitmap(FindImageFile(@"Common\Images\Grid\GridListControlDemo\ImageList\bug_green.png")));
                imageList2.Images.Add(new Bitmap(FindImageFile(@"Common\Images\Grid\GridListControlDemo\ImageList\star_blue.png")));
                imageList2.Images.Add(new Bitmap(FindImageFile(@"Common\Images\Grid\GridListControlDemo\ImageList\navigate_check.png")));
                imageList2.Images.Add(new Bitmap(FindImageFile(@"Common\Images\Grid\GridListControlDemo\ImageList\jar_bean_delete.png")));
                imageList2.Images.Add(new Bitmap(FindImageFile(@"Common\Images\Grid\GridListControlDemo\ImageList\console.png")));
                imageList2.Images.Add(new Bitmap(FindImageFile(@"Common\Images\Grid\GridListControlDemo\ImageList\delete2.png")));
                imageList2.Images.Add(new Bitmap(FindImageFile(@"Common\Images\Grid\GridListControlDemo\ImageList\layout_horizontal.png")));
            }
            catch
            {
            }
            ListBox1.ImageList = imageList2;

            ListBox1.SelectedValueChanged += new EventHandler(ListBox1_SelectedValueChanged);
            ListBox1.BeginUpdate();
            ListBox1.DataSource = USStates;
            ListBox1.DisplayMember = "LongName";
            ListBox1.ValueMember = "ShortName";
            ListBox1.MultiColumn = true;
            ListBox1.ShowColumnHeader = true;
            ListBox1.SelectionMode = SelectionMode.One;
            ListBox1.ThemesEnabled = true;
            ListBox1.Grid.VerticalThumbTrack = true;

            ListBox1.FillLastColumn = true;
            ListBox1.EndUpdate();

            textBox1.ReadOnly = true;
            this.Controls.AddRange(new Control[] { ListBox1, textBox1, selectionComboBox, visualStylesComboBox, selectionModeLabel, visualStylesLabel });
            this.ListBox1.Grid.RowHeights.ResizeToFit(GridRangeInfo.Table());
            this.ListBox1.Grid.ColWidths[1] = 100;
            ListBox1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            ListBox1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(208)), ((System.Byte)(215)), ((System.Byte)(229)));
            ListBox1.BorderStyle = BorderStyle.FixedSingle;
            ListBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            ListBox1.BackColor = SystemColors.Window;
            ListBox1.Font = new System.Drawing.Font("Verdana", 8.5F);
            ListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimumSize = new Size(700, 500);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            #endregion
        }

        #endregion

        #region "Designer Stuffs"

        #region "FindImageFile"
        /// <summary>
        /// Finds the image from specified location
        /// </summary>
        private string FindImageFile(string bitmapName)
        {
            string bitmappath = "";
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    bitmappath = bitmapName;

                bitmapName = @"..\" + bitmapName;
            }
            return bitmappath;
        }


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ListBoxSample3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(239)))));
            //this.ClientSize = new System.Drawing.Size(1012, 653);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ListBoxSample3";
            this.Load += new System.EventHandler(this.ListBoxSample3_Load);
            this.ResumeLayout(false);

        }
        #endregion

        #region "Entry Point"

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
# if SyncfusionFramework1_1 || SyncfusionFramework2_0
            Application.EnableVisualStyles();
# endif
            Application.Run(new ListBoxSample3());
        }

        #endregion

        #endregion

        #region EventHandlers

        //set the selectionmode
        private void OnSelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (selectionComboBox.SelectedIndex)
            {
                case 0:
                    ListBox1.SelectionMode = SelectionMode.One;
                    break;
                case 1:
                    ListBox1.SelectionMode = SelectionMode.MultiSimple;
                    break;
                case 2:
                default:
                    ListBox1.SelectionMode = SelectionMode.MultiExtended;
                    break;
            }

            ListBox1.ClearSelected();
        }

        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex != -1)
            {
                textBox1.Text = "Selected Value - " + ListBox1.SelectedValue.ToString();
            }
        }

        private void OnVisualStylesComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (visualStylesComboBox.SelectedItem.ToString())
            {
                case "Metro":
                    this.ListBox1.Grid.GridVisualStyles = GridVisualStyles.Metro;
                    ListBox1.Grid.GridOfficeScrollBars = OfficeScrollBars.Metro;
                    selectionComboBox.ThemeName = "Metro";
                    visualStylesComboBox.ThemeName = "Metro";
                    this.CaptionForeColor = ColorTranslator.FromHtml("#4e4d4d");
                    this.CaptionBarColor = Color.White;
                    this.BackColor = Color.White;
                    this.BorderColor = ColorTranslator.FromHtml("#1ba1e2");
                    break;
                case "Office2007Blue":
                    this.ListBox1.Grid.GridVisualStyles = GridVisualStyles.Office2007Blue;
                    ListBox1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2007;
                    ListBox1.Grid.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                    selectionComboBox.ThemeName = "Office2007Blue";
                    visualStylesComboBox.ThemeName = "Office2007Blue";
                    this.CaptionForeColor = ColorTranslator.FromHtml("#4e4d4d");
                    this.CaptionBarColor = Color.White;
                    this.BackColor = Color.White;
                    this.BorderColor = ColorTranslator.FromHtml("#1ba1e2");
                    break;
                case "Office2007Black":
                    this.ListBox1.Grid.GridVisualStyles = GridVisualStyles.Office2007Black;
                    ListBox1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2007;
                    ListBox1.Grid.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                    selectionComboBox.ThemeName = "Office2007Black";
                    visualStylesComboBox.ThemeName = "Office2007Black";
                    this.CaptionForeColor = ColorTranslator.FromHtml("#4e4d4d");
                    this.CaptionBarColor = Color.White;
                    this.BackColor = Color.White;
                    this.BorderColor = ColorTranslator.FromHtml("#1ba1e2");
                    break;
                case "Office2007Silver":
                    this.ListBox1.Grid.GridVisualStyles = GridVisualStyles.Office2007Silver;
                    ListBox1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2007;
                    ListBox1.Grid.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                    selectionComboBox.ThemeName = "Office2007Silver";
                    visualStylesComboBox.ThemeName = "Office2007Silver";
                    this.CaptionForeColor = ColorTranslator.FromHtml("#4e4d4d");
                    this.CaptionBarColor = Color.White;
                    this.BackColor = Color.White;
                    this.BorderColor = ColorTranslator.FromHtml("#1ba1e2");
                    break;
                case "Office2010Blue":
                    this.ListBox1.Grid.GridVisualStyles = GridVisualStyles.Office2010Blue;
                    ListBox1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2010;
                    ListBox1.Grid.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Blue;
                    selectionComboBox.ThemeName = "Office2010Blue";
                    visualStylesComboBox.ThemeName = "Office2010Blue";
                    this.CaptionForeColor = ColorTranslator.FromHtml("#4e4d4d");
                    this.CaptionBarColor = Color.White;
                    this.BackColor = Color.White;
                    this.BorderColor = ColorTranslator.FromHtml("#1ba1e2");
                    break;
                case "Office2010Black":
                    this.ListBox1.Grid.GridVisualStyles = GridVisualStyles.Office2010Black;
                    ListBox1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2010;
                    ListBox1.Grid.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black;
                    selectionComboBox.ThemeName = "Office2010Black";
                    visualStylesComboBox.ThemeName = "Office2010Black";
                    this.CaptionForeColor = ColorTranslator.FromHtml("#4e4d4d");
                    this.CaptionBarColor = Color.White;
                    this.BackColor = Color.White;
                    this.BorderColor = ColorTranslator.FromHtml("#1ba1e2");
                    break;
                case "Office2010Silver":
                    this.ListBox1.Grid.GridVisualStyles = GridVisualStyles.Office2010Silver;
                    ListBox1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2010;
                    ListBox1.Grid.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Silver;
                    selectionComboBox.ThemeName = "Office2010Silver";
                    visualStylesComboBox.ThemeName = "Office2010Silver";
                    this.CaptionForeColor = ColorTranslator.FromHtml("#4e4d4d");
                    this.CaptionBarColor = Color.White;
                    this.BackColor = Color.White;
                    this.BorderColor = ColorTranslator.FromHtml("#1ba1e2");
                    break;
                case "Office2016Black":
                    this.ListBox1.Grid.GridVisualStyles = GridVisualStyles.Office2016Black;
                    ListBox1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2016;
                    ListBox1.Grid.Office2016ScrollBarsColorScheme = ScrollBarOffice2016ColorScheme.Black;
                    selectionComboBox.ThemeName = "Office2016Black";
                    visualStylesComboBox.ThemeName = "Office2016Black";
                    this.BackColor = ColorTranslator.FromHtml("#828282");
                    this.CaptionBarColor = ColorTranslator.FromHtml("#828282");
                    this.CaptionForeColor = Color.Black;
                    this.textBox1.BackColor = ColorTranslator.FromHtml("#444444");
                    this.textBox1.ForeColor = Color.White;
                    this.BorderColor = Color.White;
                    break;
                case "Office2016White":
                    this.ListBox1.Grid.GridVisualStyles = GridVisualStyles.Office2016White;
                    ListBox1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2016;
                    ListBox1.Grid.Office2016ScrollBarsColorScheme = ScrollBarOffice2016ColorScheme.White;
                    selectionComboBox.ThemeName = "Office2016White";
                    visualStylesComboBox.ThemeName = "Office2016White";
                    this.CaptionForeColor = ColorTranslator.FromHtml("#4e4d4d");
                    this.CaptionBarColor = Color.White;
                    this.BackColor = Color.White;
                    this.BorderColor = ColorTranslator.FromHtml("#1ba1e2");
                    break;
                case "Office2016DarkGray":
                    this.ListBox1.Grid.GridVisualStyles = GridVisualStyles.Office2016DarkGray;
                    ListBox1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2016;
                    ListBox1.Grid.Office2016ScrollBarsColorScheme = ScrollBarOffice2016ColorScheme.DarkGray;
                    selectionComboBox.ThemeName = "Office2016DarkGray";
                    visualStylesComboBox.ThemeName = "Office2016DarkGray";
                    this.BackColor = ColorTranslator.FromHtml("#828282");
                    this.CaptionBarColor = ColorTranslator.FromHtml("#828282");
                    this.CaptionForeColor = Color.Black;
                    this.textBox1.BackColor = ColorTranslator.FromHtml("#D4D4D4");
                    this.textBox1.ForeColor = Color.Black;
                    this.BorderColor = Color.White;
                    break;
                case "Office2016Colorful":
                    this.ListBox1.Grid.GridVisualStyles = GridVisualStyles.Office2016Colorful;
                    ListBox1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2016;
                    ListBox1.Grid.Office2016ScrollBarsColorScheme = ScrollBarOffice2016ColorScheme.Colorful;
                    selectionComboBox.ThemeName = "Office2016Colorful";
                    visualStylesComboBox.ThemeName = "Office2016Colorful";
                    this.CaptionForeColor = ColorTranslator.FromHtml("#4e4d4d");
                    this.CaptionBarColor = Color.White;
                    this.BackColor = Color.White;
                    this.BorderColor = ColorTranslator.FromHtml("#1ba1e2");
                    break;
            }

            ListBox1.Refresh();
        }
        private void ListBoxSample3_Load(object sender, System.EventArgs e)
        {
            ListBox1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;

            ListBox1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            ListBox1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(208)), ((System.Byte)(215)), ((System.Byte)(229)));
            ListBox1.BorderStyle = BorderStyle.FixedSingle;
            ListBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            ListBox1.Font = new System.Drawing.Font("Verdana", 8.5F);
            ListBox1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            ListBox1.Grid.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(Grid_PrepareViewStyleInfo);

        }

        private void OnGrid_PrepareViewStyleInfo(object sender, GridPrepareViewStyleInfoEventArgs e)
        {
            if (e.RowIndex == 0)
                if (e.ColIndex == 1)
                    e.Style.Text = "Short Name";
                else if (e.ColIndex == 2)
                    e.Style.Text = "Long Name";
        }

        void Grid_PrepareViewStyleInfo(object sender, GridPrepareViewStyleInfoEventArgs e)
        {
            if (e.ColIndex > 0 && e.RowIndex == 0)
            {
                switch (e.ColIndex)
                {
                    case 1:
                        e.Style.Text = "Short Name";
                        break;
                    case 2:
                        e.Style.Text = "Long Name";
                        break;
                   
                    default:
                        break;
                }
            } 
        }
        #endregion
    }

    #region "USState Class"
    /// <summary>
    /// Creating the class 
    /// </summary>
    public class USState
    {
        private string myShortName;
        private string myLongName;
        private int imgIndex;

        public USState(string strLongName, string strShortName, int imageIndex)
        {
            this.myShortName = strShortName;
            this.myLongName = strLongName;
            this.imgIndex = imageIndex;
        }

        public string ShortName
        {
            get
            {
                return myShortName;
            }
        }

        public string LongName
        {

            get
            {
                return myLongName;
            }
        }

        public int ImageIndex
        {
            get
            {
                return imgIndex;
            }
            set
            {
                imgIndex = value;
            }
        }


        public override string ToString()
        {
            return this.ShortName + " - " + this.LongName;
        }
    }
    #endregion
}

