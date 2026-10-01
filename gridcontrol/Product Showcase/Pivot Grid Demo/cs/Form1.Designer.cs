#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;

namespace PrivotGridSample
{
    partial class Form1
    {        /// <summary>
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSchemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSchemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSchemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAppearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAppearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAppearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshCalculationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualStylesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freezeHeadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideRightPaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pivotGridControl1 = new PivotGridLibrary.PivotGridControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSchemaToolStripMenuItem,
            this.saveSchemaToolStripMenuItem,
            this.resetSchemaToolStripMenuItem,
            this.displayDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadSchemaToolStripMenuItem
            // 
            this.loadSchemaToolStripMenuItem.Name = "loadSchemaToolStripMenuItem";
            this.loadSchemaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.loadSchemaToolStripMenuItem.Text = "Load Schema";
            this.loadSchemaToolStripMenuItem.Click += new System.EventHandler(this.loadSchemaToolStripMenuItem_Click);
            // 
            // saveSchemaToolStripMenuItem
            // 
            this.saveSchemaToolStripMenuItem.Name = "saveSchemaToolStripMenuItem";
            this.saveSchemaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveSchemaToolStripMenuItem.Text = "Save Schema";
            this.saveSchemaToolStripMenuItem.Click += new System.EventHandler(this.saveSchemaToolStripMenuItem_Click);
            // 
            // resetSchemaToolStripMenuItem
            // 
            this.resetSchemaToolStripMenuItem.Name = "resetSchemaToolStripMenuItem";
            this.resetSchemaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.resetSchemaToolStripMenuItem.Text = "Reset Schema";
            this.resetSchemaToolStripMenuItem.Click += new System.EventHandler(this.resetSchemaToolStripMenuItem_Click);
            // 
            // displayDataToolStripMenuItem
            // 
            this.displayDataToolStripMenuItem.Name = "displayDataToolStripMenuItem";
            this.displayDataToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.displayDataToolStripMenuItem.Text = "Display  Data";
            this.displayDataToolStripMenuItem.Click += new System.EventHandler(this.displayDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.CheckOnClick = true;
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeAppearanceToolStripMenuItem,
            this.loadAppearanceToolStripMenuItem,
            this.saveAppearanceToolStripMenuItem,
            this.expandAllToolStripMenuItem,
            this.collapseAllToolStripMenuItem,
            this.refreshCalculationsToolStripMenuItem,
            this.showAllColorsToolStripMenuItem,
            this.visualStylesToolStripMenuItem,
            this.freezeHeadersToolStripMenuItem,
            this.hideRightPaneToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // changeAppearanceToolStripMenuItem
            // 
            this.changeAppearanceToolStripMenuItem.Name = "changeAppearanceToolStripMenuItem";
            this.changeAppearanceToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.changeAppearanceToolStripMenuItem.Text = "Change Appearance";
            this.changeAppearanceToolStripMenuItem.Click += new System.EventHandler(this.changeAppearanceToolStripMenuItem_Click);
            // 
            // loadAppearanceToolStripMenuItem
            // 
            this.loadAppearanceToolStripMenuItem.Name = "loadAppearanceToolStripMenuItem";
            this.loadAppearanceToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.loadAppearanceToolStripMenuItem.Text = "Load Appearance";
            this.loadAppearanceToolStripMenuItem.Click += new System.EventHandler(this.loadAppearanceToolStripMenuItem_Click);
            // 
            // saveAppearanceToolStripMenuItem
            // 
            this.saveAppearanceToolStripMenuItem.Name = "saveAppearanceToolStripMenuItem";
            this.saveAppearanceToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveAppearanceToolStripMenuItem.Text = "Save Appearance";
            this.saveAppearanceToolStripMenuItem.Click += new System.EventHandler(this.saveAppearanceToolStripMenuItem_Click);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.collapseAllToolStripMenuItem.Text = "Collapse All";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // refreshCalculationsToolStripMenuItem
            // 
            this.refreshCalculationsToolStripMenuItem.Name = "refreshCalculationsToolStripMenuItem";
            this.refreshCalculationsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.refreshCalculationsToolStripMenuItem.Text = "Refresh Calculations";
            this.refreshCalculationsToolStripMenuItem.Click += new System.EventHandler(this.refreshCalculationsToolStripMenuItem_Click);
            // 
            // showAllColorsToolStripMenuItem
            // 
            this.showAllColorsToolStripMenuItem.Name = "showAllColorsToolStripMenuItem";
            this.showAllColorsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.showAllColorsToolStripMenuItem.Text = "Show All Colors";
            this.showAllColorsToolStripMenuItem.Click += new System.EventHandler(this.showAllColorsToolStripMenuItem_Click);
            // 
            // visualStylesToolStripMenuItem
            // 
            this.visualStylesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.silverToolStripMenuItem,
            this.toolStripMenuItem2,
            this.systemToolStripMenuItem,
            this.noneToolStripMenuItem,
            this.metroToolStripMenuItem});
            this.visualStylesToolStripMenuItem.Name = "visualStylesToolStripMenuItem";
            this.visualStylesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.visualStylesToolStripMenuItem.Text = "VisualStyles";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.blackToolStripMenuItem.Text = "2007-Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Checked = true;
            this.blueToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.blueToolStripMenuItem.Text = "2007-Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // silverToolStripMenuItem
            // 
            this.silverToolStripMenuItem.Name = "silverToolStripMenuItem";
            this.silverToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.silverToolStripMenuItem.Text = "2007-Silver";
            this.silverToolStripMenuItem.Click += new System.EventHandler(this.silverToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem2.Text = "2003";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.systemToolStripMenuItem.Text = "System";
            this.systemToolStripMenuItem.Click += new System.EventHandler(this.systemToolStripMenuItem_Click);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.noneToolStripMenuItem.Text = "none";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // metroToolStripMenuItem
            // 
            this.metroToolStripMenuItem.Name = "metroToolStripMenuItem";
            this.metroToolStripMenuItem.ShowShortcutKeys = false;
            this.metroToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.metroToolStripMenuItem.Text = "Metro";
            this.metroToolStripMenuItem.Click += new System.EventHandler(this.metroToolStripMenuItem_Click);
            // 
            // freezeHeadersToolStripMenuItem
            // 
            this.freezeHeadersToolStripMenuItem.Checked = true;
            this.freezeHeadersToolStripMenuItem.CheckOnClick = true;
            this.freezeHeadersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.freezeHeadersToolStripMenuItem.Name = "freezeHeadersToolStripMenuItem";
            this.freezeHeadersToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.freezeHeadersToolStripMenuItem.Text = "Freeze Headers";
            this.freezeHeadersToolStripMenuItem.Click += new System.EventHandler(this.freezeHeadersToolStripMenuItem_Click);
            // 
            // hideRightPaneToolStripMenuItem
            // 
            this.hideRightPaneToolStripMenuItem.CheckOnClick = true;
            this.hideRightPaneToolStripMenuItem.Name = "hideRightPaneToolStripMenuItem";
            this.hideRightPaneToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.hideRightPaneToolStripMenuItem.Text = "Hide Right Pane";
            this.hideRightPaneToolStripMenuItem.Click += new System.EventHandler(this.hideRightPaneToolStripMenuItem_Click);
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.AllString = "(all)";
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.AutoSizeColumns = true;
            this.pivotGridControl1.BackColor = System.Drawing.SystemColors.Control;
            this.pivotGridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pivotGridControl1.DataSource = null;
            this.pivotGridControl1.DefaultComputationName = "Sum";
            this.pivotGridControl1.DefaultDescriptionFormat = "{0} of {1}";
            this.pivotGridControl1.FreezeHeaders = true;
            this.pivotGridControl1.GrandTotalString = "Grand Total";
            this.pivotGridControl1.LeftPanelHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.pivotGridControl1.LeftPanelWidth = (int)DpiAware.LogicalToDeviceUnits(90.0f);
            this.pivotGridControl1.Location = new System.Drawing.Point(24, 47);
            this.pivotGridControl1.MultipleString = "(multiple)";
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.ShowExpandButton = true;
            this.pivotGridControl1.Size = new System.Drawing.Size(976, 527);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.TotalString = "Total";
            // 
            // Form1
            //          
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 591);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;            
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pivot Grid ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PivotGridLibrary.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSchemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSchemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSchemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAppearanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAppearanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAppearanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshCalculationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualStylesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freezeHeadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideRightPaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metroToolStripMenuItem;
    }
}

