#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace TableLayout
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
            this.lytProp = new System.Windows.Forms.Label();
            this.comboCellSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboExpandMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaxRowsCount = new System.Windows.Forms.Label();
            this.txtMaxRowsCount = new System.Windows.Forms.TextBox();
            this.lblTableMaxHeight = new System.Windows.Forms.Label();
            this.txtMaxWidth = new System.Windows.Forms.TextBox();
            this.lblMaxColumnCount = new System.Windows.Forms.Label();
            this.lblTableMaxWidth = new System.Windows.Forms.Label();
            this.txtMaxHeight = new System.Windows.Forms.TextBox();
            this.apply = new System.Windows.Forms.Button();
            this.txtTMarigin = new System.Windows.Forms.TextBox();
            this.txtMaxColumnCount = new System.Windows.Forms.TextBox();
            this.chkAutoLayout = new System.Windows.Forms.CheckBox();
            this.txtLMarigin = new System.Windows.Forms.TextBox();
            this.txtVSpacing = new System.Windows.Forms.TextBox();
            this.lMarigin = new System.Windows.Forms.Label();
            this.tMarigin = new System.Windows.Forms.Label();
            this.txtHSpacing = new System.Windows.Forms.TextBox();
            this.vSpacing = new System.Windows.Forms.Label();
            this.hSpacing = new System.Windows.Forms.Label();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lytProp);
            this.panel2.Controls.Add(this.comboCellSize);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboExpandMode);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblMaxRowsCount);
            this.panel2.Controls.Add(this.txtMaxRowsCount);
            this.panel2.Controls.Add(this.lblTableMaxHeight);
            this.panel2.Controls.Add(this.txtMaxWidth);
            this.panel2.Controls.Add(this.lblMaxColumnCount);
            this.panel2.Controls.Add(this.lblTableMaxWidth);
            this.panel2.Controls.Add(this.txtMaxHeight);
            this.panel2.Controls.Add(this.apply);
            this.panel2.Controls.Add(this.txtTMarigin);
            this.panel2.Controls.Add(this.txtMaxColumnCount);
            this.panel2.Controls.Add(this.chkAutoLayout);
            this.panel2.Controls.Add(this.txtLMarigin);
            this.panel2.Controls.Add(this.txtVSpacing);
            this.panel2.Controls.Add(this.lMarigin);
            this.panel2.Controls.Add(this.tMarigin);
            this.panel2.Controls.Add(this.txtHSpacing);
            this.panel2.Controls.Add(this.vSpacing);
            this.panel2.Controls.Add(this.hSpacing);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(590, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(259, 603);
            this.panel2.TabIndex = 1;
            // 
            // lytProp
            // 
            this.lytProp.AutoEllipsis = true;
            this.lytProp.BackColor = System.Drawing.Color.White;
            this.lytProp.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lytProp.Location = new System.Drawing.Point(9, 11);
            this.lytProp.Name = "lytProp";
            this.lytProp.Size = new System.Drawing.Size(99, 20);
            this.lytProp.TabIndex = 53;
            this.lytProp.Text = "Properties";
            // 
            // comboCellSize
            // 
            this.comboCellSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCellSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCellSize.FormattingEnabled = true;
            this.comboCellSize.Items.AddRange(new object[] {
            "Equal to Max",
            "Minimal",
            "Minimal Table"});
            this.comboCellSize.Location = new System.Drawing.Point(146, 449);
            this.comboCellSize.Name = "comboCellSize";
            this.comboCellSize.Size = new System.Drawing.Size(100, 23);
            this.comboCellSize.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Cell Size Mode";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboExpandMode
            // 
            this.comboExpandMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboExpandMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboExpandMode.FormattingEnabled = true;
            this.comboExpandMode.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.comboExpandMode.Location = new System.Drawing.Point(146, 409);
            this.comboExpandMode.Name = "comboExpandMode";
            this.comboExpandMode.Size = new System.Drawing.Size(100, 23);
            this.comboExpandMode.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Expand Mode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Auto Layout";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaxRowsCount
            // 
            this.lblMaxRowsCount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMaxRowsCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxRowsCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMaxRowsCount.Location = new System.Drawing.Point(12, 288);
            this.lblMaxRowsCount.Name = "lblMaxRowsCount";
            this.lblMaxRowsCount.Size = new System.Drawing.Size(97, 20);
            this.lblMaxRowsCount.TabIndex = 44;
            this.lblMaxRowsCount.Text = "Max rows count";
            this.lblMaxRowsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaxRowsCount
            // 
            this.txtMaxRowsCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxRowsCount.Location = new System.Drawing.Point(146, 285);
            this.txtMaxRowsCount.MaxLength = 3;
            this.txtMaxRowsCount.Name = "txtMaxRowsCount";
            this.txtMaxRowsCount.Size = new System.Drawing.Size(100, 23);
            this.txtMaxRowsCount.TabIndex = 45;
            this.txtMaxRowsCount.Text = "5";
            // 
            // lblTableMaxHeight
            // 
            this.lblTableMaxHeight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTableMaxHeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableMaxHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTableMaxHeight.Location = new System.Drawing.Point(12, 248);
            this.lblTableMaxHeight.Name = "lblTableMaxHeight";
            this.lblTableMaxHeight.Size = new System.Drawing.Size(112, 20);
            this.lblTableMaxHeight.TabIndex = 40;
            this.lblTableMaxHeight.Text = "Max height";
            this.lblTableMaxHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaxWidth
            // 
            this.txtMaxWidth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxWidth.Location = new System.Drawing.Point(146, 206);
            this.txtMaxWidth.MaxLength = 3;
            this.txtMaxWidth.Name = "txtMaxWidth";
            this.txtMaxWidth.Size = new System.Drawing.Size(100, 23);
            this.txtMaxWidth.TabIndex = 39;
            this.txtMaxWidth.Text = "600";
            // 
            // lblMaxColumnCount
            // 
            this.lblMaxColumnCount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMaxColumnCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxColumnCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMaxColumnCount.Location = new System.Drawing.Point(12, 328);
            this.lblMaxColumnCount.Name = "lblMaxColumnCount";
            this.lblMaxColumnCount.Size = new System.Drawing.Size(112, 20);
            this.lblMaxColumnCount.TabIndex = 42;
            this.lblMaxColumnCount.Text = "Max column count";
            this.lblMaxColumnCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTableMaxWidth
            // 
            this.lblTableMaxWidth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTableMaxWidth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableMaxWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTableMaxWidth.Location = new System.Drawing.Point(12, 206);
            this.lblTableMaxWidth.Name = "lblTableMaxWidth";
            this.lblTableMaxWidth.Size = new System.Drawing.Size(73, 20);
            this.lblTableMaxWidth.TabIndex = 38;
            this.lblTableMaxWidth.Text = "Max width";
            this.lblTableMaxWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaxHeight
            // 
            this.txtMaxHeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxHeight.Location = new System.Drawing.Point(146, 248);
            this.txtMaxHeight.MaxLength = 3;
            this.txtMaxHeight.Name = "txtMaxHeight";
            this.txtMaxHeight.Size = new System.Drawing.Size(100, 23);
            this.txtMaxHeight.TabIndex = 41;
            this.txtMaxHeight.Text = "500";
            // 
            // apply
            // 
            this.apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.apply.FlatAppearance.BorderSize = 0;
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply.ForeColor = System.Drawing.Color.White;
            this.apply.Location = new System.Drawing.Point(107, 488);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(80, 30);
            this.apply.TabIndex = 33;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // txtTMarigin
            // 
            this.txtTMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTMarigin.Location = new System.Drawing.Point(146, 168);
            this.txtTMarigin.MaxLength = 3;
            this.txtTMarigin.Name = "txtTMarigin";
            this.txtTMarigin.Size = new System.Drawing.Size(100, 23);
            this.txtTMarigin.TabIndex = 35;
            // 
            // txtMaxColumnCount
            // 
            this.txtMaxColumnCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxColumnCount.Location = new System.Drawing.Point(146, 325);
            this.txtMaxColumnCount.MaxLength = 3;
            this.txtMaxColumnCount.Name = "txtMaxColumnCount";
            this.txtMaxColumnCount.Size = new System.Drawing.Size(100, 23);
            this.txtMaxColumnCount.TabIndex = 43;
            this.txtMaxColumnCount.Text = "4";
            // 
            // chkAutoLayout
            // 
            this.chkAutoLayout.AutoSize = true;
            this.chkAutoLayout.FlatAppearance.BorderSize = 0;
            this.chkAutoLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAutoLayout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoLayout.Location = new System.Drawing.Point(146, 368);
            this.chkAutoLayout.Name = "chkAutoLayout";
            this.chkAutoLayout.Size = new System.Drawing.Size(12, 11);
            this.chkAutoLayout.TabIndex = 36;
            this.chkAutoLayout.UseVisualStyleBackColor = true;
            // 
            // txtLMarigin
            // 
            this.txtLMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLMarigin.Location = new System.Drawing.Point(146, 128);
            this.txtLMarigin.MaxLength = 3;
            this.txtLMarigin.Name = "txtLMarigin";
            this.txtLMarigin.Size = new System.Drawing.Size(100, 23);
            this.txtLMarigin.TabIndex = 34;
            // 
            // txtVSpacing
            // 
            this.txtVSpacing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVSpacing.Location = new System.Drawing.Point(146, 88);
            this.txtVSpacing.MaxLength = 3;
            this.txtVSpacing.Name = "txtVSpacing";
            this.txtVSpacing.Size = new System.Drawing.Size(100, 23);
            this.txtVSpacing.TabIndex = 31;
            // 
            // lMarigin
            // 
            this.lMarigin.AutoSize = true;
            this.lMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMarigin.Location = new System.Drawing.Point(9, 128);
            this.lMarigin.Name = "lMarigin";
            this.lMarigin.Size = new System.Drawing.Size(71, 15);
            this.lMarigin.TabIndex = 32;
            this.lMarigin.Text = "Left Marigin";
            // 
            // tMarigin
            // 
            this.tMarigin.AutoSize = true;
            this.tMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMarigin.Location = new System.Drawing.Point(9, 170);
            this.tMarigin.Name = "tMarigin";
            this.tMarigin.Size = new System.Drawing.Size(72, 15);
            this.tMarigin.TabIndex = 33;
            this.tMarigin.Text = "Top Marigin";
            // 
            // txtHSpacing
            // 
            this.txtHSpacing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSpacing.Location = new System.Drawing.Point(146, 48);
            this.txtHSpacing.MaxLength = 3;
            this.txtHSpacing.Name = "txtHSpacing";
            this.txtHSpacing.Size = new System.Drawing.Size(100, 23);
            this.txtHSpacing.TabIndex = 30;
            // 
            // vSpacing
            // 
            this.vSpacing.AutoSize = true;
            this.vSpacing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vSpacing.Location = new System.Drawing.Point(9, 88);
            this.vSpacing.Name = "vSpacing";
            this.vSpacing.Size = new System.Drawing.Size(91, 15);
            this.vSpacing.TabIndex = 29;
            this.vSpacing.Text = "Vertical Spacing";
            // 
            // hSpacing
            // 
            this.hSpacing.AutoSize = true;
            this.hSpacing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hSpacing.Location = new System.Drawing.Point(9, 48);
            this.hSpacing.Name = "hSpacing";
            this.hSpacing.Size = new System.Drawing.Size(107, 15);
            this.hSpacing.TabIndex = 28;
            this.hSpacing.Text = "Horizontal Spacing";
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
            this.diagram1.Size = new System.Drawing.Size(588, 603);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 2;
            this.diagram1.Text = "diagram1";
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
            this.model1.DocumentSize.Width = 1000F;
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LineStyle.LineWidth = 0F;
            this.model1.LogicalSize = new System.Drawing.SizeF(1000F, 1169F);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 607);
            this.Controls.Add(this.diagram1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableLayout";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaxRowsCount;
        private System.Windows.Forms.TextBox txtMaxRowsCount;
        private System.Windows.Forms.TextBox txtMaxWidth;
        private System.Windows.Forms.Label lblTableMaxWidth;
        private System.Windows.Forms.Label lblTableMaxHeight;
        private System.Windows.Forms.TextBox txtMaxHeight;
        private System.Windows.Forms.TextBox txtMaxColumnCount;
        private System.Windows.Forms.Label lblMaxColumnCount;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.CheckBox chkAutoLayout;
        private System.Windows.Forms.TextBox txtTMarigin;
        private System.Windows.Forms.TextBox txtLMarigin;
        private System.Windows.Forms.Label tMarigin;
        private System.Windows.Forms.Label lMarigin;
        private System.Windows.Forms.TextBox txtVSpacing;
        private System.Windows.Forms.TextBox txtHSpacing;
        private System.Windows.Forms.Label vSpacing;
        private System.Windows.Forms.Label hSpacing;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Syncfusion.Windows.Forms.Diagram.Model model1;
        private System.Windows.Forms.ComboBox comboExpandMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCellSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lytProp;


    }
}

