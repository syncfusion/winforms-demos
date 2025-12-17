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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using Syncfusion.SVG.IO;
using Syncfusion.Windows.Forms;
using System.Collections;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Xml;

namespace DatabaseDiagram
{
    public partial class Form1 : Form
    {
        #region Members

        bool needSave = false;
        public string fileName;
        private Point mousePt;
        private Node prevbNode = null;
        private OpenFileDialog fileDialog = new OpenFileDialog();
#if !NETCORE
        private string datasrcpath = @"..\..\..\..\..\..\common\Data\Diagram\xml\Database.xml";
#else
        private string datasrcpath = @"..\..\..\..\..\..\..\common\Data\Diagram\xml\Database.xml";
#endif
        #endregion

        #region Form initialize
        public Form1()
        {
            InitializeComponent();
            diagram1.BeginUpdate();
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.Model.LineStyle.LineColor = Color.LightGray;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            InitailizeDiagram();
            diagram1.EndUpdate();
            cboDatabaseDiagram.SelectedIndex = 0;
            diagram1.EventSink.NodeClick += new NodeMouseEventHandler(EventSink_NodeClick);
            // Wire up OnIdle processing
            Application.Idle += new EventHandler(Application_Idle);
        }
 

        #endregion

        #region Private Methods

        /// <summary>
        /// Change's the appearance of the Diagram 
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
            this.diagram1.Model.DocumentSize = new PageSize(this.diagram1.View.ClientRectangle.Size.Width, diagram1.View.ClientRectangle.Size.Height);
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.Model.MinimumSize = diagram1.View.ClientRectangle.Size;
            this.diagram1.Model.SizeToContent = true;
            this.diagram1.View.SelectionList.Clear();
        }
        #endregion

        #region Initailize Diagram 
        /// <summary>
        /// Initializes the diagram
        /// </summary>
        private void InitailizeDiagram()
        {
            InitializeDiagramFromXMLData(datasrcpath);
            diagram1.View.SelectionList.Clear();
        }

        /// <summary>
        /// Make connection establishment between nodes
        /// </summary>
        private void ConnectNodes()
        {
            if (cboDatabaseDiagram.SelectedIndex == 0)
            {
                diagram1.Model.Nodes["Employee"].PinPoint = new PointF(450, 150);
                diagram1.Model.Nodes["Publishers"].PinPoint = new PointF(100, 150);
                diagram1.Model.Nodes["Titles"].PinPoint = new PointF(100, 480);
                diagram1.Model.Nodes["PubInfo"].PinPoint = new PointF(300, 350);
                diagram1.Model.Nodes["Sales"].PinPoint = new PointF(750, 480);
                diagram1.Model.Nodes["Stores"].PinPoint = new PointF(750, 310);
                diagram1.Model.Nodes["Discounts"].PinPoint = new PointF(750, 100);

                ConnectNodes(diagram1.Model.Nodes["Employee"], diagram1.Model.Nodes["Publishers"], "OneToMany");
                ConnectNodes(diagram1.Model.Nodes["Publishers"], diagram1.Model.Nodes["Titles"], "OneToMany");
                ConnectNodes(diagram1.Model.Nodes["Publishers"], diagram1.Model.Nodes["PubInfo"], "OneToOne");
                ConnectNodes(diagram1.Model.Nodes["Titles"], diagram1.Model.Nodes["Sales"], "OneToMany");
                ConnectNodes(diagram1.Model.Nodes["Stores"], diagram1.Model.Nodes["Sales"], "OneToMany");
                ConnectNodes(diagram1.Model.Nodes["Stores"], diagram1.Model.Nodes["Discounts"], "OneToMany");
            }
            else if (cboDatabaseDiagram.SelectedIndex == 1)
            {
                diagram1.Model.Nodes["Course"].PinPoint = new PointF(200, 200);
                diagram1.Model.Nodes["Department"].PinPoint = new PointF(200, 500);
                diagram1.Model.Nodes["CourseInstructor"].PinPoint = new PointF(500, 100);
                diagram1.Model.Nodes["Person"].PinPoint = new PointF(500, 300);
                diagram1.Model.Nodes["Enrollment"].PinPoint = new PointF(500, 550);
                ConnectNodes(diagram1.Model.Nodes["Course"], diagram1.Model.Nodes["Department"], "OneToMany");
                ConnectNodes(diagram1.Model.Nodes["Course"], diagram1.Model.Nodes["CourseInstructor"], "OneToMany");
                ConnectNodes(diagram1.Model.Nodes["Course"], diagram1.Model.Nodes["Enrollment"], "OneToMany");
                ConnectNodes(diagram1.Model.Nodes["CourseInstructor"], diagram1.Model.Nodes["Person"], "OneToMany");
                ConnectNodes(diagram1.Model.Nodes["Person"], diagram1.Model.Nodes["Enrollment"], "OneToMany");
            }
            else if (cboDatabaseDiagram.SelectedIndex == 2)
            {
                diagram1.Model.Nodes["Payments"].PinPoint = new PointF(200, 150);
                diagram1.Model.Nodes["Employees"].PinPoint = new PointF(600, 150);
                diagram1.Model.Nodes["LoanTypes"].PinPoint = new PointF(175, 450);
                diagram1.Model.Nodes["LoanAllocations"].PinPoint = new PointF(400, 450);
                diagram1.Model.Nodes["Customers"].PinPoint = new PointF(610, 450);
                ConnectNodes(diagram1.Model.Nodes["Payments"], diagram1.Model.Nodes["Employees"], "OneToMany");
                ConnectNodes(diagram1.Model.Nodes["LoanAllocations"], diagram1.Model.Nodes["LoanTypes"], "OneToMany");
                ConnectNodes(diagram1.Model.Nodes["LoanAllocations"], diagram1.Model.Nodes["Customers"], "OneToMany");
                ConnectNodes(diagram1.Model.Nodes["Payments"], diagram1.Model.Nodes["LoanAllocations"], "OneToMany");
                ConnectNodes(diagram1.Model.Nodes["LoanAllocations"], diagram1.Model.Nodes["Employees"], "OneToMany");
            }

        }
       
        /// <summary>
        /// Initialize the Diagram from XML file
        /// </summary>
        protected void InitializeDiagramFromXMLData(string path)
        {
            diagram1.Model.Clear();
            diagram1.Model.BeginUpdate();
            RoundRect rrect = new RoundRect(900, 30, 250, 70, MeasureUnits.Pixel);
            rrect.FillStyle.Color = Color.Transparent;
            rrect.EditStyle.AllowSelect = false;
            rrect.LineStyle.LineColor = Color.Gray;
            Syncfusion.Windows.Forms.Diagram.Label lbl = new Syncfusion.Windows.Forms.Diagram.Label(rrect, "Relationships");
            lbl.Position = Position.TopLeft;
            lbl.FontStyle.Family = "Segoe UI";
            lbl.FontStyle.Size = 9;
            rrect.Labels.Add(lbl);
            Syncfusion.Windows.Forms.Diagram.Label lblOneToOne = new Syncfusion.Windows.Forms.Diagram.Label(rrect, ": OneToOne");
            lblOneToOne.FontStyle.Family = "Segoe UI";
            lblOneToOne.FontStyle.Size = 9;
            lblOneToOne.OffsetX = 120;
            lblOneToOne.OffsetY = 10;
            rrect.Labels.Add(lblOneToOne);
            Syncfusion.Windows.Forms.Diagram.Label lblOneToMany = new Syncfusion.Windows.Forms.Diagram.Label(rrect, ": OneToMany");
            lblOneToMany.FontStyle.Family = "Segoe UI";
            lblOneToMany.FontStyle.Size = 9;
            lblOneToMany.OffsetX = 120;
            lblOneToMany.OffsetY = 40;
            rrect.Labels.Add(lblOneToMany);
            diagram1.Model.AppendChild(rrect);
            LineConnector oneToOne = new LineConnector(new PointF(910, 50), new PointF(1010, 50));
            oneToOne.EditStyle.AllowSelect = false;
            oneToOne.TailDecorator.DecoratorShape = DecoratorShape.FilledDiamond;
            oneToOne.HeadDecorator.DecoratorShape = DecoratorShape.FilledDiamond;
            diagram1.Model.AppendChild(oneToOne);

            LineConnector oneToMany = new LineConnector(new PointF(910, 80), new PointF(1010, 80));
            oneToMany.EditStyle.AllowSelect = false;
            oneToMany.TailDecorator.DecoratorShape = DecoratorShape.Diamond;
            oneToMany.HeadDecorator.DecoratorShape = DecoratorShape.FilledDiamond;
            diagram1.Model.AppendChild(oneToMany);


            // Read data from the XML data file and populate a Hashtable using the employee ID as the key
            Hashtable lstEmployees = this.ReadEmployeeDataFromXMLFile(path);

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

            //Make connection between nodes
            ConnectNodes();
            diagram1.Model.EndUpdate();
            diagram1.View.SelectionList.Clear();
        }

        /// <summary>
        /// Generates the SubEmployee count
        /// </summary>
        /// <param name="empl">Employee</param>
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
        /// Read data from the XML file
        /// </summary>
        /// <param name="datasrc">XML file</param>
        /// <returns>returns the table</returns>
        protected Hashtable ReadEmployeeDataFromXMLFile(string datasrc)
        {
            Hashtable lstEmployee = new Hashtable();

            // Use the XML DOM to read data from the employees XML data file
            XmlDocument xmldoc = new XmlDocument();
#if SyncfusionFramework4_0
            xmldoc.XmlResolver = null;
#endif
            try
            {
                xmldoc.Load(datasrc);
                if (xmldoc.DocumentElement.HasChildNodes)
                {
                    XmlNodeList employeelist = xmldoc.DocumentElement.ChildNodes;
                    for (int i = 0; i < employeelist.Count; i++)
                    {
                        // Create an Employee instance to represent each employee
                        Employee emply = new Employee();

                        XmlNode employeenode = employeelist[i];
                        emply.TableName = employeenode.Name;
                        string strTableName = employeenode.Name;
                        ArrayList strColoumnName = new ArrayList();

                        XmlNodeList employeedatalist = employeenode.ChildNodes;
                        IEnumerator employeedata = employeedatalist.GetEnumerator();
                        employeedata.Reset();
                        while (employeedata.MoveNext())
                        {
                            XmlNode dataelement = employeedata.Current as XmlNode;
                            strColoumnName.Add(dataelement.Name);

                            switch (dataelement.Name)
                            {
                                case "PrimaryKey":
                                    emply.PrimaryKeyID = dataelement.InnerText;
                                    break;
                                case "ForeignKey":
                                    emply.ForeignKeyID = dataelement.InnerText;
                                    break;
                                case "TableID":
                                    emply.EmployeeID = dataelement.InnerText;
                                    break;
                                default:
                                    emply.Coloumns.Add(dataelement.Name);
                                    break;
                            }
                        }
                        lstEmployee.Add(emply.EmployeeID, emply);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not able to load the xml file");
            }

            return lstEmployee;
        }

        /// <summary>
        ///  Rearrange the employees collection as a manager-subemployee nested tree
        /// </summary>
        /// <param name="htemployees">List of data</param>
        /// <returns>returns sorted data list</returns>
        private ArrayList GetSortedEmployeesList(Hashtable htemployees)
        {
            ICollection employees = htemployees.Values;
            ArrayList sortedlist = new ArrayList();
            foreach (Employee emply in employees)
            {
                if (emply.ForeignKeyID == string.Empty)
                {
                    // Employees without a ManagerID are top-level nodes in the org tree
                    sortedlist.Add(emply);
                }
                else
                {
                    // Find the employee instance associated with the managerID and add this object as 
                    // a subemployee of the manager node.
                    Employee manager = (Employee)htemployees[emply.ForeignKeyID];
                    if (manager != null)
                        manager.SubEmployees.Add(emply);
                }
            }

            return sortedlist;
        }

      
        /// <summary>
        /// Create diagram symbol nodes for each employee in the organization and add these symbols to the diagram
        /// Create links between manager and sub-employees to depict the org structure
        /// </summary>
        /// <param name="alemployees"></param>
        private void CreateOrgDiagramFromList(ArrayList alemployees)
        {
            // Temporarily suspend the Diagram Model redrawing
            this.diagram1.Model.BeginUpdate();

            foreach (Employee emply in alemployees)
            {
                Group emplysymbol = InsertSymbolEmployee(emply);
                this.IterCreateEmployeeSymbol(emply, emplysymbol);
            }

            // ReEnable the Model redraw
            this.diagram1.Model.EndUpdate();
        }

        /// <summary>
        /// Iterative sub-employee symbol node creation
        /// </summary>
        /// <param name="emply">Employees business object</param>
        /// <param name="emplysymbol">Node</param>
        private void IterCreateEmployeeSymbol(Employee emply, Group emplysymbol)
        {
            foreach (Employee subemply in emply.SubEmployees)
            {
                // Create a EmployeeSymbol for each of the sub-employees of the particular employee //Waterfall, Horizontal
                Group subemplysymbol = InsertSymbolEmployee(subemply);
                this.IterCreateEmployeeSymbol(subemply, subemplysymbol);
            }
        }

        /// <summary>
        /// Insert Node
        /// </summary>
        /// <param name="employee">Employee object</param>
        /// <returns>returns the node</returns>
        private Group InsertSymbolEmployee(Employee employee)
        {
            DataSymbol Symbol = new DataSymbol( employee.Coloumns, employee.TableName,employee.PrimaryKeyID);
            this.diagram1.Model.AppendChild(Symbol);
            return Symbol;
        }
      
        
        /// <summary>
        /// Connect Nodes with connectors
        /// </summary>
        /// <param name="emplysymbol">Parent</param>
        /// <param name="subemplysymbol">Child</param>
        /// <param name="relation">relationship</param>
        private void ConnectNodes(Node emplysymbol, Node subemplysymbol, string relation)
        {
            LineConnector ortholink = new LineConnector(PointF.Empty, new PointF(0, 1));
            ortholink.LineStyle.DashStyle = DashStyle.Solid;
            
            ortholink.LineStyle.LineWidth = 1f;
            ortholink.LineStyle.LineColor = Color.Black; 
            if( relation == "OneToMany")
                ortholink.TailDecorator.DecoratorShape = DecoratorShape.Diamond;
            else
                ortholink.TailDecorator.DecoratorShape = DecoratorShape.FilledDiamond;

            ortholink.HeadDecorator.DecoratorShape = DecoratorShape.FilledDiamond;
            
            this.diagram1.Model.AppendChild(ortholink);

            if (emplysymbol.CentralPort != null && subemplysymbol.CentralPort != null)
            {
                emplysymbol.CentralPort.TryConnect(ortholink.TailEndPoint);
                subemplysymbol.CentralPort.TryConnect(ortholink.HeadEndPoint);
            }

            this.diagram1.Controller.SendToBack();
        }

        #endregion

        #region Properties

       
         bool SaveChanges
        {
            get
            {
                if (diagram1.Model.Modified || needSave)
                    return true;
                else
                    return false;
            }
            set
            {
                needSave = value;
            }
        }

        public bool HasFileName
        {
            get
            {
                return (this.fileName != null && this.fileName.Length > 0);
            }
        }

        #endregion

        #region Event Handlers
        void EventSink_NodeClick(NodeMouseEventArgs evtArgs)
        {
            if (diagram1.Controller.TextEditor.IsEditing)
            {
                diagram1.Controller.TextEditor.EndEdit(true);
            }
            NodeCollection nodes = diagram1.Controller.GetAllNodesAtPoint(diagram1.Model, diagram1.Controller.MouseLocation) as NodeCollection;

            foreach (Node gnode in nodes)
            {
                if (gnode is TextNode)
                {
                    diagram1.Controller.TextEditor.BeginEdit(gnode, false);
                }
                if (gnode.Name == "BaseNode")
                {
                    if (prevbNode == null)
                        prevbNode = gnode;
                    if (prevbNode == gnode)
                    {
                        ((FilledPath)gnode).FillStyle.Color = Color.FromArgb(117, 186, 255);
                        //((FilledPath)prevbNode).FillStyle.Color = Color.WhiteSmoke;
                    }
                    else
                    {
                        ((FilledPath)gnode).FillStyle.Color = Color.FromArgb(117, 186, 255);
                        ((FilledPath)prevbNode).FillStyle.Color = Color.WhiteSmoke;
                        prevbNode = gnode;
                    }
                }
            }
        }

        void Application_Idle(object sender, EventArgs e)
        {
            if (this.diagram1 != null && this.diagram1.Model != null)
            {
                this.saveToolStripButton.Enabled = true;
                this.saveAsToolStripButton.Enabled = true;
               

            }
            else
            {
                this.saveToolStripButton.Enabled = false;
                this.saveAsToolStripButton.Enabled = false;
              
            }
        }

       
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = "Diagram";
            saveFileDialog1.Filter = @"XML file(*.xml)|*.xml|EDD file(*.edd)|*.edd|All files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
#if NETCORE || NET50 || NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                        diagram1.SaveXml(saveFileDialog1.FileName);
                        this.diagram1.Refresh();
#else
                        this.diagram1.SaveSoap(saveFileDialog1.FileName);
#endif
                        break;
                    case 2:
                        diagram1.SaveBinary(saveFileDialog1.FileName);

                        break;
                    default:
                        diagram1.SaveBinary(saveFileDialog1.FileName);
                        break;
                }
            }
        } 
        
        private void saveAsToolStripButton_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = "Diagram";
            saveFileDialog1.Filter = @"XML file(*.xml)|*.xml|EDD file(*.edd)|*.edd|All files|*.*";
            saveFileDialog1.Title = "Save File As:";
            saveFileDialog1.FileName = "Diagram";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
#if NETCORE || NET50 || NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                        diagram1.SaveXml(saveFileDialog1.FileName);
                        this.diagram1.Refresh();
#else
                        this.diagram1.SaveSoap(saveFileDialog1.FileName);
#endif
                        break;
                    case 2:
                        diagram1.SaveBinary(saveFileDialog1.FileName);

                        break;
                    default:
                        diagram1.SaveBinary(saveFileDialog1.FileName);
                        break;
                }
            }
        }

        private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"W3C Portable Network Graphics(*.png)|*.png";
            saveFileDialog1.Title = "Export Diagram As:";
            saveFileDialog1.FileName = "Diagram";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageFormat imgformat = ImageFormat.Png;
                SaveImage(saveFileDialog1.FileName, imgformat);
            }
            else
            {
                return;
            }
        }

        private void jPEGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"Joint Photographic Experts Group(*.jpeg)|*.jpeg";
            saveFileDialog1.Title = "Export Diagram As:";
            saveFileDialog1.FileName = "Diagram";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageFormat imgformat = ImageFormat.Jpeg;
                SaveImage(saveFileDialog1.FileName, imgformat);
            }
            else
            {
                return;
            }
        }

        private void gIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"Graphics Interchange Format(*.gif)|*.gif";
            saveFileDialog1.Title = "Export Diagram As:";
            saveFileDialog1.FileName = "Diagram";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageFormat imgformat = ImageFormat.Gif;
                SaveImage(saveFileDialog1.FileName, imgformat);

            }
            else
            {
                return;
            }
        }

        private void sVGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = @"Scalable Vector Graphics Format(*.svg)|*.svg";
            saveFileDialog1.FileName = "Diagram";
            saveFileDialog1.Title = "Export Diagram As:";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                ToSvg tosvg = new ToSvg();
                // Get Diagram Nodes Bounding Rectangle.
                RectangleF rectBounding = this.diagram1.Model.GetBoundingRect();
                Graphics gfx = tosvg.GetRealGraphics(new Size((int)rectBounding.Width, (int)rectBounding.Height));
                this.diagram1.ExportDiagramToGraphics(gfx);
                tosvg.Save(saveFileDialog1.FileName);

            }
            else
            {
                return;
            }
        }

        private void zoomInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            diagram1.View.ZoomIn();
            diagram1.Controller.ActivateTool("PanTool");
        }

        private void zoomOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            diagram1.View.ZoomOut();
        }

        private void resetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            diagram1.View.ZoomToActual();
        }
        
#endregion

#region Helper Methods
        /// Save diagram as Image
        /// </summary>
        /// <param name="filename">Filename </param>
        /// <param name="imageformat">image format</param>
        private void SaveImage(string filename, ImageFormat imageformat)
        {
            Image img = this.diagram1.View.ExportDiagramAsImage(false);
            img.Save(filename, imageformat);
        }

        /// <summary>
        /// Save diagram
        /// </summary>
        /// <param name="filename">file name</param>
        /// <param name="index">index</param>
        private void SaveDiagramAs(string filename, int index)
        {
            switch (index)
            {
                case 1:
                    diagram1.SaveBinary(filename);
                    break;
                case 2:
#if !NETCORE
                    diagram1.SaveSoap(filename);
#endif
                    break;
                default:
                    diagram1.SaveBinary(filename);
                    break;
            }
        }

        /// <summary>
        /// Open Diagram
        /// </summary>
        /// <param name="filename">file name</param>
        /// <param name="index">index</param>
        private void OpenDiagramAs(string filename, int index)
        {
            switch (index)
            {
                case 1:
#if NETCORE || NET50 || NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                    diagram1.LoadXml(filename);
                    this.diagram1.Refresh();
#else
                        this.diagram1.LoadSoap(filename);
#endif
                    break;
                case 2:
                    diagram1.LoadBinary(filename);
                    break;
                default:
                    diagram1.LoadBinary(filename);
                    break;
            }
        }

        /// <summary>
        /// Activates the given tool
        /// </summary>
        /// <param name="toolName">Tool</param>
        private void SetActiveTool(string toolName)
        {
            this.diagram1.Controller.ActivateTool(toolName);
        }
#endregion

        private void cboDatabaseDiagram_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDatabaseDiagram.SelectedIndex == 0)
            {
#if !NETCORE
                InitializeDiagramFromXMLData(@"..\..\..\..\..\..\common\Data\Diagram\xml\Database.xml");
#else
                InitializeDiagramFromXMLData(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Database.xml");
#endif
            }
            else if (cboDatabaseDiagram.SelectedIndex == 1)
            {
#if !NETCORE
                InitializeDiagramFromXMLData(@"..\..\..\..\..\..\common\Data\Diagram\xml\Database1.xml");
#else
                InitializeDiagramFromXMLData(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Database1.xml");
#endif
            }
            else if (cboDatabaseDiagram.SelectedIndex == 2)
            {
#if !NETCORE
                InitializeDiagramFromXMLData(@"..\..\..\..\..\..\common\Data\Diagram\xml\Database2.xml");
#else
                InitializeDiagramFromXMLData(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Database2.xml");
#endif
            }
        }
    }
}
