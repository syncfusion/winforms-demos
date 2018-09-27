using Syncfusion.Windows.Forms.Tools;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NavigationDrawer_2010
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            captionLabel1 = new Syncfusion.Windows.Forms.CaptionLabel();
            this.navigationDrawer1 = new Syncfusion.Windows.Forms.Tools.NavigationDrawer();
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SlideOnTop = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Apply = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Reveal = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Push = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BottomPosition = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.TopPosition = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rightPosition = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.leftposition = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.comboboxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drawerMenuItem1 = new DrawerMenuItem();
            this.drawerMenuItem2 = new DrawerMenuItem();
            this.drawerMenuItem3 = new DrawerMenuItem();
            this.drawerMenuItem4 = new DrawerMenuItem();
            this.drawerMenuItem5 = new DrawerMenuItem();
            this.header = new DrawerHeader();
            this.SettingsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlideOnTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reveal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Push)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftposition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboboxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationDrawer1
            // 
            this.navigationDrawer1.Dock = System.Windows.Forms.DockStyle.Fill;
            header.Size = new System.Drawing.Size(header.Width, 120);
            header.Font = new System.Drawing.Font("Arial Narrow", 12, System.Drawing.FontStyle.Regular);
            this.navigationDrawer1.Items.Add(this.header);
            this.navigationDrawer1.Items.Add(this.drawerMenuItem1);
            this.navigationDrawer1.Items.Add(this.drawerMenuItem2);
            this.navigationDrawer1.Items.Add(this.drawerMenuItem3);
            this.navigationDrawer1.Items.Add(this.drawerMenuItem4);
            this.navigationDrawer1.Items.Add(this.drawerMenuItem5);
            this.navigationDrawer1.Location = new System.Drawing.Point(0, 0);
            this.navigationDrawer1.Name = "navigationDrawer1";
            this.navigationDrawer1.Size = new System.Drawing.Size(988, 719);
            this.navigationDrawer1.TabIndex = 0;
            this.navigationDrawer1.Text = "navigationDrawer1";
            this.navigationDrawer1.Style = NavigationDrawerStyle.Office2016Colorful;
            this.navigationDrawer1.Font = new System.Drawing.Font("Arial Narrow", 12, System.Drawing.FontStyle.Regular);
            // 
            // imageListAdv1
            // 
            this.imageListAdv1.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images1"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images2"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images3"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images4"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images5"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images6"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images7"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images8"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images9"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images10"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images11"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images12"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images13")))});
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.panel2);
            this.SettingsPanel.Controls.Add(this.panel3);
            this.SettingsPanel.Controls.Add(this.panel1);
            this.SettingsPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsPanel.Location = new System.Drawing.Point(534, 9);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(294, 661);
            this.SettingsPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Cancel);
            this.panel2.Controls.Add(this.SlideOnTop);
            this.panel2.Controls.Add(this.Apply);
            this.panel2.Controls.Add(this.Reveal);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboboxAdv1);
            this.panel2.Controls.Add(this.Push);
            this.panel2.Dock = System.Windows.Forms.DockStyle.None;
            this.panel2.Location = new System.Drawing.Point(0, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 500);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18,10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Transition";
            // 
            // Cancel
            // 
            this.Cancel.BeforeTouchSize = new System.Drawing.Size(85, 27);
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.IsBackStageButton = false;
            this.Cancel.Location = new System.Drawing.Point(165, 330);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(85, 27);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Reset";
            this.Cancel.UseVisualStyle = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            this.Cancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            // 
            // SlideOnTop
            // 
            this.SlideOnTop.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.SlideOnTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlideOnTop.Location = new System.Drawing.Point(42, 73);
            this.SlideOnTop.Name = "SlideOnTop";
            this.SlideOnTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SlideOnTop.Size = new System.Drawing.Size(150, 21);
            this.SlideOnTop.TabIndex = 11;
            this.SlideOnTop.Text = "Slide On Top";
            this.SlideOnTop.TextContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.SlideOnTop.ThemesEnabled = false;
            this.SlideOnTop.Style = RadioButtonAdvStyle.Office2016Colorful;
            // 
            // Apply
            // 
            this.Apply.BeforeTouchSize = new System.Drawing.Size(85, 27);
            this.Apply.IsBackStageButton = false;
            this.Apply.Location = new System.Drawing.Point(43, 330);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(85, 27);
            this.Apply.TabIndex = 14;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyle = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            this.Apply.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            // 
            // Reveal
            // 
            this.Reveal.BeforeTouchSize = new System.Drawing.Size(150, 21); 
            this.Reveal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reveal.Location = new System.Drawing.Point(42, 108);
            this.Reveal.Name = "Reveal";
            this.Reveal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Reveal.Size = new System.Drawing.Size(150, 21);
            this.Reveal.TabIndex = 12;
            this.Reveal.Text = "Reveal";
            this.Reveal.TextContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Reveal.ThemesEnabled = false;
            this.Reveal.Style = RadioButtonAdvStyle.Office2016Colorful;
            // 
            // Push
            // 
            this.Push.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.Push.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Push.Location = new System.Drawing.Point(42, 143);
            this.Push.Name = "Push";
            this.Push.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Push.Size = new System.Drawing.Size(150, 21);
            this.Push.TabIndex = 13;
            this.Push.Text = "Push";
            this.Push.TextContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Push.ThemesEnabled = false;
            this.Push.Style = RadioButtonAdvStyle.Office2016Colorful;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.None;
            this.panel3.Location = new System.Drawing.Point(0, 250);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.panel3.Size = new System.Drawing.Size(294, 2);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.None;
            this.panel4.Location = new System.Drawing.Point(0, 200);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.panel4.Size = new System.Drawing.Size(294, 2);
            this.panel4.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BottomPosition);
            this.panel1.Controls.Add(this.TopPosition);
            this.panel1.Controls.Add(this.rightPosition);
            this.panel1.Controls.Add(this.leftposition);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 322);
            this.panel1.TabIndex = 16;
            // 
            // BottomPosition
            // 
            this.BottomPosition.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.BottomPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomPosition.Location = new System.Drawing.Point(39, 192);
            this.BottomPosition.Name = "BottomPosition";
            this.BottomPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BottomPosition.Size = new System.Drawing.Size(150, 21);
            this.BottomPosition.TabIndex = 15;
            this.BottomPosition.Text = "Bottom";
            this.BottomPosition.TextContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.BottomPosition.ThemesEnabled = false;
            this.BottomPosition.Style = RadioButtonAdvStyle.Office2016Colorful;
            // 
            // TopPosition
            // 
            this.TopPosition.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.TopPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPosition.Location = new System.Drawing.Point(39, 157);
            this.TopPosition.Name = "TopPosition";
            this.TopPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TopPosition.Size = new System.Drawing.Size(150, 21);
            this.TopPosition.TabIndex = 14;
            this.TopPosition.Text = "Top";
            this.TopPosition.TextContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.TopPosition.ThemesEnabled = false;
            this.TopPosition.Style = RadioButtonAdvStyle.Office2016Colorful;
            // 
            // rightPosition
            // 
            this.rightPosition.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.rightPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPosition.Location = new System.Drawing.Point(39, 122);
            this.rightPosition.Name = "rightPosition";
            this.rightPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rightPosition.Size = new System.Drawing.Size(150, 21);
            this.rightPosition.TabIndex = 13;
            this.rightPosition.Text = "Right";
            this.rightPosition.TextContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.rightPosition.ThemesEnabled = false;
            this.rightPosition.Style = RadioButtonAdvStyle.Office2016Colorful;
            // 
            // leftposition
            // 
            this.leftposition.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.leftposition.DrawFocusRectangle = false;
            this.leftposition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftposition.Location = new System.Drawing.Point(39, 87);
            this.leftposition.Name = "leftposition";
            this.leftposition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.leftposition.Size = new System.Drawing.Size(150, 21);
            this.leftposition.TabIndex = 12;
            this.leftposition.Text = "Left";
            this.leftposition.TextContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.leftposition.ThemesEnabled = false;
            this.leftposition.Style = RadioButtonAdvStyle.Office2016Colorful;
            //
            //comboBoxAdv1
            //
            this.comboboxAdv1.Items.AddRange(new object[] {
            "Office2016Colorful",
            "Office2016White",
            "Office2016DarkGray",
            "Office2016Black"});
            this.comboboxAdv1.Location = new System.Drawing.Point(50, 270);
            this.comboboxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxAdv1.Size = new System.Drawing.Size(200,200);
            this.comboboxAdv1.Name = "Style";
            this.comboboxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboboxAdv1.SelectedIndex = 0;
            this.comboboxAdv1.ListBox.SelectionMode = SelectionMode.One;
            this.comboboxAdv1.ListBox.SelectedIndexChanged += new System.EventHandler(ComboboxAdv1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Position";
            //
            // label4
            //
            this.label4.Location = new System.Drawing.Point(20, 210);
            this.label4.Text = "Style";
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Settings";
            // 
            // drawerMenuItem1
            // 
            this.drawerMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Regular);
            this.drawerMenuItem1.ItemText = "   Home";
            this.drawerMenuItem1.Location = new System.Drawing.Point(2, 0);
            this.drawerMenuItem1.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItem1.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItem1.Name = "drawerMenuItem1";
            this.drawerMenuItem1.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItem1.TabIndex = 0;
            this.drawerMenuItem1.TextAlign = TextAlignment.Left;
            // 
            // drawerMenuItem2
            // 
            this.drawerMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Regular);
            this.drawerMenuItem2.ItemText = "People";
            this.drawerMenuItem2.Location = new System.Drawing.Point(2, 50);
            this.drawerMenuItem2.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItem2.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItem2.Name = "drawerMenuItem2";
            //this.drawerMenuItem2.Selected = false;
            this.drawerMenuItem2.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItem2.TabIndex = 1;
            this.drawerMenuItem2.Text = "   People";
            this.drawerMenuItem2.TextAlign = TextAlignment.Left;
            // 
            // drawerMenuItem3
            // 
            this.drawerMenuItem3.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Regular);
            this.drawerMenuItem3.ItemText = "Profile";
            this.drawerMenuItem3.Location = new System.Drawing.Point(2, 100);
            this.drawerMenuItem3.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItem3.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItem3.Name = "drawerMenuItem3";
            //this.drawerMenuItem3.Selected = false;
            this.drawerMenuItem3.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItem3.TabIndex = 2;
            this.drawerMenuItem3.Text = "   Profile";
            this.drawerMenuItem3.TextAlign = TextAlignment.Left;
            // 
            // drawerMenuItem4
            // 
            this.drawerMenuItem4.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Regular);
            this.drawerMenuItem4.ItemText = "Photos";
            this.drawerMenuItem4.Location = new System.Drawing.Point(2, 150);
            this.drawerMenuItem4.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItem4.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItem4.Name = "drawerMenuItem4";
            //this.drawerMenuItem4.Selected = false;
            this.drawerMenuItem4.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItem4.TabIndex = 3;
            this.drawerMenuItem4.Text = "   Photos";
            this.drawerMenuItem4.TextAlign = TextAlignment.Left;
            // 
            // drawerMenuItem5
            // 
            this.drawerMenuItem5.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Regular);
            this.drawerMenuItem5.ItemText = "About us";
            this.drawerMenuItem5.Location = new System.Drawing.Point(2, 200);
            this.drawerMenuItem5.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItem5.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItem5.Name = "drawerMenuItem5";
            //this.drawerMenuItem5.Selected = false;
            this.drawerMenuItem5.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItem5.TabIndex = 4;
            this.drawerMenuItem5.Text = "   About us";
            this.drawerMenuItem5.Visible = false;
            this.drawerMenuItem5.TextAlign = TextAlignment.Left;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderThickness = 1;
            this.CaptionBarHeight = 50;
            captionImage1.Image = global::NavigationDrawer_2010.Properties.Resources.TriggerImage6_1;
            captionImage1.Location = new System.Drawing.Point(6, 15);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(45, 28);
            this.CaptionImages.Add(captionImage1);
            captionLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            captionLabel1.ForeColor = System.Drawing.Color.White;
            captionLabel1.Location = new System.Drawing.Point(55, 16);
            captionLabel1.Name = "CaptionLabel1";
            captionLabel1.Text = "Home";
            this.CaptionLabels.Add(captionLabel1);
            this.ClientSize = new System.Drawing.Size(988, 719);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.navigationDrawer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SettingsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlideOnTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reveal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Push)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftposition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboboxAdv1)).EndInit();
            this.ResumeLayout(false);

        }

       


        #endregion

        private Syncfusion.Windows.Forms.Tools.NavigationDrawer navigationDrawer1;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItem1;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItem2;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItem3;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItem4;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItem5;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv imageListAdv1;
        private System.Windows.Forms.Panel SettingsPanel;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv Push;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv Reveal;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv SlideOnTop;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.ButtonAdv Cancel;
        private Syncfusion.Windows.Forms.ButtonAdv Apply;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv BottomPosition;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv TopPosition;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rightPosition;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv leftposition;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboboxAdv1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DrawerHeader header;
        private Syncfusion.Windows.Forms.CaptionImage captionImage1;
        private Syncfusion.Windows.Forms.CaptionLabel captionLabel1;

    }
}

