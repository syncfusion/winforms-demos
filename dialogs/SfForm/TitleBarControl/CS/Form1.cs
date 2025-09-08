#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System.Drawing;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System;

namespace TitleBarControl
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : SfForm
    {
        OrderInfoCollection data;
        TextBoxExt searchBox;
        Label titleLabel;
        FlowLayoutPanel panel;
        SfButton button;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sficon.ico"));
                this.Icon = ico;
            }
            catch { }

            data = new OrderInfoCollection();
            sfDataGrid1.DataSource = data.OrdersListDetails;
            GridSettings();

            #region TitleBarControl Customizations
            this.Style.TitleBar.Height = (int)DpiAware.LogicalToDeviceUnits(38.0f);
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimumSize = this.Size;
            panel = new FlowLayoutPanel();
            panel.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(1061f), (int)DpiAware.LogicalToDeviceUnits(26f));
            titleLabel = new Label();
            titleLabel.Location = new Point((int)DpiAware.LogicalToDeviceUnits(3f), (int)DpiAware.LogicalToDeviceUnits(3f));
            titleLabel.Size = new Size((int)DpiAware.LogicalToDeviceUnits(470f), (int)DpiAware.LogicalToDeviceUnits(25f));
            titleLabel.Font = new Font("Segeo UI", 13, FontStyle.Regular);
            titleLabel.Text = "Searching";
            titleLabel.ForeColor = Color.FromArgb(78, 77, 77);
            searchBox = new TextBoxExt();
            searchBox.Text = "Quick Search";
            searchBox.ForeColor = SystemColors.GrayText;
            searchBox.Leave += SearchBox_Leave;
            searchBox.Enter += SearchBox_Enter;
            searchBox.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(276f), (int)DpiAware.LogicalToDeviceUnits(26f));
            searchBox.BorderStyle = BorderStyle.FixedSingle;
            searchBox.BorderColor = ColorTranslator.FromHtml("#0AA2E6");
            searchBox.KeyUp += SearchBox_KeyUp;
            searchBox.Anchor = AnchorStyles.Right;
            this.Style.TitleBar.BackColor = Color.White;
            button = new SfButton();
            button.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(30f), (int)DpiAware.LogicalToDeviceUnits(21f));
#if NETCORE
            button.Image = Image.FromFile("../../../Images/search.png");
#else
            button.Image = Image.FromFile("../../Images/search.png");
#endif
            button.BackColor = Color.White;
            button.Style.FocusedBackColor = Color.White;
            button.Style.HoverBackColor = Color.White;
            button.Style.PressedBackColor = Color.White;
            button.Style.FocusedBorder = Pens.White;
            button.Style.Border = Pens.White;
            button.Style.PressedBorder = Pens.White;
            button.Style.HoverBorder = Pens.White;
            button.Width = 29;
            panel.Controls.Add(titleLabel);
            panel.Controls.Add(button);
            panel.Controls.Add(searchBox);
            this.TitleBarTextControl = panel;
            titleLabel.MouseDown += TitleLabel_MouseDown;
            #endregion
        }

        /// <summary>
        /// Occurs when a mouse button in pressed ovre the label
        /// </summary>
        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //To provide the Dragging behavior of the Form when clicking and draging over the title bar control.
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Search settings

        /// <summary>
        /// Occurs when enter key is pressed in the search box.
        /// </summary>
        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            this.sfDataGrid1.SearchController.Search(searchBox.Text);
        }

        /// <summary>
        /// Occurs when search box got focus
        /// </summary>
        private void SearchBox_Enter(object sender, System.EventArgs e)
        {
            if (searchBox.Text == "Quick Search")
            {
                searchBox.Text = "";
                searchBox.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Occurs when search box lost focus
        /// </summary>
        private void SearchBox_Leave(object sender, System.EventArgs e)
        {
            if (searchBox.Text.Length == 0)
            {
                searchBox.Text = "Quick Search";
                searchBox.ForeColor = SystemColors.GrayText;
            }
        }

        #endregion

        #region GridSettings
        /// <summary>
        /// Grid Settings for better Look and Feel.
        /// </summary>
        private void GridSettings()
        {
            sfDataGrid1.Columns["Quantity"].CellStyle.HorizontalAlignment = HorizontalAlignment.Right;
            sfDataGrid1.Columns["UnitPrice"].CellStyle.HorizontalAlignment = HorizontalAlignment.Right;
            sfDataGrid1.Columns["ContactNumber"].CellStyle.HorizontalAlignment = HorizontalAlignment.Right;
        }

        #endregion

        #region Icon Handlers
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

        #endregion

    }
}
