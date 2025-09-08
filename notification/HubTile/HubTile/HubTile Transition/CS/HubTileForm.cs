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
            this.Load += HubTileForm_Load1;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = true;
            this.pulseduration.ValueChanged +=new EventHandler(pulseduration_ValueChanged);
            this.pulsescale.ValueChanged +=new EventHandler(pulsescale_ValueChanged);
            this.Text = "HubTile Transition Demo";
            this.RotateTile.BackColor = Color.White;
            this.ZoomGroupBar.SelectedItem = 0;
            this.Rotategroupbar.SelectedItem = 0;
            this.ZoomTile.TileType = HubTileType.PulsingTile;
            this.RotateTile.TileType = HubTileType.RotateTile;
            this.zoomingbtn.Click += new EventHandler(zoomingbtn_Click_1);
            this.MinimumSize = this.Size;
            this.splitContainerAdv1.SplitterDistance = 400;
            this.splitContainerAdv2.SplitterDistance = 400;
            this.pulsetext.TextChanged +=new EventHandler(pulsetext_TextChanged);
            this.colorPickerButton1.ColorSelected +=new EventHandler(colorPickerButton1_ColorSelected);
        }

        private void HubTileForm_Load1(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(830, 505);
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Size = new System.Drawing.Size(272, 289);
            this.panel5.Location = new System.Drawing.Point(0, 25);
            this.panel5.Size = new System.Drawing.Size(272, 289);
            this.right.Location = new System.Drawing.Point(64, 145);
            this.right.Size = new System.Drawing.Size(144, 23);
            this.lef.Location = new System.Drawing.Point(64, 197);
            this.lef.Size = new System.Drawing.Size(144, 23);
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Size = new System.Drawing.Size(830, 39);
            this.panel14.Location = new System.Drawing.Point(0, 39);
            this.panel14.Size = new System.Drawing.Size(830, 466);
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Size = new System.Drawing.Size(830, 466);
            this.PulsingTilePage.Location = new System.Drawing.Point(1, 40);
            this.PulsingTilePage.Size = new System.Drawing.Size(827, 424);
            this.splitContainerAdv1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdv1.Size = new System.Drawing.Size(827, 424);
            this.splitContainerAdv1.SplitterDistance = 492;
            this.splitContainerAdv1.SplitterWidth = 1;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Size = new System.Drawing.Size(490, 422);
            this.ZoomTile.Location = new System.Drawing.Point(162, 118);
            this.ZoomTile.Margin = new System.Windows.Forms.Padding(1);
            this.ZoomTile.MinimumSize = new System.Drawing.Size(100, 100);
            this.ZoomGroupBar.Location = new System.Drawing.Point(0, 0);
            this.ZoomGroupBar.Size = new System.Drawing.Size(332, 422);
            this.panel7.Location = new System.Drawing.Point(0, 30);
            this.panel7.Size = new System.Drawing.Size(332, 392);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Size = new System.Drawing.Size(332, 392);
            this.zoomingbtn.Location = new System.Drawing.Point(64, 254);
            this.zoomingbtn.Size = new System.Drawing.Size(215, 31);
            this.pulsescale.Location = new System.Drawing.Point(189, 197);
            this.pulsescale.Size = new System.Drawing.Size(92, 25);
            this.pulseduration.Location = new System.Drawing.Point(189, 152);
            this.pulseduration.Size = new System.Drawing.Size(92, 25);
            this.label6.Location = new System.Drawing.Point(63, 205);
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label5.Location = new System.Drawing.Point(63, 155);
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.frzbtn.Location = new System.Drawing.Point(64, 307);
            this.frzbtn.Size = new System.Drawing.Size(215, 32);
            this.colorPickerButton1.Location = new System.Drawing.Point(187, 100);
            this.colorPickerButton1.Size = new System.Drawing.Size(94, 30);
            this.label14.Location = new System.Drawing.Point(63, 106);
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.pulsetext.Location = new System.Drawing.Point(189, 52);
            this.pulsetext.Size = new System.Drawing.Size(92, 25);
            this.label4.Location = new System.Drawing.Point(63, 56);
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.panel12.Location = new System.Drawing.Point(0, 422);
            this.panel12.Size = new System.Drawing.Size(304, 0);
            this.RotateTilePage.Location = new System.Drawing.Point(1, 40);
            this.RotateTilePage.Size = new System.Drawing.Size(827, 424);
            this.splitContainerAdv2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdv2.Size = new System.Drawing.Size(827, 424);
            this.splitContainerAdv2.SplitterDistance = 520;
            this.splitContainerAdv2.SplitterWidth = 1;
            this.RotateTile.Location = new System.Drawing.Point(92, 101);
            this.RotateTile.Margin = new System.Windows.Forms.Padding(1);
            this.RotateTile.MinimumSize = new System.Drawing.Size(100, 100);
            this.RotateTile.Size = new System.Drawing.Size(199, 189);
            this.Rotategroupbar.Location = new System.Drawing.Point(0, 0);
            this.Rotategroupbar.Size = new System.Drawing.Size(304, 422);
            this.panel8.Location = new System.Drawing.Point(0, 30);
            this.panel8.Size = new System.Drawing.Size(304, 362);
            this.numericUpDownExt1.Location = new System.Drawing.Point(171, 272);
            this.numericUpDownExt1.Size = new System.Drawing.Size(107, 25);
            this.rotatespeed.Location = new System.Drawing.Point(49, 274);
            this.rotatespeed.Size = new System.Drawing.Size(98, 17);
            this.flipmode.Location = new System.Drawing.Point(171, 218);
            this.flipmode.Size = new System.Drawing.Size(107, 25);
            this.rotatemode.Location = new System.Drawing.Point(50, 222);
            this.rotatemode.Size = new System.Drawing.Size(96, 17);
            this.freezebtn.Location = new System.Drawing.Point(51, 151);
            this.freezebtn.Size = new System.Drawing.Size(227, 29);
            this.enablerotate.Location = new System.Drawing.Point(53, 80);
            this.enablerotate.Size = new System.Drawing.Size(225, 29);
            this.panel9.Location = new System.Drawing.Point(0, 422);
            this.panel9.Size = new System.Drawing.Size(304, 0);
            this.rotatetiletxt.Location = new System.Drawing.Point(153, 164);
            this.rotatetiletxt.Size = new System.Drawing.Size(115, 25);
            this.showtilebannerbtn.Location = new System.Drawing.Point(50, 108);
            this.showtilebannerbtn.Size = new System.Drawing.Size(218, 29);
            this.label8.Location = new System.Drawing.Point(47, 166);
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.comboBoxAdv3.Location = new System.Drawing.Point(116, 181);
            this.comboBoxAdv3.Size = new System.Drawing.Size(137, 21);
            this.comboBoxAdv2.Location = new System.Drawing.Point(116, 133);
            this.comboBoxAdv2.Size = new System.Drawing.Size(137, 21);
            this.comboBoxAdv1.Location = new System.Drawing.Point(116, 93);
            this.comboBoxAdv1.Size = new System.Drawing.Size(137, 21);
            this.defcmbtransis.Location = new System.Drawing.Point(163, 179);
            this.defcmbtransis.Size = new System.Drawing.Size(123, 21);
            this.comboBoxAdv4.Location = new System.Drawing.Point(165, 146);
            this.comboBoxAdv4.Size = new System.Drawing.Size(119, 21);
            this.comboBoxAdv5.Location = new System.Drawing.Point(106, 84);
            this.comboBoxAdv5.Size = new System.Drawing.Size(133, 21); 
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.enablerotate.Height = (int)DpiAware.LogicalToDeviceUnits(this.enablerotate.Height);
                this.zoomingbtn.Height = (int)DpiAware.LogicalToDeviceUnits(this.zoomingbtn.Height);
                this.freezebtn.Height = (int)DpiAware.LogicalToDeviceUnits(this.freezebtn.Height);
                this.frzbtn.Height = (int)DpiAware.LogicalToDeviceUnits(this.frzbtn.Height);
                this.zoomingbtn.Location = new Point(this.zoomingbtn.Location.X, this.zoomingbtn.Location.Y + 30);
                this.frzbtn.Location = new Point(this.frzbtn.Location.X, this.frzbtn.Location.Y + 50);
                this.rotatetiletxt.Location = new Point(this.label8.Width + this.label8.Location.X + 10, this.rotatetiletxt.Location.Y);
                this.rotatetiletxt.Width = this.label8.Width;
                this.showtilebannerbtn.Height = (int)DpiAware.LogicalToDeviceUnits(this.showtilebannerbtn.Height) - 5;
                this.Rotategroupbar.GroupBarItemHeight = (int)DpiAware.LogicalToDeviceUnits(30);
                this.ZoomGroupBar.GroupBarItemHeight = (int)DpiAware.LogicalToDeviceUnits(30);
                this.colorPickerButton1.Size = new Size(this.label4.Width, (int)DpiAware.LogicalToDeviceUnits(this.colorPickerButton1.Height) - 5);
                this.colorPickerButton1.Location = new Point(this.label4.Width + this.label4.Location.X + 20, this.colorPickerButton1.Location.Y);
                this.pulsetext.Location = new Point(this.label4.Width + this.label4.Location.X + 20, this.pulsetext.Location.Y);
                this.pulsetext.Width = this.label4.Width; this.pulseduration.Location = new Point(this.label4.Width + this.label4.Location.X + 20, this.pulseduration.Location.Y);
                this.pulseduration.Width = this.label4.Width;
                this.pulsescale.Location = new Point(this.label4.Width + this.label4.Location.X + 20, this.pulsescale.Location.Y);
                this.pulsescale.Width = this.label4.Width;
                this.flipmode.Location = new Point(this.rotatemode.Width + this.rotatemode.Location.X + 10, this.flipmode.Location.Y);
                this.flipmode.Width = this.rotatemode.Width;
                this.numericUpDownExt1.Width = this.rotatespeed.Width;
                this.numericUpDownExt1.Location = new Point(this.rotatemode.Width + this.rotatemode.Location.X + 10, this.numericUpDownExt1.Location.Y);
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

        #region ZoomTile

        private void zoomtrk_ValueChanged(object sender, EventArgs e)
        {
            this.ZoomTile.PulseDuration = (sender as TrackBarEx).Value;
        }

        private void pulseduration_ValueChanged(object sender, EventArgs e)
        {
            if ((int)this.pulseduration.Value > 0)
                this.ZoomTile.PulseDuration = (int)this.pulseduration.Value;
            else
                this.ZoomTile.PulseDuration = 1;
        }

        private void pulsescale_ValueChanged(object sender, EventArgs e)
        {
            this.ZoomTile.PulseScale = (int)this.pulsescale.Value;
        }

        void pulsetext_TextChanged(object sender, System.EventArgs e)
        {
            this.ZoomTile.Footer.Text = (sender as TextBoxExt).Text;
        }
       
        private void zoomingbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void disablezoomingbtn_Click(object sender, EventArgs e)
        {
            this.ZoomTile.TileType = HubTileType.DefaultTile;
        }

        private void frzbtn_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region RotateTile

        private void rotatetilespd_ValueChanged(object sender, EventArgs e)
        {
            if ((sender as TrackBarEx).Value > 0)
                this.RotateTile.RotationTransitionSpeed = (sender as TrackBarEx).Value;
            else
                this.RotateTile.RotationTransitionSpeed = 1;
        }

        private void enablerotate_Click(object sender, EventArgs e)
        {
            if (this.RotateTile.TileType != HubTileType.RotateTile)
            {
                this.RotateTile.TileType = HubTileType.RotateTile;
                (sender as ButtonAdv).Text = "Disable Rotate";
            }
            else
            {
                this.RotateTile.TileType = HubTileType.DefaultTile;
                (sender as ButtonAdv).Text = "Enable Rotate";
            }
        }

        private void disablerotate_Click(object sender, EventArgs e)
        {
            this.RotateTile.TileType = HubTileType.DefaultTile;
        }

        private void freezebtn_Click(object sender, EventArgs e)
        {
            if (this.RotateTile.IsFrozen)
            {
                this.RotateTile.IsFrozen = false;
                (sender as ButtonAdv).Text = "Freeze";
            }
            else
            {
                this.RotateTile.IsFrozen = true;
                (sender as ButtonAdv).Text = "UnFreeze";
            }
        }

        private void flipmode_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBoxAdv).Text == "Horizontal")
            {
                this.RotateTile.RotationTransition = TileFlipDirection.Horizontal;
            }
            else if ((sender as ComboBoxAdv).Text == "Vertical")
            {
                this.RotateTile.RotationTransition = TileFlipDirection.Vertical;
            }
        }

        private void rotatespd_SelectedValueChanged(object sender, EventArgs e)
        {
            this.RotateTile.RotationTransitionSpeed = int.Parse((sender as ComboBoxAdv).Text);
        }

        void rotatetiletxt_TextChanged(object sender, System.EventArgs e)
        {
            this.RotateTile.Banner.Text = (sender as TextBoxExt).Text;
        }

        private void showtilebannerbtn_Click(object sender, EventArgs e)
        {
            if (this.RotateTile.ShowRotateTileBanner)
            {
                this.RotateTile.ShowRotateTileBanner = false;
                (sender as ButtonAdv).Text = "Show Rotate Tile Banner";
            }
            else
            {
                this.RotateTile.ShowRotateTileBanner = true;
                (sender as ButtonAdv).Text = "Hide Rotate Tile Banner";
            }
            this.RotateTile.Banner.Text = this.rotatetiletxt.Text;
        }

        private void hidetilebanner_Click(object sender, EventArgs e)
        {
            this.RotateTile.ShowRotateTileBanner = false;
        }

        #endregion

        #region Docking Logic

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.ZoomTile.Footer.TextColor = (sender as ColorPickerButton).SelectedColor;
            (sender as ColorPickerButton).BackColor = (sender as ColorPickerButton).SelectedColor;
            this.ZoomTile.Invalidate();
        }


        private void HubTileForm_Load(object sender, EventArgs e)
        {
            this.ZoomTile.Location = new Point(34 + ((this.Width - 700) / 2), 53 + ((this.Height - 461) / 2));

            this.RotateTile.Location = new Point(34 + ((this.Width - 700) / 2), 53 + ((this.Height - 461) / 2));
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
                this.ZoomTile.Location = new Point(34 + ((this.Width - 700) / 2), 53 + ((this.Height - 461) / 2));
                this.RotateTile.Location = new Point(34 + ((this.Width - 700) / 2), 53 + ((this.Height - 461) / 2));
            }

        }

        private void splitContainerAdv1_SplitterMoving(object sender, Syncfusion.Windows.Forms.Tools.Events.SplitterMoveEventArgs e)
        {
           
        }

        private void splitContainerAdv1_StyleChanged(object sender, EventArgs e)
        {
            if (this.splitContainerAdv1.SplitterDistance < this.Width / 2)
            {
                this.splitContainerAdv1.SplitterDistance = this.Width / 2;
            }
        }

        #endregion

        private void numericUpDownExt1_ValueChanged(object sender, EventArgs e)
        {
            this.RotateTile.RotationTransitionSpeed = (int)(sender as NumericUpDownExt).Value;
        }

        private void zoomingbtn_Click_1(object sender, EventArgs e)
        {
            if (this.ZoomTile.TileType == HubTileType.PulsingTile)
            {
                this.ZoomTile.TileType = HubTileType.DefaultTile;
                (sender as ButtonAdv).Text = "Enable Zoom";
            }
            else
            {
                this.ZoomTile.TileType = HubTileType.PulsingTile;
                (sender as ButtonAdv).Text = "Disable Zoom";
            }
        }

        private void frzbtn_Click_1(object sender, EventArgs e)
        {
           
        }

        private void frzbtn_Click_2(object sender, EventArgs e)
        {
            if (this.ZoomTile.IsFrozen)
            {
                this.ZoomTile.IsFrozen = false;
                (sender as ButtonAdv).Text = "Freeze";
            }
            else
            {
                this.ZoomTile.IsFrozen = true;
                (sender as ButtonAdv).Text = "UnFreeze";
            }
        }

    }
}
