#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Diagram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DataSourceBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Syncfusion.Windows.Forms.Diagram.Rectangle rect= new Syncfusion.Windows.Forms.Diagram.Rectangle(10, 10, 100, 50);
            Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label();
            label.FontColorStyle.Color = Color.White;
            label.FontStyle.Family = "Segoe UI";
            rect.Labels.Add(label);
            rect.FillStyle.Color = System.Drawing.Color.FromArgb(116,160,47);
#if !NETCORE
            DataTable table = diagram1.GetDataSourceFromXML(@"..\..\..\..\..\..\common\Data\Diagram\xml\XML Binding1.xml");
#else
            DataTable table = diagram1.GetDataSourceFromXML(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\XML Binding1.xml");
#endif
            this.diagram1.Binding.DefaultNode = rect;
            this.diagram1.Binding.Label.Add("Name");
            this.diagram1.Binding.ParentId = "ManagerID";
            this.diagram1.Binding.Id = "EmployeeID";
            this.diagram1.Binding.DataSource = table;
        }
        private void Initialize()
        {
            this.model1.LineStyle.LineColor = System.Drawing.Color.Transparent;
            this.diagram1.View.Grid.Color = System.Drawing.Color.White;
            this.diagram1.Model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.diagram1.View.BackgroundColor = Color.White;
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            Syncfusion.Windows.Forms.Diagram.HierarchicLayoutManager hlayout = new Syncfusion.Windows.Forms.Diagram.HierarchicLayoutManager();
            hlayout.AutoLayout = true;
            hlayout.VerticalSpacing = 40;
            hlayout.HorizontalSpacing = 20;
            hlayout.LeftMargin = 50;
            hlayout.TopMargin = 50;
            this.diagram1.LayoutManager = hlayout;
        }
    }
}
