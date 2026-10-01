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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace GettingStarted
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.MetroColor = Color.White;
            Office2007Colors.ApplyManagedColors(this, Color.Red);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ratingControl2.ResetButton.BackColor = Color.White;
            this.ratingControl3.ResetButtonSettings.BackColor = Color.White;
            this.ratingControl4.ResetButtonSettings.BackColor = Color.White;
            using (Graphics g = CreateGraphics())
            {
                if (g.DpiX > 96)
                {
                    this.ratingControl2.Size = new Size(197, 28);
                    this.ratingControl3.Size = new Size(404, 28);
                    this.ratingControl4.Size = new Size(197, 28);
                    this.ratingControl2.ResetButtonSettings.Size = new Size(24, 16);
                    this.ratingControl3.ResetButtonSettings.Size = new Size(24, 16);
                    this.ratingControl4.ResetButtonSettings.Size = new Size(24, 16);
                }
            }
            
            #region Events
            this.ratingControl2.ResetButtonSettings.MouseEnter += new EventHandler(ResetButton_MouseEnter);
            this.ratingControl2.ResetButtonSettings.MouseLeave += new EventHandler(ResetButton_MouseLeave);
            this.ratingControl3.ResetButtonSettings.MouseEnter += new EventHandler(ResetButton_MouseEnter);
            this.ratingControl3.ResetButtonSettings.MouseLeave += new EventHandler(ResetButton_MouseLeave);
            this.ratingControl4.ResetButtonSettings.MouseEnter += new EventHandler(ResetButton_MouseEnter);
            this.ratingControl4.ResetButtonSettings.MouseLeave += new EventHandler(ResetButton_MouseLeave);
            this.ratingControl2.ResetButtonSettings.Paint += new PaintEventHandler(ResetButton_Paint);
            this.ratingControl3.ResetButtonSettings.Paint += new PaintEventHandler(ResetButton_Paint);
            this.ratingControl4.ResetButtonSettings.Paint += new PaintEventHandler(ResetButton_Paint);
            this.ratingControl2.ValueChanging += new Syncfusion.Windows.Forms.Tools.ValueChangingEventHandler(ratingControl2_ValueChanging);
            this.ratingControl3.ValueChanging += new Syncfusion.Windows.Forms.Tools.ValueChangingEventHandler(ratingControl3_ValueChanging);
            #endregion
            this.Icon = new Icon("icon_Zov_icon.ico");
            this.MetroColor = Color.White;
        }
        #region RatingEvents
        void ratingControl3_ValueChanging(object sender, Syncfusion.Windows.Forms.Tools.ValueChangingEventArgs args)
        {
            if (args.Value == 1)
                this.ratingControl3.ToolTipSettings.Body.Text = "10%";
            else if (args.Value == 2)
                this.ratingControl3.ToolTipSettings.Body.Text = "20%";
            else if (args.Value == 3)
                this.ratingControl3.ToolTipSettings.Body.Text = "30%";
            else if (args.Value == 4)
                this.ratingControl3.ToolTipSettings.Body.Text = "40%";
            else if (args.Value == 5)
                this.ratingControl3.ToolTipSettings.Body.Text = "50%";
            else if (args.Value == 6)
                this.ratingControl3.ToolTipSettings.Body.Text = "60%";
            else if (args.Value == 7)
                this.ratingControl3.ToolTipSettings.Body.Text = "70%";
            else if (args.Value == 8)
                this.ratingControl3.ToolTipSettings.Body.Text = "80%";
            else if (args.Value == 9)
                this.ratingControl3.ToolTipSettings.Body.Text = "90%";
            else if (args.Value == 10)
                this.ratingControl3.ToolTipSettings.Body.Text = "100%";
        }

        void ratingControl2_ValueChanging(object sender, Syncfusion.Windows.Forms.Tools.ValueChangingEventArgs args)
        {
            if (args.Value == 1)
                this.ratingControl2.ToolTipSettings.Body.Text = "Poor";
            else if (args.Value == 2)
                this.ratingControl2.ToolTipSettings.Body.Text = "Bad";
            else if (args.Value == 3)
                this.ratingControl2.ToolTipSettings.Body.Text = "Average";
            else if (args.Value == 4)
                this.ratingControl2.ToolTipSettings.Body.Text = "Good";
            else if (args.Value == 5)
                this.ratingControl2.ToolTipSettings.Body.Text = "Excellent";
        }
        void ResetButton_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush br = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(br, e.ClipRectangle);
            if (ismouseover)
            {
                e.Graphics.DrawImage(this.ratingControl2.ResetButtonSettings.BackgroundImage, e.ClipRectangle);
            }
            else
            {
                e.Graphics.DrawImage(this.ratingControl2.ResetButtonSettings.BackgroundImage, e.ClipRectangle);
            }
            
            br.Dispose();
            
        }
        bool ismouseover = false;
        void ResetButton_MouseLeave(object sender, EventArgs e)
        {
            ismouseover = false;
            this.ratingControl2.ResetButtonSettings.BackgroundImage = global::GettingStarted.Properties.Resources._02;
        }

        void ResetButton_MouseEnter(object sender, EventArgs e)
        {
            ismouseover = true;
            this.ratingControl2.ResetButtonSettings.BackgroundImage = global::GettingStarted.Properties.Resources._01;
        }
        #endregion
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
    }
}
