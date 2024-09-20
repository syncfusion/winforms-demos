#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;

namespace HeaderFooter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowControlCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowFooterCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowHeaderCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sfListView1 = new Syncfusion.WinForms.ListView.SfListView();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowControlCheckBox);
            this.groupBox1.Controls.Add(this.ShowFooterCheckBox);
            this.groupBox1.Controls.Add(this.ShowHeaderCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(466, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 533);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // ShowControlCheckBox
            // 
            this.ShowControlCheckBox.AutoSize = true;
            this.ShowControlCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowControlCheckBox.Location = new System.Drawing.Point(32, 139);
            this.ShowControlCheckBox.Name = "ShowControlCheckBox";
            this.ShowControlCheckBox.Size = new System.Drawing.Size(220, 20);
            this.ShowControlCheckBox.TabIndex = 9;
            this.ShowControlCheckBox.Text = "Show Search TextBox in Header";
            this.ShowControlCheckBox.UseVisualStyleBackColor = true;
            this.ShowControlCheckBox.CheckedChanged += new System.EventHandler(this.OnShowControlCheckBoxChanged);
            // 
            // ShowFooterCheckBox
            // 
            this.ShowFooterCheckBox.AutoSize = true;
            this.ShowFooterCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowFooterCheckBox.Location = new System.Drawing.Point(32, 93);
            this.ShowFooterCheckBox.Name = "ShowFooterCheckBox";
            this.ShowFooterCheckBox.Size = new System.Drawing.Size(102, 20);
            this.ShowFooterCheckBox.TabIndex = 8;
            this.ShowFooterCheckBox.Text = "Show Footer";
            this.ShowFooterCheckBox.UseVisualStyleBackColor = true;
            this.ShowFooterCheckBox.CheckedChanged += new System.EventHandler(this.OnShowFooterCheckBoxCheckedChanged);
            // 
            // ShowHeaderCheckBox
            // 
            this.ShowHeaderCheckBox.AutoSize = true;
            this.ShowHeaderCheckBox.Checked = true;
            this.ShowHeaderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowHeaderCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowHeaderCheckBox.Location = new System.Drawing.Point(32, 47);
            this.ShowHeaderCheckBox.Name = "ShowHeaderCheckBox";
            this.ShowHeaderCheckBox.Size = new System.Drawing.Size(109, 20);
            this.ShowHeaderCheckBox.TabIndex = 7;
            this.ShowHeaderCheckBox.Text = "Show Header";
            this.ShowHeaderCheckBox.UseVisualStyleBackColor = true;
            this.ShowHeaderCheckBox.CheckedChanged += new System.EventHandler(this.OnShowHeaderCheckBoxCheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sfListView1);
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 526);
            this.panel2.TabIndex = 2;
            // 
            // sfListView1
            // 
            this.sfListView1.AccessibleName = "ScrollControl";
            this.sfListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfListView1.Location = new System.Drawing.Point(0, 0);
            this.sfListView1.Name = "sfListView1";
            this.sfListView1.Size = new System.Drawing.Size(424, 526);
            this.sfListView1.TabIndex = 0;
            this.sfListView1.Text = "sfListView1";
            // 
            // Form1
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Header and Footer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.ListView.SfListView sfListView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ShowControlCheckBox;
        private System.Windows.Forms.CheckBox ShowFooterCheckBox;
        private System.Windows.Forms.CheckBox ShowHeaderCheckBox;
    }
}

