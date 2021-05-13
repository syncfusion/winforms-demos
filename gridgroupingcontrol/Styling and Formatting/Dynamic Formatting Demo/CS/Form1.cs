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
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace DynamicFormatting_GGC
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private DynamicFormatting_GGC.Dataset1 dataset11;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private PropertyGrid propertyGrid1;
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

            // Events : GridGroupingControl
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
            
            String commandstring = "select * from Orders";

            SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring, connString);
            try
            {
                da.Fill(dataset11, "Orders");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }

             #endregion

            this.gridGroupingControl1.QueryCellStyleInfo += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventHandler(gridGroupingControl1_QueryCellStyleInfo);

            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
			this.gridGroupingControl1.TableControl.DpiAware = true;

            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
			this.gridGroupingControl1.TableOptions.DefaultColumnWidth = (int)DpiAware.LogicalToDeviceUnits(154.0f);
            this.MetroColor = System.Drawing.Color.Transparent;

            // HeaderText
            this.gridGroupingControl1.TableDescriptor.Columns["ShipVia"].HeaderText = "Ship Via";
            this.gridGroupingControl1.TableDescriptor.Columns["CustomerID"].HeaderText = "Customer ID";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipRegion"].HeaderText = "Ship Region";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipPostalCode"].HeaderText = "Ship Postal Code";
            this.gridGroupingControl1.TableDescriptor.Columns["ShippedDate"].HeaderText = "Shipped Date";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipName"].HeaderText = "Ship Name";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipCountry"].HeaderText = "Ship Country";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipCity"].HeaderText = "Ship City";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipAddress"].HeaderText = "Ship Address";
            this.gridGroupingControl1.TableDescriptor.Columns["RequiredDate"].HeaderText = "Required Date";
            this.gridGroupingControl1.TableDescriptor.Columns["OrderID"].HeaderText = "Order ID";
            this.gridGroupingControl1.TableDescriptor.Columns["OrderDate"].HeaderText = "Order Date";
            this.gridGroupingControl1.TableDescriptor.Columns["EmployeeID"].HeaderText = "Employee ID";

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region "Sample Customized"

        private void SampleCustomization()
        {

            this.gridGroupingControl1.TableDescriptor.Columns["OrderDate"].HeaderText = "Order Date";
            this.gridGroupingControl1.TableDescriptor.Columns["RequiredDate"].HeaderText = "Required Date";
            this.gridGroupingControl1.TableDescriptor.Columns["ShippedDate"].HeaderText = "Shipped Date";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipName"].HeaderText = "Ship Name";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipPostalCode"].HeaderText = "Ship Postal Code";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipCountry"].HeaderText = "Ship Country";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipCity"].HeaderText = "Ship City";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipAddress"].HeaderText = "Ship Address";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipRegion"].HeaderText = "Ship Region";
        }

        #region "Events"
        /// <summary>
        /// QueryCellStyleInfo event : To Format Cell by Cell Basis on demand 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridGroupingControl1_QueryCellStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventArgs e)
        {
            if (e.Style.CellValueType != null && e.Style.CellValueType == typeof(DateTime))
            {
                e.Style.Format = "M/d/yyyy";
            }
            if (e.TableCellIdentity.TableCellType == GridTableCellType.RecordFieldCell)
            {
                if (e.TableCellIdentity.ColIndex % 2 == 0)
                {
                    e.Style.BackColor = Color.FromArgb(255, 187, 111);
                    e.Style.Font.FontStyle = FontStyle.Bold;
                }
                else
                {
                    e.Style.TextColor = Color.White;
                    e.Style.BackColor = Color.FromArgb(55, 91, 114);
                }
            }
            else if (e.TableCellIdentity.TableCellType == GridTableCellType.AlternateRecordFieldCell)
            {
                if (e.TableCellIdentity.ColIndex % 2 == 0)
                {
                    e.Style.Font.FontStyle = FontStyle.Underline;
                    e.Style.BackColor = Color.FromArgb(0, 21, 84);
                    e.Style.TextColor = Color.White;
                }
                else
                {
                    e.Style.BackColor = Color.FromArgb(255, 188, 112);
                    e.Style.Font.FontStyle = FontStyle.Italic;
                }
            }
        }

        #endregion

        #endregion

        #region "Designer Stuff"

        #region "Find File"

        /// <summary>
        /// Find the data file in specified location
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

        #region Error message

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

        // <summary>
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
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.dataset11 = new DynamicFormatting_GGC.Dataset1();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.DataSource = this.dataset11.Orders;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(12, 12);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(774, 629);
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
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229))))));
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.VersionInfo = "4.201.0.60";
            // 
            // dataset11
            // 
            this.dataset11.DataSetName = "Dataset1";
            this.dataset11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(796, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            this.propertyGrid1.Size = new System.Drawing.Size(203, 629);
            this.propertyGrid1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1012, 653);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.gridGroupingControl1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = " Dynamic Formating";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).EndInit();
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
