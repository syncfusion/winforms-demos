using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Collections;

namespace MultiSelectionComboBoxDemo
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.MultiSelectionComboBox1.Location = new Point(this.panel2.Width / 2 - this.MultiSelectionComboBox1.Width / 2, this.panel2.Height / 2 - this.MultiSelectionComboBox1.Height / 2);
            this.MultiSelectionComboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //Create dataTable
            DataTable dt = new DataTable("Table1");
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("occupation");
            dt.Columns.Add("place");
            // Create a Data Set
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            dt.Rows.Add(new string[] { "Alex", "Zen", "Doctor", "Italy" });
            dt.Rows.Add(new string[] { "Bob", "Harry", "Staff", "London" });
            dt.Rows.Add(new string[] { "Alice", "Peter", "Developer", "US" });
            dt.Rows.Add(new string[] { "Adlensha", "Fdo", "Staff", "Italy" });
            dt.Rows.Add(new string[] { "Brick", "John", "Nurse", "North America" });
            dt.Rows.Add(new string[] { "Collen", "Geo", "Developer", "India" });
            DataView view = new DataView(dt);
            this.MultiSelectionComboBox1.MetroColor = Color.DarkGray;
            this.MultiSelectionComboBox1.ForeColor = Color.SlateGray;
            this.MultiSelectionComboBox1.GroupHeaderForeColor = Color.DimGray;
            this.MultiSelectionComboBox1.GroupHeaderBackColor = Color.White;
            this.MultiSelectionComboBox1.ShowCheckBox = true;
            this.MultiSelectionComboBox1.ShowGroups = true;
            this.MultiSelectionComboBox1.DisplayMode = DisplayMode.VisualItem;
            this.MultiSelectionComboBox1.DataSource = view;
            this.MultiSelectionComboBox1.DisplayMember = "FirstName";
            this.MultiSelectionComboBox1.AutoSuggestMode = AutoSuggestMode.Begin;
            this.MultiSelectionComboBox1.MaxDropDownItems = 5;
            this.splitContainerAdv1.SplitterWidth = 1;
            this.MultiSelectionComboBox1.Location = new Point(this.panel2.Width / 2 - this.MultiSelectionComboBox1.Width / 2, this.panel2.Height / 2 - this.MultiSelectionComboBox1.Height / 2);
            this.SizeChanged += new EventHandler(Form1_SizeChanged);
            this.colorPickerButton1.BackColor = Color.White;
            this.MultiSelectionComboBox1.DropDownButton.MouseEnter += new EventHandler(DropDownButton_MouseEnter);
            this.MultiSelectionComboBox1.DropDownButton.MouseLeave += new EventHandler(DropDownButton_MouseLeave);
            this.MultiSelectionComboBox1.DropDownButton.BackColor = Color.FromArgb(237, 238, 236);
            using (Graphics g = this.CreateGraphics())
            {
                if (g.DpiX >= 120)
                {
                    this.splitContainerAdv1.Panel2MinSize = 490;
                    this.splitContainerAdv1.Panel1MinSize = 550;
                    this.splitContainerAdv1.SplitterDistance = 800;
                }
                else
                {
                    this.splitContainerAdv1.Panel2MinSize = 370;
                    this.splitContainerAdv1.Panel1MinSize = 420;
                }
            }
        

            this.Load += Form1_Load;
            this.CaptionImages[0].Size = new Size(0, this.CaptionBarHeight);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBoxAdv6.SelectedIndex = 1;
            this.panel5.Visible = false;
        }

        void DropDownButton_MouseLeave(object sender, EventArgs e)
        {
            (sender as ButtonEditChildButton).BackColor = Color.FromArgb(237, 238, 236);
        }

        void DropDownButton_MouseEnter(object sender, EventArgs e)
        {
            (sender as ButtonEditChildButton).BackColor = Color.FromArgb(233, 233, 233);
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

        void Form1_SizeChanged(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                if (g.DpiX >= 120)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.splitContainerAdv1.Panel1MinSize = 640;
                        this.splitContainerAdv1.Panel2MinSize = 500;
                    }
                    this.splitContainerAdv1.SplitterDistance = this.Width - 500;
                    this.MultiSelectionComboBox1.Location = new Point(this.panel2.Width / 2 - this.MultiSelectionComboBox1.Width / 2, this.panel2.Height / 2 - this.MultiSelectionComboBox1.Height / 2);
                }
                else
                {
                    if (this.WindowState == FormWindowState.Maximized)
                        this.splitContainerAdv1.Panel1MinSize = 620;
                    this.splitContainerAdv1.SplitterDistance = this.Width - 400;
                    this.MultiSelectionComboBox1.Location = new Point(this.panel2.Width / 2 - this.MultiSelectionComboBox1.Width / 2, this.panel2.Height / 2 - this.MultiSelectionComboBox1.Height / 2);
                }
            }
        }



        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
           this.MultiSelectionComboBox1.GroupHeaderBackColor = (sender as ColorPickerButton).SelectedColor;
        }

        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            this.MultiSelectionComboBox1.GroupHeaderForeColor = (sender as ColorPickerButton).SelectedColor;
        }

        private void colorPickerButton3_ColorSelected(object sender, EventArgs e)
        {
            this.MultiSelectionComboBox1.GroupHeaderSeparatorColor = (sender as ColorPickerButton).SelectedColor;
        }

        /// <summary>
        /// Selection Mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBoxAdv).Text == "Begin")
            {
                this.MultiSelectionComboBox1.AutoSuggestMode = AutoSuggestMode.Begin;
            }
            else if ((sender as ComboBoxAdv).Text == "Match")
            {
                this.MultiSelectionComboBox1.AutoSuggestMode = AutoSuggestMode.Match;
            }
            else
            {
                this.MultiSelectionComboBox1.AutoSuggestMode = AutoSuggestMode.Disabled;
            }
        }

        /// <summary>
        /// AutoSizeMode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAdv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBoxAdv).Text == "Horizontal")
            {
                this.MultiSelectionComboBox1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.AutoSizeModes.Horizontal;
            }
            else if ((sender as ComboBoxAdv).Text == "Vertical")
            {
                this.MultiSelectionComboBox1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.AutoSizeModes.Vertical;
            }
            else
            {
                this.MultiSelectionComboBox1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.AutoSizeModes.None;
            }
        }

        /// <summary>
        /// ShowCheckBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAdv4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBoxAdv).Text == "True")
            {
                this.MultiSelectionComboBox1.ShowCheckBox = true;
            }
            else
            {
                this.MultiSelectionComboBox1.ShowCheckBox = false;
            }
        }

        /// <summary>
        /// Allow Grouping
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBoxAdv).Text == "True")
                this.MultiSelectionComboBox1.ShowGroups = true;
            else
                this.MultiSelectionComboBox1.ShowGroups = false;
        }

        private void comboBoxAdv5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBoxAdv).Text == "Visual Item")
            {
                this.MultiSelectionComboBox1.DisplayMode = DisplayMode.VisualItem;
            }
            else if ((sender as ComboBoxAdv).Text == "Delimiter Mode")
            {
                this.MultiSelectionComboBox1.DisplayMode = DisplayMode.DelimiterMode;
            }
            else
            {
                this.MultiSelectionComboBox1.DisplayMode = DisplayMode.NormalMode;
            }
        }

        private void comboBoxAdv6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv6.Text != "Office2016DarkGray" && this.comboBoxAdv6.Text != "Office2016Black")
            {
                this.CaptionBarColor = Color.White;
                this.BackColor = Color.White;
                this.MetroColor = Color.White;
                this.CaptionForeColor = Color.Black;
                this.CaptionButtonColor = Color.Black;
                this.CaptionButtonHoverColor = Color.Black;
                //SkinManager.SetVisualStyle(this.groupBar1, VisualTheme.Office2016White);
                this.groupBar2.VisualStyle = VisualStyle.Office2016White;
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel4.BackColor = Color.White;
                foreach (Control ctrl in this.panel4.Controls)
                {
                    if (ctrl is Label)
                    {
                        ctrl.ForeColor = Color.Black;
                    }
                }
            }

            switch (this.comboBoxAdv6.Text)
            {
                case "Default":
                    this.MultiSelectionComboBox1.Style = Syncfusion.Windows.Forms.Tools.MultiSelectionComboBoxStyle.Default;
                    this.groupBar1.VisualStyle = VisualStyle.Default;
                    this.groupBar2.VisualStyle = VisualStyle.Default;
                    this.comboBoxAdv1.Style = this.comboBoxAdv2.Style = this.comboBoxAdv3.Style = this.comboBoxAdv4.Style = this.comboBoxAdv5.Style = this.comboBoxAdv6.Style = VisualStyle.Default;
                    break;
                case "Office2016Colorful":
                    this.MultiSelectionComboBox1.Style = Syncfusion.Windows.Forms.Tools.MultiSelectionComboBoxStyle.Office2016Colorful;
                    this.CaptionForeColor = Color.Black;
                    this.CaptionBarColor = Color.White;
                    this.MetroColor = Color.White;
                    this.CaptionButtonHoverColor = Color.Black;
                    this.CaptionButtonColor = Color.Black;
                    //SkinManager.SetVisualStyle(this.groupBar1, VisualTheme.Office2016Colorful);
                    this.groupBar1.VisualStyle = VisualStyle.Office2016Colorful;
                    this.groupBar2.VisualStyle = VisualStyle.Office2016Colorful;
                    this.comboBoxAdv1.Style = this.comboBoxAdv2.Style = this.comboBoxAdv3.Style = this.comboBoxAdv4.Style = this.comboBoxAdv5.Style = this.comboBoxAdv6.Style = VisualStyle.Office2016Colorful;
                    break;
                case "Office2016White":
                    this.MultiSelectionComboBox1.Style = Syncfusion.Windows.Forms.Tools.MultiSelectionComboBoxStyle.Office2016White;
                    this.groupBar1.VisualStyle = VisualStyle.Office2016White;
                    this.groupBar2.VisualStyle = VisualStyle.Office2016White;
                    this.CaptionForeColor = Color.Black;
                    this.CaptionBarColor = Color.White;
                    this.MetroColor = Color.White;
                    this.CaptionButtonHoverColor = Color.Black;
                    this.CaptionButtonColor = Color.Black;
                    this.comboBoxAdv1.Style = this.comboBoxAdv2.Style = this.comboBoxAdv3.Style = this.comboBoxAdv4.Style = this.comboBoxAdv5.Style = this.comboBoxAdv6.Style = VisualStyle.Office2016White;
                    break;
                case "Office2016Black":
                    this.MultiSelectionComboBox1.Style = Syncfusion.Windows.Forms.Tools.MultiSelectionComboBoxStyle.Office2016Black;
                    this.CaptionForeColor = Color.White;
                    this.CaptionButtonColor = Color.White;
                    this.CaptionButtonHoverColor = Color.White;
                    this.MetroColor = ColorTranslator.FromHtml("#363636");
                    this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                    this.groupBar1.VisualStyle = VisualStyle.Office2016Black;
                    this.groupBar2.VisualStyle = VisualStyle.Office2016Black;
                    //SkinManager.SetVisualStyle(this.groupBar1, VisualTheme.Office2016Black);
                    this.panel2.BackColor = ColorTranslator.FromHtml("#262626");
                    this.panel4.BackColor = ColorTranslator.FromHtml("#262626");
                    this.comboBoxAdv1.Style = this.comboBoxAdv2.Style = this.comboBoxAdv3.Style = this.comboBoxAdv4.Style = this.comboBoxAdv5.Style = this.comboBoxAdv6.Style = VisualStyle.Office2016Black;

                    foreach (Control ctrl in this.panel4.Controls)
                    {
                        if (ctrl is Label)
                        {
                            ctrl.ForeColor = Color.White;
                        }
                    }
                    break;
                case "Office2016DarkGray":
                    this.MultiSelectionComboBox1.Style = Syncfusion.Windows.Forms.Tools.MultiSelectionComboBoxStyle.Office2016DarkGray;
                    this.MetroColor = ColorTranslator.FromHtml("#505050");
                    this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                    this.CaptionImages[0].BackColor = ColorTranslator.FromHtml("#505050");
                    this.CaptionForeColor = Color.White;
                    this.CaptionButtonColor = Color.White;
                    this.CaptionButtonHoverColor = Color.White;
                    this.groupBar1.VisualStyle = VisualStyle.Office2016DarkGray;
                    this.groupBar2.VisualStyle = VisualStyle.Office2016DarkGray;
                    //SkinManager.SetVisualStyle(this.groupBar1, VisualTheme.Office2016DarkGray);
                    this.panel2.BackColor = ColorTranslator.FromHtml("#666666");
                    this.panel4.BackColor = ColorTranslator.FromHtml("#666666");
                    this.comboBoxAdv1.Style = this.comboBoxAdv2.Style = this.comboBoxAdv3.Style = this.comboBoxAdv4.Style = this.comboBoxAdv5.Style = this.comboBoxAdv6.Style = VisualStyle.Office2016DarkGray;
                    foreach (Control ctrl in this.panel4.Controls)
                    {
                        if(ctrl is Label)
                        {
                            ctrl.ForeColor = Color.White;
                        }
                    }
                    
                    break;
            }
        }
    }
}
