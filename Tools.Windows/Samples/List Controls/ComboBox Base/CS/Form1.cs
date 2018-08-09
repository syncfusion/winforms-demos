#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Licensing;
using System.IO;

namespace ComboBoxBase
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		internal System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label label2;
		private Syncfusion.Windows.Forms.Tools.ComboBoxBase comboBoxBase1;		
		private ComboBoxBase.DataSet1 dataSet11;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.ListBox listBox1;				
		private System.Windows.Forms.Panel groupBox1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private Syncfusion.Windows.Forms.Tools.ComboBoxBase comboBoxBase2;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
		private TextBoxExt textLog;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxBase comboBoxBase4;
		private System.Windows.Forms.ListBox listBox3;
		private Syncfusion.Windows.Forms.Tools.ComboBoxBase comboBoxBase5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private System.ComponentModel.IContainer components;
        private Color listBoxBorderColor = ColorTranslator.FromHtml("#dedede");
        private Color listBoxBackColor = ColorTranslator.FromHtml("#ffffff");
        private Color listBoxItemSelectedTextColor = ColorTranslator.FromHtml("#2b2b2b");
        private Color listBoxItemNormalTextColor = ColorTranslator.FromHtml("#5e5e5e");
        private SkinManager skinManager1;
        private Label label9;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        internal Label label10;
        private ScrollersFrame scrollersFrame1;
        private Color listBoxItemHoverBackgroundColor = ColorTranslator.FromHtml("#e1e1e1");
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
            this.MinimumSize = this.Size;
            this.listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            this.listBox2.DrawMode = DrawMode.OwnerDrawFixed;
            this.listBox3.DrawMode = DrawMode.OwnerDrawFixed;
            this.listBox1.DrawItem += ListBox1_DrawItem;
            this.listBox2.DrawItem += ListBox1_DrawItem;
            this.listBox3.DrawItem += ListBox1_DrawItem;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TextFormatFlags tf = TextFormatFlags.SingleLine | TextFormatFlags.TextBoxControl | TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter| TextFormatFlags.Left;
            SolidBrush brush = new SolidBrush(this.listBoxBackColor);
            if (this.comboBoxBase1.Style == VisualStyle.Office2016Colorful)
            {
                listBoxBorderColor = ColorTranslator.FromHtml("#dedede");
                listBoxBackColor = ColorTranslator.FromHtml("#ffffff");
                listBoxItemSelectedTextColor = ColorTranslator.FromHtml("#2b2b2b");
                listBoxItemNormalTextColor = ColorTranslator.FromHtml("#5e5e5e");
                listBoxItemHoverBackgroundColor = ColorTranslator.FromHtml("#e1e1e1");
            }
            else if (this.comboBoxBase1.Style == VisualStyle.Office2016DarkGray)
            {
                listBoxBorderColor = ColorTranslator.FromHtml("#acacac");
                listBoxBackColor = ColorTranslator.FromHtml("#f0f0f0");
                listBoxItemSelectedTextColor = ColorTranslator.FromHtml("#0b0b0b");
                listBoxItemNormalTextColor = ColorTranslator.FromHtml("#444444");
                listBoxItemHoverBackgroundColor = ColorTranslator.FromHtml("#adadad");
            }
            else if (this.comboBoxBase1.Style == VisualStyle.Office2016Black)
            {
                listBoxBorderColor = ColorTranslator.FromHtml("#5e5e5e");
                listBoxBackColor = ColorTranslator.FromHtml("#363636");
                listBoxItemSelectedTextColor = ColorTranslator.FromHtml("#ffffff");
                listBoxItemNormalTextColor = ColorTranslator.FromHtml("#f0f0f0");
                listBoxItemHoverBackgroundColor = ColorTranslator.FromHtml("#666666");
            }
            else 
            {
                listBoxBackColor = ColorTranslator.FromHtml("#ffffff");
                listBoxBorderColor = ColorTranslator.FromHtml("#c6c6c6");
                listBoxItemSelectedTextColor = ColorTranslator.FromHtml("#5e5e5e");
                listBoxItemNormalTextColor = ColorTranslator.FromHtml("#5e5e5e");
                listBoxItemHoverBackgroundColor = ColorTranslator.FromHtml("#e6f2fa");
            }
            if (e.State == DrawItemState.Selected)
            {
                brush = new SolidBrush(this.listBoxItemHoverBackgroundColor);
                e.Graphics.FillRectangle(brush, e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }
            string text = string.Empty;
            if ((sender as ListBox).Items[e.Index] is DataRowView)
            {
                text = ((sender as ListBox).Items[e.Index] as DataRowView).Row["CategoryName"].ToString();
            }
            TextRenderer.DrawText(e.Graphics, text, this.Font, e.Bounds, this.listBoxItemNormalTextColor, tf);
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
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable2 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable3 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable4 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable5 = new Syncfusion.Windows.Forms.MetroColorTable();
            this.Label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataSet11 = new ComboBoxBase.DataSet1();
            this.skinManager1 = new Syncfusion.Windows.Forms.SkinManager(this.components);
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.comboBoxBase2 = new Syncfusion.Windows.Forms.Tools.ComboBoxBase();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBoxBase1 = new Syncfusion.Windows.Forms.Tools.ComboBoxBase();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textLog = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.comboBoxBase4 = new Syncfusion.Windows.Forms.Tools.ComboBoxBase();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.comboBoxBase5 = new Syncfusion.Windows.Forms.Tools.ComboBoxBase();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Label1.ImageList = this.imageList1;
            this.Label1.Location = new System.Drawing.Point(10, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(1119, 60);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "The ComboBoxBase can be bound to any ListBox derived class during design-time, \r\n" +
    "which will then appear in its drop-down during runtime.";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skinManager1
            // 
            this.skinManager1.Controls = this;
            this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016White;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerAdv1.BeforeTouchSize = 13;
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.Location = new System.Drawing.Point(13, 130);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.panel1);
            this.splitContainerAdv1.Size = new System.Drawing.Size(1112, 462);
            this.splitContainerAdv1.SplitterDistance = 635;
            this.splitContainerAdv1.SplitterWidth = 13;
            this.splitContainerAdv1.TabIndex = 15;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBoxBase2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGrid1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.comboBoxBase1);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 480);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.Text = "Bounded";
            // 
            // comboBoxBase2
            // 
            this.comboBoxBase2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxBase2.BeforeTouchSize = new System.Drawing.Size(213, 27);
            this.comboBoxBase2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBase2.ListControl = this.listBox2;
            this.comboBoxBase2.Location = new System.Drawing.Point(269, 414);
            this.comboBoxBase2.Name = "comboBoxBase2";
            this.comboBoxBase2.Size = new System.Drawing.Size(213, 27);
            this.comboBoxBase2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
            this.comboBoxBase2.TabIndex = 15;
            this.comboBoxBase2.Text = "True";
            this.comboBoxBase2.SelectionChangeCommitted += new System.EventHandler(this.comboBoxBase2_SelectionChangeCommitted);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBox2.ItemHeight = 19;
            this.listBox2.Items.AddRange(new object[] {
            "True",
            "False"});
            this.listBox2.Location = new System.Drawing.Point(265, 167);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(168, 23);
            this.listBox2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Set Discontinue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bounded ListControls";
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(63, 108);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(110)))), ((int)(((byte)(152)))));
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(110)))), ((int)(((byte)(152)))));
            this.dataGrid1.Size = new System.Drawing.Size(515, 274);
            this.dataGrid1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Category for Display";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.Items.AddRange(new object[] {
            ""});
            this.listBox1.Location = new System.Drawing.Point(220, 187);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 121);
            this.listBox1.TabIndex = 12;
            // 
            // comboBoxBase1
            // 
            this.comboBoxBase1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxBase1.BeforeTouchSize = new System.Drawing.Size(212, 27);
            this.comboBoxBase1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBase1.ListControl = this.listBox1;
            this.comboBoxBase1.Location = new System.Drawing.Point(265, 58);
            this.comboBoxBase1.Name = "comboBoxBase1";
            this.comboBoxBase1.Size = new System.Drawing.Size(212, 27);
            this.comboBoxBase1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
            this.comboBoxBase1.TabIndex = 9;
            this.comboBoxBase1.SelectionChangeCommitted += new System.EventHandler(this.comboBoxBase1_SelectionChangeCommitted);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textLog);
            this.panel1.Controls.Add(this.comboBoxBase4);
            this.panel1.Controls.Add(this.comboBoxBase5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.listBox3);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 460);
            this.panel1.TabIndex = 14;
            // 
            // textLog
            // 
            this.textLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textLog.BeforeTouchSize = new System.Drawing.Size(462, 192);
            this.textLog.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.textLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textLog.Location = new System.Drawing.Point(0, 268);
            this.textLog.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLog.Size = new System.Drawing.Size(462, 192);
            this.textLog.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.textLog.TabIndex = 17;
            // 
            // comboBoxBase4
            // 
            this.comboBoxBase4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxBase4.BeforeTouchSize = new System.Drawing.Size(224, 27);
            this.comboBoxBase4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBase4.ListControl = this.listBox3;
            this.comboBoxBase4.Location = new System.Drawing.Point(113, 99);
            this.comboBoxBase4.Name = "comboBoxBase4";
            this.comboBoxBase4.Size = new System.Drawing.Size(224, 27);
            this.comboBoxBase4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
            this.comboBoxBase4.TabIndex = 19;
            this.comboBoxBase4.Text = "Item1";
            this.comboBoxBase4.DropDown += new System.EventHandler(this.comboBoxBase_DropDown);
            this.comboBoxBase4.SelectionChangeCommitted += new System.EventHandler(this.comboBoxBase_SelectionChangeCommitted);
            this.comboBoxBase4.TextChanged += new System.EventHandler(this.comboBoxBase_TextChanged);
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBox3.ItemHeight = 19;
            this.listBox3.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Item3",
            "Item4",
            "Item5"});
            this.listBox3.Location = new System.Drawing.Point(269, 310);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(145, 61);
            this.listBox3.TabIndex = 23;
            // 
            // comboBoxBase5
            // 
            this.comboBoxBase5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxBase5.BeforeTouchSize = new System.Drawing.Size(224, 27);
            this.comboBoxBase5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBase5.ListControl = this.checkedListBox1;
            this.comboBoxBase5.Location = new System.Drawing.Point(113, 189);
            this.comboBoxBase5.Name = "comboBoxBase5";
            this.comboBoxBase5.Size = new System.Drawing.Size(224, 27);
            this.comboBoxBase5.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
            this.comboBoxBase5.TabIndex = 20;
            this.comboBoxBase5.Text = "Item1";
            this.comboBoxBase5.DropDown += new System.EventHandler(this.comboBoxBase_DropDown);
            this.comboBoxBase5.SelectionChangeCommitted += new System.EventHandler(this.comboBoxBase_SelectionChangeCommitted);
            this.comboBoxBase5.TextChanged += new System.EventHandler(this.comboBoxBase_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkedListBox1.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Item3",
            "Item4",
            "Item5",
            "Item6"});
            this.checkedListBox1.Location = new System.Drawing.Point(312, 275);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(146, 67);
            this.checkedListBox1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(113, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Combo With CheckedListBox:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(113, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Combo With ListBox:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Events Log";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(372, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "ComboBoxBase with different Controls in DropDown";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(10, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1116, 48);
            this.label10.TabIndex = 17;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Visual Styles for ComboBoxBase";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(213, 27);
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Office2007",
            "Office2010",
            "Metro",
            "Office2016Colorful",
            "Office2016White",
            "Office2016DarkGray",
            "Office2016Black"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(622, 82);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(213, 27);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
            this.comboBoxAdv1.TabIndex = 19;
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.AttachedTo = this.textLog;
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame1.MetroThumbSize = new System.Drawing.Size(0, 0);
            this.scrollersFrame1.Office2016ColorScheme = Syncfusion.Windows.Forms.ScrollBarOffice2016ColorScheme.Colorful;
            metroColorTable1.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable1.ArrowCheckedBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ArrowInActive = System.Drawing.Color.White;
            metroColorTable1.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ArrowNormalBackGround = System.Drawing.Color.Empty;
            metroColorTable1.ArrowNormalBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ArrowPushedBackGround = System.Drawing.Color.Empty;
            metroColorTable1.ArrowPushedBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ScrollerBackground = System.Drawing.Color.White;
            metroColorTable1.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable1.ThumbCheckedBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ThumbInActive = System.Drawing.Color.White;
            metroColorTable1.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ThumbNormalBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ThumbPushedBorder = System.Drawing.Color.Empty;
            metroColorTable1.ThumbPushedBorderColor = System.Drawing.Color.Empty;
            this.scrollersFrame1.ScrollMetroColorTable = metroColorTable1;
            metroColorTable2.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            metroColorTable2.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            metroColorTable2.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            metroColorTable2.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            metroColorTable2.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable2.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable2.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable2.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable2.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable2.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.scrollersFrame1.ScrollOffice2016BlackColorTable = metroColorTable2;
            metroColorTable3.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable3.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable3.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable3.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable3.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable3.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable3.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            metroColorTable3.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable3.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable3.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable3.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable3.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable3.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable3.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            metroColorTable3.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.scrollersFrame1.ScrollOffice2016ColorfulColorTable = metroColorTable3;
            metroColorTable4.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable4.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            metroColorTable4.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable4.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            metroColorTable4.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable4.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable4.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            metroColorTable4.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            metroColorTable4.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            metroColorTable4.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            metroColorTable4.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable4.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable4.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.scrollersFrame1.ScrollOffice2016DarkGrayColorTable = metroColorTable4;
            metroColorTable5.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable5.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable5.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable5.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable5.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable5.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable5.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable5.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable5.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            metroColorTable5.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable5.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable5.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable5.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable5.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable5.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable5.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable5.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            metroColorTable5.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.scrollersFrame1.ScrollOffice2016WhiteColorTable = metroColorTable5;
            this.scrollersFrame1.ShowMetroArrowButton = true;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2016;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 19);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 602);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxAdv1);
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Label1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox Base";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main() 
		{
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
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


        private void Form1_Load(object sender, System.EventArgs e)
        {

            this.comboBoxAdv1.SelectedIndex = 3;
            this.comboBoxAdv1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.listBox1.DataSource = this.dataSet11.Categories;
            this.listBox1.DisplayMember = "CategoryName";

            string DEF_DB_COMMAND2 = "SELECT DISTINCT CategoryName FROM Categories";

            //Access the database and get the NorthWind
            SqlCeConnection conn = new SqlCeConnection();
            if (conn.ServerVersion.StartsWith("3.5"))
                conn.ConnectionString = "Data Source = " + (@"..\..\..\..\..\..\..\Common\Data\" + "NorthwindIO_3.5.sdf");
            else
                conn.ConnectionString = "Data Source = " + (@"..\..\..\..\..\..\..\Common\Data\" + "NorthwindIO.sdf");
            conn.Open();

            SqlCeDataAdapter adapter = new SqlCeDataAdapter(DEF_DB_COMMAND2, conn);

            adapter.Fill(this.dataSet11.Categories);

            this.dataGrid1.DataSource = this.dataSet11.Products;

            //this.dataGrid1.HeaderBackColor = ColorTranslator.FromHtml("#d7e4f2");
            //this.dataGrid1.CaptionBackColor = ColorTranslator.FromHtml("#16a5dc");
            //this.dataGrid1.BackColor = System.Drawing.Color.White;
            //this.dataGrid1.BackgroundColor = ColorTranslator.FromHtml("#edf0f6");
            //this.dataGrid1.CaptionForeColor = System.Drawing.Color.White;
            this.comboBoxBase2.DataBindings.Add("Text", this.dataSet11.Products, "Discontinued");
            this.comboBoxBase2.Enabled = false;
        }

        private void FilterProductsList(DataTable productListTable, string category)
        {

            string DEF_DB_COMMAND2 = "SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Products.Discontinued FROM (Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID) WHERE Categories.CategoryName='" + category + "'";

            //Access the database and get the NorthWind
            SqlCeConnection conn = new SqlCeConnection();
            if (conn.ServerVersion.StartsWith("3.5"))
                conn.ConnectionString = "Data Source = " + (@"..\..\..\..\..\..\..\Common\Data\" + "NorthwindIO_3.5.sdf");
            else
                conn.ConnectionString = "Data Source = " + (@"..\..\..\..\..\..\..\Common\Data\" + "NorthwindIO.sdf");
            conn.Open();

            SqlCeDataAdapter adapter = new SqlCeDataAdapter(DEF_DB_COMMAND2, conn);

            adapter.Fill(productListTable);

        }

        private void comboBoxBase1_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            this.dataSet11.Products.Clear();
            FilterProductsList(this.dataSet11.Products, this.comboBoxBase1.Text);
            this.comboBoxBase2.Enabled = true;
            AddLog("Displaying " + this.comboBoxBase1.Text + " Category");
        }


        private void AddLog(string text)
        {
            this.textLog.Text += text + "\r\n";
        }

        private void comboBoxBase2_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[this.dataGrid1.DataSource];
            DataRow dr = this.dataSet11.Products.Rows[cm.Position];
            if (dr != null && dr["Discontinued"].ToString() != this.comboBoxBase2.Text)
            {
                AddLog("Setting Discontinuation " + this.comboBoxBase2.Text + " to the Product -> " + dr["ProductName"].ToString());
            }
        }

        private void comboBoxBase_DropDown(object sender, System.EventArgs e)
        {
            AddLog("Event: DropDown");
        }

        private void comboBoxBase_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            AddLog("Event: SelectionChangeCommitted");
        }

        private void comboBoxBase_TextChanged(object sender, System.EventArgs e)
        {
            AddLog("Event: TextChanged");
        }
        private void GetColors(Color backcolor, Color forecolor)
        {
            this.BackColor = backcolor;
            this.CaptionBarColor = backcolor;
            this.MetroColor = backcolor;
            //this.panel1.BackColor = backcolor;
            this.groupBox1.ForeColor = forecolor;
            this.panel1.ForeColor = forecolor;
            this.ForeColor = forecolor;
            this.CaptionForeColor = forecolor;
            this.Label1.ForeColor = forecolor;
           
        }
        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGrid1.BackgroundColor = Color.Gainsboro;
            switch (this.comboBoxAdv1.SelectedItem.ToString())
            {
                case "Office2007":
                    {
                        //this.listBox1.DrawMode = DrawMode.Normal;
                        //this.listBox2.DrawMode = DrawMode.Normal;
                        //this.listBox3.DrawMode = DrawMode.Normal;
                        this.comboBoxAdv1.ForeColor =
                        this.comboBoxBase1.ForeColor =
                        this.comboBoxBase2.ForeColor =
                        this.comboBoxBase4.ForeColor =
                        this.comboBoxBase5.ForeColor = SystemColors.WindowText; 
                        this.skinManager1.VisualTheme = VisualTheme.Metro;
                        this.skinManager1.VisualTheme = VisualTheme.Office2007Blue;
                        this.comboBoxAdv1.Style = VisualStyle.Office2007;
                        this.comboBoxBase1.Style = VisualStyle.Office2007;
                        this.comboBoxBase2.Style = VisualStyle.Office2007;
                        this.comboBoxBase4.Style = VisualStyle.Office2007;
                        this.comboBoxBase5.Style = VisualStyle.Office2007;
                        this.scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Office2007;
                        this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Blue;
                        this.comboBoxAdv1.ForeColor =
                       this.comboBoxBase1.ForeColor =
                       this.comboBoxBase2.ForeColor =
                       this.comboBoxBase4.ForeColor =
                       this.comboBoxBase5.ForeColor = SystemColors.WindowText;
                        this.GetColors(Color.White, Color.Black);
                        break;
                    }
                case "Office2010":
                    {
                        //this.listBox1.DrawMode = DrawMode.Normal;
                        //this.listBox2.DrawMode = DrawMode.Normal;
                        //this.listBox3.DrawMode = DrawMode.Normal;
                        this.skinManager1.VisualTheme = VisualTheme.Metro;
                        this.skinManager1.VisualTheme = VisualTheme.Office2010Blue;
                        this.GetColors(Color.White, Color.Black);
                        this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Blue;
                        this.comboBoxAdv1.ForeColor =
                         this.comboBoxBase1.ForeColor =
                         this.comboBoxBase2.ForeColor =
                         this.comboBoxBase4.ForeColor =
                         this.comboBoxBase5.ForeColor = SystemColors.WindowText;
                        this.scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Office2010;
                        break;
                    }
                case "Metro":
                    {
                        //this.listBox1.DrawMode = DrawMode.Normal;
                        //this.listBox2.DrawMode = DrawMode.Normal;
                        //this.listBox3.DrawMode = DrawMode.Normal;
                        this.skinManager1.VisualTheme = VisualTheme.Metro;
                        this.GetColors(Color.White, Color.Black);
                        this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Metro;
                        this.comboBoxAdv1.ForeColor =
                          this.comboBoxBase1.ForeColor =
                          this.comboBoxBase2.ForeColor =
                          this.comboBoxBase4.ForeColor =
                          this.comboBoxBase5.ForeColor = SystemColors.WindowText;
                        this.scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Metro;
                        this.textLog.BackColor = Color.White;
                        break;
                    }
                case "Office2016Colorful":
                    {
                        //this.listBox1.DrawMode = DrawMode.OwnerDrawFixed;
                        //this.listBox2.DrawMode = DrawMode.OwnerDrawFixed;
                        //this.listBox3.DrawMode = DrawMode.OwnerDrawFixed;
                        this.skinManager1.VisualTheme = VisualTheme.Office2016Colorful;
                        this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Colorful;
                        this.GetColors(Color.White, Color.Black);
                        break;
                    }
                case "Office2016White":
                    {
                        //this.listBox1.DrawMode = DrawMode.OwnerDrawFixed;
                        //this.listBox2.DrawMode = DrawMode.OwnerDrawFixed;
                        //this.listBox3.DrawMode = DrawMode.OwnerDrawFixed;
                        this.skinManager1.VisualTheme = VisualTheme.Office2016White;
                        this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016White;
                        this.GetColors(Color.White, Color.Black);
                        break;
                    }
                case "Office2016DarkGray":
                    {
                        //this.listBox1.DrawMode = DrawMode.OwnerDrawFixed;
                        //this.listBox2.DrawMode = DrawMode.OwnerDrawFixed;
                        //this.listBox3.DrawMode = DrawMode.OwnerDrawFixed;
                        this.skinManager1.VisualTheme = VisualTheme.Office2016DarkGray;
                        this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016DarkGray;
                        this.GetColors(ColorTranslator.FromHtml("#7c7c7c"), Color.LightGray);
                        break;
                    }
                case "Office2016Black":
                    {
                        //this.listBox1.DrawMode = DrawMode.OwnerDrawFixed;
                        //this.listBox2.DrawMode = DrawMode.OwnerDrawFixed;
                        //this.listBox3.DrawMode = DrawMode.OwnerDrawFixed;
                        this.GetColors(Color.FromArgb(37, 37, 37), Color.White);
                        this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Black;
                        this.skinManager1.VisualTheme = VisualTheme.Office2016Black;
                        break;
                    }
            }
        }
    }

}
