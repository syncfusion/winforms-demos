#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Syncfusion.Windows.Forms.CellGrid;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.Windows.Forms.Spreadsheet.Helpers;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools.Win32API;
using Syncfusion.Windows.Forms.Tools;

namespace ExportingDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private Spreadsheet spreadsheet;
        private SpreadsheetRibbon ribbon;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.WindowState = FormWindowState.Maximized;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            #region Spreadsheet

            spreadsheet = new Spreadsheet();
            ribbon = new SpreadsheetRibbon() { Spreadsheet = spreadsheet };
            spreadsheet.ShowBusyIndicator = false;
            ribbon.SelectedTab = ribbon.Header.MainItems[2] as ToolStripTabItem;
            AddVisualStyleMenu(ribbon);

            this.DataBindings.Add("Text", this.spreadsheet, "FileName");
            spreadsheet.Dock = DockStyle.Fill;
            spreadsheet.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            spreadsheet.ThemeName = "Office2016Black";
            ribbon.ThemeName = "Office2016Black";
#if !NETCORE
            spreadsheet.Open(@"..\..\..\..\..\..\Common\Data\Spreadsheet\GettingStarted.xlsx");
#else
            spreadsheet.Open(@"..\..\..\..\..\..\..\Common\Data\Spreadsheet\GettingStarted.xlsx");
#endif
            this.Controls.Add(spreadsheet);
            this.Controls.Add(ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            #endregion
        }
        ToolStripComboBoxEx visualStyleComboBox;
        private void AddVisualStyleMenu(SpreadsheetRibbon ribbon)
        {
            ToolStripEx panel = new ToolStripEx();
            panel.GripStyle = ToolStripGripStyle.Hidden;
            panel.Office12Mode = false;
            panel.Size = new Size(143, 0);
            panel.ShowLauncher = false;
            panel.Text = "Visual Style";
            visualStyleComboBox = new ToolStripComboBoxEx();
            visualStyleComboBox.Size = new Size(140, 0);
            visualStyleComboBox.Style = ToolStripExStyle.Metro;            
            visualStyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            visualStyleComboBox.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            visualStyleComboBox.Items.Add("Default");
            visualStyleComboBox.Items.Add("Office 2016 Colorful");
            visualStyleComboBox.Items.Add("Office 2016 DarkGray");
            visualStyleComboBox.Items.Add("Office 2016 Black");
            visualStyleComboBox.Items.Add("Office 2016 White");
            visualStyleComboBox.SelectedIndex = 3;
            visualStyleComboBox.SelectedIndexChanged += visualStyleComboBox_SelectedIndexChanged;
            visualStyleComboBox.DropDownClosed += visualStyleComboBox_DropDownClosed;
            panel.Items.Add(visualStyleComboBox);
            var tab = ribbon.Header.MainItems[2] as ToolStripTabItem;

            tab.Panel.Controls.Add(panel);
        }

        void visualStyleComboBox_DropDownClosed(object sender, EventArgs e)
        {
            this.spreadsheet.ActiveGrid.Focus();
        }

        void visualStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combobox = sender as ToolStripComboBoxEx;
            if (combobox.SelectedIndex == 0)
            {
                spreadsheet.ThemeName = "Default";
                ribbon.ThemeName = "Default";
                visualStyleComboBox.Style = ToolStripExStyle.Metro;
                visualStyleComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                
            }
            else if (combobox.SelectedIndex == 1)
            {
                spreadsheet.ThemeName = "Office2016Colorful";
                ribbon.ThemeName = "Office2016Colorful";
            }
            else if (combobox.SelectedIndex == 2)
            {
                spreadsheet.ThemeName = "Office2016DarkGray";
                ribbon.ThemeName = "Office2016DarkGray";
            }
            else if (combobox.SelectedIndex == 3)
            {
                spreadsheet.ThemeName = "Office2016Black";
                ribbon.ThemeName = "Office2016Black";
            }
            else if (combobox.SelectedIndex == 4)
            {
                spreadsheet.ThemeName = "Office2016White";
                ribbon.ThemeName = "Office2016White";
            }
        }

        /// <summary>
        /// Provide support for Excel like closing operation when press the close button.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            this.spreadsheet.Commands.FileClose.Execute(null);
            if (Form.ActiveForm != null)
                e.Cancel = true;
            base.OnClosing(e);
        }

        #endregion
    }
}

