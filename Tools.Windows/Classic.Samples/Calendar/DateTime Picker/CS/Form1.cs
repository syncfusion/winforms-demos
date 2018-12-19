#region Copyright Syncfusion Inc. 2001 - 2014
//
//  Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Globalization;
using System.Resources;

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.Reflection;
using System.IO;
using Syncfusion.Licensing;


namespace CalendarControlsDemo
{

    public class Form1 : MetroForm
    {
        #region Declaration

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.ComponentModel.IContainer components;
        DataSet m_dataSetTbg = null;
        private DateTimePickerAdv dateTimePickerAdv15;
        private CheckBoxAdv checkBoxAdv1;
        private ComboBoxAdv comboBox1;
        private Label label10;
        private CheckBoxAdv checkBoxAdv2;
        private CheckBoxAdv checkBoxAdv3;
        private CheckBoxAdv checkBoxAdv4;
        private Label label7;
        private ComboBoxAdv comboBox2;
        private CheckBoxAdv checkBoxAdv5;
        private Label label4;
        private ComboBoxAdv comboBox3;
        private CheckBoxAdv checkBoxAdv6;
        private Label label1;
        private ComboBoxAdv comboBox4;
        private Label label2;
        private ComboBoxAdv comboBox5;
        private GradientPanel gradientPanel3;
        private Label label116;
        private CheckBoxAdv checkBoxAdv7;
        private CheckBoxAdv checkBoxAdv8;
        private CheckBoxAdv checkBoxAdv9;
        private ToolTip toolTip1;
        private Label label11;
        private ComboBoxAdv comboBox7;
        private ColorDialog colorDialog1;
        private GradientPanel gradientPanel2;
        private GradientPanel gradientPanel4;
        private GradientPanel gradientPanel5;
        private GroupBar groupBar1;
        private GroupBarItem groupBarItem1;
        private GroupBarItem groupBarItem2;
        private GroupBarItem groupBarItem3;
        private SplitContainerAdv splitContainerAdv1;
        private PopupControlContainer popupControlContainer1;
        private MonthCalendarAdv monthCalendarAdv1;
        DataTable table = null;
        #endregion

        #region Form Constructor and Dispose
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
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

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dateTimePickerAdv15 = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.checkBoxAdv5 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.checkBoxAdv6 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox4 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox5 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label116 = new System.Windows.Forms.Label();
            this.checkBoxAdv7 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv8 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv9 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox7 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.groupBarItem1 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem3 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.monthCalendarAdv1 = new Syncfusion.Windows.Forms.Tools.MonthCalendarAdv();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv15.Calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).BeginInit();
            this.gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
            this.groupBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthCalendarAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "popupback.png");
            // 
            // dataGrid1
            // 
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dataGrid1.BackColor = System.Drawing.Color.DarkGray;
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.Navy;
            this.dataGrid1.CaptionText = "Date";
            this.dataGrid1.DataMember = "";
            this.dataGrid1.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid1.LinkColor = System.Drawing.Color.Navy;
            this.dataGrid1.Location = new System.Drawing.Point(23, 144);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid1.Size = new System.Drawing.Size(247, 111);
            this.dataGrid1.TabIndex = 10;
            // 
            // dateTimePickerAdv15
            // 
            this.dateTimePickerAdv15.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.dateTimePickerAdv15.BorderColor = System.Drawing.Color.Silver;
            this.dateTimePickerAdv15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dateTimePickerAdv15.Calendar.AllowMultipleSelection = false;
            this.dateTimePickerAdv15.Calendar.Culture = new System.Globalization.CultureInfo("");
            this.dateTimePickerAdv15.Calendar.DaysFont = new System.Drawing.Font("Verdana", 8F);
            this.dateTimePickerAdv15.Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerAdv15.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAdv15.Calendar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerAdv15.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            this.dateTimePickerAdv15.Calendar.HeadForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerAdv15.Calendar.Location = new System.Drawing.Point(0, 0);
            this.dateTimePickerAdv15.Calendar.MetroColor = System.Drawing.Color.Silver;
            this.dateTimePickerAdv15.Calendar.MinValue = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAdv15.Calendar.Name = "monthCalendar";
            this.dateTimePickerAdv15.Calendar.ScrollButtonSize = new System.Drawing.Size(24, 24);
            this.dateTimePickerAdv15.Calendar.SelectedDates = new System.DateTime[0];
            this.dateTimePickerAdv15.Calendar.Size = new System.Drawing.Size(185, 174);
            this.dateTimePickerAdv15.Calendar.SizeToFit = true;
            this.dateTimePickerAdv15.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.dateTimePickerAdv15.Calendar.TabIndex = 0;
            this.dateTimePickerAdv15.Calendar.WeekFont = new System.Drawing.Font("Verdana", 8F);
            this.dateTimePickerAdv15.Calendar.WeekInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite);
            // 
            // 
            // 
            this.dateTimePickerAdv15.Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.dateTimePickerAdv15.Calendar.NoneButton.BackColor = System.Drawing.Color.Silver;
            this.dateTimePickerAdv15.Calendar.NoneButton.Location = new System.Drawing.Point(113, 0);
            this.dateTimePickerAdv15.Calendar.NoneButton.Size = new System.Drawing.Size(72, 20);
            this.dateTimePickerAdv15.Calendar.NoneButton.Text = "None";
            this.dateTimePickerAdv15.Calendar.NoneButton.UseVisualStyle = true;
            // 
            // 
            // 
            this.dateTimePickerAdv15.Calendar.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.dateTimePickerAdv15.Calendar.TodayButton.BackColor = System.Drawing.Color.Silver;
            this.dateTimePickerAdv15.Calendar.TodayButton.Location = new System.Drawing.Point(0, 0);
            this.dateTimePickerAdv15.Calendar.TodayButton.Size = new System.Drawing.Size(113, 20);
            this.dateTimePickerAdv15.Calendar.TodayButton.Text = "Today";
            this.dateTimePickerAdv15.Calendar.TodayButton.UseVisualStyle = true;
            this.dateTimePickerAdv15.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAdv15.CalendarSize = new System.Drawing.Size(189, 176);
            this.dateTimePickerAdv15.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerAdv15.DropDownImage = null;
            this.dateTimePickerAdv15.DropDownNormalColor = System.Drawing.Color.White;
            this.dateTimePickerAdv15.DropDownPressedColor = System.Drawing.Color.Silver;
            this.dateTimePickerAdv15.DropDownSelectedColor = System.Drawing.Color.Silver;
            this.dateTimePickerAdv15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAdv15.Location = new System.Drawing.Point(116, 163);
            this.dateTimePickerAdv15.MetroColor = System.Drawing.Color.Silver;
            this.dateTimePickerAdv15.MinValue = new System.DateTime(((long)(0)));
            this.dateTimePickerAdv15.Name = "dateTimePickerAdv15";
            this.dateTimePickerAdv15.ShowCheckBox = false;
            this.dateTimePickerAdv15.Size = new System.Drawing.Size(241, 20);
            this.dateTimePickerAdv15.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.dateTimePickerAdv15.TabIndex = 9;
            this.dateTimePickerAdv15.Value = new System.DateTime(2007, 11, 21, 11, 34, 33, 781);
            this.dateTimePickerAdv15.VSLikeUpDown = true;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.Location = new System.Drawing.Point(23, 47);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.Empty;
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(197, 29);
            this.checkBoxAdv1.TabIndex = 10;
            this.checkBoxAdv1.Text = "CustomPopupWindow";
            this.checkBoxAdv1.ThemesEnabled = true;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Location = new System.Drawing.Point(157, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 30);
            this.label10.TabIndex = 12;
            this.label10.Text = "Culture Settings";
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv2.DrawFocusRectangle = false;
            this.checkBoxAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv2.Location = new System.Drawing.Point(6, 249);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(207, 25);
            this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv2.TabIndex = 13;
            this.checkBoxAdv2.Text = "ShowUpDownOnFocus";
            this.checkBoxAdv2.ThemesEnabled = false;
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // checkBoxAdv3
            // 
            this.checkBoxAdv3.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv3.DrawFocusRectangle = false;
            this.checkBoxAdv3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv3.Location = new System.Drawing.Point(6, 216);
            this.checkBoxAdv3.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv3.Name = "checkBoxAdv3";
            this.checkBoxAdv3.Size = new System.Drawing.Size(189, 21);
            this.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv3.TabIndex = 14;
            this.checkBoxAdv3.Text = "ShowCheckBox";
            this.checkBoxAdv3.ThemesEnabled = false;
            this.checkBoxAdv3.CheckStateChanged += new System.EventHandler(this.checkBoxAdv3_CheckStateChanged);
            // 
            // checkBoxAdv4
            // 
            this.checkBoxAdv4.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv4.DrawFocusRectangle = false;
            this.checkBoxAdv4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv4.Location = new System.Drawing.Point(6, 285);
            this.checkBoxAdv4.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv4.Name = "checkBoxAdv4";
            this.checkBoxAdv4.Size = new System.Drawing.Size(189, 24);
            this.checkBoxAdv4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv4.TabIndex = 15;
            this.checkBoxAdv4.Text = "ShowUpDown";
            this.checkBoxAdv4.ThemesEnabled = false;
            this.checkBoxAdv4.CheckStateChanged += new System.EventHandler(this.checkBoxAdv4_CheckStateChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 33);
            this.label7.TabIndex = 17;
            this.label7.Text = "Custom Format";
            this.label7.Enabled = false;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.Items.AddRange(new object[] {
            "MMMM MMM MM dddd ddd dd yyyy hh mm ss",
            "dddd - dd MMMM yyyy",
            "HH:m , dd MM yyyy"});
            this.comboBox2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox2, "MMMM MMM MM dddd ddd dd yyyy hh mm ss"));
            this.comboBox2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox2, "dddd - dd MMMM yyyy"));
            this.comboBox2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox2, "HH:m , dd MM yyyy"));
            this.comboBox2.Location = new System.Drawing.Point(157, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 21);
            this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox2.TabIndex = 16;
            this.comboBox2.Text = "MMMM MMM MM dddd ddd dd yyyy hh mm ss";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // checkBoxAdv5
            // 
            this.checkBoxAdv5.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv5.Location = new System.Drawing.Point(23, 71);
            this.checkBoxAdv5.MetroColor = System.Drawing.Color.Empty;
            this.checkBoxAdv5.Name = "checkBoxAdv5";
            this.checkBoxAdv5.Size = new System.Drawing.Size(197, 29);
            this.checkBoxAdv5.TabIndex = 18;
            this.checkBoxAdv5.Text = "DataBinding";
            this.checkBoxAdv5.ThemesEnabled = true;
            this.checkBoxAdv5.CheckStateChanged += new System.EventHandler(this.checkBoxAdv5_CheckStateChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "Format";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.Items.AddRange(new object[] {
            "Long",
            "Short",
            "Time",
            "Custom"});
            this.comboBox3.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox3, "Long"));
            this.comboBox3.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox3, "Short"));
            this.comboBox3.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox3, "Time"));
            this.comboBox3.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox3, "Custom"));
            this.comboBox3.Location = new System.Drawing.Point(157, 38);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(108, 21);
            this.comboBox3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox3.TabIndex = 19;
            this.comboBox3.Text = "Long";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // checkBoxAdv6
            // 
            this.checkBoxAdv6.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv6.DrawFocusRectangle = false;
            this.checkBoxAdv6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv6.Location = new System.Drawing.Point(6, 181);
            this.checkBoxAdv6.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv6.Name = "checkBoxAdv6";
            this.checkBoxAdv6.Size = new System.Drawing.Size(167, 21);
            this.checkBoxAdv6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv6.TabIndex = 133;
            this.checkBoxAdv6.Text = "ThemesEnabled";
            this.checkBoxAdv6.ThemesEnabled = false;
            this.checkBoxAdv6.CheckStateChanged += new System.EventHandler(this.checkBoxAdv6_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 135;
            this.label1.Text = "Visual Styles";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.White;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.Items.AddRange(new object[] {
            "Metro",
            "Default",
            "OfficeXP",
            "Office2003",
            "Office2007",
            "Office2007Outlook",
            "Office2010",
            "VS2005",
            "VS2010",
            "Office2016White",
            "Office2016Colorful",
            "Office2016DarkGray",
            "Office2016Black"
            });
            this.comboBox4.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox4, "Default"));
            this.comboBox4.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox4, "OfficeXP"));
            this.comboBox4.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox4, "Office2007"));
            this.comboBox4.Location = new System.Drawing.Point(148, 31);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(106, 21);
            this.comboBox4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox4.TabIndex = 134;
            this.comboBox4.Text = "Metro";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 47);
            this.label2.TabIndex = 137;
            this.label2.Text = "Office2007 Color Scheme";
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.Color.White;
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.Items.AddRange(new object[] {
            "Blue",
            "Silver",
            "Black"});
            this.comboBox5.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox5, "Blue"));
            this.comboBox5.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox5, "Silver"));
            this.comboBox5.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox5, "Black"));
            this.comboBox5.Location = new System.Drawing.Point(148, 82);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(106, 21);
            this.comboBox5.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox5.TabIndex = 136;
            this.comboBox5.Text = "Blue";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BackColor = System.Drawing.Color.White;
            this.gradientPanel3.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.Controls.Add(this.label116);
            this.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel3.Location = new System.Drawing.Point(20, 20);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(719, 67);
            this.gradientPanel3.TabIndex = 140;
            // 
            // label116
            // 
            this.label116.BackColor = System.Drawing.Color.Transparent;
            this.label116.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label116.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label116.ForeColor = System.Drawing.Color.Black;
            this.label116.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label116.Location = new System.Drawing.Point(0, 0);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(717, 65);
            this.label116.TabIndex = 1;
            this.label116.Text = "DateTimePickerAdv is an advanced DateTimePicker control that provides an easy way" +
    " to implement a \r\nculture based DateTimePicker in an application. It has various" +
    " features as shown below.";
            this.label116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxAdv7
            // 
            this.checkBoxAdv7.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv7.DrawFocusRectangle = false;
            this.checkBoxAdv7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv7.Location = new System.Drawing.Point(13, 219);
            this.checkBoxAdv7.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv7.Name = "checkBoxAdv7";
            this.checkBoxAdv7.Size = new System.Drawing.Size(191, 31);
            this.checkBoxAdv7.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv7.TabIndex = 143;
            this.checkBoxAdv7.Text = "ReadOnly";
            this.checkBoxAdv7.ThemesEnabled = true;
            this.checkBoxAdv7.CheckStateChanged += new System.EventHandler(this.checkBoxAdv7_CheckStateChanged);
            // 
            // checkBoxAdv8
            // 
            this.checkBoxAdv8.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv8.DrawFocusRectangle = false;
            this.checkBoxAdv8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv8.Location = new System.Drawing.Point(13, 245);
            this.checkBoxAdv8.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv8.Name = "checkBoxAdv8";
            this.checkBoxAdv8.Size = new System.Drawing.Size(191, 31);
            this.checkBoxAdv8.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv8.TabIndex = 144;
            this.checkBoxAdv8.Text = "RightToLeft";
            this.checkBoxAdv8.ThemesEnabled = true;
            this.checkBoxAdv8.CheckStateChanged += new System.EventHandler(this.checkBoxAdv8_CheckStateChanged);
            // 
            // checkBoxAdv9
            // 
            this.checkBoxAdv9.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv9.DrawFocusRectangle = false;
            this.checkBoxAdv9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv9.Location = new System.Drawing.Point(6, 144);
            this.checkBoxAdv9.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv9.Name = "checkBoxAdv9";
            this.checkBoxAdv9.Size = new System.Drawing.Size(174, 21);
            this.checkBoxAdv9.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv9.TabIndex = 147;
            this.checkBoxAdv9.Text = "UseEnhancedMenu";
            this.checkBoxAdv9.ThemesEnabled = false;
            this.checkBoxAdv9.CheckStateChanged += new System.EventHandler(this.checkBoxAdv9_CheckStateChanged);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 28);
            this.label11.TabIndex = 150;
            this.label11.Text = "NullModeKeyReset";
            // 
            // comboBox7
            // 
            this.comboBox7.BackColor = System.Drawing.Color.White;
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.Items.AddRange(new object[] {
            "Arrow Keys",
            "Numeric Keys",
            "Any Key"});
            this.comboBox7.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox7, "Arrow Keys"));
            this.comboBox7.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox7, "Numeric Keys"));
            this.comboBox7.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox7, "Any Key"));
            this.comboBox7.Location = new System.Drawing.Point(157, 172);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(108, 21);
            this.comboBox7.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox7.TabIndex = 149;
            this.comboBox7.Text = "Arrow Keys";
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.BackColor = System.Drawing.Color.White;
            this.gradientPanel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            this.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel5.Controls.Add(this.label4);
            this.gradientPanel5.Controls.Add(this.label7);
            this.gradientPanel5.Controls.Add(this.label10);
            this.gradientPanel5.Controls.Add(this.checkBoxAdv7);
            this.gradientPanel5.Controls.Add(this.checkBoxAdv8);
            this.gradientPanel5.Controls.Add(this.label11);
            this.gradientPanel5.Controls.Add(this.comboBox3);
            this.gradientPanel5.Controls.Add(this.comboBox2);
            this.gradientPanel5.Controls.Add(this.comboBox7);
            this.gradientPanel5.Controls.Add(this.comboBox1);
            this.gradientPanel5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel5.ForeColor = System.Drawing.Color.Black;
            this.gradientPanel5.Location = new System.Drawing.Point(0, 44);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(274, 0);
            this.gradientPanel5.TabIndex = 158;
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BackColor = System.Drawing.Color.White;
            this.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel4.Controls.Add(this.checkBoxAdv1);
            this.gradientPanel4.Controls.Add(this.checkBoxAdv5);
            this.gradientPanel4.Controls.Add(this.dataGrid1);
            this.gradientPanel4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel4.ForeColor = System.Drawing.Color.Black;
            this.gradientPanel4.Location = new System.Drawing.Point(0, 66);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(274, 338);
            this.gradientPanel4.TabIndex = 154;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.Color.White;
            this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel2.Controls.Add(this.checkBoxAdv2);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv3);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv4);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv9);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv6);
            this.gradientPanel2.Controls.Add(this.comboBox4);
            this.gradientPanel2.Controls.Add(this.label1);
            this.gradientPanel2.Controls.Add(this.label2);
            this.gradientPanel2.Controls.Add(this.comboBox5);
            this.gradientPanel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel2.ForeColor = System.Drawing.Color.Black;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 22);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(274, 0);
            this.gradientPanel2.TabIndex = 153;
            // 
            // groupBar1
            // 
            this.groupBar1.AllowDrop = true;
            this.groupBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBar1.BorderColor = System.Drawing.Color.White;
            this.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupBar1.Controls.Add(this.gradientPanel4);
            this.groupBar1.Controls.Add(this.gradientPanel5);
            this.groupBar1.Controls.Add(this.gradientPanel2);
            this.groupBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBar1.ExpandButtonToolTip = null;
            this.groupBar1.FlatLook = true;
            this.groupBar1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBar1.ForeColor = System.Drawing.Color.White;
            this.groupBar1.GroupBarDropDownToolTip = null;
            this.groupBar1.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.groupBarItem1,
            this.groupBarItem2,
            this.groupBarItem3});
            this.groupBar1.IndexOnVisibleItems = true;
            this.groupBar1.Location = new System.Drawing.Point(0, 0);
            this.groupBar1.MinimizeButtonToolTip = null;
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.NavigationPaneTooltip = null;
            this.groupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar1.SelectedItem = 0;
            this.groupBar1.Size = new System.Drawing.Size(274, 404);
            this.groupBar1.TabIndex = 153;
            this.groupBar1.Text = "groupBar1";
            this.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // groupBarItem1
            // 
            this.groupBarItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupBarItem1.Client = this.gradientPanel2;
            this.groupBarItem1.Text = "Appearance";
            // 
            // groupBarItem2
            // 
            this.groupBarItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupBarItem2.Client = this.gradientPanel5;
            this.groupBarItem2.Text = "Behavior";
            // 
            // groupBarItem3
            // 
            this.groupBarItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupBarItem3.Client = this.gradientPanel4;
            this.groupBarItem3.Text = "Data Association";
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.Location = new System.Drawing.Point(20, 105);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.groupBar1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.popupControlContainer1);
            this.splitContainerAdv1.Panel2.Controls.Add(this.dateTimePickerAdv15);
            this.splitContainerAdv1.Size = new System.Drawing.Size(719, 406);
            this.splitContainerAdv1.SplitterDistance = 276;
            this.splitContainerAdv1.TabIndex = 154;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(252)))));
            this.popupControlContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.popupControlContainer1.Controls.Add(this.monthCalendarAdv1);
            this.popupControlContainer1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.popupControlContainer1.Location = new System.Drawing.Point(270, 504);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.popupControlContainer1.Size = new System.Drawing.Size(272, 180);
            this.popupControlContainer1.TabIndex = 5;
            this.popupControlContainer1.Visible = false;
            // 
            // monthCalendarAdv1
            // 
            this.monthCalendarAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(203)))));
            this.monthCalendarAdv1.BorderColor = System.Drawing.Color.White;
            this.monthCalendarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthCalendarAdv1.Culture = new System.Globalization.CultureInfo("");
            this.monthCalendarAdv1.DaysFont = new System.Drawing.Font("Verdana", 8F);
            this.monthCalendarAdv1.DaysHeaderInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            this.monthCalendarAdv1.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            this.monthCalendarAdv1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendarAdv1.HeaderHeight = 20;
            this.monthCalendarAdv1.HeaderStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(62)))));
            this.monthCalendarAdv1.Location = new System.Drawing.Point(77, 6);
            this.monthCalendarAdv1.Name = "monthCalendarAdv1";
            this.monthCalendarAdv1.ScrollButtonSize = new System.Drawing.Size(24, 24);
            this.monthCalendarAdv1.SelectedDates = new System.DateTime[] {
        new System.DateTime(2013, 8, 10, 0, 0, 0, 0)};
            this.monthCalendarAdv1.Size = new System.Drawing.Size(192, 145);
            this.monthCalendarAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
            this.monthCalendarAdv1.TabIndex = 1;
            this.monthCalendarAdv1.WeekFont = new System.Drawing.Font("Verdana", 8F);
            this.monthCalendarAdv1.WeekInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite);
            // 
            // 
            // 
            this.monthCalendarAdv1.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2003;
            this.monthCalendarAdv1.NoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(203)))));
            this.monthCalendarAdv1.NoneButton.Location = new System.Drawing.Point(116, 0);
            this.monthCalendarAdv1.NoneButton.Size = new System.Drawing.Size(72, 20);
            this.monthCalendarAdv1.NoneButton.UseVisualStyle = true;
            // 
            // 
            // 
            this.monthCalendarAdv1.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2003;
            this.monthCalendarAdv1.TodayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(203)))));
            this.monthCalendarAdv1.TodayButton.Location = new System.Drawing.Point(0, 0);
            this.monthCalendarAdv1.TodayButton.Size = new System.Drawing.Size(116, 20);
            this.monthCalendarAdv1.TodayButton.UseVisualStyle = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(759, 529);
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.gradientPanel3);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(771, 566);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTimePickerAdv";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv15.Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).EndInit();
            this.gradientPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.groupBar1.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.popupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthCalendarAdv1)).EndInit();
            this.ResumeLayout(false);

        }

        void monthCalendarAdv1_DateSelected(object sender, EventArgs e)
        {
            this.popupControlContainer1.HidePopup();
            this.dateTimePickerAdv15.Value = this.monthCalendarAdv1.SelectedDates[0];
        }
        #endregion

        #region Main
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }


        #endregion

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


        #region FormLoad
        Image leftButtonImg;
        Image rightButtonImg;
        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assem = this.GetType().Assembly;
            Stream imgStr1 = assem.GetManifestResourceStream("CalendarControls.arrow_left_blue.png");
            Stream imgStr2 = assem.GetManifestResourceStream("CalendarControls.arrow_right_blue.png");
            leftButtonImg = Image.FromStream(imgStr1);
            rightButtonImg = Image.FromStream(imgStr2);

            // Load all Specific Cultures to the Combo Box
            foreach (CultureInfo info in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                comboBox1.Items.Add(info.Name);
            }

            this.comboBox2.SelectedIndex = 0;
            this.comboBox2.Enabled = false;
            this.comboBox5.SelectedIndex = 0;
            this.comboBox5.Enabled = false;
            this.comboBox7.SelectedIndex = 0;
            this.comboBox1.SelectedIndex = 173;
            this.comboBox3.SelectedIndex = 0;


            // Populate Combo Box with VisualStyle
            string[] str = Enum.GetNames(typeof(VisualStyle));
            comboBox4.SelectedIndex = 10;
            // Populate Week Days
            string[] str1 = Enum.GetNames(typeof(Day));

            #region DataBinding
            m_dataSetTbg = new DataSet();
            table = m_dataSetTbg.Tables.Add("tbgstrg");
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns[0].AllowDBNull = true;
            table.Rows.Add(new object[] { DateTime.Now - TimeSpan.FromDays(60) });
            table.Rows.Add(new object[] { DateTime.Now });
            table.Rows.Add(new object[] { DBNull.Value });
            dataGrid1.DataSource = m_dataSetTbg;
            dataGrid1.DataMember = "tbgstrg";
            #endregion


            this.dataGrid1.HeaderBackColor = ColorTranslator.FromHtml("#d7e4f2");
            this.dataGrid1.CaptionBackColor = ColorTranslator.FromHtml("#16a5dc");
            this.dataGrid1.BackColor = System.Drawing.Color.White;
            this.dataGrid1.BackgroundColor = ColorTranslator.FromHtml("#edf0f6");
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.White;

            monthCalendarAdv1.TodayButton.Click += new EventHandler(TodayButton_Click);
            monthCalendarAdv1.NoneButtonClick += new EventHandler(monthCalendarAdv1_NoneButtonClick);
            monthCalendarAdv1.DateChanged += new EventHandler(monthCalendarAdv1_DateChanged);
        }

      
        #endregion
        void monthCalendarAdv1_DateChanged(object sender, EventArgs e)
        {
            this.popupControlContainer1.HidePopup();
            this.dateTimePickerAdv15.Value = this.monthCalendarAdv1.Value;
        }
        void monthCalendarAdv1_NoneButtonClick(object sender, EventArgs e)
        {
            this.popupControlContainer1.HidePopup();
            this.dateTimePickerAdv15.IsNullDate = true;
        }

        void TodayButton_Click(object sender, EventArgs e)
        {
            this.popupControlContainer1.HidePopup();
            this.dateTimePickerAdv15.Value = this.monthCalendarAdv1.Value;
        }

        #region DateTimePickerAdv


        #region dateTimePickerAdv Culture


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string culture = comboBox1.SelectedItem.ToString();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            this.dateTimePickerAdv15.Culture = new System.Globalization.CultureInfo(culture);

        }
        #endregion

        private void checkBoxAdv3_CheckStateChanged(object sender, EventArgs e)
        {
            this.dateTimePickerAdv15.ShowCheckBox = this.checkBoxAdv3.Checked;
        }

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            this.dateTimePickerAdv15.ShowUpDownOnFocus = this.checkBoxAdv2.Checked;
        }

        private void checkBoxAdv4_CheckStateChanged(object sender, EventArgs e)
        {
            this.dateTimePickerAdv15.ShowUpDown = this.checkBoxAdv4.Checked;
        }


        #region CustomFormat
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dateTimePickerAdv15.Format = DateTimePickerFormat.Custom;
            switch (this.comboBox2.SelectedIndex)
            {

                case 0:
                    {
                        this.dateTimePickerAdv15.CustomFormat = "MMMM MMM MM dddd ddd dd yyyy hh mm ss";
                        break;
                    }
                case 1:
                    {
                        this.dateTimePickerAdv15.CustomFormat = "dddd - dd MMMM yyyy";
                        break;
                    }
                case 2:
                    {
                        this.dateTimePickerAdv15.CustomFormat = "HH:m , dd MM yyyy";
                        break;
                    }
            }
        #endregion


        }




        private void checkBoxAdv5_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv5.Checked)
            {
                this.dateTimePickerAdv15.DataBindings.Add("BindableValue", m_dataSetTbg, "tbgstrg.Date");
            }
            else
            {
                this.dateTimePickerAdv15.DataBindings.Clear();
            }

        }
        #region Format
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox3.SelectedIndex)
            {

                case 0:
                    {
                        this.dateTimePickerAdv15.Format = DateTimePickerFormat.Long;
                        this.comboBox2.Enabled = false;
                        this.label7.Enabled = false;
                        break;
                    }
                case 1:
                    {
                        this.dateTimePickerAdv15.Format = DateTimePickerFormat.Short;
                        this.comboBox2.Enabled = false;
                        this.label7.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        this.dateTimePickerAdv15.Format = DateTimePickerFormat.Time;
                        this.comboBox2.Enabled = false;
                        this.label7.Enabled = false;
                        break;
                    }
                case 3:
                    {
                        this.dateTimePickerAdv15.Format = DateTimePickerFormat.Custom;
                        this.comboBox2.Enabled = true;
                        this.comboBox2.SelectedIndex = 1;
                        this.label7.Enabled = true;
                        break;
                    }
            }
        }
        #endregion

        private void checkBoxAdv6_CheckStateChanged(object sender, EventArgs e)
        {
            this.dateTimePickerAdv15.ThemesEnabled = this.checkBoxAdv6.Checked;
        }

        #region Visual Style
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox4.SelectedItem.ToString())
            {

                case "Default":
                    {
                        this.dateTimePickerAdv15.Style = VisualStyle.Default;
                        this.comboBox5.Enabled = false;
                        break;
                    }
                case "OfficeXP":
                    {
                        this.dateTimePickerAdv15.Style = VisualStyle.OfficeXP;
                        this.comboBox5.Enabled = false;
                        break;
                    }

                case "Office2007":
                    {
                        this.dateTimePickerAdv15.Style = VisualStyle.Office2007;
                        this.comboBox5.Enabled = true;
                        break;
                    }

                case "Metro":
                    {
                        this.dateTimePickerAdv15.Style = VisualStyle.Metro;
                        this.comboBox5.Enabled = false;
                        break;
                    }

                case "Office2003":
                    {
                        this.dateTimePickerAdv15.Style = VisualStyle.Office2003;
                        this.comboBox5.Enabled = false;
                        break;
                    }

                case "Office2007Outlook":
                    {
                        this.dateTimePickerAdv15.Style = VisualStyle.Office2007Outlook;
                        this.comboBox5.Enabled = false;
                        break;
                    }

                case "VS2010":
                    {
                        this.dateTimePickerAdv15.Style = VisualStyle.VS2010;
                        this.comboBox5.Enabled = false;
                        break;
                    }

                case "VS2005":
                    {
                        this.dateTimePickerAdv15.Style = VisualStyle.VS2005;
                        this.comboBox5.Enabled = false;
                        break;
                    }

                case "Office2010":
                    {
                        this.dateTimePickerAdv15.Style = VisualStyle.Office2010;
                        this.comboBox5.Enabled = false;
                        break;
                    }
                case "Office2016White":
                    {
                        this.dateTimePickerAdv15.Style = VisualStyle.Office2016White;
                        this.comboBox5.Enabled = false;
                        break;
                    }
                case "Office2016DarkGray":
                    {
                        this.dateTimePickerAdv15.Style = VisualStyle.Office2016DarkGray;
                        this.comboBox5.Enabled = false;
                        break;
                    }
                case "Office2016Black":
                    {
                        this.dateTimePickerAdv15.Style = VisualStyle.Office2016Black;
                        this.comboBox5.Enabled = false;
                        break;
                    }
                case "Office2016Colorful":
                    {
                        this.dateTimePickerAdv15.Style = VisualStyle.Office2016Colorful;
                        this.comboBox5.Enabled = false;
                        break;
                    }
            }


        }
        #endregion

        #region Color Scheme
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox5.SelectedItem.ToString() == "Blue")
            {
                this.dateTimePickerAdv15.Office2007Theme = Office2007Theme.Blue;
            }
            else if (this.comboBox5.SelectedItem.ToString() == "Silver")
            {
                this.dateTimePickerAdv15.Office2007Theme = Office2007Theme.Silver;
            }
            else
            {
                this.dateTimePickerAdv15.Office2007Theme = Office2007Theme.Black;
            }
        }
        #endregion

        private void checkBoxAdv7_CheckStateChanged(object sender, EventArgs e)
        {
            this.dateTimePickerAdv15.ReadOnly = checkBoxAdv7.Checked;
            this.dateTimePickerAdv15.ReadOnlyValueChange = !checkBoxAdv7.Checked;
        }

        private void checkBoxAdv8_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv8.Checked)
            {
                this.dateTimePickerAdv15.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                this.dateTimePickerAdv15.RightToLeft = RightToLeft.No;
            }


        }



        private void checkBoxAdv9_CheckStateChanged(object sender, EventArgs e)
        {
            this.dateTimePickerAdv15.UseEnhancedMenu = checkBoxAdv9.Checked;
        }

        #region NullModeKeyReset
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox7.SelectedIndex)
            {
                case 0:
                    {
                        this.dateTimePickerAdv15.NullModeKeyReset = NullModeKeyReset.ArrowKeys;
                        break;
                    }
                case 1:
                    {
                        this.dateTimePickerAdv15.NullModeKeyReset = NullModeKeyReset.NumericKeys;
                        break;
                    }
                case 2:
                    {
                        this.dateTimePickerAdv15.NullModeKeyReset = NullModeKeyReset.Any;
                        break;
                    }
            }
        }
        #endregion

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv1.Checked)
            {
                this.popupControlContainer1.BackgroundImage = Image.FromFile(@"..\\..\\popupback.png");
                this.dateTimePickerAdv15.CustomPopupWindow = this.popupControlContainer1;
                this.dateTimePickerAdv15.CustomDrop = true;
            }
            else
            {

                this.dateTimePickerAdv15.CustomDrop = false;

            }

        }

        #region PopUpControlContainer


        private void popupControlContainer1_Popup(object sender, System.EventArgs e)
        {
            this.monthCalendarAdv1.Focus();
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
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }

}
