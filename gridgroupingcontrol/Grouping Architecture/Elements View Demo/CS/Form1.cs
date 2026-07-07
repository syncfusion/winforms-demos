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
using Syncfusion.Windows.Forms.Grid.Grouping;
using System.Text.RegularExpressions;

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
        private ComboboxCells.EventTracer eventTracer1;
        private Label label1;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
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
		}

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {

            #region "Data Source"

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

            #endregion
            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
			this.gridGroupingControl1.TableControl.DpiAware = true;

            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;


            this.eventTracer1 = new ComboboxCells.EventTracer();
            // 
            // eventTracer1
            // 
            this.eventTracer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventTracer1.Enabled = false;
            this.eventTracer1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTracer1.ForeColor = System.Drawing.Color.DimGray;
            this.eventTracer1.Location = new System.Drawing.Point(10, 32);
            this.eventTracer1.Name = "eventTracer1";
            this.eventTracer1.Size = new System.Drawing.Size(824, 166);
            this.eventTracer1.TabIndex = 13;
            this.panel2.Controls.Add(this.eventTracer1);
            eventTracer1.output.ControllerOptions = GridControllerOptions.All & (~GridControllerOptions.OleDataSource);

            eventTracer1.output.ResetVolatileData();
            eventTracer1.output.ColWidths[1] = 200;
            eventTracer1.output.ColWidths[2] = 1000;
            eventTracer1.output.GridVisualStyles = GridVisualStyles.Metro;
            eventTracer1.output.DefaultGridBorderStyle = GridBorderStyle.None;
            eventTracer1.output.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            GridStyleInfo style = eventTracer1.output.BaseStylesMap["Header"].StyleInfo;
            eventTracer1.output.RowHeights[0] = 0;
            eventTracer1.output.ColWidths[0] = 0;
            eventTracer1.output.RowCount = 0;
            eventTracer1.output.ColCount = 2;
            eventTracer1.output.ListBoxSelectionMode = SelectionMode.One;
            eventTracer1.output.QueryCellInfo += new GridQueryCellInfoEventHandler(Output_QueryCellInfo);
            eventTracer1.output.CurrentCellStartEditing += new CancelEventHandler(Output_CurrentCellStartEditing);

            tracer = new Tracer(this.gridGroupingControl1.Engine, eventTracer1);


            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
           
            #region HeaderText
            foreach (GridColumnDescriptor col in this.gridGroupingControl1.TableDescriptor.Columns)
            {
                Regex rex = new Regex(@"\p{Lu}");
                int index = rex.Match(col.MappingName.Substring(1)).Index;
                string name = "";
                while (index > 0)
                {
                    name += col.MappingName.Substring(0, index + 1) + " ";
                    string secondName = col.MappingName.Substring(index + 1);
                    index = rex.Match(secondName.Substring(1)).Index;
                    while (index > 0)
                    {
                        name += secondName.Substring(0, index + 1) + " ";
                        index = rex.Match(col.MappingName.Substring(name.Replace(" ", "").Length).Substring(1)).Index;
                    }
                }
                name += col.MappingName.Substring(name.Replace(" ", "").Length);
                col.HeaderText = name;
            }
            #endregion
        }

        #endregion

        #region "Sample Customized"

        #region Event
        /// <summary>
        /// Set the CellType as Static
        /// </summary>
        void Output_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            e.Style.CellType = "Static";
        }

        /// <summary>
        /// Cancel the Crrent Cell Start to Edit
        /// </summary>
        void Output_CurrentCellStartEditing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        /// <summary>
        /// Handling the Table Events
        /// </summary>
        private void button1_Click(object sender, System.EventArgs e)
        {
            this.tracer.UnhookEngTableEvents();
            if (!this.checkBoxAdv1.Checked)
                this.tracer.HookEngEvents();
        }

        /// <summary>
        /// Handled Table Events
        /// </summary>
        private void button2_Click(object sender, System.EventArgs e)
        {
            this.tracer.UnhookEngEvents();
            if (!this.checkBoxAdv1.Checked)
                this.tracer.HookEngTableEvents();
        }

        /// <summary>
        /// Clear the Event Tracer 
        /// </summary>
        private void button3_Click(object sender, System.EventArgs e)
        {
            this.eventTracer1.clear();
        }

        /// <summary>
        /// Table Events has been handled by check box
        /// </summary>
        private void checkBoxAdv1_CheckStateChanged(object sender, System.EventArgs e)
        {
            if (this.checkBoxAdv1.Checked)
            {
                this.tracer.UnhookEngEvents();
                this.tracer.UnhookEngTableEvents();
            }
        }

        /// <summary>
        /// Assigning the Event Tracer based on the check box state 
        /// </summary>
        private void checkBoxAdv1_CheckedChanged(object sender, EventArgs e)
        {
            this.eventTracer1.Enabled = !checkBoxAdv1.Checked;
        }

        #endregion

        #endregion

        #region Designer Stuff

        #region "Find Utility"

        /// <summary>
        /// Find the data file in specified location
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

        #region "Error Message"

        /// <summary>
        /// Display the error message
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
            this.panel2.SuspendLayout();
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
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(128, 23);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(12, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Engine Events";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(128, 23);
            this.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(12, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Engine.Table Events";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button3.BeforeTouchSize = new System.Drawing.Size(128, 23);
            this.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.IsBackStageButton = false;
            this.button3.Location = new System.Drawing.Point(12, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
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
            this.gradientPanel1.Location = new System.Drawing.Point(849, 443);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(149, 203);
            this.gradientPanel1.TabIndex = 6;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAdv1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxAdv1.Location = new System.Drawing.Point(19, 135);
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(110, 23);
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
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 640);
            this.panel1.TabIndex = 7;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridGroupingControl1.DataMember = "Employees";
            this.gridGroupingControl1.DataSource = this.dataset11;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font = new GridFontInfo(new Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font.Bold = true;
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(0, -1);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(999, 425);
            this.gridGroupingControl1.TabIndex = 1;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.VersionInfo = "4.301.0.0";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 203);
            this.panel2.TabIndex = 8;
           
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Event Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 653);
            this.MinimumSize = new System.Drawing.Size(850, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Elements View";
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
			Application.Run(new Form1());
		}

        #endregion
    }
}
