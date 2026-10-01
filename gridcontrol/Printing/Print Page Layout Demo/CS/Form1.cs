#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace PrintPageLayout
{
    public partial class Form1 : GridDemoForm
    {
        #region "Constructor"

        public Form1()
        {
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.GridSettings();
            this.SampleCustomization();
			this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(30);
        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// Setting Grid control Properties
        /// </summary>
        private void GridSettings()
        {
            gridControl1.RowCount = 153;
            gridControl1.ColCount = 45;

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;
        }

        #endregion

        #region "Sample Customizations"

        LayoutSupportHelper layoutHelper;
        GridPrintDocument pd;
        /// <summary>
        /// PrintPageLayout sample Customizations 
        /// </summary>
        private void SampleCustomization()
        {
            pd = new GridPrintDocument(gridControl1);
            if (pd.PrinterSettings.IsValid)
                layoutHelper = new LayoutSupportHelper(gridControl1);

            gridControl1.HorizontalThumbTrack = true;
            gridControl1.VerticalThumbTrack = true;
            colorPickerButton1.ColorSelected += new EventHandler(colorPickerButton1_ColorSelected);
            colorPickerButton2.ColorSelected += new EventHandler(colorPickerButton2_ColorSelected);
        }

        #endregion

        #region Event Handlers

        #region Layout LineColor
        /// <summary>
        /// Select the Layout Line Color
        /// </summary>
        void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            if (layoutHelper != null)
                layoutHelper.LineColor = colorPickerButton1.SelectedColor;
            gridControl1.Invalidate();
        }
        #endregion

        #region TextColor
        /// <summary>
        /// Select the Layout Text Color
        /// </summary>
        void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            if (layoutHelper != null)
                layoutHelper.TextColor = colorPickerButton2.SelectedColor;
            gridControl1.Invalidate();
        }
        #endregion

        #region Layout Lines
        /// <summary>
        /// Show or Hide Layout lines
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (layoutHelper != null)
                layoutHelper.ShowLayoutLines = this.checkBox1.Checked;
        }
        #endregion

        #region PrintPreview
        /// <summary>
        /// Show PrintPreview Dialog on Button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }
        #endregion

        #endregion
    }
}