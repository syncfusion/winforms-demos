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
using System.Xml;

namespace OrgChartLayout
{
    public partial class Form1 : MetroForm
    {
        #region Members
        protected OrgChartLayoutManager dtLayoutMgr;
        #endregion

        #region Form Initialize
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            diagram1.BeginUpdate();
            this.diagram1.Controller.InPlaceEditing = false;
            this.dtLayoutMgr = new OrgChartLayoutManager(this.diagram1.Model, RotateDirection.TopToBottom, 40, 50, LayoutType.Waterfall, 1);
            dtLayoutMgr.LeftMargin = 10;
            dtLayoutMgr.TopMargin = 10;
            dtLayoutMgr.VerticalSpacing = 50;
            diagram1.LayoutManager = dtLayoutMgr;
            DiagramAppearance();
            InitializeDiagramFromXMLData();
            this.diagram1.View.SelectionList.Clear();

            txtHSpacing.Text = dtLayoutMgr.HorizontalSpacing.ToString();
            txtVSpacing.Text = dtLayoutMgr.VerticalSpacing.ToString();
            txtLMarigin.Text = dtLayoutMgr.LeftMargin.ToString();
            txtTMarigin.Text = dtLayoutMgr.TopMargin.ToString();
            chkAutoLayout.Checked = dtLayoutMgr.AutoLayout;

            comboLytType.SelectedIndex = 0;
            comboBShape.SelectedIndex = 1;
            comboExpSymbol.SelectedIndex = 0;

            diagram1.EndUpdate();
            comboBShape.SelectedIndexChanged += new EventHandler(comboBShape_SelectedIndexChanged);
            comboExpSymbol.SelectedIndexChanged += new EventHandler(comboExpSymbol_SelectedIndexChanged);
            apply.Click += new EventHandler(apply_Click);
            diagram1.MouseMove += new MouseEventHandler(diagram1_MouseMove);
            diagram1.EventSink.NodeMouseEnter += new Syncfusion.Windows.Forms.Diagram.NodeMouseEventHandler(EventSink_NodeMouseEnter);
            this.dtLayoutMgr.UpdateLayout(this);
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Change's the appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {
            //this.diagram1.MetroScrollBars = true;            
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.View.BackgroundColor = Color.White;            
            this.diagram1.Model.SizeToContent = true;

        }
        #endregion

        #region Initialize Diagram

        /// <summary>
        /// Initialize the diagram from XML file.
        /// </summary>
        protected void InitializeDiagramFromXMLData()
        {
#if !NETCORE
            string datasrcpath = @"..\..\..\..\..\..\common\Data\Diagram\xml\OrgLayout.xml";
#else
            string datasrcpath = @"..\..\..\..\..\..\..\common\Data\Diagram\xml\OrgLayout.xml";
#endif

            // Read data from the XML data file and populate a Hashtable using the employee ID as the key
            Hashtable lstEmployees = this.ReadEmployeeDataFromXMLFile(datasrcpath);

            // Create a manager-employee nested list with top-level employees forming the root nodes
            ArrayList sortedlist = this.GetSortedEmployeesList(lstEmployees);

            foreach (Employee_CS emply in sortedlist)
            {
                this.IterUpdateSubEmployeeCount(emply);
            }

            // Create diagram symbol nodes for each employee and initialize the diagram
            this.CreateOrgDiagramFromList(sortedlist);
            lstEmployees.Clear();
            sortedlist.Clear();
        }

        /// <summary>
        /// Read the data from the XML file
        /// </summary>
        /// <param name="datasrc">Path of the XML File</param>
        /// <returns>returns the employee table</returns>
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
                    Employee_CS emply = new Employee_CS();

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
                                emply.EmployeeName = "Name :" + dataelement.InnerText;
                                break;
                            case "EmployeeID":
                                emply.EmployeeID = dataelement.InnerText;
                                emply.EmployeeName += System.Environment.NewLine + "Emp ID :" + dataelement.InnerText;
                                break;
                            case "Designation":
                                emply.Designation = dataelement.InnerText;
                                emply.EmployeeName += System.Environment.NewLine + "Des :" + dataelement.InnerText;
                                break;
                            case "DOJ":
                                emply.DOJ = dataelement.InnerText;
                                emply.EmployeeName += System.Environment.NewLine + "DOJ :" + dataelement.InnerText;
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
            foreach (Employee_CS emply in employees)
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
                    Employee_CS manager = (Employee_CS)htemployees[emply.ManagerID];
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
        protected void IterUpdateSubEmployeeCount(Employee_CS empl)
        {
            empl.RecSubEmployeeCount = empl.SubEmployees.Count;
            foreach (Employee_CS subempl in empl.SubEmployees)
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

            foreach (Employee_CS emply in alemployees)
            {
#if !NETCORE
                String fileName = @"..\..\..\..\..\..\common\Images\Diagram\OrgChart Layout\" + emply.ImageName + ".png";
#else
                String fileName = @"..\..\..\..\..\..\..\common\Images\Diagram\OrgChart Layout\" + emply.ImageName + ".png";
#endif
                EmpSymbol emplysymbol = new EmpSymbol(fileName);
                emplysymbol.LineStyle.LineColor = Color.LightSkyBlue;
                emplysymbol.EmployeeName = emply.EmployeeName;
                this.diagram1.Model.AppendChild(emplysymbol);
                this.IterCreateEmployeeSymbol(emply, emplysymbol);
            }

            // ReEnable the Model redraw
            this.diagram1.Model.EndUpdate();

            // Instruct the LayoutManager to calculate and layout the diagram nodes
            LayoutNodes();
        }


        /// <summary>
        ///  Iterative sub-employee symbol node creation
        /// </summary>
        /// <param name="emply">Employess business object</param>
        /// <param name="emplysymbol">Employee Node</param>
        protected void IterCreateEmployeeSymbol(Employee_CS emply, EmpSymbol emplysymbol)
        {
            foreach (Employee_CS subemply in emply.SubEmployees)
            {
#if !NETCORE
                String fileName = @"..\..\..\..\..\..\common\Images\Diagram\OrgChart Layout\" + subemply.ImageName + ".png";
#else
                String fileName = @"..\..\..\..\..\..\..\common\Images\Diagram\OrgChart Layout\" + subemply.ImageName + ".png";
#endif
                // Create a EmployeeSymbol for each of the sub-employees of the particular employee //Waterfall, Horizontal
                EmpSymbol subemplysymbol = new EmpSymbol(fileName);
                subemplysymbol.LineStyle.LineColor = Color.LightSkyBlue;
                subemplysymbol.EmployeeName = emply.EmployeeName;
                this.diagram1.Model.AppendChild(subemplysymbol);

                emplysymbol.EnableCentralPort = true;
                subemplysymbol.EnableCentralPort = true;
                ConnectNodes(emplysymbol, subemplysymbol);

                this.IterCreateEmployeeSymbol(subemply, subemplysymbol);
            }

        }

        /// <summary>
        /// Connects the nodes
        /// </summary>
        /// <param name="emplysymbol">Parent Node</param>
        /// <param name="subemplysymbol">Child node</param>
        private void ConnectNodes(Node emplysymbol, Node subemplysymbol)
        {
            OrgLineConnector ortholink = new OrgLineConnector(PointF.Empty, new PointF(0, 1));            
            ortholink.LineStyle.LineWidth = 1f;
            ortholink.LineStyle.LineColor = Color.Black;
            ortholink.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;            
            ortholink.HeadDecorator.FillStyle.Color = Color.Black;
            this.diagram1.Model.AppendChild(ortholink);

            if (emplysymbol.CentralPort != null && subemplysymbol.CentralPort != null)
            {
                emplysymbol.CentralPort.TryConnect(ortholink.TailEndPoint);
                subemplysymbol.CentralPort.TryConnect(ortholink.HeadEndPoint);
            }

            this.diagram1.Controller.SendToBack();
        }

#endregion
        
#region Event Handlers
        
        private void dialog_BeginLayout(OrgChartLayoutManager layout)
        {
            this.diagram1.LayoutManager = layout;
            LayoutNodes();
        }

        void apply_Click(object sender, EventArgs e)
        {
            this.diagram1.BeginUpdate();
            dtLayoutMgr = new OrgChartLayoutManager(this.diagram1.Model, RotateDirection.TopToBottom, 20, 50, (LayoutType)Enum.Parse(typeof(LayoutType), this.comboLytType.SelectedItem.ToString(), true), 1, true);
            if (txtHSpacing.Text != string.Empty)
                dtLayoutMgr.LeftMargin = float.Parse(txtLMarigin.Text);
            if (txtVSpacing.Text != string.Empty)
                dtLayoutMgr.TopMargin = float.Parse(txtTMarigin.Text);
            if (txtLMarigin.Text != string.Empty)
                dtLayoutMgr.HorizontalSpacing = float.Parse(txtHSpacing.Text);
            if (txtTMarigin.Text != string.Empty)
                dtLayoutMgr.VerticalSpacing = float.Parse(txtVSpacing.Text);

            dtLayoutMgr.AutoLayout = chkAutoLayout.Checked;

            this.diagram1.LayoutManager = this.dtLayoutMgr;
            this.dtLayoutMgr.UpdateLayout(null);
            this.diagram1.EndUpdate();
            this.diagram1.UpdateView();
        }

        void comboExpSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.diagram1.BeginUpdate();
            foreach (Node node in diagram1.Model.Nodes)
            {
                if (node is EmpSymbol)
                {
                    if (comboExpSymbol.SelectedIndex == 1)
                    {
                        ((EmpSymbol)node).SymbolShapeType = EmpSymbol.SymbolShape.PlusMinus;
                    }
                    else if (comboExpSymbol.SelectedIndex == 0)
                    {
                        ((EmpSymbol)node).SymbolShapeType = EmpSymbol.SymbolShape.RightDownTriangle;
                    }
                }
            }
            this.diagram1.Refresh();
            this.diagram1.EndUpdate();
        }

        void comboBShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.diagram1.BeginUpdate();
            foreach (Node node in diagram1.Model.Nodes)
            {
                if (node is EmpSymbol)
                {
                    if (comboBShape.SelectedIndex == 1)
                    {
                        ((EmpSymbol)node).BackgroundShapeType = EmpSymbol.BackgroundShape.ellipse;
                    }
                    else if (comboBShape.SelectedIndex == 0)
                    {
                        ((EmpSymbol)node).BackgroundShapeType = EmpSymbol.BackgroundShape.Rectangle;
                    }
                }
            }
            this.diagram1.Refresh();
            this.diagram1.EndUpdate();
        }

        void EventSink_NodeMouseEnter(Syncfusion.Windows.Forms.Diagram.NodeMouseEventArgs evtArgs)
        {
            diagram1.Controller.ActiveTool.ActionCursor = Cursors.Arrow;
        }

        void diagram1_MouseMove(object sender, MouseEventArgs e)
        {
            EmpSymbol node = diagram1.Controller.GetNodeAtPoint(diagram1.Controller.ConvertToModelCoordinates(e.Location)) as EmpSymbol;
            if (node != null)
            {
                node.MouseMove(diagram1.Controller.ConvertToModelCoordinates(e.Location));
            }
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