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

namespace PrintGroupingGrid
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private PrintGroupingGrid.DataSet1 dataSet11;
        private IContainer components;
        private Panel panel1;
        private ToolTip tipDesc;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv3;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv4;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");

        #endregion

        #region "Constructor"

        public Form1()
        {
            #region Grid Intialization Settings
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            this.InitializeDataSet();

            // Example: If you want to manually add foreign key columns and don't autopopulate them
            bool manualForeignKey = true;
            if (manualForeignKey)
            {
                // The following code shows how to avoid columns being automatically added to the parent table for each
                // column in the foreign table. It does instead manually add those columns
                // from the referenced table by setting ShowRelationFields = ShowRelationFields.Hide
                // and calling Columns.Add("ForeignTable.ColumnName")

                // Reset Relations - so that they get recreated from scratch
                this.gridGroupingControl1.TableDescriptor.Relations.Reset();

                // NOTE: If you open DataSet1.xsd and right click on the 
                // relation between Products and Suppliers and select "Edit Relation" 
                // you will notice in the dialog that is shown that the 
                // DataSet property "Create foreign key constraint only" has been checked.
                // This setting allows the grouping engine to differentiate between
                // foreign key relations and master details relations when autopopulating
                // relations.
                //

                this.gridGroupingControl1.ShowRelationFields = ShowRelationFields.Hide;

                GridTableDescriptor td = this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor;
                int n = td.Columns.Add("Suppliers.CompanyName");   // . will be replaced with '_' in column.Name
                Console.WriteLine(td.Columns[n].Name);
                td.Columns[n].ReadOnly = true;
                td.VisibleColumns.Clear();
                td.VisibleColumns.AddRange(
                    new GridVisibleColumnDescriptor[] {
														  new GridVisibleColumnDescriptor("ProductID"),
														  new GridVisibleColumnDescriptor("ProductName"),
														  new GridVisibleColumnDescriptor("UnitPrice"),
														  new GridVisibleColumnDescriptor("Suppliers_CompanyName")
													  });
            }
           
            #endregion
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
           
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            this.MetroColor = System.Drawing.Color.Transparent;
            
            // Show group area
            this.gridGroupingControl1.ShowGroupDropArea = true;

            // Additionial table descriptors currently habe to be added manually. We
            // plan to provide a TableDescriptor.ShowInGroupDropArea property later
            // to make this easier.
            AddGroupDropAreas(this.gridGroupingControl1.Table);

            this.gridGroupingControl1.Table.Records[0].IsExpanded = true;
            this.gridGroupingControl1.Table.Records[2].IsExpanded = true;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordAfterDetails = false;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordAfterDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Segoe UI";
            gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.gridGroupingControl1.TableDescriptor.Columns["CategoryID"].HeaderText = "Category ID";
            this.gridGroupingControl1.TableDescriptor.Columns["CategoryName"].HeaderText = "Category Name";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Columns["ProductID"].HeaderText = "Product ID";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Columns["ProductName"].HeaderText = "Product Name";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Columns["UnitPrice"].HeaderText = "Unit Price";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.VisibleColumns.RemoveAt(3);

            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = this.gridGroupingControl1.GetTable("Products").DefaultCaptionRowHeight = 25;
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = this.gridGroupingControl1.GetTable("Products").DefaultColumnHeaderRowHeight = 30;
            this.gridGroupingControl1.GetTable("Products").DefaultRecordRowHeight = 28;
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = 38;

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region "Sample Customization"

        #region Button Handlers

        //used to expand all the records
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.gridGroupingControl1.Table.ExpandAllRecords();
        }

        //used to collapse all the records and groups
        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.gridGroupingControl1.Table.CollapseAllRecords();
            this.gridGroupingControl1.Table.CollapseAllGroups();
        }

        //used to display the printpreview dialog
        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            // Print the contents of the grouping grid.
            GridPrintDocument pd = new GridPrintDocument(this.gridGroupingControl1.TableControl, true);
            PrintPreviewDialog ppv = new PrintPreviewDialog();
            ppv.MouseWheel += ppv_MouseWheel;
            ppv.Document = pd;
            pd.DefaultPageSettings.Landscape = true;
            try
            {
                Icon ico = new Icon(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Icon", "sfgrid.ico"));
                ppv.FindForm().Icon = ico;
            }
            catch
            { }
            ppv.ShowDialog();
            // NOTE: There is a known problem when the width of the nested table is larger
            // than the width of the parent table. Some columns that do not fit on the same
            // page as the last column of the parent table will be omitted. We are working
            // on a solution for this.
        }

        void ppv_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                SendKeys.Send("{UP}");
            }
            else
            {
                SendKeys.Send("{DOWN}");
            }
        }
        //used to display the print dialog
        private void buttonAdv4_Click(object sender, EventArgs e)
        {
            GridPrintDocument pd = new GridPrintDocument(this.gridGroupingControl1.TableControl);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;
            pd.DefaultPageSettings.Landscape = true;
            if (printDialog.ShowDialog() == DialogResult.OK)
                pd.Print();
        }

        #endregion

        #endregion

        #region "Designer Stuffs"

        #region Dataset 
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

        #region Form Handlers
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
            this.components = new System.ComponentModel.Container();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.dataSet11 = new PrintGroupingGrid.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tipDesc = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(18, 15);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(759, 628);
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
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gridGroupingControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 654);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonAdv3);
            this.groupBox2.Controls.Add(this.buttonAdv4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(793, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 148);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Print Options";
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv3.FlatStyle = FlatStyle.Flat;
            this.buttonAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv3.BeforeTouchSize = new System.Drawing.Size(108, 30);
            this.buttonAdv3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv3.ForeColor = System.Drawing.Color.White;
            this.buttonAdv3.IsBackStageButton = false;
            this.buttonAdv3.Location = new System.Drawing.Point(45, 37);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(108, 30);
            this.buttonAdv3.TabIndex = 4;
            this.buttonAdv3.Text = "Print Preview";
            this.buttonAdv3.Click += new System.EventHandler(this.buttonAdv3_Click);
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv4.FlatStyle = FlatStyle.Flat;
            this.buttonAdv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv4.BeforeTouchSize = new System.Drawing.Size(108, 30);
            this.buttonAdv4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv4.ForeColor = System.Drawing.Color.White;
            this.buttonAdv4.IsBackStageButton = false;
            this.buttonAdv4.Location = new System.Drawing.Point(45, 88);
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(108, 30);
            this.buttonAdv4.TabIndex = 4;
            this.buttonAdv4.Text = "Print";
            this.buttonAdv4.Click += new System.EventHandler(this.buttonAdv4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonAdv2);
            this.groupBox1.Controls.Add(this.buttonAdv1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(793, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expand / Collapse";
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.FlatStyle = FlatStyle.Flat;
            this.buttonAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(108, 30);
            this.buttonAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv2.ForeColor = System.Drawing.Color.White;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(45, 93);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(108, 30);
            this.buttonAdv2.TabIndex = 2;
            this.buttonAdv2.Text = "Collapse All";
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.FlatStyle = FlatStyle.Flat;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(108, 30);
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(45, 46);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(108, 30);
            this.buttonAdv1.TabIndex = 1;
            this.buttonAdv1.Text = "Expand All";
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // tipDesc
            // 
            this.tipDesc.BackColor = System.Drawing.Color.White;
            this.tipDesc.ForeColor = System.Drawing.Color.Black;
            this.tipDesc.IsBalloon = true;
            this.tipDesc.ShowAlways = true;
            this.tipDesc.UseFading = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 654);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Printing Hierarchical Grid ";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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

        #endregion

        #region Helper Methods
        /// <summary>
        /// Add the groupdroparea
        /// </summary>
        private void AddGroupDropAreas(GridTable table)
        {
            Syncfusion.Grouping.RelationDescriptor rd = table.TableDescriptor.ParentRelation;
            if (rd != null && rd.RelationKind != Syncfusion.Grouping.RelationKind.RelatedMasterDetails)
                return;

            foreach (GridTable t in table.RelatedTables)
            {
                Console.WriteLine("AddGroupDropArea " + t.Info);

                gridGroupingControl1.AddGroupDropArea(t);
                //recurse...
                AddGroupDropAreas(t);
            }
        }
        
        /// <summary>
        /// sets the dataset to the GridGroupingControl using SqlCeDataAdapter
        /// </summary>
        void InitializeDataSet()
        {
            // Initialize the data set

            this.dataSet11.BeginInit();

            String commandstring1 = "select * from Categories";
            String commandstring2 = "select * from Products";

            SqlCeDataAdapter da1 = new SqlCeDataAdapter(commandstring1, connString);
            SqlCeDataAdapter da2 = new SqlCeDataAdapter(commandstring2, connString);
            try
            {
                da1.Fill(dataSet11, "Categories");
                da2.Fill(dataSet11, "Products");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }

            this.dataSet11.EndInit();
        }

        /// <summary>
        /// Display the Error message
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