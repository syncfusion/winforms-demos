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
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Styles;
using Syncfusion.ComponentModel;
using Syncfusion.Windows.Forms;

public class GroupingGridPropertyDialog : MetroForm
{
	internal System.Windows.Forms.PropertyGrid propertyGrid;
	private System.ComponentModel.Container components = null;
	private PropertyGridContextMenu pgMenu;

	GridGroupingControl grid;

	public GroupingGridPropertyDialog(GridGroupingControl grid)
	{
        //
        // Required for Windows Form Designer support
        //
		InitializeComponent();

        System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"Common\Images\Grid\Icon\sfgrid.ico"));
		this.Icon = ico ;	

		this.grid = grid;
		this.grid.FilterRuntimeProperties = true;
		propertyGrid.SelectedObject = grid;

		if(propertyGrid != null)
			this.pgMenu = new PropertyGridContextMenu(this.propertyGrid);

		this.grid.PropertyChanged += new DescriptorPropertyChangedEventHandler(grid_PropertyChanged);
		this.grid.TableDescriptor.PropertyChanged += new DescriptorPropertyChangedEventHandler(TableDescriptor_PropertyChanged);
		this.grid.Engine.SourceListChanged += new EventHandler(Engine_SourceListChanged);
		Application.Idle += new EventHandler(Application_Idle);
	}

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

	bool needRefresh = false;

	private void grid_PropertyChanged(object sender, DescriptorPropertyChangedEventArgs e)
	{
		needRefresh = true;
	}

	private void TableDescriptor_PropertyChanged(object sender, DescriptorPropertyChangedEventArgs e)
	{
		needRefresh = true;
	}

	private void Engine_SourceListChanged(object sender, EventArgs e)
	{
		needRefresh = true;
	}

	private void Application_Idle(object sender, EventArgs e)
	{
		if (this.needRefresh && propertyGrid != null && propertyGrid.Parent != null)
		{
			needRefresh = false;
			propertyGrid.Refresh();
		}
	}

	protected override void OnClosed(EventArgs e)
	{
		Application.Idle -= new EventHandler(Application_Idle);
		base.OnClosed (e);
	}

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	protected override void Dispose( bool disposing )
	{
		if( disposing )
		{
			if(components != null)
			{
				components.Dispose();
			}
		}
		base.Dispose( disposing );
	}

	protected override void WndProc(ref Message m)
	{
		base.WndProc (ref m);

	}

	#region Windows Form Designer generated code
	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
        this.propertyGrid = new System.Windows.Forms.PropertyGrid();
        this.SuspendLayout();
        // 
        // propertyGrid
        // 
        this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        this.propertyGrid.Location = new System.Drawing.Point(0, 0);
        this.propertyGrid.Name = "propertyGrid";
        this.propertyGrid.Size = new System.Drawing.Size(292, 266);
        this.propertyGrid.TabIndex = 0;
        // 
        // GroupingGridPropertyDialog
        // 
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.ClientSize = new System.Drawing.Size(292, 266);
        this.Controls.Add(this.propertyGrid);
        this.Name = "GroupingGridPropertyDialog";
        this.Text = "Grouping Grid Property Dialog";
        this.ResumeLayout(false);
	}
	#endregion
}
