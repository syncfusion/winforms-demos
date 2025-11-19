#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using Syncfusion.Windows.Forms.Grid;
using System.Data.SqlClient;

using System.Data.SqlServerCe;
using System.IO;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Collections.Specialized;
using DemoCommon.Grid;

namespace SortingMethods
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region  "API Definitions"

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
		private Syncfusion.Windows.Forms.ButtonAdv button1;
		private Syncfusion.Windows.Forms.ButtonAdv button2;
		private Syncfusion.Windows.Forms.ButtonAdv button3;
        private Syncfusion.Windows.Forms.ButtonAdv button4;
        private IContainer components;
		private SortingMethods.Dataset1 dataset11;
        private Panel panel1;
        private CheckBoxAdv checkBoxAdv1;
        private ComboBoxAdv comboBoxAdv1;
        private ButtonAdv buttonAdv1;
        private GroupBox groupBox1;
        private Panel panel2;
        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");

        #endregion

        #region "Constructor"

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
            this.GridSettings();
            this.SampleCustomization();
		}

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            this.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            StringCollection ar = new StringCollection();
            ar.Add("Left Align");
            ar.Add("Center Align");
            ar.Add("Right Align");
            comboBoxAdv1.DataSource = ar;

            //used to set GridCaptionRowHeight.
			this.gridGroupingControl1.TableControl.DpiAware = true;
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);;
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);;
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);;
            this.gridGroupingControl1.TableModel.ColWidths.ResizeToFit(GridRangeInfo.Table());

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region "Sample Customizations"

        /// <summary>
        /// Grouping sample Customizations are done here.
        /// </summary>
        private void SampleCustomization()
        {
            String commandstring = "select * from Customers";

            SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring, connString);
            try
            {
                da.Fill(dataset11, "Customers");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }

            this.gridGroupingControl1.TableDescriptor.AllowNew = false;
            this.gridGroupingControl1.TableControlQueryAllowSortColumn += new Syncfusion.Windows.Forms.Grid.Grouping.GridQueryAllowSortColumnEventHandler(gridGroupingControl1_TableControlQueryAllowSortColumn);
            this.checkBoxAdv1.Checked = true;
        }

        #region Event Handlers
        // Sort GridGroupingControl by ContactName column
        private void button1_Click(object sender, System.EventArgs e)
        {
            if (this.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Contains("ContactName"))
                this.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Clear();
            if (this.gridGroupingControl1.TableOptions.AllowSortColumns)
                this.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Add("ContactName", ListSortDirection.Ascending);
        }
        // Sort GridGroupingControl by City column
        private void button2_Click(object sender, System.EventArgs e)
        {
            if (this.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Contains("City"))
                this.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Clear();
            if (this.gridGroupingControl1.TableOptions.AllowSortColumns)
                this.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Add("City", ListSortDirection.Ascending);
        }
        // Sort GridGroupingControl by Country column
        private void button3_Click(object sender, System.EventArgs e)
        {
            if (this.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Contains("Country"))
                this.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Clear();
            if (this.gridGroupingControl1.TableOptions.AllowSortColumns)
                this.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Add("Country", ListSortDirection.Ascending);
        }

        // reset the Soring columns
        private void button4_Click(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.Engine.TableDescriptor.ResetSortedColumns();
        }

        // Prevent the column Region from sorting
        private void gridGroupingControl1_TableControlQueryAllowSortColumn(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridQueryAllowSortColumnEventArgs e)
        {
            if (e.Column.GetName() == "Region")
            {
                e.AllowSort = false;
            }
        }

        private void checkBoxAdv1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxAdv chkBox = sender as CheckBoxAdv;
            this.gridGroupingControl1.TableOptions.AllowSortColumns = this.checkBoxAdv1.Checked;
            this.panel2.Enabled = this.checkBoxAdv1.Checked;
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            if (comboBoxAdv1.SelectedIndex == 0)
                this.gridGroupingControl1.SortIconPlacement = SortIconPlacement.Left;
            else if (comboBoxAdv1.SelectedIndex == 1)
                this.gridGroupingControl1.SortIconPlacement = SortIconPlacement.Top;
            else if (comboBoxAdv1.SelectedIndex == 2)
                this.gridGroupingControl1.SortIconPlacement = SortIconPlacement.Right;
            this.gridGroupingControl1.Refresh();
        }

        #endregion

        #endregion

        #region "Designer Stuffs"

        #region Dispose
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

        #endregion

        #region FindFile
        /// <summary>
        /// Find the file at the specific location 
        /// </summary>
        private static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Common\Data\" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return new FileInfo(fileName).FullName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return fileName;
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
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor3 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor4 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor5 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor6 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor7 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.dataset11 = new SortingMethods.Dataset1();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gridGroupingControl1.DataSource = this.dataset11.Customers;
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2007;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(6, 1);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Office2007ScrollBars = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(838, 649);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.TableDescriptor.AllowNew = false;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = true;
            this.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader";
            gridColumnDescriptor1.HeaderImage = null;
            gridColumnDescriptor1.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor1.HeaderText = "Customer ID";
            gridColumnDescriptor1.MappingName = "CustomerID";
            gridColumnDescriptor1.SerializedImageArray = "";
            gridColumnDescriptor2.HeaderImage = null;
            gridColumnDescriptor2.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor2.HeaderText = "Company Name";
            gridColumnDescriptor2.MappingName = "CompanyName";
            gridColumnDescriptor2.SerializedImageArray = "";
            gridColumnDescriptor3.HeaderImage = null;
            gridColumnDescriptor3.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor3.HeaderText = "Contact Name";
            gridColumnDescriptor3.MappingName = "ContactName";
            gridColumnDescriptor3.SerializedImageArray = "";
            gridColumnDescriptor4.HeaderImage = null;
            gridColumnDescriptor4.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor4.HeaderText = "Contact Title";
            gridColumnDescriptor4.MappingName = "ContactTitle";
            gridColumnDescriptor4.SerializedImageArray = "";
            gridColumnDescriptor5.HeaderImage = null;
            gridColumnDescriptor5.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor5.MappingName = "Address";
            gridColumnDescriptor5.SerializedImageArray = "";
            gridColumnDescriptor6.HeaderImage = null;
            gridColumnDescriptor6.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor6.MappingName = "City";
            gridColumnDescriptor6.SerializedImageArray = "";
            gridColumnDescriptor7.HeaderImage = null;
            gridColumnDescriptor7.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor7.MappingName = "Country";
            gridColumnDescriptor7.SerializedImageArray = "";
            this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            gridColumnDescriptor1,
            gridColumnDescriptor2,
            gridColumnDescriptor3,
            gridColumnDescriptor4,
            gridColumnDescriptor5,
            gridColumnDescriptor6,
            gridColumnDescriptor7});
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.VersionInfo = "4.201.0.37";
            // 
            // dataset11
            // 
            this.dataset11.DataSetName = "Dataset1";
            this.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(137, 25);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(7, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 25);
            this.button1.TabIndex = 29;
            this.button1.Text = "SortByContactName";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(137, 25);
            this.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(7, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 25);
            this.button2.TabIndex = 28;
            this.button2.Text = "SortByCity";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button3.BeforeTouchSize = new System.Drawing.Size(137, 25);
            this.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.IsBackStageButton = false;
            this.button3.Location = new System.Drawing.Point(7, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 25);
            this.button3.TabIndex = 27;
            this.button3.Text = "SortByCountry";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button4.BeforeTouchSize = new System.Drawing.Size(137, 25);
            this.button4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.IsBackStageButton = false;
            this.button4.Location = new System.Drawing.Point(7, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 25);
            this.button4.TabIndex = 30;
            this.button4.Text = "ClearSorting";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(856, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 606);
            this.panel1.TabIndex = 21;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxAdv1.Location = new System.Drawing.Point(866, 150);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(134, 30);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.DrawFocusRectangle = true;
            this.checkBoxAdv1.TabIndex = 26;
            this.checkBoxAdv1.Text = "Allow Sorting";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckedChanged += new System.EventHandler(this.checkBoxAdv1_CheckedChanged);
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(110, 21);
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboBoxAdv1.Location = new System.Drawing.Point(6, 38);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(110, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 24;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(110, 25);
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(6, 76);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(110, 25);
            this.buttonAdv1.TabIndex = 25;
            this.buttonAdv1.Text = "Align Icon";
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxAdv1);
            this.groupBox1.Controls.Add(this.buttonAdv1);
            this.groupBox1.Location = new System.Drawing.Point(866, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 120);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Align Sort Icon";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(859, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 274);
            this.panel2.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxAdv1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridGroupingControl1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Sorting ";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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

        #region ShowErrorMessage

        /// <summary>
        /// Display error messge for invalid cell values
        /// </summary>
        private static void ShowErrorMessage(SqlException ex)
        {
            if (ex.Number == 11001)
                MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 208)
                MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 156 || ex.Number == 102)
                MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
   
    }
}
