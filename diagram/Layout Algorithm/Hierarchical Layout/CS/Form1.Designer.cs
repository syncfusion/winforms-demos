#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;

namespace HierarchicalLayout
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboLytDirection = new System.Windows.Forms.ComboBox();
            this.txtLMarigin = new System.Windows.Forms.TextBox();
            this.txtTMarigin = new System.Windows.Forms.TextBox();
            this.tMarigin = new System.Windows.Forms.Label();
            this.txtVSpacing = new System.Windows.Forms.TextBox();
            this.lMarigin = new System.Windows.Forms.Label();
            this.hSpacing = new System.Windows.Forms.Label();
            this.vSpacing = new System.Windows.Forms.Label();
            this.txtHSpacing = new System.Windows.Forms.TextBox();
            this.apply = new System.Windows.Forms.Button();
            this.addMember = new System.Windows.Forms.Button();
            this.chkAutoLayout = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.lytProp = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lytProp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboLytDirection);
            this.panel2.Controls.Add(this.txtLMarigin);
            this.panel2.Controls.Add(this.txtTMarigin);
            this.panel2.Controls.Add(this.tMarigin);
            this.panel2.Controls.Add(this.txtVSpacing);
            this.panel2.Controls.Add(this.lMarigin);
            this.panel2.Controls.Add(this.hSpacing);
            this.panel2.Controls.Add(this.vSpacing);
            this.panel2.Controls.Add(this.txtHSpacing);
            this.panel2.Controls.Add(this.apply);
            this.panel2.Controls.Add(this.addMember);
            this.panel2.Controls.Add(this.chkAutoLayout);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(766, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panel2.Size = new System.Drawing.Size(264, 520);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Direction Selection";
            // 
            // comboLytDirection
            // 
            this.comboLytDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLytDirection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLytDirection.FormattingEnabled = true;
            this.comboLytDirection.Items.AddRange(new object[] {
            "TopToBottom",
            "TopRight",
            "TopLeft",
            "RightToLeft",
            "LeftToRight",
            "BottomToTop",
            "BottomLeft",
            "BottomRight"});
            this.comboLytDirection.Location = new System.Drawing.Point(148, 245);
            this.comboLytDirection.Name = "comboLytDirection";
            this.comboLytDirection.Size = new System.Drawing.Size(100, 23);
            this.comboLytDirection.TabIndex = 37;
            this.comboLytDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // txtLMarigin
            // 
            this.txtLMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLMarigin.Location = new System.Drawing.Point(148, 125);
            this.txtLMarigin.MaxLength = 3;
            this.txtLMarigin.Name = "txtLMarigin";
            this.txtLMarigin.Size = new System.Drawing.Size(100, 23);
            this.txtLMarigin.TabIndex = 26;
            // 
            // txtTMarigin
            // 
            this.txtTMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTMarigin.Location = new System.Drawing.Point(148, 165);
            this.txtTMarigin.MaxLength = 3;
            this.txtTMarigin.Name = "txtTMarigin";
            this.txtTMarigin.Size = new System.Drawing.Size(100, 23);
            this.txtTMarigin.TabIndex = 27;
            // 
            // tMarigin
            // 
            this.tMarigin.AutoSize = true;
            this.tMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMarigin.Location = new System.Drawing.Point(13, 167);
            this.tMarigin.Name = "tMarigin";
            this.tMarigin.Size = new System.Drawing.Size(72, 15);
            this.tMarigin.TabIndex = 25;
            this.tMarigin.Text = "Top Marigin";
            // 
            // txtVSpacing
            // 
            this.txtVSpacing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVSpacing.Location = new System.Drawing.Point(148, 85);
            this.txtVSpacing.MaxLength = 3;
            this.txtVSpacing.Name = "txtVSpacing";
            this.txtVSpacing.Size = new System.Drawing.Size(100, 23);
            this.txtVSpacing.TabIndex = 23;
            // 
            // lMarigin
            // 
            this.lMarigin.AutoSize = true;
            this.lMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMarigin.Location = new System.Drawing.Point(13, 127);
            this.lMarigin.Name = "lMarigin";
            this.lMarigin.Size = new System.Drawing.Size(71, 15);
            this.lMarigin.TabIndex = 24;
            this.lMarigin.Text = "Left Marigin";
            // 
            // hSpacing
            // 
            this.hSpacing.AutoSize = true;
            this.hSpacing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hSpacing.Location = new System.Drawing.Point(13, 48);
            this.hSpacing.Name = "hSpacing";
            this.hSpacing.Size = new System.Drawing.Size(107, 15);
            this.hSpacing.TabIndex = 20;
            this.hSpacing.Text = "Horizontal Spacing";
            // 
            // vSpacing
            // 
            this.vSpacing.AutoSize = true;
            this.vSpacing.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.vSpacing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vSpacing.Location = new System.Drawing.Point(13, 87);
            this.vSpacing.Name = "vSpacing";
            this.vSpacing.Size = new System.Drawing.Size(91, 15);
            this.vSpacing.TabIndex = 21;
            this.vSpacing.Text = "Vertical Spacing";
            // 
            // txtHSpacing
            // 
            this.txtHSpacing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSpacing.Location = new System.Drawing.Point(148, 46);
            this.txtHSpacing.MaxLength = 3;
            this.txtHSpacing.Name = "txtHSpacing";
            this.txtHSpacing.Size = new System.Drawing.Size(100, 23);
            this.txtHSpacing.TabIndex = 22;
            // 
            // apply
            // 
            this.apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.apply.FlatAppearance.BorderSize = 0;
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply.ForeColor = System.Drawing.Color.White;
            this.apply.Location = new System.Drawing.Point(103, 327);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(80, 30);
            this.apply.TabIndex = 33;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // addMember
            // 
            this.addMember.BackColor = System.Drawing.Color.Transparent;
            this.addMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMember.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addMember.Location = new System.Drawing.Point(12, 285);
            this.addMember.Name = "addMember";
            this.addMember.Size = new System.Drawing.Size(98, 23);
            this.addMember.TabIndex = 33;
            this.addMember.Text = "Add Member ";
            this.addMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addMember.UseVisualStyleBackColor = false;
            this.addMember.Click += new System.EventHandler(this.addMember_Click);
            // 
            // chkAutoLayout
            // 
            this.chkAutoLayout.FlatAppearance.BorderSize = 0;
            this.chkAutoLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAutoLayout.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoLayout.Location = new System.Drawing.Point(148, 193);
            this.chkAutoLayout.Name = "chkAutoLayout";
            this.chkAutoLayout.Size = new System.Drawing.Size(16, 33);
            this.chkAutoLayout.TabIndex = 28;
            this.chkAutoLayout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Auto Layout";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.diagram1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 520);
            this.panel3.TabIndex = 1;
            // 
            // diagram1
            // 
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.HScroll = true;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.MetroScrollBars = true;
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.Size = new System.Drawing.Size(764, 520);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 0;
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
            this.model1.DocumentSize.Height = (int)DpiAware.LogicalToDeviceUnits(1000F);
            this.model1.DocumentSize.Width = (int)DpiAware.LogicalToDeviceUnits(1000F);
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LineStyle.LineWidth = 0F;
            this.model1.LogicalSize = new System.Drawing.SizeF(DpiAware.LogicalToDeviceUnits(1000F), DpiAware.LogicalToDeviceUnits(1000F));
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // lytProp
            // 
            this.lytProp.AutoEllipsis = true;
            this.lytProp.BackColor = System.Drawing.Color.White;
            this.lytProp.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lytProp.Location = new System.Drawing.Point(9, 15);
            this.lytProp.Name = "lytProp";
            this.lytProp.Size = new System.Drawing.Size(99, 20);
            this.lytProp.TabIndex = 38;
            this.lytProp.Text = "Properties";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 524);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hierarchical Layout";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTMarigin;
        private System.Windows.Forms.TextBox txtLMarigin;
        private System.Windows.Forms.Label tMarigin;
        private System.Windows.Forms.Label lMarigin;
        private System.Windows.Forms.TextBox txtVSpacing;
        private System.Windows.Forms.Label hSpacing;
        private System.Windows.Forms.Label vSpacing;
        private System.Windows.Forms.TextBox txtHSpacing;
        private System.Windows.Forms.CheckBox chkAutoLayout;
        private System.Windows.Forms.Button addMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Panel panel3;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Syncfusion.Windows.Forms.Diagram.Model model1;
        private System.Windows.Forms.ComboBox comboLytDirection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lytProp;

    }
}

