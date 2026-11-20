#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NestedDocking
{
    public partial class ControlLogs : UserControl
    {
        public ControlLogs()
        {
            InitializeComponent();
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.VS2010;
            this.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2010;
            this.dockingManager1.NewDockStateEndLoad += dockingManager1_NewDockStateEndLoad;
            this.treeNavigator1.ParentPanel.AutoScroll = false;
            this.treeNavigator2.ParentPanel.AutoScroll = false;
            this.treeNavigator3.ParentPanel.AutoScroll = false;
            this.dockingManager1.DockTabBackColor = ColorTranslator.FromHtml("#4d6082");
            this.dockingManager1.DockTabSeparatorColor = ColorTranslator.FromHtml("#4d6082");
            this.dockingManager1.ActiveCaptionBackground = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#fff29d"));
        }

        void dockingManager1_NewDockStateEndLoad(object sender, EventArgs e)
        {
            this.dockingManager1.SetDockLabel(this.panel1, "Venenatis");
            this.dockingManager1.SetDockLabel(this.panel2, "Consequat");
            this.dockingManager1.SetDockLabel(this.panel3, "Felis");
            this.dockingManager1.SetDockLabel(this.panel4, "Morbi");
        }
    }
}
