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
using System.Drawing;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Diagnostics;

namespace GridSample
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm
	{
		Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
		Syncfusion.Windows.Forms.SplitterControl splitterControl1;
		DataSet1 dataSet11;
		Form1 form;

		public MainForm(Form1 form)
		{
			this.form = form;
			this.gridControl1 = form.gridControl1;
			this.splitterControl1 = form.splitterControl1;
			this.dataSet11 = form.dataSet11;
			InitializeForm();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif		
			Form1 form = new Form1();
			MainForm main = new MainForm(form);
			Application.Run(form);
		}
        
		void InitializeForm()
		{
			// disable splitting grid view - with this type of cell renderer,
			// only a single view is supported. 
			splitterControl1.SplitBars = DynamicSplitBars.None;

            // Web Browser
            WebBrowser webbrowser = new WebBrowser();
            
            webbrowser.Url = new System.Uri("https://www.google.com/");
			// Grid
			gridControl1.BeginUpdate();
			gridControl1.AllowSelection = GridSelectionFlags.None;

			this.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(6, 2, 22, 10));
			this.gridControl1[6,2].CellType = "Control";
            this.gridControl1[6, 2].Control = webbrowser;
            this.gridControl1.CurrentCell.MoveTo(GridRangeInfo.Cell(6, 2));

			this.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(4,2,5,6));
			this.gridControl1[4,2].Text = "Host Internet Explorer as CellType";
			this.gridControl1[4,2].Font.Facename = "Arial";
			this.gridControl1[4,2].Font.Bold = true;
			this.gridControl1[4,2].TextColor = Color.FromArgb( 255, 153, 51 );
			this.gridControl1[4,2].Font.Size = 14;
			this.gridControl1[4,2].VerticalAlignment = GridVerticalAlignment.Middle;			
			gridControl1.EndUpdate(true);
		}			
	}
}
