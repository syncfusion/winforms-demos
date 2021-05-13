#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
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
using Syncfusion.Windows.Forms.Tools;
using WindowsFormsApplication626.Properties;
using System.Runtime.InteropServices;

namespace BackStageDemo
{
    
    public partial class Form1 : RibbonForm
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        private const int WM_SETREDRAW = 11;
        string statusStripText = "Office2016 Colorful";
        Syncfusion.Windows.Forms.Tools.ToolStripTabGroup toolStripTabGroup1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabGroup();
        private Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv colorPickerUIAdv1;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.transparentPanel1.BorderStyle = BorderStyle.FixedSingle;
            this.transparentPanel2.BorderStyle = BorderStyle.FixedSingle;
            this.transparentPanel3.BorderStyle = BorderStyle.FixedSingle;
            this.transparentPanel4.BorderStyle = BorderStyle.FixedSingle;
            this.transparentPanel5.BorderStyle = BorderStyle.FixedSingle;
            this.transparentPanel6.BorderStyle = BorderStyle.FixedSingle;
            this.transparentPanel7.BorderStyle = BorderStyle.FixedSingle;
            this.transparentPanel8.BorderStyle = BorderStyle.FixedSingle;
            this.transparentPanel9.BorderStyle = BorderStyle.FixedSingle;
            this.transparentPanel10.BorderStyle = BorderStyle.FixedSingle;
            this.transparentPanel11.BorderStyle = BorderStyle.FixedSingle;
            this.transparentPanel12.BorderStyle = BorderStyle.FixedSingle;
            this.transparentPanel13.BorderStyle = BorderStyle.FixedSingle;
            this.transparentPanel14.BorderStyle = BorderStyle.FixedSingle;
            this.transparentPanel15.BorderStyle = BorderStyle.FixedSingle;
            this.transparentPanel16.BorderStyle = BorderStyle.FixedSingle;
            toolStripTabGroup1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            toolStripTabGroup1.Name = "Layout";
            toolStripTabGroup1.Visible = true;
            this.toolStripButton18.Enabled = false;
            this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver;
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
            // 
            // colorPickerUIAdv1.RecentGroup
            // 
            this.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors";
            this.colorPickerUIAdv1.RecentGroup.Visible = false;
            // 
            // colorPickerUIAdv1.StandardGroup
            // 
            this.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors";
            // 
            // colorPickerUIAdv1.ThemeGroup
            // 
            this.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = true;
            this.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors";
            // 
            // colorPickerUIAdv1
            // 
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.HorizontalItemsSpacing = 5;
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(25, 52);
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 149);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty;
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(181, 195);
            this.colorPickerUIAdv1.TabIndex = 0;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.ItemSelection += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_ItemSelection);
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked);
            this.backStageTab1.Controls.Add(this.colorPickerUIAdv1);
            this.colorPickerUIAdv1.Visible = false;
            this.colorPickerUIAdv1.MetroColor = Color.Blue;
            getIcon(false);
            Point[] point = new Point[2];
            point[0] = new Point(this.transparentPanel3.Left + 2, this.transparentPanel3.Top + this.transparentPanel3.Height - 2);
            point[1] = new Point(this.transparentPanel3.Left + this.transparentPanel3.Width - 2, this.transparentPanel3.Top + this.transparentPanel3.Height - 2);
            this.panel3.Invalidate();
            getMenu();
            this.toolStripComboBox1.Items.Add("Times New Roman");
            this.toolStripComboBox1.Items.Add("Arial");
            this.toolStripComboBox1.Items.Add("Calibri");
            this.toolStripComboBox1.Items.Add("Segoe UI");
            this.toolStripComboBox2.Items.Add("1");
            this.toolStripComboBox2.Items.Add("2");
            this.toolStripComboBox2.Items.Add("3");
            this.toolStripComboBox2.Items.Add("4");
            this.toolStripComboBox2.Items.Add("5");
            this.toolStripComboBox2.Items.Add("6");
            this.toolStripComboBox2.Items.Add("7");
            this.toolStripComboBox2.Items.Add("8");
            this.toolStripComboBox2.Items.Add("9");
            this.toolStripComboBox2.Items.Add("10");
            this.toolStripComboBox2.Items.Add("11");
            this.toolStripComboBox2.Items.Add("12");
            this.toolStripComboBox2.Items.Add("13");
            this.toolStripComboBox2.Items.Add("14");
            this.toolStripComboBox2.Items.Add("15");
            this.toolStripComboBox2.Items.Add("16");
            this.toolStripComboBox2.Items.Add("17");
            this.toolStripComboBox2.Items.Add("18");
            this.toolStripComboBox2.Items.Add("19");
            this.toolStripComboBox2.Items.Add("20");
            this.ribbonControlAdv1.TitleColor = Color.FromArgb(59, 59, 59);
            this.toolStripButton21.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            panel2.Location = new Point(0, 0);
            if (ribbonControlAdv1.RibbonStyle == RibbonStyle.Office2016)
            {
                this.toolStripComboBox3.Visible = true;
            }
            foreach (ToolStripTabItem items in this.ribbonControlAdv1.Header.MainItems)
            {
                foreach (ToolStripEx item in items.Panel.Controls)
                {
                    item.LauncherClick += new EventHandler(item_LauncherClick);
                }
            }
            this.toolStripEx11.AutoSize = true;
            this.toolStripEx11.Visible = false;
            this.toolStripComboBox5.Visible = false;
            this.statusStripEx2.Dock = DockStyleEx.Bottom;
            this.statusStripEx2.Visible = false;
            this.SizeChanged += new EventHandler(Form1_SizeChanged);
            this.ribbonControlAdv1.SizeChanged += new EventHandler(ribbonControlAdv1_SizeChanged);
            this.statusStripEx1.ThemeName = "Office2019Colorful";
            this.trackBarItem1.TrackBarExControl.ThemeName = "Office2019Colorful";
            this.trackBarItem1.TrackBarExControl.ThemeStyle.BackColor = this.statusStripEx1.ThemeStyle.BackColor;
            this.trackBarItem1.TrackBarExControl.ThemeStyle.TrackBarColor = this.trackBarItem1.TrackBarExControl.ThemeStyle.ButtonForeColor =
                this.trackBarItem1.TrackBarExControl.ThemeStyle.SliderColor = Color.White;
            this.trackBarItem1.TrackBarExControl.ThemeStyle.ButtonBackColor = this.statusStripEx1.ThemeStyle.BackColor;
            this.statusStripLabel1.Text = "Currently Ribbon is in Office2019";
            this.ribbonControlAdv1.ThemeName = "Office2019Colorful";
        }

        void ribbonControlAdv1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.panel7.Height = this.Height - (this.ribbonControlAdv1.Height + 40);
            }
            else
            {
                this.panel7.Height = this.Height - (this.ribbonControlAdv1.Height + 10);
            }
        }

        void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.panel7.Height = this.Height - (this.ribbonControlAdv1.Height + 40);
            }
            else
            {
                this.panel7.Height = this.Height - (this.ribbonControlAdv1.Height + 10);
            }
        }

        /// <summary>
        /// This event raises when the launcher is clicked
        /// </summary>
        /// <param name="sender">Instance of the Object</param>
        /// <param name="e">Contains data for the source</param>
        void item_LauncherClick(object sender, EventArgs e)
        {

            MessageBox.Show("Launcher is clicked","Launcher");
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
        #region Avoid flickering
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
        //        return cp;
        //    }
        //}
        #endregion
        private void colorPickerUIAdv1_ItemSelection(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {

        }

        private void colorPickerUIAdv1_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            toolStripTabGroup1.Color = this.ribbonControlAdv1.MenuColor = this.colorPickerUIAdv1.SelectedColor;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.ribbonControlAdv1.Focus();
            base.OnKeyUp(e);
        }

        private void GetToolStripbuttonImage(RibbonStyle ribbonStyle)
        {
            if (ribbonStyle == RibbonStyle.Office2010)
            {
                this.toolStripButton1.Image = global::WindowsFormsApplication626.Properties.Resources.Paste32;
                this.toolStripButton2.Image = global::WindowsFormsApplication626.Properties.Resources.Cut16;
                this.toolStripButton3.Image = global::WindowsFormsApplication626.Properties.Resources.Copy16;
                this.toolStripButton4.Image = global::WindowsFormsApplication626.Properties.Resources.FormatPainter16;
                this.toolStripButton11.Image =global::WindowsFormsApplication626.Properties.Resources.GrowFont16;
                this.toolStripButton16.Image =global::WindowsFormsApplication626.Properties.Resources.ShrinkFont16;
                this.toolStripButton5.Image = global::WindowsFormsApplication626.Properties.Resources.Bold16;
                this.toolStripButton6.Image = global::WindowsFormsApplication626.Properties.Resources.Italic16;
                this.toolStripButton7.Image = global::WindowsFormsApplication626.Properties.Resources.Underline16;
                this.toolStripButton8.Image = global::WindowsFormsApplication626.Properties.Resources.Strikethrough16;
                this.toolStripButton9.Image = global::WindowsFormsApplication626.Properties.Resources.Subscript16;
                this.toolStripButton10.Image =global::WindowsFormsApplication626.Properties.Resources.Superscript16;
                this.toolStripSplitButtonEx1.Image= global::WindowsFormsApplication626.Properties.Resources.TextHighlightColor16;
                this.toolStripSplitButtonEx3.Image= global::WindowsFormsApplication626.Properties.Resources.FontColor16;
                this.toolStripButton18.Image = global::WindowsFormsApplication626.Properties.Resources.Save16;
                this.toolStripButton20.Image = global::WindowsFormsApplication626.Properties.Resources.base_business_contacts;
                this.toolStripButton21.Image = global::WindowsFormsApplication626.Properties.Resources._0205_WebInsertHyperlink_32;
                this.toolStripButton29.Image = global::WindowsFormsApplication626.Properties.Resources.base_paperclip_32;
                this.toolStripButton27.Image = global::WindowsFormsApplication626.Properties.Resources.base_map;
                this.toolStripButton23.Image = global::WindowsFormsApplication626.Properties.Resources.base_charts;
                this.toolStripButton19.Image = global::WindowsFormsApplication626.Properties.Resources._0202_InsertShape_32;
                this.toolStripButton28.Image = global::WindowsFormsApplication626.Properties.Resources.PrintArea;
                this.toolStripButton30.Image = global::WindowsFormsApplication626.Properties.Resources._0356_NewComment_32;
                this.toolStripButton12.Image = global::WindowsFormsApplication626.Properties.Resources.CoverPage32;
                this.toolStripButton13.Image = global::WindowsFormsApplication626.Properties.Resources.BlankPage32;
                this.toolStripButton14.Image = global::WindowsFormsApplication626.Properties.Resources.PageBreak32;
                this.toolStripButton15.Image = global::WindowsFormsApplication626.Properties.Resources.Picture32;
                this.toolStripButton24.Image = global::WindowsFormsApplication626.Properties.Resources.BlankPage32;
                this.toolStripButton25.Image = global::WindowsFormsApplication626.Properties.Resources.IssueTracking_32x32;
                this.toolStripButton26.Image = global::WindowsFormsApplication626.Properties.Resources.Table_32;
            }
            else
            {
#if NETCORE
                this.toolStripButton1.Image = Bitmap.FromFile("..//..//..//FlatIcons//Paste32flat.png");
                this.toolStripButton2.Image = Bitmap.FromFile("..//..//..//FlatIcons//Cut16flat.png");
                this.toolStripButton3.Image = Bitmap.FromFile("..//..//..//FlatIcons//Copy16flat.png");
                this.toolStripButton4.Image = Bitmap.FromFile("..//..//..//FlatIcons//FormatPainter16flat.png");
                this.toolStripButton11.Image = Bitmap.FromFile("..//..//..//FlatIcons//GrowFont16flat.png");
                this.toolStripButton16.Image = Bitmap.FromFile("..//..//..//FlatIcons//ShrinkFont16flat.png");
                this.toolStripButton5.Image = Bitmap.FromFile("..//..//..//FlatIcons//Bold16flat.png");
                this.toolStripButton6.Image = Bitmap.FromFile("..//..//..//FlatIcons//Italic16flat.png");
                this.toolStripButton7.Image = Bitmap.FromFile("..//..//..//FlatIcons//Underline16flat.png");
                this.toolStripButton8.Image = Bitmap.FromFile("..//..//..//FlatIcons//Strike.png");
                this.toolStripButton9.Image = Bitmap.FromFile("..//..//..//FlatIcons//Subscript16flat.png");
                this.toolStripButton10.Image = Bitmap.FromFile("..//..//..//FlatIcons//SuperScript16flat.png");
                this.toolStripSplitButtonEx1.Image = Bitmap.FromFile("..//..//..//FlatIcons//TextHighlightColor16flat.png");
                this.toolStripSplitButtonEx3.Image = Bitmap.FromFile("..//..//..//FlatIcons//FontColor16flat.png");
                this.toolStripButton18.Image = Bitmap.FromFile("..//..//..//FlatIcons//Save16flat.png");
                this.toolStripButton20.Image = Bitmap.FromFile("..//..//..//FlatIcons//mailflat.png");
                this.toolStripButton21.Image = Bitmap.FromFile("..//..//..//FlatIcons//0205_WebInsertHyperlink_32flat.png");
                this.toolStripButton29.Image = Bitmap.FromFile("..//..//..//FlatIcons//base_paperclip_32flat.png");
                this.toolStripButton27.Image = Bitmap.FromFile("..//..//..//FlatIcons//base_mapflat.png");
                this.toolStripButton23.Image = Bitmap.FromFile("..//..//..//FlatIcons//base_chartsflat.png");
                this.toolStripButton19.Image = Bitmap.FromFile("..//..//..//FlatIcons//0202_InsertShape_32flat.png");
                this.toolStripButton28.Image = Bitmap.FromFile("..//..//..//FlatIcons//PrintAreaflat.png");
                this.toolStripButton30.Image = Bitmap.FromFile("..//..//..//FlatIcons//0356_NewComment_32flat.png");
                this.toolStripButton12.Image = Bitmap.FromFile("..//..//..//FlatIcons//0356_NewComment_32flat.png");
                this.toolStripButton13.Image = Bitmap.FromFile("..//..//..//FlatIcons//New32flat.png");
                this.toolStripButton14.Image = Bitmap.FromFile("..//..//..//FlatIcons//previouspageflat.png");
                this.toolStripButton15.Image = Bitmap.FromFile("..//..//..//FlatIcons//Pictureflat.png");
                this.toolStripButton24.Image = Bitmap.FromFile("..//..//..//FlatIcons//New32flat.png");
                this.toolStripButton25.Image = Bitmap.FromFile("..//..//..//FlatIcons//New32flat.png");
                this.toolStripButton26.Image = Bitmap.FromFile("..//..//..//FlatIcons//Table_32flat.png");
#else
                this.toolStripButton1.Image = Bitmap.FromFile("..//..//FlatIcons//Paste32flat.png");
                this.toolStripButton2.Image = Bitmap.FromFile("..//..//FlatIcons//Cut16flat.png");
                this.toolStripButton3.Image = Bitmap.FromFile("..//..//FlatIcons//Copy16flat.png");
                this.toolStripButton4.Image = Bitmap.FromFile("..//..//FlatIcons//FormatPainter16flat.png");
                this.toolStripButton11.Image = Bitmap.FromFile("..//..//FlatIcons//GrowFont16flat.png");
                this.toolStripButton16.Image = Bitmap.FromFile("..//..//FlatIcons//ShrinkFont16flat.png");
                this.toolStripButton5.Image = Bitmap.FromFile("..//..//FlatIcons//Bold16flat.png");
                this.toolStripButton6.Image = Bitmap.FromFile("..//..//FlatIcons//Italic16flat.png");
                this.toolStripButton7.Image = Bitmap.FromFile("..//..//FlatIcons//Underline16flat.png");
                this.toolStripButton8.Image = Bitmap.FromFile("..//..//FlatIcons//Strike.png");
                this.toolStripButton9.Image = Bitmap.FromFile("..//..//FlatIcons//Subscript16flat.png");
                this.toolStripButton10.Image = Bitmap.FromFile("..//..//FlatIcons//SuperScript16flat.png");
                this.toolStripSplitButtonEx1.Image = Bitmap.FromFile("..//..//FlatIcons//TextHighlightColor16flat.png");
                this.toolStripSplitButtonEx3.Image = Bitmap.FromFile("..//..//FlatIcons//FontColor16flat.png");
                this.toolStripButton18.Image = Bitmap.FromFile("..//..//FlatIcons//Save16flat.png");
                this.toolStripButton20.Image = Bitmap.FromFile("..//..//FlatIcons//mailflat.png");
                this.toolStripButton21.Image = Bitmap.FromFile("..//..//FlatIcons//0205_WebInsertHyperlink_32flat.png");
                this.toolStripButton29.Image = Bitmap.FromFile("..//..//FlatIcons//base_paperclip_32flat.png");
                this.toolStripButton27.Image = Bitmap.FromFile("..//..//FlatIcons//base_mapflat.png");
                this.toolStripButton23.Image = Bitmap.FromFile("..//..//FlatIcons//base_chartsflat.png");
                this.toolStripButton19.Image = Bitmap.FromFile("..//..//FlatIcons//0202_InsertShape_32flat.png");
                this.toolStripButton28.Image = Bitmap.FromFile("..//..//FlatIcons//PrintAreaflat.png");
                this.toolStripButton30.Image = Bitmap.FromFile("..//..//FlatIcons//0356_NewComment_32flat.png");
                this.toolStripButton12.Image = Bitmap.FromFile("..//..//FlatIcons//0356_NewComment_32flat.png");
                this.toolStripButton13.Image = Bitmap.FromFile("..//..//FlatIcons//New32flat.png");
                this.toolStripButton14.Image = Bitmap.FromFile("..//..//FlatIcons//previouspageflat.png");
                this.toolStripButton15.Image = Bitmap.FromFile("..//..//FlatIcons//Pictureflat.png");
                this.toolStripButton24.Image = Bitmap.FromFile("..//..//FlatIcons//New32flat.png");
                this.toolStripButton25.Image = Bitmap.FromFile("..//..//FlatIcons//New32flat.png");
                this.toolStripButton26.Image = Bitmap.FromFile("..//..//FlatIcons//Table_32flat.png");
#endif
            }
        }

        RibbonHeaderImage tempHeaderImage = RibbonHeaderImage.None;
        private void transparentPanel1_Click(object sender, EventArgs e)
        {
            SendMessage(this.Handle, WM_SETREDRAW, false, 0);
            this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2016;
            SendMessage(this.Handle, WM_SETREDRAW, true, 0);
            this.Refresh();
            tempHeaderImage = this.ribbonControlAdv1.RibbonHeaderImage;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.None;
            GetToolStripbuttonImage(this.ribbonControlAdv1.RibbonStyle);
            this.statusStripEx1.VisualStyle = StatusStripExStyle.Office2016Colorful;
            this.trackBarItem1.TrackBarExControl.Style = TrackBarEx.Theme.Office2016Colorful;
            this.statusStripEx1.Visible = true;
            this.statusStripEx2.Visible = false;
            this.toolStripEx11.Visible = false;
            this.statusStripText = this.ribbonControlAdv1.Office2016ColorScheme.ToString();
            this.statusStripLabel1.Text = "Currently Ribbon is in "+statusStripText;
            this.SetBackStageColor(ColorTranslator.FromHtml("#f1f1f1"));
            //this.toolStripComboBox3.Visible = true;
            //this.toolStripComboBox5.Visible = false;
            this.panel2.Visible = false;
            this.panel9.Visible = false;
            this.panel4.Visible = false;
            this.panel8.Visible = true;
            getDisabled();
            this.transparentPanel1.Image = global::WindowsFormsApplication626.Properties.Resources._2016;
            getIcon(false);
            Point[] point = new Point[2];
            point[0] = new Point(this.transparentPanel3.Left + 2, this.transparentPanel3.Top + this.transparentPanel3.Height - 2);
            point[1] = new Point(this.transparentPanel3.Left + this.transparentPanel3.Width - 2, this.transparentPanel3.Top + this.transparentPanel3.Height - 2);
            this.panel3.Invalidate();
            getSize();
        }
       
        private void SetBackStageColor(Color color)
        {
            this.backStageTab1.BackColor = color;
            this.backStageTab2.BackColor = color;
            this.backStageTab3.BackColor = color;
            this.backStageTab4.BackColor = color;
            this.backStageTab5.BackColor = color;
            this.backStageTab6.BackColor = color;
        }

        private void transparentPanel2_Click(object sender, EventArgs e)
        {
            this.ribbonControlAdv1.ShowMinimizeButton = true;
            
            SendMessage(this.Handle, WM_SETREDRAW, false, 0);
            this.statusStripEx1.Visible = false;
            this.statusStripEx2.Visible = true;
            this.trackBarItem2.TrackBarExControl.Style = TrackBarEx.Theme.Default;
            this.statusStripEx2.VisualStyle = StatusStripExStyle.Default;
            this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2010;
            this.statusStripLabel2.Text = "Currently Ribbon is in Office2010 Blue";
            SendMessage(this.Handle, WM_SETREDRAW, true, 0);
            this.Refresh();

            this.toolStripEx11.Visible = false;

             if (!ribbonControlAdv1.MinimizePanel && ribbonControlAdv1.ShowQuickPanelBelowRibbon)
            {
                this.ribbonControlAdv1.Height = 180;
            }
            GetToolStripbuttonImage(this.ribbonControlAdv1.RibbonStyle);
            getDisabled();
            switch (this.ribbonControlAdv1.OfficeColorScheme)
            {
                case ToolStripEx.ColorScheme.Blue:
                    this.transparentPanel2.Image=this.transparentPanel4.Image = global::WindowsFormsApplication626.Properties.Resources._2010blue;
                    break;
                case ToolStripEx.ColorScheme.Silver:
                  this.transparentPanel2.Image = this.transparentPanel5.Image = global::WindowsFormsApplication626.Properties.Resources._2010;
                    break;
                case ToolStripEx.ColorScheme.Black:
                    this.transparentPanel2.Image = this.transparentPanel6.Image = global::WindowsFormsApplication626.Properties.Resources._2010black;
                    break;
            }
            this.statusStripEx2.OfficeColorScheme = this.ribbonControlAdv1.OfficeColorScheme;
            this.panel2.Visible = false;
            this.panel8.Visible = false;
            this.panel9.Visible = false;
            this.panel4.Visible = true;
            getIcon(true);
            Point[] point = new Point[2];
            point[0] = new Point(this.transparentPanel2.Left+2, this.transparentPanel2.Top + this.transparentPanel2.Height-2);
            point[1] = new Point(this.transparentPanel2.Left + this.transparentPanel2.Width-2, this.transparentPanel2.Top + this.transparentPanel2.Height-2);
            this.panel3.Invalidate();
            getSize();
        }

        private void transparentPanel3_Click(object sender, EventArgs e)
        {
            this.panel8.Visible = false;
            this.panel9.Visible = false;
            this.panel4.Visible = true;

            getimages();

            this.ribbonControlAdv1.RibbonHeaderImage = tempHeaderImage;

            SendMessage(this.Handle, WM_SETREDRAW, false, 0);
            this.SetBackStageColor(Color.White);

            this.ribbonControlAdv1.Office2013ColorScheme = Office2013ColorScheme.LightGray;
            this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2013;
            this.ribbonControlAdv1.Office2013ColorScheme = Office2013ColorScheme.White;
            this.toolStripComboBox5.SelectedIndex = 0;
            this.statusStripEx1.VisualStyle = StatusStripExStyle.Office2016Colorful;
            this.trackBarItem1.TrackBarExControl.Style = TrackBarEx.Theme.Office2016Colorful;
            statusStripText = this.ribbonControlAdv1.Office2013ColorScheme.ToString();
            this.statusStripLabel1.Text = "Currently Ribbon is in Office2013 "+statusStripText;

            this.statusStripEx1.Visible = true;
            this.statusStripEx2.Visible = false;
            SendMessage(this.Handle, WM_SETREDRAW, true, 0);
            this.Refresh();
            
            this.ribbonControlAdv1.Office2013ColorScheme = Office2013ColorScheme.White;
        
            if (!ribbonControlAdv1.MinimizePanel && ribbonControlAdv1.ShowQuickPanelBelowRibbon)
            {
                this.ribbonControlAdv1.Height = 180;
            }
            GetToolStripbuttonImage(this.ribbonControlAdv1.RibbonStyle);
            this.toolStripEx11.Visible = true;
            this.toolStripComboBox5.Visible = true;
            getDisabled();
            this.transparentPanel3.Image = global::WindowsFormsApplication626.Properties.Resources._2013;
            this.panel2.Visible = true;
            getIcon(false);
            Point[] point = new Point[2];
            point[0] = new Point(this.transparentPanel3.Left+2, this.transparentPanel3.Top + this.transparentPanel3.Height-2);
            point[1] = new Point(this.transparentPanel3.Left + this.transparentPanel3.Width-2, this.transparentPanel3.Top + this.transparentPanel3.Height-2);
            this.panel3.Invalidate();
            getSize();
        }

        private void transparentPanel4_Click(object sender, EventArgs e)
        {
            getDisabled();
            SendMessage(this.Handle, WM_SETREDRAW, false, 0);
            this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue;
            this.statusStripEx1.Visible = false;
            this.statusStripEx2.Visible = true;
            this.trackBarItem2.TrackBarExControl.Style = TrackBarEx.Theme.Default;
            this.statusStripLabel2.Text = "Currently Ribbon is in Office2010 Blue";
            this.statusStripEx2.OfficeColorScheme = this.ribbonControlAdv1.OfficeColorScheme;

            this.statusStripEx2.VisualStyle = StatusStripExStyle.Default;
            SendMessage(this.Handle, WM_SETREDRAW, true, 0);
            this.Refresh();

            this.transparentPanel4.Image = global::WindowsFormsApplication626.Properties.Resources._2010blue;
            this.transparentPanel2.Image = global::WindowsFormsApplication626.Properties.Resources._2010blue;
        }

        private void transparentPanel5_Click(object sender, EventArgs e)
        {
            getDisabled();
            SendMessage(this.Handle, WM_SETREDRAW, false, 0);
            this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver;
            this.statusStripLabel2.Text = "Currently Ribbon is in Office2010 Silver";
            this.statusStripEx2.OfficeColorScheme = this.ribbonControlAdv1.OfficeColorScheme;

            this.statusStripEx2.VisualStyle = StatusStripExStyle.Default;
            this.trackBarItem2.TrackBarExControl.Style = TrackBarEx.Theme.Default;
            this.statusStripEx1.Visible = false;
            this.statusStripEx2.Visible = true;
            SendMessage(this.Handle, WM_SETREDRAW, true, 0);
            this.Refresh();
            this.transparentPanel5.Image = global::WindowsFormsApplication626.Properties.Resources._2010;
            this.transparentPanel2.Image = global::WindowsFormsApplication626.Properties.Resources._2010;
        }

        private void transparentPanel6_Click(object sender, EventArgs e)
        {
            getDisabled();
            SendMessage(this.Handle, WM_SETREDRAW, false, 0);
            this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
            this.statusStripLabel2.Text = "Currently Ribbon is in Office2010 Black";
            this.statusStripEx2.VisualStyle = StatusStripExStyle.Default;
            this.statusStripEx2.OfficeColorScheme = this.ribbonControlAdv1.OfficeColorScheme;
            this.trackBarItem2.TrackBarExControl.Style = TrackBarEx.Theme.Default;
            this.statusStripEx1.Visible = false;
            this.statusStripEx2.Visible = true;
            SendMessage(this.Handle, WM_SETREDRAW, true, 0);
            this.Refresh();

            this.transparentPanel6.Image = global::WindowsFormsApplication626.Properties.Resources._2010black;
            this.transparentPanel2.Image = global::WindowsFormsApplication626.Properties.Resources._2010black;
        }


        private void getIcon(bool value)
        {
            if (value)
            {
                this.backStageButton6.Image = global::WindowsFormsApplication626.Properties.Resources.Exit;
                this.backStageButton5.Image = global::WindowsFormsApplication626.Properties.Resources.Options;
                this.backStageButton4.Image = global::WindowsFormsApplication626.Properties.Resources.Close32;
                this.backStageButton3.Image = global::WindowsFormsApplication626.Properties.Resources.Open32;
                this.backStageButton2.Image = global::WindowsFormsApplication626.Properties.Resources.SaveAs32;
                this.backStageButton1.Image = global::WindowsFormsApplication626.Properties.Resources.Save16;
            }
            else
            {
                this.backStageButton6.Image = null;
                this.backStageButton5.Image = null;
                this.backStageButton4.Image = null;
                this.backStageButton3.Image = null;
                this.backStageButton2.Image = null;
                this.backStageButton1.Image = null;
            }
        }
        /// <summary>
        /// To get the toolstrip button size.
        /// </summary>
        private void getSize()
        {
            if (this.ribbonControlAdv1.RibbonStyle == RibbonStyle.Office2007)
            {
                this.toolStripButton1.Size = new Size(39, 68);
                this.toolStripButton19.Size = new Size(39, 68);
                this.toolStripButton20.Size = new Size(39, 68);
                this.toolStripButton21.Size = new Size(39, 68);
                this.toolStripButton23.Size = new Size(39, 68);
                this.toolStripButton27.Size = new Size(39, 68);
                this.toolStripButton28.Size = new Size(39, 68);
                this.toolStripButton29.Size = new Size(39, 68);
                this.toolStripButton30.Size = new Size(39, 68);
            }
            else
            {
                this.toolStripButton1.Size = new Size(39, 74);
                this.toolStripButton19.Size = new Size(39, 74);
                this.toolStripButton20.Size = new Size(39, 74);
                this.toolStripButton21.Size = new Size(39, 74);
                this.toolStripButton23.Size = new Size(39, 74);
                this.toolStripButton27.Size = new Size(39, 74);
                this.toolStripButton28.Size = new Size(39, 74);
                this.toolStripButton29.Size = new Size(39, 74);
                this.toolStripButton30.Size = new Size(39, 74);
            }
        }

        private void getMenu()
        {

            ToolStripButton toolStripButton231 = new ToolStripButton();
            ToolStripButton toolStripButton81 = new ToolStripButton();
            ToolStripButton toolStripButton91 = new ToolStripButton();
            ToolStripButton toolStripButton101 = new ToolStripButton();

            ToolStripLabel toolStripLabel13 = new ToolStripLabel();
            ToolStripLabel toolStripLabel17 = new ToolStripLabel();
            ToolStripLabel toolStripLabel18 = new ToolStripLabel();

            ToolStripSeparator toolStripSeparator1 = new ToolStripSeparator();

            toolStripButton231.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButton231.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // this.toolStripButton231.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton23.Image")));
            toolStripButton231.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton231.Name = "toolStripButton23";
            toolStripButton231.Padding = new System.Windows.Forms.Padding(5);
            toolStripButton231.Size = new System.Drawing.Size(128, 27);
            toolStripButton231.Text = "Recent Documents";


            // 
            // toolStripButton8
            // 
            toolStripButton81.Image = global::WindowsFormsApplication626.Properties.Resources.BlankPage32;

            toolStripButton81.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripButton81.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton81.Name = "toolStripButton8";
            toolStripButton81.Size = new System.Drawing.Size(69, 36);
            toolStripButton81.Text = "New";

            // 
            // toolStripButton9
            // 
            toolStripButton91.Image = global::WindowsFormsApplication626.Properties.Resources.Open32;
            toolStripButton91.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripButton91.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton91.Name = "toolStripButton9";
            toolStripButton91.Size = new System.Drawing.Size(69, 36);
            toolStripButton91.Text = "Open";
            // 
            // toolStripButton10
            // 
            toolStripButton101.Image = global::WindowsFormsApplication626.Properties.Resources.Save32;
            toolStripButton101.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripButton101.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton101.Name = "toolStripButton10";
            toolStripButton101.Size = new System.Drawing.Size(69, 36);
            toolStripButton101.Text = "Save";
            toolStripButton101.Enabled = false;

            // 
            // toolStripLabel13
            // 
            toolStripLabel13.Name = "toolStripLabel13";
            toolStripLabel13.Padding = new System.Windows.Forms.Padding(5);
            toolStripLabel13.Size = new System.Drawing.Size(128, 23);
            toolStripLabel13.Text = "1. Document.doc";
            toolStripLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel17
            // 
            toolStripLabel17.Name = "toolStripLabel17";
            toolStripLabel17.Padding = new System.Windows.Forms.Padding(5);
            toolStripLabel17.Size = new System.Drawing.Size(128, 23);
            toolStripLabel17.Text = "2. New Features.doc";
            toolStripLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel18
            // 
            toolStripLabel18.Name = "toolStripLabel18";
            toolStripLabel18.Padding = new System.Windows.Forms.Padding(5);
            toolStripLabel18.Size = new System.Drawing.Size(128, 23);
            toolStripLabel18.Text = "3. Report.doc";
            toolStripLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Padding = new System.Windows.Forms.Padding(5);
            toolStripSeparator1.Size = new System.Drawing.Size(112, 2);

            this.ribbonControlAdv1.OfficeMenu.AuxPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripButton231,
            toolStripSeparator1,
            toolStripLabel13,
            toolStripLabel17,
            toolStripLabel18});
            ribbonControlAdv1.OfficeMenu.MainPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripButton81,
            toolStripButton91,
            toolStripButton101});
        }

        private void getDisabled()
        {
            switch (this.ribbonControlAdv1.OfficeColorScheme)
            {
                case ToolStripEx.ColorScheme.Black:
                    this.transparentPanel2.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2010black;
                    this.transparentPanel1.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2007black;
                    break;
                case ToolStripEx.ColorScheme.Blue:
                     this.transparentPanel2.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2010blue;
                    this.transparentPanel1.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2007blue;
                    break;
                case ToolStripEx.ColorScheme.Silver:
                     this.transparentPanel2.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2010;
                    this.transparentPanel1.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2007silver;
                    break;
            }
            switch (this.ribbonControlAdv1.RibbonStyle)
            {
                case RibbonStyle.Office2007:
                    this.transparentPanel4.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2007blue;
                    this.transparentPanel5.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2007silver;
                    this.transparentPanel6.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2007black;
                    break;
                case RibbonStyle.Office2010:
                    this.transparentPanel4.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2010blue;
                    this.transparentPanel5.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2010;
                    this.transparentPanel6.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2010black;
                    break;
            }
            this.transparentPanel3.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2013;
            this.transparentPanel1.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2007silver;
            this.pictureBox5.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2019;

        }

        private void getimages()
        {
            this.transparentPanel12.Image = global::WindowsFormsApplication626.Properties.Resources.DisCircles;
            this.transparentPanel14.Image = global::WindowsFormsApplication626.Properties.Resources.DisDottedArrows;
            this.transparentPanel13.Image = global::WindowsFormsApplication626.Properties.Resources.DisLines;
            this.transparentPanel7.Image = global::WindowsFormsApplication626.Properties.Resources.DisNodes;
            this.transparentPanel8.Image = global::WindowsFormsApplication626.Properties.Resources.DisBirds;
            this.transparentPanel9.Image = global::WindowsFormsApplication626.Properties.Resources.DisBoxes3D;
            this.transparentPanel10.Image = global::WindowsFormsApplication626.Properties.Resources.DisBubbles;
            this.transparentPanel11.Image = global::WindowsFormsApplication626.Properties.Resources.DisButterflies;
            this.transparentPanel15.Image = global::WindowsFormsApplication626.Properties.Resources.DisCircles;
            this.transparentPanel16.Image = global::WindowsFormsApplication626.Properties.Resources.DisFloweral;
            
        }

        #region Header Image
        private void transparentPanel12_Click(object sender, EventArgs e)
        {
            getimages();
            this.transparentPanel12.Image = global::WindowsFormsApplication626.Properties.Resources.Circles;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Circles;
            this.ribbonControlAdv1.TitleColor = Color.FromArgb(59, 59, 59);
        }

        private void transparentPanel8_Click(object sender, EventArgs e)
        {
            getimages();
            this.transparentPanel8.Image = global::WindowsFormsApplication626.Properties.Resources.Birds;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Birds;
            this.ribbonControlAdv1.TitleColor = Color.FromArgb(59, 59, 59);
        }

        private void transparentPanel9_Click(object sender, EventArgs e)
        {
            getimages();
            this.transparentPanel9.Image = global::WindowsFormsApplication626.Properties.Resources.Boxes3D;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Boxes3D;
            this.ribbonControlAdv1.TitleColor = Color.FromArgb(59, 59, 59);
        }

        private void transparentPanel10_Click(object sender, EventArgs e)
        {
            getimages();
            this.transparentPanel10.Image = global::WindowsFormsApplication626.Properties.Resources.Bubbles;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Bubbles;
            this.ribbonControlAdv1.TitleColor = Color.FromArgb(59, 59, 59);
        }

        private void transparentPanel11_Click(object sender, EventArgs e)
        {
            getimages();
            this.transparentPanel11.Image = global::WindowsFormsApplication626.Properties.Resources.Butterflies;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Butterflies;
            this.ribbonControlAdv1.TitleColor = Color.FromArgb(59, 59, 59);
        }

        private void transparentPanel16_Click(object sender, EventArgs e)
        {
            getimages();
            this.transparentPanel16.Image = global::WindowsFormsApplication626.Properties.Resources.Floweral;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Floweral;
            this.ribbonControlAdv1.TitleColor = Color.FromArgb(59, 59, 59);
        }

        private void transparentPanel15_Click(object sender, EventArgs e)
        {
            getimages();
            this.transparentPanel15.Image = global::WindowsFormsApplication626.Properties.Resources.Circles;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Circles2;
            this.ribbonControlAdv1.TitleColor = Color.FromArgb(59, 59, 59);
        }

        private void transparentPanel14_Click(object sender, EventArgs e)
        {
            getimages();
            this.transparentPanel14.Image = global::WindowsFormsApplication626.Properties.Resources.DottedArrows;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.DottedArrows;
            this.ribbonControlAdv1.TitleColor = Color.FromArgb(59, 59, 59);
        }

        private void transparentPanel13_Click(object sender, EventArgs e)
        {
            getimages();
            this.transparentPanel13.Image = global::WindowsFormsApplication626.Properties.Resources.Lines;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Lines ;
            this.ribbonControlAdv1.TitleColor = Color.FromArgb(59, 59, 59);
        }

        private void transparentPanel7_Click(object sender, EventArgs e)
        {
            getimages();
            this.transparentPanel7.Image = global::WindowsFormsApplication626.Properties.Resources.Nodes;
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Nodes;
            this.ribbonControlAdv1.TitleColor = Color.FromArgb(59, 59, 59);
        }
        #endregion

        private void toolStripComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (this.toolStripComboBox3.SelectedItem.ToString())
            //{
            //    case "Colorful": this.ribbonControlAdv1.Office2016ColorScheme = Office2016ColorScheme.Colorful; break;
            //    case "Black": this.ribbonControlAdv1.Office2016ColorScheme = Office2016ColorScheme.Black; break;
            //    case "White": this.ribbonControlAdv1.Office2016ColorScheme = Office2016ColorScheme.White; break;
            //    case "DarkGray": this.ribbonControlAdv1.Office2016ColorScheme = Office2016ColorScheme.DarkGray; break;
            //}
        }

        private void toolStripComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetBackStageColor(Color.White);
            switch (this.toolStripComboBox5.SelectedItem.ToString())
            {
                case "LightGray": this.ribbonControlAdv1.Office2013ColorScheme = Office2013ColorScheme.LightGray; this.statusStripLabel1.Text = "Currently Ribbon is in Office2013 LightGray"; break;
                case "White": this.ribbonControlAdv1.Office2013ColorScheme = Office2013ColorScheme.White; this.statusStripLabel1.Text = "Currently Ribbon is in Office2013 White"; break;
                case "DarkGray": this.ribbonControlAdv1.Office2013ColorScheme = Office2013ColorScheme.DarkGray; this.statusStripLabel1.Text = "Currently Ribbon is in Office2013 DarkGray"; break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SendMessage(this.Handle, WM_SETREDRAW, false, 0);
            this.SetBackStageColor(ColorTranslator.FromHtml("#f1f1f1"));
            this.statusStripLabel1.Text = "Currently Ribbon is in Office2016 Colorful";
            this.ribbonControlAdv1.Office2016ColorScheme = Office2016ColorScheme.Colorful;
            this.statusStripEx1.VisualStyle = StatusStripExStyle.Office2016Colorful;
            this.trackBarItem1.TrackBarExControl.Style = TrackBarEx.Theme.Office2016Colorful;
            this.statusStripEx1.Visible = true;
            this.statusStripEx2.Visible = false;
            SendMessage(this.Handle, WM_SETREDRAW, true, 0);
            this.Refresh();
            this.pictureBox1.Image = global::WindowsFormsApplication626.Properties.Resources._2016;
            this.pictureBox2.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2016White;
            this.pictureBox3.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2016Black;
            this.pictureBox4.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2016DarkGray;

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SendMessage(this.Handle, WM_SETREDRAW, false, 0);
            this.SetBackStageColor(Color.White);
            this.statusStripEx1.VisualStyle = StatusStripExStyle.Office2016White;
            this.statusStripLabel1.Text = "Currently Ribbon is in Office2016 White";
            this.trackBarItem1.TrackBarExControl.Style = TrackBarEx.Theme.Office2016White;
            this.statusStripEx1.Visible = true;
            this.statusStripEx2.Visible = false;
            this.ribbonControlAdv1.Office2016ColorScheme = Office2016ColorScheme.White;
            SendMessage(this.Handle, WM_SETREDRAW, true, 0);
            this.Refresh();
            this.pictureBox1.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2016;
            this.pictureBox2.Image = global::WindowsFormsApplication626.Properties.Resources._2016White;
            this.pictureBox3.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2016Black;
            this.pictureBox4.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2016DarkGray;

            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SendMessage(this.Handle, WM_SETREDRAW, false, 0);
            this.statusStripEx1.VisualStyle = StatusStripExStyle.Office2016Black;
            this.trackBarItem1.TrackBarExControl.Style = TrackBarEx.Theme.Office2016Black;
            this.statusStripLabel1.Text = "Currently Ribbon is in Office2016 Black";
            this.SetBackStageColor(ColorTranslator.FromHtml("#262626"));
            this.ribbonControlAdv1.Office2016ColorScheme = Office2016ColorScheme.Black;
            this.statusStripEx1.Visible = true;
            this.statusStripEx2.Visible = false;
            SendMessage(this.Handle, WM_SETREDRAW, true, 0);
            this.Refresh();
            this.pictureBox1.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2016;
            this.pictureBox2.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2016White;
            this.pictureBox3.Image = global::WindowsFormsApplication626.Properties.Resources._2016Black;
            this.pictureBox4.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2016DarkGray;

            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SendMessage(this.Handle, WM_SETREDRAW, false, 0);
            this.SetBackStageColor(ColorTranslator.FromHtml("#6a6a6a"));
            this.statusStripEx1.VisualStyle = StatusStripExStyle.Office2016DarkGray;
            this.trackBarItem1.TrackBarExControl.Style = TrackBarEx.Theme.Office2016DarkGray;
            this.statusStripLabel1.Text = "Currently Ribbon is in Office2016 DarkGray";
            this.ribbonControlAdv1.Office2016ColorScheme = Office2016ColorScheme.DarkGray;
            this.statusStripEx1.Visible = true;
            this.statusStripEx2.Visible = false;
            SendMessage(this.Handle, WM_SETREDRAW, true, 0);
            this.Refresh();
            this.pictureBox1.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2016;
            this.pictureBox2.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2016White;
            this.pictureBox3.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2016Black;
            this.pictureBox4.Image = global::WindowsFormsApplication626.Properties.Resources._2016DarkGray;

           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // SendMessage(this.Handle, WM_SETREDRAW, false, 0);
            this.statusStripEx1.ThemeName = "Office2019Colorful";
            this.trackBarItem1.TrackBarExControl.ThemeName = "Office2019Colorful";
            this.trackBarItem1.TrackBarExControl.ThemeStyle.BackColor = this.statusStripEx1.ThemeStyle.BackColor;
            this.trackBarItem1.TrackBarExControl.ThemeStyle.TrackBarColor = this.trackBarItem1.TrackBarExControl.ThemeStyle.ButtonForeColor =
                this.trackBarItem1.TrackBarExControl.ThemeStyle.SliderColor = Color.White;
            this.trackBarItem1.TrackBarExControl.ThemeStyle.ButtonBackColor = this.statusStripEx1.ThemeStyle.BackColor;
            this.statusStripLabel1.Text = "Currently Ribbon is in Office2019";
            this.ribbonControlAdv1.ThemeName = "Office2019Colorful";
            this.statusStripEx1.Visible = true;
            this.statusStripEx2.Visible = false;
            this.panel8.Visible = false;
            this.panel2.Visible = false;
            this.panel9.Visible = true;
            getDisabled();
            this.toolStripEx11.Visible = false;
            this.toolStripComboBox5.Visible = false;
            this.pictureBox5.Image = global::WindowsFormsApplication626.Properties.Resources._2019Colorful;
            //  SendMessage(this.Handle, WM_SETREDRAW, true, 0);
        }
    }
}
