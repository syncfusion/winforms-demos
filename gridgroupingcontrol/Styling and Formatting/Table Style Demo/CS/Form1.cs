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
using Syncfusion.Drawing;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace StylesAtTableLevel_2003
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
		private StylesAtTableLevel_2003.Dataset1 dataset11;
		private System.ComponentModel.Container components = null;
        private Panel panel1;
        private PropertyGrid propertyGrid1;

        #region "Data Source"

        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");

        #endregion

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
            #region "Data Source"

            String commandstring1 = "select * from Customers";
            String commandstring2 = "select * from Orders";

            SqlCeDataAdapter da1 = new SqlCeDataAdapter(commandstring1, connString);
            SqlCeDataAdapter da2 = new SqlCeDataAdapter(commandstring2, connString);
            try
            {
                da1.Fill(dataset11, "Customers");
                da2.Fill(dataset11, "Orders");
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
            //ColumnName
            this.gridGroupingControl1.TableDescriptor.Columns["CompanyName"].HeaderText = "Company Name";
            this.gridGroupingControl1.TableDescriptor.Columns["CustomerID"].HeaderText = "Customer ID";
            this.gridGroupingControl1.TableDescriptor.Columns["ContactName"].HeaderText = "Contact Name";
            this.gridGroupingControl1.TableDescriptor.Columns["ContactTitle"].HeaderText = "Contact Title";
            this.gridGroupingControl1.TableDescriptor.Columns["PostalCode"].HeaderText = "Postal Code";


            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion
   
        #region "Sample Customized"

        #region Form "Event"

        /// <summary>
        /// Set theApperance for GridTable
        /// </summary>
        private void Form1_Load(object sender, System.EventArgs e)
        {
            GridTableDescriptor gtd = this.gridGroupingControl1.GetTableDescriptor("Orders");
            gtd.Appearance.AnyRecordFieldCell.BackColor = Color.FromArgb(223, 247, 252);
            gtd.Appearance.AlternateRecordFieldCell.BackColor = Color.FromArgb(255, 229, 201);
            gtd.Appearance.ColumnHeaderCell.Interior = new BrushInfo(GradientStyle.Vertical, Color.FromArgb(203, 201, 202), Color.FromArgb(253, 247, 215));
            gtd.Appearance.ColumnHeaderCell.TextColor = Color.Black;
            gtd.Appearance.GroupCaptionCell.Interior = new BrushInfo(Color.FromArgb(255, 238, 220));
            gtd.Appearance.GroupCaptionCell.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(242, 158, 32), GridBorderWeight.Medium);

        }

        #endregion

         #endregion

        #region "Designer Stuff"

        #region "Find Utility"

        /// <summary>
        /// Find the data file in specified location
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

        #region "Error Message"

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

        #region "Dispose"

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

        #region "Windows Form Designer generated code"

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.dataset11 = new StylesAtTableLevel_2003.Dataset1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.Appearance.ColumnHeaderCell.CellTipText = "ColumnHeader";
            this.gridGroupingControl1.Appearance.ColumnHeaderCell.Font.Bold = false;
            this.gridGroupingControl1.Appearance.ColumnHeaderCell.Font.Facename = "Tahoma";
            this.gridGroupingControl1.Appearance.ColumnHeaderCell.Font.Italic = false;
            this.gridGroupingControl1.Appearance.ColumnHeaderCell.Font.Size = 8.25F;
            this.gridGroupingControl1.Appearance.ColumnHeaderCell.Font.Strikeout = false;
            this.gridGroupingControl1.Appearance.ColumnHeaderCell.Font.Underline = false;
            this.gridGroupingControl1.Appearance.ColumnHeaderCell.Font.Unit = System.Drawing.GraphicsUnit.Point;
            this.gridGroupingControl1.Appearance.ColumnHeaderCell.TextColor = System.Drawing.Color.Red;
            this.gridGroupingControl1.Appearance.ColumnHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(232))))), System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(151))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.TextColor = Color.White;
            this.gridGroupingControl1.Appearance.ColumnHeaderCell.Themed = false;
            this.gridGroupingControl1.Appearance.GroupCaptionCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(159)))), ((int)(((byte)(153))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.Medium);
            this.gridGroupingControl1.Appearance.GroupCaptionCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(224))))));
            this.gridGroupingControl1.Appearance.GroupCaptionCell.Themed = false;
            this.gridGroupingControl1.Appearance.NestedTableCell.CellAppearance = Syncfusion.Windows.Forms.Grid.GridCellAppearance.Raised;
            this.gridGroupingControl1.Appearance.NestedTableCell.CellTipText = "OrderDetails";
            this.gridGroupingControl1.Appearance.NestedTableCell.Font.Bold = true;
            this.gridGroupingControl1.Appearance.NestedTableCell.Font.Facename = "Arial";
            this.gridGroupingControl1.Appearance.NestedTableCell.Font.Italic = false;
            this.gridGroupingControl1.Appearance.NestedTableCell.Font.Size = 8.25F;
            this.gridGroupingControl1.Appearance.NestedTableCell.Font.Strikeout = false;
            this.gridGroupingControl1.Appearance.NestedTableCell.Font.Underline = false;
            this.gridGroupingControl1.Appearance.NestedTableCell.Font.Unit = System.Drawing.GraphicsUnit.Point;
            this.gridGroupingControl1.Appearance.NestedTableCell.Format = "";
            this.gridGroupingControl1.Appearance.NestedTableCell.ImageFromByteArray = true;
            this.gridGroupingControl1.Appearance.NestedTableCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(213)))), ((int)(((byte)(231))))));
            this.gridGroupingControl1.Appearance.NestedTableCell.TextColor = System.Drawing.Color.Brown;
            this.gridGroupingControl1.Appearance.NestedTableCell.Themed = true;
            this.gridGroupingControl1.Appearance.NestedTableRowHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(213)))), ((int)(((byte)(231))))));
            this.gridGroupingControl1.Appearance.NestedTableRowHeaderCell.Themed = false;
            this.gridGroupingControl1.Appearance.RecordFieldCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Lavender);
            this.gridGroupingControl1.Appearance.RecordPlusMinusCell.Font.Bold = true;
            this.gridGroupingControl1.Appearance.RecordPlusMinusCell.Font.Facename = "Tahoma";
            this.gridGroupingControl1.Appearance.RecordPlusMinusCell.Font.Italic = false;
            this.gridGroupingControl1.Appearance.RecordPlusMinusCell.Font.Size = 8.25F;
            this.gridGroupingControl1.Appearance.RecordPlusMinusCell.Font.Strikeout = false;
            this.gridGroupingControl1.Appearance.RecordPlusMinusCell.Font.Underline = false;
            this.gridGroupingControl1.Appearance.RecordPlusMinusCell.Font.Unit = System.Drawing.GraphicsUnit.Point;
            this.gridGroupingControl1.Appearance.RecordPlusMinusCell.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.Window, System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(222))))));
            this.gridGroupingControl1.Appearance.RecordPlusMinusCell.Themed = true;
            this.gridGroupingControl1.Appearance.RowHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.SystemColors.Window, System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(213)))), ((int)(((byte)(231))))));
            this.gridGroupingControl1.Appearance.RowHeaderCell.Themed = false;
            this.gridGroupingControl1.Appearance.TopLeftHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.Window, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(221))))));
            this.gridGroupingControl1.Appearance.TopLeftHeaderCell.Themed = false;
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.DataMember = "Customers";
            this.gridGroupingControl1.DataSource = this.dataset11;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridGroupingControl1.FreezeCaption = false;
            //this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            //this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(12, 12);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.Size = new System.Drawing.Size(776, 628);
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
            this.gridGroupingControl1.TableDescriptor.SortedColumns.AddRange(new Syncfusion.Grouping.SortColumnDescriptor[] {
            new Syncfusion.Grouping.SortColumnDescriptor("CompanyName", System.ComponentModel.ListSortDirection.Descending)});
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(220))))));
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.VersionInfo = "4.301.0.0";
            // 
            // dataset11
            // 
            this.dataset11.DataSetName = "Dataset1";
            this.dataset11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(792, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 607);
            this.panel1.TabIndex = 22;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(799, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            this.propertyGrid1.Size = new System.Drawing.Size(203, 628);
            this.propertyGrid1.TabIndex = 21;
            // 
            // Form1
            // 
			this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 654);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.gridGroupingControl1);
            this.Name = "Form1";
            this.Text = "Styles At Table Level";
            this.Load += new System.EventHandler(this.Form1_Load);
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
