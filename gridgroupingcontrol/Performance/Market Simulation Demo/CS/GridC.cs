#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Grid;
using System.Data;
using System.Drawing;
using Syncfusion.Grouping;

using Syncfusion.Windows.Forms.Grid.Grouping;
using System.Windows.Forms;
using System.ComponentModel;

#if !SyncfusionFramework2_0
namespace System.Collections.Generic
{
}
#endif

namespace MarketSimulation
{
    class GridC : GridGroupingControl
    {
        public void SetStyle()
        {
            this.BlinkTime = 700;
//            this.UpdateDisplayFrequency = 0; // manually call Update for grid.
//            this.UpdateDisplayFrequency = 1; // paint after each change.
            this.UpdateDisplayFrequency = 50; // paint every 50 ms. (but scroll window will force immediate paint ...)
			this.SortPositionChangedBehavior = GridListChangedInsertRemoveBehavior.ScrollWithImmediateUpdate;
			this.InsertRemoveBehavior = GridListChangedInsertRemoveBehavior.ScrollWithImmediateUpdate;
			this.BindToCurrencyManager = false;
			this.UseDefaultsForFasterDrawing = true;

            ShowNavigationBar = false;
            ShowGroupDropArea = true;
            TopLevelGroupOptions.ShowCaption = false;
			TableControl.DpiAware = true;

            //TableDescriptor.ChildGroupOptions.ShowCaptionSummaryCells = true;
            TableDescriptor.ChildGroupOptions.ShowSummaries = false;

            // Fonts
            this.Font = new Font("Segoe UI", (float)8.5, FontStyle.Regular);
            GridGroupDropArea.Font = this.Font;

            Appearance.AnyRecordFieldCell.BackColor = Color.FromArgb(255, 245, 227);
            Appearance.ColumnHeaderCell.Font.Bold = true;

            Appearance.GroupCaptionCell.BackColor = Appearance.AnyRecordFieldCell.BackColor;
            Appearance.GroupCaptionCell.TextColor = Appearance.AnyRecordFieldCell.TextColor;
            Appearance.GroupCaptionCell.Borders.Top = new GridBorder(GridBorderStyle.Standard);
            Appearance.GroupCaptionCell.CellType = "Static";
            
            // General Table Options
            TableOptions.CaptionRowHeight = TableOptions.RecordRowHeight;
            TableOptions.IndentWidth = 16;
            TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.HideCurrentCell;
            TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            TableOptions.ShowRowHeader = false;            

            // Can't add rows
            ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            TopLevelGroupOptions.ShowCaption = false;
            Appearance.AnyCell.Font.Facename = "Segoe UI";            
			Engine.QueryAddColumn += new GridQueryAddColumnEventHandler(Engine_QueryAddColumn);
        }



        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #region SetBoundList

        public static DataTable CreateDataTable(OrderAgreementListC ocList)
        {
            DataTable table = new DataTable();

            if (ocList == null)
                return table;

            OrderAgreementC record;

            if (ocList.Count == 0)
            {
                record = new OrderAgreementC();
            }
            else
            {
                record = ocList[0];
            }

            TypeSystemC.FidEnum[] recordKeys = new TypeSystemC.FidEnum[record.Count];
            record.Keys.CopyTo(recordKeys, 0);

#if SyncfusionFramework2_0
            foreach (TypeSystemC.FidEnum fid in recordKeys)
            {
#else
            for (int n = recordKeys.Length-1; n >= 0; n--)
            {
                TypeSystemC.FidEnum fid = recordKeys[n];
#endif
            //foreach (TypeSystemC.FidEnum fid in record.Keys)
            //{
                string name = TypeSystemC.FidName(fid);
                Type type = TypeSystemC.FidType(fid);

                DataColumn col = new DataColumn(name, type);
                table.Columns.Add(col);
            }

            foreach (OrderAgreementC oc in ocList)
            {   
                object[] row = new object[oc.Count];

#if SyncfusionFramework2_0
                int i = 0;
                foreach (object o in oc.Values)
                {
                    row[i++] = o;
                }
#else
                int i = oc.Count-1;
                foreach (object o in oc.Values)
                {
                    row[i--] = o;
                }
#endif

                table.Rows.Add(row);
            }

            return table;
        }

		#endregion

		private void Engine_QueryAddColumn(object sender, GridQueryAddColumnEventArgs e)
		{
			e.GridColumn.AllowBlink = true;
		}
	}
}

