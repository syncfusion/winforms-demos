#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Drawing;
using System.Windows.Forms;

namespace CustomCaption
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

        //Get and Load the images
#if NET9_0_OR_GREATER
        private static Image GetImage(string path)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            if (asm != null && !string.IsNullOrEmpty(path))
                return Image.FromStream(asm.GetManifestResourceStream(path));
            return null;
        }

        private void LoadImages(ImageList imageList, string folder, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                string imagePath = ($"CustomCaption.Images.{folder}.Image_{i}.png");
                imageList.Images.Add(GetImage(imagePath));
            }
        }
#endif

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel2 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel3 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel4 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel5 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel6 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel7 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel8 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel9 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel10 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbflowLayoutPanel1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpanel11 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.serverExplorer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.solutionExplorer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.properties = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorList = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.startPage = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.toolbox = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.findResults = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.teamExplorer = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            this.serverExplorer.SuspendLayout();
            this.solutionExplorer.SuspendLayout();
            this.properties.SuspendLayout();
            this.errorList.SuspendLayout();
            this.startPage.SuspendLayout();
            this.toolbox.SuspendLayout();
            this.findResults.SuspendLayout();
            this.teamExplorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockingManager1
            // 
            this.dockingManager1.AnimateAutoHiddenWindow = true;
            this.dockingManager1.AutoHideTabForeColor = System.Drawing.Color.Empty;
#if !NETCORE
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
#endif
            this.dockingManager1.HostControl = this;
            this.dockingManager1.MetroButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockingManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.dockingManager1.MetroSplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            this.dockingManager1.ReduceFlickeringInRtl = false;
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.SetDockLabel(this.serverExplorer, "Server Explorer");
            this.dockingManager1.SetEnableDocking(this.serverExplorer, true);
            ccbpanel1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.serverExplorer, ccbpanel1);
            this.dockingManager1.SetDockLabel(this.solutionExplorer, "Solution Explorer");
            this.dockingManager1.SetEnableDocking(this.solutionExplorer, true);
            ccbpanel2.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.solutionExplorer, ccbpanel2);
            this.dockingManager1.SetDockLabel(this.properties, "Properties");
            this.dockingManager1.SetEnableDocking(this.properties, true);
            ccbpanel3.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.properties, ccbpanel3);
            ccbpanel4.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetDockLabel(this.errorList, "Error List");
            this.dockingManager1.SetEnableDocking(this.errorList, true);
            ccbpanel5.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.errorList, ccbpanel5);
            ccbpanel6.MergeWith(this.dockingManager1.CaptionButtons, false);
            ccbpanel7.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetDockLabel(this.startPage, "Start Page");
            this.dockingManager1.SetEnableDocking(this.startPage, true);
            ccbpanel8.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.startPage, ccbpanel8);
            this.dockingManager1.SetDockLabel(this.toolbox, "Toolbox");
            this.dockingManager1.SetEnableDocking(this.toolbox, true);
            ccbpanel9.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.toolbox, ccbpanel9);
            this.dockingManager1.SetDockLabel(this.findResults, "Find Results");
            this.dockingManager1.SetEnableDocking(this.findResults, true);
            ccbpanel10.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.findResults, ccbpanel10);
            this.dockingManager1.SetDockLabel(this.teamExplorer, "Team Explorer");
            this.dockingManager1.SetEnableDocking(this.teamExplorer, true);
            ccbflowLayoutPanel1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.teamExplorer, ccbflowLayoutPanel1);
            ccbpanel11.MergeWith(this.dockingManager1.CaptionButtons, false);
            // 
            // panel1
            // 
            this.serverExplorer.Controls.Add(this.label1);
            this.serverExplorer.Location = new System.Drawing.Point(1, 24);
            this.serverExplorer.Name = "panel1";
            this.serverExplorer.Size = new System.Drawing.Size(187, 302);
            this.serverExplorer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 302);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.solutionExplorer.Controls.Add(this.label2);
            this.solutionExplorer.Location = new System.Drawing.Point(1, 24);
            this.solutionExplorer.Name = "panel2";
            this.solutionExplorer.Size = new System.Drawing.Size(202, 353);
            this.solutionExplorer.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 353);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.properties.Controls.Add(this.label3);
            this.properties.Location = new System.Drawing.Point(1, 24);
            this.properties.Name = "panel3";
            this.properties.Size = new System.Drawing.Size(202, 357);
            this.properties.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 357);
            this.label3.TabIndex = 1;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1217, 277);
            this.label4.TabIndex = 1;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.errorList.Controls.Add(this.label5);
            this.errorList.Location = new System.Drawing.Point(1, 24);
            this.errorList.Name = "panel5";
            this.errorList.Size = new System.Drawing.Size(1217, 277);
            this.errorList.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1217, 277);
            this.label5.TabIndex = 1;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startPage
            // 
            this.startPage.Controls.Add(this.label9);
            this.startPage.Location = new System.Drawing.Point(1, 24);
            this.startPage.Name = "panel8";
            this.startPage.Size = new System.Drawing.Size(161, 408);
            this.startPage.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 408);
            this.label9.TabIndex = 2;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolbox
            // 
            this.toolbox.Controls.Add(this.label10);
            this.toolbox.Location = new System.Drawing.Point(1, 24);
            this.toolbox.Name = "panel9";
            this.toolbox.Size = new System.Drawing.Size(183, 408);
            this.toolbox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 408);
            this.label10.TabIndex = 1;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.findResults.Controls.Add(this.label11);
            this.findResults.Location = new System.Drawing.Point(1, 24);
            this.findResults.Name = "panel10";
            this.findResults.Size = new System.Drawing.Size(1217, 277);
            this.findResults.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1217, 277);
            this.label11.TabIndex = 2;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.teamExplorer.Controls.Add(label12);
            this.teamExplorer.Location = new System.Drawing.Point(1, 24);
            this.teamExplorer.Name = "flowLayoutPanel1";
            this.teamExplorer.Size = new System.Drawing.Size(183, 191);
            this.teamExplorer.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 0);
            this.label12.TabIndex = 2;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList1, "ImageList1", 16);
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "panels_new3_close.ico");
            this.imageList1.Images.SetKeyName(1, "panels_new3_autohide1.ico");
            this.imageList1.Images.SetKeyName(2, "panels_new3_menu.ico");
            this.imageList1.Images.SetKeyName(3, "panels_new1_restore2.ico");
            this.imageList1.Images.SetKeyName(4, "previous_icon_16.png");
            this.imageList1.Images.SetKeyName(5, "next_icon_16.png");
            this.imageList1.Images.SetKeyName(6, "minus.png");
            this.imageList1.Images.SetKeyName(7, "plus.png");
            this.imageList1.Images.SetKeyName(8, "information.png");
            this.imageList1.Images.SetKeyName(9, "about.png");
            this.imageList1.Images.SetKeyName(10, "window.png");
            this.imageList1.Images.SetKeyName(11, "signpost.png");
            this.imageList1.Images.SetKeyName(12, "unknown.png");
            this.imageList1.Images.SetKeyName(13, "panels_new3_autohide2.png");
            this.imageList1.Images.SetKeyName(14, "PushpinHS.png");
            this.imageList1.Images.SetKeyName(15, "PropertiesHS.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 768);
            this.Name = "Form1";
            this.Text = "Caption Restriction";
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            this.serverExplorer.ResumeLayout(false);
            this.solutionExplorer.ResumeLayout(false);
            this.properties.ResumeLayout(false);
            this.errorList.ResumeLayout(false);
            this.startPage.ResumeLayout(false);
            this.toolbox.ResumeLayout(false);
            this.findResults.ResumeLayout(false);
            this.teamExplorer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
        private System.Windows.Forms.Panel toolbox;
        private System.Windows.Forms.Panel solutionExplorer;
        private System.Windows.Forms.Panel serverExplorer;
        private System.Windows.Forms.Panel teamExplorer;
        private System.Windows.Forms.Panel properties;
        private System.Windows.Forms.Panel errorList;
        private System.Windows.Forms.Panel findResults;
        private System.Windows.Forms.Panel startPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ImageList imageList1;
    }
}

