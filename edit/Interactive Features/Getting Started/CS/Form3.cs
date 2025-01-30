#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace ActionGroupingDemo
{
    public partial class ColumnGuidesEditor : SfForm
    {
        public static string[] columnnumber, color;
        private char[] colorchar;
        public static string columnnumbers, colors;
        public static int columncount, colorcount;
        private int index, arrayindex = 0;
        public static bool invalidinput = false;
        public ColumnGuidesEditor()
        {
            InitializeComponent();
            this.AcceptButton.DialogResult = DialogResult.OK;
        }
        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (this.textBox1.Text != "" && this.textBox2.Text != "")
            {
                columncount = 1;
                arrayindex = 0;
                colorcount = 1;
                columnnumber = new string[10];
                color = new string[30];
                colorchar = new char[30];
                this.textBox1.Text = this.textBox1.Text.Replace(" ", "");
                this.textBox2.Text = this.textBox2.Text.Replace(" ", "");

                columnnumbers = this.textBox1.Text;
                for (; ; )
                {
                    index = columnnumbers.LastIndexOf(",");
                    if (index != -1)
                    {
                        columnnumber[arrayindex++] = columnnumbers.Substring(index + 1);
                        columnnumbers = columnnumbers.Substring(0, index);
                        columncount++;
                    }
                    else
                    {
                        columnnumber[arrayindex] = columnnumbers;
                        break;
                    }
                }
                arrayindex = 0;
                colors = this.textBox2.Text.ToLower();

                for (; ; )
                {
                    index = colors.LastIndexOf(",");
                    if (index != -1)
                    {
                        color[arrayindex] = colors.Substring(index + 1);

                        colorchar = color[arrayindex].ToCharArray();
                        if (colorchar.Length > 0)
                        {
                            color[arrayindex] = ((colorchar[0].ToString()).ToUpper());
                            color[arrayindex] = string.Concat(color[arrayindex], colors.Substring(index + 2));
                            arrayindex++;
                            colors = colors.Substring(0, index);
                            colorcount++;
                        }
                        else
                            break;
                    }
                    else
                    {
                        color[arrayindex] = colors;
                        colorchar = color[arrayindex].ToCharArray();
                        color[arrayindex] = ((colorchar[0].ToString()).ToUpper());
                        color[arrayindex] = string.Concat(color[arrayindex], colors.Substring(1, colors.Length - 1));
                        break;
                    }
                }
                if (columncount == colorcount)
                {
                    invalidinput = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Number of Colors should be equal to the number of Columns");
                    invalidinput = true;
                }

            }
        }
    }
}
