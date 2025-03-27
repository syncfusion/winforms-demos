#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Reflection;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using System.Collections.Generic;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace TreeGridHelper
{
    #region the TreeGridHelper class

    /// <summary>
    /// Summary description for TreeGridHelper.
    /// </summary>
    public class TreeGridHelper
    {


        public TreeGridHelper()
        {

        }

        #region private fields

        private GridGroupingControl grid = null;


        private NodeArray rowIndexer = null;
        private ITreeGridDataSource dataSource;
        private string selfReferenceProperty;
        private string idProperty;
        private string nodeProperty;
        private bool treeNodeEditable = true;

        private const int TREECOLUMN = 1;
        private bool treeLines = true;
        private bool editingEnabled = false;
        private int maxIndent = int.MaxValue;
        private Color[] colorlist;        
        private bool colorCodeSiblings = false;



        Dictionary<int, List<bool>> visibleDescendantExpandStates = null;

        private SelfReferenceDataSourceAccessor accessor;

        private bool showCellBorderInTreeCell = false;

        private ListSortDirection sortDirection = ListSortDirection.Ascending;
        private string sortColumn = "";




        #endregion

        #region Properties


        public void Sort(string sortColumn)
        {
            if (sortColumn.Length == 0)
            {
                this.sortColumn = sortColumn;
                accessor.sortString = sortColumn;
            }
            else if (this.sortColumn == sortColumn)
            {
                accessor.sortString = sortColumn + ((sortDirection == ListSortDirection.Ascending) ? " Desc" : "");

                sortDirection = (sortDirection == ListSortDirection.Ascending) ? ListSortDirection.Descending : ListSortDirection.Ascending;
            }
            else
            {
                sortDirection = ListSortDirection.Ascending;
                accessor.sortString = sortColumn;
                this.sortColumn = sortColumn;

            }


            //      CollapseAll();
            List<int> saveExpands = GetExpandedNodes();
            rowIndexer.Clear();
            PopulateIndexer(0, accessor.GetRootDataView(), 0);
            ResetExpandedNodes(saveExpands);
            this.grid.Refresh();
            // ExpandAll();
        }


        public bool ColorCodeSiblings
        {
            get { return colorCodeSiblings; }
            set { colorCodeSiblings = value; }
        }

        public Color[] ColorCodeList
        {
            get
            {
                if (colorlist == null)
                    return new Color[] { Color.White };
                else
                    return colorlist;
            }
            set { colorlist = value; }
        }

        public bool ShowCellBorderInTreeCell
        {
            get { return showCellBorderInTreeCell; }
            set { showCellBorderInTreeCell = value; }
        }
        protected Dictionary<int, List<bool>> VisibleDescendantExpandStates
        {
            get
            {
                if (visibleDescendantExpandStates == null)
                    visibleDescendantExpandStates = new Dictionary<int, List<bool>>();
                return visibleDescendantExpandStates;
            }
            set { visibleDescendantExpandStates = value; }
        }

        /// <summary>
        /// Gets or sets whether tree lines are displayed
        /// </summary>
        public bool ShowTreeLines
        {
            get
            {
                return treeLines;
            }
            set
            {
                if (treeLines != value)
                {
                    treeLines = value;
                    if (this.grid.TableControl != null && this.grid.TableControl.Visible)
                        this.grid.TableControl.Refresh();
                }
            }
        }

        /// <summary>
        /// Gets or sets whether treenode cell is editable.
        /// </summary>
        public bool TreeNodeCellEditable
        {
            get { return treeNodeEditable; }
            set { treeNodeEditable = true; }
        }

        /// <summary>
        /// Gets or sets whether non treenode cells are allowed to go into edit mode.
        /// </summary>
        public bool EditingEnabled
        {
            get
            {
                return editingEnabled;
            }
            set
            {
                editingEnabled = value;
            }
        }




        /// <summary>
        /// Gets or sets maximum tree levels displayable in the grid. The default is int.MaxValue.
        /// </summary>
        public int MaxIndentLevels
        {
            get { return this.maxIndent; }
            set { this.maxIndent = value; }
        }
        #endregion

        /// <summary>
        /// Adds tree node support to a GridGroupingControl whose datasource is a DataTable with
        /// a self-reference.
        /// </summary>
        /// <param name="grid">The GridGroupingControl.</param>
        /// <param name="dataSource">The DataTable with a column that references to primary key values for the same DataTable. This means there is a field that refers to another DataRow in the same DataTable.</param>
        /// <param name="selfReferenceColumn">The is the name of the column that refers to the primary key value that identifies another DataRow in the DataTabale.</param>
        /// <param name="idColumn">The primary key column for the DataTable.</param>
        /// <param name="nodeColumn">The name of the column that should appear in the +/- expansion cell.</param>
        /// <returns>An accessor object (generally for internal use) that maps rowindexes to tree node objects.</returns>
        public SelfReferenceDataSourceAccessor WireSelfReferenceGrid(GridGroupingControl grid, DataTable dataSource, string selfReferenceColumn, string idColumn, string nodeColumn)
        {

            this.rowIndexer = new NodeArray(dataSource.DefaultView);
            this.grid = grid;
            this.grid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.grid.TopLevelGroupOptions.ShowCaption = false;
            this.selfReferenceProperty = selfReferenceColumn;
            this.idProperty = idColumn;
            this.nodeProperty = nodeColumn;

            this.accessor = new SelfReferenceDataSourceAccessor(dataSource, selfReferenceColumn, idColumn);
            this.grid.DataSource = this.rowIndexer;// accessor.GetRootDataView();
            WireGrid(grid, accessor.GetRootDataView(), accessor);

            //make sure nodeColumn is the first one...
            GridColumnDescriptor gbc = grid.TableDescriptor.Columns[nodeColumn];
            if (gbc == null)
            {
                throw new Exception(string.Format("{0} is missing from the grid.", nodeColumn));
            }
            int loc = grid.TableDescriptor.Columns.IndexOf(gbc);
            if (loc != 0)
            {
                grid.TableDescriptor.Columns.Move(loc, 0);

            }
            foreach (GridColumnDescriptor cd in grid.TableDescriptor.Columns)
            {
                cd.AllowSort = false;
            }
            return accessor;
        }

        private int rowOffSet = 2;
        private int GetPosition(int rowIndex)
        {
            return rowIndex - rowOffSet;
        }

        /// <summary>
        /// Does some low level initializations. Generally, you should use the WireSelfReferenceGrid method which, in turn, will 
        /// call WireGrid.
        /// </summary>
        /// <param name="grid">The GridDataBoundGrid</param>
        /// <param name="parentList">The parentList</param>
        /// <param name="dataSource">The dataSource that serves as an ITreeGridDataSource.</param>
        public void WireGrid(GridGroupingControl grid, IList parentList, ITreeGridDataSource dataSource)
        {
            this.grid = grid;
            this.grid.TableControl.BeginUpdate();

            //used by renderer to access rowindexer 
            this.grid.TableControl.Model.TableStyle.Tag = this;

            this.dataSource = dataSource;

            if (!this.grid.TableControl.Model.CellModels.ContainsKey("GridTreeCell"))
                this.grid.TableControl.Model.CellModels.Add("GridTreeCell", new GridDataBoundTreeCellModel(this.grid.TableControl.Model, this));

            this.grid.TableDescriptor.Columns[nodeProperty].Appearance.AnyRecordFieldCell.CellType = "GridTreeCell";

            WireTreeLineEvents();


            rowIndexer.Clear();
            PopulateIndexer(0, parentList, 0);
            this.grid.TableControl.Model.ResetVolatileData();

            this.grid.TableControl.Model.ColWidths.ResizeToFit(GridRangeInfo.Col(2));

            this.grid.TableControl.EndUpdate();

            this.grid.TableControl.Refresh();

        }

        /// <summary>
        /// Disconnects this TreeHelper from its GridDataBoundGrid.
        /// </summary>
        public void UnwireGrid()
        {
            if (this.grid.TableControl != null)
            {
                this.grid.TableControl.BeginUpdate();
                this.grid.TableControl.Model.TableStyle.Tag = null;
                UnwireTreeLineEvents();

                this.grid.TableControl.Model.ColWidths.ResizeToFit(GridRangeInfo.Col(TREECOLUMN));
                this.grid.TableControl.EndUpdate();
                this.grid.TableControl.Refresh();

                this.grid = null;
            }
        }

        /// <summary>
        /// Gets whether there is a GridDataBoundGrid wired to this TreeHelper.
        /// </summary>
        public bool IsWired
        {
            get { return this.grid.TableControl != null; }
        }

        /// <summary>
        /// Expands all nodes in the wired grid.
        /// </summary>
        public void ExpandAll()
        {
            this.grid.TableControl.Parent.Cursor = Cursors.WaitCursor;
            this.grid.TableControl.BeginUpdate();
            this.CollapseAll(); //speeds things up...
            int rowIndex = rowOffSet;
            while (rowIndex <= this.grid.TableControl.Model.RowCount)
            {
                ExpandNode(rowIndex, false, false);
                rowIndex += 1;
            }
            this.grid.TableControl.Model.ColWidths.ResizeToFit(GridRangeInfo.Col(TREECOLUMN), GridResizeToFitOptions.NoShrinkSize);
            this.grid.TableControl.EndUpdate();
            this.grid.TableControl.Parent.Cursor = Cursors.Default;
            this.grid.TableControl.Refresh();


        }

        /// <summary>
        /// Expands a single node at grid rowIndex.
        /// </summary>
        /// <param name="rowIndex">The row index of the node to be expanded.</param>
        public void ExpandNode(int rowIndex)
        {
            ExpandNode(rowIndex, true);
        }


        /// <summary>
        /// Expands the tree node at grid rowIndex.
        /// </summary>
        /// <param name="rowIndex">The rowIndex of the node to be expanded.</param>
        /// <param name="refresh">Indicates whether grid.Refresh is called after the expansion.</param>
        public void ExpandNode(int rowIndex, bool refresh)
        {
            ExpandNode(rowIndex, refresh, true);
        }


        private void ExpandNode(int rowIndex, bool refresh, bool resizeNodeCell)
        {
            ExpandNode(rowIndex, refresh, resizeNodeCell, false);
        }

        private void ExpandNode(int rowIndex, bool refresh, bool resizeNodeCell, bool expandDescendents)
        {
            Node n = GetNode(rowIndex);

            if (n.Indent > this.MaxIndentLevels)
                return;



            if (n.HasChildren)
            {
                
                if (refresh)
                    this.grid.TableControl.BeginUpdate();
                try
                {
                    int pos = GetPosition(rowIndex);
                    IList list = (n.ChildList == null) ? this.dataSource.GetChildList(n.Position, n.SiblingList, n.ParentNode) : n.ChildList;

                    PopulateIndexer(pos + 1, list, n.Indent + 1, n);
                    n.IsExpanded = true;
                    this.grid.TableControl.Model.ResetVolatileData();
                    if (resizeNodeCell)
                    {
                        this.grid.TableControl.Model.ColWidths.ResizeToFit(GridRangeInfo.Cells(rowIndex, TREECOLUMN, rowIndex + list.Count, TREECOLUMN), GridResizeToFitOptions.NoShrinkSize);
                    }
                    if (expandDescendents)
                    {
                        ExpandDescendants(rowIndex);
                        int id = GetPrimaryId(rowIndex);
                        if (VisibleDescendantExpandStates.ContainsKey(id))
                        {
                            VisibleDescendantExpandStates.Remove(id);
                        }
                    }
                }
                catch { }
                finally
                {
                    if (refresh)
                    {
                        this.grid.TableControl.EndUpdate();
                        this.grid.TableControl.Refresh();
                    }
                }
            }
        }

        private List<bool> QueryVisibleDescendantsExpandStates(int rowIndex)
        {
            List<bool> expandStates = new List<bool>();
            int indent = GetNode(rowIndex).Indent;
            int row = rowIndex + 1;
            bool continueProcessing = true;
            while (continueProcessing && row < this.grid.TableControl.Model.RowCount) //no need to check last row as it is nochild or collapsed
            {
                Node n = GetNode(row);
                if (n.Indent > indent)
                {
                    expandStates.Add(n.HasChildren && n.IsExpanded);
                }
                else
                    continueProcessing = false;
                row++;
            }

            return expandStates;
        }

        private List<bool> GetVisibleDescendantExpandStates(int rowIndex)
        {
            int i = GetPrimaryId(rowIndex);
            if (!VisibleDescendantExpandStates.ContainsKey(i))
            {
                VisibleDescendantExpandStates.Add(i, new List<bool>());
            }
            return VisibleDescendantExpandStates[i];
        }

        private void ExpandDescendants(int rowIndex)
        {
            int row = rowIndex + 1;
            List<bool> expandStates = GetVisibleDescendantExpandStates(rowIndex);
            foreach (bool b in expandStates)
            {
                if (b && row < grid.TableModel.RowCount)
                {
                    ExpandNode(row, false, false, false);
                }
                row++;
            }
        }

        /// <summary>
        /// Collapses all the nodes in the grid.
        /// </summary>
        public void CollapseAll()
        {
            this.grid.TableControl.BeginUpdate();
            try
            {
                int rowIndex = rowOffSet;
                Node n = GetNode(rowIndex);
                IList list = n.SiblingList;
                CollapseNode(rowIndex);
                if (list != null)
                {
                    for (int i = 1; i < list.Count; ++i)
                    {
                        CollapseNode(rowIndex + i);
                    }
                }
            }
            catch { }
            finally
            {
                this.grid.TableControl.EndUpdate();
            }
            VisibleDescendantExpandStates.Clear();
        }



        /// <summary>
        /// Collapses the node at the grid rowIndex.
        /// </summary>
        /// <param name="rowIndex">The rowIndex.</param>
        public void CollapseNode(int rowIndex)
        {
            CollapseNode(rowIndex, false);
        }

        private void CollapseNode(int rowIndex, bool saveExpandStates)
        {
            Node n = GetNode(rowIndex);
            if (n.IsExpanded && n.HasChildren)
            {
                if (saveExpandStates)
                {
                    int id = GetPrimaryId(rowIndex);
                    if (VisibleDescendantExpandStates.ContainsKey(id))
                    {
                        VisibleDescendantExpandStates[id] = QueryVisibleDescendantsExpandStates(rowIndex);
                    }
                    else
                    {
                        VisibleDescendantExpandStates.Add(id, QueryVisibleDescendantsExpandStates(rowIndex));
                    }
                }
                int i = rowIndex + 1;
                int pos = GetPosition(i);
                int rowCount = this.grid.TableControl.Model.RowCount;
                if (i <= rowCount)
                {
                    Node next = GetNode(i);
                    this.grid.TableControl.Model.ResetVolatileData();
                    while (next.Indent > n.Indent && i <= rowCount)
                    {
                        this.rowIndexer.RemoveAt(pos);
                        rowCount--;
                        if (i <= rowCount)
                            next = GetNode(i);
                    }
                }
                n.IsExpanded = false;
                this.grid.TableControl.Refresh();
                this.grid.Table.Reload();
            }

        }

        /// <summary>
        /// Returns the Node object for the given grid rowIndex.
        /// </summary>
        /// <param name="rowIndex">The rowIndex.</param>
        /// <returns>The Node for the given row.</returns>
        public Node GetNode(int rowIndex)
        {
            int pos = GetPosition(rowIndex);
            return this.rowIndexer[pos];
        }

        #region non-public methods methods

        private void PopulateIndexer(int pos, IList data, int indent)
        {
            PopulateIndexer(pos, data, indent, null);
        }

        private void PopulateIndexer(int pos, IList data, int indent, Node parent)
        {
            for (int i = 0; i < data.Count; ++i)
            {
                DataRowView drv = data[i] as DataRowView;
                Node node1 = new Node(drv);
                node1.Position = i;
                node1.SiblingList = data;
                node1.Indent = indent;
                node1.ParentNode = parent;
                node1.HasChildren = this.dataSource.NodeHasChildren(i, data);
                this.rowIndexer.Insert(pos, node1);
                pos += 1;
            }
        }

        private void WireTreeLineEvents()
        {
            this.grid.TableControl.CellButtonClicked += new GridCellButtonClickedEventHandler(treeCellButton_Clicked);
            this.grid.TableControlPrepareViewStyleInfo += new GridTableControlPrepareViewStyleInfoEventHandler(grid_TableControlPrepareViewStyleInfo);
            this.grid.TableControlCurrentCellStartEditing += new GridTableControlCancelEventHandler(grid_TableControlCurrentCellStartEditing);
            this.grid.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(grid_QueryCellStyleInfo);
            this.grid.TableControlCellClick += new GridTableControlCellClickEventHandler(grid_TableControlCellClick);
        }

        void grid_TableControlCellClick(object sender, GridTableControlCellClickEventArgs e)
        {
            GridTableCellStyleInfo style = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex);
            if (style.TableCellIdentity.TableCellType == GridTableCellType.ColumnHeaderCell
                && style.TableCellIdentity.Column != null)
            {
                if (style.TableCellIdentity.Column.Name == sortColumn)
                {
                    Sort(sortColumn);
                }
                else
                {
                    sortDirection = ListSortDirection.Ascending;
                    Sort(style.TableCellIdentity.Column.Name);
                }
                e.Inner.Cancel = true;
            }

        }

        void grid_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {

            if (e.Style.TableCellIdentity.TableCellType == GridTableCellType.ColumnHeaderCell
                && e.Style.TableCellIdentity.Column != null && e.Style.TableCellIdentity.Column.Name == sortColumn)
            {
                e.Style.Tag = sortDirection;
            }
        }



        void grid_TableControlCurrentCellStartEditing(object sender, GridTableControlCancelEventArgs e)
        {
            e.Inner.Cancel = !EditingEnabled;
        }

        void grid_TableControlPrepareViewStyleInfo(object sender, GridTableControlPrepareViewStyleInfoEventArgs e)
        {
            GridTableCellStyleInfo style = e.Inner.Style as GridTableCellStyleInfo;
            if (!showCellBorderInTreeCell)
            {
                if (style.TableCellIdentity.ColIndex == TREECOLUMN)
                    style.Borders.Bottom = GridBorder.Empty;
            }
            if (colorCodeSiblings && style.TableCellIdentity.DisplayElement.GetRecord() != null)
            {
                style.BackColor = GetIndentLevelColor(GetNode(e.Inner.RowIndex).Indent);
            }
        }

        private List<int> GetExpandedNodes()
        {
            List<int> expandedNodes = new List<int>();
            if (rowIndexer.Count > 0)
            {
                for (int row = rowOffSet; row <= grid.TableModel.RowCount; ++row)
                {
                    Node n = rowIndexer[row - rowOffSet];
                    if (n.IsExpanded)
                    {
                        int id = GetPrimaryId(row);
                        int loc = expandedNodes.BinarySearch(id);
                        if (loc < 0)
                            expandedNodes.Insert(-(loc + 1), id);
                    }
                }
            }
            return expandedNodes;
        }

        private void ResetExpandedNodes(List<int> expandedNodes)
        {
            grid.BeginUpdate();
            int row = rowOffSet;
            while (row-1 <= rowIndexer.Count)
            {
                int id = GetPrimaryId(row);
                int loc = expandedNodes.BinarySearch(id);
                if (loc >= 0)
                    ExpandNode(row);
                row++;
            }
            grid.EndUpdate(true);
        }

        private void grid_CurrentCellStartEditing(object sender, CancelEventArgs e)
        {
            e.Cancel = !this.editingEnabled;
        }

        private void UnwireTreeLineEvents()
        {
            this.grid.TableControl.CellButtonClicked -= new GridCellButtonClickedEventHandler(treeCellButton_Clicked);
        }


        private void treeCellButton_Clicked(object sender, GridCellButtonClickedEventArgs e)
        {
            if (e.ColIndex == TREECOLUMN)
            {
                if (GetNode(e.RowIndex).IsExpanded)
                {
                    CollapseNode(e.RowIndex, true);
                }
                else
                {
                    ExpandNode(e.RowIndex, true, true, true);
                }
                //tell base class not to process
                e.Cancel = true;
            }
        }

        private int GetPrimaryId(int rowIndex)
        {
            if (rowIndex >= rowOffSet && rowIndex <= this.grid.TableControl.Model.RowCount
                && this.rowIndexer.Count > 0)
            {
                int pos = GetPosition(rowIndex);// this.grid.TableControl.Binder.RowIndexToPosition(rowIndex);
                Node n = this.rowIndexer[pos];
                DataRowView drv = n.SiblingList[n.Position] as DataRowView;
                if (drv != null)
                {
                    return (int)drv[idProperty];
                }
            }
            return -1;
        }

        private Color GetIndentLevelColor(int indent)
        {
            if (ColorCodeList.Length - 1 < indent)
                return Color.White;
            else
                return ColorCodeList[indent];
        }


        #endregion
    }

    #endregion

    #region The NodeArray and Node classes
    public class NodeArray : BindingList<Node>, ITypedList
    {
        private DataView dv;
        public NodeArray(DataView dv)
        {
            this.dv = dv;
        }
        public new Node this[int i]
        {
            get { return (Node)base[i]; }
            set { base[i] = value; }
        }

        #region ITypedList Members

        public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
        {
            ITypedList list = (ITypedList)dv;


            PropertyDescriptorCollection pdc = ((ITypedList)dv).GetItemProperties(listAccessors);
            CustomPropertyDescriptor[] pds = new CustomPropertyDescriptor[pdc.Count];
            int i = 0;
            foreach (PropertyDescriptor pd in pdc)
            {
                pds[i++] = new CustomPropertyDescriptor(pd);
            }
            return new PropertyDescriptorCollection(pds);
        }

        public string GetListName(PropertyDescriptor[] listAccessors)
        {
            return "NodeDrv";
        }

        #endregion
    }

    public class Node
    {
        public Node(DataRowView drv)
        {
            this.drv = drv;
        }

        DataRowView drv;

        public DataRowView Drv
        {
            get { return drv; }
            set { drv = value; }
        }
        int pos1;
        IList cList = null;
        IList sList = null;
        int indent1;
        bool hasChildren1 = true;
        bool expanded = false;
        Node pNode = null;


        public Node ParentNode
        {
            get { return pNode; }
            set { pNode = value; }
        }

        public int Position
        {
            get { return pos1; }
            set { pos1 = value; }
        }

        public IList ChildList
        {
            get { return cList; }
            set { cList = value; }
        }

        public IList SiblingList
        {
            get { return sList; }
            set { sList = value; }
        }

        public int Indent
        {
            get { return indent1; }
            set { indent1 = value; }
        }

        public bool HasChildren
        {
            get { return hasChildren1; }
            set { hasChildren1 = value; }
        }

        public bool IsInitialized
        {
            get { return !hasChildren1 || cList != null; }
        }
        public bool IsExpanded
        {
            get { return expanded; }
            set { expanded = value; }
        }
    }

    #region custom property descriptor  - Used to expose properties in the DataTable as properties in a NodeList member
    /// <summary>
    /// Used to expose properties in the DataTable as properties in a NodeList member.
    /// </summary>
    public class CustomPropertyDescriptor : PropertyDescriptor
    {
        private PropertyDescriptor pd;
        public CustomPropertyDescriptor(PropertyDescriptor pd)
            : base(pd.Name, null)
        {
            this.pd = pd;
        }

        public override bool CanResetValue(object component)
        {
            return pd.CanResetValue(((Node)component).Drv);
        }

        public override Type ComponentType
        {
            get { return pd.ComponentType; }
        }

        public override object GetValue(object component)
        {
            if (((Node)component).Drv == null)
                return null;
            return pd.GetValue(((Node)component).Drv);
        }

        public override bool IsReadOnly
        {
            get { return pd.IsReadOnly; }
        }

        public override Type PropertyType
        {
            get { return pd.PropertyType; }
        }

        public override void ResetValue(object component)
        {
            pd.ResetValue(((Node)component).Drv);
        }

        public override void SetValue(object component, object value)
        {
            pd.SetValue(((Node)component).Drv, value);
        }

        public override bool ShouldSerializeValue(object component)
        {
            return pd.ShouldSerializeValue(((Node)component).Drv);
        }
    }
    #endregion
    #endregion

    #region mainly internal use - support classes for tree structure and datasources

    public interface ITreeGridDataSource
    {
        bool NodeHasChildren(int pos, IList parent);
        bool NodeHasChildren(int pos, IList parent, Node parentNode);
        IList GetChildList(int pos, IList parent);
        IList GetChildList(int pos, IList parent, Node parentNode);

    }

    public class SelfReferenceDataSourceAccessor : ITreeGridDataSource, IDisposable
    {
        private DataTable dt;
        private string matchProperty;
        private string valueProperty;
        private DataView dv = null;
        private IList lastParent = null;
        private int lastPos;
        private bool reset1 = false;
        internal string sortString = "";


        public void ResetDataView()
        {
            reset1 = true;
        }



        public DataView GetRootDataView()
        {
            string filter = string.Format("[{0}] = -1", matchProperty);
            this.dv = new DataView(this.dt, filter, sortString, DataViewRowState.CurrentRows);
            return this.dv;
        }

        private bool UseSameDataView(int pos, IList parent)
        {
            if (reset1)
            {
                reset1 = false;
                return false;
            }
            return this.dv != null && parent.Equals(this.lastParent) && pos == this.lastPos;
        }

        public SelfReferenceDataSourceAccessor(DataTable dt, string matchProperty, string valueProperty)
        {
            this.dt = dt;
            this.matchProperty = matchProperty;
            this.valueProperty = valueProperty;

        }

        #region ITreeGridDataSource Members

        public bool NodeHasChildren(int pos, IList parent, Node parentNode)
        {
            if (UseSameDataView(pos, parent))
                return this.dv.Count > 0;
            this.dv = GetChildDataView(pos, parent);
            return this.dv != null && this.dv.Count > 0;
        }

        public bool NodeHasChildren(int pos, IList parent)
        {
            if (UseSameDataView(pos, parent))
                return this.dv.Count > 0;
            this.dv = GetChildDataView(pos, parent);
            return this.dv != null && this.dv.Count > 0;
        }

        public IList GetChildList(int pos, IList parent, Node parentNode)
        {
            if (UseSameDataView(pos, parent))
                return this.dv;

            return GetChildDataView(pos, parent);
        }

        public IList GetChildList(int pos, IList parent)
        {
            if (UseSameDataView(pos, parent))
                return this.dv;

            return GetChildDataView(pos, parent);
        }

        public DataView GetChildDataView(int pos, IList parent)
        {
            this.lastParent = parent;
            this.lastPos = pos;
            string s = ((DataView)parent)[pos][this.valueProperty].ToString();

            string filter = string.Format("[{0}] = {1}", this.matchProperty, s);


            dv = new DataView(this.dt, filter, sortString, DataViewRowState.CurrentRows);
            

            return dv;
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            if (dv != null)
            {
                dv.Dispose();
                dv = null;
            }

        }

        #endregion
    }

    #endregion

}
