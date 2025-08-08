#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Drawing;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Windows.Forms;
using Syncfusion.WinForms.Core.Enums;

namespace Styling
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();

            #region DataSource
            CountryInfoCollection data = new CountryInfoCollection();
            sfDataGrid.DataSource = data.CountryDetails;
            #endregion

            GridSettings();
        }

        #endregion

        #region SampleGridSettings

        /// <summary>
        /// Customization of SfDataGrid
        /// </summary>
        private void GridSettings()
        {
            //ColumnStyle
            this.sfDataGrid.Columns[0].CellStyle.BackColor = Color.White;
            this.sfDataGrid.Columns[1].CellStyle.BackColor = Color.White;
            this.sfDataGrid.Columns[2].CellStyle.BackColor = Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.sfDataGrid.Columns[3].CellStyle.BackColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.sfDataGrid.Columns[4].CellStyle.BackColor = Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(110)))), ((int)(((byte)(152)))));
            this.sfDataGrid.Columns[4].CellStyle.TextColor = Color.White;
            this.sfDataGrid.Columns[5].CellStyle.BackColor = Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(172)))), ((int)(((byte)(38)))));
            this.sfDataGrid.Columns[6].CellStyle.Interior = new Syncfusion.WinForms.Core.BrushInfo(GradientStyle.Horizontal, ColorTranslator.FromHtml("#5aff8d"), ColorTranslator.FromHtml("#12cb74"));
            this.sfDataGrid.Columns[7].CellStyle.Interior = new Syncfusion.WinForms.Core.BrushInfo(GradientStyle.Horizontal, ColorTranslator.FromHtml("#FFDF80"), ColorTranslator.FromHtml("#FFA925"));
            this.sfDataGrid.Columns[8].CellStyle.Interior = new Syncfusion.WinForms.Core.BrushInfo(GradientStyle.Horizontal, ColorTranslator.FromHtml("#f77891"), ColorTranslator.FromHtml("#ff5862"));
        }

        #endregion
    }
}
