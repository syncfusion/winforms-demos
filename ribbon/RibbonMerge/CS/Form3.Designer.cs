#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.Input.Enums;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace RibbonControlMerging
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.ViewToolStripEx = new Syncfusion.Windows.Forms.Tools.RibbonPanelMergeContainer();
            this.toolStripEx7 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.DataToolStripEx = new Syncfusion.Windows.Forms.Tools.RibbonPanelMergeContainer();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripEx3 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripEx4 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.HyperLinkBtn = new System.Windows.Forms.ToolStripButton();
            this.GroupBtn = new System.Windows.Forms.ToolStripButton();
            this.UngroupBtn = new System.Windows.Forms.ToolStripButton();
            this.DataBtn = new System.Windows.Forms.ToolStripButton();
            this.NameManagerBtn = new System.Windows.Forms.ToolStripButton();
            this.themesToolStripExt = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.NewCommentsBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteBtn = new System.Windows.Forms.ToolStripButton();
            this.SheetBtn = new System.Windows.Forms.ToolStripButton();
            this.WorkbookBtn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            this.ViewToolStripEx.SuspendLayout();
            this.toolStripEx7.SuspendLayout();
            this.DataToolStripEx.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            this.toolStripEx2.SuspendLayout();
            this.toolStripEx3.SuspendLayout();
            this.toolStripEx4.SuspendLayout();
            this.themesToolStripExt.SuspendLayout();
            this.SuspendLayout();
            // 
            // sfDataGrid
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.AllowDraggingColumns = true;
            this.sfDataGrid.AllowFiltering = true;
            this.sfDataGrid.AllowResizingColumns = true;
            this.sfDataGrid.AllowResizingHiddenColumns = true;
            this.sfDataGrid.AutoGenerateColumns = false;
            this.sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.sfDataGrid.BackColor = System.Drawing.SystemColors.Window;
            this.sfDataGrid.Location = new System.Drawing.Point(0, 55);
            this.sfDataGrid.Name = "sfDataGrid";
            this.sfDataGrid.RowHeight = 21;
            this.sfDataGrid.Size = new System.Drawing.Size(990, 499);
            this.sfDataGrid.TabIndex = 1;
            // 
            // ViewToolStripEx
            // 
            this.ViewToolStripEx.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Center;
            this.ViewToolStripEx.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            this.ViewToolStripEx.Controls.Add(this.themesToolStripExt);
            this.ViewToolStripEx.Controls.Add(this.toolStripEx7);
            this.ViewToolStripEx.Location = new System.Drawing.Point(513, 10);
            this.ViewToolStripEx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ViewToolStripEx.Name = "ViewToolStripEx";
            this.ViewToolStripEx.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue;
            this.ViewToolStripEx.ScrollPosition = 0;
            this.ViewToolStripEx.Size = new System.Drawing.Size(292, 68);
            this.ViewToolStripEx.TabIndex = 2;
            this.ViewToolStripEx.Text = "VIEW";
            // 
            // toolStripEx7
            // 
            this.toolStripEx7.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx7.Image = null;
            this.toolStripEx7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SheetBtn,
            this.WorkbookBtn});
            this.toolStripEx7.Location = new System.Drawing.Point(114, 1);
            this.toolStripEx7.Name = "toolStripEx7";
            this.toolStripEx7.Office12Mode = false;
            this.toolStripEx7.Size = new System.Drawing.Size(116, 66);
            this.toolStripEx7.TabIndex = 4;
            this.toolStripEx7.Text = "Sheets";
            // 
            // DataToolStripEx
            // 
            this.DataToolStripEx.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Center;
            this.DataToolStripEx.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            this.DataToolStripEx.Controls.Add(this.toolStripEx1);
            this.DataToolStripEx.Controls.Add(this.toolStripEx2);
            this.DataToolStripEx.Controls.Add(this.toolStripEx3);
            this.DataToolStripEx.Controls.Add(this.toolStripEx4);
            this.DataToolStripEx.Location = new System.Drawing.Point(102, 9);
            this.DataToolStripEx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DataToolStripEx.Name = "DataToolStripEx";
            this.DataToolStripEx.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue;
            this.DataToolStripEx.ScrollPosition = 0;
            this.DataToolStripEx.Size = new System.Drawing.Size(259, 55);
            this.DataToolStripEx.TabIndex = 3;
            this.DataToolStripEx.Text = "DATA";
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HyperLinkBtn});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.Size = new System.Drawing.Size(65, 53);
            this.toolStripEx1.TabIndex = 7;
            this.toolStripEx1.Text = "Tables";
            // 
            // toolStripEx2
            // 
            this.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx2.Image = null;
            this.toolStripEx2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GroupBtn,
            this.UngroupBtn});
            this.toolStripEx2.Location = new System.Drawing.Point(67, 1);
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.Office12Mode = false;
            this.toolStripEx2.Size = new System.Drawing.Size(105, 53);
            this.toolStripEx2.TabIndex = 6;
            this.toolStripEx2.Text = "Outline";
            // 
            // toolStripEx3
            // 
            this.toolStripEx3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx3.Image = null;
            this.toolStripEx3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataBtn});
            this.toolStripEx3.Location = new System.Drawing.Point(174, 1);
            this.toolStripEx3.Name = "toolStripEx3";
            this.toolStripEx3.Office12Mode = false;
            this.toolStripEx3.Size = new System.Drawing.Size(38, 53);
            this.toolStripEx3.TabIndex = 5;
            this.toolStripEx3.Text = "Data";
            // 
            // toolStripEx4
            // 
            this.toolStripEx4.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx4.Image = null;
            this.toolStripEx4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameManagerBtn});
            this.toolStripEx4.Location = new System.Drawing.Point(214, 1);
            this.toolStripEx4.Name = "toolStripEx4";
            this.toolStripEx4.Office12Mode = false;
            this.toolStripEx4.Size = new System.Drawing.Size(34, 53);
            this.toolStripEx4.TabIndex = 4;
            this.toolStripEx4.Text = "Formulas";
            // 
            // HyperLinkBtn
            // 
            this.HyperLinkBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.HyperLinkBtn.Image = ((System.Drawing.Image)(resources.GetObject("HyperLinkBtn.Image")));
            this.HyperLinkBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HyperLinkBtn.Name = "HyperLinkBtn";
            this.HyperLinkBtn.Size = new System.Drawing.Size(62, 50);
            this.HyperLinkBtn.Text = "HyperLink";
            this.HyperLinkBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HyperLinkBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // GroupBtn
            // 
            this.GroupBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.GroupBtn.Image = ((System.Drawing.Image)(resources.GetObject("GroupBtn.Image")));
            this.GroupBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GroupBtn.Name = "GroupBtn";
            this.GroupBtn.Size = new System.Drawing.Size(44, 50);
            this.GroupBtn.Text = "Group";
            this.GroupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GroupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // UngroupBtn
            // 
            this.UngroupBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.UngroupBtn.Image = ((System.Drawing.Image)(resources.GetObject("UngroupBtn.Image")));
            this.UngroupBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UngroupBtn.Name = "UngroupBtn";
            this.UngroupBtn.Size = new System.Drawing.Size(58, 50);
            this.UngroupBtn.Text = "Ungroup";
            this.UngroupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UngroupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // DataBtn
            // 
            this.DataBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.DataBtn.Image = ((System.Drawing.Image)(resources.GetObject("DataBtn.Image")));
            this.DataBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DataBtn.Name = "DataBtn";
            this.DataBtn.Size = new System.Drawing.Size(35, 50);
            this.DataBtn.Text = "Data";
            this.DataBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DataBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // NameManagerBtn
            // 
            this.NameManagerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.NameManagerBtn.Image = ((System.Drawing.Image)(resources.GetObject("NameManagerBtn.Image")));
            this.NameManagerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NameManagerBtn.Name = "NameManagerBtn";
            this.NameManagerBtn.Size = new System.Drawing.Size(57, 46);
            this.NameManagerBtn.Text = "Name\r\nManager";
            this.NameManagerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NameManagerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // themesToolStripExt
            // 
            this.themesToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight;
            this.themesToolStripExt.Dock = System.Windows.Forms.DockStyle.None;
            this.themesToolStripExt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.themesToolStripExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.themesToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.themesToolStripExt.Image = ((System.Drawing.Image)(resources.GetObject("themesToolStripExt.Image")));
            this.themesToolStripExt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewCommentsBtn,
            this.DeleteBtn});
            this.themesToolStripExt.Location = new System.Drawing.Point(0, 1);
            this.themesToolStripExt.Name = "themesToolStripExt";
            this.themesToolStripExt.Office12Mode = false;
            this.themesToolStripExt.ShowLauncher = false;
            this.themesToolStripExt.Size = new System.Drawing.Size(112, 66);
            this.themesToolStripExt.TabIndex = 5;
            this.themesToolStripExt.Text = "Comments";
            // 
            // NewCommentsBtn
            // 
            this.NewCommentsBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCommentsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.NewCommentsBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewCommentsBtn.Image")));
            this.NewCommentsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewCommentsBtn.Name = "NewCommentsBtn";
            this.NewCommentsBtn.Size = new System.Drawing.Size(65, 63);
            this.NewCommentsBtn.Text = "New \r\nComments";
            this.NewCommentsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewCommentsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.DeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Image")));
            this.DeleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(44, 63);
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SheetBtn
            // 
            this.SheetBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SheetBtn.Image = ((System.Drawing.Image)(resources.GetObject("SheetBtn.Image")));
            this.SheetBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SheetBtn.Name = "SheetBtn";
            this.SheetBtn.Size = new System.Drawing.Size(47, 63);
            this.SheetBtn.Text = "Protect\r\nSheet";
            this.SheetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SheetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // WorkbookBtn
            // 
            this.WorkbookBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkbookBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.WorkbookBtn.Image = ((System.Drawing.Image)(resources.GetObject("WorkbookBtn.Image")));
            this.WorkbookBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WorkbookBtn.Name = "WorkbookBtn";
            this.WorkbookBtn.Size = new System.Drawing.Size(66, 63);
            this.WorkbookBtn.Text = "Protect\r\nWorkbook";
            this.WorkbookBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.WorkbookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Form3
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(990, 554);
            this.Controls.Add(this.DataToolStripEx);
            this.Controls.Add(this.ViewToolStripEx);
            this.Controls.Add(this.sfDataGrid);
            this.MetroColor = Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            this.ViewToolStripEx.ResumeLayout(false);
            this.ViewToolStripEx.PerformLayout();
            this.toolStripEx7.ResumeLayout(false);
            this.toolStripEx7.PerformLayout();
            this.DataToolStripEx.ResumeLayout(false);
            this.DataToolStripEx.PerformLayout();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.toolStripEx2.ResumeLayout(false);
            this.toolStripEx2.PerformLayout();
            this.toolStripEx3.ResumeLayout(false);
            this.toolStripEx3.PerformLayout();
            this.toolStripEx4.ResumeLayout(false);
            this.toolStripEx4.PerformLayout();
            this.themesToolStripExt.ResumeLayout(false);
            this.themesToolStripExt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region API Definition
        private SfDataGrid sfDataGrid;

        #endregion

        public Syncfusion.Windows.Forms.Tools.RibbonPanelMergeContainer ViewToolStripEx;
        public Syncfusion.Windows.Forms.Tools.ToolStripEx themesToolStripExt;
        public ToolStripButton NewCommentsBtn;
        public ToolStripButton DeleteBtn;
        public Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx7;
        public ToolStripButton SheetBtn;
        public ToolStripButton WorkbookBtn;
        public Syncfusion.Windows.Forms.Tools.RibbonPanelMergeContainer DataToolStripEx;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        public ToolStripButton HyperLinkBtn;
        public Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        public ToolStripButton GroupBtn;
        public ToolStripButton UngroupBtn;
        public Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx3;
        public ToolStripButton DataBtn;
        public Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx4;
        public ToolStripButton NameManagerBtn;
    }
}

