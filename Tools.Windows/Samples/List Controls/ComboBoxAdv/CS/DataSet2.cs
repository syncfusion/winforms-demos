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

namespace ComboTest {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class DataSet2 : DataSet {
        
        private Sex_DescriptionDataTable tableSex_Description;
        
        public DataSet2() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected DataSet2(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Sex_Description"] != null)) {
                    this.Tables.Add(new Sex_DescriptionDataTable(ds.Tables["Sex_Description"]));
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
        public Sex_DescriptionDataTable Sex_Description {
            get {
                return this.tableSex_Description;
            }
        }
        
        public override DataSet Clone() {
            DataSet2 cln = ((DataSet2)(base.Clone()));
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
            if ((ds.Tables["Sex_Description"] != null)) {
                this.Tables.Add(new Sex_DescriptionDataTable(ds.Tables["Sex_Description"]));
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
            this.tableSex_Description = ((Sex_DescriptionDataTable)(this.Tables["Sex_Description"]));
            if ((this.tableSex_Description != null)) {
                this.tableSex_Description.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "DataSet2";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/DataSet2.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableSex_Description = new Sex_DescriptionDataTable();
            this.Tables.Add(this.tableSex_Description);
        }
        
        private bool ShouldSerializeSex_Description() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void Sex_DescriptionRowChangeEventHandler(object sender, Sex_DescriptionRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class Sex_DescriptionDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnDescription;
            
            private DataColumn columnID;
            
            internal Sex_DescriptionDataTable() : 
                    base("Sex_Description") {
                this.InitClass();
            }
            
            internal Sex_DescriptionDataTable(DataTable table) : 
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
            
            internal DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            public Sex_DescriptionRow this[int index] {
                get {
                    return ((Sex_DescriptionRow)(this.Rows[index]));
                }
            }
            
            public event Sex_DescriptionRowChangeEventHandler Sex_DescriptionRowChanged;
            
            public event Sex_DescriptionRowChangeEventHandler Sex_DescriptionRowChanging;
            
            public event Sex_DescriptionRowChangeEventHandler Sex_DescriptionRowDeleted;
            
            public event Sex_DescriptionRowChangeEventHandler Sex_DescriptionRowDeleting;
            
            public void AddSex_DescriptionRow(Sex_DescriptionRow row) {
                this.Rows.Add(row);
            }
            
            public Sex_DescriptionRow AddSex_DescriptionRow(string Description) {
                Sex_DescriptionRow rowSex_DescriptionRow = ((Sex_DescriptionRow)(this.NewRow()));
                rowSex_DescriptionRow.ItemArray = new object[] {
                        Description,
                        null};
                this.Rows.Add(rowSex_DescriptionRow);
                return rowSex_DescriptionRow;
            }
            
            public Sex_DescriptionRow FindByID(int ID) {
                return ((Sex_DescriptionRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                Sex_DescriptionDataTable cln = ((Sex_DescriptionDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new Sex_DescriptionDataTable();
            }
            
            internal void InitVars() {
                this.columnDescription = this.Columns["Description"];
                this.columnID = this.Columns["ID"];
            }
            
            private void InitClass() {
                this.columnDescription = new DataColumn("Description", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescription);
                this.columnID = new DataColumn("ID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnID);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
            }
            
            public Sex_DescriptionRow NewSex_DescriptionRow() {
                return ((Sex_DescriptionRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new Sex_DescriptionRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(Sex_DescriptionRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.Sex_DescriptionRowChanged != null)) {
                    this.Sex_DescriptionRowChanged(this, new Sex_DescriptionRowChangeEvent(((Sex_DescriptionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.Sex_DescriptionRowChanging != null)) {
                    this.Sex_DescriptionRowChanging(this, new Sex_DescriptionRowChangeEvent(((Sex_DescriptionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.Sex_DescriptionRowDeleted != null)) {
                    this.Sex_DescriptionRowDeleted(this, new Sex_DescriptionRowChangeEvent(((Sex_DescriptionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.Sex_DescriptionRowDeleting != null)) {
                    this.Sex_DescriptionRowDeleting(this, new Sex_DescriptionRowChangeEvent(((Sex_DescriptionRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveSex_DescriptionRow(Sex_DescriptionRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class Sex_DescriptionRow : DataRow {
            
            private Sex_DescriptionDataTable tableSex_Description;
            
            internal Sex_DescriptionRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableSex_Description = ((Sex_DescriptionDataTable)(this.Table));
            }
            
            public string Description {
                get {
                    try {
                        return ((string)(this[this.tableSex_Description.DescriptionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableSex_Description.DescriptionColumn] = value;
                }
            }
            
            public int ID {
                get {
                    return ((int)(this[this.tableSex_Description.IDColumn]));
                }
                set {
                    this[this.tableSex_Description.IDColumn] = value;
                }
            }
            
            public bool IsDescriptionNull() {
                return this.IsNull(this.tableSex_Description.DescriptionColumn);
            }
            
            public void SetDescriptionNull() {
                this[this.tableSex_Description.DescriptionColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class Sex_DescriptionRowChangeEvent : EventArgs {
            
            private Sex_DescriptionRow eventRow;
            
            private DataRowAction eventAction;
            
            public Sex_DescriptionRowChangeEvent(Sex_DescriptionRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public Sex_DescriptionRow Row {
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
