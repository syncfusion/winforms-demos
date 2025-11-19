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
using DemoCommon.Diagram;
using Syncfusion.Windows.Forms;

namespace Grouping
{
    public partial class Form1 : MetroForm
    {
#region Class members
        /// <summary>
        /// Indicate in context menu needed to show.
        /// </summary>
        private bool m_bShowMenu = true;
#endregion

#region Form Initialize
        public Form1()
        {
            InitializeComponent();
            diagram1.Model.EnableSelectionListSubstitute = false;
			diagram1.DefaultContextMenuEnabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diagram1.Model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Syncfusion.Windows.Forms.Diagram.Rectangle rect = new Syncfusion.Windows.Forms.Diagram.Rectangle(100, 50, 100, 75);
            rect.FillStyle.Color = Color.FromArgb(242,242,242);
            rect.FillStyle.ForeColor = Color.White;
            rect.FillStyle.Type = FillStyleType.LinearGradient;
            rect.LineStyle.LineWidth = 1;
            AddLabel(rect);

            Syncfusion.Windows.Forms.Diagram.RoundRect roundRect = new Syncfusion.Windows.Forms.Diagram.RoundRect(220, 0, 100, 75, MeasureUnits.Pixel);
            roundRect.FillStyle.Color = Color.FromArgb(242, 242, 242);
            roundRect.FillStyle.ForeColor = Color.White;
            roundRect.FillStyle.Type = FillStyleType.LinearGradient;
            roundRect.LineStyle.LineWidth = 1;
            AddLabel(roundRect);

            Ellipse ellipse1 = new Ellipse(100, 200, 100, 80);
            ellipse1.Name = "Start/Stop";
            ellipse1.FillStyle.Color = Color.FromArgb(242, 242, 242);
            ellipse1.FillStyle.ForeColor = Color.White;
            ellipse1.FillStyle.Type = FillStyleType.LinearGradient;
            ellipse1.LineStyle.LineWidth = 1;
            AddLabel(ellipse1);
            diagram1.Model.AppendChild(ellipse1);

            Polygon poly = new Polygon(new PointF[] { new PointF(15, 0), new PointF(0, 45), new PointF(15, 90), new PointF(60, 90), new PointF(75, 45), new PointF(60, 0) });
            poly = new Polygon(new PointF[] { new PointF(45, 0), new PointF(0, 45), new PointF(45, 90), new PointF(90, 45) });
            poly.Name = "Decision";
            poly.PinPoint = new PointF(350, 230);
            poly.FillStyle.Color = Color.FromArgb(242,242,242);
            poly.FillStyle.ForeColor = Color.White;
            poly.FillStyle.Type = FillStyleType.LinearGradient;
            poly.LineStyle.LineWidth = 1;
            AddLabel(poly);
            diagram1.Model.AppendChild(poly);

            Syncfusion.Windows.Forms.Diagram.Rectangle rect1 = new Syncfusion.Windows.Forms.Diagram.Rectangle(100, 350, 100, 75);
            rect1.Name = "Process";
            rect1.FillStyle.Color = Color.FromArgb(242, 242, 242);
            rect1.FillStyle.ForeColor = Color.White;
            rect1.FillStyle.Type = FillStyleType.LinearGradient;
            rect1.LineStyle.LineWidth = 1;
            AddLabel(rect1);
            diagram1.Model.AppendChild(rect1);

            Group group = new Group();
            group.AppendChild(rect);
            group.AppendChild(roundRect);
            diagram1.Model.AppendChild(group);
            Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label();
            label.Container = group;
            label.Text = "Group1";
            label.FontStyle.Family = "Segoe UI";
            label.FontStyle.Size = 9;
            group.Labels.Add(label);
            diagram1.View.BackgroundColor = Color.White;
            diagram1.View.SelectionList.Clear();
            this.diagram1.MouseDown += new MouseEventHandler(diagram1_MouseDown);
            this.diagram1.MouseUp += new MouseEventHandler(diagram1_MouseUp);

            // Wire up OnIdle processing
            Application.Idle += new EventHandler(Application_Idle);
        }
#endregion

#region Event Handlers

        void Application_Idle(object sender, EventArgs e)
        {
            if (this.diagram1.Controller != null)
            {
                int count = this.diagram1.Controller.SelectionList.Count;
                groupToolStripMenuItem.Enabled = (count > 1);
                unGroupToolStripMenuItem.Enabled = true;
                bringToFrontToolStripMenuItem.Enabled = (count > 0);
                bringForwardToolStripMenuItem.Enabled = (count > 0);
                sendBackwardToolStripMenuItem.Enabled = (count > 0);
                sendToBackToolStripMenuItem.Enabled = (count > 0);
            }
        }

        void diagram1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && m_bShowMenu)
            {
                if (this.diagram1.Controller.SelectionList.Count > 0)
                    this.ShowNodeContextMenu(e);               
            }

            m_bShowMenu = true;
        }

        void diagram1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.diagram1.Controller.ActiveTool != null)
            {
                m_bShowMenu = !this.diagram1.Controller.ActiveTool.InAction;
            }
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram1.Controller.Group();
        }

        private void unGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram1.Controller.UnGroup();
        }

        private void bringToFrontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram1.Controller.BringToFront();
        }

        private void bringForwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram1.Controller.BringForward();
        }

        private void sendBackwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram1.Controller.SendBackward();
        }

        private void sendToBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram1.Controller.SendToBack();
        }
#endregion

#region Helper Methods
        /// <summary>
        /// The Node ContextMenu contains menu items that perform operations on the particular node over 
        /// which the mouse right click took place.
        /// </summary>
        /// <param name="e"></param>
        private void ShowNodeContextMenu(MouseEventArgs e)
        {            
            this.contextMenuStrip1.Show(this.diagram1, new Point(e.X, e.Y));
            this.diagram1.Refresh();
        }

        /// <summary>
        /// Adds the label to the given Node.
        /// </summary>
        /// <param name="pathNode">Node</param>
        private static void AddLabel(Syncfusion.Windows.Forms.Diagram.PathNode pathNode)
        {
            Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label(pathNode, pathNode.Name);
            label.FontColorStyle.Color = Color.Black;
            label.FontStyle.Family = "Segoe UI";
            pathNode.Labels.Add(label);
        }

#endregion

    }
}