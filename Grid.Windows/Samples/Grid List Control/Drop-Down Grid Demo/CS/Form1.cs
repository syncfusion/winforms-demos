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
using System.IO;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using DemoCommon.Grid;
using System.Text.RegularExpressions;

namespace ComboBoxBaseGridDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxBase comboBoxBase1;
		private Syncfusion.Windows.Forms.Grid.GridListControl gridListControl1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textLog;
		internal System.Windows.Forms.Label Label1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private ComboBoxBaseGridDemo.DataSet1 dataSet11;
        private ComboBoxAdv comboDropDown1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        #endregion

        #region "Constructor"

        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            //we'll read the data from a local XML file
            //comment this line if you want to access your SQLserver
            ReadXML(dataSet11, @"ComboBoxExtData.XML");
            //ReadXML(dataSet11, @"ComboBoxExtData.XML");

            //uncomment these DataAdapter1.Fill lines if you want to access your SQLserver
            //load the dataset with the tables we use
            //this.sqlDataAdapter1.Fill(this.dataSet11);
            this.GridSettings();			
		}

        #endregion

        #region "GridSettings"

        /// <summary>
        /// Grid Settings can be customized
        /// </summary>
        private void GridSettings()        
        {            
            this.comboDropDown1.Items.Add(this.comboBoxBase1);
            this.comboDropDown1.Items.Add(this.gridListControl1);
            this.comboDropDown1.SelectedIndex = 0;
            this.gridListControl1.BackColor = System.Drawing.SystemColors.Window;
            this.propertyGrid1.SelectedObject = this.comboDropDown1.SelectedItem;
            this.gridListControl1.Grid.PrepareViewStyleInfo += new Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventHandler(Grid_PrepareViewStyleInfo);
            this.Text = "DropDown Grid";
        }

        void Grid_PrepareViewStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs e)
        {
            if (e.ColIndex > 0 && e.RowIndex == 0)
            {
                switch (e.ColIndex)
                {
                    case 1:
                        e.Style.Text = "Product ID";
                        break;
                    case 2:
                        e.Style.Text = "Product Name";
                        break;
                    case 3:
                        e.Style.Text = "Unit Price";
                        break;
                    case 4:
                        e.Style.Text = "Units In Stock";
                        break;
                    case 5:
                        e.Style.Text = "Units On Order";
                        break;
                    case 6:
                        e.Style.Text = "Reorder Level";
                        break;
                    case 7:
                        e.Style.Text = "Units In Stock";
                        break;
                    case 8:
                        e.Style.Text = "Units On Order";
                        break;
                    case 9:
                        e.Style.Text = "Reorder Level";
                        break;
                    default:
                        break;
                }
            } 
        }

        #endregion

        #region "Designer Stuffs"

        #region Windows Form Designer generated code
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxBase1 = new Syncfusion.Windows.Forms.Tools.ComboBoxBase();
            this.gridListControl1 = new Syncfusion.Windows.Forms.Grid.GridListControl();
            this.dataSet11 = new ComboBoxBaseGridDemo.DataSet1();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textLog = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.comboDropDown1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxBase1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComboBoxBase";
            // 
            // comboBoxBase1
            // 
            this.comboBoxBase1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBase1.BackColor = System.Drawing.Color.White;
            this.comboBoxBase1.BeforeTouchSize = new System.Drawing.Size(260, 21);
            this.comboBoxBase1.DropDownWidth = 320;
            this.comboBoxBase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBase1.ListControl = this.gridListControl1;
            this.comboBoxBase1.Location = new System.Drawing.Point(16, 24);
            this.comboBoxBase1.Name = "comboBoxBase1";
            this.comboBoxBase1.Size = new System.Drawing.Size(260, 21);
            this.comboBoxBase1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxBase1.TabIndex = 0;
            this.comboBoxBase1.DropDownCloseOnClick += new Syncfusion.Windows.Forms.Tools.MouseClickCancelEventHandler(this.comboBoxBase1_DropDownCloseOnClick);
            this.comboBoxBase1.DropDown += new System.EventHandler(this.comboBoxBase1_DropDown);
            this.comboBoxBase1.SelectionChangeCommitted += new System.EventHandler(this.comboBoxBase1_SelectionChangeCommitted);
            this.comboBoxBase1.TextChanged += new System.EventHandler(this.comboBoxBase1_TextChanged);
            this.comboBoxBase1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxBase1_Validating);
            this.comboBoxBase1.Validated += new System.EventHandler(this.comboBoxBase1_Validated);
            // 
            // gridListControl1
            // 
            this.gridListControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridListControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridListControl1.BackColor = System.Drawing.Color.White;
            this.gridListControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridListControl1.DataSource = this.dataSet11.Products;
            this.gridListControl1.DisplayMember = "ProductName";
            this.gridListControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridListControl1.ItemHeight = 22;
            this.gridListControl1.Location = new System.Drawing.Point(43, 131);
            this.gridListControl1.MultiColumn = true;
            this.gridListControl1.Name = "gridListControl1";
            this.gridListControl1.Properties.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridListControl1.Properties.ForceImmediateRepaint = false;
            this.gridListControl1.Properties.MarkColHeader = false;
            this.gridListControl1.Properties.MarkRowHeader = false;
            this.gridListControl1.SelectedIndex = -1;
            this.gridListControl1.Size = new System.Drawing.Size(416, 274);
            this.gridListControl1.SupportsTransparentBackColor = true;
            this.gridListControl1.TabIndex = 3;
            this.gridListControl1.ThemesEnabled = true;
            this.gridListControl1.TopIndex = 0;
            this.gridListControl1.ValueMember = "ProductID";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.Window;
            this.propertyGrid1.Location = new System.Drawing.Point(578, 50);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(200, 303);
            this.propertyGrid1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textLog);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 144);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Event Log:";
            // 
            // textLog
            // 
            this.textLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textLog.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLog.Location = new System.Drawing.Point(3, 18);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLog.Size = new System.Drawing.Size(542, 123);
            this.textLog.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(27, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(476, 48);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "The ComboBoxBase control shown below, is bound to a GridListControl which is bein" +
                "g used in the drop-down. Properties of both controls can be modified using the P" +
                "ropertyGrid to the right hand side.";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice" +
                ", UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" +
                "es;persist security info=True;user id=sa;packet size=4096;Pooling=true";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"),
            new System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"),
            new System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"),
            new System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"),
            new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"),
            new System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"),
            new System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"),
            new System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"),
            new System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"),
            new System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"),
            new System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"),
            new System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"),
            new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"),
            new System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"),
            new System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"),
            new System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"),
            new System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued"),
            new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Discontinued", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Discontinued", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Products", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
                        new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
                        new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
                        new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
                        new System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
                        new System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"),
                        new System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"),
                        new System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"),
                        new System.Data.Common.DataColumnMapping("Discontinued", "Discontinued")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // comboDropDown1
            // 
            this.comboDropDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDropDown1.BackColor = System.Drawing.Color.White;
            this.comboDropDown1.BeforeTouchSize = new System.Drawing.Size(200, 21);
            this.comboDropDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDropDown1.Location = new System.Drawing.Point(578, 16);
            this.comboDropDown1.Name = "comboDropDown1";
            this.comboDropDown1.Size = new System.Drawing.Size(200, 21);
            this.comboDropDown1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboDropDown1.TabIndex = 7;
            this.comboDropDown1.SelectedIndexChanging += new Syncfusion.Windows.Forms.Tools.SelectedIndexChangingHandler(this.comboDropDown1_SelectedIndexChanging);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(788, 393);
            this.Controls.Add(this.comboDropDown1);
            this.Controls.Add(this.gridListControl1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "&";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDown1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        #region "ReadXml"

        /// <summary>
        /// Read the XML
        /// </summary>
        void ReadXML(DataSet dataSet11, string xmlFileName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (File.Exists(xmlFileName))
                {
                    this.dataSet11.ReadXml(xmlFileName);
                    break;
                }
                xmlFileName = @"..\" + xmlFileName;
            }
        }

        #endregion

        #region "Entry Point"

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

        #endregion

        #region "EventHandlers"

        private void comboBoxBase1_DropDown(object sender, System.EventArgs e)
		{
			this.textLog.Text += "Event: DropDown\r\n";

            for (int i = 1; i < this.gridListControl1.Grid.ColCount; i++)
            {
                Regex rex = new Regex(@"\p{Lu}");
                string MappingName = this.gridListControl1.Grid[0, i].Text;
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
                this.gridListControl1.Grid[0, i].Text = name;
            }
			//this.comboBoxBase1.PopupContainer.Width = 400;
		}

		private void comboBoxBase1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			this.textLog.Text += "Event: SelectionChangeCommitted\r\n";
		}

		private void comboBoxBase1_Validated(object sender, System.EventArgs e)
		{
			this.textLog.Text += "Event: Validated\r\n";
		}

		private void comboBoxBase1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.textLog.Text += "Event: Validating\r\n";
		}

		private void comboBoxBase1_TextChanged(object sender, System.EventArgs e)
		{
			this.textLog.Text += "Event: TextChanged\r\n";
		}

		private void comboBoxBase1_DropDownCloseOnClick(object sender, Syncfusion.Windows.Forms.Tools.MouseClickCancelEventArgs args)
		{
			// Optionally, you can prevent the dropdown from closing
			// when there are no selected items in the list control.
			// This might happen when you resized the column width via the header, for example.
			if(this.gridListControl1.SelectedIndex == -1)
				args.Cancel = true;
		}

        private void comboDropDown1_SelectedIndexChanging(object sender, SelectedIndexChangingArgs e)
        {
           this.propertyGrid1.SelectedObject = this.comboDropDown1.SelectedItem;
        }

        #endregion

    }
}
