using System;
using System.ComponentModel;

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Grid;

namespace ContentCellDemo
{
	/// <summary>
	/// Summary description for ChartGridSeriesModel.
	/// </summary>
	/// 

	public class ChartGridSeriesModel : IChartSeriesModel
	{
		private GridRangeInfo rangeInfo;
		private GridModel grid;
		private int colIndex;
		private ListChangedEventHandler changedHandler;

		public ChartGridSeriesModel(GridModel grid, GridRangeInfo rangeInfo, int colIndex)
		{
			this.grid = grid;
			this.rangeInfo = rangeInfo;	
			this.colIndex = colIndex;
		}

		public int Count 
		{ 
			get
			{
				return this.rangeInfo.Height;
			}
		}
		
		public double GetX(int xIndex)
		{
			//System.Diagnostics.Trace.WriteLine("GetX");
			return xIndex + 1;
		}

        public double[] GetY(int xIndex)
        {
            string value = this.grid[this.rangeInfo.Top + xIndex, this.rangeInfo.Left + this.colIndex].Text;
            if (!string.IsNullOrEmpty(value))
                return new double[] { Convert.ToDouble(value) };
            return new double[] { Convert.ToDouble(0) };
        }

		public event ListChangedEventHandler Changed
		{
			add
			{
				this.changedHandler += value;
			}
			remove
			{
				this.changedHandler -= value;
			}
		}
		
		public bool GetEmpty(int xIndex)
		{
			// TODO:  Add ChartGridSelectionSeriesModel.GetEmpty implementation
			return false;
		}
	}
}