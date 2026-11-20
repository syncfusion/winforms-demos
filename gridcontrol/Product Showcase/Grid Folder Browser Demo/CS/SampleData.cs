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
using System.IO;


namespace FolderBrowser
{
	public class TreeNodeState
	{
		static public int Opened =0 ;
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
				if(_items == null)
					 _items = new string[_count];
				return _items;
			}
			set{ _items = value;}
		}

		
		public int IndentLevel
		{
			get{ return _indentLevel;}
			set{ _indentLevel = value;}
		}

		public int ItemCount
		{
			get{return _count;}
		}

		public int ExpandState
		{
			get{return _state;}
			set{ _state = value;}
		}

		public SampleData()
		{
		}

		public SampleData(int indentLevel, int expandstate, string item1, string item2, string item3, string item4, string item5)
		{
			_count = 5;
			_items = new string[_count];
			_items[0] = item1;
			_items[1] = item2;
			_items[2] = item3;
			_items[3] = item4;
			_items[4] = item5;
			_indentLevel = indentLevel;
			_state = expandstate;

		}
	}
	
	[Serializable]
	public class CollapsibleDataSource
	{
		FileData fc;
		private int internalRowCount;
		private int internalColCount;
		private string drvName;
		DataCollection data;
		bool isempty = false;
		private ArrayList visibleRows;

		public bool Locked;

		public CollapsibleDataSource( string drive )
		{
			internalColCount = 5;

			Locked = false;

			internalRowCount = 10;
			drvName = drive;

			visibleRows = new ArrayList();
			data=new DataCollection();
			fc=new FileData(this.drvName);
			if(fc.Count == 0)
				isempty=true;
		}

		public bool IsEmpty
		{
			get { return isempty; }
		}
		public int RowCount
		{
			get{return visibleRows.Count;}
		}

		public int ColCount
		{
			get{return internalColCount;}
		}

		public void CollapseData(int start)
		{
			//decide which rows are visible and add then to visibleRows
			if(start > 0)
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

		public void InsertData(int index, string filePath, int indent)
		{
            int iOrginalIndex = int.Parse(visibleRows[index - 1].ToString()) + 1;

            this.fc = new FileData(filePath);

            foreach (FileDataItem item in this.fc)
            {
                int state = 1;
                if (item.ItemType.ToString() == "File")
                    state = 2;
                data.Insert(iOrginalIndex, new SampleData(indent + 1, state, item.Name, item.Size.ToString(), item.FullName, item.Modified.ToString(), item.ItemType.ToString()));
                internalRowCount++;
                index++;
            }
            CollapseData();

		}

		private int ProcessNode(int i)
		{
			if(i >= internalRowCount)
				return i;

			int indent = data[i].IndentLevel;
			bool closed = (data[i].ExpandState == TreeNodeState.Closed);
			visibleRows.Add(i);

			//make sure parent is not a nocheck
			int k;
			if( visibleRows.Count > 1)
			{
				k = (int) visibleRows[visibleRows.Count - 2];
				if( data[k].ExpandState == TreeNodeState.NoChildren 
					&& indent > data[k].IndentLevel )
				{
					data[k].ExpandState = TreeNodeState.Opened;
				}
			}

			++i;
			if(closed)
			{
				// since last node was not open, 
				// ignore all nodes indented further
				while(i < internalRowCount && data[i].IndentLevel > indent)
					++i;
				return i; // return & process next node at same level
			}
			
				// last node was open, so process all on same level
				while(i < internalRowCount && data[i].IndentLevel == indent)
				{
					i = ProcessNode(i);
					return i;
				}
			
			return i;	
			
			
		}
		public SampleData this[int i]
		{
			get{ return data[(int) visibleRows[i]];}
		}

		public void InitData()
		{
            ArrayList temp = GetFileListing(this.drvName);

			internalRowCount = temp.Count;
			
			for(int i = 0; i < internalRowCount; ++i)
			{	
				SampleData d = (SampleData) temp[i];
				
				if(d.Items[3] == "Directory")
				{
					FileData f = new FileData(System.IO.Directory.GetDirectoryRoot(d.Items[0]));
					d.IndentLevel = 1;
					if(f.Count > 0)
						d.ExpandState = TreeNodeState.Closed;
				}
				else if(d.Items[3] == "File")
				{
					d.ExpandState = TreeNodeState.NoChildren;
					d.IndentLevel = 1;
				}

				data.Add(d);
			}
			
		}

		public void ExpandAll()
		{
			for(int i = 0; i < internalRowCount; ++i)
			{
				if(data[i].ExpandState == TreeNodeState.Closed)
					data[i].ExpandState = TreeNodeState.Opened;
			}
		}

		public void CloseAll()
		{
			for(int i = 0; i < internalRowCount; ++i)
			{
				if(data[i].ExpandState == TreeNodeState.Opened)
					data[i].ExpandState = TreeNodeState.Closed;
			}

		}

		ArrayList GetFileListing(string aStartingDir)
		{
			DirectoryInfo di = new DirectoryInfo(aStartingDir);
			
			ArrayList List=new ArrayList();
			this.fc = new FileData(aStartingDir);
			List.Add( new SampleData (0, TreeNodeState.Opened, drvName , aStartingDir.Length.ToString(),  aStartingDir, di.LastWriteTime.ToString(), "Drive" ) );
			foreach(FileDataItem item in this.fc)
			{
				List.Add( new SampleData(1, TreeNodeState.Closed, item.Name, item.Size.ToString(), item.FullName, item.Modified.ToString(), item.ItemType.ToString() ) );
			}
			return List;
		}
	}
}
