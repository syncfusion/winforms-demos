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
using System.Collections;


namespace CustomGridCell
{
    public class TreeNodeState
    {
        static public int Opened = 0;
        static public int Closed = 1;
        static public int NoChildren = 2;
    }

    [Serializable]
    public class SampleData
    {
        private int _count;
        private int _indentLevel;
        private string[] _items;
        private int _state;

        public string[] Items
        {
            get
            {
                if (_items == null)
                    _items = new string[_count];
                return _items;
            }
            set { _items = value; }
        }


        public int IndentLevel
        {
            get { return _indentLevel; }
            set { _indentLevel = value; }
        }

        public int ItemCount
        {
            get { return _count; }
        }

        public int ExpandState
        {
            get { return _state; }
            set { _state = value; }
        }

        public SampleData(int indentLevel, int expandstate, string item1, string item2, string item3, string item4)
        {
            _count = 4;
            _items = new string[_count];
            _items[0] = item1;
            _items[1] = item2;
            _items[2] = item3;
            _items[3] = item4;
            _indentLevel = indentLevel;
            _state = expandstate;

        }
    }

    [Serializable]
    public class CollapsibleDataSource
    {
        private int internalRowCount;
        private int internalColCount;
        private SampleData[] data;

        private ArrayList visibleRows;

        public bool Locked;

        public CollapsibleDataSource(int rawRowCount)
        {
            internalColCount = 4;

            Locked = false;

            internalRowCount = rawRowCount;

            visibleRows = new ArrayList();

        }

        public int RowCount
        {
            get { return visibleRows.Count; }
        }

        public int ColCount
        {
            get { return internalColCount; }
        }

        public void CollapseData(int start)
        {
            //decide which rows are visible and add then to visibleRows
            if (start > 0)
                visibleRows.RemoveRange(start, visibleRows.Count - start);
            else
                visibleRows = new ArrayList();

            int i = start;
            while (i < internalRowCount)
            {
                i = ProcessNode(i);// will increment i at least once, maybe more
            }
        }
        public void CollapseData()
        {
            //decide which rows are visible and add then to visibleRows
            visibleRows = new ArrayList();

            int i = 0;
            while (i < internalRowCount)
            {
                i = ProcessNode(i);// will increment i at least once, maybe more
            }
        }

        private int ProcessNode(int i)
        {
            if (i >= internalRowCount)
                return i;

            int indent = data[i].IndentLevel;
            bool closed = (data[i].ExpandState == TreeNodeState.Closed);
            visibleRows.Add(i);

            //make sure parent is not a nocheck
            int k;
            if (visibleRows.Count > 1)
            {
                k = (int)visibleRows[visibleRows.Count - 2];
                if (data[k].ExpandState == TreeNodeState.NoChildren
                    && indent > data[k].IndentLevel)
                {
                    data[k].ExpandState = TreeNodeState.Opened;
                }
            }

            ++i;
            if (closed)
            {
                // since last node was not open, 
                // ignore all nodes indented further
                while (i < internalRowCount && data[i].IndentLevel > indent)
                    ++i;
                return i; // return & process next node at same level
            }

            // last node was open, so process all on same level
            while (i < internalRowCount && data[i].IndentLevel == indent)
            {
                i = ProcessNode(i);
                return i;
            }

            return i;


        }
        public SampleData this[int i]
        {
            get { return data[(int)visibleRows[i]]; }
        }

        public void InitData()
        {
            this.data = new SampleData[internalRowCount];

            for (int i = 0; i < internalRowCount; ++i)
            {
                int ii = i + 1;
                data[i] = new SampleData(0, TreeNodeState.NoChildren, "row " + ii.ToString() + ", col 1",
                    "row " + ii.ToString() + ", col 2",
                    "row " + ii.ToString() + ", col 3",
                    "row " + ii.ToString() + ", col 4");
            }

        }

        public void ExpandAll()
        {
            for (int i = 0; i < internalRowCount; ++i)
            {
                if (data[i].ExpandState == TreeNodeState.Closed)
                    data[i].ExpandState = TreeNodeState.Opened;
            }
        }

        public void CloseAll()
        {
            for (int i = 0; i < internalRowCount; ++i)
            {
                if (data[i].ExpandState == TreeNodeState.Opened)
                    data[i].ExpandState = TreeNodeState.Closed;
            }

        }

    }


}
