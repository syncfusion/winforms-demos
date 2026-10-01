#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace CustomOffice2007Colors_2005
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            CustomOffice2007Colors();
            //this.propertyGrid1.SelectedObject = Office2007Colors.Default;
            this.richTextBox1.ReadOnly = false;
            this.barItem11.Click += new EventHandler(barItem11_Click);
            this.barItem5.Click += new EventHandler(barItem5_Click);
            this.barItem6.Click += new EventHandler(barItem6_Click);
            this.barItem7.Click += new EventHandler(barItem7_Click);
            this.barItem8.Click += new EventHandler(barItem8_Click);
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
        }

        DemoCommon.AboutForm aboutForm = null;
        void barItem6_Click(object sender, EventArgs e)
        {
            aboutForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            aboutForm.ShowDialog();
        }

        void barItem8_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Redo();
        }

        void barItem7_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        void barItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void barItem11_Click(object sender, EventArgs e)
        {
            if (!this.barItem11.Checked)
            {
                this.barItem11.Checked = true;
                this.groupBar1.Visible = true;
            }
            else
            {
                this.barItem11.Checked = false;
                this.groupBar1.Visible = false;
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

        Office2007Colors colors = Office2007Colors.Default;
        private void CustomOffice2007Colors()
        {
            colors.BarItemCheckBorderColor = Color.FromArgb(64, 64, 0);
            colors.BarItemCheckDarkColor = Color.DarkGoldenrod;
            colors.BarItemCheckFlashColor = Color.FromArgb(192, 192, 0);
            colors.BarItemCheckLightColor = Color.FromArgb(253, 241, 176);
            colors.BarItemHighlightBorderColor = Color.FromArgb(185, 160, 116);
            colors.BarItemPressBorderColor = Color.FromArgb(64, 64, 0);
            colors.BarItemPressDarkColor = Color.Olive;
            colors.BarItemPressFlashColor = Color.White;
            colors.BarItemPressLightColor = Color.FromArgb(255, 192, 128);
            colors.BarItemSelectFlashColor = Color.White;
            colors.BarItemSeparatorColor = Color.Olive;

            colors.ComboButtonBorder = Color.White;
            colors.ComboButtonDarkColor = Color.Olive;
            colors.ComboButtonHighlightBorder = Color.FromArgb(192, 192, 0);
            colors.ComboButtonHighlightDarkColor = Color.FromArgb(192, 192, 0);
            colors.ComboButtonHighlightLightColor = Color.FromArgb(255, 252, 217);
            colors.ComboButtonLightColor = Color.FromArgb(192, 192, 0);
            colors.ComboButtonPressBorder = Color.FromArgb(192, 192, 0);
            colors.ComboButtonPressDarkColor = Color.Olive;
            colors.ComboButtonPressLightColor = Color.Khaki;

            colors.CommandBarBorderColor = Color.FromArgb(64,64,0);
            colors.CommandBarDarkColor = Color.Olive;
            colors.CommandBarLightColor = Color.Khaki;

            colors.DockBarBackColor = Color.DarkKhaki;
            colors.DropDownBarItemBorderColor = Color.FromArgb(158, 130, 85);
            colors.DropDownBarItemDarkColor = Color.Olive;
            colors.DropDownBarItemLightColor = Color.FromArgb(234, 207, 178);
            colors.DropDownDarkColor = Color.Olive;
            colors.DropDownHighlightDarkColor = Color.DarkKhaki;
            colors.DropDownHighlightLightColor = Color.FromArgb(255, 248, 237);
            colors.DropDownLightColor = Color.FromArgb(255, 255, 192);
            colors.DropDownPressedDarkColor = Color.FromArgb(255, 255, 192);
            colors.DropDownPressedLightColor = Color.Olive;

            colors.FloatBackgroundColor = Color.Olive;
            colors.FloatBorderColor = Color.FromArgb(64, 64, 0);
            colors.FloatCaptionColor = Color.White;
            colors.FloatCommandBarDarkColor = Color.Khaki;
            colors.FloatCommandBarLightColor = Color.Khaki;
            colors.FloatHighlightButtonBorderColor = Color.Olive;
            colors.FloatHighlightButtonColor = Color.FromArgb(192, 192, 0);
            colors.FloatLightBorderColor = Color.White;
            colors.FloatPressButtonBorderColor = Color.FromArgb(64, 64, 0);
            colors.FloatPressButtonColor = Color.White;
            colors.FloatPressCloseButtonBorderColor = Color.FromArgb(64, 64, 0);
            colors.FloatPressCloseButtonColor = Color.FromArgb(192, 192, 0);

            colors.GroupBarBorderColor = Color.FromArgb(64, 64, 0);
            colors.GroupBarHighlightColorDark = Color.Brown;
            colors.GroupBarHighlightColorLight = Color.White;
            colors.GroupBarItemColorDark = Color.Olive;
            colors.GroupBarItemColorLight = Color.White;
            colors.GroupBarItemTextColor = Color.White;
            colors.GroupBarSelectedColorDark = Color.FromArgb(255, 217, 112);
            colors.GroupBarSelectedColorLight = Color.FromArgb(255, 227, 149);
            colors.GroupBarSelectedHighlightColorDark = Color.DarkGray;
            colors.GroupBarSelectedHighlightColorLight = Color.Gainsboro;
            colors.GroupBarSelectedTopColorDark = Color.FromArgb(255, 238, 184);
            colors.GroupBarSelectedTopColorLight = Color.FromArgb(255, 250, 217);

            colors.MenuBorderColor = Color.FromArgb(64, 64, 0);
            colors.MenuCheckedBorderColor = Color.FromArgb(64, 64, 0);
            colors.MenuCheckedColor = Color.White;
            colors.MenuCheckedFillColor = Color.Olive;
            colors.MenuColumnColor = Color.White;
            colors.MenuColumnSeparatorColor = Color.White;
            colors.MenuComboButtonArrowColor = Color.White;
            colors.MenuComboButtonHighlightDarkColor = Color.FromArgb(64, 64, 0);
            colors.MenuComboButtonHighlightLightColor = Color.FromArgb(192, 192, 0);
            colors.MenuComboButtonPushed1Color = Color.Olive;
            colors.MenuComboButtonPushed2Color = Color.Olive;
            colors.MenuComboButtonPushed3Color = Color.FromArgb(64, 64, 0);
            colors.MenuComboButtonPushed4Color = Color.FromArgb(64, 64, 64);
            colors.MenuItemArrowDarkColor = Color.White;
            colors.MenuItemArrowLightColor = Color.White;
            colors.MenuItemBorderColor = Color.FromArgb(150, 175, 142, 180);
            colors.MenuItemDarkColor = Color.Olive;
            colors.MenuSeparatorColor = Color.Khaki;
            colors.MenuTextBoxBackColor = Color.FromArgb(234, 242, 251);
            colors.MenuTextBoxBorderColor = Color.FromArgb(179, 199, 225);
            colors.TextBarItemBackColor = Color.White;
            colors.TextBarItemBorderColor = Color.FromArgb(192, 192, 0);
            colors.TextBarItemBorderHighlightColor = Color.FromArgb(64, 64, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath.ToString() + @"..\..\..\Text.rtf";
            if (File.Exists(path))
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);

        }
    }
}