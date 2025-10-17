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
using System.Xml;
using System.Drawing.Drawing2D;
using System.Collections;
using Syncfusion.Windows.Forms;

namespace DynamicProperties
{
    public partial class Form1 : MetroForm
    {
        #region Members
        protected RadialTreeLayoutManager dtLayoutMgr;
        ToolTip tooltips = new ToolTip();
        #endregion

        #region initializeForm
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            diagram1.Model.BeginUpdate();
            this.diagram1.Controller.InPlaceEditing = false;
            this.dtLayoutMgr = new RadialTreeLayoutManager(this.diagram1.Model, 0, 80, 80);
            dtLayoutMgr.LeftMargin = 80;
            dtLayoutMgr.TopMargin = 30;
            dtLayoutMgr.AutoLayout = true;
            diagram1.LayoutManager = dtLayoutMgr;
            DiagramAppearance();
#if !NETCORE
            InitializeDiagramFromXMLData(@"..\..\..\..\..\..\common\Data\Diagram\xml\DynamicProperties.xml");  
#else
            InitializeDiagramFromXMLData(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\DynamicProperties.xml");
#endif
            diagram1.Model.EndUpdate();
            diagram1.View.SelectionList.Clear();
            diagram1.EventSink.NodeMouseEnter += new NodeMouseEventHandler(EventSink_NodeMouseEnter);
            diagram1.EventSink.NodeMouseLeave += new NodeMouseEventHandler(EventSink_NodeMouseLeave);
        }

        void EventSink_NodeMouseLeave(NodeMouseEventArgs evtArgs)
        {
            tooltips.Active = false;
        }

        void EventSink_NodeMouseEnter(NodeMouseEventArgs evtArgs)
        {
            if (!(evtArgs.Node is ConnectorBase) && evtArgs.Node.PropertyBag.Count > 0)
            {
                tooltips.IsBalloon = true;
                string strData = string.Empty;
                foreach (string key in evtArgs.Node.PropertyBag.Keys)
                {
                    strData += key + " : " + evtArgs.Node.PropertyBag[key] + "\n";
                }
                tooltips.SetToolTip(this.diagram1, strData);
                tooltips.Active = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (diagram1.View.SelectionList.Count > 0)
            {
                PropertyBagDialog propertyBagDialog = new PropertyBagDialog();
                propertyBagDialog.PropertyBag = diagram1.View.SelectionList[0].PropertyBag;
                propertyBagDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a node to edit property info collection  ", "Meesage");
            }
        }
#endregion

#region Private Methods
        /// <summary>
        /// Change's the appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {            
            this.diagram1.Model.LineStyle.LineColor = Color.Transparent;
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.View.BackgroundColor = Color.White;
            this.diagram1.View.Grid.Visible = false;
            this.diagram1.View.SelectionList.Clear();
        }
#endregion

#region Initailize Diagram
        
        /// <summary>
        /// Initialize diagram from XML file
        /// </summary>
        /// <param name="datasrcpath">Path of the XML file</param>
        protected void InitializeDiagramFromXMLData(string datasrcpath)
        {
            Hashtable lstEmployees = this.ReadEmployeeDataFromXMLFile(datasrcpath);

            // Create a manager-employee nested list with top-level employees forming the root nodes
            ArrayList sortedlist = this.GetSortedEmployeesList(lstEmployees);

            foreach (Employee emply in sortedlist)
            {
                this.IterUpdateSubEmployeeCount(emply);
            }

            // Create diagram symbol nodes for each employee and initialize the diagram
            this.CreateOrgDiagramFromList(sortedlist);
            lstEmployees.Clear();
            sortedlist.Clear();
        }

        /// <summary>
        /// New function for reading data from xml file
        /// </summary>
        /// <param name="datasrc">XML File</param>
        protected Hashtable ReadEmployeeDataFromXMLFile(string datasrc)
        {
            Hashtable lstEmployee = new Hashtable();  

            // Use the XML DOM to read data from the employees XML data file
            XmlDocument xmldoc = new XmlDocument();
#if SyncfusionFramework4_0
            xmldoc.XmlResolver = null;
#endif
            xmldoc.Load(datasrc);
            if (xmldoc.DocumentElement.HasChildNodes)
            {
                XmlNodeList employeelist = xmldoc.DocumentElement.ChildNodes;
                for (int i = 0; i < employeelist.Count; i++)
                {
                    // Create an Employee instance to represent each employee
                    Employee emply = new Employee();

                    XmlNode employeenode = employeelist[i];
                    XmlNodeList employeedatalist = employeenode.ChildNodes;
                    IEnumerator employeedata = employeedatalist.GetEnumerator();
                    employeedata.Reset();
                    while (employeedata.MoveNext())
                    {
                        XmlNode dataelement = employeedata.Current as XmlNode;
                        switch (dataelement.Name)
                        {
                            case "Name":
                                emply.EmployeeName = dataelement.InnerText;
                                break;
                            case "EmployeeID":
                                emply.EmployeeID = dataelement.InnerText;                                
                                break;
                            case "Designation":
                                emply.Designation = dataelement.InnerText;                                
                                break;
                            case "DOJ":
                                emply.DOJ = dataelement.InnerText;                                
                                break;
                            case "ImageNo":
                                emply.ImageName = dataelement.InnerText;
                                break;
                            case "ManagerID":
                                emply.ManagerID = dataelement.InnerText;
                                break;
                        }
                    }
                    lstEmployee.Add(emply.EmployeeID,emply);
                }
            }
            return lstEmployee;
        }

        /// <summary>
        ///  Rearrange the employees collection as a manager-subemployee nested tree
        /// </summary>
        /// <param name="htemployees">Employee table</param>
        /// <returns>returns the sorted list</returns>
        protected ArrayList GetSortedEmployeesList(Hashtable htemployees)
        {
            ICollection employees = htemployees.Values;
            ArrayList sortedlist = new ArrayList();
            foreach (Employee emply in employees)
            {
                if (emply.ManagerID == string.Empty)
                {
                    // Employees without a ManagerID are top-level nodes in the org tree
                    sortedlist.Add(emply);
                }
                else
                {
                    // Find the employee instance associated with the managerID and add this object as 
                    // a subemployee of the manager node.
                    Employee manager = (Employee)htemployees[emply.ManagerID];
                    if (manager != null)
                        manager.SubEmployees.Add(emply);
                }
            }

            return sortedlist;
        }

        /// <summary>
        /// generates the sub employees count
        /// </summary>
        /// <param name="empl">Employee business object</param>
        protected void IterUpdateSubEmployeeCount(Employee empl)
        {
            empl.RecSubEmployeeCount = empl.SubEmployees.Count;
            foreach (Employee subempl in empl.SubEmployees)
            {
                this.IterUpdateSubEmployeeCount(subempl);
                empl.RecSubEmployeeCount += subempl.RecSubEmployeeCount;
            }
        }

        /// <summary>
        /// Create diagram symbol nodes for each employee in the organization and add these symbols to the diagram
        /// Create links between manager and sub-employees to depict the org structure
        /// </summary>
        /// <param name="alemployees"> Employees list</param>
        protected void CreateOrgDiagramFromList(ArrayList alemployees)
        {
            // Temporarily suspend the Diagram Model redrawing
            this.diagram1.Model.BeginUpdate();

            foreach (Employee emply in alemployees)
            {
#if !NETCORE
                String fileName = @"..\..\..\..\..\..\common\Images\Diagram\OrgChart Layout\" + emply.ImageName + ".png";
#else
                String fileName = @"..\..\..\..\..\..\..\common\Images\Diagram\OrgChart Layout\" + emply.ImageName + ".png";
#endif
                BitmapNode employeeSymbol = new BitmapNode(new Bitmap(fileName), new RectangleF(100,100,75,75));
                employeeSymbol.LineStyle.LineColor = Color.Transparent;
                employeeSymbol.PropertyBag.Add("Name",emply.EmployeeName);
                employeeSymbol.PropertyBag.Add("ID", emply.EmployeeID);
                employeeSymbol.PropertyBag.Add("Designation", emply.Designation);
                this.diagram1.Model.AppendChild(employeeSymbol);
                this.IterCreateEmployeeSymbol(emply, employeeSymbol);
            }

            // Enable the Model redraw
            this.diagram1.Model.EndUpdate();

            // Instruct the LayoutManager to calculate and layout the diagram nodes
            LayoutNodes();
        }


        /// <summary>
        ///  Iterative sub-employee symbol node creation
        /// </summary>
        /// <param name="emply">Employess business object</param>
        /// <param name="emplysymbol">Employee Node</param>
        protected void IterCreateEmployeeSymbol(Employee emply, BitmapNode bmpNode)
        {
            foreach (Employee subemply in emply.SubEmployees)
            {
#if !NETCORE
                String fileName = @"..\..\..\..\..\..\common\Images\Diagram\OrgChart Layout\" + subemply.ImageName + ".png";
#else
                String fileName = @"..\..\..\..\..\..\..\common\Images\Diagram\OrgChart Layout\" + subemply.ImageName + ".png";
#endif
                // Create a BitmapNode for each of the sub-employees of the particular employee 
                BitmapNode subemplysymbol = new BitmapNode(new Bitmap(fileName), new RectangleF(100, 100, 75, 75));
                subemplysymbol.LineStyle.LineColor = Color.Transparent;
                subemplysymbol.PropertyBag.Add("Name", subemply.EmployeeName);
                subemplysymbol.PropertyBag.Add("ID", subemply.EmployeeID);
                subemplysymbol.PropertyBag.Add("Designation", subemply.Designation);
                this.diagram1.Model.AppendChild(subemplysymbol);

                bmpNode.EnableCentralPort = true;
                subemplysymbol.EnableCentralPort = true;
                ConnectNodes(bmpNode, subemplysymbol);

                this.IterCreateEmployeeSymbol(subemply, subemplysymbol);
            }

        }

        /// <summary>
        /// Connects the nodes
        /// </summary>
        /// <param name="parent">Parent Node</param>
        /// <param name="child">Child node</param>
        private void ConnectNodes(Node parent, Node child)
        {
            LineConnector lConnector = new LineConnector(PointF.Empty, new PointF(0, 1));
            lConnector.LineStyle.LineWidth = 1f;
            lConnector.LineStyle.LineColor = Color.Black;
            lConnector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;            
            lConnector.HeadDecorator.FillStyle.Color = Color.White;
            this.diagram1.Model.AppendChild(lConnector);

            if (parent.CentralPort != null && child.CentralPort != null)
            {
                parent.CentralPort.TryConnect(lConnector.TailEndPoint);
                child.CentralPort.TryConnect(lConnector.HeadEndPoint);
            }

            this.diagram1.Controller.SendToBack();
        }
    
#endregion
        
#region Helper Methods

        private void LayoutNodes()
        {
            // Temporarily suspend the layoutmanager
            this.diagram1.LayoutManager.AutoLayout = false;

            this.diagram1.LayoutManager.Nodes.Clear();
            this.diagram1.LayoutManager.Nodes.AddRange(this.diagram1.Model.Nodes);
            this.diagram1.LayoutManager.UpdateLayout(null);
        }
#endregion
    }
}