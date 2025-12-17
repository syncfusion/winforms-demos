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


namespace XMLBinding
{
    public partial class Form1 : MetroForm
    {
        #region Members        
        
        #endregion

        #region Form Initialization
        public Form1()
        {
            InitializeComponent();

            diagram1.BeginUpdate();

            DiagramAppearance();
#if !NETCORE
            InitializeDiagramFromXMLData(@"..\..\..\..\..\..\common\Data\Diagram\xml\XML Binding.xml");
#else
            InitializeDiagramFromXMLData(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\XML Binding.xml");
#endif
            SetLayout();
            comboXml.SelectedIndex = 0;
            diagram1.View.SelectionList.Clear();

            diagram1.EndUpdate();
            comboXml.SelectedIndexChanged += new EventHandler(comboXml_SelectedIndexChanged);
        }

#endregion

#region Private Methods
        /// <summary>
        /// Change's the appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.Model.LineStyle.LineColor = Color.LightGray;            
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;            
            this.diagram1.Model.BoundaryConstraintsEnabled = false;            
            this.diagram1.View.BackgroundColor = Color.White;
            this.diagram1.View.SelectionList.Clear();
        }
#endregion

#region Initailize Diagram 

        /// <summary>
        /// Apply Layout to the Diagram
        /// </summary>
        private void SetLayout()
        {
            HierarchicLayoutManager hierarchicalLayout = new HierarchicLayoutManager(diagram1.Model, 0, 100, 20);
            hierarchicalLayout.HorizontalSpacing = 20;
            hierarchicalLayout.VerticalSpacing = 100;
            hierarchicalLayout.LeftMargin = 10;
            hierarchicalLayout.TopMargin = 20;
            diagram1.LayoutManager = hierarchicalLayout;
            diagram1.LayoutManager.UpdateLayout(null);
        }

        /// <summary>
        /// Initialize diagram from XML file
        /// </summary>
        /// <param name="datasrcpath">Path of the XML file</param>
        protected void InitializeDiagramFromXMLData(string datasrcpath)
        {

            //C:\Users\senthilkumarm\AppData\Local\Syncfusion\EssentialStudio\10.2.0.56\Common\Data\Diagram
            // Read data from the XML data file and populate a Hashtable using the employee ID as the key
            System.Collections.Generic.List<XMLBindinglist> lstEmployees = this.ReadEmployeeDataFromXMLFile(datasrcpath);
            IterCreateEmployeeSymbol(lstEmployees);

        }

        /// <summary>
        /// New function for reading data from xml file
        /// </summary>
        /// <param name="datasrc">XML File</param>
        /// <returns></returns>
        protected System.Collections.Generic.List<XMLBindinglist> ReadEmployeeDataFromXMLFile(string datasrc)
        {
            System.Collections.Generic.List<XMLBindinglist> lstEmployee = new System.Collections.Generic.List<XMLBindinglist>();

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
                    XMLBindinglist emply = new XMLBindinglist();

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
                                emply.EmployeeName =  dataelement.InnerText;
                                break;
                            case "EmployeeID":
                                emply.EmployeeID = dataelement.InnerText;
                                break;
                            case "Designation":
                                emply.Designation = dataelement.InnerText;
                                emply.EmployeeName += System.Environment.NewLine +  dataelement.InnerText;
                                break;
                            case "ManagerID":
                                emply.ManagerID = dataelement.InnerText;
                                break;
                        }
                    }
                    lstEmployee.Add(emply);
                }
            }

            return lstEmployee;
        }

        /// <summary>
        /// Iterative sub-employee symbol node creation
        /// </summary>
        /// <param name="emply">List Employees in the XML file</param>       
        protected void IterCreateEmployeeSymbol(List<XMLBindinglist> emply)
        {
            foreach (XMLBindinglist subemply in emply)
            {

                Syncfusion.Windows.Forms.Diagram.Rectangle rect = new Syncfusion.Windows.Forms.Diagram.Rectangle(200, 0, 150, 60);
                rect.Name = subemply.EmployeeID;
                rect.FillStyle.Color = System.Drawing.Color.FromArgb(240, 242, 240);
                rect.FillStyle.ForeColor = System.Drawing.Color.White;
                rect.FillStyle.Type = FillStyleType.LinearGradient;
                rect.LineStyle.LineColor = System.Drawing.Color.Black;
                this.diagram1.Model.AppendChild(rect);
                Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label();
                label.Container = rect;
                label.Text = subemply.EmployeeName;
                label.Position = Position.Center;
                label.FontStyle.Family = "Segoe UI";
                label.FontStyle.Size = 8;
                rect.Labels.Add(label);

                if (!string.IsNullOrEmpty(subemply.ManagerID))
                {

                    //OrthogonalConnector conn = new OrthogonalConnector(PointF.Empty, new PointF(0, 1));
                    OrgLineConnector conn = new OrgLineConnector(System.Drawing.PointF.Empty, new System.Drawing.PointF(0, 1), MeasureUnits.Pixel);
                    conn.LineStyle.LineColor = System.Drawing.Color.Black;
                    Decorator decor = conn.HeadDecorator;
                    decor.DecoratorShape = DecoratorShape.Filled45Arrow;
                    decor.Size = new System.Drawing.SizeF(10, 10);
                    decor.FillStyle.Color = System.Drawing.Color.Black;
                    decor.LineStyle.LineColor = System.Drawing.Color.Black;
                    conn.VerticalDistance = 50;
                    Syncfusion.Windows.Forms.Diagram.Rectangle rect1 = diagram1.Model.Nodes.FindNodeByName(subemply.ManagerID) as Syncfusion.Windows.Forms.Diagram.Rectangle;

                    rect1.CentralPort.TryConnect(conn.TailEndPoint);
                    rect.CentralPort.TryConnect(conn.HeadEndPoint);
                    this.diagram1.Model.AppendChild(conn);
                    // this.diagram1.Model.BringToFront(rect1);
                }
                //orgLayoutMgr.Nodes.Clear();
                //orgLayoutMgr.Nodes.AddRange(this.diagram1.Model.Nodes);
                //orgLayoutMgr.UpdateLayout(null);

            }

        }
#endregion

#region Event Handlers

        void comboXml_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboXml.SelectedIndex == 1)
            {
                this.diagram1.BeginUpdate();
                diagram1.Model.Nodes.Clear();
#if !NETCORE
                InitializeDiagramFromXMLData(@"..\..\..\..\..\..\common\Data\Diagram\xml\XML Binding1.xml");
#else
                InitializeDiagramFromXMLData(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\XML Binding1.xml");
#endif
                SetLayout();
                diagram1.View.SelectionList.Clear();
                diagram1.EndUpdate();
            }
            else if (comboXml.SelectedIndex == 0)
            {
                this.diagram1.BeginUpdate();
                diagram1.Model.Nodes.Clear();
#if !NETCORE
                InitializeDiagramFromXMLData(@"..\..\..\..\..\..\common\Data\Diagram\xml\XML Binding.xml");
#else
                InitializeDiagramFromXMLData(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\XML Binding.xml");
#endif
                SetLayout();
                diagram1.View.SelectionList.Clear();
                diagram1.EndUpdate();
            }
        }      

#endregion

        
    }
   
}
