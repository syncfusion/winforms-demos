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
        private int widthListBox = 600;
        private int heightListBox = 800;

        #endregion

        #region "Constructor"

        public ListBoxSample3()
        {
            #region Form and control settings

            this.AutoScaleBaseSize = new Size(5, 13);
            this.ClientSize = new System.Drawing.Size(700, 330);
            this.Text = "Getting Started";

            ListBox1.Location = new Point(55, 50);
            ListBox1.Name = "ListBox1";
            ListBox1.TabIndex = 1;
            ListBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            ListBox1.Grid.DefaultGridBorderStyle = GridBorderStyle.Solid;
            ListBox1.Properties.GridLineColor = Color.FromArgb(208, 215, 229);

            this.selectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.selectionComboBox.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.selectionComboBox.MetroColor = Color.FromArgb(27, 161, 226);
            this.selectionComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.selectionComboBox.Name = "selectionComboBox";
            this.selectionComboBox.Size = new System.Drawing.Size(widthListBox / 3, 21);
            this.selectionComboBox.TabIndex = 0;
            this.selectionComboBox.Location = new Point(55, 25);
            selectionComboBox.Items.Add("Single Selection");
            selectionComboBox.Items.Add("Simple Multiple Selection");
            selectionComboBox.Items.Add("Extended Multiple Selection");
            selectionComboBox.Text = "Single Selection";

            selectionComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.selectionComboBox.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChanged);


            heightListBox = 10 * (ListBox1.ItemHeight + 1);


            ListBox1.Size = new Size(widthListBox, heightListBox);
            //this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(239)))));
            textBox1.Location = new Point(55, 251);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(widthListBox, 24);
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            this.Controls.AddRange(new Control[] { ListBox1, textBox1, selectionComboBox });
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1012, 653);
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
                textBox1.Text = ListBox1.SelectedValue.ToString();
            }
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

