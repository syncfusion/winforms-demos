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

namespace PopupControlContainerDemo
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
    using Syncfusion.Windows.Forms;
    using System.Reflection;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.Licensing;

    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
	{
		private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
		private System.Windows.Forms.Label label1;
		private TextBoxExt sourceTextBox;
		private TextBoxExt popupTextBox;
		private ButtonAdv OK;
		private ButtonAdv cancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private ButtonAdv dropDownBtn;
		private System.Windows.Forms.ImageList imageList1;
        private AutoLabel autoLabel1;
        private GradientPanel gradientPanel1;
        private GradientPanel gradientPanel2;
		private System.ComponentModel.IContainer components;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		// <samplecodeblock name="PopupControlContainer Initialization">
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }


			// It's recommended that you keep the PopupControlContainer unparented by
			// any Control on the Form (which will be the default case as set up during design-time).
			// Otherwise, the Form wouldn't close sometimes, after dropping down this popup!
			this.popupControlContainer1.Parent.Controls.Remove(this.popupControlContainer1);
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

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.cancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.OK = new Syncfusion.Windows.Forms.ButtonAdv();
            this.popupTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sourceTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.dropDownBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceTextBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.popupControlContainer1.Controls.Add(this.cancel);
            this.popupControlContainer1.Controls.Add(this.OK);
            this.popupControlContainer1.Controls.Add(this.popupTextBox);
            this.popupControlContainer1.Location = new System.Drawing.Point(32, 156);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(120, 128);
            this.popupControlContainer1.TabIndex = 0;
            this.popupControlContainer1.Visible = false;
            this.popupControlContainer1.CloseUp += new Syncfusion.Windows.Forms.PopupClosedEventHandler(this.popupControlContainer1_CloseUp);
            this.popupControlContainer1.BeforePopup += new System.ComponentModel.CancelEventHandler(this.popupControlContainer1_BeforePopup);
            this.popupControlContainer1.Popup += new System.EventHandler(this.popupControlContainer1_Popup);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.cancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(56, 96);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(56, 24);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyle = true;
            this.cancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.OK.BackColor = System.Drawing.SystemColors.Highlight;
            this.OK.ForeColor = System.Drawing.Color.White;
            this.OK.Location = new System.Drawing.Point(8, 96);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(48, 24);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyle = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // popupTextBox
            // 
            this.popupTextBox.BorderColor = System.Drawing.Color.Gray;
            this.popupTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.popupTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.popupTextBox.Location = new System.Drawing.Point(0, 0);
            this.popupTextBox.Metrocolor = System.Drawing.Color.Gray;
            this.popupTextBox.Multiline = true;
            this.popupTextBox.Name = "popupTextBox";
            this.popupTextBox.Size = new System.Drawing.Size(118, 90);
            this.popupTextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.popupTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Associate a PopupControlContainer with this TextBox. And also transfer data back " +
    "and forth between the popup and the TextBox.";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.BorderColor = System.Drawing.Color.Gray;
            this.sourceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sourceTextBox.Location = new System.Drawing.Point(32, 40);
            this.sourceTextBox.Metrocolor = System.Drawing.Color.Gray;
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(176, 22);
            this.sourceTextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.sourceTextBox.TabIndex = 2;
            this.sourceTextBox.Text = "Alt+DownArrow for popup";
            this.sourceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPopupParent_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gradientPanel2);
            this.groupBox1.Controls.Add(this.gradientPanel1);
            this.groupBox1.Controls.Add(this.popupControlContainer1);
            this.groupBox1.Controls.Add(this.dropDownBtn);
            this.groupBox1.Controls.Add(this.sourceTextBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 325);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PopupControlContainer demo";
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel2.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.autoLabel1);
            this.gradientPanel2.Location = new System.Drawing.Point(270, 156);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(361, 113);
            this.gradientPanel2.TabIndex = 5;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel1.AutoSize = false;
            this.autoLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(35, 2);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(295, 84);
            this.autoLabel1.TabIndex = 3;
            this.autoLabel1.Text = resources.GetString("autoLabel1.Text");
            this.autoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Location = new System.Drawing.Point(270, 40);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(361, 88);
            this.gradientPanel1.TabIndex = 4;
            // 
            // dropDownBtn
            // 
            this.dropDownBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.dropDownBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.dropDownBtn.Image = ((System.Drawing.Image)(resources.GetObject("dropDownBtn.Image")));
            this.dropDownBtn.Location = new System.Drawing.Point(216, 40);
            this.dropDownBtn.Name = "dropDownBtn";
            this.dropDownBtn.Size = new System.Drawing.Size(26, 20);
            this.dropDownBtn.TabIndex = 0;
            this.dropDownBtn.UseVisualStyle = true;
            this.dropDownBtn.Click += new System.EventHandler(this.dropDownBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 18);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(739, 374);
            this.Controls.Add(this.groupBox1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(751, 411);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popup Container Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.popupControlContainer1.ResumeLayout(false);
            this.popupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceTextBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		public static void Main() 
		{
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
		}
        

        #region OpenClosePopup
        private void textBoxPopupParent_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			// Using this unconventional if statement syntax to avoid "and" symbol (documentation restriction, please ignore).

			// If user pressed key down, then show the popup.
			if(e.Alt)
				if(e.KeyCode == Keys.Down)
					if(!this.popupControlContainer1.IsShowing())
					{
						// Let the popup align around the source textBox.
						this.popupControlContainer1.ParentControl = this.sourceTextBox;
						// Passing Point.Empty will align it automatically around the above ParentControl.
						this.popupControlContainer1.ShowPopup(Point.Empty);

						e.Handled = true;
					}
			// Escape should close the popup.
			if(e.KeyCode == Keys.Escape)
				if(this.popupControlContainer1.IsShowing())
					this.popupControlContainer1.HidePopup(PopupCloseType.Canceled);
		}

		private void OK_Click(object sender, System.EventArgs e)
		{
			this.popupControlContainer1.HidePopup(PopupCloseType.Done);
		}

		private void cancelButton_Click(object sender, System.EventArgs e)
		{
			this.popupControlContainer1.HidePopup(PopupCloseType.Canceled);
		}
		#endregion OpenClosePopup
		#region PopupEvents
		private void popupControlContainer1_BeforePopup(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// Set the text to be edited with the text in the form text box.
			this.popupTextBox.Text = this.sourceTextBox.Text;
			this.popupControlContainer1.BackColor =Color.FromArgb (227, 241, 254);
		}

		private void popupControlContainer1_Popup(object sender, System.EventArgs e)
		{
			// Set the focus on the text box inside the popup after its open.
			this.popupTextBox.Focus();
			this.popupTextBox.SelectionStart = 0;
			this.popupTextBox.SelectionLength = 0;
		}

		private void popupControlContainer1_CloseUp(object sender, Syncfusion.Windows.Forms.PopupClosedEventArgs args)
		{
			// Transfer data from the popup.
			if(args.PopupCloseType == PopupCloseType.Done)
			{
				this.sourceTextBox.Text = this.popupTextBox.Text;
			}
			// Set focus back to textbox.
			if(args.PopupCloseType == PopupCloseType.Done
				|| args.PopupCloseType == PopupCloseType.Canceled)
				this.sourceTextBox.Focus();
		}
		#endregion PopupEvents
		// </samplecodeblock>
		#region ShowPopup
		private void dropDownBtn_Click(object sender, System.EventArgs e)
		{
			this.popupControlContainer1.ParentControl = this.sourceTextBox;
			this.popupControlContainer1.ShowPopup(Point.Empty);
		}
		#endregion
		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
