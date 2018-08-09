using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GettingStarted
{
    public partial class Form1 : SfForm
    {
        #region constructor
        public Form1()
        {
            InitializeComponent();
            OrderInfoCollection data = new OrderInfoCollection();
            this.sfListView1.DataSource = data.OrdersListDetails;
            this.sfListView1.DisplayMember = "ProductName";
            this.sfListViewSettings();
            try
            {
                Bitmap bmp = new Bitmap(Image.FromFile(@"../../Icon/sficon.ico"));
                this.Icon = Icon.FromHandle(bmp.GetHicon());
            }
            catch (Exception ex)
            { }
        }
        #endregion

        #region sfListViewSeetings
        void sfListViewSettings()
        {
            this.sfListView1.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            this.sfListView1.SelectionMode = SelectionMode.One;
            this.sfListView1.HotTracking = true;
            this.sfListView1.ItemHeight = 25;
            this.sfListView1.ThemeName = "Office2016Colorful";

            #region themeCombo
            List<ThemeTypes> theme = new List<ThemeTypes>();
            theme.Add(new ThemeTypes() { ThemeName = "Office2016Black", Value = 1 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2016White", Value = 2 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2016DarkGray", Value = 3 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2016Colorful", Value = 4 });
            this.themeComboBox.DataSource = theme;
            this.themeComboBox.DisplayMember = "ThemeName";
            this.themeComboBox.ValueMember = "ThemeName";
            this.themeComboBox.SelectedValue = "Office2016Colorful";
            this.themeComboBox.ThemeName = "Office2016Colorful";
            this.themeComboBox.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            #endregion
            #region ThemeSetings_CheckBox 
            this.SelectionMode_One.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.selectionMode_None.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.selectionMode_Multiple.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.selectionMode_MultiExt.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            #endregion
        }
        #endregion

        #region event
        private void Selection_Mode_CheckedChanged(object sender, EventArgs e)
        {
            SelectionMode selectionMode;
            string selectedValue = (sender as RadioButtonAdv).Text;
            if (Enum.TryParse<SelectionMode>(selectedValue, out selectionMode))
                this.sfListView1.SelectionMode = selectionMode;
        }

        private void themeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.BeginUpdate();
            this.sfListView1.ThemeName = this.themeComboBox.SelectedValue.ToString();
            this.themeComboBox.ThemeName = this.themeComboBox.SelectedValue.ToString();

              switch (this.themeComboBox.SelectedValue.ToString())
            {
                case "Office2016Black":
                    
                    this.Style.TitleBar.BackColor = Color.FromArgb(38, 38, 38);
                    this.Style.TitleBar.CloseButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.CloseButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.Style.TitleBar.MinimizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.MinimizeButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.BackColor = ColorTranslator.FromHtml("#444444");
                    this.label1.BackColor = ColorTranslator.FromHtml("#444444");
                    this.groupBox1.BackColor = ColorTranslator.FromHtml("#444444");
                    this.panel1.BackColor = ColorTranslator.FromHtml("#444444");
                    this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label1.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.groupBox1.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    
                    this.SelectionMode_One.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Black;
                    this.selectionMode_None.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Black;
                    this.selectionMode_Multiple.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Black;
                    this.selectionMode_MultiExt.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Black;

                    this.SelectionMode_One.BackColor = ColorTranslator.FromHtml("#444444");
                    this.selectionMode_None.BackColor = ColorTranslator.FromHtml("#444444");
                    this.selectionMode_Multiple.BackColor = ColorTranslator.FromHtml("#444444");
                    this.selectionMode_MultiExt.BackColor = ColorTranslator.FromHtml("#444444");
                    break;
                case "Office2016DarkGray":
                    this.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.Style.TitleBar.CloseButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.CloseButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.Style.TitleBar.MinimizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.MinimizeButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.Style.TitleBar.BackColor = Color.FromArgb(102, 102, 102);
                    this.label1.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.groupBox1.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.panel1.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.Style.TitleBar.ForeColor = Color.FromArgb(240, 240, 240);
                    this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.groupBox1.ForeColor = ColorTranslator.FromHtml("#262626");

                    this.SelectionMode_One.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016DarkGray;
                    this.selectionMode_None.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016DarkGray;
                    this.selectionMode_Multiple.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016DarkGray;
                    this.selectionMode_MultiExt.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016DarkGray;
                    this.SelectionMode_One.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.selectionMode_None.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.selectionMode_Multiple.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.selectionMode_MultiExt.BackColor = ColorTranslator.FromHtml("#d4d4d4");

                    this.SelectionMode_One.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.selectionMode_None.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.selectionMode_Multiple.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.selectionMode_MultiExt.ForeColor = ColorTranslator.FromHtml("#262626");
                    break;
                    default:
                    this.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                    this.Style.TitleBar.CloseButtonForeColor = Color.FromArgb(51, 51, 51);
                    this.Style.TitleBar.MinimizeButtonForeColor = Color.FromArgb(51, 51, 51);
                    this.Style.TitleBar.CloseButtonHoverBackColor = this.Style.TitleBar.MinimizeButtonHoverBackColor;
                    this.Style.TitleBar.CloseButtonHoverForeColor = this.Style.TitleBar.MinimizeButtonHoverForeColor;
                    this.label1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.groupBox1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.panel1.BackColor = ColorTranslator.FromHtml("#FFFFFF");

                    this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label1.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.groupBox1.ForeColor = ColorTranslator.FromHtml("#444444");
                    if (this.themeComboBox.SelectedValue.ToString() == "Office2016Colorful")
                    {
                        this.SelectionMode_One.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
                        this.selectionMode_None.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
                        this.selectionMode_Multiple.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
                        this.selectionMode_MultiExt.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
                    }
                    else
                    {
                        this.SelectionMode_One.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
                        this.selectionMode_None.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
                        this.selectionMode_Multiple.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
                        this.selectionMode_MultiExt.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
                    }
                    this.SelectionMode_One.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.selectionMode_None.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.selectionMode_Multiple.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.selectionMode_MultiExt.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    break;
            }

            this.EndUpdate();
        }
        #endregion
    }

    #region ThemeData
    public class ThemeTypes
    {
        public string ThemeName { get; set; }
        public int Value { get; set; }
    }
    #endregion
}
