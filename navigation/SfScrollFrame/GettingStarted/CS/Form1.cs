#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace GettingStarted
{
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Form constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            CreateListView();
            SetCustomScrollBarColor();
            WireEvents();
        }

        #endregion

        /// <summary>
        /// Creates the list view for display the items.
        /// </summary>
        private void CreateListView()
        {
            // Set the view to show details.
            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("Order ID",(int)DpiAware.LogicalToDeviceUnits(100f), HorizontalAlignment.Left);
            listView1.Columns.Add("Customer ID", (int)DpiAware.LogicalToDeviceUnits(100f), HorizontalAlignment.Left);
            listView1.Columns.Add("Order Date", (int)DpiAware.LogicalToDeviceUnits(150f), HorizontalAlignment.Left);
            listView1.Columns.Add("Product Name", (int)DpiAware.LogicalToDeviceUnits(150f), HorizontalAlignment.Left);
            listView1.Columns.Add("Quantity", (int)DpiAware.LogicalToDeviceUnits(100f), HorizontalAlignment.Left);
            listView1.Columns.Add("ShipCountry", (int)DpiAware.LogicalToDeviceUnits(100f), HorizontalAlignment.Left);
            listView1.Columns.Add("UnitPrice", (int)DpiAware.LogicalToDeviceUnits(100f), HorizontalAlignment.Left);
            listView1.Columns.Add("ContactNumber", (int)DpiAware.LogicalToDeviceUnits(100f), HorizontalAlignment.Left);


            List<OrderInfo> OrderInfoList = new OrderInfoCollection().GetListOrdersDetails(100);
            foreach (OrderInfo order in OrderInfoList)
            {
                ListViewItem listItem = new ListViewItem(order.OrderID.ToString());
                listItem.SubItems.Add(order.CustomerID.ToString());
                listItem.SubItems.Add(order.OrderDate.ToString());
                listItem.SubItems.Add(order.ProductName.ToString());
                listItem.SubItems.Add(order.Quantity.ToString());
                listItem.SubItems.Add(order.ShipCountry.ToString());
                listItem.SubItems.Add(order.UnitPrice.ToString());
                listItem.SubItems.Add(order.ContactNumber.ToString());
                listView1.Items.Add(listItem);
            }
        }

        #region Sample Customization

        /// <summary>
        /// Customize the default scrollbar colors.
        /// </summary>
        private void SetCustomScrollBarColor()
        {
            sfScrollFrame1.Style.VerticalScrollBar.ArrowButtonBackColor = ColorTranslator.FromHtml("#999999");
            sfScrollFrame1.Style.VerticalScrollBar.ArrowButtonHoverBackColor = ColorTranslator.FromHtml("#999999");
            sfScrollFrame1.Style.VerticalScrollBar.ArrowButtonPressedBackColor = ColorTranslator.FromHtml("#C4C4C4");
            sfScrollFrame1.Style.VerticalScrollBar.ScrollBarBackColor = ColorTranslator.FromHtml("#575757");
            sfScrollFrame1.Style.VerticalScrollBar.ThumbColor = ColorTranslator.FromHtml("#999999");
            sfScrollFrame1.Style.VerticalScrollBar.ArrowButtonForeColor = ColorTranslator.FromHtml("#303030");
            sfScrollFrame1.Style.VerticalScrollBar.ArrowButtonBorderColor = ColorTranslator.FromHtml("#3A3A3A");
            sfScrollFrame1.Style.VerticalScrollBar.ThumbBorderColor = ColorTranslator.FromHtml("#3A3A3A");
            sfScrollFrame1.Style.VerticalScrollBar.ThumbHoverColor = ColorTranslator.FromHtml("#B3B3B3");
            sfScrollFrame1.Style.VerticalScrollBar.ThumbPressedColor = ColorTranslator.FromHtml("#C4C4C4");

            sfScrollFrame1.Style.HorizontalScrollBar.ArrowButtonBackColor = ColorTranslator.FromHtml("#999999");
            sfScrollFrame1.Style.HorizontalScrollBar.ArrowButtonHoverBackColor = ColorTranslator.FromHtml("#999999");
            sfScrollFrame1.Style.HorizontalScrollBar.ArrowButtonPressedBackColor = ColorTranslator.FromHtml("#C4C4C4");
            sfScrollFrame1.Style.HorizontalScrollBar.ScrollBarBackColor = ColorTranslator.FromHtml("#575757");
            sfScrollFrame1.Style.HorizontalScrollBar.ThumbColor = ColorTranslator.FromHtml("#999999");
            sfScrollFrame1.Style.HorizontalScrollBar.ArrowButtonForeColor = ColorTranslator.FromHtml("#303030");
            sfScrollFrame1.Style.HorizontalScrollBar.ArrowButtonBorderColor = ColorTranslator.FromHtml("#3A3A3A");
            sfScrollFrame1.Style.HorizontalScrollBar.ThumbBorderColor = ColorTranslator.FromHtml("#3A3A3A");
            sfScrollFrame1.Style.HorizontalScrollBar.ThumbHoverColor = ColorTranslator.FromHtml("#B3B3B3");
            sfScrollFrame1.Style.HorizontalScrollBar.ThumbPressedColor = ColorTranslator.FromHtml("#C4C4C4");
        }

        /// <summary>
        /// Wire the necessary events
        /// </summary>
        private void WireEvents()
        {
            btnArrowButtonBackColor.ColorSelected += btnArrowButtonBackColor_Click;
            btnArrowButtonForeColor.ColorSelected += btnArrowButtonForeColor_Click;
            btnArrowButtonHoverForeColor.ColorSelected += btnArrowButtonHoverForeColor_Click;
            btnArrowButtonHoverBackColor.ColorSelected += btnArrowButtonHoverBackColor_Click;
            btnArrowButtonPressedBackColor.ColorSelected += btnArrowButtonPressedBackColor_Click;
            btnArrowButtonPressedForeColor.ColorSelected += btnArrowButtonPressedForeColor_Click;
            btnThumbColor.ColorSelected += btnThumbColor_Click;
            btnThumbHoverColor.ColorSelected += btnThumbHoverColor_Click;
            btnThumbPressedColor.ColorSelected += btnThumbPressedColor_Click;
            btnScrollBarBackColor.ColorSelected += btnScrollBarBackColor_Click;


            btnVerticalArrowBackColor.ColorSelected += btnVerticalArrowBackColor_Click;
            btnVerticalArrowForeColor.ColorSelected += btnVerticalArrowForeColor_Click;
            btnVerticalArrowHoverBackColor.ColorSelected += btnVerticalArrowHoverBackColor_Click;
            btnVerticalArrowHoverForeColor.ColorSelected += btnVerticalArrowHoverForeColor_Click;
            btnVerticalThumbHoverColor.ColorSelected += btnVerticalThumbHoverColor_Click;
            btnVerticalThumbColor.ColorSelected += btnVerticalThumbColor_Click;
            btnVerticalThumbPressedColor.ColorSelected += btnVerticalThumbPressedColor_Click;
            btnVerticalScrollBarBackColor.ColorSelected += btnVerticalScrollBarBackColor_Click;
            btnVerticalArrowPressedForeColor.ColorSelected += btnVerticalArrowPressedForeColor_Click;
            btnVerticalArrowPressedBackColor.ColorSelected += btnVerticalArrowPressedBackColor_Click;
        }

        /// <summary>
        /// Wire the necessary events
        /// </summary>
        private void UnWireEvents()
        {
            btnArrowButtonBackColor.ColorSelected -= btnArrowButtonBackColor_Click;
            btnArrowButtonForeColor.ColorSelected -= btnArrowButtonForeColor_Click;
            btnArrowButtonHoverForeColor.ColorSelected -= btnArrowButtonHoverForeColor_Click;
            btnArrowButtonHoverBackColor.ColorSelected -= btnArrowButtonHoverBackColor_Click;
            btnArrowButtonPressedBackColor.ColorSelected -= btnArrowButtonPressedBackColor_Click;
            btnArrowButtonPressedForeColor.ColorSelected -= btnArrowButtonPressedForeColor_Click;
            btnThumbColor.ColorSelected -= btnThumbColor_Click;
            btnThumbHoverColor.ColorSelected -= btnThumbHoverColor_Click;
            btnThumbPressedColor.ColorSelected -= btnThumbPressedColor_Click;
            btnScrollBarBackColor.ColorSelected -= btnScrollBarBackColor_Click;


            btnVerticalArrowBackColor.ColorSelected -= btnVerticalArrowBackColor_Click;
            btnVerticalArrowForeColor.ColorSelected -= btnVerticalArrowForeColor_Click;
            btnVerticalArrowHoverBackColor.ColorSelected -= btnVerticalArrowHoverBackColor_Click;
            btnVerticalArrowHoverForeColor.ColorSelected -= btnVerticalArrowHoverForeColor_Click;
            btnVerticalThumbHoverColor.ColorSelected -= btnVerticalThumbHoverColor_Click;
            btnVerticalThumbColor.ColorSelected -= btnVerticalThumbColor_Click;
            btnVerticalThumbPressedColor.ColorSelected -= btnVerticalThumbPressedColor_Click;
            btnVerticalScrollBarBackColor.ColorSelected -= btnVerticalScrollBarBackColor_Click;
            btnVerticalArrowPressedForeColor.ColorSelected -= btnVerticalArrowPressedForeColor_Click;
            btnVerticalArrowPressedBackColor.ColorSelected -= btnVerticalArrowPressedBackColor_Click;
        }

        /// <summary>
        /// Sets the hover fore color for the arrow button of the HorizontalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnArrowButtonHoverForeColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.HorizontalScrollBar.ArrowButtonHoverForeColor = btnArrowButtonHoverForeColor.SelectedColor;
            this.sfScrollFrame1.HorizontalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the pressed fore color for the arrow button of the HorizontalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnArrowButtonPressedForeColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.HorizontalScrollBar.ArrowButtonPressedForeColor = btnArrowButtonPressedForeColor.SelectedColor;
            this.sfScrollFrame1.HorizontalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the back color for the arrow button of the HorizontalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnArrowButtonBackColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.HorizontalScrollBar.ArrowButtonBackColor = btnArrowButtonBackColor.SelectedColor;
            this.sfScrollFrame1.HorizontalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the hover back color for the arrow button of the HorizontalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnArrowButtonHoverBackColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.HorizontalScrollBar.ArrowButtonHoverBackColor = btnArrowButtonHoverBackColor.SelectedColor; ;
            this.sfScrollFrame1.HorizontalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the pressed back color for the arrow button of the HorizontalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnArrowButtonPressedBackColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.HorizontalScrollBar.ArrowButtonPressedBackColor = btnArrowButtonPressedBackColor.SelectedColor;
            this.sfScrollFrame1.HorizontalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the thumb hover color of the HorizontalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnThumbHoverColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.HorizontalScrollBar.ThumbHoverColor = btnThumbHoverColor.SelectedColor;
            this.sfScrollFrame1.HorizontalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the thumb pressed color of the HorizontalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnThumbPressedColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.HorizontalScrollBar.ThumbPressedColor = btnThumbPressedColor.SelectedColor;
            this.sfScrollFrame1.HorizontalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the thumb color of the HorizontalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnThumbColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.HorizontalScrollBar.ThumbColor = btnThumbColor.SelectedColor;
            this.sfScrollFrame1.HorizontalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the fore color for the arrow button of the VerticalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnVerticalArrowForeColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.VerticalScrollBar.ArrowButtonForeColor = btnVerticalArrowForeColor.SelectedColor;
            this.sfScrollFrame1.VerticalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the hover fore color for the arrow button of the VerticalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnVerticalArrowHoverForeColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.VerticalScrollBar.ArrowButtonHoverForeColor = btnVerticalArrowHoverForeColor.SelectedColor;
            this.sfScrollFrame1.VerticalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the pressed fore color for the arrow button of the VerticalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnVerticalArrowPressedForeColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.VerticalScrollBar.ArrowButtonPressedForeColor = btnVerticalArrowPressedForeColor.SelectedColor;
            this.sfScrollFrame1.VerticalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the back color for the arrow button of the VerticalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnVerticalArrowBackColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.VerticalScrollBar.ArrowButtonBackColor = btnVerticalArrowBackColor.SelectedColor;
            this.sfScrollFrame1.VerticalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the hover back color for the arrow button of the VerticalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnVerticalArrowHoverBackColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.VerticalScrollBar.ArrowButtonHoverBackColor = btnVerticalArrowHoverBackColor.SelectedColor;
            this.sfScrollFrame1.VerticalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the pressed back color for the arrow button of the VerticalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnVerticalArrowPressedBackColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.VerticalScrollBar.ArrowButtonPressedBackColor = btnVerticalArrowPressedBackColor.SelectedColor;
            this.sfScrollFrame1.VerticalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the thumb hover color of the VerticalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnVerticalThumbHoverColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.VerticalScrollBar.ThumbHoverColor = btnVerticalThumbHoverColor.SelectedColor;
            this.sfScrollFrame1.VerticalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the thumb pressed color of the VerticalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnVerticalThumbPressedColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.VerticalScrollBar.ThumbPressedColor = btnVerticalThumbPressedColor.SelectedColor;
            this.sfScrollFrame1.VerticalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the thumb color of the VerticalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnVerticalThumbColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.VerticalScrollBar.ThumbColor = btnVerticalThumbColor.SelectedColor;
            this.sfScrollFrame1.VerticalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the arrow button fore color of the HorizontalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnArrowButtonForeColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.HorizontalScrollBar.ArrowButtonForeColor = btnArrowButtonForeColor.SelectedColor;
            this.sfScrollFrame1.HorizontalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the back color of the HorizontalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnScrollBarBackColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.HorizontalScrollBar.ScrollBarBackColor = btnScrollBarBackColor.SelectedColor;
            this.sfScrollFrame1.HorizontalScrollBar.Invalidate();
        }

        /// <summary>
        /// Sets the back color of the VerticalScrollBar.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void btnVerticalScrollBarBackColor_Click(object sender, EventArgs e)
        {
            // Set form background to the selected color.
            this.sfScrollFrame1.Style.VerticalScrollBar.ScrollBarBackColor = btnVerticalScrollBarBackColor.SelectedColor;
            this.sfScrollFrame1.VerticalScrollBar.Invalidate();
        }

        #endregion
    }
}
