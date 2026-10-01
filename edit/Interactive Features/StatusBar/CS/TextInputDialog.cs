#region Copyright Syncfusion Inc. 2001 - 2014
//
//  Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
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
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace StatusBarDemo
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class TextInputDialog : SfForm
	{
		private System.Windows.Forms.TextBox textBox1;
		private ButtonAdv button1;
        private ButtonAdv button2;
        private IContainer components;
		public event EventHandler TextAccepted;
		
		public TextInputDialog ()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\\logo.ico")));
                this.Icon = ico;
            }
            catch { }
       
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 112);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.Location = new System.Drawing.Point(72, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Accept";
            this.button1.UseVisualStyle = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button2.Location = new System.Drawing.Point(176, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyle = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextInputDialog
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(338, 184);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(350, 216);
            this.Name = "TextInputDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Text Input Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			text = this.textBox1.Text;

			if(this.TextAccepted != null)
				this.TextAccepted(this,EventArgs.Empty);
			
			this.Close();
		}

		string text="";
		public string InputText
		{
			get
			{
				return text;
			}
		}
	}
}
