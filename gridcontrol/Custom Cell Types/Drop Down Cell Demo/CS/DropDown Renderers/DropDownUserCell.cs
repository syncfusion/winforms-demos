#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
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
using System.Runtime.Serialization;

using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;


namespace DropDownCellDemo
{
	// The model class is mainly derived to make
	// CreateRenderer return our derived renderer class.
	// Here we add an internal member, ddUser, to hold our UserControl
	// that we want to show in our popup. We set this member
	// in the constructor call. 

	public class DropDownUserCellModel : GridStaticCellModel
	{
		internal DropDownUser ddUser;

		protected DropDownUserCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			ButtonBarSize = new Size(14, 14);
		}

		public DropDownUserCellModel(GridModel grid, DropDownUser ddUser)
			: base(grid)
		{
			this.ddUser = ddUser;
			ButtonBarSize = new Size(14, 14);
		}
	
		//note that this method create our new derived renderer
		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new DropDownUserCellRenderer(control, this);
		}
	}

	//The renderer class. The constructor caches a reference to the UserControl,
	//adds the button, disables the text box from being typed into, and 
	//subscribes to Save and Cancel events on teh User Control.

	public class DropDownUserCellRenderer: GridStaticCellRenderer
	{
		internal DropDownUser ddUser;

		public DropDownUserCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
		{
			this.ddUser = ((DropDownUserCellModel)this.Model).ddUser;
			this.ddUser.Visible = false;
			DropDownPart = new GridDropDownCellImp(this);
			DropDownButton = new GridCellComboBoxButton(this);

			//hook the usercontrol save and cancel events...
			this.ddUser.UserControlSave += new EventHandler(user_Save);
			this.ddUser.UserControlCancel += new EventHandler(user_Cancel);
			
		}

		public new GridDropDownContainer DropDownContainer
		{
			get{return (GridDropDownContainer)base.DropDownContainer;}
		}
	
		//here we add the user control to the popup window.
		protected  override void InitializeDropDownContainer()
		{
			base.InitializeDropDownContainer();

			if (this.DropDownContainer != null)
			{
				this.DropDownContainer.Controls.Add(this.ddUser);
			}
		}

		//used to setup the dropdown before it is shown. The RaiseCurrentCellShowingDropDown
		//code is commeted out as it requires teh 2.0 code base. This commented code allow
		//for an event that might cancel teh drop or set its size.
        public override void DropDownContainerShowingDropDown(object sender, CancelEventArgs e)
		{
			GridCurrentCell cc = this.Grid.CurrentCell;

////			Size size = ddUser.Size;
////			GridCurrentCellShowingDropDownEventArgs ce = new GridCurrentCellShowingDropDownEventArgs(size);
////			Grid.RaiseCurrentCellShowingDropDown(ce);
////			if (ce.Cancel)
////			{
////				e.Cancel = true;
////				return;
////			}
////			ddUser.Size = ce.Size;
///
			this.DropDownContainer.Size = ddUser.Size;
			this.ddUser.SetValuesFromString(this.ControlText);
			ddUser.Visible = true;
		}

		//used to change teh ControlValue if dropdown was closed with Done.
		public override void DropDownContainerCloseDropDown(object sender, PopupClosedEventArgs e)  
		{
			if (e.PopupCloseType == PopupCloseType.Done)
			{
				if (this.NotifyCurrentCellChanging())
				{
					ControlValue = this.ddUser.GetValuesToString();
					this.NotifyCurrentCellChanged();
				}
			}
			Grid.InvalidateRange(GridRangeInfo.Cell(RowIndex, ColIndex), GridRangeOptions.MergeCoveredCells); // Merge all cells

			base.DropDownContainerCloseDropDown(sender, e);
		}

		//handler for the user control Save event
		private void user_Save(object sender, EventArgs e)
		{
			// closethe dropdown with a Done setting
			this.Grid.CurrentCell.CloseDropDown(Syncfusion.Windows.Forms.PopupCloseType.Done);
		}

		//handler for the user control Cancel event
		private void user_Cancel(object sender, EventArgs e)
		{
			// close the dropdown with a Canceled setting
			this.Grid.CurrentCell.CloseDropDown(Syncfusion.Windows.Forms.PopupCloseType.Canceled);
		}
	
		//used to move the grid value into the cell control
		protected override void OnInitialize(int rowIndex, int colIndex)
		{
			base.OnInitialize (rowIndex, colIndex);
			ddUser.SetValuesFromString(this.Grid.Model[rowIndex, colIndex].Text);
		}
	
		//used to save the cell control value back to the grid
		protected override bool OnSaveChanges()
		{
			string s = this.ddUser.GetValuesToString();
			this.Grid.Model[this.RowIndex, this.ColIndex].Text = s;
			return true;
		}
	}
}
