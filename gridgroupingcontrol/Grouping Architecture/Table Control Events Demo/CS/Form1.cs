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
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Drawing;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace TableControlEvents
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private TableControlEvents.Dataset1 dataset11 = new Dataset1();
        private EngineEventTracer eventTracer;
        private System.Windows.Forms.Label label1;
        private IContainer components;
        private GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
        private Syncfusion.Windows.Forms.ButtonAdv button3;
        private Syncfusion.Windows.Forms.ButtonAdv button1;
        private Syncfusion.Windows.Forms.ButtonAdv button2;
        private Syncfusion.Windows.Forms.ButtonAdv button6;
        private Syncfusion.Windows.Forms.ButtonAdv button4;
        private Syncfusion.Windows.Forms.ButtonAdv button5;
        private Syncfusion.Windows.Forms.ButtonAdv button7;
        private ListBox Output;
        private GridGroupingControl gridGroupingControl1;
        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");

        #endregion

        #region "Constructor"

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

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
			this.gridGroupingControl1.TableControl.DpiAware = true;

            this.gridGroupingControl1.AllowProportionalColumnSizing = true;      

            //set the caption color
            this.MetroColor = System.Drawing.Color.Transparent;           
          
            this.gridGroupingControl1.DataMember = "Categories";
            this.gridGroupingControl1.DataSource = this.dataset11;
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.AddGroupDropArea("Categories");
            this.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana";
            this.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.TableDescriptor.Columns["CategoryID"].HeaderText = "Category ID";
            this.gridGroupingControl1.TableDescriptor.Columns["CategoryName"].HeaderText = "Category Name";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Columns["ProductName"].HeaderText = "Product Name";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Columns["ProductID"].HeaderText = "Product ID";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Columns["SupplierID"].HeaderText = "Supplier ID";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Columns["UnitPrice"].HeaderText = "Unit Price";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Columns["UnitsInStock"].HeaderText = "Units In Stock";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Columns["QuantityPerUnit"].HeaderText = "Quantity Per Unit";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Columns["UnitsOnOrder"].HeaderText = "Units On Order";
            this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Columns["ReorderLevel"].HeaderText = "Reorder Level";

            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(55.0f);

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
           
        }

        #endregion

        #region "Sample  Customization"
        /// <summary>
        /// Current cell tracing events and set the dataset to the GridGroupingControl
        /// </summary>
        private void SampleCustomization()
        {
            GridEngine eng = this.gridGroupingControl1.Engine;
            eventTracer = new EngineEventTracer(eng, this.Output);
            this.eventTracer.HookCurrentCellEvents();

            String commandstring1 = "select * from Categories";
            String commandstring2 = "select * from Products";

            SqlCeDataAdapter da1 = new SqlCeDataAdapter(commandstring1, connString);
            SqlCeDataAdapter da2 = new SqlCeDataAdapter(commandstring2, connString);
            try
            {
                da1.Fill(dataset11, "Categories");
                da2.Fill(dataset11, "Products");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }
        }

        #region "Events"

        //used to hook the cell events
        private void button1_Click(object sender, System.EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                this.eventTracer.UnHookEvents();
                this.eventTracer.HookCellEvents();
            }
        }

        //used to hook the tablestyle events
        private void button6_Click(object sender, System.EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                this.eventTracer.UnHookEvents();
                this.eventTracer.HookTableStyleEvents();
            }
        }

        //used to clear the items in the output window
        private void button7_Click(object sender, System.EventArgs e)
        {
            this.Output.Items.Clear();
        }

        //used to hook the current cell events
        private void button2_Click(object sender, System.EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                this.eventTracer.UnHookEvents();
                this.eventTracer.HookCurrentCellEvents();
            }
        }

        // //used to hook the Grid Control events
        private void button3_Click(object sender, System.EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                this.eventTracer.UnHookEvents();
                this.eventTracer.HookGridControlEvents();
            }
        }

        // used to hook the key events
        private void button4_Click(object sender, System.EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                this.eventTracer.UnHookEvents();
                this.eventTracer.HookKeyEvents();
            }
        }

        //used to hook the mouse events
        private void button5_Click(object sender, System.EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                this.eventTracer.UnHookEvents();
                this.eventTracer.HookMouseEvents();
            }
        }

        //used to handle the hooking events
        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox1.Checked)
                this.eventTracer.UnHookEvents();
            else
            {
                this.eventTracer.HookCellEvents();
                this.eventTracer.HookCurrentCellEvents();
                this.eventTracer.HookGridControlEvents();
                this.eventTracer.HookKeyEvents();
                this.eventTracer.HookMouseEvents();
                this.eventTracer.HookTableStyleEvents();
            }
        }
        
        #endregion
        
        #endregion

        #region "Designer Stuffs"

        #region FindFile
        /// <summary>
        /// Find the file from the specified location
        /// </summary>
        private static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Common\Data\" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return new FileInfo(fileName).FullName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return fileName;
        }
        #endregion

        #region "ShowErrorMessage" Method
        /// <summary>
        /// display the error message
        /// </summary>
        private static void ShowErrorMessage(SqlException ex)
        {
            if (ex.Number == 11001)
                MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 208)
                MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 156 || ex.Number == 102)
                MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
        
        #region "Dispose"
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button6 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button7 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Output = new System.Windows.Forms.ListBox();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(10, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Event Log";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(806, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 635);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Events";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(49, 331);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.DrawFocusRectangle = true;
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Disable Tracing";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button3.BeforeTouchSize = new System.Drawing.Size(130, 25);
            this.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.IsBackStageButton = false;
            this.button3.Location = new System.Drawing.Point(23, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 25);
            this.button3.TabIndex = 1;
            this.button3.Text = "Trace Grid Events";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(130, 25);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(23, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Trace Cell Events";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(130, 25);
            this.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(23, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Trace CurrentCell Events";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button6.BeforeTouchSize = new System.Drawing.Size(130, 25);
            this.button6.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.IsBackStageButton = false;
            this.button6.Location = new System.Drawing.Point(23, 248);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 25);
            this.button6.TabIndex = 7;
            this.button6.Text = "Trace TableStyle Events";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button4.BeforeTouchSize = new System.Drawing.Size(130, 25);
            this.button4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.IsBackStageButton = false;
            this.button4.Location = new System.Drawing.Point(23, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 25);
            this.button4.TabIndex = 5;
            this.button4.Text = "Trace Key Events";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button5.BeforeTouchSize = new System.Drawing.Size(130, 25);
            this.button5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.IsBackStageButton = false;
            this.button5.Location = new System.Drawing.Point(23, 211);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 25);
            this.button5.TabIndex = 6;
            this.button5.Text = "Trace Mouse Events";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button7.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button7.BeforeTouchSize = new System.Drawing.Size(130, 25);
            this.button7.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.IsBackStageButton = false;
            this.button7.Location = new System.Drawing.Point(23, 282);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 25);
            this.button7.TabIndex = 8;
            this.button7.Text = "Clear Output Window";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Output
            // 
            this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.Color.DimGray;
            this.Output.Location = new System.Drawing.Point(11, 476);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(775, 171);
            this.Output.TabIndex = 14;
            this.Output.TabStop = false;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(11, 12);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(775, 438);
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
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.VersionInfo = "4.301.0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 656);
            this.MinimumSize = new System.Drawing.Size(850, 570);
            this.Controls.Add(this.gridGroupingControl1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Table Control Events";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
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
       
    }		
}
 