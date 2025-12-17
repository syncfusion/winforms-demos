#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
namespace OutlookDemo
{
	# region GroupingEngineFactory

	/// <summary>
	/// GroupingEngineFactory provides a trimmed down GridGroup
	/// which eliminates overhead of not needed preview rows, header and footer cells.
	/// </summary>
	public class GroupingEngineFactory : GridEngineFactoryBase
	{
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
			return 20;
		}
	}

	public class GroupingChildTable : GridChildTable
	{
		public GroupingChildTable(Element parent)
			: base(parent)
		{
		}

		private static bool sectionRequired = true;
		public static bool SectionRequired
		{
			get{return sectionRequired;}
			set{sectionRequired = value;}
		}

		protected override void OnInitializeSections(bool hasRecords, SortColumnDescriptorCollection fields)
		{
			if (this.IsTopLevelGroup && GroupingChildTable.sectionRequired)
				this.Sections.Add(new ExtraSection(this));
			base.OnInitializeSections(hasRecords, fields);
		}

		public override bool IsChildVisible(Element el)
		{
			if (this.IsTopLevelGroup && GroupingChildTable.sectionRequired && el is ExtraSection )
			{
				return true;
			}
			else
				return base.IsChildVisible(el);
		}
	}
	# endregion
}
