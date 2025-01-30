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

namespace ZoomAndPan
{
    public partial class Form1 : Form
    {
        #region Members        
        public string fileName;
       
        #endregion

        #region Form Initialize
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diagram1.BeginUpdate();
#if !NETCORE
            this.diagram1.LoadXml(@"..\..\..\..\..\..\common\Data\Diagram\xml\ProcessFlowChart.xml");
#else
            this.diagram1.LoadXml(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\ProcessFlowChart.xml");
#endif
            DiagramAppearance();
            diagram1.EndUpdate();          
            
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
            this.diagram1.Model.LineStyle.LineColor = Color.LightGray;           
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.Model.DocumentSize = new PageSize(this.diagram1.View.ClientRectangle.Size.Width, diagram1.View.ClientRectangle.Size.Height);
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.Model.MinimumSize = diagram1.View.ClientRectangle.Size;
            this.diagram1.Model.SizeToContent = true;
            this.diagram1.View.BackgroundColor = Color.White;
            this.diagram1.View.SelectionList.Clear();
        }

#endregion

#region Event Handlers


        void Application_Idle(object sender, EventArgs e)
        {
            if (this.diagram1 != null && this.diagram1.Model != null)
            {
                this.zoomInToolStrip.Enabled = true;
                this.zoomOutToolStripButton.Enabled = true;              

            }
            else
            {
                this.zoomInToolStrip.Enabled = false;
                this.zoomOutToolStripButton.Enabled = false;
              
            }
        }

        private void zoomInToolStrip_Click(object sender, EventArgs e)
        {
            diagram1.View.ZoomIn();
        }

        private void zoomOutToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.View.ZoomOut();
        }

        private void resetToolStripButton_Click_1(object sender, EventArgs e)
        {
            diagram1.View.ZoomToActual();
            diagram1.View.Origin = new PointF(0, 0);
            diagram1.Controller.ActivateTool("SelectTool");
        }

        private void panToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.Controller.ActivateTool("PanTool");
        }         

        private void helpToolStripButton_Click_1(object sender, EventArgs e)
        {
            string targetURL = @"http://help.syncfusion.com/";
            System.Diagnostics.Process.Start(targetURL);
        }             
       
#endregion
             
    }
}
