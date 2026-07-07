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

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using DemoCommon.Grid;
using System.Text.RegularExpressions;


namespace CustomFieldType
{
	
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region API Definition
        /// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        DataTable table = new DataTable();
		GridGroupingControl gridGroupingControl1;
        Random rand = new Random();	
        #endregion

        #region Constructor
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
			gridGroupingControl1 = new GridGroupingControl();
            // now assign the datasource			
			gridGroupingControl1.DataSource = table;
            SampleCustomization();
            GridSettings();	

			Console.WriteLine(GridPropertyTypeDefaultStyleCollection.Default["System.Boolean"].Style);

			// enable/disable UITYpeEditors for boolean cells only and show checkbox instead.
			bool displayCheckBoxForBooleanFields = false;
			if (displayCheckBoxForBooleanFields)
			{
				GridPropertyTypeDefaultStyle booleanDefault = this.gridGroupingControl1.Engine.PropertyTypeDefaultStyles["System.Boolean"];
				booleanDefault.AllowDropDown = false;
            }

            #region Sample code to get the row and column index
            // Sample code to get the row and column index in the grid for a column (works also
			// if column sets with multiple rows are specified).
			bool useOldCodeToGetCellInfo = false;
			if (useOldCodeToGetCellInfo)
			{
				GridColumnDescriptor cd = this.gridGroupingControl1.TableDescriptor.Columns["Boolean"];
				int relativeRowIndex, colIndex;
				this.gridGroupingControl1.TableDescriptor.ColumnToRowColIndex(cd.MappingName, out relativeRowIndex, out colIndex);
				
				Record r = this.gridGroupingControl1.Table.Records[0];
				int recordRowIndex = this.gridGroupingControl1.Table.DisplayElements.IndexOf(r);
				
				int rowIndex = recordRowIndex + relativeRowIndex;
				GridTableCellStyleInfo style = this.gridGroupingControl1.Table.GetTableCellStyle(rowIndex, colIndex + this.gridGroupingControl1.TableDescriptor.GetColumnIndentCount());

				Console.WriteLine(style.TableCellIdentity.ToString());
				Console.WriteLine(style.ToString());
			}
			else
			{
				// Newer code using new GetTableCellStyle overloads after version 3.0.0.16
				Record r = this.gridGroupingControl1.Table.Records[0];
				GridTableCellStyleInfo style = this.gridGroupingControl1.Table.GetTableCellStyle(r, "Boolean");

				Console.WriteLine(style.TableCellIdentity.ToString());
				Console.WriteLine(style.ToString());
            }
            #endregion
        }
        #endregion

        #region Sample Customization
        /// <summary>
        /// Populating the Fields as certain Cell types using DataTable.
        /// </summary>
        private void SampleCustomization()
        {
            #region DataTable
            table.Columns.Add("FooColumn1", typeof(Foo));
            table.Columns.Add("FooColumn2", typeof(NestedFoo));
            table.Columns.Add("Boolean", typeof(bool));
            table.Columns.Add("Color", typeof(Color));
            table.Columns.Add("Font", typeof(Font));
            table.Columns.Add("PatternStyle", typeof(Syncfusion.Drawing.PatternStyle));
            table.Columns.Add("DockStyle", typeof(DockStyle));
            table.Columns.Add("FieldDescriptor", typeof(FieldDescriptor));
            table.Columns.Add("BordersInfo", typeof(GridBordersInfo));

            // and then add a few rows:
            for (int i = 0; i < 50; i++)
            {
                table.Rows.Add(table.NewRow());

                // Simple nested properties
                Foo foo = new Foo();
                foo.PropertyOne = rand.Next().ToString();
                foo.PropertyTwo = rand.Next().ToString();
                table.Rows[i][0] = foo;

                // Nested with nested properties
                NestedFoo nestedFoo = new NestedFoo();
                nestedFoo.SomeProperty = rand.Next().ToString();
                nestedFoo.Inner.PropertyOne = rand.Next().ToString();
                nestedFoo.Inner.PropertyTwo = rand.Next().ToString();
                table.Rows[i][1] = nestedFoo;

                // Boolean
                if (i % 2 == 0)
                    table.Rows[i][2] = (i % 4 == 0);

                // Color
                table.Rows[i][3] = SystemColors.ActiveBorder;

                // Font
                if (i % 4 == 0)
                    table.Rows[i][4] = new Font("Arial", 12);

                table.Rows[i]["BordersInfo"] = new GridBordersInfo();
                table.Rows[i]["FieldDescriptor"] = new FieldDescriptor();
            }
            #endregion
        }
        #endregion

        #region GridSettings
        /// <summary>
        /// Grid Settings for better Look and Feel
        /// </summary>
        private void GridSettings()
        {           
            this.gridGroupingControl1.Size = new System.Drawing.Size(980, 640);
            this.gridGroupingControl1.Location = new Point(15, 2);
            this.gridGroupingControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.gridGroupingControl1.TableOptions.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Segoe UI";    
            GridTableDescriptor td = this.gridGroupingControl1.TableDescriptor;
            FieldDescriptor unboundFd = new FieldDescriptor("Unbound");
            td.UnboundFields.Add(unboundFd);

            // In case you want to manually add fields here
            gridGroupingControl1.TableDescriptor.Columns.Clear();
            gridGroupingControl1.TableDescriptor.Columns.Add("FooColumn1_PropertyOne");
            gridGroupingControl1.TableDescriptor.Columns.Add("FooColumn1_PropertyTwo");
            gridGroupingControl1.TableDescriptor.Columns.Add("FooColumn2_SomeProperty");
            gridGroupingControl1.TableDescriptor.Columns.Add("FooColumn2_Inner_PropertyOne");
            gridGroupingControl1.TableDescriptor.Columns.Add("FooColumn2_Inner_PropertyTwo");
            gridGroupingControl1.TableDescriptor.Columns.Add("Boolean");
            gridGroupingControl1.TableDescriptor.Columns.Add("Color");
            gridGroupingControl1.TableDescriptor.Columns.Add("Font");
            gridGroupingControl1.TableDescriptor.Columns.Add("PatternStyle");
            gridGroupingControl1.TableDescriptor.Columns.Add("DockStyle");
            gridGroupingControl1.TableDescriptor.Columns.Add("FieldDescriptor");
            gridGroupingControl1.TableDescriptor.Columns.Add("BordersInfo");
            gridGroupingControl1.TableDescriptor.Columns.Add("Unbound");
			this.gridGroupingControl1.Dock = DockStyle.Fill;

            //Adding GridGroupingControl to the form controls
            this.Controls.Add(gridGroupingControl1);

			this.gridGroupingControl1.TableControl.DpiAware = true;
            gridGroupingControl1.SaveValue += new FieldValueEventHandler(grid_SaveValue);
            gridGroupingControl1.QueryValue += new FieldValueEventHandler(grid_QueryValue);

            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            // enable/disable UITYpeEditors for cells.
            bool showUITypeEditors = true;
            this.gridGroupingControl1.TableOptions.AllowDropDownCell = showUITypeEditors;
            this.gridGroupingControl1.TableDescriptor.Columns["Boolean"].Appearance.AnyRecordFieldCell.CellType = "ComboBox";
            //Used to set the selction mode for grid
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font.Bold = true;


            gridGroupingControl1.TableDescriptor.Columns["FooColumn1_PropertyOne"].HeaderText = "Foo Column1_Property One";
            gridGroupingControl1.TableDescriptor.Columns["FooColumn1_PropertyTwo"].HeaderText = "Foo Column1_Property Two";
            gridGroupingControl1.TableDescriptor.Columns["FooColumn2_SomeProperty"].HeaderText = "Foo Column2_Some Property";
            gridGroupingControl1.TableDescriptor.Columns["FooColumn2_Inner_PropertyOne"].HeaderText = "Foo Column2_Inner_Property One";
            gridGroupingControl1.TableDescriptor.Columns["FooColumn2_Inner_PropertyTwo"].HeaderText = "Foo Column2_Inner_Property Two";
            gridGroupingControl1.TableDescriptor.Columns["PatternStyle"].HeaderText = "Pattern Style";
            gridGroupingControl1.TableDescriptor.Columns["DockStyle"].HeaderText = "Dock Style";
            gridGroupingControl1.TableDescriptor.Columns["FieldDescriptor"].HeaderText = "Field Descriptor";
            gridGroupingControl1.TableDescriptor.Columns["BordersInfo"].HeaderText = "Borders Info";
        }
        #endregion               

        #region Designer Stuffs
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // Form1
            //           
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 656);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Custom Field Type";
            this.ResumeLayout(false);

		}

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
		#endregion

        #region Events
        private void grid_SaveValue(object sender, FieldValueEventArgs e)
        {
            Console.WriteLine("grid_SaveValue: " + e.ToString());
        }

        private void grid_QueryValue(object sender, FieldValueEventArgs e)
        {
            e.Value = e.Record.ParentTable.Records.IndexOf(e.Record);
        }
        #endregion
		
    }

    #region Properties
    [TypeConverter(typeof(ExpandableObjectConverter))]
	public class Foo
	{
		string someProperty;
		string someProperty2;

		public string PropertyOne
		{
			get
			{
				return someProperty;
			}
			set
			{
				someProperty = value;
			}
		}

		public string PropertyTwo
		{
			get
			{
				return someProperty2;
			}
			set
			{
				someProperty2 = value;
			}
		}
	} 

	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class NestedFoo
	{
		string someProperty;
		Foo someFoo = new Foo();

		public string SomeProperty
		{
			get
			{
				return someProperty;
			}
			set
			{
				someProperty = value;
			}
		}

		public Foo Inner
		{
			get
			{
				return someFoo;
			}
		}
	} 
#endregion
}
