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
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using DemoCommon.Grid;

namespace GroupingEngineEventsTracer
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
	public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.ButtonAdv button1;
		private Syncfusion.Windows.Forms.ButtonAdv button2;
		private Syncfusion.Windows.Forms.ButtonAdv button3;
		private GroupingEngineEventsTracer.Dataset1 dataset11;
        private Tracer tracer;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxAdv1;
        private IContainer components;
        private Panel panel2;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private Label label1;
        private ComboboxCells.EventTracer eventTracer1;
        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");

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
            this.SampleCustomization();
            this.GridSettings();
		}

        #endregion 

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {

            this.eventTracer1 = new ComboboxCells.EventTracer();
            

            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
			this.gridGroupingControl1.TableControl.DpiAware = true;

            // Header Text
            this.gridGroupingControl1.TableDescriptor.Columns["EmployeeID"].HeaderText = "Employee ID";
            this.gridGroupingControl1.TableDescriptor.Columns["LastName"].HeaderText = "Last Name";
            this.gridGroupingControl1.TableDescriptor.Columns["FirstName"].HeaderText = "First Name";
            this.gridGroupingControl1.TableDescriptor.Columns["TitleOfCourtesy"].HeaderText = "Title Of Courtesy";
            this.gridGroupingControl1.TableDescriptor.Columns["BirthDate"].HeaderText = "Birth Date";
            this.gridGroupingControl1.TableDescriptor.Columns["HireDate"].HeaderText = "Hire Date";
            this.gridGroupingControl1.TableDescriptor.Columns["HomePhone"].HeaderText = "Home Phone";
            this.gridGroupingControl1.TableDescriptor.Columns["ReportsTo"].HeaderText = "Reports To";
            this.gridGroupingControl1.TableDescriptor.Columns["PostalCode"].HeaderText = "Postal Code";
            this.gridGroupingControl1.TableDescriptor.Columns["PhotoPath"].HeaderText = "Photo Path";
            this.gridGroupingControl1.TableDescriptor.Columns["SmallPhoto"].HeaderText = "Small Photo";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipVia"].HeaderText = "Ship Via";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipRegion"].HeaderText = "Ship Region";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipPostalCode"].HeaderText = "Ship Postal Code";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShippedDate"].HeaderText = "Shipped Date";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipName"].HeaderText = "Ship Name";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipCountry"].HeaderText = "Ship Country";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipCity"].HeaderText = "Ship City";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipAddress"].HeaderText = "Ship Address";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["RequiredDate"].HeaderText = "Required Date";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["OrderID"].HeaderText = "Order ID";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["OrderDate"].HeaderText = "Order Date";

            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            eventTracer1.output.ControllerOptions = GridControllerOptions.All & (~GridControllerOptions.OleDataSource);

            eventTracer1.output.ResetVolatileData();
            eventTracer1.output.ColWidths[1] = 200;
            eventTracer1.output.ColWidths[2] = 1000;
            eventTracer1.output.GridVisualStyles = GridVisualStyles.Metro;
            eventTracer1.output.DefaultGridBorderStyle = GridBorderStyle.None;
            eventTracer1.output.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            GridStyleInfo style = eventTracer1.output.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Verdana";

            eventTracer1.output.RowHeights[0] = 0;
            eventTracer1.output.ColWidths[0] = 0;
            eventTracer1.output.RowCount = 0;
            eventTracer1.output.ColCount = 2;
            eventTracer1.output.ListBoxSelectionMode = SelectionMode.One;

            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            eventTracer1.output.QueryCellInfo += new GridQueryCellInfoEventHandler(Output_QueryCellInfo);
            eventTracer1.output.CurrentCellStartEditing += new CancelEventHandler(Output_CurrentCellStartEditing);
            this.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;

            #region
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.eventTracer1);
            this.panel2.Location = new System.Drawing.Point(1, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 148);
            this.panel2.TabIndex = 8;
            // 
            // eventTracer1
            // 
            this.eventTracer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventTracer1.Enabled = false;
            this.eventTracer1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTracer1.ForeColor = System.Drawing.Color.DimGray;
            this.eventTracer1.Location = new System.Drawing.Point(0, 0);
            this.eventTracer1.Name = "eventTracer1";
            this.eventTracer1.Size = new System.Drawing.Size(852, 146);
            this.eventTracer1.TabIndex = 12;
            tracer = new Tracer(this.gridGroupingControl1.Engine, eventTracer1);

            this.Controls.Add(this.panel2);
            #endregion
        }

        #endregion

        #region "Sample Customization"

        /// <summary>
        /// set the dataset to the GridGroupingControl using the adapter
        /// </summary>        
        private void SampleCustomization()
        {
            String commandstring1 = "select * from Employees";
            String commandstring2 = "select * from Orders";

            SqlCeDataAdapter da1 = new SqlCeDataAdapter(commandstring1, connString);
            SqlCeDataAdapter da2 = new SqlCeDataAdapter(commandstring2, connString);
            try
            {
                da1.Fill(dataset11, "Employees");
                da2.Fill(dataset11, "Orders");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }
        }       

        #region "Events"

        //set the celltype as static
        void Output_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            e.Style.CellType = "Static";
        }

        //disables the currentcell start editing
        void Output_CurrentCellStartEditing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        //handles the hook operations
        private void button1_Click(object sender, System.EventArgs e)
        {
            this.tracer.UnhookEngTableEvents();
            if (!this.checkBoxAdv1.Checked)
                this.tracer.HookEngEvents();
        }

        //handles the hook operations
        private void button2_Click(object sender, System.EventArgs e)
        {
            this.tracer.UnhookEngEvents();
            if (!this.checkBoxAdv1.Checked)
                this.tracer.HookEngTableEvents();
        }

        //clear the eventtracer 
        private void button3_Click(object sender, System.EventArgs e)
        {
            this.eventTracer1.clear();
        }

        //handles the unhook operations
        private void checkBoxAdv1_CheckStateChanged(object sender, System.EventArgs e)
        {
            if (this.checkBoxAdv1.Checked)
            {
                this.tracer.UnhookEngEvents();
                this.tracer.UnhookEngTableEvents();
            }
        }

        //enables or disables the eventtracer based on the boolean value
        private void checkBoxAdv1_CheckedChanged(object sender, EventArgs e)
        {
            this.eventTracer1.Enabled = !checkBoxAdv1.Checked;
        }
       
        #endregion

        #endregion

        #region "Desginer Stuffs"

        #region "FindFile"
        /// <summary>
        /// Find the file from the specified location
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
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
        /// Display the error message
        /// </summary>
        /// <param name="ex"></param>
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
            this.dataset11 = new GroupingEngineEventsTracer.Dataset1();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.checkBoxAdv1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataset11
            // 
            this.dataset11.DataSetName = "Dataset1";
            this.dataset11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(128, 23);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(4, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Engine Events";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(128, 23);
            this.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(4, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Engine.Table Events";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button3.BeforeTouchSize = new System.Drawing.Size(128, 23);
            this.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.IsBackStageButton = false;
            this.button3.Location = new System.Drawing.Point(4, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Clear Output Window";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.checkBoxAdv1);
            this.gradientPanel1.Controls.Add(this.button1);
            this.gradientPanel1.Controls.Add(this.button2);
            this.gradientPanel1.Controls.Add(this.button3);
            this.gradientPanel1.Location = new System.Drawing.Point(1292, 740);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(215, 256);
            this.gradientPanel1.TabIndex = 2;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxAdv1.Location = new System.Drawing.Point(28, 208);
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(165, 35);
            this.checkBoxAdv1.TabIndex = 6;
            this.checkBoxAdv1.Text = "Disable Tracing";
            this.checkBoxAdv1.UseVisualStyleBackColor = false;
            this.checkBoxAdv1.CheckedChanged += new System.EventHandler(this.checkBoxAdv1_CheckedChanged);
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gridGroupingControl1);
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1514, 711);
            this.panel1.TabIndex = 7;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridGroupingControl1.DataMember = "Employees";
            this.gridGroupingControl1.DataSource = this.dataset11;
            this.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font = new GridFontInfo(new Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font.Bold = true;
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.Location = new System.Drawing.Point(0, 0);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(1008, 461);
            this.gridGroupingControl1.TabIndex = 1;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.VersionInfo = "4.301.0.0";
           
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(18, 740);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Event Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 1015);
            this.MinimumSize = new System.Drawing.Size(850, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Grouping Engine Events";
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
