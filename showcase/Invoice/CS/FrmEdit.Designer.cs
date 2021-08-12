namespace Invoice
{
    partial class FrmEdit
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
            this.cmbItems = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.txtTotal = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtTaxes = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtPrice = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtQty = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnUpdate = new Syncfusion.Windows.Forms.ButtonAdv();
            this.autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblCaption = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.cmbItems);
            this.gradientPanel1.Controls.Add(this.txtTotal);
            this.gradientPanel1.Controls.Add(this.txtTaxes);
            this.gradientPanel1.Controls.Add(this.txtPrice);
            this.gradientPanel1.Controls.Add(this.txtQty);
            this.gradientPanel1.Controls.Add(this.btnCancel);
            this.gradientPanel1.Controls.Add(this.btnUpdate);
            this.gradientPanel1.Controls.Add(this.autoLabel7);
            this.gradientPanel1.Controls.Add(this.autoLabel6);
            this.gradientPanel1.Controls.Add(this.autoLabel5);
            this.gradientPanel1.Controls.Add(this.autoLabel4);
            this.gradientPanel1.Controls.Add(this.autoLabel3);
            this.gradientPanel1.Controls.Add(this.lblCaption);
            this.gradientPanel1.Controls.Add(this.autoLabel2);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(665, 622);
            this.gradientPanel1.TabIndex = 1;
            // 
            // cmbItems
            // 
            this.cmbItems.BeforeTouchSize = new System.Drawing.Size(404, 40);
            this.cmbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItems.Location = new System.Drawing.Point(204, 102);
            this.cmbItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(404, 40);
            this.cmbItems.TabIndex = 0;
            this.cmbItems.SelectedValueChanged += new System.EventHandler(this.cmbItems_SelectedValueChanged);
            this.cmbItems.Click += new System.EventHandler(this.cmbItems_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = false;
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(204, 452);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(404, 39);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTaxes
            // 
            this.txtTaxes.AutoSize = false;
            this.txtTaxes.BackColor = System.Drawing.SystemColors.Control;
            this.txtTaxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaxes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaxes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxes.Location = new System.Drawing.Point(204, 363);
            this.txtTaxes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaxes.Name = "txtTaxes";
            this.txtTaxes.Size = new System.Drawing.Size(404, 39);
            this.txtTaxes.TabIndex = 3;
            this.txtTaxes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = false;
            this.txtPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(204, 280);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(404, 39);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.SystemColors.Control;
            this.txtQty.BeforeTouchSize = new System.Drawing.Size(404, 39);
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(204, 185);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQty.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.txtQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(404, 39);
            this.txtQty.TabIndex = 1;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQty.ValueChanged += new System.EventHandler(this.txtQty_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(177, 57);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.IsBackStageButton = false;
            this.btnCancel.Location = new System.Drawing.Point(434, 534);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 57);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnUpdate.BeforeTouchSize = new System.Drawing.Size(177, 57);
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.IsBackStageButton = false;
            this.btnUpdate.Location = new System.Drawing.Point(204, 534);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(177, 57);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // autoLabel7
            // 
            this.autoLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel7.Location = new System.Drawing.Point(27, 458);
            this.autoLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autoLabel7.Name = "autoLabel7";
            this.autoLabel7.Size = new System.Drawing.Size(159, 32);
            this.autoLabel7.TabIndex = 6;
            this.autoLabel7.Text = "Total Amount";
            // 
            // autoLabel6
            // 
            this.autoLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel6.Location = new System.Drawing.Point(27, 369);
            this.autoLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autoLabel6.Name = "autoLabel6";
            this.autoLabel6.Size = new System.Drawing.Size(71, 32);
            this.autoLabel6.TabIndex = 5;
            this.autoLabel6.Text = "Taxes";
            // 
            // autoLabel5
            // 
            this.autoLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel5.Location = new System.Drawing.Point(27, 280);
            this.autoLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(66, 32);
            this.autoLabel5.TabIndex = 4;
            this.autoLabel5.Text = "Price";
            // 
            // autoLabel4
            // 
            this.autoLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.Location = new System.Drawing.Point(27, 191);
            this.autoLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(107, 32);
            this.autoLabel4.TabIndex = 3;
            this.autoLabel4.Text = "Quantity";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.Location = new System.Drawing.Point(27, 102);
            this.autoLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(63, 32);
            this.autoLabel3.TabIndex = 2;
            this.autoLabel3.Text = "Item";
            // 
            // lblCaption
            // 
            this.lblCaption.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(27, 22);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(155, 40);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Edit Fields";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.Location = new System.Drawing.Point(27, 29);
            this.autoLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(593, 40);
            this.autoLabel2.TabIndex = 1;
            this.autoLabel2.Text = "________________________________________________";
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 623);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Fields";
            this.Load += new System.EventHandler(this.FrmEdit_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gradientPanel1;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnUpdate;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblCaption;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt txtQty;
        private Syncfusion.Windows.Forms.Tools.AutoLabel txtTotal;
        private Syncfusion.Windows.Forms.Tools.AutoLabel txtTaxes;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbItems;
        private Syncfusion.Windows.Forms.Tools.AutoLabel txtPrice;
    }
}