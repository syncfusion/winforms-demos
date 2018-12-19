using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace RatingCustomizationDemo
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.panel4.Visible = false;
            this.checkBoxAdv2.Visible = false;
            this.ratingControl7.ResetButtonSettings.Paint += new PaintEventHandler(ResetButton_Paint);
            this.ratingControl7.ResetButtonSettings.Click += new EventHandler(ResetButton_Click);
            this.ratingControl7.ValueChanging+=new Syncfusion.Windows.Forms.Tools.ValueChangingEventHandler(ratingControl7_ValueChanging);
            using (Graphics g = CreateGraphics())
            {
                if (g.DpiX > 96)
                {
                    this.ratingControl7.Size = new Size(497, 28);
                    this.ratingControl7.ResetButtonSettings.Size = new Size(24, 16);
                }
            }
            this.Icon = new Icon("..//..//icon_Zov_icon.ico");
            this.MetroColor = Color.White;
            this.textBoxExt4.ScrollBars = ScrollBars.Vertical;
            this.ratingControl7.Style = Syncfusion.Windows.Forms.Tools.RatingControl.Styles.Office2016Colorful;
            this.skinManager1.VisualTheme = VisualTheme.Office2016Colorful;
            this.Backcolorchange(Color.White, Color.Black);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
        }
        void ResetButton_Paint(object sender, PaintEventArgs e)
        {
            if (ratingControl7.Style == Syncfusion.Windows.Forms.Tools.RatingControl.Styles.Office2016Black)
            {
                SolidBrush br = new SolidBrush(ColorTranslator.FromHtml("#000000"));
                e.Graphics.FillRectangle(br, e.ClipRectangle);
            }
            else if (ratingControl7.Style == Syncfusion.Windows.Forms.Tools.RatingControl.Styles.Office2016DarkGray)
            {
                SolidBrush br = new SolidBrush(ColorTranslator.FromHtml("#5a5a5a"));
                e.Graphics.FillRectangle(br, e.ClipRectangle);
            }
            else
            {
                SolidBrush br = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(br, e.ClipRectangle);
            }

            e.Graphics.DrawImage(this.ratingControl7.ResetButtonSettings.BackgroundImage, e.ClipRectangle);
            
        }
       
        void ResetButton_Click(object sender, EventArgs e)
        {
            this.textBoxExt4.Text = this.textBoxExt4.Text + Environment.NewLine + "Reset Button Clicked";
        }

        void ratingControl7_ValueChanging(object sender, Syncfusion.Windows.Forms.Tools.ValueChangingEventArgs args)
        {
            this.textBoxExt4.Text =this.textBoxExt4.Text +Environment.NewLine+ "Rating Control value changed to :" + args.Value;
        }
        private void buttonAdv7_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemSelectionColor = this.buttonAdv7.BackColor;
        }

        private void buttonAdv8_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemSelectionColor = this.buttonAdv8.BackColor;
        }

        private void buttonAdv9_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemSelectionColor = this.buttonAdv9.BackColor;
        }

        private void buttonAdv10_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemSelectionColor = this.buttonAdv10.BackColor;
        }

        private void buttonAdv11_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemSelectionColor = this.buttonAdv11.BackColor;
        }

        private void buttonAdv12_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemSelectionColor = this.buttonAdv12.BackColor;
        }

        private void buttonAdv6_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemHighlightColor = this.buttonAdv6.BackColor;
        }

        private void buttonAdv5_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemHighlightColor = this.buttonAdv5.BackColor;
        }

        private void buttonAdv4_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemHighlightColor = this.buttonAdv4.BackColor;
        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemHighlightColor = this.buttonAdv3.BackColor;
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemHighlightColor = this.buttonAdv2.BackColor;
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.ratingControl7.ItemHighlightColor = this.buttonAdv1.BackColor;
        }

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            this.ratingControl7.ReadOnly = this.checkBoxAdv1.Checked;
        }

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            this.ratingControl7.ApplyGradientColors = this.checkBoxAdv2.Checked;
            this.panel4.Visible = !this.checkBoxAdv2.Checked;
        }

        ScrollersFrame scroll = new ScrollersFrame();
        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.panel4.Visible = false;

            this.checkBoxAdv2.Visible = false;
            switch (comboBoxAdv2.SelectedIndex)
            {
                case 0:
                    {
                        this.checkBoxAdv2.Enabled =true;
                        this.ratingControl7.ResetButton.BackColor = SystemColors.Control;
                        this.ratingControl7.Style = Syncfusion.Windows.Forms.Tools.RatingControl.Styles.Default;
                        //this.skinManager1.VisualTheme = VisualTheme.;
                        this.comboBoxAdv1.Style = this.comboBoxAdv2.Style = this.comboBoxAdv3.Style = this.comboBoxAdv4.Style = this.comboBoxAdv5.Style = this.comboBoxAdv6.Style = VisualStyle.Default;
                        this.panel4.Visible = true;
                        this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Default;
                        this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Default;
                        foreach (Control ctrl in this.panel4.Controls)
                        {
                            if (ctrl is ButtonAdv)
                            {
                                (ctrl as ButtonAdv).UseVisualStyle = true;
                                (ctrl as ButtonAdv).UseVisualStyleBackColor = true;
                            }                        
                        }
                        this.Backcolorchange(Color.White, Color.Black);
                        this.checkBoxAdv2.Visible = true;
                    }
                    break;
                case 1:
                    {
                        this.ratingControl7.ResetButton.BackColor = Color.FromArgb(22,165,220);
                        this.ratingControl7.Style = Syncfusion.Windows.Forms.Tools.RatingControl.Styles.Metro;
                        this.skinManager1.VisualTheme = VisualTheme.Metro;
                        this.Backcolorchange(Color.White, Color.Black);
                        this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                        this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                    }
                    break;
                case 2:
                    {                    
                        this.ratingControl7.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.OfficeColorSchemes.Blue;
                        this.ratingControl7.Style = Syncfusion.Windows.Forms.Tools.RatingControl.Styles.Office2007;
                        this.skinManager1.VisualTheme = VisualTheme.Office2007Blue;
                        this.Backcolorchange(Color.White, Color.Black);
                        this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007;
                        this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007;

                    }
                    break;
                case 3:
                    {                       
                        this.ratingControl7.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.OfficeColorSchemes.Blue;
                        this.ratingControl7.Style = Syncfusion.Windows.Forms.Tools.RatingControl.Styles.Office2010;
                        this.skinManager1.VisualTheme = VisualTheme.Office2010Silver;
                        this.Backcolorchange(Color.White, Color.Black);
                        this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2010;
                        this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2010;

                    }
                    break;
                case 4:
                    {                                        
                        this.ratingControl7.Style = Syncfusion.Windows.Forms.Tools.RatingControl.Styles.Office2016Colorful;
                        this.skinManager1.VisualTheme = VisualTheme.Office2016Colorful;
                        this.Backcolorchange(Color.White, Color.Black);
                        this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                        this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;

                    }

                    break;
                case 5:
                    {                                          
                        this.ratingControl7.Style = Syncfusion.Windows.Forms.Tools.RatingControl.Styles.Office2016DarkGray;
                        this.skinManager1.VisualTheme = VisualTheme.Office2016DarkGray;
                        this.Backcolorchange(Color.FromArgb(90, 90, 90), Color.White);
                        this.ratingControl7.ResetButtonSettings.BackColor = Color.FromArgb(90,90,90);
                        this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                        this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                        //this.textBoxExt4.ScrollBars = 

                    }

                    break;
                case 6:
                    {                                         
                        this.ratingControl7.Style = Syncfusion.Windows.Forms.Tools.RatingControl.Styles.Office2016White;
                        this.skinManager1.VisualTheme = VisualTheme.Office2016White;
                        this.Backcolorchange(Color.White, Color.Black);
                        this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                        this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    }

                    break;
                case 7:
                    {                                               
                        this.ratingControl7.Style = Syncfusion.Windows.Forms.Tools.RatingControl.Styles.Office2016Black;
                        this.Backcolorchange(ColorTranslator.FromHtml("#262626"), Color.White);
                        this.skinManager1.VisualTheme = VisualTheme.Office2016Black;
                        this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                        this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;

                    }
                    break;
                                  
            }
        }
        private void Backcolorchange(Color backColor, Color foreColor)
        {

            this.gradientPanel2.ForeColor = foreColor;
            this.gradientPanel2.BackColor = backColor;
            this.gradientPanel3.ForeColor = foreColor;
            this.gradientPanel3.BackColor = backColor;
            this.gradientPanel4.ForeColor = foreColor;
            this.gradientPanel4.BackColor = backColor;
            this.gradientPanel5.ForeColor = foreColor;
            this.gradientPanel5.BackColor = backColor;
            this.autoLabel1.ForeColor = foreColor;
            this.CaptionForeColor = foreColor;
            this.CaptionButtonColor = foreColor;
            this.MetroColor = backColor;
            this.BackColor = backColor;
            if (comboBoxAdv2.SelectedIndex == 0 || comboBoxAdv2.SelectedIndex == 1 || comboBoxAdv2.SelectedIndex == 2 || comboBoxAdv2.SelectedIndex == 3)
            {
                this.autoLabel1.BackColor = backColor;
                this.autoLabel18.BackColor = Color.Gainsboro;

            }
            else
            {
                this.autoLabel1.BackColor = backColor;
            }
            this.CaptionBarColor = backColor;
            this.autoLabel26.BackColor = backColor;
            this.autoLabel18.BackColor = backColor;
            this.checkBoxAdv1.BackColor = backColor;
            this.checkBoxAdv2.BackColor = backColor;
            this.checkBoxAdv1.ForeColor = foreColor;
            this.checkBoxAdv2.ForeColor = foreColor;

        }
        private void comboBoxAdv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxAdv3.SelectedIndex)
            {
                case 0:
                    this.ratingControl7.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.OfficeColorSchemes.Blue;
                    break;
                case 1:
                    this.ratingControl7.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.OfficeColorSchemes.Silver;
                    break;
                case 2:
                    this.ratingControl7.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.OfficeColorSchemes.Black;
                    break;
                case 3:
                    this.ratingControl7.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.OfficeColorSchemes.Managed;
                    break;
            }
        }
        private void comboBoxAdv4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxAdv4.SelectedIndex)
            {
                case 0:
                    this.ratingControl7.Shape = Syncfusion.Windows.Forms.Tools.Shapes.Star;
                    break;
                case 1:
                    this.ratingControl7.Shape = Syncfusion.Windows.Forms.Tools.Shapes.Diamond;
                    break;
                case 2:
                    this.ratingControl7.Shape = Syncfusion.Windows.Forms.Tools.Shapes.Circle;
                    break;
                case 3:
                    this.ratingControl7.Shape = Syncfusion.Windows.Forms.Tools.Shapes.Triangle;
                    break;
                case 4:
                    this.ratingControl7.Shape = Syncfusion.Windows.Forms.Tools.Shapes.Kite;
                    break;
                case 5:
                    this.ratingControl7.Shape = Syncfusion.Windows.Forms.Tools.Shapes.Heart;
                    break;
            }
        }

        private void comboBoxAdv5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxAdv5.SelectedIndex)
            {
                case 0:
                    this.ratingControl7.ItemsCount = 1;
                    break;
                case 1:
                    this.ratingControl7.ItemsCount = 2;
                    break;
                case 2:
                    this.ratingControl7.ItemsCount = 3;
                    break;
                case 3:
                    this.ratingControl7.ItemsCount = 4;
                    break;
                case 4:
                    this.ratingControl7.ItemsCount = 5;
                    break;
                case 5:
                    this.ratingControl7.ItemsCount = 6;
                    break;
                case 6:
                    this.ratingControl7.ItemsCount = 7;
                    break;
                case 7:
                    this.ratingControl7.ItemsCount = 8;
                    break;
                case 8:
                    this.ratingControl7.ItemsCount = 9;
                    break;
            }
        }

        private void comboBoxAdv6_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxAdv6.SelectedIndex)
            {
                case 0:
                    this.ratingControl7.ItemBorderWeight = 1;
                    break;
                case 1:
                    this.ratingControl7.ItemBorderWeight = 2;
                    break;
                case 2:
                    this.ratingControl7.ItemBorderWeight = 3;
                    break;
            }
        }
    }
}
