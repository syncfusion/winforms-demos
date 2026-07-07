#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.ListView;
using Syncfusion.WinForms.ListView.Enums;

namespace HeaderFooter
{
    #region Custom textBox
    internal class CustomHeaderUserControl : Panel
    {
        /// <summary>
        /// The picture box control.
        /// </summary>
        internal PictureBox pictureBox = new PictureBox();

        /// <summary>
        /// The SfListView control.
        /// </summary>
        internal SfListView ListView;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomHeaderUserControl"/>.
        /// </summary>
        internal CustomHeaderUserControl(SfListView listView)
        {
            this.ListView = listView;
            TextBox = new TextBox();
            TextBox.AutoSize = false;
            TextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Controls.Add(TextBox);
            pictureBox.Image = Image.FromFile(@"Icon/search_Colorful.png");
            this.TextBox.TextAlign = HorizontalAlignment.Left;
            this.TextBox.Margin = new Padding(10, 0, 0, 0);
            this.TextBox.Controls.Add(pictureBox);
            TextBox.TextChanged += OnTextBoxTextChanged;
            ListView.MouseDown += OnDropDownListViewMouseDown;
            ListView.SizeChanged += OnDropDownSizeChanged;
            ListView.VerticalScroll.ScrollBar.VisibleChanged += OnScrollBarVisibleChanged;
            ListView.View.Filter = FilterItem;
        }

        /// <summary>
        /// Gets or sets the textbox control value.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal TextBox TextBox { get; set; }

        /// <summary>
        /// Occurs when mouse down on the list view control.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">A mouse event arguments.</param>
        void OnDropDownListViewMouseDown(object sender, MouseEventArgs e)
        {
            ListView.Focus();
        }

        /// <summary>
        /// Occurs while scroll bar visibility changed in the this.ListView.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">A event data.</param>
        private void OnScrollBarVisibleChanged(object sender, EventArgs e)
        {
            if (this.ListView.VerticalScroll.ScrollBar.Visible)
            {
                if (this.ListView.HeaderControl != null && this.ListView.HeaderControl.Width == this.ListView.Width)
                {
                    this.ListView.HeaderControl.Width -= this.ListView.VerticalScroll.ScrollBar.Width;
                }

                if (this.ListView.FooterControl != null && this.ListView.FooterControl.Width == this.ListView.Width)
                {
                    this.ListView.FooterControl.Width -= this.ListView.VerticalScroll.ScrollBar.Width;
                }
            }
            else
            {
                if (this.ListView.HeaderControl != null)
                    this.ListView.HeaderControl.Width = this.ListView.Width;

                if (this.ListView.FooterControl != null)
                    this.ListView.FooterControl.Width = this.ListView.Width;
            }
        }

        /// <summary>
        /// Occurs while size changed in the this.ListView.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">A event data.</param>
        private void OnDropDownSizeChanged(object sender, EventArgs e)
        {
            this.Width = this.ListView.Size.Width - 14;
        }

        /// <summary>
        /// Occurs while text value changed in textbox item in the customTextBox control.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">A event data.</param>
        private void OnTextBoxTextChanged(object sender, EventArgs e)
        {
            this.ListView.View.RefreshFilter();
        }

        /// <summary>
        /// Creates a filter condition based on the customTextBox value.
        /// </summary>
        /// <param name="data">The value.</param>
        /// <returns>Return the boolean value.</returns>
        private bool FilterItem(object data)
        {
            if ((data as USState).LongName.ToLower().Contains(this.TextBox.Text.ToLower()))
                return true;
            return false;
        }

        /// <summary>
        /// Occurs while back color changed.
        /// </summary>
        /// <param name="e">A event data.</param>
        protected override void OnBackColorChanged(EventArgs e)
        {
            this.TextBox.BackColor = this.BackColor;
            base.OnBackColorChanged(e);
        }

        /// <summary>
        /// Occurs while fore color changed.
        /// </summary>
        /// <param name="e">A event data.</param>
        protected override void OnForeColorChanged(EventArgs e)
        {
            this.TextBox.ForeColor = this.ForeColor;
            base.OnForeColorChanged(e);
        }

        /// <summary>
        /// Occurs while size changed.
        /// </summary>
        /// <param name="e">A event data.</param>
        protected override void OnSizeChanged(EventArgs e)
        {
            this.TextBox.Width = this.Size.Width - 1;
            this.TextBox.Height = this.Size.Height - 1;
            this.pictureBox.Height = this.pictureBox.Image.Height;
            this.pictureBox.Width = this.pictureBox.Image.Width;
            this.TextBox.Location = new Point(0, 0);

            if (this.RightToLeft != System.Windows.Forms.RightToLeft.Yes)
                this.pictureBox.Location = new Point(this.TextBox.Width - this.pictureBox.Width - 4, 1);
            else
            {
                this.pictureBox.Location = new Point(1, 1);
            }

            base.OnSizeChanged(e);
        }

        /// <summary>
        /// Occurs while RightToLeft property changed.
        /// </summary>
        /// <param name="e">A event data.</param>
        protected override void OnRightToLeftChanged(EventArgs e)
        {
            if (this.RightToLeft != System.Windows.Forms.RightToLeft.Yes)
                this.pictureBox.Location = new Point(this.TextBox.Width - this.pictureBox.Width - 4, 0);
            else
                this.pictureBox.Location = new Point(0, 0);

            base.OnRightToLeftChanged(e);
        }

        /// <summary>
        /// Overrides the paint.
        /// </summary>
        /// <param name="e">A <see cref="PaintEventArgs"/> value.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, ColorTranslator.FromHtml("#7A7A7A"), ButtonBorderStyle.Solid);
        }
    }

    #endregion
}
