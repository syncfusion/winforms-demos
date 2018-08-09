using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Design;
using Syncfusion.Collections;
using Syncfusion.ComponentModel;
using System.Drawing.Design;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Reflection;
using Syncfusion.Runtime.Serialization;

using Syncfusion.Windows.Forms.Grid;

using Syncfusion.Windows.Forms.Tools;

namespace TabBarSplitterDemo
{
    public partial class Form1 : RibbonForm
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            this.tabBarSplitterControl1.ThemesEnabled = true;
            this.tabBarSplitterControl1.ScrollBehavior = InternalTabBarScrollBehavior.ScrollPixels;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
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
        #endregion

        #region Helper Methods
        void QuickItems()
        {
            ToolStripButton saveBtn = new ToolStripButton("Save");
            saveBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveBtn.Image = this.imageList1.Images[0];
            ribbonControlAdv1.Header.AddQuickItem(saveBtn);
            
            ToolStripButton undoBtn = new ToolStripButton("Undo");
            undoBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            undoBtn.Image  = this.imageList1.Images[1];
            ribbonControlAdv1.Header.AddQuickItem(undoBtn);

            ToolStripButton redoBtn = new ToolStripButton("Redo");
            redoBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            redoBtn.Image = this.imageList1.Images[2];
            redoBtn.Enabled = false;
            ribbonControlAdv1.Header.AddQuickItem(redoBtn);
        }

        GridControl CreateGridControl()
        {
            GridControl gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            
            gridControl1.ColCount = 20;
            gridControl1.RowCount = 100;

            return gridControl1;
        }
        GridControl grid;
        void AddTabBarPage()
        {
            TabBarPage page = new TabBarPage("Sheet" + (this.tabBarSplitterControl1.TabBarPages.Count + 1));
            grid = CreateGridControl();
            page.Controls.Add(grid);

            grid.ThemesEnabled = true;
            grid.GridVisualStyles = GridVisualStyles.Metro;

            this.tabBarSplitterControl1.TabBarPages.Add(page);
        }

        #endregion

        #region Event Handlers
        
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            QuickItems();

            for (int i = 0; i < 3;i++)
                AddTabBarPage();
        }

        private void toolStripCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.tabBarSplitterControl1.ShowHorizontalScrollBar = !this.toolStripCheckBox1.Checked;
        }

        private void toolStripCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.tabBarSplitterControl1.ShowVerticalScrollBar = !this.toolStripCheckBox2.Checked;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            AddTabBarPage();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            if (this.tabBarSplitterControl1.TabBarPages.Count > 1)
                this.tabBarSplitterControl1.HidePage(this.tabBarSplitterControl1.ActivePage);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (this.tabBarSplitterControl1.TabBarPages.Count > 1)
                this.tabBarSplitterControl1.TabBarPages.Remove(this.tabBarSplitterControl1.ActivePage);
            else
                MessageBoxAdv.Show("One sheet alone exists! No more sheets to remove!", "Warning!");
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.toolStripCheckBox3.Checked)
            {
            switch (this.toolStripComboBox1.SelectedIndex)
                {
                    case 0:
                        this.tabBarSplitterControl1.Office2007ColorScheme = Office2007Theme.Blue;
                        this.tabBarSplitterControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                        ApplyThemetoGrid("Blue");
                        break;
                    case 1:
                        this.tabBarSplitterControl1.Office2007ColorScheme = Office2007Theme.Black;
                        this.tabBarSplitterControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                        ApplyThemetoGrid("Black");
                        break;
                    case 2:
                        this.tabBarSplitterControl1.Office2007ColorScheme = Office2007Theme.Silver;
                        this.tabBarSplitterControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                        ApplyThemetoGrid("Silver");
                        break;
                }
            }

        }
        #endregion
        private void toolStripCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            toolStripComboBox1.Visible = toolStripCheckBox3.Checked;
            if (toolStripCheckBox3.Checked)
            {
                if (toolStripComboBox1.Text == "Blue")
                {
                    this.tabBarSplitterControl1.Style = TabBarSplitterStyle.Office2007;
                    this.tabBarSplitterControl1.Office2007ColorScheme = Office2007Theme.Blue;
                    this.tabBarSplitterControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                    ApplyThemetoGrid("Blue");
                }
                else if (toolStripComboBox1.Text == "Black")
                {
                    this.tabBarSplitterControl1.Style = TabBarSplitterStyle.Office2007;
                    this.tabBarSplitterControl1.Office2007ColorScheme = Office2007Theme.Black;
                    this.tabBarSplitterControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                    ApplyThemetoGrid("Black");
                }
                else if (toolStripComboBox1.Text == "Silver")
                {
                    this.tabBarSplitterControl1.Style = TabBarSplitterStyle.Office2007;
                    this.tabBarSplitterControl1.Office2007ColorScheme = Office2007Theme.Silver;
                    this.tabBarSplitterControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                    ApplyThemetoGrid("Silver");
                }
            }
            else
            {
                this.tabBarSplitterControl1.Style = TabBarSplitterStyle.Metro;
                ApplyThemetoGrid("Metro");
            }
        }

        private void ApplyThemetoGrid(string theme)
        {
            foreach (TabBarPage t in tabBarSplitterControl1.TabBarPages)
            {
                foreach (Control c in t.Controls)
                {
                    if (c.GetType().Name.Equals("GridControl"))
                    {
                        switch (theme)
                        {
                            case "Blue":
                                (c as GridControl).GridVisualStyles = GridVisualStyles.Office2007Blue;
                                break;
                            case "Black":
                                (c as GridControl).GridVisualStyles = GridVisualStyles.Office2007Black;
                                break;
                            case "Silver":
                                (c as GridControl).GridVisualStyles = GridVisualStyles.Office2007Silver;
                                break;
                            case "Metro":
                                (c as GridControl).GridVisualStyles = GridVisualStyles.Metro;
                                break;
                            default:
                                (c as GridControl).GridVisualStyles = GridVisualStyles.Office2007Blue;
                                break;
                        }
                        break;
                    }
                }
            }
        }
        private void ScrollerButtons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ScrollerButtons.Text == "All")
                this.tabBarSplitterControl1.ScrollButtons = DisplayArrowButtons.All;
            else if (this.ScrollerButtons.Text == "Single")
                this.tabBarSplitterControl1.ScrollButtons = DisplayArrowButtons.Single;
            else if (this.ScrollerButtons.Text == "None")
                this.tabBarSplitterControl1.ScrollButtons = DisplayArrowButtons.None;
        }

    }
}