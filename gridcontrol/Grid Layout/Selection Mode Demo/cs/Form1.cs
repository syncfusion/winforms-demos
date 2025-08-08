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

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using DemoCommon.Grid;
using System.Text.RegularExpressions;
using Syncfusion.Windows.Forms;

namespace SelectionModes
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private SelectionModes.DataSet1 dataSet11;
		private System.Windows.Forms.GroupBox groupBox2;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox3;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox4;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox5;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox7;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox8;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox9;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox10;
		private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        private GroupBox groupBox3;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox11;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox12;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox13;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox14;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox6;

        #endregion

        #region "Constructor"
        /// <summary>
        /// Form Sonstructor
        /// </summary>

        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }

            #region Data Initialization
            String commandstring = "select * from Customers";
            String connection = @"Data Source=" + FindFile("NorthwindwithImage.sdf");
            SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring, connection);
            try
            {
                da.Fill(dataSet11, "Customers");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }
            #endregion

            this.GridSettings();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        #endregion 

        #region "Grid Settings"
        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void GridSettings()
        {
            this.gridControl1.RowCount = this.dataSet11.Customers.Rows.Count;
            this.gridControl1.ColCount = this.dataSet11.Customers.Columns.Count;

            this.gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, gridControl1.RowCount, gridControl1.ColCount), dataSet11.Customers);
            this.gridControl1.PopulateHeaders(GridRangeInfo.Cells(0, 1, 1, gridControl1.ColCount), dataSet11.Customers);
            this.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cols(1, gridControl1.ColCount));
            this.gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Cols(1, gridControl1.RowCount));

            this.gridControl1.BackColor = Color.White;
            this.gridControl1.AlphaBlendSelectionColor = Color.CornflowerBlue;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;

            //Used to set default row height
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            this.gridControl1.Model.Options.DisplayEmptyRows = true;

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;

            for (int i = 1; i < this.gridControl1.ColCount; i++)
            {
                Regex rex = new Regex(@"\p{Lu}");
                string MappingName = this.gridControl1[0, i].Text;
                int index = rex.Match(MappingName.Substring(1)).Index;
                string name = "";
                while (index > 0)
                {
                    name += MappingName.Substring(0, index + 1) + " ";
                    string secondName = MappingName.Substring(index + 1);
                    index = rex.Match(secondName.Substring(1)).Index;
                    while (index > 0)
                    {
                        name += secondName.Substring(0, index + 1) + " ";
                        index = rex.Match(MappingName.Substring(name.Replace(" ", "").Length).Substring(1)).Index;
                    }
                }
                name += MappingName.Substring(name.Replace(" ", "").Length);
                this.gridControl1[0, i].Text = name;
            }

        }
        #endregion

        #region "Designer Stuffs"

        private string FindFile(string connstring)
        {
            connstring = @"Common\Data\" + connstring;
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(connstring))
                    return new FileInfo(connstring).FullName;
                connstring = @"..\" + connstring;
            }

            return connstring;
        }

		
        private static void ShowErrorMessage(SqlException ex)
        {
            if (ex.Number == 11001)
                MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 208)
                MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 156 || ex.Number == 102)
                MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        bool inCheckAll = false;
        private void CheckAll(bool b)
        {
            inCheckAll = true;
            checkBox1.Checked = b;
            checkBox3.Checked = b;
            checkBox4.Checked = b;
            checkBox5.Checked = b;
            checkBox6.Checked = b;
            checkBox7.Checked = b;
            checkBox8.Checked = b;
            checkBox9.Checked = b;
            checkBox10.Checked = b;
            inCheckAll = false;
        }

        private bool inCheck = false;
        private void Check(Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox, GridSelectionFlags flag)
        {
            checkListUnchecked();
            if (inCheckAll)
                return;
            inCheck = true;
            if (checkBox.Checked)
                this.gridControl1.AllowSelection |= flag;
            else
                this.gridControl1.AllowSelection &= ~flag;

            checkBox2.Checked = false;
            inCheck = false;            
        }

        #region Windows Form Designer generated code
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.dataSet11 = new SelectionModes.DataSet1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox10 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox9 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox8 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox7 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox6 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox5 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox11 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox12 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox13 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox14 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox14)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.Maroon, System.Drawing.Color.IndianRed);
            this.gradientPanel2.Controls.Add(this.groupBox1);
            this.gradientPanel2.Location = new System.Drawing.Point(2, 46);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(0, 0);
            this.gradientPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection Mode";
            // 
            // radioButton3
            // 
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(8, 88);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "MultiExtended";
            // 
            // radioButton2
            // 
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(8, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "MultiSimple";
            // 
            // radioButton1
            // 
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(8, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "One";
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel3.Border3DStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.gradientPanel3.Location = new System.Drawing.Point(9, 32);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(607, 126);
            this.gradientPanel3.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.AllowSelection = ((Syncfusion.Windows.Forms.Grid.GridSelectionFlags)(((((((Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Row | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Table)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Cell)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Multiple)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Shift)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Keyboard)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.AlphaBlend)));
            this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.BackColor = System.Drawing.Color.White;
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 5;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(1, 126),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(2, 127),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(3, 113),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(4, 109),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(5, 139)});
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.gridControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl1.Location = new System.Drawing.Point(14, 7);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.NumberedColHeaders = false;
            this.gridControl1.NumberedRowHeaders = false;
            this.gridControl1.Properties.BackgroundColor = System.Drawing.Color.White;
            this.gridControl1.Properties.ForceImmediateRepaint = false;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(612, 395);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.checkBox10);
            this.groupBox2.Controls.Add(this.checkBox9);
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(641, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 203);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection Modes";
            // 
            // checkBox10
            // 
            this.checkBox10.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.Location = new System.Drawing.Point(146, 145);
            this.checkBox10.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(89, 24);
            this.checkBox10.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox10.DrawFocusRectangle = true;
            this.checkBox10.TabIndex = 10;
            this.checkBox10.Text = "Table";
            this.checkBox10.ThemesEnabled = false;
            this.checkBox10.CheckStateChanged += new System.EventHandler(this.checkBox10_CheckStateChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Location = new System.Drawing.Point(10, 143);
            this.checkBox9.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(104, 24);
            this.checkBox9.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox9.DrawFocusRectangle = true;
            this.checkBox9.TabIndex = 9;
            this.checkBox9.Text = "Shift";
            this.checkBox9.ThemesEnabled = false;
            this.checkBox9.CheckStateChanged += new System.EventHandler(this.checkBox9_CheckStateChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(146, 115);
            this.checkBox8.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(89, 24);
            this.checkBox8.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox8.DrawFocusRectangle = true;
            this.checkBox8.TabIndex = 8;
            this.checkBox8.Text = "Row";
            this.checkBox8.ThemesEnabled = false;
            this.checkBox8.CheckStateChanged += new System.EventHandler(this.checkBox8_CheckStateChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(146, 83);
            this.checkBox7.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(89, 24);
            this.checkBox7.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox7.DrawFocusRectangle = true;
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Multiple";
            this.checkBox7.ThemesEnabled = false;
            this.checkBox7.CheckStateChanged += new System.EventHandler(this.checkBox7_CheckStateChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(10, 113);
            this.checkBox6.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(119, 24);
            this.checkBox6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox6.DrawFocusRectangle = true;
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "MixRangeType";
            this.checkBox6.ThemesEnabled = false;
            this.checkBox6.CheckStateChanged += new System.EventHandler(this.checkBox6_CheckStateChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(10, 83);
            this.checkBox5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(105, 24);
            this.checkBox5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox5.DrawFocusRectangle = true;
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "Keyboard";
            this.checkBox5.ThemesEnabled = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(146, 53);
            this.checkBox4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(89, 24);
            this.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox4.DrawFocusRectangle = true;
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Column";
            this.checkBox4.ThemesEnabled = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(146, 21);
            this.checkBox3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(89, 24);
            this.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox3.DrawFocusRectangle = true;
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Cell";
            this.checkBox3.ThemesEnabled = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(10, 21);
            this.checkBox2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 24);
            this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox2.DrawFocusRectangle = true;
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Any";
            this.checkBox2.ThemesEnabled = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(10, 53);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.DrawFocusRectangle = true;
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "AlphaBlend";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.checkBox11);
            this.groupBox3.Controls.Add(this.checkBox12);
            this.groupBox3.Controls.Add(this.checkBox13);
            this.groupBox3.Controls.Add(this.checkBox14);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(641, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 180);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ListBox Selection Modes";
            // 
            // checkBox11
            // 
            this.checkBox11.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(10, 23);
            this.checkBox11.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(119, 24);
            this.checkBox11.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox11.DrawFocusRectangle = true;
            this.checkBox11.TabIndex = 9;
            this.checkBox11.Text = "MultiSimple";
            this.checkBox11.ThemesEnabled = false;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.Location = new System.Drawing.Point(146, 23);
            this.checkBox12.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(75, 24);
            this.checkBox12.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox12.DrawFocusRectangle = true;
            this.checkBox12.TabIndex = 10;
            this.checkBox12.Text = "One";
            this.checkBox12.ThemesEnabled = false;
            this.checkBox12.CheckStateChanged += new System.EventHandler(this.checkBox12_CheckStateChanged);
            // 
            // checkBox13
            // 
            this.checkBox13.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox13.Location = new System.Drawing.Point(10, 53);
            this.checkBox13.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(104, 24);
            this.checkBox13.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox13.DrawFocusRectangle = true;
            this.checkBox13.TabIndex = 11;
            this.checkBox13.Text = "MultiExtended";
            this.checkBox13.ThemesEnabled = false;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBox13_CheckedChanged);
            // 
            // checkBox14
            // 
            this.checkBox14.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox14.Location = new System.Drawing.Point(146, 53);
            this.checkBox14.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(75, 24);
            this.checkBox14.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox14.DrawFocusRectangle = true;
            this.checkBox14.TabIndex = 12;
            this.checkBox14.Text = "None";
            this.checkBox14.ThemesEnabled = false;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBox14_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 414);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gradientPanel3);
            this.MinimumSize = new System.Drawing.Size(780, 420);
            this.Name = "Form1";
            this.Text = "Selection Mode ";
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox14)).EndInit();
            this.ResumeLayout(false);

		}

       
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
			Application.Run(new Form1());
        }

        #endregion

        #region EventHandler
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Check(checkBox1, GridSelectionFlags.AlphaBlend);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Check(checkBox4, GridSelectionFlags.Column);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Check(checkBox5, GridSelectionFlags.Keyboard);
        }

        private void checkBox7_CheckStateChanged(object sender, EventArgs e)
        {
            Check(checkBox7, GridSelectionFlags.Multiple);
        }

        private void checkBox6_CheckStateChanged(object sender, EventArgs e)
        {
            Check(checkBox6, GridSelectionFlags.MixRangeType);
        }

        private void checkBox8_CheckStateChanged(object sender, EventArgs e)
        {
            Check(checkBox8, GridSelectionFlags.Row);
        }

        private void checkBox9_CheckStateChanged(object sender, EventArgs e)
        {
            Check(checkBox9, GridSelectionFlags.Shift);
        }

        private void checkBox10_CheckStateChanged(object sender, EventArgs e)
        {
            Check(checkBox10, GridSelectionFlags.Table);
        }       

       
        private void checkSelectionUnchecked()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;           
                  
        }
        private void checkListUnchecked()
        {
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            checkSelectionUnchecked();
            checkBox13.Checked = false;
            checkBox12.Checked = false;
            checkBox14.Checked = false;
            this.gridControl1.ListBoxSelectionMode = SelectionMode.MultiSimple;
        }

        private void checkBox12_CheckStateChanged(object sender, EventArgs e)
        {
            checkSelectionUnchecked();
            //checkBox13.Checked = false;
            //checkBox11.Checked = false;
            //checkBox14.Checked = false;
            this.gridControl1.ListBoxSelectionMode = SelectionMode.One;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            checkSelectionUnchecked();
            //checkBox11.Checked = false;
            //checkBox12.Checked = false;
            //checkBox14.Checked = false;
            this.gridControl1.ListBoxSelectionMode = SelectionMode.MultiExtended;           

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            checkSelectionUnchecked();
        //    checkListUnchecked();
            this.gridControl1.ListBoxSelectionMode = SelectionMode.None;
        }
       

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Check(checkBox3, GridSelectionFlags.Cell); 
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (inCheck)
                return;

            if (checkBox2.Checked)
            {
                CheckAll(true);
                this.gridControl1.AllowSelection = GridSelectionFlags.Any;// (GridSelectionFlags)(this.gridControl1.AllowSelection | GridSelectionFlags.Any);
            }
            else
            {
                CheckAll(false);
                this.gridControl1.Selections.Clear();
                this.gridControl1.AllowSelection = GridSelectionFlags.None;// (GridSelectionFlags)(this.gridControl1.AllowSelection & ~GridSelectionFlags.Any);
            }
        }
        #endregion
    }
}
