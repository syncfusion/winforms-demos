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
using Syncfusion.Windows.Forms;

namespace Grid
{
    public partial class Form1 : Form
    {
        #region Form Initialize
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {                      
            DiagramAppearance();
            propertyEditor1.PropertyGrid.SelectedObject = this.diagram1.View.Grid;
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Changes the appearance of the Diagram
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.HorizontalRuler.BackgroundColor = Color.White;
            this.diagram1.VerticalRuler.BackgroundColor = Color.White;
            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.LightGray;
            this.diagram1.View.Grid.VerticalSpacing = (int)DpiAware.LogicalToDeviceUnits(15);
            this.diagram1.View.Grid.HorizontalSpacing = (int)DpiAware.LogicalToDeviceUnits(15);
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.View.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.View.SelectionList.Clear();
        }
        #endregion
    }
}
