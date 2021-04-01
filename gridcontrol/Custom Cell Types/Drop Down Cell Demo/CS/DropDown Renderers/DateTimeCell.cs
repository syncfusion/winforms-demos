using System;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Drawing;
using System.Windows.Forms;
using System.Drawing;

namespace DropDownCellDemo
{
	#region the cell model class
	public class DateTimeCellModel : GridStaticCellModel
	{
		public DateTimeCellModel (GridModel grid)
			: base(grid)
		{	 

		}

		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new DateTimeCellRenderer(control, this);
		}
	}
	#endregion

	#region the cell renderer class

	public class DateTimeCellRenderer : GridStaticCellRenderer
	{
		private MyDateTimePicker dateTimePicker;

		public DateTimeCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
		{
			dateTimePicker = new MyDateTimePicker();
					
			dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			dateTimePicker.ShowUpDown = false;
			dateTimePicker.ShowCheckBox = false;
			dateTimePicker.ShowDropButton = true;
			dateTimePicker.Border3DStyle = Border3DStyle.Flat;
		
			grid.Controls.Add(dateTimePicker);

			//show & hide to make sure it is initilized properly for teh first use...
			dateTimePicker.Show();
			dateTimePicker.Hide();
            Grid.HScrollBar.ValueChanged += new EventHandler(HScrollBar_ValueChanged);
            Grid.VScrollBar.ValueChanged += new EventHandler(VScrollBar_ValueChanged);
        }

        void VScrollBar_ValueChanged(object sender, EventArgs e)
        {
            int row, col;
            Grid.PointToRowCol(dateTimePicker.Location, out row, out col);
            if (!Grid.ViewLayout.VisibleCellsRange.IntersectsWith(GridRangeInfo.Cell(row, col)) || (row <= this.Grid.Model.Rows.HeaderCount) || !(row.Equals(RowIndex) && col.Equals(ColIndex)))
            {
                this.dateTimePicker.Hide();
                this.dateTimePicker.ShowDropButton = false;
            }
            else
            {
                this.dateTimePicker.Show();
                this.dateTimePicker.ShowDropButton = true;
            }
            
        }

        void HScrollBar_ValueChanged(object sender, EventArgs e)
        {
            int row, col;
            Grid.PointToRowCol(dateTimePicker.Location, out row, out col);
            if (!Grid.ViewLayout.VisibleCellsRange.IntersectsWith(GridRangeInfo.Cell(row, col)) || (row <= this.Grid.Model.Rows.HeaderCount) || !(row.Equals(RowIndex) && col.Equals(ColIndex)))
            {
                this.dateTimePicker.Hide();
                this.dateTimePicker.ShowDropButton = false;
            }
            else
            {
                this.dateTimePicker.Show();
                this.dateTimePicker.ShowDropButton = true;
            }

        }

		#region usual renderer overrides

		//handle drawing the cell
		protected override void OnDraw(System.Drawing.Graphics g, System.Drawing.Rectangle clientRectangle, int rowIndex, int colIndex, Syncfusion.Windows.Forms.Grid.GridStyleInfo style)
		{
			if (Grid.CurrentCell.HasCurrentCellAt(rowIndex, colIndex) && CurrentCell.IsEditing)
			{
				dateTimePicker.Size = clientRectangle.Size;
				dateTimePicker.CustomFormat = style.Format;
				dateTimePicker.Font = style.GdipFont;
				dateTimePicker.Location = clientRectangle.Location;
                dateTimePicker.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
				dateTimePicker.Show();
				//if (!dateTimePicker.ContainsFocus)
					//dateTimePicker.Focus();
			}
			else
			{
				style.TextMargins.Left = 3; //avoid the little jump...
				base.OnDraw(g, clientRectangle, rowIndex, colIndex, style);
			}
		}

		//set the value into the cell control & initialize it
		protected override void OnInitialize(int rowIndex, int colIndex)
		{
			// Immeditaly switch into editing mode when cell is initialized.
			GridStyleInfo style = Grid.Model[rowIndex, colIndex];
            if (style.CultureInfo != null)
                dateTimePicker.Culture = style.CultureInfo;
			dateTimePicker.Value = (DateTime) style.CellValue;
			CurrentCell.BeginEdit();
			base.OnInitialize(rowIndex, colIndex);
			dateTimePicker.ValueChanged += new EventHandler(datePicker_ValueChanged);
            dateTimePicker.ShowDropButton = style.ShowButtons != GridShowButtons.Hide;
			dateTimePicker.Update();
		}

		//save the changes from the cell control to the grid cell
		protected override bool OnSaveChanges()
		{
			if (CurrentCell.IsModified)
			{
				Grid.Focus();
				GridStyleInfo style = Grid.Model[this.RowIndex, this.ColIndex];
				style.CellValue = this.dateTimePicker.Value;;
				return true;
			}
			return false;
		}
		//hide the control
		protected override void OnDeactived(int rowIndex, int colIndex)
		{
			if(dateTimePicker.Visible)
			{
				this.dateTimePicker.Hide();
				
			}
			dateTimePicker.ValueChanged -= new EventHandler(datePicker_ValueChanged);
			
		}

		private void datePicker_ValueChanged(object sender, EventArgs e)
		{
			CurrentCell.IsModified = true;
		}
		#endregion
	
		#region Click stuff

		//Simulate a click to place focus where user clicked in the control
		protected override void OnClick(int rowIndex, int colIndex, MouseEventArgs e)
		{
			base.OnClick(rowIndex, colIndex, e);
			if (e.Button == MouseButtons.Left)
			{
				ClickControl();
			}
		}

		private Timer t;
		private void ClickControl()
		{
			t = new Timer();
			t.Interval = 20;
			t.Tick += new EventHandler(click);
			t.Start();
		}

		private void click(object sender, EventArgs e)
		{
			t.Stop();
			t.Tick -= new EventHandler(click);
			Point p = this.dateTimePicker.PointToClient(Control.MousePosition);
			ActiveXSnapshot.FakeLeftMouseClick(this.dateTimePicker, p);
			t.Dispose();
			t = null;
		}
		#endregion

		//handle initial keystroke on inactive cell, passing it to the datetimepicker
		protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
		{
			if(!dateTimePicker.Focused)
			{
				dateTimePicker.Focus();
				SendKeys.Send(new string(e.KeyChar, 1));
			}
			base.OnKeyPress(e);
		}
		
	}

	#endregion

	#region derived DateTimePickerExt
	public class MyDateTimePicker : Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
	{
		public bool keyPressed = false;

		//pass the enter key back to the grid....
		//and trigger change event on other keystrokes...
		protected override bool ProcessCmdKey(ref Message msg,Keys keyData)
		{
			if(keyData == Keys.Enter)
				return false;

			if(msg.Msg == 0x100 && keyData != Keys.Tab) //keydown...
				this.OnValueChanged(EventArgs.Empty);

			return base.ProcessCmdKey(ref msg, keyData);
		}

	}
	#endregion
}