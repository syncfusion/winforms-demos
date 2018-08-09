using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace RatingPrecisionDemo
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ratingControl8.ValueChanged += new Syncfusion.Windows.Forms.Tools.RatingValueChangedEventHandler(ratingControl8_ValueChanged);
            this.ratingControl8.ResetButtonSettings.MouseEnter+=new EventHandler(ResetButton_MouseEnter);
            this.ratingControl8.ResetButtonSettings.MouseLeave += new EventHandler(ResetButton_MouseLeave);
            this.ratingControl8.ResetButtonSettings.Paint += new PaintEventHandler(ResetButton_Paint);
            using (Graphics g = CreateGraphics())
            {
                if (g.DpiX > 96)
                {
                    this.ratingControl8.Size = new Size(297, 28);
                    this.ratingControl8.ResetButtonSettings.Size = new Size(24, 16);
                }
            }
            this.Icon = new Icon("..//..//icon_Zov_icon.ico");
            this.MetroColor = Color.White;
        }

        void ratingControl8_ValueChanged(object sender, Syncfusion.Windows.Forms.Tools.RatingValueChangedEventArgs args)
        {
           this.comboBoxAdv7.Text = null;
           this.comboBoxAdv7.Text = (args.Value).ToString();
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

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxAdv1.SelectedIndex)
            {
                case 0:
                    {
                        this.ratingControl8.Location = new Point(136, 188);
                        this.ratingControl8.Orientation = Syncfusion.Windows.Forms.Tools.Orientationmode.Horizontal;
                    }
                    break;
                case 1:
                    {
                        this.ratingControl8.Location = new Point(196,150);
                        this.ratingControl8.Orientation = Syncfusion.Windows.Forms.Tools.Orientationmode.Vertical;
                    }
                    break;
            }
        }

        private void comboBoxAdv5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxAdv5.SelectedIndex)
            {
                case 0:
                    {
                        this.ratingControl8.Precision = Syncfusion.Windows.Forms.Tools.PrecisionMode.Standard;
                        this.comboBoxAdv7.Items.Clear();
                        this.comboBoxAdv7.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
                    }
                    break;
                case 1:
                    {
                        this.ratingControl8.Precision = Syncfusion.Windows.Forms.Tools.PrecisionMode.Half;
                        this.comboBoxAdv7.Items.Clear();
                        this.comboBoxAdv7.Items.AddRange(new object[] {"0.5", "1","1.5", "2","2.5", "3","3.5", "4","4.5", "5" });
                    }
                    break;

            }
            this.comboBoxAdv7.Text = this.ratingControl8.Value.ToString();
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.ratingControl8.Reset();
        }
        void ResetButton_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush br = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(br, e.ClipRectangle);
            if (ismouseover)
            {
                e.Graphics.DrawImage(this.ratingControl8.ResetButtonSettings.BackgroundImage, e.ClipRectangle);
            }
            else
            {
                e.Graphics.DrawImage(this.ratingControl8.ResetButtonSettings.BackgroundImage, e.ClipRectangle);
            }

            br.Dispose();

        }
        bool ismouseover = false;
        void ResetButton_MouseLeave(object sender, EventArgs e)
        {
            ismouseover = false;
            this.ratingControl8.ResetButtonSettings.BackgroundImage = global::RatingPrecisionDemo.Properties.Resources._02;
        }

        void ResetButton_MouseEnter(object sender, EventArgs e)
        {
            ismouseover = true;
            this.ratingControl8.ResetButtonSettings.BackgroundImage = global::RatingPrecisionDemo.Properties.Resources._01;
        }

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            this.ratingControl8.ResetButton.Visible= checkBoxAdv1.Checked;
            this.ratingControl8.ResetButtonSettings.Visible = this.checkBoxAdv1.Checked;
            this.ratingControl8.Refresh();
        }

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            this.ratingControl8.ShowTooltip = this.checkBoxAdv2.Checked;
        }

        private void comboBoxAdv6_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxAdv6.SelectedIndex)
            {
                case 0:
                    this.ratingControl8.DrawMode = Syncfusion.Windows.Forms.Tools.Drawmodes.Default;
                    break;
                case 1:
                    this.ratingControl8.DrawMode = Syncfusion.Windows.Forms.Tools.Drawmodes.Stretch;
                    break;
            }
        }

        private void comboBoxAdv7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAdv5.SelectedIndex == 0)
            {
                switch (comboBoxAdv7.SelectedIndex)
                {
                    case 0:
                        this.ratingControl8.Value = 1;
                        break;
                    case 1:
                        this.ratingControl8.Value = 2;
                        break;
                    case 2:
                        this.ratingControl8.Value = 3;
                        break;
                    case 3:
                        this.ratingControl8.Value = 4;
                        break;
                    case 4:
                        this.ratingControl8.Value = 5;
                        break;
                }
            }
            else
            {
                switch (comboBoxAdv7.SelectedIndex)
                {
                    case 0:
                        this.ratingControl8.Value = 0.5F;
                        break;
                    case 1:
                        this.ratingControl8.Value = 1;
                        break;
                    case 2:
                        this.ratingControl8.Value = 1.5F;
                        break;
                    case 3:
                        this.ratingControl8.Value = 2;
                        break;
                    case 4:
                        this.ratingControl8.Value = 2.5F;
                        break;
                    case 5:
                        this.ratingControl8.Value = 3;
                        break;
                    case 6:
                        this.ratingControl8.Value = 3.5F;
                        break;
                    case 7:
                        this.ratingControl8.Value = 4;
                        break;
                    case 8:
                        this.ratingControl8.Value = 4.5F;
                        break;
                    case 9:
                        this.ratingControl8.Value = 5;
                        break;
                }
            }
        }
    }
}
