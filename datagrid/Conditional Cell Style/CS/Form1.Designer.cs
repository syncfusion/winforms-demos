#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Drawing;
using System.Windows.Forms;

namespace ConditionalCellStyle
{
    partial class Form1 : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.AllowFiltering = true;
            this.sfDataGrid.Dock = DockStyle.Fill;
            this.sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid.BackColor = System.Drawing.SystemColors.Window;
            this.sfDataGrid.Location = new System.Drawing.Point(15, 8);
            this.sfDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sfDataGrid.Name = "sfDataGrid";
			this.sfDataGrid.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid.ShowGroupDropArea = true;
            this.sfDataGrid.Size = new System.Drawing.Size(1152, 890);
            this.sfDataGrid.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1194, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 912);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Legend";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(58, 311);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 66);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Sales below $30,00,000.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 312);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 46);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox1.Location = new System.Drawing.Point(8, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 26);
            this.textBox1.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 240);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 46);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(58, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 57);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total Sales above $30,00,000.00";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(60, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 62);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sales in Quarter2 between $1,00,000.00 - $3,00,000.00";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.textBox3.Location = new System.Drawing.Point(8, 197);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(37, 26);
            this.textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightBlue;
            this.textBox2.Location = new System.Drawing.Point(8, 131);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 26);
            this.textBox2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(58, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 62);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sales in Quarter4 between $3,00,000.00 - $6,00,000.00";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(58, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 62);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sales in Quarter3 between $3,00,000.00 - $5,00,000.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1509, 912);
            this.Controls.Add(this.sfDataGrid);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MinimumSize = new System.Drawing.Size(739, 585);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conditional Cell Style";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        #region API Definition

        private SfDataGrid sfDataGrid;

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label6;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;

    }
}

