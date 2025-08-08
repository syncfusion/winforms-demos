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
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace DataBinding10_GGC
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region API Definition
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private DataBinding10_GGC.Dataset1 dataset11;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        #endregion

        #region Constructor
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

            //Reading Data from XML file
            ReadXml(this.dataset11, "DataToBind.xml");
            this.GridSettings();
            
        }
        #endregion

        #region Grid Settings

        /// <summary>
        /// Grid Settings for better Look and Feel
        /// </summary>
        private void GridSettings()
        {            
            this.gridGroupingControl1.TableControl.DpiAware = true;
			this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            //Used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            this.gridGroupingControl1.TableDescriptor.Columns["CompanyName"].HeaderText = "Company Name";
            this.gridGroupingControl1.TableDescriptor.Columns["HomePage"].HeaderText = "Home page";
            this.gridGroupingControl1.TableDescriptor.Columns["PostalCode"].HeaderText = "Postal Code";
            this.gridGroupingControl1.TableDescriptor.Columns["ContactName"].HeaderText = "Contact Name";
            this.gridGroupingControl1.TableDescriptor.Columns["ContactTitle"].HeaderText = "Contact Title";

        }

        #endregion        

        #region Read XML
        /// <summary>
        /// Reading data from the XML file
        /// </summary>
        /// <param name="ds">DataSet</param>
        /// <param name="xmlFileName">XML file</param>
        void ReadXml(DataSet ds, string xmlFileName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(xmlFileName))
                {
                    ds.ReadXml(xmlFileName);
                    break;
                }
                xmlFileName = @"..\" + xmlFileName;
            }
        }
        #endregion        

        #region Designer Stuffs
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor13 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.dataset11 = new DataBinding10_GGC.Dataset1();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.DataSource = this.dataset11.Suppliers;
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(24, 3);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(964, 628);
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
            gridColumnDescriptor13.HeaderImage = null;
            gridColumnDescriptor13.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor13.HeaderText = "Supplier ID";
            gridColumnDescriptor13.MappingName = "SupplierID";
            gridColumnDescriptor13.SerializedImageArray = "";
            gridColumnDescriptor14.HeaderImage = null;
            gridColumnDescriptor14.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor14.MappingName = "CompanyName";
            gridColumnDescriptor14.SerializedImageArray = "";
            gridColumnDescriptor15.HeaderImage = null;
            gridColumnDescriptor15.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor15.MappingName = "ContactName";
            gridColumnDescriptor15.SerializedImageArray = "";
            gridColumnDescriptor16.HeaderImage = null;
            gridColumnDescriptor16.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor16.MappingName = "ContactTitle";
            gridColumnDescriptor16.SerializedImageArray = "";
            gridColumnDescriptor17.HeaderImage = null;
            gridColumnDescriptor17.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor17.MappingName = "Address";
            gridColumnDescriptor17.SerializedImageArray = "";
            gridColumnDescriptor18.HeaderImage = null;
            gridColumnDescriptor18.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor18.MappingName = "City";
            gridColumnDescriptor18.SerializedImageArray = "";
            gridColumnDescriptor19.HeaderImage = null;
            gridColumnDescriptor19.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor19.MappingName = "Region";
            gridColumnDescriptor19.SerializedImageArray = "";
            gridColumnDescriptor20.HeaderImage = null;
            gridColumnDescriptor20.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor20.MappingName = "PostalCode";
            gridColumnDescriptor20.SerializedImageArray = "";
            gridColumnDescriptor21.HeaderImage = null;
            gridColumnDescriptor21.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor21.MappingName = "Country";
            gridColumnDescriptor21.SerializedImageArray = "";
            gridColumnDescriptor22.HeaderImage = null;
            gridColumnDescriptor22.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor22.MappingName = "Phone";
            gridColumnDescriptor22.SerializedImageArray = "";
            gridColumnDescriptor23.HeaderImage = null;
            gridColumnDescriptor23.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor23.MappingName = "Fax";
            gridColumnDescriptor23.SerializedImageArray = "";
            gridColumnDescriptor24.HeaderImage = null;
            gridColumnDescriptor24.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor24.MappingName = "HomePage";
            gridColumnDescriptor24.SerializedImageArray = "";
            this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            gridColumnDescriptor13,
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
            gridColumnDescriptor24});
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.VersionInfo = "4.200.0.60";
            // 
            // dataset11
            // 
            this.dataset11.DataSetName = "Dataset1";
            this.dataset11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Suppliers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
                        new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                        new System.Data.Common.DataColumnMapping("Fax", "Fax"),
                        new System.Data.Common.DataColumnMapping("HomePage", "HomePage")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_SupplierID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ContactName1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ContactTitle1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fax", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fax", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText");
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"),
            new System.Data.OleDb.OleDbParameter("ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactName"),
            new System.Data.OleDb.OleDbParameter("ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactTitle"),
            new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"),
            new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"),
            new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"),
            new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"),
            new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"),
            new System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"),
            new System.Data.OleDb.OleDbParameter("HomePage", System.Data.OleDb.OleDbType.VarWChar, 1073741823, "HomePage")});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region," +
                " PostalCode, Country, Phone, Fax, HomePage FROM Suppliers";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"),
            new System.Data.OleDb.OleDbParameter("ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactName"),
            new System.Data.OleDb.OleDbParameter("ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactTitle"),
            new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"),
            new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"),
            new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"),
            new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"),
            new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"),
            new System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"),
            new System.Data.OleDb.OleDbParameter("HomePage", System.Data.OleDb.OleDbType.VarWChar, 1073741823, "HomePage"),
            new System.Data.OleDb.OleDbParameter("Original_SupplierID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ContactName1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ContactTitle1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fax", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fax", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Select_SupplierID", System.Data.OleDb.OleDbType.Integer, 4, "SupplierID")});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 653);
            this.Controls.Add(this.gridGroupingControl1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Getting Started";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).EndInit();
            this.ResumeLayout(false);

        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }
        #region Dispose
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
        #endregion

    }
}
