#region Copyright Syncfusion Inc. 2001 - 2011
//
//  Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Licensing;

namespace ControlsGalore
{
	/// <summary>
	/// Sample application form.
	/// </summary>
	public class Form1: Form
	{
        #region Form controls

        private OpenFileDialog openDiagramDialog;
        private SaveFileDialog saveDiagramDialog;
        private Panel panel2;
        private PaletteGroupBar paletteGroupBar1;
        private Panel panel3;
        private PropertyEditor propertyEditor1;
        private Panel panel4;
        private Panel panel6;
        private Diagram diagram2;
        private Panel panel5;
        private Diagram diagram1;
        private Model model;
        private System.ComponentModel.IContainer components;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram selectedDiagram = null;
        #endregion
		
        #region Class Initialize/Finalize methods
        /// <summary>
        /// Default Applcation constructor.
        /// </summary>
        public Form1()
        {
            
            InitializeComponent();
            this.diagram2.View.Grid.GridStyle = GridStyle.Point;
            this.diagram2.View.Grid.Color = Color.Black;
            
            //
            // Create a model and attach it to both diagrams
            //
            this.selectedDiagram = this.diagram1;
            this.selectedDiagram.Model = this.model;
            this.diagram2.Model = this.model;
            this.propertyEditor1.Diagram = this.selectedDiagram;
#if !NETCORE
            this.paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
#else
            this.paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
#endif
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if (components != null) 
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
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
            this.openDiagramDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDiagramDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paletteGroupBar1 = new Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.propertyEditor1 = new Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.diagram2 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paletteGroupBar1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            this.SuspendLayout();
            // 
            // openDiagramDialog
            // 
            this.openDiagramDialog.Filter = "XML Files|*.xml|All files|*.*";
            this.openDiagramDialog.Title = "Open Diagram";
            // 
            // saveDiagramDialog
            // 
            this.saveDiagramDialog.FileName = "doc1";
            this.saveDiagramDialog.Filter = "XML Files|*.xml|All files|*.*";
            this.saveDiagramDialog.Title = "SaveDiagram";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.paletteGroupBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 615);
            this.panel2.TabIndex = 1;
            // 
            // paletteGroupBar1
            // 
            this.paletteGroupBar1.AllowDrop = true;
            this.paletteGroupBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.paletteGroupBar1.BeforeTouchSize = new System.Drawing.Size(211, 615);
            this.paletteGroupBar1.BorderColor = System.Drawing.Color.White;
            this.paletteGroupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paletteGroupBar1.CollapseImage = ((System.Drawing.Image)(resources.GetObject("paletteGroupBar1.CollapseImage")));
            this.paletteGroupBar1.Diagram = null;
            this.paletteGroupBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paletteGroupBar1.EditMode = false;
            this.paletteGroupBar1.ExpandButtonToolTip = null;
            this.paletteGroupBar1.ExpandImage = ((System.Drawing.Image)(resources.GetObject("paletteGroupBar1.ExpandImage")));
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
            this.paletteGroupBar1.Size = new System.Drawing.Size(211, 615);
            this.paletteGroupBar1.TabIndex = 1;
            this.paletteGroupBar1.Text = "paletteGroupBar1";
            this.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.propertyEditor1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(697, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 615);
            this.panel3.TabIndex = 0;
            // 
            // propertyEditor1
            // 
            this.propertyEditor1.Diagram = null;
            this.propertyEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyEditor1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyEditor1.Location = new System.Drawing.Point(0, 0);
            this.propertyEditor1.Name = "propertyEditor1";
            this.propertyEditor1.Size = new System.Drawing.Size(253, 615);
            this.propertyEditor1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(211, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 615);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.diagram2);
            this.panel6.Location = new System.Drawing.Point(0, 297);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(482, 290);
            this.panel6.TabIndex = 0;
            // 
            // diagram2
            // 
            this.diagram2.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram2.HScroll = true;
            this.diagram2.LayoutManager = null;
            this.diagram2.Location = new System.Drawing.Point(0, 0);
            this.diagram2.MetroScrollBars = true;
            this.diagram2.Model = this.model;
            this.diagram2.Name = "diagram2";
            this.diagram2.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram2.Size = new System.Drawing.Size(482, 290);
            this.diagram2.SmartSizeBox = false;
            this.diagram2.TabIndex = 0;
            this.diagram2.Text = "diagram2";
            // 
            // 
            // 
            this.diagram2.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram2.View.Controller = this.diagram2.Controller;
            this.diagram2.View.Grid.MinPixelSpacing = 4F;
            this.diagram2.View.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram2.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center;
            this.diagram2.VScroll = true;
            this.diagram2.Click += new System.EventHandler(this.diagram2_Click);
            // 
            // model
            // 
            this.model.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model.DocumentScale.DisplayName = "No Scale";
            this.model.DocumentScale.Height = 1F;
            this.model.DocumentScale.Width = 1F;
            this.model.DocumentSize.Height = 1169F;
            this.model.DocumentSize.Width = 827F;
            this.model.LineStyle.DashPattern = null;
            this.model.LineStyle.LineColor = System.Drawing.Color.White;
            this.model.LogicalSize = new System.Drawing.SizeF(827F, 1169F);
            this.model.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.diagram1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(482, 290);
            this.panel5.TabIndex = 0;
            // 
            // diagram1
            // 
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.HScroll = true;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.MetroScrollBars = true;
            this.diagram1.Model = this.model;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.Size = new System.Drawing.Size(482, 290);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 0;
            this.diagram1.Text = "diagram1";
            // 
            // 
            // 
            this.diagram1.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram1.View.Controller = this.diagram1.Controller;
            this.diagram1.View.Grid.MinPixelSpacing = 4F;
            this.diagram1.View.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center;
            this.diagram1.VScroll = true;
            this.diagram1.Click += new System.EventHandler(this.diagram1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(950, 615);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mutiple views";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paletteGroupBar1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            this.ResumeLayout(false);

		}
#endregion

#endregion

#region MAIN
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }

#endregion
        void LoadDiagram()
        {
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            Syncfusion.Windows.Forms.Diagram.Ellipse ellipse = new Syncfusion.Windows.Forms.Diagram.Ellipse(150, 5, 110, 70);
            ellipse.FillStyle.Type = FillStyleType.LinearGradient;
            ellipse.FillStyle.Color = Color.FromArgb(51, 153, 255);
            ellipse.FillStyle.ForeColor = Color.FromArgb(51, 153, 255);
            ellipse.LineStyle.LineColor = Color.Black;
            ellipse.LineStyle.LineWidth = 2.0f;
            ellipse.LineStyle.LineJoin = LineJoin.Miter;
            Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label();
            label.Text = "Start";
            label.FontStyle.Family = "Arial";
            ellipse.Labels.Add(label);
            diagram1.Model.AppendChild(ellipse);
            Syncfusion.Windows.Forms.Diagram.Rectangle process = new Syncfusion.Windows.Forms.Diagram.Rectangle(150, 100, 100, 70);
            process.FillStyle.Type = FillStyleType.LinearGradient;
            process.FillStyle.Color = Color.FromArgb(51, 153, 255);
            process.FillStyle.ForeColor = Color.FromArgb(51, 153, 255);
            process.LineStyle.LineColor = Color.Black;
            process.LineStyle.LineWidth = 2.0f;
            process.LineStyle.LineJoin = LineJoin.Miter;
            Syncfusion.Windows.Forms.Diagram.Label label2 = new Syncfusion.Windows.Forms.Diagram.Label();
            label2.Text = "Process";
            label2.FontStyle.Family = "Arial";
            process.Labels.Add(label2);
            diagram1.Model.AppendChild(process);
            OrthogonalConnector link = new OrthogonalConnector(ellipse.PinPoint, process.PinPoint);
            link.LineStyle.LineColor = Color.Black;
            link.LineStyle.LineWidth = 2f;
            diagram1.Model.AppendChild(link);
            link.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            link.HeadDecorator.Size = new SizeF(8, 8);
            link.HeadDecorator.FillStyle.Color = Color.Black;
            link.HeadDecorator.LineStyle.LineColor = Color.Black;
            ellipse.CentralPort.TryConnect(link.TailEndPoint);
            process.CentralPort.TryConnect(link.HeadEndPoint);
            Polygon decision = new Polygon(new PointF[] { new PointF(0, 50), new PointF(50, 0), new PointF(100, 50), new PointF(50, 100), new PointF(0, 50) });
            decision.FillStyle.Type = FillStyleType.LinearGradient;
            decision.FillStyle.Color = Color.FromArgb(51, 153, 255);
            decision.FillStyle.ForeColor = Color.FromArgb(51, 153, 255);
            decision.LineStyle.LineColor = Color.Black;
            decision.LineStyle.LineWidth = 2.0f;
            decision.LineStyle.LineJoin = LineJoin.Miter;
            Syncfusion.Windows.Forms.Diagram.Label label3 = new Syncfusion.Windows.Forms.Diagram.Label();
            label3.Text = "Decision";
            label3.FontStyle.Family = "Arial";
            decision.Labels.Add(label3);
            decision.PinPoint = new PointF(200, 250);
            diagram1.Model.AppendChild(decision);
            OrthogonalConnector link2 = new OrthogonalConnector(decision.PinPoint, process.PinPoint);
            link2.LineStyle.LineColor = Color.Black;
            link2.LineStyle.LineWidth = 2f;
            diagram1.Model.AppendChild(link2);
            link2.TailDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            link2.TailDecorator.Size = new SizeF(8, 8);
            link2.TailDecorator.FillStyle.Color = Color.Black;
            link2.TailDecorator.LineStyle.LineColor = Color.Black;
            decision.CentralPort.TryConnect(link2.TailEndPoint);
            process.CentralPort.TryConnect(link2.HeadEndPoint);
            Syncfusion.Windows.Forms.Diagram.Rectangle process2 = new Syncfusion.Windows.Forms.Diagram.Rectangle(150, 325, 100, 70);
            process2.FillStyle.Type = FillStyleType.LinearGradient;
            process2.FillStyle.Color = Color.FromArgb(51, 153, 255);
            process2.FillStyle.ForeColor = Color.FromArgb(51, 153, 255);
            process2.LineStyle.LineColor = Color.Black;
            process2.LineStyle.LineWidth = 2.0f;
            process2.LineStyle.LineJoin = LineJoin.Miter;
            Syncfusion.Windows.Forms.Diagram.Label label4 = new Syncfusion.Windows.Forms.Diagram.Label();
            label4.Text = "Process2";
            label4.FontStyle.Family = "Arial";
            process2.Labels.Add(label4);
            diagram1.Model.AppendChild(process2);
            diagram1.Model.AppendChild(decision); OrthogonalConnector link3 = new OrthogonalConnector(decision.PinPoint, process2.PinPoint);
            link3.LineStyle.LineColor = Color.Black;
            link3.LineStyle.LineWidth = 2f;
            diagram1.Model.AppendChild(link3);
            link3.TailDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            link3.TailDecorator.Size = new SizeF(8, 8);
            link3.TailDecorator.FillStyle.Color = Color.Black;
            link3.TailDecorator.LineStyle.LineColor = Color.Black;
            decision.CentralPort.TryConnect(link3.HeadEndPoint);
            process2.CentralPort.TryConnect(link3.TailEndPoint);
            Syncfusion.Windows.Forms.Diagram.Ellipse ellipse2 = new Syncfusion.Windows.Forms.Diagram.Ellipse(150, 420, 110, 70);
            ellipse2.FillStyle.Type = FillStyleType.LinearGradient;
            ellipse2.FillStyle.Color = Color.FromArgb(51, 153, 255);
            ellipse2.FillStyle.ForeColor = Color.FromArgb(51, 153, 255);
            ellipse2.LineStyle.LineColor = Color.Black;
            ellipse2.LineStyle.LineWidth = 2.0f;
            ellipse2.LineStyle.LineJoin = LineJoin.Miter;
            Syncfusion.Windows.Forms.Diagram.Label label5 = new Syncfusion.Windows.Forms.Diagram.Label();
            label5.Text = "End";
            label5.FontStyle.Family = "Arial";
            ellipse2.Labels.Add(label5);
            diagram1.Model.AppendChild(ellipse2);
            diagram1.Model.AppendChild(decision); OrthogonalConnector link4 = new OrthogonalConnector(process2.PinPoint, ellipse2.PinPoint);
            link4.LineStyle.LineColor = Color.Black;
            link4.LineStyle.LineWidth = 2f;
            diagram1.Model.AppendChild(link4);
            link4.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            link4.HeadDecorator.Size = new SizeF(8, 8);
            link4.HeadDecorator.FillStyle.Color = Color.Black;
            link4.HeadDecorator.LineStyle.LineColor = Color.Black;

            ellipse2.CentralPort.TryConnect(link4.HeadEndPoint);
            process2.CentralPort.TryConnect(link4.TailEndPoint);
            diagram1.View.SelectionList.Clear();
        }
#region Class events
        private void Form1_Load(object sender, EventArgs e)
        {

            this.LoadDiagram();
            this.diagram1.View.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.View.Grid.Visible = false;
            this.diagram1.View.BackgroundColor = Color.White;
            this.diagram1.View.SelectionList.Clear();

          
            this.diagram2.View.HandleColor = Color.AliceBlue;
            this.diagram2.View.HandleOutlineColor = Color.SkyBlue;
            this.diagram2.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram2.View.Grid.Visible = false;
            this.diagram2.View.BackgroundColor = Color.White;
            this.diagram2.View.SelectionList.Clear();
            GroupBarAppearance();
        }        

        private void diagram1_Click(object sender, EventArgs e)
        {
            this.SelectDiagram(this.diagram1);
        }

        private void diagram2_Click(object sender, EventArgs e)
        {
            this.SelectDiagram(this.diagram2);
        }

#endregion

#region Private Methods
        /// <summary>
        /// Select the Diagram
        /// </summary>
        /// <param name="diagram">Diagram to select</param>
        private void SelectDiagram(Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram)
        {
            this.selectedDiagram = diagram;
            this.selectedDiagram.Model = this.model;
            this.propertyEditor1.Diagram = this.selectedDiagram;
        }

        /// <summary>
        /// Change's Appearance of GroupBar
        /// </summary>
        private void GroupBarAppearance()
        {
            this.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA");
            foreach (GroupBarItem item in paletteGroupBar1.GroupBarItems)
            {
                //palette view settings
                if (item.Client is PaletteGroupView)
                {
                    PaletteGroupView view = item.Client as PaletteGroupView;
                    view.Font = new Font("Segoe UI", 9, System.Drawing.FontStyle.Regular);
                    view.ForeColor = Color.Black;
                    view.FlowView = true;
                    view.ShowToolTips = true;
                    view.ShowFlowViewItemText = true;
                    view.SelectedItemColor = Color.FromArgb(255, 219, 118);
                    view.HighlightItemColor = Color.FromArgb(255, 227, 149);
                    view.SelectingItemColor = Color.FromArgb(255, 238, 184);
                    view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115);
                    view.FlowViewItemTextLength = (int)DpiAware.LogicalToDeviceUnits(80);
                    view.BackColor = Color.White;
                    view.TextWrap = true;
                    view.FlatLook = true;
                    view.BorderStyle = BorderStyle.FixedSingle;
                }
            }
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
