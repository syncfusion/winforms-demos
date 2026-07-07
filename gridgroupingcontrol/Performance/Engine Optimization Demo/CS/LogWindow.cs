#region Copyright Syncfusion Inc. 2001 - 2005
//
//  Copyright Syncfusion Inc. 2001 - 2005. All rights reserved.
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
using System.IO;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace TestEngineOptimizations
{
	/// <summary>
	/// Summary description for LogWindow.
	/// </summary>
	public class LogWindow : MetroForm
	{
		private System.Windows.Forms.ListBox listBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LogWindow()
		{
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"Common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
         
			tw = new ListboxTextWriter(this.listBox1);
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


		ListboxTextWriter tw;

		public ListboxTextWriter Log
		{
			get
			{
				return tw;
			}
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(680, 277);
            this.listBox1.TabIndex = 0;
            // 
            // LogWindow
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(680, 278);
            this.Controls.Add(this.listBox1);
            this.DropShadow = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogWindow";
            this.Text = "Log Window";
            this.ResumeLayout(false);

		}
		#endregion
	}

	public class ListboxTextWriter : TextWriter
	{
		ListBox lb;
		string lastItem = "";

		public ListboxTextWriter(ListBox lb)
		{
			this.lb = lb;
		}

		public override void Write(char[] buffer, int index, int count)
		{
			lastItem = new string(buffer, index, count).TrimEnd('\r', '\n', '\0');
			base.Write (buffer, index, count);
			lb.Items.Add(lastItem);
			lb.SelectedIndex = lb.Items.Count-1;
		}

		public override System.Text.Encoding Encoding
		{
			get
			{
				return System.Text.Encoding.Unicode;
			}
		}


	}
}
