#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace ComboboxCells
{
    public partial class EventTracer : UserControl
    {
        #region "API Definition"

        public string eventtype = "";
        public string gridCheck= "";
        public string mouseCheck = "";
        public string cellCheck = "";
        Timer t;
        DataTable dt;

        #endregion

        #region "Constructor"

        public EventTracer()
        {
            dt = new DataTable();
            dt.Columns.Add("Event");
            dt.Columns.Add("Description");
            t = new Timer();
            t.Interval = 10;
            t.Enabled = true;
            t.Start();
            t.Tick += new EventHandler(t_Tick);
            InitializeComponent();
            output.HScrollPixel = true;
        }

        #endregion

        #region "Properties And Methods"
        bool _enabled = false;
		new public bool Enabled
		{
			get
			{
				return _enabled;
			}
			set
			{
				_enabled = value;
			}
		}
        int pcount = 0;
        public void clear()
        {
            this.output.RowCount = 0;
            this.dt.Rows.Clear();
        }
        void t_Tick(object sender, EventArgs e)
        {
            if (dt.Rows.Count!= pcount)
            {
                pcount = dt.Rows.Count;
                this.output.RowCount = dt.Rows.Count;
                this.output.PopulateValues(GridRangeInfo.Cells(1, 1, dt.Rows.Count, dt.Columns.Count), dt);
                this.output.ScrollCellInView(GridRangeInfo.Row(dt.Rows.Count));
                this.output.CurrentCell.MoveTo(GridRangeInfo.Row(dt.Rows.Count));
                this.output.Invalidate();
                this.output.CurrentCellActivating += new GridCurrentCellActivatingEventHandler(output_CurrentCellActivating);
            }
        }

        void output_CurrentCellActivating(object sender, GridCurrentCellActivatingEventArgs e)
        {
            e.Cancel = true;
        }

        public void AppendOutput(string name, EventArgs e)
        {
            if (gridCheck != "" || cellCheck!="" || mouseCheck!="")
            {
                if (eventtype.Trim().Equals(gridCheck) || eventtype.Trim().Equals(mouseCheck) || eventtype.Trim().Equals(cellCheck))
                {
                    //Console.WriteLine(eventtype.ToString() + " : " + check.ToString());

                    string s1 = "";
                    string s2 = "";

                    s1 = name;
                    s2 = e.ToString();

                    if (s1.Length > 0 && s2.Length > 0)
                    {
                        if (dt.Rows.Count < 1000)
                        {
                            DataRow dr = dt.NewRow();
                            dr[0] = s1;
                            dr[1] = s2;
                            dt.Rows.Add(dr);
                        }
                        else if (dt.Rows.Count == 1000)
                        {
                            for (int i = 0; i < 100; i++)
                                dt.Rows.RemoveAt(i);
                            DataRow dr = dt.NewRow();
                            dr[0] = s1;
                            dr[1] = s2;
                            dt.Rows.Add(dr);
                        }
                    }
                }
            }
        }

        #endregion
    }
}