#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace HubTileDemo_2008
{
    public partial class HubTileForm : MetroForm
    {
        public HubTileForm()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = true;
            this.defaulttile.ImageTransitionSpeed = 7;
            this.BannerTile.ImageTransitionSpeed = 7;
            this.groupBar2.SelectedItem = 0;
            this.groupBar1.SelectedItem = 0;
            this.BannerTile.TurnLiveTileOn = true;
            this.EnableTransition.Text = "Disable Transition";
            this.MinimumSize = this.Size;
            this.tabControlAdv1.SelectedIndexChanging += new SelectedIndexChangingEventHandler(tabControlAdv1_SelectedIndexChanging);
            this.BannerTile.TurnLiveTileOn = false;
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.groupBar1.GroupBarItemHeight = (int)DpiAware.LogicalToDeviceUnits(30);
                this.groupBar2.GroupBarItemHeight = (int)DpiAware.LogicalToDeviceUnits(30);
            }

        }

        void tabControlAdv1_SelectedIndexChanging(object sender, SelectedIndexChangingEventArgs args)
        {
            if (args.NewSelectedIndex == 1)
            {
                this.BannerTile.TurnLiveTileOn = true;
                this.EnableTransition.Text = "Disable Transition";
            }
            else
            {
                this.BannerTile.TurnLiveTileOn = false;
                this.EnableTransition.Text = "Enable Transition";
            }
        }
    


        #region Form Icon
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

        #region Banner Tile

        private void EnableTransition_Click(object sender, EventArgs e)
        {
            if (this.BannerTile.TurnLiveTileOn)
            {
                this.BannerTile.TurnLiveTileOn = false;
                (sender as ButtonAdv).Text = "Enable Transition";
            }
            else
            {
                this.BannerTile.TurnLiveTileOn = true;
                (sender as ButtonAdv).Text = "Disable Transition";
            }
        }

        private void DisableTransition_Click(object sender, EventArgs e)
        {
            this.BannerTile.TurnLiveTileOn = false;
            this.BannerTile.Invalidate();
        }

        private void FreezeUnFreeze_Click(object sender, EventArgs e)
        {
            if (this.BannerTile.IsFrozen)
            {
                this.BannerTile.IsFrozen = false;
                (sender as ButtonAdv).Text = "Freeze";
            }
            else
            {
                this.BannerTile.IsFrozen = true;
                (sender as ButtonAdv).Text = "UnFreeze";
            }
            this.BannerTile.Invalidate();
        }

        private void comboBoxAdv4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBoxAdv).Text == "Right To Left")
            {
                this.BannerTile.SlideTransition = TransitionDirection.RightToLeft;
            }
            else if ((sender as ComboBoxAdv).Text == "Bottom To Top")
            {
                this.BannerTile.SlideTransition = TransitionDirection.BottomToTop;
            }
            else if ((sender as ComboBoxAdv).Text == "Left To Right")
            {
                this.BannerTile.SlideTransition = TransitionDirection.LeftToRight;
            }
            else if ((sender as ComboBoxAdv).Text == "Top To Bottom")
            {
                this.BannerTile.SlideTransition = TransitionDirection.TopToBottom;
            }
            this.BannerTile.Invalidate();
        }

        private void ShowBannerIcon_Click(object sender, EventArgs e)
        {
            if (this.BannerTile.ShowBannerIcon)
            {
                this.BannerTile.ShowBannerIcon = false;
                (sender as ButtonAdv).Text = "Show Banner Icon";
            }
            else
            {
                this.BannerTile.ShowBannerIcon = true;
                (sender as ButtonAdv).Text = "Hide Banner Icon";
            }
        }

        private void HideBannerIcon_Click(object sender, EventArgs e)
        {
            this.BannerTile.ShowBannerIcon = false;
        }

        private void right_Click(object sender, EventArgs e)
        {
            this.BannerTile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BannerTile.Invalidate();
        }

        private void lef_Click(object sender, EventArgs e)
        {
            this.BannerTile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BannerTile.Invalidate();
        }

        private void RTL_Click(object sender, EventArgs e)
        {

            if (this.BannerTile.RightToLeft == System.Windows.Forms.RightToLeft.Yes)
            {
                this.BannerTile.RightToLeft = System.Windows.Forms.RightToLeft.No;
                (sender as ButtonAdv).Text = "Right To Left";
            }
            else
            {
                this.BannerTile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                (sender as ButtonAdv).Text = "Left To Right";
            }
        }

        private void left_Click(object sender, EventArgs e)
        {
            this.BannerTile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BannerTile.Invalidate();
        }

        private void bannertextcolor_ColorSelected(object sender, EventArgs e)
        {
            this.BannerTile.Banner.TextColor = (sender as ColorPickerButton).SelectedColor;
            (sender as ColorPickerButton).BackColor = (sender as ColorPickerButton).SelectedColor;
        }

        private void BannerColor_ColorSelected(object sender, EventArgs e)
        {
            this.BannerTile.BannerColor = (sender as ColorPickerButton).SelectedColor;
            (sender as ColorPickerButton).BackColor = (sender as ColorPickerButton).SelectedColor;
        }

        void bannertextbox_TextChanged(object sender, System.EventArgs e)
        {
            this.BannerTile.Banner.Text = (sender as TextBoxExt).Text;
        }


        #endregion

        #region Default Tile

        private void HoverBorderColor_ColorSelected(object sender, EventArgs e)
        {
            this.defaulttile.HoveredBorderColor = (sender as ColorPickerButton).SelectedColor;
            (sender as ColorPickerButton).BackColor = (sender as ColorPickerButton).SelectedColor;
        }

        private void titletextcolor_ColorSelected(object sender, EventArgs e)
        {
            this.defaulttile.Title.TextColor = (sender as ColorPickerButton).SelectedColor;
            (sender as ColorPickerButton).BackColor = (sender as ColorPickerButton).SelectedColor;
            this.defaulttile.Invalidate();
        }

        private void Footertextcolor_ColorSelected(object sender, EventArgs e)
        {
            this.defaulttile.Footer.TextColor = (sender as ColorPickerButton).SelectedColor;
            (sender as ColorPickerButton).BackColor = (sender as ColorPickerButton).SelectedColor;
            this.defaulttile.Invalidate();
        }

        private void righttoleft_Click(object sender, EventArgs e)
        {
            if (this.defaulttile.RightToLeft == System.Windows.Forms.RightToLeft.Yes)
            {
                this.defaulttile.RightToLeft = System.Windows.Forms.RightToLeft.No;
                (sender as ButtonAdv).Text = "Right To Left";
            }
            else
            {
                this.defaulttile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                (sender as ButtonAdv).Text = "Left To Right";
            }
            this.defaulttile.Invalidate();
        }

        private void lefttorightbtn_Click(object sender, EventArgs e)
        {
            this.defaulttile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.defaulttile.Invalidate();
        }

        private void defenabletran_Click(object sender, EventArgs e)
        {
            if (this.defaulttile.TurnLiveTileOn)
            {
                this.defaulttile.TurnLiveTileOn = false;
                (sender as ButtonAdv).Text = "Enable Transition";
            }
            else
            {
                this.defaulttile.TurnLiveTileOn = true;
                (sender as ButtonAdv).Text = "Disable Transition";
            }
        }

        private void defcmbtransis_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBoxAdv).Text == "Right To Left")
            {
                this.defaulttile.SlideTransition = TransitionDirection.RightToLeft;
            }
            else if ((sender as ComboBoxAdv).Text == "Bottom To Top")
            {
                this.defaulttile.SlideTransition = TransitionDirection.BottomToTop;
            }
            else if ((sender as ComboBoxAdv).Text == "Left To Right")
            {
                this.defaulttile.SlideTransition = TransitionDirection.LeftToRight;
            }
            else if ((sender as ComboBoxAdv).Text == "Top To Bottom")
            {
                this.defaulttile.SlideTransition = TransitionDirection.TopToBottom;
            }
        }

        private void defaultdisbtn_Click(object sender, EventArgs e)
        {
            this.defaulttile.TurnLiveTileOn = false;
        }

        private void dffreezebtn_Click(object sender, EventArgs e)
        {
            if (this.defaulttile.IsFrozen)
            {
                this.defaulttile.IsFrozen = false;
                (sender as ButtonAdv).Text = "Freeze";
            }
            else
            {
                this.defaulttile.IsFrozen = true;
                (sender as ButtonAdv).Text = "UnFreeze";

            }
        }

        void titletexttxt_TextChanged(object sender, System.EventArgs e)
        {
            this.defaulttile.Title.Text = (sender as TextBoxExt).Text;
        }

        void footertxt_TextChanged(object sender, System.EventArgs e)
        {
            this.defaulttile.Footer.Text = (sender as TextBoxExt).Text;
        }


        #endregion

        private void highlightborderbtn_ColorSelected(object sender, EventArgs e)
        {
            this.defaulttile.HoveredBorderColor = (sender as ColorPickerButton).SelectedColor;
            (sender as ColorPickerButton).BackColor = (sender as ColorPickerButton).SelectedColor;
        }

        private void expandonhover_Click(object sender, EventArgs e)
        {
            if (this.defaulttile.ExpandOnHover)
            {
                this.defaulttile.ExpandOnHover = false;
                (sender as ButtonAdv).Text = "Expand on Hover";
            }
            else
            {
                this.defaulttile.ExpandOnHover = true;
                (sender as ButtonAdv).Text = "Highlight on Hover";
            }
        }


        private void highlightbordercolor_ColorSelected(object sender, EventArgs e)
        {
            this.BannerTile.HoveredBorderColor = (sender as ColorPickerButton).SelectedColor;
            (sender as ColorPickerButton).BackColor = (sender as ColorPickerButton).SelectedColor;
        }

        private void expandhoverbtn_Click(object sender, EventArgs e)
        {
            if (this.BannerTile.ExpandOnHover)
            {
                this.BannerTile.ExpandOnHover = false;
                (sender as ButtonAdv).Text = "Expand on Hover";
            }
            else
            {
                this.BannerTile.ExpandOnHover = true;
                (sender as ButtonAdv).Text = "Highlight on Hover";
            }
        }

        private void selectioncolor_ColorSelected(object sender, EventArgs e)
        {
            this.defaulttile.SelectionMarkerColor = (sender as ColorPickerButton).SelectedColor;
            (sender as ColorPickerButton).BackColor = (sender as ColorPickerButton).SelectedColor;
        }

        private void arrowcolor_ColorSelected(object sender, EventArgs e)
        {
            this.defaulttile.SelectionArrowColor = (sender as ColorPickerButton).SelectedColor;
            (sender as ColorPickerButton).BackColor = (sender as ColorPickerButton).SelectedColor;
        }

        private void SelectionColrr_ColorSelected(object sender, EventArgs e)
        {
            this.BannerTile.SelectionMarkerColor = (sender as ColorPickerButton).SelectedColor;
            (sender as ColorPickerButton).BackColor = (sender as ColorPickerButton).SelectedColor;
        }

        private void arrowcolorbtn_ColorSelected(object sender, EventArgs e)
        {
            this.BannerTile.SelectionArrowColor = (sender as ColorPickerButton).SelectedColor;
            (sender as ColorPickerButton).BackColor = (sender as ColorPickerButton).SelectedColor;
        }

        private void HubTileForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.CreateGraphics().DpiX > 96)
            {

            }
            else
            {
                this.defaulttile.Location = new Point(34 + ((this.Width - 700) / 2), 53 + ((this.Height - 461) / 2));
                this.BannerTile.Location = new Point(34 + ((this.Width - 700) / 2), 53 + ((this.Height - 461) / 2));
            }
        }
    }
}
