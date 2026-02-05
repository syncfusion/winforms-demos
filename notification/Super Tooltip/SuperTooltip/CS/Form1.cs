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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace SuperToolTipDemo_2005
{
	public partial class Form1 : MetroForm
	{
		public Form1 ( )
		{
			InitializeComponent();
            this.MinimumSize = this.Size;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }


            this.colorPickerUIAdv1.MoreColorsButton.Visible = false;
            this.colorPickerUIAdv1.StateButton.Visible = false;
            comboBox1.SelectedIndex = 0;
		}

		#region SuperToolTip Gradient Colors
        
        private void buttonAdv4_Click(object sender, EventArgs e)
        {
            this.colorPickerUIAdv1.UpdateControl();
            this.colorPickerUIAdv1.Invalidate(true);
            this.popupControlContainer1.Height = this.colorPickerUIAdv1.Height;// +padding;
            this.popupControlContainer1.Refresh();
            this.popupControlContainer1.Update();
            this.popupControlContainer1.Invalidate(true);
            this.Refresh();
            this.popupControlContainer1.ShowPopup(Point.Empty);
        }
#endregion

        #region SuperToolTip through Code
        // To add a toolTip through code
        Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfothroughCode = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //toolTipInfothroughCode.BackColor = Color.Bisque;
            toolTipInfothroughCode.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
                toolTipInfothroughCode.Header.Text = this.textBox1.Text;
            
                toolTipInfothroughCode.Body.Text = this.textBox2.Text;
            
                toolTipInfothroughCode.Footer.Text = this.textBox3.Text;
            
            toolTipInfothroughCode.Header.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void gradientLabel6_MouseHover(object sender, EventArgs e)
        {
            this.superToolTip1.VisualStyle = SuperToolTip.Appearance.Office2016Colorful;
            this.superToolTip1.SetToolTip(this.gradientLabel6, toolTipInfothroughCode);
        }
       #endregion
              
        #region Custom region
        // To show the tooltip in a custom location use 'PopupToolTip' event.
        // NOTE: You cannot handle this event for tooltips created through code.
        private void superToolTip1_PopupToolTip(Component component, ref Rectangle rc)
        {           
            if (component == gradientLabel5)
            {
                rc.X = rc.X - 260;
                rc.Y = rc.Y - 220;              
            }
        } 
        #endregion

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemoCommon.AboutForm abtForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            abtForm.ShowDialog();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
			{
				this.RightToLeft = RightToLeft.Yes;
                this.superToolTip1.RightToLeft = RightToLeft.Yes;
			}
            else
			{
				this.RightToLeft = RightToLeft.No;
                this.superToolTip1.RightToLeft = RightToLeft.No;
			}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Normal":
                    this.superToolTip1.Style = SuperToolTip.SuperToolTipStyle.Normal;
                    break;
                case "Balloon":
                    this.superToolTip1.Style = SuperToolTip.SuperToolTipStyle.Balloon;
                    break;
            }
        }

        private void splitContainerAdv1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void colorPickerUIAdv1_Picked_1(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo29 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            // assign the color
            toolTipInfo29.BackColor = args.Color;

            toolTipInfo29.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo29.Header.Text = "SuperToolTip with \r\nGradient Look And Feel";
            toolTipInfo29.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo29.Header.TextMargin = new System.Windows.Forms.Padding(5);
            toolTipInfo29.Body.Text = "Select a color to experience the\r\nGradient look and feel of SuperTooltip.";
            toolTipInfo29.Body.TextMargin = new System.Windows.Forms.Padding(5);
            toolTipInfo29.Footer.Text = "Appealing look and feel with various \r\ngradient colors.";
            toolTipInfo29.Footer.TextMargin = new System.Windows.Forms.Padding(5);

            // To assign the created tooltip to a control.
            
            this.superToolTip1.SetToolTip(this.buttonAdv4, toolTipInfo29);
            this.popupControlContainer1.HidePopup(PopupCloseType.Done);
        }

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016Colorful"))
            {
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Colorful;
                this.CaptionBarColor = this.MetroColor=Color.White;
                this.label6.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.label6.ForeColor = Color.Black;
                this.label6.BorderColor = Color.Black;
                this.superToolTip1.Style = SuperToolTip.SuperToolTipStyle.Office2013Style;
                this.superToolTip1.VisualStyle = SuperToolTip.Appearance.Office2016Colorful;
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                this.groupBox1.ForeColor = Color.Black;
                this.groupBox2.ForeColor = Color.Black;
                this.groupBox3.ForeColor = Color.Black;
                this.groupBox4.ForeColor = Color.Black;
                this.splitContainerAdv1.Panel2.ForeColor = Color.Black;
                //this.statusStripLabel1.ForeColor = Color.Black;
                this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel5.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel6.BackgroundColor= new Syncfusion.Drawing.BrushInfo(Color.White);
                this.statusStripEx1.VisualStyle = StatusStripExStyle.Office2016Colorful;
                this.statusStripLabel1.ForeColor = Color.Black;
                this.buttonAdv4.UseVisualStyle = true;
                this.buttonAdv4.Appearance = ButtonAppearance.Office2016Colorful;
                this.BorderColor = ColorTranslator.FromHtml("#ababab");
                this.comboBox1.Style = VisualStyle.Office2016Colorful;
                this.comboBoxAdv1.Style = VisualStyle.Office2016Colorful;
                //  this.>	SuperToolTipDemo_2005.exe!SuperToolTipDemo_2005.Form1.Form1() Line 35	C#	Symbols loaded.
                statusStripLabel1.BackColor = Color.White;
                this.textBox1.BackColor = Color.White;
                this.textBox2.BackColor = Color.White;
                this.textBox3.BackColor = Color.White;
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016White"))
            {
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016White;
                this.label6.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.CaptionBarColor =this.MetroColor= Color.White;
                this.label6.BorderColor= Color.Black;
                this.label6.ForeColor = Color.Black;
                this.superToolTip1.Style = SuperToolTip.SuperToolTipStyle.Office2013Style;
                this.superToolTip1.VisualStyle = SuperToolTip.Appearance.Office2016White;
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                this.groupBox1.ForeColor = Color.Black;
                this.groupBox2.ForeColor = Color.Black;
                this.groupBox3.ForeColor = Color.Black;
                this.groupBox4.ForeColor = Color.Black;
                this.splitContainerAdv1.Panel2.ForeColor = Color.Black;
                this.statusStripLabel1.ForeColor = Color.Black;
                //this.statusStripLabel1.BackColor = Color.White;
                this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel5.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel6.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.statusStripEx1.VisualStyle = StatusStripExStyle.Office2016White;
                this.statusStripLabel1.ForeColor = Color.Black;
                this.buttonAdv4.UseVisualStyle = true;
                this.buttonAdv4.Appearance = ButtonAppearance.Office2016White;
                this.CaptionForeColor = Color.Black;
                this.label5.ForeColor = Color.Black;
                this.BorderColor = ColorTranslator.FromHtml("#e1e1e1");
                this.comboBox1.Style = VisualStyle.Office2016White;
                this.comboBoxAdv1.Style = VisualStyle.Office2016White;
                this.textBox1.BackColor = Color.White;
                this.textBox2.BackColor = Color.White;
                this.textBox3.BackColor = Color.White;

            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016Black"))
            {
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Black;
                this.CaptionBarColor = this.MetroColor = ColorTranslator.FromHtml("#363636");
                this.CaptionForeColor = Color.White;
                this.label6.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.Black);
                this.label6.ForeColor = Color.White;
                this.superToolTip1.Style = SuperToolTip.SuperToolTipStyle.Office2013Style;
                this.superToolTip1.VisualStyle = SuperToolTip.Appearance.Office2016Black;
                this.groupBox1.ForeColor = Color.White;
                this.groupBox2.ForeColor = Color.White;
                this.groupBox3.ForeColor = Color.White;
                this.groupBox4.ForeColor = Color.White;
                this.splitContainerAdv1.Panel2.ForeColor = Color.White;
                this.label5.ForeColor = Color.White;
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                this.statusStripLabel1.ForeColor = Color.White;
                this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.Black);
                this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.Black);
                this.gradientLabel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.Black);
                this.gradientLabel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.Black);
                this.gradientLabel5.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.Black);
                this.gradientLabel6.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.Black);
                this.statusStripEx1.VisualStyle = StatusStripExStyle.Office2016Black;
                this.statusStripLabel1.ForeColor = Color.White;
                this.buttonAdv4.UseVisualStyle = true;
                this.buttonAdv4.Appearance = ButtonAppearance.Office2016Black;
                this.BorderColor = ColorTranslator.FromHtml("#5e5e5e");
                this.comboBox1.Style = VisualStyle.Office2016Black;
                this.comboBoxAdv1.Style = VisualStyle.Office2016Black;
                this.textBox1.BackColor = ColorTranslator.FromHtml("#363636");
                this.textBox2.BackColor = ColorTranslator.FromHtml("#363636");
                this.textBox3.BackColor = ColorTranslator.FromHtml("#363636");
                this.gradientLabel6.BorderColor = ColorTranslator.FromHtml("#444444");
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016DarkGray"))
            {
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016DarkGray;
                this.CaptionBarColor = this.MetroColor = ColorTranslator.FromHtml("#505050");
                this.CaptionForeColor = ColorTranslator.FromHtml("#444444");
                this.superToolTip1.Style = SuperToolTip.SuperToolTipStyle.Office2013Style;
                this.superToolTip1.VisualStyle = SuperToolTip.Appearance.Office2016DarkGray;
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.label6.BackgroundColor= new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#666666"));
                this.label6.ForeColor = ColorTranslator.FromHtml("#444444");
                this.ForeColor = ColorTranslator.FromHtml("#444444");
                this.groupBox1.ForeColor = ColorTranslator.FromHtml("#444444");
                this.groupBox2.ForeColor = ColorTranslator.FromHtml("#444444");
                this.groupBox3.ForeColor = ColorTranslator.FromHtml("#444444");
                this.groupBox4.ForeColor = ColorTranslator.FromHtml("#444444");
                this.splitContainerAdv1.Panel2.ForeColor = ColorTranslator.FromHtml("#444444");
                this.statusStripLabel1.ForeColor = ColorTranslator.FromHtml("#444444");
                this.label5.ForeColor = ColorTranslator.FromHtml("#444444");
                this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#666666"));
                this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#666666"));
                this.gradientLabel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#666666"));
                this.gradientLabel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#666666"));
                this.gradientLabel5.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#666666"));
                this.gradientLabel6.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#666666"));
                this.statusStripEx1.VisualStyle = StatusStripExStyle.Office2016DarkGray;
                this.statusStripLabel1.ForeColor = ColorTranslator.FromHtml("#444444");
                this.buttonAdv4.UseVisualStyle = true;
                this.buttonAdv4.Appearance = ButtonAppearance.Office2016DarkGray;
                this.BorderColor = ColorTranslator.FromHtml("#444444");
                this.comboBox1.Style = VisualStyle.Office2016DarkGray;
                this.comboBoxAdv1.Style = VisualStyle.Office2016DarkGray;
                this.label6.BorderColor = ColorTranslator.FromHtml("#4a4a4a");
                this.textBox1.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.textBox2.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.textBox3.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                // this.statusStripLabel1.BackColor = ColorTranslator.FromHtml("#666666");
            }
            else if(this.comboBoxAdv1.SelectedItem.ToString().Equals("Metro"))
            {
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Metro;
                this.superToolTip1.VisualStyle = SuperToolTip.Appearance.Metro;
                this.statusStripEx1.VisualStyle = StatusStripExStyle.Office2016White;
                this.CaptionBarColor = this.MetroColor = Color.White;
                this.buttonAdv4.UseVisualStyle = true;
                this.buttonAdv4.Appearance = ButtonAppearance.Metro;
                this.BorderColor = Color.White;
                this.label6.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.CaptionBarColor = Color.White;
                this.label6.BorderColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                this.groupBox1.ForeColor = Color.Black;
                this.groupBox2.ForeColor = Color.Black;
                this.groupBox3.ForeColor = Color.Black;
                this.groupBox4.ForeColor = Color.Black;
                this.splitContainerAdv1.Panel2.ForeColor = Color.Black;
                //this.statusStripLabel1.ForeColor = Color.Black;
                this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel5.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel6.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.CaptionForeColor = Color.Black;
                this.label5.ForeColor = Color.Black;
                this.comboBox1.Style = VisualStyle.Metro;
                this.comboBoxAdv1.Style = VisualStyle.Metro;
                this.textBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.textBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.textBox3.BackColor = ColorTranslator.FromHtml("#ffffff");
            }
            else if(this.comboBoxAdv1.SelectedItem.ToString().Equals("Default"))
            {
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Default;
                this.superToolTip1.VisualStyle = SuperToolTip.Appearance.Default;
                this.statusStripEx1.VisualStyle = StatusStripExStyle.Office2016White;
                this.CaptionBarColor = this.MetroColor = Color.White;
                this.buttonAdv4.UseVisualStyle = true;
                this.buttonAdv4.Appearance = ButtonAppearance.Classic;
                this.BorderColor = Color.White;
                this.label6.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.CaptionBarColor = Color.White;
                this.label6.BorderColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                this.groupBox1.ForeColor = Color.Black;
                this.groupBox2.ForeColor = Color.Black;
                this.groupBox3.ForeColor = Color.Black;
                this.groupBox4.ForeColor = Color.Black;
                this.splitContainerAdv1.Panel2.ForeColor = Color.Black;
                this.statusStripLabel1.ForeColor = Color.Black;
                this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel5.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.gradientLabel6.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.CaptionForeColor = Color.Black;
                this.label5.ForeColor = Color.Black;
                this.comboBox1.Style = VisualStyle.Default;
                this.comboBoxAdv1.Style = VisualStyle.Default;
                this.textBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.textBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.textBox3.BackColor = ColorTranslator.FromHtml("#ffffff");
            }
        }
    }
}