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

namespace CustomizationDemo
{
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
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
            string path = Application.StartupPath.ToString() + @"..\..\..\..\Introduction.rtf";
#else
            Bitmap bmp = new Bitmap(Image.FromFile(@"../../Images/App.ico"));
            string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
#endif

            this.Icon = Icon.FromHandle(bmp.GetHicon());
            this.Load += this.Form1_Load;
            if (File.Exists(path))
            {
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
            }
            this.label1.Location = new Point(this.panel1.Bounds.X, this.panel1.Bounds.Y);
            this.richTextBox1.Location = new Point(this.label1.Bounds.X, this.label1.Bounds.Y + this.label1.Height);
            this.groupBox1.Location = new Point(this.richTextBox1.Bounds.X + this.richTextBox1.Width + 10, this.label1.Bounds.Y + this.label1.Height);
        }
    }
}
