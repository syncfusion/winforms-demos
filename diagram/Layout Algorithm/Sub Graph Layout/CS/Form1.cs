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

namespace SubGraphLayout
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
            PopulateFields(SetDataSource());
            this.diagram1.View.SelectionList.Clear();

            SubgraphTreeLayoutManager subLayout = new SubgraphTreeLayoutManager(this.diagram1.Model, 0, 20, 50);
            subLayout.LeftMargin = 100;
            subLayout.TopMargin = 50;
            subLayout.HorizontalSpacing = 75;
            subLayout.VerticalSpacing = 50;
            this.diagram1.LayoutManager = subLayout;
            this.diagram1.LayoutManager.UpdateLayout(null);

            txtHSpacing.Text = subLayout.HorizontalSpacing.ToString();
            txtVSpacing.Text = subLayout.VerticalSpacing.ToString();
            txtLMarigin.Text = subLayout.LeftMargin.ToString();
            txtTMarigin.Text = subLayout.TopMargin.ToString();
            chkAutoLayout.Checked = subLayout.AutoLayout;

            diagram1.EndUpdate();
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

        #region InitializeDiagram

        /// <summary>
        /// Generates the Datatable
        /// </summary>
        /// <returns>returns the table</returns>
        private DataTable SetDataSource()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("ParentID", typeof(string));
            //
            // Here we add five DataRows.
            //
            table.Rows.Add("1", "Root", string.Empty);
            table.Rows.Add("2", "Node 1", "1");
            table.Rows.Add("3", "Node 2", "1");
            table.Rows.Add("4", "Node 3", "1");
            table.Rows.Add("8", "Graph 1", "1");
            table.Rows.Add("9", "Node 11", "8");
            table.Rows.Add("10", "Node 12", "8");
            table.Rows.Add("11", "Graph 2", "8");
            table.Rows.Add("12", "Node 21", "11");
            table.Rows.Add("13", "Node 22", "11");

            return table;
        }

        /// <summary>
        /// Initialize the nodes in daigram
        /// </summary>
        private void PopulateFields(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Syncfusion.Windows.Forms.Diagram.Rectangle rect = new Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 80, 50);
                rect.FillStyle.Color = Color.FromArgb(159, 80, 0);
                rect.FillStyle.ForeColor = Color.FromArgb(255, 149, 149);
                rect.FillStyle.Type = FillStyleType.LinearGradient;
                rect.LineStyle.LineColor = Color.White;
                //rect.EnableShading = true;
                rect.Name = "Node" + dt.Rows[i]["ID"].ToString();
                Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label(rect, dt.Rows[i]["Title"].ToString());
                label.FontStyle.Family = "Verdana";
                label.FontStyle.Size = 8;
                label.FontColorStyle.Color = Color.White;
                rect.Labels.Add(label);
                diagram1.Model.AppendChild(rect);
                if (!string.IsNullOrEmpty(dt.Rows[i]["ParentID"].ToString()))
                {
                    Syncfusion.Windows.Forms.Diagram.Rectangle parentNode = diagram1.Model.Nodes.FindNodeByName("Node" + dt.Rows[i]["ParentID"].ToString()) as Syncfusion.Windows.Forms.Diagram.Rectangle;
                    string ss = parentNode.Name;
                    ConnectNodes(parentNode, rect);
                }

            }
        }

        /// <summary>
        /// Connects the given nodes
        /// </summary>
        /// <param name="parentNode">Parent Node</param>
        /// <param name="childNode">Child node</param>
        private void ConnectNodes(Node parentNode, Node childNode)
        {
            if (parentNode != null && childNode != null)
            {
                LineConnector conn = new LineConnector(PointF.Empty, new PointF(0, 1));
                conn.LineStyle.LineColor = Color.Gray; 
                Decorator decor = conn.HeadDecorator;
                decor.DecoratorShape = DecoratorShape.Filled45Arrow;
                decor.FillStyle.Color = Color.White; 
                decor.LineStyle.LineColor = Color.Gray;

                this.diagram1.Model.AppendChild(conn);

                parentNode.CentralPort.TryConnect(conn.TailEndPoint);
                childNode.CentralPort.TryConnect(conn.HeadEndPoint);

                this.diagram1.Model.SendToBack(conn);

            }
        }
        #endregion

        #region Event Handlers
       

        private void dialog_BeginLayout(SubgraphTreeLayoutManager layout)
        {
            this.diagram1.LayoutManager = layout;
            Layouting();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            float rotationAngle = 0;
            float parseVal;
            if (txtHSpacing.Text != string.Empty && float.TryParse(txtHSpacing.Text.ToString(), out parseVal))
                ((SubgraphTreeLayoutManager)this.diagram1.LayoutManager).HorizontalSpacing = parseVal;
            else
                txtHSpacing.Text = ((SubgraphTreeLayoutManager)this.diagram1.LayoutManager).HorizontalSpacing.ToString();

            if (txtVSpacing.Text != string.Empty && float.TryParse(txtVSpacing.Text.ToString(), out parseVal))
                ((SubgraphTreeLayoutManager)this.diagram1.LayoutManager).VerticalSpacing = parseVal;
            else
                txtVSpacing.Text = ((SubgraphTreeLayoutManager)this.diagram1.LayoutManager).VerticalSpacing.ToString();

            if (txtLMarigin.Text != string.Empty && float.TryParse(txtLMarigin.Text.ToString(), out parseVal))
                ((SubgraphTreeLayoutManager)this.diagram1.LayoutManager).LeftMargin = parseVal;
            else
                txtLMarigin.Text = ((SubgraphTreeLayoutManager)this.diagram1.LayoutManager).LeftMargin.ToString();

            if (txtTMarigin.Text != string.Empty && float.TryParse(txtTMarigin.Text.ToString(), out parseVal))
                ((SubgraphTreeLayoutManager)this.diagram1.LayoutManager).TopMargin = parseVal;
            else
                txtTMarigin.Text = ((SubgraphTreeLayoutManager)this.diagram1.LayoutManager).TopMargin.ToString();


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
            ((SubgraphTreeLayoutManager)this.diagram1.LayoutManager).RotationAngle = rotationAngle;
            ((SubgraphTreeLayoutManager)this.diagram1.LayoutManager).AutoLayout = chkAutoLayout.Checked;
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