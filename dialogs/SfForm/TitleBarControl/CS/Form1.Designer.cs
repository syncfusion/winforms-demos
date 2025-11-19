#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.DataGrid.Enums;
using System.Drawing;
using System.Windows.Forms;

namespace TitleBarControl
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    partial class Form1
    {

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
            this.sfDataGrid1.Location = new System.Drawing.Point(28, 65);
            this.sfDataGrid1.Name = "sfDataGrid";
            this.sfDataGrid1.Size = new System.Drawing.Size(970, 540);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            this.sfDataGrid1.AutoGenerateColumns = true;
            this.sfDataGrid1.SearchController.AllowFiltering = true;
            this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(1024, 640);
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.sfDataGrid1);
            this.Name = "Form1";
            this.Style.Border.Color = ColorTranslator.FromHtml("#0AA2E6");
            this.Style.InactiveBorder.Color = ColorTranslator.FromHtml("#0AA2E6");
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximumSize = new System.Drawing.Size(1024, 640);
            this.MinimumSize = new System.Drawing.Size(1024, 640);
            this.Style.BackColor = System.Drawing.SystemColors.Window;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.IContainer components;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
    }
}

