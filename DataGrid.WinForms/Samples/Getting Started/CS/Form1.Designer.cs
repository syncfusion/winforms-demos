using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.Input.Enums;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GettingStarted
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // NumberFormatInfo
            // 
            numberFormat = Application.CurrentCulture.NumberFormat.Clone() as NumberFormatInfo;
            numberFormat.CurrencyDecimalDigits = 0;
            numberFormat.CurrencyGroupSizes = new int[] { };
            numberFormat = Application.CurrentCulture.NumberFormat.Clone() as NumberFormatInfo;
            numberFormat.NumberDecimalDigits = 0;
            numberFormat.NumberGroupSizes = new int[] { };
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.AllowDraggingColumns = true;
            this.sfDataGrid.AllowFiltering = true;
            this.sfDataGrid.AutoGenerateColumns = false;
            this.sfDataGrid.AllowResizingColumns = true;
            this.sfDataGrid.AllowResizingHiddenColumns = true;
            this.sfDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.sfDataGrid.BackColor = System.Drawing.SystemColors.Window;
            this.sfDataGrid.Location = new System.Drawing.Point(10, 5);
            this.sfDataGrid.Name = "sfDataGrid";
            this.sfDataGrid.ShowGroupDropArea = true;
			this.sfDataGrid.RowHeight = 21;
            this.sfDataGrid.Size = new System.Drawing.Size(990, 590);
            this.sfDataGrid.TabIndex = 1;
            this.sfDataGrid.Columns.Add(new GridCheckBoxColumn { MappingName = "Selected", HeaderText = "", AllowCheckBoxOnHeader = true, CheckBoxSize = new Size(13, 13) });
            this.sfDataGrid.Columns.Add(new GridImageColumn() { MappingName = "EmployeeName", HeaderText = "Employee Name", ImageLayout = ImageLayout.None });
            this.sfDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Designation", HeaderText = "Designation" });
            this.sfDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Mail", HeaderText = "Mail" });
            this.sfDataGrid.Columns.Add(new GridImageColumn() { MappingName = "Location", TextImageRelation = TextImageRelation.ImageBeforeText, Width = 100 });
            this.sfDataGrid.Columns.Add(new GridTextColumn { MappingName = "Status", HeaderText = "Status" });
            this.sfDataGrid.Columns.Add(new GridImageColumn() { MappingName = "Trustworthiness", HeaderText = "Trustworthiness" });
            this.sfDataGrid.Columns.Add(new GridImageColumn() { MappingName = "Rating", ImageLayout = ImageLayout.Center, Width = 80 });
            this.sfDataGrid.Columns.Add(new GridNumericColumn { MappingName = "Salary", HeaderText = "Salary", FormatMode = FormatMode.Currency, NumberFormatInfo = numberFormat });
            this.sfDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Address", HeaderText = "Address" });
            this.sfDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "SoftwareProficiency", HeaderText = "Software Proficiency", FormatMode = FormatMode.Percent });
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1006, 593);
            this.Controls.Add(this.sfDataGrid);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            this.ResumeLayout(false);           
        }

        #endregion

        #region API Definition
        private NumberFormatInfo numberFormat;
        private SfDataGrid sfDataGrid;
        
        #endregion
    }
}

