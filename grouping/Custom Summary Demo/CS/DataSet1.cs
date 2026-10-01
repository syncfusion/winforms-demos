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

namespace CustomSummary {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class DataSet1 : DataSet {
        
        private Order_DetailsDataTable tableOrder_Details;
        
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
                if ((ds.Tables["Order Details"] != null)) {
                    this.Tables.Add(new Order_DetailsDataTable(ds.Tables["Order Details"]));
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
        public Order_DetailsDataTable Order_Details {
            get {
                return this.tableOrder_Details;
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
            if ((ds.Tables["Order Details"] != null)) {
                this.Tables.Add(new Order_DetailsDataTable(ds.Tables["Order Details"]));
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
            this.tableOrder_Details = ((Order_DetailsDataTable)(this.Tables["Order Details"]));
            if ((this.tableOrder_Details != null)) {
                this.tableOrder_Details.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "DataSet1";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/DataSet1.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableOrder_Details = new Order_DetailsDataTable();
            this.Tables.Add(this.tableOrder_Details);
        }
        
        private bool ShouldSerializeOrder_Details() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void Order_DetailsRowChangeEventHandler(object sender, Order_DetailsRowChangeEvent e);
        
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
            
            public Order_DetailsRow AddOrder_DetailsRow(int OrderID, int ProductID, System.Decimal UnitPrice, short Quantity, System.Single Discount) {
                Order_DetailsRow rowOrder_DetailsRow = ((Order_DetailsRow)(this.NewRow()));
                rowOrder_DetailsRow.ItemArray = new object[] {
                        OrderID,
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
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
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
    }
}
