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
using System.Drawing.Printing;
using Syncfusion.Windows.Forms.Diagram;
using System.Collections;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing.Drawing2D;
using System.IO;
using Syncfusion.SVG.IO;
using System.Drawing.Imaging;
using Syncfusion.Windows.Forms;

namespace LayerDemo
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
            this.diagram1.BeginUpdate();               
            InitailizeDiagram();
            DiagramAppearance();
            this.diagram1.EndUpdate();         
            comboLayers.SelectedIndex = 0;           
            comboLayers.SelectedIndexChanged += new EventHandler(comboLayers_SelectedIndexChanged);
            this.diagram1.Focus();
            
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Changes the appearance of the Diagram
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.HorizontalRuler.BackgroundColor = Color.White;
            this.diagram1.VerticalRuler.BackgroundColor = Color.White;  
            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.LightGray;
            this.diagram1.View.Grid.VerticalSpacing = 15;
            this.diagram1.View.Grid.HorizontalSpacing = 15;
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;          
            this.diagram1.View.SelectionList.Clear();
        }

        #endregion

        #region InitializeDiagram
        /// <summary>
        /// Initialize the Diagram
        /// </summary>
        protected void InitailizeDiagram()
        {
            Layer rectanglelayer = CreateLayer("Rectangle Layer");
            Layer ellipselayer = CreateLayer("Ellipse Layer");
            Layer roundRectlayer = CreateLayer("RoundRect Layer");
                       
            float rectPinPointX = 50, ellipsePinPointX = 300, roundRectPinPointX = 550, PinPointY = 75;
            for (int i = 0; i < 4; i++)
            {
                Syncfusion.Windows.Forms.Diagram.Rectangle rect = new Syncfusion.Windows.Forms.Diagram.Rectangle(rectPinPointX, PinPointY, 200, 50);
                rect.FillStyle.Color = Color.FromArgb(240, 242, 240);
                rect.FillStyle.ForeColor = Color.White;
                rect.FillStyle.Type = FillStyleType.LinearGradient;
                rect.LineStyle.LineColor = Color.DarkGray;
                //rect.Name = "Rectangle" + (i + 1);
                AddLabel(rect.Name, rect);
                diagram1.Model.AppendChild(rect);
                rectanglelayer.Nodes.Add(rect);
                rect.Layers.Add(rectanglelayer);

                Syncfusion.Windows.Forms.Diagram.Ellipse ellipse = new Syncfusion.Windows.Forms.Diagram.Ellipse(ellipsePinPointX, PinPointY, 200, 50);
                ellipse.FillStyle.Color = Color.FromArgb(240, 242, 240);
                ellipse.FillStyle.ForeColor = Color.White;
                ellipse.FillStyle.Type = FillStyleType.LinearGradient;
                ellipse.LineStyle.LineColor = Color.DarkGray;
                // ellipse.Name = "Ellipse" + (i + 1);
                AddLabel(ellipse.Name, ellipse);
                diagram1.Model.AppendChild(ellipse);
                ellipselayer.Nodes.Add(ellipse);
                ellipse.Layers.Add(ellipselayer);


                Syncfusion.Windows.Forms.Diagram.RoundRect roundRect = new Syncfusion.Windows.Forms.Diagram.RoundRect(roundRectPinPointX, PinPointY, 200, 50, MeasureUnits.Pixel);
                roundRect.FillStyle.Color = Color.FromArgb(240, 242, 240);
                roundRect.FillStyle.ForeColor = Color.White;
                roundRect.FillStyle.Type = FillStyleType.LinearGradient;
                roundRect.LineStyle.LineColor = Color.DarkGray;
                // roundRect.Name = "RoundRect" + (i + 1);
                AddLabel(roundRect.Name, roundRect);
                diagram1.Model.AppendChild(roundRect);
                roundRectlayer.Nodes.Add(roundRect);
                roundRect.Layers.Add(roundRectlayer);

                PinPointY += 125;

            }
        }

        /// <summary>
        /// Creates the Layer 
        /// </summary>
        /// <param name="strName">Layer Name</param>
        /// <returns></returns>
        private Layer CreateLayer(string strName)
        {
            Layer layer = new Layer(this.diagram1.Model, strName);
            this.diagram1.Model.Layers.Add(layer);
            return layer;
        }

        /// <summary>
        /// Adds the label to the given node.
        /// </summary>
        /// <param name="Text">Label's text</param>
        /// <param name="node">Node</param>
        private void AddLabel(string Text, PathNode node)
        {
            Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label(node, Text);
            label.Position = Position.Center;
            label.FontStyle.Size = 9;
            label.FontStyle.Family = "verdana";
            node.Labels.Add(label);
        }

        /// <summary>
        /// Appends TextNode to the Layer
        /// </summary>
        /// <param name="strText">TextNode's Text</param>
        /// <param name="ptPinPoint">TextNode's Location</param>
        /// <param name="layer">layer</param>
        private void InsertTextNode(string strText, PointF ptPinPoint, Layer layer)
        {
            Syncfusion.Windows.Forms.Diagram.TextNode txtnode = new TextNode(strText);
            txtnode.FontStyle.Size = 10;
            txtnode.FontStyle.Family = "verdana";
            txtnode.FontColorStyle.Color = Color.Black;
            txtnode.LineStyle.LineColor = Color.Transparent;
            txtnode.SizeToText(SizeF.Empty);
            txtnode.PinPoint = ptPinPoint;
            layer.Nodes.Add(txtnode);
            txtnode.Layers.Add(layer);
            diagram1.Model.AppendChild(txtnode);
            diagram1.Model.BringToFront(txtnode);
        }
        #endregion

        #region Event Handlers
        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram1.Controller.ActivateTool("RectangleTool");
        }

        private void roundRectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram1.Controller.ActivateTool("RoundRectTool");
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram1.Controller.ActivateTool("EllipseTool");
        }

        private void polygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram1.Controller.ActivateTool("PolygonTool");
        }
        private void createLyr_Click(object sender, EventArgs e)
        {
            if (chkEnableNewlayer.Checked)
            {
                foreach (Layer layer in diagram1.Model.Layers)
                {
                    if (layer.Enabled)
                        layer.Enabled = false;
                }
            }

            Layer nwLayer = new Layer();
            nwLayer.Name = txtLayerName.Text;
            nwLayer.Enabled = chkEnableNewlayer.Checked;
            if (nwLayer.Name != string.Empty)
            {
                comboLayers.Items.Add(nwLayer.Name);
                diagram1.Model.Layers.Add(nwLayer);
            }
            if (chkEnableNewlayer.Checked)
                diagram1.Model.ActiveLayers.Add(nwLayer);
            comboLayers.SelectedIndex = comboLayers.Items.Count - 1;
        }

        private void apply_Click(object sender, EventArgs e)
        {
            this.diagram1.Model.BeginUpdate();
            if (comboLayers.Items.Count > 0 && comboLayers.SelectedItem != null)
            {
                Layer curLayer = this.diagram1.Model.Layers[comboLayers.SelectedItem.ToString()];
                if (chkVisibleLyr.Checked)
                {
                    curLayer.Visible = true;
                }
                else
                {
                    curLayer.Visible = false;
                }

                if (chkEnableLyr.Checked)
                {
                    chkEditingLyr.Enabled = true;
                    curLayer.Enabled = true;
                }
                else
                {
                    chkEditingLyr.Enabled = false;
                    curLayer.Enabled = false;
                }
                if (chkRemoveLyr.Checked)
                {
                    this.diagram1.BeginUpdate();
                    Layer lyr = diagram1.Model.Layers[comboLayers.SelectedItem.ToString()];
                    while (diagram1.Model.Layers[comboLayers.SelectedItem.ToString()].Nodes.Count > 0)
                    {
                        diagram1.Model.Nodes.Remove(diagram1.Model.Layers[comboLayers.SelectedItem.ToString()].Nodes[0]);
                    }
                    diagram1.Model.Layers.Remove(diagram1.Model.Layers[comboLayers.SelectedItem.ToString()]);
                    comboLayers.Items.Remove(comboLayers.SelectedItem);
                    comboLayers.Text = string.Empty;
                    this.diagram1.EndUpdate();
                }
                if (comboLayers.SelectedItem != null)
                {
                    if (chkEditingLyr.Checked)
                    {
                        Layer lyr = diagram1.Model.Layers[comboLayers.SelectedItem.ToString()];
                        lyr.Constraints = Constraints.UserInteraction;
                    }
                    else
                    {
                        Layer lyr = diagram1.Model.Layers[comboLayers.SelectedItem.ToString()];
                        lyr.Constraints = Constraints.APIUpdate;
                        diagram1.View.SelectionList.Clear();
                    }
                }
                this.diagram1.EndUpdate();
                this.diagram1.Invalidate(true);
            }
        }

        private void comboLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Layer lyr = this.diagram1.Model.Layers[comboLayers.SelectedItem.ToString()];
            if (lyr != null)
            {
                chkEnableLyr.Checked = lyr.Enabled;
                chkVisibleLyr.Checked = lyr.Visible;
            }
        }      

        #endregion      
           
    }
}


