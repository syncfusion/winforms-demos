#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using System.Drawing;
namespace Virtual_Import
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabBarSplitterControl1 = new Syncfusion.Windows.Forms.TabBarSplitterControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.importBordersCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.importStylesCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.importButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importBordersCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importStylesCheckBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBarSplitterControl1
            // 
            this.tabBarSplitterControl1.ActivePageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
            this.tabBarSplitterControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabBarSplitterControl1.BeforeTouchSize = new System.Drawing.Size(1081, 593);
            this.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabBarSplitterControl1.EnabledColor = System.Drawing.SystemColors.WindowText;
            this.tabBarSplitterControl1.EnableOffice2013Style = true;
            this.tabBarSplitterControl1.Location = new System.Drawing.Point(3, 52);
            this.tabBarSplitterControl1.Name = "tabBarSplitterControl1";
            this.tabBarSplitterControl1.RelativeWidth = (int)DpiAware.LogicalToDeviceUnits(56.0f);
            this.tabBarSplitterControl1.ScrollButtons = Syncfusion.Windows.Forms.DisplayArrowButtons.Single;
            this.tabBarSplitterControl1.Size = new System.Drawing.Size(1081, 593);
            this.tabBarSplitterControl1.SizeFactor = 1.5D;
            this.tabBarSplitterControl1.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarSplitterControl1.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Metro;
            this.tabBarSplitterControl1.TabFolderDelta = 11;
            this.tabBarSplitterControl1.TabIndex = 0;
            this.tabBarSplitterControl1.Text = "tabBarSplitterControl1";
            this.tabBarSplitterControl1.ThemesEnabled = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.importBordersCheckBox);
            this.panel1.Controls.Add(this.importStylesCheckBox);
            this.panel1.Controls.Add(this.importButton);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 46);
            this.panel1.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.saveBtn.BeforeTouchSize = new System.Drawing.Size(96, 38);
            this.saveBtn.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.IsBackStageButton = false;
            this.saveBtn.Location = new System.Drawing.Point(319, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(96, 38);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save Excel";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // importBordersCheckBox
            // 
            this.importBordersCheckBox.BeforeTouchSize = new System.Drawing.Size(106, 21);
            this.importBordersCheckBox.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.importBordersCheckBox.Checked = true;
            this.importBordersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.importBordersCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBordersCheckBox.Location = new System.Drawing.Point(105, 20);
            this.importBordersCheckBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.importBordersCheckBox.Name = "importBordersCheckBox";
            this.importBordersCheckBox.Size = new System.Drawing.Size(106, 21);
            this.importBordersCheckBox.TabIndex = 3;
            this.importBordersCheckBox.Text = "ImportBorders";
            this.importBordersCheckBox.ThemesEnabled = false;
            // 
            // importStylesCheckBox
            // 
            this.importStylesCheckBox.BeforeTouchSize = new System.Drawing.Size(91, 21);
            this.importStylesCheckBox.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.importStylesCheckBox.Checked = true;
            this.importStylesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.importStylesCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importStylesCheckBox.Location = new System.Drawing.Point(105, 3);
            this.importStylesCheckBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.importStylesCheckBox.Name = "importStylesCheckBox";
            this.importStylesCheckBox.Size = new System.Drawing.Size(91, 21);
            this.importStylesCheckBox.TabIndex = 2;
            this.importStylesCheckBox.Text = "ImportStyles";
            this.importStylesCheckBox.ThemesEnabled = false;
            // 
            // importButton
            // 
            this.importButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.importButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.importButton.BeforeTouchSize = new System.Drawing.Size(96, 38);
            this.importButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.ForeColor = System.Drawing.Color.White;
            this.importButton.IsBackStageButton = false;
            this.importButton.Location = new System.Drawing.Point(3, 3);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(96, 38);
            this.importButton.TabIndex = 1;
            this.importButton.Text = "Import Excel";
            this.importButton.UseVisualStyle = false;
            this.importButton.UseVisualStyleBackColor = false;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 649);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabBarSplitterControl1);
            this.Name = "Form1";
            this.Text = "Virtual Importing";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.importBordersCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importStylesCheckBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.TabBarSplitterControl tabBarSplitterControl1;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.ButtonAdv importButton;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv importBordersCheckBox;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv importStylesCheckBox;
        private Syncfusion.Windows.Forms.ButtonAdv saveBtn;

    }
}

