#region Copyright Syncfusion Inc. 2001-2018.
//-------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="syncfusion">
//  Copyright (c) Syncfusion Inc. 2001 - 2019. All rights reserved.
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
// </copyright>
//-------------------------------------------------------------------------------------------------
#endregion

namespace GettingStarted
{
    using System.Drawing;
    using Syncfusion.WinForms.Controls;

    /// <summary>
    /// Represents a class that is used to design the context menu.
    /// </summary>
    public partial class Form1 : SfForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
#if NETCORE
            Bitmap bmp = new Bitmap(Image.FromFile(@"../../../Images/App.ico"));
#else
            Bitmap bmp = new Bitmap(Image.FromFile(@"../../Images/App.ico"));
#endif
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            this.Load += this.Form1_Load;
            this.comboBoxAdv1.Location = new Point(this.label2.Bounds.X + this.label2.Width, this.label2.Bounds.Y);
            this.panel2.Location = new Point(this.label1.Bounds.X, this.label1.Bounds.Y + this.label1.Height);
        }
    }
}
