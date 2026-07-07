using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace DragAndDrop
{
    partial class Form1
    {
        private IContainer components = null;
        private SfDataGrid sfDataGrid1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();

            // Set the window caption for the Drag and Drop sample
            this.Text = "Drag and Drop";

            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowFiltering = true;
            this.sfDataGrid1.Dock = DockStyle.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.sfDataGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid1.ShowGroupDropArea = true;
            this.sfDataGrid1.Size = new System.Drawing.Size(1512, 925);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // Enable drag-and-drop for rows and columns; allow the grid to accept drop targets
            this.sfDataGrid1.AllowDraggingRows = true;
            this.sfDataGrid1.AllowDraggingColumns = true;
            this.sfDataGrid1.AllowDrop = true;

            // Configure layout and selection behavior
            this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.SelectionMode = GridSelectionMode.Multiple;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1512, 925);
            this.Controls.Add(this.sfDataGrid1);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MinimumSize = new System.Drawing.Size(739, 585);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drag and Drop";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

