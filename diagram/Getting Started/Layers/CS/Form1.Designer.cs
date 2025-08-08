#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;

namespace LayerDemo
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
            this.chkEditingLyr = new System.Windows.Forms.CheckBox();
            this.apply = new System.Windows.Forms.Button();
            this.chkRemoveLyr = new System.Windows.Forms.CheckBox();
            this.txtLayerName = new System.Windows.Forms.TextBox();
            this.chkVisibleLyr = new System.Windows.Forms.CheckBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.comboLayers = new System.Windows.Forms.ComboBox();
            this.createLyr = new System.Windows.Forms.Button();
            this.chkEnableLyr = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEnableNewlayer = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundRectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.chkEditingLyr);
            this.panel1.Controls.Add(this.apply);
            this.panel1.Controls.Add(this.chkRemoveLyr);
            this.panel1.Controls.Add(this.txtLayerName);
            this.panel1.Controls.Add(this.chkVisibleLyr);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Controls.Add(this.comboLayers);
            this.panel1.Controls.Add(this.createLyr);
            this.panel1.Controls.Add(this.chkEnableLyr);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkEnableNewlayer);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 67);
            this.panel1.TabIndex = 0;
            // 
            // chkEditingLyr
            // 
            this.chkEditingLyr.AutoSize = true;
            this.chkEditingLyr.Checked = true;
            this.chkEditingLyr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEditingLyr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEditingLyr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditingLyr.Location = new System.Drawing.Point(564, 44);
            this.chkEditingLyr.Name = "chkEditingLyr";
            this.chkEditingLyr.Size = new System.Drawing.Size(60, 19);
            this.chkEditingLyr.TabIndex = 15;
            this.chkEditingLyr.Text = "Editing";
            this.chkEditingLyr.UseVisualStyleBackColor = true;
            // 
            // apply
            // 
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply.Location = new System.Drawing.Point(665, 8);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(83, 52);
            this.apply.TabIndex = 12;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // chkRemoveLyr
            // 
            this.chkRemoveLyr.AutoSize = true;
            this.chkRemoveLyr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRemoveLyr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemoveLyr.Location = new System.Drawing.Point(492, 44);
            this.chkRemoveLyr.Name = "chkRemoveLyr";
            this.chkRemoveLyr.Size = new System.Drawing.Size(66, 19);
            this.chkRemoveLyr.TabIndex = 14;
            this.chkRemoveLyr.Text = "Remove";
            this.chkRemoveLyr.UseVisualStyleBackColor = true;
            // 
            // txtLayerName
            // 
            this.txtLayerName.Location = new System.Drawing.Point(158, 11);
            this.txtLayerName.Name = "txtLayerName";
            this.txtLayerName.Size = new System.Drawing.Size(168, 20);
            this.txtLayerName.TabIndex = 9;
            // 
            // chkVisibleLyr
            // 
            this.chkVisibleLyr.AutoSize = true;
            this.chkVisibleLyr.Checked = true;
            this.chkVisibleLyr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisibleLyr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkVisibleLyr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVisibleLyr.Location = new System.Drawing.Point(422, 44);
            this.chkVisibleLyr.Name = "chkVisibleLyr";
            this.chkVisibleLyr.Size = new System.Drawing.Size(57, 19);
            this.chkVisibleLyr.TabIndex = 13;
            this.chkVisibleLyr.Text = "Visible";
            this.chkVisibleLyr.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.toolStrip2.Location = new System.Drawing.Point(329, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(7, 67);
            this.toolStrip2.TabIndex = 13;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 67);
            // 
            // comboLayers
            // 
            this.comboLayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLayers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLayers.FormattingEnabled = true;
            this.comboLayers.Items.AddRange(new object[] {
            "Rectangle Layer",
            "Ellipse Layer",
            "RoundRect Layer"});
            this.comboLayers.Location = new System.Drawing.Point(448, 12);
            this.comboLayers.Name = "comboLayers";
            this.comboLayers.Size = new System.Drawing.Size(145, 23);
            this.comboLayers.TabIndex = 13;
            // 
            // createLyr
            // 
            this.createLyr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createLyr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLyr.Location = new System.Drawing.Point(235, 40);
            this.createLyr.Name = "createLyr";
            this.createLyr.Size = new System.Drawing.Size(91, 23);
            this.createLyr.TabIndex = 2;
            this.createLyr.TabStop = false;
            this.createLyr.Text = "Add";
            this.createLyr.UseVisualStyleBackColor = true;
            this.createLyr.Click += new System.EventHandler(this.createLyr_Click);
            // 
            // chkEnableLyr
            // 
            this.chkEnableLyr.AutoSize = true;
            this.chkEnableLyr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEnableLyr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableLyr.Location = new System.Drawing.Point(343, 44);
            this.chkEnableLyr.Name = "chkEnableLyr";
            this.chkEnableLyr.Size = new System.Drawing.Size(58, 19);
            this.chkEnableLyr.TabIndex = 12;
            this.chkEnableLyr.Text = "Enable";
            this.chkEnableLyr.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Layers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Layer Name";
            // 
            // chkEnableNewlayer
            // 
            this.chkEnableNewlayer.AutoSize = true;
            this.chkEnableNewlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEnableNewlayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableNewlayer.Location = new System.Drawing.Point(158, 44);
            this.chkEnableNewlayer.Name = "chkEnableNewlayer";
            this.chkEnableNewlayer.Size = new System.Drawing.Size(58, 19);
            this.chkEnableNewlayer.TabIndex = 10;
            this.chkEnableNewlayer.Text = "Enable";
            this.chkEnableNewlayer.UseVisualStyleBackColor = true;
            this.chkEditingLyr.Enabled = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(67, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.AutoSize = false;
            this.newToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.newToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.roundRectToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.polygonToolStripMenuItem});
            this.newToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.ShowDropDownArrow = false;
            this.newToolStripButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(60), (int)DpiAware.LogicalToDeviceUnits(50));
            this.newToolStripButton.Text = "Shapes";
            this.newToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.rectangleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rectangleToolStripMenuItem.Image")));
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // roundRectToolStripMenuItem
            // 
            this.roundRectToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.roundRectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("roundRectToolStripMenuItem.Image")));
            this.roundRectToolStripMenuItem.Name = "roundRectToolStripMenuItem";
            this.roundRectToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.roundRectToolStripMenuItem.Text = "RoundRect";
            this.roundRectToolStripMenuItem.Click += new System.EventHandler(this.roundRectToolStripMenuItem_Click);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ellipseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ellipseToolStripMenuItem.Image")));
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.polygonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("polygonToolStripMenuItem.Image")));
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.polygonToolStripMenuItem.Text = "Polygon";
            this.polygonToolStripMenuItem.Click += new System.EventHandler(this.polygonToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 67);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.diagram1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 591);
            this.panel2.TabIndex = 1;
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
            this.diagram1.Size = new System.Drawing.Size(824, 591);
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
            this.model1.DocumentSize.Width = 827F;
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LineStyle.LineWidth = 0F;
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
            this.ClientSize = new System.Drawing.Size(824, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Layer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
        private System.Windows.Forms.Button createLyr;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox chkEnableNewlayer;
        private System.Windows.Forms.TextBox txtLayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboLayers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkVisibleLyr;
        private System.Windows.Forms.CheckBox chkEnableLyr;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.CheckBox chkRemoveLyr;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton newToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roundRectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Syncfusion.Windows.Forms.Diagram.Model model1;
        private System.Windows.Forms.CheckBox chkEditingLyr;
    }
}

