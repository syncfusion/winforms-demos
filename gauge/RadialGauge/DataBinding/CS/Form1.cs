#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Syncfusion.WinForms.Controls;

namespace RadialGaugeDemo
{
    public partial class Form1 : SfForm
    {
        DataTable dataTable; Timer t;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataTable = GetDataTable();
            InitiateGrid();
            this.radialGauge1.DataSource = dataTable;
            t = new Timer();
            t.Interval = 10;
            t.Tick += new EventHandler(t_Tick);

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
        }

      

        #region Helpers

        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }
        private void InitiateGrid()
        {
            this.gridGroupingControl1.DataSource = dataTable;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.One;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.None;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.gridGroupingControl1.TableOptions.SelectionBackColor = Color.Gray;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.TableControlCurrentCellStartEditing += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCancelEventHandler(gridGroupingControl1_TableControlCurrentCellStartEditing);
        }

        private DataTable GetDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Patient", typeof(string));
            table.Rows.Add(25, "Indocin", "David");
            table.Rows.Add(50, "Enebrel", "Sam");
            table.Rows.Add(10, "Hydralazine", "Christoff");
            table.Rows.Add(21, "Combivent", "Janet");
            table.Rows.Add(100, "Dilantin", "Melanie");
            table.Rows.Add(25, "Hydralazine", "Christoff");
            table.Rows.Add(43, "Combivent", "Janet");
            table.Rows.Add(70, "Dilantin", "Melanie");
            table.Rows.Add(73, "Combivent", "Melanie");
            table.Rows.Add(65, "Dilantin", "Melanie");
            return table;
        }

        #endregion

        #region Event Handlers
        void gridGroupingControl1_TableControlCurrentCellStartEditing(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCancelEventArgs e)
        {
            e.Inner.Cancel = true;
        }

   
        int selRow = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            t.Interval = (int)numericUpDown1.Value;
            t.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = true;

        }

        private void gridGroupingControl1_SelectedRecordsChanged(object sender, Syncfusion.Grouping.SelectedRecordsChangedEventArgs e)
        {
            if (e.Action == Syncfusion.Grouping.SelectedRecordsChangedType.Added && e.SelectedRecord != null)
            {
                this.radialGauge1.DisplayRecordIndex = e.SelectedRecord.GetSourcePosition();
                selRow = this.radialGauge1.DisplayRecordIndex;
                exValue = (int)radialGauge1.Value;
                this.radialGauge1.Invalidate();
            }
        }
        Random r = new Random(); bool reset = false; int exValue;
        void t_Tick(object sender, EventArgs e)
        {
            if (selRow > -1)
            {
                dataTable.Rows[selRow].BeginEdit();
                if (radialGauge1.Value + 1 <= 100 && !reset)
                    dataTable.Rows[selRow]["Dosage"] = radialGauge1.Value + 1;
                else
                    reset = true;
                if (reset)
                {
                    if (radialGauge1.Value + 1 >= 25)
                        dataTable.Rows[selRow]["Dosage"] = radialGauge1.Value - 1;
                    else
                        reset = false;
                }
                dataTable.Rows[selRow].EndEdit();
            }
        }
        #endregion

    }
					/// <summary>
/// Represents a class that is used to find the licensing file for Syncfusion controls.
/// </summary>
public class DemoCommon
{

    /// <summary>
    /// Finds the license key from the Common folder.
    /// </summary>
    /// <returns>Returns the license key.</returns>
    public static string FindLicenseKey()
    {
        string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
        for (int n = 0; n < 20; n++)
        {
            if (!System.IO.File.Exists(licenseKeyFile))
           {
                licenseKeyFile = @"..\" + licenseKeyFile;
                continue;
            }
            return File.ReadAllText(licenseKeyFile);
        }
        return string.Empty;
    }
}
}
