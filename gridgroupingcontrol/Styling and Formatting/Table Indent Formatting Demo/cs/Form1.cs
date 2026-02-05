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

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace NestedTables
{
	/// <summary>
	/// This sample demonstrates how to manually specify master-details relations 
	/// between three separate tables that primary keys and foreign key columns
	/// in common. 
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
			this.gridGroupingControl1.TableControl.DpiAware = true;

            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            this.MetroColor = System.Drawing.Color.Transparent;

            this.gridGroupingControl1.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(gridGroupingControl1_QueryCellStyleInfo);
            this.gridGroupingControl1.TableControlCellButtonClicked += new GridTableControlCellButtonClickedEventHandler(gridGroupingControl1_TableControlCellButtonClicked);
            this.gridGroupingControl1.TableControl.ClientSizeChanged += new EventHandler(TableControl_ClientSizeChanged);

            //this.gridGroupingControl1.TableDescriptor.Columns["child ID"].HeaderText = "Child ID";
            //this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Columns["GrandChildID"].HeaderText = "Grand Child ID";

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region "Sample Custmized"

        #region "Events"

        /// <summary>
        /// Load the form for Create a Nested Table
        /// </summary>
        private void Form1_Load(object sender, System.EventArgs e)
        {
            DataTable parentTable = GetParentTable();
            DataTable childTable = GetChildTable();
            DataTable grandChildTable = GetGrandChildTable();

            // Manually specify relations in grouping engine. The DataSet does not need to have any DataRelations.
            // This is the same approach that should be used if you want to set up relation ships
            // between independent IList.
            GridRelationDescriptor parentToChildRelationDescriptor = new GridRelationDescriptor();
            parentToChildRelationDescriptor.ChildTableName = "MyChildTable";    // same as SourceListSetEntry.Name for childTable (see below)
            parentToChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails;
            parentToChildRelationDescriptor.RelationKeys.Add("Parent ID", "ParentID");

            // Add relation to ParentTable 
            gridGroupingControl1.TableDescriptor.Relations.Add(parentToChildRelationDescriptor);

            GridRelationDescriptor childToGrandChildRelationDescriptor = new GridRelationDescriptor();
            childToGrandChildRelationDescriptor.ChildTableName = "MyGrandChildTable";  // same as SourceListSetEntry.Name for grandChhildTable (see below)
            childToGrandChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails;
            childToGrandChildRelationDescriptor.RelationKeys.Add("Child ID", "ChildID");

            // Add relation to ChildTable 
            parentToChildRelationDescriptor.ChildTableDescriptor.Relations.Add(childToGrandChildRelationDescriptor);


            // Register any DataTable/IList with SourceListSet, so that RelationDescriptor can resolve the name
            this.gridGroupingControl1.Engine.SourceListSet.Add("MyParentTable", parentTable);
            this.gridGroupingControl1.Engine.SourceListSet.Add("MyChildTable", childTable);
            this.gridGroupingControl1.Engine.SourceListSet.Add("MyGrandChildTable", grandChildTable);

            this.gridGroupingControl1.DataSource = parentTable;

            this.gridGroupingControl1.TableOptions.ShowRowHeader = false;
            this.gridGroupingControl1.GetTableDescriptor("MyChildTable").TableOptions.ShowTableIndent = false;
            this.gridGroupingControl1.Appearance.RecordPlusMinusCell.Themed = false;
            this.gridGroupingControl1.Appearance.RecordPlusMinusCell.BorderMargins = new Syncfusion.Windows.Forms.Grid.GridMarginsInfo(3, 3, 3, 3);

            this.gridGroupingControl1.Table.ExpandAllRecords();

        }

        /// <summary>
        /// Using the Cell Button for Expand an collapse in NestedTable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void gridGroupingControl1_TableControlCellButtonClicked(object sender, GridTableControlCellButtonClickedEventArgs e)
        {
            GridTableCellStyleInfo style = this.gridGroupingControl1.Table.GetTableCellStyle(e.Inner.RowIndex, e.Inner.ColIndex);
            if (style.TableCellIdentity == null)
                return;

            if (style.TableCellIdentity.TableCellType == GridTableCellType.RecordPlusMinusCell)
            {
                if (style.TableCellIdentity.DisplayElement.Kind == DisplayElementKind.NestedTable)
                {
                    // NestedTable
                    GridNestedTable nt = (GridNestedTable)style.TableCellIdentity.DisplayElement;

                    foreach (Element el in nt.ChildTable.Elements)
                    {
                        if (el.Kind == DisplayElementKind.Record)
                        {
                            if (style.TableCellIdentity.RowIndex == this.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(el))
                            {
                                Record r = Record.GetParentRecord(el);
                                bool shouldExpand = !r.IsExpanded;
                                this.gridGroupingControl1.Table.CurrentRecord = r;
                                r.IsExpanded = shouldExpand;
                                e.Inner.Cancel = true;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Set the '+' or '-' for ParentGrid
        /// </summary>
        void gridGroupingControl1_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {

            if (e.TableCellIdentity.TableCellType == GridTableCellType.NestedTableIndentCell)
            {
                if (e.TableCellIdentity.DisplayElement.Kind == DisplayElementKind.NestedTable)
                {
                    // NestedTable
                    GridNestedTable nt = (GridNestedTable)e.TableCellIdentity.DisplayElement;

                    foreach (Element el in nt.ChildTable.Elements)
                    {
                        if (el.Kind == DisplayElementKind.Record)
                        {

                            if (e.TableCellIdentity.RowIndex == this.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(el))
                            {
                                Record r = Record.GetParentRecord(el);
                                e.TableCellIdentity.TableCellType = GridTableCellType.RecordPlusMinusCell;
                                e.Style.Description = r.IsExpanded ? "-" : "+";
                                e.Style.BorderMargins = new Syncfusion.Windows.Forms.Grid.GridMarginsInfo(3, 3, 3, 3);
                                e.Style.Themed = false;
                                e.Style.Enabled = true;
                            }
                        }

                    }
                }
            }
        }

        /// <summary>
        /// Client Size changed event.
        /// </summary>        
        void TableControl_ClientSizeChanged(object sender, EventArgs e)
        {
            if (this.gridGroupingControl1.TableControl.ClientSize.Height == 0)
                this.gridGroupingControl1.AllowProportionalColumnSizing = false;
            else
                this.gridGroupingControl1.AllowProportionalColumnSizing = true;
        }
        #endregion

        #endregion

        #region "Designer Stuff"

        #region "Dispose"

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
            //this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            //| System.Windows.Forms.AnchorStyles.Left) 
            //| System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.Appearance.AlternateRecordFieldCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192))))));
            this.gridGroupingControl1.Appearance.AnyCell.TextColor = System.Drawing.Color.MidnightBlue;
            this.gridGroupingControl1.Appearance.AnyIndentCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            this.gridGroupingControl1.Appearance.RecordPlusMinusCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.gridGroupingControl1.BackColor = System.Drawing.Color.White;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(12, 12);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.Size = new System.Drawing.Size(775, 630);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.TableDescriptor.AllowNew = false;
            this.gridGroupingControl1.TableDescriptor.Appearance.AlternateRecordRowHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(231)))), ((int)(((byte)(247))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AlternateRecordRowHeaderCell.TextColor = System.Drawing.SystemColors.ControlText;
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
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            // 
            // panel1
            // 
            //this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            //| System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(792, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 615);
            this.panel1.TabIndex = 22;
            // 
            // propertyGrid1
            // 
            //this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            //| System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(799, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            this.propertyGrid1.Size = new System.Drawing.Size(203, 642);
            this.propertyGrid1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 654);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.gridGroupingControl1);
            this.Name = "Form1";
            this.Text = "Table Indent Formatting";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        #endregion
        
        #region Create a Table

        private int numberParentRows = 5;
        private int numberChildRows = 20;
        private int numberGrandChildRows = 50;
        private DataTable GetParentTable()
        {
            DataTable dt = new DataTable("ParentTable");

            dt.Columns.Add(new DataColumn("Parent ID")); //lower case p
            dt.Columns.Add(new DataColumn("Parent Name"));
            dt.Columns.Add(new DataColumn("Parent Address"));
            dt.Columns.Add(new DataColumn("Parent Description"));

            for (int i = 0; i < numberParentRows; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i;//.ToString();
                dr[1] = string.Format("parent Name{0}", i);
                dr[2] = string.Format("parent Address{0}", i);
                dr[3] = string.Format("parent Description{0}", i);
                dt.Rows.Add(dr);
            }

            return dt;
        }

        private DataTable GetChildTable()
        {
            DataTable dt = new DataTable("ChildTable");
            
            dt.Columns.Add(new DataColumn("Child ID")); //lower case c
            dt.Columns.Add(new DataColumn("Name"));
            dt.Columns.Add(new DataColumn("ParentID")); //upper case P
            dt.Columns.Add(new DataColumn("Child Address"));
            dt.Columns.Add(new DataColumn("Child Description"));

            for (int i = 0; i < numberChildRows; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i.ToString();
                dr[1] = string.Format("ChildName{0}", i);
                dr[2] = (i % numberParentRows).ToString();
                dr[3] = string.Format("ChildAdress{0}", i);
                dr[4] = string.Format("ChildDescription{0}", i);
                dt.Rows.Add(dr);
            }

            return dt;
        }

        private DataTable GetGrandChildTable()
        {
            DataTable dt = new DataTable("GrandChildTable");

            dt.Columns.Add(new DataColumn("Grand Child ID"));
            dt.Columns.Add(new DataColumn("Name"));
            dt.Columns.Add(new DataColumn("ChildID")); //upper case C
            dt.Columns.Add(new DataColumn("Address"));
            dt.Columns.Add(new DataColumn("Description"));

            for (int i = 0; i < numberGrandChildRows; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i.ToString();
                dr[1] = string.Format("GrandChildName{0}", i);
                dr[2] = (i % numberChildRows).ToString();
                dr[1] = string.Format("GrandChildAddress{0}", i);
                dr[1] = string.Format("GrandChildDescription{0}", i);
                dt.Rows.Add(dr);
            }

            return dt;
        }

        #endregion
    }
}
