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
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace ManualRelations
{
	/// <summary>
	/// This sample demonstrates how to manually specify master-details relations 
	/// between three separate tables that primary keys and foreign key columns
	/// in common. 
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region "API definition"

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
		private System.ComponentModel.Container components = null;

        #endregion

        #region "Constructor"

        public Form1()
		{
			InitializeComponent();
			
            this.SampleCustomization();

            this.GridSettings();

		}

        #endregion

        #region "Sample Customization"
        /// <summary>
        /// Setting reltion to the parent and child tables.
        /// </summary>
        private void SampleCustomization()
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
            //Addin DataSource to the gridgroupingcontrol.
            this.gridGroupingControl1.DataSource = parentTable;
        }

        #endregion

        #region "Designer Stuffs"

       #region Dispose
        /// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
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
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.Location = new System.Drawing.Point(16, 16);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(976, 638);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1012, 674);
            this.Controls.Add(this.gridGroupingControl1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Related Master Details";
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

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            //Setting Style for Grid and ScrollBar.
			this.gridGroupingControl1.TableControl.DpiAware = true;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;

            //used for disabling ShowAddNewRecord and ShowCaption.
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;

            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22);
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;

            this.gridGroupingControl1.TableDescriptor.Columns["ParentName"].HeaderText = "Parent Name";
            this.gridGroupingControl1.TableDescriptor.Columns["ParentDec"].HeaderText = "Parent Dec";
            this.gridGroupingControl1.TableDescriptor.Columns["parentID"].HeaderText = "Parent ID";
            

            this.gridGroupingControl1.GetTable("MyChildTable").DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22);
            this.gridGroupingControl1.GetTable("MyGrandChildTable").DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22);

            this.gridGroupingControl1.GetTableDescriptor("MyChildTable").Columns["childID"].HeaderText = "Child ID";
            this.gridGroupingControl1.GetTableDescriptor("MyGrandChildTable").Columns["GrandChildID"].HeaderText = "Grand Child ID";
            
        }

        #endregion

		# region "DataTables"

		private int numberParentRows = 10;
		private int numberChildRows = 20;
		private int numberGrandChildRows = 50;
		private DataTable GetParentTable()
		{
			DataTable dt = new DataTable("ParentTable");

			
			dt.Columns.Add(new DataColumn("parentID")); //lower case p
			dt.Columns.Add(new DataColumn("ParentName"));
			dt.Columns.Add(new DataColumn("ParentDec"));

			for(int i = 0; i < numberParentRows; i++)
			{
				DataRow dr = dt.NewRow();
				dr[0] = i;//.ToString();
				dr[1] = string.Format("parentName{0}", i);
                dr[2] = (i % numberParentRows).ToString();
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
			
			for(int i = 0; i < numberChildRows; i++)
			{
				DataRow dr = dt.NewRow();
				dr[0] = i.ToString();
				dr[1] = string.Format("ChildName{0}",i);
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
			
			for(int i = 0; i < numberGrandChildRows; i++)
			{
				DataRow dr = dt.NewRow();
				dr[0] = i.ToString();
				dr[1] = string.Format("GrandChildName{0}",i);
				dr[2] = (i % numberChildRows).ToString();
				dt.Rows.Add(dr);
			}
			
			return dt;
		}
		#endregion
	}
}
