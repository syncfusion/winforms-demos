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
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using DemoCommon.Grid;

namespace EmployeeView
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : GridDemoForm
    {
        #region Private Variables
        private EmployeeView.DataSet1 dataSet11;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private PropertyGrid propertyGrid1;
        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");
        #endregion

        #region Constructor
        /// <summary>
        ///  Form Constructor.
        /// </summary>
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            String commandstring = "select * from Employees";

            SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring, connString);
            try
            {
                da.Fill(dataSet11, "Employees");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }

            GridSettings();
            SampleCustomization();
        }
        #endregion

        #region Grid Settings

        /// <summary>
        /// Required Method for Grid Settings
        /// </summary>
        void GridSettings()
        {
            this.gridGroupingControl1.TableControl.DpiAware = true;
			this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana";
            this.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            // Header Text Name
            this.gridGroupingControl1.TableDescriptor.Columns["FirstName"].HeaderText = "First Name";
            this.gridGroupingControl1.TableDescriptor.Columns["LastName"].HeaderText = "Last Name";
            this.gridGroupingControl1.TableDescriptor.Columns["BirthDate"].HeaderText = "Birth Date";
            this.gridGroupingControl1.TableDescriptor.Columns["TitleOfCourtesy"].HeaderText = "Title Of Courtesy";
            this.gridGroupingControl1.TableDescriptor.Columns["ReportsTo"].HeaderText = "Reports To";
            this.gridGroupingControl1.TableDescriptor.Columns["PostalCode"].HeaderText = "Postal Code";

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }
        #endregion

        #region Sample Customization
        /// <summary>
        /// Required Method for sample level customization.
        /// </summary>
        void SampleCustomization()
        {
            this.gridGroupingControl1.Appearance.AnyCell.ImageSizeMode = GridImageSizeMode.CenterImage;
            this.gridGroupingControl1.IntelliMousePanning = true;
            this.gridGroupingControl1.TableControl.ResizingRows += new GridResizingRowsEventHandler(TableControl_ResizingRows);
        }

        #region Events

        // QueryCellInfo even is hooked to set the values.
        private void gridGroupingControl1_QueryCellStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventArgs e)
        {
            switch (e.TableCellIdentity.TableCellType)
            {
                case GridTableCellType.RecordPreviewCell:
                    {
                        GridGroupingControl groupingControl = (GridGroupingControl)sender;
                        GridTable table = groupingControl.Table;
                        GridRecord record = e.TableCellIdentity.DisplayElement.ParentRecord as GridRecord;
                        if (record != null)
                            e.Style.CellValue = record.GetValue("Notes").ToString();
                        else
                            e.Style.CellValue = "No Notes.";
                        break;
                    }
            }

            StringBuilder sb = new StringBuilder();

            sb.Append(e.TableCellIdentity.Info);

            if (e.Style != null)
            {
                sb.AppendFormat("\r\nCellType = {0}", e.Style.CellType);
                sb.AppendFormat(", CellValueType = {0}", e.Style.CellValueType);
                sb.AppendFormat(", nFormat = \"{0}\"", e.Style.Format);
                sb.AppendFormat(", CellValue = \"{0}\"", e.Style.CellValue);
                sb.AppendFormat(", ImageSizeMode = \"{0}\"", e.Style.ImageSizeMode);
            }
            e.Style.CellTipText = sb.ToString();
        }

        private void TableControl_ResizingRows(object sender, GridResizingRowsEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #endregion

        #region Designer Stuffs

        /// <summary>
        /// Gets the Icon File.
        /// </summary>  
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
        /// Gets the path for the sdf File.
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor14 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor15 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor16 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor17 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor18 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor19 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor20 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor21 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor22 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor23 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor24 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor25 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor26 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor8 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor9 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor10 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor11 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor12 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor13 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor14 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            this.dataSet11 = new EmployeeView.DataSet1();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.Appearance.AlternateRecordFieldCell.BaseStyle = "";
            this.gridGroupingControl1.Appearance.AlternateRecordFieldCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(219))))));
            this.gridGroupingControl1.Appearance.RecordPreviewCell.BaseStyle = "";
            this.gridGroupingControl1.Appearance.RecordPreviewCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(246))))));
            this.gridGroupingControl1.Appearance.RecordPreviewRowHeaderCell.BaseStyle = "";
            this.gridGroupingControl1.Appearance.RecordPreviewRowHeaderCell.CellType = "Static";
            this.gridGroupingControl1.Appearance.RecordPreviewRowHeaderCell.Enabled = false;
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordAfterDetails = true;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.DataSource = this.dataSet11.Employees;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(13, 15);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(685, 620);
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
            gridColumnDescriptor14.HeaderImage = null;
            gridColumnDescriptor14.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor14.HeaderText = "ID";
            gridColumnDescriptor14.MappingName = "EmployeeID";
            gridColumnDescriptor14.SerializedImageArray = "";
            gridColumnDescriptor14.Width = 60;
            gridColumnDescriptor15.HeaderImage = null;
            gridColumnDescriptor15.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor15.MappingName = "FirstName";
            gridColumnDescriptor15.SerializedImageArray = "";
            gridColumnDescriptor15.Width = 115;
            gridColumnDescriptor16.HeaderImage = null;
            gridColumnDescriptor16.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor16.MappingName = "LastName";
            gridColumnDescriptor16.SerializedImageArray = "";
            gridColumnDescriptor17.HeaderImage = null;
            gridColumnDescriptor17.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor17.MappingName = "Address";
            gridColumnDescriptor17.SerializedImageArray = "";
            gridColumnDescriptor17.Width = 118;
            gridColumnDescriptor18.HeaderImage = null;
            gridColumnDescriptor18.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor18.MappingName = "City";
            gridColumnDescriptor18.SerializedImageArray = "";
            gridColumnDescriptor18.Width = 83;
            gridColumnDescriptor19.HeaderImage = null;
            gridColumnDescriptor19.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor19.MappingName = "PostalCode";
            gridColumnDescriptor19.SerializedImageArray = "";
            gridColumnDescriptor20.HeaderImage = null;
            gridColumnDescriptor20.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor20.MappingName = "Region";
            gridColumnDescriptor20.SerializedImageArray = "";
            gridColumnDescriptor20.Width = 80;
            gridColumnDescriptor21.HeaderImage = null;
            gridColumnDescriptor21.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor21.MappingName = "Country";
            gridColumnDescriptor21.SerializedImageArray = "";
            gridColumnDescriptor21.Width = 80;
            gridColumnDescriptor22.HeaderImage = null;
            gridColumnDescriptor22.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor22.MappingName = "BirthDate";
            gridColumnDescriptor22.SerializedImageArray = "";
            gridColumnDescriptor23.HeaderImage = null;
            gridColumnDescriptor23.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor23.MappingName = "Photo";
            gridColumnDescriptor23.SerializedImageArray = "";
            gridColumnDescriptor24.HeaderImage = null;
            gridColumnDescriptor24.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor24.MappingName = "ReportsTo";
            gridColumnDescriptor24.SerializedImageArray = "";
            gridColumnDescriptor25.HeaderImage = null;
            gridColumnDescriptor25.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor25.MappingName = "Title";
            gridColumnDescriptor25.SerializedImageArray = "";
            gridColumnDescriptor25.Width = 144;
            gridColumnDescriptor26.HeaderImage = null;
            gridColumnDescriptor26.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor26.MappingName = "TitleOfCourtesy";
            gridColumnDescriptor26.SerializedImageArray = "";
            gridColumnDescriptor26.Width = 133;
            this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            gridColumnDescriptor14,
            gridColumnDescriptor15,
            gridColumnDescriptor16,
            gridColumnDescriptor17,
            gridColumnDescriptor18,
            gridColumnDescriptor19,
            gridColumnDescriptor20,
            gridColumnDescriptor21,
            gridColumnDescriptor22,
            gridColumnDescriptor23,
            gridColumnDescriptor24,
            gridColumnDescriptor25,
            gridColumnDescriptor26});
            gridColumnSetDescriptor8.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("EmployeeID", "R0C0:R1C0")});
            gridColumnSetDescriptor8.Name = "ColumnSetId";
            gridColumnSetDescriptor9.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Photo", "R0C0:R1C0")});
            gridColumnSetDescriptor9.Name = "ColumnSetPhoto";
            gridColumnSetDescriptor10.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("FirstName", "R0C0"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("LastName", "R1C0")});
            gridColumnSetDescriptor10.Name = "ColumnSetName";
            gridColumnSetDescriptor11.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Address", "R0C0:R0C1"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("City", "R1C0"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("PostalCode", "R1C1")});
            gridColumnSetDescriptor11.Name = "ColumnSetAddress";
            gridColumnSetDescriptor12.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Region", "R0C0"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Country", "R1C0")});
            gridColumnSetDescriptor12.Name = "ColumnSetRegionCountry";
            gridColumnSetDescriptor13.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Title", "R0C0"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("TitleOfCourtesy", "R1C0")});
            gridColumnSetDescriptor13.Name = "ColumnSetTitle";
            gridColumnSetDescriptor14.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("BirthDate", "R0C0"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("ReportsTo", "R1C0")});
            gridColumnSetDescriptor14.Name = "ColumnSetBirth";
            this.gridGroupingControl1.TableDescriptor.ColumnSets.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor[] {
            gridColumnSetDescriptor8,
            gridColumnSetDescriptor9,
            gridColumnSetDescriptor10,
            gridColumnSetDescriptor11,
            gridColumnSetDescriptor12,
            gridColumnSetDescriptor13,
            gridColumnSetDescriptor14});
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20;
            this.gridGroupingControl1.TableOptions.RecordPreviewRowHeight = 60;
            this.gridGroupingControl1.TableOptions.RecordRowHeight = 30;
            this.gridGroupingControl1.TableOptions.ShowRecordPreviewRow = true;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = true;
            this.gridGroupingControl1.QueryCellStyleInfo += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventHandler(this.gridGroupingControl1_QueryCellStyleInfo);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(704, 15);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(292, 620);
            this.propertyGrid1.TabIndex = 9;
            // 
            // Form1
            // 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 656); 
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.gridGroupingControl1);
            this.Name = "Form1";
            this.Text = "Record Customization";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.ResumeLayout(false);

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
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
        #endregion

    }
}
