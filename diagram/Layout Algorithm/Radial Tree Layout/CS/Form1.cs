#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
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

namespace RadialTreeLayout
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

            RadialTreeLayoutManager rdlLyt = new RadialTreeLayoutManager(this.diagram1.Model, 0, 10, 10);
            rdlLyt.LeftMargin = 40;
            rdlLyt.TopMargin = 20;
            this.diagram1.LayoutManager = rdlLyt;
            this.diagram1.LayoutManager.UpdateLayout(null);
            diagram1.EndUpdate();

            txtHSpacing.Text = rdlLyt.HorizontalSpacing.ToString();
            txtVSpacing.Text = rdlLyt.VerticalSpacing.ToString();
            txtLMarigin.Text = rdlLyt.LeftMargin.ToString();
            txtTMarigin.Text = rdlLyt.TopMargin.ToString();
            chkAutoLayout.Checked = rdlLyt.AutoLayout;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Change's the appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {           
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.View.BackgroundColor = Color.White;
            this.diagram1.Model.BoundaryConstraintsEnabled = false;

        }
        #endregion

        #region Initialize Diagram

        /// <summary>
        /// Initialize the nodes in daigram
        /// </summary>
        private void PopulateNodes()
        {
            //First level node
            Ellipse e1 = new Ellipse(0, 0, 45, 45);
            e1.FillStyle.Color = Color.FromArgb(174, 205, 227);
            e1.FillStyle.ForeColor = Color.FromArgb(121,188,220);
            e1.FillStyle.Type = FillStyleType.LinearGradient;
            e1.LineStyle.LineWidth = 1;
            e1.EnableShading = false;
            this.diagram1.Model.AppendChild(e1);
            GenerateInnerLevelNodes(e1, 9, Color.FromArgb(237,195,229),Color.FromArgb(249,226,249), 0);
        }

        /// <summary>
        /// Generates the Inner level nodes
        /// </summary>
        /// <param name="parentNode">Parent Node</param>
        /// <param name="maxSubNodes">Maximum sub nodes</param>
        /// <param name="LevelColor">Fill color for nodes</param>
        /// <param name="foreColor">ForeColor for nodes</param>
        /// <param name="n"></param>
        private void GenerateInnerLevelNodes(Node parentNode, int maxSubNodes, Color LevelColor, Color foreColor, int n)
        {

            for (int i = 1; i <= maxSubNodes; i++)
            {
                Ellipse ellipse1 = GetEllipse(LevelColor, foreColor);
                ellipse1.FillStyle.Type = FillStyleType.LinearGradient;
                this.diagram1.Model.AppendChild(ellipse1);
                if (i == 7)
                {
                    Ellipse ellipse2 = GetEllipse(Color.FromArgb(151,204,237), Color.FromArgb(184,255,255));
                    this.diagram1.Model.AppendChild(ellipse2);
                    ConnectNodes(ellipse1, ellipse2, Color.Black);
                    for (int l = 0; l < 4; l++)
                    {
                        Ellipse ellipse4 = GetEllipse(Color.FromArgb(179, 220, 179), Color.FromArgb(222, 233, 162));
                        this.diagram1.Model.AppendChild(ellipse4);
                        ConnectNodes(ellipse2, ellipse4, Color.Black);
                        if (l == 2 || l == 3)
                        {
                            for (int m = 0; m < 1; m++)
                            {
                                Ellipse ellipse5 = GetEllipse(Color.FromArgb(179, 220, 179), Color.FromArgb(222, 233, 162));
                                this.diagram1.Model.AppendChild(ellipse5);
                                ConnectNodes(ellipse4, ellipse5, Color.Black);
                            }

                        }
                    }

                }
                ConnectNodes(parentNode, ellipse1, Color.Black);
                if (i == 2 || i == 3 || i == 8 || i== 9)
                {
                   for (int j = 0; j < 2; j++)
                    {
                        Ellipse ellipse2 = GetEllipse(Color.FromArgb(151, 204, 237), Color.FromArgb(184, 255, 255));
                    this.diagram1.Model.AppendChild(ellipse2);
                    ConnectNodes(ellipse1, ellipse2, Color.Black);
                        if (i == 2 || i == 3 && j == 1||i==9)
                        {
                            for (int k = 0; k < 2; k++)
                            {
                                Ellipse ellipse3 = GetEllipse(Color.FromArgb(179, 220, 179), Color.FromArgb(222, 233, 162));
                                this.diagram1.Model.AppendChild(ellipse3);
                                ConnectNodes(ellipse2, ellipse3, Color.Black);
                                if (i == 2 && j == 0 || i == 2 && j == 1 && k == 1||i==3&&j==1&&k==1) 
                                {
                                    for (int l = 0; l < 1; l++)
                                    {
                                        Ellipse ellipse9 = GetEllipse(Color.FromArgb(179,220,179), Color.FromArgb(222,233,162));
                                        this.diagram1.Model.AppendChild(ellipse9);
                                        ConnectNodes(ellipse3, ellipse9, Color.Black);
                }

            }
                                if (i == 2 && j == 1 && k == 0)
                                {
                                    for (int l = 0; l < 2; l++)
                                    {
                                        Ellipse ellipse9 = GetEllipse(Color.FromArgb(179,220,179), Color.FromArgb(222,233,162));
                                        this.diagram1.Model.AppendChild(ellipse9);
                                        ConnectNodes(ellipse3, ellipse9, Color.Black);
        }

                                }
                            }
                        }
                        if (i == 8 && j == 0)
                        {

                            for (int l = 0; l < 4; l++)
                            {
                                Ellipse ellipse4 = GetEllipse(Color.FromArgb(179, 220, 179), Color.FromArgb(222, 233, 162));
                                this.diagram1.Model.AppendChild(ellipse4);
                                ConnectNodes(ellipse2, ellipse4, Color.Black);
                            }
                        }
                       
                    }
                }
            }
        }

        /// <summary>
        /// New function for create a ellipse
        /// </summary>
        /// <returns></returns>
        private static Ellipse GetEllipse(Color fillColor,Color foreColor)
        {
            Ellipse ellipse1 = new Ellipse(0, 0, 30, 30);
            ellipse1.FillStyle.Color = fillColor;
            ellipse1.FillStyle.ForeColor = foreColor;
            ellipse1.FillStyle.Type = FillStyleType.LinearGradient;
            return ellipse1;
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
                //lConnector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;               
                lConnector.HeadDecorator.FillStyle.Color = Color.White;
                lConnector.HeadDecorator.LineStyle.LineColor = connectionColor;
                lConnector.LineStyle.LineColor = connectionColor;


                parentNode.CentralPort.TryConnect(lConnector.TailEndPoint);
                childNode.CentralPort.TryConnect(lConnector.HeadEndPoint);
                this.diagram1.Model.AppendChild(lConnector);
                this.diagram1.Model.SendToBack(lConnector);
            }
        }
        #endregion

        #region Event Handlers

        private void dialog_BeginLayout(TableLayoutManager layout)
        {
            this.diagram1.LayoutManager = layout;
            Layouting();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            float rotationAngle = 0;
            float parseVal;
            if (txtHSpacing.Text != string.Empty && float.TryParse(txtHSpacing.Text.ToString(), out parseVal))
                ((RadialTreeLayoutManager)this.diagram1.LayoutManager).HorizontalSpacing = parseVal;
            else
                txtHSpacing.Text = ((RadialTreeLayoutManager)this.diagram1.LayoutManager).HorizontalSpacing.ToString();

            if (txtVSpacing.Text != string.Empty && float.TryParse(txtVSpacing.Text.ToString(), out parseVal))
                ((RadialTreeLayoutManager)this.diagram1.LayoutManager).VerticalSpacing = parseVal;
            else
                txtVSpacing.Text = ((RadialTreeLayoutManager)this.diagram1.LayoutManager).VerticalSpacing.ToString();

            if (txtLMarigin.Text != string.Empty && float.TryParse(txtLMarigin.Text.ToString(), out parseVal))
                ((RadialTreeLayoutManager)this.diagram1.LayoutManager).LeftMargin = parseVal;
            else
                txtLMarigin.Text = ((RadialTreeLayoutManager)this.diagram1.LayoutManager).LeftMargin.ToString();

            if (txtTMarigin.Text != string.Empty && float.TryParse(txtTMarigin.Text.ToString(), out parseVal))
                ((RadialTreeLayoutManager)this.diagram1.LayoutManager).TopMargin = parseVal;
            else
                txtTMarigin.Text = ((RadialTreeLayoutManager)this.diagram1.LayoutManager).TopMargin.ToString();
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
            ((RadialTreeLayoutManager)this.diagram1.LayoutManager).RotationAngle = rotationAngle;
            ((RadialTreeLayoutManager)this.diagram1.LayoutManager).AutoLayout = chkAutoLayout.Checked;
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