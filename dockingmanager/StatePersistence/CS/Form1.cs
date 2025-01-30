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
using Syncfusion.WinForms.Controls;

namespace StatePersistence
{
    public partial class Form1 :SfForm
    {
        TabControlAdv tabControlAdv;
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SkinManager.SetVisualStyle(this, "Office2019Colorful");
            this.dockingManager1.EnableDocumentMode = true;
            this.dockingManager1.DragProviderStyle = DragProviderStyle.VS2012;

            this.panel3.TabIndex = 1;
            this.panel4.TabIndex = 2;
            this.panel5.TabIndex = 3;
            this.panel3.TabStop = true;
            this.panel4.TabStop = true;
            this.panel5.TabStop = true;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            this.treeViewAdv1.ShowLines = false;
            this.dockingManager1.ShowMetroCaptionDottedLines = false;
            this.dockingManager1.LoadDesignerDockState();
            this.treeViewAdv1.FullRowSelect = true;
            this.treeViewAdv1.TabIndex = 4;
            this.treeViewAdv2.TabIndex = 5;
            this.treeViewAdv3.TabIndex = 6;
            this.treeViewAdv3.ExpandAll();
            this.dockingManager1.NewDockStateEndLoad += new EventHandler(dockingManager1_NewDockStateEndLoad);
            this.propertyGrid1.SelectedObject = (object)this.dockingManager1;
            this.treeViewAdv1.MouseMove += new MouseEventHandler(treeViewAdv1_MouseMove);
            this.treeViewAdv1.MouseLeave += new EventHandler(treeViewAdv1_MouseLeave);
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.UseXPStyle = false;
            this.editControl2.UseXPStyle = false;
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl2.ShowVerticalSplitters = false;
            this.editControl2.ShowHorizontalSplitters = false;
#if !NETCORE
            this.editControl1.LoadFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Form1.cs");
            this.editControl2.LoadFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Program.cs");
#else
            this.editControl1.LoadFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\..\Form1.cs");
            this.editControl2.LoadFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\..\Program.cs");
#endif
            WireEvents();

        }

         bool canUpdateLayout = true;

        /// <summary>
        /// Wire the events
        /// </summary>
        public void WireEvents()
        {
            this.barItem13.Click += BarItem13_Click;
            this.barItem14.Click += BarItem14_Click;
            this.barItem15.Click += BarItem15_Click;
            this.barItem16.Click += BarItem16_Click;
            this.barItem17.Click += BarItem17_Click;
            this.barItem18.Click += BarItem18_Click;
            this.barItem19.Click += BarItem19_Click;
            this.barItem20.Click += BarItem20_Click;
            this.barItem21.Click += BarItem21_Click;
            this.barItem22.Click += BarItem22_Click;

        }

        private void DockingManager1_TabGroupCreated(object sender, TabGroupCreatedEventArgs arg)
        {
            if (arg.CurrentTabGroup == arg.PreviousTabGroup)

                tabControlAdv = arg.CurrentTabGroup;
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
#if NET9_0_OR_GREATER
            if (canUpdateLayout)
            {
                ResetLayout();
            }
#else
            this.dockingManager1.SetDockLabel(this.panel3, "ToolBox");
            this.dockingManager1.SetDockLabel(this.panel4, "Properties");
            this.dockingManager1.SetDockLabel(this.panel5, "SolutionExplorer");
            this.dockingManager1.ShowMetroCaptionDottedLines = true;
            this.dockingManager1.TabGroupCreated += DockingManager1_TabGroupCreated;
            this.dockingManager1.DockAsDocument(this.editControl1);
            this.dockingManager1.DockAsDocument(this.editControl2);
            if (tabControlAdv != null)
                tabControlAdv.SelectedIndex = 0;
            SkinManager.SetVisualStyle(this, "Office2019Colorful");
            this.mainFrameBarManager1.ThemeName = "Office2019Colorful";
#endif
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


        /// <summary>
        /// Save As IsolatedStorage
        /// </summary>
        private void BarItem16_Click(object sender, EventArgs e)
        {
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.IsolatedStorage, "myfile");

            this.dockingManager1.SaveDockState(serializer);

            serializer.PersistNow();
        }

        /// <summary>
        /// Load From IsolatedStorage
        /// </summary>
        private void BarItem19_Click(object sender, EventArgs e)
        {
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.IsolatedStorage, "myfile");

            this.dockingManager1.LoadDockState(serializer);
        }

        #endregion

        #region Binary format Load and Save

        /// <summary>
        /// Save As BinaryFile
        /// </summary>
        private void BarItem17_Click(object sender, EventArgs e)
        {
            // To Save

            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.BinaryFile, "myfile");

            this.dockingManager1.SaveDockState(serializer);

            serializer.PersistNow();
        }

        /// <summary>
        /// Load from BinaryFile
        /// </summary>
        private void BarItem20_Click(object sender, EventArgs e)
        {
            // To Load

            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.BinaryFile, "myfile");

            this.dockingManager1.LoadDockState(serializer);
        }

        #endregion

        #region XML file Load and Save

        /// <summary>
        /// Save As XMLFile
        /// </summary>
        private void BarItem18_Click(object sender, EventArgs e)
        {
            // To save
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, "Dock1");
            this.dockingManager1.SaveDockState(serializer);
            serializer.PersistNow();
        }


        /// <summary>
        /// Load from XMLFile
        /// </summary>
        private void BarItem21_Click(object sender, EventArgs e)
        {
            //  AppStateSerializer serializer = new AppStateSerializer(SerializeMode.BinaryFile, "MyFile");
            canUpdateLayout = false;
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, "Dock1");
            this.dockingManager1.LoadDockState(serializer);
        }



        #endregion

        #region Saved layout 

#if NET9_0_OR_GREATER
        /// <summary>
        /// To load the layout 1
        /// </summary>
        private void BarItem13_Click(object sender, EventArgs e)
        {
            //  AppStateSerializer serializer = new AppStateSerializer(SerializeMode.BinaryFile, "MyFile");
            canUpdateLayout = false;
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\..\Layout_NET9.0\Layout1.xml");
            this.dockingManager1.LoadDockState(serializer);
        }

        /// <summary>
        /// To load the layout 2
        /// </summary>
        private void BarItem14_Click(object sender, EventArgs e)
        {
            //  AppStateSerializer serializer = new AppStateSerializer(SerializeMode.BinaryFile, "MyFile");
            canUpdateLayout = false;
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\..\Layout_NET9.0\Layout2.xml");
            this.dockingManager1.LoadDockState(serializer);
        }

        /// <summary>
        /// To load the layout 3
        /// </summary>
        private void BarItem15_Click(object sender, EventArgs e)
        {

            //  AppStateSerializer serializer = new AppStateSerializer(SerializeMode.BinaryFile, "MyFile");
            canUpdateLayout = false;
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\..\Layout_NET9.0\Layout3.xml");
            this.dockingManager1.LoadDockState(serializer);
        }
#else
        private void BarItem13_Click(object sender, EventArgs e)
        {
            //  AppStateSerializer serializer = new AppStateSerializer(SerializeMode.BinaryFile, "MyFile");
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, @"..\\..\\Layout1");
            this.dockingManager1.LoadDockState(serializer);
        }

        private void BarItem14_Click(object sender, EventArgs e)
        {
            //  AppStateSerializer serializer = new AppStateSerializer(SerializeMode.BinaryFile, "MyFile");
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, @"..\\..\\Layout2");
            this.dockingManager1.LoadDockState(serializer);
        }

        private void BarItem15_Click(object sender, EventArgs e)
        {

            //  AppStateSerializer serializer = new AppStateSerializer(SerializeMode.BinaryFile, "MyFile");
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, @"..\\..\\Layout3");
            this.dockingManager1.LoadDockState(serializer);
        }
#endif

        #endregion

        #region Reset State

#if NET9_0_OR_GREATER
        public void ResetLayout()
        {
            canUpdateLayout = false;
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\..\Layout_NET9.0\Reset_Layout.xml");
            this.dockingManager1.LoadDockState(serializer);
        }

        private void BarItem22_Click(object sender, EventArgs e)
        {
            ResetLayout();
        }
#else
        private void BarItem22_Click(object sender, EventArgs e)
        {
            this.dockingManager1.LoadDesignerDockState();
        }
#endif

        #endregion

    }
}
