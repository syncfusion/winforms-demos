#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.Text;
using System.Diagnostics;

namespace SummaryInCaption
{


    /// <summary>
    /// Provides a diagnostic utility for measuring performance. 
    /// </summary>
    /// <example>The following example display a message box with performance info.
    /// <code lang="C#">
    /// 		private void button1_Click(object sender, System.EventArgs e)
    /// 		{
    /// 			int rows = (int) this.numericUpDown1.Value;
    /// 
    /// 			this.gridControl1.theData = new VirtGrid.VirtData(rows, 20);
    /// 			this.gridControl1.Refresh();
    /// 
    /// 			using (MeasureTime.Measure("gridControl1.TopRowIndex = 500000"))
    /// 			{
    /// 				this.gridControl1.TopRowIndex = 5000000;
    /// 			}
    /// 
    /// 			MessageBox.Show(MeasureTime.DumpTimes());
    /// 		}
    /// </code>
    /// </example>
    public class MeasureTime : IDisposable
    {
        static Hashtable times = new Hashtable();
        #region Externals
        [System.Runtime.InteropServices.DllImport("Kernel32.dll")]
        private static extern int QueryPerformanceFrequency(ref Int64 lpFrequency);

        [System.Runtime.InteropServices.DllImport("Kernel32.dll")]
        private static extern int QueryPerformanceCounter(ref Int64 lpPerformanceCount);
        #endregion


        /// <summary>
        /// Returns the time since Reset in microseconds.
        /// </summary>
        public Int64 TickCount
        {
            get
            {
                Int64 m_LastCount = 0;
                QueryPerformanceCounter(ref m_LastCount);
                return m_LastCount;
            }
        }


        Int64 ticks = 0;
        string id = "";

        MeasureTime(string id)
        {
            this.id = id;
            ticks = TickCount;
        }

        /// <summary>
        ///     Insert this before a code block that should be measured.
        /// </summary>
        public static MeasureTime Measure(string id)
        {
            return new MeasureTime(id);
        }

        /// <summary>
        ///     Ends the code block that should be measured and increments the associated performance counter.
        /// </summary>
        public void Dispose()
        {
            Int64 time = TickCount - ticks;
            if (times.ContainsKey(id))
                times[id] = ((Int64) times[id]) + time;
            else
                times[id] = time;
        }

        private static long GetFrequency()
        {
            long ret = 0;
            if (QueryPerformanceFrequency(ref ret) == 0)
                throw new NotSupportedException("Error while querying the performance counter frequency.");
            return ret;
        }

        /// <summary>
        ///     Prints all performance counters into a string and sorts it by ids. All counters will be reset afterwards.
        /// </summary>
        public static string DumpTimes()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("MeasureTime results:");
            ArrayList al = new ArrayList();
            foreach (DictionaryEntry d in times)
            {
                Int64 value = (Int64) d.Value;
                double t1 = ((double) value) / (double) GetFrequency() * 1000 * 1000;
                string msg = d.Key.ToString();
                StringBuilder s1 = new StringBuilder("\r\n");
                if (t1 < 1000)
                    s1.AppendFormat("{0} Time = {1} us", msg, t1.ToString("F2"));
                else if (t1 < 1000000)
                    s1.AppendFormat("{0} Time = {1} ms", msg, (t1 / 1000).ToString("F2"));
                else
                    s1.AppendFormat("{0} Time = {1} s", msg, (t1 / 1000000).ToString("F2"));
                al.Add(s1.ToString());
            }
            al.Sort();
            foreach (string s in al)
                sb.Append(s);
            times.Clear();
            return sb.ToString();
        }

    }
}
