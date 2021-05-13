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
using System.Text;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Grouping;

using Syncfusion.Collections;
using Syncfusion.Drawing;
using Syncfusion.ComponentModel;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid.Grouping;
using DemoCommon.Grid;

namespace StrongTypedCollectionSample
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl groupingGrid1;
        private Panel panel1;
        private PropertyGrid propertyGrid1;
        private System.ComponentModel.Container components = null;

        #endregion

        #region "Constructor"

        public Form1()
        {
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.SampleCustomization();
            this.GridSettings();
        }

        #endregion

        #region "SampleCustomization"

        /// <summary>
        /// binding Custom collection to the GridGroupingControl.
        /// </summary>
        private void SampleCustomization()
        {

            CustomerCollection customers = PopulateCustomers.CreateCustomers();


           this.groupingGrid1.DataSource = customers;

            GridEngine engine = this.groupingGrid1.Engine;
            engine.TopLevelGroupOptions.ShowCaption = true;

            GridRelationDescriptorCollection relations = new GridRelationDescriptorCollection();

            // First level
            GridRelationDescriptor rd = AddRelation("Level_0", relations);

            // Subsequent levels
            for (int level = 1; level < 5; level++)
            {
                rd = AddRelation("Level_" + level.ToString(), rd.ChildTableDescriptor.Relations);
            }
            this.groupingGrid1.TableDescriptor.Relations = relations;


            Syncfusion.Grouping.Diagnostics.IterateThroughNestedDisplayElement(this.groupingGrid1.Table);
        }

        //Adding relation to the child columns.
        GridRelationDescriptor AddRelation(string name, GridRelationDescriptorCollection relations)
        {
            GridRelationDescriptor children = new GridRelationDescriptor();
            children.RelationKind = RelationKind.UniformChildList;
            children.MappingName = "Children";
            children.Name = name;
            relations.Add(children);
            return children;
        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            //setting propertygrid object as GridGroupingControl.
            this.propertyGrid1.SelectedObject = this.groupingGrid1;
            this.propertyGrid1.BackColor = Color.White;

            //Disabling ShowAddNewRow and ShowCaption.
            this.groupingGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.groupingGrid1.TopLevelGroupOptions.ShowCaption = false;

            //Setting Grid NavigationBar
            this.groupingGrid1.ShowNavigationBar = true;
            //Setting Grid HorizontalScrollTips
            this.groupingGrid1.TableControl.HorizontalScrollTips = false;
            //Setting GroupingGrid Border style.
            this.groupingGrid1.BorderStyle = BorderStyle.FixedSingle;
            this.groupingGrid1.FilterRuntimeProperties = true;


            this.groupingGrid1.TableOptions.ShowRecordPlusMinus = true;
            this.groupingGrid1.NestedTableGroupOptions.ShowCaptionPlusMinus = false;
            this.groupingGrid1.Table.ExpandAllRecords();

            //used to set multiextended selection mode in gridgrouping control. 
            this.groupingGrid1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            this.groupingGrid1.TableControl.DpiAware = true;
			//used to set GridCaptionRowHeight.
            this.groupingGrid1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.groupingGrid1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.groupingGrid1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.groupingGrid1.AllowProportionalColumnSizing = true;

            this.groupingGrid1.TableDescriptor.Columns["FirstName"].HeaderText = "First Name";
            this.groupingGrid1.TableDescriptor.Columns["LastName"].HeaderText = "Last Name";

            //Navigate to other control using tabkey navigation
            this.groupingGrid1.WantTabKey = false;

            foreach (GridTableDescriptor td in this.groupingGrid1.Engine.EnumerateTableDescriptor())
            {
                if (td.Name == "Level_0")
                {
                    td.Columns["FirstName"].HeaderText = "First Name";
                    td.Columns["LastName"].HeaderText = "Last Name";
                }
                if (td.Name == "Level_1")
                {
                    td.Columns["FirstName"].HeaderText = "First Name";
                    td.Columns["LastName"].HeaderText = "Last Name";
                }

            }

            this.groupingGrid1.GetTable("Level_0").DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
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
            this.groupingGrid1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.panel1 = new Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.groupingGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupingGrid1
            // 
            this.groupingGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.groupingGrid1.FreezeCaption = false;
            this.groupingGrid1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.groupingGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.groupingGrid1.Location = new System.Drawing.Point(28, 23);
            this.groupingGrid1.Name = "groupingGrid1";
            this.groupingGrid1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.groupingGrid1.NestedTableGroupOptions.ShowCaption = true;
            this.groupingGrid1.Size = new System.Drawing.Size(686, 626);
            this.groupingGrid1.TabIndex = 1;
            this.groupingGrid1.TableDescriptor.AllowNew = false;
            this.groupingGrid1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.groupingGrid1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))));
            this.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.groupingGrid1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))));
            this.groupingGrid1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = true;
            this.groupingGrid1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader";
            this.groupingGrid1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.groupingGrid1.TableDescriptor.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.groupingGrid1.Text = "groupingGrid1";
            this.groupingGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.groupingGrid1.TopLevelGroupOptions.ShowCaption = false;
            //
            //Panel1
            //
            this.panel1.Location = new Point(28, 23);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(this.groupingGrid1);

            // 
            // propertyGrid1
            // 
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(720, 23);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(259, 626);
            this.propertyGrid1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 674);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(860, 400);
            this.Name = "Form1";
            this.Text = "Strongly Typed Collection";
            ((System.ComponentModel.ISupportInitialize)(this.groupingGrid1)).EndInit();
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
    }
}