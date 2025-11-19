#region Copyright Syncfusion Inc. 2001 - 2005
//
//  Copyright Syncfusion Inc. 2001 - 2005. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;

namespace TestEngineOptimizations
{
	public enum DataSourceType
	{
		None,
		FlatVirtualList,
		FlatDataView,
//		FlatDataTableWrapperList,
//		HierachicalDataView,
//		FlatVirtualListWithForeinKeys,
//		FlatDataViewWithForeinKeys,
	}

	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Config
	{
		string name;
		DataSourceType dataSourceType;
		int recordCount;
		string comment;
		GridEngine schema = new GridEngine();
		bool useCustomEngine;
		bool allowGrouping;
        bool allowThumbtracking = true;

      

		public Config(string name)
		{
			this.name = name;

			switch (name)
			{
				case "Flat Virtual List, 30 million records, Virtual Mode":
					dataSourceType = DataSourceType.FlatVirtualList;
					recordCount = 30000000; // 30 million
					schema.InvalidateAllWhenListChanged = false;
					schema.AllowedOptimizations = EngineOptimizations.All;
					schema.CounterLogic = EngineCounters.YAmount;//.FilteredRecords;
					schema.TableOptions.VerticalPixelScroll = false;  // also dependant on CounterLogic = EngineCounters.YAmount 
					schema.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;
					schema.TableOptions.ColumnsMaxLengthFirstNRecords = 100;
					schema.TableOptions.AllowSortColumns = false;
					schema.TableDescriptor.AllowEdit = false;
					comment = "Large Virtual List with 30,000,000 records. Sorting and Grouping disabled. ReadOnly. Pixelscroll.";
					schema.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige;
					allowGrouping = false;
					useCustomEngine = false;
                    allowThumbtracking = false;
					this.OnDataSourceTypeChange();
					schema.TableDescriptor.Columns["Index"].MaxLength = 10;
					break;

				case "Flat Virtual List, VirtualMode":
					dataSourceType = DataSourceType.FlatVirtualList;
					recordCount = 100000; // 100k
					schema.InvalidateAllWhenListChanged = false;
					schema.AllowedOptimizations = EngineOptimizations.All;
					schema.CounterLogic = EngineCounters.FilteredRecords;
					schema.TableOptions.VerticalPixelScroll = false;  // also dependant on CounterLogic = EngineCounters.YAmount 
					schema.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;
					schema.TableOptions.ColumnsMaxLengthFirstNRecords = 100;
					schema.TableOptions.AllowSortColumns = true;
					schema.TableDescriptor.AllowEdit = false;
					allowGrouping = true;
					comment = "Virtual List With 100,000 records. Sorting and Grouping enabled. No pass-through sort. ReadOnly";
					schema.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige;
					useCustomEngine = false;
					this.OnDataSourceTypeChange();
					schema.TableDescriptor.Columns["Index"].MaxLength = 10;
					break;

				case "Flat DataView, VirtualMode, Pass-Through sorting enabled.":
					dataSourceType = DataSourceType.FlatDataView;
					recordCount = 100000; // 100k
					schema.InvalidateAllWhenListChanged = false;
					schema.AllowedOptimizations = EngineOptimizations.All;
					schema.CounterLogic = EngineCounters.FilteredRecords;
					schema.TableOptions.VerticalPixelScroll = false;  // also dependant on CounterLogic = EngineCounters.YAmount 
					schema.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;
					schema.TableOptions.ColumnsMaxLengthFirstNRecords = 100;
					schema.TableOptions.AllowSortColumns = true;
					schema.TableDescriptor.AllowEdit = true;
					allowGrouping = true;
					comment = "FlatDataView with 100,000 records. Sorting and Grouping enabled. Pass-through sort enabled.";
					schema.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige;
					useCustomEngine = false;
					this.OnDataSourceTypeChange();
					break;

				case "Flat DataView, VirtualMode, Pass-Through sorting disabled.":
					dataSourceType = DataSourceType.FlatDataView;
					recordCount = 100000; // 100k
					schema.InvalidateAllWhenListChanged = false;
					schema.AllowedOptimizations = EngineOptimizations.DisableCounters|EngineOptimizations.VirtualMode|EngineOptimizations.RecordsAsDisplayElements;
					schema.CounterLogic = EngineCounters.FilteredRecords;
					schema.TableOptions.VerticalPixelScroll = false;  // also dependant on CounterLogic = EngineCounters.YAmount 
					schema.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;
					schema.TableOptions.ColumnsMaxLengthFirstNRecords = 100;
					schema.TableOptions.AllowSortColumns = true;
					schema.TableDescriptor.AllowEdit = true;
					allowGrouping = true;
					comment = "FlatDataView with 100,000 records. Sorting and Grouping enabled. No pass-through sort.";
					schema.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige;
					useCustomEngine = false;
					this.OnDataSourceTypeChange();
					break;

				case "Flat DataView, Summaries.":
					dataSourceType = DataSourceType.FlatDataView;
					recordCount = 100000; // 100k
					schema.InvalidateAllWhenListChanged = false;
					schema.AllowedOptimizations = EngineOptimizations.DisableCounters|EngineOptimizations.VirtualMode|EngineOptimizations.RecordsAsDisplayElements;
					schema.CounterLogic = EngineCounters.FilteredRecords;
					schema.TableOptions.VerticalPixelScroll = false;  // also dependant on CounterLogic = EngineCounters.YAmount 
					schema.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;
					schema.TableOptions.ColumnsMaxLengthFirstNRecords = 100;
					schema.TableOptions.AllowSortColumns = true;
					schema.TableDescriptor.AllowEdit = true;
					schema.TableDescriptor.SummaryRows.Add(new GridSummaryRowDescriptor("Average", new GridSummaryColumnDescriptor("Zip", SummaryType.Int32Aggregate, "Zip", "{Average:###}")));
					allowGrouping = true;
					comment = "FlatDataView with 100,000 records. Summaries. Sorting and Grouping enabled. No pass-through sort.";
					schema.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige;
					useCustomEngine = false;
					this.OnDataSourceTypeChange();
					break;

				case "Flat DataView, Grouped.":
					dataSourceType = DataSourceType.FlatDataView;
					recordCount = 100000; // 100k
					schema.InvalidateAllWhenListChanged = false;
					schema.AllowedOptimizations = EngineOptimizations.DisableCounters|EngineOptimizations.VirtualMode|EngineOptimizations.RecordsAsDisplayElements;
					schema.CounterLogic = EngineCounters.FilteredRecords;
					schema.TableOptions.VerticalPixelScroll = false;  // also dependant on CounterLogic = EngineCounters.YAmount 
					schema.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;
					schema.TableOptions.ColumnsMaxLengthFirstNRecords = 100;
					schema.TableOptions.AllowSortColumns = true;
					schema.TableDescriptor.AllowEdit = true;
					schema.TableDescriptor.GroupedColumns.Add("Zip");
					allowGrouping = true;
					comment = "FlatDataView with 100,000 records. Grouped. Sorting enabled. No pass-through sort.";
					schema.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige;
					useCustomEngine = false;
					this.OnDataSourceTypeChange();
					break;

				case "Flat Virtual List, No Optimizations":
					dataSourceType = DataSourceType.FlatVirtualList;
					recordCount = 100000; // 100k
					schema.InvalidateAllWhenListChanged = false;
					schema.AllowedOptimizations = EngineOptimizations.None;
					schema.CounterLogic = EngineCounters.All;
					schema.TableOptions.VerticalPixelScroll = false;  // also dependant on CounterLogic = EngineCounters.YAmount 
					schema.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;
					schema.TableOptions.ColumnsMaxLengthFirstNRecords = 100;
					schema.TableOptions.AllowSortColumns = true;
					schema.TableDescriptor.AllowEdit = false;
					allowGrouping = true;
					comment = "Virtual List With 100,000 records. Sorting and Grouping enabled. No pass-through sort. ReadOnly";
					schema.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige;
					useCustomEngine = false;
					this.OnDataSourceTypeChange();
					schema.TableDescriptor.Columns["Index"].MaxLength = 10;
					break;

				case "Flat Virtual List, Using Custom Engine":
					dataSourceType = DataSourceType.FlatVirtualList;
					recordCount = 100000; // 100k
					schema.InvalidateAllWhenListChanged = false;
					schema.AllowedOptimizations = EngineOptimizations.All;
					schema.CounterLogic = EngineCounters.FilteredRecords;
					schema.TableOptions.VerticalPixelScroll = false;  // also dependant on CounterLogic = EngineCounters.YAmount 
					schema.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;
					schema.TableOptions.ColumnsMaxLengthFirstNRecords = 100;
					schema.TableOptions.AllowSortColumns = true;
					schema.TableDescriptor.AllowEdit = false;
					allowGrouping = true;
					comment = "Virtual List With 100,000 records. Sorting and Grouping enabled. No pass-through sort. ReadOnly. Using Custom Engine.";
					schema.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige;
					useCustomEngine = true;
					this.OnDataSourceTypeChange();
					schema.TableDescriptor.Columns["Index"].MaxLength = 10;
					break;

				case "Flat Virtual List, Sorted":
					dataSourceType = DataSourceType.FlatVirtualList;
					recordCount = 100000; // 100k
					schema.InvalidateAllWhenListChanged = false;
					schema.AllowedOptimizations = EngineOptimizations.All;
					schema.CounterLogic = EngineCounters.FilteredRecords;
					schema.TableOptions.VerticalPixelScroll = false;  // also dependant on CounterLogic = EngineCounters.YAmount 
					schema.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;
					schema.TableOptions.ColumnsMaxLengthFirstNRecords = 100;
					schema.TableOptions.AllowSortColumns = true;
					schema.TableDescriptor.AllowEdit = false;
					schema.TableDescriptor.SortedColumns.Add("SomeValue");
					allowGrouping = true;
					comment = "Sorted Virtual List With 100,000 records. Sorting and Grouping enabled. No pass-through sort. ReadOnly";
					schema.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige;
					useCustomEngine = false;
					this.OnDataSourceTypeChange();
					schema.TableDescriptor.Columns["Index"].MaxLength = 10;
					break;

				case "Flat Virtual List, Grouped":
					dataSourceType = DataSourceType.FlatVirtualList;
					recordCount = 100000; // 100k
					schema.InvalidateAllWhenListChanged = false;
					schema.AllowedOptimizations = EngineOptimizations.All;
					schema.CounterLogic = EngineCounters.FilteredRecords;
					schema.TableOptions.VerticalPixelScroll = false;  // also dependant on CounterLogic = EngineCounters.YAmount 
					schema.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;
					schema.TableOptions.ColumnsMaxLengthFirstNRecords = 100;
					schema.TableOptions.AllowSortColumns = true;
					schema.TableDescriptor.AllowEdit = true;
					schema.TableDescriptor.GroupedColumns.Add("OtherValue");
					allowGrouping = true;
					comment = "Virtual List With 100,000 records. Sorting and Grouping enabled. No pass-through sort. ReadOnly";
					schema.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige;
					useCustomEngine = false;
					this.OnDataSourceTypeChange();
					schema.TableDescriptor.Columns["Index"].MaxLength = 10;
					break;

				case "Flat Virtual List, Grouped, VerticalPixelScroll":
					dataSourceType = DataSourceType.FlatVirtualList;
					recordCount = 100000; // 100k
					schema.InvalidateAllWhenListChanged = false;
					schema.AllowedOptimizations = EngineOptimizations.All;
					schema.CounterLogic = EngineCounters.YAmount;
					schema.TableOptions.VerticalPixelScroll = true;  // also dependant on CounterLogic = EngineCounters.YAmount 
					schema.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;
					schema.TableOptions.ColumnsMaxLengthFirstNRecords = 100;
					schema.TableOptions.AllowSortColumns = true;
					schema.TableDescriptor.AllowEdit = true;
					schema.TableDescriptor.GroupedColumns.Add("OtherValue");
					allowGrouping = true;
					comment = "Virtual List With 100,000 records. Sorting and Grouping enabled. No pass-through sort. ReadOnly";
					schema.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige;
					useCustomEngine = false;
					this.OnDataSourceTypeChange();
					schema.TableDescriptor.Columns["Index"].MaxLength = 10;
					break;

				case "Reset Datasource":
					dataSourceType = DataSourceType.None;
					recordCount = 0; // 100k
					comment = "Empty Datasource (null)";
					this.OnDataSourceTypeChange();
					break;


			}
		}

		public Config()
		{
		}

		[Category("Info")]
		[RefreshProperties(RefreshProperties.All)]
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}

		[Category("Info")]
		[RefreshProperties(RefreshProperties.All)]
		public string Comment
		{
			get
			{
				return comment;
			}
			set
			{
				comment = value;
			}
		}
		
		[Category("Data")]
		[RefreshProperties(RefreshProperties.All)]
		public DataSourceType DataSourceType
		{
			get
			{
				return dataSourceType;
			}
			set
			{
				dataSourceType = value;
			}
		}
		
		[Category("Data")]
		[RefreshProperties(RefreshProperties.All)]
		public int RecordCount
		{
			get
			{
				return recordCount;
			}
			set
			{
				recordCount = value;
			}
		}

		[Category("Data")]
		[RefreshProperties(RefreshProperties.All)]
		public GridEngine Schema
		{
			get
			{
				return schema;
			}
			set
			{
				schema.InitializeFrom(value);
			}
		}

        [Category("Data")]
        [RefreshProperties(RefreshProperties.All)]
        public bool AllowThumbtracking
        {
            get { return allowThumbtracking; }
            set { allowThumbtracking = value; }
        }

		[Category("Data")]
		[RefreshProperties(RefreshProperties.All)]
		public bool AllowGrouping
		{
			get
			{
				return allowGrouping;
			}
			set
			{
				allowGrouping = value;
			}
		}

		[Category("Data")]
		[RefreshProperties(RefreshProperties.All)]
		public bool UseCustomEngine
		{
			get
			{
				return useCustomEngine;
			}
			set
			{
				useCustomEngine = value;
			}
		}

		void OnDataSourceTypeChange()
		{
			switch (this.dataSourceType)
			{
				case DataSourceType.FlatVirtualList:
					this.schema.DataSource = new TestEngineOptimizations.VirtualList(this.recordCount);
					this.schema.Reset();
					break;

				case DataSourceType.None:
					this.schema.DataSource = null;
					this.schema.Reset();
					break;

				case DataSourceType.FlatDataView:
				{
					this.schema.DataSource = GetDataTable(100, this.recordCount);
					this.schema.Reset();
					break;
				}
			}
		}

		DataTable GetDataTable(int zipCount, int recordCount)
		{
			string[] states = new string[]{"North Carolina", "South Carolina", "Washington", "Nevada", "Ohio"};

			Random random = new Random();
			int numStates = states.GetLength(0);
			string nameFormat = "Name{0:00000}";

			DataTable table = new DataTable("Test");

			DataColumn col = table.Columns.Add();
			col.DataType = typeof(string);
			col.ColumnName = "Name";

			col = table.Columns.Add();
			col.DataType = typeof(string);
			col.ColumnName = "State";

			col = table.Columns.Add();
			col.DataType = typeof(int);
			col.ColumnName = "Zip";

			for(int i = 0; i < recordCount; i++)
			{
				DataRow row = table.NewRow();
				row["Name"] = string.Format(nameFormat, i);
				row["State"] = states[random.Next(numStates-1)];
				row["Zip"] = random.Next(zipCount);
				table.Rows.Add(row);
			}

			return table;
		}

		public void ApplyTo(Form1 form)
		{
			bool currentCustomEngine = form.gridGroupingControl1.Engine is GroupingEngine;

			
				// Create a new GridGroupingControl with new engine
				form.Controls.Remove(form.gridGroupingControl1);
				if (this.useCustomEngine)
					form.gridGroupingControl1 = new GridGroupingControl(new GroupingEngine());
				else
					form.gridGroupingControl1 = new GridGroupingControl();
				form.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
				form.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
                form.gridGroupingControl1.ClientSize = new Size(380, 300);
                form.gridGroupingControl1.Location = new Point(20, 18);
				form.gridGroupingControl1.Name = "gridGroupingControl1";
				form.gridGroupingControl1.TabIndex = 0;
				form.gridGroupingControl1.VersionInfo = "3.2.0.0";
				form.gridGroupingControl1.IntelliMousePanning = true;
				//form.Controls.Add(form.gridGroupingControl1);

                form.Controls["panel2"].Controls.Add(form.gridGroupingControl1);

			GridGroupingControl grid = form.gridGroupingControl1;
			grid.DataSource = null;
			grid.Engine = schema;  // will call Engine.InitializeFrom in setter.

			switch (this.dataSourceType)
			{
				case DataSourceType.None:
					grid.DataSource = null;
					break;

				case DataSourceType.FlatVirtualList:
					grid.DataSource = new TestEngineOptimizations.VirtualList(this.recordCount);
					break;
				case DataSourceType.FlatDataView:
				{
					grid.DataSource = GetDataTable(100, this.recordCount);
					break;
				}
			}

			grid.ShowGroupDropArea = this.allowGrouping;
            grid.VerticalThumbTrack = this.AllowThumbtracking;

		}
	}


	#region "'ConfigCollection' strongly typed collection class"

	[EditorAttribute(typeof(System.ComponentModel.Design.CollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
	public class ConfigCollection : System.Collections.CollectionBase 
	{
		public ConfigCollection() 
		{
		}
    
		public ConfigCollection(ConfigCollection fieValue) 
		{
			this.AddRange(fieValue);
		}
    
		public ConfigCollection(Config[] fieValue) 
		{
			this.AddRange(fieValue);
		}
    
		public Config this[int intIndex] 
		{
			get 
			{
				return ((Config)(List[intIndex]));
			}
			set 
			{
				List[intIndex] = value;
			}
		}

		public Config Find(string name)
		{
			for (int n = 0; n < Count; n++)
				if (this[n].Name == name)
					return this[n];

			return null;
		}

		public Config GetConfig(string name)
		{
			Config value = Find(name);
			if (value == null)
			{
				Config obj = new Config();
				obj.Name = name;
				Add(obj);
			}

			return value;
		}

		public int Add(Config fieValue) 
		{
			return List.Add(fieValue);
		}
    
		public void AddRange(Config[] fieValue) 
		{
			for (int intCounter = 0; (intCounter < fieValue.Length); intCounter = (intCounter + 1)) 
			{
				this.Add(fieValue[intCounter]);
			}
		}
    
		public void AddRange(ConfigCollection fieValue) 
		{
			for (int intCounter = 0; (intCounter < fieValue.Count); intCounter = (intCounter + 1)) 
			{
				this.Add(fieValue[intCounter]);
			}
		}
    
		public bool Contains(Config fieValue) 
		{
			return List.Contains(fieValue);
		}
    
		public void CopyTo(Config[] fieArray, int intIndex) 
		{
			List.CopyTo(fieArray, intIndex);
		}
    
		public int IndexOf(Config fieValue) 
		{
			return List.IndexOf(fieValue);
		}
    
		public void Insert(int intIndex, Config fieValue) 
		{
			List.Insert(intIndex, fieValue);
		}
    
		public new ConfigEnumerator GetEnumerator() 
		{
			return new ConfigEnumerator(this);
		}
    
		public void Remove(Config fieValue) 
		{
			List.Remove(fieValue);
		}
    
		public class ConfigEnumerator : object, System.Collections.IEnumerator 
		{
        
			private System.Collections.IEnumerator iEnBase;
        
			private System.Collections.IEnumerable iEnLocal;
        
			public ConfigEnumerator(ConfigCollection fieMappings) 
			{
				this.iEnLocal = ((System.Collections.IEnumerable)(fieMappings));
				this.iEnBase = iEnLocal.GetEnumerator();
			}
        
			public Config Current 
			{
				get 
				{
					return ((Config)(iEnBase.Current));
				}
			}
        
			object System.Collections.IEnumerator.Current 
			{
				get 
				{
					return iEnBase.Current;
				}
			}
        
			public bool MoveNext() 
			{
				return iEnBase.MoveNext();
			}
        
			bool System.Collections.IEnumerator.MoveNext() 
			{
				return iEnBase.MoveNext();
			}
        
			public void Reset() 
			{
				iEnBase.Reset();
			}
        
			void System.Collections.IEnumerator.Reset() 
			{
				iEnBase.Reset();
			}
		}
	}

	#endregion //('ConfigCollection' strongly typed collection class)
}
