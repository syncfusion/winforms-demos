using System.Drawing;
using DemoCommon.Grid;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Windows.Forms;

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
            this.sfDataGrid.Columns[6].CellStyle.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.sfDataGrid.Columns[7].CellStyle.BackColor = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(122)))), ((int)(((byte)(3)))));
            this.sfDataGrid.Columns[8].CellStyle.BackColor = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(122)))), ((int)(((byte)(3)))));
        }

        #endregion
    }
}
