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
using System.Xml.Serialization;
using System.Runtime.Serialization;
using Syncfusion.Drawing;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace EmployeeView
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private EmployeeView.DataSet1 dataSet11;
        DataSet currentDataSet = null;
        private IContainer components;
        static XmlSerializer tableRecordFieldStylesSerializer;
        private GridGroupingControl gridGroupingControl1;
        private Panel panel1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv5;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv4;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv3;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private TableRecordFieldStylesCollection tableRecordFieldStyles = new TableRecordFieldStylesCollection();
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
            this.SampleCustomization();
            this.GridSettings();
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
			this.gridGroupingControl1.TableControl.DpiAware = true;
          
            //set the styles to the GridGroupingControl
            this.gridGroupingControl1.DataSource = currentDataSet.Tables[0];
            this.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;

            //set the caption color
            this.MetroColor = System.Drawing.Color.Transparent;
    
            this.gridGroupingControl1.TableDescriptor.Columns["PostalCode"].HeaderText = "Postal Code";
            this.gridGroupingControl1.TableDescriptor.Columns["FirstName"].HeaderText = "First Name";
            this.gridGroupingControl1.TableDescriptor.Columns["LastName"].HeaderText = "Last Name";
            this.gridGroupingControl1.TableDescriptor.Columns["TitleOfCourtesy"].HeaderText = "Title Of Courtesy";
            this.gridGroupingControl1.TableDescriptor.Columns["BirthDate"].HeaderText = "Birth Date";
            this.gridGroupingControl1.TableDescriptor.Columns["ReportsTo"].HeaderText = "Reports To";

            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = 25;
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = 30;
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = 35;

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;

        }

        #endregion

        #region "Sample customization"
        /// <summary>
        ///  set the dataset to GridGroupingControl using SqlCeDataAdapter.
        /// </summary>
        private void SampleCustomization()
        {
            currentDataSet = this.dataSet11.Clone();
            String commandstring = "select * from Employees";
                       
            SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring, connString);
            try
            {
                da.Fill(currentDataSet, "Employees");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }
        }
        
        /// <summary>
        /// Gets/Sets TableRecordFieldStylesCollection of GridGroupingControl
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        public TableRecordFieldStylesCollection TableRecordFieldStyles
        {
            get
            {
                return tableRecordFieldStyles;
            }
            set
            {
                tableRecordFieldStyles = value;
            }
        }

        /// <summary>
        /// Serialize and deserialize the objects into and from xml
        /// </summary>
        static XmlSerializer TableRecordFieldStylesSerializer
        {
            get
            {
                if (tableRecordFieldStylesSerializer == null)
                    tableRecordFieldStylesSerializer = new XmlSerializer(typeof(TableRecordFieldStylesCollection));
                return tableRecordFieldStylesSerializer;
            }
        }

        #region "Events"

        //Used to setup the cell-specific formatting information 
        private void gridGroupingControl1_QueryCellStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventArgs e)
        {
            switch (e.TableCellIdentity.TableCellType)
            {
                case GridTableCellType.RecordPreviewCell:
                    {
                        GridGroupingControl groupingControl = (GridGroupingControl)sender;
                        GridTable table = groupingControl.Table;
                        GridRecord record = (GridRecord)e.TableCellIdentity.DisplayElement.ParentRecord;
                        e.Style.CellValue = record.GetValue("Notes").ToString();
                        break;
                    }
                case GridTableCellType.AlternateRecordFieldCell:
                case GridTableCellType.AddNewRecordFieldCell:
                case GridTableCellType.RecordFieldCell:
                    {
                        GridTable table = e.TableCellIdentity.Table;
                        string tableName = table.TableDescriptor.Name;
                        GridRecord record = (GridRecord)e.TableCellIdentity.DisplayElement.ParentRecord;
                        object recordkey = record.PrimaryKeys[0];
                        string fieldName = e.TableCellIdentity.Column.MappingName;

                        GridStyleInfo style = GetCellStyle(tableName, recordkey, fieldName);
                        if (style != null)
                            e.Style.ModifyStyle(style, Syncfusion.Styles.StyleModifyType.Override);
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

        /// <summary>
        /// Get the styles through  the fieldname
        /// </summary>
        public GridStyleInfo GetCellStyle(string tableName, object primaryKey, string fieldName)
        {
            RecordFieldStylesCollection recordFieldStyles = TableRecordFieldStyles.GetRecordFieldStylesByTableName(tableName);
            if (recordFieldStyles != null)
            {
                FieldStyleCollection fieldStyles = recordFieldStyles.GetFieldStylesByRecordKey(primaryKey);
                if (fieldStyles != null)
                {
                    return fieldStyles.GetStyleByFieldName(fieldName);
                }
            }
            return null;
        }

        //used to initialize the custom styles to the GridGroupingControl
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.gridGroupingControl1.Appearance.AnyCell.ImageSizeMode = GridImageSizeMode.CenterImage;
            this.gridGroupingControl1.IntelliMousePanning = true;

            GridTable employeeTable = this.gridGroupingControl1.Table;
            GridTableDescriptor employeeTableDescriptor = this.gridGroupingControl1.TableDescriptor;

            RecordFieldStylesCollection employee = TableRecordFieldStyles.GetObject(this.gridGroupingControl1.TableDescriptor.Name);

            employee.GetObject(2).GetObject("LastName").BackColor = ColorConvert.ColorFromString("#84A1C3");
            employee.GetObject(2).GetObject("LastName").Font.Bold = true;
            employee.GetObject(1).GetObject("City").BackColor = ColorConvert.ColorFromString("#FF9933"); ;
            employee.GetObject(1).GetObject("City").Font.Italic = true;
            employee.GetObject(1).GetObject("Address").Interior = new BrushInfo(PatternStyle.OutlinedDiamond, ColorConvert.ColorFromString("#84A1C3"), ColorConvert.ColorFromString("#2a437e"));
            employee.GetObject(1).GetObject("Address").TextColor = Color.White;
            employee.GetObject(1).GetObject("Address").Font.Bold = true;
            employee.GetObject(1).GetObject("Address").Font.Size += 2;

            // see also gridGroupingControl1_QueryCellStyleInfo handler, 
            //	case GridTableCellType.AlternateRecordFieldCell:
            //	case GridTableCellType.AddNewRecordFieldCell:
            //	case GridTableCellType.RecordFieldCell:
        }

        //used to save all the files to the xml
        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            try
            {
                XmlTextWriter xw = new XmlTextWriter("TableRecordFieldStylesCollection.xml", System.Text.Encoding.UTF8);
                xw.Formatting = Formatting.Indented;
                TableRecordFieldStylesSerializer.Serialize(xw, TableRecordFieldStyles);
                xw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                XmlTextWriter xw = new XmlTextWriter("DataSet.xml", System.Text.Encoding.UTF8);
                xw.Formatting = Formatting.Indented;
                DataTable dt = this.gridGroupingControl1.DataSource as DataTable;
                dt.DataSet.WriteXml(xw, XmlWriteMode.WriteSchema);
                xw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                XmlTextWriter xw = new XmlTextWriter("LookAndFeel.xml", System.Text.Encoding.UTF8);
                xw.Formatting = Formatting.Indented;
                this.gridGroupingControl1.WriteXmlLookAndFeel(xw);
                xw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                XmlTextWriter xw = new XmlTextWriter("EngineSchema.xml", System.Text.Encoding.UTF8);
                xw.Formatting = Formatting.Indented;
                this.gridGroupingControl1.WriteXmlSchema(xw);
                xw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Saved to " + System.IO.Directory.GetCurrentDirectory());
        }

        //used to clear all the files
        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            TableRecordFieldStyles.Clear();
            this.currentDataSet.Clear();
            this.gridGroupingControl1.Refresh();
        }

        //used to restore all the files from xml
        private void buttonAdv4_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists("TableRecordFieldStylesCollection.xml"))
            {
                MessageBox.Show("Xml file does not exist. Please save to xml before trying to restore.");
                return;
            }

            try
            {
                XmlTextReader xr = new XmlTextReader("TableRecordFieldStylesCollection.xml");
                TableRecordFieldStyles = (TableRecordFieldStylesCollection)TableRecordFieldStylesSerializer.Deserialize(xr);
                xr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                XmlTextReader xr = new XmlTextReader("DataSet.xml");
                currentDataSet = new DataSet();
                currentDataSet.ReadXml(xr, XmlReadMode.ReadSchema);
                this.gridGroupingControl1.DataSource = currentDataSet.Tables[0];
                xr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                XmlTextReader xr = new XmlTextReader("EngineSchema.xml");
                this.gridGroupingControl1.ApplyXmlSchema(xr);
                xr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                XmlTextReader xr = new XmlTextReader("LookAndFeel.xml");
                this.gridGroupingControl1.ApplyXmlLookAndFeel(xr);
                xr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            this.gridGroupingControl1.Refresh();

            MessageBox.Show("Loaded from " + System.IO.Directory.GetCurrentDirectory());
        }

        //used to edit the custom styles into the GridGroupingControl
        private void buttonAdv5_Click(object sender, EventArgs e)
        {
            System.ComponentModel.Design.CollectionEditor ce = new System.ComponentModel.Design.CollectionEditor(this.tableRecordFieldStyles.GetType());
            Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer esc = new Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer(null);
            PropertyDescriptor pd = TypeDescriptor.GetProperties(this)["TableRecordFieldStyles"];
            Syncfusion.ComponentModel.TypeDescriptorContext tdc = new Syncfusion.ComponentModel.TypeDescriptorContext(this, pd);
            tdc.ServiceProvider = esc;

            ce.EditValue(tdc, esc, tableRecordFieldStyles);

            this.gridGroupingControl1.Refresh();
        }
        
        #endregion

        #endregion

        #region "Designer Stuffs"

        #region "FindFile"

        /// <summary>
        /// find the file from the specified location
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

        #region "ShowErrorMessage" Method
        /// <summary>
        /// Show the Error message while problem occurs
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
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor8 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor9 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor10 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor11 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor12 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor13 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor3 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor4 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor5 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor6 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor7 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            this.dataSet11 = new EmployeeView.DataSet1();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdv5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(21, 8);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(802, 634);
            this.gridGroupingControl1.TabIndex = 1;
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
            gridColumnDescriptor1.HeaderText = "ID";
            gridColumnDescriptor1.MappingName = "EmployeeID";
            gridColumnDescriptor1.SerializedImageArray = "";
            gridColumnDescriptor1.Width = 60;
            gridColumnDescriptor2.HeaderImage = null;
            gridColumnDescriptor2.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor2.MappingName = "FirstName";
            gridColumnDescriptor2.SerializedImageArray = "";
            gridColumnDescriptor2.Width = 115;
            gridColumnDescriptor3.HeaderImage = null;
            gridColumnDescriptor3.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor3.MappingName = "LastName";
            gridColumnDescriptor3.SerializedImageArray = "";
            gridColumnDescriptor4.HeaderImage = null;
            gridColumnDescriptor4.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor4.MappingName = "Address";
            gridColumnDescriptor4.SerializedImageArray = "";
            gridColumnDescriptor4.Width = 118;
            gridColumnDescriptor5.HeaderImage = null;
            gridColumnDescriptor5.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor5.MappingName = "City";
            gridColumnDescriptor5.SerializedImageArray = "";
            gridColumnDescriptor5.Width = 83;
            gridColumnDescriptor6.HeaderImage = null;
            gridColumnDescriptor6.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor6.MappingName = "PostalCode";
            gridColumnDescriptor6.SerializedImageArray = "";
            gridColumnDescriptor7.HeaderImage = null;
            gridColumnDescriptor7.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor7.MappingName = "Region";
            gridColumnDescriptor7.SerializedImageArray = "";
            gridColumnDescriptor7.Width = 80;
            gridColumnDescriptor8.HeaderImage = null;
            gridColumnDescriptor8.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor8.MappingName = "Country";
            gridColumnDescriptor8.SerializedImageArray = "";
            gridColumnDescriptor8.Width = 80;
            gridColumnDescriptor9.HeaderImage = null;
            gridColumnDescriptor9.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor9.MappingName = "BirthDate";
            gridColumnDescriptor9.SerializedImageArray = "";
            gridColumnDescriptor10.HeaderImage = null;
            gridColumnDescriptor10.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor10.MappingName = "Photo";
            gridColumnDescriptor10.SerializedImageArray = "";
            gridColumnDescriptor11.HeaderImage = null;
            gridColumnDescriptor11.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor11.MappingName = "ReportsTo";
            gridColumnDescriptor11.SerializedImageArray = "";
            gridColumnDescriptor12.HeaderImage = null;
            gridColumnDescriptor12.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor12.MappingName = "Title";
            gridColumnDescriptor12.SerializedImageArray = "";
            gridColumnDescriptor12.Width = 144;
            gridColumnDescriptor13.HeaderImage = null;
            gridColumnDescriptor13.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor13.MappingName = "TitleOfCourtesy";
            gridColumnDescriptor13.SerializedImageArray = "";
            gridColumnDescriptor13.Width = 133;
            this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            gridColumnDescriptor1,
            gridColumnDescriptor2,
            gridColumnDescriptor3,
            gridColumnDescriptor4,
            gridColumnDescriptor5,
            gridColumnDescriptor6,
            gridColumnDescriptor7,
            gridColumnDescriptor8,
            gridColumnDescriptor9,
            gridColumnDescriptor10,
            gridColumnDescriptor11,
            gridColumnDescriptor12,
            gridColumnDescriptor13});
            gridColumnSetDescriptor1.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("EmployeeID", "R0C0:R1C0")});
            gridColumnSetDescriptor1.Name = "ColumnSetId";
            gridColumnSetDescriptor2.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Photo", "R0C0:R1C0")});
            gridColumnSetDescriptor2.Name = "ColumnSetPhoto";
            gridColumnSetDescriptor3.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("FirstName", "R0C0"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("LastName", "R1C0")});
            gridColumnSetDescriptor3.Name = "ColumnSetName";
            gridColumnSetDescriptor4.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Address", "R0C0:R0C1"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("City", "R1C0"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("PostalCode", "R1C1")});
            gridColumnSetDescriptor4.Name = "ColumnSetAddress";
            gridColumnSetDescriptor5.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Region", "R0C0"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Country", "R1C0")});
            gridColumnSetDescriptor5.Name = "ColumnSetRegionCountry";
            gridColumnSetDescriptor6.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Title", "R0C0"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("TitleOfCourtesy", "R1C0")});
            gridColumnSetDescriptor6.Name = "ColumnSetTitle";
            gridColumnSetDescriptor7.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("BirthDate", "R0C0"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("ReportsTo", "R1C0")});
            gridColumnSetDescriptor7.Name = "ColumnSetBirth";
            this.gridGroupingControl1.TableDescriptor.ColumnSets.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor[] {
            gridColumnSetDescriptor1,
            gridColumnSetDescriptor2,
            gridColumnSetDescriptor3,
            gridColumnSetDescriptor4,
            gridColumnSetDescriptor5,
            gridColumnSetDescriptor6,
            gridColumnSetDescriptor7});
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20;
            this.gridGroupingControl1.TableOptions.RecordPreviewRowHeight = 60;
            this.gridGroupingControl1.TableOptions.RecordRowHeight = 30;
            this.gridGroupingControl1.TableOptions.ShowRecordPreviewRow = true;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonAdv5);
            this.panel1.Controls.Add(this.buttonAdv4);
            this.panel1.Controls.Add(this.buttonAdv3);
            this.panel1.Controls.Add(this.buttonAdv2);
            this.panel1.Controls.Add(this.buttonAdv1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(829, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 635);
            this.panel1.TabIndex = 2;
            // 
            // buttonAdv5
            // 
            this.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv5.FlatStyle = FlatStyle.Flat;
            this.buttonAdv5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv5.BeforeTouchSize = new System.Drawing.Size(151, 40);
            this.buttonAdv5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv5.ForeColor = System.Drawing.Color.White;
            this.buttonAdv5.IsBackStageButton = false;
            this.buttonAdv5.Location = new System.Drawing.Point(16, 215);
            this.buttonAdv5.Name = "buttonAdv5";
            this.buttonAdv5.Size = new System.Drawing.Size(151, 40);
            this.buttonAdv5.TabIndex = 6;
            this.buttonAdv5.Text = "Edit custom styles";
            this.buttonAdv5.Click += new System.EventHandler(this.buttonAdv5_Click);
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv4.FlatStyle = FlatStyle.Flat;
            this.buttonAdv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv4.BeforeTouchSize = new System.Drawing.Size(151, 40);
            this.buttonAdv4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv4.ForeColor = System.Drawing.Color.White;
            this.buttonAdv4.IsBackStageButton = false;
            this.buttonAdv4.Location = new System.Drawing.Point(16, 165);
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(151, 40);
            this.buttonAdv4.TabIndex = 5;
            this.buttonAdv4.Text = "Restore all from xml";
            this.buttonAdv4.Click += new System.EventHandler(this.buttonAdv4_Click);
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv3.FlatStyle = FlatStyle.Flat;
            this.buttonAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv3.BeforeTouchSize = new System.Drawing.Size(151, 40);
            this.buttonAdv3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv3.ForeColor = System.Drawing.Color.White;
            this.buttonAdv3.IsBackStageButton = false;
            this.buttonAdv3.Location = new System.Drawing.Point(16, 115);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(151, 40);
            this.buttonAdv3.TabIndex = 4;
            this.buttonAdv3.Text = "Clear all";
            this.buttonAdv3.Click += new System.EventHandler(this.buttonAdv3_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.FlatStyle = FlatStyle.Flat;
            this.buttonAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(151, 40);
            this.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv2.ForeColor = System.Drawing.Color.White;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(16, 65);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(151, 40);
            this.buttonAdv2.TabIndex = 3;
            this.buttonAdv2.Text = "Save all to xml";
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.FlatStyle = FlatStyle.Flat;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(151, 40);
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(16, 15);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(151, 40);
            this.buttonAdv1.TabIndex = 2;
            this.buttonAdv1.Text = "Initialize with custom styles";
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridGroupingControl1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Employee View ";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.panel1.ResumeLayout(false);
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
# if SyncfusionFramework1_1 || SyncfusionFramework2_0
            Application.EnableVisualStyles();
# endif
            Application.Run(new Form1());
        }
        #endregion     

    }
}
