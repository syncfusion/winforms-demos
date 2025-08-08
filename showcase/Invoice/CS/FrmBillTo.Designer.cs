#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Invoice
{
    partial class FrmBillTo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gradientPanel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnUpdate = new Syncfusion.Windows.Forms.ButtonAdv();
            this.dtpDueDate = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.txtInvoiceNo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtAddress = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.dtpDate = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.txtName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblCaption = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoice));
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.btnCancel);
            this.gradientPanel1.Controls.Add(this.btnUpdate);
            this.gradientPanel1.Controls.Add(this.dtpDueDate);
            this.gradientPanel1.Controls.Add(this.txtInvoiceNo);
            this.gradientPanel1.Controls.Add(this.txtAddress);
            this.gradientPanel1.Controls.Add(this.dtpDate);
            this.gradientPanel1.Controls.Add(this.txtName);
            this.gradientPanel1.Controls.Add(this.autoLabel7);
            this.gradientPanel1.Controls.Add(this.autoLabel6);
            this.gradientPanel1.Controls.Add(this.autoLabel5);
            this.gradientPanel1.Controls.Add(this.autoLabel4);
            this.gradientPanel1.Controls.Add(this.autoLabel3);
            this.gradientPanel1.Controls.Add(this.lblCaption);
            this.gradientPanel1.Controls.Add(this.autoLabel2);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(377, 405);
            this.gradientPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(234, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 37);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(109, 347);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 37);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.BorderColor = System.Drawing.Color.Empty;
            // 
            // 
            // 
            this.dtpDueDate.Calendar.AllowMultipleSelection = false;
            this.dtpDueDate.Calendar.Culture = new System.Globalization.CultureInfo("en-US");
            this.dtpDueDate.Calendar.DaysFont = new System.Drawing.Font("Verdana", 8F);
            this.dtpDueDate.Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDueDate.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Calendar.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Calendar.Location = new System.Drawing.Point(0, 0);
            this.dtpDueDate.Calendar.Name = "monthCalendar";
            this.dtpDueDate.Calendar.SelectedDates = new System.DateTime[0];
            this.dtpDueDate.Calendar.Size = new System.Drawing.Size(185, 174);
            this.dtpDueDate.Calendar.SizeToFit = true;
            this.dtpDueDate.Calendar.TabIndex = 0;
            this.dtpDueDate.Calendar.WeekFont = new System.Drawing.Font("Verdana", 8F);
            this.dtpDueDate.Calendar.WeekInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite);
            // 
            // 
            // 
            this.dtpDueDate.Calendar.NoneButton.Location = new System.Drawing.Point(113, 0);
            this.dtpDueDate.Calendar.NoneButton.Size = new System.Drawing.Size(72, 20);
            this.dtpDueDate.Calendar.NoneButton.Text = "None";
            // 
            // 
            // 
            this.dtpDueDate.Calendar.TodayButton.Location = new System.Drawing.Point(0, 0);
            this.dtpDueDate.Calendar.TodayButton.Size = new System.Drawing.Size(113, 20);
            this.dtpDueDate.Calendar.TodayButton.Text = "Today";
            this.dtpDueDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.CalendarSize = new System.Drawing.Size(189, 176);
            this.dtpDueDate.Checked = false;
            this.dtpDueDate.DropDownImage = null;
            this.dtpDueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(109, 303);
            this.dtpDueDate.MinValue = new System.DateTime(((long)(0)));
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.ShowCheckBox = false;
            this.dtpDueDate.Size = new System.Drawing.Size(243, 25);
            this.dtpDueDate.TabIndex = 4;
            this.dtpDueDate.Value = new System.DateTime(2013, 8, 14, 7, 11, 17, 356);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(109, 257);
            this.txtInvoiceNo.Metrocolor = System.Drawing.Color.Empty;
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(243, 29);
            this.txtInvoiceNo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtInvoiceNo.TabIndex = 3;
            this.txtInvoiceNo.TextChanged += new System.EventHandler(this.txtInvoiceNo_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(109, 108);
            this.txtAddress.Metrocolor = System.Drawing.Color.Empty;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(243, 90);
            this.txtAddress.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtAddress.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.BorderColor = System.Drawing.Color.Empty;
            // 
            // 
            // 
            this.dtpDate.Calendar.AllowMultipleSelection = false;
            this.dtpDate.Calendar.Culture = new System.Globalization.CultureInfo("en-US");
            this.dtpDate.Calendar.DaysFont = new System.Drawing.Font("Verdana", 8F);
            this.dtpDate.Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Calendar.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Calendar.Location = new System.Drawing.Point(0, 0);
            this.dtpDate.Calendar.Name = "monthCalendar";
            this.dtpDate.Calendar.SelectedDates = new System.DateTime[0];
            this.dtpDate.Calendar.Size = new System.Drawing.Size(185, 174);
            this.dtpDate.Calendar.SizeToFit = true;
            this.dtpDate.Calendar.TabIndex = 0;
            this.dtpDate.Calendar.WeekFont = new System.Drawing.Font("Verdana", 8F);
            this.dtpDate.Calendar.WeekInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite);
            // 
            // 
            // 
            this.dtpDate.Calendar.NoneButton.Location = new System.Drawing.Point(113, 0);
            this.dtpDate.Calendar.NoneButton.Size = new System.Drawing.Size(72, 20);
            this.dtpDate.Calendar.NoneButton.Text = "None";
            // 
            // 
            // 
            this.dtpDate.Calendar.TodayButton.Location = new System.Drawing.Point(0, 0);
            this.dtpDate.Calendar.TodayButton.Size = new System.Drawing.Size(113, 20);
            this.dtpDate.Calendar.TodayButton.Text = "Today";
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.CalendarSize = new System.Drawing.Size(189, 176);
            this.dtpDate.Checked = false;
            this.dtpDate.DropDownImage = null;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(109, 215);
            this.dtpDate.MinValue = new System.DateTime(((long)(0)));
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShowCheckBox = false;
            this.dtpDate.Size = new System.Drawing.Size(243, 25);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.Value = new System.DateTime(2013, 8, 14, 7, 11, 17, 356);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(109, 62);
            this.txtName.Metrocolor = System.Drawing.Color.Empty;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 29);
            this.txtName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtName.TabIndex = 0;
            // 
            // autoLabel7
            // 
            this.autoLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel7.Location = new System.Drawing.Point(18, 305);
            this.autoLabel7.Name = "autoLabel7";
            this.autoLabel7.Size = new System.Drawing.Size(74, 21);
            this.autoLabel7.TabIndex = 6;
            this.autoLabel7.Text = "Due Date";
            // 
            // autoLabel6
            // 
            this.autoLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel6.Location = new System.Drawing.Point(18, 261);
            this.autoLabel6.Name = "autoLabel6";
            this.autoLabel6.Size = new System.Drawing.Size(84, 21);
            this.autoLabel6.TabIndex = 5;
            this.autoLabel6.Text = "Invoice No";
            // 
            // autoLabel5
            // 
            this.autoLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel5.Location = new System.Drawing.Point(18, 215);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(42, 21);
            this.autoLabel5.TabIndex = 4;
            this.autoLabel5.Text = "Date";
            // 
            // autoLabel4
            // 
            this.autoLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.Location = new System.Drawing.Point(18, 111);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(66, 21);
            this.autoLabel4.TabIndex = 3;
            this.autoLabel4.Text = "Address";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.Location = new System.Drawing.Point(18, 66);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(52, 21);
            this.autoLabel3.TabIndex = 2;
            this.autoLabel3.Text = "Name";
            // 
            // lblCaption
            // 
            this.lblCaption.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(18, 14);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(65, 25);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Bill To";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.Location = new System.Drawing.Point(18, 19);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(340, 25);
            this.autoLabel2.TabIndex = 1;
            this.autoLabel2.Text = "_________________________________________";
            // 
            // FrmBillTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 405);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBillTo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bill To";
            this.Load += new System.EventHandler(this.FrmBillTo_Load);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblCaption;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtpDate;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtName;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtpDueDate;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtInvoiceNo;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtAddress;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnUpdate;
    }
}