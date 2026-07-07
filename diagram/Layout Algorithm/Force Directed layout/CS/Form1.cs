using Syncfusion.SVG.IO;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ForceDirectedlayout
{
    public partial class Form1 : MetroForm
    {
        #region Members        
        bool ValueCheck = false;
        #endregion

        #region Form Initialize
        public Form1()
        {
            InitializeComponent();

            this.diagram1.BeginUpdate();
            DiagramAppearance();
            PopulateNodes();

            this.diagram1.View.SelectionList.Clear();
            
            ForceDirectedTreeLayoutManager smtLayout = SetLayout();            
            diagram1.EndUpdate();
                       
            this.AttractionStrength.Value = (decimal)smtLayout.AttractionStrength;
             this.MaxIteration.Value = smtLayout.MaximumIteration;
            this.RepulsionStrength.Value = smtLayout.RepulsionStrength;
            chkAutoLayout.Checked = smtLayout.AutoLayout;
            diagram1.FitDocument();
            diagram1.Model.EventSink.NodeCollectionChanging += EventSink_NodeCollectionChanging;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Apply layout to the diagram
        /// </summary>
        /// <returns>returns the layout manager</returns>
        private ForceDirectedTreeLayoutManager SetLayout()
        {
            ForceDirectedTreeLayoutManager smtLayout = new ForceDirectedTreeLayoutManager(this.diagram1.Model, 110);

            smtLayout.MaximumIteration = 800;
            smtLayout.AttractionStrength = 0.6;
            smtLayout.RepulsionStrength = 16000;
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

        private void EventSink_NodeCollectionChanging(CollectionExEventArgs evtArgs)
        {
            if (evtArgs.ChangeType == CollectionExChangeType.Remove && evtArgs.Elements.Count == 1)
            {
                var deleteNode = evtArgs.Element as Node;
                // If needed, you can also explicitly remove connectors from the model
                var edgesEntering = (deleteNode.EdgesEntering as ArrayList).ToArray();
                var edgesLeaving = (deleteNode.EdgesLeaving as ArrayList).ToArray();

                // Remove all connectors connected to this node
                foreach (ConnectorBase connector in edgesEntering)
                {
                    diagram1.Model.Nodes.Remove(connector);
                }

                foreach (ConnectorBase connector in edgesLeaving)
                {
                    if (connector.ToNode != null)
                    {
                        this.diagram1.Model.RemoveChild(connector.ToNode as Node);
                    }
                    diagram1.Model.Nodes.Remove(connector);
                }
            }
        }

        #endregion

        #region Initialize Diagram

        /// <summary>
        /// Initialize the nodes in daigram
        /// </summary>
        private void PopulateNodes()
        {
            // Colors of the Nodes
            Color centerColor = Color.FromArgb(100, 181, 246);  // Light blue
            Color purpleA2 = Color.FromArgb(171, 71, 188);      // Purple for A2
            Color purpleA2Child = Color.FromArgb(206, 147, 216); // Light purple for A2 children
            Color blueA1 = Color.FromArgb(63, 81, 181);         // Blue for A1
            Color blueA1Child = Color.FromArgb(159, 168, 218);  // Light blue for A1 children
            Color pinkA3 = Color.FromArgb(233, 30, 99);         // Pink for A3 (UX Team)
            Color pinkA3Child = Color.FromArgb(244, 143, 177);  // Light pink for A3 children
            Color link = Color.Black;

            // Sizes of the Nodes
            SizeF centerSize = new SizeF(80, 80);
            SizeF deptSize = new SizeF(70, 70);
            SizeF mgrSize = new SizeF(60, 60);
            SizeF teamSize = new SizeF(45, 45);

            //
            // ---------- CENTER ----------
            //
            var Node1 = CreateNode("Departments", centerSize, centerColor, Color.Black);
            diagram1.Model.AppendChild(Node1);

            //
            // ---------- DEPARTMENTS (Different Colors) ----------
            //
            var Node2 = CreateNode("Sales Team", deptSize, purpleA2, Color.White);
            var Node3 = CreateNode("HR Team", deptSize, blueA1, Color.White);
            var Node4 = CreateNode("UX Team", deptSize, pinkA3, Color.Black);
            var Node5 = CreateNode("Development Team", deptSize, blueA1, Color.White);

            diagram1.Model.AppendChild(Node2);
            diagram1.Model.AppendChild(Node3);
            diagram1.Model.AppendChild(Node4);
            diagram1.Model.AppendChild(Node5);

            //
            // ---------- MANAGERS (With Category Colors) ----------
            //
            var Node6 = CreateNode("AGM-1", mgrSize, purpleA2, Color.White);
            var Node7 = CreateNode("AGM-2", mgrSize, purpleA2, Color.White);
            var Node8 = CreateNode("Manager", mgrSize, blueA1, Color.White);
            var Node9 = CreateNode("Manager-1", mgrSize, pinkA3, Color.Black);
            var Node10 = CreateNode("Manager-2", mgrSize, pinkA3, Color.Black);
            var Node11 = CreateNode("PO-1", mgrSize, blueA1, Color.White);
            var Node12 = CreateNode("PO-2", mgrSize, blueA1, Color.White);
            var Node13 = CreateNode("PO-3", mgrSize, blueA1, Color.White);
            var Node14 = CreateNode("PO-4", mgrSize, blueA1, Color.White);

            diagram1.Model.AppendChild(Node6);
            diagram1.Model.AppendChild(Node7);
            diagram1.Model.AppendChild(Node8);
            diagram1.Model.AppendChild(Node9);
            diagram1.Model.AppendChild(Node10);
            diagram1.Model.AppendChild(Node11);
            diagram1.Model.AppendChild(Node12);
            diagram1.Model.AppendChild(Node13);
            diagram1.Model.AppendChild(Node14);

            //
            // ---------- TEAMS (Color Coded by Category) ----------
            // AGM‑1 Teams (Purple)
            var Node15 = CreateNode("Team-1", teamSize, purpleA2Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node16 = CreateNode("Team-2", teamSize, purpleA2Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node17 = CreateNode("Team-3", teamSize, purpleA2Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node18 = CreateNode("Team-4", teamSize, purpleA2Child, Color.FromArgb(0x11, 0x11, 0x11));

            // AGM‑2 Teams (Purple)
            var Node19 = CreateNode("Team-1", teamSize, purpleA2Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node20 = CreateNode("Team-2", teamSize, purpleA2Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node21 = CreateNode("Team-3", teamSize, purpleA2Child, Color.FromArgb(0x11, 0x11, 0x11));

            // HR Manager Teams (Blue)
            var Node22 = CreateNode("Team-1", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node23 = CreateNode("Team-2", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node24 = CreateNode("Team-3", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));

            // UX Manager‑1 Teams (Pink)
            var Node25 = CreateNode("Team-1", teamSize, pinkA3Child, Color.Black);
            var Node26 = CreateNode("Team-2", teamSize, pinkA3Child, Color.Black);
            var Node27 = CreateNode("Team-3", teamSize, pinkA3Child, Color.Black);

            // UX Manager‑2 Teams (Pink)
            var Node28 = CreateNode("Team-1", teamSize, pinkA3Child, Color.Black);
            var Node29 = CreateNode("Team-2", teamSize, pinkA3Child, Color.Black);
            var Node30 = CreateNode("Team-3", teamSize, pinkA3Child, Color.Black);

            // PO‑1 Teams (Blue)
            var Node31 = CreateNode("Team-1", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node32 = CreateNode("Team-2", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node33 = CreateNode("Team-3", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node34 = CreateNode("Team-4", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));

            // PO‑2 Teams (Blue)
            var Node35 = CreateNode("Team-1", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node36 = CreateNode("Team-2", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node37 = CreateNode("Team-3", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node38 = CreateNode("Team-4", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));

            // PO‑3 Teams (Blue)
            var Node39 = CreateNode("Team-1", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node40 = CreateNode("Team-2", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node41 = CreateNode("Team-3", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node42 = CreateNode("Team-4", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));

            // PO‑4 Teams (Blue)
            var Node43 = CreateNode("Team-1", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node44 = CreateNode("Team-2", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node45 = CreateNode("Team-3", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));
            var Node46 = CreateNode("Team-4", teamSize, blueA1Child, Color.FromArgb(0x11, 0x11, 0x11));


            // Append all team nodes
            diagram1.Model.AppendChild(Node15);
            diagram1.Model.AppendChild(Node16);
            diagram1.Model.AppendChild(Node17);
            diagram1.Model.AppendChild(Node18);

            diagram1.Model.AppendChild(Node19);
            diagram1.Model.AppendChild(Node20);
            diagram1.Model.AppendChild(Node21);

            diagram1.Model.AppendChild(Node22);
            diagram1.Model.AppendChild(Node23);
            diagram1.Model.AppendChild(Node24);

            diagram1.Model.AppendChild(Node25);
            diagram1.Model.AppendChild(Node26);
            diagram1.Model.AppendChild(Node27);

            diagram1.Model.AppendChild(Node28);
            diagram1.Model.AppendChild(Node29);
            diagram1.Model.AppendChild(Node30);

            diagram1.Model.AppendChild(Node31);
            diagram1.Model.AppendChild(Node32);
            diagram1.Model.AppendChild(Node33);
            diagram1.Model.AppendChild(Node34);

            diagram1.Model.AppendChild(Node35);
            diagram1.Model.AppendChild(Node36);
            diagram1.Model.AppendChild(Node37);
            diagram1.Model.AppendChild(Node38);

            diagram1.Model.AppendChild(Node39);
            diagram1.Model.AppendChild(Node40);
            diagram1.Model.AppendChild(Node41);
            diagram1.Model.AppendChild(Node42);

            diagram1.Model.AppendChild(Node43);
            diagram1.Model.AppendChild(Node44);
            diagram1.Model.AppendChild(Node45);
            diagram1.Model.AppendChild(Node46);


            // Center -> Departments
            ConnectNodes(Node1, Node2, link);
            ConnectNodes(Node1, Node3, link);
            ConnectNodes(Node1, Node4, link);
            ConnectNodes(Node1, Node5, link);

            // Sales -> AGM-1, AGM-2
            ConnectNodes(Node2, Node6, link);
            ConnectNodes(Node2, Node7, link);

            // HR -> Manager
            ConnectNodes(Node3, Node8, link);

            // UX -> Manager-1, Manager-2
            ConnectNodes(Node4, Node9, link);
            ConnectNodes(Node4, Node10, link);

            // Development -> PO-1..PO-4
            ConnectNodes(Node5, Node11, link);
            ConnectNodes(Node5, Node12, link);
            ConnectNodes(Node5, Node13, link);
            ConnectNodes(Node5, Node14, link);

            // AGM-1 -> 4 teams
            ConnectNodes(Node6, Node15, link);
            ConnectNodes(Node6, Node16, link);
            ConnectNodes(Node6, Node17, link);
            ConnectNodes(Node6, Node18, link);

            // AGM-2 -> 3 teams
            ConnectNodes(Node7, Node19, link);
            ConnectNodes(Node7, Node20, link);
            ConnectNodes(Node7, Node21, link);

            // HR Manager -> 3 teams
            ConnectNodes(Node8, Node22, link);
            ConnectNodes(Node8, Node23, link);
            ConnectNodes(Node8, Node24, link);

            // UX Manager-1 -> 3 teams
            ConnectNodes(Node9, Node25, link);
            ConnectNodes(Node9, Node26, link);
            ConnectNodes(Node9, Node27, link);

            // UX Manager-2 -> 3 teams
            ConnectNodes(Node10, Node28, link);
            ConnectNodes(Node10, Node29, link);
            ConnectNodes(Node10, Node30, link);

            // PO-1 -> 4 teams
            ConnectNodes(Node11, Node31, link);
            ConnectNodes(Node11, Node32, link);
            ConnectNodes(Node11, Node33, link);
            ConnectNodes(Node11, Node34, link);

            // PO-2 -> 4 teams
            ConnectNodes(Node12, Node35, link);
            ConnectNodes(Node12, Node36, link);
            ConnectNodes(Node12, Node37, link);
            ConnectNodes(Node12, Node38, link);

            // PO-3 -> 4 teams
            ConnectNodes(Node13, Node39, link);
            ConnectNodes(Node13, Node40, link);
            ConnectNodes(Node13, Node41, link);
            ConnectNodes(Node13, Node42, link);

            // PO-4 -> 4 teams
            ConnectNodes(Node14, Node43, link);
            ConnectNodes(Node14, Node44, link);
            ConnectNodes(Node14, Node45, link);
            ConnectNodes(Node14, Node46, link);
        }


        /// <summary>
        /// Create the nodes using the given values
        /// </summary>
        /// <param name="text"> Label of the Node</param>
        /// <param name="size"> Height and Width of the Node</param>
        /// <param name="fill"> Fill color of the Node</param>
        /// <param name="textColor">Color of the label</param>
        /// <returns></returns>
        private Syncfusion.Windows.Forms.Diagram.Ellipse CreateNode(string text, SizeF size, Color fill, Color textColor)
        {
            var rect = new Syncfusion.Windows.Forms.Diagram.Ellipse(0, 0, size.Width, size.Height);
            rect.FillStyle.Color = fill;
            rect.LineStyle.LineColor = Color.Black;

            var lbl = new Syncfusion.Windows.Forms.Diagram.Label(rect, text);
            lbl.Position = Position.Center;
            lbl.FontStyle.Family = "Segoe UI";
            lbl.FontStyle.Size = 8f;
            lbl.FontStyle.Bold = true;
            lbl.FontColorStyle.Color = textColor;
            rect.Labels.Add(lbl);
            return rect;
        }


        /// <summary>
        /// Connects the given nodes (same as your method; kept minimal changes)
        /// </summary>
        private void ConnectNodes(Node parentNode, Node childNode, Color connectionColor)
        {

            if (parentNode != null && childNode != null)
            {
                LineConnector lConnector = new LineConnector(PointF.Empty, new PointF(0, 1));

                lConnector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
                lConnector.LineStyle.LineColor = connectionColor;

                lConnector.HeadDecorator.FillStyle.Color = connectionColor;
                lConnector.HeadDecorator.LineStyle.LineColor = connectionColor;
                lConnector.HeadDecorator.Size = new SizeF(8, 8);

                lConnector.CentralPort.ConnectionsLimit = 10000;

                parentNode.CentralPort.TryConnect(lConnector.TailEndPoint);
                childNode.CentralPort.TryConnect(lConnector.HeadEndPoint);

                diagram1.Model.AppendChild(lConnector);
                diagram1.Model.SendToBack(lConnector);
            }

        }

        #endregion

        #region Event Handlers

        private void apply_Click(object sender, EventArgs e)
        {
            if (ValueCheck == true)
            {

                if (AttractionStrength.Value != null)
                {
                    ((ForceDirectedTreeLayoutManager)this.diagram1.LayoutManager).AttractionStrength = (double)AttractionStrength.Value;
                }

                if (MaxIteration.Value != null)
                {
                    ((ForceDirectedTreeLayoutManager)this.diagram1.LayoutManager).MaximumIteration = (int)MaxIteration.Value;
                }

                if (RepulsionStrength.Value != null)
                {
                    ((ForceDirectedTreeLayoutManager)this.diagram1.LayoutManager).RepulsionStrength = (int)RepulsionStrength.Value;
                }

                ((ForceDirectedTreeLayoutManager)this.diagram1.LayoutManager).AutoLayout = chkAutoLayout.Checked;

                Layouting();

                ValueCheck= false;
            }
        }
        #endregion

        #region Helper Methods

        private void Layouting()
        {
            this.diagram1.LayoutManager.UpdateLayout(null);
            this.diagram1.UpdateView();
        }

       
        private void ConnectorLength_ValueChanged(object sender, EventArgs e)
        {  
            ValueCheck = true;
        }

        private void MaxIteration_ValueChanged(object sender, EventArgs e)
        {   
            ValueCheck = true;
        }

        private void AttractionStrength_ValueChanged(object sender, EventArgs e)
        {
            ValueCheck = true;
        }

        private void RepulsionStrength_ValueChanged(object sender, EventArgs e)
        {
            
            ValueCheck = true;
        }
        #endregion
    }
}