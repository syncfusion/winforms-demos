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
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Printing;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.SVG.IO;
using System.Drawing.Imaging;
using Syncfusion.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace Class_Diagram
{
    public partial class Form1 : Form
    {
        #region Members

        bool needSave = false;
        public string fileName;
        float PinPointX = 0, PinPointY = 0;
        private SymbolPalette palette = new SymbolPalette();
        #endregion

        #region Form Initialize
        public Form1()
        {
            InitializeComponent();
            this.diagram1.BeginUpdate();
            //Diagram Settings
            this.diagram1.Model.DocumentSize = new PageSize(1050, 650);
            this.diagram1.Model.LineBridgingEnabled = true;
            this.diagram1.Model.LineRoutingEnabled = true;
            this.diagram1.Model.LineRouter.RoutingMode = RoutingMode.Automatic;
            this.diagram1.Model.LineRouter.DistanceToObstacles = 20;
            this.diagram1.DefaultContextMenuEnabled = false;

            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.VScroll = false;
            this.diagram1.HScroll = false;
            //Generate Diagram
            CreateClassDiagram();
            //Clear selectionlist
            this.diagram1.View.SelectionList.Clear();
            ApplyLayout();
            //Route all model connectors
            this.diagram1.Model.LineRouter.RouteAllModelConnectors();
            GroupBarAppearance();
            this.diagram1.EndUpdate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Wire up OnIdle processing
            Application.Idle += new EventHandler(Application_Idle);
        }
        #endregion

        #region Initialize Diagram
        /// <summary>
        /// Initializes the diagram
        /// </summary>
        private void CreateClassDiagram()
        {
            List<ClassList> classList = ReadFromDatabase(1);
            GenerateClassDiagram(classList, 1);

            Node group1 = diagram1.Model.Nodes.FindNodeByName("group1");            
            Node group2 = diagram1.Model.Nodes.FindNodeByName("group2");
            group2.Size = new SizeF(group2.Size.Width + 15, group2.Size.Height);
            group2.PinPoint = new PointF(group2.PinPoint.X + 15, group2.PinPoint.Y);
            Node group3 = diagram1.Model.Nodes.FindNodeByName("group3");            
            Node group4 = diagram1.Model.Nodes.FindNodeByName("group4");            
            Node group5 = diagram1.Model.Nodes.FindNodeByName("group5");            
            Node group6 = diagram1.Model.Nodes.FindNodeByName("group6");

            //ports 
            ConnectionPoint gp3 = new ConnectionPoint();
            gp3.Position = Position.MiddleRight;
            gp3.Visible = false;
            group3.Ports.Add(gp3);
            ConnectionPoint gp5 = new ConnectionPoint();
            gp5.OffsetX = 0;
            gp5.OffsetY = group5.BoundingRectangle.Height - 20;
            gp5.Visible = false;
            group5.Ports.Add(gp5);

            ConnectorBase Connector1 = ConnectNodes(group2, group1, DecoratorShape.DoubleArrow, "Errors", 40, -25, true, 1);
            ConnectorBase Connector2 = ConnectNodes(group3, group2, DecoratorShape.OpenFancyArrow, "Notification", 30, 20, true, 1);
            ConnectorBase Connector3 = ConnectNodes(group4, group3, DecoratorShape.Filled45Arrow, "", 0, 0, false, 0);
            ConnectorBase Connector4 = ConnectNodes(group5, group2, DecoratorShape.OpenFancyArrow, "Notification", 50, -25, true, 2);
            ConnectorBase Connector5 = ConnectNodes(group5.Ports[1], group3.Ports[1], DecoratorShape.OpenFancyArrow, "Data", 90, -15, true, 2);
            ConnectorBase Connector6 = ConnectNodes(group6, group5, DecoratorShape.Filled45Arrow, "", 0, 0, false, 0);

            SymbolPalette palette = new SymbolPalette();
            palette.Name = "Class Nodes";
            palette.AppendChild(group1);
            palette.AppendChild(group2);
            palette.AppendChild(group3);
            palette.AppendChild(group4);
            palette.AppendChild(group5);
            palette.AppendChild(group6);
            palette.AppendChild(Connector1);
            palette.AppendChild(Connector2);
            palette.AppendChild(Connector3);
            palette.AppendChild(Connector4);
            palette.AppendChild(Connector5);
            palette.AppendChild(Connector6);
            paletteGroupBar1.AddPalette(palette);
           
        }


        private void CreateClassDiagram1()
        {
            List<ClassList> classList = ReadFromDatabase(2);
            GenerateClassDiagram(classList, 2);


            Node group1 = diagram1.Model.Nodes.FindNodeByName("group1");
            Node group2 = diagram1.Model.Nodes.FindNodeByName("group2");
            Node group3 = diagram1.Model.Nodes.FindNodeByName("group3");
            Node group4 = diagram1.Model.Nodes.FindNodeByName("group4");
            Node group5 = diagram1.Model.Nodes.FindNodeByName("group5");
            Node group6 = diagram1.Model.Nodes.FindNodeByName("group6");


            ConnectNodes(group1, group2, DecoratorShape.OpenFancyArrow, "", 0, 0, false, 1);
            ConnectNodes(group2, group4, DecoratorShape.OpenFancyArrow, "", 0, 0, false, 1);
            ConnectNodes(group3, group5, DecoratorShape.OpenFancyArrow, "", 0, 0, false, 0);
            ConnectNodes(group3, group6, DecoratorShape.OpenFancyArrow, "", 0, 0, false, 2);
            
        }

        /// <summary>
        /// Generate the class diagram through ClassList
        /// </summary>
        /// <param name="classList"></param>
        private void GenerateClassDiagram(List<ClassList> classList, int DiagramType)
        {
            if (classList.Count > 0)
            {
                for (int i = 0; i < classList.Count; i++)
                {
                    GetPinPoint(i, DiagramType);
                    CustomGroup custom = new CustomGroup(classList[i]);
                    custom.PinPoint = new PointF(PinPointX, PinPointY);
                    custom.Name = "group" + (i + 1);
                    diagram1.Model.AppendChild(custom);
                }
            }
        }

        /// <summary>
        /// Applies layout to the diagram
        /// </summary>
        private void ApplyLayout()
        {
            RadialTreeLayoutManager smtLayout = new RadialTreeLayoutManager(this.diagram1.Model, 0, 100, 30);
            smtLayout.TopMargin = 0;
            smtLayout.LeftMargin = 40;
            this.diagram1.LayoutManager = smtLayout;
            this.diagram1.LayoutManager.UpdateLayout(null);
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Change's the appearance of GroupBar
        /// </summary>
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

        /// <summary>
        /// Change's the appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.Model.LineBridgingEnabled = true;
            this.diagram1.Model.LineRoutingEnabled = true;
            this.diagram1.Model.LineRouter.RoutingMode = RoutingMode.Automatic;
            this.diagram1.Model.LineRouter.DistanceToObstacles = 20;                       
            this.diagram1.DefaultContextMenuEnabled = false;
            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.LightGray;
            this.diagram1.View.Grid.VerticalSpacing = 15;
            this.diagram1.View.Grid.HorizontalSpacing = 15;
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;           
            this.diagram1.Model.DocumentSize = new PageSize(this.diagram1.View.ClientRectangle.Size.Width, diagram1.View.ClientRectangle.Size.Height);
            this.diagram1.Model.MinimumSize = diagram1.View.ClientRectangle.Size;
            this.diagram1.Model.SizeToContent = true;
            this.diagram1.View.SelectionList.Clear();
        }
        

        /// <summary>
        /// Connect the ParentNode and ChildNode
        /// </summary>
        /// <param name="parentNode">ParentNode</param>
        /// <param name="childNode">ChildNode</param>
        /// <param name="decoratorShape">DecoratorShape of the connector</param>
        /// <param name="labelText">Set the text to the label</param>
        /// <param name="OffsetX">Set the OffsetX to the label</param>
        /// <param name="OffsetY">Set the OffsetY to the label</param>
        /// <param name="DrawImage">Determines whether image should draw with label or not</param>
        /// <param name="classType">Classtype</param>
        private ConnectorBase ConnectNodes(Node parentNode, Node childNode, DecoratorShape decoratorShape, string labelText, float OffsetX, float OffsetY, bool DrawImage, int classType)
        {
            if (parentNode != null && childNode != null)
            {

                OrthogonalConnector lConnector = new OrthogonalConnector(System.Drawing.PointF.Empty, new System.Drawing.PointF(0, 1));
                lConnector.HeadDecorator.DecoratorShape = decoratorShape;
                lConnector.LineRoutingEnabled = true;
                lConnector.LineStyle.LineColor = Color.Goldenrod;
                lConnector.LineStyle.LineWidth = 1;
                lConnector.CentralPort.ConnectionsLimit = 10000;

                ImageLabel imageLabel = new ImageLabel(lConnector, labelText);
                imageLabel.OffsetX = OffsetX;
                imageLabel.OffsetY = OffsetY;
                imageLabel.ImageOffsetX = OffsetX - 25;
                imageLabel.ImageOffsetY = OffsetY - 5;
                imageLabel.DrawImage = DrawImage;
                if (classType == 1)
                    imageLabel.TextImage = System.Drawing.Image.FromFile(@"..\..\..\..\..\..\Common\Images\Diagram\class diagram\6.png");
                else
                    imageLabel.TextImage = System.Drawing.Image.FromFile(@"..\..\..\..\..\..\Common\Images\Diagram\class diagram\7.png");
                lConnector.Labels.Add(imageLabel);
                lConnector.HeadDecorator.Size = new System.Drawing.SizeF(12, 12);
                if (decoratorShape == DecoratorShape.Filled45Arrow)
                    lConnector.HeadDecorator.FillStyle.Color = Color.White;
                lConnector.HeadDecorator.LineStyle.LineColor = Color.Goldenrod;
                lConnector.LineRoutingEnabled = true;
                parentNode.CentralPort.TryConnect(lConnector.TailEndPoint);
                childNode.CentralPort.TryConnect(lConnector.HeadEndPoint);
                this.diagram1.Model.AppendChild(lConnector);
                this.diagram1.Model.SendToBack(lConnector);

                return lConnector;
            }
            else
                return null;
        }

        /// <summary>
        /// Connect the ParentNode's Port and ChildNode's Port
        /// </summary>
        /// <param name="parentNode">ParentNode's Port</param>
        /// <param name="childNode">ChildNode's Port</param>
        /// <param name="decoratorShape">DecoratorShape of the connector</param>
        /// <param name="labelText">Set the text to the label</param>
        /// <param name="OffsetX">Set the OffsetX to the label</param>
        /// <param name="OffsetY">Set the OffsetY to the label</param>
        /// <param name="DrawImage">Determines whether image should draw with label or not</param>
        /// <param name="classType">Classtype</param>
        private ConnectorBase ConnectNodes(ConnectionPoint parentNode, ConnectionPoint childNode, DecoratorShape decoratorShape, string labelText, float OffsetX, float OffsetY, bool DrawImage, int classType)
        {
            if (parentNode != null && childNode != null)
            {

                OrthogonalConnector lConnector = new OrthogonalConnector(System.Drawing.PointF.Empty, new System.Drawing.PointF(0, 1));
                lConnector.LineRoutingEnabled = true;
                lConnector.LineRoutingEnabled = true;
                lConnector.HeadDecorator.DecoratorShape = decoratorShape;
                lConnector.LineStyle.LineColor = Color.Goldenrod;
                lConnector.LineStyle.LineWidth = 1;
                lConnector.CentralPort.ConnectionsLimit = 10000;

                ImageLabel imageLabel = new ImageLabel(lConnector, labelText);
                imageLabel.OffsetX = OffsetX;
                imageLabel.OffsetY = OffsetY;
                imageLabel.ImageOffsetX = OffsetX - 25;
                imageLabel.ImageOffsetY = OffsetY - 5;
                imageLabel.DrawImage = DrawImage;
                if (classType == 1)
                    imageLabel.TextImage = System.Drawing.Image.FromFile(@"..\..\..\..\..\..\Common\Images\Diagram\class diagram\6.png");
                else
                    imageLabel.TextImage = System.Drawing.Image.FromFile(@"..\..\..\..\..\..\Common\Images\Diagram\class diagram\7.png");
                lConnector.Labels.Add(imageLabel);
                lConnector.HeadDecorator.Size = new System.Drawing.SizeF(12, 12);
                if (decoratorShape == DecoratorShape.Filled45Arrow)
                    lConnector.HeadDecorator.FillStyle.Color = Color.White;
                lConnector.HeadDecorator.LineStyle.LineColor = Color.Goldenrod;
                lConnector.LineRoutingEnabled = true;
                parentNode.TryConnect(lConnector.TailEndPoint);
                childNode.TryConnect(lConnector.HeadEndPoint);
                this.diagram1.Model.AppendChild(lConnector);
                this.diagram1.Model.SendToBack(lConnector);
                return lConnector;
            }
            else
                return null;
        }
        /// <summary>
        /// Read the values from database and returns ClassList
        /// </summary>
        /// <returns></returns>
        protected System.Collections.Generic.List<ClassList> ReadFromDatabase(int SelectType)
        {
            System.Collections.Generic.List<ClassList> lstClass = new System.Collections.Generic.List<ClassList>();

            string strCon = @"Data Source=..\..\..\..\..\..\Common\Data\Diagram\db\Diagram.sdf";
            System.Data.SqlServerCe.SqlCeConnection connection = new System.Data.SqlServerCe.SqlCeConnection(strCon);
            connection.Open();
            
            System.Data.SqlServerCe.SqlCeDataAdapter adapter;
            SqlCeCommand comm;
            if (SelectType == 1)
            {
                comm = new SqlCeCommand("Select * from tblClassDiagram", connection);                
            }
            else
            {
                comm = new SqlCeCommand("Select * from tblClassDiagram1 order by ClassId", connection);                
            }
            adapter = new System.Data.SqlServerCe.SqlCeDataAdapter(comm);
            System.Data.DataSet ds = new System.Data.DataSet("Table");
            
            adapter.Fill(ds);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ClassList classObj = new ClassList();
                    classObj.ClassName = dt.Rows[i]["ClassName"].ToString();
                    classObj.ClassType = dt.Rows[i]["ClassType"].ToString();
                    classObj.ObjectType = dt.Rows[i]["ObjectType"].ToString();

                    for (int j = i; j < dt.Rows.Count; j++)
                    {
                        if (dt.Rows[i]["ClassName"].ToString() == dt.Rows[j]["ClassName"].ToString())
                        {

                            if (!string.IsNullOrEmpty(dt.Rows[j]["Properties"].ToString()))
                            {
                                PropertyList propertyList = new PropertyList();
                                propertyList.PropertyName = dt.Rows[j]["Properties"].ToString();
                                propertyList.PropertyType = (PropertyType)(Enum.Parse(typeof(PropertyType), dt.Rows[j]["PropertyType"].ToString()));
                                classObj.PropertyList.Add(propertyList);
                            }
                            if (!string.IsNullOrEmpty(dt.Rows[j]["Methods"].ToString()))
                            {
                                MethodList methodList = new MethodList();
                                methodList.MethodName = dt.Rows[j]["Methods"].ToString();
                                methodList.MethodType = (MethodType)(Enum.Parse(typeof(MethodType), dt.Rows[j]["MethodType"].ToString()));
                                classObj.MethodList.Add(methodList);
                            }
                        }
                        else
                        {
                            i = j - 1;
                            lstClass.Add(classObj);
                            break;
                        }
                        if (j == dt.Rows.Count - 1)
                        {
                            i = j;
                            lstClass.Add(classObj);
                            break;
                        }
                    }

                }
            }
            return lstClass;
        }

        /// <summary>
        /// Set the pinpoint of group
        /// </summary>
        /// <param name="i"></param>
        protected void GetPinPoint(int i, int DiagramType)
        {
            if (DiagramType == 1)
            {
                switch (i)
                {
                    case 0:
                        PinPointX = 150;
                        PinPointY = 150;
                        break;
                    case 1:
                        PinPointX = 500;
                        PinPointY = 150;
                        break;
                    case 2:
                        PinPointX = 500;
                        PinPointY = 340;
                        break;
                    case 3:
                        PinPointX = 500;
                        PinPointY = 510;
                        break;
                    case 4:
                        PinPointX = 900;
                        PinPointY = 150;
                        break;
                    case 5:
                        PinPointX = 900;
                        PinPointY = 400;
                        break;
                }
            }
            else
            {
                switch (i)
                {
                    case 0:
                        PinPointX = 150;
                        PinPointY = 150;
                        break;
                    case 1:
                        PinPointX = 150;
                        PinPointY = 450;
                        break;
                    case 2:
                        PinPointX = 500;
                        PinPointY = 150;
                        break;
                    case 3:
                        PinPointX = 500;
                        PinPointY = 450;
                        break;
                    case 4:
                        PinPointX = 850;
                        PinPointY = 150;
                        break;
                    case 5:
                        PinPointX = 850;
                        PinPointY = 400;
                        break;
                }
            }
        }
        #endregion

        #region Properties

        public bool SaveChanges
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

        void Application_Idle(object sender, EventArgs e)
        {
            if (this.diagram1 != null && this.diagram1.Model != null)
            {
                this.saveToolStripButton.Enabled = true;
                this.saveAsToolStripButton.Enabled = true;
                this.cutToolStripButton.Enabled = diagram1.CanCut;
                this.copyToolStripButton.Enabled = diagram1.CanCopy;
                if (this.WindowState != FormWindowState.Minimized)
                    this.pasteToolStripButton.Enabled = diagram1.CanPaste;
                this.undoToolStripButton.Enabled = diagram1.Model.HistoryManager.CanUndo;
                this.redoToolStripButton.Enabled = diagram1.Model.HistoryManager.CanRedo;
                this.deleteToolStripButton.Enabled = (this.diagram1.View.SelectionList.Count > 0);

            }
            else
            {
                this.saveToolStripButton.Enabled = false;
                this.saveAsToolStripButton.Enabled = false;
                this.cutToolStripButton.Enabled = false;
                this.copyToolStripButton.Enabled = false;
                if (this.WindowState != FormWindowState.Minimized)
                    this.pasteToolStripButton.Enabled = false;
                this.undoToolStripButton.Enabled = false;
                this.redoToolStripButton.Enabled = false;
                this.deleteToolStripButton.Enabled = false;
            }
        }

        #region MenuTools

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.SaveChanges)
            {
                DialogResult res = MessageBoxAdv.Show(this, "The diagram or its association has been modified. Save changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.saveFileDialog1.FileName = "Diagram";
                    saveFileDialog1.Filter = @"EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
                    saveFileDialog1.Title = "Save File As:";

                    if (this.HasFileName)
                    {
                        this.saveFileDialog1.FileName = this.fileName;
                    }
                    if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                    {
                        this.fileName = this.saveFileDialog1.FileName;
                        SaveDiagramAs(saveFileDialog1.FileName, saveFileDialog1.FilterIndex);
                        diagram1.Model.Clear();
                        Model model = new Model();
                        model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        model.LineStyle.LineColor = Color.LightGray;
                        diagram1.Model = model;
                    }
                }
                else if (res == DialogResult.No)
                {
                    diagram1.Model.Clear();
                    Model model = new Model();
                    model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    model.LineStyle.LineColor = Color.LightGray;
                    diagram1.Model = model;
                }
            }
            else
            {
                diagram1.Model.Clear();
                Model model = new Model();
                model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                model.LineStyle.LineColor = Color.LightGray;
                diagram1.Model = model;
            }
            this.fileName = "";
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.SaveChanges)
            {
                DialogResult res = MessageBoxAdv.Show(this, "The diagram or its association has been modified. Save changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.saveFileDialog1.FileName = "Diagram";
                    saveFileDialog1.Filter = @"EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
                    saveFileDialog1.Title = "Save File As:";

                    if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                    {
                        this.fileName = this.saveFileDialog1.FileName;
                        SaveDiagramAs(saveFileDialog1.FileName, saveFileDialog1.FilterIndex);
                    }

                    this.openFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
                    this.openFileDialog1.Title = "Open Diagram";
                    this.openFileDialog1.FileName = "";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(openFileDialog1.FileName))
                        {
                            OpenDiagramAs(openFileDialog1.FileName, openFileDialog1.FilterIndex);
                        }
                    }
                }
                else if (res == DialogResult.No)
                {
                    this.openFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
                    this.openFileDialog1.Title = "Open Diagram";
                    this.openFileDialog1.FileName = "";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(openFileDialog1.FileName))
                        {
                            OpenDiagramAs(openFileDialog1.FileName, openFileDialog1.FilterIndex);
                        }
                    }
                }
            }
            else
            {
                this.openFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
                this.openFileDialog1.Title = "Open Diagram";
                this.openFileDialog1.FileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(openFileDialog1.FileName))
                    {
                        OpenDiagramAs(openFileDialog1.FileName, openFileDialog1.FilterIndex);
                    }
                }
            }
            this.fileName = openFileDialog1.FileName;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName) || !File.Exists(fileName))
            {
                saveFileDialog1.Filter = @"EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            diagram1.SaveBinary(saveFileDialog1.FileName);
                            break;
                        case 2:
                            diagram1.SaveSoap(saveFileDialog1.FileName);
                            break;
                    }
                    this.fileName = saveFileDialog1.FileName;
                }
            }
            else
            {
                FileInfo fi = new FileInfo(fileName);
                if (fi.Extension == ".edd")
                {
                    diagram1.SaveBinary(fi.FullName);
                }
                else if (fi.Extension == ".xml")
                {
                    diagram1.SaveSoap(fi.FullName);
                }
            }
        }

        private void undoToolStripButton_Click(object sender, EventArgs e)
        {
            this.diagram1.Model.HistoryManager.Undo();
        }

        private void redoToolStripButton_Click(object sender, EventArgs e)
        {
            this.diagram1.Model.HistoryManager.Redo();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.Controller.Cut();
            this.pasteToolStripButton.Enabled = true;
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.Controller.Copy();
            this.pasteToolStripButton.Enabled = true;
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.Controller.Paste();
            this.pasteToolStripButton.Enabled = false;
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.Model.BeginUpdate();
            diagram1.Controller.Delete();
            diagram1.Model.EndUpdate();

        }

        private void zoomInToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.View.ZoomIn();
        }

        private void zoomOutToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.View.ZoomOut();
        }

        private void showGridToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.diagram1.View.Grid.Visible)
                this.diagram1.View.Grid.Visible = false;
            else
                this.diagram1.View.Grid.Visible = true;
        }

        private void snapToGridToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (diagram1.View.Grid.SnapToGrid)
                diagram1.View.Grid.SnapToGrid = false;
            else
                diagram1.View.Grid.SnapToGrid = true;
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            string targetURL = @"http://help.syncfusion.com/";
            System.Diagnostics.Process.Start(targetURL);
        }

        private void resetToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.View.ZoomToActual();
        }

        private void saveAsToolStripButton_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = "Diagram";
            saveFileDialog1.Filter = @"EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
            saveFileDialog1.Title = "Save File As:";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        diagram1.SaveBinary(saveFileDialog1.FileName);
                        break;
                    case 2:
                        diagram1.SaveSoap(saveFileDialog1.FileName);
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

        private void rulerToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.diagram1.ShowRulers)
                this.diagram1.ShowRulers = false;
            else
                this.diagram1.ShowRulers = true;
        }

        private void lineConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool("LineLinkTool");
        }

        private void directedLineConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool("DirectedLineLinkTool");
        }

        private void orthogonalConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool("OrthogonalLinkTool");
        }

        private void polylineConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool("PolylineLinkTool");
        }

        private void bezierConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool("BezierTool");
        }

        private void splineConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool("SplineTool");
        }

        #endregion

        #endregion    

        #region Helper Methods
        /// <summary>
        /// Save diagram as Image
        /// </summary>
        /// <param name="filename">Filename </param>
        /// <param name="imageformat">image format</param>//Save diagram as Image
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
                    diagram1.SaveSoap(filename);
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
                    diagram1.LoadBinary(filename);
                    break;
                case 2:
                    diagram1.LoadSoap(filename);
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
               
    }
}