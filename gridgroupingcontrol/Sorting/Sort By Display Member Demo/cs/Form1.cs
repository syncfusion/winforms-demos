#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;
using System.Text.RegularExpressions;

namespace SortByDisplayMember
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private Panel panel1;
        private PropertyGrid propertyGrid1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        #endregion

        #region "Constructor"

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.GridSettings();
            this.SampleCustomization();

        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
			this.gridGroupingControl1.TableControl.DpiAware = true;
            
            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);;
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);;
            this.gridGroupingControl1.TableModel.ColWidths.ResizeToFit(GridRangeInfo.Table());

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region "Sample Customizations"

        /// <summary>
        /// Grouping sample Customizations are done here.
        /// </summary>
        private void SampleCustomization()
        {
            //set up the main table
            DataTable dt = GetMainDataTable();
            DataSet ds = new DataSet("Main");
            ds.Tables.Add(dt);

            this.gridGroupingControl1.DataSource = ds;
            this.gridGroupingControl1.DataMember = dt.TableName;

            //remember the location of lookupcol so it can be swapped out later
            GridTableDescriptor td = this.gridGroupingControl1.TableDescriptor;
            td.VisibleColumns.LoadDefault();
            int lookUpIndex = td.VisibleColumns.IndexOf("Customer");

            //get the lookup table
            DataTable lookUpDataTable = this.GetForeignTable();

            DataSet ds2 = new DataSet("LookUp");
            ds2.Tables.Add(lookUpDataTable);

            //add it to the grouping engine
            this.gridGroupingControl1.Engine.SourceListSet.Add(lookUpDataTable.TableName, lookUpDataTable.DefaultView);

            //set up relation descriptor that defines mapping between main table and foreign table
            GridRelationDescriptor rd = new GridRelationDescriptor();
            rd.Name = "CustomerColDisplay"; //just some unique name
            rd.RelationKind = RelationKind.ForeignKeyReference; //foreign key look up
            rd.ChildTableName = lookUpDataTable.TableName;  // SourceListSet name for lookup

            //get foreign key for col "CustomerID" in foreign table
            rd.RelationKeys.Add("Customer", "CustomerID"); //col in main table,  foreign key col

            //Set any optional properties on the relation
            // dropdown only shows CustomerName
            rd.ChildTableDescriptor.VisibleColumns.Add("CustomerName"); //display column
            rd.ChildTableDescriptor.SortedColumns.Add("CustomerName"); //sort it for dropdown display
            rd.ChildTableDescriptor.AllowEdit = false; //no editing of foreign table
            rd.ChildTableDescriptor.AllowNew = false;  //no new items added to foreign table
            rd.ChildTableDescriptor.Appearance.AlternateRecordFieldCell.BackColor = Color.FromArgb(0xff, 0xbf, 0x34);

            //add relation descriptor to main tabledescriptor
            td.Relations.Add(rd);

            //Add the relation column to main TableDescriptor's Columns collection.
            this.gridGroupingControl1.TableDescriptor.Columns.Add("Customer");
            
            //Replace maintable.LookUpCol with foreigntable.DisplayCol
            string foreignPrefix = rd.Name + "_";

            //get the hashed name of foreign col
            string foreignDisplayColInMainTable = foreignPrefix + "CustomerName";
            td.VisibleColumns.Insert(lookUpIndex, foreignDisplayColInMainTable);

            //set its headertext to something other than default hashedname
            td.Columns[foreignDisplayColInMainTable].HeaderText = "Customer";
            td.Columns[foreignDisplayColInMainTable].Appearance.AnyCell.BackColor = Color.FromArgb(218, 229, 245);
            foreach (GridColumnDescriptor col in this.gridGroupingControl1.TableDescriptor.Columns)
            {
                int index = (new Regex(@"\p{Lu}")).Match(col.MappingName.Substring(1)).Index;
                if (index > 0)
                    col.HeaderText = col.MappingName.Substring(0, index + 1) + " " + col.MappingName.Substring(index + 1);
            }
        }

        #endregion

        #region "Designer Stuffs"

        #region Dispose
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.Color.White;
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(12, 6);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(480, 396);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.TableDescriptor.AllowNew = false;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = true;
            this.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader";
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Silver);
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.VersionInfo = "3.201.1.0";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(497, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 370);
            this.panel1.TabIndex = 20;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(504, 6);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            this.propertyGrid1.Size = new System.Drawing.Size(203, 396);
            this.propertyGrid1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.gridGroupingControl1);
            this.MinimumSize = new System.Drawing.Size(530, 376);
            this.Name = "Form1";
            this.Text = "Sort By Display Member ";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }

        #endregion

        #region datatables

        /// <summary>
        /// Return Data table to set the datasource for Grid
        /// </summary>
        private DataTable GetMainDataTable()
        {
            DataTable dt = new DataTable("MainTable");

            dt.Columns.Add(new DataColumn("OrderID", typeof(int)));
            dt.Columns.Add(new DataColumn("CompanyName", typeof(string)));
            dt.Columns.Add(new DataColumn("ShipName", typeof(string)));
            dt.Columns.Add(new DataColumn("Customer", typeof(string)));

            dt.Rows.Add(new object[] { 1020, "Antonio Moreno Taquer�a", "Vins et alcools Chevalier", 100 });
            dt.Rows.Add(new object[] { 1021, "Berglunds snabbk�p", "Toms Spezialit�ten", 101 });
            dt.Rows.Add(new object[] { 1022, "Around the Horn", "Hanari Carnes", 102 });
            dt.Rows.Add(new object[] { 1023, "Blauer See Delikatessen", "Victuailles en stock", 103 });
            dt.Rows.Add(new object[] { 1024, "Drachenblut Delikatessen", "Supr�mes d�lices", 104 });
            dt.Rows.Add(new object[] { 1025, "Consolidated Holdings", "Wellington Importadora", 105 });
            dt.Rows.Add(new object[] { 1026, "Folies gourmandes", "Ottilies K�seladen:", 106 });
            dt.Rows.Add(new object[] { 1027, "Ernst Handel", "White Clover Markets", 107 });
            dt.Rows.Add(new object[] { 1028, "Bon app'", "White Clover Markets", 108 });
            dt.Rows.Add(new object[] { 1029, "B's Beverages", "Buchanan", 109 });
            dt.Rows.Add(new object[] { 1030, "Folk och f� HB", "Suyama", 110 });
            dt.Rows.Add(new object[] { 1031, "Folies gourmandes", "Peacock", 111 });
            dt.Rows.Add(new object[] { 1032, "Eastern Connection", "Leverling", 112 });
            dt.Rows.Add(new object[] { 1033, "Let's Stop N Shop", "Dodsworth", 113 });
            dt.Rows.Add(new object[] { 1034, "QUICK-Stop", "Davolio", 114 });
            dt.Rows.Add(new object[] { 1035, "Toms Spezialit�ten", "Callahan", 115 });
            dt.Rows.Add(new object[] { 1036, "Wilman Kala", "Peacock", 116 });
            dt.Rows.Add(new object[] { 1037, "Wartian Herkku", "Leverling", 117 });

            dt.Rows.Add(new object[] { 1038, "Blauer See Delikatessen", "Victuailles en stock", 103 });
            dt.Rows.Add(new object[] { 1039, "Drachenblut Delikatessen", "Supr�mes d�lices", 104 });
            dt.Rows.Add(new object[] { 1040, "Consolidated Holdings", "Wellington Importadora", 105 });
            dt.Rows.Add(new object[] { 1041, "Folies gourmandes", "Ottilies K�seladen:", 106 });
            dt.Rows.Add(new object[] { 1042, "Ernst Handel", "White Clover Markets", 107 });
            dt.Rows.Add(new object[] { 1043, "Bon app'", "White Clover Markets", 108 });
            dt.Rows.Add(new object[] { 1044, "B's Beverages", "Buchanan", 109 });
            dt.Rows.Add(new object[] { 1045, "Folk och f� HB", "Suyama", 110 });
            dt.Rows.Add(new object[] { 1046, "Folies gourmandes", "Peacock", 111 });
            dt.Rows.Add(new object[] { 1047, "Eastern Connection", "Leverling", 112 });
            dt.Rows.Add(new object[] { 1048, "Let's Stop N Shop", "Dodsworth", 113 });
            dt.Rows.Add(new object[] { 1049, "QUICK-Stop", "Davolio", 114 });
            dt.Rows.Add(new object[] { 1050, "Toms Spezialit�ten", "Callahan", 115 });
            dt.Rows.Add(new object[] { 1051, "Wilman Kala", "Peacock", 116 });
            dt.Rows.Add(new object[] { 1052, "Wartian Herkku", "Leverling", 117 });

            return dt;
        }

        /// <summary>
        /// Return nested Data table to set the datasource for Grid
        /// </summary>
        private DataTable GetForeignTable()
        {
            DataTable dt = new DataTable("ForeignTable");

            dt.Columns.Add(new DataColumn("CustomerID", typeof(int)));
            dt.Columns.Add(new DataColumn("CustomerName", typeof(string)));

            dt.Rows.Add(new object[] { 100, "Fr�d�rique Citeaux" });
            dt.Rows.Add(new object[] { 101, "Laurence Lebihan" });
            dt.Rows.Add(new object[] { 102, "Christina Berglund" });
            dt.Rows.Add(new object[] { 103, "Victoria Ashworth" });
            dt.Rows.Add(new object[] { 104, "Elizabeth Brown" });
            dt.Rows.Add(new object[] { 105, "Eduardo Saavedra" });
            dt.Rows.Add(new object[] { 106, "Janine Labrune" });
            dt.Rows.Add(new object[] { 107, "Catherine Dewey" });
            dt.Rows.Add(new object[] { 108, "Helvetius Nagy" });
            dt.Rows.Add(new object[] { 109, "Palle Ibsen" });
            dt.Rows.Add(new object[] { 110, "Rita M�ller" });
            dt.Rows.Add(new object[] { 111, "Anabela Domingues" });
            dt.Rows.Add(new object[] { 112, "Zbyszek Piestrzeniewicz" });
            dt.Rows.Add(new object[] { 113, "Matti Karttunen" });
            dt.Rows.Add(new object[] { 114, "Pirkko Koskitalo" });
            dt.Rows.Add(new object[] { 115, "Karl Jablonski" });
            dt.Rows.Add(new object[] { 116, "Anne Granger" });
            dt.Rows.Add(new object[] { 117, "Paula Parente" });

            dt.Rows.Add(new object[] { 107, "Catherine Dewey" });

            return dt;
        }
        #endregion
    }
}
