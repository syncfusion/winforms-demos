#region Copyright Syncfusion Inc. 2001 - 2013
//
//  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

namespace CustomViews {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class DataSet1 : DataSet {
        
        private CustomersDataTable tableCustomers;
        
        public DataSet1() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected DataSet1(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
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
        public CustomersDataTable Customers {
            get {
                return this.tableCustomers;
            }
        }
        
        public override DataSet Clone() {
            DataSet1 cln = ((DataSet1)(base.Clone()));
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
        }
        
        private void InitClass() {
            this.DataSetName = "DataSet1";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/DataSet1.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableCustomers = new CustomersDataTable();
            this.Tables.Add(this.tableCustomers);
        }
        
        private bool ShouldSerializeCustomers() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void CustomersRowChangeEventHandler(object sender, CustomersRowChangeEvent e);
        
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
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
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
