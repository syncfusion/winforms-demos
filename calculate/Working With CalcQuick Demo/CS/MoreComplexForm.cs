#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
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

using Syncfusion.Calculate;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace FirstSample
{
	/// <summary>
	/// Summary description for MoreComplexForm.
	/// </summary>
	public class MoreComplexForm : GridDemoForm
    {
        #region API Definitions
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		
		private System.Windows.Forms.TextBox Total;
		private System.Windows.Forms.TextBox Price;
		private System.Windows.Forms.ComboBox itemComboBox;
		private System.Windows.Forms.TextBox Quantity;
		private System.Windows.Forms.TextBox Shipping;
		private System.Windows.Forms.TextBox Tax;
		private System.Windows.Forms.ComboBox Discount;
        CalcQuick calculator = null;
        private Panel panel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        #endregion
        public MoreComplexForm()
		{
			//
			// Required for Windows Form Designer support.
			//
			InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
		
		#region Windows Form Designer stuffs
		/// <summary>
		/// Required method for Designer support; do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Shipping = new System.Windows.Forms.TextBox();
            this.Tax = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.Discount = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = " Discount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Shipping";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tax";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(123, 72);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(121, 20);
            this.Quantity.TabIndex = 1;
            // 
            // Shipping
            // 
            this.Shipping.Location = new System.Drawing.Point(123, 192);
            this.Shipping.Name = "Shipping";
            this.Shipping.Size = new System.Drawing.Size(121, 20);
            this.Shipping.TabIndex = 4;
            // 
            // Tax
            // 
            this.Tax.Location = new System.Drawing.Point(123, 232);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(121, 20);
            this.Tax.TabIndex = 5;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(123, 272);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(121, 20);
            this.Total.TabIndex = 6;
            this.Total.Text = "= ([Quantity] * [Price]) * (1-[Discount]) + [Shipping] + [Tax]";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(123, 112);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(121, 20);
            this.Price.TabIndex = 2;
            this.Price.Text = "0";
            // 
            // itemComboBox
            // 
            this.itemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemComboBox.Items.AddRange(new object[] {
            "WidgetA",
            "WidgetB",
            "WidgetC"});
            this.itemComboBox.Location = new System.Drawing.Point(123, 32);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(121, 21);
            this.itemComboBox.TabIndex = 0;
            // 
            // Discount
            // 
            this.Discount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Discount.Items.AddRange(new object[] {
            "1%",
            "2%",
            "3%",
            "5%",
            "10%",
            "20%"});
            this.Discount.Location = new System.Drawing.Point(123, 152);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(121, 21);
            this.Discount.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.Discount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.itemComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Tax);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Shipping);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 337);
            this.panel1.TabIndex = 14;
            // 
            // MoreComplexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ClientSize = new System.Drawing.Size(348, 361);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 388);
            this.Name = "MoreComplexForm";
            this.Text = "More Complex Form ";
            this.Load += new System.EventHandler(this.MoreComplexForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

		#endregion

		private void MoreComplexForm_Load(object sender, System.EventArgs e)
		{
			//Instantiate a CalcQuick object:
			calculator = new CalcQuick();

			//Register the controls used in calculations.
			//The formula names used are the Control.Name strings.
            this.calculator.RegisterControlArray(new Control[]
                                                {
                                                    this.Quantity,
                                                    this.Price,
                                                    this.Discount,
                                                    this.Shipping,
                                                    this.Tax,
                                                    this.Total
												});

			//Allow the CalcQuick sheet to create dependency lists among the formula objects
			//necesary for auto-calculations and do the initial computations.
			this.calculator.RefreshAllCalculations();
		}
	}
}
