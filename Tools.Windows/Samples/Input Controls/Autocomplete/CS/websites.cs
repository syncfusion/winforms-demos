#region Copyright Syncfusion Inc. 2001 - 2013
//
//  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
//
#endregion

namespace AutoCompleteDemo {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class Websites : DataSet {
        
        private WebsiteDataTable tableWebsite;
        
        public Websites() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected Websites(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Website"] != null)) {
                    this.Tables.Add(new WebsiteDataTable(ds.Tables["Website"]));
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
        public WebsiteDataTable Website {
            get {
                return this.tableWebsite;
            }
        }
        
        public override DataSet Clone() {
            Websites cln = ((Websites)(base.Clone()));
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
            if ((ds.Tables["Website"] != null)) {
                this.Tables.Add(new WebsiteDataTable(ds.Tables["Website"]));
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
            this.tableWebsite = ((WebsiteDataTable)(this.Tables["Website"]));
            if ((this.tableWebsite != null)) {
                this.tableWebsite.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "Websites";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/websites.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = false;
            this.tableWebsite = new WebsiteDataTable();
            this.Tables.Add(this.tableWebsite);
        }
        
        private bool ShouldSerializeWebsite() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void WebsiteRowChangeEventHandler(object sender, WebsiteRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class WebsiteDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnURL;
            
            private DataColumn columnName;
            
            private DataColumn columnImageIndex;
            
            internal WebsiteDataTable() : 
                    base("Website") {
                this.InitClass();
            }
            
            internal WebsiteDataTable(DataTable table) : 
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
            
            internal DataColumn URLColumn {
                get {
                    return this.columnURL;
                }
            }
            
            internal DataColumn NameColumn {
                get {
                    return this.columnName;
                }
            }
            
            internal DataColumn ImageIndexColumn {
                get {
                    return this.columnImageIndex;
                }
            }
            
            public WebsiteRow this[int index] {
                get {
                    return ((WebsiteRow)(this.Rows[index]));
                }
            }
            
            public event WebsiteRowChangeEventHandler WebsiteRowChanged;
            
            public event WebsiteRowChangeEventHandler WebsiteRowChanging;
            
            public event WebsiteRowChangeEventHandler WebsiteRowDeleted;
            
            public event WebsiteRowChangeEventHandler WebsiteRowDeleting;
            
            public void AddWebsiteRow(WebsiteRow row) {
                this.Rows.Add(row);
            }
            
            public WebsiteRow AddWebsiteRow(string URL, string Name, string ImageIndex) {
                WebsiteRow rowWebsiteRow = ((WebsiteRow)(this.NewRow()));
                rowWebsiteRow.ItemArray = new object[] {
                        URL,
                        Name,
                        ImageIndex};
                this.Rows.Add(rowWebsiteRow);
                return rowWebsiteRow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                WebsiteDataTable cln = ((WebsiteDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new WebsiteDataTable();
            }
            
            internal void InitVars() {
                this.columnURL = this.Columns["URL"];
                this.columnName = this.Columns["Name"];
                this.columnImageIndex = this.Columns["ImageIndex"];
            }
            
            private void InitClass() {
                this.columnURL = new DataColumn("URL", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnURL);
                this.columnName = new DataColumn("Name", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnName);
                this.columnImageIndex = new DataColumn("ImageIndex", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnImageIndex);
            }
            
            public WebsiteRow NewWebsiteRow() {
                return ((WebsiteRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new WebsiteRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(WebsiteRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.WebsiteRowChanged != null)) {
                    this.WebsiteRowChanged(this, new WebsiteRowChangeEvent(((WebsiteRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.WebsiteRowChanging != null)) {
                    this.WebsiteRowChanging(this, new WebsiteRowChangeEvent(((WebsiteRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.WebsiteRowDeleted != null)) {
                    this.WebsiteRowDeleted(this, new WebsiteRowChangeEvent(((WebsiteRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.WebsiteRowDeleting != null)) {
                    this.WebsiteRowDeleting(this, new WebsiteRowChangeEvent(((WebsiteRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveWebsiteRow(WebsiteRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class WebsiteRow : DataRow {
            
            private WebsiteDataTable tableWebsite;
            
            internal WebsiteRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableWebsite = ((WebsiteDataTable)(this.Table));
            }
            
            public string URL {
                get {
                    try {
                        return ((string)(this[this.tableWebsite.URLColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableWebsite.URLColumn] = value;
                }
            }
            
            public string Name {
                get {
                    try {
                        return ((string)(this[this.tableWebsite.NameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableWebsite.NameColumn] = value;
                }
            }
            
            public string ImageIndex {
                get {
                    try {
                        return ((string)(this[this.tableWebsite.ImageIndexColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableWebsite.ImageIndexColumn] = value;
                }
            }
            
            public bool IsURLNull() {
                return this.IsNull(this.tableWebsite.URLColumn);
            }
            
            public void SetURLNull() {
                this[this.tableWebsite.URLColumn] = System.Convert.DBNull;
            }
            
            public bool IsNameNull() {
                return this.IsNull(this.tableWebsite.NameColumn);
            }
            
            public void SetNameNull() {
                this[this.tableWebsite.NameColumn] = System.Convert.DBNull;
            }
            
            public bool IsImageIndexNull() {
                return this.IsNull(this.tableWebsite.ImageIndexColumn);
            }
            
            public void SetImageIndexNull() {
                this[this.tableWebsite.ImageIndexColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class WebsiteRowChangeEvent : EventArgs {
            
            private WebsiteRow eventRow;
            
            private DataRowAction eventAction;
            
            public WebsiteRowChangeEvent(WebsiteRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public WebsiteRow Row {
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
