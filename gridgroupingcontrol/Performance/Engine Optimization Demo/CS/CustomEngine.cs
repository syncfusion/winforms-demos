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
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace TestEngineOptimizations
{
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
		public override Group CreateGroup(Section parent)
		{
			return new GroupingGroup(parent);
		}

	}

	public class GroupingGroup : Group
	{
		public GroupingGroup(Section parent)
			: base(parent)
		{
		}

		protected override void OnInitializeSections(bool hasRecords, SortColumnDescriptorCollection fields)
		{
			this.Sections.Add(this.ParentTableDescriptor.CreateCaptionSection(this));
			if (hasRecords)
				this.Sections.Add(this.ParentTableDescriptor.CreateRecordsDetails(this, fields));
			else
				this.Sections.Add(this.ParentTableDescriptor.CreateGroupsDetails(this, fields));
			this.Sections.Add(this.ParentTableDescriptor.CreateSummarySection(this));
		}

		public override bool IsChildVisible(Element el)
		{
			if (el is CaptionSection)
			{
				return true;
			}
			else if (el is DetailsSection)
			{
				return this.IsExpanded;
			}
			else if (el is GridSummarySection)
			{
				return this.IsExpanded;
			}
			return true;
		}
	}

}
