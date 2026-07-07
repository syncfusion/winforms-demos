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
using DemoCommon.Grid;

namespace Syncfusion.Samples.GridPad
{

	/// <summary>
	/// A form that displays a <see cref="PropertyGrid"/> with ok button.
	/// </summary>
	/// <example>
	/// </example>
    public class PropertyForm : GridDemoForm
	{
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button okButton;
		private PropertyGrid grid;
		private object customizer;

		/// <summary>
		/// Initializes a new <see cref="PropertyForm"/> with an object to display properties for.
		/// </summary>
		/// <param name="customizer">The object for which properties should be displayed.</param>
		public PropertyForm(object customizer)
		{
			InitializeComponent();
			this.customizer = customizer;
			grid.SelectedObject = customizer;
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

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.okButton = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Location = new System.Drawing.Point(232, 297);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.grid.Location = new System.Drawing.Point(8, 8);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(312, 281);
            this.grid.TabIndex = 1;
            this.grid.ToolbarVisible = false;
            // 
            // PropertyForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.okButton;
            this.ClientSize = new System.Drawing.Size(328, 325);
            this.ControlBox = false;
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.grid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropertyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.PropertyForm_Load);
            this.ResumeLayout(false);

		}

        private void PropertyForm_Load(object sender, EventArgs e)
        {

        }
	}
}
