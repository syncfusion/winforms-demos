#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace FindReplaceDemo
{
	/// <summary>
	/// Summary description for History.
	/// </summary>
	public class AddToHistoryDlg :MetroForm
	{
		private System.Windows.Forms.Label label2;
		private TextBoxExt txtaddedItem;
		private ButtonAdv btnOK;
        private ButtonAdv BtnCancel;
        private IContainer components;

		public AddToHistoryDlg()
		{		
			InitializeComponent();

            this.AcceptButton.DialogResult = DialogResult.OK;
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtaddedItem = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnOK = new Syncfusion.Windows.Forms.ButtonAdv();
            this.BtnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddedItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add Item";
            // 
            // txtaddedItem
            // 
            this.txtaddedItem.BorderColor = System.Drawing.Color.Silver;
            this.txtaddedItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaddedItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddedItem.Location = new System.Drawing.Point(96, 22);
            this.txtaddedItem.Metrocolor = System.Drawing.Color.Silver;
            this.txtaddedItem.Name = "txtaddedItem";
            this.txtaddedItem.Size = new System.Drawing.Size(192, 22);
            this.txtaddedItem.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtaddedItem.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(40, 64);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Add";
            this.btnOK.UseVisualStyle = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(192, 64);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyle = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // AddToHistoryDlg
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(312, 102);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtaddedItem);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MaximizeBox = false;
            this.Name = "AddToHistoryDlg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.txtaddedItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


        private void BtnCancel_Click(object sender, System.EventArgs e)
		{
			return;
		}
	
		public string addedItem
		{
			get
			{
				return this.txtaddedItem.Text;
			}
		}
	}
}
