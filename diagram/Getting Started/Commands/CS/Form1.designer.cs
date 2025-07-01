#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Diagram;

namespace Commands
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.alignLeftToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.alignCenterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.alignRightToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.alignTopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.alignMiddleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.alignBottomToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.rotateLeftToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rotateRightToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.flipVerticalToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.flipHorizontalToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.spaceAcrossToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.spaceDownToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sameWidthToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sameHeightToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sameSizeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.alignLeftToolStripButton,
            this.alignCenterToolStripButton,
            this.alignRightToolStripButton,
            this.alignTopToolStripButton,
            this.alignMiddleToolStripButton,
            this.alignBottomToolStripButton,
            this.toolStripSeparator4,
            this.rotateLeftToolStripButton,
            this.rotateRightToolStripButton,
            this.toolStripSeparator5,
            this.flipVerticalToolStripButton,
            this.flipHorizontalToolStripButton,
            this.toolStripSeparator2,
            this.spaceAcrossToolStripButton,
            this.spaceDownToolStripButton,
            this.sameWidthToolStripButton,
            this.sameHeightToolStripButton,
            this.sameSizeToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 76);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.toolStrip1.Size = new System.Drawing.Size(735, 42);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.AutoSize = false;
            this.cutToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.cutToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Enabled = false;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.cutToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.cutToolStripButton.Text = "Cut";
            this.cutToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cutToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.AutoSize = false;
            this.copyToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Enabled = false;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.copyToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.copyToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.copyToolStripButton.Text = "Copy";
            this.copyToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.copyToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.AutoSize = false;
            this.pasteToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Enabled = false;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.pasteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pasteToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.pasteToolStripButton.Text = "Paste";
            this.pasteToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pasteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // alignLeftToolStripButton
            // 
            this.alignLeftToolStripButton.AutoSize = false;
            this.alignLeftToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.alignLeftToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignLeftToolStripButton.Enabled = false;
            this.alignLeftToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alignLeftToolStripButton.Image")));
            this.alignLeftToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.alignLeftToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.alignLeftToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignLeftToolStripButton.Name = "alignLeftToolStripButton";
            this.alignLeftToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.alignLeftToolStripButton.Text = "Align\nLeft";
            this.alignLeftToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.alignLeftToolStripButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.alignLeftToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // alignCenterToolStripButton
            // 
            this.alignCenterToolStripButton.AutoSize = false;
            this.alignCenterToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alignCenterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignCenterToolStripButton.Enabled = false;
            this.alignCenterToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alignCenterToolStripButton.Image")));
            this.alignCenterToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.alignCenterToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.alignCenterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignCenterToolStripButton.Name = "alignCenterToolStripButton";
            this.alignCenterToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.alignCenterToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.alignCenterToolStripButton.Text = "Align\nCenter";
            this.alignCenterToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // alignRightToolStripButton
            // 
            this.alignRightToolStripButton.AutoSize = false;
            this.alignRightToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alignRightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignRightToolStripButton.Enabled = false;
            this.alignRightToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alignRightToolStripButton.Image")));
            this.alignRightToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.alignRightToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.alignRightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignRightToolStripButton.Margin = new System.Windows.Forms.Padding(0);
            this.alignRightToolStripButton.Name = "alignRightToolStripButton";
            this.alignRightToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.alignRightToolStripButton.Text = "Align\nRight";
            this.alignRightToolStripButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.alignRightToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // alignTopToolStripButton
            // 
            this.alignTopToolStripButton.AutoSize = false;
            this.alignTopToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.alignTopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignTopToolStripButton.Enabled = false;
            this.alignTopToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alignTopToolStripButton.Image")));
            this.alignTopToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.alignTopToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.alignTopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignTopToolStripButton.Name = "alignTopToolStripButton";
            this.alignTopToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.alignTopToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.alignTopToolStripButton.Text = "Align\nTop";
            this.alignTopToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.alignTopToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // alignMiddleToolStripButton
            // 
            this.alignMiddleToolStripButton.AutoSize = false;
            this.alignMiddleToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.alignMiddleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignMiddleToolStripButton.Enabled = false;
            this.alignMiddleToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alignMiddleToolStripButton.Image")));
            this.alignMiddleToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.alignMiddleToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.alignMiddleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignMiddleToolStripButton.Name = "alignMiddleToolStripButton";
            this.alignMiddleToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.alignMiddleToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.alignMiddleToolStripButton.Text = "Align\nMiddle";
            this.alignMiddleToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.alignMiddleToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // alignBottomToolStripButton
            // 
            this.alignBottomToolStripButton.AutoSize = false;
            this.alignBottomToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.alignBottomToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignBottomToolStripButton.Enabled = false;
            this.alignBottomToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alignBottomToolStripButton.Image")));
            this.alignBottomToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.alignBottomToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.alignBottomToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignBottomToolStripButton.Name = "alignBottomToolStripButton";
            this.alignBottomToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.alignBottomToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.alignBottomToolStripButton.Text = "Align\nBottom";
            this.alignBottomToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.alignBottomToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // rotateLeftToolStripButton
            // 
            this.rotateLeftToolStripButton.AutoSize = false;
            this.rotateLeftToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rotateLeftToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotateLeftToolStripButton.Enabled = false;
            this.rotateLeftToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateLeftToolStripButton.Image")));
            this.rotateLeftToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rotateLeftToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rotateLeftToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rotateLeftToolStripButton.Name = "rotateLeftToolStripButton";
            this.rotateLeftToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.rotateLeftToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.rotateLeftToolStripButton.Text = "Rotate\nLeft";
            this.rotateLeftToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rotateLeftToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // rotateRightToolStripButton
            // 
            this.rotateRightToolStripButton.AutoSize = false;
            this.rotateRightToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rotateRightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotateRightToolStripButton.Enabled = false;
            this.rotateRightToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateRightToolStripButton.Image")));
            this.rotateRightToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rotateRightToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rotateRightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rotateRightToolStripButton.Name = "rotateRightToolStripButton";
            this.rotateRightToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.rotateRightToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.rotateRightToolStripButton.Text = "Rotate\nRight";
            this.rotateRightToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rotateRightToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
            // 
            // flipVerticalToolStripButton
            // 
            this.flipVerticalToolStripButton.AutoSize = false;
            this.flipVerticalToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flipVerticalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.flipVerticalToolStripButton.Enabled = false;
            this.flipVerticalToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("flipVerticalToolStripButton.Image")));
            this.flipVerticalToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flipVerticalToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.flipVerticalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.flipVerticalToolStripButton.Name = "flipVerticalToolStripButton";
            this.flipVerticalToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.flipVerticalToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.flipVerticalToolStripButton.Text = "Flip\nVertical";
            this.flipVerticalToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.flipVerticalToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // flipHorizontalToolStripButton
            // 
            this.flipHorizontalToolStripButton.AutoSize = false;
            this.flipHorizontalToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flipHorizontalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.flipHorizontalToolStripButton.Enabled = false;
            this.flipHorizontalToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("flipHorizontalToolStripButton.Image")));
            this.flipHorizontalToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flipHorizontalToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.flipHorizontalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.flipHorizontalToolStripButton.Name = "flipHorizontalToolStripButton";
            this.flipHorizontalToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.flipHorizontalToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.flipHorizontalToolStripButton.Text = "Flip\nHorizontal";
            this.flipHorizontalToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.flipHorizontalToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // spaceAcrossToolStripButton
            // 
            this.spaceAcrossToolStripButton.AutoSize = false;
            this.spaceAcrossToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.spaceAcrossToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.spaceAcrossToolStripButton.Enabled = false;
            this.spaceAcrossToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("spaceAcrossToolStripButton.Image")));
            this.spaceAcrossToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.spaceAcrossToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.spaceAcrossToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.spaceAcrossToolStripButton.Name = "spaceAcrossToolStripButton";
            this.spaceAcrossToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.spaceAcrossToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.spaceAcrossToolStripButton.Text = "Space\nAcross";
            this.spaceAcrossToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.spaceAcrossToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // spaceDownToolStripButton
            // 
            this.spaceDownToolStripButton.AutoSize = false;
            this.spaceDownToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.spaceDownToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.spaceDownToolStripButton.Enabled = false;
            this.spaceDownToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("spaceDownToolStripButton.Image")));
            this.spaceDownToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.spaceDownToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.spaceDownToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.spaceDownToolStripButton.Name = "spaceDownToolStripButton";
            this.spaceDownToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.spaceDownToolStripButton.Text = "Space\nDown";
            this.spaceDownToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.spaceDownToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sameWidthToolStripButton
            // 
            this.sameWidthToolStripButton.AutoSize = false;
            this.sameWidthToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sameWidthToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sameWidthToolStripButton.Enabled = false;
            this.sameWidthToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("sameWidthToolStripButton.Image")));
            this.sameWidthToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.sameWidthToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sameWidthToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sameWidthToolStripButton.Name = "sameWidthToolStripButton";
            this.sameWidthToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.sameWidthToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.sameWidthToolStripButton.Text = "Same\nWidth";
            this.sameWidthToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sameWidthToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sameHeightToolStripButton
            // 
            this.sameHeightToolStripButton.AutoSize = false;
            this.sameHeightToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sameHeightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sameHeightToolStripButton.Enabled = false;
            this.sameHeightToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("sameHeightToolStripButton.Image")));
            this.sameHeightToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.sameHeightToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sameHeightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sameHeightToolStripButton.Name = "sameHeightToolStripButton";
            this.sameHeightToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.sameHeightToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.sameHeightToolStripButton.Text = "Same\nHeight";
            this.sameHeightToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sameHeightToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sameSizeToolStripButton
            // 
            this.sameSizeToolStripButton.AutoSize = false;
            this.sameSizeToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sameSizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sameSizeToolStripButton.Enabled = false;
            this.sameSizeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("sameSizeToolStripButton.Image")));
            this.sameSizeToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.sameSizeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sameSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sameSizeToolStripButton.Name = "sameSizeToolStripButton";
            this.sameSizeToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.sameSizeToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.sameSizeToolStripButton.Text = "Same\nSize";
            this.sameSizeToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sameSizeToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.diagram1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 543);
            this.panel2.TabIndex = 3;
            // 
            // diagram1
            // 
            this.diagram1.BackColor = System.Drawing.SystemColors.Control;
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.Padding = new System.Windows.Forms.Padding(2, 2, 10, 2);
            this.diagram1.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.Size = new System.Drawing.Size(735, 543);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 0;
            this.diagram1.Text = "diagram1";
            // 
            // 
            // 
            this.diagram1.View.BackgroundColor = System.Drawing.SystemColors.Control;
            this.diagram1.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram1.View.Controller = this.diagram1.Controller;
            this.diagram1.View.Grid.MinPixelSpacing = 4F;
            this.diagram1.View.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            // 
            // model1
            // 
            this.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model1.DocumentScale.DisplayName = "No Scale";
            this.model1.DocumentScale.Height = 1F;
            this.model1.DocumentScale.Width = 1F;
            this.model1.DocumentSize.Height = 485F;
            this.model1.DocumentSize.Width = 1492F;
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LogicalSize = new System.Drawing.SizeF(1492F, 485F);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Commands";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton alignLeftToolStripButton;
        private System.Windows.Forms.ToolStripButton alignBottomToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton rotateLeftToolStripButton;
        private System.Windows.Forms.ToolStripButton rotateRightToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton alignCenterToolStripButton;
        private System.Windows.Forms.ToolStripButton alignRightToolStripButton;
        private System.Windows.Forms.ToolStripButton alignTopToolStripButton;
        private System.Windows.Forms.ToolStripButton alignMiddleToolStripButton;
        private System.Windows.Forms.ToolStripButton spaceAcrossToolStripButton;
        private System.Windows.Forms.ToolStripButton spaceDownToolStripButton;
        private System.Windows.Forms.ToolStripButton sameWidthToolStripButton;
        private System.Windows.Forms.ToolStripButton sameHeightToolStripButton;
        private System.Windows.Forms.ToolStripButton sameSizeToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton flipVerticalToolStripButton;
        private System.Windows.Forms.ToolStripButton flipHorizontalToolStripButton;
        private System.Windows.Forms.Panel panel2;
        private Diagram diagram1;
        private Model model1;
    }
}

