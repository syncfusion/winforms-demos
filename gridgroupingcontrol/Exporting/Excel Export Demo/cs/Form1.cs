#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
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
using System.IO;


using Syncfusion.XlsIO;

using Syncfusion.GridExcelConverter;
using Syncfusion.GroupingGridExcelConverter;


using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace GridExcelConverter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region "API Definitions"

        private Syncfusion.Windows.Forms.ButtonAdv button2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox3;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox4;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox5;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox6;
        private GroupBox groupBox1;
        private GridGroupingControl gridGroupingControl1;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label4;
        private IContainer components;

        #endregion

        #region "Constructor"
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.GridSettings();
        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {

            #region SetUpGroupingGrid

            DataTable parentTable = GetParentTable();
			DataTable childTable = GetChildTable();
            DataTable grandChildTable = GetGrandChildTable();

            //Add Summary row to parent table
            GridSummaryColumnDescriptor gridSummaryColumnDescriptor = new GridSummaryColumnDescriptor();
            gridSummaryColumnDescriptor.DisplayColumn = "GroupID";
            gridSummaryColumnDescriptor.Format = "  {Count} Records.";
            gridSummaryColumnDescriptor.Name = "SummaryColumn";
            gridSummaryColumnDescriptor.SummaryType = Syncfusion.Grouping.SummaryType.Count;
            this.gridGroupingControl1.TableDescriptor.SummaryRows.Add(new GridSummaryRowDescriptor("SummaryRow", new GridSummaryColumnDescriptor[] {
                gridSummaryColumnDescriptor}));


			// Manually specify relations in grouping engine. The DataSet does not need to have any DataRelations.
			// This is the same approach that should be used if you want to set up relation ships
			// between independent IList.
			GridRelationDescriptor parentToChildRelationDescriptor = new GridRelationDescriptor();
			parentToChildRelationDescriptor.ChildTableName = "MyChildTable";    // same as SourceListSetEntry.Name for childTable (see below)
			parentToChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails;
			parentToChildRelationDescriptor.RelationKeys.Add("parentID", "ParentID");

            //Add Summary Row to child table
            gridSummaryColumnDescriptor = new GridSummaryColumnDescriptor();
            gridSummaryColumnDescriptor.DisplayColumn = "ChildGroupID";
            gridSummaryColumnDescriptor.Format = "  {Count} Records.";
            gridSummaryColumnDescriptor.Name = "SummaryColumn";
            gridSummaryColumnDescriptor.SummaryType = Syncfusion.Grouping.SummaryType.Count;
            parentToChildRelationDescriptor.ChildTableDescriptor.SummaryRows.Add(new GridSummaryRowDescriptor("SummaryRow", new Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor[] {
                gridSummaryColumnDescriptor}));


			this.gridGroupingControl1.TableControl.DpiAware = true;
			// Add relation to ParentTable 
			gridGroupingControl1.TableDescriptor.Relations.Add(parentToChildRelationDescriptor);

			GridRelationDescriptor childToGrandChildRelationDescriptor = new GridRelationDescriptor();
			childToGrandChildRelationDescriptor.ChildTableName = "MyGrandChildTable";  // same as SourceListSetEntry.Name for grandChhildTable (see below)
			childToGrandChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails;
			childToGrandChildRelationDescriptor.RelationKeys.Add("childID", "ChildID");

            //Add Summary row to GrandChildTable 
            gridSummaryColumnDescriptor = new GridSummaryColumnDescriptor();
            gridSummaryColumnDescriptor.DisplayColumn = "GrandChildGroupID";
            gridSummaryColumnDescriptor.Format = "  {Count} Records.";
            gridSummaryColumnDescriptor.Name = "SummaryColumn";
            gridSummaryColumnDescriptor.SummaryType = Syncfusion.Grouping.SummaryType.Count;
            childToGrandChildRelationDescriptor.ChildTableDescriptor.SummaryRows.Add(new GridSummaryRowDescriptor("SummaryRow", new GridSummaryColumnDescriptor[] {
                gridSummaryColumnDescriptor}));


			// Add relation to ChildTable 
			parentToChildRelationDescriptor.ChildTableDescriptor.Relations.Add(childToGrandChildRelationDescriptor);

			// Register any DataTable/IList with SourceListSet, so that RelationDescriptor can resolve the name
			this.gridGroupingControl1.Engine.SourceListSet.Add("MyParentTable", parentTable);
			this.gridGroupingControl1.Engine.SourceListSet.Add("MyChildTable", childTable);
			this.gridGroupingControl1.Engine.SourceListSet.Add("MyGrandChildTable", grandChildTable);

			this.gridGroupingControl1.DataSource = parentTable;
			this.gridGroupingControl1.ShowGroupDropArea = true;
			this.gridGroupingControl1.AddGroupDropArea("MyChildTable");
			this.gridGroupingControl1.AddGroupDropArea("MyGrandChildTable");


			//Sync the col width with nested table to avoid messing up of RecordPreviewCell

			// The TrackWidthOfParentColumn propetry of a column descriptor ensures that 
			// columns are aligned and stay in sync. 

			this.gridGroupingControl1.TableDescriptor.Columns[0].Width = 200;
			this.gridGroupingControl1.TableDescriptor.Columns[1].Width = 150;
			this.gridGroupingControl1.TableDescriptor.Columns[2].Width = 150;

			//// synchronize width of columns in child record with width of column in parent record.
			for(int n=0;n<3;n++)
			parentToChildRelationDescriptor.ChildTableDescriptor.Columns[n].TrackWidthOfParentColumn = gridGroupingControl1.TableDescriptor.Columns[n].Name;
			
			///same for grandchild table.
			for(int n=0;n<3;n++)
			childToGrandChildRelationDescriptor.ChildTableDescriptor.Columns[n].TrackWidthOfParentColumn = parentToChildRelationDescriptor.ChildTableDescriptor.Columns[n].Name;
            

            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("GroupID");
            this.gridGroupingControl1.TableOptions.ShowRecordPreviewRow = true;
            this.gridGroupingControl1.ChildGroupOptions.ShowGroupPreview = true;
            gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue;
            //this.gridGroupingControl1.TableDescriptor.Columns["GroupID"].Appearance.AnyHeaderCell.HorizontalAlignment = GridHorizontalAlignment.Right;
            //this.gridGroupingControl1.TableDescriptor.Columns["GroupID"].Appearance.AnyHeaderCell.VerticalAlignment = GridVerticalAlignment.Bottom;
            this.gridGroupingControl1.TableDescriptor.Columns["GroupID"].HeaderText = "Group ID";
            this.gridGroupingControl1.TableDescriptor.Columns["parentID"].HeaderText="Parent ID";
            this.gridGroupingControl1.TableDescriptor.Columns["ParentName"].HeaderText = "Parent Name";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Columns["childID"].HeaderText = "Child ID";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Columns["ChildGroupID"].HeaderText = "Child Group ID";

            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Relations[0].ChildTableDescriptor.Columns["GrandChildID"].HeaderText = "Grand Child ID";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Relations[0].ChildTableDescriptor.Columns["GrandChildGroupID"].HeaderText = "Grand Child Group ID";
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);

            #endregion

            this.comboBox1.Items.Add(ConverterOptions.Default);
            this.comboBox1.Items.Add(ConverterOptions.Visible);
            this.comboBox1.SelectedIndex = 0;
            this.checkBox2.Checked = true;
            this.checkBox3.Checked = true;
            this.checkBox5.Checked = true;
            this.checkBox6.Checked = true;
            this.colorPickerButton1.SelectedColor = Color.Empty;
            this.colorPickerButton2.SelectedColor = Color.Empty;
            this.comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        
    }
        #endregion

        #region "Sample Customization"

        #region Events

        //used to handle file
        private void button2_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Files(*.XLS)|*.XLS";
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".XLS";

            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.CheckPathExists)
            {
                GroupingGridExcelConverterControl converter = new GroupingGridExcelConverterControl();

                //Properties

                //ExportStyle
                if (checkBox1.Checked)
                {
                    //by default ExportStyle is true


                    converter.ExportBorders = this.checkBox4.Checked;
                }
                else
                    converter.ExportStyle = false;

                if (colorPickerButton1.SelectedColor != Color.Empty)
                    converter.HeaderBackColor = this.colorPickerButton1.SelectedColor;
                if (colorPickerButton2.SelectedColor != Color.Empty)
                    converter.CaptionBackColor = this.colorPickerButton2.SelectedColor;


                //by default ExportPreviewRows is false
                converter.ExportPreviewRows = this.checkBox2.Checked;

                converter.ExportGroupPlusMinus = this.checkBox5.Checked;
                converter.ExportRecordPlusMinus = this.checkBox6.Checked;

                //Hook QueryExportPreviewRowInfo event for non display elements.
                if (this.checkBox3.Checked)
                {
                    //must handle the QueryExportPreviewRowInfo event when the ConverterOptions is
                    //not Visible
                    converter.QueryExportPreviewRowInfo += new GroupingGridExcelConverterControl.GroupingGridExportPreviewRowQueryInfoEventHandler(converter_QueryExportPreviewRowInfo);
                }
                else
                {
                    converter.QueryExportPreviewRowInfo -= new GroupingGridExcelConverterControl.GroupingGridExportPreviewRowQueryInfoEventHandler(converter_QueryExportPreviewRowInfo);
                }

                ConverterOptions options = (ConverterOptions)this.comboBox1.SelectedItem;
                converter.GroupingGridToExcel(this.gridGroupingControl1, saveFileDialog.FileName,
                    options);
                converter.Dispose();
                if (MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.StartInfo.FileName = saveFileDialog.FileName;
                    proc.Start();
                }
            }
        }

        //set the custom styles to the recordelement
        void converter_QueryExportPreviewRowInfo(object sender, GroupingGridExportPreviewRowQueryInfoEventArgs e)
        {
            if (e.Element.Kind == DisplayElementKind.GroupPreview)
            {
                Element el = e.Element;
                e.Style.CellValue = "Preview notes for Group (" + el.ParentGroup.Name + ": " + el.ParentGroup.Category.ToString() + ")";
                e.Style.BackColor = Color.MistyRose;
                e.Handled = true;
            }
            if (e.Element.Kind == DisplayElementKind.RecordPreview)
            {

                Element el = e.Element;
                e.Style.CellValue = "Preview notes for Record (" + el.ParentTableDescriptor.Fields[0].Name + ": " + el.ParentRecord.GetValue(el.ParentTableDescriptor.Fields[0].Name) + ")";
                e.Style.BackColor = Color.MistyRose;
                e.Handled = true;
            }
        }

        //set the custom styles to the cells
        private void gridGroupingControl1_QueryCellStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventArgs e)
        {
            if (e.TableCellIdentity.TableCellType == GridTableCellType.RecordPreviewCell)
            {
                Element el = e.TableCellIdentity.DisplayElement;
                e.Style.CellValue = "Preview notes for Record (" + el.ParentTableDescriptor.Fields[0].Name + ": " + el.ParentRecord.GetValue(el.ParentTableDescriptor.Fields[0].Name) + ")";
            }
            if (e.TableCellIdentity.TableCellType == GridTableCellType.GroupPreviewCell)
            {
                Element el = e.TableCellIdentity.DisplayElement;
                e.Style.CellValue = "Preview notes for Group (" + el.ParentGroup.Name + ": " + el.ParentGroup.Category.ToString() + ")";
            }
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 1)
                this.checkBox3.Checked = false;
            else
                this.checkBox3.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.checkBox4.Enabled = true;
                this.checkBox4.Checked = true;
            }
            else
            {
                this.checkBox4.Checked = false;
                this.checkBox4.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.checkBox3.Enabled = true;
                if (comboBox1.SelectedIndex == 0)
                    this.checkBox3.Checked = true;
                else
                    this.checkBox3.Checked = false;
            }
            else
            {
                this.checkBox3.Checked = false;
                this.checkBox3.Enabled = false;
            }
        }

        #endregion

        #endregion

        #region DataTable
        private int numberParentRows = 50;
		private int numberChildRows = 200;
		private int numberGrandChildRows = 500;
		private DataTable GetParentTable()
		{
			DataTable dt = new DataTable("ParentTable");

			
			dt.Columns.Add(new DataColumn("parentID")); //lower case p
			dt.Columns.Add(new DataColumn("ParentName"));
			dt.Columns.Add(new DataColumn("GroupID"));

			Random r = new Random();
			for(int i = 0; i < numberParentRows; i++)
			{
				DataRow dr = dt.NewRow();
				dr[0] = i;//.ToString();
				dr[1] = string.Format("parentName{0}", i);
				dr[2] = r.Next(99,111);
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
			dt.Columns.Add(new DataColumn("ChildGroupID"));
			
			Random r = new Random();
			for(int i = 0; i < numberChildRows; i++)
			{
				DataRow dr = dt.NewRow();
				dr[0] = i.ToString();
				dr[1] = string.Format("ChildName{0}",i);
				dr[2] = (i % numberParentRows).ToString();
				dr[3] = r.Next(994,1006);
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
			dt.Columns.Add(new DataColumn("GrandChildGroupID"));
			
			Random r = new Random();
			for(int i = 0; i < numberGrandChildRows; i++)
			{
				DataRow dr = dt.NewRow();
				dr[0] = i.ToString();
				dr[1] = string.Format("GrandChildName{0}",i);
				dr[2] = (i % numberChildRows).ToString();
				dr[3] = r.Next(100,112);
				dt.Rows.Add(dr);
			}
			
			return dt;
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.checkBox2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox5 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox6 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(174, 28);
            this.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(36, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Export Grid";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(45, 26);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.DrawFocusRectangle = true;
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Export Grid Style";
            this.checkBox1.ThemesEnabled = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Converter Options: ";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(101, 21);
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Location = new System.Drawing.Point(122, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox2.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox2.DrawFocusRectangle = false;
            this.checkBox2.Location = new System.Drawing.Point(8, 98);
            this.checkBox2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(134, 30);
            this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox2.DrawFocusRectangle = true;
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "ExportPreviewRows";
            this.checkBox2.ThemesEnabled = false;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox3.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox3.DrawFocusRectangle = false;
            this.checkBox3.Location = new System.Drawing.Point(8, 134);
            this.checkBox3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(196, 34);
            this.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox3.DrawFocusRectangle = true;
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "Hook QueryExporPreviewRowInfo event handler.  ";
            this.checkBox3.ThemesEnabled = false;
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox4.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.DrawFocusRectangle = false;
            this.checkBox4.Location = new System.Drawing.Point(45, 53);
            this.checkBox4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(99, 17);
            this.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox4.DrawFocusRectangle = true;
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "Export Borders";
            this.checkBox4.ThemesEnabled = false;
            // 
            // checkBox5
            // 
            this.checkBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox5.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.DrawFocusRectangle = false;
            this.checkBox5.Location = new System.Drawing.Point(8, 67);
            this.checkBox5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(145, 25);
            this.checkBox5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox5.DrawFocusRectangle = true;
            this.checkBox5.TabIndex = 17;
            this.checkBox5.Text = "ExportGroupPlusMinus";
            this.checkBox5.ThemesEnabled = false;
            // 
            // checkBox6
            // 
            this.checkBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox6.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.DrawFocusRectangle = false;
            this.checkBox6.Location = new System.Drawing.Point(8, 35);
            this.checkBox6.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(148, 26);
            this.checkBox6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox6.DrawFocusRectangle = true;
            this.checkBox6.TabIndex = 16;
            this.checkBox6.Text = "ExportRecordPlusMinus";
            this.checkBox6.ThemesEnabled = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(751, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 631);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Location = new System.Drawing.Point(14, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 248);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other Options";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 53);
            this.label4.TabIndex = 17;
            this.label4.Text = "[ Handle this event when you want to export PreviewRow for non-display elements ]" +
    "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.colorPickerButton2);
            this.groupBox2.Controls.Add(this.colorPickerButton1);
            this.groupBox2.Location = new System.Drawing.Point(14, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 162);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export Style";
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.BackColor = System.Drawing.Color.DarkGray;
            this.colorPickerButton2.BeforeTouchSize = new System.Drawing.Size(126, 25);
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton2.IsBackStageButton = false;
            this.colorPickerButton2.Location = new System.Drawing.Point(45, 119);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedAsBackcolor = true;
            this.colorPickerButton2.SelectedColor = System.Drawing.Color.DarkGray;
            this.colorPickerButton2.Size = new System.Drawing.Size(126, 25);
            this.colorPickerButton2.TabIndex = 14;
            this.colorPickerButton2.Text = "Caption BackColor";
            this.colorPickerButton2.UseVisualStyleBackColor = false;
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.Gray;
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(126, 24);
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(45, 84);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.Gray;
            this.colorPickerButton1.Size = new System.Drawing.Size(126, 24);
            this.colorPickerButton1.TabIndex = 13;
            this.colorPickerButton1.Text = "Header BackColor";
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(162))))));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(10, 10);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(725, 632);
            this.gridGroupingControl1.TabIndex = 3;
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
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229))))));
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.VersionInfo = "4.401.0.51";
            this.gridGroupingControl1.QueryCellStyleInfo += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventHandler(this.gridGroupingControl1_QueryCellStyleInfo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridGroupingControl1);
            this.MinimumSize = new System.Drawing.Size(723, 620);
            this.Name = "Form1";
            this.Text = "Excel Export ";
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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

            #if FrameWork20 || FrameWork11
                Application.EnableVisualStyles();
            #endif
			Application.Run(new Form1());
		}

        #endregion       
    }
}
