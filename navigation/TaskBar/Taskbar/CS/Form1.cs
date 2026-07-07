#region Copyright Syncfusion Inc. 2001 - 2014
//
//  Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

namespace XPTaskBarSample
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        #region Declarations

        private Syncfusion.Windows.Forms.Tools.XPTaskBarBox taskMenuBox1;
        private Syncfusion.Windows.Forms.Tools.XPTaskBar xpTaskBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbllabel6;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private Syncfusion.Windows.Forms.Tools.XPTaskBarBox taskMenuBox2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel2;
        private CheckBoxAdv checkBox1;
        private CheckBoxAdv checkBox2;
        private System.Windows.Forms.Splitter splitter1;
        private CheckBoxAdv checkBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private CheckBoxAdv checkBox4;
        private CheckBoxAdv checkBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private CheckBoxAdv checkBox7;
        private CheckBoxAdv checkBox8;
        private System.ComponentModel.IContainer components;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv4;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv propertyComboBoxAdv;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv headerDirectionComboBoxAdv;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv headerTextAlignmentComboBox;
        private Syncfusion.Windows.Forms.ButtonAdv addNewXPTaskBarBoxButtonAdv;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDown2;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDown4;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDown1;
        private Syncfusion.Windows.Forms.ButtonAdv searchButtonAdv;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private Label label11;
        private Label label3;
        private XPTaskBarBox xpTaskBarBoxNew;

        private Color color1 = Office2007Colors.Default.GroupBarItemColorLight;
        private Color color2 = Office2007Colors.Default.GroupBarItemColorDark;

        // On Mouse Hover
        private Color color3 = Office2007Colors.Default.GroupBarHighlightColorLight;
        private Color color4 = Office2007Colors.Default.GroupBarHighlightColorDark;

        private Color color5 = Office2007Colors.Default.GroupBarSelectedColorLight;
        private Color color7 = Color.FromArgb(227, 238, 255);
        private Color color8 = Color.FromArgb(227, 238, 255);
        private ButtonAdv buttonAdv2;
        private FlowLayout flowLayout1;
        private NumericUpDownExt numericUpDownExt1;
        private ComboBoxAdv comboBoxAdv1;
        private Label label12;
        private TextBoxExt textBoxExt1;
        private Color color6 = Office2007Colors.Default.GroupBarSelectedColorDark;        
        #endregion

        public Form1()
        {
            InitializeComponent();
            this.comboBoxAdv1.SelectedIndex = 1;
            this.comboBoxAdv1.SelectedIndexChanged += ComboBoxAdv1_SelectedIndexChanged;            
            this.MinimumSize = this.Size;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            // To collapse a box
            this.taskMenuBox1.ExpandContent(true);
            this.taskMenuBox2.ExpandContent(true);
            UpdateXPTaskBarStyleforOffice2016Themes();
        }

        private void ComboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv1.SelectedIndex == 0)
            {
                this.xpTaskBar1.Style = XPTaskBarStyle.Metro;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 1)
            {               
                this.xpTaskBar1.Style = XPTaskBarStyle.Office2016Colorful;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 2)
            {
                this.xpTaskBar1.Style = XPTaskBarStyle.Office2016White;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 3)
            {
                this.xpTaskBar1.Style = XPTaskBarStyle.Office2016DarkGray;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 4)
            {
                this.xpTaskBar1.Style = XPTaskBarStyle.Office2016Black;
            }
            UpdateXPTaskBarStyleforOffice2016Themes();
        }
        private void UpdateXPTaskBarStyleforOffice2016Themes()
        {

            if (this.xpTaskBar1.Style == XPTaskBarStyle.Office2016Colorful)
            {
                this.CaptionBarColor = ColorTranslator.FromHtml("#0173c7");
                this.CaptionForeColor = ColorTranslator.FromHtml("#ffffff");
                this.ShowIcon = false;
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.comboBoxAdv2.Style = VisualStyle.Office2016Colorful;
                this.comboBoxAdv1.Style = VisualStyle.Office2016Colorful;                
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016Colorful;
                this.buttonAdv2.Appearance = ButtonAppearance.Office2016Colorful;
                this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label4.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label11.ForeColor = ColorTranslator.FromHtml("#262626");                
                this.label7.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label9.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label10.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label12.ForeColor = ColorTranslator.FromHtml("#262626");
                this.checkBox1.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox2.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox3.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox4.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox5.Style = CheckBoxAdvStyle.Office2016Colorful;                
                this.checkBox7.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox8.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.xpTaskBar1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
                this.textBoxExt1.Style = TextBoxExt.theme.Office2016Colorful;
                this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanel1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanel2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanel3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanel4.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel5.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanel5.ForeColor = ColorTranslator.FromHtml("#262626");
                this.numericUpDown1.VisualStyle = VisualStyle.Office2016Colorful;
                this.numericUpDown2.VisualStyle = VisualStyle.Office2016Colorful;
                this.numericUpDown4.VisualStyle = VisualStyle.Office2016Colorful;
                this.numericUpDownExt1.VisualStyle = VisualStyle.Office2016Colorful;                
                this.headerDirectionComboBoxAdv.Style = VisualStyle.Office2016Colorful;
                this.headerTextAlignmentComboBox.Style = VisualStyle.Office2016Colorful;
                this.searchButtonAdv.Appearance = ButtonAppearance.Office2016Colorful;
                this.addNewXPTaskBarBoxButtonAdv.Appearance = ButtonAppearance.Office2016Colorful;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016Colorful;
                this.buttonAdv2.Appearance = ButtonAppearance.Office2016Colorful;
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.listView1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.listView1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.propertyComboBoxAdv.Style = VisualStyle.Office2016Colorful;
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel4.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel5.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel3.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.textBoxExt1.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.BackColor = ColorTranslator.FromHtml("#ffffff");
                //this.propertyGrid1.ViewBackColor = ColorTranslator.FromHtml("#ffffff");
                //this.propertyGrid1.ViewForeColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.ViewBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.HelpBackColor = ColorTranslator.FromHtml("#ffffff");
                //this.propertyGrid1.HelpForeColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.HelpBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.LineColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.CategoryForeColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.CategorySplitterColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.CommandsBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.CommandsActiveLinkColor = ColorTranslator.FromHtml("#ffffff");
                this.tabControlAdv1.FixedSingleBorderColor = ColorTranslator.FromHtml("#c5c5c5");                
                this.xpTaskBar1.ScrollerFrame.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                this.xpTaskBar1.ScrollerFrame.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.Colorful;                              
            }
            else if (this.xpTaskBar1.Style == XPTaskBarStyle.Office2016White)
            {

                this.ShowIcon = false;
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                this.comboBoxAdv2.Style = VisualStyle.Office2016White;
                this.comboBoxAdv1.Style = VisualStyle.Office2016White;
                this.numericUpDownExt1.VisualStyle = VisualStyle.Office2016White;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016White;
                this.buttonAdv2.Appearance = ButtonAppearance.Office2016White;
                this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label11.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label4.ForeColor = ColorTranslator.FromHtml("#262626");                
                this.label7.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label9.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label10.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label12.ForeColor = ColorTranslator.FromHtml("#262626");
                this.checkBox1.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox2.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox3.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox4.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox5.Style = CheckBoxAdvStyle.Office2016White;                
                this.checkBox7.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox8.Style = CheckBoxAdvStyle.Office2016White;
                this.xpTaskBar1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
                this.textBoxExt1.Style = TextBoxExt.theme.Office2016White;
                this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanel1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanel2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanel3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanel4.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel5.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanel5.ForeColor = ColorTranslator.FromHtml("#262626");
                this.numericUpDown1.VisualStyle = VisualStyle.Office2016White;
                this.numericUpDown2.VisualStyle = VisualStyle.Office2016White;
                this.numericUpDown4.VisualStyle = VisualStyle.Office2016White;
                this.numericUpDownExt1.VisualStyle = VisualStyle.Office2016White;                
                this.headerDirectionComboBoxAdv.Style = VisualStyle.Office2016White;
                this.headerTextAlignmentComboBox.Style = VisualStyle.Office2016White;
                this.searchButtonAdv.Appearance = ButtonAppearance.Office2016White;
                this.addNewXPTaskBarBoxButtonAdv.Appearance = ButtonAppearance.Office2016White;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016White;
                this.buttonAdv2.Appearance = ButtonAppearance.Office2016White;
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.listView1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.listView1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.propertyComboBoxAdv.Style = VisualStyle.Office2016White;
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel4.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel5.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel3.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.textBoxExt1.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.tabControlAdv1.FixedSingleBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.xpTaskBar1.UseCustomScrollerFrame = true;
                this.xpTaskBar1.ScrollerFrame.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                this.xpTaskBar1.ScrollerFrame.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.White;
            }
            else if (this.xpTaskBar1.Style == XPTaskBarStyle.Office2016DarkGray)
            {

                this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.ShowIcon = false;
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.comboBoxAdv2.Style = VisualStyle.Office2016DarkGray;
                this.comboBoxAdv1.Style = VisualStyle.Office2016DarkGray;
                this.numericUpDownExt1.VisualStyle = VisualStyle.Office2016DarkGray;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016DarkGray;
                this.buttonAdv2.Appearance = ButtonAppearance.Office2016DarkGray;
                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label11.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");                
                this.label7.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label9.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label10.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label12.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.checkBox1.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox2.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox3.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox4.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox5.Style = CheckBoxAdvStyle.Office2016DarkGray;                
                this.checkBox7.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox8.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.xpTaskBar1.BackColor = ColorTranslator.FromHtml("#5e5e5e");
                this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016DarkGray);
                this.textBoxExt1.Style = TextBoxExt.theme.Office2016DarkGray;
                this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel2.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel3.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel4.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel5.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel5.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.numericUpDown1.VisualStyle = VisualStyle.Office2016DarkGray;
                this.numericUpDown2.VisualStyle = VisualStyle.Office2016DarkGray;
                this.numericUpDown4.VisualStyle = VisualStyle.Office2016DarkGray;
                this.numericUpDownExt1.VisualStyle = VisualStyle.Office2016DarkGray;                
                this.headerDirectionComboBoxAdv.Style = VisualStyle.Office2016DarkGray;
                this.headerTextAlignmentComboBox.Style = VisualStyle.Office2016DarkGray;
                this.searchButtonAdv.Appearance = ButtonAppearance.Office2016DarkGray;
                this.addNewXPTaskBarBoxButtonAdv.Appearance = ButtonAppearance.Office2016DarkGray;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016DarkGray;
                this.buttonAdv2.Appearance = ButtonAppearance.Office2016DarkGray;
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#666666");
                this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.listView1.BackColor = ColorTranslator.FromHtml("#666666");
                this.listView1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.propertyComboBoxAdv.Style = VisualStyle.Office2016DarkGray;
                this.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel4.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel5.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel3.BorderColor = ColorTranslator.FromHtml("#444444");
                this.textBoxExt1.BorderColor = ColorTranslator.FromHtml("#444444");
                this.tabControlAdv1.FixedSingleBorderColor = ColorTranslator.FromHtml("#444444");
                this.xpTaskBar1.UseCustomScrollerFrame = true;
                this.xpTaskBar1.ScrollerFrame.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                this.xpTaskBar1.ScrollerFrame.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.DarkGray;

            }
            else if (this.xpTaskBar1.Style == XPTaskBarStyle.Office2016Black)
            {

                this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.ShowIcon = false;
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.comboBoxAdv2.Style = VisualStyle.Office2016Black;
                this.comboBoxAdv1.Style = VisualStyle.Office2016Black;
                this.numericUpDownExt1.VisualStyle = VisualStyle.Office2016Black;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016Black;
                this.buttonAdv2.Appearance = ButtonAppearance.Office2016Black;
                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label11.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");                
                this.label7.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label9.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label10.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label12.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.xpTaskBar1.BackColor = ColorTranslator.FromHtml("#363636");
                this.checkBox1.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox2.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox3.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox4.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox5.Style = CheckBoxAdvStyle.Office2016Black;                
                this.checkBox7.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox8.Style = CheckBoxAdvStyle.Office2016Black;
                this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Black);
                this.textBoxExt1.Style = TextBoxExt.theme.Office2016Black;
                this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel2.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel3.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel4.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel5.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel5.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.numericUpDown1.VisualStyle = VisualStyle.Office2016Black;
                this.numericUpDown2.VisualStyle = VisualStyle.Office2016Black;
                this.numericUpDown4.VisualStyle = VisualStyle.Office2016Black;
                this.numericUpDownExt1.VisualStyle = VisualStyle.Office2016Black;                
                this.headerDirectionComboBoxAdv.Style = VisualStyle.Office2016Black;
                this.headerTextAlignmentComboBox.Style = VisualStyle.Office2016Black;
                this.searchButtonAdv.Appearance = ButtonAppearance.Office2016Black;
                this.addNewXPTaskBarBoxButtonAdv.Appearance = ButtonAppearance.Office2016Black;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016Black;
                this.buttonAdv2.Appearance = ButtonAppearance.Office2016Black;
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#262626");
                this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.listView1.BackColor = ColorTranslator.FromHtml("#262626");
                this.listView1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.propertyGrid1.BackColor = ColorTranslator.FromHtml("#262626");
                this.propertyComboBoxAdv.Style = VisualStyle.Office2016Black;
                this.BorderColor = ColorTranslator.FromHtml("#363636");
                this.gradientPanel4.BorderColor = ColorTranslator.FromHtml("#363636");
                this.gradientPanel5.BorderColor = ColorTranslator.FromHtml("#363636");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#363636");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#363636");
                this.gradientPanel3.BorderColor = ColorTranslator.FromHtml("#363636");
                this.tabControlAdv1.FixedSingleBorderColor = ColorTranslator.FromHtml("#363636");
             //   this.xpTaskBar1.BackColor = ColorTranslator.FromHtml("#1d1d1d");
                this.xpTaskBar1.UseCustomScrollerFrame = true;
                this.xpTaskBar1.ScrollerFrame.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                this.xpTaskBar1.ScrollerFrame.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.Black;
            }
            else
            {

                this.ShowIcon = true;
                this.CaptionBarColor = Color.White;
                this.CaptionForeColor = Color.FromArgb(52, 52, 52);
                this.comboBoxAdv2.Style = VisualStyle.Metro;
                this.comboBoxAdv1.Style = VisualStyle.Metro;
                this.label1.ForeColor = SystemColors.ControlText;
                this.label2.ForeColor = SystemColors.ControlText;
                this.label3.ForeColor = SystemColors.ControlText;
                this.label11.ForeColor = SystemColors.ControlText;
                this.label4.ForeColor = SystemColors.ControlText;                
                this.label7.ForeColor = SystemColors.ControlText;
                this.label9.ForeColor = SystemColors.ControlText;
                this.label10.ForeColor = SystemColors.ControlText;
                this.label12.ForeColor = SystemColors.ControlText;
                this.BackColor = Color.White;
                this.ForeColor = SystemColors.ControlText;
                this.buttonAdv1.Appearance = ButtonAppearance.Metro;
                this.buttonAdv2.Appearance = ButtonAppearance.Metro;
                this.numericUpDownExt1.VisualStyle = VisualStyle.Metro;
                this.numericUpDownExt1.BackColor = Color.White;
                this.xpTaskBar1.BackColor = Color.White;
                this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
                this.textBoxExt1.Style = TextBoxExt.theme.Metro;
                this.checkBox1.Style = CheckBoxAdvStyle.Metro;
                this.checkBox2.Style = CheckBoxAdvStyle.Metro;
                this.checkBox3.Style = CheckBoxAdvStyle.Metro;
                this.checkBox4.Style = CheckBoxAdvStyle.Metro;
                this.checkBox5.Style = CheckBoxAdvStyle.Metro;                
                this.checkBox7.Style = CheckBoxAdvStyle.Metro;
                this.checkBox8.Style = CheckBoxAdvStyle.Metro;
                this.gradientPanel1.BackColor = Color.White;
                this.gradientPanel1.ForeColor = SystemColors.ControlText;
                this.gradientPanel2.BackColor = Color.White;
                this.gradientPanel2.ForeColor = SystemColors.ControlText;
                this.gradientPanel3.BackColor = Color.White;
                this.gradientPanel3.ForeColor = SystemColors.ControlText;
                this.gradientPanel4.BackColor = Color.White;
                this.gradientPanel4.ForeColor = SystemColors.ControlText;
                this.gradientPanel5.BackColor = Color.White;
                this.gradientPanel5.ForeColor = SystemColors.ControlText;              
                this.headerDirectionComboBoxAdv.Style = VisualStyle.Metro;
                this.headerTextAlignmentComboBox.Style = VisualStyle.Metro;
                this.searchButtonAdv.Appearance = ButtonAppearance.Metro;
                this.addNewXPTaskBarBoxButtonAdv.Appearance = ButtonAppearance.Metro;
                this.buttonAdv1.Appearance = ButtonAppearance.Metro;
                this.buttonAdv2.Appearance = ButtonAppearance.Metro;
                this.richTextBox1.BackColor = Color.White;
                this.richTextBox1.ForeColor = SystemColors.ControlText;
                this.listView1.BackColor = Color.White;
                this.propertyComboBoxAdv.Style = VisualStyle.Metro;
                this.listView1.ForeColor = SystemColors.ControlText;
                this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
                this.gradientPanel4.BorderColor = ColorTranslator.FromHtml("#ffbfdbfe");
                this.gradientPanel5.BorderColor = ColorTranslator.FromHtml("#ffbfdbfe");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#ffbfdbfe");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#ffbfdbfe");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#ffbfdbfe");
                this.gradientPanel3.BorderColor = ColorTranslator.FromHtml("#ffbfdbfe");
                this.textBoxExt1.BorderColor = Color.Silver;
                this.propertyGrid1.BackColor = Color.White;
                this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
                this.xpTaskBar1.UseCustomScrollerFrame = true;
                this.xpTaskBar1.ScrollerFrame.VisualStyle = ScrollBarCustomDrawStyles.Metro;
                this.numericUpDown1.VisualStyle = VisualStyle.Metro;
                this.numericUpDown2.VisualStyle = VisualStyle.Metro;
                this.numericUpDown4.VisualStyle = VisualStyle.Metro;
                this.numericUpDown1.BackColor = Color.White;
                this.numericUpDown2.BackColor = Color.White;
                this.numericUpDown4.BackColor = Color.White;
                this.textBoxExt1.BackColor = Color.White;
            }
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

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        //Get and Load the images
#if NET9_0_OR_GREATER
        private static Image GetImage(string path)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            if (asm != null && !string.IsNullOrEmpty(path))
                return Image.FromStream(asm.GetManifestResourceStream(path));
            return null;
        }

        private void LoadImages(ImageList imageList, string folder, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                string imagePath = ($"XPTaskBarSample.Images.{folder}.Image_{i}.png");
                imageList.Images.Add(GetImage(imagePath));
            }
        }
#endif

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbllabel6 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownExt1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.checkBox2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox5 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.numericUpDown2 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDown4 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox8 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox7 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.headerDirectionComboBoxAdv = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.headerTextAlignmentComboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.addNewXPTaskBarBoxButtonAdv = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.propertyComboBoxAdv = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.xpTaskBar1 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.taskMenuBox1 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.taskMenuBox2 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.searchButtonAdv = new Syncfusion.Windows.Forms.ButtonAdv();
            this.flowLayout1 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).BeginInit();
            this.gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerDirectionComboBoxAdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTextAlignmentComboBox)).BeginInit();
            this.tabPageAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyComboBoxAdv)).BeginInit();
            this.tabPageAdv3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageAdv4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).BeginInit();
            this.xpTaskBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskMenuBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskMenuBox2)).BeginInit();
            this.taskMenuBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList2
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList2, "ImageList2", 3);
#else
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
#endif
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "007.ico");
            this.imageList2.Images.SetKeyName(1, "012.ico");
            this.imageList2.Images.SetKeyName(2, "016.ico");
            // 
            // imageList1
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList1, "ImageList1", 9);
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "bo813e1.gif");
            this.imageList1.Images.SetKeyName(3, "flagred.gif");
            this.imageList1.Images.SetKeyName(4, "barcha1.gif");
            this.imageList1.Images.SetKeyName(5, "help2.gif");
            this.imageList1.Images.SetKeyName(6, "option1.gif");
            this.imageList1.Images.SetKeyName(7, "treevi1.gif");
            this.imageList1.Images.SetKeyName(8, "artist.png");
            // 
            // lbllabel6
            // 
            this.lbllabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbllabel6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllabel6.Location = new System.Drawing.Point(0, 0);
            this.lbllabel6.Name = "lbllabel6";
            this.lbllabel6.Size = new System.Drawing.Size(176, 24);
            this.lbllabel6.TabIndex = 11;
            this.lbllabel6.Text = "       XPTaskBar properties";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(211)))), ((int)(((byte)(241))))), System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(229)))), ((int)(((byte)(241))))));
            this.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gradientPanel1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.tabControlAdv1);
            this.gradientPanel1.Controls.Add(this.splitter1);
            this.gradientPanel1.Controls.Add(this.xpTaskBar1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(689, 439);
            this.gradientPanel1.TabIndex = 13;
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(479, 439);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv4);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.tabControlAdv1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdv1.ImageList = this.imageList1;
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Location = new System.Drawing.Point(210, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(479, 439);
            this.tabControlAdv1.TabIndex = 8;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.tabControlAdv1.VSLikeScrollButton = true;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.White;
            this.tabPageAdv1.Controls.Add(this.gradientPanel3);
            this.tabPageAdv1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageIndex = 3;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(477, 413);
            this.tabPageAdv1.TabFont = new System.Drawing.Font("Arial", 8.25F);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "XPTaskBar Features";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.AutoScroll = true;
            this.gradientPanel3.BackColor = System.Drawing.Color.White;
            this.gradientPanel3.BorderColor = System.Drawing.Color.White;
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.Controls.Add(this.label11);
            this.gradientPanel3.Controls.Add(this.label3);
            this.gradientPanel3.Controls.Add(this.gradientPanel5);
            this.gradientPanel3.Controls.Add(this.gradientPanel4);
            this.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(477, 413);
            this.gradientPanel3.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 14);
            this.label11.TabIndex = 36;
            this.label11.Text = "XPTaskBarBox Properties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 14);
            this.label3.TabIndex = 34;
            this.label3.Text = "XPTaskBar Properties";
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel5.Controls.Add(this.comboBoxAdv1);
            this.gradientPanel5.Controls.Add(this.label12);
            this.gradientPanel5.Controls.Add(this.numericUpDownExt1);
            this.gradientPanel5.Controls.Add(this.checkBox2);
            this.gradientPanel5.Controls.Add(this.checkBox3);
            this.gradientPanel5.Controls.Add(this.label10);
            this.gradientPanel5.Controls.Add(this.numericUpDown1);
            this.gradientPanel5.Controls.Add(this.label4);
            this.gradientPanel5.Controls.Add(this.checkBox1);
            this.gradientPanel5.Location = new System.Drawing.Point(23, 27);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(426, 134);
            this.gradientPanel5.TabIndex = 33;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(135, 23);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Arial", 9F);
            this.comboBoxAdv1.Items.AddRange(new object[] {
            " Metro",
            "Office2016Colorful",
            "Office2016White",
            "Office2016DarkGray",
            "Office2016Black"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(284, 95);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(135, 23);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(176, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Style";
            // 
            // numericUpDownExt1
            // 
            this.numericUpDownExt1.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt1.BeforeTouchSize = new System.Drawing.Size(44, 23);
            this.numericUpDownExt1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.numericUpDownExt1.BorderColor = System.Drawing.Color.Silver;
            this.numericUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownExt1.Location = new System.Drawing.Point(286, 21);
            this.numericUpDownExt1.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDownExt1.MetroColor = System.Drawing.Color.Silver;
            this.numericUpDownExt1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownExt1.Name = "numericUpDownExt1";
            this.numericUpDownExt1.Size = new System.Drawing.Size(44, 23);
            this.numericUpDownExt1.TabIndex = 28;
            this.numericUpDownExt1.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDownExt1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDownExt1.ValueChanged += new System.EventHandler(this.numericUpDownExt1_ValueChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.BeforeTouchSize = new System.Drawing.Size(121, 19);
            this.checkBox2.DrawFocusRectangle = false;
            this.checkBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(24, 20);
            this.checkBox2.MetroColor = System.Drawing.Color.Gray;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(121, 19);
            this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Vertical Layout";
            this.checkBox2.ThemesEnabled = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.BeforeTouchSize = new System.Drawing.Size(98, 20);
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.DrawFocusRectangle = false;
            this.checkBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(24, 94);
            this.checkBox3.MetroColor = System.Drawing.Color.Gray;
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(98, 20);
            this.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "AutoScroll";
            this.checkBox3.ThemesEnabled = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(176, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Dock Padding";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.BeforeTouchSize = new System.Drawing.Size(44, 23);
            this.numericUpDown1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.numericUpDown1.BorderColor = System.Drawing.Color.Silver;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(285, 57);
            this.numericUpDown1.MetroColor = System.Drawing.Color.Silver;
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 23);
            this.numericUpDown1.TabIndex = 24;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Column Width on Horizontal Alignment";
            // 
            // checkBox1
            // 
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(128, 20);
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(24, 57);
            this.checkBox1.MetroColor = System.Drawing.Color.Gray;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 20);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Themes Enabled";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel4.Controls.Add(this.buttonAdv2);
            this.gradientPanel4.Controls.Add(this.label8);
            this.gradientPanel4.Controls.Add(this.label9);
            this.gradientPanel4.Controls.Add(this.checkBox5);
            this.gradientPanel4.Controls.Add(this.numericUpDown2);
            this.gradientPanel4.Controls.Add(this.numericUpDown4);
            this.gradientPanel4.Controls.Add(this.label5);
            this.gradientPanel4.Controls.Add(this.checkBox4);
            this.gradientPanel4.Controls.Add(this.checkBox8);
            this.gradientPanel4.Controls.Add(this.checkBox7);
            this.gradientPanel4.Controls.Add(this.headerDirectionComboBoxAdv);
            this.gradientPanel4.Controls.Add(this.headerTextAlignmentComboBox);
            this.gradientPanel4.Controls.Add(this.label7);
            this.gradientPanel4.Controls.Add(this.addNewXPTaskBarBoxButtonAdv);
            this.gradientPanel4.Location = new System.Drawing.Point(23, 198);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(424, 203);
            this.gradientPanel4.TabIndex = 32;
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(66, 26);
            this.buttonAdv2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv2.ForeColor = System.Drawing.Color.Black;
            this.buttonAdv2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(58, 162);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(66, 26);
            this.buttonAdv2.TabIndex = 24;
            this.buttonAdv2.Text = "Sort Items";
            this.buttonAdv2.UseVisualStyle = true;
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(179, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Header Direction";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(180, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "Header Text \r\nAlignment";
            // 
            // checkBox5
            // 
            this.checkBox5.BeforeTouchSize = new System.Drawing.Size(122, 20);
            this.checkBox5.DrawFocusRectangle = false;
            this.checkBox5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(25, 47);
            this.checkBox5.MetroColor = System.Drawing.Color.Gray;
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(122, 20);
            this.checkBox5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "Collapse Boxes";
            this.checkBox5.ThemesEnabled = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.White;
            this.numericUpDown2.BeforeTouchSize = new System.Drawing.Size(96, 23);
            this.numericUpDown2.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.numericUpDown2.BorderColor = System.Drawing.Color.Silver;
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(287, 83);
            this.numericUpDown2.MetroColor = System.Drawing.Color.Silver;
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(96, 23);
            this.numericUpDown2.TabIndex = 21;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDown2.Click += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.Color.White;
            this.numericUpDown4.BeforeTouchSize = new System.Drawing.Size(96, 23);
            this.numericUpDown4.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.numericUpDown4.BorderColor = System.Drawing.Color.Silver;
            this.numericUpDown4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.Location = new System.Drawing.Point(287, 119);
            this.numericUpDown4.MetroColor = System.Drawing.Color.Silver;
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(96, 23);
            this.numericUpDown4.TabIndex = 22;
            this.numericUpDown4.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown4.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDown4.Click += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "PadX";
            // 
            // checkBox4
            // 
            this.checkBox4.BeforeTouchSize = new System.Drawing.Size(127, 20);
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.DrawFocusRectangle = false;
            this.checkBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(26, 15);
            this.checkBox4.MetroColor = System.Drawing.Color.Gray;
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(127, 20);
            this.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Allow Drag Drop";
            this.checkBox4.ThemesEnabled = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.BeforeTouchSize = new System.Drawing.Size(132, 20);
            this.checkBox8.DrawFocusRectangle = false;
            this.checkBox8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(25, 120);
            this.checkBox8.MetroColor = System.Drawing.Color.Gray;
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(132, 20);
            this.checkBox8.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox8.TabIndex = 12;
            this.checkBox8.Text = "Toggle by Button";
            this.checkBox8.ThemesEnabled = false;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.BeforeTouchSize = new System.Drawing.Size(154, 20);
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.DrawFocusRectangle = false;
            this.checkBox7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(25, 83);
            this.checkBox7.MetroColor = System.Drawing.Color.Gray;
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(154, 20);
            this.checkBox7.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox7.TabIndex = 11;
            this.checkBox7.Text = "Show Collapse Button";
            this.checkBox7.ThemesEnabled = false;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // headerDirectionComboBoxAdv
            // 
            this.headerDirectionComboBoxAdv.BackColor = System.Drawing.Color.White;
            this.headerDirectionComboBoxAdv.BeforeTouchSize = new System.Drawing.Size(96, 23);
            this.headerDirectionComboBoxAdv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.headerDirectionComboBoxAdv.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerDirectionComboBoxAdv.Items.AddRange(new object[] {
            "LeftToRight",
            "RightToLeft"});
            this.headerDirectionComboBoxAdv.Location = new System.Drawing.Point(286, 15);
            this.headerDirectionComboBoxAdv.Name = "headerDirectionComboBoxAdv";
            this.headerDirectionComboBoxAdv.Size = new System.Drawing.Size(96, 23);
            this.headerDirectionComboBoxAdv.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.headerDirectionComboBoxAdv.TabIndex = 19;
            this.headerDirectionComboBoxAdv.Text = "LeftToRight";
            this.headerDirectionComboBoxAdv.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // headerTextAlignmentComboBox
            // 
            this.headerTextAlignmentComboBox.BackColor = System.Drawing.Color.White;
            this.headerTextAlignmentComboBox.BeforeTouchSize = new System.Drawing.Size(96, 23);
            this.headerTextAlignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.headerTextAlignmentComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTextAlignmentComboBox.Items.AddRange(new object[] {
            "Near",
            "Center",
            "Far"});
            this.headerTextAlignmentComboBox.Location = new System.Drawing.Point(286, 47);
            this.headerTextAlignmentComboBox.Name = "headerTextAlignmentComboBox";
            this.headerTextAlignmentComboBox.Size = new System.Drawing.Size(96, 23);
            this.headerTextAlignmentComboBox.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.headerTextAlignmentComboBox.TabIndex = 20;
            this.headerTextAlignmentComboBox.Text = "Near";
            this.headerTextAlignmentComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(182, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "PadY";
            // 
            // addNewXPTaskBarBoxButtonAdv
            // 
            this.addNewXPTaskBarBoxButtonAdv.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.addNewXPTaskBarBoxButtonAdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.addNewXPTaskBarBoxButtonAdv.BeforeTouchSize = new System.Drawing.Size(192, 26);
            this.addNewXPTaskBarBoxButtonAdv.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewXPTaskBarBoxButtonAdv.ForeColor = System.Drawing.Color.Black;
            this.addNewXPTaskBarBoxButtonAdv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewXPTaskBarBoxButtonAdv.IsBackStageButton = false;
            this.addNewXPTaskBarBoxButtonAdv.Location = new System.Drawing.Point(164, 162);
            this.addNewXPTaskBarBoxButtonAdv.Name = "addNewXPTaskBarBoxButtonAdv";
            this.addNewXPTaskBarBoxButtonAdv.Size = new System.Drawing.Size(192, 26);
            this.addNewXPTaskBarBoxButtonAdv.TabIndex = 23;
            this.addNewXPTaskBarBoxButtonAdv.Text = "Add New XPTaskBar Box";
            this.addNewXPTaskBarBoxButtonAdv.UseVisualStyle = true;
            this.addNewXPTaskBarBoxButtonAdv.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(253)))));
            this.tabPageAdv2.Controls.Add(this.propertyGrid1);
            this.tabPageAdv2.Controls.Add(this.propertyComboBoxAdv);
            this.tabPageAdv2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageIndex = 0;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(477, 413);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "Property Grid";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(158)))));
            this.propertyGrid1.CommandsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.propertyGrid1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 22);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGrid1.Size = new System.Drawing.Size(477, 391);
            this.propertyGrid1.TabIndex = 10;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // propertyComboBoxAdv
            // 
            this.propertyComboBoxAdv.BackColor = System.Drawing.Color.White;
            this.propertyComboBoxAdv.BeforeTouchSize = new System.Drawing.Size(477, 22);
            this.propertyComboBoxAdv.Dock = System.Windows.Forms.DockStyle.Top;
            this.propertyComboBoxAdv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propertyComboBoxAdv.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyComboBoxAdv.Items.AddRange(new object[] {
            "XPTaskBar",
            "XPTaskBarBox1",
            "XPTaskBarBox2"});
            this.propertyComboBoxAdv.Location = new System.Drawing.Point(0, 0);
            this.propertyComboBoxAdv.Name = "propertyComboBoxAdv";
            this.propertyComboBoxAdv.Size = new System.Drawing.Size(477, 22);
            this.propertyComboBoxAdv.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.propertyComboBoxAdv.TabIndex = 13;
            this.propertyComboBoxAdv.Text = "XPTaskBar";
            this.propertyComboBoxAdv.SelectedIndexChanged += new System.EventHandler(this.cmbcomboBox2_SelectedIndexChanged);
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(253)))));
            this.tabPageAdv3.Controls.Add(this.listView1);
            this.tabPageAdv3.Controls.Add(this.panel2);
            this.tabPageAdv3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageIndex = 1;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(477, 413);
            this.tabPageAdv3.TabIndex = 3;
            this.tabPageAdv3.Text = "Event Log";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(477, 385);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Events";
            this.columnHeader1.Width = 168;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Object";
            this.columnHeader2.Width = 298;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonAdv1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 28);
            this.panel2.TabIndex = 1;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(120, 28);
            this.buttonAdv1.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(357, 0);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(120, 28);
            this.buttonAdv1.TabIndex = 0;
            this.buttonAdv1.Text = "Clear Log";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(253)))));
            this.tabPageAdv4.Controls.Add(this.richTextBox1);
            this.tabPageAdv4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv4.Image = null;
            this.tabPageAdv4.ImageIndex = 5;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv4.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.ShowCloseButton = true;
            this.tabPageAdv4.Size = new System.Drawing.Size(477, 413);
            this.tabPageAdv4.TabIndex = 4;
            this.tabPageAdv4.Text = "About";
            this.tabPageAdv4.ThemesEnabled = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(477, 413);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(237)))), ((int)(((byte)(248)))));
            this.splitter1.Location = new System.Drawing.Point(208, 0);
            this.splitter1.MinExtra = 5;
            this.splitter1.MinSize = 5;
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 439);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // xpTaskBar1
            // 
            this.xpTaskBar1.AutoScroll = true;
            this.xpTaskBar1.BackColor = System.Drawing.Color.White;
            this.xpTaskBar1.BeforeTouchSize = new System.Drawing.Size(208, 439);
            this.xpTaskBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xpTaskBar1.ColWidthOnHorizontalAlignment = 120;
            this.xpTaskBar1.Controls.Add(this.taskMenuBox1);
            this.xpTaskBar1.Controls.Add(this.taskMenuBox2);
            this.xpTaskBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xpTaskBar1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.xpTaskBar1.HorizontalPadding = 5;
            this.xpTaskBar1.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBar1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.xpTaskBar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar1.Name = "xpTaskBar1";
            this.xpTaskBar1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.xpTaskBar1.PADY = 2;
            this.xpTaskBar1.Size = new System.Drawing.Size(208, 439);
            this.xpTaskBar1.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2016Colorful;
            this.xpTaskBar1.TabIndex = 1;
            this.xpTaskBar1.VerticalPadding = 5;
            // 
            // taskMenuBox1
            // 
            this.taskMenuBox1.AllowDrop = true;
            this.taskMenuBox1.BackColor = System.Drawing.Color.Transparent;
            this.taskMenuBox1.DrawFocusRect = false;
            this.taskMenuBox1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.taskMenuBox1.HeaderFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskMenuBox1.HeaderImageIndex = 0;
            this.taskMenuBox1.HeaderImageList = this.imageList2;
            this.taskMenuBox1.HitTaskBoxArea = false;
            this.taskMenuBox1.HotTrackColor = System.Drawing.Color.Empty;
            this.taskMenuBox1.ImageList = this.imageList1;
            this.taskMenuBox1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Text, Image, Click Events and DragDrop items", System.Drawing.Color.Empty, 7, "1", "ItemClick,  DragDropItems", true, true, "Item1", new System.Drawing.Font("Arial", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Drawing Header and Item area with a custom brush.", System.Drawing.Color.Empty, 2, "2", "Header Image, Gradient Header Brush", true, true, "Item2", new System.Drawing.Font("Arial", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Disabled TaskbarItem", System.Drawing.Color.Empty, 6, "3", "Tooltip can also be provided for Disabled Items", true, false, "Item3", new System.Drawing.Font("Arial", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Header Text and Direction", System.Drawing.Color.Empty, 8, "4", "HeaderDirection and HeaderTextAlign", true, true, "Item4", new System.Drawing.Font("Arial", 8.25F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("About Syncfusion", System.Drawing.Color.Empty, 4, "5", "Syncfusion", true, true, "Item5", new System.Drawing.Font("Arial", 8.25F), 0)});
            this.taskMenuBox1.Location = new System.Drawing.Point(10, 10);
            this.taskMenuBox1.Name = "taskMenuBox1";
            this.taskMenuBox1.PADY = 2;
            this.taskMenuBox1.ShowToolTip = true;
            this.taskMenuBox1.Size = new System.Drawing.Size(186, 134);
            this.taskMenuBox1.TabIndex = 0;
            this.taskMenuBox1.Text = "Features";
            this.taskMenuBox1.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.OnTaskMenuProvideHeaderBackgroundBrush);
            this.taskMenuBox1.CollapsedStateChanged += new System.EventHandler(this.taskMenuBox1_CollapsedStateChanged);
            this.taskMenuBox1.ProvideItemsBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.OnTaskMenuProvideItemsBackgroundBrush);
            this.taskMenuBox1.ItemClick += new Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickHandler(this.xpTaskBarBox_ItemClick);
            this.taskMenuBox1.BeforeAnimation += new System.EventHandler(this.taskMenuBox1_BeforeAnimation);
            this.taskMenuBox1.AfterAnimation += new System.EventHandler(this.taskMenuBox1_AfterAnimation);
            this.taskMenuBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.taskMenuBox1_DragDrop);
            this.taskMenuBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.xpTaskMenu_Paint);
            // 
            // taskMenuBox2
            // 
            this.taskMenuBox2.BackColor = System.Drawing.Color.Transparent;
            this.taskMenuBox2.Controls.Add(this.gradientPanel2);
            this.taskMenuBox2.DrawFocusRect = false;
            this.taskMenuBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskMenuBox2.HeaderFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskMenuBox2.HeaderImageIndex = 1;
            this.taskMenuBox2.HeaderImageList = this.imageList2;
            this.taskMenuBox2.HitTaskBoxArea = false;
            this.taskMenuBox2.HotTrackColor = System.Drawing.Color.Empty;
            this.taskMenuBox2.ImageList = this.imageList1;
            this.taskMenuBox2.Location = new System.Drawing.Point(10, 149);
            this.taskMenuBox2.Name = "taskMenuBox2";
            this.taskMenuBox2.PADY = 2;
            this.taskMenuBox2.PreferredChildPanelHeight = 125;
            this.taskMenuBox2.Size = new System.Drawing.Size(186, 149);
            this.taskMenuBox2.TabIndex = 1;
            this.taskMenuBox2.Text = "Advanced Search";
            this.taskMenuBox2.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.OnTaskMenuProvideHeaderBackgroundBrush);
            this.taskMenuBox2.CollapsedStateChanged += new System.EventHandler(this.taskMenuBox1_CollapsedStateChanged);
            this.taskMenuBox2.ProvideItemsBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.OnTaskMenuProvideItemsBackgroundBrush);
            this.taskMenuBox2.ItemClick += new Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickHandler(this.xpTaskBarBox_ItemClick);
            this.taskMenuBox2.BeforeAnimation += new System.EventHandler(this.taskMenuBox1_BeforeAnimation);
            this.taskMenuBox2.AfterAnimation += new System.EventHandler(this.taskMenuBox1_AfterAnimation);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(77)))), ((int)(((byte)(143)))));
            this.gradientPanel2.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel2.Controls.Add(this.label1);
            this.gradientPanel2.Controls.Add(this.textBoxExt1);
            this.gradientPanel2.Controls.Add(this.label2);
            this.gradientPanel2.Controls.Add(this.comboBoxAdv2);
            this.gradientPanel2.Controls.Add(this.searchButtonAdv);
            this.gradientPanel2.Location = new System.Drawing.Point(2, 22);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(182, 125);
            this.gradientPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayout1.SetConstraints(this.label1, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Center, true, false, false));
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keywords:";
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(77, 23);
            this.textBoxExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt1.Location = new System.Drawing.Point(85, 10);
            this.textBoxExt1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.Size = new System.Drawing.Size(77, 23);
            this.textBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBoxExt1.TabIndex = 31;
            this.textBoxExt1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayout1.SetConstraints(this.label2, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Center, true, false, false));
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category  :";
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv2.BeforeTouchSize = new System.Drawing.Size(78, 22);
            this.comboBoxAdv2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv2.Location = new System.Drawing.Point(84, 35);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(78, 22);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv2.TabIndex = 6;
            // 
            // searchButtonAdv
            // 
            this.searchButtonAdv.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.searchButtonAdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.searchButtonAdv.BeforeTouchSize = new System.Drawing.Size(80, 23);
            this.searchButtonAdv.Font = new System.Drawing.Font("Arial", 8.25F);
            this.searchButtonAdv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.searchButtonAdv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButtonAdv.IsBackStageButton = false;
            this.searchButtonAdv.Location = new System.Drawing.Point(51, 59);
            this.flowLayout1.SetMinimumSize(this.searchButtonAdv, new System.Drawing.Size(80, 23));
            this.searchButtonAdv.Name = "searchButtonAdv";
            this.flowLayout1.SetPreferredSize(this.searchButtonAdv, new System.Drawing.Size(80, 23));
            this.searchButtonAdv.Size = new System.Drawing.Size(80, 23);
            this.searchButtonAdv.TabIndex = 7;
            this.searchButtonAdv.Text = "Search";
            this.searchButtonAdv.UseVisualStyle = true;
            // 
            // flowLayout1
            // 
            this.flowLayout1.BottomMargin = 10;
            this.flowLayout1.ContainerControl = this.gradientPanel2;
            this.flowLayout1.TopMargin = 10;
            this.flowLayout1.VGap = 2;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(689, 439);
            this.Controls.Add(this.gradientPanel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskBar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            this.gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).EndInit();
            this.gradientPanel5.ResumeLayout(false);
            this.gradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            this.gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerDirectionComboBoxAdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTextAlignmentComboBox)).EndInit();
            this.tabPageAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyComboBoxAdv)).EndInit();
            this.tabPageAdv3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPageAdv4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).EndInit();
            this.xpTaskBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskMenuBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskMenuBox2)).EndInit();
            this.taskMenuBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.propertyGrid1.SelectedObject = this.xpTaskBar1;

            //foreach(Control c in this.Controls)
            //{
            //    c.ForeColor = Color.FromArgb(21,66,139);
            //}

            headerTextAlignmentComboBox.SelectedIndex = 0;
            headerDirectionComboBoxAdv.SelectedIndex = 0;
            this.taskMenuBox1.WrapText = true;
        }

        #region XPTaskBarBackgroundbrush
        private void OnTaskMenuProvideHeaderBackgroundBrush(object sender, Syncfusion.Windows.Forms.Tools.ProvideBrushEventArgs args)
        {
            //XPTaskBarBox xBox = sender as XPTaskBarBox;            

            //Blend blend = new Blend();
            //blend.Positions = new float[] { 0.0F, 0.4F, 0.4F + 0.001F, 1.0F };
            //blend.Factors = new float[] { 0.0F, 0.5F, 1.0F, 0.5F };

            //LinearGradientBrush lgb;
            //if (!xBox.HeaderHit)
            //    lgb = new LinearGradientBrush(args.Bounds, color1, color2, LinearGradientMode.Vertical);
            //else
            //    lgb = new LinearGradientBrush(args.Bounds, color3, color4, LinearGradientMode.Vertical);

            //// if the box is collapsed.
            //if (xBox.Collapsed)
            //    lgb = new LinearGradientBrush(args.Bounds, color5, color6, LinearGradientMode.Vertical);

            //lgb.Blend = blend;
            //args.Brush = lgb;
        }

        // To draw a border around taskbarbox
        private void xpTaskMenu_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            //Rectangle itemsRect = this.taskMenuBox1.GetItemsRect();
            //itemsRect.Width -= 1;
            //itemsRect.Height -= 1;
            //e.Graphics.DrawRectangle(new Pen(color2), itemsRect);
        }

        private void OnTaskMenuProvideItemsBackgroundBrush(object sender, Syncfusion.Windows.Forms.Tools.ProvideBrushEventArgs args)
        {
            //System.Drawing.Drawing2D.Blend blend = new System.Drawing.Drawing2D.Blend();
            //blend.Factors = new float[] { 0.0f, 0.25F, 0.5f, 1.0F };
            //blend.Positions = new float[] { 0.0F, 0.25F, 0.5F, 1.0F, 1.5F };
            //// Estimate the TaskBar header bounds

            //Rectangle taskbarHeader = args.Bounds;
            //// Create and initialize the LinearGradientBrush
            //if (taskbarHeader.Height > 0)
            //{
            //    System.Drawing.Drawing2D.LinearGradientBrush lgbrush = new System.Drawing.Drawing2D.LinearGradientBrush(taskbarHeader, color7, color8, 75, true);
            //    lgbrush.Blend = blend;
            //    args.Brush = lgbrush;
            //}
        }
        #endregion //Item Background brush

        #region Item Click Event Handler
        private void xpTaskBarBox_ItemClick(object sender, Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickArgs e)
        {
            switch (e.XPTaskBarItem.Tag as string)
            {
                case "1":
                    ListViewItem listViewItem1 = new ListViewItem(new String[] { "ItemClick", "XPTaskBarItem: " + e.XPTaskBarItem.Text });
                    this.listView1.Items.Add(listViewItem1);
                    break;
                case "2":
                    ListViewItem listViewItem2 = new ListViewItem(new String[] { "ItemClick", "XPTaskBarItem: " + e.XPTaskBarItem.Text });
                    this.listView1.Items.Add(listViewItem2);
                    break;
                case "3":
                    ListViewItem listViewItem3 = new ListViewItem(new String[] { "ItemClick", "XPTaskBarItem: " + e.XPTaskBarItem.Text });
                    this.listView1.Items.Add(listViewItem3);
                    break;
                case "4":
                    ListViewItem listViewItem4 = new ListViewItem(new String[] { "ItemClick", "XPTaskBarItem: " + e.XPTaskBarItem.Text });
                    this.listView1.Items.Add(listViewItem4);
                    break;
                case "5":
                    ListViewItem listViewItem5 = new ListViewItem(new String[] { "ItemClick", "XPTaskBarItem: " + e.XPTaskBarItem.Text });
                    this.listView1.Items.Add(listViewItem5);
                    this.ShowAboutDialog();
                    break;
            }
        }
        #endregion //Item Click Event Hamdler

        #region AboutForm_Logic
        DemoCommon.AboutForm aboutForm = null;
        private void ShowAboutDialog()
        {
            aboutForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            aboutForm.ShowDialog();
        }

        private void AboutFormCloseBtnClicked(object sender, EventArgs e)
        {
            aboutForm.Close();
        }
        #endregion AboutForm_Logic

        #region Properties and Events
        private void buttonAdv1_Click(object sender, System.EventArgs e)
        {
            this.taskMenuBox1.ToggleByButton = !this.taskMenuBox1.ToggleByButton;
        }

        private void cmbcomboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.propertyComboBoxAdv.SelectedIndex == 0)
            {
                this.propertyGrid1.SelectedObject = this.xpTaskBar1;
            }
            else if (this.propertyComboBoxAdv.SelectedIndex == 1)
            {
                this.propertyGrid1.SelectedObject = this.taskMenuBox1;
            }
            else if (this.propertyComboBoxAdv.SelectedIndex == 2)
            {
                this.propertyGrid1.SelectedObject = this.taskMenuBox2;
            }
        }

        private void taskMenuBox1_BeforeAnimation(object sender, System.EventArgs e)
        {
            XPTaskBarBox box = sender as XPTaskBarBox;
            ListViewItem listViewItem = new ListViewItem(new String[] { "Before Animation", "XPTaskBarBox: " + box.Text });
            this.listView1.Items.Add(listViewItem);
        }

        private void taskMenuBox1_AfterAnimation(object sender, System.EventArgs e)
        {
            XPTaskBarBox box = sender as XPTaskBarBox;
            ListViewItem listViewItem = new ListViewItem(new String[] { "After Animation", "XPTaskBarBox: " + box.Text });
            this.listView1.Items.Add(listViewItem);
        }

        private void taskMenuBox1_CollapsedStateChanged(object sender, System.EventArgs e)
        {
            XPTaskBarBox box = sender as XPTaskBarBox;
            ListViewItem listViewItem = new ListViewItem(new String[] { "CollapsedStateChanged", "XPTaskBarBox: " + box.Text });
            this.listView1.Items.Add(listViewItem);
        }

        private void taskMenuBox1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem(new String[] { "DragDrop" });
            this.listView1.Items.Add(listViewItem);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.listView1.Items.Clear();
        }

        int count = 1;
        private void button3_Click(object sender, System.EventArgs e)
        {
            xpTaskBarBoxNew = new XPTaskBarBox();
            xpTaskBarBoxNew.HeaderImageList = this.imageList2;
            xpTaskBarBoxNew.HeaderDirection = taskMenuBox1.HeaderDirection;
            if (this.xpTaskBar1.Style == XPTaskBarStyle.Office2016Colorful)
            {
                this.xpTaskBar1.Style = XPTaskBarStyle.Office2016Colorful;
            }
            else if (this.xpTaskBar1.Style == XPTaskBarStyle.Office2016White)
            {
                this.xpTaskBar1.Style = XPTaskBarStyle.Office2016White;
            }
            else if (this.xpTaskBar1.Style == XPTaskBarStyle.Office2016DarkGray)
            {
                this.xpTaskBar1.Style = XPTaskBarStyle.Office2016DarkGray;
            }
            else if (this.xpTaskBar1.Style == XPTaskBarStyle.Office2016Black)
            { 
                this.xpTaskBar1.Style = XPTaskBarStyle.Office2016Black;
            }
            else
            {
                this.xpTaskBar1.Style = XPTaskBarStyle.Metro;
            }
            xpTaskBarBoxNew.DrawFocusRect = false;
            xpTaskBarBoxNew.ImageList = this.imageList1;
            xpTaskBarBoxNew.HeaderImageIndex = 2;
            xpTaskBarBoxNew.AllowDrop = true;

            xpTaskBarBoxNew.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
                                                                                                  new XPTaskBarItem("New Item1", System.Drawing.Color.Empty, 1, 1, "", true, true, "XPTaskBarItem0"),
                                                                                                  new XPTaskBarItem("New Item2", System.Drawing.Color.Empty, 3, 2, "", true, true, "XPTaskBarItem1"),
                                                                                                  new XPTaskBarItem("New Item3", System.Drawing.Color.Empty, 6, 3, "", true, true, "XPTaskBarItem2"),
                                                                                                  new XPTaskBarItem("New Item4", System.Drawing.Color.Empty, 5, 4, "", true, true, "XPTaskBarItem3"),
                                                                                                  new XPTaskBarItem("New Item4", System.Drawing.Color.Empty, 4, 5, "", true, true, "XPTaskBarItem4")});
            xpTaskBarBoxNew.Location = new System.Drawing.Point(0, 0);
            xpTaskBarBoxNew.Name = "xpTaskBarBox1" + count.ToString();
            xpTaskBarBoxNew.Size = new Size(188, 180);
            xpTaskBarBoxNew.TabIndex = 0;
            xpTaskBarBoxNew.Text = "New Box" + count.ToString();
            xpTaskBarBoxNew.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.OnTaskMenuProvideHeaderBackgroundBrush);
            xpTaskBarBoxNew.ProvideItemsBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.OnTaskMenuProvideItemsBackgroundBrush);
            xpTaskBarBoxNew.BeforeAnimation += new System.EventHandler(this.taskMenuBox1_BeforeAnimation);
            xpTaskBarBoxNew.AfterAnimation += new System.EventHandler(this.taskMenuBox1_AfterAnimation);
            xpTaskBarBoxNew.ItemClick += new Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickHandler(xpTaskBarBoxNew_ItemClick);
            xpTaskBarBoxNew.CollapsedStateChanged += new System.EventHandler(this.taskMenuBox1_CollapsedStateChanged);
            this.xpTaskBar1.Controls.Add(xpTaskBarBoxNew);
            count++;
        }

        private void xpTaskBarBoxNew_ItemClick(object sender, Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickArgs e)
        {
            switch (e.XPTaskBarItem.Text as string)
            {
                case "New Item1":
                    ListViewItem listViewItem1 = new ListViewItem(new String[] { "ItemClick", "XPTaskBarItem: " + e.XPTaskBarItem.Text });
                    this.listView1.Items.Add(listViewItem1);
                    break;
                case "New Item2":
                    ListViewItem listViewItem2 = new ListViewItem(new String[] { "ItemClick", "XPTaskBarItem: " + e.XPTaskBarItem.Text });
                    this.listView1.Items.Add(listViewItem2);
                    break;
                case "New Item3":
                    ListViewItem listViewItem3 = new ListViewItem(new String[] { "ItemClick", "XPTaskBarItem: " + e.XPTaskBarItem.Text });
                    this.listView1.Items.Add(listViewItem3);
                    break;
                case "New Item4":
                    ListViewItem listViewItem4 = new ListViewItem(new String[] { "ItemClick", "XPTaskBarItem: " + e.XPTaskBarItem.Text });
                    this.listView1.Items.Add(listViewItem4);
                    break;
                case "New Item5":
                    ListViewItem listViewItem5 = new ListViewItem(new String[] { "ItemClick", "XPTaskBarItem: " + e.XPTaskBarItem.Text });
                    this.listView1.Items.Add(listViewItem5);
                    this.ShowAboutDialog();
                    break;
            }
        }

        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            this.xpTaskBar1.VerticalLayout = !this.xpTaskBar1.VerticalLayout;
            this.xpTaskBar1.ColWidthOnHorizontalAlignment = (int)this.numericUpDownExt1.Value;

        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            this.xpTaskBar1.ThemesEnabled = !this.xpTaskBar1.ThemesEnabled;
        }

        private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
        {
            this.xpTaskBar1.AutoScroll = this.checkBox3.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            this.xpTaskBar1.DockPadding.All = (int)this.numericUpDown1.Value;
        }


        private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
        {
            foreach (Control ctrl in this.xpTaskBar1.Controls)
            {
                if (ctrl is XPTaskBarBox)
                {
                    XPTaskBarBox taskBarBox = (XPTaskBarBox)ctrl;
                    taskBarBox.AllowDrop = this.checkBox4.Checked;
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, System.EventArgs e)
        {
            foreach (Control ctrl in this.xpTaskBar1.Controls)
            {
                if (ctrl is XPTaskBarBox)
                {
                    XPTaskBarBox taskBarBox = (XPTaskBarBox)ctrl;
                    if (this.checkBox5.Checked)
                    {
                        taskBarBox.CollapseContent();
                    }
                    else
                    {
                        taskBarBox.ExpandContent();
                    }
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, System.EventArgs e)
        {
            foreach (Control ctrl in this.xpTaskBar1.Controls)
            {
                if (ctrl is XPTaskBarBox)
                {
                    XPTaskBarBox taskBarBox = (XPTaskBarBox)ctrl;
                    taskBarBox.ShowCollapseButton = this.checkBox7.Checked;
                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, System.EventArgs e)
        {
            foreach (Control ctrl in this.xpTaskBar1.Controls)
            {
                if (ctrl is XPTaskBarBox)
                {
                    XPTaskBarBox taskBarBox = (XPTaskBarBox)ctrl;
                    taskBarBox.ToggleByButton = this.checkBox8.Checked;
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            foreach (Control ctrl in this.xpTaskBar1.Controls)
            {
                if (ctrl is XPTaskBarBox)
                {
                    if (this.headerDirectionComboBoxAdv.SelectedIndex == 0)
                    {
                        XPTaskBarBox taskBarBox = (XPTaskBarBox)ctrl;
                        taskBarBox.HeaderDirection = Syncfusion.Windows.Forms.Tools.XPTaskBarBox.HeaderDirectionFormat.LeftToRight;
                        taskBarBox.HeaderTextAlign = StringAlignment.Near;
                        headerTextAlignmentComboBox.SelectedIndex = 0;
                    }

                    else if (this.headerDirectionComboBoxAdv.SelectedIndex == 1)
                    {
                        XPTaskBarBox taskBarBox = (XPTaskBarBox)ctrl;
                        taskBarBox.HeaderDirection = Syncfusion.Windows.Forms.Tools.XPTaskBarBox.HeaderDirectionFormat.RightToLeft;
                        taskBarBox.HeaderTextAlign = StringAlignment.Far;
                        headerTextAlignmentComboBox.SelectedIndex = 0;
                    }
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            foreach (Control ctrl in this.xpTaskBar1.Controls)
            {
                if (ctrl is XPTaskBarBox)
                {
                    XPTaskBarBox taskBarBox = (XPTaskBarBox)ctrl;
                    if (taskBarBox.HeaderDirection == XPTaskBarBox.HeaderDirectionFormat.LeftToRight)
                    {
                        if (this.headerTextAlignmentComboBox.SelectedIndex == 0)
                        {
                            taskBarBox.HeaderTextAlign = StringAlignment.Near;
                        }
                        else if (this.headerTextAlignmentComboBox.SelectedIndex == 1)
                        {
                            taskBarBox.HeaderTextAlign = StringAlignment.Center;
                        }
                        else if (this.headerTextAlignmentComboBox.SelectedIndex == 2)
                        {
                            taskBarBox.HeaderTextAlign = StringAlignment.Far;
                        }
                    }
                    else
                    {
                        if (this.headerTextAlignmentComboBox.SelectedIndex == 0)
                        {
                            taskBarBox.HeaderTextAlign = StringAlignment.Far;
                        }
                        else if (this.headerTextAlignmentComboBox.SelectedIndex == 1)
                        {
                            taskBarBox.HeaderTextAlign = StringAlignment.Center;
                        }
                        else if (this.headerTextAlignmentComboBox.SelectedIndex == 2)
                        {
                            taskBarBox.HeaderTextAlign = StringAlignment.Near;
                        }
                    }
                }
            }

        }

        private void numericUpDown2_ValueChanged(object sender, System.EventArgs e)
        {
            foreach (Control ctrl in this.xpTaskBar1.Controls)
            {
                if (ctrl is XPTaskBarBox)
                {
                    XPTaskBarBox taskBarBox = (XPTaskBarBox)ctrl;
                    taskBarBox.PADX = (int)this.numericUpDown2.Value;
                }
            }
        }

        private void numericUpDown4_ValueChanged(object sender, System.EventArgs e)
        {
            foreach (Control ctrl in this.xpTaskBar1.Controls)
            {
                if (ctrl is XPTaskBarBox)
                {
                    XPTaskBarBox taskBarBox = (XPTaskBarBox)ctrl;
                    taskBarBox.PADY = (int)this.numericUpDown4.Value;
                }
            }
        }

        private void taskMenuBox1_MouseLeave(object sender, System.EventArgs e)
        {
            this.taskMenuBox1.HeaderImageIndex = 0;
        }
        #endregion

        
        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.taskMenuBox1.Items.Sort();
        }

        private void numericUpDownExt1_ValueChanged(object sender, EventArgs e)
        {
            this.xpTaskBar1.ColWidthOnHorizontalAlignment = (int)this.numericUpDownExt1.Value;
        }

    }
}
