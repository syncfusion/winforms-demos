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

namespace XPMenusMDI
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;

	/// <summary>
	/// Summary description for DocumentTypeSelectionDialog.
	/// </summary>
	public class DocumentTypeSelectionDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton_;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public int SelectedType
		{
			get{return this.listBox1.SelectedIndex;}
		}

		public DocumentTypeSelectionDialog()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton_ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(213)))));
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.Items.AddRange(new object[] {
            "Text Editor",
            "Image Editor"});
            this.listBox1.Location = new System.Drawing.Point(6, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 43);
            this.listBox1.TabIndex = 0;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(12, 70);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(78, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton_
            // 
            this.cancelButton_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.cancelButton_.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cancelButton_.ForeColor = System.Drawing.Color.White;
            this.cancelButton_.Location = new System.Drawing.Point(96, 70);
            this.cancelButton_.Name = "cancelButton_";
            this.cancelButton_.Size = new System.Drawing.Size(75, 23);
            this.cancelButton_.TabIndex = 2;
            this.cancelButton_.Text = "&Cancel";
            this.cancelButton_.UseVisualStyleBackColor = false;
            // 
            // DocumentTypeSelectionDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancelButton_;
            this.ClientSize = new System.Drawing.Size(192, 105);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton_);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DocumentTypeSelectionDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Document Type";
            this.Load += new System.EventHandler(this.DocumentTypeSelectionDialog_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void DocumentTypeSelectionDialog_Load(object sender, System.EventArgs e)
		{
			this.listBox1.SelectedIndex = 0;
		}

		private void listBox1_DoubleClick(object sender, System.EventArgs e)
		{
			this.okButton.PerformClick();		
		}

		private void listBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
		{
			e.DrawBackground();
			Brush myBrush = Brushes.Black;
			switch (e.Index)
			{
				case 0:
					myBrush = Brushes.MidnightBlue;
					break;
				case 1:
					myBrush = Brushes.Brown;
					break;

			}
			e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), 
				e.Font, myBrush,e.Bounds,StringFormat.GenericDefault);

			//e.DrawFocusRectangle();
		}
	}
}
