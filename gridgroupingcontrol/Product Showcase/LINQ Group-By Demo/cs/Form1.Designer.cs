#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;

namespace LinqGroupBy
{
    partial class Form1
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
            this.tipDesc = new System.Windows.Forms.ToolTip(this.components);
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.panForm = new System.Windows.Forms.Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.panForm.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipDesc
            // 
            this.tipDesc.BackColor = System.Drawing.Color.Black;
            this.tipDesc.ForeColor = System.Drawing.Color.White;
            this.tipDesc.IsBalloon = true;
            this.tipDesc.ShowAlways = true;
            this.tipDesc.UseFading = false;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(11, 3);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.Size = new System.Drawing.Size(653, 630);
            this.gridGroupingControl1.TabIndex = 2;
            this.gridGroupingControl1.TableDescriptor.AllowNew = false;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = true;
            this.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader";
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.TableOptions.AllowDragColumns = false;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255))))));
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.VersionInfo = "6.102.0.34";
            // 
            // panForm
            // 
            this.panForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panForm.BackColor = System.Drawing.Color.White;
            this.panForm.Controls.Add(this.gridGroupingControl1);
            this.panForm.Location = new System.Drawing.Point(12, 6);
            this.panForm.Name = "panForm";
            this.panForm.Size = new System.Drawing.Size(673, 636);
            this.panForm.TabIndex = 10;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(17, 62);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(289, 576);
            this.propertyGrid1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBoxAdv1);
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(17, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 53);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Query";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.AllowNewText = false;
            this.comboBoxAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(230, 21);
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Customer",
            "CustomerOrders",
            "CustomerOrderDetails",
            "CustomerOrdersGroupedByShippers",
            "ProductsGroupedBySupplier",
            "ProductsGroupedBySupplierAndCategory"});
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Customer"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "CustomerOrders"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "CustomerOrderDetails"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "CustomerOrdersGroupedByShippers"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "ProductsGroupedBySupplier"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "ProductsGroupedBySupplierAndCategory"));
            this.comboBoxAdv1.Location = new System.Drawing.Point(27, 21);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(230, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.propertyGrid1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(682, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 653);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1012, 654);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panForm);
            this.MinimumSize = new System.Drawing.Size(850, 450);
            this.Name = "Form1";
            this.Text = "LINQ Group-By";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.panForm.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip tipDesc;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private System.Windows.Forms.Panel panForm;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;

    }
}

