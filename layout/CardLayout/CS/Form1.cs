#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardLayout_Example
{
    public partial class Form1 : SfForm
    {
        public Form1()
        {
            InitializeComponent();
            this.autoLabel1.Text = this.cardLayout1.SelectedCard;
            this.MinimumSize = new Size(800, this.panelTop.Height + this.Imagespanel.Height + (int)DpiAware.LogicalToDeviceUnits(100));
            InitializeLayout();
            this.SizeChanged += Form1_SizeChanged;
            
        }
        
        private void InitializeLayout()
        {
            this.Imagespanel.Height = this.Angles_demons.Height + (int)DpiAware.LogicalToDeviceUnits(60);
            this.panelTop.Height = this.ClientRectangle.Height - this.Imagespanel.Height - this.Autolabelpanel.Height;
            this.Autolabelpanel.Location = new Point(0, this.panelTop.Location.Y + panelTop.Height);
            this.Autolabelpanel.Width = this.ClientRectangle.Width;
            this.Autolabelpanel.Height = this.autoLabel1.Height;
            int centre = (this.ClientRectangle.Width) / 2;
            int panelcentre = (this.panelTop.Height) / 2;
            this.previousButton.Location = new Point(previousButton.Location.X, panelTop.Location.Y + panelcentre);
            this.nextButton.Location = new Point(nextButton.Location.X, panelTop.Location.Y + panelcentre);
            int autolableHalf = this.autoLabel1.Width / 2;
            this.autoLabel1.Location = new Point(centre - autolableHalf, 0);

            this.Angles_demons.Location = new Point(20, this.Angles_demons.Location.Y);
            this.Battleship.Location = new Point(this.Angles_demons.Location.X + this.Angles_demons.Width + 20, this.Battleship.Location.Y);
            this.DarkKnight.Location = new Point(this.Battleship.Location.X + this.Battleship.Width + 20, this.DarkKnight.Location.Y);
            this.Darkness.Location = new Point(this.DarkKnight.Location.X + this.DarkKnight.Width + 20, this.Darkness.Location.Y);
            this.Holmes.Location = new Point(this.Darkness.Location.X + this.Darkness.Width + 20, this.Holmes.Location.Y);
            this.LOW.Location = new Point(this.Holmes.Location.X + this.Holmes.Width + 20, this.LOW.Location.Y);
            this.Miserables.Location = new Point(this.LOW.Location.X + this.LOW.Width + 20, this.Miserables.Location.Y);
            this.Pirates.Location = new Point(this.Miserables.Location.X + this.Miserables.Width + 20, this.Pirates.Location.Y);
            this.Twilight.Location = new Point(this.Pirates.Location.X + this.Pirates.Width + 20, this.Twilight.Location.Y);
            this.IronMan_3.Location = new Point(this.Twilight.Location.X + this.Twilight.Width + 20, this.IronMan_3.Location.Y);
            this.Oblivion.Location = new Point(this.IronMan_3.Location.X + this.IronMan_3.Width + 20, this.Oblivion.Location.Y);
            this.IdentityThief.Location = new Point(this.Oblivion.Location.X + this.Oblivion.Width + 20, this.IdentityThief.Location.Y);
            this.TheCroods.Location = new Point(this.IdentityThief.Location.X + this.IdentityThief.Width + 20, this.TheCroods.Location.Y);

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            InitializeLayout();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.cardLayout1.Next();
            this.autoLabel1.Text = this.cardLayout1.SelectedCard;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            this.cardLayout1.Previous();
            this.autoLabel1.Text = this.cardLayout1.SelectedCard;
        }

        private void CardLayoutDisplay(string cardName)
        {
            this.cardLayout1.Show(cardName);
            this.autoLabel1.Text = this.cardLayout1.SelectedCard;
        }

        private void angles_demons_Click(object sender, EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void battleship_Click(object sender, EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void DarkKnight_Click(object sender, EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void Darkness_Click(object sender, EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void Holmes_Click(object sender, EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void LOW_Click(object sender, EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void Miserables_Click(object sender, EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void Pirates_Click(object sender, EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void twilight_Click(object sender, EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void IronMan_3_Click(object sender, EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void Oblivion_Click(object sender, EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void IdentityThief_Click(object sender, EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void TheCroods_Click(object sender, EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void TheCroods_GotFocus(object sender, System.EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void IdentityThief_GotFocus(object sender, System.EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void Oblivion_GotFocus(object sender, System.EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void IronMan_3_GotFocus(object sender, System.EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void Twilight_GotFocus(object sender, System.EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void Pirates_GotFocus(object sender, System.EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void Miserables_GotFocus(object sender, System.EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void LOW_GotFocus(object sender, System.EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void Holmes_GotFocus(object sender, System.EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void Darkness_GotFocus(object sender, System.EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void DarkKnight_GotFocus(object sender, System.EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void Angles_demons_GotFocus(object sender, System.EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

        private void Battleship_GotFocus(object sender, System.EventArgs e)
        {
            string cardName = (sender as Button).Name;
            CardLayoutDisplay(cardName);
        }

    }
}


