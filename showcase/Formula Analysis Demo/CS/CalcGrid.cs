#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Calculate;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalcEngine.Showcase_2010
{
    public class CalcGrid : GridControl, Syncfusion.Calculate.ICalcData, ISheetData
    {
        public CalcGrid()
            : base()
        {
            //Avoid the complexity of sorting:
            this.ApplyVisualStyles = true;
            this.ThemesEnabled = true;
            this.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            GridMetroColors color = new GridMetroColors();
            color.HeaderColor.HoverColor = ColorTranslator.FromHtml("#003B51");
            color.HeaderColor.NormalColor = Color.FromArgb(48, 126, 156); //Color.FromArgb(51, 153, 255);
            color.HeaderTextColor.NormalTextColor = Color.White;
            color.HeaderTextColor.HoverTextColor = Color.White;
            color.HeaderBottomBorderWeight = GridBottomBorderWeight.None;
            this.SetMetroStyle(color);
            //this.VScrollBehavior = GridScrollbarMode.AutoScroll;
            //this.HScrollBehavior = GridScrollbarMode.AutoScroll;
            this.RowHeights[0] = 55;
            this.DefaultRowHeight = 50;
            this.QueryCellInfo += CalcGrid_QueryCellInfo;
            this.Properties.BackgroundColor = Color.Transparent;
            this.ForeColor = Color.White;
            this.TableStyle.TextColor = Color.White;
            this.BackColor = ColorTranslator.FromHtml("#003B51");
            this.GridVisualStyles = GridVisualStyles.Metro;
            this.BorderStyle = BorderStyle.FixedSingle;

            this.TableStyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            this.TableStyle.VerticalAlignment = GridVerticalAlignment.Middle;
            this.TableStyle.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(0, 59, 100), GridBorderWeight.ExtraThin);
            this.TableStyle.Borders.Right = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(0, 59, 100), GridBorderWeight.ExtraThin);
            

        }
        Color[] colorCollection = new Color[] { Color.FromArgb(95, 140, 237), Color.FromArgb(235, 94, 96), Color.FromArgb(141, 97, 194), Color.FromArgb(45, 150, 57), Color.FromArgb(191, 76, 145), Color.FromArgb(227, 130, 34) };
        void CalcGrid_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            if (e.ColIndex > 0)
            {
                int j = GetColorID(GridRangeInfo.Cell(e.RowIndex, e.ColIndex));
                e.Style.BackColor = (j == -1) ? ColorTranslator.FromHtml("#003B51") : colorCollection[j];
            }
        }


        public int GetColorID(GridRangeInfo range)
        {
            int j = 0;
            for (int i = 0; i < this.Model.Selections.Count; i++)
            {
                j = (j == 5) ? 0 : j;
                if (this.Model.SelectedRanges[i].Contains(range))
                {
                    return j;
                }
                j++;
            }
            return -1;
        }
        //Used to avoid focus problem on disabled grid.
        private bool locked = false;
        public bool Locked
        {
            get { return locked; }
            set { locked = value; }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (this.locked)
                return;
            base.OnMouseDown(e);
        }

        #region ICalcData Members

        public void WireParentObject()
        {
            //Use this event to get cell changes:
        }

        private int changeCol = -1;
        private void defaultView_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged && changeCol > -1)
            {
                int row = e.NewIndex;
                int col = this.changeCol;

                string val = this[row + 1, col + 1].Text;
                Syncfusion.Calculate.ValueChangedEventArgs e1 = new Syncfusion.Calculate.ValueChangedEventArgs(row + 1, col + 1, val);
                ValueChanged(this, e1);
            }
        }

        //One based:
        public object GetValueRowCol(int row, int col)
        {
            return this[row, col].Text;
        }

        //One based:
        public void SetValueRowCol(object value, int row, int col)
        {
            this[row - 1, col - 1].Text = value.ToString();
        }

        public event Syncfusion.Calculate.ValueChangedEventHandler ValueChanged;

        #endregion

        /// <summary>
        /// Includes the different methods of ISheetData interface.
        /// </summary>
        /// <returns></returns>
        #region ISheetData Members


        public int GetFirstRow()
        {
            return 1;
        }
        public int GetLastRow()
        {
            return this.RowCount;
        }


        public int GetRowCount()
        {
            return this.RowCount;
        }

        public int GetFirstColumn()
        {
            return 1;
        }

        public int GetLastColumn()
        {
            return this.ColCount;
        }


        public int GetColumnCount()
        {
            return this.ColCount;
        }
        #endregion
    }
}
