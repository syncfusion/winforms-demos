#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace GroupingEvents {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class Dataset1 : DataSet {
        
        private EmployeesDataTable tableEmployees;
        
        private OrdersDataTable tableOrders;
        
        private DataRelation relationEmployeesOrders;
        
        public Dataset1() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected Dataset1(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Employees"] != null)) {
                    this.Tables.Add(new EmployeesDataTable(ds.Tables["Employees"]));
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
        public EmployeesDataTable Employees {
            get {
                return this.tableEmployees;
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
            Dataset1 cln = ((Dataset1)(base.Clone()));
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
            this.tableEmployees = ((EmployeesDataTable)(this.Tables["Employees"]));
            if ((this.tableEmployees != null)) {
                this.tableEmployees.InitVars();
            }
            this.tableOrders = ((OrdersDataTable)(this.Tables["Orders"]));
            if ((this.tableOrders != null)) {
                this.tableOrders.InitVars();
            }
            this.relationEmployeesOrders = this.Relations["EmployeesOrders"];
        }
        
        private void InitClass() {
            this.DataSetName = "Dataset1";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/Dataset1.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableEmployees = new EmployeesDataTable();
            this.Tables.Add(this.tableEmployees);
            this.tableOrders = new OrdersDataTable();
            this.Tables.Add(this.tableOrders);
            ForeignKeyConstraint fkc;
            fkc = new ForeignKeyConstraint("EmployeesOrders", new DataColumn[] {
                        this.tableEmployees.EmployeeIDColumn}, new DataColumn[] {
                        this.tableOrders.EmployeeIDColumn});
            this.tableOrders.Constraints.Add(fkc);
            fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None;
            fkc.DeleteRule = System.Data.Rule.Cascade;
            fkc.UpdateRule = System.Data.Rule.Cascade;
            this.relationEmployeesOrders = new DataRelation("EmployeesOrders", new DataColumn[] {
                        this.tableEmployees.EmployeeIDColumn}, new DataColumn[] {
                        this.tableOrders.EmployeeIDColumn}, false);
            this.Relations.Add(this.relationEmployeesOrders);
        }
        
        private bool ShouldSerializeEmployees() {
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
        
        public delegate void EmployeesRowChangeEventHandler(object sender, EmployeesRowChangeEvent e);
        
        public delegate void OrdersRowChangeEventHandler(object sender, OrdersRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EmployeesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnEmployeeID;
            
            private DataColumn columnFirstName;
            
            private DataColumn columnLastName;
            
            private DataColumn columnTitle;
            
            private DataColumn columnAddress;
            
            private DataColumn columnCity;
            
            private DataColumn columnCountry;
            
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
            
            internal DataColumn FirstNameColumn {
                get {
                    return this.columnFirstName;
                }
            }
            
            internal DataColumn LastNameColumn {
                get {
                    return this.columnLastName;
                }
            }
            
            internal DataColumn TitleColumn {
                get {
                    return this.columnTitle;
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
            
            internal DataColumn CountryColumn {
                get {
                    return this.columnCountry;
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
            
            public EmployeesRow AddEmployeesRow(string FirstName, string LastName, string Title, string Address, string City, string Country) {
                EmployeesRow rowEmployeesRow = ((EmployeesRow)(this.NewRow()));
                rowEmployeesRow.ItemArray = new object[] {
                        null,
                        FirstName,
                        LastName,
                        Title,
                        Address,
                        City,
                        Country};
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
                this.columnFirstName = this.Columns["FirstName"];
                this.columnLastName = this.Columns["LastName"];
                this.columnTitle = this.Columns["Title"];
                this.columnAddress = this.Columns["Address"];
                this.columnCity = this.Columns["City"];
                this.columnCountry = this.Columns["Country"];
            }
            
            private void InitClass() {
                this.columnEmployeeID = new DataColumn("EmployeeID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnEmployeeID);
                this.columnFirstName = new DataColumn("FirstName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFirstName);
                this.columnLastName = new DataColumn("LastName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnLastName);
                this.columnTitle = new DataColumn("Title", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTitle);
                this.columnAddress = new DataColumn("Address", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAddress);
                this.columnCity = new DataColumn("City", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCity);
                this.columnCountry = new DataColumn("Country", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCountry);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnEmployeeID}, true));
                this.columnEmployeeID.AutoIncrement = true;
                this.columnEmployeeID.AllowDBNull = false;
                this.columnEmployeeID.Unique = true;
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
            
            public string FirstName {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.FirstNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.FirstNameColumn] = value;
                }
            }
            
            public string LastName {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.LastNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.LastNameColumn] = value;
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
            
            public bool IsFirstNameNull() {
                return this.IsNull(this.tableEmployees.FirstNameColumn);
            }
            
            public void SetFirstNameNull() {
                this[this.tableEmployees.FirstNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsLastNameNull() {
                return this.IsNull(this.tableEmployees.LastNameColumn);
            }
            
            public void SetLastNameNull() {
                this[this.tableEmployees.LastNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsTitleNull() {
                return this.IsNull(this.tableEmployees.TitleColumn);
            }
            
            public void SetTitleNull() {
                this[this.tableEmployees.TitleColumn] = System.Convert.DBNull;
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
            
            public bool IsCountryNull() {
                return this.IsNull(this.tableEmployees.CountryColumn);
            }
            
            public void SetCountryNull() {
                this[this.tableEmployees.CountryColumn] = System.Convert.DBNull;
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
        public class OrdersDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnCustomerID;
            
            private DataColumn columnEmployeeID;
            
            private DataColumn columnOrderDate;
            
            private DataColumn columnOrderID;
            
            private DataColumn columnShipAddress;
            
            private DataColumn columnShipName;
            
            private DataColumn columnShippedDate;
            
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
            
            internal DataColumn OrderIDColumn {
                get {
                    return this.columnOrderID;
                }
            }
            
            internal DataColumn ShipAddressColumn {
                get {
                    return this.columnShipAddress;
                }
            }
            
            internal DataColumn ShipNameColumn {
                get {
                    return this.columnShipName;
                }
            }
            
            internal DataColumn ShippedDateColumn {
                get {
                    return this.columnShippedDate;
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
            
            public OrdersRow AddOrdersRow(string CustomerID, EmployeesRow parentEmployeesRowByEmployeesOrders, System.DateTime OrderDate, string ShipAddress, string ShipName, System.DateTime ShippedDate) {
                OrdersRow rowOrdersRow = ((OrdersRow)(this.NewRow()));
                rowOrdersRow.ItemArray = new object[] {
                        CustomerID,
                        parentEmployeesRowByEmployeesOrders[0],
                        OrderDate,
                        null,
                        ShipAddress,
                        ShipName,
                        ShippedDate};
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
                this.columnCustomerID = this.Columns["CustomerID"];
                this.columnEmployeeID = this.Columns["EmployeeID"];
                this.columnOrderDate = this.Columns["OrderDate"];
                this.columnOrderID = this.Columns["OrderID"];
                this.columnShipAddress = this.Columns["ShipAddress"];
                this.columnShipName = this.Columns["ShipName"];
                this.columnShippedDate = this.Columns["ShippedDate"];
            }
            
            private void InitClass() {
                this.columnCustomerID = new DataColumn("CustomerID", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCustomerID);
                this.columnEmployeeID = new DataColumn("EmployeeID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnEmployeeID);
                this.columnOrderDate = new DataColumn("OrderDate", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOrderDate);
                this.columnOrderID = new DataColumn("OrderID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOrderID);
                this.columnShipAddress = new DataColumn("ShipAddress", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnShipAddress);
                this.columnShipName = new DataColumn("ShipName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnShipName);
                this.columnShippedDate = new DataColumn("ShippedDate", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnShippedDate);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnOrderID}, true));
                this.columnOrderID.AutoIncrement = true;
                this.columnOrderID.AllowDBNull = false;
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
            
            public int OrderID {
                get {
                    return ((int)(this[this.tableOrders.OrderIDColumn]));
                }
                set {
                    this[this.tableOrders.OrderIDColumn] = value;
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
            
            public bool IsShipAddressNull() {
                return this.IsNull(this.tableOrders.ShipAddressColumn);
            }
            
            public void SetShipAddressNull() {
                this[this.tableOrders.ShipAddressColumn] = System.Convert.DBNull;
            }
            
            public bool IsShipNameNull() {
                return this.IsNull(this.tableOrders.ShipNameColumn);
            }
            
            public void SetShipNameNull() {
                this[this.tableOrders.ShipNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsShippedDateNull() {
                return this.IsNull(this.tableOrders.ShippedDateColumn);
            }
            
            public void SetShippedDateNull() {
                this[this.tableOrders.ShippedDateColumn] = System.Convert.DBNull;
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
