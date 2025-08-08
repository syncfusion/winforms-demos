#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.DataGrid.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Syncfusion.WinForms.DataGrid;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Enums;

namespace AlternateRowStyle
{
    public partial class Form1 : Form
    {
        Color oddRow = Color.Transparent;
        Color evenRow = Color.AliceBlue;
        public Form1()
        {
            InitializeComponent();
            OrderInfoRepository orderInfo = new OrderInfoRepository();
            sfDataGrid1.DataSource = orderInfo.OrdersDetail;
            sfDataGrid1.QueryRowStyle += SfDataGrid_QueryRowStyle;
            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                Color color = Color.FromKnownColor(knownColor);
                if (!color.IsSystemColor)
                {
                    comboBox1.Items.Add(color);
                    comboBox2.Items.Add(color);
                }
            }

            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var color = ((sender as ComboBox).Text).ToString();
            Color c = Color.FromName(color);
            oddRow = c;
            sfDataGrid1.TableControl.Invalidate();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var color = ((sender as ComboBox).Text).ToString();
            Color c = Color.FromName(color);
            evenRow = c;
            sfDataGrid1.TableControl.Invalidate();
        }

        private void SfDataGrid_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = evenRow;
            else
                e.Style.BackColor = oddRow;
        }
    }
}
