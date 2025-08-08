#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;

namespace ZoomAndPan
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
            this.zoomInToolStrip = new System.Windows.Forms.ToolStripButton();
            this.zoomOutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.resetToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 63);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStrip,
            this.zoomOutToolStripButton,
            this.panToolStripButton,
            this.resetToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(706), (int)DpiAware.LogicalToDeviceUnits(63));
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // zoomInToolStrip
            // 
            this.zoomInToolStrip.AutoSize = false;
            this.zoomInToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zoomInToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("zoomInToolStrip.Image")));
            this.zoomInToolStrip.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.zoomInToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.zoomInToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInToolStrip.Name = "zoomInToolStrip";
            this.zoomInToolStrip.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(70), (int)DpiAware.LogicalToDeviceUnits(55));
            this.zoomInToolStrip.Text = "ZoomIn";
            this.zoomInToolStrip.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.zoomInToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.zoomInToolStrip.Click += new System.EventHandler(this.zoomInToolStrip_Click);
            // 
            // zoomOutToolStripButton
            // 
            this.zoomOutToolStripButton.AutoSize = false;
            this.zoomOutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutToolStripButton.Image")));
            this.zoomOutToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.zoomOutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.zoomOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutToolStripButton.Name = "zoomOutToolStripButton";
            this.zoomOutToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(70), (int)DpiAware.LogicalToDeviceUnits(55));
            this.zoomOutToolStripButton.Text = "ZoomOut";
            this.zoomOutToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.zoomOutToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.zoomOutToolStripButton.Click += new System.EventHandler(this.zoomOutToolStripButton_Click);
            // 
            // panToolStripButton
            // 
            this.panToolStripButton.AutoSize = false;
            this.panToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("panToolStripButton.Image")));
            this.panToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.panToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.panToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.panToolStripButton.Name = "panToolStripButton";
            this.panToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(70), (int)DpiAware.LogicalToDeviceUnits(55));
            this.panToolStripButton.Text = "Pan";
            this.panToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.panToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.panToolStripButton.Click += new System.EventHandler(this.panToolStripButton_Click);
            // 
            // resetToolStripButton
            // 
            this.resetToolStripButton.AutoSize = false;
            this.resetToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.resetToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("resetToolStripButton.Image")));
            this.resetToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resetToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.resetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetToolStripButton.Name = "resetToolStripButton";
            this.resetToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(70), (int)DpiAware.LogicalToDeviceUnits(55));
            this.resetToolStripButton.Text = "Reset";
            this.resetToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.resetToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.resetToolStripButton.Click += new System.EventHandler(this.resetToolStripButton_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.diagram1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 599);
            this.panel2.TabIndex = 1;
            // 
            // diagram1
            // 
            this.diagram1.BackColor = System.Drawing.Color.White;
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.HScroll = true;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.MetroScrollBars = true;
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.Size = new System.Drawing.Size(706, 599);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 1;
            this.diagram1.Text = "diagram1";
            // 
            // 
            // 
            this.diagram1.View.BackgroundColor = System.Drawing.Color.LightGray;
            this.diagram1.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram1.View.Controller = this.diagram1.Controller;
            this.diagram1.View.Grid.MinPixelSpacing = 4F;
            this.diagram1.View.Grid.Visible = false;
            this.diagram1.View.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center;
            this.diagram1.VScroll = true;
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
            this.model1.LineStyle.LineColor = System.Drawing.Color.LightGray;
            this.model1.LogicalSize = new System.Drawing.SizeF(827F, 1169F);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
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
            this.ClientSize = new System.Drawing.Size(706, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZoomAndPan Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton zoomInToolStrip;
        private System.Windows.Forms.ToolStripButton zoomOutToolStripButton;
        private System.Windows.Forms.ImageList ImageList;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Syncfusion.Windows.Forms.Diagram.Model model1;
        private System.Windows.Forms.ToolStripButton resetToolStripButton;
        private System.Windows.Forms.ToolStripButton panToolStripButton;
    }
}

