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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
using PivotGridLibrary;
using DemoCommon.Grid;

namespace PrivotGridSample
{
    public partial class Form1 : GridDemoForm
    {
        #region Constructor
        public Form1()
        {

            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            pivotGridControl1.DefaultComputationName = "Average";
            pivotGridControl1.DataSource = GetDataTable();
#if NETCORE
            this.Icon = new Icon("../../../Icon/sfgrid.ico");
#else
            this.Icon = new Icon("../../Icon/sfgrid.ico");
#endif
            //set the visualstyle...
            pivotGridControl1.GetAppearance().VisualStyle = GridVisualStyles.Metro;
        }
        #endregion        

        #region Events
        void menuStrip1_MenuDeactivate(object sender, EventArgs e)
        {
            this.menuStrip1.ForeColor = Color.White;
        }

        void menuStrip1_MenuActivate(object sender, EventArgs e)
        {
            this.menuStrip1.ForeColor = Color.Black;
        }

        protected override void OnClosed(EventArgs e)
        {
            pivotGridControl1.Dispose();
            pivotGridControl1 = null;

            base.OnClosed(e);
        }
        private DataTable GetDataTable()
        {
            #region Get the DataSource
            DataTable dt = new DataTable("MyTable");

            int nRows = 2000;
            Random r = new Random(123345345);

            dt.Columns.Add(new DataColumn("City", typeof(string)));
            dt.Columns.Add(new DataColumn("Sex", typeof(string)));
            string[] sexes = new string[] { "Male", "Female"};
            dt.Columns.Add(new DataColumn("Age", typeof(int)));
            dt.Columns.Add(new DataColumn("Profession", typeof(string)));
            string[] jobs = new string[] { "nurse", "teacher", "engineer", "tailor", "salesperson", "programmer", "gardener", "cook", "surgeon" };
            dt.Columns.Add(new DataColumn("Salary", typeof(double)));
            dt.Columns.Add(new DataColumn("State", typeof(string)));
            string[] states = new string[] { "NC", "SC", "GA", "VA" };
            string[] NCcities = new string[] { "Raleigh", "Charlotte", "Wilmington", "Ashville" };
            string[] GAcities = new string[] { "Augusta", "Albany", "Atlanta" };
            string[] VAcities = new string[] { "Norfolk", "Richmond" };
            string[] SCcities = new string[] { "Clemson", "Myrtle Beach", "Charleston" };
            dt.Columns.Add(new DataColumn("Married", typeof(bool)));
            dt.Columns.Add(new DataColumn("Children", typeof(int)));
            dt.Columns.Add(new DataColumn("Siblings", typeof(int)));
            dt.Columns.Add(new DataColumn("CC Debt", typeof(double)));
            

            for (int i = 0; i < nRows; ++i)
            {
                DataRow dr = dt.NewRow();
              //  dr["City"] = cities[r.Next(cities.GetLength(0))];
                dr["Sex"] = sexes[r.Next(sexes.GetLength(0))];
                dr["Age"] = r.Next(45) + 20;
                dr["Profession"] = jobs[r.Next(jobs.GetLength(0))];
                dr["Salary"] = 15000d + (int)(r.NextDouble() * 100000);
                dr["State"] = states[r.Next(states.GetLength(0))];
                int k = "NCSCVAGA".IndexOf(dr["State"].ToString());
                switch (k)
                {
                    case 0:
                        dr["City"] = NCcities[r.Next(NCcities.GetLength(0))];
                        break;
                    case 2:
                        dr["City"] = SCcities[r.Next(SCcities.GetLength(0))];
                        break;
                    case 6:
                        dr["City"] = GAcities[r.Next(GAcities.GetLength(0))];
                        break;
                    case 4:
                        dr["City"] = VAcities[r.Next(VAcities.GetLength(0))];
                        break;
                }
                dr["Married"] = r.Next(3) == 1;
                dr["Children"] = (bool) dr["Married"] ? r.Next(6) : 0;
                dr["Siblings"] = r.Next(7);
                dr["CC Debt"] = ((int)(r.NextDouble() * 2000000)) / 100d;
                dt.Rows.Add(dr);
            }
            #endregion

            return dt;
        }
        #endregion

        #region Menu handlers

        #region Load Schema

        private void loadSchemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  DateTime start = DateTime.Now;

            //load schema
            OpenFileDialog dlg = new OpenFileDialog(); 
			dlg.Title = "Open Pivot Table Schema file" ;
            string s = GetFile("blue.appearance.xml");
            s = s.Substring(0, s.LastIndexOf(@"\"));
            dlg.InitialDirectory = s;
            dlg.Filter = "Pivot Table Schema files (*.schema.xml)|*.schema.xml|All files (*.*)|*.*"; 
		 
			if(dlg.ShowDialog() == DialogResult.OK) 
			{
             //   start = DateTime.Now;

                Application.DoEvents();// let the dialog close before loading schema
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    PivotSchema schema = PivotSchema.LoadXML(dlg.FileName);
                    pivotGridControl1.ApplySchema(schema);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
			}

          //  this.Text = this.Text + "  " + string.Format("Load time: {0} secs", ((TimeSpan)(DateTime.Now - start)).TotalSeconds);
          //  Console.WriteLine(this.Text);
        }

        private string GetFile(string fileName)
        {
            string dataFileName = @"PivotGrid\" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                dataFileName = @"..\" + dataFileName;
            }
            return dataFileName;
        }

        #endregion

        #region Save Schema

        private void saveSchemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save schema
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Untitled";
			saveFile.DefaultExt = "*.schema.xml";
			saveFile.Filter = "Pivot Table Schema files (*.schema.xml)|*.schema.xml|All files (*.*)|*.*";

			// get a file name from the user
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PivotSchema schema = pivotGridControl1.InitSchema();
                    schema.SaveXML(saveFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion

        #region Reset Schema

        private void resetSchemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //reset schema
            pivotGridControl1.ResetSchema();
        }

        #endregion

        #region Show Data

        private void displayDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display data - just shows the underlying flat list in a DataGridView...
            Form2 f = new Form2();
            f.dataGridView1.DataSource = pivotGridControl1.DataSource;
            f.Show();
        }

        #endregion

        #region Exit

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Change Appearance
        PropertyGridForm propertyForm = null;

        private void changeAppearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change appearance
            if (propertyForm == null)
            {
                propertyForm = new PropertyGridForm();
                propertyForm.Closing += new CancelEventHandler(propertyForm_Closing);
                propertyForm.AppearancePropertyGrid1.SelectedObject = pivotGridControl1.GetAppearance();
                propertyForm.AppearancePropertyGrid1.PropertyValueChanged += new PropertyValueChangedEventHandler(AppearancePropertyGrid1_PropertyValueChanged);
            }
            if (!propertyForm.Visible)
                propertyForm.Show();
        }
        private void propertyForm_Closing(object sender, CancelEventArgs e)
        {
            propertyForm.Hide();
            e.Cancel = true;
        }
        private void AppearancePropertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            this.pivotGridControl1.UpdateValues();
        }
        #endregion

        #region Load Appearance

        private void loadAppearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Pivot Table Appearance file";
            string s = GetFile("default.appearance.XML");
            s = s.Substring(0, s.LastIndexOf(@"\"));
            dlg.InitialDirectory = s;
            dlg.Filter = "Pivot Table Appearance files (*.appearance.xml)|*.appearance.xml|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();// let the dialog close before loading schema
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    PivotAppearance appearance = PivotAppearance.LoadXML(dlg.FileName);
                    pivotGridControl1.SetAppearance(appearance);
               }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        #endregion

        #region Save Appearance

        private void saveAppearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save appearance
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Untitled";
            saveFile.DefaultExt = "*.appearance.xml";
            saveFile.Filter = "Pivot Table Appearance files (*.appearance.xml)|*.appearance.xml|All files (*.*)|*.*";

            // get a file name from the user
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pivotGridControl1.GetAppearance().SaveXML(saveFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion

        #region Expand All / Collapse All

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //expandall
            pivotGridControl1.ExpandAll();
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //collapse all
            pivotGridControl1.CollapseAll();
        }

        #endregion

        #region Refresh display

        private void refreshCalculationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //refresh calculations...
            DateTime start = DateTime.Now;

            pivotGridControl1.UpdateValues();
            this.Text = string.Format("Update time: {0:0.0000} secs     {1} rows x {2} cols", ((TimeSpan)(DateTime.Now - start)).TotalSeconds, pivotGridControl1.MainDisplayGrid.RowCount, pivotGridControl1.MainDisplayGrid.ColCount);
  
        }
        #endregion

        #region Show All Colors

        private void showAllColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show all colors - just for illustration to allow you to see what Appearance property affects what part of the pivotCOntrol1.MainDisplayGrid.
            PivotAppearance appearance = pivotGridControl1.GetAppearance();
            appearance.RowTotalCell.BackColor = Color.Gold;
            appearance.RowExpandCell.BackColor = Color.Blue;
            appearance.ColumnExpandCell.BackColor = Color.Red;
            appearance.RowCell.BackColor = Color.Pink;
            appearance.ValueCell.BackColor = Color.LemonChiffon;
            appearance.ColumnTotalCell.BackColor = Color.IndianRed;
            appearance.ColumnCell.BackColor = Color.LawnGreen;
            appearance.CalculationNameCell.BackColor = Color.Yellow;
            appearance.TopLeftCell.BackColor = Color.Turquoise;

            pivotGridControl1.UpdateValues(); //forces a refresh to display new appearance
        }
        #endregion

        #region Visual Styles

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //2007 Black
            this.pivotGridControl1.GetAppearance().VisualStyle = GridVisualStyles.Office2007Black;
            blackToolStripMenuItem.Checked = true;
            blueToolStripMenuItem.Checked = false;
            silverToolStripMenuItem.Checked = false;
            systemToolStripMenuItem.Checked = false;
            toolStripMenuItem2.Checked = false;
            noneToolStripMenuItem.Checked = false;
        }

       

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //2007 Blue
            this.pivotGridControl1.GetAppearance().VisualStyle = GridVisualStyles.Office2007Blue;
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = true;
            silverToolStripMenuItem.Checked = false;
            systemToolStripMenuItem.Checked = false;
            toolStripMenuItem2.Checked = false;
            noneToolStripMenuItem.Checked = false;
        }

        private void silverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //2007 Silver
            this.pivotGridControl1.GetAppearance().VisualStyle = GridVisualStyles.Office2007Silver;
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            silverToolStripMenuItem.Checked = true;
            systemToolStripMenuItem.Checked = false;
            toolStripMenuItem2.Checked = false;
            noneToolStripMenuItem.Checked = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //2003
            this.pivotGridControl1.GetAppearance().VisualStyle = GridVisualStyles.Office2003;
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            silverToolStripMenuItem.Checked = false;
            systemToolStripMenuItem.Checked = false;
            toolStripMenuItem2.Checked = true;
            noneToolStripMenuItem.Checked = false;
        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System
            this.pivotGridControl1.GetAppearance().VisualStyle = GridVisualStyles.SystemTheme;
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            silverToolStripMenuItem.Checked = false;
            systemToolStripMenuItem.Checked = true;
            toolStripMenuItem2.Checked = false;
            noneToolStripMenuItem.Checked = false;
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //none
            this.pivotGridControl1.GetAppearance().ThemesEnabled = !this.pivotGridControl1.GetAppearance().ThemesEnabled;
            noneToolStripMenuItem.Checked = this.pivotGridControl1.GetAppearance().ThemesEnabled;
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            silverToolStripMenuItem.Checked = false;
            systemToolStripMenuItem.Checked = false;
            toolStripMenuItem2.Checked = false;
            noneToolStripMenuItem.Checked = true;
        }

        private void metroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pivotGridControl1.GetAppearance().VisualStyle = GridVisualStyles.Metro;
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            silverToolStripMenuItem.Checked = false;
            systemToolStripMenuItem.Checked = false;
            toolStripMenuItem2.Checked = false;
            noneToolStripMenuItem.Checked = false;
            metroToolStripMenuItem.Checked = true;
        }
        #endregion

        #region Freeze Headers
        private void freezeHeadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pivotGridControl1.FreezeHeaders = this.freezeHeadersToolStripMenuItem.Checked;

        }
        #endregion

        private void hideRightPaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hideRightPaneToolStripMenuItem.Checked)
            {
                this.pivotGridControl1.ShowExpandButton = false;
            }
            else
            {
                this.pivotGridControl1.ShowExpandButton = true;
            }

            hideRightPaneToolStripMenuItem.Checked = !this.pivotGridControl1.ShowExpandButton;
        }

        #endregion
    }
}