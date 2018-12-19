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
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

using Syncfusion.Samples.GridPad;
using Syncfusion.Styles;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Drawing;

namespace Syncfusion.Samples.GridPad.Actions
{
	public class ExitProgram : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
			MainWindow.Close();
		}
	}

	public class Find : GridPadBasicAction
	{
		SampleGrid grid = null;

		public override void InvokeAction(object sender, EventArgs e)
		{
			grid = ActiveGrid as SampleGrid;
			if (grid != null)
			{
				GridFindReplaceDialog frDialog = GridFindReplaceDialog.Instance;
				frDialog.SetState(grid.GridFindReplaceDialogSink, "", false);
				frDialog.Show();
			}
		}
	}                                 
	
	public class FindNext : GridPadBasicAction
	{
		SampleGrid grid = null;

		public override void InvokeAction(object sender, EventArgs e)
		{
			grid = ActiveGrid as SampleGrid;
			if (grid != null)
			{
				GridFindReplaceDialog frDialog = GridFindReplaceDialog.Instance;
				frDialog.FindNext();
			}
		}
	}                                 
	
	public class Replace : GridPadBasicAction
	{
		SampleGrid grid = null;

		public override void InvokeAction(object sender, EventArgs e)
		{
			grid = ActiveGrid as SampleGrid;
			if (grid != null)
			{
				GridFindReplaceDialog frDialog = GridFindReplaceDialog.Instance;
				frDialog.SetState(grid.GridFindReplaceDialogSink, "", true);
				frDialog.Show();
			}
		}
	}                                 
	
    public class PrintPreviewFile : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
            {
                try 
                {
                    GridPrintDocument pd = new GridPrintDocument(grid, true); //Assumes the default printer


                    if (PrinterSettings.storedPageSettings != null) 
                    {
                        pd.DefaultPageSettings = PrinterSettings.storedPageSettings ;
                    }

                    PrintPreviewDialog dlg = new PrintPreviewDialog() ;
                    dlg.Document = pd;
                    dlg.ShowDialog();
                } 
                catch(Exception ex) 
                { 
                    MessageBox.Show("An error occurred attempting to preview the file to print - " + ex.Message);
                }
            }
        }
    }

    public class PrintFile : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
            {
                try 
                {
                    GridPrintDocument pd = new GridPrintDocument(grid); //Assumes the default printer

                    if (PrinterSettings.storedPageSettings != null) 
                    {
                        pd.DefaultPageSettings = PrinterSettings.storedPageSettings ;
                    }
           
                    PrintDialog dlg = new PrintDialog() ;
                    dlg.Document = pd;
                    dlg.AllowSelection = true;
                    dlg.AllowSomePages = true;
                    DialogResult result = dlg.ShowDialog();
           
                    if (result == DialogResult.OK) 
                    {
                        pd.Print();
                    }
                }
                catch(Exception ex) 
                { 
                    MessageBox.Show("An error occurred attempting to preview the file to print - " + ex.Message);
                }
            }
        }
    }

    public class PrinterSettings : GridPadBasicAction
    {
        public static PageSettings storedPageSettings = null ;

        public override void InvokeAction(object sender, EventArgs e)
        {
            try 
            {
                PageSetupDialog psDlg = new PageSetupDialog() ;
            
                if (storedPageSettings == null) 
                {
                    storedPageSettings =  new PageSettings();
                }

                psDlg.PageSettings = storedPageSettings ;
                psDlg.ShowDialog();
            
            } 
            catch(Exception ex) 
            { 
                MessageBox.Show("An error occurred - " + ex.Message);
            }
        }
    }


    public class BlackWhiteGrid : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
            {
                grid.Model.Properties.BlackWhite = !grid.Model.Properties.BlackWhite;
                grid.Model.Refresh();
            }
        }
    }

	public class AlphaBlending : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
			GridControlBase grid = ActiveGrid;
			if (grid != null)
			{
				grid.SupportsTransparentBackColor = !grid.SupportsTransparentBackColor;
				if (grid.SupportsTransparentBackColor)
					grid.Model.TableStyle.Interior = new BrushInfo(Color.FromArgb(50, Color.White));
				else
					grid.Model.TableStyle.ResetInterior();
				grid.Model.Options.TransparentBackground = !grid.SupportsTransparentBackColor && grid.BackgroundImage == null;
			}
		}
	}

	public class TransparentBackground : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
			GridControlBase grid = ActiveGrid;
			if (grid != null)
			{
				grid.Model.Options.TransparentBackground = !grid.Model.Options.TransparentBackground;
			}
		}
	}

	public class ResetTransparency : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
			GridControlBase grid = ActiveGrid;
			if (grid != null)
			{
				grid.Model.Options.TransparentBackground = false;
				grid.SupportsTransparentBackColor = false;
				grid.BackgroundImage = null;
				grid.BackColor = Color.White;
			}
		}
	}

	public class BackgroundImage : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
			GridControlBase grid = ActiveGrid;
			if (grid != null)
			{
				Control c = grid;
				// does not work for SplitterControl right now
				if (grid.Parent is SplitterControl)
					c = grid.Parent;
				if (c.BackgroundImage == null)
				{
					// (grid.TransparentBackground completely disables background drawing for all cells
					// whereas SupportsTransparentBackColor = true  together with TransparentBackground
					// lets me do alphablending).

					Type type = typeof(Bitmap);
					System.IO.Stream stream = typeof(SampleGrid).Module.Assembly.GetManifestResourceStream(ApplicationMain.manifestNamespace + "logo_800_edf0f7.jpg");
					Bitmap bm = new Bitmap(stream);
					c.BackgroundImage = bm;
				}
				else
				{
					c.BackgroundImage = null;
				}
			}
		}
	}

    
            
    public class FormatBaseStylesMap : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
            {
				GridBaseStylesMap.ShowGridBaseStylesMapDialog(grid.Model, "BaseStylesMap");
                grid.Model.Refresh();
            }
        }
    }

	public class FormatOptions : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
			GridControlBase grid = ActiveGrid;
			if (grid != null)
			{
				PropertyForm form = new PropertyForm(grid.Model.Options);
				form.ShowDialog();
				grid.Model.Refresh();
			}
		}
	}

	public class FormatProperties : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
			GridControlBase grid = ActiveGrid;
			if (grid != null)
			{
				PropertyForm form = new PropertyForm(grid.Model.Properties);
				form.ShowDialog();
				grid.Model.Refresh();
			}
		}
	}

	public class FormatCells : GridPadBasicAction
    {
		GridStyleInfo style = null;
        GridRangeInfoList ranges = null;
        GridControlBase grid = null;

		public override void InvokeAction(object sender, EventArgs e)
		{
            grid = ActiveGrid;
            if (grid != null)
            {
                grid.Selections.GetSelectedRanges(out ranges, true);
				GetCombinedStyle();

				if (style != null)
				{
					StyleInfoForm form = new StyleInfoForm(style);
					form.ApplyButton.Click += new System.EventHandler (this.applyButton_Click);
					form.Text = "Cells";

					if (form.ShowDialog(MainWindow) == DialogResult.OK)
					{
						Trace.WriteLine(style.ToString("d"));
						ApplyChanges();
					}
				}
			}
		}

        protected void applyButton_Click (object sender, System.EventArgs e)
        {
            ApplyChanges();
			GetCombinedStyle();
		}

		public void GetCombinedStyle()
		{
			style = grid.Model.GetCombinedStyle(ranges);
		}

        public void ApplyChanges()
        {
            if (grid != null)
            {
                foreach (GridRangeInfo range in ranges)
                {
                    grid.Model.ChangeCells(range, style, StyleModifyType.Changes);
                }
            }
        }            
    }                                 

    public class FontStyleBold : GridPadBasicAction
    {
        public override void InvokeAction(object sender, EventArgs e)
        {
            if (this.ActiveGrid != null)
            {
                GridStyleInfo style = new GridStyleInfo();
                GridCurrentCell cc = this.ActiveGrid.CurrentCell;
                GridControlBase grid = ActiveGrid;
                if (this.ActiveGrid.Model[cc.RowIndex, cc.ColIndex].Font.Bold)
                {
                    style.Font.Bold = false;
                }
                else
                {
                    style.Font.Bold = true;
                }
                ApplyStyle(style);
            }
            //ContainerControl c = MainWindow;
            //while (c != null)
            //{
            //    if (c is SplitterControl)
            //    {
            //        ((SplitterControl) c).ScrollBarColor = Color.Red;
            //        break;
            //    }
            //    c = c.ActiveControl is ContainerControl ? (ContainerControl) c.ActiveControl : null;
            //}
		}
    }                                 
          
    public class FontStyleItalic : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            if (this.ActiveGrid != null)
            {
                GridStyleInfo style = new GridStyleInfo();
                GridCurrentCell cc = this.ActiveGrid.CurrentCell;
                if (this.ActiveGrid.Model[cc.RowIndex, cc.ColIndex].Font.Italic)
                {
                    style.Font.Italic = false;
                }
                else
                {

                    style.Font.Italic = true;
                }
                ApplyStyle(style);
            } 
		}
    }                                 
          
    public class FontStyleUnderline : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            if(this.ActiveGrid!=null)
            {
                GridStyleInfo style = new GridStyleInfo();
                GridCurrentCell cc = this.ActiveGrid.CurrentCell;
                if (this.ActiveGrid.Model[cc.RowIndex, cc.ColIndex].Font.Underline)
                {
                    style.Font.Underline = false;
                }
                else
                {
                    style.Font.Underline = true;
                }
                ApplyStyle(style);
            }
          
		}
    }                                 
          
    public class AlignLeft : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridStyleInfo style = new GridStyleInfo();
            style.HorizontalAlignment = GridHorizontalAlignment.Left;
            ApplyStyle(style);
		}
    }                                 

    public class AlignCenter : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridStyleInfo style = new GridStyleInfo();
            style.HorizontalAlignment = GridHorizontalAlignment.Center;
            ApplyStyle(style);
		}
    }                                 

    public class AlignRight : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridStyleInfo style = new GridStyleInfo();
            style.HorizontalAlignment = GridHorizontalAlignment.Right;
            ApplyStyle(style);
		}
    }                                 

    public class ResizeColumns : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
            {
                foreach (GridRangeInfo range in grid.Model.Selections)
                {
                    grid.Model.ColWidths.ResizeToFit(range, GridResizeToFitOptions.ResizeCoveredCells);
                }
            }
        }
    }
                    
	public class ResizeRows : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
            {
                foreach (GridRangeInfo range in grid.Model.Selections)
                {
                    grid.Model.RowHeights.ResizeToFit(range, GridResizeToFitOptions.ResizeCoveredCells);
                }
            }
        }
    }

    public class RemoveRows : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
        {
            GridControlBase grid = ActiveGrid;
            if (grid != null)
            {
                GridRangeInfoList ranges = grid.Model.Selections.Ranges.GetRowRanges(GridRangeInfoType.Rows);
                if (ranges.Count == 0)
                    return;

                grid.Model.CommandStack.BeginTrans("Remove Rows");

                foreach (GridRangeInfo range in ranges)
                    grid.Model.Rows.RemoveRange(range.Top, range.Bottom);

                grid.Model.CommandStack.CommitTrans();
            }
        }
    }

    public class RemoveCols : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
        {
            GridControlBase grid = ActiveGrid;
            if (grid != null)
            {
                GridRangeInfoList ranges = grid.Model.Selections.Ranges.GetColRanges(GridRangeInfoType.Cols);
                if (ranges.Count == 0)
                    return;

                grid.Model.CommandStack.BeginTrans("Remove Columns");

                foreach (GridRangeInfo range in ranges)
                    grid.Model.Cols.RemoveRange(range.Left, range.Right);

                grid.Model.CommandStack.CommitTrans();
            }
        }
    }

    public class InsertRows : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
        {
            GridControlBase grid = ActiveGrid;
            if (grid != null)
            {
                int rowIndex, colIndex;
                if (grid.CurrentCell.GetCurrentCell(out rowIndex, out colIndex))
                {
                    grid.Model.Rows.InsertRange(rowIndex, 1, null);
                }
            }
        }
    }

    public class InsertCols : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
        {
            GridControlBase grid = ActiveGrid;
            if (grid != null)
            {
                int rowIndex, colIndex;
                if (grid.CurrentCell.GetCurrentCell(out rowIndex, out colIndex))
                {
					grid.Model.Cols.InsertRange(colIndex, 1, null);
				}
            }
        }
    }

    public class CoverCell : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
            {
                GridRangeInfo range = grid.Model.Selections.Ranges.ActiveRange;
                grid.Model.CoveredRanges.Add(range);
            }
        }
    }
    
    public class ResetCover : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
            {
                GridRangeInfoList rl;
                if (grid.Selections.GetSelectedRanges(out rl, true))
                {
                    GridRangeInfo range = rl.ActiveRange;
                    if (!range.IsEmpty)
                        range = grid.Model.CoveredRanges.Merge(range);
                    grid.Model.CoveredRanges.Remove(range);
                }
            }
        }
    }

    public class FreezeColumns : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
                grid.Model.Cols.FreezeSelection();
        }
    }

    public class ReleaseColumns : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
				grid.Model.Cols.RestoreFrozen();
        }
    }

    public class FreezeRows : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
				grid.Model.Rows.FreezeSelection();
        }
    }

    public class ReleaseRows : GridPadBasicAction
    {
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
				grid.Model.Rows.RestoreFrozen();
        }
    }

    
        
    
    public class NewFile : GridPadBasicAction
	{
        int windowCount = 0;
		public override void InvokeAction(object sender, EventArgs e)
		{
            windowCount++;
            GridFrame doc = new GridFrame();
            doc.Text = "Document " + windowCount.ToString();
            doc.MdiParent = MainWindow;
			
			doc.Show();
			
			GridPadBasicAction ba = new AlphaBlending();
			ba.MainWindow = MainWindow;
			ba.InvokeAction(sender, e);

			ba = new BackgroundImage();
			ba.MainWindow = MainWindow;
			ba.InvokeAction(sender, e);

		}
	}

	public class NewDialog : GridPadBasicAction
	{
		int windowCount = 0;
		public override void InvokeAction(object sender, EventArgs e)
		{
			windowCount++;
			GridDialog doc = new GridDialog();
			doc.Text = "Document " + windowCount.ToString();
			doc.MdiParent = MainWindow;
			doc.Show();

		}
	}

	public class NewWorkbookFile : GridPadBasicAction
	{
        int windowCount = 0;
		WorkbookModel workbook;
		public override void InvokeAction(object sender, EventArgs e)
		{
            windowCount++;
			workbook = new WorkbookModel("Workbook");
			GridModel sheet1 = new SampleGridModel();
			SampleGrid.SetupGridModel(sheet1);
            sheet1.EnableGridListControlInComboBox = false;
			GridModel sheet2 = new SampleGridModel();
			SampleGrid.SetupGridModel(sheet2);
            sheet2.EnableGridListControlInComboBox=false;

			workbook.Worksheets.Add(new WorksheetModel(workbook, "Sheet 1", sheet1));
			workbook.Worksheets.Add(new WorksheetModel(workbook, "Sheet 2", sheet2));

            WorkbookForm doc = new WorkbookForm(workbook);
			doc.ThemesEnabled = true;
			doc.Text = workbook.Name + windowCount.ToString();
            doc.MdiParent = MainWindow;
            doc.Show();
		}
	}

    public class NewSplitterFile : GridPadBasicAction
	{
        int windowCount = 0;
		public override void InvokeAction(object sender, EventArgs e)
		{
            windowCount++;
            SplitterFrame doc = new SplitterFrame();
            doc.Text = "Splitter " + windowCount.ToString();
            doc.MdiParent = MainWindow;
            doc.Show();
		}
	}

    public class NewRecordFile : GridPadBasicAction
	{
        int windowCount = 0;
		public override void InvokeAction(object sender, EventArgs e)
		{
            windowCount++;
            RecordFrame doc = new RecordFrame();
            doc.Text = "Record " + windowCount.ToString();
            doc.MdiParent = MainWindow;
            doc.Show();
		}
	}
	
    public class OpenFile : GridPadBasicAction
	{
		
		public override void InvokeAction(object sender, EventArgs e)
		{
			OpenFileDialog fdiag  = new OpenFileDialog();
			fdiag.AddExtension    = true;
			fdiag.Filter          = "EssentialGrid files (*.obg)|*.obg"; 
			fdiag.Multiselect     = true;
			fdiag.CheckFileExists = true;
            fdiag.FileName = "Untitled";
			
			if (fdiag.ShowDialog() == DialogResult.OK) {
				foreach (String name in fdiag.FileNames) {
                    GridFrame doc = new GridFrame(GridModel.LoadBinary(name));
                    doc.MdiParent = MainWindow;
                    doc.Text = name;
                    doc.Show();
					//Options.AddLastFile(name);
				}
				//MainWindow.UpdateLastFiles();
			}
			fdiag.Dispose();
		}
	}
	
	public class CloseFile : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
            Form form = MainWindow.ActiveControl is Form ? (Form) MainWindow.ActiveControl : null;
            if (form != null)
                form.Close();
		}
	}
	
	public class CloseAll : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
			foreach (Form form in MainWindow.MdiChildren) {
				form.Close();
			}
		}
	}
	
    public class SaveFile : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
			GridControlBase grid = ActiveGrid;
            if (grid != null)
            {
                GridModel model = grid.Model;
                if (model.IsUntitled)
                {
                    SaveFileAs sfa = new SaveFileAs();
                    sfa.MainWindow = MainWindow;
                    sfa.InvokeAction(sender, e);
                }
                else
                    model.SaveBinary();
            }
            grid.Model.EnableGridListControlInComboBox = false;
		}
	}
	
	
	public class SaveFileAs : GridPadBasicAction
	{
		SaveFileDialog fdiag = null;
		public override void InvokeAction(object sender, EventArgs e)
		{
			GridControlBase grid = ActiveGrid;
			if (grid != null) {
                GridModel model = grid.Model;
				if (fdiag == null) {
					fdiag = new SaveFileDialog();
					fdiag.OverwritePrompt = true;
					fdiag.AddExtension    = true;
                   fdiag.FileName = "Untitled";
                   fdiag.Filter = "EssentialGrid files (*.obg)|*.obg";
				}
				
				if (fdiag.ShowDialog() == DialogResult.OK) {
					model.SaveBinary(fdiag.FileName);
					MessageBox.Show(fdiag.FileName, "File saved", MessageBoxButtons.OK);
                    grid.Parent.Text = fdiag.FileName;
				}
			}
		}
	}

	public class SaveAll : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
			foreach (Form form in MainWindow.MdiChildren) {
                GridControlBase grid = GetGrid(form);
                if (grid != null)
                {
                    GridModel model = grid.Model;
				    if (model.IsUntitled) {
				    	SaveFileAs sfa = new SaveFileAs();
				    	sfa.MainWindow = MainWindow;
				    	sfa.InvokeAction(sender, e);
				    }
				    else
				    	model.SaveBinary();
                }
			}
		}
	}

	////////////////// Edit Menu
	public class UndoAction : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
                grid.Model.CommandStack.Undo();
		}
	}
	
	public class RedoAction : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
                grid.Model.CommandStack.Redo();
		}
	}
	
    public class CutAction : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
                grid.Model.CutPaste.Cut();
		}
	}
	
	public class CopyAction : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
                grid.Model.CutPaste.Copy();
		}
	}
	
	public class PasteAction : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
                grid.Model.CutPaste.Paste();
		}
	}
		
	public class DeleteAction : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
                grid.Model.Clear(true);
		}
	}
	
	public class SelectAllAction : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
            {
                grid.Selections.Clear();
                grid.Selections.Add(GridRangeInfo.Table());
            }
		}
	}

	public class ExcelLikeSelection : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
            GridControlBase grid = ActiveGrid;
            if (grid != null)
            {
				grid.Model.BeginUpdate(BeginUpdateOptions.None);
                bool bSelect = !grid.Model.Options.ExcelLikeCurrentCell;
                grid.Model.Options.ExcelLikeCurrentCell = bSelect;
                grid.Model.Options.ExcelLikeSelectionFrame = bSelect;
				GridRangeInfo range = grid.Selections.Ranges.ActiveRange;
				if (!range.IsEmpty)
				{
					grid.CurrentCell.ConfirmChanges();
					grid.CurrentCell.Deactivate(true);
					grid.CurrentCell.MoveTo(range.Top, range.Left, GridSetCurrentCellOptions.NoSelectRange);
				}
				grid.Model.EndUpdate(false);
				grid.Model.Refresh();
			}
		}
	}
	

	///////// Window Menu
    public class WindowNew : GridPadBasicAction
    {
        public override void InvokeAction(object sender, EventArgs e)
        {
			if (MainWindow != null)
			{
				if (MainWindow.ActiveControl is WorkbookForm)
				{
					WorkbookForm form = (WorkbookForm) MainWindow.ActiveControl;
					form = new WorkbookForm(form.WorkbookView.Workbook);
					form.MdiParent = MainWindow;
					form.Show();
					return;
				}
				else
				{
					GridControlBase grid = ActiveGrid;
					if (grid != null) 
					{
						GridModel model = grid.Model;
						GridFrame doc = new GridFrame(model);
						doc.Text =  ((Form) MainWindow.ActiveControl).Text + ":2";
						doc.MdiParent = MainWindow;
						doc.Show();
					}
				}
			}
        }
    }

    public class WindowCascade : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
			MainWindow.LayoutMdi(MdiLayout.Cascade);
		}
	}
		
	public class WindowTileHorizontal : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
			MainWindow.LayoutMdi(MdiLayout.TileHorizontal);
		}
	}
		
	public class WindowTileVertical : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
			MainWindow.LayoutMdi(MdiLayout.TileVertical);
		}
	}
		
	public class WindowArrangeIcons : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
			MainWindow.LayoutMdi(MdiLayout.ArrangeIcons);
		}
	}

	public class AboutObjectGrid : GridPadBasicAction
	{
		public override void InvokeAction(object sender, EventArgs e)
		{
            DemoCommon.AboutForm abtform = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            abtform.ShowDialog();
		}
	}
}

