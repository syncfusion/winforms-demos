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
using Syncfusion.Windows.Forms;

namespace Ports
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
#if !NETCORE
            this.diagram1.LoadXml(@"..\..\..\..\..\..\common\Data\Diagram\xml\PortsAhoy.xml");
#else
            this.diagram1.LoadXml(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\PortsAhoy.xml");
#endif
        }
#endregion

        private void btnConnectionPointTool_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnConnectionPointTool, "Add or delete connection points on shapes.\n Hold CTRL key and click on a connection point will delete the connection point.");

        }

        private void btnConnectionPointTool_Click(object sender, EventArgs e)
        {
            diagram1.Controller.ActivateTool("ConnectionPointTool");
        }

    }
}