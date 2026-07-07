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
using System.IO;
using System.Drawing.Imaging;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS ;
using System.Collections.Generic;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace PrintGroupingGrid
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API definition"

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        IContainer components = null;
        private ButtonAdv buttonAdv1;
        private ButtonAdv buttonAdv2;
        private GroupBox groupBox1;
        private ButtonAdv button1;
        private Panel panel;

        #endregion

        #region "Constructor"

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();           
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            this.InitializeDataSet();
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
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region Sample Customization
      
        #region "Events"

        private void button1_Click(object sender, EventArgs e)
        {
            GroupingGridWordConverter converter = new GroupingGridWordConverter(true, true);
            converter.DrawHeader += new GridWordConverterBase.DrawDocHeaderFooterEventHandler(converter_DrawHeader);
            converter.DrawFooter += new GridWordConverterBase.DrawDocHeaderFooterEventHandler(converter_DrawFooter);
            converter.GroupingGridToWord("Sample.doc", gridGroupingControl1);
            System.Diagnostics.Process.Start("Sample.doc");
        }

        void converter_DrawFooter(object sender, DocHeaderFooterEventArgs e)
        {
            IWTextRange txt = e.Footer.AddParagraph().AppendText("\t\t\tCopyright Syncfusion Inc. 2001 - 2008");
            txt.CharacterFormat.Font = new Font("verdana", 12f, FontStyle.Bold);
        }

        void converter_DrawHeader(object sender, DocHeaderFooterEventArgs e)
        {
            IWTextRange txt = e.Header.AddParagraph().AppendText("\t\t\t\tSyncfusion Inc.\n");
            txt.CharacterFormat.Font = new Font("verdana", 12f, FontStyle.Bold);
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.gridGroupingControl1.Table.ExpandAllRecords();
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.gridGroupingControl1.Table.CollapseAllRecords();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gridGroupingControl1.Table.ExpandAllRecords();
        }

        #endregion

        #endregion

        #region "DesignerStuff" 

        #region "Initialize Data"

        void InitializeDataSet()
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
            parentToChildRelationDescriptor.RelationKeys.Add("parentID", "ParentID");

            // Add relation to ParentTable 
            gridGroupingControl1.TableDescriptor.Relations.Add(parentToChildRelationDescriptor);

            GridRelationDescriptor childToGrandChildRelationDescriptor = new GridRelationDescriptor();
            childToGrandChildRelationDescriptor.ChildTableName = "MyGrandChildTable";  // same as SourceListSetEntry.Name for grandChhildTable (see below)
            childToGrandChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails;
            childToGrandChildRelationDescriptor.RelationKeys.Add("childID", "ChildID");

            // Add relation to ChildTable 
            parentToChildRelationDescriptor.ChildTableDescriptor.Relations.Add(childToGrandChildRelationDescriptor);

            // Register any DataTable/IList with SourceListSet, so that RelationDescriptor can resolve the name
            this.gridGroupingControl1.Engine.SourceListSet.Add("MyParentTable", parentTable);
            this.gridGroupingControl1.Engine.SourceListSet.Add("MyChildTable", childTable);
            this.gridGroupingControl1.Engine.SourceListSet.Add("MyGrandChildTable", grandChildTable);

            this.gridGroupingControl1.DataSource = parentTable;

            this.gridGroupingControl1.TableDescriptor.Columns["parentID"].HeaderText = "Parent ID";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Columns["childID"].HeaderText = "Child ID";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Relations[0].ChildTableDescriptor.Columns["GrandChildID"].HeaderText = "Grand Child ID";
        }

        #endregion

        #region "DataTable"

        private int numberParentRows = 5;
        private int numberChildRows = 20;
        private int numberGrandChildRows = 50;
        private DataTable GetParentTable()
        {
            DataTable dt = new DataTable("ParentTable");


            dt.Columns.Add(new DataColumn("parentID")); //lower case p
            dt.Columns.Add(new DataColumn("Parent Name"));
            dt.Columns.Add(new DataColumn("Parent Decription"));

            for (int i = 0; i < numberParentRows; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i;//.ToString();
                dr[1] = string.Format("parent Name{0}", i);
                dr[2] = string.Format("parent Decription{0}", i);
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private DataTable GetChildTable()
        {
            DataTable dt = new DataTable("ChildTable");

            dt.Columns.Add(new DataColumn("childID")); //lower case c
            dt.Columns.Add(new DataColumn("Name"));
            dt.Columns.Add(new DataColumn("ParentID")); //upper case P

            for (int i = 0; i < numberChildRows; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i.ToString();
                dr[1] = string.Format("ChildName{0}", i);
                dr[2] = (i % numberParentRows).ToString();
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private DataTable GetGrandChildTable()
        {
            DataTable dt = new DataTable("GrandChildTable");

            dt.Columns.Add(new DataColumn("GrandChildID"));
            dt.Columns.Add(new DataColumn("Name"));
            dt.Columns.Add(new DataColumn("ChildID")); //upper case C

            for (int i = 0; i < numberGrandChildRows; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i.ToString();
                dr[1] = string.Format("GrandChildName{0}", i);
                dr[2] = (i % numberChildRows).ToString();
                dt.Rows.Add(dr);
            }

            return dt;
        }
        #endregion

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

        #region "Windows Form Designer generated code"
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            //this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            //            | System.Windows.Forms.AnchorStyles.Left)
            //            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.Dock = DockStyle.Fill;
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.ChildGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.Location = new System.Drawing.Point(10, 12);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.Size = new System.Drawing.Size(798, 631);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.TableDescriptor.AllowNew = false;
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255))))));
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(160, 34);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(41, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Export to Word Document";
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(154, 31);
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(12, 87);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(154, 31);
            this.buttonAdv1.TabIndex = 4;
            this.buttonAdv1.Text = "Collapse All";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.UseVisualStyleBackColor = true;
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(154, 31);
            this.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv2.ForeColor = System.Drawing.Color.White;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(12, 33);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(154, 31);
            this.buttonAdv2.TabIndex = 3;
            this.buttonAdv2.Text = "Expand All";
            this.buttonAdv2.UseVisualStyle = true;
            this.buttonAdv2.UseVisualStyleBackColor = true;
            //
            //Panel
            //
            this.panel.Dock = DockStyle.Right;
            this.panel.Size = new Size(250, 300);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Location = new Point(10, 10);
            this.panel.Controls.Add(this.button1);

            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonAdv2);
            this.groupBox1.Controls.Add(this.buttonAdv1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expand Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 653);
            this.Controls.Add(this.gridGroupingControl1);
            this.Controls.Add(panel);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Word Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
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

# if SyncfusionFramework1_1 || SyncfusionFramework2_0
            Application.EnableVisualStyles();
# endif
            Application.Run(new Form1());
        }

        #endregion     
        
    }
}