#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace NestedDocking
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel2 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel3 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel4 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection headerCollection1 = new Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection();
            Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection headerCollection2 = new Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection();
            Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection headerCollection3 = new Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection();
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeNavigator3 = new Syncfusion.Windows.Forms.Tools.TreeNavigator();
            this.treeMenuItem11 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMenuItem12 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMenuItem13 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMenuItem14 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMenuItem15 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.treeNavigator2 = new Syncfusion.Windows.Forms.Tools.TreeNavigator();
            this.treeMenuItem6 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMenuItem7 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMenuItem8 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMenuItem9 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMenuItem10 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.treeNavigator1 = new Syncfusion.Windows.Forms.Tools.TreeNavigator();
            this.treeMenuItem1 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMenuItem2 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMenuItem3 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMenuItem4 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMenuItem5 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockingManager1
            // 
            this.dockingManager1.ActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.AutoHideTabFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.AutoHideTabForeColor = System.Drawing.Color.Empty;
#if !NETCORE
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
#endif            
            this.dockingManager1.DockTabFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.DockTabForeColor = System.Drawing.Color.Empty;
            this.dockingManager1.HostControl = this;
            this.dockingManager1.InActiveCaptionBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212))))));
            this.dockingManager1.InActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.MetroButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockingManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.dockingManager1.MetroSplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            this.dockingManager1.ReduceFlickeringInRtl = false;
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.SetDockLabel(this.panel2, "Ipsum");
            this.dockingManager1.SetEnableDocking(this.panel2, true);
            ccbpanel2.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.panel2, ccbpanel2);
            this.dockingManager1.SetDockLabel(this.panel3, "Navigation Controls");
            this.dockingManager1.SetEnableDocking(this.panel3, true);
            ccbpanel3.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.panel3, ccbpanel3);
            this.dockingManager1.SetDockLabel(this.panel4, "List Controls");
            this.dockingManager1.SetEnableDocking(this.panel4, true);
            ccbpanel4.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.panel4, ccbpanel4);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeNavigator3);
            this.panel2.Location = new System.Drawing.Point(1, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 516);
            this.panel2.TabIndex = 3;
            // 
            // treeNavigator3
            // 
            this.treeNavigator3.BackColor = System.Drawing.Color.White;
            this.treeNavigator3.Dock = System.Windows.Forms.DockStyle.Fill;
            headerCollection1.Font = new System.Drawing.Font("Arial", 8F);
            headerCollection1.Height = 20;
            this.treeNavigator3.Header = headerCollection1;
            this.treeNavigator3.ItemBackColor = System.Drawing.Color.White;
            this.treeNavigator3.Items.Add(this.treeMenuItem11);
            this.treeNavigator3.Items.Add(this.treeMenuItem12);
            this.treeNavigator3.Items.Add(this.treeMenuItem13);
            this.treeNavigator3.Items.Add(this.treeMenuItem14);
            this.treeNavigator3.Items.Add(this.treeMenuItem15);
            this.treeNavigator3.Location = new System.Drawing.Point(0, 0);
            this.treeNavigator3.MinimumSize = new System.Drawing.Size(150, 150);
            this.treeNavigator3.Name = "treeNavigator3";
            this.treeNavigator3.PadY = 5;
            this.treeNavigator3.ShowHeader = false;
            this.treeNavigator3.Size = new System.Drawing.Size(161, 516);
            this.treeNavigator3.TabIndex = 0;
            this.treeNavigator3.Text = "treeNavigator3";
            // 
            // treeMenuItem11
            // 
            this.treeMenuItem11.BackColor = System.Drawing.Color.White;
            this.treeMenuItem11.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem11.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem11.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem11.Location = new System.Drawing.Point(2, 0);
            this.treeMenuItem11.Name = "treeMenuItem11";
            this.treeMenuItem11.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem11.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem11.Size = new System.Drawing.Size(139, 20);
            this.treeMenuItem11.TabIndex = 0;
            this.treeMenuItem11.Text = "Libero";
            // 
            // treeMenuItem12
            // 
            this.treeMenuItem12.BackColor = System.Drawing.Color.White;
            this.treeMenuItem12.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem12.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem12.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem12.Location = new System.Drawing.Point(2, 25);
            this.treeMenuItem12.Name = "treeMenuItem12";
            this.treeMenuItem12.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem12.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem12.Size = new System.Drawing.Size(139, 20);
            this.treeMenuItem12.TabIndex = 0;
            this.treeMenuItem12.Text = "Orci dis";
            // 
            // treeMenuItem13
            // 
            this.treeMenuItem13.BackColor = System.Drawing.Color.White;
            this.treeMenuItem13.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem13.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem13.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem13.Location = new System.Drawing.Point(2, 50);
            this.treeMenuItem13.Name = "treeMenuItem13";
            this.treeMenuItem13.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem13.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem13.Size = new System.Drawing.Size(139, 20);
            this.treeMenuItem13.TabIndex = 0;
            this.treeMenuItem13.Text = "Porta";
            // 
            // treeMenuItem14
            // 
            this.treeMenuItem14.BackColor = System.Drawing.Color.White;
            this.treeMenuItem14.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem14.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem14.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem14.Location = new System.Drawing.Point(2, 75);
            this.treeMenuItem14.Name = "treeMenuItem14";
            this.treeMenuItem14.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem14.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem14.Size = new System.Drawing.Size(139, 20);
            this.treeMenuItem14.TabIndex = 0;
            this.treeMenuItem14.Text = "Massa";
            // 
            // treeMenuItem15
            // 
            this.treeMenuItem15.BackColor = System.Drawing.Color.White;
            this.treeMenuItem15.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem15.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem15.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem15.Location = new System.Drawing.Point(2, 100);
            this.treeMenuItem15.Name = "treeMenuItem15";
            this.treeMenuItem15.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem15.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem15.Size = new System.Drawing.Size(139, 20);
            this.treeMenuItem15.TabIndex = 0;
            this.treeMenuItem15.Text = "Ligula";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.treeNavigator2);
            this.panel3.Location = new System.Drawing.Point(1, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 516);
            this.panel3.TabIndex = 4;
            // 
            // treeNavigator2
            // 
            this.treeNavigator2.BackColor = System.Drawing.Color.White;
            this.treeNavigator2.Dock = System.Windows.Forms.DockStyle.Fill;
            headerCollection2.Font = new System.Drawing.Font("Arial", 8F);
            headerCollection2.Height = 20;
            this.treeNavigator2.Header = headerCollection2;
            this.treeNavigator2.ItemBackColor = System.Drawing.Color.White;
            this.treeNavigator2.Items.Add(this.treeMenuItem6);
            this.treeNavigator2.Items.Add(this.treeMenuItem7);
            this.treeNavigator2.Items.Add(this.treeMenuItem8);
            this.treeNavigator2.Items.Add(this.treeMenuItem9);
            this.treeNavigator2.Items.Add(this.treeMenuItem10);
            this.treeNavigator2.Location = new System.Drawing.Point(0, 0);
            this.treeNavigator2.MinimumSize = new System.Drawing.Size(150, 150);
            this.treeNavigator2.Name = "treeNavigator2";
            this.treeNavigator2.PadY = 5;
            this.treeNavigator2.ShowHeader = false;
            this.treeNavigator2.Size = new System.Drawing.Size(165, 516);
            this.treeNavigator2.TabIndex = 0;
            this.treeNavigator2.Text = "treeNavigator2";
            // 
            // treeMenuItem6
            // 
            this.treeMenuItem6.BackColor = System.Drawing.Color.White;
            this.treeMenuItem6.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem6.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem6.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem6.Location = new System.Drawing.Point(2, 0);
            this.treeMenuItem6.Name = "treeMenuItem6";
            this.treeMenuItem6.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem6.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem6.Size = new System.Drawing.Size(144, 20);
            this.treeMenuItem6.TabIndex = 0;
            this.treeMenuItem6.Text = "Suscipit";
            // 
            // treeMenuItem7
            // 
            this.treeMenuItem7.BackColor = System.Drawing.Color.White;
            this.treeMenuItem7.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem7.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem7.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem7.Location = new System.Drawing.Point(2, 25);
            this.treeMenuItem7.Name = "treeMenuItem7";
            this.treeMenuItem7.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem7.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem7.Size = new System.Drawing.Size(144, 20);
            this.treeMenuItem7.TabIndex = 0;
            this.treeMenuItem7.Text = "Fringilla";
            // 
            // treeMenuItem8
            // 
            this.treeMenuItem8.BackColor = System.Drawing.Color.White;
            this.treeMenuItem8.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem8.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem8.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem8.Location = new System.Drawing.Point(2, 50);
            this.treeMenuItem8.Name = "treeMenuItem8";
            this.treeMenuItem8.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem8.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem8.Size = new System.Drawing.Size(144, 20);
            this.treeMenuItem8.TabIndex = 0;
            this.treeMenuItem8.Text = "Aliquam";
            // 
            // treeMenuItem9
            // 
            this.treeMenuItem9.BackColor = System.Drawing.Color.White;
            this.treeMenuItem9.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem9.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem9.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem9.Location = new System.Drawing.Point(2, 75);
            this.treeMenuItem9.Name = "treeMenuItem9";
            this.treeMenuItem9.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem9.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem9.Size = new System.Drawing.Size(144, 20);
            this.treeMenuItem9.TabIndex = 0;
            this.treeMenuItem9.Text = "Mollis";
            // 
            // treeMenuItem10
            // 
            this.treeMenuItem10.BackColor = System.Drawing.Color.White;
            this.treeMenuItem10.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem10.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem10.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem10.Location = new System.Drawing.Point(2, 100);
            this.treeMenuItem10.Name = "treeMenuItem10";
            this.treeMenuItem10.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem10.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem10.Size = new System.Drawing.Size(144, 20);
            this.treeMenuItem10.TabIndex = 0;
            this.treeMenuItem10.Text = "Lorem";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.treeNavigator1);
            this.panel4.Location = new System.Drawing.Point(1, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 516);
            this.panel4.TabIndex = 5;
            // 
            // treeNavigator1
            // 
            this.treeNavigator1.BackColor = System.Drawing.Color.White;
            this.treeNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            headerCollection3.Font = new System.Drawing.Font("Arial", 8F);
            headerCollection3.Height = 20;
            this.treeNavigator1.Header = headerCollection3;
            this.treeNavigator1.ItemBackColor = System.Drawing.Color.White;
            this.treeNavigator1.Items.Add(this.treeMenuItem1);
            this.treeNavigator1.Items.Add(this.treeMenuItem2);
            this.treeNavigator1.Items.Add(this.treeMenuItem3);
            this.treeNavigator1.Items.Add(this.treeMenuItem4);
            this.treeNavigator1.Items.Add(this.treeMenuItem5);
            this.treeNavigator1.Location = new System.Drawing.Point(0, 0);
            this.treeNavigator1.MinimumSize = new System.Drawing.Size(150, 150);
            this.treeNavigator1.Name = "treeNavigator1";
            this.treeNavigator1.PadY = 5;
            this.treeNavigator1.ShowHeader = false;
            this.treeNavigator1.Size = new System.Drawing.Size(165, 516);
            this.treeNavigator1.TabIndex = 0;
            this.treeNavigator1.Text = "treeNavigator1";
            // 
            // treeMenuItem1
            // 
            this.treeMenuItem1.BackColor = System.Drawing.Color.White;
            this.treeMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem1.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem1.Location = new System.Drawing.Point(2, 0);
            this.treeMenuItem1.Name = "treeMenuItem1";
            this.treeMenuItem1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem1.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem1.Size = new System.Drawing.Size(144, 20);
            this.treeMenuItem1.TabIndex = 0;
            this.treeMenuItem1.Text = "Vestibulum";
            // 
            // treeMenuItem2
            // 
            this.treeMenuItem2.BackColor = System.Drawing.Color.White;
            this.treeMenuItem2.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem2.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem2.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem2.Location = new System.Drawing.Point(2, 25);
            this.treeMenuItem2.Name = "treeMenuItem2";
            this.treeMenuItem2.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem2.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem2.Size = new System.Drawing.Size(144, 20);
            this.treeMenuItem2.TabIndex = 0;
            this.treeMenuItem2.Text = "Nullam";
            // 
            // treeMenuItem3
            // 
            this.treeMenuItem3.BackColor = System.Drawing.Color.White;
            this.treeMenuItem3.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem3.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem3.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem3.Location = new System.Drawing.Point(2, 50);
            this.treeMenuItem3.Name = "treeMenuItem3";
            this.treeMenuItem3.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem3.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem3.Size = new System.Drawing.Size(144, 20);
            this.treeMenuItem3.TabIndex = 0;
            this.treeMenuItem3.Text = "Volutpat";
            // 
            // treeMenuItem4
            // 
            this.treeMenuItem4.BackColor = System.Drawing.Color.White;
            this.treeMenuItem4.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem4.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem4.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem4.Location = new System.Drawing.Point(2, 75);
            this.treeMenuItem4.Name = "treeMenuItem4";
            this.treeMenuItem4.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem4.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem4.Size = new System.Drawing.Size(144, 20);
            this.treeMenuItem4.TabIndex = 0;
            this.treeMenuItem4.Text = "Lectus";
            // 
            // treeMenuItem5
            // 
            this.treeMenuItem5.BackColor = System.Drawing.Color.White;
            this.treeMenuItem5.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem5.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem5.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem5.Location = new System.Drawing.Point(2, 100);
            this.treeMenuItem5.Name = "treeMenuItem5";
            this.treeMenuItem5.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem5.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem5.Size = new System.Drawing.Size(144, 20);
            this.treeMenuItem5.TabIndex = 0;
            this.treeMenuItem5.Text = "Pulvinar";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(172, 566);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Tools.TreeNavigator treeNavigator1;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem1;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem2;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem3;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem4;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem5;
        private Syncfusion.Windows.Forms.Tools.TreeNavigator treeNavigator3;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem11;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem12;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem13;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem14;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem15;
        private Syncfusion.Windows.Forms.Tools.TreeNavigator treeNavigator2;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem6;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem7;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem8;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem9;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem10;
    }
}
