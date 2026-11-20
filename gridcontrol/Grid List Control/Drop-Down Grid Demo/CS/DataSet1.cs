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

namespace ComboBoxBaseGridDemo {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class DataSet1 : DataSet {
        
        private CategoriesDataTable tableCategories;
        
        private ProductsDataTable tableProducts;
        
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
                if ((ds.Tables["Categories"] != null)) {
                    this.Tables.Add(new CategoriesDataTable(ds.Tables["Categories"]));
                }
                if ((ds.Tables["Products"] != null)) {
                    this.Tables.Add(new ProductsDataTable(ds.Tables["Products"]));
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
        public CategoriesDataTable Categories {
            get {
                return this.tableCategories;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public ProductsDataTable Products {
            get {
                return this.tableProducts;
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
            if ((ds.Tables["Categories"] != null)) {
                this.Tables.Add(new CategoriesDataTable(ds.Tables["Categories"]));
            }
            if ((ds.Tables["Products"] != null)) {
                this.Tables.Add(new ProductsDataTable(ds.Tables["Products"]));
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
            this.tableCategories = ((CategoriesDataTable)(this.Tables["Categories"]));
            if ((this.tableCategories != null)) {
                this.tableCategories.InitVars();
            }
            this.tableProducts = ((ProductsDataTable)(this.Tables["Products"]));
            if ((this.tableProducts != null)) {
                this.tableProducts.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "DataSet1";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/DataSet1.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableCategories = new CategoriesDataTable();
            this.Tables.Add(this.tableCategories);
            this.tableProducts = new ProductsDataTable();
            this.Tables.Add(this.tableProducts);
        }
        
        private bool ShouldSerializeCategories() {
            return false;
        }
        
        private bool ShouldSerializeProducts() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void CategoriesRowChangeEventHandler(object sender, CategoriesRowChangeEvent e);
        
        public delegate void ProductsRowChangeEventHandler(object sender, ProductsRowChangeEvent e);
        
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
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
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
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
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
    }
}
