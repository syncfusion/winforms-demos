#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
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
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.Controls;

using Syncfusion.SVG.IO;
using Syncfusion.Windows.Forms;
using System.Reflection;

namespace ExportImage
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Syncfusion.Windows.Forms.Diagram.Binding binding1 = new Syncfusion.Windows.Forms.Diagram.Binding();
            this.paletteGroupView1 = new Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupView(this.components);
            this.pdfdocument_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuExportImg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportSvg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportEmf = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBarButton_PropertyEditor = new System.Windows.Forms.ToolStripButton();
            this.toolBarButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolBarButton_Palette = new System.Windows.Forms.ToolStripButton();
            this.Model = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.menuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolBarButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolBarButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolBarButton8 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportAsImageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsSVGToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsEmfToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.contextMenu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Model)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            this.SuspendLayout();
            // 
            // paletteGroupView1
            // 
            this.paletteGroupView1.BeforeTouchSize = new System.Drawing.Size(140, 451);
            this.paletteGroupView1.ButtonView = true;
            this.paletteGroupView1.Diagram = null;
            this.paletteGroupView1.Location = new System.Drawing.Point(2, 24);
            this.paletteGroupView1.Name = "paletteGroupView1";
            this.paletteGroupView1.PaletteItemSize = new System.Drawing.Size(0, 0);
            this.paletteGroupView1.Size = new System.Drawing.Size(140, 451);
            this.paletteGroupView1.TabIndex = 0;
            this.paletteGroupView1.Text = "paletteGroupView1";
            // 
            // pdfdocument_menu
            // 
            this.pdfdocument_menu.Name = "pdfdocument_menu";
            this.pdfdocument_menu.Size = new System.Drawing.Size(32, 19);
            this.pdfdocument_menu.Text = "Export As PDF Document...";
            // 
            // menuItemFileExit
            // 
            this.menuItemFileExit.Name = "menuItemFileExit";
            this.menuItemFileExit.Size = new System.Drawing.Size(32, 19);
            this.menuItemFileExit.Text = "&Exit";
            // 
            // contextMenu2
            // 
            this.contextMenu2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExportImg,
            this.menuExportSvg,
            this.menuExportEmf});
            this.contextMenu2.Name = "contextMenu2";
            this.contextMenu2.Size = new System.Drawing.Size(228, 100);
            // 
            // menuExportImg
            // 
            this.menuExportImg.Name = "menuExportImg";
            this.menuExportImg.Size = new System.Drawing.Size(227, 32);
            this.menuExportImg.Text = "Export As Image...";
            this.menuExportImg.Click += new System.EventHandler(this.menuExportImg_Click);
            // 
            // menuExportSvg
            // 
            this.menuExportSvg.Name = "menuExportSvg";
            this.menuExportSvg.Size = new System.Drawing.Size(227, 32);
            this.menuExportSvg.Text = "Export As Svg...";
            this.menuExportSvg.Click += new System.EventHandler(this.menuExportSvg_Click);
            // 
            // menuExportEmf
            // 
            this.menuExportEmf.Name = "menuExportEmf";
            this.menuExportEmf.Size = new System.Drawing.Size(227, 32);
            this.menuExportEmf.Text = "Export As Emf...";
            this.menuExportEmf.Click += new System.EventHandler(this.menuExportEmf_Click);
            // 
            // menuExportPdf
            // 
            this.menuExportPdf.Name = "menuExportPdf";
            this.menuExportPdf.Size = new System.Drawing.Size(32, 19);
            this.menuExportPdf.Text = "Export As Pdf...";
            // 
            // menuItem3
            // 
            this.menuItem3.Name = "menuItem3";
            this.menuItem3.Size = new System.Drawing.Size(32, 19);
            this.menuItem3.Text = "-";
            // 
            // menuItem1
            // 
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(32, 19);
            this.menuItem1.Text = "-";
            // 
            // ToolBarButton_PropertyEditor
            // 
            this.ToolBarButton_PropertyEditor.Name = "ToolBarButton_PropertyEditor";
            this.ToolBarButton_PropertyEditor.Size = new System.Drawing.Size(23, 23);
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // ToolBarButton_Palette
            // 
            this.ToolBarButton_Palette.Name = "ToolBarButton_Palette";
            this.ToolBarButton_Palette.Size = new System.Drawing.Size(23, 23);
            // 
            // Model
            // 
            this.Model.AlignmentType = Syncfusion.Windows.Forms.Diagram.AlignmentType.SelectedNode;
            this.Model.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.Model.DocumentScale.DisplayName = "No Scale";
            this.Model.DocumentScale.Height = 1F;
            this.Model.DocumentScale.Width = 1F;
            this.Model.DocumentSize.Height = 1169F;
            this.Model.DocumentSize.Width = 827F;
            this.Model.LineStyle.DashPattern = null;
            this.Model.LineStyle.LineColor = System.Drawing.Color.Black;
            this.Model.LogicalSize = new System.Drawing.SizeF(827F, 1169F);
            this.Model.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Model.ShadowStyle.Color = System.Drawing.Color.DimGray;
            this.Model.ShadowStyle.ColorAlphaFactor = 255;
            this.Model.ShadowStyle.ForeColor = System.Drawing.Color.DimGray;
            this.Model.ShadowStyle.ForeColorAlphaFactor = 255;
            // 
            // menuItem2
            // 
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Size = new System.Drawing.Size(32, 19);
            this.menuItem2.Text = "&Exit";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Size = new System.Drawing.Size(23, 23);
            // 
            // menuItem4
            // 
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Size = new System.Drawing.Size(32, 19);
            this.menuItem4.Text = "Export As PDF Document...";
            // 
            // menuItem5
            // 
            this.menuItem5.Name = "menuItem5";
            this.menuItem5.Size = new System.Drawing.Size(32, 19);
            this.menuItem5.Text = "&File";
            // 
            // menuItem6
            // 
            this.menuItem6.Name = "menuItem6";
            this.menuItem6.Size = new System.Drawing.Size(32, 19);
            this.menuItem6.Text = "Export As Image...";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.Size = new System.Drawing.Size(23, 23);
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.Size = new System.Drawing.Size(23, 23);
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Size = new System.Drawing.Size(23, 23);
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.Name = "toolBarButton6";
            this.toolBarButton6.Size = new System.Drawing.Size(23, 23);
            // 
            // toolBarButton7
            // 
            this.toolBarButton7.Name = "toolBarButton7";
            this.toolBarButton7.Size = new System.Drawing.Size(23, 23);
            // 
            // toolBarButton8
            // 
            this.toolBarButton8.Name = "toolBarButton8";
            this.toolBarButton8.Size = new System.Drawing.Size(23, 23);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsImageToolStripMenuItem1,
            this.exportAsSVGToolStripMenuItem1,
            this.exportAsEmfToolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(702, 36);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportAsImageToolStripMenuItem1
            // 
            this.exportAsImageToolStripMenuItem1.Name = "exportAsImageToolStripMenuItem1";
            this.exportAsImageToolStripMenuItem1.Size = new System.Drawing.Size(143, 32);
            this.exportAsImageToolStripMenuItem1.Text = "Export as Image";
            this.exportAsImageToolStripMenuItem1.Click += new System.EventHandler(this.exportAsImageToolStripMenuItem1_Click);
            // 
            // exportAsSVGToolStripMenuItem1
            // 
            this.exportAsSVGToolStripMenuItem1.Name = "exportAsSVGToolStripMenuItem1";
            this.exportAsSVGToolStripMenuItem1.Size = new System.Drawing.Size(125, 32);
            this.exportAsSVGToolStripMenuItem1.Text = "Export as Svg";
            this.exportAsSVGToolStripMenuItem1.Click += new System.EventHandler(this.exportAsSVGToolStripMenuItem1_Click);
            // 
            // exportAsEmfToolStripMenuItem1
            // 
            this.exportAsEmfToolStripMenuItem1.Name = "exportAsEmfToolStripMenuItem1";
            this.exportAsEmfToolStripMenuItem1.Size = new System.Drawing.Size(127, 32);
            this.exportAsEmfToolStripMenuItem1.Text = "Export as Emf";
            this.exportAsEmfToolStripMenuItem1.Click += new System.EventHandler(this.exportAsEmfToolStripMenuItem1_Click);
            // 
            // diagram1
            // 
            this.diagram1.BackColor = System.Drawing.Color.Transparent;
            binding1.DefaultConnector = null;
            binding1.DefaultNode = null;
            binding1.Diagram = this.diagram1;
            binding1.Id = null;
            binding1.Label = ((System.Collections.Generic.List<string>)(resources.GetObject("binding1.Label")));
            binding1.ParentId = null;
            this.diagram1.Binding = binding1;
            this.diagram1.Controller.Constraint = Syncfusion.Windows.Forms.Diagram.Constraints.PageEditable;
            this.diagram1.Controller.DefaultConnectorTool = Syncfusion.Windows.Forms.Diagram.ConnectorTool.OrgLineConnectorTool;
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.EnableTouchMode = false;
            this.diagram1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2007;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(0, 36);
            this.diagram1.Margin = new System.Windows.Forms.Padding(0);
            this.diagram1.Model = null;
            this.diagram1.Name = "diagram1";
            this.diagram1.Office2007ScrollBars = true;
            this.diagram1.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.Size = new System.Drawing.Size(702, 627);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 157;
            this.diagram1.Text = "diagram1";
            // 
            // 
            // 
            this.diagram1.View.BackgroundColor = System.Drawing.Color.Transparent;
            this.diagram1.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram1.View.Controller = this.diagram1.Controller;
            this.diagram1.View.Grid.Color = System.Drawing.Color.White;
            this.diagram1.View.Grid.MinPixelSpacing = 4F;
            this.diagram1.View.PasteOffsetX = 0;
            this.diagram1.View.PasteOffsetY = 0;
            this.diagram1.View.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(702), (int)DpiAware.LogicalToDeviceUnits(663));
            this.Controls.Add(this.diagram1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Image";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenu2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Model)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void menuExportEmf_Click(object sender, EventArgs e)
        {
            ExportEmf();
        }

        void menuExportSvg_Click(object sender, EventArgs e)
        {
            ExportSvg();
        }

        void menuExportImg_Click(object sender, EventArgs e)
        {
            ExportImage();
        }
        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem pdfdocument_menu;
        private Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupView paletteGroupView1;
        private ToolStripMenuItem menuItem1;
        internal ToolStripButton ToolBarButton_PropertyEditor;
        private ToolStripButton toolBarButton1;
        internal ToolStripButton ToolBarButton_Palette;
        private Model Model;
        private ToolStripMenuItem menuItem2;
        private ToolStripButton toolBarButton2;
        private ToolStripMenuItem menuItem4;
        private ToolStripMenuItem menuItem5;
        private ToolStripMenuItem menuItem6;
        private ToolStripButton toolBarButton3;
        private ToolStripButton toolBarButton4;
        private ToolStripButton toolBarButton5;
        private ToolStripButton toolBarButton6;
        private ToolStripButton toolBarButton7;
        private ToolStripButton toolBarButton8;
        private ContextMenuStrip contextMenu2;
        private ToolStripMenuItem menuExportImg;
        private ToolStripMenuItem menuExportSvg;
        private ToolStripMenuItem menuExportPdf;
        private ToolStripMenuItem menuExportEmf;
        private MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem3;
        private ToolStripMenuItem exportAsImageToolStripMenuItem1;
        private ToolStripMenuItem exportAsSVGToolStripMenuItem1;
        private ToolStripMenuItem exportAsEmfToolStripMenuItem1;
        private Diagram diagram1;
    }
}