#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FlowLayoutExample
{
    public partial class Form1 : RibbonForm
    {
        string galleryItem = string.Empty;
        public Form1()
        {
            InitializeComponent();
            this.treeViewAdv1.LeftImageList = this.imageList1;
            #region Events
            this.treeViewAdv1.AfterSelect += TreeViewAdv1_AfterSelect;
            this.toolStripGallery2.GalleryItemClicked += ToolStripGallery1_GalleryItemClicked;
            #endregion
            this.MinimumSize = new Size((int)DpiAware.LogicalToDeviceUnits(600), (int)DpiAware.LogicalToDeviceUnits(400));
            string[] drives = null;
            drives = Environment.GetLogicalDrives();
            for (int i = 0; i < 2; i++)
            {
                string drive = drives[i];
                GetDirectories(drive.ToString());
            }

            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowApplicationIcon = true;
        }

        /// <summary>
        /// TreeViewAdv after select event
        /// </summary>
        /// <param name="sender">TreeViewAdv</param>
        /// <param name="e">Event args</param>
        private void TreeViewAdv1_AfterSelect(object sender, EventArgs e)
        {
            if (this.treeViewAdv1.SelectedNode.Text == "This PC")
            {
                this.panelPC.Visible = true;
                this.panelC.Visible = false;
                this.panelD.Visible = false;
            }
            else if(this.treeViewAdv1.SelectedNode.Text == "Local Disk (C:)")
            {
                this.panelPC.Visible = false;
                this.panelC.Visible = true;
                this.panelD.Visible = false;
            }
            else
            {
                this.panelPC.Visible = false;
                this.panelC.Visible = false;
                this.panelD.Visible = true;
            }
            GalleryItemSize(galleryItem);
        }

        /// <summary>
        /// Gets the folder of the given directory 
        /// </summary>
        /// <param name="directory">Directory to which the sub folders to be found</param>
        private void GetDirectories(string directory)
        {
            DirectoryInfo dir = null;
            DirectoryInfo[] subDir = null;
            DriveInfo drive = new DriveInfo(directory);
            dir = drive.RootDirectory;
            subDir = dir.GetDirectories();
            
            if (subDir != null)
            {
                if (directory.Contains("C"))
                {
                    foreach (DirectoryInfo dirinfo in subDir)
                    {
                        FolderWithName folder = new FolderWithName();
                        folder.FolderName = dirinfo.Name;
                        folder.BackColor = System.Drawing.Color.White;
                        folder.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
                        folder.Size = new System.Drawing.Size(100, 97);
#if NETCORE
                        folder.FolderImage = Image.FromFile("..//..//..//Resources//FlatIcons//Folder.png");
#else
                        folder.FolderImage = Image.FromFile("..//..//Resources//FlatIcons//Folder.png");
#endif
                        this.panelC.Controls.Add(folder);
                    }
                }
                else
                {
                    foreach (DirectoryInfo dirinfo in subDir)
                    {
                        FolderWithName folder = new FolderWithName();
                        folder.FolderName = dirinfo.Name;
                        folder.BackColor = System.Drawing.Color.White;
                        folder.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
                        folder.Size = new System.Drawing.Size(100, 97);
#if NETCORE
                        folder.FolderImage = Image.FromFile("..//..//..//Resources//FlatIcons//Folder.png");
#else
                          folder.FolderImage = Image.FromFile("..//..//Resources//FlatIcons//Folder.png");
#endif

                        this.panelD.Controls.Add(folder);
                    }
                }
            }
        }

        /// <summary>
        /// Event for Gallery Item clicked.
        /// </summary>
        /// <param name="sender">ToolstripGalleryItem</param>
        /// <param name="args">ToolstripGalleryItem event args</param>
        private void ToolStripGallery1_GalleryItemClicked(object sender, Syncfusion.Windows.Forms.Tools.ToolStripGalleryItemEventArgs args)
        {
            galleryItem = args.GalleryItem.Text.Trim();
            GalleryItemSize(args.GalleryItem.Text.Trim());
        }

        private void GalleryItemSize(string ItemSize)
        {
            if (ItemSize == "Extra large icons")
            {
                Size size = new Size(300, 316);
                SetButtonsSize(size);
            }
            else if (ItemSize == "Large icons")
            {
                Size size = new Size(200, 216);
                SetButtonsSize(size);
            }
            else if (ItemSize == "Medium icons")
            {
                Size size = new Size(102, 118);
                SetButtonsSize(size);
            }
            else if (ItemSize == "Small icons")
            {
                Size size = new Size(50, 56);
                SetButtonsSize(size);
            }

        }
        /// <summary>
        /// Set the size of the Folder based on the view size.
        /// </summary>
        /// <param name="size">Size to be set</param>
        private void SetButtonsSize(Size size)
        {
            Panel visiblePanel = null;
            this.FlowLayoutpanel.SuspendLayout();
            for (int i = 0; i < this.FlowLayoutpanel.Controls.Count; i++)
            {
                if (this.FlowLayoutpanel.Controls[i] is Panel && (this.FlowLayoutpanel.Controls[i] as Panel).Visible)
                {
                    (this.FlowLayoutpanel.Controls[i] as Panel).Visible = false;
                    visiblePanel = (this.FlowLayoutpanel.Controls[i] as Panel);
                    for (int j = 0; j < (this.FlowLayoutpanel.Controls[i] as Panel).Controls.Count; j++)
                    {
                        (this.FlowLayoutpanel.Controls[i] as Panel).Controls[j].Size = size;
                    }
                }
            }
            visiblePanel.Visible = true;
            this.FlowLayoutpanel.ResumeLayout();

        }
    }
}
