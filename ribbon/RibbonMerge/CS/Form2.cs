#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace RibbonControlMerging
{
    public partial class Form2 : MetroForm
    {
        ScrollersFrame scrollerFrame1 = new ScrollersFrame();
        public TabBarSplitterControl tabBarSplitterControl1 = new TabBarSplitterControl();
        TabBarPage page = new TabBarPage();
        public Form2()
        {
            InitializeComponent();
            this.Controls.Add(tabBarSplitterControl1);
            this.tabBarSplitterControl1.TabBarPages.Add(page);
            page.Controls.Add(this.gridControl1);
            this.tabBarSplitterControl1.Dock = DockStyle.Fill;
            this.page.Dock = DockStyle.Fill;
            //this.WindowState = FormWindowState.Maximized;
            page.Text = "TabBarPage1";
            tabBarSplitterControl1.EnableOffice2013Style = true;
            tabBarSplitterControl1.Style = TabBarSplitterStyle.Metro;
            tabBarSplitterControl1.ShowAddNewTabBarPageOption = true;
            this.gridControl1.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
          //  this.gridControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.tabBarSplitterControl1.ShowAddNewTabBarPageOption = true;
            this.tabBarSplitterControl1.LabelEdit = true;
            this.tabBarSplitterControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBarSplitterControl1.TabBarPages[0].Text = "Sheet1";
            //foreach (ToolStripEx item in this.DataToolStripEx.Controls)
            //{
            //    item.LauncherClick += new EventHandler(item_LauncherClick);
            //    item.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //}

            foreach (ToolStripEx item1 in this.ViewToolStripEx.Controls)
            {

                item1.LauncherClick += new EventHandler(item1_LauncherClick);
                new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            this.ShowIcon = false;
            
        }
        
        /// <summary>
        /// This event raises when the launcher is clicked
        /// </summary>
        /// <param name="sender">Instance of the Object</param>
        /// <param name="e">Contains data for the source</param>
        void item1_LauncherClick(object sender, EventArgs e)
        {
            MessageBox.Show("Launcher is clicked", "Launcher");
        }


        /// <summary>
        /// This event raises when the launcher is clicked
        /// </summary>
        /// <param name="sender">Instance of the Object</param>
        /// <param name="e">Contains data for the source</param>
        void item_LauncherClick(object sender, EventArgs e)
        {
            MessageBox.Show("Launcher is clicked", "Launcher");
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            this.tabBarSplitterControl1.AddButtonHoverColor = ColorTranslator.FromHtml("#217346");
            this.tabBarSplitterControl1.ControlAdded += new ControlEventHandler(tabBarSplitterControl1_ControlAdded);
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridControl1.ColCount = 40;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.DefaultRowHeight = 20;
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            // this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.Location = new System.Drawing.Point(189, 136);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.ForceImmediateRepaint = false;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RowCount = 50;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 29)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(321, 189);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 2;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.UseRightToLeftCompatibleTextBox = true;

            this.tabBarSplitterControl1.ActivePageBorderColor = ColorTranslator.FromHtml("#217346");
            this.tabBarSplitterControl1.ForeColor = ColorTranslator.FromHtml("#444444");
            GridMetroColors theme = new GridMetroColors();
            theme.HeaderBottomBorderWeight = GridBottomBorderWeight.Thick;
            theme.HeaderBottomBorderColor = ColorTranslator.FromHtml("#217346");
            theme.HeaderColor.HoverColor = ColorTranslator.FromHtml("#9fd5b7");
            theme.HeaderTextColor.NormalTextColor = Color.Black;

            this.gridControl1.SetMetroStyle(theme);
            this.gridControl1.QueryCellInfo += new Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventHandler(gridControl1_QueryCellInfo);
            this.superAccelerator1.SetAccelerator(this.HyperLinkBtn, "sd");
            this.tabBarSplitterControl1.ShowAddNewTabBarPageOption = false;

        }

        void gridControl1_QueryCellInfo(object sender, Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventArgs e)
        {
            if (e.RowIndex == 0 || e.ColIndex == 0)
            {
                e.Style.Font.Bold = false;
            }
        }

       
        int i = 2;
        protected void tabBarSplitterControl1_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.Text = "Sheet" + i.ToString();
            i++;
            GridControl gridControl = new GridControl();            
            gridControl.Dock = DockStyle.Fill;
            gridControl.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            gridControl.ColCount = 25;
            gridControl.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            gridControl.DefaultRowHeight = 20;
            gridControl.Location = new System.Drawing.Point(189, 136);
            gridControl.Name = "gridControl1";
            gridControl.Properties.ForceImmediateRepaint = false;
            gridControl.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            gridControl.Properties.MarkColHeader = false;
            gridControl.Properties.MarkRowHeader = false;
            gridControl.RowCount = 50;
            gridControl.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 29)});
            gridControl.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            gridControl.Size = new System.Drawing.Size(321, 189);
            gridControl.SmartSizeBox = false;
            gridControl.TabIndex = 2;
            gridControl.Text = "gridControl1";
            gridControl.ThemesEnabled = true;
            GridMetroColors theme = new GridMetroColors();
            theme.HeaderBottomBorderWeight = GridBottomBorderWeight.Thick;
            theme.HeaderBottomBorderColor = ColorTranslator.FromHtml("#217346");
            theme.HeaderColor.HoverColor = ColorTranslator.FromHtml("#9fd5b7");            
            theme.HeaderTextColor.NormalTextColor = Color.Black;
            gridControl.SetMetroStyle(theme);
            e.Control.Controls.Add(gridControl);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}