#region Copyright Syncfusion Inc. 2001 - 2023
//
//  Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DiagramTool
{
	/// <summary>
	/// Diagram used by the Diagram printing system for setting the PrintZoom values.
	/// </summary>
	public class PrintZoomingDialog : System.Windows.Forms.Form
	{
		public System.Windows.Forms.RadioButton radio1;
		public System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		public System.Windows.Forms.RadioButton radio2;
		private System.Windows.Forms.TextBox txtAcross;
		private System.Windows.Forms.TextBox txtDown;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PrintZoomingDialog()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();			
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
			this.radio1 = new System.Windows.Forms.RadioButton();
			this.radio2 = new System.Windows.Forms.RadioButton();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDown = new System.Windows.Forms.TextBox();
			this.txtAcross = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// radio1
			// 
			this.radio1.Location = new System.Drawing.Point(16, 24);
			this.radio1.Name = "radio1";
			this.radio1.Size = new System.Drawing.Size(72, 16);
			this.radio1.TabIndex = 0;
			this.radio1.Text = "Adjust to ";
			this.radio1.CheckedChanged += new System.EventHandler(this.radio1_CheckedChanged);
			// 
			// radio2
			// 
			this.radio2.Location = new System.Drawing.Point(16, 56);
			this.radio2.Name = "radio2";
			this.radio2.Size = new System.Drawing.Size(56, 16);
			this.radio2.TabIndex = 1;
			this.radio2.Text = "Fit to";
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
														   "25%",
														   "50%",
														   "100%",
														   "200%",
														   "400%"});
			this.comboBox1.Location = new System.Drawing.Point(104, 24);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(64, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtDown);
			this.groupBox1.Controls.Add(this.txtAcross);
			this.groupBox1.Controls.Add(this.radio1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.radio2);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 112);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(160, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "sheet(s) down";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(80, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "by";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(160, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "sheet(s) across";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(80, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "to";
			// 
			// txtDown
			// 
			this.txtDown.Location = new System.Drawing.Point(104, 80);
			this.txtDown.Name = "txtDown";
			this.txtDown.Size = new System.Drawing.Size(48, 20);
			this.txtDown.TabIndex = 4;
			this.txtDown.Text = "1";
			this.txtDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDown_KeyPress);
			this.txtDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDown_KeyUp);
			// 
			// txtAcross
			// 
			this.txtAcross.Location = new System.Drawing.Point(104, 56);
			this.txtAcross.Name = "txtAcross";
			this.txtAcross.Size = new System.Drawing.Size(48, 20);
			this.txtAcross.TabIndex = 3;
			this.txtAcross.Text = "1";
			this.txtAcross.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDown_KeyPress);
			this.txtAcross.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDown_KeyUp);
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(96, 128);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(76, 24);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(184, 128);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(76, 24);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			// 
			// PrintZoomingDialog
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(274, 159);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PrintZoomingDialog";
			this.Text = "Print Zooming";
			this.Load += new System.EventHandler(this.PrintZoomingDialog_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void txtDown_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			// proceed if user input is number or backspace
			if ( Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
			{
				if ( ((TextBox)sender).Text.Length > 2 )
				{
					e.Handled = true;
					return;
				}
				e.Handled = false;
				return;
			}
			
			e.Handled = true;
			
		}

		private void txtDown_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			int ii = int.Parse(((TextBox)sender).Text);
			if ( ii > 50 )
				((TextBox)sender).Text = "50";
		}

		private void radio1_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( ((RadioButton)sender).Checked == true )
			{
				this.txtAcross.Enabled = false;
				this.txtDown.Enabled = false;
				this.comboBox1.Enabled = true;
			}
			else
			{
				this.comboBox1.Enabled = false;
				this.txtAcross.Enabled = true;
				this.txtDown.Enabled = true;
			}

		}

		private void PrintZoomingDialog_Load(object sender, System.EventArgs e)
		{
			if ( this.radio1.Checked == false )
			{
				this.radio1_CheckedChanged(this.radio1, new EventArgs());
			}
		}

		#region Public Properties

		public string SheetsDown
		{
			get
			{
				return this.txtDown.Text;
			}
			set
			{
				this.txtDown.Text = value;
			}
		}


		public string SheetsAcross
		{
			get
			{
				return this.txtAcross.Text;
			}
			set
			{
				this.txtAcross.Text = value;
			}
		}

		#endregion
	}
}
