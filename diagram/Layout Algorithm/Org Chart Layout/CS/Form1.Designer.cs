#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace OrgChartLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.expanderPanel2 = new System.Windows.Forms.Panel();
            this.bShape = new System.Windows.Forms.Label();
            this.expSymShapeLbl = new System.Windows.Forms.Label();
            this.comboBShape = new System.Windows.Forms.ComboBox();
            this.comboExpSymbol = new System.Windows.Forms.ComboBox();
            this.expanderPanel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.vSpacing = new System.Windows.Forms.Label();
            this.hSpacing = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            this.txtHSpacing = new System.Windows.Forms.TextBox();
            this.chkAutoLayout = new System.Windows.Forms.CheckBox();
            this.txtVSpacing = new System.Windows.Forms.TextBox();
            this.txtTMarigin = new System.Windows.Forms.TextBox();
            this.lMarigin = new System.Windows.Forms.Label();
            this.tMarigin = new System.Windows.Forms.Label();
            this.txtLMarigin = new System.Windows.Forms.TextBox();
            this.lytTypLbl = new System.Windows.Forms.Label();
            this.comboLytType = new System.Windows.Forms.ComboBox();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.lytProp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.expanderPanel2.SuspendLayout();
            this.expanderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.expanderPanel2);
            this.panel2.Controls.Add(this.expanderPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(751, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 607);
            this.panel2.TabIndex = 2;
            // 
            // expanderPanel2
            // 
            this.expanderPanel2.BackColor = System.Drawing.Color.White;
            this.expanderPanel2.Controls.Add(this.label2);
            this.expanderPanel2.Controls.Add(this.bShape);
            this.expanderPanel2.Controls.Add(this.expSymShapeLbl);
            this.expanderPanel2.Controls.Add(this.comboBShape);
            this.expanderPanel2.Controls.Add(this.comboExpSymbol);
            this.expanderPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expanderPanel2.Location = new System.Drawing.Point(0, 344);
            this.expanderPanel2.Name = "expanderPanel2";
            this.expanderPanel2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.expanderPanel2.Size = new System.Drawing.Size(279, 263);
            this.expanderPanel2.TabIndex = 1;
            // 
            // bShape
            // 
            this.bShape.AutoSize = true;
            this.bShape.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShape.Location = new System.Drawing.Point(13, 55);
            this.bShape.Name = "bShape";
            this.bShape.Size = new System.Drawing.Size(106, 15);
            this.bShape.TabIndex = 3;
            this.bShape.Text = "Background Shape";
            // 
            // expSymShapeLbl
            // 
            this.expSymShapeLbl.AutoSize = true;
            this.expSymShapeLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expSymShapeLbl.Location = new System.Drawing.Point(13, 91);
            this.expSymShapeLbl.Name = "expSymShapeLbl";
            this.expSymShapeLbl.Size = new System.Drawing.Size(82, 15);
            this.expSymShapeLbl.TabIndex = 5;
            this.expSymShapeLbl.Text = "Symbol Shape";
            // 
            // comboBShape
            // 
            this.comboBShape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBShape.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBShape.FormattingEnabled = true;
            this.comboBShape.Items.AddRange(new object[] {
            "Rectangle",
            "Ellipse"});
            this.comboBShape.Location = new System.Drawing.Point(151, 52);
            this.comboBShape.Name = "comboBShape";
            this.comboBShape.Size = new System.Drawing.Size(104, 23);
            this.comboBShape.TabIndex = 2;
            // 
            // comboExpSymbol
            // 
            this.comboExpSymbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboExpSymbol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboExpSymbol.FormattingEnabled = true;
            this.comboExpSymbol.Items.AddRange(new object[] {
            "Triangle",
            "PlusMinus"});
            this.comboExpSymbol.Location = new System.Drawing.Point(151, 88);
            this.comboExpSymbol.Name = "comboExpSymbol";
            this.comboExpSymbol.Size = new System.Drawing.Size(104, 23);
            this.comboExpSymbol.TabIndex = 4;
            // 
            // expanderPanel1
            // 
            this.expanderPanel1.BackColor = System.Drawing.Color.White;
            this.expanderPanel1.Controls.Add(this.lytProp);
            this.expanderPanel1.Controls.Add(this.label1);
            this.expanderPanel1.Controls.Add(this.vSpacing);
            this.expanderPanel1.Controls.Add(this.hSpacing);
            this.expanderPanel1.Controls.Add(this.apply);
            this.expanderPanel1.Controls.Add(this.txtHSpacing);
            this.expanderPanel1.Controls.Add(this.chkAutoLayout);
            this.expanderPanel1.Controls.Add(this.txtVSpacing);
            this.expanderPanel1.Controls.Add(this.txtTMarigin);
            this.expanderPanel1.Controls.Add(this.lMarigin);
            this.expanderPanel1.Controls.Add(this.tMarigin);
            this.expanderPanel1.Controls.Add(this.txtLMarigin);
            this.expanderPanel1.Controls.Add(this.lytTypLbl);
            this.expanderPanel1.Controls.Add(this.comboLytType);
            this.expanderPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.expanderPanel1.Location = new System.Drawing.Point(0, 0);
            this.expanderPanel1.Name = "expanderPanel1";
            this.expanderPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.expanderPanel1.Size = new System.Drawing.Size(279, 344);
            this.expanderPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "Auto Layout";
            // 
            // vSpacing
            // 
            this.vSpacing.AutoSize = true;
            this.vSpacing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vSpacing.Location = new System.Drawing.Point(13, 133);
            this.vSpacing.Name = "vSpacing";
            this.vSpacing.Size = new System.Drawing.Size(91, 15);
            this.vSpacing.TabIndex = 37;
            this.vSpacing.Text = "Vertical Spacing";
            // 
            // hSpacing
            // 
            this.hSpacing.AutoSize = true;
            this.hSpacing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hSpacing.Location = new System.Drawing.Point(13, 93);
            this.hSpacing.Name = "hSpacing";
            this.hSpacing.Size = new System.Drawing.Size(107, 15);
            this.hSpacing.TabIndex = 36;
            this.hSpacing.Text = "Horizontal Spacing";
            // 
            // apply
            // 
            this.apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.apply.FlatAppearance.BorderSize = 0;
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply.ForeColor = System.Drawing.Color.White;
            this.apply.Location = new System.Drawing.Point(109, 293);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(80, 30);
            this.apply.TabIndex = 46;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = false;
            // 
            // txtHSpacing
            // 
            this.txtHSpacing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSpacing.Location = new System.Drawing.Point(144, 91);
            this.txtHSpacing.MaxLength = 3;
            this.txtHSpacing.Name = "txtHSpacing";
            this.txtHSpacing.Size = new System.Drawing.Size(110, 23);
            this.txtHSpacing.TabIndex = 38;
            // 
            // chkAutoLayout
            // 
            this.chkAutoLayout.AutoSize = true;
            this.chkAutoLayout.FlatAppearance.BorderSize = 0;
            this.chkAutoLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAutoLayout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoLayout.Location = new System.Drawing.Point(144, 255);
            this.chkAutoLayout.Name = "chkAutoLayout";
            this.chkAutoLayout.Size = new System.Drawing.Size(12, 11);
            this.chkAutoLayout.TabIndex = 44;
            this.chkAutoLayout.UseVisualStyleBackColor = true;
            // 
            // txtVSpacing
            // 
            this.txtVSpacing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVSpacing.Location = new System.Drawing.Point(144, 131);
            this.txtVSpacing.MaxLength = 3;
            this.txtVSpacing.Name = "txtVSpacing";
            this.txtVSpacing.Size = new System.Drawing.Size(110, 23);
            this.txtVSpacing.TabIndex = 39;
            // 
            // txtTMarigin
            // 
            this.txtTMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTMarigin.Location = new System.Drawing.Point(144, 211);
            this.txtTMarigin.MaxLength = 3;
            this.txtTMarigin.Name = "txtTMarigin";
            this.txtTMarigin.Size = new System.Drawing.Size(110, 23);
            this.txtTMarigin.TabIndex = 43;
            // 
            // lMarigin
            // 
            this.lMarigin.AutoSize = true;
            this.lMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMarigin.Location = new System.Drawing.Point(13, 173);
            this.lMarigin.Name = "lMarigin";
            this.lMarigin.Size = new System.Drawing.Size(71, 15);
            this.lMarigin.TabIndex = 40;
            this.lMarigin.Text = "Left Marigin";
            // 
            // tMarigin
            // 
            this.tMarigin.AutoSize = true;
            this.tMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMarigin.Location = new System.Drawing.Point(13, 213);
            this.tMarigin.Name = "tMarigin";
            this.tMarigin.Size = new System.Drawing.Size(72, 15);
            this.tMarigin.TabIndex = 41;
            this.tMarigin.Text = "Top Marigin";
            // 
            // txtLMarigin
            // 
            this.txtLMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLMarigin.Location = new System.Drawing.Point(144, 171);
            this.txtLMarigin.MaxLength = 3;
            this.txtLMarigin.Name = "txtLMarigin";
            this.txtLMarigin.Size = new System.Drawing.Size(110, 23);
            this.txtLMarigin.TabIndex = 42;
            // 
            // lytTypLbl
            // 
            this.lytTypLbl.AutoSize = true;
            this.lytTypLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lytTypLbl.Location = new System.Drawing.Point(13, 53);
            this.lytTypLbl.Name = "lytTypLbl";
            this.lytTypLbl.Size = new System.Drawing.Size(72, 15);
            this.lytTypLbl.TabIndex = 35;
            this.lytTypLbl.Text = "Layout Type";
            // 
            // comboLytType
            // 
            this.comboLytType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLytType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLytType.FormattingEnabled = true;
            this.comboLytType.Items.AddRange(new object[] {
            "WaterFall",
            "Horizontal"});
            this.comboLytType.Location = new System.Drawing.Point(144, 51);
            this.comboLytType.Name = "comboLytType";
            this.comboLytType.Size = new System.Drawing.Size(110, 23);
            this.comboLytType.TabIndex = 34;
            // 
            // diagram1
            // 
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.HScroll = true;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(2, 2);
            this.diagram1.MetroScrollBars = true;
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.Size = new System.Drawing.Size(749, 607);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 2;
            this.diagram1.Text = "diagram1";
            this.diagram1.Model.LineBridgingEnabled = true;
            // 
            // 
            // 
            this.diagram1.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram1.View.Controller = this.diagram1.Controller;
            this.diagram1.View.Grid.MinPixelSpacing = 4F;
            this.diagram1.View.Grid.Visible = false;
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
            this.model1.DocumentSize.Height = 1169F;
            this.model1.DocumentSize.Width = 1227F;
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LineStyle.LineWidth = 0F;
            this.model1.LogicalSize = new System.Drawing.SizeF(1227F, 1169F);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // lytProp
            // 
            this.lytProp.AutoEllipsis = true;
            this.lytProp.BackColor = System.Drawing.Color.White;
            this.lytProp.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lytProp.Location = new System.Drawing.Point(13, 20);
            this.lytProp.Name = "lytProp";
            this.lytProp.Size = new System.Drawing.Size(99, 20);
            this.lytProp.TabIndex = 47;
            this.lytProp.Text = "Properties";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Expander";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 611);
            this.Controls.Add(this.diagram1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrgChartLayout";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.expanderPanel2.ResumeLayout(false);
            this.expanderPanel2.PerformLayout();
            this.expanderPanel1.ResumeLayout(false);
            this.expanderPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel expanderPanel2;
        private System.Windows.Forms.Label expSymShapeLbl;
        private System.Windows.Forms.ComboBox comboBShape;
        private System.Windows.Forms.Label bShape;
        private System.Windows.Forms.ComboBox comboExpSymbol;
        private System.Windows.Forms.Panel expanderPanel1;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Syncfusion.Windows.Forms.Diagram.Model model1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vSpacing;
        private System.Windows.Forms.Label hSpacing;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.TextBox txtHSpacing;
        private System.Windows.Forms.CheckBox chkAutoLayout;
        private System.Windows.Forms.TextBox txtVSpacing;
        private System.Windows.Forms.TextBox txtTMarigin;
        private System.Windows.Forms.Label lMarigin;
        private System.Windows.Forms.Label tMarigin;
        private System.Windows.Forms.TextBox txtLMarigin;
        private System.Windows.Forms.Label lytTypLbl;
        private System.Windows.Forms.ComboBox comboLytType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lytProp;

    }
}

