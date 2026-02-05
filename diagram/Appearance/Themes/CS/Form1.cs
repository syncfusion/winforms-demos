#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Themes
{
    public partial class Form1 : SfForm
    {
        public Form1()
        {
            InitializeComponent();
            SampleCustomization();

            try
            {
                Bitmap bmp = new Bitmap(Image.FromFile(@"../../Icon/sficon.ico"));
                this.Icon = Icon.FromHandle(bmp.GetHicon());
            }
            catch (Exception ex)
            { }

            InitializeDiagramNodes();
        }

        private void InitializeDiagramNodes()
        {
            SymbolPalette palette = new SymbolPalette();
#if !NETCORE
            palette = palette.FromFile(@"..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
#else
            palette = palette.FromFile(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
#endif
            Node start = palette.Nodes["On-page reference"];
            start.PinPoint = new PointF(70, 100);
            start.Size = new SizeF(80, 80);
            ((PathNode)start).Labels.Add(new Syncfusion.Windows.Forms.Diagram.Label(start, "Start"));
            diagram1.Model.AppendChild(start);
            Node decision = palette.Nodes["Decision"];
            decision.PinPoint = new PointF(270, 100);
            decision.Size = new SizeF(100, 100);
            ((PathNode)decision).Labels.Add(new Syncfusion.Windows.Forms.Diagram.Label(decision, "Decision"));
            diagram1.Model.AppendChild(decision);
            Node document = palette.Nodes["Document"];
            document.PinPoint = new PointF(470, 100);
            document.Size = new SizeF(120, 80);
            ((PathNode)document).Labels.Add(new Syncfusion.Windows.Forms.Diagram.Label(document, "Document"));
            diagram1.Model.AppendChild(document);
            Node process = palette.Nodes["Process"];
            process.PinPoint = new PointF(270, 230);
            process.Size = new SizeF(100, 80);
            ((PathNode)process).Labels.Add(new Syncfusion.Windows.Forms.Diagram.Label(process, "Process"));
            diagram1.Model.AppendChild(process);
            Node end = palette.Nodes["On-page reference"].Clone() as Node;
            end.PinPoint = new PointF(270, 350);
            end.Size = new SizeF(80, 80);
            ((PathNode)end).Labels.Clear();
            ((PathNode)end).Labels.Add(new Syncfusion.Windows.Forms.Diagram.Label(end, "End"));
            diagram1.Model.AppendChild(end);

            ConnectNodes(start, decision, false);
            ConnectNodes(decision, document, false);
            ConnectNodes(document, process, true);
            ConnectNodes(decision, process, false);
            ConnectNodes(process, end, false);
            DiagramAppearance();
        }
        public void DiagramAppearance()
        {
            this.diagram1.VisualStyle = Syncfusion.Windows.Forms.Diagram.Controls.DiagramStyle.Office2016Black;
            this.diagram1.Model.LineStyle.LineWidth = 0;
            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.White;
            this.diagram1.View.Grid.VerticalSpacing = 15;
            this.diagram1.View.Grid.HorizontalSpacing = 15;
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.View.BackgroundColor = Color.White;
            this.diagram1.View.SelectionList.Clear();
        }
        private void ConnectNodes(Node parent, Node child, bool useOrthogonal)
        {
            ConnectorBase conn;
            if (!useOrthogonal)
                conn = new LineConnector(PointF.Empty, new PointF(0, 1));
            else
                conn = new OrthogonalConnector(parent.PinPoint, child.PinPoint, false);

            conn.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            conn.HeadDecorator.FillStyle.Color = Color.Black;
            diagram1.Model.AppendChild(conn);
            parent.CentralPort.Connect(conn.TailEndPoint);
            child.CentralPort.Connect(conn.HeadEndPoint);
        }

        /// <summary>
        /// Sets the sample customization settings.
        /// </summary>
        private void SampleCustomization()
        {
            this.Style.TitleBar.BackColor = Color.FromArgb(38, 38, 38);
            this.Style.TitleBar.CloseButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
            this.Style.TitleBar.MaximizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
            this.Style.TitleBar.CloseButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
            this.Style.TitleBar.MinimizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
            this.Style.TitleBar.MinimizeButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
            this.BackColor = ColorTranslator.FromHtml("#444444");
            this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
            this.label1.BackColor = ColorTranslator.FromHtml("#444444");
            this.label1.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
            this.comboBox1.SelectedText = "Office2016Black";
            this.comboBox1.SelectedText = "Office2016DarkGray";
            this.comboBox1.SelectedIndex = 0;
            this.comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            diagram1.View.Grid.Visible = false;
        }

#region events

        void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {            
            if (comboBox1.SelectedItem.ToString() == "Office2016Black")
            {                
                diagram1.VisualStyle = Syncfusion.Windows.Forms.Diagram.Controls.DiagramStyle.Office2016Black;
                this.Style.TitleBar.BackColor = Color.FromArgb(38, 38, 38);
                this.Style.TitleBar.CloseButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.MaximizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.CloseButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.Style.TitleBar.MinimizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.MinimizeButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.BackColor = ColorTranslator.FromHtml("#444444");
                this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                this.label1.BackColor = ColorTranslator.FromHtml("#444444");
                this.label1.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                this.comboBox1.SelectedText = "Office2016Black";
            }
            else if (comboBox1.SelectedItem.ToString() == "Office2016DarkGray")
            {
                diagram1.VisualStyle = Syncfusion.Windows.Forms.Diagram.Controls.DiagramStyle.Office2016DarkGray;
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.Style.TitleBar.CloseButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.MaximizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.CloseButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.Style.TitleBar.MinimizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.MinimizeButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.Style.TitleBar.BackColor = Color.FromArgb(38, 38, 38);
                this.Style.TitleBar.ForeColor = Color.FromArgb(240, 240, 240);
                this.label1.BackColor = ColorTranslator.FromHtml("#666666");
                this.label1.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                this.comboBox1.SelectedText = "Office2016DarkGray";
            }
            else if (comboBox1.SelectedItem.ToString() == "Office2016Colorful")
            {
                diagram1.VisualStyle = Syncfusion.Windows.Forms.Diagram.Controls.DiagramStyle.Office2016Colorful;
                this.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                this.Style.TitleBar.CloseButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MaximizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MinimizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.CloseButtonHoverBackColor = this.Style.TitleBar.MinimizeButtonHoverBackColor;
                this.Style.TitleBar.CloseButtonHoverForeColor = this.Style.TitleBar.MinimizeButtonHoverForeColor;
                this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#444444");
                this.label1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.label1.ForeColor = ColorTranslator.FromHtml("#444444");
                this.comboBox1.SelectedText = "Office2016Colorful";
            }
            else if (comboBox1.SelectedItem.ToString() == "Office2016White")
            {
                diagram1.VisualStyle = Syncfusion.Windows.Forms.Diagram.Controls.DiagramStyle.Office2016White;
                this.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                this.Style.TitleBar.CloseButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MaximizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MinimizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.CloseButtonHoverBackColor = this.Style.TitleBar.MinimizeButtonHoverBackColor;
                this.Style.TitleBar.CloseButtonHoverForeColor = this.Style.TitleBar.MinimizeButtonHoverForeColor;
                this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#444444");
                this.label1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.label1.ForeColor = ColorTranslator.FromHtml("#444444");
                this.comboBox1.SelectedText = "Office2016White";
            }
        }

#endregion
    }
}
