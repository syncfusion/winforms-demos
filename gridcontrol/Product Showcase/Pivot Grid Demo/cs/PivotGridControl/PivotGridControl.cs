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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Grouping;
using System.Collections;
using System.Collections.Specialized;
using ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary;
using PivotGridControl;
using Syncfusion.Styles;
using Syncfusion.ComponentModel;
using Syncfusion.Windows.Forms;
using System.Runtime.InteropServices;

namespace PivotGridLibrary
{
    /// <summary>
    /// PivotGridControl provides the functionality of a pivot table from Excel.
    /// </summary>
    /// <remarks>
    /// To use this control, you must set the <see cref="DataSource"/> property to some
    /// IList object. The objects in the IList should expose public properties that you
    /// want to use in your pivot table. This control provides a UI that allows your user
    /// specify the rows and columns in the pivot table through drag/drop actions. You
    /// can save the pivot table schema (the rows/columns that go into a pivot table
    /// design) in an XML format as a PivotSchema object that can later be reloaded to define a pivot table
    /// layout without using the Drag/Drop UI.
    /// 
    /// The visual aspects of the control are saved in an Appearance object that can also 
    /// be serialized through XML. The control does support a VisualStyle property that 
    /// allows you to use Office2003 and Office2007 styles.
    /// 
    /// The default calculations are summations, but you can right-click a value entry and 
    /// change the calculation type to average, median, peccentiles, variances, standard
    /// deviations, etc. The calculations are done through the Grouping Engine that is part
    /// of Essential Grouping. So, you can also provide custom calculations through the
    /// the Grouping Engine. This control uses three different grouping engines to provide 
    /// the necessary calculations to display the control. One engine tracks the value fields,
    /// one engine tracks the column fields, and the last engine tracks the row fields specified
    /// by the Schema associated with this control. 
    /// </remarks>
    public partial class PivotGridControl : UserControl
    {
        /// <summary>
        /// The default constructor.
        /// </summary>
        public PivotGridControl()
        {
           //turn off warning on Fields.Add behavior...
            FieldDescriptorCollection.AllowAddRangeChangedWarning = false;

            InitializeComponent();

            gridFields.isFieldsGrid = true;
            collapsedNodes = new Hashtable();
            appearance = new PivotAppearance(this);

            appearance.VisualStyleChanged += new EventHandler(appearance_VisualStyleChanged);
            appearance.ThemesEnabledChanged += new EventHandler(appearance_ThemesEnabledChanged);
            isAppearanceHooked = true;
            //make sure inital settings are applied	in the one time Paint event
 
            SubscribeToNonGridEvents();

            SizeGridsInLowerRight();

            SizePanelsOnLeftSide();

            SubscribeToGridEventsAndSetGridProperties();

         }
      
        #region event subscription code

        private void SubscribeToGridEventsAndSetGridProperties()
        {
            //used to handle dragging items from grid to grid and rearranging 
 
            this.gridColumns.RowsMoved += new GridRangeMovedEventHandler(grid_RowsMoved);
            this.gridFilter.RowsMoved += new GridRangeMovedEventHandler(grid_RowsMoved);
            this.gridRows.RowsMoved += new GridRangeMovedEventHandler(grid_RowsMoved);
            this.gridValues.RowsMoved += new GridRangeMovedEventHandler(grid_RowsMoved);

            this.gridColumns.ShowColumnHeaders = false;
            this.gridFilter.ShowColumnHeaders = false;
            this.gridRows.ShowColumnHeaders = false;
            this.gridValues.ShowColumnHeaders = false;
            this.gridFields.ShowColumnHeaders = false;

            this.gridColumns.FieldDrop += new FieldDropEventHandler(grid_FieldDrop);
            this.gridFields.FieldDrop += new FieldDropEventHandler(grid_FieldDrop);
            this.gridFilter.FieldDrop += new FieldDropEventHandler(grid_FieldDrop);
            this.gridRows.FieldDrop += new FieldDropEventHandler(grid_FieldDrop);
            this.gridValues.FieldDrop += new FieldDropEventHandler(grid_FieldDrop);

            this.gridColumns.QueryCanDropField += new QueryCanDropFieldEventHandler(grid_QueryCanDropField);
            this.gridFields.QueryCanDropField += new QueryCanDropFieldEventHandler(grid_QueryCanDropField);
            this.gridFilter.QueryCanDropField += new QueryCanDropFieldEventHandler(grid_QueryCanDropField);
            this.gridRows.QueryCanDropField += new QueryCanDropFieldEventHandler(grid_QueryCanDropField);
            this.gridValues.QueryCanDropField += new QueryCanDropFieldEventHandler(grid_QueryCanDropField);

            this.gridFilter.RowsMoving += new GridRangeMovingEventHandler(gridFilter_RowsMoving);

            this.gridValues.CellClick += new GridCellClickEventHandler(gridValues_CellClick);

            this.gridFields.CheckBoxClick += new GridCellClickEventHandler(gridFields_CheckBoxClick);

            //set up virtual support of the display grid
            gridMainDisplay.QueryCellInfo += new GridQueryCellInfoEventHandler(gridMainDisplay_QueryCellInfo);

            //set up TopRowChanged/LeftColChnaged to handle scrolling zero sized rows/cols...
            gridMainDisplay.TopRowChanged += new GridRowColIndexChangedEventHandler(gridMainDisplay_TopRowChanged);
            gridMainDisplay.LeftColChanged += new GridRowColIndexChangedEventHandler(gridMainDisplay_LeftColChanged);

            //collapse cell support
            gridMainDisplay.CellModels.Add("PivotButtonCell", new PivotButtonCellModel(gridMainDisplay.Model));
            gridMainDisplay.PushButtonClick += new GridCellPushButtonClickEventHandler(gridMainDisplay_PushButtonClick);

            //show initial panel through the grid drawing event the first time loaded...
            gridMainDisplay.Visible = true;
            this.gridMainDisplay.Paint += new PaintEventHandler(gridMainDisplay_Paint);

            //listen to events to draw icons
            gridMainFilters.CellDrawn += new GridDrawCellEventHandler(gridMainFilters_CellDrawn);
            gridMainRows.CellDrawn += new GridDrawCellEventHandler(gridMainRows_CellDrawn);
            gridMainColumns.CellDrawn += new GridDrawCellEventHandler(gridMainColumns_CellDrawn);

            //handle the filtering on the filters grid
            gridMainFilters.CurrentCellAcceptedChanges += new CancelEventHandler(gridMainFilters_CurrentCellAcceptedChanges);
            gridMainFilters.CurrentCellCloseDropDown += new Syncfusion.Windows.Forms.PopupClosedEventHandler(gridMainFilters_CurrentCellCloseDropDown);
            gridMainFilters.DrawCellDisplayText += new GridDrawCellDisplayTextEventHandler(gridMainFilters_DrawCellDisplayText);

            gridMainDisplay.ResizeColsBehavior = GridResizeCellsBehavior.InsideGrid | GridResizeCellsBehavior.IgnoreHeaders | GridResizeCellsBehavior.ResizeSingle;
            
            //gridFilter.RowsRemoved += new GridRangeRemovedEventHandler(gridFilter_RowsRemoved);
            //gridColumns.RowsRemoved += new GridRangeRemovedEventHandler(gridColumns_RowsRemoved);
            //gridRows.RowsRemoved += new GridRangeRemovedEventHandler(gridRows_RowsRemoved);
            //gridRows.RowsRemoving += new GridRangeRemovingEventHandler(gridRows_RowsRemoving);
            //gridColumns.RowsRemoving += new GridRangeRemovingEventHandler(gridColumns_RowsRemoving);
            gridFilter.RowsRemoving += new GridRangeRemovingEventHandler(gridFilter_RowsRemoving);

            gridFilter.KeyDown += new KeyEventHandler(grid_Delete);
            gridRows.KeyDown += new KeyEventHandler(grid_Delete);
            gridValues.KeyDown += new KeyEventHandler(grid_Delete);
            gridColumns.KeyDown += new KeyEventHandler(grid_Delete);            
        }

        void grid_Delete(object sender, KeyEventArgs e)
        {
            GridList grid = sender as GridList;
            if (e.KeyCode == Keys.Delete)
            {
                string fieldName = grid.CurrentCell.Renderer.ControlText;
                int row = grid.CurrentCell.RowIndex;
                grid.Rows.RemoveRange(row, row);
                SetCheck(fieldName, false);
                PerformLayout(grid, null);
            }
            e.Handled = true;
        }

        void gridFilter_RowsRemoving(object sender, GridRangeRemovingEventArgs e)
        {
            String s = gridFilter[e.From];
            if (engineValues.TableDescriptor.RecordFilters.Contains(s))
                engineValues.TableDescriptor.RecordFilters.Remove(s);
            if (engineColumns.TableDescriptor.RecordFilters.Contains(s))
                engineColumns.TableDescriptor.RecordFilters.Remove(s);
            if (engineRows.TableDescriptor.RecordFilters.Contains(s))
                engineRows.TableDescriptor.RecordFilters.Remove(s);
        }

        void gridColumns_RowsRemoving(object sender, GridRangeRemovingEventArgs e)
        {
            SetCheck(gridColumns[e.From], false);
        }

        void gridRows_RowsRemoving(object sender, GridRangeRemovingEventArgs e)
        {
            SetCheck(gridRows[e.From], false); 
        }

        void gridRows_RowsRemoved(object sender, GridRangeRemovedEventArgs e)
        {
            SetUpMainRowsGridAndEngines();
            if (gridRows.RowCount > 0)  PerformLayout(gridFields, gridMainDisplay);
        }

        void gridColumns_RowsRemoved(object sender, GridRangeRemovedEventArgs e)
        {
            SetUpMainColumnsGridAndEngines();
            if (gridColumns.RowCount > 0) PerformLayout(gridFields, gridMainDisplay);
        }

        #region handle scrolling of rows/cols with zero size
        private int lastTopRow = 1;
        private int lastLeftCol = 1;

        void gridMainDisplay_LeftColChanged(object sender, GridRowColIndexChangedEventArgs e)
        {
            if (lastLeftCol > -1)
            {
                if (gridMainDisplay.ColWidths[gridMainDisplay.LeftColIndex] == 0)
                {
                    if (lastLeftCol < gridMainDisplay.LeftColIndex && gridMainDisplay.LeftColIndex < gridMainDisplay.ColCount)
                    {
                        lastLeftCol = gridMainDisplay.LeftColIndex;
                        gridMainDisplay.LeftColIndex += 1;
                    }
                    else if (lastLeftCol > gridMainDisplay.LeftColIndex && gridMainDisplay.LeftColIndex > 1)
                    {
                        lastLeftCol = gridMainDisplay.LeftColIndex;
                        gridMainDisplay.LeftColIndex -= 1;
                    }
                }
            }
            lastLeftCol = gridMainDisplay.LeftColIndex ;
        }

      
        void gridMainDisplay_TopRowChanged(object sender, GridRowColIndexChangedEventArgs e)
        {
            if (lastTopRow > -1)
            {
                if (gridMainDisplay.RowHeights[gridMainDisplay.TopRowIndex] == 0)
                {
                    if (lastTopRow < gridMainDisplay.TopRowIndex && gridMainDisplay.TopRowIndex < gridMainDisplay.RowCount)
                    {
                        lastTopRow = gridMainDisplay.TopRowIndex;
                        gridMainDisplay.TopRowIndex += 1;
                    }
                    else if (lastTopRow > gridMainDisplay.TopRowIndex && gridMainDisplay.TopRowIndex > 1)
                    {
                        lastTopRow = gridMainDisplay.TopRowIndex;
                        gridMainDisplay.TopRowIndex -= 1;
                    }
                }
            }
            lastTopRow = gridMainDisplay.TopRowIndex;
        }

        #endregion

        void gridFilter_RowsRemoved(object sender, GridRangeRemovedEventArgs e)
        {
            SetUpMainFiltersGridAndApplyFilters();
            if (gridFilter.RowCount > 0) PerformLayout(gridFields, gridMainDisplay);
        }

        //used to managed displaying text in the filter cells
        private char listSeparator = ',';
        void gridMainFilters_DrawCellDisplayText(object sender, GridDrawCellDisplayTextEventArgs e)
        {
            if (e.DisplayText.StartsWith(AllString))
            {
                e.DisplayText = " ";
            }
            else if (e.DisplayText.IndexOf(listSeparator) > -1)
            {
                e.DisplayText = MultipleString;
            }
        }

        //used to handle layout of the various panels holding the various grids
        //used to catch click actions on various non-grid controls
        //used to set particular non-grid control properties
        private void SubscribeToNonGridEvents()
        {
           this.panelRB.SizeChanged += new EventHandler(panelRB_SizeChanged);
             this.panelLeft.SizeChanged += new EventHandler(panelLeft_SizeChanged);
            this.checkBoxDeferLayout.CheckedChanged += new EventHandler(checkBoxDeferLayout_CheckedChanged);
            this.buttonUpdate.Click += new EventHandler(buttonUpdate_Click);
            this.splitter2.Enabled = false;

            //handle the collapse and expand of the right panel
            this.pictureBoxExpanded.Click += new EventHandler(pictureBoxCollapseExpand_Click);
            this.pictureBoxCollapsed.Click += new EventHandler(pictureBoxCollapseExpand_Click);

        }

       

        #endregion

        #region strings

        private string allString = "(all)";

        /// <summary>
        /// Gets or sets the '(all)' string that appears in filter cell dropdowns.
        /// </summary>
        public string AllString
        {
            get { return allString; }
            set { allString = value; }
        }

        private string multipleString = "(multiple)";

        /// <summary>
        /// Gets or sets the '(multiple)' string that appears in filter cell dropdowns.
        /// </summary>
        public string MultipleString
        {
            get { return multipleString; }
            set { multipleString = value; }
        }


        private string totalString = "Total";

        /// <summary>
        /// Gets or sets the 'Total' string that appears total summary cells.
        /// </summary>
        public string TotalString
        {
            get { return totalString; }
            set { totalString = value; }
        }

        private string grandTotalString = "Grand Total";

        /// <summary>
        /// Gets or sets the 'Grand Total' string that appears grand total summary cells.
        /// </summary>
        public string GrandTotalString
        {
            get { return grandTotalString; }
            set { grandTotalString = value; }
        }

        #endregion

        #region filtering support

        void gridMainFilters_CurrentCellCloseDropDown(object sender, Syncfusion.Windows.Forms.PopupClosedEventArgs e)
        {
            gridMainFilters.CurrentCell.ConfirmChanges();
            
        }

       
        void gridMainFilters_CurrentCellAcceptedChanges(object sender, CancelEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            GridCurrentCell cc = gridMainFilters.CurrentCell;
            string value = cc.Renderer.ControlText;
            //need to strip off the colon that was added to the cell value....
            string columnName = gridMainFilters[cc.RowIndex, cc.ColIndex - 1].Text.Substring(0, gridMainFilters[cc.RowIndex, cc.ColIndex - 1].Text.Length - 1);
            ApplyFilter(columnName, value);
            cc.EndEdit();
            int width = gridMainFilters.ColWidths[cc.ColIndex];
            if (value.IndexOf(listSeparator) == -1)
            {
                gridMainFilters.ColWidths.ResizeToFit(cc.RangeInfo, GridResizeToFitOptions.NoShrinkSize);
                if (width != gridMainFilters.ColWidths[cc.ColIndex])
                {
                    LeftPanelWidth = gridMainFilters.ColWidths.GetTotal(0, gridMainFilters.ColCount); //triggers a resize...
                }
            }
            else
            {
                string save = gridMainFilters[cc.RowIndex, cc.ColIndex].Text;
                gridMainFilters[cc.RowIndex, cc.ColIndex].Text = MultipleString;
                gridMainFilters.ColWidths.ResizeToFit(cc.RangeInfo, GridResizeToFitOptions.NoShrinkSize);
                if (width != gridMainFilters.ColWidths[cc.ColIndex])
                {
                    LeftPanelWidth = gridMainFilters.ColWidths.GetTotal(0, gridMainFilters.ColCount); //triggers a resize...
                }
                gridMainFilters[cc.RowIndex, cc.ColIndex].Text = save;
            }
            this.Cursor = Cursors.Default;
        }

        private void ApplyFilter(string columnName, string value)
        {

            //remove any existing filter
            if (engineValues.TableDescriptor.RecordFilters.IndexOf(columnName) > -1)
            {
                engineValues.TableDescriptor.RecordFilters.Remove(columnName);
            }
            if (engineColumns.TableDescriptor.RecordFilters.IndexOf(columnName) > -1)
            {
                engineColumns.TableDescriptor.RecordFilters.Remove(columnName);
            }
            if (engineRows.TableDescriptor.RecordFilters.IndexOf(columnName) > -1)
            {
                engineRows.TableDescriptor.RecordFilters.Remove(columnName);
            }

            //aply a new filter...
            if (!value.StartsWith(AllString))
            {
                string[] choices = value.Split(new char[] { listSeparator });
                FilterCondition[] fcs = new FilterCondition[choices.GetLength(0)];
                int i = 0;
                foreach (string s in choices)
                {
                    fcs[i] = new FilterCondition(FilterCompareOperator.Equals, s);
                    i++;
                }
                RecordFilterDescriptor rfd = new RecordFilterDescriptor(columnName,FilterLogicalOperator.Or, fcs);
                engineValues.TableDescriptor.RecordFilters.Add(rfd.Clone() as RecordFilterDescriptor);
                engineColumns.TableDescriptor.RecordFilters.Add(rfd.Clone() as RecordFilterDescriptor);
                engineRows.TableDescriptor.RecordFilters.Add(rfd as RecordFilterDescriptor);

            }
            UpdateValues();
        }

        #endregion

        #region right panel show/hide

        private bool rightPaneCollapsed = false;
        void pictureBoxCollapseExpand_Click(object sender, EventArgs e)
        {   
            //avoid panels reacting to size changes
            inSizeChanged = true;
            //show/hide the right panel
            this.panelRight.Visible = rightPaneCollapsed;
            //show/hide the clickable glyph
            this.pictureBoxCollapsed.Visible = !rightPaneCollapsed;
            //change the state variable
            rightPaneCollapsed = !rightPaneCollapsed;
            inSizeChanged = false;
        }
        #endregion

        #region bitmap drawing support

        void gridMainColumns_CellDrawn(object sender, GridDrawCellEventArgs e)
        {
            if (e.RowIndex == 0 && e.ColIndex > 0)
            {
                DrawIcon(COLUMNHEADERBITMAP, e);
            }
        }

        void gridMainRows_CellDrawn(object sender, GridDrawCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColIndex == 0)
            {
                DrawIcon(ROWHEADERBITMAP, e);
            }
        }

        void gridMainFilters_CellDrawn(object sender, GridDrawCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColIndex == 0)
            {
                DrawIcon(FUNNELBITMAP, e);
            }
        }

        private const string FUNNELBITMAP = "funnel.png";
        private const string ROWHEADERBITMAP = "table_sql_row.png";
        private const string COLUMNHEADERBITMAP = "table_sql.png";
        private void DrawIcon(string bitMapName, GridDrawCellEventArgs e)
        {
            Rectangle rect = e.Bounds;
            rect.Width = 20; //bmp centered in this rectangle
            IconDrawingSupport.DrawImage(e.Graphics, bitMapName, rect, new Point(0, 0));
        }

        #endregion

        #region handle responding to change in underlying data

        private bool isDirty = false;
        void engine_GroupSummaryInvalidated(object sender, GroupEventArgs e)
        {
           
            if (!isDirty)
            {
                isDirty = true;
                BeginInvoke(new MethodInvoker(DelayUpdateValues));
            }
        }

        void engine_GroupSummaryInvalidated1(object sender, GroupEventArgs e)
        {
            if (!isDirty)
            {
                isDirty = true;
                BeginInvoke(new MethodInvoker(DelayUpdateValues));
            }
        }

        private void DelayUpdateValues()
        {
            if (isDirty)
            {
                UpdateValues();
            }
            isDirty = false;
        }

        #endregion
        
        #region initialization code

        private void InitDisplay()
        {
            ITypedList typedList = list as ITypedList;
            if (typedList != null)
            {
                #region the Fields grid
                PropertyDescriptorCollection pdc = typedList.GetItemProperties(null);
                gridFields.RowCount = pdc.Count + 2;
                gridFields.RowHeights[1] = 1; //need extra row at top tro allow dragging of headers to grids in the left panel
                gridFields.RowHeights[gridFields.RowCount] = 1; //need extra row at bottom to allow dragging of headers to grid beneath
                gridFields.ColCount = 0;
                gridFields.ColWidths[0] = gridFields.ClientSize.Width;
                int row = 2;
                foreach (PropertyDescriptor pd in pdc)
                {
                    gridFields[row, 0].Text = "0";
                    gridFields[row++, 0].Description = pd.Name;
                }

                gridFields.BaseStylesMap["Row Header"].StyleInfo.CellAppearance = GridCellAppearance.Flat;
                gridFields.BaseStylesMap["Row Header"].StyleInfo.BackColor = gridFields.TableStyle.BackColor;
                gridFields.BaseStylesMap["Row Header"].StyleInfo.CellType = "CheckBox";
                gridFields.BaseStylesMap["Row Header"].StyleInfo.CheckBoxOptions.CheckedValue = "1";
                gridFields.BaseStylesMap["Row Header"].StyleInfo.CheckBoxOptions.UncheckedValue = "0";
                
                gridFields.BaseStylesMap["Row Header"].StyleInfo.Font.Bold = false;
                gridFields.HasCheckBox = true;
                gridFields.HasPaddedRow = false;
                #endregion

                #region the other grids
                InitTargetGrid(gridRows);
                InitTargetGrid(gridFilter);
                InitTargetGrid(gridColumns);
                InitTargetGrid(gridValues);

                 #endregion

                #region main display grid
                gridMainDisplay.TableStyle.CellType = "Static";
                gridMainDisplay.TableStyle.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.LightGray);
                gridMainDisplay.TableStyle.Borders.Right = new GridBorder(GridBorderStyle.Solid, Color.LightGray);
               // gridMainDisplay.DefaultGridBorderStyle = GridBorderStyle.Solid;
                gridMainDisplay.Model.Options.DisplayEmptyRows = true;
                gridMainDisplay.Model.Options.DisplayEmptyColumns = true;
                gridMainDisplay.ThemesEnabled = true;
                gridMainDisplay.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
                gridMainDisplay.Office2007ScrollBars = true;

                SetUpAMainGrid(gridMainColumns);
                
                SetUpAMainGrid(gridMainRows);
 
                SetUpAMainGrid(gridMainFilters);

                //add custom celltype to gridFilter
                DropDownUser ddu = new DropDownUser();
                ddu.ListSeparator = GridFormulaEngine.ParseArgumentSeparator;
                listSeparator = ddu.ListSeparator;
                gridMainFilters.CellModels.Add("DropDownCheckList", new DropDownUserCellModel(gridMainFilters.Model, ddu));
               
                #endregion

                SetLabelVisibility();
            }
        }

        private void SetUpAMainGrid(GridControl grid)
        {
            grid.ThemesEnabled = true;
            grid.HScrollBehavior = GridScrollbarMode.Disabled;
            grid.HScroll = false;
           // grid.ControllerOptions |= GridControllerOptions.DragColumnHeader;
            grid.AllowSelection = GridSelectionFlags.None;
            grid.ColWidths[0] = panelRows.Width - 1; ;
            grid.RowHeights[0] = panelColumns.Height - 1;
            grid.BaseStylesMap["Row Header"].StyleInfo.HorizontalAlignment = GridHorizontalAlignment.Center;
            grid.BaseStylesMap["Column Header"].StyleInfo.HorizontalAlignment = GridHorizontalAlignment.Center;
            grid.BaseStylesMap["Row Header"].StyleInfo.VerticalAlignment = GridVerticalAlignment.Middle;
            grid.BaseStylesMap["Column Header"].StyleInfo.VerticalAlignment = GridVerticalAlignment.Middle;

            grid.BaseStylesMap["Column Header"].StyleInfo.TextMargins = new GridMarginsInfo(16, 0, 0, 0); //20 is space for bmp on the left
            grid.BaseStylesMap["Row Header"].StyleInfo.TextMargins = new GridMarginsInfo(16, 0, 0, 0); //20 is space for bmp on the left
            grid.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            grid.Office2007ScrollBars = true;
            grid.Properties.BackgroundColor = Color.FromArgb(227, 239, 255); //office2007Blue 
        }

        private void InitTargetGrid(GridControl grid)
        {
            grid.ColCount = 0;
            grid.RowCount = 2;
            grid.RowHeights[1] = 3; //hidden last row serves as a pad to allow D&D to work
            grid.RowHeights[2] = 3;
            //grid[1, 0].BackColor = Color.Red; //so you can see them for debug purposes....
            //grid[2, 0].BackColor = Color.Blue;

            grid.ColWidths[0] = gridRows.ClientSize.Width;
            grid.BaseStylesMap["Row Header"].StyleInfo.CellAppearance = GridCellAppearance.Flat;
            grid.BaseStylesMap["Row Header"].StyleInfo.BackColor = gridFields.TableStyle.BackColor;
            grid.BaseStylesMap["Row Header"].StyleInfo.Font.Bold = false;
            grid.BaseStylesMap["Row Header"].StyleInfo.CellType = "Static";
        }
        #endregion

        #region properties

        [NonSerialized]
        private PivotAppearance appearance = null;

        [NonSerialized]
        private bool isAppearanceHooked = false;

        /// <summary>
        /// Gets the Appearance object associated with this PivotGridControl.
        /// </summary>
        /// <returns>The Appearance object.</returns>
        public PivotAppearance GetAppearance()
        {
            if (appearance == null)
            {
                appearance = new PivotAppearance(this);
                isAppearanceHooked = false;
            }
            return appearance;
        }

        /// <summary>
        /// Sets the Appearance object associated with this PivotGridControl.
        /// </summary>
        /// <param name="appearance">The Appearance object.</param>
        public void SetAppearance(PivotAppearance appearance)
        {
            if (this.appearance != null && isAppearanceHooked)
            {
                this.appearance.VisualStyleChanged -= new EventHandler(appearance_VisualStyleChanged);
                this.appearance.ThemesEnabledChanged -= new EventHandler(appearance_ThemesEnabledChanged);
         
            }
            this.appearance = appearance;
           
            this.appearance.PivotGridControl = this;

            appearance.VisualStyleChanged += new EventHandler(appearance_VisualStyleChanged);
            appearance.ThemesEnabledChanged += new EventHandler(appearance_ThemesEnabledChanged);
            isAppearanceHooked = true;

            appearance_ThemesEnabledChanged(appearance, EventArgs.Empty);
            appearance_VisualStyleChanged(appearance, EventArgs.Empty);


            this.UpdateValues();//forces the appearance to be applied
        }


        #region count properties
        //public int Count
        //{
        //    get
        //    {
        //        return DataRowCount;
        //    }
        //}

        /// <summary>
        /// Gets the number of objects in the underlying IList object that serves as the DataSoruce
        /// for this PivotGridControl.
        /// </summary>
        public int DataRowCount
        {
            get { return list.Count; }
        }

        /// <summary>
        /// Gets the number of distinct fields that are being used as for filters in this PivotGridControl.
        /// </summary>
        public int FilterCount
        {
            get { return gridFilter.RowCount - 2 ; }
        }

        /// <summary>
        /// Gets the number of distinct fields that are being used as for values in this PivotGridControl.
        /// </summary>
        public int ValueCount
        {
            get { return gridValues.RowCount - 2;}
        }

        /// <summary>
        /// Gets the number of distinct fields that are being used as for columns in this PivotGridControl.
        /// </summary>
        public int ColumnsCount
        {
            get { return gridColumns.RowCount - 2; }
        }

        /// <summary>
        /// Gets the number of distinct fields that are being used as for Rows in this PivotGridControl.
        /// </summary>
        public int RowsCount
        {
            get { return gridRows.RowCount - 2; }
        }



        private bool freezeHeaders = true;

        /// <summary>
        /// Gets or sets whether the Rows and Columns header cells are scrollable in the main display of the
        /// PivotGridControl.
        /// </summary>
        public bool FreezeHeaders
        {
            get { return freezeHeaders; }
            set 
            {
                if (freezeHeaders != value)
                {
                    freezeHeaders = value;
                    SetFreezeState();
                }
            }
        }

        private void SetFreezeState()
        {
            if (FreezeHeaders)
            {
                this.gridMainDisplay.Model.Cols.FrozenCount = this.numberRowFields;
                this.gridMainDisplay.Model.Rows.FrozenCount = this.numberColumnFields + Math.Max(1, this.numberValueFields);
            }
            else
            {
                this.gridMainDisplay.Model.Cols.FrozenCount = 0;
                this.gridMainDisplay.Model.Rows.FrozenCount = 0;
            }
        }


        #endregion

        #region ShowExpandbutton
        bool showExpandButton = true;

        /// <summary>
        /// Gets or sets whether the design grids are available to the user.
        /// </summary>
        public bool ShowExpandButton
        {
            get { return showExpandButton; }
            set 
            {
                if (showExpandButton != value)
                {
                    showExpandButton = value;
                    if ((showExpandButton && rightPaneCollapsed)
                        || (!showExpandButton && !rightPaneCollapsed))
                    {
                        //need to do it twice to keep things synced up
                        pictureBoxCollapseExpand_Click(pictureBoxExpanded, EventArgs.Empty);
                    }

                    if (!showExpandButton)
                    {
                        this.pictureBoxExpanded.Visible = showExpandButton;
                        this.pictureBoxCollapsed.Visible = showExpandButton;
                    }
                    else
                    {
                        this.pictureBoxExpanded.Visible = showExpandButton;
                    }
                   
                }
            }
        }


        #endregion

        #region DataSource

        object dataSource = null;
        IList list = null;

        /// <summary>
        /// Gets of sets the IList object that serves as the DataSource for this PivotGridControl.
        /// </summary>
        /// <remarks>
        /// This IList object must hold objects that expose public properties in some way.
        /// </remarks>
        public object DataSource
        {
            get { return dataSource; }
            set 
            {
                if (dataSource == null || !dataSource.Equals(value))
                {
                    dataSource = value;
                    this.list = null;
                    if (dataSource is IList)
                    {
                        this.list = dataSource as IList;
                    }
                    else if (dataSource is DataTable)
                    {
                        this.list = ((DataTable)dataSource).DefaultView;
                    }
                    EngineColumns.SetSourceList(this.list);
                    EngineRows.SetSourceList(this.list);
                    EngineValues.SetSourceList(this.list);
                    InitDisplay();
                }
            }
        }

       
        #endregion

        #region grouping Engines

        Engine engineColumns = null;
        Engine engineRows = null;
        Engine engineValues = null;

        /// <summary>
        /// Gets the Grouping Engine that tracks the value fields that are used for this PivotGridControl.
        /// </summary>
        public Engine EngineValues
        {
            get
            {
                if (engineValues == null)
                {
                    engineValues = CreateEngine(PivotContent.Values);
                    engineValues.GroupSummaryInvalidated += new GroupEventHandler(engine_GroupSummaryInvalidated);
                }
                return engineValues;
            }
        }
        /// <summary>
        /// Gets the Grouping Engine that tracks the row fields that are used for this PivotGridControl.
        /// </summary>
        public Engine EngineRows
        {
            get 
            {
                if (engineRows == null)
                {
                    engineRows = CreateEngine(PivotContent.Rows);
                    engineRows.GroupSummaryInvalidated += new GroupEventHandler(engine_GroupSummaryInvalidated);
                }
                return engineRows;
            }
        }

        /// <summary>
        /// Gets the Grouping Engine that tracks the column fields that are used for this PivotGridControl.
        /// </summary>
        public Engine EngineColumns
        {
            get 
            {
                if (engineColumns == null)
                {
                    engineColumns = CreateEngine(PivotContent.Columns);
                    engineColumns.GroupSummaryInvalidated += new GroupEventHandler(engine_GroupSummaryInvalidated);
                }
                return engineColumns; 
            }
        }

        /// <summary>
        /// Override to use a derived engine.
        /// </summary>
        /// <param name="type">Indicates which engine is needed.</param>
        /// <returns>The Engine.</returns>
        public virtual Engine CreateEngine(PivotContent type)
        {
            //just return a default engine...
            return new Engine();
       }

        #endregion

        #region other properties
        private bool autoSizeColumns = true;

        /// <summary>
        /// Gets or sets whether column widths should be to to fully display all calculated values in the MainDisplayGrid.
        /// </summary>
        public bool AutoSizeColumns
        {
            get { return autoSizeColumns; }
            set { autoSizeColumns = value; }
        }

        /// <summary>
        /// Gets the GridControl that holds the pivot table results.
        /// </summary>
        public GridControl MainDisplayGrid
        {
            get { return gridMainDisplay; }
        }
        #endregion

        #endregion

        #region event handlers

        #region Paint
        //used to show intially empty panel - used only once...
        void gridMainDisplay_Paint(object sender, PaintEventArgs e)
        {
            this.gridMainDisplay.Paint -= new PaintEventHandler(gridMainDisplay_Paint);
            appearance_VisualStyleChanged(this, EventArgs.Empty);
            SetLabelVisibility();
        }
        #endregion

        #region QueryCellInfo

        //celltip just for debug.... need to implement true celltip that displays something
        //cachedValuesForQueryCellInfo holds values of collapsed cells
        void gridMainDisplay_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            Point pt = GetCellHashKey(e.RowIndex, e.ColIndex);
            if (cachedValuesForQueryCellInfo.ContainsKey(pt))
            {
                e.Style.Text = GetCachedValue(pt);
            }
            if (e.ColIndex > -1 && e.ColIndex > numberRowFields && numberValueFields > 0 && e.ColIndex < pivotRightCol && IsSummaryRow(e.RowIndex))
            {
                e.Style.ModifyStyle(GetAppearance().RowTotalCell, StyleModifyType.Override);
            }
            //if(e.RowIndex > 0 && e.ColIndex > 0)
            // e.Style.CellTipText = string.Format("{0}", gridMainDisplay.CoveredRanges.FindRange(e.RowIndex, e.ColIndex));
        }

        private bool IsSummaryRow(int rowIndex)
        {
            bool b = false;
            int col = 1;
            while (!b && col <= numberRowFields)
            {
                b = gridMainDisplay[rowIndex, col].Text.EndsWith(TotalString);
                col++;
            }
            return b;
        }

        #endregion

        #region Schema support

        private void ResetEngine(Engine engine)
        {
            engine.TableDescriptor.Reset();
            engine.TableDescriptor.GroupedColumns.Clear();
            engine.TableDescriptor.Summaries.Clear();
            engine.TableDescriptor.RecordFilters.Clear();
        }

        /// <summary>
        /// Resets this PivotGridControl to its initial empty state.
        /// </summary>
        public void ResetSchema()
        {
            //reset the engines...
            ResetEngine(engineColumns);
            ResetEngine(engineRows);
            ResetEngine(engineValues);


            //reset the grids...
            gridRows.RowCount = 0;
            gridColumns.RowCount = 0;
            gridFilter.RowCount = 0;
            gridValues.RowCount = 0;

          

            gridRows.RowCount = 2;
            gridColumns.RowCount = 2;
            gridFilter.RowCount =  2;

            for (int i = 2; i < gridFields.RowCount; ++i)
            {
                SetCheck(gridFields[i, 0].Description, false);
            }
           
            ValuesComputationInfos.Clear();
            gridValues.RowCount = 2;
            

            InitGridRowSizes(gridFields);
            InitGridRowSizes(gridRows);
            InitGridRowSizes(gridColumns);
            InitGridRowSizes(gridFilter);
            InitGridRowSizes(gridValues);

            LayoutAllGrids();
        }

        /// <summary>
        /// Sets the schema of this PivotGridControl to the passed in schema object.
        /// </summary>
        /// <param name="schema"></param>
        public void ApplySchema(PivotSchema schema)
        {
            //reset the engines...
            ResetEngine(engineColumns);
            ResetEngine(engineRows);
            ResetEngine(engineValues);
            

            //reset the grids...
            gridFields.RowCount = 0;
            gridRows.RowCount = 0;
            gridColumns.RowCount = 0;
            gridFilter.RowCount = 0;
            gridValues.RowCount = 0;

            //gridMainColumns.RowCount = 0;
            //gridMainDisplay.RowCount = 0;
            //gridMainFilters.RowCount = 0;
            //gridMainRows.RowCount = 0;
            
            
            gridFields.RowCount = schema.Fields.GetLength(0) + 2;
            for (int i = 2; i < gridFields.RowCount; ++i)
            {
                gridFields[i, 0].Description = schema.Fields[i - 2];
                SetCheck(schema.Fields[i - 2], false);
            }

            gridRows.RowCount = schema.RowFields.GetLength(0) + 2;
            for (int i = 2; i < gridRows.RowCount; ++i)
            {
                gridRows[i, 0].Text = schema.RowFields[i - 2];
                SetCheck(schema.RowFields[i - 2], true);
            }

            gridColumns.RowCount = schema.ColumnFields.GetLength(0) + 2;
            for (int i = 2; i < gridColumns.RowCount; ++i)
            {
                gridColumns[i, 0].Text = schema.ColumnFields[i - 2];
                SetCheck(schema.ColumnFields[i - 2], true);
            }

            gridFilter.RowCount = schema.FilterFields.GetLength(0) + 2;
            for (int i = 2; i < gridFilter.RowCount; ++i)
            {
                gridFilter[i, 0].Text = schema.FilterFields[i - 2];
                SetCheck(schema.FilterFields[i - 2], true);
            }

            gridFilter.RowCount = 0;
            gridFilter.RowCount = schema.FilterValues.GetLength(0) + 2;
            if (gridFilter.RowCount > 2)
                gridMainFilters.RowCount = gridFilter.RowCount - 2;
            for (int i = 2; i < gridFilter.RowCount; ++i)
            {
                gridMainFilters[i - 1, 1].Text = schema.FilterValues[i - 2];
            }

            ValuesComputationInfos.Clear();
           gridValues.RowCount = schema.ValueComputations.GetLength(0) + 2;
            for (int i = 2; i < gridValues.RowCount; ++i)
            {
                 string fieldName = schema.ValueComputations[i - 2].FieldName;
                 string computationName = schema.ValueComputations[i - 2].CalculationName;
                 string fmt = schema.ValueComputations[i - 2].Format;
                 SetCheck(fieldName, true);

                 SummaryBase sum = PivotComputationInfoList.CreateSummary(computationName);// new DoubleAggregateSummary(0, double.MaxValue, double.MinValue, 0d);
                 PivotComputationInfo info = new PivotComputationInfo(sum, computationName, string.Format(DefaultDescriptionFormat, computationName, fieldName), fieldName);
                gridValues[i, 0].Text = fieldName;
                ValuesComputationInfos.Add(info);
            }
        
            InitGridRowSizes(gridFields);
            InitGridRowSizes(gridRows);
            InitGridRowSizes(gridColumns);
            InitGridRowSizes(gridFilter);
            InitGridRowSizes(gridValues);
        
            LayoutAllGrids();
        }

        private void InitGridRowSizes(GridControl grid)
        {
            grid.RowHeights[1] = 1;
            grid.RowHeights[grid.RowCount] = 1;
        }
        private void LayoutAllGrids()
        {
            gridMainColumns.BeginUpdate();
            gridMainDisplay.BeginUpdate();
            gridMainFilters.BeginUpdate();
            gridMainRows.BeginUpdate();

            PerformLayoutOnAllGrids();
            //PerformLayout(gridFields, gridColumns);
            //PerformLayout(gridFields, gridRows);
            //PerformLayout(gridFields, gridValues);
            //PerformLayout(gridFields, gridFilter);

           
            //PerformLayout(gridColumns, null);
            //PerformLayout(gridRows, null);
            //PerformLayout(gridFilter, null);
            //PerformLayout(gridValues, null);



            gridMainColumns.EndUpdate(true);
            gridMainDisplay.EndUpdate(true);
            gridMainFilters.EndUpdate(true);
            gridMainRows.EndUpdate(true);
        }

        private void PerformLayoutOnAllGrids()
        {
         //   DateTime start = DateTime.Now;

              SetUpEngineFromPanelGrids(EngineColumns, gridColumns);
              SetUpMainColumnsGridAndEngines();
              ResizeColumnHeaders();
           
              SetUpEngineFromPanelGrids(EngineRows, gridRows);
              SetUpMainRowsGridAndEngines();
          
              SetUpMainFiltersGridAndApplyFilters();
 

            engineValues.TableDescriptor.GroupedColumns.Clear();
            engineValues.TableDescriptor.Summaries.Clear();
            engineValues.TableDescriptor.Fields.Clear(); //added 

            ArrayList a = new ArrayList();
            for (int i = 2; i <= gridColumns.RowCount - 1; i++)
            {
                a.Add(gridColumns[i, 0].Text);
            }
            for (int i = 2; i <= gridRows.RowCount - 1; i++)
            {
                a.Add(gridRows[i, 0].Text);
            }
            for (int i = 2; i <= gridValues.RowCount - 1; i++)
            {
                a.Add(gridValues[i, 0].Text);
            }

            //force the loading of the fields
            engineValues.TableDescriptor.Fields.LoadDefault();
            //find the ones not being used....
            ArrayList d = new ArrayList();
            foreach (FieldDescriptor fd in engineValues.TableDescriptor.Fields)
            {
                if (a.IndexOf(fd.Name) == -1)
                {
                    d.Add(fd.Name);
                }
            }
            //and delete them.
            foreach (string s in d)
            {
                engineValues.TableDescriptor.Fields.Remove(s);
            }

            //add the value summaries
            string name2;
            for (int i = 2; i <= gridValues.RowCount - 1; i++)
            {
                name2 = gridValues[i, 0].Text;
                AddSummaryToEngine(name2, EngineValues);
            }
            //now group the value engine - first the columns, then the rows...
            for (int i = 2; i <= gridColumns.RowCount - 1; i++)
            {
                engineValues.TableDescriptor.GroupedColumns.Add(gridColumns[i, 0].Text);
            }

            for (int i = 2; i <= gridRows.RowCount - 1; i++)
            {
                if (engineValues.TableDescriptor.GroupedColumns.Count == 0)
                engineValues.TableDescriptor.GroupedColumns.Add(gridRows[i, 0].Text);
            }

            string name;
            for (int i = 2; i <= gridValues.RowCount - 1; i++)
            {
                name = gridValues[i, 0].Text;
                AddSummaryToEngine(name, EngineColumns);
                AddSummaryToEngine(name, EngineRows);
            }


            for (int i = 2; i <= gridFilter.RowCount - 1; ++i)
            {
                if (engineColumns.TableDescriptor.Fields.IndexOf(gridFilter[i, 0].Text) == -1)
                    engineColumns.TableDescriptor.Fields.Add(gridFilter[i, 0].Text);
                if (engineRows.TableDescriptor.Fields.IndexOf(gridFilter[i, 0].Text) == -1)
                    engineRows.TableDescriptor.Fields.Add(gridFilter[i, 0].Text);
                if (engineValues.TableDescriptor.Fields.IndexOf(gridFilter[i, 0].Text) == -1)
                    engineValues.TableDescriptor.Fields.Add(gridFilter[i, 0].Text);
                
            }
            SetLabelVisibility();

            gridMainDisplay.BeginUpdate();
            gridMainDisplay.ColWidths.ResetRange(leftColBase, gridMainDisplay.ColCount);
            PopulateDisplayGrid();
            if (AutoSizeColumns)
            {
                gridMainDisplay.ColWidths.ResizeToFit(GridRangeInfo.Cells(pivotTopRow, pivotLeftCol, pivotBottomRow, pivotRightCol));
            }
            gridMainDisplay.EndUpdate();
            gridMainDisplay.Refresh();
            gridMainRows.Refresh();
            gridMainColumns.Refresh();

            this.Cursor = Cursors.Default;

            //if (this.ParentForm != null)
            //{
            //    this.ParentForm.Text = this.ParentForm.Text + " " + string.Format("Layout#{1} time: {0} secs", ((TimeSpan)(DateTime.Now - start)).TotalSeconds, aaaaa++);
            //}
        }

        /// <summary>
        /// Creates a new PivotSchema object and associates it with this PivotGridControl.
        /// </summary>
        /// <returns></returns>
        public PivotSchema InitSchema()
        {
            PivotSchema schema = new PivotSchema();
            schema.Fields = new string[gridFields.RowCount - 2];
            for (int i = 2; i < gridFields.RowCount; ++i)
            {
                   schema.Fields[i - 2] = gridFields[i, 0].Description;
            }

            schema.RowFields = new string[gridRows.RowCount - 2];
            for (int i = 2; i < gridRows.RowCount; ++i)
            {
                schema.RowFields[i - 2] = gridRows[i, 0].Text;
            }

            schema.ColumnFields = new string[gridColumns.RowCount - 2];
            for (int i = 2; i < gridColumns.RowCount; ++i)
            {
                schema.ColumnFields[i - 2] = gridColumns[i, 0].Text;
            }

            schema.FilterFields = new string[gridFilter.RowCount - 2];
            for (int i = 2; i < gridFilter.RowCount; ++i)
            {
                schema.FilterFields[i - 2] = gridFilter[i, 0].Text;
            }

            schema.FilterValues = new string[gridFilter.RowCount - 2];
            for (int i = 2; i < gridFilter.RowCount; ++i)
            {
                schema.FilterValues[i - 2] = gridMainFilters[i-1, 1].Text;
            }

            schema.ValueComputations = ValuesComputationInfos.ToArray(typeof(PivotComputationInfo)) as PivotComputationInfo[];

            return schema;
        }


        #endregion

        #region node support for expand and collapse and cache data

        [NonSerialized]
        private Hashtable collapsedNodes = null;
        private Point GetCellHashKey(int rowIndex, int colIndex)
        {
            return new Point(colIndex, rowIndex);
        }

        internal Hashtable CollapsedNodes()
        {
             if (collapsedNodes == null)
                    collapsedNodes = new Hashtable();
                return collapsedNodes; 
        }

        /// <summary>
        /// Gets the number of columns in the MainDisplayGrid.
        /// </summary>
         public int ColumnCount
        {
            get { return gridMainDisplay.ColCount; }
        }
      
        //expand collapse...

        void gridMainDisplay_PushButtonClick(object sender, GridCellPushButtonClickEventArgs e)
        {
            this.gridMainDisplay.BeginUpdate();
            if (e.ColIndex < leftColBase)
            {
                ClickRow(e.RowIndex, e.ColIndex);
            }
            else
            {
                ClickCol(e.RowIndex, e.ColIndex);
            }
            this.gridMainDisplay.EndUpdate();
            gridMainDisplay.Refresh();
        }

        private void ClickRow(int rowIndex, int colIndex)
        {
            if (rowIndex >= startGroupRows && rowIndex <= gridMainDisplay.RowCount)
            {
                object key = GetCellHashKey(rowIndex, colIndex);
                if (collapsedNodes.ContainsKey(key))
                {//expanding
                    object[] saved = collapsedNodes[key] as object[];
                    int[] sizes = saved[0] as int[];
                    string[] values = saved[2] as string[];
                    GridRangeInfoList ranges = saved[1] as GridRangeInfoList;

                    collapsedNodes.Remove(key);
                    gridMainDisplay[rowIndex, colIndex].Description = "-";
                    GridRangeInfo range = this.gridMainDisplay.CoveredRanges.FindRange(rowIndex, colIndex);
                    gridMainDisplay.RowHeights.SetRange(rowIndex + 1, rowIndex + sizes.GetLength(0), sizes, true);

                    this.gridMainDisplay.CoveredRanges.Remove(range);
                    foreach (GridRangeInfo r in ranges)
                        this.gridMainDisplay.CoveredRanges.Add(r);

                    int count = pivotRightCol + 1;
                    for (int n = colIndex + 1; n < count; ++n)
                    {
                        RemoveCachedValue(rowIndex, n);
                    }
                }
                else
                {//collapsing
                    object[] save = new object[3];
                    GridRangeInfo range = this.gridMainDisplay.CoveredRanges.FindRange(rowIndex, colIndex);
                    GridRangeInfo newRange = GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + range.Height, rightCol);

                    if (range.IsEmpty) //cacheLastCoveredRange conaints this as cell range..
                        return;
                    save[0] = gridMainDisplay.RowHeights.GetRange(rowIndex + 1, range.Bottom + Math.Max(summaryCount, 1));
                    save[1] = this.gridMainDisplay.CoveredRanges.Ranges.GetRangesIntersecting(newRange);
                    save[2] = new string[summaryCount];

                    //cache the summary values so they are available in QueryCellInfo for the collapsed node
                    int count = pivotRightCol + 1;

                    for (int n = colIndex + 1; n < count; ++n)
                    {
                        CacheValue(rowIndex, n, this.gridMainDisplay[rowIndex + range.Height, n].Text);
                    }

                    collapsedNodes.Add(key, save);
                    gridMainDisplay.RowHeights.SetRange(rowIndex + 1, range.Bottom + 1, 0);
                    gridMainDisplay[rowIndex, colIndex].Description = "+";
                    foreach (GridRangeInfo r in save[1] as GridRangeInfoList)
                    {
                        this.gridMainDisplay.CoveredRanges.Remove(r);
                    }
                    if (!(newRange.Width == 1 && newRange.Height == 1))
                    {
                        this.gridMainDisplay.CoveredRanges.Add(newRange);
                    }
                }
            }
        }

        /// <summary>
        /// Colapses all expanded nodes in the PivotGridControl.
        /// </summary>
        public void CollapseAll()
        {
            gridMainDisplay.BeginUpdate();
            //start at bottom and work up...
            for (int row = pivotBottomRow; row >= pivotTopRow + numberColumnFields; --row)
            {
                for (int col = pivotLeftCol + numberRowFields - 2; col >= pivotLeftCol; --col)
                {
                    GridStyleInfo style = gridMainDisplay[row, col];
                    if (style.CellType == "PivotButtonCell")
                    {
                        object key = GetCellHashKey(row, col);
                        if (!collapsedNodes.ContainsKey(key))
                        {
                            ClickRow(row, col);
                        }
                    }
                }
            }

            for (int row = pivotTopRow + numberColumnFields - 1; row >= pivotTopRow; --row)
            {
                for (int col = pivotRightCol; col >= pivotLeftCol + numberRowFields; --col)
                {
                    GridStyleInfo style = gridMainDisplay[row, col];
                    if (style.CellType == "PivotButtonCell")
                    {
                        object key = GetCellHashKey(row, col);
                        if (!collapsedNodes.ContainsKey(key))
                        {
                            ClickCol(row, col);
                        }
                    }
                }
            }
            gridMainDisplay.EndUpdate();
            gridMainDisplay.Refresh();
        }

        /// <summary>
        /// Expands all the collapsed nodes in the PivotGridControl.
        /// </summary>
        public void ExpandAll()
        {
            gridMainDisplay.BeginUpdate();
            //start at left and work right...
            //for (int row = pivotTopRow + numberColumnFields; row <= pivotBottomRow; ++row)
            for (int row = pivotTopRow + numberColumnFields + 1; row <= pivotBottomRow - 2; ++row)
                       {
                for (int col = pivotLeftCol; col <= pivotLeftCol + numberRowFields - 2; ++col)
                {
                    object key = GetCellHashKey(row, col);
                    if (collapsedNodes.ContainsKey(key))
                    {
                        ClickRow(row, col);

                    }
                }
            }

            //start high and work lower
            for (int row = pivotTopRow + 1; row <= pivotTopRow + numberColumnFields - 1; ++row)
            {
                for (int col = pivotLeftCol + numberRowFields; col <= pivotRightCol; ++col)
                {
                    object key = GetCellHashKey(row, col);
                    if (collapsedNodes.ContainsKey(key))
                    {
                        ClickCol(row, col);
                    }

                }
            }
            gridMainDisplay.EndUpdate();
            gridMainDisplay.Refresh();

            //gridMainDisplay.BeginUpdate();
            ////start at bottom and work up...
            //Point[] keys = new Point[CollapsedNodes.Count];
            //CollapsedNodes.Keys.CopyTo(keys, 0);

            //foreach (Point pt in keys)
            //{
            //    ClickCol(pt.Y, pt.X);
            //    ClickRow(pt.Y, pt.X);
            //}
            //gridMainDisplay.EndUpdate();
            //gridMainDisplay.Refresh();
        }

        private void ClickCol(int rowIndex, int colIndex)
        {
            if (colIndex >= leftColBase && colIndex < ColumnCount)
            {
                object key = GetCellHashKey(rowIndex, colIndex);
                if (collapsedNodes.ContainsKey(key))
                {//expanding
                    object[] saved = collapsedNodes[key] as object[];
                    int[] sizes = saved[0] as int[];
                    string[] values = saved[2] as string[];
                    GridRangeInfoList ranges = saved[1] as GridRangeInfoList;

                    collapsedNodes.Remove(key);
                    gridMainDisplay[rowIndex, colIndex].Description = "-";
                    GridRangeInfo range = this.gridMainDisplay.CoveredRanges.FindRange(rowIndex, colIndex);
                    gridMainDisplay.ColWidths.SetRange(colIndex + 1, colIndex + sizes.GetLength(0), sizes, true);

                    this.gridMainDisplay.CoveredRanges.Remove(range);
                    foreach (GridRangeInfo r in ranges)
                        this.gridMainDisplay.CoveredRanges.Add(r);

                    //remove the cached summary values used in QueryCellInfo
                    int count = pivotBottomRow + 1;
                    for (int k = 0; k < summaryCount; k++)
                    {
                        for (int n = bottomRow + 1; n < count; ++n)
                        {
                            RemoveCachedValue(n, colIndex + k);
                        }
                    }
                }
                else
                {//collapsing
                    object[] save = new object[3];
                    GridRangeInfo range = this.gridMainDisplay.CoveredRanges.FindRange(rowIndex, colIndex);
                    GridRangeInfo newRange = GridRangeInfo.Cells(rowIndex, colIndex, this.bottomRow, colIndex + range.Width + Math.Max(summaryCount, 1) - 1);

                    //GridRangeInfo newRange = GridRangeInfo.Cells(e.RowIndex, e.ColIndex, this.bottomRow, e.ColIndex + Math.Max(summaryCount, 1) - 1);

                    save[0] = gridMainDisplay.ColWidths.GetRange(colIndex + 1, range.Right + Math.Max(summaryCount, 1));
                    save[1] = this.gridMainDisplay.CoveredRanges.Ranges.GetRangesIntersecting(newRange);
                    save[2] = new string[summaryCount];

                    //cache the summary values so they are available in QueryCellInfo for the collapsed node
                    int count = pivotBottomRow + 1;
                    for (int k = 0; k < summaryCount; k++)
                    {
                        for (int n = bottomRow + 1; n < count; ++n)
                        {
                            CacheValue(n, colIndex + k, this.gridMainDisplay[n, colIndex + k + range.Width].Text);
                        }
                    }

                    collapsedNodes.Add(key, save);
                    gridMainDisplay.ColWidths.SetRange(colIndex + 1, range.Right + 1, 0);
                    gridMainDisplay[rowIndex, colIndex].Description = "+";
                    foreach (GridRangeInfo r in save[1] as GridRangeInfoList)
                    {
                        this.gridMainDisplay.CoveredRanges.Remove(r);
                    }
                    if (!(newRange.Height == 1 && newRange.Width == 1))
                    {
                        this.gridMainDisplay.CoveredRanges.Add(newRange);
                    }
                }
            }
        }
       
        Hashtable cachedValuesForQueryCellInfo = new Hashtable();

        private string GetCachedValue(Point pt)
        {
            Stack a = cachedValuesForQueryCellInfo[pt] as Stack;
            return a.Peek().ToString();
        }
        private void RemoveCachedValue(int rowIndex, int colIndex)
        {
            Point pt = GetCellHashKey(rowIndex, colIndex);
            Stack a = cachedValuesForQueryCellInfo[pt] as Stack;
            if (a != null)
            {
                a.Pop();
                if (a.Count == 0)
                {
                    cachedValuesForQueryCellInfo.Remove(pt);
                }
            }
        }
        private void CacheValue(int rowIndex, int colIndex, string value)
        {
            Point pt = GetCellHashKey(rowIndex, colIndex);
            Stack a = cachedValuesForQueryCellInfo[pt] as Stack;
            if (a == null)
            {
                 a = new Stack();
                cachedValuesForQueryCellInfo.Add(pt, a);
            }
            a.Push(value);
        }
        
        private Group GetColGroup(int rowIndex, int colIndex)
        {
            Group g = engineColumns.Table.TopLevelGroup;

            for (int ii = pivotTopRow + 1; ii <= rowIndex; ++ii)
            {
                GridRangeInfo range1 = gridMainDisplay.CoveredRanges.FindRange(ii, colIndex);
                int iii = range1.IsEmpty ? colIndex : range1.Left;
                Console.WriteLine("[" + gridMainDisplay[ii, iii].Text + "]");
                g = g.Groups[gridMainDisplay[ii, iii].Text];
            }
            return g;
        }
        
        
        #endregion

        #region update button and checkbox
        void buttonUpdate_Click(object sender, EventArgs e)
        {
          ////  DisplayGroupAndSubGroups(engineColumns.Table.TopLevelGroup as Group);
            checkBoxDeferLayout.Checked = false;
            LayoutAllGrids();
           
        }

        void checkBoxDeferLayout_CheckedChanged(object sender, EventArgs e)
        {
            this.buttonUpdate.Enabled = this.checkBoxDeferLayout.Checked;
        }
        #endregion

        #region layout support

        private const int MINHEIGHT = 180;
        private bool inSizeChanged = false;
        void panelRB_SizeChanged(object sender, EventArgs e)
        {
            if (panelRB.Height < MINHEIGHT)
            {
                panelRB.Height = MINHEIGHT;
            }
            else if (!inSizeChanged)
            {
                inSizeChanged = true;
                SizeGridsInLowerRight();
                inSizeChanged = false;
            }
        }
       
        public void SetLabelVisibility()
        {
            this.labelColumns.Visible = gridColumns.RowCount <= 2;
            this.labelFilter.Visible = gridFilter.RowCount <= 2;
            this.labelRows.Visible = gridRows.RowCount <= 2;
            this.labelGrid.Visible = gridValues.RowCount <= 2 && this.labelRows.Visible && this.labelColumns.Visible;
           
        }

        private int leftPanelWidth = 90;

        public int LeftPanelWidth
        {
            get { return leftPanelWidth; }
            set 
            {
                if (leftPanelWidth != value)
                {
                    leftPanelWidth = value;
                    SizePanelsOnLeftSide();
                }
            }
        }
        private int leftPanelHeight = 30;

        public int LeftPanelHeight
        {
            get { return leftPanelHeight; }
            set 
            {
                if (leftPanelHeight != value)
                {
                    leftPanelHeight = value;
                    SizePanelsOnLeftSide();
                }
            }
        }

        private void SizePanelsOnLeftSide()
        {
            this.panelFilter.Size = new Size(LeftPanelWidth, LeftPanelHeight);
            this.panelRows.Location = new Point(0, LeftPanelHeight + 1);
            this.panelRows.Size = new Size(LeftPanelWidth, this.panelLeft.Height - LeftPanelHeight - 1);
            this.panelColumns.Location = new Point(LeftPanelWidth + 1, 0);
            this.panelColumns.Size = new Size(this.panelLeft.Width - LeftPanelWidth - 1, LeftPanelHeight);
            this.panelGrid.Location = new Point(LeftPanelWidth + 1, LeftPanelHeight + 1);
            this.panelGrid.Size = new Size(this.panelLeft.Width - LeftPanelWidth - 1, this.panelLeft.Height - LeftPanelHeight - 1);

            //this grid shares the width
            gridMainRows.ColWidths[0] = LeftPanelWidth;
        }

        void panelLeft_SizeChanged(object sender, EventArgs e)
        {
            SizePanelsOnLeftSide();
        }

        private void SizeGridsInLowerRight()
        {
            int midHeight = this.panelRB.Height / 2;
            int midWidth = this.panelRB.Width / 2;
            int gridHeight = midHeight - this.gridFilter.Top - 10;
            int gridWidth = midWidth - this.gridFilter.Left - 10;
            int secondRowStart = midHeight;
            int secondColStart = midWidth;
            int y = secondRowStart + labelRowLabel.Height + 5;
            int x = this.gridFilter.Location.X;// labelRowLabel.Left;

            this.gridFilter.Size = new Size(gridWidth, gridHeight);
            int offset = midHeight + this.labelValues.Height + 5;
            this.gridRows.Size = new Size(gridWidth, gridHeight);
            this.gridRows.Location = new Point(x, y);

            this.gridColumns.Size = new Size(gridWidth, gridHeight);
            this.gridColumns.Location = new Point(midWidth, this.gridFilter.Top);

            this.gridValues.Size = new Size(gridWidth, gridHeight);
            this.gridValues.Location = new Point(midWidth, y);

            pictureBox1.Location = new Point(x, labelReportFilter.Location.Y);
            labelReportFilter.Location = new Point(this.gridFilter.Location.X + pictureBox1.Width + 2, labelReportFilter.Location.Y);
           
            pictureBox2.Location = new Point(midWidth, labelColumnLabel.Location.Y);
            this.labelColumnLabel.Location = new Point(midWidth + pictureBox2.Width + 2, labelColumnLabel.Location.Y);

            pictureBox3.Location = new Point(x, midHeight);
            this.labelRowLabel.Location = new Point(x + pictureBox3.Width + 2, midHeight);

            pictureBox4.Location = new Point(midWidth, midHeight);
            this.labelValues.Location = new Point(midWidth + pictureBox4.Width + 2, midHeight);

          //  this.splitter2.SplitPosition = panelRight.Height / 2;

        }

       
        #endregion

        #region handle click support in values grid to choose Summary

        /// <summary>
        /// Override to use a derived PivotComputationInfoForm so that you can override the Choices property to provide custom choices.
        /// </summary>
        /// <returns>A CreatePivotComputationInfoForm object.</returns>
        protected virtual PivotComputationInfoForm CreatePivotComputationInfoForm()
        {
            return new PivotComputationInfoForm();
        }
        void gridValues_CellClick(object sender, GridCellClickEventArgs e)
        {
            PivotComputationInfoForm f = CreatePivotComputationInfoForm();
            string name = gridValues[e.RowIndex, 0].Text;


            PivotComputationInfo comp = ValuesComputationInfos.Find(name);
            int loc = -1;
            if (comp == null)
            {
                PivotComputationInfo info = f.Choices.Find(DefaultComputationName);
                if (info != null)
                {
                    comp = info;
                    comp.FieldName = name;
                    comp.Format = "#.##";
                    comp.CalculationName = info.CalculationName;
                }
                else
                {
                    throw new ArgumentException("Invalid PivotGridCOntrol.DefaultComputationName");
                }
            }
            else
            {
                loc = ValuesComputationInfos.IndexOf(comp);
                ValuesComputationInfos.RemoveAt(loc);
            }
            
            f.ComputationInfo = comp;
            f.PivotGrid = this;
            f.StartPosition = FormStartPosition.Manual;
            Point pt = Control.MousePosition;
            f.Location = new Point(pt.X, pt.Y); //puts up form with topleft at mouseclick
            //f.Location = new Point( pt.X - f.Width / 2, pt.Y - f.Height / 2); //puts up form centered at mouseclick

             if (f.ShowDialog() == DialogResult.OK)
            {
                if (loc == -1)
                {
                    ValuesComputationInfos.Add(f.ComputationInfo);
                }
                else
                {
                    ValuesComputationInfos.Insert(loc, f.ComputationInfo);
                }

                PerformLayout(gridValues, null);

            }
        }
        PivotComputationInfoList valuesComputationInfos;

        public PivotComputationInfoList ValuesComputationInfos
        {
            get 
            {
                if (valuesComputationInfos == null)
                    valuesComputationInfos = new PivotComputationInfoList();
                return valuesComputationInfos; 
            }
        }

        #endregion

        #region drag drop support
        void grid_RowsMoved(object sender, GridRangeMovedEventArgs e)
        {
            if (ignoreRowMoving)
                return;
            GridList sourceGrid = sender as GridList;
            PerformLayout(sourceGrid, null);
        }

        void gridFilter_RowsMoving(object sender, GridRangeMovingEventArgs e)
        {
            e.Cancel = true;
        }


        private bool ignoreRowMoving = false;
        void grid_RowsMoving(object sender, GridRangeMovingEventArgs e)
        {
            if (ignoreRowMoving)
                return;

            GridList sourceGrid = sender as GridList;
            Point pt = sourceGrid.Parent.PointToClient(Control.MousePosition);
            GridControl targetGrid = null;
            e.Cancel = true;
            string fieldName = "";
            if (!sourceGrid.Bounds.Contains(pt))
            {
                targetGrid = LocateGrid(sourceGrid.Parent.PointToScreen(pt));
                if (targetGrid != null)
                {
                    fieldName = sourceGrid.Equals(gridFields) ? sourceGrid[e.From, 0].Description : sourceGrid[e.From, 0].Text;
                    for (int i = 2; i <= targetGrid.RowCount + 1; ++i)
                    {
                        if (fieldName == targetGrid[i, 0].Text)
                        {
                            return;// already present
                        }
                    }

                    if (sourceGrid != gridFields)
                    {
                        sourceGrid.Rows.RemoveRange(e.From, e.From);
                    }

                    if (targetGrid == gridFields)
                    {
                        SetCheck(fieldName, false);
                    }
                    else
                    {
                        if (sourceGrid == gridFields && targetGrid == gridFilter)
                        {
                            // clear the use case...
                            int location;
                            GridList grid = FindField(fieldName, out location) as GridList;
                            if (grid != null && location != -1)
                            {
                                grid.Rows.RemoveRange(location, location);
                                PerformLayout(grid, null);
                            }
                        }                        
                        targetGrid.Rows.InsertRange(targetGrid.RowCount, 1);
                        targetGrid[targetGrid.RowCount - 1, 0].Text = fieldName;
                        SetCheck(fieldName, true);
                        if (targetGrid == gridFilter)
                        {
                            SetUpMainFiltersGridAndApplyFilters();
                        }
                    }                   
                }
            }
            else if(!sourceGrid.Equals(gridFields))
            {
                int row = e.Target;
                if (e.Target < 2)
                {
                    row = 2;
                }
                else if (e.Target > sourceGrid.RowCount - 1)
                {
                    row = sourceGrid.RowCount - 1;
                }
                ignoreRowMoving = true;
                sourceGrid.Rows.MoveRange(e.From, row);
                ignoreRowMoving = false;
            }
            PerformLayout(sourceGrid, targetGrid);
        }


        void grid_FieldDrop(object sender, FieldDropEventArgs e)
        {
            if (ignoreRowMoving)
                return;


            GridList sourceGrid = sender as GridList;
            Point pt = sourceGrid.Parent.PointToClient(Control.MousePosition);//e.DropPoint;
            GridControl targetGrid = null;
            string fieldName = "";
            if (!sourceGrid.Bounds.Contains(pt))
            {
                targetGrid = LocateGrid(sourceGrid.Parent.PointToScreen(pt));
                if (targetGrid != null)
                {
                    fieldName = e.Field;//sourceGrid.Equals(gridFields) ? sourceGrid[e.From, 0].Description : sourceGrid[e.From, 0].Text;
                    for (int i = 2; i <= targetGrid.RowCount + 1; ++i)
                    {
                        if (fieldName == targetGrid[i, 0].Text)
                        {
                            return;// already present
                        }
                    }
                    if (sourceGrid != gridFields)
                    {
                        sourceGrid.Rows.RemoveRange(e.FieldIndex, e.FieldIndex);
                    }

                    if (targetGrid == gridFields)
                    {
                        SetCheck(fieldName, false);
                    }
                    else
                    {
                        if (sourceGrid == gridFields && targetGrid == gridFilter)
                        {
                            // clear the use case...
                            int location;
                            GridList grid = FindField(fieldName, out location) as GridList;
                            if (grid != null && location != -1)
                            {
                                grid.Rows.RemoveRange(location, location);
                                PerformLayout(grid, null);
                            }
                        }                        
                        int dropAt = Math.Max(Math.Min(e.DropAtIndex, targetGrid.Model.RowCount), 2);
                        //if (targetGrid.Model.RowCount - 2 > dropAt)
                            targetGrid.Rows.InsertRange(dropAt, 1);
                        //targetGrid.Rows.InsertRange(targetGrid.RowCount, 1);
                        targetGrid[dropAt /*targetGrid.RowCount - 1*/, 0].Text = fieldName;
                        SetCheck(fieldName, true);
                        if (targetGrid == gridFilter)
                        {
                            SetUpMainFiltersGridAndApplyFilters();
                        }
                    }                    
                    if (targetGrid == gridFields && sourceGrid == gridFilter)
                        SetUpMainFiltersGridAndApplyFilters();

                }
			  }
            else if (!sourceGrid.Equals(gridFields))
            {
                //int row = e.Target;
                //if (e.Target < 2)
                //{
                //    row = 2;
                //}
                //else if (e.Target > sourceGrid.RowCount - 1)
                //{
                //    row = sourceGrid.RowCount - 1;
                //}
                //ignoreRowMoving = true;
                //sourceGrid.Rows.MoveRange(e.From, row);
                //ignoreRowMoving = false;
            }
            PerformLayout(sourceGrid, targetGrid);

        }

        void grid_QueryCanDropField(object sender, QueryCanDropFieldEventArgs e)
        {
            GridList sourceGrid = sender as GridList;
            Point pt = sourceGrid.Parent.PointToClient(Control.MousePosition);//e.MousePoint;
            GridControl targetGrid = null;
                targetGrid = LocateGrid(sourceGrid.Parent.PointToScreen(pt));
           
            if (!sourceGrid.Bounds.Contains(pt))
            {
                if (targetGrid != null)
                {
                    string fieldName = e.Field;
                    for (int i = 2; i <= targetGrid.RowCount + 1; ++i)
                    {
                        if (fieldName == targetGrid[i, 0].Text)
                        {
                            e.CanDrop = false;
                            return;// already present
                        }
                    }
                    e.DropOnGrid = targetGrid;
                    e.CanDrop = true;
                }
            }
            else if(targetGrid != null)
            {
                if (targetGrid.Equals(gridFilter))
                    e.CanDrop = false;
                else
                    e.CanDrop = true;
            }

        }

        private void SetUpEngineFromPanelGrids(Engine engine, GridControl grid)
        {
            engine.Table.TableDirty = true;
            engine.TableDescriptor.Fields.Clear();
            engine.TableDescriptor.GroupedColumns.Clear();
            engine.TableDescriptor.Summaries.Clear();
            for (int i = 2; i <= grid.RowCount - 1; i++)
            {
               // engine.TableDescriptor.Fields.Add(grid[i, 0].Text);
                AddFieldToEngine(engine, grid[i, 0].Text);
            }
        }

        private void SetUpMainColumnsGridAndEngines()
        {
            if (gridColumns.RowCount>0)
            gridMainColumns.ColCount = gridColumns.RowCount - 2;
            
            gridMainColumns.Model.ColWidths[0] = 0;
            gridMainColumns.RowCount = 0;
         
            for (int i = 2; i <= gridColumns.RowCount - 1; i++)
            {
                AddFieldToEngine(engineRows, gridColumns[i, 0].Text);
                gridMainColumns[0, i - 1].Text = gridColumns[i, 0].Text;
            }

            for (int i = 2; i <= gridValues.RowCount - 1; i++)
            {
                AddSummaryToEngine(gridValues[i, 0].Text, EngineColumns);
            }

            gridMainColumns.ColWidths[0] = 0;

            for (int i = 2; i <= gridColumns.RowCount - 1; i++)
            {
                if (!engineColumns.TableDescriptor.GroupedColumns.Contains(gridColumns[i, 0].Text))
                    engineColumns.TableDescriptor.GroupedColumns.Add(gridColumns[i, 0].Text);
            }
            SetLabelVisibility();
        }

        private SummaryType GetSummaryType(PivotComputationInfo info)
        {
            //assume DoubleAggregate
            SummaryType st = SummaryType.DoubleAggregate;
            switch (info.CalculationName)
            {
                case "StdDev":
                case "StdDevP":
                case "Var":
                case "VarP":
                    st = SummaryType.Custom;
                    break;
                case "Count":
                    st = SummaryType.Count;
                    break;
                case "Median":
                case "Percentile25":
                case "Percentile75":
                    st = SummaryType.DoubleVector;
                    break;
                case "Sum":
                case "Average":
                default:
                    break;
            }

            return st;
        }

        private string defaultDescriptionFormat = "{0} of {1}";//0=ComputationName and 1=FieldName

        /// <summary>
        /// Defines the format of the calculation description. Use {0} for the ComputationName value
        /// and {1} for the FieldName value. The default value for this string is "{0} of {1}".
        /// </summary>
        public string DefaultDescriptionFormat
        {
            get { return defaultDescriptionFormat; }
            set { defaultDescriptionFormat = value; }
        }


        private string defaultComputationName = "Sum";

        /// <summary>
        /// Specifies the name of the default calculation. The default value is "Sum".
        /// </summary>
        public string DefaultComputationName
        {
            get { return defaultComputationName; }
            set { defaultComputationName = value; }
        }
        private void AddSummaryToEngine(string fieldName, Engine engine)
        {
            PivotComputationInfo info = ValuesComputationInfos.Find(fieldName);
            if (info == null)
            {
                string computationName = DefaultComputationName; //default computation
                FieldDescriptor fd = EngineValues.TableDescriptor.Fields[fieldName];
                if (fd != null && fd.FieldPropertyType == typeof(string))
                {
                    computationName = "Count";
                }

                SummaryBase sum = PivotComputationInfoList.CreateSummary(computationName);// new DoubleAggregateSummary(0, double.MaxValue, double.MinValue, 0d);
                info = new PivotComputationInfo(sum, computationName, string.Format(DefaultDescriptionFormat, computationName, fieldName), fieldName);
                ValuesComputationInfos.Add(info);
            }

            if (engine.TableDescriptor.Fields.IndexOf(fieldName) == -1)
            {
               // engine.TableDescriptor.Fields.Add(fieldName);
                AddFieldToEngine(engine, fieldName);
            }

            SummaryType st = GetSummaryType(info);
            SummaryDescriptor sd = new SummaryDescriptor(fieldName + " " + info.CalculationName, fieldName, st);
            if (st == SummaryType.Custom)
            {
                sd.CreateSummaryMethod = new CreateSummaryDelegate(DoubleStdDevSummary.CreateSummaryMethod);
            }
 
            engine.TableDescriptor.Summaries.Add(sd);

        }

        private const int FILTERPAD = 4; //On the left side grids, the distance between bottom of filter grid and top of the row grid
        private void SetUpMainFiltersGridAndApplyFilters()
        {
            if(gridFilter.RowCount>0)
            gridMainFilters.RowCount = gridFilter.RowCount - 2;
            
            gridMainFilters.Model.RowHeights[0] = 0;
            gridMainFilters.ColCount = 1;
            gridMainFilters.ColStyles[1].CellType = "DropDownCheckList";

            //populate the dropdowns
            string name;
            for (int i = 2; i <= gridFilter.RowCount - 1; i++)
            {
                name = gridFilter[i, 0].Text;
                gridMainFilters[i - 1, 0].Text = name + ":";
                gridMainFilters[i-1, 1].DataSource = CreateUniqueEntries(name); 
            }


            gridMainFilters.BaseStylesMap["Row Header"].StyleInfo.HorizontalAlignment = GridHorizontalAlignment.Right;
            gridMainFilters.HScrollBehavior = GridScrollbarMode.Disabled;
            gridMainFilters.VScrollBehavior = GridScrollbarMode.Disabled;
            gridMainFilters.HScroll = false;
            gridMainFilters.VScroll = false;
            if (gridFilter.RowCount - 2 > 0)
            {
                gridMainFilters.ColWidths.ResizeToFit(GridRangeInfo.Cells(1, 0, gridFilter.RowCount - 2, 0));
            }
            gridMainFilters.ResetVolatileData();

            
            gridMainFilters.RowHeights[0] = 0;

            //need to set height of gridMainFilter....
            if (gridFilter.RowCount - 2 > 0)
            {
                LeftPanelHeight = Math.Max(gridMainColumns.RowHeights[0], FILTERPAD + gridMainFilters.RowHeights.GetTotal(0, gridMainFilters.RowCount));
                LeftPanelWidth = gridMainFilters.ColWidths.GetTotal(0, gridMainFilters.ColCount);
            }
            gridMainFilters.HScrollBehavior = GridScrollbarMode.Disabled;
            gridMainFilters.HScroll = false;
            SetLabelVisibility();
        }

        private void SetUpMainRowsGridAndEngines()
        {
            if(gridRows.RowCount>0)
            gridMainRows.RowCount = gridRows.RowCount - 2;
           // gridMainRows.Model.RowHeights[0] = 0;
            gridMainRows.ColCount = 0;
            gridMainRows.ColWidths[0] = LeftPanelWidth;
            gridMainRows.ResetVolatileData();

            for (int i = 2; i <= gridColumns.RowCount - 1; i++)
            {
                AddFieldToEngine(engineRows, gridColumns[i, 0].Text);
            }
            for (int i = 2; i <= gridRows.RowCount - 1; i++)
            {
                gridMainRows[i - 1, 0].Text = gridRows[i, 0].Text;
            }

            gridMainRows.DefaultRowHeight = gridMainColumns.RowHeights[0];
            gridMainRows.RowHeights[0] = 0;

            for (int i = 2; i <= gridValues.RowCount - 1; i++)
            {
                AddSummaryToEngine(gridValues[i, 0].Text, EngineRows);
            }

            engineRows.TableDescriptor.GroupedColumns.Clear();
            for (int i = 2; i <= gridRows.RowCount - 1; i++)
            {
                if (!engineRows.TableDescriptor.GroupedColumns.Contains(gridRows[i, 0].Text))
                    engineRows.TableDescriptor.GroupedColumns.Add(gridRows[i, 0].Text);
            }
            SetLabelVisibility();
        }

        #region freeze painting support for PivotGridControl
        int paintFrozen;
        private const int WM_SETREDRAW = 0xB;
        [DllImport("User32")]
        private static extern bool SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private bool FreezePainting
        {
            get { return paintFrozen > 0; }
            set
            {
                if (value && IsHandleCreated && this.Visible)
                {
                    if (0 == paintFrozen++)
                    {
                        SendMessage(Handle, WM_SETREDRAW, 0, 0);
                    }
                }

                if (!value)
                {
                    if (paintFrozen == 0)
                    {
                        return;
                    }

                    if (0 == --paintFrozen)
                    {
                        SendMessage(Handle, WM_SETREDRAW, 1, 0);
                        Invalidate(true);
                    }
                }
            }
        }
        #endregion

        private void PerformLayout(GridList sourceGrid, GridControl targetGrid)
        {
          //  DateTime start = DateTime.Now;
            this.Cursor = Cursors.WaitCursor;

            //check if layout should be deferred..
            if (checkBoxDeferLayout.Checked)
            {
                string name1;
                for (int i = 2; i <= gridValues.RowCount - 1; i++)
                {
                    name1 = gridValues[i, 0].Text;
                    AddSummaryToEngine(name1, EngineValues);
                }
                return;
            }

            FreezePainting = true;
            ExpandAll();

            //first remove the field if the source != target and != gridFields
              if (sourceGrid.Equals(gridColumns))
                {
                    SetUpEngineFromPanelGrids(EngineColumns, gridColumns);
                    SetUpMainColumnsGridAndEngines();
                    ResizeColumnHeaders();
                }
                else if (sourceGrid.Equals(gridRows))
                {
                    SetUpEngineFromPanelGrids(EngineRows, gridRows);
                    SetUpMainRowsGridAndEngines();
                }
               
            

            //first check to see if need to make a change because the columns (gridColumns) were modified
            if (!sourceGrid.Equals(gridColumns) && (targetGrid != null && targetGrid.Equals(gridColumns)))
            {
                SetUpEngineFromPanelGrids(EngineColumns, gridColumns);
                SetUpMainColumnsGridAndEngines();
                ResizeColumnHeaders();
            }
            //now check to see if need to make a change because the rows (gridRows) were modified
            else if (!sourceGrid.Equals(gridRows) && (targetGrid != null && targetGrid.Equals(gridRows)))
            {
                SetUpEngineFromPanelGrids(EngineRows, gridRows);
                SetUpMainRowsGridAndEngines();
            }
            //now check to see if need to make a change because the filters (gridFilters) were modified
            else if (!sourceGrid.Equals(gridFilter) && (targetGrid != null && targetGrid.Equals(gridFilter)))
            {
                 SetUpMainFiltersGridAndApplyFilters();
            }


            engineColumns.TableDescriptor.Summaries.Clear();
            engineRows.TableDescriptor.Summaries.Clear();
            engineValues.TableDescriptor.GroupedColumns.Clear();
            engineValues.TableDescriptor.Summaries.Clear();
            engineValues.TableDescriptor.Fields.Clear(); //added 
          
            #region set up the values engine

            //setup value engine - add the columns fields first, then add the row fields
            //colect the fields that are used...
            ArrayList a = new ArrayList();
            for (int i = 2; i <= gridColumns.RowCount - 1; i++)
            {
                a.Add(gridColumns[i, 0].Text);
            }
            for (int i = 2; i <= gridRows.RowCount - 1; i++)
            {
                //engineValues.TableDescriptor.Fields.Add(gridRows[i, 0].Text);
                a.Add(gridRows[i, 0].Text);
            }
            for (int i = 2; i <= gridValues.RowCount - 1; i++)
            {
                //engineValues.TableDescriptor.Fields.Add(gridValues[i, 0].Text);
                a.Add(gridValues[i, 0].Text);
            }

            //force the loading of the fields
            engineValues.TableDescriptor.Fields.LoadDefault();
            //find the ones not being used....
            ArrayList d = new ArrayList();
            foreach (FieldDescriptor fd in engineValues.TableDescriptor.Fields)
            {
                if (a.IndexOf(fd.Name) == -1)
                {
                    d.Add(fd.Name);
                }
            }
            //and delete them.
            foreach (string s in d)
            {
                engineValues.TableDescriptor.Fields.Remove(s);
            }

            engineValues.TableDescriptor.GroupedColumns.Clear();
            engineValues.TableDescriptor.Summaries.Clear();

            //add the value summaries
            string name2;
            for (int i = 2; i <= gridValues.RowCount - 1; i++)
            {
                name2 = gridValues[i, 0].Text;
                AddSummaryToEngine(name2, EngineValues);
            }
            //now group the value engine - first the columns, then the rows...
            for (int i = 2; i <= gridColumns.RowCount - 1; i++)
            {
                if(!engineValues.TableDescriptor.GroupedColumns.Contains(gridColumns[i, 0].Text))
                engineValues.TableDescriptor.GroupedColumns.Add(gridColumns[i, 0].Text);
            }

            for (int i = 2; i <= gridRows.RowCount - 1; i++)
            {
                if(!engineValues.TableDescriptor.GroupedColumns.Contains(gridRows[i, 0].Text))
                engineValues.TableDescriptor.GroupedColumns.Add(gridRows[i, 0].Text);
            }

            #endregion

            string name;
            for (int i = 2; i <= gridValues.RowCount - 1; i++)
            {
                name = gridValues[i, 0].Text;
                AddSummaryToEngine(name, EngineColumns);
                AddSummaryToEngine(name, EngineRows);
            }


            for (int i = 2; i <= gridFilter.RowCount - 1; ++i)
            {
                if (engineColumns.TableDescriptor.Fields.IndexOf(gridFilter[i, 0].Text) == -1)
                    engineColumns.TableDescriptor.Fields.Add(gridFilter[i, 0].Text);
                if (engineRows.TableDescriptor.Fields.IndexOf(gridFilter[i, 0].Text) == -1)
                    engineRows.TableDescriptor.Fields.Add(gridFilter[i, 0].Text);
                if (engineValues.TableDescriptor.Fields.IndexOf(gridFilter[i, 0].Text) == -1)
                    engineValues.TableDescriptor.Fields.Add(gridFilter[i, 0].Text);

            }

            if (sourceGrid.Equals(gridValues) || (targetGrid != null && targetGrid.Equals(gridValues)))
            {
                for (int i = 2; i <= gridValues.RowCount - 1; i++)
                {
                    PivotComputationInfo comp = ValuesComputationInfos.Find(gridValues[i, 0].Text);
                    int loc = valuesComputationInfos.IndexOf(comp);
                    if (loc != -1)
                    {
                        if (loc != i - 2)
                        {
                            ValuesComputationInfos.RemoveAt(loc);
                            valuesComputationInfos.Insert(i - 2, comp);
                        }
                    }
                }
            }  

            SetLabelVisibility();

            gridMainDisplay.BeginUpdate();

            //reset so no left over rows are seen...
            gridMainDisplay.RowCount = 2;

            gridMainDisplay.ColWidths.ResetRange(leftColBase, gridMainDisplay.ColCount);
            PopulateDisplayGrid();
            if (AutoSizeColumns)
            {
                gridMainDisplay.ColWidths.ResizeToFit(GridRangeInfo.Cells(pivotTopRow, pivotLeftCol, pivotBottomRow, pivotRightCol));
            }
            gridMainDisplay.EndUpdate();
            FreezePainting = false;
            gridMainDisplay.Refresh();
            gridMainRows.Refresh();
            gridMainColumns.Refresh();

            this.Cursor = Cursors.Default;

            //if (this.ParentForm != null)
            //{
            //    this.ParentForm.Text = this.ParentForm.Text + " " + string.Format("Layout#{1} time: {0} secs", ((TimeSpan)(DateTime.Now - start)).TotalSeconds, aaaaa++);
            //}
        }
      //  private int aaaaa = 0;

        private void ResizeColumnHeaders()
        {
            gridMainColumns.ColWidths.ResizeToFit(GridRangeInfo.Cells(0, 1, 0, gridMainColumns.ColCount), GridResizeToFitOptions.IncludeHeaders); 
            for (int i = 1; i <= gridMainColumns.ColCount; ++i)
                gridMainColumns.ColWidths[i] = gridMainColumns.ColWidths[i] + 24; //icon width
        }
       

        private void AddFieldToEngine(Engine engine, string fieldName)
        {
            if (engine.TableDescriptor.Fields.IndexOf(fieldName) == -1)
            {
                ITypedList typedList = list as ITypedList;
                PropertyDescriptor pd = typedList.GetItemProperties(null)[fieldName];
                if (pd != null)
                {
                    FieldDescriptor fd = new FieldDescriptor(fieldName, pd.PropertyType);
                    engine.TableDescriptor.Fields.Add(fd);
                }
            }
        }

        
        private IList CreateUniqueEntries(string fieldName)
        {
            ArrayList entries = new ArrayList();
            ITypedList typedList = list as ITypedList;
            PropertyDescriptor pd = typedList.GetItemProperties(null)[fieldName];
            if (pd != null)
            {
                foreach (object o in list)
                {
                    string s = pd.GetValue(o).ToString();
                    int i = entries.BinarySearch(s);
                    if (i < 0)
                        entries.Insert(-i - 1, s);
                }
            }
            entries.Insert(0, AllString);
            return entries;
        }

        int startGroupColumns;

        /// <summary>
        /// This method updates all the calculations being displayed. Use it after values in the underlying IList
        /// DataSource have changed to make sure the calculations are current.
        /// </summary>
        public void UpdateValues()
        {
            Point[] keys = new Point[collapsedNodes.Keys.Count];
            collapsedNodes.Keys.CopyTo(keys, 0);
           
            gridMainDisplay.BeginUpdate();
            ExpandAll();
            PopulateDisplayGrid();
            
            foreach (Point key in keys)
            {
                if(key.Y <= numberColumnFields)
                    ClickCol(key.Y, key.X);
                else if(key.X < numberRowFields)
                    ClickRow(key.Y, key.X);
            }
            gridMainDisplay.EndUpdate();

            gridMainDisplay.Refresh();
             
        }

     
        int recurLevel = 0;
        int bottomRow = 0;
        int rightCol = 0;
        int summaryCount = 0;

        private bool CheckFilter(Group group)
        {
            for (int i = 2; i <= gridFilter.RowCount; i++)
            {
                if (gridFilter[i, 0].Text == group.Name)
                {
                    for (int k = 1; k <= gridMainFilters.RowCount; k++)
                    {
                        string Name = gridMainFilters[k, 0].Text.Substring(0, gridMainFilters[k, 0].Text.Length - 1);
                        if (Name == group.Name)
                        {
                            bool filter = true;
                            if (engineValues.TableDescriptor.RecordFilters.IndexOf(Name) == -1 &&
                                engineValues.TableDescriptor.RecordFilters.IndexOf(Name) == -1 &&
                                engineColumns.TableDescriptor.RecordFilters.IndexOf(Name) == -1 &&
                                engineRows.TableDescriptor.RecordFilters.IndexOf(Name) == -1)
                            {
                                filter = false;
                            }
                            string value = gridMainFilters[k, 1].Text;
                            if (filter && !value.Contains(group.Category.ToString()))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private int AddGroupRowsToGrid(int rowIndex, Group parentGroup, int colIndex)
        {
            if (recurLevel == 0)
            {
                rightCol = colIndex;
            }

            recurLevel++;

            foreach (Group g in parentGroup.Groups)
            {
                if (g.Groups != null && g.Groups.Count > 0)
                {
                    gridMainDisplay[rowIndex, colIndex].ModifyStyle(GetAppearance().RowExpandCell, StyleModifyType.Override);
                    gridMainDisplay[rowIndex, colIndex].Text = g.Category.ToString();
                    int top = rowIndex;
                    gridMainDisplay[rowIndex, colIndex].CellType = "PivotButtonCell";
                    gridMainDisplay[rowIndex, colIndex].Description = "-";
                    rowIndex = AddGroupRowsToGrid(rowIndex, g, colIndex + 1);

                    gridMainDisplay[rowIndex, colIndex].ModifyStyle(GetAppearance().RowTotalCell, StyleModifyType.Override);
                    DisplayRowSummaryItems(rowIndex, colIndex, g, g.Category.ToString() + " Total");
                    int w = Math.Max(summaryCount, 1) - 1;
                    if (!(top == rowIndex - 1))
                    {
                        gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(top, colIndex, rowIndex - 1, colIndex));
                        if (CheckFilter(g))
                            this.gridMainDisplay.HideRows.SetRange(top, rowIndex - 1, true); 
                    }
                    this.gridMainDisplay.HideRows[rowIndex] = CheckFilter(g);                  
                    if (!(colIndex == rightCol))
                                 gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, rightCol));
                    rowIndex = rowIndex + 1;
                }
                else
                {
                    rightCol = colIndex;
                    gridMainDisplay[rowIndex, colIndex].ModifyStyle(GetAppearance().RowCell, StyleModifyType.Override);
                    DisplayRowSummaryItems(rowIndex, colIndex, g, g.Category.ToString());
                    this.gridMainDisplay.HideRows[rowIndex] = CheckFilter(g);
                    rowIndex = rowIndex + 1;
                }

            }
            recurLevel--;
            if (recurLevel == 0)
            {
                EnsureRowCount(rowIndex);
                gridMainDisplay[rowIndex, colIndex].ModifyStyle(GetAppearance().RowTotalCell, StyleModifyType.Override);
                DisplayRowSummaryItems(rowIndex, colIndex, engineRows.Table.TopLevelGroup, GrandTotalString);
                if(!(colIndex == rightCol))
                         gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, rightCol));
                if (summaryCount > 1)
                {
                    int col = rightCol + 1;
                    while (col + summaryCount - 1 <= pivotRightCol)
                    {
                        for (int k = 0; k < summaryCount; ++k)
                        {
                            gridMainDisplay[startGroupRows - 1, col].ModifyStyle(GetAppearance().CalculationNameCell, StyleModifyType.Override);
                            gridMainDisplay[startGroupRows - 1, col].Text = ValuesComputationInfos[k].Description;
                            col++;
                        }
                    }
                }
                else if (summaryCount == 1)
                {
                    if (numberColumnFields == 0)
                    {
                      gridMainDisplay[startGroupRows - 2, pivotLeftCol].ModifyStyle(GetAppearance().CalculationNameCell, StyleModifyType.Override);
                      gridMainDisplay[startGroupRows - 1, rightCol + 1].ModifyStyle(GetAppearance().RowTotalCell, StyleModifyType.Override);
                           
                        gridMainDisplay[startGroupRows - 2, pivotLeftCol].Text = ValuesComputationInfos[0].Description;
                        gridMainDisplay[startGroupRows - 1, rightCol + 1].Text = TotalString;
                    }
                    //else
                    //{
                    //    gridMainDisplay[startGroupRows - 1, rightCol + 1].ModifyStyle(GetAppearance().RowTotalCell, StyleModifyType.Override);
                    //    gridMainDisplay[startGroupRows - 1, rightCol + 1].BackColor = Color.Yellow;
                    //     gridMainDisplay[startGroupRows - 1, rightCol + 1].Text = TotalString;
                    //}

                }
           
            }
            return rowIndex;


        }

        private void EnsureRowCount(int rowIndex)
        {
            if (rowIndex + summaryCount > gridMainDisplay.RowCount)
            {
                gridMainDisplay.RowCount = rowIndex + summaryCount;
            }
        }

        private int AddGroupColumnsToGrid(int rowIndex, Group parentGroup, int colIndex)
        {
            return AddGroupColumnsToGrid(rowIndex, parentGroup, colIndex, true);
        }

        private int AddGroupColumnsToGrid(int rowIndex, Group parentGroup, int colIndex, bool setCovededCells)
        {
            if (recurLevel == 0)
            {
                
                colIndex = leftColBase;
                bottomRow = rowIndex;
            }

            recurLevel++;
            
            foreach (Group g in parentGroup.Groups)
            {
         
                if (g.Groups != null && g.Groups.Count > 0)
                {
                    gridMainDisplay[rowIndex, colIndex].ModifyStyle(GetAppearance().ColumnExpandCell, StyleModifyType.Override);
                    gridMainDisplay[rowIndex, colIndex].Text = g.Category.ToString();
                    int left = colIndex;
                    gridMainDisplay[rowIndex, colIndex].CellType = "PivotButtonCell";
                    gridMainDisplay[rowIndex, colIndex].Description = "-";
                    colIndex = AddGroupColumnsToGrid(rowIndex + 1, g, colIndex);
                
                    gridMainDisplay[rowIndex, colIndex].ModifyStyle(GetAppearance().ColumnTotalCell, StyleModifyType.Override);
                    DisplayColumnSummaryItems(rowIndex, colIndex, g, g.Category.ToString() + " " + TotalString);
                    if (setCovededCells)
                    {
                        int w = Math.Max(summaryCount, 1) - 1;
                        if (!(left == colIndex - 1))
                        {
                            gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, left, rowIndex, colIndex - 1));
                            if (CheckFilter(g))
                                this.gridMainDisplay.HideCols.SetRange(left, colIndex - 1, true);
                        }
                        if (!(rowIndex == bottomRow && w == 0))
                            gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, bottomRow, colIndex + w));
                    }
                    this.gridMainDisplay.HideCols[colIndex] = CheckFilter(g);                    
                    colIndex = colIndex + Math.Max(1, gridValues.RowCount - 2);
                }
                else
                {
                  //  EnsureColumnCount(colIndex);
                    bottomRow = rowIndex;
                    gridMainDisplay[rowIndex, colIndex].ModifyStyle(GetAppearance().ColumnCell, StyleModifyType.Override);
                    
                    DisplayColumnSummaryItems(rowIndex, colIndex, g, g.Category.ToString());
                    if (summaryCount > 1)
                    {
                        if (setCovededCells)
                        {
                            gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, colIndex + summaryCount - 1));
                        }
                    }
                    this.gridMainDisplay.HideCols[colIndex] = CheckFilter(g);                    
                    colIndex = colIndex + Math.Max(1, summaryCount);
                }

            }
            recurLevel--;
            if (recurLevel == 0 && setCovededCells)
            {
               // EnsureColumnCount(colIndex);

                if (numberColumnFields > 0)
                {
                    gridMainDisplay[rowIndex, colIndex].ModifyStyle(GetAppearance().ColumnTotalCell, StyleModifyType.Override);   
               
                    DisplayColumnSummaryItems(rowIndex, colIndex, engineColumns.Table.TopLevelGroup, GrandTotalString);
                }
                if (setCovededCells)
                {
                    int w = Math.Max(summaryCount, 1) - 1;
                    if (!(rowIndex == bottomRow && w == 0))
                        gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, bottomRow, colIndex + w));
                }
                if(summaryCount == 1)
                {
                    if (numberRowFields > 1)
                    {
                        gridMainDisplay[rowIndex - 1, leftColBase - 2].ModifyStyle(GetAppearance().CalculationNameCell, StyleModifyType.Override);   
             
                        gridMainDisplay[rowIndex - 1, leftColBase - 2].Text = ValuesComputationInfos[0].Description;
                      
                    }
                    else
                    {

                        gridMainDisplay[rowIndex - 1, leftColBase - 1].ModifyStyle(GetAppearance().CalculationNameCell, StyleModifyType.Override);   
             
                        //if (numberRowFields == 0)
                        //{
                        //    gridMainDisplay[rowIndex - 1, leftColBase - 1].Text = ValuesComputationInfos[0].Description;
                        //}
                        //else
                        //{
                            gridMainDisplay[rowIndex - 1, leftColBase - 1].Text = ValuesComputationInfos[0].Description;
                        //}

                    }
                        
                }
                else if (summaryCount > 1)
                {
                    gridMainDisplay[rowIndex, leftColBase - 1].Text = "";
                
                    if (numberRowFields == 0)
                    {
                        if (setCovededCells)
                        {
                            if (!(rowIndex - 1 == pivotSummaryRowBase + 1 && pivotLeftCol != leftColBase - 1))
                                gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, pivotLeftCol, pivotSummaryRowBase + 1, leftColBase - 1));
                        }

                        gridMainDisplay[pivotSummaryRowBase + 2, leftColBase - 1].ModifyStyle(GetAppearance().CalculationNameCell, StyleModifyType.Override);
                        gridMainDisplay[pivotSummaryRowBase + 2, leftColBase - 1].Text = TotalString;


                        int col = rightCol + 1;
                        while (col + summaryCount - 1 <= pivotRightCol)
                        {
                            for (int k = 0; k < summaryCount; ++k)
                            {
                                gridMainDisplay[startGroupRows, col].ModifyStyle(GetAppearance().CalculationNameCell, StyleModifyType.Override);
                                gridMainDisplay[startGroupRows, col].Text = ValuesComputationInfos[k].Description;
                                col++;
                            }
                        }
                    }
                    else
                    {
                        if (setCovededCells)
                        {
                            if (!(rowIndex - 1 == pivotSummaryRowBase + 1 && pivotLeftCol != leftColBase - 1))
                                gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, pivotLeftCol, rowIndex + numberColumnFields - 1, leftColBase - 1));
                        }

                    }
                    
                }

                if (setCovededCells)
                {
                    //int h = Math.Max(0, numberColumnFields - 1);
                    int h = (numberColumnFields - 1) + ((numberRowFields > 0) ? 1 : 0) + (numberValueFields > 1 ? 1 : 0); 
                    int w = Math.Max(0, numberRowFields - 1);
                    if (h > 0 || w > 0)
                    {
                        GridRangeInfo range = gridMainDisplay.CoveredRanges.FindRange(pivotTopRow, pivotLeftCol);
                        if (!range.IsEmpty)
                            gridMainDisplay.CoveredRanges.Remove(range);
                        range = GridRangeInfo.Cells(pivotTopRow, pivotLeftCol, pivotTopRow + h, pivotLeftCol + w);
                        gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(pivotTopRow, pivotLeftCol, pivotTopRow + h, pivotLeftCol + w));
                        //      gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, leftColBase - 1, bottomRow, leftColBase - 1 + numberRowFields - 1));
                    }
                }

                gridMainDisplay[pivotTopRow, pivotLeftCol].ModifyStyle(GetAppearance().TopLeftCell, StyleModifyType.Override);
                gridMainDisplay.RowHeights[pivotTopRow] = 0;
            }
            return colIndex;
                
           
        }

        private void EnsureColumnCount(int colIndex)
        {
            if (colIndex + summaryCount > gridMainDisplay.ColCount)
            {
                gridMainDisplay.ColCount = colIndex + summaryCount;
            }
        }

        private void DisplayRowSummaryItems(int rowIndex, int colIndex, Group g, string s)
        {
            if (summaryCount > 0)
            {
                EnsureRowCount(rowIndex);

                if (s.EndsWith(TotalString))
                {
                    gridMainDisplay[rowIndex, colIndex].ModifyStyle(GetAppearance().RowTotalCell, StyleModifyType.Override);
                }
                else
                {
                    gridMainDisplay[rowIndex, colIndex].ModifyStyle(GetAppearance().RowCell, StyleModifyType.Override);
                   
                }
                
                gridMainDisplay[rowIndex, colIndex].Text = s;
                for (int k = 0; k < summaryCount; ++k)
                {
                    string temp = gridValues[2 + k, 0].Text;
                    ISummary[] summaries = g.GetSummaries(engineColumns.Table);
                    ISummary summary = summaries[k];
                    PivotComputationInfo info = ValuesComputationInfos.Find(gridValues[2 + k, 0].Text);
                    string fmt = "{0:" + info.Format + "}";
                    if (info != null)
                    {
                        if (numberRowFields > 0 && numberColumnFields > 0)
                        {
                            object o =GetAppearance().ValueCell;
                            gridMainDisplay[rowIndex, pivotSummaryColBase + k].ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override);
                    
                            gridMainDisplay[rowIndex, pivotSummaryColBase + k].Text = string.Format(fmt, info.Pd.GetValue(summary)); //info.Pd.GetValue(summary).ToString(info.Format); //** + 1
                        }
                        else
                        {
                            gridMainDisplay[rowIndex, pivotSummaryColBase + k + 1].ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override);
                            //  gridMainDisplay[rowIndex, pivotSummaryColBase + k + 1].Text = "h" + string.Format(fmt, info.Pd.GetValue(summary)); //info.Pd.GetValue(summary).ToString(info.Format); //** + 1
                            gridMainDisplay[rowIndex, pivotSummaryColBase + k + 1].Text = string.Format(fmt, info.Pd.GetValue(summary)); //info.Pd.GetValue(summary).ToString(info.Format); //** + 1
                        }
                    }
                }
            }
            else
            {
                EnsureRowCount(rowIndex);
                if (s.EndsWith(TotalString))
                {
                    gridMainDisplay[rowIndex, colIndex].ModifyStyle(GetAppearance().RowTotalCell, StyleModifyType.Override);
                }
                else
                {
                    //gridMainDisplay[rowIndex, colIndex].ModifyStyle(GetAppearance().CalculationNameCell, StyleModifyType.Override);
                    gridMainDisplay[rowIndex, colIndex].ModifyStyle(GetAppearance().RowCell, StyleModifyType.Override);
                }
                  
                gridMainDisplay[rowIndex, colIndex].Text = s;
            }
        }
        private void DisplayColumnSummaryItems(int rowIndex, int colIndex, Group g, string s)
        {
            if (summaryCount > 0)
            {
                for (int k = 0; k < summaryCount; ++k)
                {
                    if (s.EndsWith(TotalString))
                    {
                        gridMainDisplay[rowIndex, colIndex + k].ModifyStyle(GetAppearance().ColumnTotalCell, StyleModifyType.Override);
                    }
                    else
                    {
                        gridMainDisplay[rowIndex, colIndex + k].ModifyStyle(GetAppearance().ColumnCell, StyleModifyType.Override);
                    }
                    
                    gridMainDisplay[rowIndex, colIndex + k].Text = s;

                    ISummary[] summaries = g.GetSummaries(engineColumns.Table);
                    ISummary summary = summaries[k];
                    PivotComputationInfo info = ValuesComputationInfos.Find(gridValues[2 + k, 0].Text);
                    string fmt = "{0:" + info.Format + "}";
                    if (info != null)
                    {
                        if (summaryCount > 1)
                        {
                            if (numberColumnFields > 0 && numberRowFields > 0)
                            {
                                gridMainDisplay[pivotSummaryRowBase + 1, colIndex + k].ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override);
                                gridMainDisplay[pivotSummaryRowBase + 1, colIndex + k].Text = string.Format(fmt, info.Pd.GetValue(summary));
                            }
                            else
                            {
                                gridMainDisplay[pivotSummaryRowBase + 2, colIndex + k].ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override);
                                gridMainDisplay[pivotSummaryRowBase + 2, colIndex + k].Text = string.Format(fmt, info.Pd.GetValue(summary));
                            }
                            //if (summaryCount == 1)
                            //{
                            //    gridMainDisplay[pivotSummaryRowBase + 1, colIndex + k].ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override);
                            //    gridMainDisplay[pivotSummaryRowBase + 1, colIndex + k].Text = info.Description;
                         
                            //}
                        }
                        else
                        {
                            if (numberValueFields == 0 || numberRowFields == 0) //**
                            {
                                gridMainDisplay[pivotSummaryRowBase + 1, colIndex + k].ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override);
                                gridMainDisplay[pivotSummaryRowBase + 1, colIndex + k].Text = string.Format(fmt, info.Pd.GetValue(summary)); //info.Pd.GetValue(summary).ToString(info.Format);
                            }
                            else
                            {
                                gridMainDisplay[pivotSummaryRowBase, colIndex + k].ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override);
                                gridMainDisplay[pivotSummaryRowBase, colIndex + k].Text = string.Format(fmt, info.Pd.GetValue(summary)); //info.Pd.GetValue(summary).ToString(info.Format); ;
                            }
                        }
                    }
                }
            }
            else
            {
                if(s.EndsWith(TotalString))
                {
                    gridMainDisplay[rowIndex, colIndex].ModifyStyle(GetAppearance().ColumnTotalCell, StyleModifyType.Override);
                }
                else
                {
                    gridMainDisplay[rowIndex, colIndex].ModifyStyle(GetAppearance().ColumnCell, StyleModifyType.Override);
                }
                gridMainDisplay[rowIndex, colIndex].Text = s;
            }
        }


        private int GetCount(Group parentGroup, int count, bool isRow)
        {
            foreach (Group g in parentGroup.Groups)
            {
                if (g.Groups != null && g.Groups.Count > 0)
                {
                    count = GetCount(g, count, isRow);
                    count = count + (isRow ? 1 : Math.Max(1, gridValues.RowCount - 2));
                }
                else
                {
                    count = count + (isRow ? 1 : Math.Max(1, summaryCount));
                }
           }
           return count;
       }


        private int pivotTopRow = 1;
        private int pivotLeftCol = 1;
        private int pivotBottomRow = 1;
        private int pivotRightCol = 1;

        private int pivotSummaryRowBase = 1;
        private int pivotSummaryColBase = 1;

        int numberColumnFields = 0;
        int numberRowFields = 0;
        int numberValueFields = 0;
        int numberFiltersFields = 0;


        private int leftColBase = 2;

     


        int startGroupRows;
        int numberRows;

        
        private void PopulateDisplayGrid()
        {
            //Set up all the counts

            //number of items
            numberColumnFields = gridColumns.RowCount - 2;
            numberRowFields = gridRows.RowCount - 2;
            numberValueFields = gridValues.RowCount - 2;
            numberFiltersFields = gridFilter.RowCount - 1;

            this.summaryCount = numberValueFields;

            //gets the number of interior rows/cols
            int numberColumns = 0;
            numberColumns = (numberRowFields == 0 ? Math.Max(1, numberValueFields) : 1) + GetCount(engineColumns.Table.TopLevelGroup, numberColumns, false);
            int tempNumberRows = 0;
            tempNumberRows = numberColumnFields + (numberColumnFields == 0 ? 1 : 0 + ((numberValueFields <= 2) ? numberValueFields : 2))
                + GetCount(engineRows.Table.TopLevelGroup, tempNumberRows, true);

            numberRows = tempNumberRows;
         //   this.Parent.Text = string.Format("TL({0},{1})  BR({2},{3})   IN{4}", pivotTopRow, pivotLeftCol, pivotBottomRow, pivotRightCol, numberRows);

            //layout the grid real estate
            pivotTopRow = 1;
            pivotLeftCol = 1;
            pivotRightCol = pivotLeftCol + (numberRowFields == 0 ? 0 : numberRowFields - 2 + numberValueFields) + numberColumns;
         
           pivotBottomRow = pivotTopRow + numberRows;

           if (numberRowFields > 0 && numberColumnFields > 0)
           {
               pivotBottomRow += 1;
               pivotRightCol += 1;
           }

           pivotSummaryRowBase = pivotBottomRow - Math.Min(numberValueFields, 2);
           pivotSummaryColBase = pivotRightCol - numberValueFields;

         //   this.Parent.Text = string.Format("RC({4},{5})    TL({0},{1})  BR({2},{3})", pivotTopRow, pivotLeftCol, pivotBottomRow, pivotRightCol, numberRows, numberColumns);

            leftColBase = pivotLeftCol + (numberRowFields > 0 ? numberRowFields - 1 : 0)+ 1;
            startGroupRows = numberColumnFields + 1 + 1;
           
            if (numberColumnFields == 0 || 
               (numberRowFields > 0 && numberValueFields > 1))
                startGroupRows++; //**

            collapsedNodes.Clear();
            gridMainDisplay.CoveredRanges.Clear();
            gridMainDisplay.RowCount = 0;//clear the grid
          
            startGroupColumns = (numberColumnFields > 0) ? 2 : 1;
      
            gridMainDisplay.RowCount = pivotBottomRow;
            gridMainDisplay.ColCount = pivotRightCol;

            int colIndex = 0;
            int rowIndex = 0;

            //populate the rows
            if (numberRowFields > 0)
            {
                rowIndex = 2;
                colIndex = 1;
                rowIndex = AddGroupRowsToGrid(startGroupRows, engineRows.Table.TopLevelGroup, colIndex);
            }
           
            //populate the columns
            gridMainDisplay.RowCount += 1;
            colIndex = leftColBase;
            colIndex = AddGroupColumnsToGrid(startGroupColumns, engineColumns.Table.TopLevelGroup, colIndex);

           
            //populate the values...
            SummaryCache.Clear();
                
            if (numberColumnFields > 0 && numberRowFields > 0 && numberValueFields > 0)
            {
               colIndex = leftColBase;
               numberRows = pivotBottomRow - pivotTopRow - numberColumnFields - (numberValueFields > 1 ? 3 : 2);// tempNumberRows - numberColumns + numberValueFields;
         //      this.Parent.Text = string.Format("TL({0},{1})  BR({2},{3})   in{4}", pivotTopRow, pivotLeftCol, pivotBottomRow, pivotRightCol, numberRows);
               DisplayMiddle((Group)engineValues.Table.TopLevelGroup, colIndex);
            }

            SetFreezeState();
            gridMainDisplay.Refresh();

        }

        #region Summary support

        Hashtable summaryCache = null;

        internal Hashtable SummaryCache
        {
            get 
            {
                if (summaryCache == null)
                    summaryCache = new Hashtable();
                return summaryCache; 
            }
            //set { summaryCache = value; }
        }

        #endregion

        //displays the values in the middle under the columnGroup at colIndex
        private int DisplayMiddle(Group columnGroup, int colIndex)
        {
            int rowIndex = startGroupRows;
            Group rowGroup = engineRows.Table.TopLevelGroup;

            SummaryPair[,] sums = new SummaryPair[numberRows, summaryCount];
            for (int i = 0; i < numberRows; ++i)
            {
                for (int j = 0; j < summaryCount; ++j)
                {
                    PivotComputationInfo info = ValuesComputationInfos.Find(gridValues[2 + j, 0].Text);
                    sums[i, j] = new SummaryPair( PivotComputationInfoList.CreateSummary(info.CalculationName), info.Pd);
                }
            }
            SummaryCache.Add(columnGroup, sums);

            if (columnGroup.Groups != null && columnGroup.Groups.Count > 0)
            {
                foreach (Group g in columnGroup.Groups)
                {
                    if (g.GroupLevel < numberColumnFields)
                    {
                        colIndex = DisplayMiddle(g, colIndex);
                    }
                }
                DisplayMiddleDown(columnGroup, colIndex, (Group)rowGroup, rowIndex);

                if (columnGroup.GroupLevel < numberColumnFields - 1//numberValueFields 
                    && columnGroup.GroupLevel > -1
                    && colIndex < gridMainDisplay.ColCount - 1)
                {
                    SummaryPair[,] sums1 = SummaryCache[columnGroup.ParentGroup] as SummaryPair[,];

                    for (int i = 0; i < numberRows; ++i)
                    {
                        for (int j = 0; j < summaryCount; ++j)
                        {
                            PivotComputationInfo info = ValuesComputationInfos[j];
                            string fmt = "{0:" + ValuesComputationInfos[j].Format + "}";
                            object val = sums[i, j].Pd.GetValue(sums[i, j].Summary);
                            if (val != null && !val.Equals(0))
                            {
                                //gridMainDisplay[startGroupRows + i, colIndex + j].Text = "g" + string.Format(fmt, val);
                                gridMainDisplay[startGroupRows + i, colIndex + j].ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override);
                           
                                gridMainDisplay[startGroupRows + i, colIndex + j].Text = string.Format(fmt, val);
                                sums1[i, j].Summary = sums1[i, j].Summary.Combine(sums[i, j].Summary);
                            }
                        }
                    }
                }
            }
            colIndex += summaryCount;
            return colIndex;
        }


        //recursively display rows in column
        private int DisplayMiddleDown(Group columnGroup, int colIndex, Group rowGroup, int rowIndex)
        {
            foreach (Group g1 in rowGroup.Groups)
            {
                rowIndex = DisplayMiddleDown(columnGroup, colIndex, g1, rowIndex);
            }
            if (rowGroup.Category != null)
            {
                Group gr = rowGroup;
                ArrayList a = new ArrayList();
                while (gr.Category != null)
                {
                    a.Add(gr.Category);
                    gr = gr.ParentGroup;
                }

                //find the proper group in the Columns fields 
                //(need to walk back up the groups for the rows that were added to engineValues)
                Group gc = columnGroup;

                while (gc.GroupLevel > numberColumnFields && gc.ParentGroup != null)
                {
                    gc = gc.ParentGroup;
                }

                //now need to move down the groups to find the right calculation
                //it may not be here in which case the value is left empty.
               ////////////////////////////////// int found = -1;
               ////////////////////////////////// for (int i = a.Count - 1; i >= 0; i--)
               ////////////////////////////////// {
               //////////////////////////////////     foreach (Group g1 in gc.Groups)
               //////////////////////////////////     {
               //////////////////////////////////         if (g1.Category.Equals(a[i]))//added changed
               //////////////////////////////////         {
               //////////////////////////////////             gc = g1;
               //////////////////////////////////             found = 0;
               //////////////////////////////////             break;
               //////////////////////////////////         }
               //////////////////////////////////     }
               //////////////////////////////////         ////found = gc.Groups.FindGroup(a[i]);
               //////////////////////////////////         ////if (found > -1)
               //////////////////////////////////         ////    gc = gc.Groups[found];
               //////////////////////////////////         ////else
               //////////////////////////////////         ////    break;
                    
               //////////////////////////////////}
                int found = 0;
                for (int i = a.Count - 1; i >= 0 && found == 0; i--)
                {
                    found = -1;
                    foreach (Group g1 in gc.Groups)
                    {
                        if (g1.Category.Equals(a[i]))//added changed
                        {
                            gc = g1;
                            found = 0;
                            break;
                        }
                    }
                        ////found = gc.Groups.FindGroup(a[i]);
                        ////if (found > -1)
                        ////    gc = gc.Groups[found];
                        ////else
                        ////    break;
                    
               }
                //if we found it, then add the results to the accumulated results and display the values
                if (found > -1)
                {
                    if (colIndex + summaryCount <= gridMainDisplay.ColCount && columnGroup.ParentGroup  != null)
                    {
                        //accumulate the calculation in the ParentGroup and display the values in the grid
                        ISummary[] summaries = gc.GetSummaries(engineValues.Table);
                        SummaryPair[,] sums1 = SummaryCache[columnGroup.ParentGroup] as SummaryPair[,];
                        for (int k = 0; k < summaryCount; ++k)
                        {
                            ISummary summary = summaries[k];
                            string fmt = "{0:" + ValuesComputationInfos[k].Format + "}";
                            PivotComputationInfo info = ValuesComputationInfos[k];
                            sums1[rowIndex - startGroupRows, k].Summary = sums1[rowIndex - startGroupRows, k].Summary.Combine(summary);
                            //gridMainDisplay[rowIndex, colIndex + k].Text = "c" + string.Format(fmt, sums1[rowIndex - startGroupRows, k].Pd.GetValue(summary)); 
                            gridMainDisplay[rowIndex, colIndex + k].ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override);
                                
                            gridMainDisplay[rowIndex, colIndex + k].Text = string.Format(fmt, sums1[rowIndex - startGroupRows, k].Pd.GetValue(summary)); 
                        }
                    }
                }
            }
            rowIndex++;
            return rowIndex;
        }

     
        private void SetCheck(int rowIndex, bool value)
        {
            if (rowIndex < 2)
                rowIndex = 2;
            gridFields[rowIndex, 0].Text = value ? "1" : "0";
        }

        private void SetCheck(string fieldName, bool value)
        {
            int check = 0;
            for (int i = 2; i < gridFields.RowCount; ++i)
            {
                if (gridFields[i, 0].Description == fieldName)
                {
                    for (int col = 2; col < gridRows.RowCount; ++col)
                        if (gridRows[col].Equals(fieldName))
                            check = 1;
                    for (int col = 2; col < gridColumns.RowCount; ++col)
                        if (gridColumns[col].Equals(fieldName))
                            check = 1;
                    for (int col = 2; col < gridValues.RowCount; ++col)
                        if (gridValues[col].Equals(fieldName))
                            check = 1;
                    for (int col = 2; col < gridFilter.RowCount; ++col)
                        if (gridFilter[col].Equals(fieldName))
                            check = 1;
                    gridFields[i, 0].Text = check.ToString();
                    break;
                }
            }
        }

        private GridList LocateGrid(Point pt)
        {

            if(this.panelColumns.Bounds.Contains(this.panelColumns.Parent.PointToClient(pt)))
                return this.gridColumns;
            if (this.panelRows.Bounds.Contains(this.panelRows.Parent.PointToClient(pt)))
                return this.gridRows;
            if (this.panelGrid.Bounds.Contains(this.panelGrid.Parent.PointToClient(pt)))
                return this.gridValues;
            if (this.panelFilter.Bounds.Contains(this.panelFilter.Parent.PointToClient(pt)))
                return this.gridFilter;

            if (this.gridColumns.Bounds.Contains(gridColumns.Parent.PointToClient(pt)))
                return this.gridColumns;
            if (this.gridFields.Bounds.Contains(gridFields.Parent.PointToClient(pt)))
                return this.gridFields;
            if (this.gridFilter.Bounds.Contains(gridFilter.Parent.PointToClient(pt)))
                return this.gridFilter;
            if (this.gridRows.Bounds.Contains(gridRows.Parent.PointToClient(pt)))
                return this.gridRows;
            if (this.gridValues.Bounds.Contains(gridValues.Parent.PointToClient(pt)))
                return this.gridValues;
            return null;
        }

        

        #endregion

        #region grid checkbox support

        void gridFields_CheckBoxClick(object sender, GridCellClickEventArgs e)
        {
            int rowIndex = e.RowIndex < 2 ? 2 : e.RowIndex;
            if (gridFields[rowIndex, 0].Text == "0")
            {
                //this.gridRows.RowCount++;
                //this.gridRows[this.gridRows.RowCount, 0].Text = gridFields[e.RowIndex, 0].Description;
                this.gridRows.Rows.InsertRange(this.gridRows.RowCount, 1);
                this.gridRows[this.gridRows.RowCount - 1, 0].Text = gridFields[rowIndex, 0].Description;
                this.gridRows.Refresh();
                PerformLayout(gridRows, null);
            }
            else
            {
                int location;
                for (int i = 0; i < 4; i++)
                {
                    GridList grid = FindField(gridFields[rowIndex, 0].Description, out location) as GridList;
                    if (grid != null && location != -1)
                    {
                        grid.Rows.RemoveRange(location, location);
                        PerformLayout(grid, null);
                    }
                }
            }
        }

        private GridControl FindField(string fieldName, out int location)
        {
            location = -1;
            GridControl grid = FindFieldInGrid(fieldName, out location, gridFilter);
            if(grid == null)
                grid = FindFieldInGrid(fieldName, out location, gridColumns);
            if (grid == null)
                grid = FindFieldInGrid(fieldName, out location, gridValues);
            if (grid == null)
                grid = FindFieldInGrid(fieldName, out location, gridRows);

            return grid;
        }

        private GridControl FindFieldInGrid(string fieldName, out int location, GridList g)
        {
            GridList grid = null;
            location = -1;
            for (int row = 1 + (g.HasPaddedRow ? 1 : 0); row <= g.RowCount; ++row)
            {
                if (g[row, 0].Text == fieldName)
                {
                    location = row;
                    grid = g;
                    break;
                }
            }
            return grid;
        }
        #endregion

        #endregion

        #region Visual Style Support
        void appearance_ThemesEnabledChanged(object sender, EventArgs e)
        {
            this.gridMainColumns.ThemesEnabled = appearance.ThemesEnabled;
            this.gridMainFilters.ThemesEnabled = appearance.ThemesEnabled;
            this.gridMainRows.ThemesEnabled = appearance.ThemesEnabled;
        }

        void appearance_VisualStyleChanged(object sender, EventArgs e)
        {
            this.gridMainColumns.GridVisualStyles = appearance.VisualStyle;
            this.gridMainFilters.GridVisualStyles = appearance.VisualStyle;
            this.gridMainRows.GridVisualStyles = appearance.VisualStyle;
            this.gridColumns.GridVisualStyles = appearance.VisualStyle;
            this.gridRows.GridVisualStyles = appearance.VisualStyle;
            this.gridFilter.GridVisualStyles = appearance.VisualStyle;
            this.gridValues.GridVisualStyles = appearance.VisualStyle;
            this.gridFields.GridVisualStyles = appearance.VisualStyle;

            Color top, back, left;
            if (this.gridMainColumns.GridVisualStyles != GridVisualStyles.Metro && this.gridMainColumns.GridVisualStylesDrawing.GetGroupDropAreaColors(out back, out  top, out left))
            {
                this.gridMainColumns.Properties.BackgroundColor = back;
                this.gridMainFilters.Properties.BackgroundColor = back;
                this.gridMainRows.Properties.BackgroundColor = back;
                this.labelFilter.BackColor = back;
                this.labelColumns.BackColor = back;
                this.labelRows.BackColor = back;
                this.BackColor = back; //set the backcolor of UC so it will be inherited through all panels

                labelPivotTableFieldList.BackColor = left;
                this.labelDragFields.BackColor = left;
                this.splitter1.BackColor = left;
                this.splitter2.BackColor = left;
                this.MainDisplayGrid.BorderStyle = BorderStyle.None;
                this.gridFields.BorderStyle = BorderStyle.None;
                this.gridColumns.BorderStyle = BorderStyle.None;
                this.gridRows.BorderStyle = BorderStyle.None;
                this.gridValues.BorderStyle = BorderStyle.None;
                this.gridFilter.BorderStyle = BorderStyle.None;
            }
            else
            {
                this.gridMainColumns.Properties.BackgroundColor = Color.White;
                this.gridMainFilters.Properties.BackgroundColor = Color.White;
                this.gridMainRows.Properties.BackgroundColor = Color.White;
                this.labelFilter.BackColor = Color.White;
                this.labelColumns.BackColor = Color.White;
                this.labelRows.BackColor = Color.White;
                this.BackColor = Color.White; //set the backcolor of UC so it will be inherited through all panels

                labelPivotTableFieldList.BackColor = Color.FromArgb(35, 130, 195);
                this.labelDragFields.BackColor = Color.FromArgb(35, 130, 195);
                this.splitter1.BackColor = Color.White;
                this.splitter2.BackColor = Color.White;
                this.MainDisplayGrid.BorderStyle = BorderStyle.FixedSingle;
                this.gridFields.BorderStyle = BorderStyle.FixedSingle;
                this.gridColumns.BorderStyle = BorderStyle.FixedSingle;
                this.gridRows.BorderStyle = BorderStyle.FixedSingle;
                this.gridValues.BorderStyle = BorderStyle.FixedSingle;
                this.gridFilter.BorderStyle = BorderStyle.FixedSingle;
            }

            switch (this.gridMainColumns.GridVisualStyles)
            {
                case GridVisualStyles.Office2007Blue:
                    MainDisplayGrid.Model.Options.Office2007ScrollBars = true;
                    MainDisplayGrid.Model.Options.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                    gridMainColumns.Office2007ScrollBars = true;
                    gridMainColumns.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                    gridMainFilters.Office2007ScrollBars = true;
                    gridMainFilters.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                    gridMainRows.Office2007ScrollBars = true;
                    gridMainRows.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                    gridRows.Office2007ScrollBars = true;
                    gridRows.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                    gridColumns.Office2007ScrollBars = true;
                    gridColumns.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                    gridFilter.Office2007ScrollBars = true;
                    gridFilter.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                    gridValues.Office2007ScrollBars = true;
                    gridValues.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                    gridFields.Office2007ScrollBars = true;
                    gridFields.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                    break;
                case GridVisualStyles.Office2007Black:
                    MainDisplayGrid.Model.Options.Office2007ScrollBars = true;
                    MainDisplayGrid.Model.Options.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                    gridMainColumns.Office2007ScrollBars = true;
                    gridMainColumns.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                    gridMainFilters.Office2007ScrollBars = true;
                    gridMainFilters.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                    gridMainRows.Office2007ScrollBars = true;
                    gridMainRows.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                    gridRows.Office2007ScrollBars = true;
                    gridRows.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                    gridColumns.Office2007ScrollBars = true;
                    gridColumns.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                    gridFilter.Office2007ScrollBars = true;
                    gridFilter.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                    gridValues.Office2007ScrollBars = true;
                    gridValues.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                    gridFields.Office2007ScrollBars = true;
                    gridFields.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                    break;
                case GridVisualStyles.Office2007Silver:
                    MainDisplayGrid.Model.Options.Office2007ScrollBars = true;
                    MainDisplayGrid.Model.Options.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                    gridMainColumns.Office2007ScrollBars = true;
                    gridMainColumns.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                    gridMainFilters.Office2007ScrollBars = true;
                    gridMainFilters.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                    gridMainRows.Office2007ScrollBars = true;
                    gridMainRows.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                    gridRows.Office2007ScrollBars = true;
                    gridRows.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                    gridColumns.Office2007ScrollBars = true;
                    gridColumns.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                    gridFilter.Office2007ScrollBars = true;
                    gridFilter.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                    gridValues.Office2007ScrollBars = true;
                    gridValues.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                    gridFields.Office2007ScrollBars = true;
                    gridFields.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                    break;
                case GridVisualStyles.Metro:
                    MainDisplayGrid.GridOfficeScrollBars = OfficeScrollBars.Metro;
                    MainDisplayGrid.Model.Options.GridOfficeScrollBars = OfficeScrollBars.Metro;
                    gridMainColumns.GridOfficeScrollBars = OfficeScrollBars.Metro;
                    gridMainRows.GridOfficeScrollBars = OfficeScrollBars.Metro;
                    gridMainFilters.GridOfficeScrollBars = OfficeScrollBars.Metro;
                    gridColumns.GridOfficeScrollBars = OfficeScrollBars.Metro;
                    gridRows.GridOfficeScrollBars = OfficeScrollBars.Metro;
                    gridFilter.GridOfficeScrollBars = OfficeScrollBars.Metro;
                    gridFields.GridOfficeScrollBars = OfficeScrollBars.Metro;
                    this.Refresh();
                    break;
                case GridVisualStyles.Office2003:
                case GridVisualStyles.SystemTheme:
                    MainDisplayGrid.Model.Options.Office2007ScrollBars = false;
                    gridMainColumns.Office2007ScrollBars = false;
                    gridMainRows.Office2007ScrollBars = false;
                    gridMainFilters.Office2007ScrollBars = false;
                    gridColumns.Office2007ScrollBars = false;
                    gridRows.Office2007ScrollBars = false;
                    gridFilter.Office2007ScrollBars = false;
                    gridFields.Office2007ScrollBars = false;
                    break;
                default:
                    break;
            }
        }
    #endregion
    }

    #region SummaryPair class
    /// <summary>
    /// SummaryPair encapsulates an ISummary object and PropertyDescriptor. The ISummary defines the type of calculation
    /// that is being done in a particular column and the PropertyDescriptor determines the values being used for the 
    /// Calculation. This class is used internally by the PivotGridControl.
    /// </summary>
    public class SummaryPair
    {
        /// <summary>
        /// A Constructor.
        /// </summary>
        /// <param name="summary">The ISummary object that defines the type of calculation being done in a column.</param>
        /// <param name="pd">The PropertyDescriptor that determines the values used in the calculations for a column.</param>
        public SummaryPair(ISummary summary, PropertyDescriptor pd)
        {
            this.pd = pd;
            this.summary = summary;
        }


        ISummary summary;

        /// <summary>
        /// Gets or sets the ISummary object that defines the type of calculation. 
        /// </summary>
        public ISummary Summary
        {
            get { return summary; }
            set { summary = value; }
        }

        PropertyDescriptor pd;

        /// <summary>
        /// Gets or sets the PropertyDescriptor that determines the values used in the calculations.
        /// </summary>
        public PropertyDescriptor Pd
        {
            get { return pd; }
            set { pd = value; }
        }
    }
    #endregion

    #region derived GridControl used in Pivot pane grids
    /// <summary>
    /// A special GridControl used for the drag and drop targets that appear in the collapsible 
    /// design panel of the PivotGridControl. 
    /// </summary>
    /// <remarks>
    /// This class is used internally by the PivotGridControl and is essentailly a single column 
    /// GridControl with special properties set.
    /// </remarks>
    public class GridList : GridControl
    {
        /// <summary>
        /// The default contructor.
        /// </summary>
        public GridList()
            : base()
        {
            this.RowCount = 1;
            this.ColCount = 1;
            this.RowHeights[0] = 0;
            this.ColWidths[0] = 0;
            this.DefaultGridBorderStyle = GridBorderStyle.None;
            this.Properties.BackgroundColor = this.TableStyle.BackColor;
            this.AllowDragSelectedRows = true;
            this.ResizeRowsBehavior = GridResizeCellsBehavior.None;
            this.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.HideAlways;
            this.selectionColor = this.AlphaBlendSelectionColor;
            this.AlphaBlendSelectionColor = Color.FromArgb(0, 0, 0, 0);
            this.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.Office2007ScrollBars = true;
            this.ThemesEnabled = true;
            this.TableStyle.Themed = true;

            this.ControllerOptions = /*GridControllerOptions.DragSelectRowOrColumn | */GridControllerOptions.ClickCells;

            MouseControllerDispatcher.Add(new DragFieldMouseController(this));


        }

        internal bool isFieldsGrid = false;

        /// <summary>
        /// Gets either the GridStyleInfo.Description property or the GridStyleInfo.Text property for a particular
        /// row depending upon the value of the isFieldsGrid property. 
        /// </summary>
        /// <param name="index">The 1-based row index.</param>
        /// <returns>A string holding either the Description or the Text for the cell in this row.</returns>
        public string this[int index]
        {
            get
            {
                if (!(index > 0 && index < this.Model.RowCount))
                    throw new IndexOutOfRangeException(this.ToString()+" invalid 'row index'");
                else
                {
                    if (isFieldsGrid)
                        return this[index, 0].Description;
                    else
                        return this[index, 0].Text;
                }

            }
        }

        #region properties

        private Color selectionColor;

        /// <summary>
        /// Gets or sets the Selection color.
        /// </summary>
        public Color SelectionColor
        {
            get { return selectionColor; }
            set { selectionColor = value; }
        }

        private bool hasCheckBox = false;

        /// <summary>
        /// Gets or sets whether this grid has a checkbox displayed in it single cell on each row.
        /// </summary>
        public bool HasCheckBox
        {
            get { return hasCheckBox; }
            set { hasCheckBox = value; }
        }

        private bool hasPaddedRow = true;

        /// <summary>
        /// Gets or sets whether there is a hidden padded row at the top of the grid.
        /// </summary>
        public bool HasPaddedRow
        {
            get { return hasPaddedRow; }
            set { hasPaddedRow = value; }
        }

        #endregion

        #region overrides

        /// <summary>
        /// Overriden to handle "Delete" key.
        /// </summary>
        /// <param name="e">The event argument.</param>
        //protected override void OnKeyDown(KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        this.Rows.RemoveRange(this.CurrentCell.RowIndex, this.CurrentCell.RowIndex);
        //    }
        //    base.OnKeyDown(e);
        //}

        /// <summary>
        /// Overriden to handle selections in clicks.
        /// </summary>
        /// <param name="e">The event argument.</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.Selections.Clear();
               
            int row, col;
            if ((e.X > 20 || !HasCheckBox) && this.PointToRowCol(new Point(e.X, e.Y), out row, out col))
            {
                 this.Selections.SelectRange(GridRangeInfo.Row(row), true);
                 this.CurrentCell.MoveTo(row, col);
            }
            base.OnMouseDown(e);
        }

        /// <summary>
        /// Oveeridden to manage selections and display bold checked values.
        /// </summary>
        /// <param name="e">The event argument.</param>
        protected override void OnPrepareViewStyleInfo(GridPrepareViewStyleInfoEventArgs e)
        {
            base.OnPrepareViewStyleInfo(e);
            if (e.ColIndex == 0 && e.RowIndex > 0 && e.Style.CellValue != null
                && e.Style.CellType == "CheckBox" && e.Style.Text == "1")
            {
                e.Style.Font.Bold = true;
                
            }
            if (this.Focused && e.RowIndex == this.CurrentCell.RowIndex)
                e.Style.BackColor = this.SelectionColor;
            ////else
            ////    e.Style.BackColor = this.TableStyle.BackColor;
        }

        /// <summary>
        /// Overriden to control cursor.
        /// </summary>
        /// <param name="m">The message object.</param>
        protected override void OnSetCursor(ref Message m)
        {
            if (Control.MouseButtons != MouseButtons.Left)
                Cursor.Current = Cursors.Default;
            else
                base.OnSetCursor(ref m);
        }

        /// <summary>
        /// Overriden to force a refresh of the cell.
        /// </summary>
        /// <param name="e">The event argument.</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (this.CurrentCell.HasCurrentCell)
                this.RefreshRange(GridRangeInfo.Row(this.CurrentCell.RowIndex));
        }

        #endregion

        /// <summary>
        /// Initiates call to <see cref="OnSelectionDragging"/>.
        /// </summary>
        /// <param name="e">The event arguments.</param>
        public void RaiseFieldDrop(FieldDropEventArgs e)
        {
            OnFieldDrop(e);
        }

        void OnFieldDrop(FieldDropEventArgs e)
        {
            if (FieldDrop != null)
                FieldDrop(this, e);
        }

        /// <summary>
        /// Initiates call to <see cref="OnQueryCanDropField"/>.
        /// </summary>
        /// <param name="e">The event arguments.</param>
        public void RaiseQueryCanDropField(QueryCanDropFieldEventArgs e)
        {
            OnQueryCanDropField(e);
        }

        /// <summary>
        /// Raises the UeryCanDropField event.
        /// </summary>
        /// <param name="e">The event argument.</param>
        protected void OnQueryCanDropField(QueryCanDropFieldEventArgs e)
        {
            if (QueryCanDropField != null)
                QueryCanDropField(this, e);
        }

        /// <summary>
        /// Occurs when drop operation is completed, on mouse up. 
        /// The FieldDropEventArgs' FieldIndex holds the dragged field index and the 
        /// DropAtIndex will hold the row index at which the field will be dropped.
        /// </summary>
        public event FieldDropEventHandler FieldDrop;

        /// <summary>
        /// Occurs when the field is being dragged to determine if they can be droped at the MousePosition.
        /// The QueryCanDropFieldEventArgs DropOnGrid will hold the GridList at the current MousePosition.
        /// And the CanDrop will be true if the field can be droped false otherwise.
        /// </summary>
        public event QueryCanDropFieldEventHandler QueryCanDropField;
    }
    #endregion

    #region PivotContent enum

    /// <summary>
    /// Used to identify the a portion of the Pivot Control Panel.
    /// </summary>
    public enum PivotContent
    {
        Fields,
        Filters,
        Columns,
        Rows,
        Values,
        ColumnsHeader,
        SummaryRow
    }
    #endregion

    #region GridList Events

    /// <summary>
    /// Occurs when drop operation is completed, on mouse up. 
    /// The FieldDropEventArgs' FieldIndex holds the dragged field index and the 
    /// DropAtIndex will hold the row index at which the field will be dropped.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event argument.</param>
    public delegate void FieldDropEventHandler(object sender, FieldDropEventArgs e);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void QueryCanDropFieldEventHandler(object sender, QueryCanDropFieldEventArgs e);
 

    /// <summary>
    /// The event argument for the FieldDrop event.
    /// </summary>
    public sealed class FieldDropEventArgs
    {
        private string field;
        private Point dropPoint;
        private int fieldIndex;
        private int dropAtIndex = -1;
        /// <summary>
        /// Initializes a new object.
        /// </summary>
        public FieldDropEventArgs(string field, int fieldIndex, Point dropPoint, int dropAtIndex)
        {
            this.field = field;
            this.dropPoint = dropPoint;
            this.fieldIndex = fieldIndex;
            this.dropAtIndex = dropAtIndex;
        }

        /// <summary>
        /// The field thats being dragged.
        /// </summary>
        public string Field
        {
            get
            {
                return field;
            }
        }

        /// <summary>
        /// The field index thats being dragged.
        /// </summary>
        public int FieldIndex
        {
            get
            {
                return fieldIndex;
            }
        }

        /// <summary>
        /// The MousePosition on mouse up.
        /// </summary>
        public Point DropPoint
        {
            get
            {
                return dropPoint;
            }
            set
            {
                dropPoint = value;
            }
        }

        /// <summary>
        /// The row index at which the field is to be dropped.
        /// </summary>
        public int DropAtIndex
        {
            get { return dropAtIndex; }
        }

    }

    /// <summary>
    /// The event argument for the QueryCanDropField event.
    /// </summary>
    public sealed class QueryCanDropFieldEventArgs
    {
        private string field;
        private Point pt;
        private bool canDrop = false;
        private GridControlBase _dropOnGrid = null;
        /// <summary>
        /// Initializes a new object.
        /// </summary>
        public QueryCanDropFieldEventArgs(Point pt, string field)
        {
            this.pt = pt;
            this.field = field;
        }

        /// <summary>
        /// Gets the point assoicated with this drop.
        /// </summary>
        public Point MousePoint
        {
            get
            {
                return pt;
            }
        }

        /// <summary>
        /// Get the field associated with this drop.
        /// </summary>
        public string Field
        {
            get { return field; }
        }

        /// <summary>
        /// Gets or sets whether this drop can be done.
        /// </summary>
        public bool CanDrop
        {
            get { return canDrop; }
            set { canDrop = value; }
        }

        /// <summary>
        /// Gets the target GridControl for this drop.
        /// </summary>
        public GridControlBase DropOnGrid
        {
            get { return _dropOnGrid; }
            set { _dropOnGrid = value; }
        }

    }
#endregion
}
