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

namespace HierarchyView {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class ShippersDataSet : DataSet {
        
        private ShippersDataTable tableShippers;
        
        public ShippersDataSet() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected ShippersDataSet(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Shippers"] != null)) {
                    this.Tables.Add(new ShippersDataTable(ds.Tables["Shippers"]));
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
        public ShippersDataTable Shippers {
            get {
                return this.tableShippers;
            }
        }
        
        public override DataSet Clone() {
            ShippersDataSet cln = ((ShippersDataSet)(base.Clone()));
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
            if ((ds.Tables["Shippers"] != null)) {
                this.Tables.Add(new ShippersDataTable(ds.Tables["Shippers"]));
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
            this.tableShippers = ((ShippersDataTable)(this.Tables["Shippers"]));
            if ((this.tableShippers != null)) {
                this.tableShippers.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "ShippersDataSet";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/ShippersDataSet.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableShippers = new ShippersDataTable();
            this.Tables.Add(this.tableShippers);
        }
        
        private bool ShouldSerializeShippers() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void ShippersRowChangeEventHandler(object sender, ShippersRowChangeEvent e);
        
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
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
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
    }
}
