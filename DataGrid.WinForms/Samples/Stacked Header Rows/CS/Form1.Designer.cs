using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Styles;
using System.Drawing;
using System.Windows.Forms;

namespace StackedHeaderRows
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.AllowFiltering = true;
            this.sfDataGrid.AllowSorting = false;
            this.sfDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid.BackColor = System.Drawing.SystemColors.Window;
            this.sfDataGrid.Location = new System.Drawing.Point(10, 5);
            this.sfDataGrid.Name = "sfDataGrid";
            this.sfDataGrid.ShowGroupDropArea = true;
            this.sfDataGrid.Size = new System.Drawing.Size(990, 540);
            this.sfDataGrid.Style.StackedHeaderStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfDataGrid.TabIndex = 0;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.sfDataGrid);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stacked Headers";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        #region API Definition

        private SfDataGrid sfDataGrid;

        #endregion
    }
}

