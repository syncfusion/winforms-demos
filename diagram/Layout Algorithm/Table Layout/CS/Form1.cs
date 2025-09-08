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

namespace TableLayout
{
    public partial class Form1 : MetroForm
    {
        #region Members       

        #endregion

        #region Form Initialize
        public Form1()
        {
            InitializeComponent();

            diagram1.BeginUpdate();
            
            DiagramAppearance();
            PopulateNodes();
            this.diagram1.View.SelectionList.Clear();

            TableLayoutManager tlLayout = new TableLayoutManager(this.diagram1.Model, 5, 5);
            tlLayout.LeftMargin = 50;
            tlLayout.TopMargin = 120;
            tlLayout.VerticalSpacing = 0;
            tlLayout.HorizontalSpacing = 0;
            tlLayout.CellSizeMode = CellSizeMode.EqualToMaxNode;
            tlLayout.Orientation = Orientation.Horizontal;
            tlLayout.MaxSize = new SizeF(1300, 600);
            this.diagram1.LayoutManager = tlLayout;
            this.diagram1.LayoutManager.UpdateLayout(null);

            txtHSpacing.Text = tlLayout.HorizontalSpacing.ToString();
            txtVSpacing.Text = tlLayout.VerticalSpacing.ToString();
            txtLMarigin.Text = tlLayout.LeftMargin.ToString();
            txtTMarigin.Text = tlLayout.TopMargin.ToString();
            chkAutoLayout.Checked = tlLayout.AutoLayout;
            comboCellSize.SelectedIndex = 0;
            comboExpandMode.SelectedIndex = 0;
            diagram1.EndUpdate();
        }

        #endregion

        /// <summary>
        /// Change's the appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {          
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;            
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.View.BackgroundColor = Color.White;

        }

        #region Initialize Diagram

        /// <summary>
        /// Initialize the nodes in daigram
        /// </summary>
        private void PopulateNodes()
        {
            Syncfusion.Windows.Forms.Diagram.Rectangle rect = GetRectangle();
            diagram1.Model.AppendChild(rect);
            for (int i = 0; i < 3; i++)
            {
                Syncfusion.Windows.Forms.Diagram.Rectangle rect1 = GetRectangle();
                AddLabel(rect1, "Header Label");
                diagram1.Model.AppendChild(rect1);
            }
            Syncfusion.Windows.Forms.Diagram.Rectangle rect2 = GetRectangle();
            diagram1.Model.AppendChild(rect2);
            int nodeNumber = 1;
            for (int i = 1; i <= 20; i++)
            {
                if (i == 1)
                {
                    Syncfusion.Windows.Forms.Diagram.Rectangle rect1 = GetRectangle();
                    AddLabel(rect1, "Add");
                    diagram1.Model.AppendChild(rect1);
                }
                else if ((i - 1) % 5 == 0)
                {
                    Syncfusion.Windows.Forms.Diagram.Rectangle rect1 = GetRectangle();
                    AddLabel(rect1, nodeNumber.ToString());
                    diagram1.Model.AppendChild(rect1);
                    nodeNumber += 1;
                }

                else if (i % 5 == 0)
                {
                    Syncfusion.Windows.Forms.Diagram.Rectangle rect1 = GetRectangle();
                    AddLabel(rect1, "Action");
                    diagram1.Model.AppendChild(rect1);
                }

                else
                {
                    Syncfusion.Windows.Forms.Diagram.Rectangle rect1 = GetRectangle();
                    AddLabel(rect1, "Component");
                    diagram1.Model.AppendChild(rect1);
                }

            }
        }

        /// <summary>
        /// Adds the Label to the given node
        /// </summary>
        /// <param name="rect1">Node</param>
        /// <param name="Text">Label's text</param>
        private static void AddLabel(Syncfusion.Windows.Forms.Diagram.Rectangle rect1, string Text)
        {
            Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label(rect1, Text);
            label.FontStyle.Family = "Segoe UI";
            // label.FontStyle.Size = 8;
            label.FontColorStyle.Color = Color.Black;
            rect1.Labels.Add(label);
        }

        /// <summary>
        /// Gets the new rectangle node
        /// </summary>
        /// <returns>returns the node</returns>
        private Syncfusion.Windows.Forms.Diagram.Rectangle GetRectangle()
        {
            Syncfusion.Windows.Forms.Diagram.Rectangle rect = new Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 100, 50);
            rect.FillStyle.Color = Color.FromArgb(242,242,242);
            rect.FillStyle.ForeColor = Color.White;
            rect.LineStyle.LineColor = Color.Black;
            rect.FillStyle.Type = FillStyleType.LinearGradient;
            //rect.EnableShading = true;
            return rect;
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
            CellSizeMode cellSizeMode = CellSizeMode.EqualToMaxNode;
            // get all parameters
            int nMaxColumnCount = int.Parse(txtMaxColumnCount.Text);
            int nMaxRowsCount = int.Parse(txtMaxRowsCount.Text);
            Orientation orientation = (comboExpandMode.SelectedIndex == 0) ? Orientation.Horizontal : Orientation.Vertical;
            if (comboCellSize.SelectedIndex == 0)
                 cellSizeMode = CellSizeMode.EqualToMaxNode;
            else if (comboCellSize.SelectedIndex == 1)
                cellSizeMode = CellSizeMode.Minimal;
            else if (comboCellSize.SelectedIndex == 2)
                cellSizeMode = CellSizeMode.MinimalTable;

            TableLayoutManager m_layoutManager = diagram1.LayoutManager as TableLayoutManager;
            m_layoutManager.MaxColummnCount = nMaxColumnCount;
            m_layoutManager.MaxRowsCount = nMaxRowsCount;
            m_layoutManager.CellSizeMode = cellSizeMode;
            m_layoutManager.HorizontalSpacing = float.Parse(txtHSpacing.Text);
            m_layoutManager.VerticalSpacing = float.Parse(txtVSpacing.Text);
            m_layoutManager.LeftMargin = float.Parse(txtLMarigin.Text);
            m_layoutManager.TopMargin = float.Parse(txtTMarigin.Text);
            m_layoutManager.MaxSize = new SizeF(float.Parse(txtMaxWidth.Text), float.Parse(txtMaxHeight.Text));
            m_layoutManager.Orientation = orientation;
            m_layoutManager.AutoLayout = chkAutoLayout.Checked;
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