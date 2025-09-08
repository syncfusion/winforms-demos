#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;

namespace NodesDemo
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.rectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ellpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rrectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.polyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.semiStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.carcToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bmpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.textToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rchtxtToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.polylneToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.curveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.closdCurvToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.splineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bezierToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pencilToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.propertyEditor1 = new Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor(this.components);
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 62);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectToolStripButton,
            this.ellpToolStripButton,
            this.rrectToolStripButton,
            this.polyToolStripButton,
            this.semiStripButton12,
            this.carcToolStripButton,
            this.bmpToolStripButton,
            this.textToolStripButton,
            this.rchtxtToolStripButton,
            this.lineToolStripButton,
            this.polylneToolStripButton,
            this.curveToolStripButton,
            this.closdCurvToolStripButton,
            this.splineToolStripButton,
            this.bezierToolStripButton,
            this.pencilToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1028, 63);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += this.toolStrip1_ItemClicked;
            // 
            // rectToolStripButton
            // 
            this.rectToolStripButton.AutoSize = false;
            this.rectToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.rectToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rectToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("rectToolStripButton.Image")));
            this.rectToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rectToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectToolStripButton.Name = "rectToolStripButton";
            this.rectToolStripButton.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.rectToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(84), (int)DpiAware.LogicalToDeviceUnits(60));
            this.rectToolStripButton.Text = "Rectangle ";
            this.rectToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rectToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.rectToolStripButton.ToolTipText = "Rectangle Tool";
            this.rectToolStripButton.Click += new System.EventHandler(this.rectToolStripButton_Click);
            // 
            // ellpToolStripButton
            // 
            this.ellpToolStripButton.AutoSize = false;
            this.ellpToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ellpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ellpToolStripButton.Image")));
            this.ellpToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ellpToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ellpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellpToolStripButton.Name = "ellpToolStripButton";
            this.ellpToolStripButton.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.ellpToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(70), (int)DpiAware.LogicalToDeviceUnits(60));
            this.ellpToolStripButton.Text = "Ellipse ";
            this.ellpToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ellpToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ellpToolStripButton.ToolTipText = "Ellipse Tool";
            this.ellpToolStripButton.Click += new System.EventHandler(this.ellpToolStripButton_Click);
            // 
            // rrectToolStripButton
            // 
            this.rrectToolStripButton.AutoSize = false;
            this.rrectToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rrectToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("rrectToolStripButton.Image")));
            this.rrectToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rrectToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rrectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rrectToolStripButton.Name = "rrectToolStripButton";
            this.rrectToolStripButton.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.rrectToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(90), (int)DpiAware.LogicalToDeviceUnits(60));
            this.rrectToolStripButton.Text = "RoundRect";
            this.rrectToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rrectToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.rrectToolStripButton.ToolTipText = "RoundRect Tool";
            this.rrectToolStripButton.Click += new System.EventHandler(this.rrectToolStripButton_Click);
            // 
            // polyToolStripButton
            // 
            this.polyToolStripButton.AutoSize = false;
            this.polyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("polyToolStripButton.Image")));
            this.polyToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.polyToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.polyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.polyToolStripButton.Name = "polyToolStripButton";
            this.polyToolStripButton.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.polyToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(86), (int)DpiAware.LogicalToDeviceUnits(60));
            this.polyToolStripButton.Text = "Polygon ";
            this.polyToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.polyToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.polyToolStripButton.ToolTipText = "Polygon Tool";
            this.polyToolStripButton.Click += new System.EventHandler(this.polyToolStripButton_Click);
            // 
            // semiStripButton12
            // 
            this.semiStripButton12.AutoSize = false;
            this.semiStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("semiStripButton12.Image")));
            this.semiStripButton12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.semiStripButton12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.semiStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.semiStripButton12.Name = "semiStripButton12";
            this.semiStripButton12.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.semiStripButton12.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(80), (int)DpiAware.LogicalToDeviceUnits(60));
            this.semiStripButton12.Text = "SemiCircle";
            this.semiStripButton12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.semiStripButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.semiStripButton12.ToolTipText = "SemiCircle Tool";
            this.semiStripButton12.Click += new System.EventHandler(this.semiStripButton12_Click);
            // 
            // carcToolStripButton
            // 
            this.carcToolStripButton.AutoSize = false;
            this.carcToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("carcToolStripButton.Image")));
            this.carcToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.carcToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.carcToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.carcToolStripButton.Name = "carcToolStripButton";
            this.carcToolStripButton.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.carcToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(80), (int)DpiAware.LogicalToDeviceUnits(60));
            this.carcToolStripButton.Text = "CircularArc";
            this.carcToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.carcToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.carcToolStripButton.ToolTipText = "CircularArc Tool";
            this.carcToolStripButton.Click += new System.EventHandler(this.carcToolStripButton_Click);
            // 
            // bmpToolStripButton
            // 
            this.bmpToolStripButton.AutoSize = false;
            this.bmpToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bmpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("bmpToolStripButton.Image")));
            this.bmpToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bmpToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bmpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bmpToolStripButton.Name = "bmpToolStripButton";
            this.bmpToolStripButton.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.bmpToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(70), (int)DpiAware.LogicalToDeviceUnits(60));
            this.bmpToolStripButton.Text = "Bitmap";
            this.bmpToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bmpToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.bmpToolStripButton.ToolTipText = "Bitmap  Tool";
            this.bmpToolStripButton.Click += new System.EventHandler(this.bmpToolStripButton_Click);
            // 
            // textToolStripButton
            // 
            this.textToolStripButton.AutoSize = false;
            this.textToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.textToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("textToolStripButton.Image")));
            this.textToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.textToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.textToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textToolStripButton.Name = "textToolStripButton";
            this.textToolStripButton.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.textToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(75), (int)DpiAware.LogicalToDeviceUnits(60));
            this.textToolStripButton.Text = "TextTool";
            this.textToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.textToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.textToolStripButton.ToolTipText = "TextNode Tool";
            this.textToolStripButton.Click += new System.EventHandler(this.textToolStripButton_Click);
            // 
            // rchtxtToolStripButton
            // 
            this.rchtxtToolStripButton.AutoSize = false;
            this.rchtxtToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rchtxtToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("rchtxtToolStripButton.Image")));
            this.rchtxtToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rchtxtToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rchtxtToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rchtxtToolStripButton.Name = "rchtxtToolStripButton";
            this.rchtxtToolStripButton.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.rchtxtToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(95), (int)DpiAware.LogicalToDeviceUnits(60));
            this.rchtxtToolStripButton.Text = "RichTextTool";
            this.rchtxtToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rchtxtToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.rchtxtToolStripButton.ToolTipText = "RichText Tool";
            this.rchtxtToolStripButton.Click += new System.EventHandler(this.rchtxtToolStripButton_Click);
            // 
            // lineToolStripButton
            // 
            this.lineToolStripButton.AutoSize = false;
            this.lineToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("lineToolStripButton.Image")));
            this.lineToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lineToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineToolStripButton.Name = "lineToolStripButton";
            this.lineToolStripButton.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.lineToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(70), (int)DpiAware.LogicalToDeviceUnits(60));
            this.lineToolStripButton.Text = "Line ";
            this.lineToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lineToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.lineToolStripButton.ToolTipText = "Line Tool";
            this.lineToolStripButton.Click += new System.EventHandler(this.lineToolStripButton_Click);
            // 
            // polylneToolStripButton
            // 
            this.polylneToolStripButton.AutoSize = false;
            this.polylneToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.polylneToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("polylneToolStripButton.Image")));
            this.polylneToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.polylneToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.polylneToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.polylneToolStripButton.Name = "polylneToolStripButton";
            this.polylneToolStripButton.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.polylneToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(84), (int)DpiAware.LogicalToDeviceUnits(60));
            this.polylneToolStripButton.Text = "PolyLine ";
            this.polylneToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.polylneToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.polylneToolStripButton.ToolTipText = "PolyLine Tool";
            this.polylneToolStripButton.Click += new System.EventHandler(this.polylneToolStripButton_Click);
            // 
            // curveToolStripButton
            // 
            this.curveToolStripButton.AutoSize = false;
            this.curveToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.curveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("curveToolStripButton.Image")));
            this.curveToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.curveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.curveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.curveToolStripButton.Name = "curveToolStripButton";
            this.curveToolStripButton.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.curveToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(70), (int)DpiAware.LogicalToDeviceUnits(60));
            this.curveToolStripButton.Text = "Curve ";
            this.curveToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.curveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.curveToolStripButton.ToolTipText = "Curve Tool";
            this.curveToolStripButton.Click += new System.EventHandler(this.curveToolStripButton_Click);
            // 
            // closdCurvToolStripButton
            // 
            this.closdCurvToolStripButton.AutoSize = false;
            this.closdCurvToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.closdCurvToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closdCurvToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("closdCurvToolStripButton.Image")));
            this.closdCurvToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closdCurvToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.closdCurvToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closdCurvToolStripButton.Name = "closdCurvToolStripButton";
            this.closdCurvToolStripButton.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.closdCurvToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(90), (int)DpiAware.LogicalToDeviceUnits(60));
            this.closdCurvToolStripButton.Text = "ClosedCurve";
            this.closdCurvToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closdCurvToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.closdCurvToolStripButton.ToolTipText = "ClosedCurve tool";
            this.closdCurvToolStripButton.Click += new System.EventHandler(this.closdCurvToolStripButton_Click);
            // 
            // splineToolStripButton
            // 
            this.splineToolStripButton.AutoSize = false;
            this.splineToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.splineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("splineToolStripButton.Image")));
            this.splineToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.splineToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.splineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.splineToolStripButton.Name = "splineToolStripButton";
            this.splineToolStripButton.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.splineToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(90), (int)DpiAware.LogicalToDeviceUnits(60));
            this.splineToolStripButton.Text = "Spline ";
            this.splineToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.splineToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.splineToolStripButton.ToolTipText = "Spline Tool";
            this.splineToolStripButton.Click += new System.EventHandler(this.splineToolStripButton_Click);
            // 
            // bezierToolStripButton
            // 
            this.bezierToolStripButton.AutoSize = false;
            this.bezierToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.bezierToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("bezierToolStripButton.Image")));
            this.bezierToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bezierToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bezierToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bezierToolStripButton.Name = "bezierToolStripButton";
            this.bezierToolStripButton.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.bezierToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(90), (int)DpiAware.LogicalToDeviceUnits(60));
            this.bezierToolStripButton.Text = "Bezier ";
            this.bezierToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bezierToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.bezierToolStripButton.ToolTipText = "Bezier Tool";
            this.bezierToolStripButton.Click += new System.EventHandler(this.bezierToolStripButton_Click);
            // 
            // pencilToolStripButton
            // 
            this.pencilToolStripButton.AutoSize = false;
            this.pencilToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.pencilToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pencilToolStripButton.Image")));
            this.pencilToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pencilToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pencilToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pencilToolStripButton.Name = "pencilToolStripButton";
            this.pencilToolStripButton.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(20), 0, (int)DpiAware.LogicalToDeviceUnits(20), 0);
            this.pencilToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(90), (int)DpiAware.LogicalToDeviceUnits(60));
            this.pencilToolStripButton.Text = "PencilTool";
            this.pencilToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pencilToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.pencilToolStripButton.ToolTipText = "Bezier Tool";
            this.pencilToolStripButton.Click += new System.EventHandler(this.pencilToolStripButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.propertyEditor1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(779, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 547);
            this.panel2.TabIndex = 1;
            // 
            // propertyEditor1
            // 
            this.propertyEditor1.Diagram = this.diagram1;
            this.propertyEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyEditor1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyEditor1.Location = new System.Drawing.Point(0, 0);
            this.propertyEditor1.Name = "propertyEditor1";
            this.propertyEditor1.Size = new System.Drawing.Size(249, 547);
            this.propertyEditor1.TabIndex = 0;
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
            this.diagram1.Size = new System.Drawing.Size(779, 547);
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
            this.diagram1.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center;
            // 
            // model1
            // 
            this.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model1.DocumentScale.DisplayName = "No Scale";
            this.model1.DocumentScale.Height = 1F;
            this.model1.DocumentScale.Width = 1F;
            this.model1.DocumentSize.Height = 1169F;
            this.model1.DocumentSize.Width = 900F;
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LineStyle.LineWidth = 0F;
            this.model1.LogicalSize = new System.Drawing.SizeF(900F, 1169F);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.diagram1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 547);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nodes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton rrectToolStripButton;
        private System.Windows.Forms.ToolStripButton textToolStripButton;
        private System.Windows.Forms.ToolStripButton rchtxtToolStripButton;
        private System.Windows.Forms.ToolStripButton lineToolStripButton;
        private System.Windows.Forms.ToolStripButton polylneToolStripButton;
        private System.Windows.Forms.ToolStripButton curveToolStripButton;
        private System.Windows.Forms.ToolStripButton closdCurvToolStripButton;
        private System.Windows.Forms.ToolStripButton rectToolStripButton;
        private System.Windows.Forms.ToolStripButton ellpToolStripButton;
        private System.Windows.Forms.ToolStripButton polyToolStripButton;
        private System.Windows.Forms.ToolStripButton semiStripButton12;
        private System.Windows.Forms.ToolStripButton bmpToolStripButton;
        private System.Windows.Forms.ToolStripButton carcToolStripButton;
        private System.Windows.Forms.ToolStripButton splineToolStripButton;
        private System.Windows.Forms.ToolStripButton bezierToolStripButton;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor propertyEditor1;
        private System.Windows.Forms.Panel panel3;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Syncfusion.Windows.Forms.Diagram.Model model1;
        private System.Windows.Forms.ToolStripButton pencilToolStripButton;
    }
}

