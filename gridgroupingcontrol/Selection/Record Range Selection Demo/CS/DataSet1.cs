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

namespace MultipleRecordSelection {
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
        
        private OrdersDataTable tableOrders;
        
        private DataRelation relationCustomersOrders;
        
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
                if ((ds.Tables["Orders"] != null)) {
                    this.Tables.Add(new OrdersDataTable(ds.Tables["Orders"]));
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
        public OrdersDataTable Orders {
            get {
                return this.tableOrders;
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
            if ((ds.Tables["Orders"] != null)) {
                this.Tables.Add(new OrdersDataTable(ds.Tables["Orders"]));
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
            this.tableOrders = ((OrdersDataTable)(this.Tables["Orders"]));
            if ((this.tableOrders != null)) {
                this.tableOrders.InitVars();
            }
            this.relationCustomersOrders = this.Relations["CustomersOrders"];
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
            this.tableOrders = new OrdersDataTable();
            this.Tables.Add(this.tableOrders);
            ForeignKeyConstraint fkc;
            fkc = new ForeignKeyConstraint("CustomersOrders", new DataColumn[] {
                        this.tableCustomers.CustomerIDColumn}, new DataColumn[] {
                        this.tableOrders.CustomerIDColumn});
            this.tableOrders.Constraints.Add(fkc);
            fkc.AcceptRejectRule = AcceptRejectRule.None;
            fkc.DeleteRule = Rule.Cascade;
            fkc.UpdateRule = Rule.Cascade;
            this.relationCustomersOrders = new DataRelation("CustomersOrders", new DataColumn[] {
                        this.tableCustomers.CustomerIDColumn}, new DataColumn[] {
                        this.tableOrders.CustomerIDColumn}, false);
            this.Relations.Add(this.relationCustomersOrders);
        }
        
        private bool ShouldSerializeCustomers() {
            return false;
        }
        
        private bool ShouldSerializeOrders() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void CustomersRowChangeEventHandler(object sender, CustomersRowChangeEvent e);
        
        public delegate void OrdersRowChangeEventHandler(object sender, OrdersRowChangeEvent e);
        
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
            
            public OrdersRow[] GetOrdersRows() {
                return ((OrdersRow[])(this.GetChildRows(this.Table.ChildRelations["CustomersOrders"])));
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
            
            public OrdersRow AddOrdersRow(CustomersRow parentCustomersRowByCustomersOrders, int EmployeeID, System.DateTime OrderDate, System.DateTime RequiredDate, System.DateTime ShippedDate, int ShipVia, System.Decimal Freight, string ShipName, string ShipAddress, string ShipCity, string ShipRegion, string ShipPostalCode, string ShipCountry) {
                OrdersRow rowOrdersRow = ((OrdersRow)(this.NewRow()));
                rowOrdersRow.ItemArray = new object[] {
                        null,
                        parentCustomersRowByCustomersOrders[0],
                        EmployeeID,
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
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
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
            
            public CustomersRow CustomersRow {
                get {
                    return ((CustomersRow)(this.GetParentRow(this.Table.ParentRelations["CustomersOrders"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["CustomersOrders"]);
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
    }
}
