#region Copyright Syncfusion Inc. 2001 - 2012
//
//  Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using Syncfusion.Licensing;

namespace Syncfusion.Windows.Forms.Diagram.Samples
{
    /// <summary>
    /// Main application for CustomSymbol sample.
    /// </summary>
    public class MainForm : Form
    {
        #region Members

        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private PropertyEditor propertyEditor1;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Model model1;
        #endregion

        #region Form controls

        private IContainer components;
        #endregion

        #region Class Initialize/Finalize methods
        /// <summary>
        /// 
        /// </summary>
        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.diagram1.Model = this.model1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Syncfusion.Windows.Forms.Diagram.Binding binding1 = new Syncfusion.Windows.Forms.Diagram.Binding();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.propertyEditor1 = new Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor(this.components);
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(754), (int)DpiAware.LogicalToDeviceUnits(25));
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(754), (int)DpiAware.LogicalToDeviceUnits(25));
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(92), (int)DpiAware.LogicalToDeviceUnits(22));
            this.toolStripButton2.Text = "Add Symbol";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(58), (int)DpiAware.LogicalToDeviceUnits(22));
            this.toolStripButton3.Text = "Clone";
            // 
            // propertyEditor1
            // 
            this.propertyEditor1.Diagram = this.diagram1;
            this.propertyEditor1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyEditor1.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(507), (int)DpiAware.LogicalToDeviceUnits(25));
            this.propertyEditor1.Name = "propertyEditor1";
            this.propertyEditor1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(247), (int)DpiAware.LogicalToDeviceUnits(416));
            this.propertyEditor1.TabIndex = 1;
            // 
            // diagram1
            // 
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
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(0, (int)DpiAware.LogicalToDeviceUnits(25));
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(507), (int)DpiAware.LogicalToDeviceUnits(416));
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 2;
            this.diagram1.Text = "diagram1";
            // 
            // 
            // 
            this.diagram1.View.BackgroundColor = System.Drawing.Color.White;
            this.diagram1.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram1.View.Controller = this.diagram1.Controller;
            this.diagram1.View.Grid.MinPixelSpacing = 4F;
            this.diagram1.View.Grid.Visible = false;
            this.diagram1.View.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center;
            // 
            // model1
            // 
            this.model1.AlignmentType = Syncfusion.Windows.Forms.Diagram.AlignmentType.SelectedNode;
            this.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model1.DocumentScale.DisplayName = "No Scale";
            this.model1.DocumentScale.Height = 1F;
            this.model1.DocumentScale.Width = 1F;
            this.model1.DocumentSize.Height = DpiAware.LogicalToDeviceUnits(1169F);
            this.model1.DocumentSize.Width = DpiAware.LogicalToDeviceUnits(827F);
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LineStyle.LineWidth = 0F;
            this.model1.LogicalSize = new System.Drawing.SizeF(DpiAware.LogicalToDeviceUnits(827F), DpiAware.LogicalToDeviceUnits(1169F));
            this.model1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(754), (int)DpiAware.LogicalToDeviceUnits(441));
            this.Controls.Add(this.diagram1);
            this.Controls.Add(this.propertyEditor1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Symbol";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        
        #endregion

        #region MAIN
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new MainForm());
        }
        #endregion

        #region Event handlers
        private void MainForm_Load(object sender, EventArgs e)
        {
            DiagramAppearance();
            //MySymbol symb1 = new MySymbol();
            //this.diagram1.Model.AppendChild(symb1);

            Rectangle outerRect = new Rectangle(160, 100, 96, 72);
            outerRect.Name = "Rectangle";
            outerRect.FillStyle.Type = FillStyleType.LinearGradient;
           outerRect.FillStyle.Color = Color.FromArgb(51, 153, 255);
           outerRect.FillStyle.ForeColor = Color.FromArgb(51, 153, 255);
            outerRect.EditStyle.AllowSelect = false;
            this.diagram1.Model.AppendChild(outerRect);
            Syncfusion.Windows.Forms.Diagram.Label label1 = new Syncfusion.Windows.Forms.Diagram.Label();
            label1.Text = "Process";
            label1.FontStyle.Family = "Arial";
            outerRect.Labels.Add(label1);
            this.diagram1.Model.AppendChild(outerRect);
            Ellipse ellipse1 = new Ellipse(150, 5, 110, 70);
           ellipse1.FillStyle.Color = Color.FromArgb(51, 153, 255);
            ellipse1.FillStyle.ForeColor = Color.FromArgb(51, 153, 255);
            this.diagram1.Model.AppendChild(ellipse1);
            Syncfusion.Windows.Forms.Diagram.Label label2 = new Syncfusion.Windows.Forms.Diagram.Label();
            label2.Text = "Start";
            label2.FontStyle.Family = "Arial";
            ellipse1.Labels.Add(label2);
            OrthogonalConnector link1 = new OrthogonalConnector(ellipse1.PinPoint, outerRect.PinPoint);
            link1.LineStyle.LineColor = Color.Black;
            link1.LineStyle.LineWidth = 2f;
            diagram1.Model.AppendChild(link1);
            link1.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            link1.HeadDecorator.Size = new SizeF(8, 8);
            link1.HeadDecorator.FillStyle.Color = Color.Black;
            link1.HeadDecorator.LineStyle.LineColor = Color.Black;
            ellipse1.CentralPort.TryConnect(link1.TailEndPoint);
            outerRect.CentralPort.TryConnect(link1.HeadEndPoint);


            Ellipse ellipse2 = new Ellipse(150, 200, 110, 70);
            ellipse2.FillStyle.Color = Color.FromArgb(51, 153, 255);
            ellipse2.FillStyle.ForeColor = Color.FromArgb(51, 153, 255);
            this.diagram1.Model.AppendChild(ellipse2);
            Syncfusion.Windows.Forms.Diagram.Label label3 = new Syncfusion.Windows.Forms.Diagram.Label();
            label3.Text = "End";
            label3.FontStyle.Family = "Arial";
            ellipse2.Labels.Add(label3);
            OrthogonalConnector link2 = new OrthogonalConnector(ellipse2.PinPoint, outerRect.PinPoint);
            link2.LineStyle.LineColor = Color.Black;
            link2.LineStyle.LineWidth = 2f;
            diagram1.Model.AppendChild(link2);
            link2.TailDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            link2.TailDecorator.Size = new SizeF(8, 8);
            link2.TailDecorator.FillStyle.Color = Color.Black;
            link2.TailDecorator.LineStyle.LineColor = Color.Black;
            outerRect.CentralPort.TryConnect(link2.HeadEndPoint);
            ellipse2.CentralPort.TryConnect(link2.TailEndPoint);
            diagram1.View.SelectionList.Clear();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == toolStrip1.Items[0].Name)
            {
                MySymbol symb = new MySymbol();
                this.diagram1.Model.AppendChild(symb);
            }
            else if ((e.ClickedItem.Name == toolStrip1.Items[1].Name) && (this.diagram1.View.SelectionList.Count > 0))
            {
                Group selectedSymbol = this.diagram1.View.SelectionList[0] as Group;

                if (selectedSymbol != null)
                {
                    Group symbolClone = (Group)selectedSymbol.Clone();
                    symbolClone.Translate(5, 5);
                    this.diagram1.Model.AppendChild(symbolClone);
                }
            }
            diagram1.Focus();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// change's the appearance of the diagram
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.View.Grid.Visible = false;
            this.diagram1.View.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.View.SelectionList.Clear();
        }

        #endregion        
    }
    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {

        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}