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

namespace EmployeeView {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class DataSet1 : DataSet {
        
        private EmployeesDataTable tableEmployees;
        
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
                if ((ds.Tables["Employees"] != null)) {
                    this.Tables.Add(new EmployeesDataTable(ds.Tables["Employees"]));
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
            if ((ds.Tables["Employees"] != null)) {
                this.Tables.Add(new EmployeesDataTable(ds.Tables["Employees"]));
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
        }
        
        private void InitClass() {
            this.DataSetName = "DataSet1";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/DataSet1.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableEmployees = new EmployeesDataTable();
            this.Tables.Add(this.tableEmployees);
        }
        
        private bool ShouldSerializeEmployees() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void EmployeesRowChangeEventHandler(object sender, EmployeesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EmployeesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnAddress;
            
            private DataColumn columnBirthDate;
            
            private DataColumn columnCity;
            
            private DataColumn columnCountry;
            
            private DataColumn columnEmployeeID;
            
            private DataColumn columnExtension;
            
            private DataColumn columnFirstName;
            
            private DataColumn columnHireDate;
            
            private DataColumn columnHomePhone;
            
            private DataColumn columnLastName;
            
            private DataColumn columnNotes;
            
            private DataColumn columnPhoto;
            
            private DataColumn columnPostalCode;
            
            private DataColumn columnRegion;
            
            private DataColumn columnReportsTo;
            
            private DataColumn columnTitle;
            
            private DataColumn columnTitleOfCourtesy;
            
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
            
            internal DataColumn AddressColumn {
                get {
                    return this.columnAddress;
                }
            }
            
            internal DataColumn BirthDateColumn {
                get {
                    return this.columnBirthDate;
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
            
            internal DataColumn EmployeeIDColumn {
                get {
                    return this.columnEmployeeID;
                }
            }
            
            internal DataColumn ExtensionColumn {
                get {
                    return this.columnExtension;
                }
            }
            
            internal DataColumn FirstNameColumn {
                get {
                    return this.columnFirstName;
                }
            }
            
            internal DataColumn HireDateColumn {
                get {
                    return this.columnHireDate;
                }
            }
            
            internal DataColumn HomePhoneColumn {
                get {
                    return this.columnHomePhone;
                }
            }
            
            internal DataColumn LastNameColumn {
                get {
                    return this.columnLastName;
                }
            }
            
            internal DataColumn NotesColumn {
                get {
                    return this.columnNotes;
                }
            }
            
            internal DataColumn PhotoColumn {
                get {
                    return this.columnPhoto;
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
            
            internal DataColumn ReportsToColumn {
                get {
                    return this.columnReportsTo;
                }
            }
            
            internal DataColumn TitleColumn {
                get {
                    return this.columnTitle;
                }
            }
            
            internal DataColumn TitleOfCourtesyColumn {
                get {
                    return this.columnTitleOfCourtesy;
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
            
            public EmployeesRow AddEmployeesRow(
                        string Address, 
                        System.DateTime BirthDate, 
                        string City, 
                        string Country, 
                        string Extension, 
                        string FirstName, 
                        System.DateTime HireDate, 
                        string HomePhone, 
                        string LastName, 
                        string Notes, 
                        System.Byte[] Photo, 
                        string PostalCode, 
                        string Region, 
                        int ReportsTo, 
                        string Title, 
                        string TitleOfCourtesy) {
                EmployeesRow rowEmployeesRow = ((EmployeesRow)(this.NewRow()));
                rowEmployeesRow.ItemArray = new object[] {
                        Address,
                        BirthDate,
                        City,
                        Country,
                        null,
                        Extension,
                        FirstName,
                        HireDate,
                        HomePhone,
                        LastName,
                        Notes,
                        Photo,
                        PostalCode,
                        Region,
                        ReportsTo,
                        Title,
                        TitleOfCourtesy};
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
                this.columnAddress = this.Columns["Address"];
                this.columnBirthDate = this.Columns["BirthDate"];
                this.columnCity = this.Columns["City"];
                this.columnCountry = this.Columns["Country"];
                this.columnEmployeeID = this.Columns["EmployeeID"];
                this.columnExtension = this.Columns["Extension"];
                this.columnFirstName = this.Columns["FirstName"];
                this.columnHireDate = this.Columns["HireDate"];
                this.columnHomePhone = this.Columns["HomePhone"];
                this.columnLastName = this.Columns["LastName"];
                this.columnNotes = this.Columns["Notes"];
                this.columnPhoto = this.Columns["Photo"];
                this.columnPostalCode = this.Columns["PostalCode"];
                this.columnRegion = this.Columns["Region"];
                this.columnReportsTo = this.Columns["ReportsTo"];
                this.columnTitle = this.Columns["Title"];
                this.columnTitleOfCourtesy = this.Columns["TitleOfCourtesy"];
            }
            
            private void InitClass() {
                this.columnAddress = new DataColumn("Address", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAddress);
                this.columnBirthDate = new DataColumn("BirthDate", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnBirthDate);
                this.columnCity = new DataColumn("City", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCity);
                this.columnCountry = new DataColumn("Country", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCountry);
                this.columnEmployeeID = new DataColumn("EmployeeID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnEmployeeID);
                this.columnExtension = new DataColumn("Extension", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnExtension);
                this.columnFirstName = new DataColumn("FirstName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFirstName);
                this.columnHireDate = new DataColumn("HireDate", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnHireDate);
                this.columnHomePhone = new DataColumn("HomePhone", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnHomePhone);
                this.columnLastName = new DataColumn("LastName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnLastName);
                this.columnNotes = new DataColumn("Notes", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnNotes);
                this.columnPhoto = new DataColumn("Photo", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPhoto);
                this.columnPostalCode = new DataColumn("PostalCode", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPostalCode);
                this.columnRegion = new DataColumn("Region", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRegion);
                this.columnReportsTo = new DataColumn("ReportsTo", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnReportsTo);
                this.columnTitle = new DataColumn("Title", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTitle);
                this.columnTitleOfCourtesy = new DataColumn("TitleOfCourtesy", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTitleOfCourtesy);
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
            
            public System.DateTime BirthDate {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableEmployees.BirthDateColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.BirthDateColumn] = value;
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
            
            public int EmployeeID {
                get {
                    return ((int)(this[this.tableEmployees.EmployeeIDColumn]));
                }
                set {
                    this[this.tableEmployees.EmployeeIDColumn] = value;
                }
            }
            
            public string Extension {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.ExtensionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.ExtensionColumn] = value;
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
            
            public System.DateTime HireDate {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableEmployees.HireDateColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.HireDateColumn] = value;
                }
            }
            
            public string HomePhone {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.HomePhoneColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.HomePhoneColumn] = value;
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
            
            public string Notes {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.NotesColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.NotesColumn] = value;
                }
            }
            
            public System.Byte[] Photo {
                get {
                    try {
                        return ((System.Byte[])(this[this.tableEmployees.PhotoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.PhotoColumn] = value;
                }
            }
            
            public string PostalCode {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.PostalCodeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.PostalCodeColumn] = value;
                }
            }
            
            public string Region {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.RegionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.RegionColumn] = value;
                }
            }
            
            public int ReportsTo {
                get {
                    try {
                        return ((int)(this[this.tableEmployees.ReportsToColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.ReportsToColumn] = value;
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
            
            public string TitleOfCourtesy {
                get {
                    try {
                        return ((string)(this[this.tableEmployees.TitleOfCourtesyColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployees.TitleOfCourtesyColumn] = value;
                }
            }
            
            public bool IsAddressNull() {
                return this.IsNull(this.tableEmployees.AddressColumn);
            }
            
            public void SetAddressNull() {
                this[this.tableEmployees.AddressColumn] = System.Convert.DBNull;
            }
            
            public bool IsBirthDateNull() {
                return this.IsNull(this.tableEmployees.BirthDateColumn);
            }
            
            public void SetBirthDateNull() {
                this[this.tableEmployees.BirthDateColumn] = System.Convert.DBNull;
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
            
            public bool IsExtensionNull() {
                return this.IsNull(this.tableEmployees.ExtensionColumn);
            }
            
            public void SetExtensionNull() {
                this[this.tableEmployees.ExtensionColumn] = System.Convert.DBNull;
            }
            
            public bool IsFirstNameNull() {
                return this.IsNull(this.tableEmployees.FirstNameColumn);
            }
            
            public void SetFirstNameNull() {
                this[this.tableEmployees.FirstNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsHireDateNull() {
                return this.IsNull(this.tableEmployees.HireDateColumn);
            }
            
            public void SetHireDateNull() {
                this[this.tableEmployees.HireDateColumn] = System.Convert.DBNull;
            }
            
            public bool IsHomePhoneNull() {
                return this.IsNull(this.tableEmployees.HomePhoneColumn);
            }
            
            public void SetHomePhoneNull() {
                this[this.tableEmployees.HomePhoneColumn] = System.Convert.DBNull;
            }
            
            public bool IsLastNameNull() {
                return this.IsNull(this.tableEmployees.LastNameColumn);
            }
            
            public void SetLastNameNull() {
                this[this.tableEmployees.LastNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsNotesNull() {
                return this.IsNull(this.tableEmployees.NotesColumn);
            }
            
            public void SetNotesNull() {
                this[this.tableEmployees.NotesColumn] = System.Convert.DBNull;
            }
            
            public bool IsPhotoNull() {
                return this.IsNull(this.tableEmployees.PhotoColumn);
            }
            
            public void SetPhotoNull() {
                this[this.tableEmployees.PhotoColumn] = System.Convert.DBNull;
            }
            
            public bool IsPostalCodeNull() {
                return this.IsNull(this.tableEmployees.PostalCodeColumn);
            }
            
            public void SetPostalCodeNull() {
                this[this.tableEmployees.PostalCodeColumn] = System.Convert.DBNull;
            }
            
            public bool IsRegionNull() {
                return this.IsNull(this.tableEmployees.RegionColumn);
            }
            
            public void SetRegionNull() {
                this[this.tableEmployees.RegionColumn] = System.Convert.DBNull;
            }
            
            public bool IsReportsToNull() {
                return this.IsNull(this.tableEmployees.ReportsToColumn);
            }
            
            public void SetReportsToNull() {
                this[this.tableEmployees.ReportsToColumn] = System.Convert.DBNull;
            }
            
            public bool IsTitleNull() {
                return this.IsNull(this.tableEmployees.TitleColumn);
            }
            
            public void SetTitleNull() {
                this[this.tableEmployees.TitleColumn] = System.Convert.DBNull;
            }
            
            public bool IsTitleOfCourtesyNull() {
                return this.IsNull(this.tableEmployees.TitleOfCourtesyColumn);
            }
            
            public void SetTitleOfCourtesyNull() {
                this[this.tableEmployees.TitleOfCourtesyColumn] = System.Convert.DBNull;
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
    }
}
