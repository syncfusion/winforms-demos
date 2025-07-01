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

namespace SymmetricLayout
{
    public partial class Form1 : MetroForm
    {
        #region Members        
        private const int DEF_LAYOUT_DISTANCE = 50;
        #endregion

        #region Form Initialize
        public Form1()
        {
            InitializeComponent();

            diagram1.BeginUpdate();
            DiagramAppearance();
            PopulateNodes();
            this.diagram1.View.SelectionList.Clear();
            
            SymmetricLayoutManager smtLayout = SetLayout();            
            diagram1.EndUpdate();
                       
            txtSLength.Text = smtLayout.SpringLength.ToString();
            txtSFactor.Text = smtLayout.SpringFactor.ToString();
            txtMaxIter.Text = smtLayout.MaxIteraction.ToString();
            chkAutoLayout.Checked = smtLayout.AutoLayout;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Apply layout to the diagram
        /// </summary>
        /// <returns>returns the layout manager</returns>
        private SymmetricLayoutManager SetLayout()
        {
            SymmetricLayoutManager smtLayout = new SymmetricLayoutManager(this.diagram1.Model, 50);

            smtLayout.MaxIteraction = 400;
            smtLayout.SpringLength = 80;
            smtLayout.SpringFactor = 1.4; 
            smtLayout.PreferredLayout += new PreferredLayoutEventHandler(smtLayout_PreferredLayout);
            this.diagram1.LayoutManager = smtLayout;
            this.diagram1.LayoutManager.UpdateLayout(null);
            return smtLayout;
        }
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

        #region Event Handlers
        void smtLayout_PreferredLayout(object sender, PreferredLayoutEventArgs evtArgs)
        {
            evtArgs.Location = new PointF(105, 30);
        }

        #endregion

        #region Initialize Diagram

        /// <summary>
        /// Initialize the nodes in daigram
        /// </summary>
        private void PopulateNodes()
        {
            Syncfusion.Windows.Forms.Diagram.Rectangle parentRect = GetRectangle();
            diagram1.Model.AppendChild(parentRect);

            for (int i = 0; i < 7; i++)
            {
                Syncfusion.Windows.Forms.Diagram.Rectangle childRect = GetRectangle();
                diagram1.Model.AppendChild(childRect);                
                ConnectNodes(parentRect, childRect, Color.Black);
                if (i == 0 || i== 4)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Syncfusion.Windows.Forms.Diagram.Rectangle childRect4 = GetRectangle();
                        diagram1.Model.AppendChild(childRect4);
                        ConnectNodes(childRect, childRect4, Color.Black);
                        if (j > 0)
                        {
                            for (int k = 0; k < j + 2; k++)
                            {
                                Syncfusion.Windows.Forms.Diagram.Rectangle childRect5 = GetRectangle();
                                diagram1.Model.AppendChild(childRect5);
                                ConnectNodes(childRect4, childRect5, Color.Black);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Gets the new rectangle node
        /// </summary>
        /// <returns>returns the node</returns>
        private static Syncfusion.Windows.Forms.Diagram.Rectangle GetRectangle()
        {
            Syncfusion.Windows.Forms.Diagram.Rectangle rect = new Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 25, 25);
            rect.FillStyle.Color = Color.FromArgb(240, 242, 240);
            rect.FillStyle.ForeColor = Color.White;
            rect.FillStyle.Type = FillStyleType.LinearGradient;
            rect.LineStyle.LineColor = Color.Black;
            return rect;
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
                lConnector.HeadDecorator.DecoratorShape = DecoratorShape.None;
                lConnector.LineStyle.LineColor = connectionColor;
                lConnector.HeadDecorator.FillStyle.Color = connectionColor;
                lConnector.HeadDecorator.LineStyle.LineColor = connectionColor;
                lConnector.HeadDecorator.Size = new SizeF(10, 10);
                lConnector.CentralPort.ConnectionsLimit = 10000;
                Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label(lConnector, diagram1.Model.Nodes.Count.ToString());
                label.Visible = false;
                lConnector.Labels.Add(label);
                parentNode.CentralPort.TryConnect(lConnector.TailEndPoint);
                childNode.CentralPort.TryConnect(lConnector.HeadEndPoint);
                this.diagram1.Model.AppendChild(lConnector);
                this.diagram1.Model.SendToBack(lConnector);
            }
        }
        #endregion

        #region Event Handlers

        private void apply_Click(object sender, EventArgs e)
        {
            float parseVal;

            if (txtSLength.Text != string.Empty && float.TryParse(txtSLength.Text.ToString(), out parseVal))
                ((SymmetricLayoutManager)this.diagram1.LayoutManager).SpringLength = parseVal;
            else
                txtSLength.Text = ((SymmetricLayoutManager)this.diagram1.LayoutManager).SpringLength.ToString();

            double parsedouble;

            if (txtSFactor.Text != string.Empty && double.TryParse(txtSFactor.Text.ToString(), out parsedouble) && parsedouble < 3.00)
                ((SymmetricLayoutManager)this.diagram1.LayoutManager).SpringFactor = parsedouble;
            else
                txtSFactor.Text = ((SymmetricLayoutManager)this.diagram1.LayoutManager).SpringFactor.ToString();

            int parseInt;

            if (txtMaxIter.Text != string.Empty && int.TryParse(txtMaxIter.Text.ToString(), out parseInt))
                ((SymmetricLayoutManager)this.diagram1.LayoutManager).MaxIteraction = parseInt;
            else
                txtMaxIter.Text = ((SymmetricLayoutManager)this.diagram1.LayoutManager).MaxIteraction.ToString();
            
            ((SymmetricLayoutManager)this.diagram1.LayoutManager).AutoLayout = chkAutoLayout.Checked;
            Layouting();
        }

        private void dialog_BeginLayout(SymmetricLayoutManager layout)
        {           
            this.diagram1.LayoutManager = layout;
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