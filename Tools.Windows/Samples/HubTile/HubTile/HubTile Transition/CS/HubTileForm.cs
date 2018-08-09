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
            this.pulseduration.ValueChanged +=new EventHandler(pulseduration_ValueChanged);
            this.pulsescale.ValueChanged +=new EventHandler(pulsescale_ValueChanged);
            this.Text = "HubTile Transition Demo";
            this.RotateTile.BackColor = Color.White;
            this.ZoomGroupBar.SelectedItem = 0;
            this.Rotategroupbar.SelectedItem = 0;
            this.ZoomTile.TileType = HubTileType.PulsingTile;
            this.RotateTile.TileType = HubTileType.RotateTile;
            this.zoomingbtn.Click += new EventHandler(zoomingbtn_Click_1);
            this.SizeChanged += new EventHandler(HubTileForm_SizeChanged);
            this.tabControlAdv1.SelectedIndexChanged += new EventHandler(tabControlAdv1_SelectedIndexChanged);
            this.MinimumSize = this.Size;
            this.splitContainerAdv1.SplitterDistance = 400;
            this.splitContainerAdv2.SplitterDistance = 400;
            this.pulsetext.TextChanged +=new EventHandler(pulsetext_TextChanged);
            this.colorPickerButton1.ColorSelected +=new EventHandler(colorPickerButton1_ColorSelected);
        }

        void tabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                if (g.DpiX >= 120)
                {
                    this.splitContainerAdv1.SplitterDistance = this.Width - 450;
                    this.splitContainerAdv2.SplitterDistance = this.Width - 450;
                }
                else
                {
                    this.splitContainerAdv1.SplitterDistance = this.Width - 350;
                    this.splitContainerAdv2.SplitterDistance = this.Width - 350;
                }
            }
        }

        void HubTileForm_SizeChanged(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                if (g.DpiX >= 120)
                {
                    this.splitContainerAdv1.SplitterDistance = this.Width - 450;
                    this.splitContainerAdv2.SplitterDistance = this.Width - 450;
                }
                else
                {
                    this.splitContainerAdv1.SplitterDistance = this.Width - 350;
                    this.splitContainerAdv2.SplitterDistance = this.Width - 350;
                }
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
