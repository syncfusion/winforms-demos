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
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Microsoft.Win32;
using Syncfusion.WinForms.Controls;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using System.Reflection;

namespace CustomCaption
{
    public partial class Form1 : SfForm
    {
        public Form1()
        {
            InitializeComponent();

            this.dockingManager1.ImageList = imageList1;
            this.dockingManager1.ThemeName = "Office2019Colorful";
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += Form1_Load;
            this.dockingManager1.SplitterWidth = 1;
            this.dockingManager1.ThemeStyle.ShowCaptionDottedLines = false;
            this.dockingManager1.DocumentWindowSettings.AllowDragging = false;
         
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
        }

        /// <summary>
        /// Occurs before a form is displayed for the first time.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data with information about the type.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dockingManager1.DockControl(this.toolbox, this, DockingStyle.Left, 100);
            this.dockingManager1.DockControl(this.solutionExplorer, this, DockingStyle.Right, 150);
            this.dockingManager1.DockControl(this.teamExplorer, this, DockingStyle.Top, 175);
            this.dockingManager1.DockControl(this.serverExplorer, this.teamExplorer, DockingStyle.Left, 175);
            this.dockingManager1.DockControl(this.properties, this.teamExplorer, DockingStyle.Right, 175);
            this.dockingManager1.EnableDocumentMode = true;
            this.dockingManager1.DockAsDocument(this.startPage);
            this.startPage.BackColor = Color.White;
            this.dockingManager1.DockControl(this.findResults, this, Syncfusion.Windows.Forms.Tools.DockingStyle.Right, 125);
            this.dockingManager1.DockControl(this.errorList, this.properties, Syncfusion.Windows.Forms.Tools.DockingStyle.Bottom, 175);
            int height = (int)((this.toolbox.Height / 3) * (1.5));
            this.dockingManager1.SetControlSize(this.toolbox, new Size(this.Width / 5, this.Height));
            this.dockingManager1.SetControlSize(this.solutionExplorer, new Size(this.Width / 5, this.Height));
            this.dockingManager1.SetControlSize(this.teamExplorer, new Size(this.Width / 5, height));
            this.dockingManager1.SetControlSize(this.serverExplorer, new Size(this.Width / 5, height));
            this.dockingManager1.SetControlSize(this.properties, new Size(this.Width / 5, height));
            this.dockingManager1.SetControlSize(this.errorList, new Size(this.Width / 5, (this.properties.Height / 2)));
            this.dockingManager1.SetControlSize(this.startPage, new Size(this.teamExplorer.Width + this.serverExplorer.Width, this.toolbox.Height / 3));
            this.dockingManager1.SetControlSize(this.findResults, new Size(this.properties.Width, this.toolbox.Height / 3));
            this.dockingManager1.DockStateChanging += DockingManager1_DockStateChanging;
            this.dockingManager1.DockContextMenu += DockingManager1_DockContextMenu;

            foreach (Control control in dockingManager1.ControlsArray)
            {
                if (control != null && control.HasChildren && control.Controls != null && control.Controls.Count > 0 && control.Controls.Count == 1 && control.Controls[0] is Label)
                {
                    Label label = ((control.Controls[0]) as Label);
                    label.ForeColor = ColorTranslator.FromHtml("#6d6d6d");
                    label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label.Padding = new Padding(0, 30, 0, 0);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    UpdateCaptionCustomization(control, label);
                }
            }

            if (dockingManager1.GetType() != null)
            {
                PropertyInfo property = dockingManager1.GetType().GetProperty("DocumentContainer", BindingFlags.Instance | BindingFlags.NonPublic);

                if (property != null)
                {
                    var source = property.GetValue(dockingManager1, null);

                    if (source != null)
                    {
                        TabbedMDIManager documentContainer = (TabbedMDIManager)source;
                        if (documentContainer != null && documentContainer.TabGroupHosts != null)
                        {
                            foreach (TabHost tabHost in documentContainer.TabGroupHosts)
                            {
                                if (tabHost != null && tabHost.MDITabPanel != null)
                                {
                                    TabControlAdv tabControl = tabHost.MDITabPanel as TabControlAdv;

                                    if (tabControl != null)
                                    {
                                        tabControl.ShowTabCloseButton = false;
                                    }
                                }
                            }

                            if (documentContainer.ContextMenuItem != null)
                            {
                                documentContainer.ContextMenuItem.BeforePopup += ContextMenuItem_BeforePopup;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Occurs just before a dock operation takes place.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="arg">The event data with information about the type.</param>
        private void DockingManager1_DockStateChanging(object sender, DockStateChangeEventArgs arg)
        {
            if (arg.NewState == DockState.Float)
            {
                arg.Handled = true;
                this.dockingManager1.ResumeLayout();
            }
        }

        /// <summary>
        /// Occurs before the submenu gets shown allowing you to cancel it.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data with information about the type.</param>
        private void ContextMenuItem_BeforePopup(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        /// <summary>
        /// Occurs when the right mouse button is clicked over a docking window's caption.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="arg">The event data with information about the type.</param>
        private void DockingManager1_DockContextMenu(object sender, DockContextMenuEventArgs arg)
        {
            if (arg.ContextMenu != null)
            {
                arg.ContextMenu.BeforePopup += ContextMenu_BeforePopup;

                if (arg.ContextMenu.ParentBarItem != null && arg.ContextMenu.ParentBarItem.Items != null && arg.ContextMenu.ParentBarItem.Items.Count > 0 && arg.ContextMenu.ParentBarItem.Items[0] is BarItem)
                {
                    BarItem item = arg.ContextMenu.ParentBarItem.Items[0] as BarItem;

                    if (item != null && item.Text == "Float")
                    {
                        arg.ContextMenu.ParentBarItem.Items.Remove(item);
                    }
                }
            }
        }

        /// <summary>
        /// Occurs before the submenu gets shown allowing you to cancel it.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data with information about the type.</param>
        private void ContextMenu_BeforePopup(object sender, CancelMouseEventArgs e)
        {
            if (this.dockingManager1.ActiveControl == serverExplorer)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        /// <summary>
        /// Update the caption customization in DockingManager child window.
        /// </summary>
        /// <param name="control">The child window of docking manager.</param>
        /// <param name="label">The label contained inside the child window of docking manager.</param>
        private void UpdateCaptionCustomization(Control control, Label label)
        {
            if (control == serverExplorer)
            {
                this.dockingManager1.SetMenuButtonVisibility(this.serverExplorer, false);
                label.Text = "Panel does not have ContextMenu option";
            }
            else if (control == errorList)
            {
                if (control != null && control.Parent is DockHost && (control.Parent as DockHost).InternalController != null)
                {
                    DockHostController dhc = (control.Parent as DockHost).InternalController as DockHostController;
                    if (dhc != null)
                    {
                        dhc.MaximizeButtonVisibility = true;
                    }
                }

                label.Text = "Panel can be maximized";
            }
            else if (control == findResults)
            {
                if (control != null && control.Parent is DockHost && (control.Parent as DockHost).InternalController != null)
                {
                    DockHostController dhc = (control.Parent as DockHost).InternalController as DockHostController;
                    if (dhc != null)
                    {
                        dhc.HideCaption = true;
                    }
                }

                label.Text = "Panel without header";
            }
            else if (control == toolbox)
            {
                label.Text = "Panel without customization";
            }
            else if (control == solutionExplorer)
            {
                this.dockingManager1.SetDockIcon(this.solutionExplorer, 10);

                CaptionButtonsCollection buttonsCollection = new CaptionButtonsCollection();

                Syncfusion.Windows.Forms.Tools.CaptionButton captionButton1 = new Syncfusion.Windows.Forms.Tools.CaptionButton();

                Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo1 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();

                captionButton1.ImageIndex = 0;

                captionButton1.Name = "CloseButton";

                captionButton1.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close;

                captionButton1.SuperToolTipInfo = toolTipInfo1;

                captionButton1.TransparentImageColor = System.Drawing.Color.Transparent;

                buttonsCollection.Add(captionButton1);

                Syncfusion.Windows.Forms.Tools.CaptionButton captionButton = new Syncfusion.Windows.Forms.Tools.CaptionButton();

                Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();

                captionButton.ImageIndex = 15;

                captionButton.Name = "PinButton";

                captionButton.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin;

                captionButton.SuperToolTipInfo = toolTipInfo;

                captionButton.TransparentImageColor = System.Drawing.Color.Transparent;

                buttonsCollection.Add(captionButton);

                Syncfusion.Windows.Forms.Tools.CaptionButton captionButton2 = new Syncfusion.Windows.Forms.Tools.CaptionButton();

                Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo2 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();

                captionButton2.ImageIndex = 2;

                captionButton2.Name = "MenuButton";

                captionButton2.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu;

                captionButton2.SuperToolTipInfo = toolTipInfo2;

                captionButton2.TransparentImageColor = System.Drawing.Color.Transparent;

                buttonsCollection.Add(captionButton2);

                this.dockingManager1.SetCustomCaptionButtons(solutionExplorer, buttonsCollection);

                label.Text = "Panel have customized caption images";
            }
            else if (control == properties)
            {
                this.dockingManager1.SetCloseButtonVisibility(this.properties, false);
                label.Text = "Panel cannot be closed";
            }
            else if (control == teamExplorer)
            {
                this.dockingManager1.SetAutoHideButtonVisibility(this.teamExplorer, false);
                label.Text = "Panel cannot be auto-hidden";
            }
            else if (control == startPage)
            {
                label.Text = "Document window cannot be closed and floated";
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