#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram.DataBinding;
using System.Windows.Forms;

namespace DiagramORM.Sample
{
    public partial class Form1 : Form
    {
        #region Self Relation declaration

        DiagramDataBindingManager dEngineSelfRelation;
        BindingList<EmployeeClass> employeeList;
        int empCount = 0;

        #endregion

        DiagramDataBindingManager dEngineParentChild;
        BindingList<ParentChildClass> familyList1;
        BindingList<ParentChildClass> familyList2;

        public Form1()
        {
            InitializeComponent();

            #region Self Relation Init

            dEngineSelfRelation = new DiagramDataBindingManager(this.diagram1);
            dEngineSelfRelation.ListenToRelationChanges = true;
            //List of data objects
            employeeList = new BindingList<EmployeeClass>();
            employeeList.Add(new EmployeeClass(empCount++, -1, "Mark"));
            employeeList.Add(new EmployeeClass(empCount++, 0, "Spencer"));
            employeeList.Add(new EmployeeClass(empCount++, 0, "Carlos"));
            employeeList.Add(new EmployeeClass(empCount++, 1, "Elliot"));
            employeeList.Add(new EmployeeClass(empCount++, 1, "Benson"));
            employeeList.Add(new EmployeeClass(empCount++, 2, "Margaret"));
            employeeList.Add(new EmployeeClass(empCount++, 1, "Rodriguez"));
            employeeList.Add(new EmployeeClass(empCount++, 2, "Samuel"));
            employeeList.Add(new EmployeeClass(empCount++, 4, "Micheal"));
            employeeList.Add(new EmployeeClass(empCount++, 7, "Whitaker"));

            this.comboBox1.DataSource = employeeList;
            this.comboBox1.DisplayMember = "EmployeeName";
            this.comboBox1.ValueMember = "Id";

            OrgChartLayoutManager ltManager = new OrgChartLayoutManager(this.diagram1.Model, RotateDirection.TopToBottom, 40, 50);
            ltManager.LeftMargin = 10;
            ltManager.TopMargin = -20;
            this.diagram1.LayoutManager = ltManager;

            dEngineSelfRelation.NodeAdded += new NodeAddedEventHandler(dEngineSelfRelation_NodeAdded);

            //Adding the list collection to SourceListSet
            dEngineSelfRelation.SourceListSet.Add(new SourceListSetEntry("EmployeeList", employeeList));

            dEngineSelfRelation.ProvideNodeConnectorInfo += new NodeConnectEventHandler(dEngineSelfRelation_ProvideNodeConnectorInfo);
            //Adding a self relation
            dEngineSelfRelation.Relations.Add(new NodeRelationDescriptor("Manager_Employee", "EmployeeList", "Id", "EmployeeList", "ManagerId", RelationType.SelfRelation));

            #endregion

            #region ParentChild Init

            this.diagram2.LayoutManager = new OrgChartLayoutManager(this.diagram2.Model, RotateDirection.TopToBottom, 40, 40);

            dEngineParentChild = new DiagramDataBindingManager(this.diagram2);
            //dEngineParentChild.NodeRelationDescriptor.ListenToRelationChanges = true;
            dEngineParentChild.NodeAdded += new NodeAddedEventHandler(dEngineParentChild_NodeAdded);
            dEngineParentChild.ProvideNodeConnectorInfo += new NodeConnectEventHandler(dEngineParentChild_ProvideNodeConnectorInfo);
            InitFamilies();

            //Adding self-relation to MatthewFamily
            dEngineParentChild.Relations.Add(new NodeRelationDescriptor("Matthew_Family", "MatthewFamily", "Id", "MatthewFamily", "ParentId", RelationType.SelfRelation));

            //Adding self-relation to JohnsonFamily
            dEngineParentChild.Relations.Add(new NodeRelationDescriptor("Johnson_Family", "JohnsonFamily", "Id", "JohnsonFamily", "ParentId", RelationType.SelfRelation));

            //Adding parentchild / masterdetail relation between both the families
            dEngineParentChild.Relations.Add(new NodeRelationDescriptor("Matthew_Johnson", "JohnsonFamily", "Id", "MatthewFamily", "Id", RelationType.ParentChild));

            #endregion

            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.LightGray;
            this.diagram1.View.Grid.VerticalSpacing = 15;
            this.diagram1.View.Grid.HorizontalSpacing = 15;
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.Model.BackgroundStyle.ForeColor = Color.Pink;
            this.diagram1.Model.BackgroundStyle.Color = Color.White;
            this.diagram1.View.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.View.BackgroundColor = Color.White;
            this.diagram1.Model.DocumentSize = new PageSize(800, 600);
            this.diagram1.View.Grid.Visible = false;
            this.diagram2.Model.DocumentSize = new PageSize(900, 600);

            this.diagram2.View.Grid.GridStyle = GridStyle.Line;
            this.diagram2.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram2.View.Grid.Color = Color.LightGray;
            this.diagram2.View.Grid.VerticalSpacing = 15;
            this.diagram2.View.Grid.HorizontalSpacing = 15;
            
            this.diagram2.View.HandleColor = Color.AliceBlue;
            this.diagram2.View.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.View.SelectionList.Clear();
            this.diagram2.View.SelectionList.Clear();
            this.diagram2.View.Grid.Visible = false;
            this.diagram1.View.BackgroundColor = Color.White;
            
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram2.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;

            diagram1.Model.LineStyle.LineWidth = 0;
            diagram2.Model.LineStyle.LineWidth = 0;
            ltManager.UpdateLayout(this);
        }

        #region SelfRelation Events and Methods

        ConnectorBase dEngineSelfRelation_ProvideNodeConnectorInfo(NodeConnectEventArgs args)
        {
            OrgLineConnector connector = null;
            if (args.ParentNode != null && args.ChildNode != null)
            {
                connector = new OrgLineConnector(PointF.Empty, new PointF(0, 1));
                connector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
                connector.HeadDecorator.LineStyle.LineColor = Color.Gray;
                connector.HeadDecorator.FillStyle.Color = Color.LightGray;
                connector.LineStyle.LineColor = Color.Gray;
                connector.LineStyle.LineWidth = 1;
                connector.HeadDecorator.Size = new SizeF(8, 8);
                //Connect the nodes
                args.ParentNode.CentralPort.TryConnect(connector.TailEndPoint);
                args.ChildNode.CentralPort.TryConnect(connector.HeadEndPoint);
            }
            return connector;
        }

        void dEngineSelfRelation_NodeAdded(object sender, NodeAddedEventArgs args)
        {
            if (args.NodeObject is Syncfusion.Windows.Forms.Diagram.Rectangle)
            {
                Syncfusion.Windows.Forms.Diagram.Rectangle rect = args.NodeObject as Syncfusion.Windows.Forms.Diagram.Rectangle;
                rect.FillStyle.Color = Color.FromArgb(242,242,242);
                rect.FillStyle.ForeColor = Color.White;
                rect.LineStyle.LineColor = Color.Black;
                rect.FillStyle.Type = FillStyleType.LinearGradient;
                rect.FillStyle.GradientAngle = 90;
                rect.FillStyle.GradientCenter = 1;
                rect.EnableShading = false;
                rect.LineStyle.DashCap = System.Drawing.Drawing2D.DashCap.Round;
                rect.Labels[0].FontStyle.Bold = true;
                rect.Labels[0].FontStyle.Family = "Segoe UI";
                rect.Labels[0].FontColorStyle.Color = Color.Black;
            }
        }

        /// <summary>
        /// Adding new Employee items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employee_Add(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                employeeList.Add(new EmployeeClass(empCount++, Convert.ToInt32(this.comboBox1.SelectedValue), this.textBox1.Text));

                OrgChartLayoutManager ltManager = new OrgChartLayoutManager(this.diagram1.Model, RotateDirection.TopToBottom, 40, 40);
                this.diagram1.LayoutManager = ltManager;
                ltManager.UpdateLayout(this);
            }
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Removing an item from the list should explicitly call the RemoveNode to remove its node instance from the SourceListSetCollection and refreshing the Diagram control appropriately. It will also remove the node relation that is associated with the node instance.
            if (this.comboBox1.SelectedValue != null)
            {
                object empObj = GetEmployeeItemFromList((int)this.comboBox1.SelectedValue);
                if (empObj != null)
                {
                    this.dEngineSelfRelation.SourceListSet.RemoveNode(this.dEngineSelfRelation.SourceListSet[0], empObj);
                    this.dEngineSelfRelation.Diagram.Refresh();
                    this.employeeList.Remove((EmployeeClass)empObj);
                }
            }
            OrgChartLayoutManager ltManager = new OrgChartLayoutManager(this.diagram1.Model, RotateDirection.TopToBottom, 40, 40);
            this.diagram1.LayoutManager = ltManager;
            ltManager.UpdateLayout(this);
        }

        private object GetEmployeeItemFromList(int id)
        {
            foreach (EmployeeClass empItem in this.employeeList)
            {
                if (empItem.Id == id)
                {
                    return empItem as object;
                }
            }
            return null;
        }
        #endregion


        #region ParentChild Events and Methods

        ConnectorBase dEngineParentChild_ProvideNodeConnectorInfo(NodeConnectEventArgs args)
        {
            ConnectorBase connector = null;
            if (args.NodeRelation.RelationName == "Matthew_Family")
            {
                if (args.ParentNode != null && args.ChildNode != null)
                {
                    connector = new OrgLineConnector(PointF.Empty, new PointF(0, 1));
                    connector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
                    connector.HeadDecorator.FillStyle.Color = Color.LightGray;
                    connector.LineStyle.LineColor = Color.Gray;
                    connector.LineStyle.LineWidth = 1;

                    //Connect the nodes
                    args.ParentNode.CentralPort.TryConnect(connector.TailEndPoint);
                    args.ChildNode.CentralPort.TryConnect(connector.HeadEndPoint);
                }
            }
            else if (args.NodeRelation.RelationName == "Johnson_Family")
            {
                if (args.ParentNode != null && args.ChildNode != null)
                {
                    connector = new OrgLineConnector(PointF.Empty, new PointF(0, 1));
                    connector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
                    connector.HeadDecorator.FillStyle.Color = Color.Black;
                    connector.HeadDecorator.LineStyle.LineColor = Color.Black;
                    connector.LineStyle.LineColor = Color.Black;
                    connector.LineStyle.LineWidth = 1;

                    //Connect the nodes
                    args.ParentNode.CentralPort.TryConnect(connector.TailEndPoint);
                    args.ChildNode.CentralPort.TryConnect(connector.HeadEndPoint);
                }
            }
            else if (args.NodeRelation.RelationName == "Matthew_Johnson")
            {
                if (args.ParentNode != null && args.ChildNode != null)
                {
                    connector = new OrgLineConnector(PointF.Empty, new PointF(0, 1));
                    connector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
                    connector.HeadDecorator.FillStyle.Color = Color.LightGreen;
                    connector.HeadDecorator.LineStyle.LineColor = Color.LightGreen;
                    connector.LineStyle.LineColor = Color.LightGreen;
                    connector.LineStyle.LineWidth = 1;

                    //Connect the nodes
                    args.ParentNode.CentralPort.TryConnect(connector.TailEndPoint);
                    args.ChildNode.CentralPort.TryConnect(connector.HeadEndPoint);
                }
            }
            return connector;
        }

        void dEngineParentChild_NodeAdded(object sender, NodeAddedEventArgs args)
        {
            if (args.SourceName == "MatthewFamily")
            {
                Syncfusion.Windows.Forms.Diagram.Rectangle rectNode = args.NodeObject as Syncfusion.Windows.Forms.Diagram.Rectangle;
                rectNode.Labels[0].FontStyle.Family = "Segoe UI";
                rectNode.Labels[0].FontStyle.Bold = true;
                rectNode.FillStyle.Color = Color.White;
                rectNode.FillStyle.Color = Color.LightSlateGray;
                rectNode.FillStyle.Type = Syncfusion.Windows.Forms.Diagram.FillStyleType.LinearGradient;
                rectNode.EnableShading = false;
                
                rectNode.ShadowStyle.Visible = true;
                rectNode.ShadowStyle.OffsetX = 0;
                rectNode.ShadowStyle.OffsetY = 6;

            }
            else if (args.SourceName == "JohnsonFamily")
            {
                Syncfusion.Windows.Forms.Diagram.Rectangle rectNode = args.NodeObject as Syncfusion.Windows.Forms.Diagram.Rectangle;
                rectNode.Labels[0].FontStyle.Family = "Segoe UI";
                rectNode.Labels[0].FontStyle.Bold = true;
                rectNode.Labels[0].FontStyle.Italic = true;
                rectNode.FillStyle.Color = Color.Bisque;
                rectNode.EnableShading = false;
                rectNode.FillStyle.ForeColor = Color.White;
                rectNode.FillStyle.Type = Syncfusion.Windows.Forms.Diagram.FillStyleType.LinearGradient;
                rectNode.FillStyle.GradientCenter = 0.5f;
                rectNode.ShadowStyle.Visible = true;
                rectNode.ShadowStyle.OffsetX = 0;
                rectNode.ShadowStyle.OffsetY = 6;
            }
        }

        private void InitFamilies()
        {
            familyList1 = new BindingList<ParentChildClass>();
            familyList1.Add(new ParentChildClass(0, -1, "Matthew"));
            familyList1.Add(new ParentChildClass(1, 0, "Carl"));
            familyList1.Add(new ParentChildClass(2, 0, "Martha"));
            familyList1.Add(new ParentChildClass(3, 1, "Stephanie"));
            familyList1.Add(new ParentChildClass(4, 2, "Eddie"));
            familyList1.Add(new ParentChildClass(5, 2, "Richard"));
            dEngineParentChild.SourceListSet.Add(new SourceListSetEntry("MatthewFamily", familyList1));

            familyList2 = new BindingList<ParentChildClass>();
            familyList2.Add(new ParentChildClass(0, -1, "Johnson"));
            familyList2.Add(new ParentChildClass(1, 0, "Micheal"));
            familyList2.Add(new ParentChildClass(2, 0, "Julie"));
            familyList2.Add(new ParentChildClass(3, 0, "Robert"));
            familyList2.Add(new ParentChildClass(4, 1, "Bruce"));
            dEngineParentChild.SourceListSet.Add(new SourceListSetEntry("JohnsonFamily", familyList2));

        }

        #endregion

    }


}