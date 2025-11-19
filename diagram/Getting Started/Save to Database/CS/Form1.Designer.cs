#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;

namespace SaveDiagramAsBinary
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.connectorToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.lineConnectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directedLineConnectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orthogonalConnectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polylineConnectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezierConnectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splineConnectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboOpen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.paletteGroupBar1 = new Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paletteGroupBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Controls.Add(this.comboOpen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 60);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.toolStripSeparator1,
            this.connectorToolStripButton});
            this.toolStrip2.Location = new System.Drawing.Point(447, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(377, 60);
            this.toolStrip2.TabIndex = 14;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.AutoSize = false;
            this.openToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.openToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.openToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(70), (int)DpiAware.LogicalToDeviceUnits(60));
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.openToolStripButton.ToolTipText = "Open from Database";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // connectorToolStripButton
            // 
            this.connectorToolStripButton.AutoSize = false;
            this.connectorToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.connectorToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineConnectorToolStripMenuItem,
            this.directedLineConnectorToolStripMenuItem,
            this.orthogonalConnectorToolStripMenuItem,
            this.polylineConnectorToolStripMenuItem,
            this.bezierConnectorToolStripMenuItem,
            this.splineConnectorToolStripMenuItem});
            this.connectorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("connectorToolStripButton.Image")));
            this.connectorToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.connectorToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.connectorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connectorToolStripButton.Name = "connectorToolStripButton";
            this.connectorToolStripButton.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.connectorToolStripButton.ShowDropDownArrow = false;
            this.connectorToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(70), (int)DpiAware.LogicalToDeviceUnits(60));
            this.connectorToolStripButton.Text = "Connectors";
            this.connectorToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.connectorToolStripButton.DropDownItemClicked += connectorToolStripButton_DropDownItemClicked;
            this.connectorToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // lineConnectorToolStripMenuItem
            // 
            this.lineConnectorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.lineConnectorToolStripMenuItem.Name = "lineConnectorToolStripMenuItem";
            this.lineConnectorToolStripMenuItem.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(199), (int)DpiAware.LogicalToDeviceUnits(22));
            this.lineConnectorToolStripMenuItem.Text = "Line Connector";
            this.lineConnectorToolStripMenuItem.Click += new System.EventHandler(this.lineConnectorToolStripMenuItem_Click);
            // 
            // directedLineConnectorToolStripMenuItem
            // 
            this.directedLineConnectorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.directedLineConnectorToolStripMenuItem.Name = "directedLineConnectorToolStripMenuItem";
            this.directedLineConnectorToolStripMenuItem.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(199), (int)DpiAware.LogicalToDeviceUnits(22));
            this.directedLineConnectorToolStripMenuItem.Text = "DirectedLine Connector";
            this.directedLineConnectorToolStripMenuItem.Click += new System.EventHandler(this.directedLineConnectorToolStripMenuItem_Click);
            // 
            // orthogonalConnectorToolStripMenuItem
            // 
            this.orthogonalConnectorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.orthogonalConnectorToolStripMenuItem.Name = "orthogonalConnectorToolStripMenuItem";
            this.orthogonalConnectorToolStripMenuItem.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(199), (int)DpiAware.LogicalToDeviceUnits(22));
            this.orthogonalConnectorToolStripMenuItem.Text = "Orthogonal Connector";
            this.orthogonalConnectorToolStripMenuItem.Click += new System.EventHandler(this.orthogonalConnectorToolStripMenuItem_Click);
            // 
            // polylineConnectorToolStripMenuItem
            // 
            this.polylineConnectorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.polylineConnectorToolStripMenuItem.Name = "polylineConnectorToolStripMenuItem";
            this.polylineConnectorToolStripMenuItem.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(199), (int)DpiAware.LogicalToDeviceUnits(22));
            this.polylineConnectorToolStripMenuItem.Text = "Polyline Connector";
            this.polylineConnectorToolStripMenuItem.Click += new System.EventHandler(this.polylineConnectorToolStripMenuItem_Click);
            // 
            // bezierConnectorToolStripMenuItem
            // 
            this.bezierConnectorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.bezierConnectorToolStripMenuItem.Name = "bezierConnectorToolStripMenuItem";
            this.bezierConnectorToolStripMenuItem.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(199), (int)DpiAware.LogicalToDeviceUnits(22));
            this.bezierConnectorToolStripMenuItem.Text = "Bezier Connector";
            this.bezierConnectorToolStripMenuItem.Click += new System.EventHandler(this.bezierConnectorToolStripMenuItem_Click);
            // 
            // splineConnectorToolStripMenuItem
            // 
            this.splineConnectorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.splineConnectorToolStripMenuItem.Name = "splineConnectorToolStripMenuItem";
            this.splineConnectorToolStripMenuItem.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(199), (int)DpiAware.LogicalToDeviceUnits(22));
            this.splineConnectorToolStripMenuItem.Text = "Spline Connector";
            this.splineConnectorToolStripMenuItem.Click += new System.EventHandler(this.splineConnectorToolStripMenuItem_Click);
            // 
            // comboOpen
            // 
            this.comboOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOpen.FormattingEnabled = true;
            this.comboOpen.Items.AddRange(new object[] {
            "Rectangle Layer",
            "Ellipse Layer",
            "RoundRect Layer"});
            this.comboOpen.Location = new System.Drawing.Point(299, 12);
            this.comboOpen.Name = "comboOpen";
            this.comboOpen.Size = new System.Drawing.Size(145, 23);
            this.comboOpen.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Choose File";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(544, 60);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.AutoSize = false;
            this.newToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.newToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(70), (int)DpiAware.LogicalToDeviceUnits(60));
            this.newToolStripButton.Text = "New";
            this.newToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.AutoSize = false;
            this.saveToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.saveToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(70), (int)DpiAware.LogicalToDeviceUnits(60));
            this.saveToolStripButton.Text = "Save";
            this.saveToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.saveToolStripButton.ToolTipText = "Save to Database";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.AutoSize = false;
            this.deleteToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deleteToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(70), (int)DpiAware.LogicalToDeviceUnits(60));
            this.deleteToolStripButton.Text = "Delete";
            this.deleteToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.deleteToolStripButton.ToolTipText = "Delete from Database";
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 60);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 598);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.diagram1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(218, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(606, 598);
            this.panel4.TabIndex = 0;
            // 
            // diagram1
            // 
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.Size = new System.Drawing.Size(606, 598);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 0;
            this.diagram1.Text = "diagram1";
            // 
            // 
            // 
            this.diagram1.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram1.View.Controller = this.diagram1.Controller;
            this.diagram1.View.Grid.MinPixelSpacing = 4F;
            this.diagram1.View.Grid.Visible = false;
            this.diagram1.View.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            // 
            // model1
            // 
            this.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model1.DocumentScale.DisplayName = "No Scale";
            this.model1.DocumentScale.Height = 1F;
            this.model1.DocumentScale.Width = 1F;
            this.model1.DocumentSize.Height = 1169F;
            this.model1.DocumentSize.Width = 827F;
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LineStyle.LineWidth = 0F;
            this.model1.LogicalSize = new System.Drawing.SizeF(827F, 1169F);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.paletteGroupBar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 598);
            this.panel3.TabIndex = 0;
            // 
            // paletteGroupBar1
            // 
            this.paletteGroupBar1.AllowDrop = true;
            this.paletteGroupBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.paletteGroupBar1.BorderColor = System.Drawing.Color.White;
            this.paletteGroupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paletteGroupBar1.Diagram = null;
            this.paletteGroupBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paletteGroupBar1.EditMode = false;
            this.paletteGroupBar1.ExpandButtonToolTip = null;
            this.paletteGroupBar1.FlatLook = true;
            this.paletteGroupBar1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paletteGroupBar1.ForeColor = System.Drawing.Color.White;
            this.paletteGroupBar1.GroupBarDropDownToolTip = null;
            this.paletteGroupBar1.GroupBarItemHeight = 32;
            this.paletteGroupBar1.IndexOnVisibleItems = true;
            this.paletteGroupBar1.Location = new System.Drawing.Point(0, 0);
            this.paletteGroupBar1.MinimizeButtonToolTip = null;
            this.paletteGroupBar1.Name = "paletteGroupBar1";
            this.paletteGroupBar1.NavigationPaneTooltip = null;
            this.paletteGroupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.paletteGroupBar1.Size = new System.Drawing.Size(218, 598);
            this.paletteGroupBar1.TabIndex = 1;
            this.paletteGroupBar1.Text = "paletteGroupBar1";
            this.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save Diagram to DataBase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paletteGroupBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Syncfusion.Windows.Forms.Diagram.Model model1;
        private System.Windows.Forms.Panel panel3;
        private Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar paletteGroupBar1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton connectorToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem lineConnectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directedLineConnectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orthogonalConnectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polylineConnectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bezierConnectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splineConnectorToolStripMenuItem;
    }
}

