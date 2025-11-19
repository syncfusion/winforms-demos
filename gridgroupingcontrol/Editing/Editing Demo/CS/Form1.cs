#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using System.Data.OleDb;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using DemoCommon.Grid;

namespace Editing_GGC
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region API Definition
        private GridGroupingControl gridGroupingControl1;
        private Panel panel1;
        private GroupBox currentCellActivationBehaviourGroupBox;
        private RadioButtonAdv clickOnCellRadioButton;
        private RadioButtonAdv doubleClickOnCellRadioButton;
        private RadioButtonAdv noneClickRadioButton;
        private RadioButtonAdv selectAllRadioButton;
        private RadioButtonAdv positionCaretRadioButton;
        private RadioButtonAdv setCurrentRadioButton;
        private GroupBox editingGroupBox;
        private RadioButtonAdv allowEditingRadioButton;
        private RadioButtonAdv readOnlyRadioButton;
        private RadioButtonAdv browseOnlyRadioButton;
        private IContainer components;

        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
			if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
			}
            GridSettings();
        }
        #endregion                

        #region Grid Settings
        /// <summary>
        /// Grid Settings for better Look and Feel
        /// </summary>
        private void GridSettings()
        {
			this.gridGroupingControl1.TableControl.DpiAware = true;
            this.gridGroupingControl1.DataSource = CreateTable();
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
        }
        #endregion

        #region "Header Images"
        /// <summary>
        /// Getting image from the file
        /// </summary>
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }

        #endregion

        #region Designer Stuffs
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
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentCellActivationBehaviourGroupBox = new System.Windows.Forms.GroupBox();
            this.clickOnCellRadioButton = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.doubleClickOnCellRadioButton = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.noneClickRadioButton = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.selectAllRadioButton = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.positionCaretRadioButton = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.setCurrentRadioButton = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.editingGroupBox = new System.Windows.Forms.GroupBox();
            this.allowEditingRadioButton = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.readOnlyRadioButton = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.browseOnlyRadioButton = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.currentCellActivationBehaviourGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clickOnCellRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClickOnCellRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noneClickRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionCaretRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setCurrentRadioButton)).BeginInit();
            this.editingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allowEditingRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readOnlyRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseOnlyRadioButton)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(18, 5);
            this.gridGroupingControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridGroupingControl1.Size = new System.Drawing.Size(980, 787);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.TableDescriptor.AllowNew = false;
            this.gridGroupingControl1.TableDescriptor.TableOptions.CaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(29.0f);
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.TableOptions.ShowTableIndentAsCoveredRange = true;
            this.gridGroupingControl1.TableOptions.ShowTableRowHeaderAsCoveredRange = true;
            this.gridGroupingControl1.Text = "gridGroupingControl2";
            this.gridGroupingControl1.UseRightToLeftCompatibleTextBox = true;
            this.gridGroupingControl1.VersionInfo = "15.4460.0.17";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.currentCellActivationBehaviourGroupBox);
            this.panel1.Controls.Add(this.editingGroupBox);
            this.panel1.Location = new System.Drawing.Point(1019, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 937);
            this.panel1.TabIndex = 4;
            // 
            // currentCellActivationBehaviourGroupBox
            // 
            this.currentCellActivationBehaviourGroupBox.Controls.Add(this.clickOnCellRadioButton);
            this.currentCellActivationBehaviourGroupBox.Controls.Add(this.doubleClickOnCellRadioButton);
            this.currentCellActivationBehaviourGroupBox.Controls.Add(this.noneClickRadioButton);
            this.currentCellActivationBehaviourGroupBox.Controls.Add(this.selectAllRadioButton);
            this.currentCellActivationBehaviourGroupBox.Controls.Add(this.positionCaretRadioButton);
            this.currentCellActivationBehaviourGroupBox.Controls.Add(this.setCurrentRadioButton);
            this.currentCellActivationBehaviourGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCellActivationBehaviourGroupBox.Location = new System.Drawing.Point(3, 140);
            this.currentCellActivationBehaviourGroupBox.Name = "currentCellActivationBehaviourGroupBox";
            this.currentCellActivationBehaviourGroupBox.Size = new System.Drawing.Size(262, 274);
            this.currentCellActivationBehaviourGroupBox.TabIndex = 26;
            this.currentCellActivationBehaviourGroupBox.TabStop = false;
            this.currentCellActivationBehaviourGroupBox.Text = "CurrentCell Activation Behaviour";
            // 
            // clickOnCellRadioButton
            // 
            this.clickOnCellRadioButton.AutoSize = true;
            this.clickOnCellRadioButton.BeforeTouchSize = new System.Drawing.Size(132, 28);
            this.clickOnCellRadioButton.Checked = true;
            this.clickOnCellRadioButton.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.clickOnCellRadioButton.Location = new System.Drawing.Point(24, 60);
            this.clickOnCellRadioButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.clickOnCellRadioButton.Name = "clickOnCellRadioButton";
            this.clickOnCellRadioButton.Size = new System.Drawing.Size(132, 28);
            this.clickOnCellRadioButton.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.clickOnCellRadioButton.TabIndex = 6;
            this.clickOnCellRadioButton.Text = "Click On Cell";
            this.clickOnCellRadioButton.ThemesEnabled = false;
            this.clickOnCellRadioButton.CheckChanged += new System.EventHandler(this.CurrentCellActivation_CheckedChanged);
            // 
            // doubleClickOnCellRadioButton
            // 
            this.doubleClickOnCellRadioButton.AutoSize = true;
            this.doubleClickOnCellRadioButton.BeforeTouchSize = new System.Drawing.Size(195, 28);
            this.doubleClickOnCellRadioButton.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.doubleClickOnCellRadioButton.Location = new System.Drawing.Point(24, 94);
            this.doubleClickOnCellRadioButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.doubleClickOnCellRadioButton.Name = "doubleClickOnCellRadioButton";
            this.doubleClickOnCellRadioButton.Size = new System.Drawing.Size(195, 28);
            this.doubleClickOnCellRadioButton.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.doubleClickOnCellRadioButton.TabIndex = 7;
            this.doubleClickOnCellRadioButton.Text = "Double Click On Cell";
            this.doubleClickOnCellRadioButton.ThemesEnabled = false;
            this.doubleClickOnCellRadioButton.CheckChanged += new System.EventHandler(this.CurrentCellActivation_CheckedChanged);
            // 
            // noneClickRadioButton
            // 
            this.noneClickRadioButton.AutoSize = true;
            this.noneClickRadioButton.BeforeTouchSize = new System.Drawing.Size(77, 28);
            this.noneClickRadioButton.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.noneClickRadioButton.Location = new System.Drawing.Point(24, 128);
            this.noneClickRadioButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.noneClickRadioButton.Name = "noneClickRadioButton";
            this.noneClickRadioButton.Size = new System.Drawing.Size(77, 28);
            this.noneClickRadioButton.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.noneClickRadioButton.TabIndex = 8;
            this.noneClickRadioButton.Text = "None";
            this.noneClickRadioButton.ThemesEnabled = false;
            this.noneClickRadioButton.CheckChanged += new System.EventHandler(this.CurrentCellActivation_CheckedChanged);
            // 
            // selectAllRadioButton
            // 
            this.selectAllRadioButton.AutoSize = true;
            this.selectAllRadioButton.BeforeTouchSize = new System.Drawing.Size(105, 28);
            this.selectAllRadioButton.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.selectAllRadioButton.Location = new System.Drawing.Point(24, 162);
            this.selectAllRadioButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.selectAllRadioButton.Name = "selectAllRadioButton";
            this.selectAllRadioButton.Size = new System.Drawing.Size(105, 28);
            this.selectAllRadioButton.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.selectAllRadioButton.TabIndex = 9;
            this.selectAllRadioButton.Text = "Select All";
            this.selectAllRadioButton.ThemesEnabled = false;
            this.selectAllRadioButton.CheckChanged += new System.EventHandler(this.CurrentCellActivation_CheckedChanged);
            // 
            // positionCaretRadioButton
            // 
            this.positionCaretRadioButton.AutoSize = true;
            this.positionCaretRadioButton.BeforeTouchSize = new System.Drawing.Size(143, 28);
            this.positionCaretRadioButton.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.positionCaretRadioButton.Location = new System.Drawing.Point(24, 196);
            this.positionCaretRadioButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.positionCaretRadioButton.Name = "positionCaretRadioButton";
            this.positionCaretRadioButton.Size = new System.Drawing.Size(143, 28);
            this.positionCaretRadioButton.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.positionCaretRadioButton.TabIndex = 10;
            this.positionCaretRadioButton.Text = "Position Caret";
            this.positionCaretRadioButton.ThemesEnabled = false;
            this.positionCaretRadioButton.CheckChanged += new System.EventHandler(this.CurrentCellActivation_CheckedChanged);
            // 
            // setCurrentRadioButton
            // 
            this.setCurrentRadioButton.AutoSize = true;
            this.setCurrentRadioButton.BeforeTouchSize = new System.Drawing.Size(122, 28);
            this.setCurrentRadioButton.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.setCurrentRadioButton.Location = new System.Drawing.Point(24, 230);
            this.setCurrentRadioButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.setCurrentRadioButton.Name = "setCurrentRadioButton";
            this.setCurrentRadioButton.Size = new System.Drawing.Size(122, 28);
            this.setCurrentRadioButton.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.setCurrentRadioButton.TabIndex = 11;
            this.setCurrentRadioButton.Text = "Set Current";
            this.setCurrentRadioButton.ThemesEnabled = false;
            this.setCurrentRadioButton.CheckChanged += new System.EventHandler(this.CurrentCellActivation_CheckedChanged);
            // 
            // editingGroupBox
            // 
            this.editingGroupBox.Controls.Add(this.allowEditingRadioButton);
            this.editingGroupBox.Controls.Add(this.readOnlyRadioButton);
            this.editingGroupBox.Controls.Add(this.browseOnlyRadioButton);
            this.editingGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editingGroupBox.Location = new System.Drawing.Point(3, 0);
            this.editingGroupBox.Name = "editingGroupBox";
            this.editingGroupBox.Size = new System.Drawing.Size(262, 134);
            this.editingGroupBox.TabIndex = 25;
            this.editingGroupBox.TabStop = false;
            this.editingGroupBox.Text = "Editing";
            // 
            // allowEditingRadioButton
            // 
            this.allowEditingRadioButton.AutoSize = true;
            this.allowEditingRadioButton.BeforeTouchSize = new System.Drawing.Size(138, 28);
            this.allowEditingRadioButton.Checked = true;
            this.allowEditingRadioButton.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.allowEditingRadioButton.Location = new System.Drawing.Point(24, 30);
            this.allowEditingRadioButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.allowEditingRadioButton.Name = "allowEditingRadioButton";
            this.allowEditingRadioButton.Size = new System.Drawing.Size(138, 28);
            this.allowEditingRadioButton.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.allowEditingRadioButton.TabIndex = 4;
            this.allowEditingRadioButton.Text = "Allow Editing";
            this.allowEditingRadioButton.ThemesEnabled = false;
            this.allowEditingRadioButton.CheckChanged += new System.EventHandler(this.read_only_CheckedChanged);
            // 
            // readOnlyRadioButton
            // 
            this.readOnlyRadioButton.AutoSize = true;
            this.readOnlyRadioButton.BeforeTouchSize = new System.Drawing.Size(115, 28);
            this.readOnlyRadioButton.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.readOnlyRadioButton.Location = new System.Drawing.Point(24, 64);
            this.readOnlyRadioButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.readOnlyRadioButton.Name = "readOnlyRadioButton";
            this.readOnlyRadioButton.Size = new System.Drawing.Size(115, 28);
            this.readOnlyRadioButton.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.readOnlyRadioButton.TabIndex = 1;
            this.readOnlyRadioButton.Text = "Read Only";
            this.readOnlyRadioButton.ThemesEnabled = false;
            this.readOnlyRadioButton.CheckChanged += new System.EventHandler(this.read_only_CheckedChanged);
            // 
            // browseOnlyRadioButton
            // 
            this.browseOnlyRadioButton.AutoSize = true;
            this.browseOnlyRadioButton.BeforeTouchSize = new System.Drawing.Size(133, 28);
            this.browseOnlyRadioButton.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.browseOnlyRadioButton.Location = new System.Drawing.Point(24, 98);
            this.browseOnlyRadioButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.browseOnlyRadioButton.Name = "browseOnlyRadioButton";
            this.browseOnlyRadioButton.Size = new System.Drawing.Size(133, 28);
            this.browseOnlyRadioButton.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.browseOnlyRadioButton.TabIndex = 2;
            this.browseOnlyRadioButton.Text = "Browse Only";
            this.browseOnlyRadioButton.ThemesEnabled = false;
            this.browseOnlyRadioButton.CheckChanged += new System.EventHandler(this.read_only_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(1300, 797);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridGroupingControl1);
            this.MinimumSize = new System.Drawing.Size(1189, 876);
            this.Name = "Form1";
            this.Text = "Editing";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.currentCellActivationBehaviourGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clickOnCellRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClickOnCellRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noneClickRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionCaretRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setCurrentRadioButton)).EndInit();
            this.editingGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allowEditingRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readOnlyRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseOnlyRadioButton)).EndInit();
            this.ResumeLayout(false);

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

        #region "Create DataTable"          

        /// <summary>
        /// To create datasource for grid.
        /// </summary>
        /// <returns></returns>
        string[] name = new string[] { "John", "Peter", "Smith", "Jay", "Krish", "Mike" };
        string[] country = new string[] { "UK", "USA", "Pune", "India", "China", "England" };
        string[] city = new string[] { "Graz", "Resende", "Bruxelles", "Aires", "Rio de janeiro", "Campinas" };
        string[] shipcountry = new string[] { "Brazil", "Belgium", "Austria", "Argentina", "France", "Beiging" };
        DataTable table = new DataTable();
        Random randomNumber = new Random();

        private DataTable CreateTable()
        {

            table.Columns.Add("Name");
            table.Columns.Add("Id");
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Country");
            table.Columns.Add("Ship City");
            table.Columns.Add("Ship Country");
            table.Columns.Add("Freight", typeof(Int16));
            table.Columns.Add("Postal code");
            table.Columns.Add("Salary", typeof(Int16));
            table.Columns.Add("PF", typeof(Int16));
            table.Columns.Add("EMI", typeof(Int16));

            for (int l = 0; l < 100; l++)
            {
                DataRow row = table.NewRow();
                row[0] = name[randomNumber.Next(0, 5)];
                row[1] = "E" + randomNumber.Next(30);
                row[2] = new DateTime(2012, 5, 23);
                row[3] = country[randomNumber.Next(0, 5)];
                row[4] = city[randomNumber.Next(0, 5)];
                row[5] = shipcountry[randomNumber.Next(0, 5)];
                row[6] = randomNumber.Next(1000, 2000);
                row[7] = randomNumber.Next(10 + (randomNumber.Next(600000, 600100)));
                row[8] = randomNumber.Next(14000, 20000);
                row[9] = randomNumber.Next(randomNumber.Next(2000, 4000));
                row[10] = randomNumber.Next(300, 1000);
                table.Rows.Add(row);
            }
            return table;
        }
        #endregion

        private void read_only_CheckedChanged(object sender, EventArgs e)
        {
            this.gridGroupingControl1.TableDescriptor.AllowEdit = allowEditingRadioButton.Checked;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.ReadOnly = readOnlyRadioButton.Checked;
            this.gridGroupingControl1.BrowseOnly = browseOnlyRadioButton.Checked;
        }

        private void CurrentCellActivation_CheckedChanged(object sender, EventArgs e)
        {
            if (this.clickOnCellRadioButton.Checked)
                this.gridGroupingControl1.TableModel.Options.ActivateCurrentCellBehavior = GridCellActivateAction.ClickOnCell;
            else if (this.doubleClickOnCellRadioButton.Checked)
                this.gridGroupingControl1.TableModel.Options.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell;
            else if (this.noneClickRadioButton.Checked)
                this.gridGroupingControl1.TableModel.Options.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            else if (this.selectAllRadioButton.Checked)
                this.gridGroupingControl1.TableModel.Options.ActivateCurrentCellBehavior = GridCellActivateAction.SelectAll;
            else if (this.setCurrentRadioButton.Checked)
                this.gridGroupingControl1.TableModel.Options.ActivateCurrentCellBehavior = GridCellActivateAction.SetCurrent;
            else if (this.positionCaretRadioButton.Checked)
                this.gridGroupingControl1.TableModel.Options.ActivateCurrentCellBehavior = GridCellActivateAction.PositionCaret;

        }
    }
}
