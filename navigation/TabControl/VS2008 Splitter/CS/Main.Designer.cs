#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using System.Drawing;
using System.Windows.Forms;

namespace TabSplitterContainer_2005
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabbedMDIManager1 = new Syncfusion.Windows.Forms.Tools.TabbedMDIManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabbedMDIManager1
            // 
            this.tabbedMDIManager1.AttachedTo = this;
            this.tabbedMDIManager1.CloseButtonBackColor = System.Drawing.Color.White;
            this.tabbedMDIManager1.CloseButtonToolTip = "";
            this.tabbedMDIManager1.DropDownButtonToolTip = "";
            this.tabbedMDIManager1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabbedMDIManager1.NeedUpdateHostedForm = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxAdv1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 43);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(210, 21);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Office2016Colorful",
            "Office2016White",
            "Office2016Black",
            "Office2016DarkGray",
            "Default",
            "Office2019Colorful",
            "HighContrastBlack"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(548, 12);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(210, 21);
            this.comboBoxAdv1.TabIndex = 2;
            this.comboBoxAdv1.Text = "Office2019Colorful";
            // 
            // Main
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Tab Splitter Container";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.ResumeLayout(false);

        }

        
        private void Main_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            foreach (Form splitWindow in this.tabbedMDIManager1.MdiChildren)
            {
                if (this.ActiveMdiChild != null && this.ActiveMdiChild.Text == splitWindow.Text)
                {
                    splitWindow.Close();
                }
            }
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabbedMDIManager tabbedMDIManager1;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
    }
}