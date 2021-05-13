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

namespace ProductRatings {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class ProductRatingsDataSet : DataSet {
        
        private CustomersDataTable tableCustomers;
        
        private ProductsDataTable tableProducts;
        
        private RatingDescriptionDataTable tableRatingDescription;
        
        private RatingsDataTable tableRatings;
        
        private SuppliersDataTable tableSuppliers;
        
        private DataRelation relationProductsRatings;
        
        public ProductRatingsDataSet() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected ProductRatingsDataSet(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Customers"] != null)) {
                    this.Tables.Add(new CustomersDataTable(ds.Tables["Customers"]));
                }
                if ((ds.Tables["Products"] != null)) {
                    this.Tables.Add(new ProductsDataTable(ds.Tables["Products"]));
                }
                if ((ds.Tables["RatingDescription"] != null)) {
                    this.Tables.Add(new RatingDescriptionDataTable(ds.Tables["RatingDescription"]));
                }
                if ((ds.Tables["Ratings"] != null)) {
                    this.Tables.Add(new RatingsDataTable(ds.Tables["Ratings"]));
                }
                if ((ds.Tables["Suppliers"] != null)) {
                    this.Tables.Add(new SuppliersDataTable(ds.Tables["Suppliers"]));
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
        public CustomersDataTable Customers {
            get {
                return this.tableCustomers;
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
        public RatingDescriptionDataTable RatingDescription {
            get {
                return this.tableRatingDescription;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public RatingsDataTable Ratings {
            get {
                return this.tableRatings;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public SuppliersDataTable Suppliers {
            get {
                return this.tableSuppliers;
            }
        }
        
        public override DataSet Clone() {
            ProductRatingsDataSet cln = ((ProductRatingsDataSet)(base.Clone()));
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
            if ((ds.Tables["Customers"] != null)) {
                this.Tables.Add(new CustomersDataTable(ds.Tables["Customers"]));
            }
            if ((ds.Tables["Products"] != null)) {
                this.Tables.Add(new ProductsDataTable(ds.Tables["Products"]));
            }
            if ((ds.Tables["RatingDescription"] != null)) {
                this.Tables.Add(new RatingDescriptionDataTable(ds.Tables["RatingDescription"]));
            }
            if ((ds.Tables["Ratings"] != null)) {
                this.Tables.Add(new RatingsDataTable(ds.Tables["Ratings"]));
            }
            if ((ds.Tables["Suppliers"] != null)) {
                this.Tables.Add(new SuppliersDataTable(ds.Tables["Suppliers"]));
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
            this.tableCustomers = ((CustomersDataTable)(this.Tables["Customers"]));
            if ((this.tableCustomers != null)) {
                this.tableCustomers.InitVars();
            }
            this.tableProducts = ((ProductsDataTable)(this.Tables["Products"]));
            if ((this.tableProducts != null)) {
                this.tableProducts.InitVars();
            }
            this.tableRatingDescription = ((RatingDescriptionDataTable)(this.Tables["RatingDescription"]));
            if ((this.tableRatingDescription != null)) {
                this.tableRatingDescription.InitVars();
            }
            this.tableRatings = ((RatingsDataTable)(this.Tables["Ratings"]));
            if ((this.tableRatings != null)) {
                this.tableRatings.InitVars();
            }
            this.tableSuppliers = ((SuppliersDataTable)(this.Tables["Suppliers"]));
            if ((this.tableSuppliers != null)) {
                this.tableSuppliers.InitVars();
            }
            this.relationProductsRatings = this.Relations["ProductsRatings"];
        }
        
        private void InitClass() {
            this.DataSetName = "ProductRatingsDataSet";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/ProductRatingsDataSet.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableCustomers = new CustomersDataTable();
            this.Tables.Add(this.tableCustomers);
            this.tableProducts = new ProductsDataTable();
            this.Tables.Add(this.tableProducts);
            this.tableRatingDescription = new RatingDescriptionDataTable();
            this.Tables.Add(this.tableRatingDescription);
            this.tableRatings = new RatingsDataTable();
            this.Tables.Add(this.tableRatings);
            this.tableSuppliers = new SuppliersDataTable();
            this.Tables.Add(this.tableSuppliers);
            ForeignKeyConstraint fkc;
            fkc = new ForeignKeyConstraint("SuppliersProducts", new DataColumn[] {
                        this.tableSuppliers.SupplierIDColumn}, new DataColumn[] {
                        this.tableProducts.SupplierIDColumn});
            this.tableProducts.Constraints.Add(fkc);
            fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None;
            fkc.DeleteRule = System.Data.Rule.Cascade;
            fkc.UpdateRule = System.Data.Rule.Cascade;
            fkc = new ForeignKeyConstraint("ProductsRatings", new DataColumn[] {
                        this.tableProducts.ProductIDColumn}, new DataColumn[] {
                        this.tableRatings.ProductIDColumn});
            this.tableRatings.Constraints.Add(fkc);
            fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None;
            fkc.DeleteRule = System.Data.Rule.Cascade;
            fkc.UpdateRule = System.Data.Rule.Cascade;
            fkc = new ForeignKeyConstraint("RatingDescriptionRatings", new DataColumn[] {
                        this.tableRatingDescription.RatingIDColumn}, new DataColumn[] {
                        this.tableRatings.RatingIDColumn});
            this.tableRatings.Constraints.Add(fkc);
            fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None;
            fkc.DeleteRule = System.Data.Rule.Cascade;
            fkc.UpdateRule = System.Data.Rule.Cascade;
            fkc = new ForeignKeyConstraint("CustomersRatings", new DataColumn[] {
                        this.tableCustomers.CustomerIDColumn}, new DataColumn[] {
                        this.tableRatings.CustomerIDColumn});
            this.tableRatings.Constraints.Add(fkc);
            fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None;
            fkc.DeleteRule = System.Data.Rule.Cascade;
            fkc.UpdateRule = System.Data.Rule.Cascade;
            this.relationProductsRatings = new DataRelation("ProductsRatings", new DataColumn[] {
                        this.tableProducts.ProductIDColumn}, new DataColumn[] {
                        this.tableRatings.ProductIDColumn}, false);
            this.Relations.Add(this.relationProductsRatings);
        }
        
        private bool ShouldSerializeCustomers() {
            return false;
        }
        
        private bool ShouldSerializeProducts() {
            return false;
        }
        
        private bool ShouldSerializeRatingDescription() {
            return false;
        }
        
        private bool ShouldSerializeRatings() {
            return false;
        }
        
        private bool ShouldSerializeSuppliers() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void CustomersRowChangeEventHandler(object sender, CustomersRowChangeEvent e);
        
        public delegate void ProductsRowChangeEventHandler(object sender, ProductsRowChangeEvent e);
        
        public delegate void RatingDescriptionRowChangeEventHandler(object sender, RatingDescriptionRowChangeEvent e);
        
        public delegate void RatingsRowChangeEventHandler(object sender, RatingsRowChangeEvent e);
        
        public delegate void SuppliersRowChangeEventHandler(object sender, SuppliersRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class CustomersDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnAddress;
            
            private DataColumn columnCity;
            
            private DataColumn columnCompanyName;
            
            private DataColumn columnContactName;
            
            private DataColumn columnContactTitle;
            
            private DataColumn columnCountry;
            
            private DataColumn columnCustomerID;
            
            private DataColumn columnFax;
            
            private DataColumn columnPhone;
            
            private DataColumn columnPostalCode;
            
            private DataColumn columnRegion;
            
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
            
            internal DataColumn CountryColumn {
                get {
                    return this.columnCountry;
                }
            }
            
            internal DataColumn CustomerIDColumn {
                get {
                    return this.columnCustomerID;
                }
            }
            
            internal DataColumn FaxColumn {
                get {
                    return this.columnFax;
                }
            }
            
            internal DataColumn PhoneColumn {
                get {
                    return this.columnPhone;
                }
            }
            
            internal DataColumn PostalCodeColumn {
                get {
                    return this.columnPostalCode;
                }
            }
            
            internal DataColumn RegionColumn {
                get {
                    return this.columnRegion;
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
            
            public CustomersRow AddCustomersRow(string Address, string City, string CompanyName, string ContactName, string ContactTitle, string Country, string CustomerID, string Fax, string Phone, string PostalCode, string Region) {
                CustomersRow rowCustomersRow = ((CustomersRow)(this.NewRow()));
                rowCustomersRow.ItemArray = new object[] {
                        Address,
                        City,
                        CompanyName,
                        ContactName,
                        ContactTitle,
                        Country,
                        CustomerID,
                        Fax,
                        Phone,
                        PostalCode,
                        Region};
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
                this.columnAddress = this.Columns["Address"];
                this.columnCity = this.Columns["City"];
                this.columnCompanyName = this.Columns["CompanyName"];
                this.columnContactName = this.Columns["ContactName"];
                this.columnContactTitle = this.Columns["ContactTitle"];
                this.columnCountry = this.Columns["Country"];
                this.columnCustomerID = this.Columns["CustomerID"];
                this.columnFax = this.Columns["Fax"];
                this.columnPhone = this.Columns["Phone"];
                this.columnPostalCode = this.Columns["PostalCode"];
                this.columnRegion = this.Columns["Region"];
            }
            
            private void InitClass() {
                this.columnAddress = new DataColumn("Address", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAddress);
                this.columnCity = new DataColumn("City", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCity);
                this.columnCompanyName = new DataColumn("CompanyName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCompanyName);
                this.columnContactName = new DataColumn("ContactName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnContactName);
                this.columnContactTitle = new DataColumn("ContactTitle", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnContactTitle);
                this.columnCountry = new DataColumn("Country", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCountry);
                this.columnCustomerID = new DataColumn("CustomerID", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCustomerID);
                this.columnFax = new DataColumn("Fax", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFax);
                this.columnPhone = new DataColumn("Phone", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPhone);
                this.columnPostalCode = new DataColumn("PostalCode", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPostalCode);
                this.columnRegion = new DataColumn("Region", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRegion);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnCustomerID}, true));
                this.columnCustomerID.AllowDBNull = false;
                this.columnCustomerID.Unique = true;
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
            
            public string CompanyName {
                get {
                    try {
                        return ((string)(this[this.tableCustomers.CompanyNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
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
            
            public string CustomerID {
                get {
                    return ((string)(this[this.tableCustomers.CustomerIDColumn]));
                }
                set {
                    this[this.tableCustomers.CustomerIDColumn] = value;
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
            
            public bool IsCompanyNameNull() {
                return this.IsNull(this.tableCustomers.CompanyNameColumn);
            }
            
            public void SetCompanyNameNull() {
                this[this.tableCustomers.CompanyNameColumn] = System.Convert.DBNull;
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
            
            public bool IsCountryNull() {
                return this.IsNull(this.tableCustomers.CountryColumn);
            }
            
            public void SetCountryNull() {
                this[this.tableCustomers.CountryColumn] = System.Convert.DBNull;
            }
            
            public bool IsFaxNull() {
                return this.IsNull(this.tableCustomers.FaxColumn);
            }
            
            public void SetFaxNull() {
                this[this.tableCustomers.FaxColumn] = System.Convert.DBNull;
            }
            
            public bool IsPhoneNull() {
                return this.IsNull(this.tableCustomers.PhoneColumn);
            }
            
            public void SetPhoneNull() {
                this[this.tableCustomers.PhoneColumn] = System.Convert.DBNull;
            }
            
            public bool IsPostalCodeNull() {
                return this.IsNull(this.tableCustomers.PostalCodeColumn);
            }
            
            public void SetPostalCodeNull() {
                this[this.tableCustomers.PostalCodeColumn] = System.Convert.DBNull;
            }
            
            public bool IsRegionNull() {
                return this.IsNull(this.tableCustomers.RegionColumn);
            }
            
            public void SetRegionNull() {
                this[this.tableCustomers.RegionColumn] = System.Convert.DBNull;
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
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ProductsDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnCategoryID;
            
            private DataColumn columnDiscontinued;
            
            private DataColumn columnProductID;
            
            private DataColumn columnProductName;
            
            private DataColumn columnQuantityPerUnit;
            
            private DataColumn columnReorderLevel;
            
            private DataColumn columnSupplierID;
            
            private DataColumn columnUnitPrice;
            
            private DataColumn columnUnitsInStock;
            
            private DataColumn columnUnitsOnOrder;
            
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
            
            internal DataColumn CategoryIDColumn {
                get {
                    return this.columnCategoryID;
                }
            }
            
            internal DataColumn DiscontinuedColumn {
                get {
                    return this.columnDiscontinued;
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
            
            internal DataColumn QuantityPerUnitColumn {
                get {
                    return this.columnQuantityPerUnit;
                }
            }
            
            internal DataColumn ReorderLevelColumn {
                get {
                    return this.columnReorderLevel;
                }
            }
            
            internal DataColumn SupplierIDColumn {
                get {
                    return this.columnSupplierID;
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
            
            public ProductsRow AddProductsRow(int CategoryID, bool Discontinued, string ProductName, string QuantityPerUnit, short ReorderLevel, int SupplierID, System.Decimal UnitPrice, short UnitsInStock, short UnitsOnOrder) {
                ProductsRow rowProductsRow = ((ProductsRow)(this.NewRow()));
                rowProductsRow.ItemArray = new object[] {
                        CategoryID,
                        Discontinued,
                        null,
                        ProductName,
                        QuantityPerUnit,
                        ReorderLevel,
                        SupplierID,
                        UnitPrice,
                        UnitsInStock,
                        UnitsOnOrder};
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
                this.columnCategoryID = this.Columns["CategoryID"];
                this.columnDiscontinued = this.Columns["Discontinued"];
                this.columnProductID = this.Columns["ProductID"];
                this.columnProductName = this.Columns["ProductName"];
                this.columnQuantityPerUnit = this.Columns["QuantityPerUnit"];
                this.columnReorderLevel = this.Columns["ReorderLevel"];
                this.columnSupplierID = this.Columns["SupplierID"];
                this.columnUnitPrice = this.Columns["UnitPrice"];
                this.columnUnitsInStock = this.Columns["UnitsInStock"];
                this.columnUnitsOnOrder = this.Columns["UnitsOnOrder"];
            }
            
            private void InitClass() {
                this.columnCategoryID = new DataColumn("CategoryID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCategoryID);
                this.columnDiscontinued = new DataColumn("Discontinued", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDiscontinued);
                this.columnProductID = new DataColumn("ProductID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnProductID);
                this.columnProductName = new DataColumn("ProductName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnProductName);
                this.columnQuantityPerUnit = new DataColumn("QuantityPerUnit", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnQuantityPerUnit);
                this.columnReorderLevel = new DataColumn("ReorderLevel", typeof(short), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnReorderLevel);
                this.columnSupplierID = new DataColumn("SupplierID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnSupplierID);
                this.columnUnitPrice = new DataColumn("UnitPrice", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUnitPrice);
                this.columnUnitsInStock = new DataColumn("UnitsInStock", typeof(short), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUnitsInStock);
                this.columnUnitsOnOrder = new DataColumn("UnitsOnOrder", typeof(short), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUnitsOnOrder);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnProductID}, true));
                this.columnProductID.AutoIncrement = true;
                this.columnProductID.AllowDBNull = false;
                this.columnProductID.Unique = true;
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
            
            public bool Discontinued {
                get {
                    try {
                        return ((bool)(this[this.tableProducts.DiscontinuedColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableProducts.DiscontinuedColumn] = value;
                }
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
                    try {
                        return ((string)(this[this.tableProducts.ProductNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableProducts.ProductNameColumn] = value;
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
            
            public bool IsCategoryIDNull() {
                return this.IsNull(this.tableProducts.CategoryIDColumn);
            }
            
            public void SetCategoryIDNull() {
                this[this.tableProducts.CategoryIDColumn] = System.Convert.DBNull;
            }
            
            public bool IsDiscontinuedNull() {
                return this.IsNull(this.tableProducts.DiscontinuedColumn);
            }
            
            public void SetDiscontinuedNull() {
                this[this.tableProducts.DiscontinuedColumn] = System.Convert.DBNull;
            }
            
            public bool IsProductNameNull() {
                return this.IsNull(this.tableProducts.ProductNameColumn);
            }
            
            public void SetProductNameNull() {
                this[this.tableProducts.ProductNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsQuantityPerUnitNull() {
                return this.IsNull(this.tableProducts.QuantityPerUnitColumn);
            }
            
            public void SetQuantityPerUnitNull() {
                this[this.tableProducts.QuantityPerUnitColumn] = System.Convert.DBNull;
            }
            
            public bool IsReorderLevelNull() {
                return this.IsNull(this.tableProducts.ReorderLevelColumn);
            }
            
            public void SetReorderLevelNull() {
                this[this.tableProducts.ReorderLevelColumn] = System.Convert.DBNull;
            }
            
            public bool IsSupplierIDNull() {
                return this.IsNull(this.tableProducts.SupplierIDColumn);
            }
            
            public void SetSupplierIDNull() {
                this[this.tableProducts.SupplierIDColumn] = System.Convert.DBNull;
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
            
            public RatingsRow[] GetRatingsRows() {
                return ((RatingsRow[])(this.GetChildRows(this.Table.ChildRelations["ProductsRatings"])));
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
        public class RatingDescriptionDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnDescription;
            
            private DataColumn columnRatingID;
            
            internal RatingDescriptionDataTable() : 
                    base("RatingDescription") {
                this.InitClass();
            }
            
            internal RatingDescriptionDataTable(DataTable table) : 
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
            
            internal DataColumn DescriptionColumn {
                get {
                    return this.columnDescription;
                }
            }
            
            internal DataColumn RatingIDColumn {
                get {
                    return this.columnRatingID;
                }
            }
            
            public RatingDescriptionRow this[int index] {
                get {
                    return ((RatingDescriptionRow)(this.Rows[index]));
                }
            }
            
            public event RatingDescriptionRowChangeEventHandler RatingDescriptionRowChanged;
            
            public event RatingDescriptionRowChangeEventHandler RatingDescriptionRowChanging;
            
            public event RatingDescriptionRowChangeEventHandler RatingDescriptionRowDeleted;
            
            public event RatingDescriptionRowChangeEventHandler RatingDescriptionRowDeleting;
            
            public void AddRatingDescriptionRow(RatingDescriptionRow row) {
                this.Rows.Add(row);
            }
            
            public RatingDescriptionRow AddRatingDescriptionRow(string Description, int RatingID) {
                RatingDescriptionRow rowRatingDescriptionRow = ((RatingDescriptionRow)(this.NewRow()));
                rowRatingDescriptionRow.ItemArray = new object[] {
                        Description,
                        RatingID};
                this.Rows.Add(rowRatingDescriptionRow);
                return rowRatingDescriptionRow;
            }
            
            public RatingDescriptionRow FindByRatingID(int RatingID) {
                return ((RatingDescriptionRow)(this.Rows.Find(new object[] {
                            RatingID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                RatingDescriptionDataTable cln = ((RatingDescriptionDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new RatingDescriptionDataTable();
            }
            
            internal void InitVars() {
                this.columnDescription = this.Columns["Description"];
                this.columnRatingID = this.Columns["RatingID"];
            }
            
            private void InitClass() {
                this.columnDescription = new DataColumn("Description", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescription);
                this.columnRatingID = new DataColumn("RatingID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRatingID);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnRatingID}, true));
                this.columnRatingID.AllowDBNull = false;
                this.columnRatingID.Unique = true;
            }
            
            public RatingDescriptionRow NewRatingDescriptionRow() {
                return ((RatingDescriptionRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new RatingDescriptionRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(RatingDescriptionRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.RatingDescriptionRowChanged != null)) {
                    this.RatingDescriptionRowChanged(this, new RatingDescriptionRowChangeEvent(((RatingDescriptionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.RatingDescriptionRowChanging != null)) {
                    this.RatingDescriptionRowChanging(this, new RatingDescriptionRowChangeEvent(((RatingDescriptionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.RatingDescriptionRowDeleted != null)) {
                    this.RatingDescriptionRowDeleted(this, new RatingDescriptionRowChangeEvent(((RatingDescriptionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.RatingDescriptionRowDeleting != null)) {
                    this.RatingDescriptionRowDeleting(this, new RatingDescriptionRowChangeEvent(((RatingDescriptionRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveRatingDescriptionRow(RatingDescriptionRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class RatingDescriptionRow : DataRow {
            
            private RatingDescriptionDataTable tableRatingDescription;
            
            internal RatingDescriptionRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableRatingDescription = ((RatingDescriptionDataTable)(this.Table));
            }
            
            public string Description {
                get {
                    try {
                        return ((string)(this[this.tableRatingDescription.DescriptionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableRatingDescription.DescriptionColumn] = value;
                }
            }
            
            public int RatingID {
                get {
                    return ((int)(this[this.tableRatingDescription.RatingIDColumn]));
                }
                set {
                    this[this.tableRatingDescription.RatingIDColumn] = value;
                }
            }
            
            public bool IsDescriptionNull() {
                return this.IsNull(this.tableRatingDescription.DescriptionColumn);
            }
            
            public void SetDescriptionNull() {
                this[this.tableRatingDescription.DescriptionColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class RatingDescriptionRowChangeEvent : EventArgs {
            
            private RatingDescriptionRow eventRow;
            
            private DataRowAction eventAction;
            
            public RatingDescriptionRowChangeEvent(RatingDescriptionRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public RatingDescriptionRow Row {
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
        public class RatingsDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnCustomerID;
            
            private DataColumn columnProductID;
            
            private DataColumn columnRatingID;
            
            internal RatingsDataTable() : 
                    base("Ratings") {
                this.InitClass();
            }
            
            internal RatingsDataTable(DataTable table) : 
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
            
            internal DataColumn ProductIDColumn {
                get {
                    return this.columnProductID;
                }
            }
            
            internal DataColumn RatingIDColumn {
                get {
                    return this.columnRatingID;
                }
            }
            
            public RatingsRow this[int index] {
                get {
                    return ((RatingsRow)(this.Rows[index]));
                }
            }
            
            public event RatingsRowChangeEventHandler RatingsRowChanged;
            
            public event RatingsRowChangeEventHandler RatingsRowChanging;
            
            public event RatingsRowChangeEventHandler RatingsRowDeleted;
            
            public event RatingsRowChangeEventHandler RatingsRowDeleting;
            
            public void AddRatingsRow(RatingsRow row) {
                this.Rows.Add(row);
            }
            
            public RatingsRow AddRatingsRow(string CustomerID, ProductsRow parentProductsRowByProductsRatings, int RatingID) {
                RatingsRow rowRatingsRow = ((RatingsRow)(this.NewRow()));
                rowRatingsRow.ItemArray = new object[] {
                        CustomerID,
                        parentProductsRowByProductsRatings[2],
                        RatingID};
                this.Rows.Add(rowRatingsRow);
                return rowRatingsRow;
            }
            
            public RatingsRow FindByCustomerIDProductID(string CustomerID, int ProductID) {
                return ((RatingsRow)(this.Rows.Find(new object[] {
                            CustomerID,
                            ProductID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                RatingsDataTable cln = ((RatingsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new RatingsDataTable();
            }
            
            internal void InitVars() {
                this.columnCustomerID = this.Columns["CustomerID"];
                this.columnProductID = this.Columns["ProductID"];
                this.columnRatingID = this.Columns["RatingID"];
            }
            
            private void InitClass() {
                this.columnCustomerID = new DataColumn("CustomerID", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCustomerID);
                this.columnProductID = new DataColumn("ProductID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnProductID);
                this.columnRatingID = new DataColumn("RatingID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRatingID);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnCustomerID,
                                this.columnProductID}, true));
                this.columnCustomerID.AllowDBNull = false;
                this.columnProductID.AllowDBNull = false;
            }
            
            public RatingsRow NewRatingsRow() {
                return ((RatingsRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new RatingsRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(RatingsRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.RatingsRowChanged != null)) {
                    this.RatingsRowChanged(this, new RatingsRowChangeEvent(((RatingsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.RatingsRowChanging != null)) {
                    this.RatingsRowChanging(this, new RatingsRowChangeEvent(((RatingsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.RatingsRowDeleted != null)) {
                    this.RatingsRowDeleted(this, new RatingsRowChangeEvent(((RatingsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.RatingsRowDeleting != null)) {
                    this.RatingsRowDeleting(this, new RatingsRowChangeEvent(((RatingsRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveRatingsRow(RatingsRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class RatingsRow : DataRow {
            
            private RatingsDataTable tableRatings;
            
            internal RatingsRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableRatings = ((RatingsDataTable)(this.Table));
            }
            
            public string CustomerID {
                get {
                    return ((string)(this[this.tableRatings.CustomerIDColumn]));
                }
                set {
                    this[this.tableRatings.CustomerIDColumn] = value;
                }
            }
            
            public int ProductID {
                get {
                    return ((int)(this[this.tableRatings.ProductIDColumn]));
                }
                set {
                    this[this.tableRatings.ProductIDColumn] = value;
                }
            }
            
            public int RatingID {
                get {
                    try {
                        return ((int)(this[this.tableRatings.RatingIDColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableRatings.RatingIDColumn] = value;
                }
            }
            
            public ProductsRow ProductsRow {
                get {
                    return ((ProductsRow)(this.GetParentRow(this.Table.ParentRelations["ProductsRatings"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["ProductsRatings"]);
                }
            }
            
            public bool IsRatingIDNull() {
                return this.IsNull(this.tableRatings.RatingIDColumn);
            }
            
            public void SetRatingIDNull() {
                this[this.tableRatings.RatingIDColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class RatingsRowChangeEvent : EventArgs {
            
            private RatingsRow eventRow;
            
            private DataRowAction eventAction;
            
            public RatingsRowChangeEvent(RatingsRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public RatingsRow Row {
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
            
            private DataColumn columnAddress;
            
            private DataColumn columnCity;
            
            private DataColumn columnCompanyName;
            
            private DataColumn columnContactName;
            
            private DataColumn columnContactTitle;
            
            private DataColumn columnCountry;
            
            private DataColumn columnFax;
            
            private DataColumn columnHomePage;
            
            private DataColumn columnPhone;
            
            private DataColumn columnPostalCode;
            
            private DataColumn columnRegion;
            
            private DataColumn columnSupplierID;
            
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
            
            internal DataColumn CountryColumn {
                get {
                    return this.columnCountry;
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
            
            internal DataColumn PhoneColumn {
                get {
                    return this.columnPhone;
                }
            }
            
            internal DataColumn PostalCodeColumn {
                get {
                    return this.columnPostalCode;
                }
            }
            
            internal DataColumn RegionColumn {
                get {
                    return this.columnRegion;
                }
            }
            
            internal DataColumn SupplierIDColumn {
                get {
                    return this.columnSupplierID;
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
            
            public SuppliersRow AddSuppliersRow(string Address, string City, string CompanyName, string ContactName, string ContactTitle, string Country, string Fax, string HomePage, string Phone, string PostalCode, string Region) {
                SuppliersRow rowSuppliersRow = ((SuppliersRow)(this.NewRow()));
                rowSuppliersRow.ItemArray = new object[] {
                        Address,
                        City,
                        CompanyName,
                        ContactName,
                        ContactTitle,
                        Country,
                        Fax,
                        HomePage,
                        Phone,
                        PostalCode,
                        Region,
                        null};
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
                this.columnAddress = this.Columns["Address"];
                this.columnCity = this.Columns["City"];
                this.columnCompanyName = this.Columns["CompanyName"];
                this.columnContactName = this.Columns["ContactName"];
                this.columnContactTitle = this.Columns["ContactTitle"];
                this.columnCountry = this.Columns["Country"];
                this.columnFax = this.Columns["Fax"];
                this.columnHomePage = this.Columns["HomePage"];
                this.columnPhone = this.Columns["Phone"];
                this.columnPostalCode = this.Columns["PostalCode"];
                this.columnRegion = this.Columns["Region"];
                this.columnSupplierID = this.Columns["SupplierID"];
            }
            
            private void InitClass() {
                this.columnAddress = new DataColumn("Address", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAddress);
                this.columnCity = new DataColumn("City", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCity);
                this.columnCompanyName = new DataColumn("CompanyName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCompanyName);
                this.columnContactName = new DataColumn("ContactName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnContactName);
                this.columnContactTitle = new DataColumn("ContactTitle", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnContactTitle);
                this.columnCountry = new DataColumn("Country", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCountry);
                this.columnFax = new DataColumn("Fax", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFax);
                this.columnHomePage = new DataColumn("HomePage", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnHomePage);
                this.columnPhone = new DataColumn("Phone", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPhone);
                this.columnPostalCode = new DataColumn("PostalCode", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPostalCode);
                this.columnRegion = new DataColumn("Region", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRegion);
                this.columnSupplierID = new DataColumn("SupplierID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnSupplierID);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnSupplierID}, true));
                this.columnSupplierID.AutoIncrement = true;
                this.columnSupplierID.AllowDBNull = false;
                this.columnSupplierID.Unique = true;
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
            
            public string CompanyName {
                get {
                    try {
                        return ((string)(this[this.tableSuppliers.CompanyNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
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
            
            public int SupplierID {
                get {
                    return ((int)(this[this.tableSuppliers.SupplierIDColumn]));
                }
                set {
                    this[this.tableSuppliers.SupplierIDColumn] = value;
                }
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
            
            public bool IsCompanyNameNull() {
                return this.IsNull(this.tableSuppliers.CompanyNameColumn);
            }
            
            public void SetCompanyNameNull() {
                this[this.tableSuppliers.CompanyNameColumn] = System.Convert.DBNull;
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
            
            public bool IsCountryNull() {
                return this.IsNull(this.tableSuppliers.CountryColumn);
            }
            
            public void SetCountryNull() {
                this[this.tableSuppliers.CountryColumn] = System.Convert.DBNull;
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
            
            public bool IsPhoneNull() {
                return this.IsNull(this.tableSuppliers.PhoneColumn);
            }
            
            public void SetPhoneNull() {
                this[this.tableSuppliers.PhoneColumn] = System.Convert.DBNull;
            }
            
            public bool IsPostalCodeNull() {
                return this.IsNull(this.tableSuppliers.PostalCodeColumn);
            }
            
            public void SetPostalCodeNull() {
                this[this.tableSuppliers.PostalCodeColumn] = System.Convert.DBNull;
            }
            
            public bool IsRegionNull() {
                return this.IsNull(this.tableSuppliers.RegionColumn);
            }
            
            public void SetRegionNull() {
                this[this.tableSuppliers.RegionColumn] = System.Convert.DBNull;
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
    }
}
