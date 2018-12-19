using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Collections;
using System.IO;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Tools;

namespace MultiColumnTreeViewDemo
{
    public partial class MainForm : MetroForm
    {
        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv1;
        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv2;
        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv3;

        public MainForm()
        {
            InitializeComponent();

            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv root = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv();
            DriveInfo drive = new DriveInfo(Environment.SystemDirectory);
            root.Text = drive.ToString();
            this.multiColumnTreeView1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv[] {
            root});

            treeColumnAdv1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv();
            treeColumnAdv2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv();
            treeColumnAdv3 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv();

            treeColumnAdv1.HelpText = "Name";
            treeColumnAdv1.Highlighted = false;
            treeColumnAdv1.Text = "Name";
            treeColumnAdv1.Width = this.multiColumnTreeView1.Width/3;
            treeColumnAdv1.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Highlight);
            treeColumnAdv1.AreaBackground = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.White, System.Drawing.Color.Snow);
            treeColumnAdv1.BorderStyle = BorderStyle.FixedSingle;

            treeColumnAdv2.HelpText = "Full Path";
            treeColumnAdv2.Highlighted = false;
            treeColumnAdv2.Text = "Full Path";
            treeColumnAdv2.Width = this.multiColumnTreeView1.Width / 3;
            treeColumnAdv2.Background = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.Highlight);
            treeColumnAdv2.BorderStyle = BorderStyle.FixedSingle;

            treeColumnAdv3.HelpText = "Date Modified";
            treeColumnAdv3.Highlighted = false;
            treeColumnAdv3.Text = "Date Modified";
            treeColumnAdv3.Width = this.multiColumnTreeView1.Width / 3;
            treeColumnAdv3.Background = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.Highlight);
            treeColumnAdv3.BorderStyle = BorderStyle.FixedSingle;

            this.multiColumnTreeView1.Columns.AddRange(new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv[]{
                treeColumnAdv1,treeColumnAdv2,treeColumnAdv3});

            this.Load += new EventHandler(MultiColumnTreeViewDemo_Load);
            this.multiColumnTreeView1.BeforeExpand += new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeViewAdvCancelableNodeEventHandler(multiColumnTreeView1_BeforeExpand);
            this.MinimumSize = this.Size;
            this.multiColumnTreeView1.Style = MultiColumnVisualStyle.Office2016Colorful;
            this.treeColumnAdv1.BaseStyle = (this.multiColumnTreeView1.BaseStylePairs[2] as Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair).Name;
            this.treeColumnAdv1.BorderStyle = BorderStyle.FixedSingle;
            this.treeColumnAdv2.BorderStyle = BorderStyle.FixedSingle;
            this.treeColumnAdv3.BorderStyle = BorderStyle.FixedSingle;
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

        void MultiColumnTreeViewDemo_Load(object sender, EventArgs e)
        {
            this.multiColumnTreeView1.Nodes[0].Expanded = true;
        }

        void multiColumnTreeView1_BeforeExpand(object sender, Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeViewAdvCancelableNodeEventArgs e)
        {
            try
            {
                //Checking whether the Node has been  expanded atleast once
                if (e.Node.ExpandedOnce) return;

                DirectoryInfo dir = null;
                DirectoryInfo[] subDir = null;
                if (this.multiColumnTreeView1.Nodes[0].Nodes.Count == 0) //Root directory
                {
                    DriveInfo drive = new DriveInfo(e.Node.Text);
                    dir = drive.RootDirectory;

                    subDir = dir.GetDirectories();
                }

                else
                {
                    //Get the Path of the node and AddSeparatorAtEnd Property set to true
                    string path = e.Node.GetPath("\\");

                    dir = new DirectoryInfo(path);
                    subDir = dir.GetDirectories();
                }

                if (subDir != null)
                {
                    foreach (DirectoryInfo dirinfo in subDir)
                    {
                        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem subitem1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem();
                        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem subitem2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem();

                        subitem1.Text = dirinfo.FullName;
                        subitem1.HelpText = subitem1.Text;

                        subitem2.Text = dirinfo.LastWriteTime.ToString();
                        subitem2.HelpText = subitem2.Text;

                        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv node = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv(dirinfo.Name);

                        node.SubItems.AddRange(new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItem[]{
                            subitem1,subitem2});
                        e.Node.Nodes.Add(node);
                    }
                }
            }
            catch { }
        }

        Label label = new Label();
        ComboBoxAdv comboBox = new ComboBoxAdv();
        private void MainForm_Load(object sender, EventArgs e)
        {
            label.Text = "VisualStyle";
            this.label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiColumnTreeView1.Style = MultiColumnVisualStyle.Office2016White;
            this.multiColumnTreeView1.LabelEdit = false;
            comboBox.Width = 150;
            this.tableLayoutPanel1.Controls.Add(label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(comboBox, 2, 0);
            label.Dock = DockStyle.Right;
            comboBox.Items.AddRange(new string[] { "Metro", "Office2016Colorful", "Office2016DarkGray", "Office2016Black", "Office2016White"  });
            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            comboBox.Style = VisualStyle.Office2016Colorful;
            this.comboBox.Dock = DockStyle.Left;
            this.multiColumnTreeView1.Style = MultiColumnVisualStyle.Default;
            this.panel1.BorderStyle = BorderStyle.None;
            this.panel1.Paint += Panel1_Paint;
            this.splitContainer1.BorderStyle = BorderStyle.None;
            this.comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox.SelectedIndex = 1;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (this.multiColumnTreeView1.Style == MultiColumnVisualStyle.Office2016DarkGray)
                ControlPaint.DrawBorder(e.Graphics, this.panel1.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.multiColumnTreeView1.Style == MultiColumnVisualStyle.Office2016Black)
                ControlPaint.DrawBorder(e.Graphics, this.panel1.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.multiColumnTreeView1.Style == MultiColumnVisualStyle.Office2016Colorful || this.multiColumnTreeView1.Style == MultiColumnVisualStyle.Office2016White)
                ControlPaint.DrawBorder(e.Graphics, this.panel1.DisplayRectangle, ColorTranslator.FromHtml("#c6c6c6"), ButtonBorderStyle.Solid);
            else
                ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CaptionBarColor = Color.White;
            this.CaptionForeColor = Color.Black;
            this.CaptionButtonColor = Color.Black;
            this.CaptionButtonHoverColor = Color.Black;
            this.label.ForeColor = Color.Black;

            if (this.comboBox.SelectedIndex == 0)
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.multiColumnTreeView1.Style = MultiColumnVisualStyle.Metro;
                this.MetroColor = Color.White;
            }
            else if (this.comboBox.SelectedIndex == 1)
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionForeColor = Color.Black;
                this.CaptionBarColor = Color.White;
                this.CaptionButtonColor = Color.Black;
                this.CaptionButtonHoverColor = Color.Black;
                this.MetroColor = Color.White;
                foreach (Control ctrl in this.tableLayoutPanel1.Controls)
                {
                    if (ctrl is ButtonAdv)
                    {
                        (ctrl as ButtonAdv).Appearance = ButtonAppearance.Office2016Colorful;
                    }
                    else if(ctrl is ComboBoxAdv)
                    {
                        (ctrl as ComboBoxAdv).Style = VisualStyle.Office2016Colorful;
                    }
                }
                this.multiColumnTreeView1.Style = MultiColumnVisualStyle.Office2016Colorful;
            }
            else if (this.comboBox.SelectedIndex == 3)
            {
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.CaptionForeColor = Color.White;
                this.CaptionButtonColor = Color.White;
                this.CaptionButtonHoverColor = Color.White;
                this.MetroColor = ColorTranslator.FromHtml("#363636");
                this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                foreach(Control ctrl in this.tableLayoutPanel1.Controls)
                {
                    if(ctrl is ButtonAdv)
                    {
                        (ctrl as ButtonAdv).Appearance = ButtonAppearance.Office2016Black;
                    }
                    else if (ctrl is ComboBoxAdv)
                    {
                        (ctrl as ComboBoxAdv).Style = VisualStyle.Office2016Black;
                    }
                }
                this.multiColumnTreeView1.Style = MultiColumnVisualStyle.Office2016Black;
                this.label.ForeColor = Color.White;
            }
            else if (this.comboBox.SelectedIndex == 4)
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                foreach (Control ctrl in this.tableLayoutPanel1.Controls)
                {
                    if (ctrl is ButtonAdv)
                    {
                        (ctrl as ButtonAdv).Appearance = ButtonAppearance.Office2016White;
                    }
                    else if (ctrl is ComboBoxAdv)
                    {
                        (ctrl as ComboBoxAdv).Style = VisualStyle.Office2016White;
                    }
                }
                this.multiColumnTreeView1.Style = MultiColumnVisualStyle.Office2016White;
                this.MetroColor = Color.White;
            }
            else if (this.comboBox.SelectedIndex == 2)
            {
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                this.CaptionForeColor = Color.White;
                this.CaptionButtonColor = Color.White;
                this.CaptionButtonHoverColor = Color.White;
                this.MetroColor = ColorTranslator.FromHtml("#505050");
                foreach (Control ctrl in this.tableLayoutPanel1.Controls)
                {
                    if (ctrl is ButtonAdv)
                    {
                        (ctrl as ButtonAdv).Appearance = ButtonAppearance.Office2016DarkGray;
                    }
                    else if (ctrl is ComboBoxAdv)
                    {
                        (ctrl as ComboBoxAdv).Style = VisualStyle.Office2016DarkGray;
                    }
                }
                this.multiColumnTreeView1.Style = MultiColumnVisualStyle.Office2016DarkGray;
                this.label.ForeColor = Color.White;
            }
        }
    }
}