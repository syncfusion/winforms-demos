#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms;

namespace Labels
{
    public partial class Form1 : Form
    {
        #region Form Initialize
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Syncfusion.Windows.Forms.Diagram.Rectangle rect = new Syncfusion.Windows.Forms.Diagram.Rectangle(100, 100, 100, 70);
            rect.FillStyle.Color = Color.Maroon;
            rect.FillStyle.ForeColor = Color.Red;
            rect.FillStyle.Type = FillStyleType.LinearGradient;
            rect.LineStyle.LineWidth = 0;
            Syncfusion.Windows.Forms.Diagram.Label lbl = new Syncfusion.Windows.Forms.Diagram.Label(rect, "Top Left");
            lbl.FontColorStyle.Color = Color.White;
            lbl.Position = Position.TopLeft;
            lbl.UpdatePosition = true;
            rect.Labels.Add(lbl);
            diagram1.Model.AppendChild(rect);

            Syncfusion.Windows.Forms.Diagram.Rectangle rect1 = new Syncfusion.Windows.Forms.Diagram.Rectangle(350, 250, 100, 70);
            rect1.FillStyle.Color = Color.Maroon;
            rect1.FillStyle.ForeColor = Color.Red;
            rect1.FillStyle.Type = FillStyleType.LinearGradient;
            rect1.LineStyle.LineWidth = 0;
            Syncfusion.Windows.Forms.Diagram.Label lbl1 = new Syncfusion.Windows.Forms.Diagram.Label(rect1, "MiddleRight");
            lbl1.FontColorStyle.Color = Color.White;
            lbl1.Position = Position.MiddleRight;
            lbl1.UpdatePosition = true;
            rect1.Labels.Add(lbl1);
            diagram1.Model.AppendChild(rect1);

            OrthogonalConnector ocon = new OrthogonalConnector(new PointF(100, 100), new PointF(200, 100), false);
            ocon.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            ocon.HeadDecorator.FillStyle.Color = Color.Black;
            rect.CentralPort.Connect(ocon.TailEndPoint);
            rect1.CentralPort.Connect(ocon.HeadEndPoint);
            diagram1.Model.AppendChild(ocon);
            Syncfusion.Windows.Forms.Diagram.Label conLbl = new Syncfusion.Windows.Forms.Diagram.Label(ocon, "BottomCenter");
            conLbl.UpdatePosition = true;
            conLbl.Position = Position.BottomCenter;
            conLbl.OffsetX = 100;
            conLbl.OffsetY = ocon.BoundingRectangle.Height ;
            conLbl.BackgroundStyle.ColorAlphaFactor = 255;
            ocon.Labels.Add(conLbl);
            

            OrthogonalConnector ocon1 = new OrthogonalConnector(PointF.Empty, new PointF(0, 1), true);
            ocon1.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            ocon1.HeadDecorator.FillStyle.Color = Color.Black;
            rect.CentralPort.Connect(ocon1.TailEndPoint);
            rect1.CentralPort.Connect(ocon1.HeadEndPoint);
            diagram1.Model.AppendChild(ocon1);
            Syncfusion.Windows.Forms.Diagram.Label conLbl1 = new Syncfusion.Windows.Forms.Diagram.Label(ocon1, "Top Center");
            conLbl1.UpdatePosition = true;
            conLbl1.Position = Position.TopCenter;
            conLbl1.OffsetX = 80;
            conLbl1.OffsetY = 0;
            conLbl1.BackgroundStyle.ColorAlphaFactor = 255;
            ocon1.Labels.Add(conLbl1);
            
            propertyGrid1.SelectedObject = ((PathNode)diagram1.View.SelectionList[0]).Labels[0];
            diagram1.View.BackgroundColor = Color.White;
            diagram1.View.SelectionList.Clear();
            diagram1.EventSink.NodeSelected += new NodeSelectedEventHandler(EventSink_NodeSelected);

        }
        #endregion

        #region Event handlers
        void EventSink_NodeSelected(NodeSelectedEventArgs evtArgs)
        {
            if (evtArgs.Node is PathNode && ((PathNode)evtArgs.Node).Labels.Count > 0)
                propertyGrid1.SelectedObject = ((PathNode)evtArgs.Node).Labels[0];
        }
        #endregion
    }
}