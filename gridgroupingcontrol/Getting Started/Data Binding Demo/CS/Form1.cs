#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms.Tools;
using System.Collections;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Tools.Navigation;
using System.IO;
using DataBinding;
using Syncfusion.Windows.Forms;

namespace DataBinding
{
    public partial class Form1 : GridDemoForm
    {
        #region Private Variables
        private DataCollection dataSource;
        private CollectionBaseData collectionBaseSource;
        private BindingList<GenericCollection> genericData;
        private int selectedIndex = 0;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"Common\Images\Grid\Icon\sficon.ico"));
            this.Icon = ico;
            SampleCustomization();
            //to set IBinding List data source as grid's datasource for initial loading.
            SetIBindingSource();
        }
        #endregion

        #region GetIconFile
        /// <summary>
        /// Gets the bitmap file for Form's icon.
        /// </summary>
        /// <param name="bitmapName">bitmap of Form's icon.</param>
        /// <returns>Bitmap.</returns>
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

        #region Sample Customization
        /// <summary>
        /// Sets the proporties to be enabled for the Grid.
        /// </summary>
        public void SampleCustomization()
        {
			this.gridGroupingControl1.TableControl.DpiAware = true;
            //setting metro theme to the grid.
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;

            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.One;

            //to set proportional column resizing to grid.
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;

            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;

            //to hide Caption.
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.ChildGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowCaption = false;

            //to disable AddNewRecord.
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;

            this.gridGroupingControl1.WantTabKey = false;

        }
        #endregion

        #region Events
        void comboBoxAdv1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBoxAdv comboBox = sender as ComboBoxAdv;
            if (comboBox.SelectedIndex != selectedIndex)
            {
                selectedIndex = comboBox.SelectedIndex;
                switch (comboBox.Text)
                {
                    case "IBinding List":
                        SetIBindingSource();
                        break;

                    case "Array List":
                        SetArrayListData();
                        break;

                    case "Collection Base":
                        SetCollectionBaseSource();
                        break;

                    case "Generic Collection":
                        SetGenericCollectionSource();
                        break;

                    case "Observable Collection":
                        SetObservableCollection();
                        break;
                }
            }
        }
        #endregion

        #region IBindingList
        /// <summary>
        /// Sets the IBindingList datasource to Grid.
        /// </summary>
        public void SetIBindingSource()
        {
            //To set IBInding List data source to grid.
            this.gridGroupingControl1.DataSource = null;
            BindingListData bindingList = new BindingListData();
            this.gridGroupingControl1.DataSource = bindingList.Data;
            this.gridGroupingControl1.AllowProportionalColumnSizing = false;

            //To change the HeaderText.
            this.gridGroupingControl1.TableDescriptor.Columns["OrderID"].HeaderText = "Order ID";
            this.gridGroupingControl1.TableDescriptor.Columns["ProductID"].HeaderText = "Product ID";
            this.gridGroupingControl1.TableDescriptor.Columns["UnitPrice"].HeaderText = "Unit Price";
        }
        #endregion

        #region Array List
        /// <summary>
        /// Sets the ArrayList datasource to the Grid.
        /// </summary>
        private void SetArrayListData()
        {
            #region Adding data to the ArrayList
            ChildList cl1 = new ChildList();
            cl1.Add(new ArrayListData(1, "Condiments", "Sweets", ""));
            ChildList cl2 = new ChildList();
            cl2.Add(new ArrayListData(2, "Confections", "Deserts", ""));
            cl2.Add(new ArrayListData(2, "Confections", "Candies", ""));
            ChildList cl3 = new ChildList();
            cl3.Add(new ArrayListData(3, "Grains/Cereals", "Breads", ""));
            cl3.Add(new ArrayListData(3, "Grains/Cereals", "Pasta", ""));
            cl3.Add(new ArrayListData(3, "Grains/Cereals", "Cereal", ""));
            ChildList cl4 = new ChildList();
            cl4.Add(new ArrayListData(4, "Meat/Poultry", "Prepared meats", ""));
            ChildList cl5 = new ChildList();
            cl5.Add(new ArrayListData(5, "Produce", "Dried fruit", ""));
            cl5.Add(new ArrayListData(5, "Produce", "Bean curd", ""));
            ChildList cl6 = new ChildList();
            cl6.Add(new ArrayListData(6, "Seafood", "Fish", ""));
            cl6.Add(new ArrayListData(6, "Seafood", "Seeweed", ""));

            ArrayList al = new ArrayList();
            al.Add(new ParentItem("Condiments", "Charlotte Cooper", "Bigfoot Breweries", cl1));
            al.Add(new ParentItem("Confections", "Regina Murphy", "Grandma Kelly's Homestead", cl2));
            al.Add(new ParentItem("Grains/Cereals", "Jean-Guy Lauzon", "Ma Maison", cl3));
            al.Add(new ParentItem("Meat/Poultry", "Shelley Burke", "New Orleans Cajun Delights", cl4));
            al.Add(new ParentItem("Produce", "Mayumi Ohno", "Mayumi's", cl5));
            al.Add(new ParentItem("Seafood", "Robb Merchant", "New England Seafood Cannery", cl6));
            al.Add(new ParentItem("Condiments", "Charlotte Cooper", "Bigfoot Breweries", cl1));
            al.Add(new ParentItem("Confections", "Regina Murphy", "Grandma Kelly's Homestead", cl2));
            al.Add(new ParentItem("Grains/Cereals", "Jean-Guy Lauzon", "Ma Maison", cl3));
            al.Add(new ParentItem("Meat/Poultry", "Shelley Burke", "New Orleans Cajun Delights", cl4));
            al.Add(new ParentItem("Produce", "Mayumi Ohno", "Mayumi's", cl5));
            al.Add(new ParentItem("Seafood", "Robb Merchant", "New England Seafood Cannery", cl6));
            al.Add(new ParentItem("Condiments", "Charlotte Cooper", "Bigfoot Breweries", cl1));
            al.Add(new ParentItem("Confections", "Regina Murphy", "Grandma Kelly's Homestead", cl2));
            al.Add(new ParentItem("Grains/Cereals", "Jean-Guy Lauzon", "Ma Maison", cl3));
            al.Add(new ParentItem("Meat/Poultry", "Shelley Burke", "New Orleans Cajun Delights", cl4));
            al.Add(new ParentItem("Produce", "Mayumi Ohno", "Mayumi's", cl5));
            al.Add(new ParentItem("Seafood", "Robb Merchant", "New England Seafood Cannery", cl6));
            al.Add(new ParentItem("Condiments", "Charlotte Cooper", "Bigfoot Breweries", cl1));
            al.Add(new ParentItem("Confections", "Regina Murphy", "Grandma Kelly's Homestead", cl2));
            al.Add(new ParentItem("Grains/Cereals", "Jean-Guy Lauzon", "Ma Maison", cl3));
            al.Add(new ParentItem("Meat/Poultry", "Shelley Burke", "New Orleans Cajun Delights", cl4));
            al.Add(new ParentItem("Produce", "Mayumi Ohno", "Mayumi's", cl5));
            al.Add(new ParentItem("Seafood", "Robb Merchant", "New England Seafood Cannery", cl6));
            al.Add(new ParentItem("Condiments", "Charlotte Cooper", "Bigfoot Breweries", cl1));
            al.Add(new ParentItem("Confections", "Regina Murphy", "Grandma Kelly's Homestead", cl2));
            al.Add(new ParentItem("Grains/Cereals", "Jean-Guy Lauzon", "Ma Maison", cl3));
            al.Add(new ParentItem("Meat/Poultry", "Shelley Burke", "New Orleans Cajun Delights", cl4));
            al.Add(new ParentItem("Produce", "Mayumi Ohno", "Mayumi's", cl5));
            al.Add(new ParentItem("Seafood", "Robb Merchant", "New England Seafood Cannery", cl6));
            #endregion
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            //Assigning DataSource to grid
            this.gridGroupingControl1.DataSource = null;
            this.gridGroupingControl1.DataSource = al;
            this.gridGroupingControl1.Engine.SetSourceList(al);
            //A relationship between tables established by the gridrelation descriptor's UniformChildList.
            GridRelationDescriptor grd = new GridRelationDescriptor();
            grd.RelationKind = RelationKind.UniformChildList;
            grd.MappingName = "Child";//name of  property with child arraylist

            this.gridGroupingControl1.Engine.SourceListSet.Clear();
            this.gridGroupingControl1.TableDescriptor.Columns.Clear();
            //Adding columns to the Grid table descriptor.
            this.gridGroupingControl1.TableDescriptor.Columns.Add("CategoryName");
            this.gridGroupingControl1.TableDescriptor.Columns.Add("SupplierName");
            this.gridGroupingControl1.TableDescriptor.Columns.Add("CompanyName");
            this.gridGroupingControl1.TableDescriptor.Relations.Add(grd);
            //Setting Column header text.
            this.gridGroupingControl1.TableDescriptor.Columns["CategoryName"].HeaderText = "Category Name";
            this.gridGroupingControl1.TableDescriptor.Columns["SupplierName"].HeaderText = "Supplier Name";
            this.gridGroupingControl1.TableDescriptor.Columns["CompanyName"].HeaderText = "Company Name";
            //Setting AllowNew and ReadOnly property value.

            foreach (GridTableDescriptor td in this.gridGroupingControl1.Engine.EnumerateTableDescriptor())
            {
                if (td.ParentTableDescriptor != null)
                {
                    td.Columns["CategoryName"].HeaderText = "Category Name";
                    td.Columns["CategoryID"].HeaderText = "Category ID";
                    td.Columns["OtherInfo"].HeaderText = "Other Info";
                }
            }

            this.gridGroupingControl1.GetTable("Child").DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            
        }
        #endregion

        #region Collection Base
        /// <summary>
        /// Sets the CollectionBase datasource to the Grid.
        /// </summary>
        void SetCollectionBaseSource()
        {
            collectionBaseSource = new CollectionBaseData();
            collectionBaseSource.Add(new Data(1, "Condiments", "Sweets", "Out of stock"));
            collectionBaseSource.Add(new Data(2, "Confections", "Deserts and Candies", "Out of stock"));
            collectionBaseSource.Add(new Data(3, "Grains/Cereals", "Breads, pasta and cereal", "Available"));
            collectionBaseSource.Add(new Data(4, "Meat/Poultry", "Prepared meats", "Available"));
            collectionBaseSource.Add(new Data(5, "Produce", "Dried fruit and bean curd", "Out of stock"));
            collectionBaseSource.Add(new Data(6, "Seafood", "Seeweed and fish", "Available"));
            collectionBaseSource.Add(new Data(7, "Hot Beverages ", " coffees", "Available"));
            collectionBaseSource.Add(new Data(8, "Healthy ", "Sweet potatoes", "Available"));
            collectionBaseSource.Add(new Data(9, "Digest", "Cod liver oil", "Out of stock"));
            collectionBaseSource.Add(new Data(10, "Cold Beverages", "Tea", "Available"));
            collectionBaseSource.Add(new Data(11, "Biodynamic Agriculture", "Seeweed and fish", "Available"));
            collectionBaseSource.Add(new Data(1, "Condiments", "Sweets", "Out of stock"));
            collectionBaseSource.Add(new Data(2, "Confections", "Deserts and Candies", "Out of stock"));
            collectionBaseSource.Add(new Data(3, "Grains/Cereals", "Breads, pasta and cereal", "Available"));
            collectionBaseSource.Add(new Data(4, "Meat/Poultry", "Prepared meats", "Available"));
            collectionBaseSource.Add(new Data(5, "Produce", "Dried fruit and bean curd", "Out of stock"));
            collectionBaseSource.Add(new Data(6, "Seafood", "Seeweed and fish", "Available"));
            collectionBaseSource.Add(new Data(7, "Hot Beverages ", " coffees", "Available"));
            collectionBaseSource.Add(new Data(8, "Healthy ", "Sweet potatoes", "Available"));
            collectionBaseSource.Add(new Data(9, "Digest", "Cod liver oil", "Out of stock"));
            collectionBaseSource.Add(new Data(10, "Cold Beverages", "Tea", "Available"));
            collectionBaseSource.Add(new Data(11, "Biodynamic Agriculture", "Seeweed and fish", "Available"));
            collectionBaseSource.Add(new Data(1, "Condiments", "Sweets", "Out of stock"));
            collectionBaseSource.Add(new Data(2, "Confections", "Deserts and Candies", "Out of stock"));
            collectionBaseSource.Add(new Data(3, "Grains/Cereals", "Breads, pasta and cereal", "Available"));
            collectionBaseSource.Add(new Data(4, "Meat/Poultry", "Prepared meats", "Available"));
            collectionBaseSource.Add(new Data(5, "Produce", "Dried fruit and bean curd", "Out of stock"));
            collectionBaseSource.Add(new Data(6, "Seafood", "Seeweed and fish", "Available"));
            collectionBaseSource.Add(new Data(7, "Hot Beverages ", " coffees", "Available"));
            collectionBaseSource.Add(new Data(8, "Healthy ", "Sweet potatoes", "Available"));
            collectionBaseSource.Add(new Data(9, "Digest", "Cod liver oil", "Out of stock"));
            collectionBaseSource.Add(new Data(10, "Cold Beverages", "Tea", "Available"));
            collectionBaseSource.Add(new Data(11, "Biodynamic Agriculture", "Seeweed and fish", "Available"));
            collectionBaseSource.Add(new Data(1, "Condiments", "Sweets", "Out of stock"));
            collectionBaseSource.Add(new Data(2, "Confections", "Deserts and Candies", "Out of stock"));
            collectionBaseSource.Add(new Data(3, "Grains/Cereals", "Breads, pasta and cereal", "Available"));
            collectionBaseSource.Add(new Data(4, "Meat/Poultry", "Prepared meats", "Available"));
            collectionBaseSource.Add(new Data(5, "Produce", "Dried fruit and bean curd", "Out of stock"));
            collectionBaseSource.Add(new Data(6, "Seafood", "Seeweed and fish", "Available"));
            collectionBaseSource.Add(new Data(7, "Hot Beverages ", " coffees", "Available"));
            collectionBaseSource.Add(new Data(8, "Healthy ", "Sweet potatoes", "Available"));
            collectionBaseSource.Add(new Data(9, "Digest", "Cod liver oil", "Out of stock"));
            collectionBaseSource.Add(new Data(10, "Cold Beverages", "Tea", "Available"));
            collectionBaseSource.Add(new Data(11, "Biodynamic Agriculture", "Seeweed and fish", "Available"));

            //Assigning data source for grid.
            this.gridGroupingControl1.DataSource = null;
            this.gridGroupingControl1.DataSource = collectionBaseSource;

            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            //Setting Column header text.
            this.gridGroupingControl1.TableDescriptor.Columns["CategoryName"].HeaderText = "Category Name";
            this.gridGroupingControl1.TableDescriptor.Columns["CategoryID"].HeaderText = "Supplier Name";
            this.gridGroupingControl1.TableDescriptor.Columns["OtherInfo"].HeaderText = "Other Info";
        }
        #endregion

        #region Generic Collection
        /// <summary>
        /// Sets GenericCollection datasource to the Grid.
        /// </summary>
        void SetGenericCollectionSource()
        {
            // Adding Values for Customer class using BindingList
            genericData = new BindingList<GenericCollection>();
            genericData.Add(new GenericCollection(0101, "Charlotte", "Cooper", "49 Gilbert St.", "London"));
            genericData.Add(new GenericCollection(0102, "Shelley", "Burke", "P.O. Box 78934", "New Orleans"));
            genericData.Add(new GenericCollection(0103, "Regina", "Murphy", "707 Oxford Rd.", "Ann Arbor"));
            genericData.Add(new GenericCollection(0104, "Yoshi", "Nagase", "9-8 Sekimai Musashino-shi", "Tokyo"));
            genericData.Add(new GenericCollection(0105, "Mayumi", "Ohno", "Calle del Rosal 4", "Oviedo"));
            genericData.Add(new GenericCollection(0106, "Ian", "Devling", "92 Setsuko Chuo-ku", "Osaka"));
            genericData.Add(new GenericCollection(0107, "Peter", "Wilson", "74 Rose St. Moonie Ponds", "Melbourne"));
            genericData.Add(new GenericCollection(0108, "Lars", "Peterson", "29 King's Way", "Manchester"));
            genericData.Add(new GenericCollection(0109, "Carlos", "Diaz", "Kaloadagatan 13", "Goteborg"));
            genericData.Add(new GenericCollection(0110, "Petra", "Winkler", "Av. das Americanas 12.890", "Sao Paulo"));
            genericData.Add(new GenericCollection(0111, "Martin", "Bein", "Tiergartenstrasse 5", "Berlin"));
            genericData.Add(new GenericCollection(0112, "Sven", "Petersen", "Bogenallee 51", "Frankfurt"));
            genericData.Add(new GenericCollection(0101, "Charlotte", "Cooper", "49 Gilbert St.", "London"));
            genericData.Add(new GenericCollection(0102, "Shelley", "Burke", "P.O. Box 78934", "New Orleans"));
            genericData.Add(new GenericCollection(0103, "Regina", "Murphy", "707 Oxford Rd.", "Ann Arbor"));
            genericData.Add(new GenericCollection(0104, "Yoshi", "Nagase", "9-8 Sekimai Musashino-shi", "Tokyo"));
            genericData.Add(new GenericCollection(0105, "Mayumi", "Ohno", "Calle del Rosal 4", "Oviedo"));
            genericData.Add(new GenericCollection(0106, "Ian", "Devling", "92 Setsuko Chuo-ku", "Osaka"));
            genericData.Add(new GenericCollection(0107, "Peter", "Wilson", "74 Rose St. Moonie Ponds", "Melbourne"));
            genericData.Add(new GenericCollection(0108, "Lars", "Peterson", "29 King's Way", "Manchester"));
            genericData.Add(new GenericCollection(0109, "Carlos", "Diaz", "Kaloadagatan 13", "Goteborg"));
            genericData.Add(new GenericCollection(0110, "Petra", "Winkler", "Av. das Americanas 12.890", "Sao Paulo"));
            genericData.Add(new GenericCollection(0111, "Martin", "Bein", "Tiergartenstrasse 5", "Berlin"));
            genericData.Add(new GenericCollection(0112, "Sven", "Petersen", "Bogenallee 51", "Frankfurt"));
            genericData.Add(new GenericCollection(0101, "Charlotte", "Cooper", "49 Gilbert St.", "London"));
            genericData.Add(new GenericCollection(0102, "Shelley", "Burke", "P.O. Box 78934", "New Orleans"));
            genericData.Add(new GenericCollection(0103, "Regina", "Murphy", "707 Oxford Rd.", "Ann Arbor"));
            genericData.Add(new GenericCollection(0104, "Yoshi", "Nagase", "9-8 Sekimai Musashino-shi", "Tokyo"));
            genericData.Add(new GenericCollection(0105, "Mayumi", "Ohno", "Calle del Rosal 4", "Oviedo"));
            genericData.Add(new GenericCollection(0106, "Ian", "Devling", "92 Setsuko Chuo-ku", "Osaka"));
            genericData.Add(new GenericCollection(0107, "Peter", "Wilson", "74 Rose St. Moonie Ponds", "Melbourne"));
            genericData.Add(new GenericCollection(0108, "Lars", "Peterson", "29 King's Way", "Manchester"));
            genericData.Add(new GenericCollection(0109, "Carlos", "Diaz", "Kaloadagatan 13", "Goteborg"));
            genericData.Add(new GenericCollection(0110, "Petra", "Winkler", "Av. das Americanas 12.890", "Sao Paulo"));
            genericData.Add(new GenericCollection(0111, "Martin", "Bein", "Tiergartenstrasse 5", "Berlin"));
            genericData.Add(new GenericCollection(0112, "Sven", "Petersen", "Bogenallee 51", "Frankfurt"));

            this.gridGroupingControl1.DataSource = null;
            this.gridGroupingControl1.DataSource = genericData;

            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            //to change header text of FirstName and LastName column.
            this.gridGroupingControl1.TableDescriptor.Columns["FirstName"].HeaderText = "First Name";
            this.gridGroupingControl1.TableDescriptor.Columns["LastName"].HeaderText = "Last Name";
        }
        #endregion

        #region Observable Collection
        void SetObservableCollection()
        {

            this.gridGroupingControl1.DataSource = null;
            this.gridGroupingControl1.DataSource = new DataBinding.Customer();
            this.gridGroupingControl1.AllowProportionalColumnSizing = false;
            this.gridGroupingControl1.TableDescriptor.Columns["OrderID"].HeaderText = "Order ID";
            this.gridGroupingControl1.TableDescriptor.Columns["CustomerID"].HeaderText = "Customer ID";
            this.gridGroupingControl1.TableDescriptor.Columns["EmployeeID"].HeaderText = "Employee ID";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipName"].HeaderText = "Ship Name";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipAddress"].HeaderText = "Ship Address";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipCity"].HeaderText = "Ship City";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipRegion"].HeaderText = "Ship Region";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipPostalCode"].HeaderText = "Ship Postal Code";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipCountry"].HeaderText = "Ship Country";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipVia"].HeaderText = "Ship Via";
            this.gridGroupingControl1.TableDescriptor.Columns["OrderDate"].HeaderText = "Order Date";
            this.gridGroupingControl1.TableDescriptor.Columns["RequiredDate"].HeaderText = "Required Date";
            this.gridGroupingControl1.TableDescriptor.Columns["ShippedDate"].HeaderText = "ShippedDate";

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;

            this.gridGroupingControl1.TableDescriptor.Relations.Clear();

        }
        #endregion
    }
}
