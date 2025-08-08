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
using ComboboxCells;

namespace GridSample
{
	/// <summary>
	/// Summary description for CurrentCellEventTracer.
	/// </summary>
	public class CurrentCellEventTracer
    {
        #region "API Definition"

        SplitterControl _splitter;
		bool _displayMouseMessage = false;
		bool traceDebug = false;
        public int count = 1;
        EventTracer etracer;
        #endregion

        #region "Constructor"
        public CurrentCellEventTracer(SplitterControl splitter, EventTracer output)
		{
			this._splitter = splitter;
            this.etracer = output;
			splitter.PaneCreated += new SplitterPaneEventHandler(splitter_PaneCreated);
			splitter.PaneClosing += new SplitterPaneEventHandler(splitter_PaneClosing);
			WireGrid(splitter.ActivePane as GridControl);
        }
        #endregion


        #region "Wire and UnwireGrid"

        public void WireGrid(GridControl grid)
        {
            grid.AccelerateScrollingChanged += new EventHandler(grid_AccelerateScrollingChanged);
            //grid.ActivateToolTip += new GridActivateToolTipEventHandler(grid_ActivateToolTip);
            grid.AutoScrollingChanged += new EventHandler(grid_AutoScrollingChanged);
            grid.BackColorChanged += new EventHandler(grid_BackColorChanged);
            grid.BackgroundImageChanged += new EventHandler(grid_BackgroundImageChanged);
            grid.BackgroundImageLayoutChanged += new EventHandler(grid_BackgroundImageLayoutChanged);
            grid.BanneredRangesChanged += new GridBanneredRangesChangedEventHandler(grid_BanneredRangesChanged);
            grid.BanneredRangesChanging += new GridBanneredRangesChangingEventHandler(grid_BanneredRangesChanging);
            grid.BaseStylesMapChanged += new EventHandler(grid_BaseStylesMapChanged);
            grid.BeginUpdateRequest += new EventHandler(grid_BeginUpdateRequest);
            grid.BindingContextChanged += new EventHandler(grid_BindingContextChanged);
            grid.CancelMode += new EventHandler(grid_CancelMode);
            grid.CausesValidationChanged += new EventHandler(grid_CausesValidationChanged);
            grid.CellCancelMode += new GridCellMouseEventHandler(grid_CellCancelMode);
            //grid.CellCursor += new GridCellCursorEventHandler(grid_CellCursor);
            //grid.CellDrawn += new GridDrawCellEventHandler(grid_CellDrawn);
            //grid.CellHitTest += new GridCellHitTestEventHandler(grid_CellHitTest);
            grid.CellModelsChanged += new CollectionChangeEventHandler(grid_CellModelsChanged);
            grid.CellMouseHover += new GridCellMouseEventHandler(grid_CellMouseHover);
            grid.CellMouseMove += new GridCellMouseEventHandler(grid_CellMouseMove);
            grid.CellsChanged += new GridCellsChangedEventHandler(grid_CellsChanged);
            grid.CellsChanging += new GridCellsChangingEventHandler(grid_CellsChanging);
            grid.ChangeUICues += new UICuesEventHandler(grid_ChangeUICues);
            grid.ClearingCells += new GridClearingCellsEventHandler(grid_ClearingCells);
            grid.ClientSizeChanged += new EventHandler(grid_ClientSizeChanged);
            grid.ClipboardCanCopy += new GridCutPasteEventHandler(grid_ClipboardCanCopy);
            grid.ClipboardCanCut += new GridCutPasteEventHandler(grid_ClipboardCanCut);
            grid.ClipboardCanPaste += new GridCutPasteEventHandler(grid_ClipboardCanPaste);
            grid.ClipboardCopy += new GridCutPasteEventHandler(grid_ClipboardCopy);
            grid.ClipboardCut += new GridCutPasteEventHandler(grid_ClipboardCut);
            grid.ClipboardPaste += new GridCutPasteEventHandler(grid_ClipboardPaste);
            grid.ColsHidden += new GridRowColHiddenEventHandler(grid_ColsHidden);
            grid.ColsHiding += new GridRowColHidingEventHandler(grid_ColsHiding);
            grid.ColsInserted += new GridRangeInsertedEventHandler(grid_ColsInserted);
            grid.ColsMoved += new GridRangeMovedEventHandler(grid_ColsMoved);
            grid.ColsMoving += new GridRangeMovingEventHandler(grid_ColsMoving);
            grid.ColsRemoved += new GridRangeRemovedEventHandler(grid_ColsRemoved);
            grid.ColsRemoving += new GridRangeRemovingEventHandler(grid_ColsRemoving);
            grid.ColWidthsChanged += new GridRowColSizeChangedEventHandler(grid_ColWidthsChanged);
            grid.ColWidthsChanging += new GridRowColSizeChangingEventHandler(grid_ColWidthsChanging);
            grid.ConfirmingPendingChanges += new CancelEventHandler(grid_ConfirmingPendingChanges);
            grid.ContextMenuChanged += new EventHandler(grid_ContextMenuChanged);
            grid.ContextMenuStripChanged += new EventHandler(grid_ContextMenuStripChanged);
            grid.ControlAdded += new ControlEventHandler(grid_ControlAdded);
            grid.ControllerOptionsChanged += new EventHandler(grid_ControllerOptionsChanged);
            grid.ControlRemoved += new ControlEventHandler(grid_ControlRemoved);
            grid.CoveredRangesChanged += new GridCoveredRangesChangedEventHandler(grid_CoveredRangesChanged);
            grid.CoveredRangesChanging += new GridCoveredRangesChangingEventHandler(grid_CoveredRangesChanging);
            grid.CurrentCellControlKeyMessage += new GridCurrentCellControlKeyMessageEventHandler(grid_CurrentCellControlKeyMessage);
            grid.CurrentCellErrorMessage += new GridCurrentCellErrorMessageEventHandler(grid_CurrentCellErrorMessage);
            grid.CursorChanged += new EventHandler(grid_CursorChanged);
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
            grid.CurrentCellKeyPress += new KeyPressEventHandler(grid_CurrentCellKeyPress);
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
            grid.DataChanged += new EventHandler(grid_DataChanged);
            grid.DataObjectConsumerOptionsChanged += new EventHandler(grid_DataObjectConsumerOptionsChanged);
            grid.DefaultColWidthChanged += new GridDefaultSizeChangedEventHandler(grid_DefaultColWidthChanged);
            //grid.DrawCell += new GridDrawCellEventHandler(grid_DrawCell);
            grid.DefaultColWidthChanging += new GridDefaultSizeChangingEventHandler(grid_DefaultColWidthChanging);
            grid.DefaultRowHeightChanged += new GridDefaultSizeChangedEventHandler(grid_DefaultRowHeightChanged);
            grid.DefaultRowHeightChanging += new GridDefaultSizeChangingEventHandler(grid_DefaultRowHeightChanging);
            grid.Disposed += new EventHandler(grid_Disposed);
            grid.DockChanged += new EventHandler(grid_DockChanged);
            grid.DrawCellBackground += new GridDrawCellBackgroundEventHandler(grid_DrawCellBackground);
            grid.DrawCellButton += new GridDrawCellButtonEventHandler(grid_DrawCellButton);
            grid.DrawCellButtonBackground += new GridDrawCellButtonBackgroundEventHandler(grid_DrawCellButtonBackground);
            grid.DrawCellDisplayText += new GridDrawCellDisplayTextEventHandler(grid_DrawCellDisplayText);
            grid.DrawCellFrameAppearance += new GridDrawCellBackgroundEventHandler(grid_DrawCellFrameAppearance);
            grid.DrawCurrentCellBorder += new GridDrawCurrentCellBorderEventHandler(grid_DrawCurrentCellBorder);
            grid.Deactivated += new EventHandler(grid_Deactivated);
            grid.DoubleClick += new EventHandler(grid_DoubleClick);
            grid.DragDrop += new DragEventHandler(grid_DragDrop);
            grid.DragEnter += new DragEventHandler(grid_DragEnter);
            grid.DragLeave += new EventHandler(grid_DragLeave);
            grid.DragOver += new DragEventHandler(grid_DragOver);
            grid.EnabledChanged += new EventHandler(grid_EnabledChanged);
            grid.EndUpdateRequest += new GridEndUpdateRequestEventHandler(grid_EndUpdateRequest);
            grid.Enter += new EventHandler(grid_Enter);
            grid.FileNameChanged += new EventHandler(grid_FileNameChanged);
            grid.FillRectangleHook += new GridFillRectangleHookEventHandler(grid_FillRectangleHook);
            grid.FillSplitterPaneChanged += new EventHandler(grid_FillSplitterPaneChanged);
            grid.FloatingCellsChanged += new GridFloatingCellsChangedEventHandler(grid_FloatingCellsChanged);
            grid.FontChanged += new EventHandler(grid_FontChanged);
            grid.ForeColorChanged += new EventHandler(grid_ForeColorChanged);
            grid.FrozenColCountChanged += new GridCountChangedEventHandler(grid_FrozenColCountChanged);
            grid.FrozenColCountChanging += new GridCountChangingEventHandler(grid_FrozenColCountChanging);
            grid.FrozenRowCountChanged += new GridCountChangedEventHandler(grid_FrozenRowCountChanged);
            grid.FrozenRowCountChanging += new GridCountChangingEventHandler(grid_FrozenRowCountChanging);
            grid.GiveFeedback += new GiveFeedbackEventHandler(grid_GiveFeedback);
            grid.GridBoundsChanged += new EventHandler(grid_GridBoundsChanged);
            grid.GridControlMouseDown += new CancelMouseEventHandler(grid_GridControlMouseDown);
            grid.GridControlMouseMove += new CancelMouseEventHandler(grid_GridControlMouseMove);
            grid.GridControlMouseUp += new CancelMouseEventHandler(grid_GridControlMouseUp);
            grid.GotFocus += new EventHandler(grid_GotFocus);
            grid.HandleCreated += new EventHandler(grid_HandleCreated);
            grid.HandleDestroyed += new EventHandler(grid_HandleDestroyed);
            grid.HeaderColCountChanged += new GridCountChangedEventHandler(grid_HeaderColCountChanged);
            grid.HeaderColCountChanging += new GridCountChangingEventHandler(grid_HeaderColCountChanging);
            grid.HeaderRowCountChanged += new GridCountChangedEventHandler(grid_HeaderRowCountChanged);
            grid.HeaderRowCountChanging += new GridCountChangingEventHandler(grid_HeaderRowCountChanging);
            grid.HelpRequested += new HelpEventHandler(grid_HelpRequested);
            grid.HorizontalScroll += new ScrollEventHandler(grid_HorizontalScroll);
            grid.HScrollPixelPosChanged += new GridScrollPositionChangedEventHandler(grid_HScrollPixelPosChanged);
            grid.HScrollPixelPosChanging += new GridScrollPositionChangingEventHandler(grid_HScrollPixelPosChanging);
            grid.ImeModeChanged += new EventHandler(grid_ImeModeChanged);
            grid.IntelliMouseDragScrolling += new IntelliMouseDragScrollEventHandler(grid_IntelliMouseDragScrolling);
            grid.Invalidated += new InvalidateEventHandler(grid_Invalidated);
            grid.KeyDown += new KeyEventHandler(grid_KeyDown);
            grid.KeyPress += new KeyPressEventHandler(grid_KeyPress);
            grid.KeyUp += new KeyEventHandler(grid_KeyUp);
            grid.LeftColChanged += new GridRowColIndexChangedEventHandler(grid_LeftColChanged);
            grid.LeftColChanging += new GridRowColIndexChangingEventHandler(grid_LeftColChanging);
            grid.LocationChanged += new EventHandler(grid_LocationChanged);
            grid.Layout += new LayoutEventHandler(grid_Layout);
            grid.Leave += new EventHandler(grid_Leave);
            grid.LostFocus += new EventHandler(grid_LostFocus);
            grid.MouseDown += new MouseEventHandler(grid_MouseDown);
            grid.MouseUp += new MouseEventHandler(grid_MouseUp);
            grid.MouseEnter += new EventHandler(grid_MouseEnter);
            grid.MouseLeave += new EventHandler(grid_MouseLeave);
            grid.MarginChanged += new EventHandler(grid_MarginChanged);
            grid.MergeCellsChanged += new GridMergeCellsChangedEventHandler(grid_MergeCellsChanged);
            grid.ModelChanged += new EventHandler(grid_ModelChanged);
            grid.ModifiedChanged += new EventHandler(grid_ModifiedChanged);
            grid.MouseActivating += new CancelEventHandler(grid_MouseActivating);
            grid.MouseCaptureChanged += new EventHandler(grid_MouseCaptureChanged);
            grid.MouseClick += new MouseEventHandler(grid_MouseClick);
            grid.MouseHover += new EventHandler(grid_MouseHover);
            grid.MouseMove += new MouseEventHandler(grid_MouseMove);
            grid.MouseWheel += new MouseEventHandler(grid_MouseWheel);
            grid.MouseWheelZoom += new MouseWheelZoomEventHandler(grid_MouseWheelZoom);
            grid.Move += new EventHandler(grid_Move);
            grid.MoveCurrentCellDirection += new GridMoveCurrentCellDirectionEventHandler(grid_MoveCurrentCellDirection);
            grid.Office2007ScrollBarsChanged += new EventHandler(grid_Office2007ScrollBarsChanged);
            grid.Office2007ScrollBarsColorSchemeChanged += new EventHandler(grid_Office2007ScrollBarsColorSchemeChanged);
            grid.OperationFeedback += new Syncfusion.ComponentModel.OperationFeedbackEventHandler(grid_OperationFeedback);
            grid.OperationFeedback += new Syncfusion.ComponentModel.OperationFeedbackEventHandler(grid_OperationFeedback);
            grid.PaddingChanged += new EventHandler(grid_PaddingChanged);
            grid.ParentChanged += new EventHandler(grid_ParentChanged);
            grid.ParseCommonFormats += new GridCellTextEventHandler(grid_ParseCommonFormats);
            grid.PasteCellText += new GridPasteCellTextEventHandler(grid_PasteCellText);
            grid.PrepareChangeSelection += new GridPrepareChangeSelectionEventHandler(grid_PrepareChangeSelection);
            grid.PrepareClearSelection += new EventHandler(grid_PrepareClearSelection);
            grid.PrepareGraphics += new Syncfusion.Drawing.GraphicsEventHandler(grid_PrepareGraphics);
            //grid.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(grid_PrepareViewStyleInfo);
            grid.PreviewKeyDown += new PreviewKeyDownEventHandler(grid_PreviewKeyDown);
            grid.PrintingModeChanged += new EventHandler(grid_PrintingModeChanged);

            //grid.QueryBanneredRange += new GridQueryBanneredRangeEventHandler(grid_QueryBanneredRange);
            //grid.QueryCellInfo += new GridQueryCellInfoEventHandler(grid_QueryCellInfo);
            //grid.QueryColWidth += new GridRowColSizeEventHandler(grid_QueryColWidth);
            //grid.QueryCoveredRange += new GridQueryCoveredRangeEventHandler(grid_QueryCoveredRange);
            //grid.QueryRowHeight += new GridRowColSizeEventHandler(grid_QueryRowHeight);
            grid.ReadOnlyChanged += new EventHandler(grid_ReadOnlyChanged);
            grid.RefreshRequest += new EventHandler(grid_RefreshRequest);
            grid.RegionChanged += new EventHandler(grid_RegionChanged);
            grid.Resize += new EventHandler(grid_Resize);
            grid.RightToLeftChanged += new EventHandler(grid_RightToLeftChanged);
            grid.RowHeightsChanged += new GridRowColSizeChangedEventHandler(grid_RowHeightsChanged);
            grid.RowHeightsChanging += new GridRowColSizeChangingEventHandler(grid_RowHeightsChanging);
            grid.RowsHidden += new GridRowColHiddenEventHandler(grid_RowsHidden);
            grid.RowsHiding += new GridRowColHidingEventHandler(grid_RowsHiding);
            grid.RowsInserted += new GridRangeInsertedEventHandler(grid_RowsInserted);
            grid.RowsInserting += new GridRangeInsertingEventHandler(grid_RowsInserting);
            grid.RowsMoved += new GridRangeMovedEventHandler(grid_RowsMoved);
            grid.RowsMoving += new GridRangeMovingEventHandler(grid_RowsMoving);
            grid.RowsRemoved += new GridRangeRemovedEventHandler(grid_RowsRemoved);
            grid.RowsRemoving += new GridRangeRemovingEventHandler(grid_RowsRemoving);
            grid.ResizingColumns += new GridResizingColumnsEventHandler(grid_ResizingColumns);
            grid.ResizingRows += new GridResizingRowsEventHandler(grid_ResizingRows);
            grid.SaveCellFormattedText += new GridCellTextEventHandler(grid_SaveCellFormattedText);
            grid.SaveCellInfo += new GridSaveCellInfoEventHandler(grid_SaveCellInfo);
            grid.SaveCellText += new GridCellTextEventHandler(grid_SaveCellText);
            grid.SaveColCount += new GridRowColCountEventHandler(grid_SaveColCount);
            grid.SaveColWidth += new GridRowColSizeEventHandler(grid_SaveColWidth);
            grid.SaveRowCount += new GridRowColCountEventHandler(grid_SaveRowCount);
            grid.SaveRowHeight += new GridRowColSizeEventHandler(grid_SaveRowHeight);
            grid.ScrollbarsVisibleChanged += new EventHandler(grid_ScrollbarsVisibleChanged);
            grid.ScrollControlHandledMouseDown += new MouseEventHandler(grid_ScrollControlHandledMouseDown);
            grid.ScrollControlHandledMouseMove += new MouseEventHandler(grid_ScrollControlHandledMouseMove);
            grid.ScrollControlHandledMouseUp += new MouseEventHandler(grid_ScrollControlHandledMouseUp);
            grid.ScrollControlMouseDown += new CancelMouseEventHandler(grid_ScrollControlMouseDown);
            grid.ScrollControlMouseMove += new CancelMouseEventHandler(grid_ScrollControlMouseMove);
            grid.ScrollControlMouseUp += new CancelMouseEventHandler(grid_ScrollControlMouseUp);
            grid.ScrollTipFeedback += new ScrollTipFeedbackEventHandler(grid_ScrollTipFeedback);
            grid.SelectionChanged += new GridSelectionChangedEventHandler(grid_SelectionChanged);
            grid.SelectionChanging += new GridSelectionChangingEventHandler(grid_SelectionChanging);
            grid.SelectionFrameChanged += new Syncfusion.Drawing.GraphicsEventHandler(grid_SelectionFrameChanged);
            grid.SelectionFrameChanging += new Syncfusion.Drawing.GraphicsEventHandler(grid_SelectionFrameChanging);
            grid.ShowContextMenu += new ShowContextMenuEventHandler(grid_ShowContextMenu);
            grid.SizeChanged += new EventHandler(grid_SizeChanged);
            grid.SplitterPaneClosed += new EventHandler(grid_SplitterPaneClosed);
            grid.SplitterPaneClosing += new EventHandler(grid_SplitterPaneClosing);
            grid.StyleChanged += new EventHandler(grid_StyleChanged);
            grid.SupportsTransparentBackColorChanged += new EventHandler(grid_SupportsTransparentBackColorChanged);
            grid.SystemColorsChanged += new EventHandler(grid_SystemColorsChanged);
            grid.ScrollInfoChanged += new EventHandler(grid_ScrollInfoChanged);
            grid.SelectionDragging += new GridSelectionDragEventHandler(grid_SelectionDragging);
            grid.SelectionDragged += new GridSelectionDragEventHandler(grid_SelectionDragged);
            grid.StartAutoScrolling += new StartAutoScrollingEventHandler(grid_StartAutoScrolling);

            grid.TabIndexChanged += new EventHandler(grid_TabIndexChanged);
            grid.TabStopChanged += new EventHandler(grid_TabStopChanged);
            grid.TextChanged += new EventHandler(grid_TextChanged);
            grid.ThemeChanged += new EventHandler(grid_ThemeChanged);
            grid.TopRowChanged += new GridRowColIndexChangedEventHandler(grid_TopRowChanged);
            grid.TopRowChanging += new GridRowColIndexChangingEventHandler(grid_TopRowChanging);
            grid.UpdatingChanged += new EventHandler(grid_UpdatingChanged);
            grid.VerticalScroll += new ScrollEventHandler(grid_VerticalScroll);
            grid.VisibleChanged += new EventHandler(grid_VisibleChanged);
            grid.VScrollPixelPosChanged += new GridScrollPositionChangedEventHandler(grid_VScrollPixelPosChanged);
            grid.VScrollPixelPosChanging += new GridScrollPositionChangingEventHandler(grid_VScrollPixelPosChanging);
            grid.Validated += new EventHandler(grid_Validated);
            grid.Validating += new CancelEventHandler(grid_Validating);
            grid.WindowScrolled += new ScrollWindowEventHandler(grid_WindowScrolled);
            grid.WindowScrolling += new ScrollWindowEventHandler(grid_WindowScrolling);
            grid.WrapCellNextControlInForm += new GridWrapCellNextControlInFormEventHandler(grid_WrapCellNextControlInForm);
        }

        public void UnwireGrid(GridControl grid)
        {
            grid.AccelerateScrollingChanged -= new EventHandler(grid_AccelerateScrollingChanged);
            grid.ActivateToolTip -= new GridActivateToolTipEventHandler(grid_ActivateToolTip);
            grid.AutoScrollingChanged -= new EventHandler(grid_AutoScrollingChanged);
            grid.BackColorChanged -= new EventHandler(grid_BackColorChanged);
            grid.BackgroundImageChanged -= new EventHandler(grid_BackgroundImageChanged);
            grid.BackgroundImageLayoutChanged -= new EventHandler(grid_BackgroundImageLayoutChanged);
            grid.BanneredRangesChanged -= new GridBanneredRangesChangedEventHandler(grid_BanneredRangesChanged);
            grid.BanneredRangesChanging -= new GridBanneredRangesChangingEventHandler(grid_BanneredRangesChanging);
            grid.BaseStylesMapChanged -= new EventHandler(grid_BaseStylesMapChanged);
            grid.BeginUpdateRequest -= new EventHandler(grid_BeginUpdateRequest);
            grid.BindingContextChanged -= new EventHandler(grid_BindingContextChanged);
            grid.CancelMode += new EventHandler(grid_CancelMode);
            grid.CausesValidationChanged -= new EventHandler(grid_CausesValidationChanged);
            grid.CellCancelMode -= new GridCellMouseEventHandler(grid_CellCancelMode);
            grid.CellCursor -= new GridCellCursorEventHandler(grid_CellCursor);
            grid.CellDrawn -= new GridDrawCellEventHandler(grid_CellDrawn);
            grid.CellHitTest -= new GridCellHitTestEventHandler(grid_CellHitTest);
            grid.CellModelsChanged -= new CollectionChangeEventHandler(grid_CellModelsChanged);
            grid.CellMouseHover -= new GridCellMouseEventHandler(grid_CellMouseHover);
            grid.CellMouseMove -= new GridCellMouseEventHandler(grid_CellMouseMove);
            grid.CellsChanged -= new GridCellsChangedEventHandler(grid_CellsChanged);
            grid.CellsChanging -= new GridCellsChangingEventHandler(grid_CellsChanging);
            grid.ChangeUICues -= new UICuesEventHandler(grid_ChangeUICues);
            grid.ClearingCells -= new GridClearingCellsEventHandler(grid_ClearingCells);
            grid.ClientSizeChanged -= new EventHandler(grid_ClientSizeChanged);
            grid.ClipboardCanCopy -= new GridCutPasteEventHandler(grid_ClipboardCanCopy);

            grid.ColsHidden -= new GridRowColHiddenEventHandler(grid_ColsHidden);
            grid.ColsHiding -= new GridRowColHidingEventHandler(grid_ColsHiding);
            grid.ColsInserted -= new GridRangeInsertedEventHandler(grid_ColsInserted);
            grid.ColsMoved -= new GridRangeMovedEventHandler(grid_ColsMoved);
            grid.ColsMoving -= new GridRangeMovingEventHandler(grid_ColsMoving);
            grid.ColsRemoved -= new GridRangeRemovedEventHandler(grid_ColsRemoved);
            grid.ColsRemoving -= new GridRangeRemovingEventHandler(grid_ColsRemoving);
            grid.ColWidthsChanged -= new GridRowColSizeChangedEventHandler(grid_ColWidthsChanged);
            grid.ColWidthsChanging -= new GridRowColSizeChangingEventHandler(grid_ColWidthsChanging);
            grid.ConfirmingPendingChanges -= new CancelEventHandler(grid_ConfirmingPendingChanges);
            grid.ContextMenuChanged -= new EventHandler(grid_ContextMenuChanged);
            grid.ContextMenuStripChanged -= new EventHandler(grid_ContextMenuStripChanged);

            grid.ControlAdded -= new ControlEventHandler(grid_ControlAdded);
            grid.ControllerOptionsChanged -= new EventHandler(grid_ControllerOptionsChanged);
            grid.ControlRemoved -= new ControlEventHandler(grid_ControlRemoved);
            grid.CoveredRangesChanged -= new GridCoveredRangesChangedEventHandler(grid_CoveredRangesChanged);
            grid.CoveredRangesChanging -= new GridCoveredRangesChangingEventHandler(grid_CoveredRangesChanging);
            grid.CurrentCellControlKeyMessage -= new GridCurrentCellControlKeyMessageEventHandler(grid_CurrentCellControlKeyMessage);
            grid.CurrentCellErrorMessage -= new GridCurrentCellErrorMessageEventHandler(grid_CurrentCellErrorMessage);
            grid.CursorChanged -= new EventHandler(grid_CursorChanged);


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
            grid.CurrentCellKeyPress -= new KeyPressEventHandler(grid_CurrentCellKeyPress);
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
            grid.DataChanged -= new EventHandler(grid_DataChanged);
            grid.DataObjectConsumerOptionsChanged -= new EventHandler(grid_DataObjectConsumerOptionsChanged);
            grid.DefaultColWidthChanging -= new GridDefaultSizeChangingEventHandler(grid_DefaultColWidthChanging);
            grid.DefaultRowHeightChanged -= new GridDefaultSizeChangedEventHandler(grid_DefaultRowHeightChanged);
            grid.DefaultRowHeightChanging -= new GridDefaultSizeChangingEventHandler(grid_DefaultRowHeightChanging);
            grid.Disposed -= new EventHandler(grid_Disposed);
            grid.DockChanged -= new EventHandler(grid_DockChanged);
            grid.DrawCellBackground -= new GridDrawCellBackgroundEventHandler(grid_DrawCellBackground);
            grid.DrawCellButton -= new GridDrawCellButtonEventHandler(grid_DrawCellButton);
            grid.DrawCellButtonBackground -= new GridDrawCellButtonBackgroundEventHandler(grid_DrawCellButtonBackground);
            grid.DrawCellDisplayText -= new GridDrawCellDisplayTextEventHandler(grid_DrawCellDisplayText);
            grid.DrawCellFrameAppearance -= new GridDrawCellBackgroundEventHandler(grid_DrawCellFrameAppearance);
            grid.DrawCurrentCellBorder -= new GridDrawCurrentCellBorderEventHandler(grid_DrawCurrentCellBorder);
            grid.DefaultColWidthChanged -= new GridDefaultSizeChangedEventHandler(grid_DefaultColWidthChanged);
            grid.Deactivated -= new EventHandler(grid_Deactivated);
            grid.DoubleClick -= new EventHandler(grid_DoubleClick);
            grid.DragDrop -= new DragEventHandler(grid_DragDrop);
            grid.DragEnter -= new DragEventHandler(grid_DragEnter);
            grid.DragLeave -= new EventHandler(grid_DragLeave);
            grid.DragOver -= new DragEventHandler(grid_DragOver);
            grid.Enter -= new EventHandler(grid_Enter);
            grid.EnabledChanged -= new EventHandler(grid_EnabledChanged);
            grid.EndUpdateRequest -= new GridEndUpdateRequestEventHandler(grid_EndUpdateRequest);
            grid.FileNameChanged -= new EventHandler(grid_FileNameChanged);
            grid.FillRectangleHook -= new GridFillRectangleHookEventHandler(grid_FillRectangleHook);
            grid.FillSplitterPaneChanged -= new EventHandler(grid_FillSplitterPaneChanged);
            grid.FloatingCellsChanged -= new GridFloatingCellsChangedEventHandler(grid_FloatingCellsChanged);
            grid.FontChanged -= new EventHandler(grid_FontChanged);
            grid.ForeColorChanged -= new EventHandler(grid_ForeColorChanged);
            grid.FrozenColCountChanged -= new GridCountChangedEventHandler(grid_FrozenColCountChanged);
            grid.FrozenColCountChanging -= new GridCountChangingEventHandler(grid_FrozenColCountChanging);
            grid.FrozenRowCountChanged -= new GridCountChangedEventHandler(grid_FrozenRowCountChanged);
            grid.FrozenRowCountChanging -= new GridCountChangingEventHandler(grid_FrozenRowCountChanging);
            grid.GiveFeedback -= new GiveFeedbackEventHandler(grid_GiveFeedback);
            grid.GridBoundsChanged -= new EventHandler(grid_GridBoundsChanged);
            grid.GridControlMouseDown -= new CancelMouseEventHandler(grid_GridControlMouseDown);
            grid.GridControlMouseMove -= new CancelMouseEventHandler(grid_GridControlMouseMove);
            grid.GridControlMouseUp -= new CancelMouseEventHandler(grid_GridControlMouseUp);
            grid.GotFocus -= new EventHandler(grid_GotFocus);
            grid.HandleCreated -= new EventHandler(grid_HandleCreated);
            grid.HandleDestroyed -= new EventHandler(grid_HandleDestroyed);
            grid.HeaderColCountChanged -= new GridCountChangedEventHandler(grid_HeaderColCountChanged);
            grid.HeaderColCountChanging -= new GridCountChangingEventHandler(grid_HeaderColCountChanging);
            grid.HeaderRowCountChanged -= new GridCountChangedEventHandler(grid_HeaderRowCountChanged);
            grid.HeaderRowCountChanging -= new GridCountChangingEventHandler(grid_HeaderRowCountChanging);
            grid.HelpRequested -= new HelpEventHandler(grid_HelpRequested);
            grid.HorizontalScroll -= new ScrollEventHandler(grid_HorizontalScroll);
            grid.HScrollPixelPosChanged -= new GridScrollPositionChangedEventHandler(grid_HScrollPixelPosChanged);
            grid.HScrollPixelPosChanging -= new GridScrollPositionChangingEventHandler(grid_HScrollPixelPosChanging);
            grid.ImeModeChanged -= new EventHandler(grid_ImeModeChanged);
            grid.IntelliMouseDragScrolling -= new IntelliMouseDragScrollEventHandler(grid_IntelliMouseDragScrolling);
            grid.Invalidated -= new InvalidateEventHandler(grid_Invalidated);
            grid.KeyDown -= new KeyEventHandler(grid_KeyDown);
            grid.KeyPress -= new KeyPressEventHandler(grid_KeyPress);
            grid.KeyUp -= new KeyEventHandler(grid_KeyUp);
            grid.LeftColChanged -= new GridRowColIndexChangedEventHandler(grid_LeftColChanged);
            grid.LeftColChanging -= new GridRowColIndexChangingEventHandler(grid_LeftColChanging);
            grid.LocationChanged -= new EventHandler(grid_LocationChanged);
            grid.MarginChanged -= new EventHandler(grid_MarginChanged);
            grid.MergeCellsChanged -= new GridMergeCellsChangedEventHandler(grid_MergeCellsChanged);
            grid.ModelChanged -= new EventHandler(grid_ModelChanged);
            grid.ModifiedChanged -= new EventHandler(grid_ModifiedChanged);
            grid.MouseActivating -= new CancelEventHandler(grid_MouseActivating);
            grid.MouseCaptureChanged -= new EventHandler(grid_MouseCaptureChanged);
            grid.MouseClick -= new MouseEventHandler(grid_MouseClick);
            grid.MouseHover -= new EventHandler(grid_MouseHover);
            grid.MouseMove -= new MouseEventHandler(grid_MouseMove);
            grid.MouseWheel -= new MouseEventHandler(grid_MouseWheel);
            grid.MouseWheelZoom -= new MouseWheelZoomEventHandler(grid_MouseWheelZoom);
            grid.Move -= new EventHandler(grid_Move);
            grid.MoveCurrentCellDirection -= new GridMoveCurrentCellDirectionEventHandler(grid_MoveCurrentCellDirection);
            grid.Office2007ScrollBarsChanged -= new EventHandler(grid_Office2007ScrollBarsChanged);
            grid.Office2007ScrollBarsColorSchemeChanged -= new EventHandler(grid_Office2007ScrollBarsColorSchemeChanged);
            grid.OperationFeedback -= new Syncfusion.ComponentModel.OperationFeedbackEventHandler(grid_OperationFeedback);
            grid.PaddingChanged -= new EventHandler(grid_PaddingChanged);
            grid.ParentChanged -= new EventHandler(grid_ParentChanged);
            grid.ParseCommonFormats -= new GridCellTextEventHandler(grid_ParseCommonFormats);
            grid.PasteCellText -= new GridPasteCellTextEventHandler(grid_PasteCellText);
            grid.PrepareChangeSelection -= new GridPrepareChangeSelectionEventHandler(grid_PrepareChangeSelection);
            grid.PrepareClearSelection -= new EventHandler(grid_PrepareClearSelection);
            grid.PrepareGraphics -= new Syncfusion.Drawing.GraphicsEventHandler(grid_PrepareGraphics);
            grid.PrepareViewStyleInfo -= new GridPrepareViewStyleInfoEventHandler(grid_PrepareViewStyleInfo);
            grid.PreviewKeyDown -= new PreviewKeyDownEventHandler(grid_PreviewKeyDown);
            grid.PrintingModeChanged -= new EventHandler(grid_PrintingModeChanged);
            grid.Layout -= new LayoutEventHandler(grid_Layout);
            grid.Leave -= new EventHandler(grid_Leave);
            grid.LostFocus -= new EventHandler(grid_LostFocus);
            grid.MouseDown -= new MouseEventHandler(grid_MouseDown);
            grid.MouseUp -= new MouseEventHandler(grid_MouseUp);
            grid.MouseEnter -= new EventHandler(grid_MouseEnter);
            grid.MouseLeave -= new EventHandler(grid_MouseLeave);
            grid.ReadOnlyChanged -= new EventHandler(grid_ReadOnlyChanged);
            grid.RefreshRequest -= new EventHandler(grid_RefreshRequest);
            grid.RegionChanged -= new EventHandler(grid_RegionChanged);
            grid.Resize -= new EventHandler(grid_Resize);
            grid.RightToLeftChanged -= new EventHandler(grid_RightToLeftChanged);
            grid.RowHeightsChanged -= new GridRowColSizeChangedEventHandler(grid_RowHeightsChanged);
            grid.RowHeightsChanging -= new GridRowColSizeChangingEventHandler(grid_RowHeightsChanging);
            grid.RowsHidden -= new GridRowColHiddenEventHandler(grid_RowsHidden);
            grid.RowsHiding -= new GridRowColHidingEventHandler(grid_RowsHiding);
            grid.RowsInserted -= new GridRangeInsertedEventHandler(grid_RowsInserted);
            grid.RowsInserting -= new GridRangeInsertingEventHandler(grid_RowsInserting);
            grid.RowsMoved -= new GridRangeMovedEventHandler(grid_RowsMoved);
            grid.RowsMoving -= new GridRangeMovingEventHandler(grid_RowsMoving);
            grid.RowsRemoved -= new GridRangeRemovedEventHandler(grid_RowsRemoved);
            grid.RowsRemoving -= new GridRangeRemovingEventHandler(grid_RowsRemoving);
            grid.ResizingColumns -= new GridResizingColumnsEventHandler(grid_ResizingColumns);
            grid.ResizingRows -= new GridResizingRowsEventHandler(grid_ResizingRows);
            grid.SaveCellFormattedText -= new GridCellTextEventHandler(grid_SaveCellFormattedText);
            grid.SaveCellInfo -= new GridSaveCellInfoEventHandler(grid_SaveCellInfo);
            grid.SaveCellText -= new GridCellTextEventHandler(grid_SaveCellText);
            grid.SaveColCount -= new GridRowColCountEventHandler(grid_SaveColCount);
            grid.SaveColWidth -= new GridRowColSizeEventHandler(grid_SaveColWidth);
            grid.SaveRowCount -= new GridRowColCountEventHandler(grid_SaveRowCount);
            grid.SaveRowHeight -= new GridRowColSizeEventHandler(grid_SaveRowHeight);
            grid.ScrollbarsVisibleChanged -= new EventHandler(grid_ScrollbarsVisibleChanged);
            grid.ScrollControlHandledMouseDown -= new MouseEventHandler(grid_ScrollControlHandledMouseDown);
            grid.ScrollControlHandledMouseMove -= new MouseEventHandler(grid_ScrollControlHandledMouseMove);
            grid.ScrollControlHandledMouseUp -= new MouseEventHandler(grid_ScrollControlHandledMouseUp);
            grid.ScrollControlMouseDown -= new CancelMouseEventHandler(grid_ScrollControlMouseDown);
            grid.ScrollControlMouseMove -= new CancelMouseEventHandler(grid_ScrollControlMouseMove);
            grid.ScrollControlMouseUp -= new CancelMouseEventHandler(grid_ScrollControlMouseUp);
            grid.ScrollTipFeedback -= new ScrollTipFeedbackEventHandler(grid_ScrollTipFeedback);
            grid.SelectionChanged -= new GridSelectionChangedEventHandler(grid_SelectionChanged);
            grid.SelectionChanging -= new GridSelectionChangingEventHandler(grid_SelectionChanging);
            grid.SelectionFrameChanged -= new Syncfusion.Drawing.GraphicsEventHandler(grid_SelectionFrameChanged);
            grid.SelectionFrameChanging -= new Syncfusion.Drawing.GraphicsEventHandler(grid_SelectionFrameChanging);
            grid.ShowContextMenu -= new ShowContextMenuEventHandler(grid_ShowContextMenu);
            grid.SizeChanged -= new EventHandler(grid_SizeChanged);
            grid.SplitterPaneClosed -= new EventHandler(grid_SplitterPaneClosed);
            grid.SplitterPaneClosing -= new EventHandler(grid_SplitterPaneClosing);
            grid.StyleChanged -= new EventHandler(grid_StyleChanged);
            grid.SupportsTransparentBackColorChanged -= new EventHandler(grid_SupportsTransparentBackColorChanged);
            grid.SystemColorsChanged -= new EventHandler(grid_SystemColorsChanged);
            grid.SaveCellFormattedText -= new GridCellTextEventHandler(grid_SaveCellFormattedText);
            grid.SaveCellInfo -= new GridSaveCellInfoEventHandler(grid_SaveCellInfo);
            grid.SaveCellText -= new GridCellTextEventHandler(grid_SaveCellText);
            grid.SaveColCount -= new GridRowColCountEventHandler(grid_SaveColCount);
            grid.SaveColWidth -= new GridRowColSizeEventHandler(grid_SaveColWidth);
            grid.SaveRowCount -= new GridRowColCountEventHandler(grid_SaveRowCount);
            grid.SaveRowHeight -= new GridRowColSizeEventHandler(grid_SaveRowHeight);
            grid.ScrollbarsVisibleChanged -= new EventHandler(grid_ScrollbarsVisibleChanged);
            grid.ScrollControlHandledMouseDown -= new MouseEventHandler(grid_ScrollControlHandledMouseDown);
            grid.ScrollControlHandledMouseMove -= new MouseEventHandler(grid_ScrollControlHandledMouseMove);
            grid.ScrollControlHandledMouseUp -= new MouseEventHandler(grid_ScrollControlHandledMouseUp);
            grid.ScrollControlMouseDown -= new CancelMouseEventHandler(grid_ScrollControlMouseDown);
            grid.ScrollControlMouseMove -= new CancelMouseEventHandler(grid_ScrollControlMouseMove);
            grid.ScrollControlMouseUp -= new CancelMouseEventHandler(grid_ScrollControlMouseUp);
            grid.ScrollTipFeedback -= new ScrollTipFeedbackEventHandler(grid_ScrollTipFeedback);
            grid.SelectionChanged -= new GridSelectionChangedEventHandler(grid_SelectionChanged);
            grid.SelectionChanging -= new GridSelectionChangingEventHandler(grid_SelectionChanging);
            grid.SelectionFrameChanged -= new Syncfusion.Drawing.GraphicsEventHandler(grid_SelectionFrameChanged);
            grid.SelectionFrameChanging -= new Syncfusion.Drawing.GraphicsEventHandler(grid_SelectionFrameChanging);
            grid.ShowContextMenu -= new ShowContextMenuEventHandler(grid_ShowContextMenu);
            grid.SizeChanged -= new EventHandler(grid_SizeChanged);
            grid.SplitterPaneClosed -= new EventHandler(grid_SplitterPaneClosed);
            grid.SplitterPaneClosing -= new EventHandler(grid_SplitterPaneClosing);
            grid.StyleChanged -= new EventHandler(grid_StyleChanged);
            grid.SupportsTransparentBackColorChanged -= new EventHandler(grid_SupportsTransparentBackColorChanged);
            grid.SystemColorsChanged -= new EventHandler(grid_SystemColorsChanged);
            grid.ScrollInfoChanged -= new EventHandler(grid_ScrollInfoChanged);
            grid.SelectionDragging -= new GridSelectionDragEventHandler(grid_SelectionDragging);
            grid.SelectionDragged -= new GridSelectionDragEventHandler(grid_SelectionDragged);
            grid.StartAutoScrolling -= new StartAutoScrollingEventHandler(grid_StartAutoScrolling);
            grid.TabIndexChanged -= new EventHandler(grid_TabIndexChanged);
            grid.TabStopChanged -= new EventHandler(grid_TabStopChanged);
            grid.TextChanged -= new EventHandler(grid_TextChanged);
            grid.ThemeChanged -= new EventHandler(grid_ThemeChanged);
            grid.TopRowChanged -= new GridRowColIndexChangedEventHandler(grid_TopRowChanged);
            grid.TopRowChanging -= new GridRowColIndexChangingEventHandler(grid_TopRowChanging);
            grid.UpdatingChanged -= new EventHandler(grid_UpdatingChanged);
            grid.VerticalScroll -= new ScrollEventHandler(grid_VerticalScroll);
            grid.VisibleChanged -= new EventHandler(grid_VisibleChanged);
            grid.VScrollPixelPosChanged -= new GridScrollPositionChangedEventHandler(grid_VScrollPixelPosChanged);
            grid.VScrollPixelPosChanging -= new GridScrollPositionChangingEventHandler(grid_VScrollPixelPosChanging);
            grid.Validated -= new EventHandler(grid_Validated);
            grid.Validating -= new CancelEventHandler(grid_Validating);
            grid.WindowScrolled += new ScrollWindowEventHandler(grid_WindowScrolled);
            grid.WindowScrolling += new ScrollWindowEventHandler(grid_WindowScrolling);
            grid.WrapCellNextControlInForm -= new GridWrapCellNextControlInFormEventHandler(grid_WrapCellNextControlInForm);
        }

        #endregion

        #region "Appending Events"

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

		public override string ToString()
		{
			return GetInfo("");
		}

        void grid_AccelerateScrollingChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("AccelerateScrollingChanged", e);
        }

        void grid_ActivateToolTip(object sender, GridActivateToolTipEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ActivateToolTip", e);
        }

        void grid_AutoScrollingChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("AutoScrollingChanged", e);
        }

        void grid_BackColorChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("BackColorChanged", e);
        }

        void grid_BackgroundImageChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("BackgroundImageChanged", e);
        }

        void grid_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("BackgroundImageLayoutChanged", e);
        }

        void grid_BanneredRangesChanged(object sender, GridBanneredRangesChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("BanneredRangesChanged", e);
        }
        void grid_BanneredRangesChanging(object sender, GridBanneredRangesChangingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("BanneredRangesChanged", e);
        }

        void grid_BaseStylesMapChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("BaseStylesMapChanged", e);
        }

        void grid_BeginUpdateRequest(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("BeginUpdateRequest", e);
        }
        void grid_BindingContextChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("BindingContextChanged", e);
        }

        void grid_CancelMode(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("CancelMode", e);
        }

        void grid_ClipboardCut(object sender, GridCutPasteEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ClipboardCut", e);
        }
        void grid_CausesValidationChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid"; 
            etracer.AppendOutput("CausesValidationChanged", e);
        }
        void grid_CellCancelMode(object sender, GridCellMouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CellCancelMode", e);
        }

        void grid_CellCursor(object sender, GridCellCursorEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CellCursor", e);
        }

        void grid_CellDrawn(object sender, GridDrawCellEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CellDrawn", e);
        }

        void grid_CellHitTest(object sender, GridCellHitTestEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CellHitTest", e);
        }
        void grid_ClipboardPaste(object sender, GridCutPasteEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ClipboardPaste", e);
        }
        void grid_CellModelsChanged(object sender, CollectionChangeEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CellModelsChanged", e);
        }
        void grid_CellMouseHover(object sender, GridCellMouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("CellMouseHover", e);
        }
        void grid_CellMouseMove(object sender, GridCellMouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("CellMouseMove", e);
        }
        void grid_CellsChanged(object sender, GridCellsChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CellsChanged", e);
        }

        void grid_ChangeUICues(object sender, UICuesEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ChangeUICues", e);
        }
        void grid_ClearingCells(object sender, GridClearingCellsEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("ClearingCells", e);
        }
        void grid_ClientSizeChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ClientSizeChanged", e);
        }
        void grid_CellsChanging(object sender, GridCellsChangingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CellsChanging", e);
        }
        void grid_ClipboardCanCopy(object sender, GridCutPasteEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ClipboardCanCopy", e);
        }

        void grid_ClipboardCanCut(object sender, GridCutPasteEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ClipboardCanCut", e);
        }
        void grid_ClipboardCanPaste(object sender, GridCutPasteEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ClipboardCanPaste", e);
        }
        void grid_ClipboardCopy(object sender, GridCutPasteEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ClipboardCopy", e);
        }

        void grid_ColsHidden(object sender, GridRowColHiddenEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ColsHidden", e);
        }

        void grid_ColsHiding(object sender, GridRowColHidingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ColsHiding", e);
        }
        void grid_ColsInserted(object sender, GridRangeInsertedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ColsInserted", e);
        }
        void grid_ColsMoved(object sender, GridRangeMovedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ColsMoved", e);
        }

        void grid_ColsMoving(object sender, GridRangeMovingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ColsMoving", e);
        }

        void grid_ColsRemoved(object sender, GridRangeRemovedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ColsRemoved", e);
        }

        void grid_CoveredRangesChanged(object sender, GridCoveredRangesChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("CoveredRangesChanged", e);
        }
        void grid_CurrentCellControlKeyMessage(object sender, GridCurrentCellControlKeyMessageEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellControlKeyMessage", e);
        }

        void grid_ColsRemoving(object sender, GridRangeRemovingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ColsRemoving", e);
        }
        void grid_ColWidthsChanged(object sender, GridRowColSizeChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ColWidthsChanged", e);
        }
        void grid_ColWidthsChanging(object sender, GridRowColSizeChangingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ColWidthsChanging", e);
        }

        void grid_ConfirmingPendingChanges(object sender, CancelEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ConfirmingPendingChanges", e);
        }
        void grid_ContextMenuChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ContextMenuChanged", e);
        }

        void grid_ContextMenuStripChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ContextMenuStripChanged", e);
        }

        void grid_ControlAdded(object sender, ControlEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ControlAdded", e);
        }
        void grid_ControllerOptionsChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ControllerOptionsChanged", e);
        }
        void grid_ControlRemoved(object sender, ControlEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ControlRemoved", e);
        }

        void grid_CoveredRangesChanging(object sender, GridCoveredRangesChangingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("CoveredRangesChanging", e);
        }
        void grid_CurrentCellErrorMessage(object sender, GridCurrentCellErrorMessageEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellErrorMessage", e);
        }

        void grid_CursorChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CursorChanged", e);
        }

        private void grid_CurrentCellMoved(object sender, Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellMoved", e);
        }

        private void grid_CurrentCellAcceptedChanges(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellAcceptedChanges", e);
        }

        private void grid_CurrentCellActivated(object sender, System.EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellActivated", e);
        }

        private void grid_CurrentCellActivateFailed(object sender, Syncfusion.Windows.Forms.Grid.GridCurrentCellActivateFailedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellActivateFailed", e);
        }

        private void grid_CurrentCellActivating(object sender, GridCurrentCellActivatingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellActivating", e);
        }

        private void grid_CurrentCellChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellChanged", e);

        }

        private void grid_CurrentCellChanging(object sender, CancelEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellChanging", e);

        }

        private void grid_CurrentCellCloseDropDown(object sender, PopupClosedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellCloseDropDown", e);

        }

        private void grid_CurrentCellControlLostFocus(object sender, ControlEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellControlLostFocus", e);
        }

        private void grid_CurrentCellMoveFailed(object sender, GridCurrentCellMoveFailedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellMoveFailed", e);

        }

        private void grid_CurrentCellRejectedChanges(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellRejectedChanges", e);

        }

        private void grid_CurrentCellShowedDropDown(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellShowedDropDown", e);

        }

        private void grid_CurrentCellShowingDropDown(object sender, GridCurrentCellShowingDropDownEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellShowingDropDown", e);

        }

        private void grid_CurrentCellStartEditing(object sender, CancelEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellStartEditing", e);

        }

        private void grid_CurrentCellValidated(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellValidated", e);

        }

        private void grid_CurrentCellValidating(object sender, CancelEventArgs e)
        {
            // Force the Renderer.ControValue to be in sync with the
            // displayed text. You have to decide on a case by case basis
            // (depeding on what cell renderer you have) if you want to do this ...
            //GridControlBase grid = (GridControlBase) sender;
            //grid.CurrentCell.Renderer.UpdateControlValue();

            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellValidating", e);
        }

        private void grid_CurrentCellControlDoubleClick(object sender, ControlEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellControlDoubleClick", e);
        }

        private void grid_CurrentCellConfirmChangesFailed(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellConfirmChangesFailed", e);
        }

        private void grid_CurrentCellControlGotFocus(object sender, ControlEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellControlGotFocus", e);
        }

        private void grid_CurrentCellDeactivateFailed(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellDeactivateFailed", e);

        }

        private void grid_CurrentCellDeactivating(object sender, CancelEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellDeactivating", e);

        }

        private void grid_CurrentCellEditingComplete(object sender, EventArgs e)
        {

            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellEditingComplete", e);
        }

        private void grid_CurrentCellKeyDown(object sender, KeyEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellKeyDown", e);

        }

        private void grid_CurrentCellKeyPress(object sender, KeyPressEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellKeyPress", e);

        }

        private void grid_CurrentCellKeyUp(object sender, KeyEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellKeyUp", e);

        }

        private void grid_CurrentCellDeleting(object sender, CancelEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellDeleting", e);
        }

        private void grid_CurrentCellMoving(object sender, GridCurrentCellMovingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellMoving", e);

        }

        private void grid_CurrentCellDeactivated(object sender, GridCurrentCellDeactivatedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellDeactivated", e);

        }

        private void grid_CurrentCellInitializeControlText(object sender, GridCurrentCellInitializeControlTextEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellInitializeControlText", e);

        }

        private void grid_CurrentCellValidateString(object sender, GridCurrentCellValidateStringEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CurrentCellValidateString", e);

        }

        private void grid_CellButtonClicked(object sender, GridCellButtonClickedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CellButtonClicked", e);

        }

        private void grid_CellClick(object sender, GridCellClickEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CellClick", e);

        }

        private void grid_CellDoubleClick(object sender, GridCellClickEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CellDoubleClick", e);

        }

        private void grid_CellMouseDown(object sender, GridCellMouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CellMouseDown", e);

        }

        private void grid_CellMouseHoverEnter(object sender, GridCellMouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("CellMouseHoverEnter", e);

        }

        private void grid_CellMouseHoverLeave(object sender, GridCellMouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("CellMouseHoverLeave", e);

        }

        private void grid_CellMouseUp(object sender, GridCellMouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("CellMouseUp", e);

        }

        private void grid_CheckBoxClick(object sender, GridCellClickEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("CheckBoxClick", e);
        }

        private void grid_PushButtonClick(object sender, GridCellPushButtonClickEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("PushButtonClick", e);
        }

        private void grid_Click(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("Click", e);
        }

        void grid_DataChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("DataChanged", e);
        }

        void grid_DataObjectConsumerOptionsChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("DataObjectConsumerOptionsChanged", e);
        }

        void grid_DefaultColWidthChanging(object sender, GridDefaultSizeChangingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("DefaultColWidthChanging", e);
        }
        void grid_DefaultRowHeightChanged(object sender, GridDefaultSizeChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("DefaultRowHeightChanged", e);
        }
        void grid_DefaultRowHeightChanging(object sender, GridDefaultSizeChangingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("DefaultRowHeightChanging", e);
        }
        void grid_Disposed(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("Disposed", e);
        }
        void grid_DockChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("DockChanged", e);
        }
        void grid_DrawCell(object sender, GridDrawCellEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("DrawCell", e);
        }
        void grid_DrawCellBackground(object sender, GridDrawCellBackgroundEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("DrawCellBackground", e);
        }
        void grid_DrawCellButton(object sender, GridDrawCellButtonEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("DrawCellButton", e);
        }
        void grid_DrawCellButtonBackground(object sender, GridDrawCellButtonBackgroundEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("DrawCellButtonBackground", e);
        }
        void grid_DrawCellDisplayText(object sender, GridDrawCellDisplayTextEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("DrawCellDisplayText", e);
        }
        void grid_DrawCellFrameAppearance(object sender, GridDrawCellBackgroundEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("DrawCellFrameAppearance", e);
        }

        void grid_DrawCurrentCellBorder(object sender, GridDrawCurrentCellBorderEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("DrawCurrentCellBorder", e);
        }

        void grid_DefaultColWidthChanged(object sender, GridDefaultSizeChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("DefaultColWidthChanged", e);
        }

        private void grid_Deactivated(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("Deactivated", e);
        }

        private void grid_DoubleClick(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("DoubleClick", e);
        }

        private void grid_DragDrop(object sender, DragEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("DragDrop", e);
        }

        private void grid_DragEnter(object sender, DragEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("DragEnter", e);
        }

        private void grid_DragLeave(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("DragLeave", e);
        }

        private void grid_DragOver(object sender, DragEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("DragOver", e);
        }

        void grid_EnabledChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("EnabledChanged", e);
        }
        void grid_EndUpdateRequest(object sender, GridEndUpdateRequestEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("EndUpdateRequest", e);
        }

        private void grid_Enter(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("Enter", e);
        }

        void grid_FrozenRowCountChanging(object sender, GridCountChangingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("FrozenRowCountChanging", e);
        }

        void grid_FrozenRowCountChanged(object sender, GridCountChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("FrozenRowCountChanged", e);
        }

        void grid_FrozenColCountChanging(object sender, GridCountChangingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("FrozenColCountChanging", e);
        }

        void grid_FrozenColCountChanged(object sender, GridCountChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("FrozenColCountChanged", e);
        }

        void grid_ForeColorChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ForeColorChanged", e);
        }

        void grid_FontChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("FontChanged", e);
        }

        void grid_FloatingCellsChanged(object sender, GridFloatingCellsChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("FloatingCellsChanged", e);
        }

        void grid_FillSplitterPaneChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("FillSplitterPaneChanged", e);
        }

        void grid_FillRectangleHook(object sender, GridFillRectangleHookEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("FillRectangleHook", e);
        }

        void grid_FileNameChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("FileNameChanged", e);
        }
        void grid_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("GiveFeedback", e);
        }
        void grid_GridBoundsChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("GridBoundsChanged", e);
        }
        void grid_GridControlMouseDown(object sender, CancelMouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("GridControlMouseDown", e);
        }
        void grid_GridControlMouseMove(object sender, CancelMouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("GridControlMouseMove", e);
        }
        void grid_GridControlMouseUp(object sender, CancelMouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("GridControlMouseUp", e);
        }

        private void grid_GotFocus(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("GotFocus", e);
        }

        void grid_HandleCreated(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("HandleCreated", e);
        }
        void grid_HandleDestroyed(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("HandleDestroyed", e);
        }
        void grid_HeaderColCountChanged(object sender, GridCountChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("HeaderColCountChanged", e);
        }
        void grid_HeaderColCountChanging(object sender, GridCountChangingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("HeaderColCountChanging", e);
        }

        void grid_HeaderRowCountChanged(object sender, GridCountChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("HeaderRowCountChanged", e);
        }
        void grid_HeaderRowCountChanging(object sender, GridCountChangingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.AppendOutput("HeaderRowCountChanging", e);
            etracer.eventtype = "Grid";
        }

        void grid_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, hlpevent);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("HelpRequested", hlpevent);
        }

        void grid_HorizontalScroll(object sender, ScrollEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("HorizontalScroll", e);
        }
        void grid_HScrollPixelPosChanged(object sender, GridScrollPositionChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("HScrollPixelPosChanged", e);
        }
        void grid_HScrollPixelPosChanging(object sender, GridScrollPositionChangingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("HScrollPixelPosChanging", e);
        }

        void grid_ImeModeChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ImeModeChanged", e);
        }

        void grid_IntelliMouseDragScrolling(object sender, IntelliMouseDragScrollEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("IntelliMouseDragScrolling", e);
        }

        void grid_Invalidated(object sender, InvalidateEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("Invalidated", e);
        }

        private void grid_KeyDown(object sender, KeyEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("KeyDown", e);
        }

        private void grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("KeyPress", e);
        }

        private void grid_KeyUp(object sender, KeyEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("KeyUp", e);
        }

        void grid_LeftColChanged(object sender, GridRowColIndexChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("LeftColChanged", e);
        }
        void grid_LeftColChanging(object sender, GridRowColIndexChangingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("LeftColChanging", e);
        }
        void grid_LocationChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("LocationChanged", e);
        }
        void grid_MarginChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("MarginChanged", e);
        }
        void grid_MergeCellsChanged(object sender, GridMergeCellsChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("MergeCellsChanged", e);
        }

        private void grid_Layout(object sender, LayoutEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("Layout", e);
        }

        private void grid_Leave(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("Leave", e);
            //sta = 0;
        }

        private void grid_LostFocus(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("LostFocus", e);
        }

        private void grid_MouseDown(object sender, MouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("MouseDown", e);
        }

        private void grid_MouseUp(object sender, MouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("MouseUp", e);
        }

        private void grid_MouseEnter(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("MouseEnter", e);
        }

        private void grid_MouseLeave(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("MouseLeave", e);
        }

        void grid_ModelChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ModelChanged", e);
        }
        void grid_ModifiedChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ModifiedChanged", e);
        }
        void grid_MouseActivating(object sender, CancelEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("MouseActivating", e);
        }
        void grid_MouseCaptureChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("MouseCaptureChanged", e);
        }

        void grid_MouseClick(object sender, MouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("MouseClick", e);
        }

        void grid_MouseHover(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("MouseHover", e);
        }
        void grid_MouseMove(object sender, MouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("MouseMove", e);
        }
        void grid_MouseWheel(object sender, MouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("MouseWheel", e);
        }
        void grid_MouseWheelZoom(object sender, MouseWheelZoomEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("MouseWheelZoom", e);
        }
        void grid_Move(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("Move", e);
        }
        void grid_MoveCurrentCellDirection(object sender, GridMoveCurrentCellDirectionEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Cell";
            etracer.AppendOutput("MoveCurrentCellDirection", e);
        }
        void grid_Office2007ScrollBarsChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("Office2007ScrollBarsChanged", e);
        }
        void grid_Office2007ScrollBarsColorSchemeChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("Office2007ScrollBarsColorSchemeChanged", e);
        }
        void grid_OperationFeedback(object sender, Syncfusion.ComponentModel.OperationFeedbackEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("OperationFeedback", e);
        }

        void grid_PaddingChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("PaddingChanged", e);
        }

        void grid_ParentChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ParentChanged", e);
        }
        void grid_ParseCommonFormats(object sender, GridCellTextEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ParseCommonFormats", e);
        }
        void grid_PasteCellText(object sender, GridPasteCellTextEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("PasteCellText", e);
        }
        void grid_PrepareChangeSelection(object sender, GridPrepareChangeSelectionEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("PrepareChangeSelection", e);
        }
        void grid_PrepareClearSelection(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("PrepareClearSelection", e);
        }
        void grid_PrepareGraphics(object sender, Syncfusion.Drawing.GraphicsEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("PrepareGraphics", e);
        }
        void grid_PrepareViewStyleInfo(object sender, GridPrepareViewStyleInfoEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("PrepareViewStyleInfo", e);
        }
        void grid_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("PreviewKeyDown", e);
        }
        void grid_PrintingModeChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("PrintingModeChanged", e);
        }

        void grid_ReadOnlyChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ReadOnlyChanged", e);
        }
        void grid_RefreshRequest(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("RefreshRequest", e);
        }
        void grid_RegionChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("RegionChanged", e);
        }
        void grid_Resize(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("Resize", e);
        }
        void grid_RightToLeftChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("RightToLeftChanged", e);
        }
        void grid_RowHeightsChanged(object sender, GridRowColSizeChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("RowHeightsChanged", e);
        }
        void grid_RowHeightsChanging(object sender, GridRowColSizeChangingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("RowHeightsChanging", e);
        }
        void grid_RowsHidden(object sender, GridRowColHiddenEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("RowsHidden", e);
        }
        void grid_RowsHiding(object sender, GridRowColHidingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("RowsHiding", e);
        }
        void grid_RowsInserted(object sender, GridRangeInsertedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("RowsInserted", e);
        }
        void grid_RowsInserting(object sender, GridRangeInsertingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("RowsInserting", e);
        }
        void grid_RowsMoved(object sender, GridRangeMovedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("RowsMoved", e);
        }
        void grid_RowsMoving(object sender, GridRangeMovingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("RowsMoving", e);
        }
        void grid_RowsRemoved(object sender, GridRangeRemovedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("RowsRemoved", e);
        }
        void grid_RowsRemoving(object sender, GridRangeRemovingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("RowsRemoving", e);
        }

        private void grid_ResizingColumns(object sender, GridResizingColumnsEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ResizingColumns", e);
        }

        private void grid_ResizingRows(object sender, GridResizingRowsEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ResizingRows", e);
        }

        void grid_SaveCellFormattedText(object sender, GridCellTextEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SaveCellFormattedText", e);
        }
        void grid_SaveCellInfo(object sender, GridSaveCellInfoEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SaveCellInfo", e);
        }
        void grid_SaveCellText(object sender, GridCellTextEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SaveCellText", e);
        }
        void grid_SaveColCount(object sender, GridRowColCountEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SaveColCount", e);
        }
        void grid_SaveColWidth(object sender, GridRowColSizeEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SaveColWidth", e);
        }
        void grid_SaveRowCount(object sender, GridRowColCountEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SaveRowCount", e);
        }
        void grid_SaveRowHeight(object sender, GridRowColSizeEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SaveRowHeight", e);
        }
        void grid_ScrollbarsVisibleChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ScrollbarsVisibleChanged", e);
        }
        void grid_ScrollControlHandledMouseDown(object sender, MouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("ScrollControlHandledMouseDown", e);
        }
        void grid_ScrollControlHandledMouseMove(object sender, MouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("ScrollControlHandledMouseMove", e);
        }
        void grid_ScrollControlHandledMouseUp(object sender, MouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("ScrollControlHandledMouseUp", e);
        }
        void grid_ScrollControlMouseDown(object sender, CancelMouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("ScrollControlMouseDown", e);
        }
        void grid_ScrollControlMouseMove(object sender, CancelMouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("ScrollControlMouseMove", e);
        }
        void grid_ScrollControlMouseUp(object sender, CancelMouseEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Mouse";
            etracer.AppendOutput("ScrollControlMouseUp", e);
        }
        void grid_ScrollTipFeedback(object sender, ScrollTipFeedbackEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ScrollTipFeedback", e);
        }
        void grid_SelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SelectionChanged", e);
        }
        void grid_SelectionChanging(object sender, GridSelectionChangingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SelectionChanged", e);
        }
        void grid_SelectionFrameChanged(object sender, Syncfusion.Drawing.GraphicsEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SelectionFrameChanged", e);
        }
        void grid_SelectionFrameChanging(object sender, Syncfusion.Drawing.GraphicsEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SelectionFrameChanging", e);
        }
        void grid_ShowContextMenu(object sender, ShowContextMenuEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ShowContextMenu", e);
        }
        void grid_SizeChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SizeChanged", e);
        }
        void grid_SplitterPaneClosed(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SplitterPaneClosed", e);
        }
        void grid_SplitterPaneClosing(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SplitterPaneClosing", e);
        }
        void grid_StyleChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("StyleChanged", e);
        }
        void grid_SupportsTransparentBackColorChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SupportsTransparentBackColorChanged", e);
        }
        void grid_SystemColorsChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SystemColorsChanged", e);
        }

        private void grid_ScrollInfoChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("ScrollInfoChanged", e);
        }

        private void grid_SelectionDragging(object sender, GridSelectionDragEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SelectionDragging", e);
        }

        private void grid_SelectionDragged(object sender, GridSelectionDragEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("SelectionDragged", e);
        }

        private void grid_StartAutoScrolling(object sender, StartAutoScrollingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("StartAutoScrolling", e);
        }

        void grid_TabIndexChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("TabIndexChanged", e);
        }
        void grid_TabStopChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("TabStopChanged", e);
        }
        void grid_TextChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("TextChanged", e);
        }
        void grid_ThemeChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.AppendOutput("ThemeChanged", e);
        }
        void grid_TopRowChanged(object sender, GridRowColIndexChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("TopRowChanged", e);
        }
        void grid_TopRowChanging(object sender, GridRowColIndexChangingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("TopRowChanging", e);
        }
        void grid_UpdatingChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("UpdatingChanged", e);
        }
        void grid_VerticalScroll(object sender, ScrollEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("VerticalScroll", e);
        }
        void grid_VisibleChanged(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("VisibleChanged", e);
        }
        void grid_VScrollPixelPosChanged(object sender, GridScrollPositionChangedEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("VScrollPixelPosChanged", e);
        }
        void grid_VScrollPixelPosChanging(object sender, GridScrollPositionChangingEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("VScrollPixelPosChanging", e);
        }

        private void grid_Validated(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("Validated", e);
        }

        private void grid_Validating(object sender, CancelEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("Validating", e);
        }

        void grid_WindowScrolled(object sender, ScrollWindowEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("WindowScrolled", e);
        }
        void grid_WindowScrolling(object sender, ScrollWindowEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("WindowScrolling", e);
        }
        private void grid_WrapCellNextControlInForm(object sender, GridWrapCellNextControlInFormEventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
            etracer.eventtype = "Grid";
            etracer.AppendOutput("WrapCellNextControlInForm", e);
        }

        #endregion
    }
}