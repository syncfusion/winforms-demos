#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

namespace EmployeeTerritoryOrder {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class NorthwindDataSet : DataSet {
        
        private EmployeesDataTable tableEmployees;
        
        private EmployeeTerritoriesDataTable tableEmployeeTerritories;
        
        private RegionDataTable tableRegion;
        
        private TerritoriesDataTable tableTerritories;
        
        private OrdersDataTable tableOrders;
        
        private Order_DetailsDataTable tableOrder_Details;
        
        private ProductsDataTable tableProducts;
        
        private SuppliersDataTable tableSuppliers;
        
        private CategoriesDataTable tableCategories;
        
        private ShippersDataTable tableShippers;
        
        private CustomersDataTable tableCustomers;
        
        private DataRelation relationEmployeesEmployeeTerritories;
        
        private DataRelation relationEmployeesOrders;
        
        private DataRelation relationOrdersOrder_x0020_Details;
        
        public NorthwindDataSet() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected NorthwindDataSet(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Employees"] != null)) {
                    this.Tables.Add(new EmployeesDataTable(ds.Tables["Employees"]));
                }
                if ((ds.Tables["EmployeeTerritories"] != null)) {
                    this.Tables.Add(new EmployeeTerritoriesDataTable(ds.Tables["EmployeeTerritories"]));
                }
                if ((ds.Tables["Region"] != null)) {
                    this.Tables.Add(new RegionDataTable(ds.Tables["Region"]));
                }
                if ((ds.Tables["Territories"] != null)) {
                    this.Tables.Add(new TerritoriesDataTable(ds.Tables["Territories"]));
                }
                if ((ds.Tables["Orders"] != null)) {
                    this.Tables.Add(new OrdersDataTable(ds.Tables["Orders"]));
                }
                if ((ds.Tables["Order Details"] != null)) {
                    this.Tables.Add(new Order_DetailsDataTable(ds.Tables["Order Details"]));
                }
                if ((ds.Tables["Products"] != null)) {
                    this.Tables.Add(new ProductsDataTable(ds.Tables["Products"]));
                }
                if ((ds.Tables["Suppliers"] != null)) {
                    this.Tables.Add(new SuppliersDataTable(ds.Tables["Suppliers"]));
                }
                if ((ds.Tables["Categories"] != null)) {
                    this.Tables.Add(new CategoriesDataTable(ds.Tables["Categories"]));
                }
                if ((ds.Tables["Shippers"] != null)) {
                    this.Tables.Add(new ShippersDataTable(ds.Tables["Shippers"]));
                }
                if ((ds.Tables["Customers"] != null)) {
                    this.Tables.Add(new CustomersDataTable(ds.Tables["Customers"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public EmployeesDataTable Employees {
            get {
                return this.tableEmployees;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public EmployeeTerritoriesDataTable EmployeeTerritories {
            get {
                return this.tableEmployeeTerritories;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public RegionDataTable Region {
            get {
                return this.tableRegion;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public TerritoriesDataTable Territories {
            get {
                return this.tableTerritories;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public OrdersDataTable Orders {
            get {
                return this.tableOrders;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public Order_DetailsDataTable Order_Details {
            get {
                return this.tableOrder_Details;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public ProductsDataTable Products {
            get {
                return this.tableProducts;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public SuppliersDataTable Suppliers {
            get {
                return this.tableSuppliers;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public CategoriesDataTable Categories {
            get {
                return this.tableCategories;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public ShippersDataTable Shippers {
            get {
                return this.tableShippers;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public CustomersDataTable Customers {
            get {
                return this.tableCustomers;
            }
        }
        
        public override DataSet Clone() {
            NorthwindDataSet cln = ((NorthwindDataSet)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["Employees"] != null)) {
                this.Tables.Add(new EmployeesDataTable(ds.Tables["Employees"]));
            }
            if ((ds.Tables["EmployeeTerritories"] != null)) {
                this.Tables.Add(new EmployeeTerritoriesDataTable(ds.Tables["EmployeeTerritories"]));
            }
            if ((ds.Tables["Region"] != null)) {
                this.Tables.Add(new RegionDataTable(ds.Tables["Region"]));
            }
            if ((ds.Tables["Territories"] != null)) {
                this.Tables.Add(new TerritoriesDataTable(ds.Tables["Territories"]));
            }
            if ((ds.Tables["Orders"] != null)) {
                this.Tables.Add(new OrdersDataTable(ds.Tables["Orders"]));
            }
            if ((ds.Tables["Order Details"] != null)) {
                this.Tables.Add(new Order_DetailsDataTable(ds.Tables["Order Details"]));
            }
            if ((ds.Tables["Products"] != null)) {
                this.Tables.Add(new ProductsDataTable(ds.Tables["Products"]));
            }
            if ((ds.Tables["Suppliers"] != null)) {
                this.Tables.Add(new SuppliersDataTable(ds.Tables["Suppliers"]));
            }
            if ((ds.Tables["Categories"] != null)) {
                this.Tables.Add(new CategoriesDataTable(ds.Tables["Categories"]));
            }
            if ((ds.Tables["Shippers"] != null)) {
                this.Tables.Add(new ShippersDataTable(ds.Tables["Shippers"]));
            }
            if ((ds.Tables["Customers"] != null)) {
                this.Tables.Add(new CustomersDataTable(ds.Tables["Customers"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableEmployees = ((EmployeesDataTable)(this.Tables["Employees"]));
            if ((this.tableEmployees != null)) {
                this.tableEmployees.InitVars();
            }
            this.tableEmployeeTerritories = ((EmployeeTerritoriesDataTable)(this.Tables["EmployeeTerritories"]));
            if ((this.tableEmployeeTerritories != null)) {
                this.tableEmployeeTerritories.InitVars();
            }
            this.tableRegion = ((RegionDataTable)(this.Tables["Region"]));
            if ((this.tableRegion != null)) {
                this.tableRegion.InitVars();
            }
            this.tableTerritories = ((TerritoriesDataTable)(this.Tables["Territories"]));
            if ((this.tableTerritories != null)) {
                this.tableTerritories.InitVars();
            }
            this.tableOrders = ((OrdersDataTable)(this.Tables["Orders"]));
            if ((this.tableOrders != null)) {
                this.tableOrders.InitVars();
            }
            this.tableOrder_Details = ((Order_DetailsDataTable)(this.Tables["Order Details"]));
            if ((this.tableOrder_Details != null)) {
                this.tableOrder_Details.InitVars();
            }
            this.tableProducts = ((ProductsDataTable)(this.Tables["Products"]));
            if ((this.tableProducts != null)) {
                this.tableProducts.InitVars();
            }
            this.tableSuppliers = ((SuppliersDataTable)(this.Tables["Suppliers"]));
            if ((this.tableSuppliers != null)) {
                this.tableSuppliers.InitVars();
            }
            this.tableCategories = ((CategoriesDataTable)(this.Tables["Categories"]));
            if ((this.tableCategories != null)) {
                this.tableCategories.InitVars();
            }
            this.tableShippers = ((ShippersDataTable)(this.Tables["Shippers"]));
            if ((this.tableShippers != null)) {
                this.tableShippers.InitVars();
            }
            this.tableCustomers = ((CustomersDataTable)(this.Tables["Customers"]));
            if ((this.tableCustomers != null)) {
                this.tableCustomers.InitVars();
            }
            this.relationEmployeesEmployeeTerritories = this.Relations["EmployeesEmployeeTerritories"];
            this.relationEmployeesOrders = this.Relations["EmployeesOrders"];
            this.relationOrdersOrder_x0020_Details = this.Relations["OrdersOrder_x0020_Details"];
        }
        
        private void InitClass() {
            this.DataSetName = "NorthwindDataSet";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/NorthwindDataSet.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableEmployees = new EmployeesDataTable();
            this.Tables.Add(this.tableEmployees);
            this.tableEmployeeTerritories = new EmployeeTerritoriesDataTable();
            this.Tables.Add(this.tableEmployeeTerritories);
            this.tableRegion = new RegionDataTable();
            this.Tables.Add(this.tableRegion);
            this.tableTerritories = new TerritoriesDataTable();
            this.Tables.Add(this.tableTerritories);
            this.tableOrders = new OrdersDataTable();
            this.Tables.Add(this.tableOrders);
            this.tableOrder_Details = new Order_DetailsDataTable();
            this.Tables.Add(this.tableOrder_Details);
            this.tableProducts = new ProductsDataTable();
            this.Tables.Add(this.tableProducts);
            this.tableSuppliers = new SuppliersDataTable();
            this.Tables.Add(this.tableSuppliers);
            this.tableCategories = new CategoriesDataTable();
            this.Tables.Add(this.tableCategories);
            this.tableShippers = new ShippersDataTable();
            this.Tables.Add(this.tableShippers);
            this.tableCustomers = new CustomersDataTable();
            this.Tables.Add(this.tableCustomers);
            ForeignKeyConstraint fkc;
            fkc = new ForeignKeyConstraint("EmployeesEmployeeTerritories", new DataColumn[] {
                        this.tableEmployees.EmployeeIDColumn}, new DataColumn[] {
                        this.tableEmployeeTerritories.EmployeeIDColumn});
            this.tableEmployeeTerritories.Constraints.Add(fkc);
            fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None;
            fkc.DeleteRule = System.Data.Rule.Cascade;
            fkc.UpdateRule = System.Data.Rule.Cascade;
            fkc = new ForeignKeyConstraint("TerritoriesEmployeeTerritories", new DataColumn[] {
                        this.tableTerritories.TerritoryIDColumn}, new DataColumn[] {
                        this.tableEmployeeTerritories.TerritoryIDColumn});
            this.tableEmployeeTerritories.Constraints.Add(fkc);
            fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None;
            fkc.DeleteRule = System.Data.Rule.Cascade;
            fkc.UpdateRule = System.Data.Rule.Cascade;
            fkc = new ForeignKeyConstraint("RegionTerritories", new DataColumn[] {
                        this.tableRegion.RegionIDColumn}, new DataColumn[] {
                        this.tableTerritories.RegionIDColumn});
            this.tableTerritories.Constraints.Add(fkc);
            fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None;
            fkc.DeleteRule = System.Data.Rule.Cascade;
            fkc.UpdateRule = System.Data.Rule.Cascade;
            fkc = new ForeignKeyConstraint("EmployeesOrders", new DataColumn[] {
                        this.tableEmployees.EmployeeIDColumn}, new DataColumn[] {
                        this.tableOrders.EmployeeIDColumn});
            this.tableOrders.Constraints.Add(fkc);
            fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None;
            fkc.DeleteRule = System.Data.Rule.Cascade;
            fkc.UpdateRule = System.Data.Rule.Cascade;
            fkc = new ForeignKeyConstraint("ShippersOrders", new DataColumn[] {
                        this.tableShippers.ShipperIDColumn}, new DataColumn[] {
                        this.tableOrders.ShipViaColumn});
            this.tableOrders.Constraints.Add(fkc);
            fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None;
            fkc.DeleteRule = System.Data.Rule.Cascade;
            fkc.UpdateRule = System.Data.Rule.Cascade;
            fkc = new ForeignKeyConstraint("CustomersOrders", new DataColumn[] {
                        this.tableCustomers.CustomerIDColumn}, new DataColumn[] {
                        this.tableOrders.CustomerIDColumn});
            this.tableOrders.Constraints.Add(fkc);
            fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None;
            fkc.DeleteRule = System.Data.Rule.Cascade;
            fkc.UpdateRule = System.Data.Rule.Cascade;
            fkc = new ForeignKeyConstraint("OrdersOrder_x0020_Details", new DataColumn[] {
                        this.tableOrders.OrderIDColumn}, new DataColumn[] {
                        this.tableOrder_Details.OrderIDColumn});
            this.tableOrder_Details.Constraints.Add(fkc);
            fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None;
            fkc.DeleteRule = System.Data.Rule.Cascade;
            fkc.UpdateRule = System.Data.Rule.Cascade;
            fkc = new ForeignKeyConstraint("ProductsOrder_x0020_Details", new DataColumn[] {
                        this.tableProducts.ProductIDColumn}, new DataColumn[] {
                        this.tableOrder_Details.ProductIDColumn});
            this.tableOrder_Details.Constraints.Add(fkc);
            fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None;
            fkc.DeleteRule = System.Data.Rule.Cascade;
            fkc.UpdateRule = System.Data.Rule.Cascade;
            fkc = new ForeignKeyConstraint("SuppliersProducts", new DataColumn[] {
                        this.tableSuppliers.SupplierIDColumn}, new DataColumn[] {
                        this.tableProducts.SupplierIDColumn});
            this.tableProducts.Constraints.Add(fkc);
            fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None;
            fkc.DeleteRule = System.Data.Rule.Cascade;
            fkc.UpdateRule = System.Data.Rule.Cascade;
            fkc = new ForeignKeyConstraint("CategoriesProducts", new DataColumn[] {
                        this.tableCategories.CategoryIDColumn}, new DataColumn[] {
                        this.tableProducts.CategoryIDColumn});
            this.tableProducts.Constraints.Add(fkc);
            fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None;
            fkc.DeleteRule = System.Data.Rule.Cascade;
            fkc.UpdateRule = System.Data.Rule.Cascade;
            this.relationEmployeesEmployeeTerritories = new DataRelation("EmployeesEmployeeTerritories", new DataColumn[] {
                        this.tableEmployees.EmployeeIDColumn}, new DataColumn[] {
                        this.tableEmployeeTerritories.EmployeeIDColumn}, false);
            this.Relations.Add(this.relationEmployeesEmployeeTerritories);
            this.relationEmployeesOrders = new DataRelation("EmployeesOrders", new DataColumn[] {
                        this.tableEmployees.EmployeeIDColumn}, new DataColumn[] {
                        this.tableOrders.EmployeeIDColumn}, false);
            this.Relations.Add(this.relationEmployeesOrders);
            this.relationOrdersOrder_x0020_Details = new DataRelation("OrdersOrder_x0020_Details", new DataColumn[] {
                        this.tableOrders.OrderIDColumn}, new DataColumn[] {
                        this.tableOrder_Details.OrderIDColumn}, false);
            this.Relations.Add(this.relationOrdersOrder_x0020_Details);
        }
        
        private bool ShouldSerializeEmployees() {
            return false;
        }
        
        private bool ShouldSerializeEmployeeTerritories() {
            return false;
        }
        
        private bool ShouldSerializeRegion() {
            return false;
        }
        
        private bool ShouldSerializeTerritories() {
            return false;
        }
        
        private bool ShouldSerializeOrders() {
            return false;
        }
        
        private bool ShouldSerializeOrder_Details() {
            return false;
        }
        
        private bool ShouldSerializeProducts() {
            return false;
        }
        
        private bool ShouldSerializeSuppliers() {
            return false;
        }
        
        private bool ShouldSerializeCategories() {
            return false;
        }
        
        private bool ShouldSerializeShippers() {
            return false;
        }
        
        private bool ShouldSerializeCustomers() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void EmployeesRowChangeEventHandler(object sender, EmployeesRowChangeEvent e);
        
        public delegate void EmployeeTerritoriesRowChangeEventHandler(object sender, EmployeeTerritoriesRowChangeEvent e);
        
        public delegate void RegionRowChangeEventHandler(object sender, RegionRowChangeEvent e);
        
        public delegate void TerritoriesRowChangeEventHandler(object sender, TerritoriesRowChangeEvent e);
        
        public delegate void OrdersRowChangeEventHandler(object sender, OrdersRowChangeEvent e);
        
        public delegate void Order_DetailsRowChangeEventHandler(object sender, Order_DetailsRowChangeEvent e);
        
        public delegate void ProductsRowChangeEventHandler(object sender, ProductsRowChangeEvent e);
        
        public delegate void SuppliersRowChangeEventHandler(object sender, SuppliersRowChangeEvent e);
        
        public delegate void CategoriesRowChangeEventHandler(object sender, CategoriesRowChangeEvent e);
        
        public delegate void ShippersRowChangeEventHandler(object sender, ShippersRowChangeEvent e);
        
        public delegate void CustomersRowChangeEventHandler(object sender, CustomersRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EmployeesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnEmployeeID;
            
            private DataColumn columnLastName;
            
            private DataColumn columnFirstName;
            
            private DataColumn columnTitle;
            
            private DataColumn columnTitleOfCourtesy;
            
            private DataColumn columnBirthDate;
            
            private DataColumn columnHireDate;
            
            private DataColumn columnAddress;
            
            private DataColumn columnCity;
            
            private DataColumn columnRegion;
            
            private DataColumn columnPostalCode;
            
            private DataColumn columnCountry;
            
            private DataColumn columnHomePhone;
            
            private DataColumn columnExtension;
            
            private DataColumn columnPhoto;
            
            private DataColumn columnNotes;
            
            private DataColumn columnReportsTo;
            
            private DataColumn columnPhotoPath;
            
            internal EmployeesDataTable() : 
                    base("Employees") {
                this.InitClass();
            }
            
            internal EmployeesDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn EmployeeIDColumn {
                get {
                    return this.columnEmployeeID;
                }
            }
            
            internal DataColumn LastNameColumn {
                get {
                    return this.columnLastName;
                }
            }
            
            internal DataColumn FirstNameColumn {
                get {
                    return this.columnFirstName;
                }
            }
            
            internal DataColumn TitleColumn {
                get {
                    return this.columnTitle;
                }
            }
            
            internal DataColumn TitleOfCourtesyColumn {
                get {
                    return this.columnTitleOfCourtesy;
                }
            }
            
            internal DataColumn BirthDateColumn {
                get {
                    return this.columnBirthDate;
                }
            }
            
            internal DataColumn HireDateColumn {
                get {
                    return this.columnHireDate;
                }
            }
            
            internal DataColumn AddressColumn {
                get {
                    return this.columnAddress;
                }
            }
            
            internal DataColumn CityColumn {
                get {
                    return this.columnCity;
                }
            }
            
            internal DataColumn RegionColumn {
                get {
                    return this.columnRegion;
                }
            }
            
            internal DataColumn PostalCodeColumn {
                get {
                    return this.columnPostalCode;
                }
            }
            
            internal DataColumn CountryColumn {
                get {
                    return this.columnCountry;
                }
            }
            
            internal DataColumn HomePhoneColumn {
                get {
                    return this.columnHomePhone;
                }
            }
            
            internal DataColumn ExtensionColumn {
                get {
                    return this.columnExtension;
                }
            }
            
            internal DataColumn PhotoColumn {
                get {
                    return this.columnPhoto;
                }
            }
            
            internal DataColumn NotesColumn {
                get {
                    return this.columnNotes;
                }
            }
            
            internal DataColumn ReportsToColumn {
                get {
                    return this.columnReportsTo;
                }
            }
            
            internal DataColumn PhotoPathColumn {
                get {
                    return this.columnPhotoPath;
                }
            }
            
            public EmployeesRow this[int index] {
                get {
                    return ((EmployeesRow)(this.Rows[index]));
                }
            }
            
            public event EmployeesRowChangeEventHandler EmployeesRowChanged;
            
            public event EmployeesRowChangeEventHandler EmployeesRowChanging;
            
            public event EmployeesRowChangeEventHandler EmployeesRowDeleted;
            
            public event EmployeesRowChangeEventHandler EmployeesRowDeleting;
            
            public void AddEmployeesRow(EmployeesRow row) {
                this.Rows.Add(row);
            }
            
            public EmployeesRow AddEmployeesRow(
                        string LastName, 
                        string FirstName, 
                        string Title, 
                        string TitleOfCourtesy, 
                        System.DateTime BirthDate, 
                        System.DateTime HireDate, 
                        string Address, 
                        string City, 
                        string Region, 
                        string PostalCode, 
                        string Country, 
                        string HomePhone, 
                        string Extension, 
                        System.Byte[] Photo, 
                        string Notes, 
                        int ReportsTo, 
                        string PhotoPath) {
                EmployeesRow rowEmployeesRow = ((EmployeesRow)(this.NewRow()));
                rowEmployeesRow.ItemArray = new object[] {
                        null,
                        LastName,
                        FirstName,
                        Title,
                        TitleOfCourtesy,
                        BirthDate,
                        HireDate,
                        Address,
                        City,
                        Region,
                        PostalCode,
                        Country,
                        HomePhone,
                        Extension,
                        Photo,
                        Notes,
                        ReportsTo,
                        PhotoPath};
                this.Rows.Add(rowEmployeesRow);
                return rowEmployeesRow;
            }
            
            public EmployeesRow FindByEmployeeID(int EmployeeID) {
                return ((EmployeesRow)(this.Rows.Find(new object[] {
                            EmployeeID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                EmployeesDataTable cln = ((EmployeesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new EmployeesDataTable();
            }
            
            internal void InitVars() {
                this.columnEmployeeID = this.Columns["EmployeeID"];
                this.columnLastName = this.Columns["LastName"];
                this.columnFirstName = this.Columns["FirstName"];
                this.columnTitle = this.Columns["Title"];
                this.columnTitleOfCourtesy = this.Columns["TitleOfCourtesy"];
                this.columnBirthDate = this.Columns["BirthDate"];
                this.columnHireDate = this.Columns["HireDate"];
                this.columnAddress = this.Columns["Address"];
                this.columnCity = this.Columns["City"];
                this.columnRegion = this.Columns["Region"];
                this.columnPostalCode = this.Columns["PostalCode"];
                this.columnCountry = this.Columns["Country"];
                this.columnHomePhone = this.Columns["HomePhone"];
                this.columnExtension = this.Columns["Extension"];
                this.columnPhoto = this.Columns["Photo"];
                this.columnNotes = this.Columns["Notes"];
                this.columnReportsTo = this.Columns["ReportsTo"];
                this.columnPhotoPath = this.Columns["PhotoPath"];
            }
            
            private void InitClass() {
                this.columnEmployeeID = new DataColumn("EmployeeID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnEmployeeID);
                this.columnLastName = new DataColumn("LastName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnLastName);
                this.columnFirstName = new DataColumn("FirstName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFirstName);
                this.columnTitle = new DataColumn("Title", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTitle);
                this.columnTitleOfCourtesy = new DataColumn("TitleOfCourtesy", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTitleOfCourtesy);
                this.columnBirthDate = new DataColumn("BirthDate", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnBirthDate);
                this.columnHireDate = new DataColumn("HireDate", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnHireDate);
                this.columnAddress = new DataColumn("Address", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAddress);
                this.columnCity = new DataColumn("City", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCity);
                this.columnRegion = new DataColumn("Region", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRegion);
                this.columnPostalCode = new DataColumn("PostalCode", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPostalCode);
                this.columnCountry = new DataColumn("Country", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCountry);
                this.columnHomePhone = new DataColumn("HomePhone", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnHomePhone);
                this.columnExtension = new DataColumn("Extension", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnExtension);
                this.columnPhoto = new DataColumn("Photo", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPhoto);
                this.columnNotes = new DataColumn("Notes", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnNotes);
                this.columnReportsTo = new DataColumn("ReportsTo", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnReportsTo);
                this.columnPhotoPath = new DataColumn("PhotoPath", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPhotoPath);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnEmployeeID}, true));
                this.columnEmployeeID.AutoIncrement = true;
                this.columnEmployeeID.AllowDBNull = false;
                this.columnEmployeeID.ReadOnly = true;
                this.columnEmployeeID.Unique = true;
                this.columnLastName.AllowDBNull = false;
                this.columnFirstName.AllowDBNull = false;
            }
            
            public EmployeesRow NewEmployeesRow() {
                return ((EmployeesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new EmployeesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(EmployeesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.EmployeesRowChanged != null)) {
                    this.EmployeesRowChanged(this, new EmployeesRowChangeEvent(((EmployeesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.EmployeesRowChanging != null)) {
                    this.EmployeesRowChanging(this, new EmployeesRowChangeEvent(((EmployeesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.EmployeesRowDeleted != null)) {
                    this.EmployeesRowDeleted(this, new EmployeesRowChangeEvent(((EmployeesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.EmployeesRowDeleting != null)) {
                    this.EmployeesRowDeleting(this, new EmployeesRowChangeEvent(((EmployeesRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveEmployeesRow(EmployeesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EmployeesRow : DataRow {
            
            private EmployeesDataTable tableEmployees;
            
            internal EmployeesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableEmployees = ((EmployeesDataTable)(this.Table));
            }
            
            public int EmployeeID {
                get {
                    return ((int)(this[this.tableEmployees.EmployeeIDColumn]));
                }
                set {
                    this[this.tableEmployees.EmployeeIDColumn] = value;
                }
            }
            
            public string LastName {
                get {
                    return ((string)(this[this.tableEmployees.LastNameColumn]));
                }
                set {
                    this[this.tableEmployees.LastNameColumn] = value;
                }
            }
            
            public string FirstName {
                get {
                    return ((string)(this[this.tableEmployees.FirstNameColumn]));
                }
                set {
                    this[this.tableEmployees.FirstNameColumn] = value;
                }
            }
            
            public string Title {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.TitleColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.TitleColumn] = value;
                }
            }
            
            public string TitleOfCourtesy {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.TitleOfCourtesyColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.TitleOfCourtesyColumn] = value;
                }
            }
            
            public System.DateTime BirthDate {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableEmployees.BirthDateColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.BirthDateColumn] = value;
                }
            }
            
            public System.DateTime HireDate {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableEmployees.HireDateColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.HireDateColumn] = value;
                }
            }
            
            public string Address {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.AddressColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.AddressColumn] = value;
                }
            }
            
            public string City {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.CityColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.CityColumn] = value;
                }
            }
            
            public string Region {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.RegionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.RegionColumn] = value;
                }
            }
            
            public string PostalCode {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.PostalCodeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.PostalCodeColumn] = value;
                }
            }
            
            public string Country {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.CountryColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.CountryColumn] = value;
                }
            }
            
            public string HomePhone {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.HomePhoneColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.HomePhoneColumn] = value;
                }
            }
            
            public string Extension {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.ExtensionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.ExtensionColumn] = value;
                }
            }
            
            public System.Byte[] Photo {
                get {
                    try {
                        return ((System.Byte[])(this[this.tableEmployees.PhotoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.PhotoColumn] = value;
                }
            }
            
            public string Notes {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.NotesColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.NotesColumn] = value;
                }
            }
            
            public int ReportsTo {
                get {
                    try {
                        return ((int)(this[this.tableEmployees.ReportsToColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.ReportsToColumn] = value;
                }
            }
            
            public string PhotoPath {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.PhotoPathColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.PhotoPathColumn] = value;
                }
            }
            
            public bool IsTitleNull() {
                return this.IsNull(this.tableEmployees.TitleColumn);
            }
            
            public void SetTitleNull() {
                this[this.tableEmployees.TitleColumn] = System.Convert.DBNull;
            }
            
            public bool IsTitleOfCourtesyNull() {
                return this.IsNull(this.tableEmployees.TitleOfCourtesyColumn);
            }
            
            public void SetTitleOfCourtesyNull() {
                this[this.tableEmployees.TitleOfCourtesyColumn] = System.Convert.DBNull;
            }
            
            public bool IsBirthDateNull() {
                return this.IsNull(this.tableEmployees.BirthDateColumn);
            }
            
            public void SetBirthDateNull() {
                this[this.tableEmployees.BirthDateColumn] = System.Convert.DBNull;
            }
            
            public bool IsHireDateNull() {
                return this.IsNull(this.tableEmployees.HireDateColumn);
            }
            
            public void SetHireDateNull() {
                this[this.tableEmployees.HireDateColumn] = System.Convert.DBNull;
            }
            
            public bool IsAddressNull() {
                return this.IsNull(this.tableEmployees.AddressColumn);
            }
            
            public void SetAddressNull() {
                this[this.tableEmployees.AddressColumn] = System.Convert.DBNull;
            }
            
            public bool IsCityNull() {
                return this.IsNull(this.tableEmployees.CityColumn);
            }
            
            public void SetCityNull() {
                this[this.tableEmployees.CityColumn] = System.Convert.DBNull;
            }
            
            public bool IsRegionNull() {
                return this.IsNull(this.tableEmployees.RegionColumn);
            }
            
            public void SetRegionNull() {
                this[this.tableEmployees.RegionColumn] = System.Convert.DBNull;
            }
            
            public bool IsPostalCodeNull() {
                return this.IsNull(this.tableEmployees.PostalCodeColumn);
            }
            
            public void SetPostalCodeNull() {
                this[this.tableEmployees.PostalCodeColumn] = System.Convert.DBNull;
            }
            
            public bool IsCountryNull() {
                return this.IsNull(this.tableEmployees.CountryColumn);
            }
            
            public void SetCountryNull() {
                this[this.tableEmployees.CountryColumn] = System.Convert.DBNull;
            }
            
            public bool IsHomePhoneNull() {
                return this.IsNull(this.tableEmployees.HomePhoneColumn);
            }
            
            public void SetHomePhoneNull() {
                this[this.tableEmployees.HomePhoneColumn] = System.Convert.DBNull;
            }
            
            public bool IsExtensionNull() {
                return this.IsNull(this.tableEmployees.ExtensionColumn);
            }
            
            public void SetExtensionNull() {
                this[this.tableEmployees.ExtensionColumn] = System.Convert.DBNull;
            }
            
            public bool IsPhotoNull() {
                return this.IsNull(this.tableEmployees.PhotoColumn);
            }
            
            public void SetPhotoNull() {
                this[this.tableEmployees.PhotoColumn] = System.Convert.DBNull;
            }
            
            public bool IsNotesNull() {
                return this.IsNull(this.tableEmployees.NotesColumn);
            }
            
            public void SetNotesNull() {
                this[this.tableEmployees.NotesColumn] = System.Convert.DBNull;
            }
            
            public bool IsReportsToNull() {
                return this.IsNull(this.tableEmployees.ReportsToColumn);
            }
            
            public void SetReportsToNull() {
                this[this.tableEmployees.ReportsToColumn] = System.Convert.DBNull;
            }
            
            public bool IsPhotoPathNull() {
                return this.IsNull(this.tableEmployees.PhotoPathColumn);
            }
            
            public void SetPhotoPathNull() {
                this[this.tableEmployees.PhotoPathColumn] = System.Convert.DBNull;
            }
            
            public EmployeeTerritoriesRow[] GetEmployeeTerritoriesRows() {
                return ((EmployeeTerritoriesRow[])(this.GetChildRows(this.Table.ChildRelations["EmployeesEmployeeTerritories"])));
            }
            
            public OrdersRow[] GetOrdersRows() {
                return ((OrdersRow[])(this.GetChildRows(this.Table.ChildRelations["EmployeesOrders"])));
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EmployeesRowChangeEvent : EventArgs {
            
            private EmployeesRow eventRow;
            
            private DataRowAction eventAction;
            
            public EmployeesRowChangeEvent(EmployeesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public EmployeesRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EmployeeTerritoriesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnEmployeeID;
            
            private DataColumn columnTerritoryID;
            
            internal EmployeeTerritoriesDataTable() : 
                    base("EmployeeTerritories") {
                this.InitClass();
            }
            
            internal EmployeeTerritoriesDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn EmployeeIDColumn {
                get {
                    return this.columnEmployeeID;
                }
            }
            
            internal DataColumn TerritoryIDColumn {
                get {
                    return this.columnTerritoryID;
                }
            }
            
            public EmployeeTerritoriesRow this[int index] {
                get {
                    return ((EmployeeTerritoriesRow)(this.Rows[index]));
                }
            }
            
            public event EmployeeTerritoriesRowChangeEventHandler EmployeeTerritoriesRowChanged;
            
            public event EmployeeTerritoriesRowChangeEventHandler EmployeeTerritoriesRowChanging;
            
            public event EmployeeTerritoriesRowChangeEventHandler EmployeeTerritoriesRowDeleted;
            
            public event EmployeeTerritoriesRowChangeEventHandler EmployeeTerritoriesRowDeleting;
            
            public void AddEmployeeTerritoriesRow(EmployeeTerritoriesRow row) {
                this.Rows.Add(row);
            }
            
            public EmployeeTerritoriesRow AddEmployeeTerritoriesRow(EmployeesRow parentEmployeesRowByEmployeesEmployeeTerritories, string TerritoryID) {
                EmployeeTerritoriesRow rowEmployeeTerritoriesRow = ((EmployeeTerritoriesRow)(this.NewRow()));
                rowEmployeeTerritoriesRow.ItemArray = new object[] {
                        parentEmployeesRowByEmployeesEmployeeTerritories[0],
                        TerritoryID};
                this.Rows.Add(rowEmployeeTerritoriesRow);
                return rowEmployeeTerritoriesRow;
            }
            
            public EmployeeTerritoriesRow FindByEmployeeIDTerritoryID(int EmployeeID, string TerritoryID) {
                return ((EmployeeTerritoriesRow)(this.Rows.Find(new object[] {
                            EmployeeID,
                            TerritoryID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                EmployeeTerritoriesDataTable cln = ((EmployeeTerritoriesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new EmployeeTerritoriesDataTable();
            }
            
            internal void InitVars() {
                this.columnEmployeeID = this.Columns["EmployeeID"];
                this.columnTerritoryID = this.Columns["TerritoryID"];
            }
            
            private void InitClass() {
                this.columnEmployeeID = new DataColumn("EmployeeID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnEmployeeID);
                this.columnTerritoryID = new DataColumn("TerritoryID", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTerritoryID);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnEmployeeID,
                                this.columnTerritoryID}, true));
                this.columnEmployeeID.AllowDBNull = false;
                this.columnTerritoryID.AllowDBNull = false;
            }
            
            public EmployeeTerritoriesRow NewEmployeeTerritoriesRow() {
                return ((EmployeeTerritoriesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new EmployeeTerritoriesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(EmployeeTerritoriesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.EmployeeTerritoriesRowChanged != null)) {
                    this.EmployeeTerritoriesRowChanged(this, new EmployeeTerritoriesRowChangeEvent(((EmployeeTerritoriesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.EmployeeTerritoriesRowChanging != null)) {
                    this.EmployeeTerritoriesRowChanging(this, new EmployeeTerritoriesRowChangeEvent(((EmployeeTerritoriesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.EmployeeTerritoriesRowDeleted != null)) {
                    this.EmployeeTerritoriesRowDeleted(this, new EmployeeTerritoriesRowChangeEvent(((EmployeeTerritoriesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.EmployeeTerritoriesRowDeleting != null)) {
                    this.EmployeeTerritoriesRowDeleting(this, new EmployeeTerritoriesRowChangeEvent(((EmployeeTerritoriesRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveEmployeeTerritoriesRow(EmployeeTerritoriesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EmployeeTerritoriesRow : DataRow {
            
            private EmployeeTerritoriesDataTable tableEmployeeTerritories;
            
            internal EmployeeTerritoriesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableEmployeeTerritories = ((EmployeeTerritoriesDataTable)(this.Table));
            }
            
            public int EmployeeID {
                get {
                    return ((int)(this[this.tableEmployeeTerritories.EmployeeIDColumn]));
                }
                set {
                    this[this.tableEmployeeTerritories.EmployeeIDColumn] = value;
                }
            }
            
            public string TerritoryID {
                get {
                    return ((string)(this[this.tableEmployeeTerritories.TerritoryIDColumn]));
                }
                set {
                    this[this.tableEmployeeTerritories.TerritoryIDColumn] = value;
                }
            }
            
            public EmployeesRow EmployeesRow {
                get {
                    return ((EmployeesRow)(this.GetParentRow(this.Table.ParentRelations["EmployeesEmployeeTerritories"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["EmployeesEmployeeTerritories"]);
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EmployeeTerritoriesRowChangeEvent : EventArgs {
            
            private EmployeeTerritoriesRow eventRow;
            
            private DataRowAction eventAction;
            
            public EmployeeTerritoriesRowChangeEvent(EmployeeTerritoriesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public EmployeeTerritoriesRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class RegionDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnRegionID;
            
            private DataColumn columnRegionDescription;
            
            internal RegionDataTable() : 
                    base("Region") {
                this.InitClass();
            }
            
            internal RegionDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn RegionIDColumn {
                get {
                    return this.columnRegionID;
                }
            }
            
            internal DataColumn RegionDescriptionColumn {
                get {
                    return this.columnRegionDescription;
                }
            }
            
            public RegionRow this[int index] {
                get {
                    return ((RegionRow)(this.Rows[index]));
                }
            }
            
            public event RegionRowChangeEventHandler RegionRowChanged;
            
            public event RegionRowChangeEventHandler RegionRowChanging;
            
            public event RegionRowChangeEventHandler RegionRowDeleted;
            
            public event RegionRowChangeEventHandler RegionRowDeleting;
            
            public void AddRegionRow(RegionRow row) {
                this.Rows.Add(row);
            }
            
            public RegionRow AddRegionRow(int RegionID, string RegionDescription) {
                RegionRow rowRegionRow = ((RegionRow)(this.NewRow()));
                rowRegionRow.ItemArray = new object[] {
                        RegionID,
                        RegionDescription};
                this.Rows.Add(rowRegionRow);
                return rowRegionRow;
            }
            
            public RegionRow FindByRegionID(int RegionID) {
                return ((RegionRow)(this.Rows.Find(new object[] {
                            RegionID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                RegionDataTable cln = ((RegionDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new RegionDataTable();
            }
            
            internal void InitVars() {
                this.columnRegionID = this.Columns["RegionID"];
                this.columnRegionDescription = this.Columns["RegionDescription"];
            }
            
            private void InitClass() {
                this.columnRegionID = new DataColumn("RegionID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRegionID);
                this.columnRegionDescription = new DataColumn("RegionDescription", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRegionDescription);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnRegionID}, true));
                this.columnRegionID.AllowDBNull = false;
                this.columnRegionID.Unique = true;
                this.columnRegionDescription.AllowDBNull = false;
            }
            
            public RegionRow NewRegionRow() {
                return ((RegionRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new RegionRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(RegionRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.RegionRowChanged != null)) {
                    this.RegionRowChanged(this, new RegionRowChangeEvent(((RegionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.RegionRowChanging != null)) {
                    this.RegionRowChanging(this, new RegionRowChangeEvent(((RegionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.RegionRowDeleted != null)) {
                    this.RegionRowDeleted(this, new RegionRowChangeEvent(((RegionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.RegionRowDeleting != null)) {
                    this.RegionRowDeleting(this, new RegionRowChangeEvent(((RegionRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveRegionRow(RegionRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class RegionRow : DataRow {
            
            private RegionDataTable tableRegion;
            
            internal RegionRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableRegion = ((RegionDataTable)(this.Table));
            }
            
            public int RegionID {
                get {
                    return ((int)(this[this.tableRegion.RegionIDColumn]));
                }
                set {
                    this[this.tableRegion.RegionIDColumn] = value;
                }
            }
            
            public string RegionDescription {
                get {
                    return ((string)(this[this.tableRegion.RegionDescriptionColumn]));
                }
                set {
                    this[this.tableRegion.RegionDescriptionColumn] = value;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class RegionRowChangeEvent : EventArgs {
            
            private RegionRow eventRow;
            
            private DataRowAction eventAction;
            
            public RegionRowChangeEvent(RegionRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public RegionRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class TerritoriesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnTerritoryID;
            
            private DataColumn columnTerritoryDescription;
            
            private DataColumn columnRegionID;
            
            internal TerritoriesDataTable() : 
                    base("Territories") {
                this.InitClass();
            }
            
            internal TerritoriesDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn TerritoryIDColumn {
                get {
                    return this.columnTerritoryID;
                }
            }
            
            internal DataColumn TerritoryDescriptionColumn {
                get {
                    return this.columnTerritoryDescription;
                }
            }
            
            internal DataColumn RegionIDColumn {
                get {
                    return this.columnRegionID;
                }
            }
            
            public TerritoriesRow this[int index] {
                get {
                    return ((TerritoriesRow)(this.Rows[index]));
                }
            }
            
            public event TerritoriesRowChangeEventHandler TerritoriesRowChanged;
            
            public event TerritoriesRowChangeEventHandler TerritoriesRowChanging;
            
            public event TerritoriesRowChangeEventHandler TerritoriesRowDeleted;
            
            public event TerritoriesRowChangeEventHandler TerritoriesRowDeleting;
            
            public void AddTerritoriesRow(TerritoriesRow row) {
                this.Rows.Add(row);
            }
            
            public TerritoriesRow AddTerritoriesRow(string TerritoryID, string TerritoryDescription, int RegionID) {
                TerritoriesRow rowTerritoriesRow = ((TerritoriesRow)(this.NewRow()));
                rowTerritoriesRow.ItemArray = new object[] {
                        TerritoryID,
                        TerritoryDescription,
                        RegionID};
                this.Rows.Add(rowTerritoriesRow);
                return rowTerritoriesRow;
            }
            
            public TerritoriesRow FindByTerritoryID(string TerritoryID) {
                return ((TerritoriesRow)(this.Rows.Find(new object[] {
                            TerritoryID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                TerritoriesDataTable cln = ((TerritoriesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new TerritoriesDataTable();
            }
            
            internal void InitVars() {
                this.columnTerritoryID = this.Columns["TerritoryID"];
                this.columnTerritoryDescription = this.Columns["TerritoryDescription"];
                this.columnRegionID = this.Columns["RegionID"];
            }
            
            private void InitClass() {
                this.columnTerritoryID = new DataColumn("TerritoryID", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTerritoryID);
                this.columnTerritoryDescription = new DataColumn("TerritoryDescription", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTerritoryDescription);
                this.columnRegionID = new DataColumn("RegionID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRegionID);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnTerritoryID}, true));
                this.columnTerritoryID.AllowDBNull = false;
                this.columnTerritoryID.Unique = true;
                this.columnTerritoryDescription.AllowDBNull = false;
                this.columnRegionID.AllowDBNull = false;
            }
            
            public TerritoriesRow NewTerritoriesRow() {
                return ((TerritoriesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new TerritoriesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(TerritoriesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.TerritoriesRowChanged != null)) {
                    this.TerritoriesRowChanged(this, new TerritoriesRowChangeEvent(((TerritoriesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.TerritoriesRowChanging != null)) {
                    this.TerritoriesRowChanging(this, new TerritoriesRowChangeEvent(((TerritoriesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.TerritoriesRowDeleted != null)) {
                    this.TerritoriesRowDeleted(this, new TerritoriesRowChangeEvent(((TerritoriesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.TerritoriesRowDeleting != null)) {
                    this.TerritoriesRowDeleting(this, new TerritoriesRowChangeEvent(((TerritoriesRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveTerritoriesRow(TerritoriesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class TerritoriesRow : DataRow {
            
            private TerritoriesDataTable tableTerritories;
            
            internal TerritoriesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableTerritories = ((TerritoriesDataTable)(this.Table));
            }
            
            public string TerritoryID {
                get {
                    return ((string)(this[this.tableTerritories.TerritoryIDColumn]));
                }
                set {
                    this[this.tableTerritories.TerritoryIDColumn] = value;
                }
            }
            
            public string TerritoryDescription {
                get {
                    return ((string)(this[this.tableTerritories.TerritoryDescriptionColumn]));
                }
                set {
                    this[this.tableTerritories.TerritoryDescriptionColumn] = value;
                }
            }
            
            public int RegionID {
                get {
                    return ((int)(this[this.tableTerritories.RegionIDColumn]));
                }
                set {
                    this[this.tableTerritories.RegionIDColumn] = value;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class TerritoriesRowChangeEvent : EventArgs {
            
            private TerritoriesRow eventRow;
            
            private DataRowAction eventAction;
            
            public TerritoriesRowChangeEvent(TerritoriesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public TerritoriesRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class OrdersDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnOrderID;
            
            private DataColumn columnCustomerID;
            
            private DataColumn columnEmployeeID;
            
            private DataColumn columnOrderDate;
            
            private DataColumn columnRequiredDate;
            
            private DataColumn columnShippedDate;
            
            private DataColumn columnShipVia;
            
            private DataColumn columnFreight;
            
            private DataColumn columnShipName;
            
            private DataColumn columnShipAddress;
            
            private DataColumn columnShipCity;
            
            private DataColumn columnShipRegion;
            
            private DataColumn columnShipPostalCode;
            
            private DataColumn columnShipCountry;
            
            internal OrdersDataTable() : 
                    base("Orders") {
                this.InitClass();
            }
            
            internal OrdersDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn OrderIDColumn {
                get {
                    return this.columnOrderID;
                }
            }
            
            internal DataColumn CustomerIDColumn {
                get {
                    return this.columnCustomerID;
                }
            }
            
            internal DataColumn EmployeeIDColumn {
                get {
                    return this.columnEmployeeID;
                }
            }
            
            internal DataColumn OrderDateColumn {
                get {
                    return this.columnOrderDate;
                }
            }
            
            internal DataColumn RequiredDateColumn {
                get {
                    return this.columnRequiredDate;
                }
            }
            
            internal DataColumn ShippedDateColumn {
                get {
                    return this.columnShippedDate;
                }
            }
            
            internal DataColumn ShipViaColumn {
                get {
                    return this.columnShipVia;
                }
            }
            
            internal DataColumn FreightColumn {
                get {
                    return this.columnFreight;
                }
            }
            
            internal DataColumn ShipNameColumn {
                get {
                    return this.columnShipName;
                }
            }
            
            internal DataColumn ShipAddressColumn {
                get {
                    return this.columnShipAddress;
                }
            }
            
            internal DataColumn ShipCityColumn {
                get {
                    return this.columnShipCity;
                }
            }
            
            internal DataColumn ShipRegionColumn {
                get {
                    return this.columnShipRegion;
                }
            }
            
            internal DataColumn ShipPostalCodeColumn {
                get {
                    return this.columnShipPostalCode;
                }
            }
            
            internal DataColumn ShipCountryColumn {
                get {
                    return this.columnShipCountry;
                }
            }
            
            public OrdersRow this[int index] {
                get {
                    return ((OrdersRow)(this.Rows[index]));
                }
            }
            
            public event OrdersRowChangeEventHandler OrdersRowChanged;
            
            public event OrdersRowChangeEventHandler OrdersRowChanging;
            
            public event OrdersRowChangeEventHandler OrdersRowDeleted;
            
            public event OrdersRowChangeEventHandler OrdersRowDeleting;
            
            public void AddOrdersRow(OrdersRow row) {
                this.Rows.Add(row);
            }
            
            public OrdersRow AddOrdersRow(string CustomerID, EmployeesRow parentEmployeesRowByEmployeesOrders, System.DateTime OrderDate, System.DateTime RequiredDate, System.DateTime ShippedDate, int ShipVia, System.Decimal Freight, string ShipName, string ShipAddress, string ShipCity, string ShipRegion, string ShipPostalCode, string ShipCountry) {
                OrdersRow rowOrdersRow = ((OrdersRow)(this.NewRow()));
                rowOrdersRow.ItemArray = new object[] {
                        null,
                        CustomerID,
                        parentEmployeesRowByEmployeesOrders[0],
                        OrderDate,
                        RequiredDate,
                        ShippedDate,
                        ShipVia,
                        Freight,
                        ShipName,
                        ShipAddress,
                        ShipCity,
                        ShipRegion,
                        ShipPostalCode,
                        ShipCountry};
                this.Rows.Add(rowOrdersRow);
                return rowOrdersRow;
            }
            
            public OrdersRow FindByOrderID(int OrderID) {
                return ((OrdersRow)(this.Rows.Find(new object[] {
                            OrderID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                OrdersDataTable cln = ((OrdersDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new OrdersDataTable();
            }
            
            internal void InitVars() {
                this.columnOrderID = this.Columns["OrderID"];
                this.columnCustomerID = this.Columns["CustomerID"];
                this.columnEmployeeID = this.Columns["EmployeeID"];
                this.columnOrderDate = this.Columns["OrderDate"];
                this.columnRequiredDate = this.Columns["RequiredDate"];
                this.columnShippedDate = this.Columns["ShippedDate"];
                this.columnShipVia = this.Columns["ShipVia"];
                this.columnFreight = this.Columns["Freight"];
                this.columnShipName = this.Columns["ShipName"];
                this.columnShipAddress = this.Columns["ShipAddress"];
                this.columnShipCity = this.Columns["ShipCity"];
                this.columnShipRegion = this.Columns["ShipRegion"];
                this.columnShipPostalCode = this.Columns["ShipPostalCode"];
                this.columnShipCountry = this.Columns["ShipCountry"];
            }
            
            private void InitClass() {
                this.columnOrderID = new DataColumn("OrderID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOrderID);
                this.columnCustomerID = new DataColumn("CustomerID", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCustomerID);
                this.columnEmployeeID = new DataColumn("EmployeeID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnEmployeeID);
                this.columnOrderDate = new DataColumn("OrderDate", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOrderDate);
                this.columnRequiredDate = new DataColumn("RequiredDate", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRequiredDate);
                this.columnShippedDate = new DataColumn("ShippedDate", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnShippedDate);
                this.columnShipVia = new DataColumn("ShipVia", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnShipVia);
                this.columnFreight = new DataColumn("Freight", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFreight);
                this.columnShipName = new DataColumn("ShipName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnShipName);
                this.columnShipAddress = new DataColumn("ShipAddress", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnShipAddress);
                this.columnShipCity = new DataColumn("ShipCity", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnShipCity);
                this.columnShipRegion = new DataColumn("ShipRegion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnShipRegion);
                this.columnShipPostalCode = new DataColumn("ShipPostalCode", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnShipPostalCode);
                this.columnShipCountry = new DataColumn("ShipCountry", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnShipCountry);
                this.Constraints.Add(new UniqueConstraint("NorthwindDataSetKey1", new DataColumn[] {
                                this.columnOrderID}, true));
                this.columnOrderID.AutoIncrement = true;
                this.columnOrderID.AllowDBNull = false;
                this.columnOrderID.ReadOnly = true;
                this.columnOrderID.Unique = true;
            }
            
            public OrdersRow NewOrdersRow() {
                return ((OrdersRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new OrdersRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(OrdersRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.OrdersRowChanged != null)) {
                    this.OrdersRowChanged(this, new OrdersRowChangeEvent(((OrdersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.OrdersRowChanging != null)) {
                    this.OrdersRowChanging(this, new OrdersRowChangeEvent(((OrdersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.OrdersRowDeleted != null)) {
                    this.OrdersRowDeleted(this, new OrdersRowChangeEvent(((OrdersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.OrdersRowDeleting != null)) {
                    this.OrdersRowDeleting(this, new OrdersRowChangeEvent(((OrdersRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveOrdersRow(OrdersRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class OrdersRow : DataRow {
            
            private OrdersDataTable tableOrders;
            
            internal OrdersRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableOrders = ((OrdersDataTable)(this.Table));
            }
            
            public int OrderID {
                get {
                    return ((int)(this[this.tableOrders.OrderIDColumn]));
                }
                set {
                    this[this.tableOrders.OrderIDColumn] = value;
                }
            }
            
            public string CustomerID {
                get {
                    try {
                        return ((string)(this[this.tableOrders.CustomerIDColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.CustomerIDColumn] = value;
                }
            }
            
            public int EmployeeID {
                get {
                    try {
                        return ((int)(this[this.tableOrders.EmployeeIDColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.EmployeeIDColumn] = value;
                }
            }
            
            public System.DateTime OrderDate {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableOrders.OrderDateColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.OrderDateColumn] = value;
                }
            }
            
            public System.DateTime RequiredDate {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableOrders.RequiredDateColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.RequiredDateColumn] = value;
                }
            }
            
            public System.DateTime ShippedDate {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableOrders.ShippedDateColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.ShippedDateColumn] = value;
                }
            }
            
            public int ShipVia {
                get {
                    try {
                        return ((int)(this[this.tableOrders.ShipViaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.ShipViaColumn] = value;
                }
            }
            
            public System.Decimal Freight {
                get {
                    try {
                        return ((System.Decimal)(this[this.tableOrders.FreightColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.FreightColumn] = value;
                }
            }
            
            public string ShipName {
                get {
                    try {
                        return ((string)(this[this.tableOrders.ShipNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.ShipNameColumn] = value;
                }
            }
            
            public string ShipAddress {
                get {
                    try {
                        return ((string)(this[this.tableOrders.ShipAddressColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.ShipAddressColumn] = value;
                }
            }
            
            public string ShipCity {
                get {
                    try {
                        return ((string)(this[this.tableOrders.ShipCityColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.ShipCityColumn] = value;
                }
            }
            
            public string ShipRegion {
                get {
                    try {
                        return ((string)(this[this.tableOrders.ShipRegionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.ShipRegionColumn] = value;
                }
            }
            
            public string ShipPostalCode {
                get {
                    try {
                        return ((string)(this[this.tableOrders.ShipPostalCodeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.ShipPostalCodeColumn] = value;
                }
            }
            
            public string ShipCountry {
                get {
                    try {
                        return ((string)(this[this.tableOrders.ShipCountryColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.ShipCountryColumn] = value;
                }
            }
            
            public EmployeesRow EmployeesRow {
                get {
                    return ((EmployeesRow)(this.GetParentRow(this.Table.ParentRelations["EmployeesOrders"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["EmployeesOrders"]);
                }
            }
            
            public bool IsCustomerIDNull() {
                return this.IsNull(this.tableOrders.CustomerIDColumn);
            }
            
            public void SetCustomerIDNull() {
                this[this.tableOrders.CustomerIDColumn] = System.Convert.DBNull;
            }
            
            public bool IsEmployeeIDNull() {
                return this.IsNull(this.tableOrders.EmployeeIDColumn);
            }
            
            public void SetEmployeeIDNull() {
                this[this.tableOrders.EmployeeIDColumn] = System.Convert.DBNull;
            }
            
            public bool IsOrderDateNull() {
                return this.IsNull(this.tableOrders.OrderDateColumn);
            }
            
            public void SetOrderDateNull() {
                this[this.tableOrders.OrderDateColumn] = System.Convert.DBNull;
            }
            
            public bool IsRequiredDateNull() {
                return this.IsNull(this.tableOrders.RequiredDateColumn);
            }
            
            public void SetRequiredDateNull() {
                this[this.tableOrders.RequiredDateColumn] = System.Convert.DBNull;
            }
            
            public bool IsShippedDateNull() {
                return this.IsNull(this.tableOrders.ShippedDateColumn);
            }
            
            public void SetShippedDateNull() {
                this[this.tableOrders.ShippedDateColumn] = System.Convert.DBNull;
            }
            
            public bool IsShipViaNull() {
                return this.IsNull(this.tableOrders.ShipViaColumn);
            }
            
            public void SetShipViaNull() {
                this[this.tableOrders.ShipViaColumn] = System.Convert.DBNull;
            }
            
            public bool IsFreightNull() {
                return this.IsNull(this.tableOrders.FreightColumn);
            }
            
            public void SetFreightNull() {
                this[this.tableOrders.FreightColumn] = System.Convert.DBNull;
            }
            
            public bool IsShipNameNull() {
                return this.IsNull(this.tableOrders.ShipNameColumn);
            }
            
            public void SetShipNameNull() {
                this[this.tableOrders.ShipNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsShipAddressNull() {
                return this.IsNull(this.tableOrders.ShipAddressColumn);
            }
            
            public void SetShipAddressNull() {
                this[this.tableOrders.ShipAddressColumn] = System.Convert.DBNull;
            }
            
            public bool IsShipCityNull() {
                return this.IsNull(this.tableOrders.ShipCityColumn);
            }
            
            public void SetShipCityNull() {
                this[this.tableOrders.ShipCityColumn] = System.Convert.DBNull;
            }
            
            public bool IsShipRegionNull() {
                return this.IsNull(this.tableOrders.ShipRegionColumn);
            }
            
            public void SetShipRegionNull() {
                this[this.tableOrders.ShipRegionColumn] = System.Convert.DBNull;
            }
            
            public bool IsShipPostalCodeNull() {
                return this.IsNull(this.tableOrders.ShipPostalCodeColumn);
            }
            
            public void SetShipPostalCodeNull() {
                this[this.tableOrders.ShipPostalCodeColumn] = System.Convert.DBNull;
            }
            
            public bool IsShipCountryNull() {
                return this.IsNull(this.tableOrders.ShipCountryColumn);
            }
            
            public void SetShipCountryNull() {
                this[this.tableOrders.ShipCountryColumn] = System.Convert.DBNull;
            }
            
            public Order_DetailsRow[] GetOrder_DetailsRows() {
                return ((Order_DetailsRow[])(this.GetChildRows(this.Table.ChildRelations["OrdersOrder_x0020_Details"])));
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class OrdersRowChangeEvent : EventArgs {
            
            private OrdersRow eventRow;
            
            private DataRowAction eventAction;
            
            public OrdersRowChangeEvent(OrdersRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public OrdersRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class Order_DetailsDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnOrderID;
            
            private DataColumn columnProductID;
            
            private DataColumn columnUnitPrice;
            
            private DataColumn columnQuantity;
            
            private DataColumn columnDiscount;
            
            internal Order_DetailsDataTable() : 
                    base("Order Details") {
                this.InitClass();
            }
            
            internal Order_DetailsDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn OrderIDColumn {
                get {
                    return this.columnOrderID;
                }
            }
            
            internal DataColumn ProductIDColumn {
                get {
                    return this.columnProductID;
                }
            }
            
            internal DataColumn UnitPriceColumn {
                get {
                    return this.columnUnitPrice;
                }
            }
            
            internal DataColumn QuantityColumn {
                get {
                    return this.columnQuantity;
                }
            }
            
            internal DataColumn DiscountColumn {
                get {
                    return this.columnDiscount;
                }
            }
            
            public Order_DetailsRow this[int index] {
                get {
                    return ((Order_DetailsRow)(this.Rows[index]));
                }
            }
            
            public event Order_DetailsRowChangeEventHandler Order_DetailsRowChanged;
            
            public event Order_DetailsRowChangeEventHandler Order_DetailsRowChanging;
            
            public event Order_DetailsRowChangeEventHandler Order_DetailsRowDeleted;
            
            public event Order_DetailsRowChangeEventHandler Order_DetailsRowDeleting;
            
            public void AddOrder_DetailsRow(Order_DetailsRow row) {
                this.Rows.Add(row);
            }
            
            public Order_DetailsRow AddOrder_DetailsRow(OrdersRow parentOrdersRowByOrdersOrder_x0020_Details, int ProductID, System.Decimal UnitPrice, short Quantity, System.Single Discount) {
                Order_DetailsRow rowOrder_DetailsRow = ((Order_DetailsRow)(this.NewRow()));
                rowOrder_DetailsRow.ItemArray = new object[] {
                        parentOrdersRowByOrdersOrder_x0020_Details[0],
                        ProductID,
                        UnitPrice,
                        Quantity,
                        Discount};
                this.Rows.Add(rowOrder_DetailsRow);
                return rowOrder_DetailsRow;
            }
            
            public Order_DetailsRow FindByOrderIDProductID(int OrderID, int ProductID) {
                return ((Order_DetailsRow)(this.Rows.Find(new object[] {
                            OrderID,
                            ProductID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                Order_DetailsDataTable cln = ((Order_DetailsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new Order_DetailsDataTable();
            }
            
            internal void InitVars() {
                this.columnOrderID = this.Columns["OrderID"];
                this.columnProductID = this.Columns["ProductID"];
                this.columnUnitPrice = this.Columns["UnitPrice"];
                this.columnQuantity = this.Columns["Quantity"];
                this.columnDiscount = this.Columns["Discount"];
            }
            
            private void InitClass() {
                this.columnOrderID = new DataColumn("OrderID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOrderID);
                this.columnProductID = new DataColumn("ProductID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnProductID);
                this.columnUnitPrice = new DataColumn("UnitPrice", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUnitPrice);
                this.columnQuantity = new DataColumn("Quantity", typeof(short), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnQuantity);
                this.columnDiscount = new DataColumn("Discount", typeof(System.Single), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDiscount);
                this.Constraints.Add(new UniqueConstraint("NorthwindDataSetKey2", new DataColumn[] {
                                this.columnOrderID,
                                this.columnProductID}, true));
                this.columnOrderID.AllowDBNull = false;
                this.columnProductID.AllowDBNull = false;
                this.columnUnitPrice.AllowDBNull = false;
                this.columnQuantity.AllowDBNull = false;
                this.columnDiscount.AllowDBNull = false;
            }
            
            public Order_DetailsRow NewOrder_DetailsRow() {
                return ((Order_DetailsRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new Order_DetailsRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(Order_DetailsRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.Order_DetailsRowChanged != null)) {
                    this.Order_DetailsRowChanged(this, new Order_DetailsRowChangeEvent(((Order_DetailsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.Order_DetailsRowChanging != null)) {
                    this.Order_DetailsRowChanging(this, new Order_DetailsRowChangeEvent(((Order_DetailsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.Order_DetailsRowDeleted != null)) {
                    this.Order_DetailsRowDeleted(this, new Order_DetailsRowChangeEvent(((Order_DetailsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.Order_DetailsRowDeleting != null)) {
                    this.Order_DetailsRowDeleting(this, new Order_DetailsRowChangeEvent(((Order_DetailsRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveOrder_DetailsRow(Order_DetailsRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class Order_DetailsRow : DataRow {
            
            private Order_DetailsDataTable tableOrder_Details;
            
            internal Order_DetailsRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableOrder_Details = ((Order_DetailsDataTable)(this.Table));
            }
            
            public int OrderID {
                get {
                    return ((int)(this[this.tableOrder_Details.OrderIDColumn]));
                }
                set {
                    this[this.tableOrder_Details.OrderIDColumn] = value;
                }
            }
            
            public int ProductID {
                get {
                    return ((int)(this[this.tableOrder_Details.ProductIDColumn]));
                }
                set {
                    this[this.tableOrder_Details.ProductIDColumn] = value;
                }
            }
            
            public System.Decimal UnitPrice {
                get {
                    return ((System.Decimal)(this[this.tableOrder_Details.UnitPriceColumn]));
                }
                set {
                    this[this.tableOrder_Details.UnitPriceColumn] = value;
                }
            }
            
            public short Quantity {
                get {
                    return ((short)(this[this.tableOrder_Details.QuantityColumn]));
                }
                set {
                    this[this.tableOrder_Details.QuantityColumn] = value;
                }
            }
            
            public System.Single Discount {
                get {
                    return ((System.Single)(this[this.tableOrder_Details.DiscountColumn]));
                }
                set {
                    this[this.tableOrder_Details.DiscountColumn] = value;
                }
            }
            
            public OrdersRow OrdersRow {
                get {
                    return ((OrdersRow)(this.GetParentRow(this.Table.ParentRelations["OrdersOrder_x0020_Details"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["OrdersOrder_x0020_Details"]);
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class Order_DetailsRowChangeEvent : EventArgs {
            
            private Order_DetailsRow eventRow;
            
            private DataRowAction eventAction;
            
            public Order_DetailsRowChangeEvent(Order_DetailsRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public Order_DetailsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ProductsDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnProductID;
            
            private DataColumn columnProductName;
            
            private DataColumn columnSupplierID;
            
            private DataColumn columnCategoryID;
            
            private DataColumn columnQuantityPerUnit;
            
            private DataColumn columnUnitPrice;
            
            private DataColumn columnUnitsInStock;
            
            private DataColumn columnUnitsOnOrder;
            
            private DataColumn columnReorderLevel;
            
            private DataColumn columnDiscontinued;
            
            internal ProductsDataTable() : 
                    base("Products") {
                this.InitClass();
            }
            
            internal ProductsDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn ProductIDColumn {
                get {
                    return this.columnProductID;
                }
            }
            
            internal DataColumn ProductNameColumn {
                get {
                    return this.columnProductName;
                }
            }
            
            internal DataColumn SupplierIDColumn {
                get {
                    return this.columnSupplierID;
                }
            }
            
            internal DataColumn CategoryIDColumn {
                get {
                    return this.columnCategoryID;
                }
            }
            
            internal DataColumn QuantityPerUnitColumn {
                get {
                    return this.columnQuantityPerUnit;
                }
            }
            
            internal DataColumn UnitPriceColumn {
                get {
                    return this.columnUnitPrice;
                }
            }
            
            internal DataColumn UnitsInStockColumn {
                get {
                    return this.columnUnitsInStock;
                }
            }
            
            internal DataColumn UnitsOnOrderColumn {
                get {
                    return this.columnUnitsOnOrder;
                }
            }
            
            internal DataColumn ReorderLevelColumn {
                get {
                    return this.columnReorderLevel;
                }
            }
            
            internal DataColumn DiscontinuedColumn {
                get {
                    return this.columnDiscontinued;
                }
            }
            
            public ProductsRow this[int index] {
                get {
                    return ((ProductsRow)(this.Rows[index]));
                }
            }
            
            public event ProductsRowChangeEventHandler ProductsRowChanged;
            
            public event ProductsRowChangeEventHandler ProductsRowChanging;
            
            public event ProductsRowChangeEventHandler ProductsRowDeleted;
            
            public event ProductsRowChangeEventHandler ProductsRowDeleting;
            
            public void AddProductsRow(ProductsRow row) {
                this.Rows.Add(row);
            }
            
            public ProductsRow AddProductsRow(string ProductName, int SupplierID, int CategoryID, string QuantityPerUnit, System.Decimal UnitPrice, short UnitsInStock, short UnitsOnOrder, short ReorderLevel, bool Discontinued) {
                ProductsRow rowProductsRow = ((ProductsRow)(this.NewRow()));
                rowProductsRow.ItemArray = new object[] {
                        null,
                        ProductName,
                        SupplierID,
                        CategoryID,
                        QuantityPerUnit,
                        UnitPrice,
                        UnitsInStock,
                        UnitsOnOrder,
                        ReorderLevel,
                        Discontinued};
                this.Rows.Add(rowProductsRow);
                return rowProductsRow;
            }
            
            public ProductsRow FindByProductID(int ProductID) {
                return ((ProductsRow)(this.Rows.Find(new object[] {
                            ProductID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                ProductsDataTable cln = ((ProductsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new ProductsDataTable();
            }
            
            internal void InitVars() {
                this.columnProductID = this.Columns["ProductID"];
                this.columnProductName = this.Columns["ProductName"];
                this.columnSupplierID = this.Columns["SupplierID"];
                this.columnCategoryID = this.Columns["CategoryID"];
                this.columnQuantityPerUnit = this.Columns["QuantityPerUnit"];
                this.columnUnitPrice = this.Columns["UnitPrice"];
                this.columnUnitsInStock = this.Columns["UnitsInStock"];
                this.columnUnitsOnOrder = this.Columns["UnitsOnOrder"];
                this.columnReorderLevel = this.Columns["ReorderLevel"];
                this.columnDiscontinued = this.Columns["Discontinued"];
            }
            
            private void InitClass() {
                this.columnProductID = new DataColumn("ProductID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnProductID);
                this.columnProductName = new DataColumn("ProductName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnProductName);
                this.columnSupplierID = new DataColumn("SupplierID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnSupplierID);
                this.columnCategoryID = new DataColumn("CategoryID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCategoryID);
                this.columnQuantityPerUnit = new DataColumn("QuantityPerUnit", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnQuantityPerUnit);
                this.columnUnitPrice = new DataColumn("UnitPrice", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUnitPrice);
                this.columnUnitsInStock = new DataColumn("UnitsInStock", typeof(short), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUnitsInStock);
                this.columnUnitsOnOrder = new DataColumn("UnitsOnOrder", typeof(short), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUnitsOnOrder);
                this.columnReorderLevel = new DataColumn("ReorderLevel", typeof(short), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnReorderLevel);
                this.columnDiscontinued = new DataColumn("Discontinued", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDiscontinued);
                this.Constraints.Add(new UniqueConstraint("NorthwindDataSetKey3", new DataColumn[] {
                                this.columnProductID}, true));
                this.columnProductID.AutoIncrement = true;
                this.columnProductID.AllowDBNull = false;
                this.columnProductID.ReadOnly = true;
                this.columnProductID.Unique = true;
                this.columnProductName.AllowDBNull = false;
                this.columnDiscontinued.AllowDBNull = false;
            }
            
            public ProductsRow NewProductsRow() {
                return ((ProductsRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new ProductsRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(ProductsRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.ProductsRowChanged != null)) {
                    this.ProductsRowChanged(this, new ProductsRowChangeEvent(((ProductsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.ProductsRowChanging != null)) {
                    this.ProductsRowChanging(this, new ProductsRowChangeEvent(((ProductsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.ProductsRowDeleted != null)) {
                    this.ProductsRowDeleted(this, new ProductsRowChangeEvent(((ProductsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.ProductsRowDeleting != null)) {
                    this.ProductsRowDeleting(this, new ProductsRowChangeEvent(((ProductsRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveProductsRow(ProductsRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ProductsRow : DataRow {
            
            private ProductsDataTable tableProducts;
            
            internal ProductsRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableProducts = ((ProductsDataTable)(this.Table));
            }
            
            public int ProductID {
                get {
                    return ((int)(this[this.tableProducts.ProductIDColumn]));
                }
                set {
                    this[this.tableProducts.ProductIDColumn] = value;
                }
            }
            
            public string ProductName {
                get {
                    return ((string)(this[this.tableProducts.ProductNameColumn]));
                }
                set {
                    this[this.tableProducts.ProductNameColumn] = value;
                }
            }
            
            public int SupplierID {
                get {
                    try {
                        return ((int)(this[this.tableProducts.SupplierIDColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableProducts.SupplierIDColumn] = value;
                }
            }
            
            public int CategoryID {
                get {
                    try {
                        return ((int)(this[this.tableProducts.CategoryIDColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableProducts.CategoryIDColumn] = value;
                }
            }
            
            public string QuantityPerUnit {
                get {
                    try {
                        return ((string)(this[this.tableProducts.QuantityPerUnitColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableProducts.QuantityPerUnitColumn] = value;
                }
            }
            
            public System.Decimal UnitPrice {
                get {
                    try {
                        return ((System.Decimal)(this[this.tableProducts.UnitPriceColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableProducts.UnitPriceColumn] = value;
                }
            }
            
            public short UnitsInStock {
                get {
                    try {
                        return ((short)(this[this.tableProducts.UnitsInStockColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableProducts.UnitsInStockColumn] = value;
                }
            }
            
            public short UnitsOnOrder {
                get {
                    try {
                        return ((short)(this[this.tableProducts.UnitsOnOrderColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableProducts.UnitsOnOrderColumn] = value;
                }
            }
            
            public short ReorderLevel {
                get {
                    try {
                        return ((short)(this[this.tableProducts.ReorderLevelColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableProducts.ReorderLevelColumn] = value;
                }
            }
            
            public bool Discontinued {
                get {
                    return ((bool)(this[this.tableProducts.DiscontinuedColumn]));
                }
                set {
                    this[this.tableProducts.DiscontinuedColumn] = value;
                }
            }
            
            public bool IsSupplierIDNull() {
                return this.IsNull(this.tableProducts.SupplierIDColumn);
            }
            
            public void SetSupplierIDNull() {
                this[this.tableProducts.SupplierIDColumn] = System.Convert.DBNull;
            }
            
            public bool IsCategoryIDNull() {
                return this.IsNull(this.tableProducts.CategoryIDColumn);
            }
            
            public void SetCategoryIDNull() {
                this[this.tableProducts.CategoryIDColumn] = System.Convert.DBNull;
            }
            
            public bool IsQuantityPerUnitNull() {
                return this.IsNull(this.tableProducts.QuantityPerUnitColumn);
            }
            
            public void SetQuantityPerUnitNull() {
                this[this.tableProducts.QuantityPerUnitColumn] = System.Convert.DBNull;
            }
            
            public bool IsUnitPriceNull() {
                return this.IsNull(this.tableProducts.UnitPriceColumn);
            }
            
            public void SetUnitPriceNull() {
                this[this.tableProducts.UnitPriceColumn] = System.Convert.DBNull;
            }
            
            public bool IsUnitsInStockNull() {
                return this.IsNull(this.tableProducts.UnitsInStockColumn);
            }
            
            public void SetUnitsInStockNull() {
                this[this.tableProducts.UnitsInStockColumn] = System.Convert.DBNull;
            }
            
            public bool IsUnitsOnOrderNull() {
                return this.IsNull(this.tableProducts.UnitsOnOrderColumn);
            }
            
            public void SetUnitsOnOrderNull() {
                this[this.tableProducts.UnitsOnOrderColumn] = System.Convert.DBNull;
            }
            
            public bool IsReorderLevelNull() {
                return this.IsNull(this.tableProducts.ReorderLevelColumn);
            }
            
            public void SetReorderLevelNull() {
                this[this.tableProducts.ReorderLevelColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ProductsRowChangeEvent : EventArgs {
            
            private ProductsRow eventRow;
            
            private DataRowAction eventAction;
            
            public ProductsRowChangeEvent(ProductsRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public ProductsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class SuppliersDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnSupplierID;
            
            private DataColumn columnCompanyName;
            
            private DataColumn columnContactName;
            
            private DataColumn columnContactTitle;
            
            private DataColumn columnAddress;
            
            private DataColumn columnCity;
            
            private DataColumn columnRegion;
            
            private DataColumn columnPostalCode;
            
            private DataColumn columnCountry;
            
            private DataColumn columnPhone;
            
            private DataColumn columnFax;
            
            private DataColumn columnHomePage;
            
            internal SuppliersDataTable() : 
                    base("Suppliers") {
                this.InitClass();
            }
            
            internal SuppliersDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn SupplierIDColumn {
                get {
                    return this.columnSupplierID;
                }
            }
            
            internal DataColumn CompanyNameColumn {
                get {
                    return this.columnCompanyName;
                }
            }
            
            internal DataColumn ContactNameColumn {
                get {
                    return this.columnContactName;
                }
            }
            
            internal DataColumn ContactTitleColumn {
                get {
                    return this.columnContactTitle;
                }
            }
            
            internal DataColumn AddressColumn {
                get {
                    return this.columnAddress;
                }
            }
            
            internal DataColumn CityColumn {
                get {
                    return this.columnCity;
                }
            }
            
            internal DataColumn RegionColumn {
                get {
                    return this.columnRegion;
                }
            }
            
            internal DataColumn PostalCodeColumn {
                get {
                    return this.columnPostalCode;
                }
            }
            
            internal DataColumn CountryColumn {
                get {
                    return this.columnCountry;
                }
            }
            
            internal DataColumn PhoneColumn {
                get {
                    return this.columnPhone;
                }
            }
            
            internal DataColumn FaxColumn {
                get {
                    return this.columnFax;
                }
            }
            
            internal DataColumn HomePageColumn {
                get {
                    return this.columnHomePage;
                }
            }
            
            public SuppliersRow this[int index] {
                get {
                    return ((SuppliersRow)(this.Rows[index]));
                }
            }
            
            public event SuppliersRowChangeEventHandler SuppliersRowChanged;
            
            public event SuppliersRowChangeEventHandler SuppliersRowChanging;
            
            public event SuppliersRowChangeEventHandler SuppliersRowDeleted;
            
            public event SuppliersRowChangeEventHandler SuppliersRowDeleting;
            
            public void AddSuppliersRow(SuppliersRow row) {
                this.Rows.Add(row);
            }
            
            public SuppliersRow AddSuppliersRow(string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country, string Phone, string Fax, string HomePage) {
                SuppliersRow rowSuppliersRow = ((SuppliersRow)(this.NewRow()));
                rowSuppliersRow.ItemArray = new object[] {
                        null,
                        CompanyName,
                        ContactName,
                        ContactTitle,
                        Address,
                        City,
                        Region,
                        PostalCode,
                        Country,
                        Phone,
                        Fax,
                        HomePage};
                this.Rows.Add(rowSuppliersRow);
                return rowSuppliersRow;
            }
            
            public SuppliersRow FindBySupplierID(int SupplierID) {
                return ((SuppliersRow)(this.Rows.Find(new object[] {
                            SupplierID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                SuppliersDataTable cln = ((SuppliersDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new SuppliersDataTable();
            }
            
            internal void InitVars() {
                this.columnSupplierID = this.Columns["SupplierID"];
                this.columnCompanyName = this.Columns["CompanyName"];
                this.columnContactName = this.Columns["ContactName"];
                this.columnContactTitle = this.Columns["ContactTitle"];
                this.columnAddress = this.Columns["Address"];
                this.columnCity = this.Columns["City"];
                this.columnRegion = this.Columns["Region"];
                this.columnPostalCode = this.Columns["PostalCode"];
                this.columnCountry = this.Columns["Country"];
                this.columnPhone = this.Columns["Phone"];
                this.columnFax = this.Columns["Fax"];
                this.columnHomePage = this.Columns["HomePage"];
            }
            
            private void InitClass() {
                this.columnSupplierID = new DataColumn("SupplierID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnSupplierID);
                this.columnCompanyName = new DataColumn("CompanyName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCompanyName);
                this.columnContactName = new DataColumn("ContactName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnContactName);
                this.columnContactTitle = new DataColumn("ContactTitle", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnContactTitle);
                this.columnAddress = new DataColumn("Address", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAddress);
                this.columnCity = new DataColumn("City", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCity);
                this.columnRegion = new DataColumn("Region", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRegion);
                this.columnPostalCode = new DataColumn("PostalCode", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPostalCode);
                this.columnCountry = new DataColumn("Country", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCountry);
                this.columnPhone = new DataColumn("Phone", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPhone);
                this.columnFax = new DataColumn("Fax", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFax);
                this.columnHomePage = new DataColumn("HomePage", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnHomePage);
                this.Constraints.Add(new UniqueConstraint("NorthwindDataSetKey4", new DataColumn[] {
                                this.columnSupplierID}, true));
                this.columnSupplierID.AutoIncrement = true;
                this.columnSupplierID.AllowDBNull = false;
                this.columnSupplierID.ReadOnly = true;
                this.columnSupplierID.Unique = true;
                this.columnCompanyName.AllowDBNull = false;
            }
            
            public SuppliersRow NewSuppliersRow() {
                return ((SuppliersRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new SuppliersRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(SuppliersRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.SuppliersRowChanged != null)) {
                    this.SuppliersRowChanged(this, new SuppliersRowChangeEvent(((SuppliersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.SuppliersRowChanging != null)) {
                    this.SuppliersRowChanging(this, new SuppliersRowChangeEvent(((SuppliersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.SuppliersRowDeleted != null)) {
                    this.SuppliersRowDeleted(this, new SuppliersRowChangeEvent(((SuppliersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.SuppliersRowDeleting != null)) {
                    this.SuppliersRowDeleting(this, new SuppliersRowChangeEvent(((SuppliersRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveSuppliersRow(SuppliersRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class SuppliersRow : DataRow {
            
            private SuppliersDataTable tableSuppliers;
            
            internal SuppliersRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableSuppliers = ((SuppliersDataTable)(this.Table));
            }
            
            public int SupplierID {
                get {
                    return ((int)(this[this.tableSuppliers.SupplierIDColumn]));
                }
                set {
                    this[this.tableSuppliers.SupplierIDColumn] = value;
                }
            }
            
            public string CompanyName {
                get {
                    return ((string)(this[this.tableSuppliers.CompanyNameColumn]));
                }
                set {
                    this[this.tableSuppliers.CompanyNameColumn] = value;
                }
            }
            
            public string ContactName {
                get {
                    try {
                        return ((string)(this[this.tableSuppliers.ContactNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSuppliers.ContactNameColumn] = value;
                }
            }
            
            public string ContactTitle {
                get {
                    try {
                        return ((string)(this[this.tableSuppliers.ContactTitleColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSuppliers.ContactTitleColumn] = value;
                }
            }
            
            public string Address {
                get {
                    try {
                        return ((string)(this[this.tableSuppliers.AddressColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSuppliers.AddressColumn] = value;
                }
            }
            
            public string City {
                get {
                    try {
                        return ((string)(this[this.tableSuppliers.CityColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSuppliers.CityColumn] = value;
                }
            }
            
            public string Region {
                get {
                    try {
                        return ((string)(this[this.tableSuppliers.RegionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSuppliers.RegionColumn] = value;
                }
            }
            
            public string PostalCode {
                get {
                    try {
                        return ((string)(this[this.tableSuppliers.PostalCodeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSuppliers.PostalCodeColumn] = value;
                }
            }
            
            public string Country {
                get {
                    try {
                        return ((string)(this[this.tableSuppliers.CountryColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSuppliers.CountryColumn] = value;
                }
            }
            
            public string Phone {
                get {
                    try {
                        return ((string)(this[this.tableSuppliers.PhoneColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSuppliers.PhoneColumn] = value;
                }
            }
            
            public string Fax {
                get {
                    try {
                        return ((string)(this[this.tableSuppliers.FaxColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSuppliers.FaxColumn] = value;
                }
            }
            
            public string HomePage {
                get {
                    try {
                        return ((string)(this[this.tableSuppliers.HomePageColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSuppliers.HomePageColumn] = value;
                }
            }
            
            public bool IsContactNameNull() {
                return this.IsNull(this.tableSuppliers.ContactNameColumn);
            }
            
            public void SetContactNameNull() {
                this[this.tableSuppliers.ContactNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsContactTitleNull() {
                return this.IsNull(this.tableSuppliers.ContactTitleColumn);
            }
            
            public void SetContactTitleNull() {
                this[this.tableSuppliers.ContactTitleColumn] = System.Convert.DBNull;
            }
            
            public bool IsAddressNull() {
                return this.IsNull(this.tableSuppliers.AddressColumn);
            }
            
            public void SetAddressNull() {
                this[this.tableSuppliers.AddressColumn] = System.Convert.DBNull;
            }
            
            public bool IsCityNull() {
                return this.IsNull(this.tableSuppliers.CityColumn);
            }
            
            public void SetCityNull() {
                this[this.tableSuppliers.CityColumn] = System.Convert.DBNull;
            }
            
            public bool IsRegionNull() {
                return this.IsNull(this.tableSuppliers.RegionColumn);
            }
            
            public void SetRegionNull() {
                this[this.tableSuppliers.RegionColumn] = System.Convert.DBNull;
            }
            
            public bool IsPostalCodeNull() {
                return this.IsNull(this.tableSuppliers.PostalCodeColumn);
            }
            
            public void SetPostalCodeNull() {
                this[this.tableSuppliers.PostalCodeColumn] = System.Convert.DBNull;
            }
            
            public bool IsCountryNull() {
                return this.IsNull(this.tableSuppliers.CountryColumn);
            }
            
            public void SetCountryNull() {
                this[this.tableSuppliers.CountryColumn] = System.Convert.DBNull;
            }
            
            public bool IsPhoneNull() {
                return this.IsNull(this.tableSuppliers.PhoneColumn);
            }
            
            public void SetPhoneNull() {
                this[this.tableSuppliers.PhoneColumn] = System.Convert.DBNull;
            }
            
            public bool IsFaxNull() {
                return this.IsNull(this.tableSuppliers.FaxColumn);
            }
            
            public void SetFaxNull() {
                this[this.tableSuppliers.FaxColumn] = System.Convert.DBNull;
            }
            
            public bool IsHomePageNull() {
                return this.IsNull(this.tableSuppliers.HomePageColumn);
            }
            
            public void SetHomePageNull() {
                this[this.tableSuppliers.HomePageColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class SuppliersRowChangeEvent : EventArgs {
            
            private SuppliersRow eventRow;
            
            private DataRowAction eventAction;
            
            public SuppliersRowChangeEvent(SuppliersRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public SuppliersRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class CategoriesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnCategoryID;
            
            private DataColumn columnCategoryName;
            
            private DataColumn columnDescription;
            
            private DataColumn columnPicture;
            
            internal CategoriesDataTable() : 
                    base("Categories") {
                this.InitClass();
            }
            
            internal CategoriesDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn CategoryIDColumn {
                get {
                    return this.columnCategoryID;
                }
            }
            
            internal DataColumn CategoryNameColumn {
                get {
                    return this.columnCategoryName;
                }
            }
            
            internal DataColumn DescriptionColumn {
                get {
                    return this.columnDescription;
                }
            }
            
            internal DataColumn PictureColumn {
                get {
                    return this.columnPicture;
                }
            }
            
            public CategoriesRow this[int index] {
                get {
                    return ((CategoriesRow)(this.Rows[index]));
                }
            }
            
            public event CategoriesRowChangeEventHandler CategoriesRowChanged;
            
            public event CategoriesRowChangeEventHandler CategoriesRowChanging;
            
            public event CategoriesRowChangeEventHandler CategoriesRowDeleted;
            
            public event CategoriesRowChangeEventHandler CategoriesRowDeleting;
            
            public void AddCategoriesRow(CategoriesRow row) {
                this.Rows.Add(row);
            }
            
            public CategoriesRow AddCategoriesRow(string CategoryName, string Description, System.Byte[] Picture) {
                CategoriesRow rowCategoriesRow = ((CategoriesRow)(this.NewRow()));
                rowCategoriesRow.ItemArray = new object[] {
                        null,
                        CategoryName,
                        Description,
                        Picture};
                this.Rows.Add(rowCategoriesRow);
                return rowCategoriesRow;
            }
            
            public CategoriesRow FindByCategoryID(int CategoryID) {
                return ((CategoriesRow)(this.Rows.Find(new object[] {
                            CategoryID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                CategoriesDataTable cln = ((CategoriesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new CategoriesDataTable();
            }
            
            internal void InitVars() {
                this.columnCategoryID = this.Columns["CategoryID"];
                this.columnCategoryName = this.Columns["CategoryName"];
                this.columnDescription = this.Columns["Description"];
                this.columnPicture = this.Columns["Picture"];
            }
            
            private void InitClass() {
                this.columnCategoryID = new DataColumn("CategoryID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCategoryID);
                this.columnCategoryName = new DataColumn("CategoryName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCategoryName);
                this.columnDescription = new DataColumn("Description", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescription);
                this.columnPicture = new DataColumn("Picture", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPicture);
                this.Constraints.Add(new UniqueConstraint("NorthwindDataSetKey5", new DataColumn[] {
                                this.columnCategoryID}, true));
                this.columnCategoryID.AutoIncrement = true;
                this.columnCategoryID.AllowDBNull = false;
                this.columnCategoryID.ReadOnly = true;
                this.columnCategoryID.Unique = true;
                this.columnCategoryName.AllowDBNull = false;
            }
            
            public CategoriesRow NewCategoriesRow() {
                return ((CategoriesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new CategoriesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(CategoriesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.CategoriesRowChanged != null)) {
                    this.CategoriesRowChanged(this, new CategoriesRowChangeEvent(((CategoriesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.CategoriesRowChanging != null)) {
                    this.CategoriesRowChanging(this, new CategoriesRowChangeEvent(((CategoriesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.CategoriesRowDeleted != null)) {
                    this.CategoriesRowDeleted(this, new CategoriesRowChangeEvent(((CategoriesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.CategoriesRowDeleting != null)) {
                    this.CategoriesRowDeleting(this, new CategoriesRowChangeEvent(((CategoriesRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveCategoriesRow(CategoriesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class CategoriesRow : DataRow {
            
            private CategoriesDataTable tableCategories;
            
            internal CategoriesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableCategories = ((CategoriesDataTable)(this.Table));
            }
            
            public int CategoryID {
                get {
                    return ((int)(this[this.tableCategories.CategoryIDColumn]));
                }
                set {
                    this[this.tableCategories.CategoryIDColumn] = value;
                }
            }
            
            public string CategoryName {
                get {
                    return ((string)(this[this.tableCategories.CategoryNameColumn]));
                }
                set {
                    this[this.tableCategories.CategoryNameColumn] = value;
                }
            }
            
            public string Description {
                get {
                    try {
                        return ((string)(this[this.tableCategories.DescriptionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCategories.DescriptionColumn] = value;
                }
            }
            
            public System.Byte[] Picture {
                get {
                    try {
                        return ((System.Byte[])(this[this.tableCategories.PictureColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCategories.PictureColumn] = value;
                }
            }
            
            public bool IsDescriptionNull() {
                return this.IsNull(this.tableCategories.DescriptionColumn);
            }
            
            public void SetDescriptionNull() {
                this[this.tableCategories.DescriptionColumn] = System.Convert.DBNull;
            }
            
            public bool IsPictureNull() {
                return this.IsNull(this.tableCategories.PictureColumn);
            }
            
            public void SetPictureNull() {
                this[this.tableCategories.PictureColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class CategoriesRowChangeEvent : EventArgs {
            
            private CategoriesRow eventRow;
            
            private DataRowAction eventAction;
            
            public CategoriesRowChangeEvent(CategoriesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public CategoriesRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ShippersDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnShipperID;
            
            private DataColumn columnCompanyName;
            
            private DataColumn columnPhone;
            
            internal ShippersDataTable() : 
                    base("Shippers") {
                this.InitClass();
            }
            
            internal ShippersDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn ShipperIDColumn {
                get {
                    return this.columnShipperID;
                }
            }
            
            internal DataColumn CompanyNameColumn {
                get {
                    return this.columnCompanyName;
                }
            }
            
            internal DataColumn PhoneColumn {
                get {
                    return this.columnPhone;
                }
            }
            
            public ShippersRow this[int index] {
                get {
                    return ((ShippersRow)(this.Rows[index]));
                }
            }
            
            public event ShippersRowChangeEventHandler ShippersRowChanged;
            
            public event ShippersRowChangeEventHandler ShippersRowChanging;
            
            public event ShippersRowChangeEventHandler ShippersRowDeleted;
            
            public event ShippersRowChangeEventHandler ShippersRowDeleting;
            
            public void AddShippersRow(ShippersRow row) {
                this.Rows.Add(row);
            }
            
            public ShippersRow AddShippersRow(string CompanyName, string Phone) {
                ShippersRow rowShippersRow = ((ShippersRow)(this.NewRow()));
                rowShippersRow.ItemArray = new object[] {
                        null,
                        CompanyName,
                        Phone};
                this.Rows.Add(rowShippersRow);
                return rowShippersRow;
            }
            
            public ShippersRow FindByShipperID(int ShipperID) {
                return ((ShippersRow)(this.Rows.Find(new object[] {
                            ShipperID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                ShippersDataTable cln = ((ShippersDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new ShippersDataTable();
            }
            
            internal void InitVars() {
                this.columnShipperID = this.Columns["ShipperID"];
                this.columnCompanyName = this.Columns["CompanyName"];
                this.columnPhone = this.Columns["Phone"];
            }
            
            private void InitClass() {
                this.columnShipperID = new DataColumn("ShipperID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnShipperID);
                this.columnCompanyName = new DataColumn("CompanyName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCompanyName);
                this.columnPhone = new DataColumn("Phone", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPhone);
                this.Constraints.Add(new UniqueConstraint("NorthwindDataSetKey6", new DataColumn[] {
                                this.columnShipperID}, true));
                this.columnShipperID.AutoIncrement = true;
                this.columnShipperID.AllowDBNull = false;
                this.columnShipperID.ReadOnly = true;
                this.columnShipperID.Unique = true;
                this.columnCompanyName.AllowDBNull = false;
            }
            
            public ShippersRow NewShippersRow() {
                return ((ShippersRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new ShippersRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(ShippersRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.ShippersRowChanged != null)) {
                    this.ShippersRowChanged(this, new ShippersRowChangeEvent(((ShippersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.ShippersRowChanging != null)) {
                    this.ShippersRowChanging(this, new ShippersRowChangeEvent(((ShippersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.ShippersRowDeleted != null)) {
                    this.ShippersRowDeleted(this, new ShippersRowChangeEvent(((ShippersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.ShippersRowDeleting != null)) {
                    this.ShippersRowDeleting(this, new ShippersRowChangeEvent(((ShippersRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveShippersRow(ShippersRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ShippersRow : DataRow {
            
            private ShippersDataTable tableShippers;
            
            internal ShippersRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableShippers = ((ShippersDataTable)(this.Table));
            }
            
            public int ShipperID {
                get {
                    return ((int)(this[this.tableShippers.ShipperIDColumn]));
                }
                set {
                    this[this.tableShippers.ShipperIDColumn] = value;
                }
            }
            
            public string CompanyName {
                get {
                    return ((string)(this[this.tableShippers.CompanyNameColumn]));
                }
                set {
                    this[this.tableShippers.CompanyNameColumn] = value;
                }
            }
            
            public string Phone {
                get {
                    try {
                        return ((string)(this[this.tableShippers.PhoneColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableShippers.PhoneColumn] = value;
                }
            }
            
            public bool IsPhoneNull() {
                return this.IsNull(this.tableShippers.PhoneColumn);
            }
            
            public void SetPhoneNull() {
                this[this.tableShippers.PhoneColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ShippersRowChangeEvent : EventArgs {
            
            private ShippersRow eventRow;
            
            private DataRowAction eventAction;
            
            public ShippersRowChangeEvent(ShippersRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public ShippersRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class CustomersDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnCustomerID;
            
            private DataColumn columnCompanyName;
            
            private DataColumn columnContactName;
            
            private DataColumn columnContactTitle;
            
            private DataColumn columnAddress;
            
            private DataColumn columnCity;
            
            private DataColumn columnRegion;
            
            private DataColumn columnPostalCode;
            
            private DataColumn columnCountry;
            
            private DataColumn columnPhone;
            
            private DataColumn columnFax;
            
            internal CustomersDataTable() : 
                    base("Customers") {
                this.InitClass();
            }
            
            internal CustomersDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn CustomerIDColumn {
                get {
                    return this.columnCustomerID;
                }
            }
            
            internal DataColumn CompanyNameColumn {
                get {
                    return this.columnCompanyName;
                }
            }
            
            internal DataColumn ContactNameColumn {
                get {
                    return this.columnContactName;
                }
            }
            
            internal DataColumn ContactTitleColumn {
                get {
                    return this.columnContactTitle;
                }
            }
            
            internal DataColumn AddressColumn {
                get {
                    return this.columnAddress;
                }
            }
            
            internal DataColumn CityColumn {
                get {
                    return this.columnCity;
                }
            }
            
            internal DataColumn RegionColumn {
                get {
                    return this.columnRegion;
                }
            }
            
            internal DataColumn PostalCodeColumn {
                get {
                    return this.columnPostalCode;
                }
            }
            
            internal DataColumn CountryColumn {
                get {
                    return this.columnCountry;
                }
            }
            
            internal DataColumn PhoneColumn {
                get {
                    return this.columnPhone;
                }
            }
            
            internal DataColumn FaxColumn {
                get {
                    return this.columnFax;
                }
            }
            
            public CustomersRow this[int index] {
                get {
                    return ((CustomersRow)(this.Rows[index]));
                }
            }
            
            public event CustomersRowChangeEventHandler CustomersRowChanged;
            
            public event CustomersRowChangeEventHandler CustomersRowChanging;
            
            public event CustomersRowChangeEventHandler CustomersRowDeleted;
            
            public event CustomersRowChangeEventHandler CustomersRowDeleting;
            
            public void AddCustomersRow(CustomersRow row) {
                this.Rows.Add(row);
            }
            
            public CustomersRow AddCustomersRow(string CustomerID, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country, string Phone, string Fax) {
                CustomersRow rowCustomersRow = ((CustomersRow)(this.NewRow()));
                rowCustomersRow.ItemArray = new object[] {
                        CustomerID,
                        CompanyName,
                        ContactName,
                        ContactTitle,
                        Address,
                        City,
                        Region,
                        PostalCode,
                        Country,
                        Phone,
                        Fax};
                this.Rows.Add(rowCustomersRow);
                return rowCustomersRow;
            }
            
            public CustomersRow FindByCustomerID(string CustomerID) {
                return ((CustomersRow)(this.Rows.Find(new object[] {
                            CustomerID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                CustomersDataTable cln = ((CustomersDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new CustomersDataTable();
            }
            
            internal void InitVars() {
                this.columnCustomerID = this.Columns["CustomerID"];
                this.columnCompanyName = this.Columns["CompanyName"];
                this.columnContactName = this.Columns["ContactName"];
                this.columnContactTitle = this.Columns["ContactTitle"];
                this.columnAddress = this.Columns["Address"];
                this.columnCity = this.Columns["City"];
                this.columnRegion = this.Columns["Region"];
                this.columnPostalCode = this.Columns["PostalCode"];
                this.columnCountry = this.Columns["Country"];
                this.columnPhone = this.Columns["Phone"];
                this.columnFax = this.Columns["Fax"];
            }
            
            private void InitClass() {
                this.columnCustomerID = new DataColumn("CustomerID", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCustomerID);
                this.columnCompanyName = new DataColumn("CompanyName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCompanyName);
                this.columnContactName = new DataColumn("ContactName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnContactName);
                this.columnContactTitle = new DataColumn("ContactTitle", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnContactTitle);
                this.columnAddress = new DataColumn("Address", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAddress);
                this.columnCity = new DataColumn("City", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCity);
                this.columnRegion = new DataColumn("Region", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRegion);
                this.columnPostalCode = new DataColumn("PostalCode", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPostalCode);
                this.columnCountry = new DataColumn("Country", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCountry);
                this.columnPhone = new DataColumn("Phone", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPhone);
                this.columnFax = new DataColumn("Fax", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFax);
                this.Constraints.Add(new UniqueConstraint("NorthwindDataSetKey7", new DataColumn[] {
                                this.columnCustomerID}, true));
                this.columnCustomerID.AllowDBNull = false;
                this.columnCustomerID.Unique = true;
                this.columnCompanyName.AllowDBNull = false;
            }
            
            public CustomersRow NewCustomersRow() {
                return ((CustomersRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new CustomersRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(CustomersRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.CustomersRowChanged != null)) {
                    this.CustomersRowChanged(this, new CustomersRowChangeEvent(((CustomersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.CustomersRowChanging != null)) {
                    this.CustomersRowChanging(this, new CustomersRowChangeEvent(((CustomersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.CustomersRowDeleted != null)) {
                    this.CustomersRowDeleted(this, new CustomersRowChangeEvent(((CustomersRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.CustomersRowDeleting != null)) {
                    this.CustomersRowDeleting(this, new CustomersRowChangeEvent(((CustomersRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveCustomersRow(CustomersRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class CustomersRow : DataRow {
            
            private CustomersDataTable tableCustomers;
            
            internal CustomersRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableCustomers = ((CustomersDataTable)(this.Table));
            }
            
            public string CustomerID {
                get {
                    return ((string)(this[this.tableCustomers.CustomerIDColumn]));
                }
                set {
                    this[this.tableCustomers.CustomerIDColumn] = value;
                }
            }
            
            public string CompanyName {
                get {
                    return ((string)(this[this.tableCustomers.CompanyNameColumn]));
                }
                set {
                    this[this.tableCustomers.CompanyNameColumn] = value;
                }
            }
            
            public string ContactName {
                get {
                    try {
                        return ((string)(this[this.tableCustomers.ContactNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomers.ContactNameColumn] = value;
                }
            }
            
            public string ContactTitle {
                get {
                    try {
                        return ((string)(this[this.tableCustomers.ContactTitleColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomers.ContactTitleColumn] = value;
                }
            }
            
            public string Address {
                get {
                    try {
                        return ((string)(this[this.tableCustomers.AddressColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomers.AddressColumn] = value;
                }
            }
            
            public string City {
                get {
                    try {
                        return ((string)(this[this.tableCustomers.CityColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomers.CityColumn] = value;
                }
            }
            
            public string Region {
                get {
                    try {
                        return ((string)(this[this.tableCustomers.RegionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomers.RegionColumn] = value;
                }
            }
            
            public string PostalCode {
                get {
                    try {
                        return ((string)(this[this.tableCustomers.PostalCodeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomers.PostalCodeColumn] = value;
                }
            }
            
            public string Country {
                get {
                    try {
                        return ((string)(this[this.tableCustomers.CountryColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomers.CountryColumn] = value;
                }
            }
            
            public string Phone {
                get {
                    try {
                        return ((string)(this[this.tableCustomers.PhoneColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomers.PhoneColumn] = value;
                }
            }
            
            public string Fax {
                get {
                    try {
                        return ((string)(this[this.tableCustomers.FaxColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomers.FaxColumn] = value;
                }
            }
            
            public bool IsContactNameNull() {
                return this.IsNull(this.tableCustomers.ContactNameColumn);
            }
            
            public void SetContactNameNull() {
                this[this.tableCustomers.ContactNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsContactTitleNull() {
                return this.IsNull(this.tableCustomers.ContactTitleColumn);
            }
            
            public void SetContactTitleNull() {
                this[this.tableCustomers.ContactTitleColumn] = System.Convert.DBNull;
            }
            
            public bool IsAddressNull() {
                return this.IsNull(this.tableCustomers.AddressColumn);
            }
            
            public void SetAddressNull() {
                this[this.tableCustomers.AddressColumn] = System.Convert.DBNull;
            }
            
            public bool IsCityNull() {
                return this.IsNull(this.tableCustomers.CityColumn);
            }
            
            public void SetCityNull() {
                this[this.tableCustomers.CityColumn] = System.Convert.DBNull;
            }
            
            public bool IsRegionNull() {
                return this.IsNull(this.tableCustomers.RegionColumn);
            }
            
            public void SetRegionNull() {
                this[this.tableCustomers.RegionColumn] = System.Convert.DBNull;
            }
            
            public bool IsPostalCodeNull() {
                return this.IsNull(this.tableCustomers.PostalCodeColumn);
            }
            
            public void SetPostalCodeNull() {
                this[this.tableCustomers.PostalCodeColumn] = System.Convert.DBNull;
            }
            
            public bool IsCountryNull() {
                return this.IsNull(this.tableCustomers.CountryColumn);
            }
            
            public void SetCountryNull() {
                this[this.tableCustomers.CountryColumn] = System.Convert.DBNull;
            }
            
            public bool IsPhoneNull() {
                return this.IsNull(this.tableCustomers.PhoneColumn);
            }
            
            public void SetPhoneNull() {
                this[this.tableCustomers.PhoneColumn] = System.Convert.DBNull;
            }
            
            public bool IsFaxNull() {
                return this.IsNull(this.tableCustomers.FaxColumn);
            }
            
            public void SetFaxNull() {
                this[this.tableCustomers.FaxColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class CustomersRowChangeEvent : EventArgs {
            
            private CustomersRow eventRow;
            
            private DataRowAction eventAction;
            
            public CustomersRowChangeEvent(CustomersRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public CustomersRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
