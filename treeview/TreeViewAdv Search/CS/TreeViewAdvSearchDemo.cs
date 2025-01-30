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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace TreeViewAdvSearchDemo
{
    public partial class TreeViewAdvSearchDemo : SfForm
    {
        TreeViewSearchForm f;
        public TreeViewAdvSearchDemo()
        {
            InitializeComponent();
            this.treeViewAdv1.CanOverrideStyle = false;
            this.treeViewAdv1.ThemeStyle.TreeNodeAdvStyle.Font= new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewAdv1.ThemeName = "Office2019Colorful";
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Padding = new System.Windows.Forms.Padding(10,0,10,10);
            this.MinimumSize = this.Size;
            this.treeViewAdv1.SelectionMode = Syncfusion.Windows.Forms.Tools.TreeSelectionMode.MultiSelectAll;
            f = new TreeViewSearchForm(this.treeViewAdv1);
            this.treeViewAdv1.PreviewKeyDown += new PreviewKeyDownEventHandler(treeViewAdv1_PreviewKeyDown);
            this.treeViewAdv1.HideSelection = false;
            this.treeViewAdv1.OnNodeAfterFound += new Syncfusion.Windows.Forms.Tools.TreeViewOnAfterFindArgs(treeViewAdv1_OnNodeAfterFound);
            this.treeViewAdv1.OnNodeBeforeFind += new Syncfusion.Windows.Forms.Tools.TreeViewOnBeforeFindArgs(treeViewAdv1_OnNodeBeforeFind);
            this.treeViewAdv1.OnNodeReplacing += new Syncfusion.Windows.Forms.Tools.TreeViewOnReplacingArgs(treeViewAdv1_OnNodeReplacing);
            this.treeViewAdv1.OnNodeReplaced += new Syncfusion.Windows.Forms.Tools.TreeViewOnReplacedArgs(treeViewAdv1_OnNodeReplaced);
        }

        
        void treeViewAdv1_OnNodeAfterFound(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvAfterFindArgs e)
        {
            this.richTextBox1.AppendText("AfterNodeMatchFound event is triggered.\n");
        }

        void treeViewAdv1_OnNodeReplaced(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvOnReplacedArgs e)
        {
            this.richTextBox1.AppendText("OnNodeTextReplaced event is triggered.\n");
        }

        void treeViewAdv1_OnNodeReplacing(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvOnReplacingArgs e)
        {
            this.richTextBox1.AppendText("OnNodeTextReplacing event is triggered.\n");
        }

        void treeViewAdv1_OnNodeBeforeFind(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvBeforeFindArgs e)
        {
            this.richTextBox1.AppendText("BeforeNodeMatchFound event is triggered.\n");
        }

        void treeViewAdv1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyValue == (Char)Keys.F)
            {
                f = new TreeViewSearchForm(this.treeViewAdv1);
                f.ShowDialog();
            }
        }
    }
}
