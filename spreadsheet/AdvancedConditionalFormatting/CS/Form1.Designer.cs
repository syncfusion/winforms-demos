#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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

namespace SpreadsheetDemo
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.WindowState = FormWindowState.Maximized;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            #region Spreadsheet

            spreadsheet = new Spreadsheet();
            SpreadsheetRibbon ribbon = new SpreadsheetRibbon() { Spreadsheet = spreadsheet };
            this.DataBindings.Add("Text", this.spreadsheet, "FileName");
            spreadsheet.Dock = DockStyle.Fill;
            spreadsheet.Anchor = AnchorStyles.Left | AnchorStyles.Top;
#if !NETCORE
            spreadsheet.Open(@"..\..\..\..\..\Common\Data\Spreadsheet\AdvancedConditionalFormatting.xlsx");
#else
            spreadsheet.Open(@"..\..\..\..\..\..\Common\Data\Spreadsheet\AdvancedConditionalFormatting.xlsx");
#endif
            this.Controls.Add(spreadsheet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));

            this.Controls.Add(ribbon);

#endregion
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

