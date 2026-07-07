#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

namespace CategoryView {
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
        }
        
        private bool ShouldSerializeCategories() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void CategoriesRowChangeEventHandler(object sender, CategoriesRowChangeEvent e);
        
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
    }
}
