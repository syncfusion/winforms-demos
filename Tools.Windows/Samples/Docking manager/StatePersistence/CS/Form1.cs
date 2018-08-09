using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Runtime.Serialization;
using System.IO;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace StatePersistence
{
    public partial class Form1 : MetroForm
    {
        #region Constructor
        DockingClientPanel panel = new DockingClientPanel();
        public Form1()
        {
            InitializeComponent();
            this.mainFrameBarManager1.MetroColor = ColorTranslator.FromHtml("#efeff2");
            this.parentBarItem1.MetroColor  = ColorTranslator.FromHtml("#efeff2");
            this.dockingManager1.DragProviderStyle = DragProviderStyle.VS2012;
            this.tabPageAdv1.Padding = new Padding(10, 8, 0, 0);
            this.richTextBox1.BorderStyle = BorderStyle.None;
            this.tabPageAdv1.BorderStyle = BorderStyle.Fixed3D;           
            this.Controls.Add(this.panel);
            this.panel.Controls.Add(this.tabControlAdv1);
            this.tabControlAdv1.Dock = DockStyle.Fill;
            this.panel3.TabIndex = 1;
            this.panel4.TabIndex = 2;
            this.panel5.TabIndex = 3;
            this.panel3.TabStop = true;
            this.panel4.TabStop = true;
            this.panel5.TabStop = true;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.CaptionBarColor = Color.LightGray;
            this.CaptionForeColor = Color.Black;
            this.CaptionButtonColor = Color.Black;
            this.MetroColor = Color.LightGray;
            this.tabControlAdv1.ActiveTabColor = Color.LightGray;
            this.tabControlAdv1.ForeColor = Color.Black;            
            this.dockingManager1.MetroColor = Color.LightGray;
            this.richTextBox1.LoadFile("..//..//RichTextBox-files//DockingManager.rtf");
            this.treeViewAdv1.ShowLines = false;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewAdv1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewAdv2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPosition = FormStartPosition.CenterScreen;
            this.dockingManager1.ShowMetroCaptionDottedLines = false;
            //this.dockingManager1.PersistState = true;
            this.dockingManager1.LoadDesignerDockState();
            this.treeViewAdv1.FullRowSelect = true;
            this.treeViewAdv1.TabIndex = 4;
            this.treeViewAdv1.Nodes[0].Background = new Syncfusion.Drawing.BrushInfo(Color.LightGray);
            this.treeViewAdv1.Nodes[1].Background = new Syncfusion.Drawing.BrushInfo(Color.LightGray);
            this.treeViewAdv2.TabIndex = 5;
            this.treeViewAdv3.TabIndex = 6;
            this.treeViewAdv3.ExpandAll();
            this.dockingManager1.ShowMetroCaptionDottedLines = false;
            this.dockingManager1.NewDockStateEndLoad += new EventHandler(dockingManager1_NewDockStateEndLoad);
            this.propertyGrid1.SelectedObject = (object)this.dockingManager1;
            this.treeViewAdv1.MouseMove += new MouseEventHandler(treeViewAdv1_MouseMove);
            this.treeViewAdv1.MouseLeave += new EventHandler(treeViewAdv1_MouseLeave);
        }

        void treeViewAdv1_MouseLeave(object sender, EventArgs e)
        {
            if ((sender as TreeViewAdv) == this.treeViewAdv1)
            {
                //this.treeViewAdv1.Nodes[0].Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
                for (int i = 0; i < this.treeViewAdv1.Nodes.Count; i++)
                {
                    foreach (TreeNodeAdv item in this.treeViewAdv1.Nodes[i].Nodes)
                    {
                        item.Background = new Syncfusion.Drawing.BrushInfo(Color.White);

                        foreach (TreeNodeAdv node in item.Nodes)
                        {
                            node.Background = new Syncfusion.Drawing.BrushInfo(Color.White);
                        }
                    }
                }

            }
        }

        void treeViewAdv1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((sender as TreeViewAdv) == this.treeViewAdv1)
            {
                for (int i = 0; i < this.treeViewAdv1.Nodes.Count; i++)
                {
                    //this.treeViewAdv1.Nodes[i].Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
                    foreach (TreeNodeAdv item in this.treeViewAdv1.Nodes[i].Nodes)
                    {
                        item.Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
                    }
                }
                if (this.treeViewAdv1.GetNodeAtPoint(new Point(e.X, e.Y)) != null)
                {
                    TreeNodeAdv node = this.treeViewAdv1.GetNodeAtPoint(new Point(e.X, e.Y));
                    if (!this.treeViewAdv1.Nodes.Contains(node))
                        node.Background = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#efeff2"));
                }
            }
        }

        void dockingManager1_NewDockStateEndLoad(object sender, EventArgs e)
        {
            this.dockingManager1.SetDockLabel(this.panel3, "ToolBox");
            this.dockingManager1.SetDockLabel(this.panel4, "Properties");
            this.dockingManager1.SetDockLabel(this.panel5, "SolutionExplorer");
            this.dockingManager1.ShowMetroCaptionDottedLines = true;
        }

        #endregion 

        #region Icon
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
        #region Show Window menu items

        private void barItem4_Click(object sender, EventArgs e)
        {
            this.dockingManager1.ActivateControl(panel5);
        }

        private void barItem5_Click(object sender, EventArgs e)
        {
            this.dockingManager1.ActivateControl(panel4);
        }

        private void barItem3_Click(object sender, EventArgs e)
        {
            this.dockingManager1.ActivateControl(panel3);
        }
        #endregion

        #region Isolated Storage Load and Save

        private void barItem1_Click(object sender, EventArgs e)
        {
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.IsolatedStorage, "myfile");

            this.dockingManager1.SaveDockState(serializer);

            serializer.PersistNow();
        }

        private void barItem2_Click(object sender, EventArgs e)
        {
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.IsolatedStorage, "myfile");

            this.dockingManager1.LoadDockState(serializer);
        }
        #endregion 

        #region Binary format Load and Save

        private void barItem6_Click(object sender, EventArgs e)
        {
            // To Save

            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.BinaryFile, "myfile");

            this.dockingManager1.SaveDockState(serializer);

            serializer.PersistNow();
        }

        private void barItem7_Click(object sender, EventArgs e)
        {
            // To Load

            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.BinaryFile, "myfile");

            this.dockingManager1.LoadDockState(serializer);
        }
        #endregion

        #region XML file Load and Save

        private void barItem10_Click(object sender, EventArgs e)
        {
            AppStateSerializer.InitializeSingleton(SerializeMode.XMLFile, "Dock1");
            this.dockingManager1.SaveDockState();
        }

        private void barItem11_Click(object sender, EventArgs e)
        {
            this.dockingManager1.LoadDockState();
        }

        #endregion

        #region Reset State

        private void barItem12_Click(object sender, EventArgs e)
        {
            this.dockingManager1.LoadDesignerDockState();
        }

        private void barItem13_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
