#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintingCustomization
{
    public partial class PreviewForm : SfForm
    {
        #region Variables
        /// <summary>
        /// 
        /// </summary>
        private int noOfPages = 0;

        /// <summary>
        /// 
        /// </summary>
        TreeViewPrintDocument printDocument;

        #endregion

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        public PreviewForm(TreeViewPrintDocument document)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            //this.panel7.Visible = false;
            printDocument = document;
            this.printPreviewControl1.Zoom = 0.5;
            this.printPreviewControl1.StartPage = 0;
            this.printPreviewControl1.Document = document;
            this.printPreviewControl1.Document.BeginPrint += Document_BeginPrint;
            this.printPreviewControl1.Document.PrintPage += Document_PrintPage;
            this.printPreviewControl1.Document.EndPrint += Document_EndPrint;
            this.scrollersFrame3.AttachedTo = this.printPreviewControl1;
            this.scrollersFrame3.VisualStyle = ScrollBarCustomDrawStyles.Metro;
            this.Load += new EventHandler(PreviewForm_Load);
            this.groupBarItem4.Visible = false;
            this.buttonAdv1.ThemeName = this.buttonAdv16.ThemeName = this.buttonAdv10.ThemeName = this.buttonAdv22.ThemeName = "Office2019Colorful";
            this.buttonAdv2.ThemeName = this.buttonAdv7.ThemeName = this.buttonAdv11.ThemeName = this.buttonAdv14.ThemeName = "Office2019Colorful";
            this.buttonAdv6.ThemeName = this.buttonAdv8.ThemeName = this.buttonAdv12.ThemeName = this.buttonAdv15.ThemeName = "Office2019Colorful";
            this.buttonAdv4.ThemeName = this.buttonAdv9.ThemeName = this.buttonAdv13.ThemeName = this.buttonAdv16.ThemeName = "Office2019Colorful";
            this.buttonAdv20.ThemeName = this.buttonAdv22.ThemeName = this.buttonAdv19.ThemeName = this.buttonAdv18.ThemeName = this.buttonAdv17.ThemeName = "Office2019Colorful";
            this.groupBar1.ThemeName = "Office2019Colorful";
            this.integerTextBox1.ThemeName = "Office2019Colorful";
            this.trackBarEx1.BackColor = Color.White;
            //this.trackBarEx1.Style = TrackBarEx.Theme.Office2016White;
            populateComboBoxItems();
            this.sfomboBox1.ThemeName=this.sfomboBox2.ThemeName=this.sfomboBox3.ThemeName= "Office2019Colorful";
            this.textBoxExt1.ThemeName = this.textBoxExt2.ThemeName = this.integerTextBox1.ThemeName = this.integerTextBox2.ThemeName = this.integerTextBox3.ThemeName = "Office2019Colorful";
            this.colorPickerButton1.ThemeName = this.colorPickerButton2.ThemeName = this.radioButtonAdv1.ThemeName= "Office2019Colorful";
            this.radioButtonAdv1.ThemeName = this.radioButtonAdv2.ThemeName = this.radioButtonAdv3.ThemeName ="Office2019Colorful";
            this.radioButtonAdv4.ThemeName = this.radioButtonAdv5.ThemeName = this.radioButtonAdv6.ThemeName ="Office2019Colorful";
            this.numericUpDownExt1.VisualStyle = this.numericUpDownExt2.VisualStyle = this.numericUpDownExt3.VisualStyle = this.numericUpDownExt4.VisualStyle = this.numericUpDownExt5.VisualStyle =
                this.numericUpDownExt6.VisualStyle = this.numericUpDownExt7.VisualStyle = this.numericUpDownExt8.VisualStyle = VisualStyle.Office2016Colorful;
            this.scrollersFrame1.ThemeName = this.scrollersFrame2.ThemeName = this.scrollersFrame3.ThemeName = "Office2019Colorful";
        }

        void PreviewForm_Load(object sender, EventArgs e)
        {
            this.textBoxExt1.Text = "TreeViewAdv Printing Customization";
            this.printPreviewControl1.Dock = DockStyle.Fill;
         
            printDocument.HeaderTextColor = this.colorPickerButton1.MetroColor;
            this.buttonAdv16.PerformClick();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        #endregion

        void Document_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.printPreviewControl1.StartPage = 0;
            this.integerTextBox3.IntegerValue = 1;
            this.label9.Text = "/" + noOfPages.ToString();
            this.checkButtons();
        }

        void Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            noOfPages++;
        }

        void Document_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            noOfPages = 0;
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            printDocument.PrintNoDialog();
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            printDocument.HeaderTextColor = this.colorPickerButton1.SelectedColor;
            this.colorPickerButton1.MetroColor = this.colorPickerButton1.SelectedColor;
        }

        private void buttonAdv4_Click(object sender, EventArgs e)
        {
            if (this.fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument.HeaderFont = this.fontDialog1.Font;
            }
        }

        private void buttonAdv10_Click(object sender, EventArgs e)
        {
            printDocument.DrawPrintHeader += PreviewForm_DrawPrintHeader;
        }

        void PreviewForm_DrawPrintHeader(object sender, TreeViewPrintHeaderFooterEventArgs e)
        {
            // Get the rectangle area to draw
            Rectangle header = e.DrawRectangle;

            //IMAGE
            //scale the image
            SizeF imageSize = new SizeF(header.Width / 3, header.Height * 0.8f);
            //Locating the logo on the right corner of the Drawing Surface
            PointF imageLocation = new PointF(e.DrawRectangle.Width - imageSize.Width + 100, header.Y + 5);
#if NETCORE
            Bitmap img = new Bitmap(@"..\..\..\CustomImage.png");
#else
            Bitmap img = new Bitmap(@"..\..\CustomImage.png");
#endif
            //Draw the image in the Header.
            e.Graphics.DrawImage(img, new RectangleF(new PointF(imageLocation.X, imageLocation.Y + 10), imageSize));

            //TITLE
            Color activeColor = Color.FromArgb(44, 71, 120);
            SolidBrush brush = new SolidBrush(activeColor);
            Font font = new Font("Segoe UI", 20, FontStyle.Bold);
            //Set formatting for the text
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Near;
            //Draw the title
            e.Graphics.DrawString("Information about countries", font, brush, new RectangleF(header.Location.X + 20, header.Location.Y + 30, e.DrawRectangle.Width, e.DrawRectangle.Height), format);

            ///BORDER LINES - Draw some lines in the header
            Pen pen = new Pen(Color.DarkBlue, 0.8f);
            e.Graphics.DrawLine(pen, new Point(header.Left, header.Top + 14), new Point(header.Right, header.Top + 14));
            e.Graphics.DrawLine(pen, new Point(header.Left, header.Top + 17), new Point(header.Right, header.Top + 17));
            e.Graphics.DrawLine(pen, new Point(header.Left, header.Bottom - 8), new Point(header.Right, header.Bottom - 8));
            e.Graphics.DrawLine(pen, new Point(header.Left, header.Bottom - 5), new Point(header.Right, header.Bottom - 5));

            //Dispose drawing resources
            font.Dispose();
            format.Dispose();
            pen.Dispose();
        }

        private void populateComboBoxItems()
        {
            List<string> item1 = new List<string>();
            List<string> item2 = new List<string>();
            List<string> item3 = new List<string>();
            item1.AddRange(new string[] {
            "Portrait",
            "LandScape"});
            this.sfomboBox1.DataSource = item1;
            this.sfomboBox1.SelectedIndex = 0;
            item2.AddRange(new string[] { "Mexico",
            "Letter - 8.5 in * 11.0 in",
            "Legal - 8.5 in * 14.0in",
            "Executive - 7.25 in. by 10.5 in.",
            "A4  - 297 mm by 420 mm",
            "Number10Envelope - 4.125 in. by 9.5 in",
            "B5Envelope - 176 mm by 250 mm",
            "MonarchEnvelope - 3.875 in. by 7.5 in.",
            "Custom Size"});
            this.sfomboBox2.DataSource = item2;
            this.sfomboBox2.SelectedIndex = 1;
            item3.AddRange(new string[] {
            "Normal",
            "Narrow",
            "Moderate",
            "Wide",
            "Custom"});
            this.sfomboBox3.DataSource = item3;
            this.sfomboBox3.SelectedIndex = 0;
        }
        private void buttonAdv13_Click(object sender, EventArgs e)
        {
            printDocument.PrintHeaderFooterOnAllPages = true;
        }

        private void buttonAdv12_Click(object sender, EventArgs e)
        {
            printDocument.PrintHeaderFooterOnAllPages = false;
        }

        private void buttonAdv11_Click(object sender, EventArgs e)
        {
            printDocument.ShowDateTime = true;
        }

        private void buttonAdv8_Click(object sender, EventArgs e)
        {
            printDocument.ShowDateTime = false;
        }

        private void buttonAdv7_Click(object sender, EventArgs e)
        {
            printDocument.ShowPageNumber = true;
        }

        private void buttonAdv18_Click(object sender, EventArgs e)
        {
            printDocument.ShowPageNumber = false;
        }

        private void buttonAdv15_Click(object sender, EventArgs e)
        {
            printDocument.PrintHeaderOnFirstPageOnly = true;
        }

        private void buttonAdv14_Click(object sender, EventArgs e)
        {
            printDocument.PrintHeaderOnFirstPageOnly = false;
        }

        private void buttonAdv9_Click(object sender, EventArgs e)
        {
            printDocument.DrawPrintFooter += PreviewForm_DrawPrintFooter;
        }

        void PreviewForm_DrawPrintFooter(object sender, TreeViewPrintHeaderFooterEventArgs e)
        {
            //Get the rectangle area to draw
            Rectangle footer = e.DrawRectangle;

            //Draw copy right
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            Font font = new Font("Segoe UI", 8);
            SolidBrush brush = new SolidBrush(Color.Red);
            e.Graphics.DrawString("@copyright", font, brush, CenterPoint(footer), format);
            e.Graphics.DrawString(string.Format("page {0} of {1}", e.PageNumber, e.PageCount), font, brush, new Point(footer.Right - 100, CenterPoint(footer).Y), format);

            //Dispose resources
            format.Dispose();
            font.Dispose();
            brush.Dispose();
        }

        /// <summary>
        /// Returns a centered point within a given rectangle.
        /// </summary>
        /// <param name="rect">The outer rectangle.</param>
        /// <returns>The centered point.</returns>
        public Point CenterPoint(Rectangle rect)
        {
            return new Point(rect.X + (rect.Width / 2), rect.Y + (rect.Height / 2));
        }

        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            printDocument.FooterTextColor = this.colorPickerButton2.SelectedColor;
            this.colorPickerButton2.MetroColor = this.colorPickerButton2.SelectedColor;
        }

        private void buttonAdv6_Click(object sender, EventArgs e)
        {
            if (this.fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument.FooterFont = this.fontDialog1.Font;
            }
        }

        private void buttonAdv16_Click(object sender, EventArgs e)
        {
            this.printPreviewControl1.Document = printDocument;
            this.printPreviewControl1.Show();
        }

        private void buttonAdv17_Click(object sender, EventArgs e) //First page
        {
            this.integerTextBox3.IntegerValue = 1;
            checkButtons();
        }

        private void buttonAdv20_Click(object sender, EventArgs e) //Next page
        {
            pageNo = (int)this.integerTextBox3.IntegerValue;
            pageNo++;
            this.integerTextBox3.IntegerValue = pageNo;
            checkButtons();
        }

        int pageNo;
        private void buttonAdv19_Click(object sender, EventArgs e) //previous page
        {
            pageNo = (int)this.integerTextBox3.IntegerValue;
            pageNo--;
            this.integerTextBox3.IntegerValue = pageNo;
            checkButtons();
        }

        private void buttonAdv21_Click(object sender, EventArgs e) //Last page
        {
            this.integerTextBox3.IntegerValue = this.noOfPages;
            checkButtons();
        }

        private void checkButtons()
        {
            if (this.printPreviewControl1.Document != null)
            {
                if (this.integerTextBox3.IntegerValue == 1)
                {
                    this.buttonAdv17.Enabled = false;
                    this.buttonAdv19.Enabled = false;
                }
                else
                {
                    this.buttonAdv17.Enabled = true;
                    this.buttonAdv19.Enabled = true;
                }
                if (this.integerTextBox3.IntegerValue == noOfPages)
                {
                    this.buttonAdv20.Enabled = false;
                    this.buttonAdv21.Enabled = false;
                }
                else
                {
                    this.buttonAdv20.Enabled = true;
                    this.buttonAdv21.Enabled = true;
                }
            }
        }

        private void integerTextBox3_TextChanged(object sender, EventArgs e)
        {
            int pageNo = (int)this.integerTextBox3.IntegerValue;
            if (pageNo > this.noOfPages)
            {
                pageNo = this.noOfPages;
            }
            if (pageNo < 1)
            {
                pageNo = 1;
            }
            this.integerTextBox3.IntegerValue = pageNo;
            this.printPreviewControl1.StartPage = pageNo - 1;
            this.checkButtons();
        }

        private void sfomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.sfomboBox1.SelectedIndex == 0)
                this.printPreviewControl1.Document.DefaultPageSettings.Landscape = false;
            else
                this.printPreviewControl1.Document.DefaultPageSettings.Landscape = true;
        }

        private void buttonAdv22_Click(object sender, EventArgs e)
        {
            PaperSize paperSize = printDocument.DefaultPageSettings.PaperSize;
            if (this.sfomboBox2.SelectedIndex == 7)
            {
                for (int paper = 0; (paper <= (printDocument.PrinterSettings.PaperSizes.Count - 1)); paper++)
                {
                    if (printDocument.PrinterSettings.PaperSizes[paper].Kind == PaperKind.Custom)
                    {
                        paperSize = new PaperSize("User Defined", (int)this.numericUpDownExt1.Value, (int)this.numericUpDownExt2.Value);
                        printDocument.DefaultPageSettings.PaperSize = paperSize;
                    }
                }
            }
        }

        private void sfomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int paper = 0; (paper <= (printDocument.PrinterSettings.PaperSizes.Count - 1)); paper++)
            {
                if (this.sfomboBox2.SelectedIndex == 0)
                {
                    if (printDocument.PrinterSettings.PaperSizes[paper].Kind == PaperKind.Letter)
                        printDocument.DefaultPageSettings.PaperSize = printDocument.PrinterSettings.PaperSizes[paper];
                }
                else if (this.sfomboBox2.SelectedIndex == 1)
                {
                    if (printDocument.PrinterSettings.PaperSizes[paper].Kind == PaperKind.Legal)
                        printDocument.DefaultPageSettings.PaperSize = printDocument.PrinterSettings.PaperSizes[paper];
                }
                else if (this.sfomboBox2.SelectedIndex == 2)
                {
                    if (printDocument.PrinterSettings.PaperSizes[paper].Kind == PaperKind.Executive)
                        printDocument.DefaultPageSettings.PaperSize = printDocument.PrinterSettings.PaperSizes[paper];
                }
                else if (this.sfomboBox2.SelectedIndex == 3)
                {
                    if (printDocument.PrinterSettings.PaperSizes[paper].Kind == PaperKind.A4)
                        printDocument.DefaultPageSettings.PaperSize = printDocument.PrinterSettings.PaperSizes[paper];
                }
                else if (this.sfomboBox2.SelectedIndex == 4)
                {
                    if (printDocument.PrinterSettings.PaperSizes[paper].Kind == PaperKind.Number10Envelope)
                        printDocument.DefaultPageSettings.PaperSize = printDocument.PrinterSettings.PaperSizes[paper];
                }
                else if (this.sfomboBox2.SelectedIndex == 5)
                {
                    if (printDocument.PrinterSettings.PaperSizes[paper].Kind == PaperKind.B5Envelope)
                        printDocument.DefaultPageSettings.PaperSize = printDocument.PrinterSettings.PaperSizes[paper];
                }
                else if (this.sfomboBox2.SelectedIndex == 6)
                {
                    if (printDocument.PrinterSettings.PaperSizes[paper].Kind == PaperKind.MonarchEnvelope)
                        printDocument.DefaultPageSettings.PaperSize = printDocument.PrinterSettings.PaperSizes[paper];
                }
                else
                {
                    if (printDocument.PrinterSettings.PaperSizes[paper].Kind == PaperKind.Custom)
                        printDocument.DefaultPageSettings.PaperSize = printDocument.PrinterSettings.PaperSizes[paper];
                }
            }
        }

        private void sfomboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.sfomboBox3.SelectedIndex == 0)
            {
                printDocument.HeaderHeight = 100;
                printDocument.FooterHeight = 100;
                printDocument.DefaultPageSettings.Margins = new Margins(100, 100, printDocument.HeaderHeight, printDocument.FooterHeight);
            }
            else if (this.sfomboBox3.SelectedIndex == 1)
            {
                printDocument.HeaderHeight = 50;
                printDocument.FooterHeight = 50;
                printDocument.DefaultPageSettings.Margins = new Margins(50, 50, printDocument.HeaderHeight, printDocument.FooterHeight);
            }
            else if (this.sfomboBox3.SelectedIndex == 2)
            {
                printDocument.HeaderHeight = 80;
                printDocument.FooterHeight = 80;
                printDocument.DefaultPageSettings.Margins = new Margins(80, 80, printDocument.HeaderHeight, printDocument.FooterHeight);
            }
            else if (this.sfomboBox3.SelectedIndex == 3)
            {
                printDocument.HeaderHeight = 100;
                printDocument.FooterHeight = 100;
                printDocument.DefaultPageSettings.Margins = new Margins(200, 200, printDocument.HeaderHeight, printDocument.FooterHeight);
            }
            else
            {
                printDocument.HeaderHeight = 100;
                printDocument.FooterHeight = 100;
                printDocument.DefaultPageSettings.Margins = new Margins(100, 100, printDocument.HeaderHeight, printDocument.FooterHeight);
            }
            this.numericUpDownExt3.Value = printDocument.DefaultPageSettings.Margins.Left;
            this.numericUpDownExt4.Value = printDocument.DefaultPageSettings.Margins.Right;
            this.numericUpDownExt5.Value = printDocument.DefaultPageSettings.Margins.Top;
            this.numericUpDownExt6.Value = printDocument.DefaultPageSettings.Margins.Bottom;
            this.integerTextBox1.IntegerValue = printDocument.DefaultPageSettings.Margins.Top;
            this.integerTextBox2.IntegerValue = printDocument.DefaultPageSettings.Margins.Bottom;
        }

        private void buttonAdv23_Click(object sender, EventArgs e)
        {
            printDocument.HeaderHeight = (int)this.numericUpDownExt5.Value;
            printDocument.FooterHeight = (int)this.numericUpDownExt6.Value;
            printDocument.DefaultPageSettings.Margins = new Margins((int)this.numericUpDownExt3.Value, (int)this.numericUpDownExt4.Value, printDocument.HeaderHeight, printDocument.FooterHeight);
            this.integerTextBox1.IntegerValue = printDocument.DefaultPageSettings.Margins.Top;
            this.integerTextBox2.IntegerValue = printDocument.DefaultPageSettings.Margins.Bottom;
        }

        private void buttonAdv25_Click(object sender, EventArgs e)
        {
            printDocument.EnableCustomHeader = true;
        }

        private void buttonAdv24_Click(object sender, EventArgs e)
        {
            printDocument.EnableCustomHeader = false;
        }

        private void buttonAdv27_Click(object sender, EventArgs e)
        {
            printDocument.EnableCustomFooter = true;
        }

        private void buttonAdv26_Click(object sender, EventArgs e)
        {
            printDocument.EnableCustomFooter = false;
        }

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {
            printDocument.HeaderText = this.textBoxExt1.Text;
        }

        private void integerTextBox1_TextChanged(object sender, EventArgs e)
        {
            if ((int)this.integerTextBox1.IntegerValue > this.numericUpDownExt5.Minimum && (int)this.integerTextBox1.IntegerValue < this.numericUpDownExt5.Maximum)
            {
                printDocument.HeaderHeight = (int)this.integerTextBox1.IntegerValue;
                this.numericUpDownExt5.Value = (int)this.integerTextBox1.IntegerValue;
            }
        }

        private void textBoxExt2_TextChanged(object sender, EventArgs e)
        {
            printDocument.FooterText = this.textBoxExt2.Text;
        }

        private void integerTextBox2_TextChanged(object sender, EventArgs e)
        {
            if ((int)this.integerTextBox2.IntegerValue > this.numericUpDownExt6.Minimum && (int)this.integerTextBox2.IntegerValue < this.numericUpDownExt6.Maximum)
            {
                printDocument.FooterHeight = (int)this.integerTextBox2.IntegerValue;
                this.numericUpDownExt6.Value = (int)this.integerTextBox2.IntegerValue;
            }
        }

        private void trackBarEx1_ValueChanged(object sender, EventArgs e)
        {
            this.printPreviewControl1.Zoom = (double)(this.trackBarEx1.Value) / 20;
            this.label10.Text = (this.trackBarEx1.Value * 5).ToString()+" %";
        }

        private void numericUpDownExt8_ValueChanged(object sender, EventArgs e)
        {
            this.printPreviewControl1.Rows = (int)this.numericUpDownExt8.Value;
        }

        private void numericUpDownExt7_ValueChanged(object sender, EventArgs e)
        {
            this.printPreviewControl1.Columns = (int)this.numericUpDownExt7.Value;
        }

        private void radioButtonAdv3_CheckChanged(object sender, EventArgs e)
        {
            if (this.radioButtonAdv1.Checked)
                printDocument.HeaderAlignment = TextAlignment.Left;
            else if(this.radioButtonAdv2.Checked)
                printDocument.HeaderAlignment = TextAlignment.Center;
            else if (this.radioButtonAdv3.Checked)
                printDocument.HeaderAlignment = TextAlignment.Right;
        }

        private void radioButtonAdv4_CheckChanged(object sender, EventArgs e)
        {
            if (this.radioButtonAdv6.Checked)
                printDocument.FooterAlignment = TextAlignment.Left;
            else if (this.radioButtonAdv5.Checked)
                printDocument.FooterAlignment = TextAlignment.Center;
            else if (this.radioButtonAdv4.Checked)
                printDocument.FooterAlignment = TextAlignment.Right;
        }

        private void groupBar1_GroupBarItemSelected(object sender, EventArgs e)
        {
            if(this.groupBar1.SelectedItem == 2)
                this.scrollersFrame1.AttachedTo = this.panel7;
        }
    }
}