
#region Copyright Syncfusion Inc. 2001 - 2021
// Copyright Syncfusion Inc. 2001 - 2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Spreadsheet;
using System.Data;
using ImportDataTable.Model;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms.Spreadsheet.Helpers;
using System.Drawing;
using ImportDataTable.View;

namespace ImportDataTable
{
    partial class Form1 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private Spreadsheet spreadsheet;
        private Panel panel;
        private GroupBox export_groupbox;
        private Label descriptionLabel;
        private Label exportOptionLabel;
        private Label importOptionLabel;
        private ComboBox selectTableComboBox;
        private Button importbtn;
        private Button exportbtn;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SpreadsheetCopyPaste spreadsheetCopyPaste1 = new SpreadsheetCopyPaste();
            FormulaRangeSelectionController formulaRangeSelectionController1 = new FormulaRangeSelectionController();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spreadsheet = new Spreadsheet();
            this.panel = new Panel();
            this.exportbtn = new Button();
            this.export_groupbox = new GroupBox();
            this.descriptionLabel = new Label();
            this.exportOptionLabel = new Label();
            this.importOptionLabel = new Label();
            this.selectTableComboBox = new ComboBox();
            this.importbtn = new Button();
            this.panel.SuspendLayout();
            this.export_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // spreadsheet
            // 
            this.spreadsheet.AllowCellContextMenu = true;
            this.spreadsheet.AllowExtendRowColumnCount = true;
            this.spreadsheet.AllowFormulaRangeSelection = true;
            this.spreadsheet.AllowTabItemContextMenu = true;
            this.spreadsheet.AllowZooming = true;
            this.spreadsheet.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste1.DefaultPasteOption = PasteOptions.Paste;
            this.spreadsheet.CopyPaste = spreadsheetCopyPaste1;
            this.spreadsheet.DefaultColumnCount = 101;
            this.spreadsheet.DefaultRowCount = 101;
            this.spreadsheet.DisplayAlerts = true;
            this.spreadsheet.FileName = "Book14";
            this.spreadsheet.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            this.spreadsheet.FormulaRangeSelectionController = formulaRangeSelectionController1;
            this.spreadsheet.IsCustomTabItemContextMenuEnabled = false;
            this.spreadsheet.Location = new Point(0, 0);
            this.spreadsheet.Name = "spreadsheet";
            this.spreadsheet.SelectedTabIndex = 0;
            this.spreadsheet.SelectedTabItem = null;
            this.spreadsheet.ShowBusyIndicator = true;
            this.spreadsheet.Size = new Size(770, 636);
            this.spreadsheet.TabIndex = 0;
            this.spreadsheet.TabItemContextMenu = null;
            this.spreadsheet.WorkbookLoaded += Spreadsheet_WorkbookLoaded;
            // 
            // panel
            // 
            this.panel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.panel.BackColor = Color.White;
            this.panel.BorderStyle = BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.spreadsheet);
            this.panel.ForeColor = Color.DarkGray;
            this.panel.Location = new Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new Size(770, 636);
            this.panel.TabIndex = 4;
            // 
            // exportbtn
            // 
            this.exportbtn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.exportbtn.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.exportbtn.FlatStyle = FlatStyle.Flat;
            this.exportbtn.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.exportbtn.ForeColor = Color.White;
            this.exportbtn.Location = new Point(19, 230);
            this.exportbtn.Name = "exportbtn";
            this.exportbtn.Size = new Size(173, 35);
            this.exportbtn.TabIndex = 3;
            this.exportbtn.Text = "Export to DataTable";
            this.exportbtn.UseVisualStyleBackColor = false;
            this.exportbtn.Click += new System.EventHandler(this.exportbtn_Click_1);
            // 
            // export_groupbox
            // 
            this.export_groupbox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.export_groupbox.Controls.Add(this.descriptionLabel);
            this.export_groupbox.Controls.Add(this.exportOptionLabel);
            this.export_groupbox.Controls.Add(this.importOptionLabel);
            this.export_groupbox.Controls.Add(this.selectTableComboBox);
            this.export_groupbox.Controls.Add(this.importbtn);
            this.export_groupbox.Controls.Add(this.exportbtn);
            this.export_groupbox.Font = new Font("Calibri", 12F, FontStyle.Bold);
            this.export_groupbox.Location = new Point(777, 1);
            this.export_groupbox.Name = "export_groupbox";
            this.export_groupbox.Size = new Size(231, 635);
            this.export_groupbox.TabIndex = 3;
            this.export_groupbox.TabStop = false;
            this.export_groupbox.Text = "Import and Export Options";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new Point(10, 285);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new Size(219, 115);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "It will export the data from \r\nworksheet to DataTable\r\nand that will be set as an" +
    "\r\nitem source to the \r\nGridGrouping control.";
            // 
            // exportOptionLabel
            // 
            this.exportOptionLabel.AutoSize = true;
            this.exportOptionLabel.Font = new Font("Calibri", 11F, FontStyle.Bold);
            this.exportOptionLabel.Location = new Point(14, 196);
            this.exportOptionLabel.Name = "exportOptionLabel";
            this.exportOptionLabel.Size = new Size(166, 23);
            this.exportOptionLabel.TabIndex = 7;
            this.exportOptionLabel.Text = "Export to DataTable";
            // 
            // importOptionLabel
            // 
            this.importOptionLabel.AutoSize = true;
            this.importOptionLabel.Font = new Font("Calibri", 11F, FontStyle.Bold);
            this.importOptionLabel.Location = new Point(10, 53);
            this.importOptionLabel.Name = "importOptionLabel";
            this.importOptionLabel.Size = new Size(215, 23);
            this.importOptionLabel.TabIndex = 6;
            this.importOptionLabel.Text = "Select the Table to Import";
            // 
            // selectTableComboBox
            // 
            this.selectTableComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.selectTableComboBox.Font = new Font("Calibri", 11F);
            this.selectTableComboBox.FormattingEnabled = true;
            this.selectTableComboBox.Items.AddRange(new object[] {
            "Products Table",
            "Orders Table",
            "Customers Table"});
            this.selectTableComboBox.Location = new Point(19, 90);
            this.selectTableComboBox.SelectedIndex = 0;
            this.selectTableComboBox.Name = "selectTableComboBox";
            this.selectTableComboBox.Size = new Size(173, 30);
            this.selectTableComboBox.TabIndex = 5;
            // 
            // importbtn
            // 
            this.importbtn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.importbtn.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.importbtn.FlatStyle = FlatStyle.Flat;
            this.importbtn.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.importbtn.ForeColor = Color.White;
            this.importbtn.Location = new Point(19, 130);
            this.importbtn.Name = "importbtn";
            this.importbtn.Size = new Size(173, 35);
            this.importbtn.TabIndex = 4;
            this.importbtn.Text = "Import DataTable";
            this.importbtn.UseVisualStyleBackColor = false;
            this.importbtn.Click += new System.EventHandler(this.Importbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 17F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1012, 663);
            this.Controls.Add(this.export_groupbox);
            this.Controls.Add(this.panel);
            this.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new Size(1024, 720);
            this.Name = "Form1";
            this.Text = "Data Management";
            this.WindowState = FormWindowState.Maximized;
            this.panel.ResumeLayout(false);
            this.export_groupbox.ResumeLayout(false);
            this.export_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        /// <summary>
        /// Set the Products table when workbook loaded into the spreadsheet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Spreadsheet_WorkbookLoaded(object sender, WorkbookLoadedEventArgs args)
        {
            //Get the product Data table from the NorthWind datasource.
            DataTable datatable = Data.GetDataTable("Products");
            this.spreadsheet.ActiveSheet.ImportDataTable(datatable, true, 1, 1);
            this.spreadsheet.ActiveGrid.InvalidateCells();

            //AutoFit column width based on the imported data table's column width.
            for (int i = 1; i <= spreadsheet.ActiveSheet.UsedRange.LastColumn; i++)
            {
                spreadsheet.ActiveSheet.AutofitColumn(i);
                spreadsheet.ActiveGrid.SetColumnWidth(i, i, spreadsheet.ActiveSheet.GetColumnWidthInPixels(i));
            }
        }

        /// <summary>
        /// Import the selected DataTable in the spreadsheet control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Importbtn_Click(object sender, EventArgs e)
        {
            //Spreadsheet.Create(3);
            string SelectedItem = selectTableComboBox.SelectedItem.ToString();
            DataTable datatable;
            if (SelectedItem.Contains("Products"))
                datatable = Data.GetDataTable("Products");
            else if (SelectedItem.Contains("Orders"))
                datatable = Data.GetDataTable("Orders");
            else
                datatable = Data.GetDataTable("Customers");

            spreadsheet.ActiveSheet.ImportDataTable(datatable, true, 1, 1);
            for (int i = 1; i <= spreadsheet.ActiveSheet.UsedRange.LastColumn; i++)
            {
                spreadsheet.ActiveSheet.AutofitColumn(i);
                spreadsheet.ActiveGrid.SetColumnWidth(i, i, spreadsheet.ActiveSheet.GetColumnWidthInPixels(i));
            }
            spreadsheet.ActiveGrid.InvalidateCells();
        }

        /// <summary>
        /// Export the spreadsheet data in GridGroupingControl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportbtn_Click_1(object sender, EventArgs e)
        {
            if (spreadsheet != null)
            {
                IWorksheet sheet = spreadsheet.Workbook.Worksheets[0];
                IRange range = sheet.Range["A1:K50"];
                DataTable Dt = sheet.ExportDataTable(range, ExcelExportDataTableOptions.ColumnNames);
                GridView dgv = new GridView();
                dgv.gridGroupingControl.DataSource = Dt;
                dgv.ShowDialog();
            }
        }

        #endregion


    }
}

