#region Copyright Syncfusion Inc. 2001 - 2013
//
//  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Label = System.Windows.Forms.Label;
using Syncfusion.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections;
using DemoCommon.Diagram;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Licensing;

namespace DragDrop
{
    public partial class Form1 : Form
    {
#region Membres
        NodeCollection managers;
        NodeCollection employees;
#endregion

#region Class initialize/finalize methods
        public Form1( ) {

            InitializeComponent( );
            managers = new NodeCollection( );
            employees = new NodeCollection( );

            this.diagram1.Model = this.model1;

            DirectedTreeLayoutManager mgr = new DirectedTreeLayoutManager( this.diagram1.Model, 0, 30, 50 );
            mgr.LeftMargin = 100;
            mgr.TopMargin = 50;
            this.diagram1.LayoutManager = mgr;            
            this.diagram1.Model.EventSink.DocumentEndUpdate += new EventHandler( EventSink_DocumentEndUpdate );
            this.diagram1.Model.DocumentSize = new PageSize( 800, 800 );
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;

            // Load Palette
#if !NETCORE
            this.paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\DragDrop.xml");  
#else
            this.paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\DragDrop.xml");
#endif

        }

        void EventSink_NodeCollectionChanged(CollectionExEventArgs evtArgs)
        {
            if (evtArgs.ChangeType == CollectionExChangeType.Insert)
            {
                if (!(evtArgs.Element is ConnectorBase))
                {
                    Group draggedNode = evtArgs.Element as Group;
                    foreach (Group node in this.managers)
                    {
                        // If the droppednode contains the pinpoint as that of manager node, connect both the nodes
                        if (draggedNode.ContainsPoint(node.PinPoint))
                            this.ConnectNodes(node, draggedNode);
                    }
                    // Update the layout for better appearance of nodes.
                    this.UpdateDiagramLayout();
                }
            }
        }

        void EventSink_DocumentEndUpdate( object sender, EventArgs e ) {
            if ( this.diagram1.Controller.ActiveTool is MoveTool && this.diagram1.Controller.NodesHit.Count != 0 && this.diagram1.Controller.NodesHit.First is Group )
            {
                this.nodeMoved = ( Group )( ( ( this.diagram1.Controller.NodesHit.First is Group ) ? this.diagram1.Controller.NodesHit.First : null ) );

                if ( this.nodeMoved.Name.StartsWith( "M" ) && this.nodeMoved.CentralPort != null && this.nodeMoved.EdgesEntering.Count != 0 )
                {
                    foreach ( Group mNode in this.managers )
                    {
                        if ( this.nodeMoved.ContainsPoint( mNode.PinPoint ) )
                        {
                            foreach ( EndPoint endpt in this.nodeMoved.CentralPort.Connections )
                            {
                                if ( endpt is HeadEndPoint )
                                {
                                    line = ( LineConnector )( ( ( endpt.Container is LineConnector ) ? endpt.Container : null ) );
                                }
                            }
                            if ( !( this.nodeMoved == mNode && line == null ) )
                            {
                                this.diagram1.Model.RemoveChild( line );
                                this.ConnectNodes( mNode, this.nodeMoved );
                                this.diagram1.Invalidate( );
                            }
                        }
                    }
                }
            }
            //this.diagram1.Model.UpdateCompositeBounds( );
        }

#endregion

#region MAIN
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( ) {
            SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.Run( new Form1( ) );
        }

#endregion

#region Helper methods

        /// <summary>
        /// Method to connect the parent and sub nodes.
        /// </summary>
        /// <param name="parentNode">From Node</param>
        /// <param name="subNode">To Node</param>
        private void ConnectNodes(Node parentNode, Node subNode)
        {
            if (parentNode.CentralPort == null || subNode.CentralPort == null)
            {
                return;
            }

            if (parentNode.Equals(subNode))
            {
                return;
            }

            // Create directed link
            LineConnector line = new LineConnector(PointF.Empty, new PointF(0F, 1F));
            line.LineStyle.LineColor = Color.DarkGray;
            line.HeadDecorator.DecoratorShape = DecoratorShape.FilledFancyArrow;
            line.HeadDecorator.Size = new SizeF(12F, 9F);
            line.HeadDecorator.FillStyle.Color = Color.MidnightBlue;
            line.HeadDecorator.LineStyle.LineColor = Color.Transparent;
            this.diagram1.Model.AppendChild(line);
            this.diagram1.Model.SendBackward(line);

            parentNode.CentralPort.TryConnect(line.TailEndPoint);
            subNode.CentralPort.TryConnect(line.HeadEndPoint);
        }

        /// <summary>
        /// Update the DiagramLayout for better appearance
        /// </summary>
        public void UpdateDiagramLayout()
        {
            this.diagram1.LayoutManager.Nodes.Clear();
            this.diagram1.LayoutManager.Nodes.AddRange(this.diagram1.Model.Nodes);

            this.diagram1.LayoutManager.UpdateLayout(true);            
            this.diagram1.UpdateView();
        }

        
        /// <summary>
        /// Initial addition of nodes while loading is handled here
        /// </summary>
        public void AddManagers()
        {
            // Insert the nodes 
            InsertNodeFromPallete(0, new PointF(50, 50));
            InsertNodeFromPallete(1, new PointF(25, 150));
            InsertNodeFromPallete(1, new PointF(100, 150));

            //Connect the nodes 
            ConnectNodes(this.managers[0], this.employees[0]);
            ConnectNodes(this.managers[0], this.employees[1]);


        }

        /// <summary>
        /// Inserts the Node in the diagram from the palette at given location
        /// </summary>
        /// <param name="nNodeIndex">index of the node</param>
        /// <param name="ptLocation">Location of the node</param>
        /// <returns></returns>
        private Node InsertNodeFromPallete(int nNodeIndex, PointF ptLocation)
        {
            Node node = null;
            NodeCollection nodes = paletteGroupBar1.CurrentSymbolPalette.Nodes;

            if (nNodeIndex >= 0 && nNodeIndex < nodes.Count)
            {
                node = (Node)nodes[nNodeIndex].Clone();
                InsertNode(node, ptLocation);
            }

            return node;
        }

        // <summary>
        /// Inserts the Node in the diagram at given location
        /// </summary>
        /// <param name="nNodeIndex">index of the node</param>
        /// <param name="ptLocation">Location of the node</param>
        /// <returns></returns>
        private Node InsertNode(Node node, PointF ptLocation)
        {

            m_list = new ArrayList();
            // Perform Matrix transformation

            MeasureUnits units = MeasureUnits.Pixel;
            SizeF szPinOffset = ((IUnitIndependent)node).GetPinPointOffset(units);
            ptLocation.X += szPinOffset.Width;
            ptLocation.Y += szPinOffset.Height;
            ((IUnitIndependent)node).SetPinPoint(ptLocation, units);

            //Append the nodes to the drawing area          
            this.diagram1.Model.AppendChild(node);

            if (node.Name.StartsWith("M"))
            {
                this.managers.Add(node);
                //Adds tag information for nodes 
                managerCount = managerCount + 1;
                int managerCode = managerCount + 100;
                m_list.AddRange(new string[] { managerCode.ToString(), projectName[managerCount] });
                node.Tag = m_list;
            }
            else
            {
                this.employees.Add(node);
                //Adds tag information for nodes 
                employeeCount = employeeCount + 1;
                int employeeCode = employeeCount + 1000;
                m_list.AddRange(new string[] { employeeCode.ToString(), employeeName[employeeCount], designation[employeeCount] });
                node.Tag = m_list;

            }
            return node;
        }

#endregion

#region Class Event handlers
        ArrayList m_list;
        String[] employeeName = new String[] { "Ria", "Alew", "Lisa", "Vincy" , "Marissa", "Seema", "Hanna", "Maria", "Ana", "Christina", "Francy"};
        String[] designation = new String[] { "Software Engineer ", "Junior SE - Level 1", "Junior SE - Level 2","Junior SE - Level 3", "Junior SE - Level 4","Junior SE - Level 4", "HR", "HR Assistant" , "Graphics Designer", "Network Admin", "System Admin"};
        String[] projectName = new String[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K"};
        int managerCount = 0;
        int employeeCount = 0;
        private void diagram1_DragDrop(object sender, DragEventArgs e)
        {
            m_list = new ArrayList();


            // Check if the dropped node is a valid node
            if (e.Data.GetDataPresent(typeof(DragDropData)))
            {
                DragDropData dragDropData = (DragDropData)e.Data.GetData(typeof(DragDropData));
                Group draggedNode = dragDropData.Nodes[0] as Group;


                if (draggedNode.Name.StartsWith("M"))
                {
                    managerCount = managerCount + 1;
                    this.managers.Add(draggedNode);
                    //Adds tag information for nodes upto 10 counts
                    if (managerCount < 10)
                    {
                        int managerCode = managerCount + 100;
                        m_list.AddRange(new string[] { managerCode.ToString(), projectName[managerCount] });
                        draggedNode.Tag = m_list;
                        ArrayList m_alist = draggedNode.Tag as ArrayList;
                        this.label2.Text = "Manager Code: " + m_alist[0].ToString() + "\n\nLeads Project " + m_alist[1].ToString();
                    }
                }
                else
                {

                    this.employees.Add(draggedNode);
                    employeeCount = employeeCount + 1;
                    //Adds tag information for nodes upto 10 counts
                    if (employeeCount < 10)
                    {
                        int employeeCode = employeeCount + 1000;
                        m_list.AddRange(new string[] { employeeCode.ToString(), employeeName[employeeCount], designation[employeeCount] });
                        draggedNode.Tag = m_list;
                        ArrayList e_alist = draggedNode.Tag as ArrayList;
                        this.label2.Text = "Employee Code: " + e_alist[0].ToString() + "\n\nEmployee Name: " + e_alist[1].ToString() + "\n\nDesignation: " + e_alist[2].ToString();
                    }

                }

            }
        }

       

        private void Form1_Load( object sender, EventArgs e )
        {
            diagram1.BeginUpdate();
            AddManagers( );
            UpdateDiagramLayout();
            DiagramAppearance();
            GroupBarAppearance();
            diagram1.EndUpdate();
            this.diagram1.Model.EventSink.NodeCollectionChanged += new CollectionExEventHandler(EventSink_NodeCollectionChanged);
            diagram1.Controller.InPlaceEditing = false;
        }

        private void GroupBarAppearance()
        {
            this.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA");
            foreach (GroupBarItem item in paletteGroupBar1.GroupBarItems)
            {
                //palette view settings
                if (item.Client is PaletteGroupView)
                {
                    PaletteGroupView view = item.Client as PaletteGroupView;
                    view.Font = new Font("Segoe UI", 9, System.Drawing.FontStyle.Regular);
                    view.ForeColor = Color.Black;
                    view.BackColor = Color.White;
                    view.TextWrap = true;
                    view.BorderStyle = BorderStyle.FixedSingle;
                }
            }        
        }
        private void DiagramAppearance()
        {
            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.LightGray;
            this.diagram1.View.Grid.VerticalSpacing = 15;
            this.diagram1.View.Grid.HorizontalSpacing = 15;
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.View.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleOutlineColor = Color.SkyBlue;
            diagram1.View.BackgroundColor = Color.White;
            diagram1.Model.DocumentSize = new PageSize(500, 500);
            this.diagram1.View.SelectionList.Clear();

        }

        //Shows Node tag inforamtion when a node is selected
        private void diagram1_MouseDown(object sender, MouseEventArgs e)
        {           
                // Retrives node under the mouse action.
                Node node = (Node)this.diagram1.Controller.GetNodeUnderMouse(new Point(e.X, e.Y));
                if (node != null && node.Tag != null)
                {
                    if (node.Name.StartsWith("M"))
                    {
                        ArrayList m_alist = node.Tag as ArrayList;
                        this.label2.Text = "Manager Code: " + m_alist[0].ToString() + "\n\nLeads Project " + m_alist[1].ToString();

                    }
                    else
                    {
                        ArrayList e_alist = node.Tag as ArrayList;
                        this.label2.Text = "Employee Code: " + e_alist[0].ToString() + "\n\nEmployee Name: " + e_alist[1].ToString() + "\n\nDesignation: " + e_alist[2].ToString();        
                   }
              }
          }
#endregion
      }
}

