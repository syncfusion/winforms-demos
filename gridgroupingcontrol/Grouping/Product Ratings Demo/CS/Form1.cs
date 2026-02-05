#region Copyright Syncfusion Inc. 2001 - 2015.
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
using System.Data.SqlServerCe;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System.IO;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace ProductRatings
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private ProductRatings.ProductRatingsDataSet productRatingsDataSet2;
        private GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private PropertyGrid propertyGrid1;
        private IContainer components;

        bool isGroupedByRatings;
        GridRelationDescriptor copyOfProducsRatings;

       
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
            this.gridGroupingControl1.TableControl.DpiAware = true;
			this.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.comboBoxAdv1.SelectedIndex = 0;
            this.comboBoxAdv1.SelectedIndexChanged += new EventHandler(comboBoxAdv1_SelectedIndexChanged);

            this.gridGroupingControl1.TableOptions.AllowDropDownCell = false;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;           

            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        /// <summary>
        /// Gets / sets whether is gropued by rating
        /// </summary>
        public bool IsGroupedByRatings
        {
            get
            {
                return isGroupedByRatings;
            }
            set
            {
                if (isGroupedByRatings != value)
                {
                    isGroupedByRatings = value;
                    if (!isGroupedByRatings)
                    {
                        // Apply original schema
                        SetupProducts();
                    }
                    else
                    {
                        SetupGroupByRatings();
                    }
                }
            }
        }

        #endregion

        #region "Sample Customizations"

        /// <summary>
        /// ProductRating sample Customizations are done here.
        /// </summary>
        private void SampleCustomization()
        {
            // NOTE: If you open ProductRatingsDataSet.xsd and right click on the 
            // relation between Products and Suppliers and select "Edit Relation" 
            // you will notice in the dialog that is shown that the 
            // DataSet property "Create foreign key constraint Only" has been checked.
            // This setting allows the grouping engine to differentiate between
            // foreign key relations and master details relations when autopopulating
            // relations.
            //
            // Check out also the "PrintGroupingGrid" sample code. In its form constructor
            // it shows how to avoid columns being automatically added to the parent table for each
            // column in the foreign table. It does instead manually add those columns
            // from the referenced table by setting ShowRelationFields = ShowRelationFields.Hide
            // and calling Columns.Add("ForeignTable.ColumnName")
            String commandstring1 = "select * from Products";
            String commandstring2 = "select * from Ratings";
            String commandstring3 = "select * from RatingDescription";
            String commandstring4 = "select * from Customers";
            String commandstring5 = "select * from Suppliers";

            String connection = @"Data Source=" + FindFile("NorthwindIO.sdf");
            SqlCeEngine ce = new SqlCeEngine(connection);
            // ce.Upgrade();

            SqlCeDataAdapter da1 = new SqlCeDataAdapter(commandstring1, connection);
            SqlCeDataAdapter da2 = new SqlCeDataAdapter(commandstring2, connection);
            SqlCeDataAdapter da3 = new SqlCeDataAdapter(commandstring3, connection);
            SqlCeDataAdapter da4 = new SqlCeDataAdapter(commandstring4, connection);
            SqlCeDataAdapter da5 = new SqlCeDataAdapter(commandstring5, connection);

            da5.Fill(productRatingsDataSet2, "Suppliers");
            da1.Fill(productRatingsDataSet2, "Products");
            da3.Fill(productRatingsDataSet2, "RatingDescription");
            da4.Fill(productRatingsDataSet2, "Customers");
            da2.Fill(productRatingsDataSet2, "Ratings");

            bool shouldGenerateRandomRatings = false;

            if (shouldGenerateRandomRatings)
            {
                Random rnd = new Random();
                for (int n = 0; n < 100; n++)
                {
                    int custIndex = (int)Math.Round(rnd.NextDouble() * (this.productRatingsDataSet2.Customers.Count - 1), 0);
                    int prodIndex = (int)Math.Round(rnd.NextDouble() * (this.productRatingsDataSet2.Products.Count - 1), 0);
                    int rating = (int)Math.Round(rnd.NextDouble() * (this.productRatingsDataSet2.RatingDescription.Count - 1), 0);
                    ProductRatings.ProductRatingsDataSet.RatingsRow row = this.productRatingsDataSet2.Ratings.NewRatingsRow();
                    row.CustomerID = this.productRatingsDataSet2.Customers[custIndex].CustomerID;
                    row.ProductID = this.productRatingsDataSet2.Products[prodIndex].ProductID;
                    row.RatingID = rating;
                    try
                    {
                        this.productRatingsDataSet2.Ratings.AddRatingsRow(row);
                    }
                    catch
                    {
                    }
                }
            }
        }

        #endregion

        #region Event Handlers
        /// <summary>
        /// Set the Grouped Columns ratings and properties
        /// </summary>
        void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxAdv1.SelectedIndex)
            {
                case 0:
                    IsGroupedByRatings = false;
                    GridTableDescriptor mainTd = this.gridGroupingControl1.TableDescriptor;
                    mainTd.GroupedColumns.Clear();
                    mainTd.VisibleColumns.Reset();
                    break;
                case 1:
                    IsGroupedByRatings = false;

                    GridTableDescriptor mainTd1 = this.gridGroupingControl1.TableDescriptor;
                    mainTd1.GroupedColumns.Clear();
                    mainTd1.GroupedColumns.Add(mainTd1.Columns["Discontinued"].MappingName);
                    mainTd1.VisibleColumns.Reset();
                    mainTd1.VisibleColumns.Remove("Discontinued");
                    break;
                case 2:
                    IsGroupedByRatings = true;

                    GridTableDescriptor mainTd2 = this.gridGroupingControl1.TableDescriptor;
                    mainTd2.GroupedColumns.Clear();
                    mainTd2.GroupedColumns.Add(mainTd2.Columns["Suppliers_CompanyName"].MappingName);
                    mainTd2.VisibleColumns.Reset();
                    mainTd2.VisibleColumns.Remove("Suppliers_CompanyName");
                    break;
                case 3:
                    IsGroupedByRatings = true;

                    GridTableDescriptor mainTd3 = this.gridGroupingControl1.TableDescriptor;
                    mainTd3.GroupedColumns.Clear();
                    mainTd3.GroupedColumns.Add(mainTd3.Columns["Ratings"].MappingName);
                    mainTd3.VisibleColumns.Reset();
                    mainTd3.VisibleColumns.Remove("Ratings");
                    this.gridGroupingControl1.Table.ExpandAllGroups();
                    break;

            }
        }

        #region menuItem_Click Event Handler

        /// <summary>
        ///Show dialog for choosing menuitems
        /// </summary>
        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            DemoCommon.AboutForm abtForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            abtForm.ShowDialog();
        }

        #endregion

        #endregion

        #region "Designer Stuffs"

        #region FindFile
        /// <summary>
        /// Used to find the file to load data
        /// </summary>
        private string FindFile(string connstring)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(connstring))
                    return new FileInfo(connstring).FullName;
                connstring = @"..\" + connstring;
            }

            return connstring;
        }

        #endregion

       
        #region Dispose
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
            Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor gridRelationDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor10 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor11 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor gridRelationDescriptor2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor gridRelationDescriptor3 = new Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor12 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor13 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor14 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor gridRelationDescriptor4 = new Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.productRatingsDataSet2 = new ProductRatings.ProductRatingsDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productRatingsDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.DataSource = this.productRatingsDataSet2.Products;
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.Location = new System.Drawing.Point(16, 16);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(772, 615);
            this.gridGroupingControl1.TabIndex = 0;
            gridColumnDescriptor1.HeaderImage = null;
            gridColumnDescriptor1.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor1.HeaderText = "Category ID";
            gridColumnDescriptor1.MappingName = "CategoryID";
            gridColumnDescriptor1.SerializedImageArray = "";
            gridColumnDescriptor2.Appearance.AnyRecordFieldCell.CellType = "TextBox";
            gridColumnDescriptor2.Appearance.AnyRecordFieldCell.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridColumnDescriptor2.HeaderImage = null;
            gridColumnDescriptor2.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor2.MappingName = "Discontinued";
            gridColumnDescriptor2.SerializedImageArray = "";
            gridColumnDescriptor3.HeaderImage = null;
            gridColumnDescriptor3.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor3.HeaderText = "Product Name";
            gridColumnDescriptor3.MappingName = "ProductName";
            gridColumnDescriptor3.SerializedImageArray = "";
            gridColumnDescriptor4.AllowDropDownCell = true;
            gridColumnDescriptor4.HeaderImage = null;
            gridColumnDescriptor4.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor4.MappingName = "Ratings_RatingDescription_Description";
            gridColumnDescriptor4.Name = "Ratings";
            gridColumnDescriptor4.SerializedImageArray = "";
            gridColumnDescriptor4.Width = 176;
            gridColumnDescriptor5.HeaderImage = null;
            gridColumnDescriptor5.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor5.HeaderText = "Reorder Level";
            gridColumnDescriptor5.MappingName = "ReorderLevel";
            gridColumnDescriptor5.SerializedImageArray = "";
            gridColumnDescriptor6.HeaderImage = null;
            gridColumnDescriptor6.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor6.HeaderText = "Supplier";
            gridColumnDescriptor6.MappingName = "Suppliers_CompanyName";
            gridColumnDescriptor6.SerializedImageArray = "";
            gridColumnDescriptor7.HeaderImage = null;
            gridColumnDescriptor7.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor7.HeaderText = "Unit Price";
            gridColumnDescriptor7.MappingName = "UnitPrice";
            gridColumnDescriptor7.SerializedImageArray = "";
            gridColumnDescriptor8.HeaderImage = null;
            gridColumnDescriptor8.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor8.HeaderText = "Units In Stock";
            gridColumnDescriptor8.MappingName = "UnitsInStock";
            gridColumnDescriptor8.SerializedImageArray = "";
            gridColumnDescriptor9.HeaderImage = null;
            gridColumnDescriptor9.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor9.HeaderText = "Units On Order";
            gridColumnDescriptor9.MappingName = "UnitsOnOrder";
            gridColumnDescriptor9.SerializedImageArray = "";
            this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            gridColumnDescriptor1,
            gridColumnDescriptor2,
            gridColumnDescriptor3,
            gridColumnDescriptor4,
            gridColumnDescriptor5,
            gridColumnDescriptor6,
            gridColumnDescriptor7,
            gridColumnDescriptor8,
            gridColumnDescriptor9});
            gridColumnDescriptor10.HeaderImage = null;
            gridColumnDescriptor10.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor10.HeaderText = "Customer";
            gridColumnDescriptor10.MappingName = "Customers_CompanyName";
            gridColumnDescriptor10.SerializedImageArray = "";
            gridColumnDescriptor11.HeaderImage = null;
            gridColumnDescriptor11.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor11.HeaderText = "Rating";
            gridColumnDescriptor11.MappingName = "RatingDescription_Description";
            gridColumnDescriptor11.SerializedImageArray = "";
            gridRelationDescriptor1.ChildTableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            gridColumnDescriptor10,
            gridColumnDescriptor11});
            gridRelationDescriptor2.MappingName = "RatingDescriptionRatings";
            gridColumnDescriptor12.HeaderImage = null;
            gridColumnDescriptor12.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor12.MappingName = "CustomerID";
            gridColumnDescriptor12.SerializedImageArray = "";
            gridColumnDescriptor13.HeaderImage = null;
            gridColumnDescriptor13.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor13.MappingName = "City";
            gridColumnDescriptor13.SerializedImageArray = "";
            gridColumnDescriptor14.HeaderImage = null;
            gridColumnDescriptor14.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor14.MappingName = "CompanyName";
            gridColumnDescriptor14.SerializedImageArray = "";
            gridRelationDescriptor3.ChildTableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            gridColumnDescriptor12,
            gridColumnDescriptor13,
            gridColumnDescriptor14});
            gridRelationDescriptor3.MappingName = "CustomersRatings";
            gridRelationDescriptor1.ChildTableDescriptor.Relations.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor[] {
            gridRelationDescriptor2,
            gridRelationDescriptor3});
            gridRelationDescriptor1.MappingName = "ProductsRatings";
            gridRelationDescriptor1.RelationKind = Syncfusion.Grouping.RelationKind.ForeignKeyKeyWords;
            gridRelationDescriptor4.MappingName = "SuppliersProducts";
            this.gridGroupingControl1.TableDescriptor.Relations.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor[] {
            gridRelationDescriptor1,
            gridRelationDescriptor4});
            this.gridGroupingControl1.TableDescriptor.SortedColumns.AddRange(new Syncfusion.Grouping.SortColumnDescriptor[] {
            new Syncfusion.Grouping.SortColumnDescriptor("Ratings", System.ComponentModel.ListSortDirection.Ascending)});
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            // 
            // productRatingsDataSet2
            // 
            this.productRatingsDataSet2.DataSetName = "ProductRatingsDataSet";
            this.productRatingsDataSet2.Locale = new System.Globalization.CultureInfo("en-US");
            this.productRatingsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxAdv1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(810, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group By";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(166, 21);
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "None",
            "Discontinued",
            "Supplier",
            "Ratings"});
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "None"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Discontinued"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Supplier"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Ratings"));
            this.comboBoxAdv1.Location = new System.Drawing.Point(9, 32);
            this.comboBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(166, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 1;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(810, 99);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(188, 532);
            this.propertyGrid1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 653);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridGroupingControl1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Product Ratings ";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productRatingsDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
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
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        #endregion

        #region SerupProducts

        /// <summary>
        /// In this method we swap the Products and Ratings table. We reverse
        /// the changes made by SetupGroupByRatings.
        /// </summary>
        void SetupProducts()
        {
            
            this.gridGroupingControl1.Table.CurrentElement = null;

            GridTableDescriptor mainTd = this.gridGroupingControl1.TableDescriptor;
            mainTd.GroupedColumns.Clear();

            // Was never switched before to Ratings - return.
            if (this.copyOfProducsRatings == null)
                return;

            // Save Suppliers and RatingDescription so that they can be reapplied.
            GridRelationDescriptor suppliersRd = new GridRelationDescriptor();
            suppliersRd.InitializeFrom(mainTd.Relations["Products"].ChildTableDescriptor.Relations["Suppliers"]);

            //
            // Change MappingNames for Columns. The name of the column stays the same.
            //
            foreach (GridColumnDescriptor cd in mainTd.Columns)
            {
                if (cd.MappingName.StartsWith("Products_"))
                    cd.MappingName = cd.MappingName.Substring("Products_".Length);
                else
                    cd.MappingName = "Ratings_" + cd.MappingName;
            }

            mainTd.Relations.Clear();
            mainTd.Relations.Add(copyOfProducsRatings);
            mainTd.Relations.Add(suppliersRd);

            this.gridGroupingControl1.DataSource = this.productRatingsDataSet2.Ratings;

            mainTd.Name = "Products View";

            // Change the main table.
            this.gridGroupingControl1.DataSource = this.productRatingsDataSet2.Products;
        }

        #endregion

        #region SetupGroupByRatings
        
        /// <summary>
        /// Group the GridGroingControl by Rating column
        /// </summary>
        void SetupGroupByRatings()
        {
            // 
            // In this method we swap the Products and Ratings table. At startup the
            // DataSource is set to the Products table which has a parent child relation 
            // with Ratings.
            //
            // In this method we assign the Ratings table as main DataSource and add
            // a ForeignKey relation to the products table. This allows products that
            // have multiple ratings to appear more than once.
            //
            // The foreign key relation from Products to Suppliers will be saved
            // and reapplied in this method.
            //

            GridTableDescriptor mainTd = this.gridGroupingControl1.TableDescriptor;

            this.gridGroupingControl1.Table.CurrentElement = null;

            // Reset all Grouping
            mainTd.GroupedColumns.Clear();
            mainTd.VisibleColumns.Reset();

            // Save the relations we previously defined for Ratings
            copyOfProducsRatings = new GridRelationDescriptor();
            copyOfProducsRatings.InitializeFrom(mainTd.Relations["Ratings"]);

            // Save also Suppliers and RatingDescription so that they can be reapplied.
            GridRelationDescriptor suppliersRd = new GridRelationDescriptor();
            suppliersRd.InitializeFrom(mainTd.Relations["Suppliers"]);

            GridRelationDescriptor ratingsDescriptionRd = new GridRelationDescriptor();
            ratingsDescriptionRd.InitializeFrom(copyOfProducsRatings.ChildTableDescriptor.Relations["RatingDescription"]);

            //
            // Change MappingNames for Columns. The name of the column stays the same.
            //
            foreach (GridColumnDescriptor cd in mainTd.Columns)
            {
                if (cd.MappingName.StartsWith("Ratings_"))
                    cd.MappingName = cd.MappingName.Substring("Ratings_".Length);
                else
                    cd.MappingName = "Products_" + cd.MappingName;
            }

            //
            // Set up foreign key relation from Ratings to Products
            // so that each Product can now appear multiple times, once for each Rating it has.
            //
            GridRelationDescriptor productsRd = new GridRelationDescriptor();
            productsRd.RelationKind = RelationKind.ForeignKeyReference;
            productsRd.ChildTableName = "Products";
            productsRd.RelationKeys.Add("ProductID", "ProductID");
            productsRd.ChildTableDescriptor.Relations.Clear();

            //
            // Main DataSource is now "Ratings" table. Add foreign key relations to products and 
            // restore the Suppliers and RatingDescription relation.
            //
            mainTd.Relations.Clear();
            mainTd.Relations.Add(productsRd);
            mainTd.Relations.Add(ratingsDescriptionRd);
            productsRd.ChildTableDescriptor.Relations.Add(suppliersRd);

            mainTd.Name = "Group by Ratings";

            this.gridGroupingControl1.DataSource = this.productRatingsDataSet2.Ratings;
        }

        #endregion


    }
}
