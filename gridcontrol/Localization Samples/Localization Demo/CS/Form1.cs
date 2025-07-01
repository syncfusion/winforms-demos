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
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace AlertMessageLocalization
{
    public partial class Form1 : GridDemoForm
    {
        #region API Definition
        private GridControl gridCtrl = null;
        #endregion

        #region Constructor

        public Form1()
        {
            Syncfusion.Windows.Forms.LocalizationProvider.Provider = new Localizer();
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.GridSettings();
            this.SampleCustomization();
        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// Setting GridGrouping control Properties
        /// </summary>
        private void GridSettings()
        {
            InitalizeGrid();
            gridCtrl.InitializeCols();
            gridCtrl.Grid.GridVisualStyles = GridVisualStyles.Metro;
            gridCtrl.Grid.TableStyle.WrapText = false;

            this.gridCtrl.Grid.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //used to set GridCaptionRowHeight.
            this.gridCtrl.Grid.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridCtrl.Grid.RowHeights[0] = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridCtrl.Grid.RowHeights[1] = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridCtrl.Grid.ColWidths.ResizeToFit(GridRangeInfo.Table());

            //tab key navigation set as false to move the next control
            this.gridCtrl.Grid.WantTabKey = false;
        }

        #endregion

        #region "Sample Customizations"

        /// <summary>
        /// AlertMessage sample Customizations 
        /// </summary>
        private void SampleCustomization()
        {
            this.gridCtrl.Grid.ShowMessageBoxOnDrop = true;
        }

        #endregion

        #region Helper Methods
        /// <summary>
        /// Initialize the Grid Properties
        /// </summary>
        private void InitalizeGrid()
        {
            this.SuspendLayout();
            gridCtrl = new GridControl();
            this.gridCtrl.Grid.DpiAware = true;
            this.gridCtrl.Grid.Model.EnableLegacyStyle = true;
            this.gridCtrl.Grid.GridVisualStyles = GridVisualStyles.Metro;
            this.gridCtrl.Grid.GridOfficeScrollBars = OfficeScrollBars.Metro;
            gridCtrl.Grid.BackColor = Color.White;
            this.gridCtrl.Grid.ThemesEnabled = true;
            this.gridCtrl.Grid.BorderStyle = BorderStyle.FixedSingle;
            this.panel1.Controls.Add(gridCtrl.Grid);
            this.ResumeLayout(false);
            this.gridCtrl.Grid.ColStyles[2].CellValueType = typeof(DateTime);
            this.gridCtrl.Grid.CurrentCellValidating += new CancelEventHandler(Grid_CurrentCellValidating);
        }

        #endregion

        #region Event Handlers

        #region Grid_CurrentCellValidating event handler
        /// <summary>
        /// Validating Current Cell
        /// </summary>
        void Grid_CurrentCellValidating(object sender, CancelEventArgs e)
        {
            string strError = "Please enter valid value";
            string numError = "Please enter less than 10";
            if (checkBox1.Checked)
            {
                numError = "Bitte geben Sie weniger als 10 ein";
                strError = "Bitte geben Sie einen gültigen Wert ein";
            }
            long result;
            if (this.gridCtrl.Grid.CurrentCell.ColIndex != 2)
            {
                if (long.TryParse(this.gridCtrl.Grid.CurrentCell.Renderer.ControlText, out result))
                {
                    if (result > 10)
                    {
                        this.gridCtrl.Grid.CurrentCell.SetError(numError);
                        e.Cancel = true;
                    }
                }
                else
                    this.gridCtrl.Grid.CurrentCell.SetError(strError);
            }
        }
        #endregion

        #region Localization
        /// <summary>
        /// Change the Localization
        /// </summary>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Localizer loc = new Localizer();
            loc.getstring(checkBox1.Checked);
            LocalizationProvider.Provider = loc;
        }
        #endregion

        #endregion
    }
}
