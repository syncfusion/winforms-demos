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
using System.Drawing.Imaging;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Diagram.Controls;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using Syncfusion.SVG.IO;


namespace DirectedTreeLayout
{
    public partial class Form1 : MetroForm
    {
       
        #region Form Initialize
        public Form1()
        {
            InitializeComponent();

            diagram1.BeginUpdate();            
            comboLytDirection.SelectedIndex = 0;
            DiagramAppearance();
            PopulateNodes();
            this.diagram1.View.SelectionList.Clear();
            

            DirectedTreeLayoutManager dtlm = new DirectedTreeLayoutManager(this.diagram1.Model, 0, 50, 60);
            dtlm.TopMargin = 50;
            dtlm.LeftMargin = 20;
            this.diagram1.LayoutManager = dtlm;
            this.diagram1.LayoutManager.UpdateLayout(null);

            txtHSpacing.Text = dtlm.HorizontalSpacing.ToString();
            txtVSpacing.Text = dtlm.VerticalSpacing.ToString();
            txtLMarigin.Text = dtlm.LeftMargin.ToString();
            txtTMarigin.Text = dtlm.TopMargin.ToString();
            chkAutoLayout.Checked = dtlm.AutoLayout;

            diagram1.EndUpdate();
        }
        #endregion


        #region Private Methods
        /// <summary>
        /// Change's the appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.Model.LineStyle.LineColor = Color.LightGray;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.View.BackgroundColor = Color.White;
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;        
            this.diagram1.View.SelectionList.Clear();
        }
        #endregion

        #region Initialize Diagram

        /// <summary>
        /// Initialize the nodes in daigram
        /// </summary>
        private void PopulateNodes()
        {
            //first level of nodes
            Syncfusion.Windows.Forms.Diagram.Rectangle rectNode1 = new Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 100, 60);
            rectNode1.FillStyle.Color = Color.FromArgb(242,242,242);
            rectNode1.FillStyle.Type = FillStyleType.LinearGradient;
            rectNode1.FillStyle.ForeColor = Color.White;
            rectNode1.FillStyle.GradientAngle = 90;
            rectNode1.FillStyle.GradientCenter = 1;
            this.diagram1.Model.AppendChild(rectNode1);
            GenerateInnerLevelNodes(rectNode1, 5, Color.LightGreen, Color.Brown, 0);
        }

        /// <summary>
        /// Generates the inner level nodes
        /// </summary>
        /// <param name="parentNode">Parent Node</param>
        /// <param name="maxSubNodes">Maximum sub nodes</param>
        /// <param name="LevelColor">Node's Fill color</param>
        /// <param name="connectionColor">Node's fore color</param>
        /// <param name="n">nodes level count</param>
        private void GenerateInnerLevelNodes(Node parentNode, int maxSubNodes, Color LevelColor, Color connectionColor, int n)
        {
            if (n == 4)
                return;
            for (int i = 0; i < maxSubNodes; i++)
            {
                Syncfusion.Windows.Forms.Diagram.Rectangle e = new Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 90, 50);
                e.FillStyle.Color = Color.FromArgb(242, 242, 242);
                e.FillStyle.Type = FillStyleType.LinearGradient;
                e.FillStyle.ForeColor = Color.White;
                e.FillStyle.GradientAngle = 90;
                e.FillStyle.GradientCenter = 1;
                this.diagram1.Model.AppendChild(e);
                ConnectNodes(parentNode, e, connectionColor);
                GenerateInnerLevelNodes(e, i, Color.Plum, Color.Purple, n++);
            }
        }
        /// <summary>
        /// Connects the given nodes
        /// </summary>
        /// <param name="parentNode">Parent Node</param>
        /// <param name="childNode">Child node</param>
        /// <param name="connectionColor">Connector Color</param>
        private void ConnectNodes(Node parentNode, Node childNode, Color connectionColor)
        {
            if (parentNode != null && childNode != null)
            {
                LineConnector lConnector = new LineConnector(PointF.Empty, new PointF(0, 1));
                lConnector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
                lConnector.HeadDecorator.FillStyle.Color = Color.White;
                parentNode.CentralPort.TryConnect(lConnector.TailEndPoint);
                childNode.CentralPort.TryConnect(lConnector.HeadEndPoint);
                this.diagram1.Model.AppendChild(lConnector);
                this.diagram1.Model.SendToBack(lConnector);
            }
        }
        #endregion

        #region Event Handlers


        private void dialog_BeginLayout(DirectedTreeLayoutManager layout)
        {
            this.diagram1.LayoutManager = layout;
            Layouting();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            float rotationAngle = 0;
            float parseVal;
            if (txtHSpacing.Text != string.Empty && float.TryParse(txtHSpacing.Text.ToString(), out parseVal))
                ((DirectedTreeLayoutManager)this.diagram1.LayoutManager).HorizontalSpacing = parseVal;
            else
                txtHSpacing.Text = ((DirectedTreeLayoutManager)this.diagram1.LayoutManager).HorizontalSpacing.ToString();

            if (txtVSpacing.Text != string.Empty && float.TryParse(txtVSpacing.Text.ToString(), out parseVal))
                ((DirectedTreeLayoutManager)this.diagram1.LayoutManager).VerticalSpacing = parseVal;
            else
                txtVSpacing.Text = ((DirectedTreeLayoutManager)this.diagram1.LayoutManager).VerticalSpacing.ToString();

            if (txtLMarigin.Text != string.Empty && float.TryParse(txtLMarigin.Text.ToString(), out parseVal))
                ((DirectedTreeLayoutManager)this.diagram1.LayoutManager).LeftMargin = parseVal;
            else
                txtLMarigin.Text = ((DirectedTreeLayoutManager)this.diagram1.LayoutManager).LeftMargin.ToString();

            if (txtTMarigin.Text != string.Empty && float.TryParse(txtTMarigin.Text.ToString(), out parseVal))
                ((DirectedTreeLayoutManager)this.diagram1.LayoutManager).TopMargin = parseVal;
            else
                txtTMarigin.Text = ((DirectedTreeLayoutManager)this.diagram1.LayoutManager).TopMargin.ToString();
            switch (comboLytDirection.SelectedItem.ToString())
            {
                case "TopToBottom":
                    rotationAngle = 0;
                    break;
                case "TopLeft":
                    rotationAngle = 45;
                    break;
                case "TopRight":
                    rotationAngle = -45;
                    break;
                case "LeftToRight":
                    rotationAngle = 90;
                    break;
                case "RightToLeft":
                    rotationAngle = -90;
                    break;
                case "BottomToTop":
                    rotationAngle = 180;
                    break;
                case "BottomLeft":
                    rotationAngle = 135;
                    break;
                case "BottomRight":
                    rotationAngle = -135;
                    break;
            }
            ((DirectedTreeLayoutManager)this.diagram1.LayoutManager).RotationAngle = rotationAngle;
            ((DirectedTreeLayoutManager)this.diagram1.LayoutManager).AutoLayout = chkAutoLayout.Checked;
            Layouting();
        }     

        #endregion

        #region Helper Methods

        private void Layouting()
        {
            this.diagram1.LayoutManager.UpdateLayout(null);
            this.diagram1.UpdateView();

        }

       
        #endregion                       
    }
   
}
