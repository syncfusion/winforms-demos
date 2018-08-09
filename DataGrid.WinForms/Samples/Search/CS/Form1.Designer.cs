using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System.ComponentModel;
using System.Drawing;

namespace Search
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
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AllowSorting = false;
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.Location = new System.Drawing.Point(10, 5);
            this.sfDataGrid1.Name = "sfDataGrid";
            this.sfDataGrid1.Size = new System.Drawing.Size(1005, 590);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            this.sfDataGrid1.SelectionMode = GridSelectionMode.Single;
            this.sfDataGrid1.AllowDeleting = true;
            this.sfDataGrid1.Style.ButtonStyle.BorderColor = new Pen(Brushes.Gray, 2);
            this.sfDataGrid1.Style.ButtonStyle.HoverBorderColor = new Pen(Brushes.Gray, 2);
            this.sfDataGrid1.Style.ButtonStyle.BackColor = Color.Red;
            this.sfDataGrid1.Style.ButtonStyle.TextColor = Color.White;
            this.sfDataGrid1.Style.ButtonStyle.HoverTextColor = Color.White;
            this.sfDataGrid1.Style.ButtonStyle.HoverBackColor = Color.Red;
            this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.CopyOption = CopyOptions.CopyData | CopyOptions.IncludeHeaders;
            // 
            // Form1
            // 
            this.Size = new System.Drawing.Size(1024, 640);
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.CenterToScreen();
            this.MinimumSize = new Size(500, 400);
            this.Controls.Add(this.sfDataGrid1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
    }
}