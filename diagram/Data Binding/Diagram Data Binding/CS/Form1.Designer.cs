#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;

namespace DiagramORM.Sample
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
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.diagram2 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model2 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model2)).BeginInit();
            this.SuspendLayout();
            // 
            // diagram1
            // 
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(DpiAware.LogicalToDeviceUnits(10F), DpiAware.LogicalToDeviceUnits(10F));
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.HScroll = true;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.MetroScrollBars = true;
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(742), (int)DpiAware.LogicalToDeviceUnits(555));
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 0;
            this.diagram1.Text = "diagram1";
            // 
            // 
            // 
            this.diagram1.View.BackgroundColor = System.Drawing.Color.White;
            this.diagram1.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram1.View.Controller = this.diagram1.Controller;
            this.diagram1.View.Grid.MinPixelSpacing = 4F;
            this.diagram1.View.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center;
            this.diagram1.VScroll = true;
            // 
            // model1
            // 
            this.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model1.DocumentScale.DisplayName = "No Scale";
            this.model1.DocumentScale.Height = 1F;
            this.model1.DocumentScale.Width = 1F;
            this.model1.DocumentSize.Height = DpiAware.LogicalToDeviceUnits(566.9291F);
            this.model1.DocumentSize.Width = DpiAware.LogicalToDeviceUnits(396.8504F);
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.LightGray;
            this.model1.LogicalSize = new System.Drawing.SizeF(DpiAware.LogicalToDeviceUnits(396.8504F), DpiAware.LogicalToDeviceUnits(566.9291F));
            this.model1.ShadowStyle.Color = System.Drawing.Color.DimGray;
            this.model1.ShadowStyle.ColorAlphaFactor = 255;
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.DimGray;
            this.model1.ShadowStyle.ForeColorAlphaFactor = 255;
            this.model1.SizeToContent = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(9), (int)DpiAware.LogicalToDeviceUnits(297));
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(115), (int)DpiAware.LogicalToDeviceUnits(23));
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(6), (int)DpiAware.LogicalToDeviceUnits(275));
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(86), (int)DpiAware.LogicalToDeviceUnits(15));
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee List:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(6), (int)DpiAware.LogicalToDeviceUnits(362));
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(76), (int)DpiAware.LogicalToDeviceUnits(15));
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(9), (int)DpiAware.LogicalToDeviceUnits(380));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(115), (int)DpiAware.LogicalToDeviceUnits(23));
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(9), (int)DpiAware.LogicalToDeviceUnits(409));
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(115), (int)DpiAware.LogicalToDeviceUnits(23));
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.employee_Add);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(3), (int)DpiAware.LogicalToDeviceUnits(3));
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnRemove);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.diagram1);
            this.splitContainer1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(901), (int)DpiAware.LogicalToDeviceUnits(555));
            this.splitContainer1.SplitterDistance = (int)DpiAware.LogicalToDeviceUnits(155);
            this.splitContainer1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(6), (int)DpiAware.LogicalToDeviceUnits(10));
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(146), (int)DpiAware.LogicalToDeviceUnits(254));
            this.label3.TabIndex = 8;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(9), (int)DpiAware.LogicalToDeviceUnits(325));
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(115), (int)DpiAware.LogicalToDeviceUnits(23));
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove Employee";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(1), (int)DpiAware.LogicalToDeviceUnits(2));
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(6), (int)DpiAware.LogicalToDeviceUnits(4));
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(915), (int)DpiAware.LogicalToDeviceUnits(594));
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(4), (int)DpiAware.LogicalToDeviceUnits(29));
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(3));
            this.tabPage1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(907), (int)DpiAware.LogicalToDeviceUnits(561));
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Self Relation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.diagram2);
            this.tabPage2.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(4), (int)DpiAware.LogicalToDeviceUnits(29));
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(3));
            this.tabPage2.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(907), (int)DpiAware.LogicalToDeviceUnits(561));
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parent-Child Relationship";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // diagram2
            // 
            this.diagram2.Controller.PasteOffset = new System.Drawing.SizeF(DpiAware.LogicalToDeviceUnits(10F), DpiAware.LogicalToDeviceUnits(10F));
            this.diagram2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram2.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2007;
            this.diagram2.LayoutManager = null;
            this.diagram2.Location = new System.Drawing.Point((int)DpiAware.LogicalToDeviceUnits(3), (int)DpiAware.LogicalToDeviceUnits(3));
            this.diagram2.Model = this.model2;
            this.diagram2.Name = "diagram2";
            this.diagram2.Office2007ScrollBars = true;
            this.diagram2.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram2.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(901), (int)DpiAware.LogicalToDeviceUnits(555));
            this.diagram2.SmartSizeBox = false;
            this.diagram2.TabIndex = 0;
            this.diagram2.Text = "diagram2";
            // 
            // 
            // 
            this.diagram2.View.BackgroundColor = System.Drawing.Color.White;
            this.diagram2.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram2.View.Controller = this.diagram2.Controller;
            this.diagram2.View.Grid.MinPixelSpacing = 4F;
            this.diagram2.View.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram2.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center;
            // 
            // model2
            // 
            this.model2.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model2.DocumentScale.DisplayName = "No Scale";
            this.model2.DocumentScale.Height = 1F;
            this.model2.DocumentScale.Width = 1F;
            this.model2.DocumentSize.Height = DpiAware.LogicalToDeviceUnits(1169F);
            this.model2.DocumentSize.Width = DpiAware.LogicalToDeviceUnits(827F);
            this.model2.LineStyle.DashPattern = null;
            this.model2.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model2.LineStyle.LineWidth = 0F;
            this.model2.LogicalSize = new System.Drawing.SizeF(DpiAware.LogicalToDeviceUnits(827F), DpiAware.LogicalToDeviceUnits(1169F));
            this.model2.ShadowStyle.Color = System.Drawing.Color.DimGray;
            this.model2.ShadowStyle.ColorAlphaFactor = 255;
            this.model2.ShadowStyle.ForeColor = System.Drawing.Color.DimGray;
            this.model2.ShadowStyle.ForeColorAlphaFactor = 255;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(DpiAware.LogicalToDeviceUnits(6F), DpiAware.LogicalToDeviceUnits(13F));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(916), (int)DpiAware.LogicalToDeviceUnits(596));
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding((int)DpiAware.LogicalToDeviceUnits(1), (int)DpiAware.LogicalToDeviceUnits(2), 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagram Data Binding";
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Syncfusion.Windows.Forms.Diagram.Model model1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram2;
        private Syncfusion.Windows.Forms.Diagram.Model model2;
    }
}