#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockAbilityDemo
{
    public partial class Form1 : SfForm
    {
        public Form1()
        {
            InitializeComponent();
            this.dockingManager1.ThemeName = "Office2019Colorful";
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += Form1_Load;
            dockingManager1.TabGroupCreated += DockingManager1_TabGroupCreated;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dockingManager1.EnableDocumentMode = true;
            this.dockingManager1.DockControl(this.toolbox, this, DockingStyle.Left, 100);
            this.dockingManager1.DockControl(this.serverExplorer, this.toolbox, DockingStyle.Bottom, 200);
            this.dockingManager1.DockControl(this.teamExplorer, this.serverExplorer, DockingStyle.Bottom, 100);
            this.dockingManager1.DockControl(this.solutionExplorer, this, DockingStyle.Right, 150);
            this.dockingManager1.DockControl(this.properties, this.solutionExplorer, DockingStyle.Bottom, 200);

            this.dockingManager1.DockControl(this.output, this, Syncfusion.Windows.Forms.Tools.DockingStyle.Bottom, 200);
            this.dockingManager1.DockControl(this.errorList, this.output, Syncfusion.Windows.Forms.Tools.DockingStyle.Tabbed, 150);
            this.dockingManager1.DockControl(this.findResults, this.output, Syncfusion.Windows.Forms.Tools.DockingStyle.Tabbed, 150);
            this.dockingManager1.DockControl(this.teamExplorer, this.output, DockingStyle.Left, 200);
            int subWidth = (int)(toolbox.Width * (0.75));
            this.dockingManager1.FloatControl(this.visualTree, new Rectangle(this.Bounds.X + subWidth, this.Bounds.Y + (int)(toolbox.Height / 2), 300, 300));

            this.dockingManager1.DockAsDocument(this.startPage);
            this.dockingManager1.DockAsDocument(this.form1);

            object[] parametersArray = new object[] { form1 };
            MethodInfo methodInfo = dockingManager1.GetType().GetMethod("CreateVerticalTabGroup", BindingFlags.NonPublic | BindingFlags.Instance);
            methodInfo.Invoke(dockingManager1, parametersArray);

            this.dockingManager1.DockAsDocument(this.program);

            object[] parametersArray1 = new object[] { program };
            MethodInfo methodInfo1 = dockingManager1.GetType().GetMethod("CreateHorizontalTabGroup", BindingFlags.NonPublic | BindingFlags.Instance);
            methodInfo1.Invoke(dockingManager1, parametersArray1);

            this.program.BackColor = Color.White;
            this.startPage.BackColor = Color.White;
            this.form1.BackColor = Color.White;

            this.dockingManager1.SetControlSize(this.toolbox, new Size(200, this.Height / 2));
            this.dockingManager1.SetControlSize(this.serverExplorer, new Size(200, this.Height/2));
            this.dockingManager1.SetControlSize(this.solutionExplorer, new Size(200, this.Height / 2));
            this.dockingManager1.SetControlSize(this.properties, new Size(200, this.Height/2));

            this.dockingManager1.SetControlSize(this.output, new Size(this.dockingManager1.GetControlSize(this.output).Width, 200));
            
            
            this.dockingManager1.PreviewDockHints += DockingManager1_PreviewDockHints;
            this.dockingManager1.DockStateChanged += DockingManager1_DockStateChanged;
            foreach (Control control in dockingManager1.ControlsArray)
            {
                if (control.HasChildren && control.Controls != null && control.Controls.Count == 1 && control.Controls[0] is Label)
                {
                    Label label = ((control.Controls[0]) as Label);

                    label.ForeColor = Color.Gray;
                    label.Padding = new Padding(0, 30, 0, 0);
                    label.TextAlign = ContentAlignment.TopCenter;
                    UpdateDockAbility(control, label);
                }
            }
            
           
            if (tabControlAdv != null)
                tabControlAdv.SelectedIndex = 0;

           
            (this.visualTree.Controls[0] as Label).Text = "Panel cannot be docked in any of the window";

            
        }

        private void DockingManager1_DockStateChanged(object sender, DockStateChangeEventArgs arg)
        {
            if(dockingManager1.GetState(teamExplorer) == DockState.Float)
            {
                (teamExplorer.Controls[0] as Label).Text = "Panel can be docked at center of any window";
            }
            else
            {
                ((teamExplorer.Controls[0]) as Label).Text = "All the dock hints will be collapsed here since the DockAbility is None";
            }
        }

        TabControlAdv tabControlAdv;
        private void DockingManager1_TabGroupCreated(object sender, TabGroupCreatedEventArgs arg)
        {
            if (arg.CurrentTabGroup == arg.PreviousTabGroup)
                tabControlAdv = arg.CurrentTabGroup;
        }

        private void DockingManager1_PreviewDockHints(object sender, PreviewDockHintsEventArgs e)
        {
            if(e.DraggingSource == visualTree)
            {
                e.DockAbility = DockAbility.None;
                return;
            }
            if(e.DraggingSource == teamExplorer)
            {
                e.DockAbility = DockAbility.Tabbed;
                return;
            }
            
            if (e.DraggingTarget.Parent == serverExplorer)
            {
                e.DockAbility = DockAbility.Left | DockAbility.Right;
            }
            else if (e.DraggingTarget.Parent == output | e.DraggingTarget.Parent == errorList | e.DraggingTarget.Parent == findResults)
            {
                e.DockAbility = DockAbility.Tabbed;
            }
            else if(e.DraggingTarget.Parent == program)
            {
                e.DockAbility = DockAbility.DocumentLeft | DockAbility.DocumentRight;
            }
            else if(e.DraggingTarget.Parent == form1)
            {
                e.DockAbility =  DockAbility.DocumentBottom | DockAbility.DocumentTop;
            }
            else if (e.DraggingTarget.Parent == startPage)
            {
                e.DockAbility = DockAbility.DocumentBottom | DockAbility.DocumentTop | DockAbility.Tabbed | DockAbility.DocumentRight | DockAbility.DocumentLeft;
            }
            else if(e.DraggingTarget.Parent == toolbox)
            {
                e.DockAbility = DockAbility.Left;
            }
            else if(e.DraggingTarget.Parent == properties)
            {
                e.DockAbility = DockAbility.Top | DockAbility.Bottom;
            }
            else if (e.DraggingTarget.Parent == solutionExplorer)
            {
                e.DockAbility = DockAbility.Top ;
            }
            else if (e.DraggingTarget == teamExplorer)
            {
                e.DockAbility = DockAbility.None;
            }
        }

        private void UpdateDockAbility(Control control, Label label)
        {
            if (control == serverExplorer)
            {
                dockingManager1.SetDockAbility(control, DockAbility.Left | DockAbility.Right);
                label.Text = "The horizontal dock hint will be visible here";
            }
            else if (control == output | control == errorList || control == findResults)
            {
                dockingManager1.SetDockAbility(control, DockAbility.Tabbed);
                label.Text = "The center dock hint will be visible here";
            }
            else if (control == program)
            {
                dockingManager1.SetDockAbility(control, DockAbility.DocumentLeft | DockAbility.DocumentRight);
                label.Text = "The left and right dock hints will be visible here";
            }
            else if (control == form1)
            {
                dockingManager1.SetDockAbility(control, DockAbility.DocumentBottom | DockAbility.DocumentTop);
                label.Text = "The top and bottom dock hints will be visible here";
            }
            else if (control == startPage)
            {
                dockingManager1.SetDockAbility(control, DockAbility.DocumentBottom | DockAbility.DocumentTop | DockAbility.Tabbed | DockAbility.DocumentRight | DockAbility.DocumentLeft);
                label.Text = "All the dock hints will be visible here";
            }
            else if (control == toolbox)
            {
                dockingManager1.SetDockAbility(control, DockAbility.Left);
                label.Text = "The left dock hint will be visible here";
            }
            else if (control == solutionExplorer)
            {
                dockingManager1.SetDockAbility(control, DockAbility.Top);
                label.Text = "The top dock hint will be visible here";
            }
            else if (control == properties)
            {
                dockingManager1.SetDockAbility(control, DockAbility.Top | DockAbility.Bottom);
                label.Text = "The vertical dock hint will be visible here";
            }
            else if (control == teamExplorer)
            {
                dockingManager1.SetDockAbility(control, DockAbility.None);
                label.Text = "All the dock hints will be collapsed here since the DockAbility is None";
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
