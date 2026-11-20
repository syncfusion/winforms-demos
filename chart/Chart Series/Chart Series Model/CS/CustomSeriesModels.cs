using System;
using System.ComponentModel;
using Syncfusion.Windows.Forms.Chart;
using System.Collections.Generic;


namespace ChartSeriesModel
{
#region CustomIndexedSeriesModel
    public class CustomIndexedSeriesModel : IChartSeriesIndexedModel
    {

        Data dd = new Data();

        public CustomIndexedSeriesModel()
        {
           // dd.FillData();

        }
        public int Count
        {
            get
            {
                return dd.customData.Count;
            }
        }

        public double[] GetY(int xIndex)
        {
            return new double[] { dd.customData[xIndex].docsGenerated };
        }

        public bool GetEmpty(int index)
        {
            return false;
        }

        public event ListChangedEventHandler Changed;

    }
        #endregion

#region CustomSeriesModel
    public class CustomSeriesModel : IChartSeriesModel
    {
        Data dd = new Data();
        public int Count
        {
            get
            {
                return dd.customData.Count;
            }
        }
        public double GetX(int xIndex)
        {
            return dd.customData[xIndex].testTime.Month;
        }

        public double[] GetY(int xIndex)
        {
            return new double[] { dd.customData[xIndex].docsGenerated };
        }

        public bool GetEmpty(int index)
        {
            return false;
        }

        public event ListChangedEventHandler Changed;
    }
   
        #endregion

#region Data
    public class Data
    {
        public DateTime testTime; // X
        public int docsGenerated; // Y
        public string testLabel; // custom strings for X axis labels. 
        public Data()
        {
            FillData();
        }
        public Data(DateTime TestTime, int DocsGenerated, string TestLabel)
        {
            this.testTime = TestTime;
            this.docsGenerated = DocsGenerated;
            this.testLabel = TestLabel;
        }
        public BindingList<Data> customData;
        public void FillData()
        {
            customData = new BindingList<Data>();
            customData.Add(new Data(new DateTime(2008, 4, 10), 50, "v5.0"));
            customData.Add(new Data(new DateTime(2008, 4, 15), 75, "SP 1"));
            customData.Add(new Data(new DateTime(2008, 5, 20), 85, "SP 2"));
            customData.Add(new Data(new DateTime(2008, 7, 30), 95, "SP 3"));
        }
    }
            #endregion
    
#region LabelModel
    public class IndexedSeriesLabelModel : IChartAxisLabelModel
    {
        Data dd = new Data();
        public ChartAxisLabel GetLabelAt(int index)
        {
            if (index == 0)
            {
                return new ChartAxisLabel("");
            }
            else
            {
                return new ChartAxisLabel("     " + dd.customData[index - 1].testLabel + "\n (" + dd.customData[index - 1].testTime.Month + "/" + dd.customData[index - 1].testTime.Day + "/" + dd.customData[index-1].testTime.Year + ")");
            }
        }

        public int Count
        {
            get
            {
                return dd.customData.Count + 1;
            }
        }
    }

    public class SeriesLabelModel : IChartAxisLabelModel
    {
        private string[] labels;

        public SeriesLabelModel(string[] labels)
        {
            this.labels = labels;
        }

        public ChartAxisLabel GetLabelAt(int index)
        {
            return new ChartAxisLabel(this.labels[index]);
        }

        public int Count
        {
            get
            {
                return this.labels.GetLength(0);
            }
        }
    }
    #endregion

}
  
     






   



 