#region Copyright Syncfusion Inc. 2001 - 2015.
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

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace ListItemReference
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
		private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
	
		private System.ComponentModel.Container components = null;

        #endregion

        #region "Constructor"

        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

		
            this.SampleCustomization();

            this.GridSettings();
            this.gridGroupingControl1.TableControlCurrentCellShowedDropDown += gridGroupingControl1_TableControlCurrentCellShowedDropDown;
		}

        void gridGroupingControl1_TableControlCurrentCellShowedDropDown(object sender, GridTableControlEventArgs e)
        {
            GridTableDropDownListCellRenderer renderer = this.gridGroupingControl1.TableControl.CellRenderers["ForeignKeyCell"] as GridTableDropDownListCellRenderer;
            renderer.ListControlPart.Grid.GridOfficeScrollBars = OfficeScrollBars.Metro;
        }

        #endregion

        #region "Sample Customization"
        /// <summary>
        /// RelationKind ListItemReference relation for looking up values from a strong-typed collection.
        /// </summary>
        private void SampleCustomization()
        {
            USStatesCollection usStates = USStatesCollection.CreateDefaultCollection();
            CountriesCollection countries = CountriesCollection.CreateDefaultCollection();

            this.gridGroupingControl1.Engine.SourceListSet.Add("Countries", countries);
            this.gridGroupingControl1.Engine.SourceListSet.Add("USStates", usStates);

            #region DataTable
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Country", typeof(Country));
            table.Columns.Add("State", typeof(USState));

            // and then add a few rows:
            for (int i = 0; i < 50; i++)
            {
                table.Rows.Add(table.NewRow());
                table.Rows[i][0] = i;
                table.Rows[i][1] = countries[i % 8];
                if (i % 8 == 0)
                    table.Rows[i][2] = usStates[i / 8];
            }

            #endregion

            GridTableDescriptor mainTd = this.gridGroupingControl1.TableDescriptor;

            //creating new relation descroptor.
            GridRelationDescriptor usStatesRd = new GridRelationDescriptor();
            usStatesRd.Name = "State";
            usStatesRd.MappingName = "State";  // FieldName in table
            usStatesRd.ChildTableName = "USStates";  // SourceListSet name for lookup
            //setting Relation Kind as ListItemreference.
            usStatesRd.RelationKind = RelationKind.ListItemReference;
            usStatesRd.ChildTableDescriptor.Appearance.AlternateRecordFieldCell.BackColor = Color.FromArgb(255, 245, 227);
            usStatesRd.ChildTableDescriptor.VisibleColumns.Add("Name");
            usStatesRd.ChildTableDescriptor.SortedColumns.Add("Name");
            mainTd.Relations.Add(usStatesRd);

            GridRelationDescriptor countriesRd = new GridRelationDescriptor();
            countriesRd.Name = "Country";
            countriesRd.MappingName = "Country";  // FieldName in table
            countriesRd.ChildTableName = "Countries";  // SourceListSet name for lookup
            //setting Relation Kind as ListItemreference.
            countriesRd.RelationKind = RelationKind.ListItemReference;
            countriesRd.ChildTableDescriptor.Appearance.AlternateRecordFieldCell.BackColor = Color.FromArgb(255, 245, 227);
            countriesRd.ChildTableDescriptor.AllowEdit = true;
            countriesRd.ChildTableDescriptor.AllowNew = true;  // Make pencil icon appear, allow user to add countries (these setting will be overriden by CountriesCollection.IsReadOnly / CountriesCollection.IsFixedSize properties if they are true).
            mainTd.Relations.Add(countriesRd);

           
            //assigning datasource to the GridGroupingControl.
            this.gridGroupingControl1.DataSource = table;
        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            //used for disabling ShowAddNewRow and ShowCaption.
			this.gridGroupingControl1.TableControl.DpiAware = true;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            //used for seeting GridVisualStyle and Scriibar style.
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;

            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22);
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
         
        }

        #endregion

        #region "Designer Stuffs"

       #region "Dispose"
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
            this.gridGroupingControl1.IntelliMousePanning = true;
            this.gridGroupingControl1.Location = new System.Drawing.Point(16, 16);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(982, 623);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            // 
            // Form1
            // 
            this.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 653);
            this.Controls.Add(this.gridGroupingControl1);
            this.Name = "Form1";
			this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Text = "List Item Reference";
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

            # if SyncfusionFramework1_1 || SyncfusionFramework2_0
                Application.EnableVisualStyles();
            # endif

			Application.Run(new Form1());
        }

        #endregion 

    }
}
