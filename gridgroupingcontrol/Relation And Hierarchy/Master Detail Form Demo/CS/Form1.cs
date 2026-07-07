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
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace MasterDetailForm
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl hierarchyGrid;
		private System.Windows.Forms.Label label4;
        private Panel panel1;
        private Label label1;
        private GridGroupingControl parentTableGrid;
        private Panel panel2;
        private Label label2;
        private GridGroupingControl parentToChildGrid;
        private Panel panel3;
        private GridGroupingControl childToGrandChildGrid;
        private Label label3;
		
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
            //
            // TODO: Add any constructor code after InitializeComponent call
            //

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			

            this.samplecustomization();
            
            this.GridSettings();

		}

        #endregion

        #region "Sample Customization"
        /// <summary>
        /// Disabling binding of the grid to a currency manager.
        /// </summary>
        private void samplecustomization()
        {
            DataSet dSet = new DataSet();

            //get the tables
            DataTable parentTable = GetParentTable();
            DataTable childTable = GetChildTable();
            DataTable grandChildTable = GetGrandChildTable();
            dSet.Tables.AddRange(new DataTable[] { parentTable, childTable, grandChildTable });

            //setup the relations
            DataColumn parentColumn = parentTable.Columns["parentID"];
            DataColumn childColumn = childTable.Columns["ParentID"];
            dSet.Relations.Add("ParentToChild", parentColumn, childColumn);

            parentColumn = childTable.Columns["childID"];
            childColumn = grandChildTable.Columns["ChildID"];
            dSet.Relations.Add("ChildToGrandChild", parentColumn, childColumn);

            //set the master-detail-detail grids
            this.parentTableGrid.DataSource = parentTable; //master
            this.parentTableGrid.TableDescriptor.Relations.Clear(); // don't autopopulate relations

            this.parentToChildGrid.DataSource = parentTable; //detail1
            this.parentToChildGrid.DataMember = "ParentToChild"; //detail1
            this.parentToChildGrid.TableDescriptor.Relations.Clear(); // don't autopopulate relations

            this.childToGrandChildGrid.DataSource = parentTable; //detail2
            this.childToGrandChildGrid.DataMember = "ParentToChild.ChildToGrandChild"; //detail2
            this.childToGrandChildGrid.TableDescriptor.Relations.Clear(); // don't autopopulate relations

            // hierarchyGrid grid with hierarchical view
            this.hierarchyGrid.DataSource = parentTable;
            //disabling BindToCurrencyManager.
            this.hierarchyGrid.Engine.BindToCurrencyManager = false; // don't attach this one to CurrencyManager.
        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            //Setting Style for Grid and ScrollBar.
			this.parentTableGrid.TableControl.DpiAware = true;
            this.parentTableGrid.GridVisualStyles = GridVisualStyles.Metro;
            this.parentTableGrid.GridOfficeScrollBars = OfficeScrollBars.Metro;
            //used for disabling ShowAddNewRow and ShowCaption.
            this.parentTableGrid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.parentTableGrid.TopLevelGroupOptions.ShowCaption = false;

            this.parentTableGrid.TableDescriptor.Columns["ParentName"].HeaderText = "Parent Name";
            this.parentTableGrid.TableDescriptor.Columns["parentID"].HeaderText = "Parent ID";
            this.hierarchyGrid.TableDescriptor.Columns["ParentName"].HeaderText = "Parent Name";
            this.hierarchyGrid.TableDescriptor.Columns["parentID"].HeaderText = "Parent ID";
            this.parentToChildGrid.TableDescriptor.Columns["childID"].HeaderText = "Child ID";
            this.parentToChildGrid.TableDescriptor.Columns["ParentID"].HeaderText = "Parent ID";
            this.childToGrandChildGrid.TableDescriptor.Columns["GrandChildID"].HeaderText = "Grand Child ID";
            this.childToGrandChildGrid.TableDescriptor.Columns["ChildID"].HeaderText = "Child ID";
            //Setting Style for Grid and ScrollBar.
			this.parentToChildGrid.TableControl.DpiAware = true;
            this.parentToChildGrid.GridVisualStyles = GridVisualStyles.Metro;
            this.parentToChildGrid.GridOfficeScrollBars = OfficeScrollBars.Metro;
            //used for disabling ShowAddNewRow and ShowCaption.
            this.parentToChildGrid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.parentToChildGrid.TopLevelGroupOptions.ShowCaption = false;

            //Setting Style for Grid and ScrollBar.
			this.childToGrandChildGrid.TableControl.DpiAware = true;
            this.childToGrandChildGrid.GridVisualStyles = GridVisualStyles.Metro;
            this.childToGrandChildGrid.GridOfficeScrollBars = OfficeScrollBars.Metro;
            //used for disabling ShowAddNewRow and ShowCaption.
            this.childToGrandChildGrid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.childToGrandChildGrid.TopLevelGroupOptions.ShowCaption = false;

            //Setting Style for Grid and ScrollBar.
            this.hierarchyGrid.GridVisualStyles = GridVisualStyles.Metro;
            this.hierarchyGrid.GridOfficeScrollBars = OfficeScrollBars.Metro;
            //used for disabling ShowAddNewRow and ShowCaption.
            this.hierarchyGrid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.hierarchyGrid.TopLevelGroupOptions.ShowCaption = false;
            
            
            //used to set multiextended selection mode in gridgrouping control. 
            this.parentTableGrid.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //used to set GridCaptionRowHeight.
            this.parentTableGrid.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);
            this.parentTableGrid.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30);
            this.parentTableGrid.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22);
            this.parentTableGrid.AllowProportionalColumnSizing = true;

            //used to set multiextended selection mode in gridgrouping control. 
            this.parentToChildGrid.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //used to set GridCaptionRowHeight.
            this.parentToChildGrid.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);
            this.parentToChildGrid.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30);
            this.parentToChildGrid.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22);
            this.parentToChildGrid.AllowProportionalColumnSizing = true;


            //used to set multiextended selection mode in gridgrouping control. 
            this.childToGrandChildGrid.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //used to set GridCaptionRowHeight.
            this.childToGrandChildGrid.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);
            this.childToGrandChildGrid.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30);
            this.childToGrandChildGrid.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22);
            this.childToGrandChildGrid.AllowProportionalColumnSizing = true;

            //used to set multiextended selection mode in gridgrouping control. 
            this.hierarchyGrid.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //used to set GridCaptionRowHeight.
            this.hierarchyGrid.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);
            this.hierarchyGrid.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30);
            this.hierarchyGrid.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22);
            this.hierarchyGrid.AllowProportionalColumnSizing = true;

            //Navigate to other control using tabkey navigation
            this.parentTableGrid.WantTabKey = false;
            this.parentToChildGrid.WantTabKey = false;
            this.hierarchyGrid.WantTabKey = false;
            this.childToGrandChildGrid.WantTabKey = false;
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
            this.hierarchyGrid = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.parentTableGrid = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.parentToChildGrid = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.childToGrandChildGrid = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hierarchyGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentTableGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentToChildGrid)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childToGrandChildGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // hierarchyGrid
            // 
            this.hierarchyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hierarchyGrid.BackColor = System.Drawing.SystemColors.Window;
            this.hierarchyGrid.FreezeCaption = false;
            this.hierarchyGrid.Location = new System.Drawing.Point(668, 32);
            this.hierarchyGrid.Name = "hierarchyGrid";
            this.hierarchyGrid.Size = new System.Drawing.Size(320, 551);
            this.hierarchyGrid.TabIndex = 2;
            this.hierarchyGrid.Text = "hierarchyGrid";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(671, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "HierarchyGrid";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.parentTableGrid);
            this.panel1.Location = new System.Drawing.Point(16, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 186);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parent";
            // 
            // parentTableGrid
            // 
            this.parentTableGrid.BackColor = System.Drawing.SystemColors.Window;
            this.parentTableGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.parentTableGrid.FreezeCaption = false;
            this.parentTableGrid.Location = new System.Drawing.Point(0, 24);
            this.parentTableGrid.Name = "parentTableGrid";
            this.parentTableGrid.Size = new System.Drawing.Size(626, 162);
            this.parentTableGrid.TabIndex = 4;
            this.parentTableGrid.Text = "parentTableGrid";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.parentToChildGrid);
            this.panel2.Location = new System.Drawing.Point(16, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 192);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(626, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Child";
            // 
            // parentToChildGrid
            // 
            this.parentToChildGrid.BackColor = System.Drawing.SystemColors.Window;
          
            this.parentToChildGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.parentToChildGrid.FreezeCaption = false;
            this.parentToChildGrid.Location = new System.Drawing.Point(0, 19);
            this.parentToChildGrid.Name = "parentToChildGrid";
            this.parentToChildGrid.Size = new System.Drawing.Size(626, 173);
            this.parentToChildGrid.TabIndex = 5;
            this.parentToChildGrid.Text = "parentToChildGrid";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.childToGrandChildGrid);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(16, 429);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 154);
            this.panel3.TabIndex = 10;
            // 
            // childToGrandChildGrid
            // 
            this.childToGrandChildGrid.BackColor = System.Drawing.SystemColors.Window;
         
            this.childToGrandChildGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.childToGrandChildGrid.FreezeCaption = false;
            this.childToGrandChildGrid.Location = new System.Drawing.Point(0, 23);
            this.childToGrandChildGrid.Name = "childToGrandChildGrid";
            this.childToGrandChildGrid.Size = new System.Drawing.Size(626, 131);
            this.childToGrandChildGrid.TabIndex = 8;
            this.childToGrandChildGrid.Text = "childToGrandChildGrid";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(626, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "GrandChild";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 591);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hierarchyGrid);
            this.MinimumSize = new System.Drawing.Size(1015, 640);
            this.Name = "Form1";
            this.Text = "Master Detail Form ";
            ((System.ComponentModel.ISupportInitialize)(this.hierarchyGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parentTableGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parentToChildGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.childToGrandChildGrid)).EndInit();
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

        #region "Data Table"

        private int parentRows = 10;
		private int ChildRows = 30;
		private int GrandChildRows = 80;
        #region Creating DataTable
        private DataTable GetParentTable()
		{
			DataTable dt = new DataTable("ParentTable");

			dt.Columns.Add(new DataColumn("parentID")); //lower case p
			dt.Columns.Add(new DataColumn("ParentName"));

			for(int i = 0; i < parentRows; ++i)
			{
				DataRow dr = dt.NewRow();
				dr[0] = i.ToString();
				dr[1] = string.Format("parentName{0}", i);
				dt.Rows.Add(dr);
			}

			return dt;
		}

		private Random r = new Random();
        
        private DataTable GetChildTable()
		{
			DataTable dt = new DataTable("ChildTable");

			dt.Columns.Add(new DataColumn("childID")); //lower case c
			dt.Columns.Add(new DataColumn("Name"));
			dt.Columns.Add(new DataColumn("ParentID")); //upper case P
			
			for(int i = 0; i < ChildRows; ++i)
			{
				DataRow dr = dt.NewRow();
				dr[0] = i.ToString();
				dr[1] = string.Format("ChildName{0}",i);
				dr[2] = r.Next(parentRows).ToString();//(i % parentRows).ToString();
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
			
			for(int i = 0; i < GrandChildRows; ++i)
			{
				DataRow dr = dt.NewRow();
				dr[0] = i.ToString();
				dr[1] = string.Format("GrandChildName{0}",i);
				dr[2] = r.Next(ChildRows).ToString();//(i % ChildRows).ToString();
				dt.Rows.Add(dr);
			}
			
			return dt;
        }
        #endregion 

#endregion

             
    }
}
