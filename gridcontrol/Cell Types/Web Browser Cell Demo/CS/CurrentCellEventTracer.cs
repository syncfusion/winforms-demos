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
using System.Drawing;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Diagnostics;

namespace GridSample
{
	/// <summary>
	/// Summary description for CurrentCellEventTracer.
	/// </summary>
	public class CurrentCellEventTracer
    {
        #region "API Definition"

        SplitterControl _splitter;
		ListBox _output;
		bool _displayMouseMessage = false;
		bool traceDebug = false;

        #endregion

        #region "Constructor"

        public CurrentCellEventTracer(SplitterControl splitter, ListBox output)
		{
			this._splitter = splitter;
			splitter.PaneCreated += new SplitterPaneEventHandler(splitter_PaneCreated);
			splitter.PaneClosing += new SplitterPaneEventHandler(splitter_PaneClosing);
			WireGrid(splitter.ActivePane as GridControl);
			this._output = output;
		}

        #endregion

        #region "WireGrid and UnwireGrid"
        public void WireGrid(GridControl grid)
		{
			grid.CurrentCellAcceptedChanges += new System.ComponentModel.CancelEventHandler(grid_CurrentCellAcceptedChanges);
			grid.CurrentCellMoved += new Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventHandler(grid_CurrentCellMoved);
			grid.CurrentCellActivateFailed += new Syncfusion.Windows.Forms.Grid.GridCurrentCellActivateFailedEventHandler(grid_CurrentCellActivateFailed);
			grid.CurrentCellActivated += new System.EventHandler(grid_CurrentCellActivated);
			grid.CurrentCellActivating += new GridCurrentCellActivatingEventHandler(grid_CurrentCellActivating);
			grid.CurrentCellChanged += new EventHandler(grid_CurrentCellChanged);
			grid.CurrentCellChanging += new CancelEventHandler(grid_CurrentCellChanging);
			grid.CurrentCellCloseDropDown += new PopupClosedEventHandler(grid_CurrentCellCloseDropDown);
			grid.CurrentCellConfirmChangesFailed += new EventHandler(grid_CurrentCellConfirmChangesFailed);
			grid.CurrentCellControlGotFocus += new ControlEventHandler(grid_CurrentCellControlGotFocus);
			grid.CurrentCellControlLostFocus += new ControlEventHandler(grid_CurrentCellControlLostFocus);
			grid.CurrentCellDeactivated += new GridCurrentCellDeactivatedEventHandler(grid_CurrentCellDeactivated);
			grid.CurrentCellDeactivateFailed += new EventHandler(grid_CurrentCellDeactivateFailed);
			grid.CurrentCellDeactivating += new CancelEventHandler(grid_CurrentCellDeactivating);
			grid.CurrentCellDeleting += new CancelEventHandler(grid_CurrentCellDeleting);
			grid.CurrentCellEditingComplete += new EventHandler(grid_CurrentCellEditingComplete);
			grid.CurrentCellInitializeControlText += new GridCurrentCellInitializeControlTextEventHandler(grid_CurrentCellInitializeControlText);
			grid.CurrentCellKeyDown += new KeyEventHandler(grid_CurrentCellKeyDown);
			grid.CurrentCellKeyPress +=new KeyPressEventHandler(grid_CurrentCellKeyPress);
			grid.CurrentCellKeyUp += new KeyEventHandler(grid_CurrentCellKeyUp);
			grid.CurrentCellMoved += new GridCurrentCellMovedEventHandler(grid_CurrentCellMoved);
			grid.CurrentCellMoveFailed += new GridCurrentCellMoveFailedEventHandler(grid_CurrentCellMoveFailed);
			grid.CurrentCellMoving += new GridCurrentCellMovingEventHandler(grid_CurrentCellMoving);
			grid.CurrentCellRejectedChanges += new EventHandler(grid_CurrentCellRejectedChanges);
			grid.CurrentCellShowedDropDown += new EventHandler(grid_CurrentCellShowedDropDown);
			grid.CurrentCellShowingDropDown += new GridCurrentCellShowingDropDownEventHandler(grid_CurrentCellShowingDropDown);
			grid.CurrentCellStartEditing += new CancelEventHandler(grid_CurrentCellStartEditing);
			grid.CurrentCellValidated += new EventHandler(grid_CurrentCellValidated);
			grid.CurrentCellValidateString += new GridCurrentCellValidateStringEventHandler(grid_CurrentCellValidateString);
			grid.CurrentCellValidating += new CancelEventHandler(grid_CurrentCellValidating);
			grid.CurrentCellControlDoubleClick += new ControlEventHandler(grid_CurrentCellControlDoubleClick);

			// Mouse events
			grid.CellButtonClicked += new GridCellButtonClickedEventHandler(grid_CellButtonClicked);
			grid.CellClick += new GridCellClickEventHandler(grid_CellClick);
			grid.CellDoubleClick += new GridCellClickEventHandler(grid_CellDoubleClick);
			grid.CellMouseDown += new GridCellMouseEventHandler(grid_CellMouseDown);
			grid.CellMouseHoverEnter += new GridCellMouseEventHandler(grid_CellMouseHoverEnter);
			grid.CellMouseHoverLeave += new GridCellMouseEventHandler(grid_CellMouseHoverLeave);
			grid.CellMouseUp += new GridCellMouseEventHandler(grid_CellMouseUp);
			grid.CheckBoxClick += new GridCellClickEventHandler(grid_CheckBoxClick);
			grid.PushButtonClick += new GridCellPushButtonClickEventHandler(grid_PushButtonClick);

			// Other events
			grid.Click += new EventHandler(grid_Click);
			grid.Deactivated += new EventHandler(grid_Deactivated);
			grid.DoubleClick += new EventHandler(grid_DoubleClick);
			grid.DragDrop += new DragEventHandler(grid_DragDrop);
			grid.DragEnter += new DragEventHandler(grid_DragEnter);
			grid.DragLeave += new EventHandler(grid_DragLeave);
			grid.DragOver += new DragEventHandler(grid_DragOver);
			grid.Enter += new EventHandler(grid_Enter);
			grid.GotFocus += new EventHandler(grid_GotFocus);
			grid.KeyDown += new KeyEventHandler(grid_KeyDown);
			grid.KeyPress += new KeyPressEventHandler(grid_KeyPress);
			grid.KeyUp += new KeyEventHandler(grid_KeyUp);
			grid.Layout += new LayoutEventHandler(grid_Layout);
			grid.Leave += new EventHandler(grid_Leave);
			grid.LostFocus += new EventHandler(grid_LostFocus);
			grid.MouseDown += new MouseEventHandler(grid_MouseDown);
			grid.MouseUp += new MouseEventHandler(grid_MouseUp);
			grid.MouseEnter += new EventHandler(grid_MouseEnter);
			grid.MouseLeave	+= new EventHandler(grid_MouseLeave);
			grid.QueryCanOleDragRange += new GridQueryCanOleDragRangeEventHandler(grid_QueryCanOleDragRange);
			grid.QueryNextCurrentCellPosition += new GridQueryNextCurrentCellPositionEventHandler(grid_QueryNextCurrentCellPosition);
			grid.QueryOleDataSourceData += new GridQueryOleDataSourceDataEventHandler(grid_QueryOleDataSourceData);
			grid.ResizingColumns += new GridResizingColumnsEventHandler(grid_ResizingColumns);
			grid.ResizingRows += new GridResizingRowsEventHandler(grid_ResizingRows);
			grid.ScrollInfoChanged += new EventHandler(grid_ScrollInfoChanged);
			grid.SelectionDragging += new GridSelectionDragEventHandler(grid_SelectionDragging);
			grid.SelectionDragged += new GridSelectionDragEventHandler(grid_SelectionDragged);
			grid.StartAutoScrolling += new StartAutoScrollingEventHandler(grid_StartAutoScrolling);
			grid.Validated += new EventHandler(grid_Validated);
			grid.Validating += new CancelEventHandler(grid_Validating);
			grid.WrapCellNextControlInForm += new GridWrapCellNextControlInFormEventHandler(grid_WrapCellNextControlInForm);
		}

		public void UnwireGrid(GridControl grid)
		{
			grid.CurrentCellAcceptedChanges -= new System.ComponentModel.CancelEventHandler(grid_CurrentCellAcceptedChanges);
			grid.CurrentCellMoved -= new Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventHandler(grid_CurrentCellMoved);
			grid.CurrentCellActivateFailed -= new Syncfusion.Windows.Forms.Grid.GridCurrentCellActivateFailedEventHandler(grid_CurrentCellActivateFailed);
			grid.CurrentCellActivated -= new System.EventHandler(grid_CurrentCellActivated);
			grid.CurrentCellActivating -= new GridCurrentCellActivatingEventHandler(grid_CurrentCellActivating);
			grid.CurrentCellChanged -= new EventHandler(grid_CurrentCellChanged);
			grid.CurrentCellChanging -= new CancelEventHandler(grid_CurrentCellChanging);
			grid.CurrentCellCloseDropDown -= new PopupClosedEventHandler(grid_CurrentCellCloseDropDown);
			grid.CurrentCellConfirmChangesFailed -= new EventHandler(grid_CurrentCellConfirmChangesFailed);
			grid.CurrentCellControlGotFocus -= new ControlEventHandler(grid_CurrentCellControlGotFocus);
			grid.CurrentCellControlLostFocus -= new ControlEventHandler(grid_CurrentCellControlLostFocus);
			grid.CurrentCellDeactivated -= new GridCurrentCellDeactivatedEventHandler(grid_CurrentCellDeactivated);
			grid.CurrentCellDeactivateFailed -= new EventHandler(grid_CurrentCellDeactivateFailed);
			grid.CurrentCellDeactivating -= new CancelEventHandler(grid_CurrentCellDeactivating);
			grid.CurrentCellDeleting -= new CancelEventHandler(grid_CurrentCellDeleting);
			grid.CurrentCellEditingComplete -= new EventHandler(grid_CurrentCellEditingComplete);
			grid.CurrentCellInitializeControlText -= new GridCurrentCellInitializeControlTextEventHandler(grid_CurrentCellInitializeControlText);
			grid.CurrentCellKeyDown -= new KeyEventHandler(grid_CurrentCellKeyDown);
			grid.CurrentCellKeyPress -=new KeyPressEventHandler(grid_CurrentCellKeyPress);
			grid.CurrentCellKeyUp -= new KeyEventHandler(grid_CurrentCellKeyUp);
			grid.CurrentCellMoved -= new GridCurrentCellMovedEventHandler(grid_CurrentCellMoved);
			grid.CurrentCellMoveFailed -= new GridCurrentCellMoveFailedEventHandler(grid_CurrentCellMoveFailed);
			grid.CurrentCellMoving -= new GridCurrentCellMovingEventHandler(grid_CurrentCellMoving);
			grid.CurrentCellRejectedChanges -= new EventHandler(grid_CurrentCellRejectedChanges);
			grid.CurrentCellShowedDropDown -= new EventHandler(grid_CurrentCellShowedDropDown);
			grid.CurrentCellShowingDropDown -= new GridCurrentCellShowingDropDownEventHandler(grid_CurrentCellShowingDropDown);
			grid.CurrentCellStartEditing -= new CancelEventHandler(grid_CurrentCellStartEditing);
			grid.CurrentCellValidated -= new EventHandler(grid_CurrentCellValidated);
			grid.CurrentCellValidateString -= new GridCurrentCellValidateStringEventHandler(grid_CurrentCellValidateString);
			grid.CurrentCellControlDoubleClick -= new ControlEventHandler(grid_CurrentCellControlDoubleClick);

			grid.CellButtonClicked -= new GridCellButtonClickedEventHandler(grid_CellButtonClicked);
			grid.CellClick -= new GridCellClickEventHandler(grid_CellClick);
			grid.CellDoubleClick -= new GridCellClickEventHandler(grid_CellDoubleClick);
			grid.CellMouseDown -= new GridCellMouseEventHandler(grid_CellMouseDown);
			grid.CellMouseHoverEnter -= new GridCellMouseEventHandler(grid_CellMouseHoverEnter);
			grid.CellMouseHoverLeave -= new GridCellMouseEventHandler(grid_CellMouseHoverLeave);
			grid.CellMouseUp -= new GridCellMouseEventHandler(grid_CellMouseUp);
			grid.CheckBoxClick -= new GridCellClickEventHandler(grid_CheckBoxClick);
			grid.PushButtonClick -= new GridCellPushButtonClickEventHandler(grid_PushButtonClick);
		
			// Other events
			grid.Click -= new EventHandler(grid_Click);
			grid.Deactivated -= new EventHandler(grid_Deactivated);
			grid.DoubleClick -= new EventHandler(grid_DoubleClick);
			grid.DragDrop -= new DragEventHandler(grid_DragDrop);
			grid.DragEnter -= new DragEventHandler(grid_DragEnter);
			grid.DragLeave -= new EventHandler(grid_DragLeave);
			grid.DragOver -= new DragEventHandler(grid_DragOver);
			grid.Enter -= new EventHandler(grid_Enter);
			grid.GotFocus -= new EventHandler(grid_GotFocus);
			grid.KeyDown -= new KeyEventHandler(grid_KeyDown);
			grid.KeyPress -= new KeyPressEventHandler(grid_KeyPress);
			grid.KeyUp -= new KeyEventHandler(grid_KeyUp);
			grid.Layout -= new LayoutEventHandler(grid_Layout);
			grid.Leave -= new EventHandler(grid_Leave);
			grid.LostFocus -= new EventHandler(grid_LostFocus);
			grid.MouseDown -= new MouseEventHandler(grid_MouseDown);
			grid.MouseUp -= new MouseEventHandler(grid_MouseUp);
			grid.MouseEnter -= new EventHandler(grid_MouseEnter);
			grid.MouseLeave	-= new EventHandler(grid_MouseLeave);
			grid.QueryCanOleDragRange -= new GridQueryCanOleDragRangeEventHandler(grid_QueryCanOleDragRange);
			grid.QueryNextCurrentCellPosition -= new GridQueryNextCurrentCellPositionEventHandler(grid_QueryNextCurrentCellPosition);
			grid.QueryOleDataSourceData -= new GridQueryOleDataSourceDataEventHandler(grid_QueryOleDataSourceData);
			grid.ResizingColumns -= new GridResizingColumnsEventHandler(grid_ResizingColumns);
			grid.ResizingRows -= new GridResizingRowsEventHandler(grid_ResizingRows);
			grid.ScrollInfoChanged -= new EventHandler(grid_ScrollInfoChanged);
			grid.SelectionDragging -= new GridSelectionDragEventHandler(grid_SelectionDragging);
			grid.SelectionDragged -= new GridSelectionDragEventHandler(grid_SelectionDragged);
			grid.StartAutoScrolling -= new StartAutoScrollingEventHandler(grid_StartAutoScrolling);
			grid.Validated -= new EventHandler(grid_Validated);
			grid.Validating -= new CancelEventHandler(grid_Validating);
			grid.WrapCellNextControlInForm -= new GridWrapCellNextControlInFormEventHandler(grid_WrapCellNextControlInForm);
		}
        #endregion

        #region "Events Appending"

        private void splitter_PaneCreated(object sender, SplitterPaneEventArgs e)
		{
			GridControl grid = e.Control as GridControl;
			WireGrid(grid);
		}

		private void splitter_PaneClosing(object sender, SplitterPaneEventArgs e)
		{
			GridControl grid = e.Control as GridControl;
			UnwireGrid(grid);
		}

		string lastLine = "";

		string GetInfo(string name)
		{
			GridControl grid = this._splitter.ActivePane as GridControl;
			string s = "";
			if (grid != null)
			{
				if (grid.CurrentCell.HasCurrentCell)
				{
					GridCurrentCell cc = grid.CurrentCell;
					GridCellRendererBase renderer = cc.Renderer;
					GridStyleInfo style = grid[cc.RowIndex, cc.ColIndex];

					string ct = "";
					if (renderer.HasControlText)
						ct = " ControlText: " + renderer.ControlText;
					string cv = "";
					if (renderer.HasControlValue)
					{
						if (renderer.ControlValue != null)
							ct = " ControlValue: " + renderer.ControlValue.ToString();
						else
							ct = " ControlValue: null";
					}
					string st = style.Text;
					string sv = "";
					if (style.CellValue != null)
						sv = style.CellValue.ToString();

					s = string.Format("{0}{1} {2}\"{3}\", \"{4}\", StyleText: \"{5}\", StyleValue: \"{6}\" ",
						cc.IsModified ? "*" : "",
						name,
						grid.CurrentCell.RangeInfo, 
						ct,
						cv,
						st, 
						sv
						);
				}
				else
				{
					s = name; 
				}
			}	
			return s;
		}

		bool _enabled = false;

		public bool Enabled
		{
			get
			{
				return _enabled;
			}
			set
			{
				_enabled = value;
			}
		}

		public bool DisplayMouseMessages
		{
			get
			{
				return _displayMouseMessage;
			}
			set
			{
				_displayMouseMessage = value;
			}
		}

		void AppendOutput(string name, EventArgs e)
		{
			if (!Enabled)
				return;

			string s = "";
			if (name.StartsWith("CurrentCell"))
			{
				//name = name.Substring("CurrentCell".Length);

				s = GetInfo(name) + " " + e.ToString();
			}
			else if (DisplayMouseMessages)
				s = name + " " + e.ToString();

			if (s.Length > 0)
			{
				if (s != lastLine)
				{
					lastLine = s;
					_output.SelectedIndex = -1;
					_output.Items.Add(s + "\n");
					_output.TopIndex = Math.Max(0, _output.Items.Count - (_output.Height/_output.ItemHeight));
				}
			}
		}

		public override string ToString()
		{
			return GetInfo("");
		}

		private void grid_CurrentCellMoved(object sender, Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellMoved", e);
		}

		private void grid_CurrentCellAcceptedChanges(object sender, System.ComponentModel.CancelEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellAcceptedChanges", e);
		}

		private void grid_CurrentCellActivated(object sender, System.EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellActivated", e);
		}

		private void grid_CurrentCellActivateFailed(object sender, Syncfusion.Windows.Forms.Grid.GridCurrentCellActivateFailedEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellActivateFailed", e);
		}

		private void grid_CurrentCellActivating(object sender, GridCurrentCellActivatingEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellActivating", e);
		}

		private void grid_CurrentCellChanged(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellChanged", e);

		}

		private void grid_CurrentCellChanging(object sender, CancelEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellChanging", e);

		}

		private void grid_CurrentCellCloseDropDown(object sender, PopupClosedEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellCloseDropDown", e);

		}

		private void grid_CurrentCellControlLostFocus(object sender, ControlEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellControlLostFocus", e);

		}

		private void grid_CurrentCellMoveFailed(object sender, GridCurrentCellMoveFailedEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellMoveFailed", e);

		}

		private void grid_CurrentCellRejectedChanges(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellRejectedChanges", e);

		}

		private void grid_CurrentCellShowedDropDown(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellShowedDropDown", e);

		}

		private void grid_CurrentCellShowingDropDown(object sender, GridCurrentCellShowingDropDownEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellShowingDropDown", e);

		}

		private void grid_CurrentCellStartEditing(object sender, CancelEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellStartEditing", e);

		}

		private void grid_CurrentCellValidated(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellValidated", e);

		}

		private void grid_CurrentCellValidating(object sender, CancelEventArgs e)
		{
			// Force the Renderer.ControValue to be in sync with the
			// displayed text. You have to decide on a case by case basis
			// (depeding on what cell renderer you have) if you want to do this ...
			//GridControlBase grid = (GridControlBase) sender;
			//grid.CurrentCell.Renderer.UpdateControlValue();

			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellValidating", e);
		}

		private void grid_CurrentCellControlDoubleClick(object sender, ControlEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellControlDoubleClick", e);
		}

		private void grid_CurrentCellConfirmChangesFailed(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellConfirmChangesFailed", e);
		}

		private void grid_CurrentCellControlGotFocus(object sender, ControlEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellControlGotFocus", e);

		}

		private void grid_CurrentCellDeactivateFailed(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellDeactivateFailed", e);

		}

		private void grid_CurrentCellDeactivating(object sender, CancelEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellDeactivating", e);

		}

		private void grid_CurrentCellEditingComplete(object sender, EventArgs e)
		{

			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellEditingComplete", e);
		}

		private void grid_CurrentCellKeyDown(object sender, KeyEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellKeyDown", e);

		}

		private void grid_CurrentCellKeyPress(object sender, KeyPressEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellKeyPress", e);

		}

		private void grid_CurrentCellKeyUp(object sender, KeyEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellKeyUp", e);

		}

		private void grid_CurrentCellDeleting(object sender, CancelEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellDeleting", e);

		}

		private void grid_CurrentCellMoving(object sender, GridCurrentCellMovingEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellMoving", e);

		}

		private void grid_CurrentCellDeactivated(object sender, GridCurrentCellDeactivatedEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellDeactivated", e);

		}

		private void grid_CurrentCellInitializeControlText(object sender, GridCurrentCellInitializeControlTextEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellInitializeControlText", e);

		}

		private void grid_CurrentCellValidateString(object sender, GridCurrentCellValidateStringEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CurrentCellValidateString", e);
			
		}

		private void grid_CellButtonClicked(object sender, GridCellButtonClickedEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CellButtonClicked", e);

		}

		private void grid_CellClick(object sender, GridCellClickEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CellClick", e);

		}

		private void grid_CellDoubleClick(object sender, GridCellClickEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CellDoubleClick", e);

		}

		private void grid_CellMouseDown(object sender, GridCellMouseEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CellMouseDown", e);

		}

		private void grid_CellMouseHoverEnter(object sender, GridCellMouseEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CellMouseHoverEnter", e);

		}

		private void grid_CellMouseHoverLeave(object sender, GridCellMouseEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CellMouseHoverLeave", e);

		}

		private void grid_CellMouseUp(object sender, GridCellMouseEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CellMouseUp", e);

		}

		private void grid_CheckBoxClick(object sender, GridCellClickEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("CheckBoxClick", e);

		}

		private void grid_PushButtonClick(object sender, GridCellPushButtonClickEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("PushButtonClick", e);

		}

		private void grid_Click(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("Click", e);
		}

		private void grid_Deactivated(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("Deactivated", e);
		}

		private void grid_DoubleClick(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("DoubleClick", e);
		}

		private void grid_DragDrop(object sender, DragEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("DragDrop", e);
		}

		private void grid_DragEnter(object sender, DragEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("DragEnter", e);
		}

		private void grid_DragLeave(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("DragLeave", e);
		}

		private void grid_DragOver(object sender, DragEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("DragOver", e);
		}

		private void grid_Enter(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("Enter", e);
		}

		private void grid_GotFocus(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("GotFocus", e);
		}

		private void grid_KeyDown(object sender, KeyEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("KeyDown", e);
		}

		private void grid_KeyPress(object sender, KeyPressEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("KeyPress", e);
		}

		private void grid_KeyUp(object sender, KeyEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("KeyUp", e);
		}

		private void grid_Layout(object sender, LayoutEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("Layout", e);
		}

		private void grid_Leave(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("Leave", e);
		}

		private void grid_LostFocus(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("LostFocus", e);
		}
		
		private void grid_MouseDown(object sender, MouseEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("MouseDown", e);
		}

		private void grid_MouseUp(object sender, MouseEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("MouseUp", e);
		}

		private void grid_MouseEnter(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("MouseEnter", e);
		}

		private void grid_MouseLeave(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("MouseLeave", e);
		}

		private void grid_QueryCanOleDragRange(object sender, GridQueryCanOleDragRangeEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("QueryCanOleDragRange", e);
		}

		private void grid_QueryNextCurrentCellPosition(object sender, GridQueryNextCurrentCellPositionEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("QueryNextCurrentCellPosition", e);
		}

		private void grid_QueryOleDataSourceData(object sender, GridQueryOleDataSourceDataEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("QueryOleDataSourceData", e);
		}

		private void grid_ResizingColumns(object sender, GridResizingColumnsEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("ResizingColumns", e);
		}

		private void grid_ResizingRows(object sender, GridResizingRowsEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("ResizingRows", e);
		}

		private void grid_ScrollInfoChanged(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("ScrollInfoChanged", e);
		}

		private void grid_SelectionDragging(object sender, GridSelectionDragEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("SelectionDragging", e);
		}

		private void grid_SelectionDragged(object sender, GridSelectionDragEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("SelectionDragged", e);
		}

		private void grid_StartAutoScrolling(object sender, StartAutoScrollingEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("StartAutoScrolling", e);
		}

		private void grid_Validated(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("Validated", e);
		}

		private void grid_Validating(object sender, CancelEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("Validating", e);
		}

		private void grid_WrapCellNextControlInForm(object sender, GridWrapCellNextControlInFormEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
			AppendOutput("WrapCellNextControlInForm", e);
        }
        #endregion
    }
}