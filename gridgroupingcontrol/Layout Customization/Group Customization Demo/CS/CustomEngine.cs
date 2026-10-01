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
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Diagnostics;

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace CustomSectionInGroup
{
	/// <summary>
	/// GroupingEngineFactory provides a trimmed down GridGroup
	/// which eliminates overhead of not needed preview rows, header and footer cells.
	/// </summary>
	public class GroupingEngineFactory : GridEngineFactoryBase
	{
		// Add this line in your forms ctor:
		// GroupingEngineFactory provides a modified GridChildTable that adds an extra section
		// GridEngineFactory.Factory = new GroupingEngineFactory();

		public override GridEngine CreateEngine()
		{
			return new GroupingEngine();
		}
	}

	public class GroupingEngine : GridEngine
	{
		public override ChildTable CreateChildTable(Element parent)
		{
			return new GroupingChildTable(parent);
		}

		public override Group CreateGroup(Section parent)
		{
			return new GroupingGroup(parent);
		}
	}

	public class ExtraSection : EmptySection
	{
		public ExtraSection(Group parent)
			: base(parent)
		{
		}

		public override DisplayElementKind Kind
		{
			get { return DisplayElementKind.None; }
		}

		public override int GetElementCount()
		{
			return 1;
		}

		public override int GetVisibleCount()
		{
			return 1;
		}

		public override double GetYAmountCount()
		{
			return 22;   // Row Height
		}
	}

	public class GroupingChildTable : ChildTable, IGridGroupOptionsSource
	{
		public GroupingChildTable(Element parent)
			: base(parent)
		{
		}

		protected override void OnInitializeSections(bool hasRecords, SortColumnDescriptorCollection fields)
		{
			// Caption
			this.Sections.Add(this.ParentTableDescriptor.CreateCaptionSection(this));

			// Column Headers
			this.Sections.Add(this.ParentTableDescriptor.CreateColumnHeaderSection(this));

			// Extra section
			this.Sections.Add(new ExtraSection(this));

			// AddNewRecord
			AddNewRecordSection addNewRecordSectionBeforeDetails = this.ParentTableDescriptor.CreateAddNewRecordSection(this);
			addNewRecordSectionBeforeDetails.IsBeforeDetails = true;
			this.Sections.Add(addNewRecordSectionBeforeDetails);

			// Details (Records or Groups)
			if (hasRecords)
				this.Sections.Add(this.ParentTableDescriptor.CreateRecordsDetails(this, fields));
			else
				this.Sections.Add(this.ParentTableDescriptor.CreateGroupsDetails(this, fields));

			// Summary
			this.Sections.Add(this.ParentTableDescriptor.CreateSummarySection(this));
		}		

		public override bool IsChildVisible(Element el)
		{
			if (this.IsTopLevelGroup)
				return true;

			if (el is ExtraSection)
				return el.ParentGroup.IsExpanded;  // here you can specify when the extra section is visible.

			else if (el is CaptionSection || el is ColumnHeaderSection)
				return true;
			
			else 
				return el.ParentGroup.IsExpanded;
		}

		#region IGridGroupOptionsSource Members

		GridGroupOptionsStyleInfo groupOptions;

		public void RaiseGroupOptionsChanging(GridGroupOptionsChangedEventArgs e)
		{
		}

		public void RaiseGroupOptionsChanged(GridGroupOptionsChangedEventArgs e)
		{
			this.InvalidateCounterTopDown(true);
		}

		public bool HasGroupOptions
		{
			get
			{
				return groupOptions != null;
			}
		}

		/// <override/>
		public new GridEngine Engine
		{
			get
			{
				return (GridEngine) base.Engine;
			}
		}

		/// <summary>
		/// Lets you control the look of inner groups like whether the Caption Row is visible, or what CaptionText is.
		/// </summary>
		[DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		public GridGroupOptionsStyleInfo GroupOptions
		{
			get
			{
				if (groupOptions == null)
				{
					GridGroupOptionsType t = GridGroupOptionsType.Groups;
					if (this.IsTopLevelGroup)
						t = GridGroupOptionsType.TopLevelGroup;
					else //if (this is ChildTable)
						t = GridGroupOptionsType.ChildTable;

					groupOptions = new GridGroupOptionsStyleInfo(new GridGroupOptionsStyleInfoIdentity((IGridGroupOptionsSource) this, t));
				}
				return groupOptions;
			}
			set
			{
				GroupOptions.CopyFrom(value);
			}
		}

		public IGridGroupOptionsSource GetParentGroupOptionsSource()
		{
			if (this.CategoryColumns.Count > 0)
			{
				GridColumnDescriptor column = ((GridTableDescriptor) this.ParentTableDescriptor).Columns[this.CategoryColumns[0].Name];
				if (column != null)
					return column;
			}
			return (IGridGroupOptionsSource) this.ParentTableDescriptor;
		}

		#endregion
	}

	public class GroupingGroup : Group, IGridGroupOptionsSource
	{
		public GroupingGroup(Section parent)
			: base(parent)
		{
		}

		protected override void OnInitializeSections(bool hasRecords, SortColumnDescriptorCollection fields)
		{
			// Caption
			this.Sections.Add(this.ParentTableDescriptor.CreateCaptionSection(this));

			// Extra section
			this.Sections.Add(new ExtraSection(this));

			// Summary
			this.Sections.Add(this.ParentTableDescriptor.CreateSummarySection(this));

			// AddNewRecord
			AddNewRecordSection addNewRecordSectionBeforeDetails = this.ParentTableDescriptor.CreateAddNewRecordSection(this);
			addNewRecordSectionBeforeDetails.IsBeforeDetails = true;
			this.Sections.Add(addNewRecordSectionBeforeDetails);

			// Details (Records or Groups)
			if (hasRecords)
				this.Sections.Add(this.ParentTableDescriptor.CreateRecordsDetails(this, fields));
			else
				this.Sections.Add(this.ParentTableDescriptor.CreateGroupsDetails(this, fields));

		}		

		public override bool IsChildVisible(Element el)
		{
			if (el is ExtraSection)
				return el.ParentGroup.IsExpanded;  // here you can specify when the extra section is visible.

			else if (el is CaptionSection)
				return true;
			
			else 
				return el.ParentGroup.IsExpanded;
		}

		#region IGridGroupOptionsSource Members

		GridGroupOptionsStyleInfo groupOptions;

		public void RaiseGroupOptionsChanging(GridGroupOptionsChangedEventArgs e)
		{
		}

		public void RaiseGroupOptionsChanged(GridGroupOptionsChangedEventArgs e)
		{
			this.InvalidateCounterTopDown(true);
		}

		public bool HasGroupOptions
		{
			get
			{
				return groupOptions != null;
			}
		}

		/// <override/>
		public new GridEngine Engine
		{
			get
			{
				return (GridEngine) base.Engine;
			}
		}

		/// <summary>
		/// Lets you control the look of inner groups like whether the Caption Row is visible, or what CaptionText is.
		/// </summary>
		[DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		public GridGroupOptionsStyleInfo GroupOptions
		{
			get
			{
				if (groupOptions == null)
				{
					GridGroupOptionsType t = GridGroupOptionsType.Groups;
					if (this.IsTopLevelGroup)
						t = GridGroupOptionsType.TopLevelGroup;
					else //if (this is ChildTable)
						t = GridGroupOptionsType.ChildTable;

					groupOptions = new GridGroupOptionsStyleInfo(new GridGroupOptionsStyleInfoIdentity((IGridGroupOptionsSource) this, t));
				}
				return groupOptions;
			}
			set
			{
				GroupOptions.CopyFrom(value);
			}
		}

		public IGridGroupOptionsSource GetParentGroupOptionsSource()
		{
			if (this.CategoryColumns.Count > 0)
			{
				GridColumnDescriptor column = ((GridTableDescriptor) this.ParentTableDescriptor).Columns[this.CategoryColumns[0].Name];
				if (column != null)
					return column;
			}
			return (IGridGroupOptionsSource) this.ParentTableDescriptor;
		}

		#endregion
	}
}
