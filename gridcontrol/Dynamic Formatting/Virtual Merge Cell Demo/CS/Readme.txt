Some Notes:

This sample demonstrates the merge cells feature.

You enable merging rows within a column with 

			Options.MergeCellsMode = GridMergeCellsMode.OnDemandCalculation|GridMergeCellsMode.MergeRowsInColumn;

Then you can specify for individual cells the merge behavior. To make merging the default for all cells do this:

			GridStyleInfo standardStyle = BaseStylesMap["Standard"].StyleInfo;
			standardStyle.MergeCell = GridMergeCellDirection.RowsInColumn;
			
			GridStyleInfo rowHeaderStyle = BaseStylesMap["Row Header"].StyleInfo;
			rowHeaderStyle.MergeCell = GridMergeCellDirection.RowsInColumn;
			
In the sample we are filling the first three columns with virtual data in OnQueryCellInfo. The grid checks which
cells are repeating (OnQueryCanMergeCells determines if cells are to be treated equal) and automatically merges
them on demand.

Changes in the columns are ignored since the value is always calculated in OnQueryCellInfo.

The other columns are regular cells where you can enter data and save them in the regular grid data object. When 
you enter the same value in neighbouring cells in the same column they will automatically merge. When one value
is change they will automatically unmerged.

As a final demonstration there is also some sample code included that shows how you could implement centering
the text within the visible parts of the cell and avoid scrolling the cell contents out of view for large cells.
You can check this out by clicking on the checkbox below.



