#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Invoice
{
    partial class FrmInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoice));
            this.txtFrom = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taxes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddItem = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnDeleteItem = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtTotalDue = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.txtName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnBillTo = new Syncfusion.Windows.Forms.ButtonAdv();
            this.dtDueDate = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.txtInvoiceNo = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.dtToDate = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.txtTo = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnExcel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnWord = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnPdf = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupView1 = new Syncfusion.Windows.Forms.Tools.GroupView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFrom
            // 
            this.txtFrom.AutoSize = false;
            this.txtFrom.BackColor = System.Drawing.Color.White;
            this.txtFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(84, 59);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(496, 198);
            this.txtFrom.TabIndex = 3;
            this.txtFrom.Text = "2501 Aerial Center Parkway\r\nSuite 200 Morrisville, NC 27560 USA\r\nTel +1 888.936.8" +
    "638 Fax +1 919.573.0306";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeColumns = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.CausesValidation = false;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.ColumnHeadersHeight = 37;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Rate,
            this.Taxes,
            this.Amount});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvItems.Location = new System.Drawing.Point(92, 177);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(0);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowTemplate.Height = 35;
            this.dgvItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.ShowEditingIcon = false;
            this.dgvItems.Size = new System.Drawing.Size(781, 159);
            this.dgvItems.TabIndex = 23;
            this.dgvItems.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_RowEnter);
            this.dgvItems.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_RowLeave);
            this.dgvItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvItems_RowsAdded);
            this.dgvItems.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvItems_RowsRemoved);
            this.dgvItems.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvItems_Paint);
            this.dgvItems.DoubleClick += new System.EventHandler(this.dgvItems_DoubleClick);
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = null;
            this.Item.DefaultCellStyle = dataGridViewCellStyle2;
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Quantity
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 150;
            // 
            // Rate
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Rate.DefaultCellStyle = dataGridViewCellStyle4;
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 150;
            // 
            // Taxes
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "0";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Taxes.DefaultCellStyle = dataGridViewCellStyle5;
            this.Taxes.HeaderText = "Taxes";
            this.Taxes.Name = "Taxes";
            this.Taxes.ReadOnly = true;
            this.Taxes.Width = 150;
            // 
            // Amount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = "0";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Amount.DefaultCellStyle = dataGridViewCellStyle6;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 150;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddItem.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(181)))), ((int)(((byte)(105)))));
            this.btnAddItem.BeforeTouchSize = new System.Drawing.Size(122, 45);
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddItem.IsBackStageButton = false;
            this.btnAddItem.Location = new System.Drawing.Point(92, 361);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(122, 45);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteItem.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btnDeleteItem.BeforeTouchSize = new System.Drawing.Size(122, 45);
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteItem.IsBackStageButton = false;
            this.btnDeleteItem.Location = new System.Drawing.Point(220, 361);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(122, 45);
            this.btnDeleteItem.TabIndex = 2;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // txtTotalDue
            // 
            this.txtTotalDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalDue.AutoSize = false;
            this.txtTotalDue.BackColor = System.Drawing.Color.White;
            this.txtTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalDue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalDue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDue.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTotalDue.Location = new System.Drawing.Point(695, 362);
            this.txtTotalDue.Name = "txtTotalDue";
            this.txtTotalDue.Size = new System.Drawing.Size(178, 43);
            this.txtTotalDue.TabIndex = 27;
            this.txtTotalDue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // autoLabel5
            // 
            this.autoLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel5.Location = new System.Drawing.Point(601, 372);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(88, 23);
            this.autoLabel5.TabIndex = 26;
            this.autoLabel5.Text = "Total Due:";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dashed;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.txtName);
            this.gradientPanel1.Controls.Add(this.btnBillTo);
            this.gradientPanel1.Controls.Add(this.dtDueDate);
            this.gradientPanel1.Controls.Add(this.txtInvoiceNo);
            this.gradientPanel1.Controls.Add(this.dtToDate);
            this.gradientPanel1.Controls.Add(this.txtTo);
            this.gradientPanel1.Controls.Add(this.autoLabel4);
            this.gradientPanel1.Controls.Add(this.autoLabel3);
            this.gradientPanel1.Controls.Add(this.autoLabel2);
            this.gradientPanel1.Controls.Add(this.autoLabel1);
            this.gradientPanel1.Location = new System.Drawing.Point(329, 28);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(544, 134);
            this.gradientPanel1.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.AutoSize = false;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtName.Location = new System.Drawing.Point(10, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 20);
            this.txtName.TabIndex = 30;
            this.txtName.Text = "Name";
            // 
            // btnBillTo
            // 
            this.btnBillTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBillTo.BeforeTouchSize = new System.Drawing.Size(30, 30);
            this.btnBillTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillTo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillTo.IsBackStageButton = false;
            this.btnBillTo.Location = new System.Drawing.Point(513, -1);
            this.btnBillTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBillTo.Name = "btnBillTo";
            this.btnBillTo.Size = new System.Drawing.Size(30, 30);
            this.btnBillTo.TabIndex = 2;
            this.btnBillTo.Click += new System.EventHandler(this.btnBillTo_Click);
            // 
            // dtDueDate
            // 
            this.dtDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDueDate.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.dtDueDate.BorderColor = System.Drawing.Color.Empty;
            this.dtDueDate.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtDueDate.CalendarSize = new System.Drawing.Size(189, 176);
            this.dtDueDate.DropDownImage = null;
            this.dtDueDate.DropDownNormalColor = System.Drawing.SystemColors.Control;
            this.dtDueDate.Enabled = false;
            this.dtDueDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDueDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDueDate.Location = new System.Drawing.Point(371, 91);
            this.dtDueDate.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtDueDate.MinValue = new System.DateTime(((long)(0)));
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.ShowCheckBox = false;
            this.dtDueDate.ShowDropButton = false;
            this.dtDueDate.Size = new System.Drawing.Size(99, 23);
            this.dtDueDate.TabIndex = 28;
            this.dtDueDate.TabStop = false;
            this.dtDueDate.Value = new System.DateTime(2013, 8, 14, 5, 21, 6, 502);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInvoiceNo.AutoSize = false;
            this.txtInvoiceNo.BackColor = System.Drawing.Color.White;
            this.txtInvoiceNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInvoiceNo.Location = new System.Drawing.Point(371, 51);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(99, 20);
            this.txtInvoiceNo.TabIndex = 27;
            this.txtInvoiceNo.Text = "1234567890";
            // 
            // dtToDate
            // 
            this.dtToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtToDate.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.dtToDate.BorderColor = System.Drawing.Color.Empty;
            this.dtToDate.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtToDate.CalendarSize = new System.Drawing.Size(189, 176);
            this.dtToDate.DropDownImage = null;
            this.dtToDate.DropDownNormalColor = System.Drawing.SystemColors.Control;
            this.dtToDate.Enabled = false;
            this.dtToDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtToDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(371, 7);
            this.dtToDate.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtToDate.MinValue = new System.DateTime(((long)(0)));
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.ShowCheckBox = false;
            this.dtToDate.ShowDropButton = false;
            this.dtToDate.Size = new System.Drawing.Size(99, 23);
            this.dtToDate.TabIndex = 26;
            this.dtToDate.TabStop = false;
            this.dtToDate.Value = new System.DateTime(2013, 8, 14, 5, 21, 6, 502);
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTo.AutoSize = false;
            this.txtTo.BackColor = System.Drawing.Color.White;
            this.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTo.Location = new System.Drawing.Point(6, 50);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(207, 69);
            this.txtTo.TabIndex = 25;
            this.txtTo.Text = "Address";
            // 
            // autoLabel4
            // 
            this.autoLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.Location = new System.Drawing.Point(238, 91);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(93, 23);
            this.autoLabel4.TabIndex = 24;
            this.autoLabel4.Text = "DUE DATE:";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.Location = new System.Drawing.Point(238, 50);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(112, 23);
            this.autoLabel3.TabIndex = 23;
            this.autoLabel3.Text = "INVOICE NO:";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.Location = new System.Drawing.Point(238, 7);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(55, 23);
            this.autoLabel2.TabIndex = 22;
            this.autoLabel2.Text = "DATE:";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(6, 7);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(72, 23);
            this.autoLabel1.TabIndex = 21;
            this.autoLabel1.Text = "BILL TO:";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(92, 28);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(140, 31);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnExcel.BeforeTouchSize = new System.Drawing.Size(122, 45);
            this.btnExcel.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcel.IsBackStageButton = false;
            this.btnExcel.Location = new System.Drawing.Point(751, 506);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(122, 45);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Export to Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnWord
            // 
            this.btnWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWord.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnWord.BeforeTouchSize = new System.Drawing.Size(122, 45);
            this.btnWord.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnWord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWord.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWord.IsBackStageButton = false;
            this.btnWord.Location = new System.Drawing.Point(623, 506);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(122, 45);
            this.btnWord.TabIndex = 4;
            this.btnWord.Text = "Export to Word";
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnPdf.BeforeTouchSize = new System.Drawing.Size(122, 45);
            this.btnPdf.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnPdf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPdf.IsBackStageButton = false;
            this.btnPdf.Location = new System.Drawing.Point(495, 506);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(122, 45);
            this.btnPdf.TabIndex = 3;
            this.btnPdf.Text = "Export to PDF";
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // groupView1
            // 
            this.groupView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.groupView1.BeforeTouchSize = new System.Drawing.Size(973, 74);
            this.groupView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupView1.Location = new System.Drawing.Point(-4, 494);
            this.groupView1.Name = "groupView1";
            this.groupView1.Size = new System.Drawing.Size(973, 74);
            this.groupView1.TabIndex = 28;
            this.groupView1.Text = "groupView1";
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 564);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.txtTotalDue);
            this.Controls.Add(this.autoLabel5);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.groupView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInvoice";
            this.Style.TitleBar.TextHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text = "Invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel txtFrom;
        private System.Windows.Forms.DataGridView dgvItems;
        private Syncfusion.Windows.Forms.ButtonAdv btnAddItem;
        private Syncfusion.Windows.Forms.ButtonAdv btnDeleteItem;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtDueDate;
        private Syncfusion.Windows.Forms.Tools.AutoLabel txtInvoiceNo;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtToDate;
        private Syncfusion.Windows.Forms.Tools.AutoLabel txtTo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.ButtonAdv btnBillTo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel txtName;
        private Syncfusion.Windows.Forms.ButtonAdv btnExcel;
        private Syncfusion.Windows.Forms.ButtonAdv btnWord;
        private Syncfusion.Windows.Forms.ButtonAdv btnPdf;
        private Syncfusion.Windows.Forms.Tools.GroupView groupView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taxes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private Syncfusion.Windows.Forms.Tools.AutoLabel txtTotalDue;
    }
}

