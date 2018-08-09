using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace TreeViewAdvSearchDemo
{
    public partial class TreeViewAdvSearchDemo : MetroForm
    {
        TreeViewSearchForm f;
        public TreeViewAdvSearchDemo()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Padding = new System.Windows.Forms.Padding(10);
            this.MinimumSize = this.Size;
            this.treeViewAdv1.SelectionMode = Syncfusion.Windows.Forms.Tools.TreeSelectionMode.MultiSelectAll;
            f = new TreeViewSearchForm(this.treeViewAdv1);
            this.treeViewAdv1.PreviewKeyDown += new PreviewKeyDownEventHandler(treeViewAdv1_PreviewKeyDown);
            this.treeViewAdv1.HideSelection = false;
            this.richTextBox1.AppendText("\n");
            this.treeViewAdv1.OnNodeAfterFound += new Syncfusion.Windows.Forms.Tools.TreeViewOnAfterFindArgs(treeViewAdv1_OnNodeAfterFound);
            this.treeViewAdv1.OnNodeBeforeFind += new Syncfusion.Windows.Forms.Tools.TreeViewOnBeforeFindArgs(treeViewAdv1_OnNodeBeforeFind);
            this.treeViewAdv1.OnNodeReplacing += new Syncfusion.Windows.Forms.Tools.TreeViewOnReplacingArgs(treeViewAdv1_OnNodeReplacing);
            this.treeViewAdv1.OnNodeReplaced += new Syncfusion.Windows.Forms.Tools.TreeViewOnReplacedArgs(treeViewAdv1_OnNodeReplaced);
        }

        
        void treeViewAdv1_OnNodeAfterFound(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvAfterFindArgs e)
        {
            this.richTextBox1.AppendText("\n AfterNodeMatchFound Event Triggered");
        }

        void treeViewAdv1_OnNodeReplaced(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvOnReplacedArgs e)
        {
            this.richTextBox1.AppendText("\n OnNodeTextReplaced Event Triggered");
        }

        void treeViewAdv1_OnNodeReplacing(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvOnReplacingArgs e)
        {
            this.richTextBox1.AppendText("\n OnNodeTextReplacing Event Triggered");
        }

        void treeViewAdv1_OnNodeBeforeFind(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvBeforeFindArgs e)
        {
            this.richTextBox1.AppendText("\n BeforeNodeMatchFound Event Triggered");
        }

        void treeViewAdv1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyValue == (Char)Keys.F)
            {
                f = new TreeViewSearchForm(this.treeViewAdv1);
                f.ShowDialog();
            }
        }

        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }
    }
}
