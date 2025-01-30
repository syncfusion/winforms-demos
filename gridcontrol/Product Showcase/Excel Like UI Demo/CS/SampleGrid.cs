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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

using Syncfusion.ComponentModel;
using Syncfusion.Drawing;
using Syncfusion.Styles;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.GridHelperClasses;

namespace ExcelLikeUI
{
	/// <summary>
	/// SampleGridModel for Workbook/Worksheet support (see MenuAction.NewWorkbookFile)
	/// </summary>
	public class SampleGridModel : GridModel, ICreateControl
    {
        #region [Override Methods]
        public override Control CreateControl()
		{
			GridControlBase grid = new SampleGrid(this);            
			grid.FillSplitterPane = true;
			return grid;
        }
        #endregion
    }

	/// <summary>
	///    A derived grid component class.
	/// </summary>
	public class SampleGrid : GridControl
    {
        #region [Constructor]
        public SampleGrid()
			: this(null)
		{
		}
		
		public SampleGrid(GridModel model)
			: base(model)
		{
			this.FillSplitterPane = true;
			// transparent
			bool alphablending = false;
			if (alphablending)
			{
				this.SupportsTransparentBackColor = true;
				this.BackColor = Color.FromArgb(99, Color.White );
			}
			else
			{
				this.BackColor = Color.White;
				this.ForeColor = SystemColors.WindowText;
			}
			this.VerticalThumbTrack = false;
			this.VerticalScrollTips = true;
			this.HorizontalThumbTrack = true;
			this.HorizontalScrollTips = true;			
			
			//Set properties to get the XP flat look
            this.ThemesEnabled = true;
			this.Properties.Buttons3D = false;
			this.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            this.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.Model.Options.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
			GridStyleInfo style = new GridStyleInfo();
			GridBorder gb = new GridBorder(GridBorderStyle.Solid,SystemColors.ControlDark);
			style.Borders.Bottom = style.Borders.Right = gb;

            this.BaseStylesMap["Header"].StyleInfo.BackColor = Color.White;
            this.BaseStylesMap["Header"].StyleInfo.Font.Facename = "Segoe UI";

            this.Model.Options.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
			this.Properties.MarkColHeader=true;
			this.Properties.MarkRowHeader=true;
			this.TableStyle.Font.Facename="Segoe UI";
			this.TableStyle.Font.Size=10;
            this.QueryCellInfo += new GridQueryCellInfoEventHandler(SampleGrid_QueryCellInfo);
		}
        #endregion

        #region [Events]
        void SampleGrid_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            GridBorder gb = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(158, 182, 206));
            if (e.Style.CellType == GridCellTypeName.Header)
            {
                e.Style.Borders.Bottom = e.Style.Borders.Right = gb;
            }
        }
        #endregion

        #region [Override Methods]
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            this.QueryCellInfo -= new GridQueryCellInfoEventHandler(SampleGrid_QueryCellInfo);
        }

		public override void Initialize()
		{
			base.Initialize();
			this.TopRowIndex = InternalGetHeaderRows()+1;
			this.LeftColIndex = InternalGetHeaderCols()+1;
			this.AllowDrop = true;

            this.ExcelLikeCurrentCell = true;
            ExcelSelectionMarkerMouseController excelMarker = new ExcelSelectionMarkerMouseController(this);
            this.MouseControllerDispatcher.Add(excelMarker);			

			//Make sure there is a current cell
			this.CurrentCell.Activate(1,1,GridSetCurrentCellOptions.ScrollInView);
		}
        #endregion 

        #region [Methods]
        public static void SetupGridModel(GridModel model)
        {
            GridFactoryProvider.Init(new GridCellModelFactory());
            model.BeginInit();
            //setting properties.
            GridFormulaCellRenderer.ForceEditWhenActivated = false;
            model.RowCount = 100;
            model.ColCount = 100;
            model.Rows.DefaultSize = 19;
            model.Cols.DefaultSize = 65;
            model.RowHeights[0] = 21;
            model.ColWidths[0] = 35;
            model.Options.ControllerOptions = GridControllerOptions.All | GridControllerOptions.ExcelLikeSelection;
            model.TableStyle.CellType = "FormulaCell";
            model.Options.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell;
            model.CommandStack.Enabled = true;
            model.CellModels.Add("LinkLabel", new LinkLabelCellModel(model));
            model.EndInit();
        }
        #endregion
    }
}