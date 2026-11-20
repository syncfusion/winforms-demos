#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Globalization;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Calculate;

namespace TabbedPanelGrids
{
    /// <summary>
    /// Summary description for PanelGrid.
    /// </summary>
    public class PanelGrid : Panel
    {
        #region API definitions
        private TextBox[] textBoxes;
        public int colCount = 0;
        public int rowCount = 0;
        private int textBoxCount = 0;
        private int leftOffSet;
        private int topOffSet;
        private CalcWorkbook workBook = null;
        public CalcSheet sheet = null;
        private bool textBoxChanged = false;
        #endregion

        public PanelGrid()
        {

        }

        public void InitGrid(CalcWorkbook workBook, CalcSheet sheet, int rowCount, int colCount, Size sz, Panel left, Panel top, string name)
        {
            //set the textboxes that hold the data
            this.textBoxCount = rowCount * colCount;
            textBoxes = new TextBox[textBoxCount];
            this.rowCount = rowCount;
            this.colCount = colCount;
            this.leftOffSet = left.Width;
            this.topOffSet = top.Height;
            this.Size = sz;
            for (int i = 0; i < textBoxCount; ++i)
            {
                TextBox tb = new TextBox();
                tb.Multiline = true;
                int row, col;
                row = (i % this.colCount) + 1;
                col = i / this.colCount + 1;
                tb.Bounds = this.GetRectangle(row, col);
                tb.Visible = true;
                this.textBoxes[i] = tb;
                tb.Leave += new EventHandler(tb_Leave);
                tb.Enter += new EventHandler(tb_Enter);
                tb.TextChanged += new EventHandler(tb_TextChanged);
            }
            this.Controls.AddRange(this.textBoxes);

            //setup the labels on the rows and columns
            for (int i = 1; i <= rowCount; ++i)
            {
                Label lb = new Label();
                Rectangle rect = this.GetRectangle(1, i);
                rect.Offset(-leftOffSet, -top.Height);
                rect.Width = left.Width - 6;
                lb.Bounds = rect;
                lb.Text = i.ToString();
                lb.Font = new Font(lb.Font, FontStyle.Bold);
                lb.TextAlign = ContentAlignment.MiddleRight;
                lb.Visible = true;
                left.Controls.Add(lb);
            }
            for (int i = 1; i <= colCount; ++i)
            {
                Label lb = new Label();
                Rectangle rect = this.GetRectangle(i, 1);
                rect.Offset(0, -top.Height);
                rect.Height = top.Height - 2;
                lb.Bounds = rect;
                lb.Text = RangeInfo.GetAlphaLabel(i).ToString();
                lb.Font = new Font(lb.Font, FontStyle.Bold);
                lb.TextAlign = ContentAlignment.BottomCenter;
                lb.Visible = true;
                top.Controls.Add(lb);
            }

            this.workBook = workBook;
            if (sheet == null)
            {
                //create a CalcSheet and add it to the workbook
                this.sheet = new CalcSheet(rowCount, colCount);
                this.sheet.Name = name;
                this.workBook.CalcSheetList.Add(this.sheet); //this line assigns sheet.Engine.
                if (this.workBook.Engine == null)
                    this.workBook.Engine = this.sheet.Engine;
            }
            else
            {
                this.sheet = sheet;
            }

            this.sheet.CalculationsSuspended = false;
            this.sheet.Engine.UseDependencies = true;

            this.sheet.CalculatedValueChanged += new ValueChangedEventHandler(sheet_CalculatedValueChanged);
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            textBoxChanged = true;
        }

        private void tb_Enter(object sender, EventArgs e)
        {
            //Console.WriteLine("enter_Enter {0}", DateTime.Now);
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                int row, col;
                if (GetRowCol(tb, out row, out col) > -1)
                {
                    string s = this.sheet.Engine.GetFormulaRowCol(this.sheet, row, col);
                    if (s.Length > 0)
                    {
                        tb.Text = s;
                    }
                }
            }
            textBoxChanged = false;
        }

        private void tb_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                int row, col;
                if (GetRowCol(tb, out row, out col) > -1)
                {
                    object o = this.sheet.GetValueRowCol(row, col);
                    if (textBoxChanged || (o != null && o.ToString() != tb.Text))
                    {
                        textBoxChanged = false;
                        this.sheet[row, col] = tb.Text;
                        tb.Text = this.sheet.GetValueRowCol(row, col).ToString();
                    }
                }
            }           
        }

        private void sheet_CalculatedValueChanged(object sender, ValueChangedEventArgs e)
        {
            TextBox tb = this.GetTextBox(e.RowIndex, e.ColIndex);
            tb.Text = e.Value;
        }

        public string this[int row, int col]
        {
            get
            {
                return GetTextBox(row, col).Text;
            }

            set
            {
                GetTextBox(row, col).Text = value;
            }
        }

        public TextBox GetTextBox(int row, int col)
        {
            return this.textBoxes[(row - 1) * this.colCount + col - 1];
        }

        public TextBox GetActiveTextBoxRowCol(out int row, out int col)
        {
            TextBox found = null;
            col = -1;
            row = -1;
            for (int i = 0; i < this.textBoxCount; ++i)
            {
                if (this.textBoxes[i].Focused)
                {
                    col = (i % this.colCount) + 1;
                    row = i / this.colCount + 1;
                    found = this.textBoxes[i];
                    break;
                }
            }
            return found;
        }
        private int GetRowCol(TextBox tb, out int row, out int col)
        {
            int found = -1;
            col = -1;
            row = -1;
            for (int i = 0; i < this.textBoxCount; ++i)
            {
                if (this.textBoxes[i] == tb)
                {
                    col = (i % this.colCount) + 1;
                    row = i / this.colCount + 1;
                    found = i;
                    break;
                }
            }
            return found;
        }

        private Rectangle GetRectangle(int row, int col)
        {
            int dx = (this.ClientSize.Width - this.leftOffSet) / this.colCount;
            int dy = (this.ClientSize.Height - this.topOffSet) / this.rowCount;

            return new Rectangle((row - 1) * dx + this.leftOffSet, (col - 1) * dy + this.topOffSet, dx, dy);
        }

    }
}
