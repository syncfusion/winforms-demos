#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Grouping;
using System.Runtime.InteropServices;
using DemoCommon.Grid;
using Syncfusion.Collections;

namespace Grouping_GGC
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private ArrayList array = new ArrayList();
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private Grouping_GGC.Dataset1 dataset11;
        private Panel panel1;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private Label label1;
        private CheckBoxAdv checkBox4;
        private GroupBox groupBox1;
        private ColorPickerButton colorPickerButton1;
        private CheckBoxAdv checkBox3;
        private CheckBoxAdv checkBox2;
        private CheckBoxAdv checkBox1;
        private ToolTip toolTip1;
        private CheckBoxAdv checkBoxAdv;
        private Label label2;
        private ComboBoxAdv comboBox1;
        private Label label3;
        private CheckBoxAdv checkBoxAdv1;
        private CheckBoxAdv checkBoxAdv2;
        private IContainer components;

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
            //this.oleDbDataAdapter1.Fill(this.dataset11);   
            ReadXml(this.dataset11, "Grouping_GGCdata.xml");

            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
			this.gridGroupingControl1.TableControl.DpiAware = true;

            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;

            //Set GridVisualStyles as metro
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;

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
            //Load CheckBox settings
            CheckBoxSettings();

            //Hook the ComboBox Selected Items Changed Event
            this.comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);

            //Display GroupDropArea with the Grouped columns in a Hierarchical structue
            this.gridGroupingControl1.HierarchicalGroupDropArea = true;

            //Support to remove the column dynamically from being grouped  
            this.gridGroupingControl1.GridGroupDropArea.AllowRemove = true;

            //Support to resize the GroupDropArea dynamically till the last level of Hierarchy
            this.gridGroupingControl1.GridGroupDropArea.DynamicResizing = true;

            //Hook GroupedColumns.Changed event to notify the changes in the GroupedColumns collection
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Changed += new Syncfusion.Collections.ListPropertyChangedEventHandler(GroupedColumns_Changed);
            this.colorPickerButton1.ColorSelected += new EventHandler(colorPickerButton1_ColorSelected);

            //Expand all records
            this.gridGroupingControl1.Table.ExpandAllRecords();
        }

        #endregion

        #region "Designer Stuffs"

        #region "Header Images"
        /// <summary>
        /// Getting image from the file
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

        #endregion

        #region "ReadXml"

        /// <summary>
        /// Read xml file to set the datasource
        /// </summary>
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

        #region "Dispose"
        /// <summary>
        /// dispose all the components when form is closed
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
            this.dataset11 = new Grouping_GGC.Dataset1();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxAdv = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.checkBox3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            this.SuspendLayout();
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
            new System.Data.Common.DataTableMapping("Table", "Employees", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("Title", "Title"),
                        new System.Data.Common.DataColumnMapping("BirthDate", "BirthDate"),
                        new System.Data.Common.DataColumnMapping("HireDate", "HireDate"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("HomePhone", "HomePhone")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_BirthDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_BirthDate1", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_HireDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_HireDate1", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_HomePhone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"),
            new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"),
            new System.Data.OleDb.OleDbParameter("BirthDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, "BirthDate"),
            new System.Data.OleDb.OleDbParameter("HireDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, "HireDate"),
            new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"),
            new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"),
            new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"),
            new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"),
            new System.Data.OleDb.OleDbParameter("HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, "HomePhone")});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT EmployeeID, LastName, FirstName, Title, BirthDate, HireDate, Address, City" +
                ", Region, PostalCode, Country, HomePhone FROM Employees";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"),
            new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"),
            new System.Data.OleDb.OleDbParameter("BirthDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, "BirthDate"),
            new System.Data.OleDb.OleDbParameter("HireDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, "HireDate"),
            new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"),
            new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"),
            new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"),
            new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"),
            new System.Data.OleDb.OleDbParameter("HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, "HomePhone"),
            new System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_BirthDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_BirthDate1", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_HireDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_HireDate1", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_HomePhone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Select_EmployeeID", System.Data.OleDb.OleDbType.Integer, 4, "EmployeeID")});
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridGroupingControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 465);
            this.panel1.TabIndex = 0;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.DataSource = this.dataset11.Employees;
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.Location = new System.Drawing.Point(3, 3);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(656, 458);
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
            gridColumnDescriptor1.HeaderImage = null;
            gridColumnDescriptor1.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor1.HeaderText = "Employee ID";
            gridColumnDescriptor1.MappingName = "EmployeeID";
            gridColumnDescriptor1.SerializedImageArray = "";
            gridColumnDescriptor2.HeaderImage = null;
            gridColumnDescriptor2.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor2.HeaderText = "Last Name";
            gridColumnDescriptor2.MappingName = "LastName";
            gridColumnDescriptor2.SerializedImageArray = "";
            gridColumnDescriptor3.HeaderImage = null;
            gridColumnDescriptor3.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor3.HeaderText = "First Name";
            gridColumnDescriptor3.MappingName = "FirstName";
            gridColumnDescriptor3.SerializedImageArray = "";
            gridColumnDescriptor4.HeaderImage = null;
            gridColumnDescriptor4.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor4.MappingName = "Title";
            gridColumnDescriptor4.SerializedImageArray = "";
            gridColumnDescriptor5.HeaderImage = null;
            gridColumnDescriptor5.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor5.HeaderText = "Birth Date";
            gridColumnDescriptor5.MappingName = "BirthDate";
            gridColumnDescriptor5.SerializedImageArray = "";
            gridColumnDescriptor6.HeaderImage = null;
            gridColumnDescriptor6.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor6.HeaderText = "Hire Date";
            gridColumnDescriptor6.MappingName = "HireDate";
            gridColumnDescriptor6.SerializedImageArray = "";
            gridColumnDescriptor7.HeaderImage = null;
            gridColumnDescriptor7.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor7.MappingName = "Address";
            gridColumnDescriptor7.SerializedImageArray = "";
            gridColumnDescriptor8.HeaderImage = null;
            gridColumnDescriptor8.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor8.MappingName = "City";
            gridColumnDescriptor8.SerializedImageArray = "";
            gridColumnDescriptor9.HeaderImage = null;
            gridColumnDescriptor9.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor9.MappingName = "Region";
            gridColumnDescriptor9.SerializedImageArray = "";
            gridColumnDescriptor10.HeaderImage = null;
            gridColumnDescriptor10.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor10.HeaderText = "Postal Code";
            gridColumnDescriptor10.MappingName = "PostalCode";
            gridColumnDescriptor10.SerializedImageArray = "";
            gridColumnDescriptor11.HeaderImage = null;
            gridColumnDescriptor11.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor11.MappingName = "Country";
            gridColumnDescriptor11.SerializedImageArray = "";
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
            gridColumnDescriptor11});
            this.gridGroupingControl1.TableDescriptor.PrimaryKeyColumns.AddRange(new Syncfusion.Grouping.SortColumnDescriptor[] {
            new Syncfusion.Grouping.SortColumnDescriptor("EmployeeID", System.ComponentModel.ListSortDirection.Ascending)});
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please check tooltip for corresponding codes";
            // 
            // checkBox4
            // 
            this.checkBox4.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.DrawFocusRectangle = false;
            this.checkBox4.Location = new System.Drawing.Point(28, 28);
            this.checkBox4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(174, 35);
            this.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox4.DrawFocusRectangle = true;
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Hierarchical GroupDrop Area";
            this.checkBox4.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.checkBox4, "this.gridGroupingControl1.HierarchicalGroupDropArea");
            this.checkBox4.CheckStateChanged += new System.EventHandler(this.checkBox4_CheckStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxAdv2);
            this.groupBox1.Controls.Add(this.checkBoxAdv1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBoxAdv);
            this.groupBox1.Controls.Add(this.colorPickerButton1);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(680, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 443);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.BeforeTouchSize = new System.Drawing.Size(127, 22);
            this.checkBoxAdv2.Location = new System.Drawing.Point(28, 357);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(127, 22);
            this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv2.DrawFocusRectangle = true;
            this.checkBoxAdv2.TabIndex = 16;
            this.checkBoxAdv2.Text = "Enable Touch Mode";
            this.checkBoxAdv2.ThemesEnabled = false;
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.Location = new System.Drawing.Point(28, 169);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(162, 26);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.DrawFocusRectangle = true;
            this.checkBoxAdv1.TabIndex = 7;
            this.checkBoxAdv1.Text = "Show Images in Header";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.checkBoxAdv1, "this.gridGroupingControl1.TableDescriptor.Columns[Column].HeaderImage = Image.Fro" +
                    "mFile(GetIconFile(ImageLocation))");
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(76, 21);
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Items.AddRange(new object[] {
            "Top",
            "Left",
            "Bottom",
            "Right"});
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "Top"));
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "Left"));
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "Bottom"));
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "Right"));
            this.comboBox1.Location = new System.Drawing.Point(145, 383);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 21);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 17;
            this.toolTip1.SetToolTip(this.comboBox1, "GroupDrop Alignment works only when Hierarchial GroupDrop Area is set to false");
            this.comboBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "GroupDrop Alignment";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 87);
            this.label2.TabIndex = 14;
            this.label2.Text = "The Tree Line Color is used to set the line color for the Grid\'s header cells in " +
                "hierarchical GroupDropArea  \r\n\r\nGridGroupDropArea.TreeLineColor = Color.White;";
            // 
            // checkBoxAdv
            // 
            this.checkBoxAdv.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv.Location = new System.Drawing.Point(28, 332);
            this.checkBoxAdv.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv.Name = "checkBoxAdv";
            this.checkBoxAdv.Size = new System.Drawing.Size(135, 29);
            this.checkBoxAdv.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv.DrawFocusRectangle = true;
            this.checkBoxAdv.TabIndex = 9;
            this.checkBoxAdv.Text = "Merge Cells";
            this.checkBoxAdv.ThemesEnabled = false;
            this.checkBoxAdv.CheckStateChanged += new System.EventHandler(this.checkBoxAdv_CheckStateChanged);
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(135, 23);
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(20, 205);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.Size = new System.Drawing.Size(135, 23);
            this.colorPickerButton1.TabIndex = 8;
            this.colorPickerButton1.Text = "TreeLine Color";
            this.toolTip1.SetToolTip(this.colorPickerButton1, "this.gridGroupingControl1.GridGroupDropArea.TreeLineColor");
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(28, 133);
            this.checkBox3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(136, 30);
            this.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox3.DrawFocusRectangle = true;
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Dynamic Resizing";
            this.checkBox3.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.checkBox3, "this.gridGroupingControl1.GridGroupDropArea.DynamicResizing");
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.checkBox3_CheckStateChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox2.Location = new System.Drawing.Point(28, 98);
            this.checkBox2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(172, 36);
            this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox2.DrawFocusRectangle = true;
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "TreeLinePlacement at Top";
            this.checkBox2.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.checkBox2, "this.gridGroupingControl1.GridGroupDropArea.TreeLinePlacement");
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckStateChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(28, 66);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 33);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.DrawFocusRectangle = true;
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Remove Group";
            this.checkBox1.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.checkBox1, "this.gridGroupingControl1.GridGroupDropArea.AllowRemove");
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Grouping ";
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }

        #endregion

        #region "Event Handlers"

        #region Event Handler for GroupedColumns_Changed

        /// <summary>
        /// Add the GropedColumn names to the array collection
        /// </summary>
        void GroupedColumns_Changed(object sender, Syncfusion.Collections.ListPropertyChangedEventArgs e)
        {
            if (e.Item != null)
            {
                SortColumnDescriptor item = (SortColumnDescriptor)e.Item;
                if (e.Action == ListPropertyChangedType.Remove)
                {
                    //Remove Grouped Column names in Array
                    if (array.Contains(item.Name))
                        array.Remove(item.Name);
                }
                else
                {
                    //Add Grouped Column names in Array
                    if (!array.Contains(item.Name))
                        array.Add(item.Name);
                }
            }
        }

        #endregion

        #region Event Handlers related with Hierarchical GroupDrop Area

        /// <summary>
        /// Set TreeLineColor
        /// </summary>
        void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            //Set the TreeLineColor for the GroupDropArea
            this.gridGroupingControl1.GridGroupDropArea.TreeLineColor = this.colorPickerButton1.SelectedColor;
            this.gridGroupingControl1.Refresh();
        }

        //Set the AllowRemove option in the GroupDropArea
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            //Set the AllowRemove option in the GroupDropArea
            this.gridGroupingControl1.GridGroupDropArea.AllowRemove = !this.gridGroupingControl1.GridGroupDropArea.AllowRemove;
            this.gridGroupingControl1.Refresh();
        }

        //Setting the TreeLinePlacement
        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            
            if (this.gridGroupingControl1.GridGroupDropArea.TreeLinePlacement == TreeLinePlacement.Bottom)
                this.gridGroupingControl1.GridGroupDropArea.TreeLinePlacement = TreeLinePlacement.Top;
            else
                this.gridGroupingControl1.GridGroupDropArea.TreeLinePlacement = TreeLinePlacement.Bottom;
            this.gridGroupingControl1.Refresh();
        }

        bool hasGroupedColumns = false;

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.gridGroupingControl1.TableDescriptor.GroupedColumns.Count > 0)
                hasGroupedColumns = true;
            else
                hasGroupedColumns = false;
            LockWindowUpdate(this.Handle);
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
            //Set DynamicResizing value
            this.gridGroupingControl1.GridGroupDropArea.DynamicResizing = !this.gridGroupingControl1.GridGroupDropArea.DynamicResizing;
            this.gridGroupingControl1.SuspendLayout();
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
            if (hasGroupedColumns)
            {
                for (int i = 0; i < array.Count; i++)
                {
                    //Adding column names to the GroupedColumns collection
                    this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add(array[i].ToString());
                }
            }
            this.gridGroupingControl1.ResumeLayout();
            this.gridGroupingControl1.Refresh();
            LockWindowUpdate(IntPtr.Zero);
        }

        /// <summary>
        /// Set the HirarchicalGroupDropArea Visibility
        /// </summary>
        private void checkBox4_CheckStateChanged(object sender, EventArgs e)
        {
            LockWindowUpdate(this.Handle);
            this.gridGroupingControl1.BeginUpdate();
            //Set HirarchicalGroupDropArea visibilty
            this.gridGroupingControl1.HierarchicalGroupDropArea = !this.gridGroupingControl1.HierarchicalGroupDropArea;
            if (this.gridGroupingControl1.HierarchicalGroupDropArea)
            {
                comboBox1.Visible = false;
                label3.Visible = false;
            }
            else
            {
                comboBox1.Visible = true;
                comboBox1.SelectedIndex = 0;
                label3.Visible = true;
            }
            this.gridGroupingControl1.EndUpdate(true);
            CheckBoxSettings();
            LockWindowUpdate(IntPtr.Zero);
        }

        /// <summary>
        /// Setting the ComboBox values
        /// </summary>
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox();
        }

        #region GroupDropArea Alignments

        //Setting GroupDrop Area Alignments
        private void ComboBox()
        {
            switch (this.comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        this.gridGroupingControl1.GroupDropAreaAlignment = Syncfusion.Windows.Forms.Grid.Grouping.GridGroupDropAreaAlignment.Top;
                        break;
                    }
                case 1:
                    {
                        this.gridGroupingControl1.GroupDropAreaAlignment = Syncfusion.Windows.Forms.Grid.Grouping.GridGroupDropAreaAlignment.Left;

                        break;
                    }
                case 2:
                    {
                        this.gridGroupingControl1.GroupDropAreaAlignment = Syncfusion.Windows.Forms.Grid.Grouping.GridGroupDropAreaAlignment.Bottom;
                        break;
                    }
                case 3:
                    {
                        this.gridGroupingControl1.GroupDropAreaAlignment = Syncfusion.Windows.Forms.Grid.Grouping.GridGroupDropAreaAlignment.Right;
                        break;
                    }
            }
        }

        #endregion

        // To set the font styles
        private void CheckBoxSettings()
        {
            //Eable or Disable the options
            if (!this.checkBox4.Checked)
            {
                this.checkBox2.Enabled = false;
                this.checkBox2.Font = new Font("Segoe UI", 8.25F, FontStyle.Strikeout);
                this.checkBox3.Enabled = false;
                this.checkBox3.Font = new Font("Segoe UI", 8.25F, FontStyle.Strikeout);
                this.colorPickerButton1.Enabled = false;
                this.colorPickerButton1.Font = new Font("Segoe UI", 8.25F, FontStyle.Strikeout);
            }
            else
            {
                this.checkBox2.Enabled = true;
                this.checkBox2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular);
                this.checkBox3.Enabled = true;
                this.checkBox3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular);
                this.colorPickerButton1.Enabled = true;
                this.colorPickerButton1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular);
            }
        }

        #endregion

        #region Event Handler for Merge Cells Layout

        //Set Merging Properties
        private void checkBoxAdv_CheckStateChanged(object sender, EventArgs e)
        {           
            if (this.checkBoxAdv.Checked)
            {
                this.gridGroupingControl1.BeginUpdate();
                this.gridGroupingControl1.TableDescriptor.Columns["Title"].Appearance.AnyRecordFieldCell.MergeCell = GridMergeCellDirection.Both;
                this.gridGroupingControl1.TableModel.Options.MergeCellsMode = GridMergeCellsMode.OnDemandCalculation | GridMergeCellsMode.MergeRowsInColumn | GridMergeCellsMode.MergeColumnsInRow;
                this.gridGroupingControl1.TableModel.Options.MergeCellsLayout = GridMergeCellsLayout.Grid;
                this.gridGroupingControl1.TableModel.MergeCells.EvaluateMergeCells(this.gridGroupingControl1.TableControl.GridCellsRange);
                this.gridGroupingControl1.EndUpdate(true);
                this.gridGroupingControl1.Refresh();
            }
            else
            {
                this.gridGroupingControl1.BeginUpdate();
                this.gridGroupingControl1.TableDescriptor.Columns["Title"].Appearance.AnyRecordFieldCell.MergeCell = GridMergeCellDirection.None;
                this.gridGroupingControl1.TableModel.Options.MergeCellsMode = GridMergeCellsMode.None;
                this.gridGroupingControl1.TableModel.Options.MergeCellsLayout = GridMergeCellsLayout.Grid;
                this.gridGroupingControl1.TableModel.MergeCells.EvaluateMergeCells(this.gridGroupingControl1.TableControl.GridCellsRange);
                this.gridGroupingControl1.EndUpdate(true);
                this.gridGroupingControl1.Refresh();
            }
        }
        #endregion

        #region Event Handler for image in headers

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool LockWindowUpdate(IntPtr hWndLock);
        //Setting Header Image
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv1.Checked)
            {
                this.gridGroupingControl1.BeginUpdate();                
                this.gridGroupingControl1.TableDescriptor.Columns["EmployeeID"].HeaderImage = Image.FromFile(GetIconFile(@"Common\Images\Grid\HeaderImages\ID.PNG"));
                this.gridGroupingControl1.TableDescriptor.Columns["EmployeeID"].HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Right;
                this.gridGroupingControl1.TableDescriptor.Columns["BirthDate"].HeaderImage = Image.FromFile(GetIconFile(@"Common\Images\Grid\HeaderImages\Date.PNG"));
                this.gridGroupingControl1.TableDescriptor.Columns["HireDate"].HeaderImage = Image.FromFile(GetIconFile(@"Common\Images\Grid\HeaderImages\Date.PNG"));
                this.gridGroupingControl1.TableDescriptor.Columns["LastName"].HeaderImage = Image.FromFile(GetIconFile(@"Common\Images\Grid\HeaderImages\Customer.PNG"));
                this.gridGroupingControl1.TableDescriptor.Columns["LastName"].HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Right;
                this.gridGroupingControl1.TableDescriptor.Columns["Title"].HeaderImage = Image.FromFile(GetIconFile(@"Common\Images\Grid\HeaderImages\Contact.PNG"));
                this.gridGroupingControl1.TableDescriptor.Columns["FirstName"].HeaderImage = Image.FromFile(GetIconFile(@"Common\Images\Grid\HeaderImages\Customer.PNG"));
                this.gridGroupingControl1.TableDescriptor.Columns["FirstName"].HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Right;
                this.gridGroupingControl1.TableDescriptor.Columns["Address"].HeaderImage = Image.FromFile(GetIconFile(@"Common\Images\Grid\HeaderImages\Address.PNG"));

            }
            else
            {
                this.gridGroupingControl1.BeginUpdate();
                this.gridGroupingControl1.TableDescriptor.Columns["EmployeeID"].HeaderImage = null;
                this.gridGroupingControl1.TableDescriptor.Columns["BirthDate"].HeaderImage = null;
                this.gridGroupingControl1.TableDescriptor.Columns["HireDate"].HeaderImage = null;
                this.gridGroupingControl1.TableDescriptor.Columns["LastName"].HeaderImage = null;
                this.gridGroupingControl1.TableDescriptor.Columns["Title"].HeaderImage = null;
                this.gridGroupingControl1.TableDescriptor.Columns["FirstName"].HeaderImage = null;
                this.gridGroupingControl1.TableDescriptor.Columns["Address"].HeaderImage = null;
            }
            this.gridGroupingControl1.EndUpdate(true);
            this.gridGroupingControl1.Refresh();
            this.gridGroupingControl1.Invalidate();
            this.gridGroupingControl1.TableControl.RefreshRange(GridRangeInfo.Table());
        }

        #endregion

        #region TouchMode

        /// <summary>
        /// Enable or Disable the touch mode properties
        /// </summary>
        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv2.CheckState == CheckState.Checked)
            {
                //Enables the touch mode 
                this.gridGroupingControl1.EnableTouchMode = true;
            }
            else
            {
                //Disable the touch mode
                this.gridGroupingControl1.EnableTouchMode = false;
            }
        }

        #endregion

        #endregion

    }
}
