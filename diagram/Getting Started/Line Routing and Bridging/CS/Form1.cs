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

namespace LineRouting
{
    public partial class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        #region Form Initialize
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
#if !NETCORE
            this.diagram1.LoadXml(@"..\..\..\..\..\..\common\Data\Diagram\xml\New Enhanced Line Routing.xml");
#else
            this.diagram1.LoadXml(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\New Enhanced Line Routing.xml");
#endif
            DiagramAppearance();

            comboLineBridge.SelectedIndex = 0;
            chkLineBridge.Checked = diagram1.Model.LineBridgingEnabled;
            txtLineBridgeSize.Text = diagram1.Model.LineBridgeSize.ToString();

            comboLineRouting.SelectedIndex = 1;
            chkLineRouting.Checked = diagram1.Model.LineRoutingEnabled;
            txtDistanceObstcl.Text = diagram1.Model.LineRouter.DistanceToObstacles.ToString();

        }
#endregion

#region Private Methods
        /// <summary>
        /// Change's the appearance of Diagram
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
            this.diagram1.View.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.Model.DocumentSize = new PageSize(this.diagram1.View.ClientRectangle.Size.Width + 50, diagram1.View.ClientRectangle.Size.Height +50);
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.Model.MinimumSize = diagram1.View.ClientRectangle.Size;
            this.diagram1.Model.SizeToContent = true;
            this.diagram1.View.SelectionList.Clear();
        }

#endregion

#region Evant handlers
        private void apply_Click(object sender, EventArgs e)
        {
            switch (comboLineBridge.SelectedIndex)
            {
                case 0:
                    diagram1.Model.BridgeStyle = BridgeStyle.Arc;
                    break;
                case 1:
                    diagram1.Model.BridgeStyle = BridgeStyle.Gap;
                    break;
                case 2:
                    diagram1.Model.BridgeStyle = BridgeStyle.Square;
                    break;
                case 3:
                    diagram1.Model.BridgeStyle = BridgeStyle.Sides2;
                    break;
                case 4:
                    diagram1.Model.BridgeStyle = BridgeStyle.Sides3;
                    break;
                case 5:
                    diagram1.Model.BridgeStyle = BridgeStyle.Sides4;
                    break;
                case 6:
                    diagram1.Model.BridgeStyle = BridgeStyle.Sides5;
                    break;
                case 7:
                    diagram1.Model.BridgeStyle = BridgeStyle.Sides6;
                    break;
                case 8:
                    diagram1.Model.BridgeStyle = BridgeStyle.Sides7;
                    break;

            }
            diagram1.Model.LineBridgingEnabled = chkLineBridge.Checked;
            try
            {
                diagram1.Model.LineBridgeSize = float.Parse(txtLineBridgeSize.Text);
            }
            catch
            {
                txtLineBridgeSize.Text = diagram1.Model.LineBridgeSize.ToString();
            }
            switch (comboLineRouting.SelectedIndex)
            {
                case 0:
                    diagram1.Model.LineRouter.RoutingMode = RoutingMode.Inactive;
                    break;
                case 1:
                    diagram1.Model.LineRouter.RoutingMode = RoutingMode.Automatic;
                    break;
                case 2:
                    diagram1.Model.LineRouter.RoutingMode = RoutingMode.SemiAutomatic;
                    break;

            }
            diagram1.Model.LineRoutingEnabled = chkLineRouting.Checked;
            try
            {
                diagram1.Model.LineRouter.DistanceToObstacles = int.Parse(txtDistanceObstcl.Text);
            }
            catch
            {
                txtDistanceObstcl.Text = diagram1.Model.LineRouter.DistanceToObstacles.ToString();
            }
        }
#endregion
    }
}