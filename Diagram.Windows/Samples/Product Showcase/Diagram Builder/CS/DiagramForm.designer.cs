#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Diagram;
//using Syncfusion.Diagram.Windows.Text;
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool
{
    partial class DiagramForm
	{

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
            
            base.Dispose( disposing );
		}

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagramForm));
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.mnuAlgn = new System.Windows.Forms.MenuItem();
            this.mnuAlgnLeft = new System.Windows.Forms.MenuItem();
            this.mnuAlgnCenter = new System.Windows.Forms.MenuItem();
            this.mnuAlgnRight = new System.Windows.Forms.MenuItem();
            this.mnuAlgnTop = new System.Windows.Forms.MenuItem();
            this.mnuAlgnMiddle = new System.Windows.Forms.MenuItem();
            this.mnuAlgnBottom = new System.Windows.Forms.MenuItem();
            this.mnuFlip = new System.Windows.Forms.MenuItem();
            this.mnuFlipHoriz = new System.Windows.Forms.MenuItem();
            this.mnuFlipVert = new System.Windows.Forms.MenuItem();
            this.mnuFlipBoth = new System.Windows.Forms.MenuItem();
            this.mnuGrouping = new System.Windows.Forms.MenuItem();
            this.mnuGGroup = new System.Windows.Forms.MenuItem();
            this.mnuGUngroup = new System.Windows.Forms.MenuItem();
            this.mnuOrder = new System.Windows.Forms.MenuItem();
            this.mnuOrdBTF = new System.Windows.Forms.MenuItem();
            this.mnuOrdBF = new System.Windows.Forms.MenuItem();
            this.mnuOrdSB = new System.Windows.Forms.MenuItem();
            this.mnuOrdSTB = new System.Windows.Forms.MenuItem();
            this.mnuRotate = new System.Windows.Forms.MenuItem();
            this.mnuRtClockwise = new System.Windows.Forms.MenuItem();
            this.mnuRtCClockwise = new System.Windows.Forms.MenuItem();
            this.mnuResize = new System.Windows.Forms.MenuItem();
            this.mnuRsSameWidth = new System.Windows.Forms.MenuItem();
            this.mnuRsSameHeight = new System.Windows.Forms.MenuItem();
            this.mnuRsSameSize = new System.Windows.Forms.MenuItem();
            this.mnuRsSpaseAcross = new System.Windows.Forms.MenuItem();
            this.mnuRsSpaceDown = new System.Windows.Forms.MenuItem();
            this.mnuLayout = new System.Windows.Forms.MenuItem();
            this.document = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.childFrameBarManager = new Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(this);
            this.barDrawing = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager, "Drawing");
            this.barItemSelect = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.smBarItemImages = new System.Windows.Forms.ImageList(this.components);
            this.barItemPort = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemLine = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemPolyline = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemRectangle = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemPenciltool = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemRoundRect = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemEllipse = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemPolygon = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemCurve = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemClosedCurve = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemSpline = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemBezier = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemText = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemRichText = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemImage = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemCircularArc = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemSemiCircle = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barNode = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager, "Node");
            this.barItemGroup = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemUngroup = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemBringToFront = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemSendToBack = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemBringForward = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemSendBackward = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barNudge = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager, "Nudge");
            this.barItemNudgeUp = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemNudgeDown = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemNudgeLeft = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemNudgeRight = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barLinks = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager, "Links");
            this.barItemLink = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemOrthogonalLink = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemOrgLineLink = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemDirectedLink = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemPolylineLink = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barRotate = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager, "Rotate");
            this.barItemRotateLeft = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemRotateRight = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemFlipVertical = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemFlipHorizontal = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager, "View");
            this.barItemPan = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemShowGrid = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemSnapToGrid = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemZoom = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.comboBoxBarItemMagnification = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager, "Text Formatting");
            this.comboBoxBarItemFontFamily = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.comboBoxBarItemPointSize = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.barItemBoldText = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemItalicText = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemUnderlineText = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemStrikeoutText = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemAlignTextLeft = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemCenterText = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemAlignTextRight = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemTextColor = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemSubscript = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemSuperscript = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemLower = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemUpper = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barLayout = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager, "Layout");
            this.barItemSpaceAcross = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemSpaceDown = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemSameWidth = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemSameHeight = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemSameSize = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barAlign = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager, "Align");
            this.barItemAlignLeft = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemAlignCenter = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemAlignRight = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemAlignTop = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemAlignMiddle = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemAlignBottom = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.superToolTip1 = new Syncfusion.Windows.Forms.Tools.SuperToolTip(this);
            this.diagramComponent = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.openDiagramDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDiagramDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.document)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childFrameBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItemMagnification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItemFontFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItemPointSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramComponent)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAlgn,
            this.mnuFlip,
            this.mnuGrouping,
            this.mnuOrder,
            this.mnuRotate,
            this.mnuResize,
            this.mnuLayout});
            // 
            // mnuAlgn
            // 
            this.mnuAlgn.Index = 0;
            this.mnuAlgn.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAlgnLeft,
            this.mnuAlgnCenter,
            this.mnuAlgnRight,
            this.mnuAlgnTop,
            this.mnuAlgnMiddle,
            this.mnuAlgnBottom});
            this.mnuAlgn.Text = "Align";
            // 
            // mnuAlgnLeft
            // 
            this.mnuAlgnLeft.Index = 0;
            this.mnuAlgnLeft.Text = "Align Left";
            this.mnuAlgnLeft.Click += new System.EventHandler(this.barItemAlignLeft_Click);
            // 
            // mnuAlgnCenter
            // 
            this.mnuAlgnCenter.Index = 1;
            this.mnuAlgnCenter.Text = "Align Center";
            this.mnuAlgnCenter.Click += new System.EventHandler(this.barItemAlignCenter_Click);
            // 
            // mnuAlgnRight
            // 
            this.mnuAlgnRight.Index = 2;
            this.mnuAlgnRight.Text = "Align Right";
            this.mnuAlgnRight.Click += new System.EventHandler(this.barItemAlignRight_Click);
            // 
            // mnuAlgnTop
            // 
            this.mnuAlgnTop.Index = 3;
            this.mnuAlgnTop.Text = "Align Top";
            this.mnuAlgnTop.Click += new System.EventHandler(this.barItemAlignTop_Click);
            // 
            // mnuAlgnMiddle
            // 
            this.mnuAlgnMiddle.Index = 4;
            this.mnuAlgnMiddle.Text = "Align Middle";
            this.mnuAlgnMiddle.Click += new System.EventHandler(this.barItemAlignMiddle_Click);
            // 
            // mnuAlgnBottom
            // 
            this.mnuAlgnBottom.Index = 5;
            this.mnuAlgnBottom.Text = "Align Bottom";
            this.mnuAlgnBottom.Click += new System.EventHandler(this.barItemAlignBottom_Click);
            // 
            // mnuFlip
            // 
            this.mnuFlip.Index = 1;
            this.mnuFlip.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFlipHoriz,
            this.mnuFlipVert,
            this.mnuFlipBoth});
            this.mnuFlip.Text = "Flip";
            // 
            // mnuFlipHoriz
            // 
            this.mnuFlipHoriz.Index = 0;
            this.mnuFlipHoriz.Text = "Flip Horizontally";
            this.mnuFlipHoriz.Click += new System.EventHandler(this.barItemFlipHorizontal_Click);
            // 
            // mnuFlipVert
            // 
            this.mnuFlipVert.Index = 1;
            this.mnuFlipVert.Text = "Flip Vertically";
            this.mnuFlipVert.Click += new System.EventHandler(this.barItemFlipVertical_Click);
            // 
            // mnuFlipBoth
            // 
            this.mnuFlipBoth.Index = 2;
            this.mnuFlipBoth.Text = "Flip Both";
            this.mnuFlipBoth.Click += new System.EventHandler(this.mnuFlipBoth_Click);
            // 
            // mnuGrouping
            // 
            this.mnuGrouping.Index = 2;
            this.mnuGrouping.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuGGroup,
            this.mnuGUngroup});
            this.mnuGrouping.Text = "Grouping";
            // 
            // mnuGGroup
            // 
            this.mnuGGroup.Index = 0;
            this.mnuGGroup.Text = "Group";
            this.mnuGGroup.Click += new System.EventHandler(this.barItemGroup_Click);
            // 
            // mnuGUngroup
            // 
            this.mnuGUngroup.Index = 1;
            this.mnuGUngroup.Text = "Ungroup";
            this.mnuGUngroup.Click += new System.EventHandler(this.barItemUngroup_Click);
            // 
            // mnuOrder
            // 
            this.mnuOrder.Index = 3;
            this.mnuOrder.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuOrdBTF,
            this.mnuOrdBF,
            this.mnuOrdSB,
            this.mnuOrdSTB});
            this.mnuOrder.Text = "Order";
            // 
            // mnuOrdBTF
            // 
            this.mnuOrdBTF.Index = 0;
            this.mnuOrdBTF.Text = "Bring To Front";
            this.mnuOrdBTF.Click += new System.EventHandler(this.barItemBringToFront_Click);
            // 
            // mnuOrdBF
            // 
            this.mnuOrdBF.Index = 1;
            this.mnuOrdBF.Text = "Bring Forward";
            this.mnuOrdBF.Click += new System.EventHandler(this.barItemBringForward_Click);
            // 
            // mnuOrdSB
            // 
            this.mnuOrdSB.Index = 2;
            this.mnuOrdSB.Text = "Send Backward";
            this.mnuOrdSB.Click += new System.EventHandler(this.barItemSendBackward_Click);
            // 
            // mnuOrdSTB
            // 
            this.mnuOrdSTB.Index = 3;
            this.mnuOrdSTB.Text = "Send To Back";
            this.mnuOrdSTB.Click += new System.EventHandler(this.barItemSendToBack_Click);
            // 
            // mnuRotate
            // 
            this.mnuRotate.Index = 4;
            this.mnuRotate.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuRtClockwise,
            this.mnuRtCClockwise});
            this.mnuRotate.Text = "Rotate";
            // 
            // mnuRtClockwise
            // 
            this.mnuRtClockwise.Index = 0;
            this.mnuRtClockwise.Text = "Rotate 90 clockwise";
            this.mnuRtClockwise.Click += new System.EventHandler(this.barItemRotateRight_Click);
            // 
            // mnuRtCClockwise
            // 
            this.mnuRtCClockwise.Index = 1;
            this.mnuRtCClockwise.Text = "Rotate 90 counter-clockwise";
            this.mnuRtCClockwise.Click += new System.EventHandler(this.barItemRotateLeft_Click);
            // 
            // mnuResize
            // 
            this.mnuResize.Index = 5;
            this.mnuResize.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuRsSameWidth,
            this.mnuRsSameHeight,
            this.mnuRsSameSize,
            this.mnuRsSpaseAcross,
            this.mnuRsSpaceDown});
            this.mnuResize.Text = "Resize";
            // 
            // mnuRsSameWidth
            // 
            this.mnuRsSameWidth.Index = 0;
            this.mnuRsSameWidth.Text = "Same Width";
            this.mnuRsSameWidth.Click += new System.EventHandler(this.barItemSameWidth_Click);
            // 
            // mnuRsSameHeight
            // 
            this.mnuRsSameHeight.Index = 1;
            this.mnuRsSameHeight.Text = "Same Height";
            this.mnuRsSameHeight.Click += new System.EventHandler(this.barItemSameHeight_Click);
            // 
            // mnuRsSameSize
            // 
            this.mnuRsSameSize.Index = 2;
            this.mnuRsSameSize.Text = "Same Size";
            this.mnuRsSameSize.Click += new System.EventHandler(this.barItemSameSize_Click);
            // 
            // mnuRsSpaseAcross
            // 
            this.mnuRsSpaseAcross.Index = 3;
            this.mnuRsSpaseAcross.Text = "Space Across";
            this.mnuRsSpaseAcross.Click += new System.EventHandler(this.barItemSpaceAcross_Click);
            // 
            // mnuRsSpaceDown
            // 
            this.mnuRsSpaceDown.Index = 4;
            this.mnuRsSpaceDown.Text = "Space Down";
            this.mnuRsSpaceDown.Click += new System.EventHandler(this.barItemSpaceDown_Click);
            // 
            // mnuLayout
            // 
            this.mnuLayout.Index = 6;
            this.mnuLayout.Text = "Layout nodes";
            this.mnuLayout.Click += new System.EventHandler(this.mnuLayout_Click);
            // 
            // document
            // 
            this.document.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.document.DocumentScale.DisplayName = "No Scale";
            this.document.DocumentScale.Height = 1F;
            this.document.DocumentScale.Width = 1F;
            this.document.DocumentSize.Height = 1169F;
            this.document.DocumentSize.Width = 827F;
            this.document.LineStyle.DashPattern = null;
            this.document.LineStyle.LineColor = System.Drawing.Color.Black;
            this.document.LogicalSize = new System.Drawing.SizeF(827F, 1169F);
            this.document.ShadowStyle.Color = System.Drawing.Color.DimGray;
            this.document.ShadowStyle.ColorAlphaFactor = 255;
            this.document.ShadowStyle.ForeColor = System.Drawing.Color.DimGray;
            this.document.ShadowStyle.ForeColorAlphaFactor = 255;
            // 
            // childFrameBarManager
            // 
            this.childFrameBarManager.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("childFrameBarManager.BarPositionInfo")));
            this.childFrameBarManager.Bars.Add(this.barDrawing);
            this.childFrameBarManager.Bars.Add(this.barNode);
            this.childFrameBarManager.Bars.Add(this.barNudge);
            this.childFrameBarManager.Bars.Add(this.barLinks);
            this.childFrameBarManager.Bars.Add(this.barRotate);
            this.childFrameBarManager.Bars.Add(this.bar1);
            this.childFrameBarManager.Bars.Add(this.bar2);
            this.childFrameBarManager.Bars.Add(this.barLayout);
            this.childFrameBarManager.Bars.Add(this.barAlign);
            this.childFrameBarManager.Categories.Add("Drawing Tools");
            this.childFrameBarManager.Categories.Add("Node Tools");
            this.childFrameBarManager.Categories.Add("Connection Tools");
            this.childFrameBarManager.Categories.Add("Nudge Tools");
            this.childFrameBarManager.Categories.Add("Rotate Tools");
            this.childFrameBarManager.Categories.Add("View Tools");
            this.childFrameBarManager.Categories.Add("Text Formatting");
            this.childFrameBarManager.Categories.Add("Scripting");
            this.childFrameBarManager.Categories.Add("Align");
            this.childFrameBarManager.Categories.Add("Layout");
            this.childFrameBarManager.CurrentBaseFormType = "System.Windows.Forms.Form";
            this.childFrameBarManager.Form = this;
            this.childFrameBarManager.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemSelect,
            this.barItemPort,
            this.barItemLine,
            this.barItemRectangle,
            this.barItemPenciltool,
            this.barItemEllipse,
            this.barItemText,
            this.barItemPolyline,
            this.barItemPolygon,
            this.barItemSpline,
            this.barItemBezier,
            this.barItemGroup,
            this.barItemCurve,
            this.barItemClosedCurve,
            this.barItemImage,
            this.barItemCircularArc,
            this.barItemSemiCircle,
            this.barItemRichText,
            this.barItemUngroup,
            this.barItemRoundRect,
            this.barItemBringToFront,
            this.barItemSendToBack,
            this.barItemBringForward,
            this.barItemSendBackward,
            this.barItemLink,
            this.barItemNudgeUp,
            this.barItemNudgeDown,
            this.barItemNudgeLeft,
            this.barItemNudgeRight,
            this.barItemRotateLeft,
            this.barItemRotateRight,
            this.barItemFlipVertical,
            this.barItemFlipHorizontal,
            this.barItemPan,
            this.barItemShowGrid,
            this.barItemSnapToGrid,
            this.barItemZoom,
            this.comboBoxBarItemMagnification,
            this.barItemOrthogonalLink,
            this.barItemOrgLineLink,
            this.barItemDirectedLink,
            this.barItemBoldText,
            this.barItemItalicText,
            this.barItemUnderlineText,
            this.barItemAlignTextLeft,
            this.barItemCenterText,
            this.barItemAlignTextRight,
            this.comboBoxBarItemFontFamily,
            this.comboBoxBarItemPointSize,
            this.barItemTextColor,
            this.barItemSuperscript,
            this.barItemSubscript,
            this.barItemUpper,
            this.barItemLower,
            this.barItemStrikeoutText,
            this.barItemSpaceAcross,
            this.barItemSpaceDown,
            this.barItemSameWidth,
            this.barItemSameHeight,
            this.barItemSameSize,
            this.barItemAlignLeft,
            this.barItemAlignCenter,
            this.barItemAlignRight,
            this.barItemAlignTop,
            this.barItemAlignMiddle,
            this.barItemAlignBottom,
            this.barItemPolylineLink});
            this.childFrameBarManager.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
            // 
            // barDrawing
            // 
            this.barDrawing.BarName = "Drawing";
            this.barDrawing.Caption = "Drawing";
            this.barDrawing.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemSelect,
            this.barItemPort,
            this.barItemLine,
            this.barItemPolyline,
            this.barItemRectangle,
            this.barItemPenciltool,
            this.barItemRoundRect,
            this.barItemEllipse,
            this.barItemPolygon,
            this.barItemCurve,
            this.barItemClosedCurve,
            this.barItemSpline,
            this.barItemBezier,
            this.barItemText,
            this.barItemRichText,
            this.barItemImage,
            this.barItemCircularArc,
            this.barItemSemiCircle});
            this.barDrawing.Manager = this.childFrameBarManager;
            // 
            // barItemSelect
            // 
            this.barItemSelect.BarName = "barItemSelect";
            this.barItemSelect.CategoryIndex = 0;
            this.barItemSelect.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemSelect.ID = "Pointer";
            this.barItemSelect.ImageIndex = 0;
            this.barItemSelect.ImageList = this.smBarItemImages;
            this.barItemSelect.ShowToolTipInPopUp = false;
            this.barItemSelect.SizeToFit = true;
            this.barItemSelect.Tag = "SelectTool";
            this.barItemSelect.Text = "Select";
            this.barItemSelect.Tooltip = "Select";
            this.barItemSelect.Click += new System.EventHandler(this.SelectToolActivate);
            // 
            // smBarItemImages
            // 
            this.smBarItemImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smBarItemImages.ImageStream")));
            this.smBarItemImages.TransparentColor = System.Drawing.Color.Fuchsia;
            this.smBarItemImages.Images.SetKeyName(0, "");
            this.smBarItemImages.Images.SetKeyName(1, "");
            this.smBarItemImages.Images.SetKeyName(2, "");
            this.smBarItemImages.Images.SetKeyName(3, "");
            this.smBarItemImages.Images.SetKeyName(4, "");
            this.smBarItemImages.Images.SetKeyName(5, "");
            this.smBarItemImages.Images.SetKeyName(6, "");
            this.smBarItemImages.Images.SetKeyName(7, "");
            this.smBarItemImages.Images.SetKeyName(8, "");
            this.smBarItemImages.Images.SetKeyName(9, "");
            this.smBarItemImages.Images.SetKeyName(10, "");
            this.smBarItemImages.Images.SetKeyName(11, "");
            this.smBarItemImages.Images.SetKeyName(12, "");
            this.smBarItemImages.Images.SetKeyName(13, "");
            this.smBarItemImages.Images.SetKeyName(14, "");
            this.smBarItemImages.Images.SetKeyName(15, "");
            this.smBarItemImages.Images.SetKeyName(16, "");
            this.smBarItemImages.Images.SetKeyName(17, "");
            this.smBarItemImages.Images.SetKeyName(18, "");
            this.smBarItemImages.Images.SetKeyName(19, "");
            this.smBarItemImages.Images.SetKeyName(20, "");
            this.smBarItemImages.Images.SetKeyName(21, "");
            this.smBarItemImages.Images.SetKeyName(22, "");
            this.smBarItemImages.Images.SetKeyName(23, "");
            this.smBarItemImages.Images.SetKeyName(24, "");
            this.smBarItemImages.Images.SetKeyName(25, "");
            this.smBarItemImages.Images.SetKeyName(26, "");
            this.smBarItemImages.Images.SetKeyName(27, "");
            this.smBarItemImages.Images.SetKeyName(28, "");
            this.smBarItemImages.Images.SetKeyName(29, "");
            this.smBarItemImages.Images.SetKeyName(30, "");
            this.smBarItemImages.Images.SetKeyName(31, "");
            this.smBarItemImages.Images.SetKeyName(32, "");
            this.smBarItemImages.Images.SetKeyName(33, "");
            this.smBarItemImages.Images.SetKeyName(34, "");
            this.smBarItemImages.Images.SetKeyName(35, "");
            this.smBarItemImages.Images.SetKeyName(36, "");
            this.smBarItemImages.Images.SetKeyName(37, "");
            this.smBarItemImages.Images.SetKeyName(38, "");
            this.smBarItemImages.Images.SetKeyName(39, "");
            this.smBarItemImages.Images.SetKeyName(40, "");
            this.smBarItemImages.Images.SetKeyName(41, "");
            this.smBarItemImages.Images.SetKeyName(42, "");
            this.smBarItemImages.Images.SetKeyName(43, "");
            this.smBarItemImages.Images.SetKeyName(44, "");
            this.smBarItemImages.Images.SetKeyName(45, "");
            this.smBarItemImages.Images.SetKeyName(46, "");
            this.smBarItemImages.Images.SetKeyName(47, "");
            this.smBarItemImages.Images.SetKeyName(48, "");
            this.smBarItemImages.Images.SetKeyName(49, "");
            this.smBarItemImages.Images.SetKeyName(50, "");
            this.smBarItemImages.Images.SetKeyName(51, "");
            this.smBarItemImages.Images.SetKeyName(52, "");
            this.smBarItemImages.Images.SetKeyName(53, "");
            this.smBarItemImages.Images.SetKeyName(54, "");
            this.smBarItemImages.Images.SetKeyName(55, "");
            this.smBarItemImages.Images.SetKeyName(56, "");
            this.smBarItemImages.Images.SetKeyName(57, "");
            this.smBarItemImages.Images.SetKeyName(58, "");
            this.smBarItemImages.Images.SetKeyName(59, "");
            this.smBarItemImages.Images.SetKeyName(60, "");
            this.smBarItemImages.Images.SetKeyName(61, "");
            this.smBarItemImages.Images.SetKeyName(62, "");
            this.smBarItemImages.Images.SetKeyName(63, "");
            this.smBarItemImages.Images.SetKeyName(64, "");
            this.smBarItemImages.Images.SetKeyName(65, "");
            this.smBarItemImages.Images.SetKeyName(66, "");
            this.smBarItemImages.Images.SetKeyName(67, "");
            this.smBarItemImages.Images.SetKeyName(68, "");
            this.smBarItemImages.Images.SetKeyName(69, "");
            this.smBarItemImages.Images.SetKeyName(70, "");
            this.smBarItemImages.Images.SetKeyName(71, "");
            this.smBarItemImages.Images.SetKeyName(72, "");
            this.smBarItemImages.Images.SetKeyName(73, "");
            this.smBarItemImages.Images.SetKeyName(74, "");
            this.smBarItemImages.Images.SetKeyName(75, "");
            this.smBarItemImages.Images.SetKeyName(76, "PolylineLink.bmp");
            this.smBarItemImages.Images.SetKeyName(77, "pencil.png");
            this.smBarItemImages.Images.SetKeyName(78, "16x16.png");
            this.smBarItemImages.Images.SetKeyName(79, "OthogonalConnector.png");
            // 
            // barItemPort
            // 
            this.barItemPort.BarName = "barItemPort";
            this.barItemPort.CategoryIndex = 0;
            this.barItemPort.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemPort.ID = "ConnectionPointTool";
            this.barItemPort.ImageIndex = 78;
            this.barItemPort.ImageList = this.smBarItemImages;
            this.barItemPort.ShowToolTipInPopUp = false;
            this.barItemPort.SizeToFit = true;
            this.barItemPort.Tag = "ConnectionPointTool";
            this.barItemPort.Text = "ConnectionPointTool";
            this.barItemPort.Tooltip = "Add or delete connection points on shapes. \n\n Hold CTRL key and click on a connec" +
                "tion point will delete the connection point.";
            this.barItemPort.Click += new System.EventHandler(this.ConnectionPointToolActivate);
            // 
            // barItemLine
            // 
            this.barItemLine.BarName = "barItemLine";
            this.barItemLine.CategoryIndex = 0;
            this.barItemLine.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemLine.ID = "Line";
            this.barItemLine.ImageIndex = 1;
            this.barItemLine.ImageList = this.smBarItemImages;
            this.barItemLine.ShowToolTipInPopUp = false;
            this.barItemLine.SizeToFit = true;
            this.barItemLine.Tag = "LineTool";
            this.barItemLine.Text = "Line";
            this.barItemLine.Tooltip = "Line";
            this.barItemLine.Click += new System.EventHandler(this.LineToolActivate);
            // 
            // barItemPolyline
            // 
            this.barItemPolyline.BarName = "barItemPolyline";
            this.barItemPolyline.CategoryIndex = 0;
            this.barItemPolyline.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemPolyline.ID = "Polyline";
            this.barItemPolyline.ImageIndex = 2;
            this.barItemPolyline.ImageList = this.smBarItemImages;
            this.barItemPolyline.ShowToolTipInPopUp = false;
            this.barItemPolyline.SizeToFit = true;
            this.barItemPolyline.Tag = "PolyLineTool";
            this.barItemPolyline.Text = "Polyline";
            this.barItemPolyline.Tooltip = "Polyline";
            this.barItemPolyline.Click += new System.EventHandler(this.PolylineToolActivate);
            // 
            // barItemRectangle
            // 
            this.barItemRectangle.BarName = "barItemRectangle";
            this.barItemRectangle.CategoryIndex = 0;
            this.barItemRectangle.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemRectangle.ID = "Rectangle";
            this.barItemRectangle.ImageIndex = 4;
            this.barItemRectangle.ImageList = this.smBarItemImages;
            this.barItemRectangle.ShowToolTipInPopUp = false;
            this.barItemRectangle.SizeToFit = true;
            this.barItemRectangle.Tag = "RectangleTool";
            this.barItemRectangle.Text = "Rectangle";
            this.barItemRectangle.Tooltip = "Rectangle";
            this.barItemRectangle.Click += new System.EventHandler(this.RectangleToolActivate);
            // 
            // barItemPenciltool
            // 
            this.barItemPenciltool.BarName = "barItemPenciltool";
            this.barItemPenciltool.CategoryIndex = 0;
            this.barItemPenciltool.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemPenciltool.ID = "Penciltool";
            this.barItemPenciltool.ImageIndex = 77;
            this.barItemPenciltool.ImageList = this.smBarItemImages;
            this.barItemPenciltool.ShowToolTipInPopUp = false;
            this.barItemPenciltool.SizeToFit = true;
            this.barItemPenciltool.Tag = "PencilTool";
            this.barItemPenciltool.Text = "PencilTool";
            this.barItemPenciltool.Tooltip = "PencilTool";
            this.barItemPenciltool.Click += new System.EventHandler(this.barItemPenciltool_Click);
            // 
            // barItemRoundRect
            // 
            this.barItemRoundRect.BarName = "barItemRoundRect";
            this.barItemRoundRect.CategoryIndex = 0;
            this.barItemRoundRect.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemRoundRect.ID = "Rounded Rectangle";
            this.barItemRoundRect.ImageIndex = 5;
            this.barItemRoundRect.ImageList = this.smBarItemImages;
            this.barItemRoundRect.ShowToolTipInPopUp = false;
            this.barItemRoundRect.SizeToFit = true;
            this.barItemRoundRect.Tag = "RoundRectTool";
            this.barItemRoundRect.Text = "Rounded Rectangle";
            this.barItemRoundRect.Click += new System.EventHandler(this.RoundedRectangleToolActivate);
            // 
            // barItemEllipse
            // 
            this.barItemEllipse.BarName = "barItemEllipse";
            this.barItemEllipse.CategoryIndex = 0;
            this.barItemEllipse.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemEllipse.ID = "Ellipse";
            this.barItemEllipse.ImageIndex = 7;
            this.barItemEllipse.ImageList = this.smBarItemImages;
            this.barItemEllipse.ShowToolTipInPopUp = false;
            this.barItemEllipse.SizeToFit = true;
            this.barItemEllipse.Tag = "EllipseTool";
            this.barItemEllipse.Text = "Ellipse";
            this.barItemEllipse.Tooltip = "Ellipse";
            this.barItemEllipse.Click += new System.EventHandler(this.EllipseToolActivate);
            // 
            // barItemPolygon
            // 
            this.barItemPolygon.BarName = "barItemPolygon";
            this.barItemPolygon.CategoryIndex = 0;
            this.barItemPolygon.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemPolygon.ID = "Polygon";
            this.barItemPolygon.ImageIndex = 6;
            this.barItemPolygon.ImageList = this.smBarItemImages;
            this.barItemPolygon.ShowToolTipInPopUp = false;
            this.barItemPolygon.SizeToFit = true;
            this.barItemPolygon.Tag = "PolygonTool";
            this.barItemPolygon.Text = "Polygon";
            this.barItemPolygon.Tooltip = "Polygon";
            this.barItemPolygon.Click += new System.EventHandler(this.PolygonToolActivate);
            // 
            // barItemCurve
            // 
            this.barItemCurve.BarName = "barItemCurve";
            this.barItemCurve.CategoryIndex = 0;
            this.barItemCurve.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemCurve.ID = "Curve";
            this.barItemCurve.ImageIndex = 9;
            this.barItemCurve.ImageList = this.smBarItemImages;
            this.barItemCurve.ShowToolTipInPopUp = false;
            this.barItemCurve.SizeToFit = true;
            this.barItemCurve.Tag = "CurveTool";
            this.barItemCurve.Text = "Curve";
            this.barItemCurve.Tooltip = "Curve";
            this.barItemCurve.Click += new System.EventHandler(this.CurveToolActivate);
            // 
            // barItemClosedCurve
            // 
            this.barItemClosedCurve.BarName = "barItemClosedCurve";
            this.barItemClosedCurve.CategoryIndex = 0;
            this.barItemClosedCurve.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemClosedCurve.ID = "Closed Curve";
            this.barItemClosedCurve.ImageIndex = 10;
            this.barItemClosedCurve.ImageList = this.smBarItemImages;
            this.barItemClosedCurve.ShowToolTipInPopUp = false;
            this.barItemClosedCurve.SizeToFit = true;
            this.barItemClosedCurve.Tag = "ClosedCurveTool";
            this.barItemClosedCurve.Text = "Closed Curve";
            this.barItemClosedCurve.Tooltip = "Closed Curve";
            this.barItemClosedCurve.Click += new System.EventHandler(this.ClosedCurveToolActivate);
            // 
            // barItemSpline
            // 
            this.barItemSpline.BarName = "barItemSpline";
            this.barItemSpline.CategoryIndex = 0;
            this.barItemSpline.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemSpline.ID = "Spline";
            this.barItemSpline.ImageIndex = 8;
            this.barItemSpline.ImageList = this.smBarItemImages;
            this.barItemSpline.ShowToolTipInPopUp = false;
            this.barItemSpline.SizeToFit = true;
            this.barItemSpline.Tag = "SplineTool";
            this.barItemSpline.Text = "Spline";
            this.barItemSpline.Tooltip = "Spline";
            this.barItemSpline.Click += new System.EventHandler(this.ArcToolActivate);
            // 
            // barItemBezier
            // 
            this.barItemBezier.BarName = "barItemBezier";
            this.barItemBezier.CategoryIndex = 0;
            this.barItemBezier.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemBezier.ID = "Bezier";
            this.barItemBezier.ImageIndex = 64;
            this.barItemBezier.ImageList = this.smBarItemImages;
            this.barItemBezier.ShowToolTipInPopUp = false;
            this.barItemBezier.SizeToFit = true;
            this.barItemBezier.Tag = "BezierTool";
            this.barItemBezier.Text = "Bezier";
            this.barItemBezier.Tooltip = "BezierTool";
            this.barItemBezier.Click += new System.EventHandler(this.BezierToolActivate);
            // 
            // barItemText
            // 
            this.barItemText.BarName = "barItemText";
            this.barItemText.CategoryIndex = 0;
            this.barItemText.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemText.ID = "Text";
            this.barItemText.ImageIndex = 12;
            this.barItemText.ImageList = this.smBarItemImages;
            this.barItemText.ShowToolTipInPopUp = false;
            this.barItemText.SizeToFit = true;
            this.barItemText.Tag = "TextTool";
            this.barItemText.Text = "Text";
            this.barItemText.Tooltip = "Text";
            this.barItemText.Click += new System.EventHandler(this.TextToolActivate);
            // 
            // barItemRichText
            // 
            this.barItemRichText.BarName = "barItemRichText";
            this.barItemRichText.CategoryIndex = 0;
            this.barItemRichText.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemRichText.ID = "Rich Text";
            this.barItemRichText.ImageIndex = 47;
            this.barItemRichText.ImageList = this.smBarItemImages;
            this.barItemRichText.ShowToolTipInPopUp = false;
            this.barItemRichText.SizeToFit = true;
            this.barItemRichText.Tag = "RichTextTool";
            this.barItemRichText.Text = "Rich Text";
            this.barItemRichText.Tooltip = "Rich Text";
            this.barItemRichText.Click += new System.EventHandler(this.RichTextToolActivate);
            // 
            // barItemImage
            // 
            this.barItemImage.BarName = "barItemImage";
            this.barItemImage.CategoryIndex = 0;
            this.barItemImage.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemImage.ID = "Image";
            this.barItemImage.ImageIndex = 11;
            this.barItemImage.ImageList = this.smBarItemImages;
            this.barItemImage.ShowToolTipInPopUp = false;
            this.barItemImage.SizeToFit = true;
            this.barItemImage.Tag = "ImageTool";
            this.barItemImage.Text = "Image";
            this.barItemImage.Tooltip = "Image";
            this.barItemImage.Click += new System.EventHandler(this.barItemImage_Click);
            // 
            // barItemCircularArc
            // 
            this.barItemCircularArc.BarName = "barItemCircularArc";
            this.barItemCircularArc.CategoryIndex = 0;
            this.barItemCircularArc.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemCircularArc.ID = "CircularArc";
            this.barItemCircularArc.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("barItemCircularArc.Image")));
            this.barItemCircularArc.ShowToolTipInPopUp = false;
            this.barItemCircularArc.SizeToFit = true;
            this.barItemCircularArc.Tag = "CircularArcTool";
            this.barItemCircularArc.Text = "CircularArc";
            this.barItemCircularArc.Tooltip = "CircularArc";
            this.barItemCircularArc.Click += new System.EventHandler(this.CircularArcToolActivate);
            // 
            // barItemSemiCircle
            // 
            this.barItemSemiCircle.BarName = "barItemSemiCircle";
            this.barItemSemiCircle.CategoryIndex = 0;
            this.barItemSemiCircle.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemSemiCircle.ID = "SemiCircle";
            this.barItemSemiCircle.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("barItemSemiCircle.Image")));
            this.barItemSemiCircle.ShowToolTipInPopUp = false;
            this.barItemSemiCircle.SizeToFit = true;
            this.barItemSemiCircle.Tag = "SemiCircle";
            this.barItemSemiCircle.Text = "SemiCircle";
            this.barItemSemiCircle.Tooltip = "SemiCircle";
            this.barItemSemiCircle.Click += new System.EventHandler(this.SemiCircleToolActivate);
            // 
            // barNode
            // 
            this.barNode.BarName = "Node";
            this.barNode.Caption = "Node";
            this.barNode.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemGroup,
            this.barItemUngroup,
            this.barItemBringToFront,
            this.barItemSendToBack,
            this.barItemBringForward,
            this.barItemSendBackward});
            this.barNode.Manager = this.childFrameBarManager;
            // 
            // barItemGroup
            // 
            this.barItemGroup.BarName = "barItemGroup";
            this.barItemGroup.CategoryIndex = 1;
            this.barItemGroup.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemGroup.Enabled = false;
            this.barItemGroup.ID = "Group";
            this.barItemGroup.ImageIndex = 13;
            this.barItemGroup.ImageList = this.smBarItemImages;
            this.barItemGroup.ShowToolTipInPopUp = false;
            this.barItemGroup.SizeToFit = true;
            this.barItemGroup.Tag = "GroupTool";
            this.barItemGroup.Text = "Group";
            this.barItemGroup.Tooltip = "Group";
            this.barItemGroup.Click += new System.EventHandler(this.barItemGroup_Click);
            // 
            // barItemUngroup
            // 
            this.barItemUngroup.BarName = "barItemUngroup";
            this.barItemUngroup.CategoryIndex = 1;
            this.barItemUngroup.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemUngroup.Enabled = false;
            this.barItemUngroup.ID = "Ungroup";
            this.barItemUngroup.ImageIndex = 14;
            this.barItemUngroup.ImageList = this.smBarItemImages;
            this.barItemUngroup.ShowToolTipInPopUp = false;
            this.barItemUngroup.SizeToFit = true;
            this.barItemUngroup.Tag = "UngroupTool";
            this.barItemUngroup.Text = "Ungroup";
            this.barItemUngroup.Tooltip = "Ungroup";
            this.barItemUngroup.Click += new System.EventHandler(this.barItemUngroup_Click);
            // 
            // barItemBringToFront
            // 
            this.barItemBringToFront.BarName = "barItemBringToFront";
            this.barItemBringToFront.CategoryIndex = 1;
            this.barItemBringToFront.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemBringToFront.ID = "Bring To Front";
            this.barItemBringToFront.ImageIndex = 40;
            this.barItemBringToFront.ImageList = this.smBarItemImages;
            this.barItemBringToFront.ShowToolTipInPopUp = false;
            this.barItemBringToFront.SizeToFit = true;
            this.barItemBringToFront.Text = "Bring To Front";
            this.barItemBringToFront.Tooltip = "Bring To Front";
            this.barItemBringToFront.Click += new System.EventHandler(this.barItemBringToFront_Click);
            // 
            // barItemSendToBack
            // 
            this.barItemSendToBack.BarName = "barItemSendToBack";
            this.barItemSendToBack.CategoryIndex = 1;
            this.barItemSendToBack.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemSendToBack.ID = "Send To Back";
            this.barItemSendToBack.ImageIndex = 42;
            this.barItemSendToBack.ImageList = this.smBarItemImages;
            this.barItemSendToBack.ShowToolTipInPopUp = false;
            this.barItemSendToBack.SizeToFit = true;
            this.barItemSendToBack.Text = "Send To Back";
            this.barItemSendToBack.Click += new System.EventHandler(this.barItemSendToBack_Click);
            // 
            // barItemBringForward
            // 
            this.barItemBringForward.BarName = "barItemBringForward";
            this.barItemBringForward.CategoryIndex = 1;
            this.barItemBringForward.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemBringForward.ID = "Bring Forward";
            this.barItemBringForward.ImageIndex = 39;
            this.barItemBringForward.ImageList = this.smBarItemImages;
            this.barItemBringForward.ShowToolTipInPopUp = false;
            this.barItemBringForward.SizeToFit = true;
            this.barItemBringForward.Text = "Bring Forward";
            this.barItemBringForward.Click += new System.EventHandler(this.barItemBringForward_Click);
            // 
            // barItemSendBackward
            // 
            this.barItemSendBackward.BarName = "barItemSendBackward";
            this.barItemSendBackward.CategoryIndex = 1;
            this.barItemSendBackward.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemSendBackward.ID = "Send Backward";
            this.barItemSendBackward.ImageIndex = 41;
            this.barItemSendBackward.ImageList = this.smBarItemImages;
            this.barItemSendBackward.ShowToolTipInPopUp = false;
            this.barItemSendBackward.SizeToFit = true;
            this.barItemSendBackward.Text = "Send Backward";
            this.barItemSendBackward.Click += new System.EventHandler(this.barItemSendBackward_Click);
            // 
            // barNudge
            // 
            this.barNudge.BarName = "Nudge";
            this.barNudge.Caption = "Nudge";
            this.barNudge.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemNudgeUp,
            this.barItemNudgeDown,
            this.barItemNudgeLeft,
            this.barItemNudgeRight});
            this.barNudge.Manager = this.childFrameBarManager;
            // 
            // barItemNudgeUp
            // 
            this.barItemNudgeUp.BarName = "barItemNudgeUp";
            this.barItemNudgeUp.CategoryIndex = 3;
            this.barItemNudgeUp.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemNudgeUp.ID = "Nudge Up";
            this.barItemNudgeUp.ImageIndex = 21;
            this.barItemNudgeUp.ImageList = this.smBarItemImages;
            this.barItemNudgeUp.ShowToolTipInPopUp = false;
            this.barItemNudgeUp.SizeToFit = true;
            this.barItemNudgeUp.Text = "Nudge Up";
            this.barItemNudgeUp.Tooltip = "Nudge Up";
            this.barItemNudgeUp.Click += new System.EventHandler(this.barItemNudgeUp_Click);
            // 
            // barItemNudgeDown
            // 
            this.barItemNudgeDown.BarName = "barItemNudgeDown";
            this.barItemNudgeDown.CategoryIndex = 3;
            this.barItemNudgeDown.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemNudgeDown.ID = "Nudge Down";
            this.barItemNudgeDown.ImageIndex = 22;
            this.barItemNudgeDown.ImageList = this.smBarItemImages;
            this.barItemNudgeDown.ShowToolTipInPopUp = false;
            this.barItemNudgeDown.SizeToFit = true;
            this.barItemNudgeDown.Text = "Nudge Down";
            this.barItemNudgeDown.Tooltip = "Nudge Down";
            this.barItemNudgeDown.Click += new System.EventHandler(this.barItemNudgeDown_Click);
            // 
            // barItemNudgeLeft
            // 
            this.barItemNudgeLeft.BarName = "barItemNudgeLeft";
            this.barItemNudgeLeft.CategoryIndex = 3;
            this.barItemNudgeLeft.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemNudgeLeft.ID = "Nudge Left";
            this.barItemNudgeLeft.ImageIndex = 19;
            this.barItemNudgeLeft.ImageList = this.smBarItemImages;
            this.barItemNudgeLeft.ShowToolTipInPopUp = false;
            this.barItemNudgeLeft.SizeToFit = true;
            this.barItemNudgeLeft.Text = "Nudge Left";
            this.barItemNudgeLeft.Tooltip = "Nudge Left";
            this.barItemNudgeLeft.Click += new System.EventHandler(this.barItemNudgeLeft_Click);
            // 
            // barItemNudgeRight
            // 
            this.barItemNudgeRight.BarName = "barItemNudgeRight";
            this.barItemNudgeRight.CategoryIndex = 3;
            this.barItemNudgeRight.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemNudgeRight.ID = "Nudge Right";
            this.barItemNudgeRight.ImageIndex = 20;
            this.barItemNudgeRight.ImageList = this.smBarItemImages;
            this.barItemNudgeRight.ShowToolTipInPopUp = false;
            this.barItemNudgeRight.SizeToFit = true;
            this.barItemNudgeRight.Text = "Nudge Right";
            this.barItemNudgeRight.Tooltip = "Nudge Right";
            this.barItemNudgeRight.Click += new System.EventHandler(this.barItemNudgeRight_Click);
            // 
            // barLinks
            // 
            this.barLinks.BarName = "Links";
            this.barLinks.Caption = "Links";
            this.barLinks.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemLink,
            this.barItemOrthogonalLink,
            this.barItemOrgLineLink,
            this.barItemDirectedLink,
            this.barItemPolylineLink});
            this.barLinks.Manager = this.childFrameBarManager;
            // 
            // barItemLink
            // 
            this.barItemLink.BarName = "barItemLink";
            this.barItemLink.CategoryIndex = 2;
            this.barItemLink.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemLink.ID = "Link";
            this.barItemLink.ImageIndex = 43;
            this.barItemLink.ImageList = this.smBarItemImages;
            this.barItemLink.ShowToolTipInPopUp = false;
            this.barItemLink.SizeToFit = true;
            this.barItemLink.Text = "Link";
            this.barItemLink.Tooltip = "Link";
            this.barItemLink.Click += new System.EventHandler(this.barItemLinkSymbols_Click);
            // 
            // barItemOrthogonalLink
            // 
            this.barItemOrthogonalLink.BarName = "barItemOrthogonalLink";
            this.barItemOrthogonalLink.CategoryIndex = 2;
            this.barItemOrthogonalLink.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemOrthogonalLink.ID = "Orthogonal Link";
            this.barItemOrthogonalLink.ImageIndex = 79;
            this.barItemOrthogonalLink.ImageList = this.smBarItemImages;
            this.barItemOrthogonalLink.ShowToolTipInPopUp = false;
            this.barItemOrthogonalLink.SizeToFit = true;
            this.barItemOrthogonalLink.Text = "Orthogonal Link";
            this.barItemOrthogonalLink.Click += new System.EventHandler(this.barItemOrthogonalLink_Click);
            // 
            // barItemOrgLineLink
            // 
            this.barItemOrgLineLink.BarName = "barItemOrgLineLink";
            this.barItemOrgLineLink.CategoryIndex = 2;
            this.barItemOrgLineLink.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemOrgLineLink.ID = "OrgLine Link";
            this.barItemOrgLineLink.ImageIndex = 44;
            this.barItemOrgLineLink.ImageList = this.smBarItemImages;
            this.barItemOrgLineLink.ShowToolTipInPopUp = false;
            this.barItemOrgLineLink.SizeToFit = true;
            this.barItemOrgLineLink.Text = "OrgLine Link";
            this.barItemOrgLineLink.Click += new System.EventHandler(this.barItemOrgLineLink_Click);
            // 
            // barItemDirectedLink
            // 
            this.barItemDirectedLink.BarName = "barItemDirectedLink";
            this.barItemDirectedLink.CategoryIndex = 2;
            this.barItemDirectedLink.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemDirectedLink.ID = "Directed Link";
            this.barItemDirectedLink.ImageIndex = 45;
            this.barItemDirectedLink.ImageList = this.smBarItemImages;
            this.barItemDirectedLink.ShowToolTipInPopUp = false;
            this.barItemDirectedLink.SizeToFit = true;
            this.barItemDirectedLink.Text = "Directed Link";
            this.barItemDirectedLink.Tooltip = "Directed Link";
            this.barItemDirectedLink.Click += new System.EventHandler(this.barItemDirectedLink_Click);
            // 
            // barItemPolylineLink
            // 
            this.barItemPolylineLink.BarName = "barItemPolylineLink";
            this.barItemPolylineLink.CategoryIndex = 2;
            this.barItemPolylineLink.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemPolylineLink.ID = "Polyline Link";
            this.barItemPolylineLink.ImageIndex = 46;
            this.barItemPolylineLink.ImageList = this.smBarItemImages;
            this.barItemPolylineLink.ShowToolTipInPopUp = false;
            this.barItemPolylineLink.SizeToFit = true;
            this.barItemPolylineLink.Text = "Polyline Link";
            this.barItemPolylineLink.Click += new System.EventHandler(this.barItemPolylineLink_Click);
            // 
            // barRotate
            // 
            this.barRotate.BarName = "Rotate";
            this.barRotate.Caption = "Rotate";
            this.barRotate.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemRotateLeft,
            this.barItemRotateRight,
            this.barItemFlipVertical,
            this.barItemFlipHorizontal});
            this.barRotate.Manager = this.childFrameBarManager;
            // 
            // barItemRotateLeft
            // 
            this.barItemRotateLeft.BarName = "barItemRotateLeft";
            this.barItemRotateLeft.CategoryIndex = 4;
            this.barItemRotateLeft.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemRotateLeft.ID = "Rotate Left";
            this.barItemRotateLeft.ImageIndex = 35;
            this.barItemRotateLeft.ImageList = this.smBarItemImages;
            this.barItemRotateLeft.ShowToolTipInPopUp = false;
            this.barItemRotateLeft.SizeToFit = true;
            this.barItemRotateLeft.Text = "Rotate Left";
            this.barItemRotateLeft.Tooltip = "Rotate Left";
            this.barItemRotateLeft.Click += new System.EventHandler(this.barItemRotateLeft_Click);
            // 
            // barItemRotateRight
            // 
            this.barItemRotateRight.BarName = "barItemRotateRight";
            this.barItemRotateRight.CategoryIndex = 4;
            this.barItemRotateRight.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemRotateRight.ID = "Rotate Right";
            this.barItemRotateRight.ImageIndex = 36;
            this.barItemRotateRight.ImageList = this.smBarItemImages;
            this.barItemRotateRight.ShowToolTipInPopUp = false;
            this.barItemRotateRight.SizeToFit = true;
            this.barItemRotateRight.Text = "Rotate Right";
            this.barItemRotateRight.Tooltip = "Rotate Right";
            this.barItemRotateRight.Click += new System.EventHandler(this.barItemRotateRight_Click);
            // 
            // barItemFlipVertical
            // 
            this.barItemFlipVertical.BarName = "barItemFlipVertical";
            this.barItemFlipVertical.CategoryIndex = 4;
            this.barItemFlipVertical.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemFlipVertical.ID = "Flip Vertical";
            this.barItemFlipVertical.ImageIndex = 38;
            this.barItemFlipVertical.ImageList = this.smBarItemImages;
            this.barItemFlipVertical.ShowToolTipInPopUp = false;
            this.barItemFlipVertical.SizeToFit = true;
            this.barItemFlipVertical.Text = "Flip Vertical";
            this.barItemFlipVertical.Tooltip = "Flip Vertical";
            this.barItemFlipVertical.Click += new System.EventHandler(this.barItemFlipVertical_Click);
            // 
            // barItemFlipHorizontal
            // 
            this.barItemFlipHorizontal.BarName = "barItemFlipHorizontal";
            this.barItemFlipHorizontal.CategoryIndex = 4;
            this.barItemFlipHorizontal.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemFlipHorizontal.ID = "Flip Horizontal";
            this.barItemFlipHorizontal.ImageIndex = 37;
            this.barItemFlipHorizontal.ImageList = this.smBarItemImages;
            this.barItemFlipHorizontal.ShowToolTipInPopUp = false;
            this.barItemFlipHorizontal.SizeToFit = true;
            this.barItemFlipHorizontal.Text = "Flip Horizontal";
            this.barItemFlipHorizontal.Tooltip = "Flip Horizontal";
            this.barItemFlipHorizontal.Click += new System.EventHandler(this.barItemFlipHorizontal_Click);
            // 
            // bar1
            // 
            this.bar1.BarName = "View";
            this.bar1.Caption = "View";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemPan,
            this.barItemShowGrid,
            this.barItemSnapToGrid,
            this.barItemZoom,
            this.comboBoxBarItemMagnification});
            this.bar1.Manager = this.childFrameBarManager;
            // 
            // barItemPan
            // 
            this.barItemPan.BarName = "barItemPan";
            this.barItemPan.CategoryIndex = 5;
            this.barItemPan.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemPan.ID = "Pan";
            this.barItemPan.ImageIndex = 15;
            this.barItemPan.ImageList = this.smBarItemImages;
            this.barItemPan.ShowToolTipInPopUp = false;
            this.barItemPan.SizeToFit = true;
            this.barItemPan.Tag = "PanTool";
            this.barItemPan.Text = "Pan";
            this.barItemPan.Tooltip = "Pan";
            this.barItemPan.Click += new System.EventHandler(this.barItemPan_Click);
            // 
            // barItemShowGrid
            // 
            this.barItemShowGrid.BarName = "barItemShowGrid";
            this.barItemShowGrid.CategoryIndex = 5;
            this.barItemShowGrid.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemShowGrid.ID = "Show Grid";
            this.barItemShowGrid.ImageIndex = 17;
            this.barItemShowGrid.ImageList = this.smBarItemImages;
            this.barItemShowGrid.ShowToolTipInPopUp = false;
            this.barItemShowGrid.SizeToFit = true;
            this.barItemShowGrid.Text = "Show Grid";
            this.barItemShowGrid.Tooltip = "Show Grid";
            this.barItemShowGrid.Click += new System.EventHandler(this.barItemShowGrid_Click);
            // 
            // barItemSnapToGrid
            // 
            this.barItemSnapToGrid.BarName = "barItemSnapToGrid";
            this.barItemSnapToGrid.CategoryIndex = 5;
            this.barItemSnapToGrid.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemSnapToGrid.ID = "Snap To Grid";
            this.barItemSnapToGrid.ImageIndex = 18;
            this.barItemSnapToGrid.ImageList = this.smBarItemImages;
            this.barItemSnapToGrid.ShowToolTipInPopUp = false;
            this.barItemSnapToGrid.SizeToFit = true;
            this.barItemSnapToGrid.Text = "Snap To Grid";
            this.barItemSnapToGrid.Click += new System.EventHandler(this.barItemSnapToGrid_Click);
            // 
            // barItemZoom
            // 
            this.barItemZoom.BarName = "barItemZoom";
            this.barItemZoom.CategoryIndex = 5;
            this.barItemZoom.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemZoom.ID = "Zoom";
            this.barItemZoom.ImageIndex = 16;
            this.barItemZoom.ImageList = this.smBarItemImages;
            this.barItemZoom.ShowToolTipInPopUp = false;
            this.barItemZoom.SizeToFit = true;
            this.barItemZoom.Tag = "ZoomTool";
            this.barItemZoom.Text = "Zoom";
            this.barItemZoom.Tooltip = "Zoom";
            this.barItemZoom.Click += new System.EventHandler(this.ZoomToolActivate);
            // 
            // comboBoxBarItemMagnification
            // 
            this.comboBoxBarItemMagnification.BarName = "comboBoxBarItemMagnification";
            this.comboBoxBarItemMagnification.CategoryIndex = 5;
            this.comboBoxBarItemMagnification.ChoiceList.AddRange(new string[] {
            "25%",
            "50%",
            "75%",
            "100%",
            "125%",
            "150%",
            "175%",
            "200%"});
            this.comboBoxBarItemMagnification.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarItemMagnification.Editable = false;
            this.comboBoxBarItemMagnification.ID = "Magnification";
            this.comboBoxBarItemMagnification.ShowToolTipInPopUp = false;
            this.comboBoxBarItemMagnification.SizeToFit = true;
            this.comboBoxBarItemMagnification.Text = "Magnification";
            this.comboBoxBarItemMagnification.Tooltip = "Magnification";
            this.comboBoxBarItemMagnification.Click += new System.EventHandler(this.comboBoxBarItemMagnification_Click);
            // 
            // bar2
            // 
            this.bar2.BarName = "Text Formatting";
            this.bar2.Caption = "Text Formatting";
            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.comboBoxBarItemFontFamily,
            this.comboBoxBarItemPointSize,
            this.barItemBoldText,
            this.barItemItalicText,
            this.barItemUnderlineText,
            this.barItemStrikeoutText,
            this.barItemAlignTextLeft,
            this.barItemCenterText,
            this.barItemAlignTextRight,
            this.barItemTextColor,
            this.barItemSubscript,
            this.barItemSuperscript,
            this.barItemLower,
            this.barItemUpper});
            this.bar2.Manager = this.childFrameBarManager;
            // 
            // comboBoxBarItemFontFamily
            // 
            this.comboBoxBarItemFontFamily.BarName = "comboBoxBarItemFontFamily";
            this.comboBoxBarItemFontFamily.CategoryIndex = 6;
            this.comboBoxBarItemFontFamily.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarItemFontFamily.Editable = false;
            this.comboBoxBarItemFontFamily.ID = "Font Family";
            this.comboBoxBarItemFontFamily.MinWidth = 120;
            this.comboBoxBarItemFontFamily.ShowToolTipInPopUp = false;
            this.comboBoxBarItemFontFamily.SizeToFit = true;
            this.comboBoxBarItemFontFamily.Text = "Font Family";
            this.comboBoxBarItemFontFamily.Tooltip = "Font Family";
            // 
            // comboBoxBarItemPointSize
            // 
            this.comboBoxBarItemPointSize.BarName = "comboBoxBarItemPointSize";
            this.comboBoxBarItemPointSize.CategoryIndex = 6;
            this.comboBoxBarItemPointSize.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarItemPointSize.ID = "Point Size";
            this.comboBoxBarItemPointSize.ShowToolTipInPopUp = false;
            this.comboBoxBarItemPointSize.SizeToFit = true;
            this.comboBoxBarItemPointSize.Text = "Point Size";
            // 
            // barItemBoldText
            // 
            this.barItemBoldText.BarName = "barItemBoldText";
            this.barItemBoldText.CategoryIndex = 6;
            this.barItemBoldText.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemBoldText.ID = "Bold";
            this.barItemBoldText.ImageIndex = 48;
            this.barItemBoldText.ImageList = this.smBarItemImages;
            this.barItemBoldText.Shortcut = System.Windows.Forms.Shortcut.CtrlB;
            this.barItemBoldText.ShowToolTipInPopUp = false;
            this.barItemBoldText.SizeToFit = true;
            this.barItemBoldText.Text = "Bold";
            this.barItemBoldText.Tooltip = "Bold";
            this.barItemBoldText.Click += new System.EventHandler(this.barItemBoldText_Click);
            // 
            // barItemItalicText
            // 
            this.barItemItalicText.BarName = "barItemItalicText";
            this.barItemItalicText.CategoryIndex = 6;
            this.barItemItalicText.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemItalicText.ID = "Italic";
            this.barItemItalicText.ImageIndex = 49;
            this.barItemItalicText.ImageList = this.smBarItemImages;
            this.barItemItalicText.Shortcut = System.Windows.Forms.Shortcut.CtrlI;
            this.barItemItalicText.ShowToolTipInPopUp = false;
            this.barItemItalicText.SizeToFit = true;
            this.barItemItalicText.Text = "Italic";
            this.barItemItalicText.Tooltip = "Italic";
            this.barItemItalicText.Click += new System.EventHandler(this.barItemItalicText_Click);
            // 
            // barItemUnderlineText
            // 
            this.barItemUnderlineText.BarName = "barItemUnderlineText";
            this.barItemUnderlineText.CategoryIndex = 6;
            this.barItemUnderlineText.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemUnderlineText.ID = "Underline";
            this.barItemUnderlineText.ImageIndex = 50;
            this.barItemUnderlineText.ImageList = this.smBarItemImages;
            this.barItemUnderlineText.Shortcut = System.Windows.Forms.Shortcut.CtrlU;
            this.barItemUnderlineText.ShowToolTipInPopUp = false;
            this.barItemUnderlineText.SizeToFit = true;
            this.barItemUnderlineText.Text = "Underline";
            this.barItemUnderlineText.Tooltip = "Underline";
            this.barItemUnderlineText.Click += new System.EventHandler(this.barItemUnderlineText_Click);
            // 
            // barItemStrikeoutText
            // 
            this.barItemStrikeoutText.BarName = "barItemStrikeoutText";
            this.barItemStrikeoutText.CategoryIndex = 6;
            this.barItemStrikeoutText.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemStrikeoutText.ID = "Strikeout";
            this.barItemStrikeoutText.ImageIndex = 63;
            this.barItemStrikeoutText.ImageList = this.smBarItemImages;
            this.barItemStrikeoutText.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.barItemStrikeoutText.ShowToolTipInPopUp = false;
            this.barItemStrikeoutText.SizeToFit = true;
            this.barItemStrikeoutText.Text = "Strikeout";
            this.barItemStrikeoutText.Tooltip = "Strikeout";
            this.barItemStrikeoutText.Click += new System.EventHandler(this.barItemStrikeoutText_Click);
            // 
            // barItemAlignTextLeft
            // 
            this.barItemAlignTextLeft.BarName = "barItemAlignTextLeft";
            this.barItemAlignTextLeft.CategoryIndex = 6;
            this.barItemAlignTextLeft.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemAlignTextLeft.ID = "Align Text Left";
            this.barItemAlignTextLeft.ImageIndex = 51;
            this.barItemAlignTextLeft.ImageList = this.smBarItemImages;
            this.barItemAlignTextLeft.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
            this.barItemAlignTextLeft.ShowToolTipInPopUp = false;
            this.barItemAlignTextLeft.SizeToFit = true;
            this.barItemAlignTextLeft.Text = "Align Text Left";
            this.barItemAlignTextLeft.Tooltip = "Align Text Left";
            this.barItemAlignTextLeft.Click += new System.EventHandler(this.barItemAlignTextLeft_Click);
            // 
            // barItemCenterText
            // 
            this.barItemCenterText.BarName = "barItemCenterText";
            this.barItemCenterText.CategoryIndex = 6;
            this.barItemCenterText.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemCenterText.ID = "Center Text";
            this.barItemCenterText.ImageIndex = 52;
            this.barItemCenterText.ImageList = this.smBarItemImages;
            this.barItemCenterText.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.barItemCenterText.ShowToolTipInPopUp = false;
            this.barItemCenterText.SizeToFit = true;
            this.barItemCenterText.Text = "Center Text";
            this.barItemCenterText.Tooltip = "Center Text";
            this.barItemCenterText.Click += new System.EventHandler(this.barItemCenterText_Click);
            // 
            // barItemAlignTextRight
            // 
            this.barItemAlignTextRight.BarName = "barItemAlignTextRight";
            this.barItemAlignTextRight.CategoryIndex = 6;
            this.barItemAlignTextRight.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemAlignTextRight.ID = "Align Text Right";
            this.barItemAlignTextRight.ImageIndex = 53;
            this.barItemAlignTextRight.ImageList = this.smBarItemImages;
            this.barItemAlignTextRight.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.barItemAlignTextRight.ShowToolTipInPopUp = false;
            this.barItemAlignTextRight.SizeToFit = true;
            this.barItemAlignTextRight.Text = "Align Text Right";
            this.barItemAlignTextRight.Tooltip = "Align Text Right";
            this.barItemAlignTextRight.Click += new System.EventHandler(this.barItemAlignTextRight_Click);
            // 
            // barItemTextColor
            // 
            this.barItemTextColor.BarName = "barItemTextColor";
            this.barItemTextColor.CategoryIndex = 6;
            this.barItemTextColor.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemTextColor.ID = "Text Color";
            this.barItemTextColor.ImageIndex = 54;
            this.barItemTextColor.ImageList = this.smBarItemImages;
            this.barItemTextColor.ShowToolTipInPopUp = false;
            this.barItemTextColor.SizeToFit = true;
            this.barItemTextColor.Text = "Text Color";
            this.barItemTextColor.Tooltip = "Text Color";
            this.barItemTextColor.Click += new System.EventHandler(this.barItemTextColor_Click);
            // 
            // barItemSubscript
            // 
            this.barItemSubscript.BarName = "barItemSubscript";
            this.barItemSubscript.CategoryIndex = 6;
            this.barItemSubscript.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemSubscript.ID = "Subscript";
            this.barItemSubscript.ImageIndex = 60;
            this.barItemSubscript.ImageList = this.smBarItemImages;
            this.barItemSubscript.ShowToolTipInPopUp = false;
            this.barItemSubscript.SizeToFit = true;
            this.barItemSubscript.Text = "Subscript";
            this.barItemSubscript.Tooltip = "Subscript";
            this.barItemSubscript.Click += new System.EventHandler(this.barItemSubscript_Click);
            // 
            // barItemSuperscript
            // 
            this.barItemSuperscript.BarName = "barItemSuperscript";
            this.barItemSuperscript.CategoryIndex = 6;
            this.barItemSuperscript.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemSuperscript.ID = "Superscript";
            this.barItemSuperscript.ImageIndex = 59;
            this.barItemSuperscript.ImageList = this.smBarItemImages;
            this.barItemSuperscript.ShowToolTipInPopUp = false;
            this.barItemSuperscript.SizeToFit = true;
            this.barItemSuperscript.Text = "Superscript";
            this.barItemSuperscript.Tooltip = "Superscript";
            this.barItemSuperscript.Click += new System.EventHandler(this.barItemSuperscript_Click);
            // 
            // barItemLower
            // 
            this.barItemLower.BarName = "barItemLower";
            this.barItemLower.CategoryIndex = 6;
            this.barItemLower.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemLower.ID = "Lower";
            this.barItemLower.ImageIndex = 62;
            this.barItemLower.ImageList = this.smBarItemImages;
            this.barItemLower.ShowToolTipInPopUp = false;
            this.barItemLower.SizeToFit = true;
            this.barItemLower.Text = "Lower";
            this.barItemLower.Click += new System.EventHandler(this.barItemLower_Click);
            // 
            // barItemUpper
            // 
            this.barItemUpper.BarName = "barItemUpper";
            this.barItemUpper.CategoryIndex = 6;
            this.barItemUpper.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemUpper.ID = "Upper";
            this.barItemUpper.ImageIndex = 61;
            this.barItemUpper.ImageList = this.smBarItemImages;
            this.barItemUpper.ShowToolTipInPopUp = false;
            this.barItemUpper.SizeToFit = true;
            this.barItemUpper.Text = "Upper";
            this.barItemUpper.Click += new System.EventHandler(this.barItemUpper_Click);
            // 
            // barLayout
            // 
            this.barLayout.BarName = "Layout";
            this.barLayout.Caption = "Layout";
            this.barLayout.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemSpaceAcross,
            this.barItemSpaceDown,
            this.barItemSameWidth,
            this.barItemSameHeight,
            this.barItemSameSize});
            this.barLayout.Manager = this.childFrameBarManager;
            // 
            // barItemSpaceAcross
            // 
            this.barItemSpaceAcross.BarName = "barItemSpaceAcross";
            this.barItemSpaceAcross.CategoryIndex = 9;
            this.barItemSpaceAcross.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemSpaceAcross.ID = "Space Across";
            this.barItemSpaceAcross.ImageIndex = 65;
            this.barItemSpaceAcross.ImageList = this.smBarItemImages;
            this.barItemSpaceAcross.ShowToolTipInPopUp = false;
            this.barItemSpaceAcross.SizeToFit = true;
            this.barItemSpaceAcross.Text = "Space Across";
            this.barItemSpaceAcross.Click += new System.EventHandler(this.barItemSpaceAcross_Click);
            // 
            // barItemSpaceDown
            // 
            this.barItemSpaceDown.BarName = "barItemSpaceDown";
            this.barItemSpaceDown.CategoryIndex = 9;
            this.barItemSpaceDown.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemSpaceDown.ID = "Space Down";
            this.barItemSpaceDown.ImageIndex = 66;
            this.barItemSpaceDown.ImageList = this.smBarItemImages;
            this.barItemSpaceDown.ShowToolTipInPopUp = false;
            this.barItemSpaceDown.SizeToFit = true;
            this.barItemSpaceDown.Text = "Space Down";
            this.barItemSpaceDown.Click += new System.EventHandler(this.barItemSpaceDown_Click);
            // 
            // barItemSameWidth
            // 
            this.barItemSameWidth.BarName = "barItemSameWidth";
            this.barItemSameWidth.CategoryIndex = 9;
            this.barItemSameWidth.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemSameWidth.ID = "Same Width";
            this.barItemSameWidth.ImageIndex = 67;
            this.barItemSameWidth.ImageList = this.smBarItemImages;
            this.barItemSameWidth.ShowToolTipInPopUp = false;
            this.barItemSameWidth.SizeToFit = true;
            this.barItemSameWidth.Text = "Same Width";
            this.barItemSameWidth.Click += new System.EventHandler(this.barItemSameWidth_Click);
            // 
            // barItemSameHeight
            // 
            this.barItemSameHeight.BarName = "barItemSameHeight";
            this.barItemSameHeight.CategoryIndex = 9;
            this.barItemSameHeight.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemSameHeight.ID = "Same Height";
            this.barItemSameHeight.ImageIndex = 68;
            this.barItemSameHeight.ImageList = this.smBarItemImages;
            this.barItemSameHeight.ShowToolTipInPopUp = false;
            this.barItemSameHeight.SizeToFit = true;
            this.barItemSameHeight.Text = "Same Height";
            this.barItemSameHeight.Click += new System.EventHandler(this.barItemSameHeight_Click);
            // 
            // barItemSameSize
            // 
            this.barItemSameSize.BarName = "barItemSameSize";
            this.barItemSameSize.CategoryIndex = 9;
            this.barItemSameSize.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemSameSize.ID = "Same Size";
            this.barItemSameSize.ImageIndex = 69;
            this.barItemSameSize.ImageList = this.smBarItemImages;
            this.barItemSameSize.ShowToolTipInPopUp = false;
            this.barItemSameSize.SizeToFit = true;
            this.barItemSameSize.Text = "Same Size";
            this.barItemSameSize.Click += new System.EventHandler(this.barItemSameSize_Click);
            // 
            // barAlign
            // 
            this.barAlign.BarName = "Align";
            this.barAlign.Caption = "Align";
            this.barAlign.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemAlignLeft,
            this.barItemAlignCenter,
            this.barItemAlignRight,
            this.barItemAlignTop,
            this.barItemAlignMiddle,
            this.barItemAlignBottom});
            this.barAlign.Manager = this.childFrameBarManager;
            // 
            // barItemAlignLeft
            // 
            this.barItemAlignLeft.BarName = "barItemAlignLeft";
            this.barItemAlignLeft.CategoryIndex = 8;
            this.barItemAlignLeft.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemAlignLeft.ID = "Align Left";
            this.barItemAlignLeft.ImageIndex = 70;
            this.barItemAlignLeft.ImageList = this.smBarItemImages;
            this.barItemAlignLeft.ShowToolTipInPopUp = false;
            this.barItemAlignLeft.SizeToFit = true;
            this.barItemAlignLeft.Text = "Align Left";
            this.barItemAlignLeft.Click += new System.EventHandler(this.barItemAlignLeft_Click);
            // 
            // barItemAlignCenter
            // 
            this.barItemAlignCenter.BarName = "barItemAlignCenter";
            this.barItemAlignCenter.CategoryIndex = 8;
            this.barItemAlignCenter.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemAlignCenter.ID = "Align Center";
            this.barItemAlignCenter.ImageIndex = 71;
            this.barItemAlignCenter.ImageList = this.smBarItemImages;
            this.barItemAlignCenter.ShowToolTipInPopUp = false;
            this.barItemAlignCenter.SizeToFit = true;
            this.barItemAlignCenter.Text = "Align Center";
            this.barItemAlignCenter.Click += new System.EventHandler(this.barItemAlignCenter_Click);
            // 
            // barItemAlignRight
            // 
            this.barItemAlignRight.BarName = "barItemAlignRight";
            this.barItemAlignRight.CategoryIndex = 8;
            this.barItemAlignRight.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemAlignRight.ID = "Align Right";
            this.barItemAlignRight.ImageIndex = 72;
            this.barItemAlignRight.ImageList = this.smBarItemImages;
            this.barItemAlignRight.ShowToolTipInPopUp = false;
            this.barItemAlignRight.SizeToFit = true;
            this.barItemAlignRight.Text = "Align Right";
            this.barItemAlignRight.Click += new System.EventHandler(this.barItemAlignRight_Click);
            // 
            // barItemAlignTop
            // 
            this.barItemAlignTop.BarName = "barItemAlignTop";
            this.barItemAlignTop.CategoryIndex = 8;
            this.barItemAlignTop.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemAlignTop.ID = "Align Top";
            this.barItemAlignTop.ImageIndex = 73;
            this.barItemAlignTop.ImageList = this.smBarItemImages;
            this.barItemAlignTop.ShowToolTipInPopUp = false;
            this.barItemAlignTop.SizeToFit = true;
            this.barItemAlignTop.Text = "Align Top";
            this.barItemAlignTop.Click += new System.EventHandler(this.barItemAlignTop_Click);
            // 
            // barItemAlignMiddle
            // 
            this.barItemAlignMiddle.BarName = "barItemAlignMiddle";
            this.barItemAlignMiddle.CategoryIndex = 8;
            this.barItemAlignMiddle.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemAlignMiddle.ID = "Align Middle";
            this.barItemAlignMiddle.ImageIndex = 74;
            this.barItemAlignMiddle.ImageList = this.smBarItemImages;
            this.barItemAlignMiddle.ShowToolTipInPopUp = false;
            this.barItemAlignMiddle.SizeToFit = true;
            this.barItemAlignMiddle.Text = "Align Middle";
            this.barItemAlignMiddle.Click += new System.EventHandler(this.barItemAlignMiddle_Click);
            // 
            // barItemAlignBottom
            // 
            this.barItemAlignBottom.BarName = "barItemAlignBottom";
            this.barItemAlignBottom.CategoryIndex = 8;
            this.barItemAlignBottom.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItemAlignBottom.ID = "Align Bottom";
            this.barItemAlignBottom.ImageIndex = 75;
            this.barItemAlignBottom.ImageList = this.smBarItemImages;
            this.barItemAlignBottom.ShowToolTipInPopUp = false;
            this.barItemAlignBottom.SizeToFit = true;
            this.barItemAlignBottom.Text = "Align Bottom";
            this.barItemAlignBottom.Click += new System.EventHandler(this.barItemAlignBottom_Click);
            // 
            // superToolTip1
            // 
            this.superToolTip1.InitialDelay = 1000;
            this.superToolTip1.ToolTipDuration = 3;
            // 
            // diagramComponent
            // 
            this.diagramComponent.ContextMenu = this.contextMenu1;
            this.diagramComponent.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagramComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramComponent.DpiAware = false;
            this.diagramComponent.HScroll = true;
            this.diagramComponent.LayoutManager = null;
            this.diagramComponent.Location = new System.Drawing.Point(0, 0);
            this.diagramComponent.Model = null;
            this.diagramComponent.Name = "diagramComponent";
            this.diagramComponent.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("diagramComponent.ScrollVirtualBounds")));
            this.diagramComponent.Size = new System.Drawing.Size(544, 414);
            this.diagramComponent.SmartSizeBox = false;
            this.diagramComponent.TabIndex = 0;
            // 
            // 
            // 
            this.diagramComponent.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagramComponent.View.Controller = this.diagramComponent.Controller;
            this.diagramComponent.View.Grid.MinPixelSpacing = 4F;
            this.diagramComponent.View.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("resource.ScrollVirtualBounds")));
            this.diagramComponent.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center;
            this.diagramComponent.VScroll = true;
            // 
            // openDiagramDialog
            // 
            this.openDiagramDialog.Filter = "Diagram Files|*.edd|All files|*.*";
            this.openDiagramDialog.Title = "Open Diagram";
            // 
            // saveDiagramDialog
            // 
            this.saveDiagramDialog.FileName = "doc1";
            this.saveDiagramDialog.Filter = "Diagram files|*.edd|EMF file|*.emf|GIF file|*.gif|PNG file|*.png|BMP file|*.bmp|J" +
                "PEG file|*.jpeg,*.jpg|TIFF file|*.tiff|SVG file|*.svg|All files|*.*";
            // 
            // DiagramForm
            // 
            this.AllowDrop = true;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(544, 414);
            this.Controls.Add(this.diagramComponent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiagramForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Diagram";
            this.Load += new System.EventHandler(this.DiagramForm_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.DiagramForm_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.document)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childFrameBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItemMagnification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItemFontFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItemPointSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramComponent)).EndInit();
            this.ResumeLayout(false);

        }

        void barItemPenciltool_Click(object sender, EventArgs e)
        {
            SetActiveTool("PencilTool");  
        }
        #endregion

        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagramComponent;
        private Model document;
        public ChildFrameBarManager childFrameBarManager;
        public ImageList smBarItemImages;
        public BarItem barItemSelect;
        public BarItem barItemPort;
        public BarItem barItemLine;
        public BarItem barItemRectangle;
        public BarItem barItemPenciltool;
        public BarItem barItemEllipse;
        public BarItem barItemText;
        public BarItem barItemPolyline;
        public BarItem barItemPolygon;
        public BarItem barItemSpline;
        public BarItem barItemCurve;
        public BarItem barItemClosedCurve;
        public BarItem barItemImage;
        public BarItem barItemCircularArc;
        public BarItem barItemSemiCircle;
        public BarItem barItemGroup;
        public BarItem barItemUngroup;
        public BarItem barItemBringToFront;
        public BarItem barItemSendToBack;
        public BarItem barItemBringForward;
        public BarItem barItemSendBackward;
        public BarItem barItemNudgeUp;
        public BarItem barItemNudgeDown;
        public BarItem barItemNudgeLeft;
        public BarItem barItemNudgeRight;
        public BarItem barItemRotateLeft;
        public BarItem barItemRotateRight;
        public BarItem barItemFlipVertical;
        public BarItem barItemFlipHorizontal;
        public Bar barDrawing;
        public Bar barNode;
        public Bar barNudge;
        public Bar barRotate;
        public BarItem barItemPan;
        public Bar bar1;
        public BarItem barItemShowGrid;
        public BarItem barItemSnapToGrid;
        public BarItem barItemZoom;
        public ComboBoxBarItem comboBoxBarItemMagnification;
        public BarItem barItemOrthogonalLink;
        public BarItem barItemOrgLineLink;
        public BarItem barItemLink;
        public Bar barLinks;
        public BarItem barItemDirectedLink;
        public BarItem barItemRichText;
        public BarItem barItemRoundRect;
        public BarItem barItemBoldText;
        public BarItem barItemAlignTextLeft;
        public BarItem barItemCenterText;
        public BarItem barItemAlignTextRight;
        public ComboBoxBarItem comboBoxBarItemFontFamily;
        public ComboBoxBarItem comboBoxBarItemPointSize;
        public Bar bar2;
        public BarItem barItemItalicText;
        public BarItem barItemUnderlineText;
        public BarItem barItemTextColor;
        public BarItem barItemSuperscript;
        public BarItem barItemSubscript;
        public BarItem barItemUpper;
        public BarItem barItemLower;
        public string fileName;
        public BarItem barItemStrikeoutText;
        public BarItem barItemBezier;
        public Bar barLayout;
        public Bar barAlign;
        public BarItem barItemSpaceAcross;
        public BarItem barItemSpaceDown;
        public BarItem barItemSameWidth;
        public BarItem barItemSameHeight;
        public BarItem barItemSameSize;
        public BarItem barItemAlignLeft;
        public BarItem barItemAlignCenter;
        public BarItem barItemAlignRight;
        public BarItem barItemAlignTop;
        public BarItem barItemAlignMiddle;
        public BarItem barItemAlignBottom;
        public ContextMenu contextMenu1;
        public MenuItem mnuAlgn;
        public MenuItem mnuFlip;
        public MenuItem mnuAlgnLeft;
        public MenuItem mnuAlgnCenter;
        public MenuItem mnuAlgnRight;
        public MenuItem mnuAlgnTop;
        public MenuItem mnuAlgnMiddle;
        public MenuItem mnuAlgnBottom;
        public MenuItem mnuGrouping;
        public MenuItem mnuOrder;
        public MenuItem mnuRotate;
        public MenuItem mnuResize;
        public MenuItem mnuFlipHoriz;
        public MenuItem mnuFlipVert;
        public MenuItem mnuFlipBoth;
        public MenuItem mnuGGroup;
        public MenuItem mnuOrdBTF;
        public MenuItem mnuOrdBF;
        public MenuItem mnuOrdSB;
        public MenuItem mnuOrdSTB;
        public MenuItem mnuLayout;
        public MenuItem mnuRtClockwise;
        public MenuItem mnuRtCClockwise;
        public MenuItem mnuRsSameWidth;
        public MenuItem mnuRsSameHeight;
        public MenuItem mnuRsSameSize;
        public MenuItem mnuRsSpaseAcross;
        public MenuItem mnuRsSpaceDown;
        public System.Windows.Forms.MenuItem mnuGUngroup;
        public BarItem m_biSelectedAlignment = null;
        private Syncfusion.Windows.Forms.Tools.SuperToolTip superToolTip1;
        private OpenFileDialog openDiagramDialog;
        private SaveFileDialog saveDiagramDialog;
        private BarItem barItemPolylineLink;
        Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo;
    }
}

