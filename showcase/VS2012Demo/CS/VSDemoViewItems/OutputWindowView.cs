#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace VSDemo
{
	/// <summary>
	/// Summary description for OutputWindow.
	/// </summary>
	public class OutputWindowView : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel panelOutputWindow;
		private System.Windows.Forms.TextBox outputTextBox;
		private System.Windows.Forms.ComboBox outputTypeComboBox;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public OutputWindowView()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.panelOutputWindow = new System.Windows.Forms.Panel();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputTypeComboBox = new System.Windows.Forms.ComboBox();
            this.panelOutputWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOutputWindow
            // 
            this.panelOutputWindow.Controls.Add(this.outputTextBox);
            this.panelOutputWindow.Controls.Add(this.outputTypeComboBox);
            this.panelOutputWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutputWindow.Location = new System.Drawing.Point(0, 0);
            this.panelOutputWindow.Name = "panelOutputWindow";
            this.panelOutputWindow.Size = new System.Drawing.Size(728, 190);
            this.panelOutputWindow.TabIndex = 0;
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.outputTextBox.Location = new System.Drawing.Point(0, 21);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(728, 169);
            this.outputTextBox.TabIndex = 3;
            this.outputTextBox.Text = "\'VSDemo.exe\': Loaded \'c:\\suite showcase\\tools\\vsdemo\\bin\\debug\\syncfusion.edit.dl" +
                "l\', Symbols loaded.";
            // 
            // outputTypeComboBox
            // 
            this.outputTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.outputTypeComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.outputTypeComboBox.Location = new System.Drawing.Point(0, 0);
            this.outputTypeComboBox.Name = "outputTypeComboBox";
            this.outputTypeComboBox.Size = new System.Drawing.Size(728, 21);
            this.outputTypeComboBox.TabIndex = 2;
            this.outputTypeComboBox.Text = "Debug";
            // 
            // OutputWindowView
            // 
            this.Controls.Add(this.panelOutputWindow);
            this.Name = "OutputWindowView";
            this.Size = new System.Drawing.Size(728, 190);
            this.panelOutputWindow.ResumeLayout(false);
            this.panelOutputWindow.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion
	}
}
