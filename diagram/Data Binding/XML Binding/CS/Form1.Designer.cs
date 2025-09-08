#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;

namespace XMLBinding
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboXml = new System.Windows.Forms.ComboBox();
            this.lytProp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model2 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboXml);
            this.panel1.Controls.Add(this.lytProp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(1055), 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(10));
            this.panel1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(283), (int)DpiAware.LogicalToDeviceUnits(614));
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(13), (int)DpiAware.LogicalToDeviceUnits(50));
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(80), (int)DpiAware.LogicalToDeviceUnits(13));
            this.label2.TabIndex = 34;
            this.label2.Text = "Select XML file";
            // 
            // comboXml
            // 
            this.comboXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboXml.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboXml.FormattingEnabled = true;
            this.comboXml.Items.AddRange(new object[] {
            "XML File1",
            "XML FIle2"});
            this.comboXml.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(170), (int)DpiAware.LogicalToDeviceUnits(48));
            this.comboXml.Name = "comboXml";
            this.comboXml.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(100), (int)DpiAware.LogicalToDeviceUnits(21));
            this.comboXml.TabIndex = 35;
            this.comboXml.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // lytProp
            // 
            this.lytProp.AutoEllipsis = true;
            this.lytProp.BackColor = System.Drawing.Color.White;
            this.lytProp.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lytProp.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(13), (int)DpiAware.LogicalToDeviceUnits(9));
            this.lytProp.Name = "lytProp";
            this.lytProp.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(149), (int)DpiAware.LogicalToDeviceUnits(20));
            this.lytProp.TabIndex = 29;
            this.lytProp.Text = "Properties";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.diagram1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(1055), (int)DpiAware.LogicalToDeviceUnits(614));
            this.panel2.TabIndex = 9;
            // 
            // diagram1
            // 
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(DpiAware.LogicalToDeviceUnits(10F), DpiAware.LogicalToDeviceUnits(10F));
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.HScroll = true;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.MetroScrollBars = true;
            this.diagram1.Model = this.model2;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(1055), (int)DpiAware.LogicalToDeviceUnits(614));
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
            // model2
            // 
            this.model2.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model2.DocumentScale.DisplayName = "No Scale";
            this.model2.DocumentScale.Height = 1F;
            this.model2.DocumentScale.Width = 1F;
            this.model2.DocumentSize.Height = DpiAware.LogicalToDeviceUnits(1169F);
            this.model2.DocumentSize.Width = DpiAware.LogicalToDeviceUnits(1527F);
            this.model2.LineStyle.DashPattern = null;
            this.model2.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model2.LineStyle.LineWidth = 0F;
            this.model2.LogicalSize = new System.Drawing.SizeF(DpiAware.LogicalToDeviceUnits(1527F), DpiAware.LogicalToDeviceUnits(1169F));
            this.model2.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model2.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(DpiAware.LogicalToDeviceUnits(6F), DpiAware.LogicalToDeviceUnits(13F));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(1338), (int)DpiAware.LogicalToDeviceUnits(614));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML Binding";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lytProp;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Syncfusion.Windows.Forms.Diagram.Model model2;
        private System.Windows.Forms.ComboBox comboXml;
        private System.Windows.Forms.Label label2;
    }
    
}

