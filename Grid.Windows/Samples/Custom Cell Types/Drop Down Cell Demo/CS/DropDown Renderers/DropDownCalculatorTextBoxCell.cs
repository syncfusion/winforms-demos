using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Runtime.Serialization;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Styles;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace DropDownCellDemo
{
    #region Cell Model
    class DropDownCalculatorTextBoxCellModel : GridStaticCellModel
    {

		protected DropDownCalculatorTextBoxCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

        public DropDownCalculatorTextBoxCellModel(GridModel grid)//, CalculatorControl calci)
			: base(grid)
		{
            ButtonBarSize = new Size(14, 20);
		}
	
		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
            return new DropDownCalculatorTextBoxCellRenderer(control, this);
		}

        protected override Size OnQueryPrefferedClientSize(Graphics g, int rowIndex, int colIndex, GridStyleInfo style, GridQueryBounds queryBounds)
		{
			Size s = base.OnQueryPrefferedClientSize(g, rowIndex, colIndex, style, queryBounds);
			s.Width = s.Width + ButtonBarSize.Width;
			return s;
		}
    }
    #endregion

    #region Cell Renderer
    class DropDownCalculatorTextBoxCellRenderer : GridStaticCellRenderer
    {
        internal CalculatorControl calci;

        public DropDownCalculatorTextBoxCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
		{
            DropDownPart = new GridDropDownCellImp(this);
            DropDownButton = new GridCellComboBoxButton(this);
		}

        void calci_ValueCalculated(object sender, CalculatorValueCalculatedEventArgs arg)
        {
            GridCurrentCell cc = this.Grid.CurrentCell;
            this.Grid.Model[cc.RowIndex, cc.ColIndex].CellValue = this.calci.Value;
        }

        public new GridDropDownContainer DropDownContainer
        {
            get { return (GridDropDownContainer)base.DropDownContainer; }
        }

        public override void DropDownContainerShowingDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridStyleInfo style = this.Grid.Model[RowIndex, ColIndex];
            this.calci = style.Control as CalculatorControl;
            this.calci.ShowDisplayArea = false;
            this.calci.Size = new Size(260, 180);

            if (this.DropDownContainer != null)
            {
                this.DropDownContainer.Controls.Add(this.calci);
            }

            this.DropDownContainer.Size = this.calci.Size;
            this.calci.ValueCalculated += new CalculatorValueCalculatedEventHandler(calci_ValueCalculated);
        }

        protected override bool OnSaveChanges()
        {
            Grid.Model[RowIndex, ColIndex].CellValue = calci.Value;
            return true;
        }

        public override void DropDownContainerCloseDropDown(object sender, Syncfusion.Windows.Forms.PopupClosedEventArgs e)
        {
            this.calci.ValueCalculated -= new CalculatorValueCalculatedEventHandler(calci_ValueCalculated);
            this.DropDownContainer.Controls.Remove(this.calci);
        }

    }
    #endregion
}