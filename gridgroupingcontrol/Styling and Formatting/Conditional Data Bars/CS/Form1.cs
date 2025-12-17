#region Copyright Syncfusion Inc. 2001 - 20155
//
//  Copyright Syncfusion Inc. 2001 - 20155. All rights reserved.
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
using Syncfusion.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using System.Xml;
using System.Drawing.Drawing2D;
using System.Windows.Forms.Design;

namespace ColumnStyles
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {

        #region "API Definition"

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;       
        Syncfusion.Windows.Forms.Grid.Grouping.ConditionalFormatDataBarRule conditionDataBarRule1 = new Syncfusion.Windows.Forms.Grid.Grouping.ConditionalFormatDataBarRule();
        Syncfusion.Windows.Forms.Grid.Grouping.GridConditionalFormatDescriptor gridConditionalFormatDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridConditionalFormatDescriptor();
        Syncfusion.Windows.Forms.Grid.Grouping.ConditionalFormatDataBarRule conditionDataBarRule2 = new Syncfusion.Windows.Forms.Grid.Grouping.ConditionalFormatDataBarRule();
        Syncfusion.Windows.Forms.Grid.Grouping.GridConditionalFormatDescriptor gridConditionalFormatDescriptor2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridConditionalFormatDescriptor();
        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");
        private BindingList<CustomClass> bl;

        #endregion

        #region "Constructor"

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            Random r = new Random();         

            #region Datasource
            bl = new BindingList<CustomClass>();
            bl.Add(new CustomClass(0101, r.Next(10), "Chai", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0102, r.Next(10), "Chang", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0103, r.Next(10), "Aniyseed Syrup", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0104, r.Next(10), "lkura", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0105, r.Next(10), "queso cabrales", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0106, r.Next(10), "Konbu", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0107, r.Next(10), "Tofu", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0108, r.Next(10), "pavlova", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0109, r.Next(10), "Alice Mutton", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0110, r.Next(10), "Carnavan Tigers", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0111, r.Next(10), "Teatime Cholocate Biscuits", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0112, r.Next(10), "Mishi Kobi Niku", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0113, r.Next(10), "Chef Anton's Cajun Seasoning", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0114, r.Next(10), "Chef Anton's Gumbo Mix", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0115, r.Next(10), "Grandma's Boysenberry Spread", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0116, r.Next(10), "Uncle Bob's Organic Dried Pears", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0117, r.Next(10), "Northwoods Cranberry Sauce", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0118, r.Next(10), "Queso Cabrales", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0119, r.Next(10), "Queso Manchego La Pastora", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0120, r.Next(10), "Konbu", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0121, r.Next(10), "Genen Shouyu", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0122, r.Next(10), "Sir Rodney's Marmalade", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0123, r.Next(10), "Sir Rodney's Scones", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0124, r.Next(10), "Gustaf's Kn�ckebr�d", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0125, r.Next(10), "Tunnbr�d", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0126, r.Next(10), "Guaran� Fant�stica", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0127, r.Next(10), "NuNuCa Nu�-Nougat-Creme", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0128, r.Next(10), "Gumb�r Gummib�rchen", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0129, r.Next(10), "Schoggi Schokolade", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0130, r.Next(10), "R�ssle Sauerkraut", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0131, r.Next(10), "Nord-Ost Matjeshering", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0132, r.Next(10), "Gorgonzola Telino", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0133, r.Next(10), "Mascarpone Fabioli", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0134, r.Next(10), "Geitost", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0135, r.Next(10), "Sasquatch Ale", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0136, r.Next(10), "Steeleye Stout", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0137, r.Next(10), "Inlagd Sill", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0138, r.Next(10), "Gravad lax", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0139, r.Next(10), "C�te de Blaye", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0140, r.Next(10), "Chartreuse verte", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0141, r.Next(10), "Boston Crab Meat", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0142, r.Next(10), "Jack's New England Clam Chowder", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0143, r.Next(10), "Singaporean Hokkien Fried Mee", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0144, r.Next(10), "Ipoh Coffee", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0145, r.Next(10), "Gula Malacca", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0145, r.Next(10), "R�gede sild", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0147, r.Next(10), "Spegesild", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0148, r.Next(10), "Zaanse koeken", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0149, r.Next(10), "Chocolade", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0150, r.Next(10), "Maxilaku", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0151, r.Next(10), "Valkoinen suklaa", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0152, r.Next(10), "Manjimup Dried Apples", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0153, r.Next(10), "Filo Mix", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0154, r.Next(10), "Perth Pasties", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0155, r.Next(10), "Tourti�re", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0156, r.Next(10), "P�t� chinois", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0157, r.Next(10), "Gnocchi di nonna Alice", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0158, r.Next(10), "Ravioli Angelo", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0159, r.Next(10), "Escargots de Bourgogne", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0160, r.Next(10), "Raclette Courdavault", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0161, r.Next(10), "Camembert Pierrot", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0162, r.Next(10), "Sirop d'�rable", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0163, r.Next(10), "Tarte au sucre", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0164, r.Next(10), "Vegie-spread", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0165, r.Next(10), "Wimmers gute Semmelkn�del", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0166, r.Next(10), "Louisiana Fiery Hot Pepper Sauces", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0167, r.Next(10), "Louisiana Hot Spiced Okra", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0168, r.Next(10), "Laughing Lumberjack Lager", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0169, r.Next(10), "Scottish Longbreads", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0170, r.Next(10), "Gudbrandsdalsost", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0171, r.Next(10), "Outback Lager", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0172, r.Next(10), "Fl�temysost", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0173, r.Next(10), "Mozzarella di Giovanni", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0174, r.Next(10), "R�d Kaviar", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0175, r.Next(10), "Longlife Tofu", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0176, r.Next(10), "Rh�nbr�u Klosterbier", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0177, r.Next(10), "Lakkalik��ri", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0178, r.Next(10), "Original Frankfurter gr�ne So�e", r.Next(100), r.Next(-100, 100)));
            bl.Add(new CustomClass(0179, r.Next(10), "Tourti�re", r.Next(100), r.Next(-100, 100)));
            this.gridGroupingControl1.DataSource = bl;
            #endregion
          
            this.GridSettings();
            SampleCustomization();
        }

        #endregion

        System.IO.MemoryStream stream;

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
			this.gridGroupingControl1.TableControl.DpiAware = true;
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);;
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);;           
            this.gridGroupingControl1.TableDescriptor.Name = "Products";        
            this.gridGroupingControl1.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell;
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Move(4, 1);
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Move(4, 3);
            this.gridGroupingControl1.TableOptions.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.gridGroupingControl1.UseRightToLeftCompatibleTextBox = true;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.One;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionColorOptions = GridListBoxSelectionColorOptions.DrawAlphablend;          
           
            GridMetroColors metro = new GridMetroColors();
            metro.HeaderBottomBorderWeight = GridBottomBorderWeight.None;
            this.gridGroupingControl1.SetMetroStyle(metro);

            stream = new System.IO.MemoryStream();
            this.gridGroupingControl1.WriteXmlSchema(new XmlTextWriter(stream, null));           

            this.gridGroupingControl1.TableDescriptor.Columns["ProductID"].HeaderText = "Product ID";
            this.gridGroupingControl1.TableDescriptor.Columns["UnitPrice"].HeaderText = "Unit Price";
            this.gridGroupingControl1.TableDescriptor.Columns["ProductName"].HeaderText = "Product Name";
            this.gridGroupingControl1.TableDescriptor.Columns["SupplierID"].HeaderText = "Supplier ID";


        }      

        #endregion

        private void SampleCustomization()
        {
            //Initialize the GridConditionalFormatDescriptor and ConditionalFormatDataBarRule.
            //Define Expression for GridConditionalFormatDescriptor.
            gridConditionalFormatDescriptor1.Expression = "[UnitPrice] > '0' AND [UnitPrice] < '100' ";

            gridConditionalFormatDescriptor1.Name = "ConditionalFormat 1";
            // column name in which column we are going to apply.
            conditionDataBarRule2.ColumnName = "UnitPrice";
            conditionDataBarRule2.AxisPosition = AxisPosition.Automatic;

            //Applying same color for negativeBar cell as like positive.
            conditionDataBarRule2.FillNegativeColorSameAsPositive = false;
            //Define whether the user need to enter minimum and maximum values or it automatically calculates based on cell values. 
            conditionDataBarRule2.AutoCalculateMinMax = true;

            //Setting appearance for Positive cells.
            conditionDataBarRule2.PositiveBar.FillStyle = FillStyle.Gradient;
            conditionDataBarRule2.PositiveBar.GradientFillColor1 = Color.DeepSkyBlue;
            conditionDataBarRule2.PositiveBar.GradientFillColor2 = Color.FromArgb(255, 255, 255);
            conditionDataBarRule2.PositiveBar.BorderColor = conditionDataBarRule2.PositiveBar.GradientFillColor1;
            conditionDataBarRule2.NegativeBar.FillStyle = FillStyle.Gradient;

            //Setting appearance for Negative cells.
            conditionDataBarRule2.NegativeBar.GradientFillColor1 = Color.FromArgb(235, 82, 82);
            conditionDataBarRule2.NegativeBar.GradientFillColor2 = Color.FromArgb(254, 255, 255);
            conditionDataBarRule2.NegativeBar.BorderColor = Color.Red;
            conditionDataBarRule1.Name = "ConditionalDataBarRule 1";
            conditionDataBarRule2.Name = "ConditionalDataBarRule 2";

            //Adding ConditionalFormatDataBarRule to the GridConditionalFormatDescriptor by using Rule property.
            gridConditionalFormatDescriptor1.Rules.Add(conditionDataBarRule2);

            conditionDataBarRule1.ColumnName = "Profit";
            conditionDataBarRule1.AxisPosition = AxisPosition.Automatic;

            //Applying same color for negativeBar cell as like positive.
            conditionDataBarRule1.FillNegativeColorSameAsPositive = false;

            //Define whether the user need to enter minimum and maximum values or it automatically calculates based on cell values. 
            conditionDataBarRule1.AutoCalculateMinMax = true;

            conditionDataBarRule1.NegativeBar.FillStyle = FillStyle.Gradient;
            conditionDataBarRule1.PositiveBar.FillStyle = FillStyle.Gradient;

            gridConditionalFormatDescriptor1.Rules.Add(conditionDataBarRule1);

            this.gridGroupingControl1.TableDescriptor.ConditionalFormats.Add(gridConditionalFormatDescriptor1);
        }

        #region "Designer Stuff"

        #region "Find File"

        /// <summary>
        /// Find data file in specified location
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
        /// Dispaly the error message
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
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));           
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.Location = new System.Drawing.Point(12, 7);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(1010, 635);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 18;
            this.gridGroupingControl1.TableOptions.RecordRowHeight = 18;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.VersionInfo = "4.201.0.60";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BorderThickness = 1;
            this.ClientSize = new System.Drawing.Size(1033, 653);
            this.Controls.Add(this.gridGroupingControl1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Data Bars";
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


        #region "Customer Class"
        public class CustomClass : INotifyPropertyChanged
        {
            int productid;
            int supplierid;
            string productname;
            double unitprice;
            double profit;
            public CustomClass(int productid, int supplierid, string productname, double unitprice, double profit)
            {
                this.productid = productid;
                this.supplierid = supplierid;
                this.productname = productname;
                this.unitprice = unitprice;
                this.profit = profit;
            }

            public int ProductID
            {
                get { return productid; }
                set
                {
                    if (productid != value)
                    {
                        productid = value;
                        RaisePropertyChanged("ProductID");
                    }
                }
            }

            public string ProductName
            {
                get { return productname; }
                set
                {
                    if (productname != value)
                    {
                        productname = value;
                        RaisePropertyChanged("ProductName");
                    }
                }
            }
            public int SupplierID
            {
                get { return supplierid; }
                set
                {
                    if (supplierid != value)
                    {
                        supplierid = value;
                        RaisePropertyChanged("SupplierID");
                    }
                    supplierid = value;
                }
            }
            public double UnitPrice
            {
                get { return unitprice; }
                set
                {
                    if (unitprice != value)
                    {
                        unitprice = value;
                        RaisePropertyChanged("UnitPrice");
                    }
                }
            }
            public double Profit
            {
                get { return profit; }
                set
                {
                    if (profit != value)
                    {
                        profit = value;
                        RaisePropertyChanged("Profit");
                    }
                }
            }

            void RaisePropertyChanged(string name)
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(name));
            }

            #region INotifyPropertyChanged Members

            public event PropertyChangedEventHandler PropertyChanged;

            #endregion
        }
        #endregion
    }
}
