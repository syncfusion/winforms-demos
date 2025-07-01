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
using System.Windows.Forms;

using Syncfusion.Styles;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.InternalMenus;
namespace Syncfusion.Samples.GridPad 
{
	
	/// <summary>
    /// This class is the common base class for actions such as
    /// MenuActions, Editactions or plugins
    /// </summary>
    public abstract class GridPadBasicAction : BasicAction
	{
		//MainWindow    window   = null;
		
		/// <summary>
 	   /// Inheriting actions must overwrite this method, it is called, when the action
 	   /// occurs.
		/// </summary>
		//public abstract void InvokeAction(object sender, EventArgs e);

        public GridControlBase ActiveGrid
        {
            get
            {
                if (MainWindow != null)
                {
					if (MainWindow.ActiveControl is Form)
	                    return GetGrid((Form) MainWindow.ActiveControl);
					else if (MainWindow.ActiveControl != null)
						return GetGrid((Form) MainWindow.ActiveControl.FindForm());
				}
                return null;
            }
        }

		public GridControlBase GetGrid(Form form)
        {
            if (form != null)
            {
                Control control = form.ActiveControl;

                if (control != null)
                {
                    while (control is ContainerControl)
                        control = ((ContainerControl)control).ActiveControl;

                    // Could be a focused textbox
                    if (!(control is GridControlBase))
                        control = control.Parent;

                    if (control is GridControlBase)
                    {
                        GridControlBase grid = (GridControlBase)control;

                        // Active cell ...
                        if (control != null && grid == null)
                        {
                            grid = control.Parent is GridControlBase ? (GridControlBase)grid : null;
                        }
                        return grid;
                    }
                }

            }
            return null;
        }            

        public void ApplyStyle(GridStyleInfo style)
        {
            GridControlBase grid = ActiveGrid;
            if (grid != null)
            {
                GridRangeInfoList ranges;
                grid.Selections.GetSelectedRanges(out ranges, true);
                foreach (GridRangeInfo range in ranges)
                    grid.Model.ChangeCells(range, style, StyleModifyType.Override);
            }
        }            

		public new MainWindow MainWindow {
			get {
				return base.MainWindow as MainWindow;
			}
			set {
				base.MainWindow  = value;
			}
		}
	}
}


