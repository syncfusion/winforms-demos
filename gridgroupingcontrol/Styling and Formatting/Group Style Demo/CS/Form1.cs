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
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace StylesAtGroupLevel_2003
{
	public class Form1 : GridDemoForm
    {
        #region "API definition"

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
		private StylesAtGroupLevel_2003.Dataset1 dataset11;
		private System.ComponentModel.Container components = null;
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
        }

        #endregion
       
        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            #region "DataSource"

            String commandstring1 = "select * from Categories";
            String commandstring2 = "select * from Products";

            SqlCeDataAdapter da1 = new SqlCeDataAdapter(commandstring1, connString);
            SqlCeDataAdapter da2 = new SqlCeDataAdapter(commandstring2, connString);
            try
            {
                da1.Fill(dataset11, "Categories");
                da2.Fill(dataset11, "Products");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }

            #endregion

            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
			this.gridGroupingControl1.TableControl.DpiAware = true;

            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            this.MetroColor = System.Drawing.Color.Transparent;

            this.gridGroupingControl1.GridGroupDropArea.PrepareViewStyleInfo += new Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventHandler(GridGroupDropArea_PrepareViewStyleInfo);
            this.gridGroupingControl1.GroupDropPanel.BackColor = Color.FromArgb(255, 203, 146);
            this.gridGroupingControl1.Splitter.BackColor = Color.FromArgb(255, 203, 146);
            this.gridGroupingControl1.GridGroupDropArea.Model.Properties.BackgroundColor = Color.FromArgb(255, 203, 146);
            this.gridGroupingControl1.TableDescriptor.Columns["CategoryName"].HeaderText = "Category Name";
            this.gridGroupingControl1.TableDescriptor.Columns["CategoryID"].HeaderText = "Category ID";

            this.gridGroupingControl1.GridGroupDropArea.PrepareViewStyleInfo += new Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventHandler(GridGroupDropArea_PrepareViewStyleInfo);
            this.gridGroupingControl1.GroupDropPanel.BackColor = Color.FromArgb(255, 203, 146);
            this.gridGroupingControl1.Splitter.BackColor = Color.FromArgb(255, 203, 146);
            this.gridGroupingControl1.GridGroupDropArea.Model.Properties.BackgroundColor = Color.FromArgb(255, 203, 146);
        }

        #endregion
        
        #region "Designer Stuff"

        #region "Find Utility"

        /// <summary>
        /// Find file in specified location 
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

        #region Error message

        /// <summary>
        /// Display the error message
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
        /// <summary>
        /// Set the Backgrond color
        /// </summary>
        void GridGroupDropArea_PrepareViewStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs e)
        {
            e.Style.BackColor = Color.FromArgb(255, 203, 146);
        }

        #region "Dispose"

        // <summary>
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
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.dataset11 = new StylesAtGroupLevel_2003.Dataset1();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.Appearance.AnyGroupCell.Themed = false;
            this.gridGroupingControl1.Appearance.GroupCaptionCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(179)))), ((int)(((byte)(200))))));
            this.gridGroupingControl1.Appearance.GroupCaptionCell.CellTipText = "GroupCaptionCell";
            this.gridGroupingControl1.Appearance.GroupCaptionCell.Font.Bold = false;
            this.gridGroupingControl1.Appearance.GroupCaptionCell.Font.Facename = "Verdana";
            this.gridGroupingControl1.Appearance.GroupCaptionCell.Font.Italic = false;
            this.gridGroupingControl1.Appearance.GroupCaptionCell.Font.Size = 8.25F;
            this.gridGroupingControl1.Appearance.GroupCaptionCell.Font.Strikeout = false;
            this.gridGroupingControl1.Appearance.GroupCaptionCell.Font.Underline = false;
            this.gridGroupingControl1.Appearance.GroupCaptionCell.Font.Unit = System.Drawing.GraphicsUnit.Point;
            this.gridGroupingControl1.Appearance.GroupCaptionCell.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(173)))), ((int)(((byte)(208))))), System.Drawing.Color.White);
            this.gridGroupingControl1.Appearance.GroupCaptionCell.TextColor = System.Drawing.Color.Black;
            this.gridGroupingControl1.Appearance.GroupCaptionCell.Themed = false;
            this.gridGroupingControl1.Appearance.GroupCaptionPlusMinusCell.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.Window, System.Drawing.Color.Pink);
            this.gridGroupingControl1.Appearance.GroupCaptionPlusMinusCell.Themed = true;
            this.gridGroupingControl1.Appearance.GroupCaptionRowHeaderCell.CellTipText = "GroupCaptionRowHeader";
            this.gridGroupingControl1.Appearance.GroupCaptionRowHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.SystemColors.Window, System.Drawing.Color.DarkOrange);
            this.gridGroupingControl1.Appearance.GroupCaptionRowHeaderCell.Themed = false;
            this.gridGroupingControl1.Appearance.GroupHeaderRowHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Window, System.Drawing.Color.LightPink);
            this.gridGroupingControl1.Appearance.GroupHeaderRowHeaderCell.Themed = false;
            this.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Enabled = false;
            this.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Font.Bold = true;
            this.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Font.Facename = "Tahoma";
            this.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Font.Italic = false;
            this.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Font.Size = 8.25F;
            this.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Font.Strikeout = false;
            this.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Font.Underline = false;
            this.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Font.Unit = System.Drawing.GraphicsUnit.Point;
            this.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(190))))));
            this.gridGroupingControl1.Appearance.GroupHeaderSectionCell.MergeCell = Syncfusion.Windows.Forms.Grid.GridMergeCellDirection.None;
            this.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Themed = false;
            this.gridGroupingControl1.Appearance.GroupIndentLCell.AutoSize = true;
            this.gridGroupingControl1.Appearance.GroupIndentLCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Moccasin);
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.DataMember = "Categories";
            this.gridGroupingControl1.DataSource = this.dataset11;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(16, 16);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowGroupHeader = false;
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(980, 624);
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
            this.gridGroupingControl1.TableDescriptor.ChildGroupOptions.ShowCaptionSummaryCells = false;
            this.gridGroupingControl1.TableDescriptor.ChildGroupOptions.ShowColumnHeaders = true;
            this.gridGroupingControl1.TableDescriptor.ChildGroupOptions.ShowGroupFooter = false;
            this.gridGroupingControl1.TableDescriptor.ChildGroupOptions.ShowGroupHeader = true;
            this.gridGroupingControl1.TableDescriptor.ChildGroupOptions.ShowGroupPreview = false;
            this.gridGroupingControl1.TableDescriptor.ChildGroupOptions.ShowGroupSummaryWhenCollapsed = false;
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.AddRange(new Syncfusion.Grouping.SortColumnDescriptor[] {
            new Syncfusion.Grouping.SortColumnDescriptor("CategoryName", System.ComponentModel.ListSortDirection.Ascending),
            new Syncfusion.Grouping.SortColumnDescriptor("CategoryID", System.ComponentModel.ListSortDirection.Ascending)});
            this.gridGroupingControl1.TableDescriptor.SortedColumns.AddRange(new Syncfusion.Grouping.SortColumnDescriptor[] {
            new Syncfusion.Grouping.SortColumnDescriptor("CategoryID", System.ComponentModel.ListSortDirection.Ascending)});
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20;
            this.gridGroupingControl1.TableDescriptor.TopLevelGroupOptions.ShowCaptionPlusMinus = false;
            this.gridGroupingControl1.TableDescriptor.TopLevelGroupOptions.ShowGroupHeader = false;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229))))));
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = true;
            this.gridGroupingControl1.VersionInfo = "4.301.0.0";
            // 
            // dataset11
            // 
            this.dataset11.DataSetName = "Dataset1";
            this.dataset11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
			this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 654);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridGroupingControl1);
            this.Name = "Form1";
            this.Text = "Group Style";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).EndInit();
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
    }
}
