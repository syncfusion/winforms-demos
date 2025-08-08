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
using System.Xml;
using System.Collections;


namespace DatabaseBinding
{
    public partial class Form1 : MetroForm
    {       

        #region Form Initialization
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diagram1.BeginUpdate();
                       
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(String));
            table.Columns.Add("Title", typeof(String));           
            table.Columns.Add("ParentID", typeof(String));
            table.Columns.Add("Designation", typeof(String));
            //'
            //' Here we add five DataRows.
            //'
            table.Rows.Add("1", "John Smith",  String.Empty, "CEO");
            table.Rows.Add("2", "Joe Robert", "1", "Manager SLS");
            table.Rows.Add("3", "Jack Kent",  "1", "Manager Mkt");
            table.Rows.Add("4", "Ravi Kumar",  "2", "Engineer");
            table.Rows.Add("5", "Sue Raymond",  "2", "Engineer");
            table.Rows.Add("6", "Lisa simpson",  "4", "Junior Engineer");
            table.Rows.Add("7", "Bob Woley",  "5", "Junior Engineer");
            table.Rows.Add("8", "Ron Jones",  "3", "CSR");
            table.Rows.Add("9", "Dave Mason",  "3", "CSR");
            table.Rows.Add("10", "John Williams",  "3", "CSR");
            dataGridView1.DataSource = table;
            
            PopulateFields(table);
            diagram1.Model.LineStyle.LineColor = Color.Transparent;
          
            HierarchicLayoutManager orgchartLayout = new HierarchicLayoutManager(diagram1.Model, 0, 40, 20);
            orgchartLayout.HorizontalSpacing = 40;
            orgchartLayout.VerticalSpacing = 70;
            orgchartLayout.LeftMargin = 20;
            orgchartLayout.TopMargin = 60;
            diagram1.LayoutManager = orgchartLayout;
            diagram1.LayoutManager.UpdateLayout(null); 
            DiagramAppearance();      

            diagram1.EndUpdate();
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Change's the appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.Model.LineStyle.LineColor = Color.LightGray;
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
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.View.BackgroundColor = Color.White;
            this.diagram1.View.SelectionList.Clear();
        }
        #endregion

        #region Initialization of Diagram

        /// <summary>
        /// Generates the diagram from the data source.
        /// </summary>
        /// <param name="dt">Data Source to be passed</param>
        private void PopulateFields(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                Syncfusion.Windows.Forms.Diagram.RoundRect rect = GetRoundRect();
                rect.Name = "Node" + dt.Rows[i]["ID"].ToString();
                string labelText = dt.Rows[i]["Title"].ToString() + "\r\n" + dt.Rows[i]["Designation"].ToString();
                // create a new label for roundrect
                Syncfusion.Windows.Forms.Diagram.Label label = AddLabel(rect, labelText);
                rect.Labels.Add(label);
                diagram1.Model.AppendChild(rect);
                if (!string.IsNullOrEmpty(dt.Rows[i]["ParentID"].ToString()))
                {
                    Syncfusion.Windows.Forms.Diagram.RoundRect parentNode = diagram1.Model.Nodes.FindNodeByName("Node" + dt.Rows[i]["ParentID"].ToString()) as Syncfusion.Windows.Forms.Diagram.RoundRect;
                    string ss = parentNode.Name;              
                    ConnectNodes(parentNode, rect);
                }

            }
        }

        /// <summary>
        /// New function for adding label to the Rectangle
        /// </summary>
        /// <param name="rect">Container of the Label</param>
        /// <param name="labelText">Text of the Label</param>
        /// <returns></returns>
        private static Syncfusion.Windows.Forms.Diagram.Label AddLabel(Syncfusion.Windows.Forms.Diagram.RoundRect rect, string labelText)
        {
            Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label(rect, labelText);
            label.FontStyle.Family = "Verdana";
            label.FontStyle.Size = 8;
            label.FontColorStyle.Color = Color.White;
            label.HorizontalAlignment = StringAlignment.Center;
            label.VerticalAlignment = StringAlignment.Center;
            return label;
        }

        /// <summary>
        /// create a new RoundRect
        /// </summary>
        /// <returns></returns>
        private static Syncfusion.Windows.Forms.Diagram.RoundRect GetRoundRect()
        {
            Syncfusion.Windows.Forms.Diagram.RoundRect rect = new Syncfusion.Windows.Forms.Diagram.RoundRect(0, 0, 110, 50, MeasureUnits.Pixel);
            rect.FillStyle.Color = Color.FromArgb(152, 152, 186);
            rect.FillStyle.ForeColor = Color.FromArgb(102, 102, 153);
            rect.LineStyle.LineColor = Color.SlateBlue;
            rect.FillStyle.Type = FillStyleType.LinearGradient;
            return rect;
        }

        /// <summary>
        /// Create a new function for connect the nodes.
        /// </summary>
        /// <param name="parentNode">ParentNode</param>
        /// <param name="childNode">ChildNode</param>
        private void ConnectNodes(Node parentNode, Node childNode)
        {
            if (parentNode != null && childNode != null)
            {
                //Create a new instance for OrgLineConnector.
                OrgLineConnector orgCon = new OrgLineConnector(new PointF(0, 0), new PointF(0, 1));                
                orgCon.LineStyle.LineColor = Color.SlateBlue;
                orgCon.VerticalDistance = parentNode.BoundingRectangle.Height-25;
                // Set the value for decorator shape.
                Decorator decor = orgCon.HeadDecorator;
                decor.DecoratorShape = DecoratorShape.Filled45Arrow;
                decor.Size = new SizeF(10, 10);
                decor.FillStyle.Color = Color.SlateBlue;
                decor.LineStyle.LineColor = Color.SlateBlue;
                // add connector to Diagram control.

                parentNode.CentralPort.TryConnect(orgCon.TailEndPoint);
                childNode.CentralPort.TryConnect(orgCon.HeadEndPoint);               
                this.diagram1.Model.AppendChild(orgCon);
                this.diagram1.Model.SendToBack(orgCon);

            }
        }
        #endregion
                             
    }
   
}
