#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlowLayoutExample
{
    /// <summary>
    /// UserControl to display the folder
    /// </summary>
    public partial class FolderWithName : UserControl
    {
        /// <summary>
        /// Background image
        /// </summary>
        private Image bgimage;

        /// <summary>
        /// Folder name 
        /// </summary>
        private string foldername;

        /// <summary>
        /// Creates an instance for <see cref="FolderWithName"/>
        /// </summary>
        public FolderWithName()
        {
            InitializeComponent();
        }
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED              
        //        return cp;
        //    }
        //}
        /// <summary>
        /// OnMouseEnter override
        /// </summary>
        /// <param name="e">EventArgs</param>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = ColorTranslator.FromHtml("#b9dcff");
        }

        /// <summary>
        /// On Mouse leave
        /// </summary>
        /// <param name="e">EventArgs</param>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = Color.White;
        }

        /// <summary>
        /// Size changed
        /// </summary>
        /// <param name="e">EventArgs</param>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Invalidate();
            //this.Refresh();
        }


        /// <summary>
        /// Paint override
        /// </summary>
        /// <param name="e">Paint EventArgs</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Size textSize = TextRenderer.MeasureText(this.FolderName, this.Font); 
            Rectangle imgrect = new Rectangle(0, 5, this.Width - 20, this.Height - textSize.Height - 10);
            e.Graphics.DrawImage(FolderImage, imgrect);
            StringFormat sf = new StringFormat();
            sf.FormatFlags = StringFormatFlags.NoWrap;
            int x = (this.Width - textSize.Width) / 2;
            if (textSize.Width>this.Width)
            {
                x = 10;
            }
            e.Graphics.DrawString(this.FolderName, this.Font, new SolidBrush(Color.Black), new Rectangle(x, imgrect.Y + imgrect.Height, this.Width - 20, 20), sf);
        }

        /// <summary>
        /// Gets or sets the image 
        /// </summary>
        public Image FolderImage
        {
            get
            {
                return this.bgimage;
            }
            set
            {
                this.bgimage = value;
                this.Invalidate();

            }
        }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string FolderName
        {
            get
            {
                return this.foldername;
            }
            set
            {
                this.foldername = value;
            }
        }
    }
}
