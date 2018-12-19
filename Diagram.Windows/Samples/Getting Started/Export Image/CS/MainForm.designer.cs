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
            this.paletteGroupView1 = new Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupView(this.components);
            this.pdfdocument_menu = new System.Windows.Forms.MenuItem();
            this.menuItemFileExit = new System.Windows.Forms.MenuItem();
            this.contextMenu2 = new System.Windows.Forms.ContextMenu();
            this.menuExportImg = new System.Windows.Forms.MenuItem();
            this.menuExportSvg = new System.Windows.Forms.MenuItem();
            this.menuExportEmf = new System.Windows.Forms.MenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuExportPdf = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.ToolBarButton_PropertyEditor = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton_Palette = new System.Windows.Forms.ToolBarButton();
            this.Model = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportAsImageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsSVGToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsEmfToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Model)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            this.SuspendLayout();
            // 
            // paletteGroupView1
            // 
            this.paletteGroupView1.ButtonView = true;
            this.paletteGroupView1.Diagram = null;
            this.paletteGroupView1.Location = new System.Drawing.Point(2, 24);
            this.paletteGroupView1.Name = "paletteGroupView1";
            this.paletteGroupView1.Size = new System.Drawing.Size(140, 451);
            this.paletteGroupView1.TabIndex = 0;
            this.paletteGroupView1.Text = "paletteGroupView1";
            // 
            // pdfdocument_menu
            // 
            this.pdfdocument_menu.Index = -1;
            this.pdfdocument_menu.Text = "Export As PDF Document...";
            // 
            // menuItemFileExit
            // 
            this.menuItemFileExit.Index = -1;
            this.menuItemFileExit.Text = "&Exit";
            // 
            // contextMenu2
            // 
            this.contextMenu2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuExportImg,
            this.menuExportSvg,
            this.menuExportEmf});
            // 
            // menuExportImg
            // 
            this.menuExportImg.Index = 0;
            this.menuExportImg.Text = "Export As Image...";
            this.menuExportImg.Click += new System.EventHandler(this.menuExportImg_Click);
            // 
            // menuExportSvg
            // 
            this.menuExportSvg.Index = 1;
            this.menuExportSvg.Text = "Export As Svg...";
            this.menuExportSvg.Click += new System.EventHandler(this.menuExportSvg_Click);
            // 
            // menuExportEmf
            // 
            this.menuExportEmf.Index = 2;
            this.menuExportEmf.Text = "Export As Emf...";
            this.menuExportEmf.Click += new System.EventHandler(this.menuExportEmf_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Fuchsia;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "palette_groupbar.png");
            this.imageList1.Images.SetKeyName(9, "property_editor.png");
            this.imageList1.Images.SetKeyName(10, "export.png");
            // 
            // menuExportPdf
            // 
            this.menuExportPdf.Index = -1;
            this.menuExportPdf.Text = "Export As Pdf...";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = -1;
            this.menuItem3.Text = "-";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = -1;
            this.menuItem1.Text = "-";
            // 
            // ToolBarButton_PropertyEditor
            // 
            this.ToolBarButton_PropertyEditor.Name = "ToolBarButton_PropertyEditor";
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            // 
            // ToolBarButton_Palette
            // 
            this.ToolBarButton_Palette.Name = "ToolBarButton_Palette";
            // 
            // Model
            // 
            this.Model.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.Model.DocumentScale.DisplayName = "No Scale";
            this.Model.DocumentScale.Height = 1F;
            this.Model.DocumentScale.Width = 1F;
            this.Model.DocumentSize.Height = 1169F;
            this.Model.DocumentSize.Width = 827F;
            this.Model.LineStyle.DashPattern = null;
            this.Model.LineStyle.LineColor = System.Drawing.Color.Black;
            this.Model.LogicalSize = new System.Drawing.SizeF(827F, 1169F);
            this.Model.ShadowStyle.Color = System.Drawing.Color.DimGray;
            this.Model.ShadowStyle.ColorAlphaFactor = 255;
            this.Model.ShadowStyle.ForeColor = System.Drawing.Color.DimGray;
            this.Model.ShadowStyle.ForeColorAlphaFactor = 255;
            // 
            // menuItem2
            // 
            this.menuItem2.Index = -1;
            this.menuItem2.Text = "&Exit";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = -1;
            this.menuItem4.Text = "Export As PDF Document...";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = -1;
            this.menuItem5.Text = "&File";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = -1;
            this.menuItem6.Text = "Export As Image...";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.Name = "toolBarButton3";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.Name = "toolBarButton4";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.Name = "toolBarButton5";
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.Name = "toolBarButton6";
            // 
            // toolBarButton7
            // 
            this.toolBarButton7.Name = "toolBarButton7";
            // 
            // toolBarButton8
            // 
            this.toolBarButton8.Name = "toolBarButton8";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsImageToolStripMenuItem1,
            this.exportAsSVGToolStripMenuItem1,
            this.exportAsEmfToolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 81);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportAsImageToolStripMenuItem1
            // 
            this.exportAsImageToolStripMenuItem1.Name = "exportAsImageToolStripMenuItem1";
            this.exportAsImageToolStripMenuItem1.Size = new System.Drawing.Size(121, 20);
            this.exportAsImageToolStripMenuItem1.Text = "Export as Image";
            this.exportAsImageToolStripMenuItem1.Click += new System.EventHandler(this.exportAsImageToolStripMenuItem1_Click);
            // 
            // exportAsSVGToolStripMenuItem1
            // 
            this.exportAsSVGToolStripMenuItem1.Name = "exportAsSVGToolStripMenuItem1";
            this.exportAsSVGToolStripMenuItem1.Size = new System.Drawing.Size(107, 20);
            this.exportAsSVGToolStripMenuItem1.Text = "Export as Svg";
            this.exportAsSVGToolStripMenuItem1.Click += new System.EventHandler(this.exportAsSVGToolStripMenuItem1_Click);
            // 
            // exportAsEmfToolStripMenuItem1
            // 
            this.exportAsEmfToolStripMenuItem1.Name = "exportAsEmfToolStripMenuItem1";
            this.exportAsEmfToolStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.exportAsEmfToolStripMenuItem1.Text = "Export as Emf";
            this.exportAsEmfToolStripMenuItem1.Click += new System.EventHandler(this.exportAsEmfToolStripMenuItem1_Click);
            // 
            // diagram1
            // 
            this.diagram1.BackColor = System.Drawing.Color.Transparent;
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2007;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(0, 105);
            this.diagram1.Margin = new System.Windows.Forms.Padding(0);
            this.diagram1.Model = null;
            this.diagram1.Name = "diagram1";
            this.diagram1.Office2007ScrollBars = true;
            this.diagram1.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("diagram1.ScrollVirtualBounds")));
            this.diagram1.Size = new System.Drawing.Size(702, 643);
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
            this.diagram1.View.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("resource.ScrollVirtualBounds")));
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 663);
            this.Controls.Add(this.diagram1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Image";
            this.Load += new System.EventHandler(this.MainForm_Load);
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

        private System.Windows.Forms.MenuItem menuItemFileExit;
        private System.Windows.Forms.MenuItem pdfdocument_menu;
        private Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupView paletteGroupView1;
        private ImageList imageList1;
        private MenuItem menuItem1;
        internal ToolBarButton ToolBarButton_PropertyEditor;
        private ToolBarButton toolBarButton1;
        internal ToolBarButton ToolBarButton_Palette;
        private Model Model;
        private MenuItem menuItem2;
        private ToolBarButton toolBarButton2;
        private MenuItem menuItem4;
        private MenuItem menuItem5;
        private MenuItem menuItem6;
        private ToolBarButton toolBarButton3;
        private ToolBarButton toolBarButton4;
        private ToolBarButton toolBarButton5;
        private ToolBarButton toolBarButton6;
        private ToolBarButton toolBarButton7;
        private ToolBarButton toolBarButton8;
        private ContextMenu contextMenu2;
        private MenuItem menuExportImg;
        private MenuItem menuExportSvg;
        private MenuItem menuExportPdf;
        private MenuItem menuExportEmf;
        private MenuStrip menuStrip1;
        private System.Windows.Forms.MenuItem menuItem3;
        private ToolStripMenuItem exportAsImageToolStripMenuItem1;
        private ToolStripMenuItem exportAsSVGToolStripMenuItem1;
        private ToolStripMenuItem exportAsEmfToolStripMenuItem1;
        private Diagram diagram1;
    }
}