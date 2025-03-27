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
using System.Collections;

namespace HierarchicalLayout
{
    public partial class Form1 : MetroForm
    {
        #region Members
        HierarchicLayoutManager hierarchicalLayout;
        #endregion

        #region Form Initialize
        public Form1()
        {
            InitializeComponent();

            diagram1.BeginUpdate();            
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            comboLytDirection.SelectedIndex = 0;
            PopulateFields(SetDataSource());
            DiagramAppearance();

            hierarchicalLayout = new HierarchicLayoutManager(this.diagram1.Model, 0, 70, 40);
            hierarchicalLayout.LeftMargin = 50;
            hierarchicalLayout.TopMargin = 50;
            this.diagram1.LayoutManager = hierarchicalLayout;
            this.diagram1.LayoutManager.UpdateLayout(null);

            txtHSpacing.Text = hierarchicalLayout.HorizontalSpacing.ToString();
            txtVSpacing.Text = hierarchicalLayout.VerticalSpacing.ToString();
            txtLMarigin.Text = hierarchicalLayout.LeftMargin.ToString();
            txtTMarigin.Text = hierarchicalLayout.TopMargin.ToString();
            chkAutoLayout.Checked = hierarchicalLayout.AutoLayout;

            diagram1.EndUpdate();
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Change's the appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {                   
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.View.BackgroundColor = Color.White;
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.View.SelectionList.Clear();
        }
        #endregion

        #region InitializeDiagram
        /// <summary>
        /// Generate the Data source for diagram
        /// </summary>
        /// <returns></returns>
        private DataTable SetDataSource()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Designation", typeof(string));
            table.Columns.Add("ParentName", typeof(string));
            //
            // Here we add five DataRows.
            //
            table.Rows.Add("1", "John Smith", "CEO", string.Empty);
            table.Rows.Add("2", "Joe Robert", "Manager-SLS", "John Smith");
            table.Rows.Add("3", "Jack Kent", "Manager-Mkt", "John Smith");
            table.Rows.Add("4", "Ravi kumar", "Manager-DEV", "John Smith");
            table.Rows.Add("5", "Sue Raymond", "CSR", "Joe Robert");
            table.Rows.Add("6", "Lisa Simpson", "CSR", "Joe Robert");
            table.Rows.Add("7", "Bob Woley", "PM", "Jack Kent");
            table.Rows.Add("8", "Ron Jones", "Engineer", "Ravi kumar");
            table.Rows.Add("9", "Dave Mason", "Engineer", "Ravi kumar");

            return table;
        }
        /// <summary>
        /// Initialize the nodes in daigram
        /// </summary>
        private void PopulateFields(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Syncfusion.Windows.Forms.Diagram.RoundRect rect = new Syncfusion.Windows.Forms.Diagram.RoundRect(0, 0, 120, 60, MeasureUnits.Pixel);
                rect.FillStyle.Color = Color.FromArgb(255, 86, 4);
                rect.FillStyle.ForeColor = Color.FromArgb(255, 165, 74);
                rect.LineStyle.LineColor = Color.White;
                rect.FillStyle.Type = FillStyleType.LinearGradient;
                //rect.EnableShading = true;
                rect.Name =  dt.Rows[i]["Name"].ToString();
                Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label(rect, dt.Rows[i]["Name"].ToString()  );
                label.FontStyle.Family = "Segoe UI";
                label.FontStyle.Size = 9;
                label.FontColorStyle.Color = Color.White;                
                rect.Labels.Add(label);
                Syncfusion.Windows.Forms.Diagram.Label label1 = new Syncfusion.Windows.Forms.Diagram.Label(rect, dt.Rows[i]["Designation"].ToString());
                label1.FontStyle.Family = "Segoe UI";
                label1.FontStyle.Size = 9;
                label1.FontColorStyle.Color = Color.White;                
                label1.OffsetX = rect.BoundingRectangle.Width / 2-label1.Size.Width /2;
                label1.OffsetY = rect.BoundingRectangle.Height / 2 + 5;
                rect.Labels.Add(label1);
                diagram1.Model.AppendChild(rect);
                if (!string.IsNullOrEmpty(dt.Rows[i]["ParentName"].ToString()))
                {
                    Syncfusion.Windows.Forms.Diagram.RoundRect parentNode = diagram1.Model.Nodes.FindNodeByName(dt.Rows[i]["ParentName"].ToString()) as Syncfusion.Windows.Forms.Diagram.RoundRect;
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
                OrgLineConnector conn = new OrgLineConnector(PointF.Empty, new PointF(0, 1));
                conn.VerticalDistance = 35;
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
                ((HierarchicLayoutManager)this.diagram1.LayoutManager).HorizontalSpacing = parseVal;
            else
                txtHSpacing.Text = ((HierarchicLayoutManager)this.diagram1.LayoutManager).HorizontalSpacing.ToString();

            if (txtVSpacing.Text != string.Empty && float.TryParse(txtVSpacing.Text.ToString(), out parseVal))
                ((HierarchicLayoutManager)this.diagram1.LayoutManager).VerticalSpacing = parseVal;
            else
                txtVSpacing.Text = ((HierarchicLayoutManager)this.diagram1.LayoutManager).VerticalSpacing.ToString();

            if (txtLMarigin.Text != string.Empty && float.TryParse(txtLMarigin.Text.ToString(), out parseVal))
                ((HierarchicLayoutManager)this.diagram1.LayoutManager).LeftMargin = parseVal;
            else
                txtLMarigin.Text = ((HierarchicLayoutManager)this.diagram1.LayoutManager).LeftMargin.ToString();

            if (txtTMarigin.Text != string.Empty && float.TryParse(txtTMarigin.Text.ToString(), out parseVal))
                ((HierarchicLayoutManager)this.diagram1.LayoutManager).TopMargin = parseVal;
            else
                txtTMarigin.Text = ((HierarchicLayoutManager)this.diagram1.LayoutManager).TopMargin.ToString();

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
            ((HierarchicLayoutManager)this.diagram1.LayoutManager).RotationAngle = rotationAngle;
            ((HierarchicLayoutManager)this.diagram1.LayoutManager).AutoLayout = chkAutoLayout.Checked;
            Layouting();
        }      

        private void addMember_Click(object sender, EventArgs e)
        {            
            AddMemberInfoDlg infoDlg = new AddMemberInfoDlg(diagram1.Model.Nodes);
            if (infoDlg.ShowDialog(this) == DialogResult.OK)
            {
                Node memSym = CreateMember(infoDlg.MemberName, infoDlg.Title);
                Node parentNode = diagram1.Model.Nodes.FindNodeByName(infoDlg.ParentName.ToString());
                if (infoDlg.MemberName != string.Empty && infoDlg.Title != string.Empty)
                {
                this.diagram1.Model.AppendChild(memSym);
                }
                else
                {
                    MessageBox.Show("Please Enter Name and Role");
                    memSym = null;
                }
                if(parentNode != null && memSym !=null)
                    ConnectNodes(parentNode, memSym);
                HierarchicLayoutManager hlyt = new HierarchicLayoutManager(this.diagram1.Model, ((HierarchicLayoutManager)this.diagram1.LayoutManager).RotationAngle, float.Parse(txtVSpacing.Text), float.Parse(txtHSpacing.Text));
                hlyt.LeftMargin = float.Parse(txtLMarigin.Text);
                hlyt.TopMargin = float.Parse(txtTMarigin.Text);
                this.diagram1.LayoutManager = hlyt;
                Layouting();
                diagram1.View.SelectionList.Clear();
            }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Create the new member with specified name and title.
        /// </summary>
        /// <param name="strMemberName">The member name.</param>
        /// <param name="strTitle">The title.</param>
        private Node CreateMember(string strMemberName, string strTitle)
        {
            SizeF szSize = new SizeF(140, 60);
            Syncfusion.Windows.Forms.Diagram.RoundRect rnRect = new Syncfusion.Windows.Forms.Diagram.RoundRect(0, 0, 120, 60, MeasureUnits.Pixel);
            rnRect.FillStyle.Color = Color.FromArgb(255, 86, 4);
            rnRect.FillStyle.ForeColor = Color.FromArgb(255, 165, 74);
            rnRect.LineStyle.LineColor = Color.White;
            rnRect.FillStyle.Type = FillStyleType.LinearGradient;
            Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label(rnRect, strMemberName);
            label.FontStyle.Family = "Segoe UI";
            label.FontStyle.Size = 9;
            label.FontColorStyle.Color = Color.White;
            rnRect.Labels.Add(label);
            Syncfusion.Windows.Forms.Diagram.Label label1 = new Syncfusion.Windows.Forms.Diagram.Label(rnRect, strTitle);
            label1.FontStyle.Family = "Segoe UI";
            label1.FontStyle.Size = 9;
            label1.FontColorStyle.Color = Color.White;
            label1.OffsetX = rnRect.BoundingRectangle.Width / 2 - label1.Size.Width / 2;
            label1.OffsetY = rnRect.BoundingRectangle.Height / 2 + 5;
            rnRect.Labels.Add(label1);
            return rnRect;
        }

        private void Layouting()
        {            
            this.diagram1.LayoutManager.UpdateLayout(null);
            this.diagram1.UpdateView();
        }      
        #endregion
    }
    
}