#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.Controls;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;

namespace WindowsFormsApp48
{
    partial class Form1 : SfForm
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

        #region Windows Form Designer - Generated Code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.clearButtonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.addButtonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.closeButtonAdv = new Syncfusion.Windows.Forms.ButtonAdv();
            this.sfListView1 = new Syncfusion.WinForms.ListView.SfListView();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.showPopupButtonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearButtonAdv2
            // 
            this.clearButtonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.clearButtonAdv2.BeforeTouchSize = new System.Drawing.Size(62, 20);
            this.clearButtonAdv2.KeepFocusRectangle = false;
            this.clearButtonAdv2.Name = "clearButtonAdv2";
            this.clearButtonAdv2.TabIndex = 2;
            this.clearButtonAdv2.Text = "Clear";
            this.clearButtonAdv2.ThemeName = "Office2019Colorful";
            this.clearButtonAdv2.UseVisualStyle = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Name = "label2";
            this.label2.TabIndex = 7;
            this.label2.Text = "Countries";
            // 
            // addButtonAdv1
            // 
            this.addButtonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.addButtonAdv1.BackColor = System.Drawing.Color.White;
            this.addButtonAdv1.BeforeTouchSize = new System.Drawing.Size(50, 20);
            this.addButtonAdv1.KeepFocusRectangle = false;
            this.addButtonAdv1.Name = "addButtonAdv1";
            this.addButtonAdv1.TabIndex = 1;
            this.addButtonAdv1.Text = "Add";
            this.addButtonAdv1.ThemeName = "Office2019Colorful";
            this.addButtonAdv1.UseVisualStyle = true;
            // 
            // closeButtonAdv
            // 
            this.closeButtonAdv.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.closeButtonAdv.BackColor = System.Drawing.Color.White;
            this.closeButtonAdv.BeforeTouchSize = new System.Drawing.Size(60, 20);
            this.closeButtonAdv.KeepFocusRectangle = false;
            this.closeButtonAdv.Name = "closeButtonAdv";
            this.closeButtonAdv.TabIndex = 1;
            this.closeButtonAdv.Text = "Close";
            this.closeButtonAdv.ThemeName = "Office2019Colorful";
            this.closeButtonAdv.UseVisualStyle = true;
            // 
            // sfListView1
            // 
            this.sfListView1.AccessibleName = "ScrollControl";
            this.sfListView1.AllowDrop = true;
            this.sfListView1.AllowSelectAll = true;
            this.sfListView1.BackColor = System.Drawing.Color.White;
            this.sfListView1.HotTracking = true;
            this.sfListView1.Name = "sfListView1";
            this.sfListView1.ShowCheckBoxes = true;
            this.sfListView1.TabIndex = 0;
            this.sfListView1.Text = "sfListView1";
            this.sfListView1.ThemeName = "Office2019Colorful";
            this.sfListView1.VerticalScrollBarVisible = true;
            // 
            // textBoxExt1
            // 
            bannerTextInfo1.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo1.Text = "Press Alt + Down Arrow to show Popup Container";
            bannerTextInfo1.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.textBoxExt1, bannerTextInfo1);
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(335, 23);
            this.textBoxExt1.BorderColor = System.Drawing.Color.LightGray;
            this.textBoxExt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBoxExt1.Location = new System.Drawing.Point(252, 211);
            this.textBoxExt1.Size = new System.Drawing.Size(272, 19);
            this.textBoxExt1.Multiline = true;
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.TabIndex = 0;
            // 
            // showPopupButtonAdv3
            // 
            this.showPopupButtonAdv3.BackColor = System.Drawing.Color.White;
            this.showPopupButtonAdv3.BeforeTouchSize = new System.Drawing.Size(37, 24);
            this.showPopupButtonAdv3.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.ComboXPDown;
            this.showPopupButtonAdv3.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.showPopupButtonAdv3.KeepFocusRectangle = false;
            this.showPopupButtonAdv3.Name = "showPopupButtonAdv3";
            this.showPopupButtonAdv3.TabIndex = 4;
            this.showPopupButtonAdv3.Text = "Popup_Click";
            this.showPopupButtonAdv3.ThemeName = "Office2019Colorful";
            this.showPopupButtonAdv3.UseVisualStyle = true;
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BackColor = System.Drawing.Color.White;
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.ParentControl = this.gradientPanel1;
            this.popupControlContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.popupControlContainer1.TabIndex = 0;
            this.popupControlContainer1.Visible = false;
            this.popupControlContainer1.Controls.Add(this.gradientPanel1);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.LightGray;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.TabIndex = 8;
            this.gradientPanel1.Visible = false;
            this.gradientPanel1.Controls.Add(this.sfListView1);
            this.gradientPanel1.Controls.Add(this.clearButtonAdv2);
            this.gradientPanel1.Controls.Add(this.addButtonAdv1);
            this.gradientPanel1.Controls.Add(this.closeButtonAdv);
            this.gradientPanel1.Controls.Add(this.label2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(830, 584);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showPopupButtonAdv3);
            this.Controls.Add(this.textBoxExt1);
            this.Controls.Add(this.popupControlContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Popup Container Demo";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion
        private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
        private Syncfusion.Windows.Forms.ButtonAdv clearButtonAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv addButtonAdv1;
        private Syncfusion.Windows.Forms.ButtonAdv closeButtonAdv;
        private Syncfusion.WinForms.ListView.SfListView sfListView1;
        private Syncfusion.Windows.Forms.ButtonAdv showPopupButtonAdv3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
    }
}

