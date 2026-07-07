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
using System.Xml;
using System.Xml.Serialization;
using System.IO;

using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using DemoCommon.Grid;
using Syncfusion.GridHelperClasses;

namespace XMLSerialization
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region "API Definitions"

        protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        protected DataSet1 dataSet11;
        private Syncfusion.Windows.Forms.ButtonAdv reset;
        private Syncfusion.Windows.Forms.ButtonAdv btnLoadXmlSchema;
        private Syncfusion.Windows.Forms.ButtonAdv btnSaveXmlSchema;
        protected GridGroupingControl gridGroupingControl1;
        private PropertyGrid propertyGrid1;
        private IContainer components;
        GridExcelFilter excelFilter = new GridExcelFilter();
        System.IO.MemoryStream gridExcelFilterStream;  
        #endregion

        #region "Constructor"

        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.SampleCustomization();
            this.GridSettings();

            #region Filter Wiring
            foreach (GridColumnDescriptor column in gridGroupingControl1.TableDescriptor.Columns)
            {
                column.AllowFilter = true;
            }
            this.excelFilter.WireGrid(this.gridGroupingControl1);
            gridExcelFilterStream = new System.IO.MemoryStream();
            this.excelFilter.WriteXml(new XmlTextWriter(gridExcelFilterStream, null));            
            #endregion
        }

        #endregion

        #region "Sample Customization"
        /// <summary>
        /// set the dataset to the GridGroupingControl using the sqlDataAdapter
        /// </summary>
        private void SampleCustomization()
        {
            bool msdeAvailable = false;
            if (msdeAvailable)
            {
                this.sqlDataAdapter1.Fill(this.dataSet11);
                this.dataSet11.WriteXml("NWCategories.xml", XmlWriteMode.WriteSchema);
            }
            else
                // Read from a xml file instead. 
                ReadXml(this.dataSet11, "NWCategories.xml");
        }

        System.IO.MemoryStream stream;     

        #region "Events"

        #region "Save Schema"

        /// <summary>
        /// Save Schema and Lool and Feel of the Grid to Xml files
        /// </summary>
        private void btnSaveXmlSchema_Click(object sender, System.EventArgs e)
        {
            XmlTextWriter xw = new XmlTextWriter("GridSchema.xml", System.Text.Encoding.UTF8);
            XmlTextWriter xwApp = new XmlTextWriter("GridLooknFeel.xml", System.Text.Encoding.UTF8);
            XmlTextWriter xwExcelFilter = new XmlTextWriter("GridExcelFilter.xml", System.Text.Encoding.UTF8);
            xw.Formatting = System.Xml.Formatting.Indented;
            this.gridGroupingControl1.WriteXmlSchema(xw);
            this.gridGroupingControl1.WriteXmlLookAndFeel(xwApp);
            this.excelFilter.WriteXml(xwExcelFilter);
            xw.Close();
            xwApp.Close();
            xwExcelFilter.Close();
        }

        #endregion

        #region LoadSchema

        /// <summary>
        /// Used to load the schema and Look and feel for the Grid
        /// </summary>
        private void btnLoadXmlSchema_Click(object sender, System.EventArgs e)
        {
            if (File.Exists("GridSchema.xml") && File.Exists("GridLooknFeel.xml") && File.Exists("GridExcelFilter.xml"))
            {
                XmlReader xr = new XmlTextReader("GridSchema.xml");
                XmlReader xrApp = new XmlTextReader("GridLooknFeel.xml");
                XmlReader xrExcelFilter = new XmlTextReader("GridExcelFilter.xml");
                this.gridGroupingControl1.ApplyXmlSchema(xr);
                this.gridGroupingControl1.ApplyXmlLookAndFeel(xrApp);
                this.excelFilter.ApplyXml(xrExcelFilter);
                xr.Close();
                xrApp.Close();
                xrExcelFilter.Close();
            }
            else
                MessageBox.Show("Click \"Save Xml Schema\" button to serialize the grid.");
        }

        #endregion

       //reset the schema
        private void reset_Click(object sender, System.EventArgs e)
        {
            System.IO.MemoryStream stream2 = new System.IO.MemoryStream(stream.ToArray());
            System.IO.MemoryStream gridExcelFilterStream2 = new System.IO.MemoryStream(gridExcelFilterStream.ToArray());
            this.gridGroupingControl1.ApplyXmlSchema(new XmlTextReader(stream2));
            this.excelFilter.ApplyXml(new XmlTextReader(gridExcelFilterStream2));
            this.excelFilter.UnWireGrid(this.gridGroupingControl1);
            foreach (GridColumnDescriptor column in gridGroupingControl1.TableDescriptor.Columns)
                column.AllowFilter = true;
            this.excelFilter.WireGrid(this.gridGroupingControl1);
        }
        #endregion

        #endregion

        #region "Grid Settings"
        /// <summary>
        /// GridGroupingControl setting starts customization
        /// </summary>
        private void GridSettings()
        {
            // Knowing the initail state
            stream = new System.IO.MemoryStream();
			this.gridGroupingControl1.TableControl.DpiAware = true;
            this.gridGroupingControl1.WriteXmlSchema(new XmlTextWriter(stream, null));
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            this.gridGroupingControl1.FilterRuntimeProperties = true;
            this.gridGroupingControl1.TableDescriptor.Appearance.AddNewRecordFieldCell.BackColor = Color.Orange;
            this.gridGroupingControl1.TableDescriptor.Appearance.AlternateRecordFieldCell.BackColor = Color.Orange;
            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = 25;
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = 30;
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = 52;
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridGroupingControl1.TableDescriptor.Columns["CategoryID"].HeaderText = "Category ID";
            this.gridGroupingControl1.TableDescriptor.Columns["CategoryName"].HeaderText = "Category Name";

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;

        }

        #endregion

        #region "Designer Stuffs"

        #region "ReadXml"

        /// <summary>
        /// Read xml file to store dataset
        /// </summary>
        /// 
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
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor3 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor4 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            this.dataSet11 = new XMLSerialization.DataSet1();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.reset = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnLoadXmlSchema = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnSaveXmlSchema = new Syncfusion.Windows.Forms.ButtonAdv();
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
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "data source=(local)\\NETSDK;initial catalog=Northwind;integrated security=SSPI;per" +
                "sist security info=True;workstation id=localhost;packet size=4096";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, "CategoryName"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 1073741823, "Description"),
            new System.Data.SqlClient.SqlParameter("@Picture", System.Data.SqlDbType.VarBinary, 2147483647, "Picture")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, "CategoryName"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 1073741823, "Description"),
            new System.Data.SqlClient.SqlParameter("@Picture", System.Data.SqlDbType.VarBinary, 2147483647, "Picture"),
            new System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CategoryName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Categories WHERE (CategoryID = @Original_CategoryID) AND (CategoryNam" +
                "e = @Original_CategoryName)";
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CategoryName", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Categories", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
                        new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Picture", "Picture")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reset.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.reset.FlatStyle = FlatStyle.Flat;
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.reset.BeforeTouchSize = new System.Drawing.Size(130, 28);
            this.reset.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.reset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.IsBackStageButton = false;
            this.reset.Location = new System.Drawing.Point(340, 615);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(130, 28);
            this.reset.TabIndex = 12;
            this.reset.Text = "Reset Schema";
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // btnLoadXmlSchema
            // 
            this.btnLoadXmlSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadXmlSchema.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnLoadXmlSchema.FlatStyle = FlatStyle.Flat;
            this.btnLoadXmlSchema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnLoadXmlSchema.BeforeTouchSize = new System.Drawing.Size(130, 28);
            this.btnLoadXmlSchema.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnLoadXmlSchema.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadXmlSchema.ForeColor = System.Drawing.Color.White;
            this.btnLoadXmlSchema.IsBackStageButton = false;
            this.btnLoadXmlSchema.Location = new System.Drawing.Point(199, 615);
            this.btnLoadXmlSchema.Name = "btnLoadXmlSchema";
            this.btnLoadXmlSchema.Size = new System.Drawing.Size(130, 28);
            this.btnLoadXmlSchema.TabIndex = 11;
            this.btnLoadXmlSchema.Text = "Load Xml Schema";
            this.btnLoadXmlSchema.Click += new System.EventHandler(this.btnLoadXmlSchema_Click);
            // 
            // btnSaveXmlSchema
            // 
            this.btnSaveXmlSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveXmlSchema.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnSaveXmlSchema.FlatStyle = FlatStyle.Flat;
            this.btnSaveXmlSchema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnSaveXmlSchema.BeforeTouchSize = new System.Drawing.Size(130, 28);
            this.btnSaveXmlSchema.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnSaveXmlSchema.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveXmlSchema.ForeColor = System.Drawing.Color.White;
            this.btnSaveXmlSchema.IsBackStageButton = false;
            this.btnSaveXmlSchema.Location = new System.Drawing.Point(60, 615);
            this.btnSaveXmlSchema.Name = "btnSaveXmlSchema";
            this.btnSaveXmlSchema.Size = new System.Drawing.Size(130, 28);
            this.btnSaveXmlSchema.TabIndex = 10;
            this.btnSaveXmlSchema.Text = "Save Xml Schema";
            this.btnSaveXmlSchema.Click += new System.EventHandler(this.btnSaveXmlSchema_Click);
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.DataSource = this.dataSet11.Categories;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.Location = new System.Drawing.Point(15, 16);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(697, 589);
            this.gridGroupingControl1.TabIndex = 9;
            gridColumnDescriptor1.HeaderImage = null;
            gridColumnDescriptor1.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor1.MappingName = "CategoryID";
            gridColumnDescriptor1.SerializedImageArray = "";
            gridColumnDescriptor1.Width = 80;
            gridColumnDescriptor2.HeaderImage = null;
            gridColumnDescriptor2.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor2.MappingName = "CategoryName";
            gridColumnDescriptor2.SerializedImageArray = "";
            gridColumnDescriptor3.HeaderImage = null;
            gridColumnDescriptor3.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor3.MappingName = "Description";
            gridColumnDescriptor3.SerializedImageArray = "";
            gridColumnDescriptor3.Width = 250;
            gridColumnDescriptor4.HeaderImage = null;
            gridColumnDescriptor4.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor4.MappingName = "Picture";
            gridColumnDescriptor4.SerializedImageArray = "";
            this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            gridColumnDescriptor1,
            gridColumnDescriptor2,
            gridColumnDescriptor3,
            gridColumnDescriptor4});
            this.gridGroupingControl1.TableOptions.RecordRowHeight = 57;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
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
            this.propertyGrid1.Location = new System.Drawing.Point(720, 16);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(276, 589);
            this.propertyGrid1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1012, 653);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.btnLoadXmlSchema);
            this.Controls.Add(this.btnSaveXmlSchema);
            this.Controls.Add(this.gridGroupingControl1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "XML Serialization";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
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

