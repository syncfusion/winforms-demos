Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2015"
'
'  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Drawing
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Diagnostics
Imports Syncfusion.Styles
Imports DemoCommon.Grid
Namespace GridControl
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits GridDemoForm
		#Region "API Definition"
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private WithEvents button1 As ButtonAdv
		Private WithEvents buttonAdv1 As ButtonAdv
		Private WithEvents buttonAdv2 As ButtonAdv
		Private WithEvents buttonAdv3 As ButtonAdv
		Private WithEvents buttonAdv4 As ButtonAdv
		Private WithEvents buttonAdv5 As ButtonAdv
		Private WithEvents buttonAdv6 As ButtonAdv
		Private panel1 As Panel
		Private components As IContainer
		#End Region

		#Region "Constructor"
		Public Sub New()
			InitializeComponent()
			GridSettings()
		End Sub
		#End Region    

		#Region "GridSettings"
		''' <summary>
		''' Grid settings for better look and feel. 
		''' </summary>
		Private Sub GridSettings()
			Me.gridControl1.DefaultRowHeight = 20
			Me.gridControl1.DefaultColWidth = 100
			Me.gridControl1.ColCount = 20
			Me.gridControl1.BackColor = Color.White
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.GridVisualStyles = GridVisualStyles.Metro
		End Sub
		#End Region

		#Region "Designer Stuffs"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim gridBaseStyle1 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle2 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle3 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle4 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridRangeStyle1 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle2 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle3 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle4 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv3 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv4 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv5 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv6 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.panel1 = New System.Windows.Forms.Panel()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(222))))))
			Me.gridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			gridBaseStyle1.Name = "Header"
			gridBaseStyle1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle1.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle1.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle1.StyleInfo.CellType = "Header"
			gridBaseStyle1.StyleInfo.Font.Bold = True
			gridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(184)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(216)))))))
			gridBaseStyle1.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
			gridBaseStyle2.Name = "Standard"
			gridBaseStyle2.StyleInfo.Font.Facename = "Tahoma"
			gridBaseStyle2.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
			gridBaseStyle3.Name = "Column Header"
			gridBaseStyle3.StyleInfo.BaseStyle = "Header"
			gridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridBaseStyle4.Name = "Row Header"
			gridBaseStyle4.StyleInfo.BaseStyle = "Header"
			gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
			gridBaseStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(184)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(216)))))))
			Me.gridControl1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() { gridBaseStyle1, gridBaseStyle2, gridBaseStyle3, gridBaseStyle4})
			Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() { New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
			Me.gridControl1.CoveredRanges.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeInfo() { Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(6, 2, 8, 8)})

			Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
			Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridControl1.Location = New System.Drawing.Point(23, 12)
			Me.gridControl1.MetroScrollBars = True
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Properties.BackgroundColor = System.Drawing.Color.White
			Me.gridControl1.Properties.ForceImmediateRepaint = False
			Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(212))))), (CInt(Fix((CByte(212))))), (CInt(Fix((CByte(212))))))
			Me.gridControl1.Properties.MarkColHeader = False
			Me.gridControl1.Properties.MarkRowHeader = False
			gridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle1.StyleInfo.Font.Bold = False
			gridRangeStyle1.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle1.StyleInfo.Font.Italic = False
			gridRangeStyle1.StyleInfo.Font.Size = 9F
			gridRangeStyle1.StyleInfo.Font.Strikeout = False
			gridRangeStyle1.StyleInfo.Font.Underline = False
			gridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle1.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			gridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(6, 2)
			gridRangeStyle2.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
			gridRangeStyle2.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
			gridRangeStyle2.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
			gridRangeStyle2.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
			gridRangeStyle2.StyleInfo.Font.Bold = True
			gridRangeStyle2.StyleInfo.Font.Facename = "Tahoma"
			gridRangeStyle2.StyleInfo.Font.Italic = False
			gridRangeStyle2.StyleInfo.Font.Size = 15.75F
			gridRangeStyle2.StyleInfo.Font.Strikeout = False
			gridRangeStyle2.StyleInfo.Font.Underline = False
			gridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridRangeStyle2.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(124))))), (CInt(Fix((CByte(130)))))))
			gridRangeStyle2.StyleInfo.Text = "Syncfusion - Essential Grid"
			gridRangeStyle2.StyleInfo.TextColor = System.Drawing.Color.White
			gridRangeStyle2.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
			gridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(6, 3, 8, 6)
			gridRangeStyle3.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
			gridRangeStyle3.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
			gridRangeStyle3.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
			gridRangeStyle3.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
			gridRangeStyle3.StyleInfo.Font.Bold = True
			gridRangeStyle3.StyleInfo.Font.Facename = "Tahoma"
			gridRangeStyle3.StyleInfo.Font.Italic = False
			gridRangeStyle3.StyleInfo.Font.Size = 15.75F
			gridRangeStyle3.StyleInfo.Font.Strikeout = False
			gridRangeStyle3.StyleInfo.Font.Underline = False
			gridRangeStyle3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridRangeStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(228))))), (CInt(Fix((CByte(221)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(184))))), (CInt(Fix((CByte(109)))))))
			gridRangeStyle3.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(65))))), (CInt(Fix((CByte(125))))))
			gridRangeStyle3.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
			gridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(7, 2, 8, 6)
			gridRangeStyle4.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
			gridRangeStyle4.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
			gridRangeStyle4.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
			gridRangeStyle4.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
			gridRangeStyle4.StyleInfo.Font.Bold = True
			gridRangeStyle4.StyleInfo.Font.Facename = "Tahoma"
			gridRangeStyle4.StyleInfo.Font.Italic = False
			gridRangeStyle4.StyleInfo.Font.Size = 15.75F
			gridRangeStyle4.StyleInfo.Font.Strikeout = False
			gridRangeStyle4.StyleInfo.Font.Underline = False
			gridRangeStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridRangeStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(228))))), (CInt(Fix((CByte(221)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(184))))), (CInt(Fix((CByte(109)))))))
			gridRangeStyle4.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(65))))), (CInt(Fix((CByte(125))))))
			gridRangeStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
			Me.gridControl1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() { gridRangeStyle1, gridRangeStyle2, gridRangeStyle3, gridRangeStyle4})
			Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.gridControl1.RowCount = 35
			Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() { New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
			Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
			Me.gridControl1.Size = New System.Drawing.Size(869, 425)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.Tag = "SaveXmlSchema"
			Me.gridControl1.ThemesEnabled = True
			' 
			' button1
			' 
			Me.button1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220))))))
			Me.button1.BeforeTouchSize = New System.Drawing.Size(106, 34)
			Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.ForeColor = System.Drawing.Color.White
			Me.button1.IsBackStageButton = False
			Me.button1.Location = New System.Drawing.Point(11, 6)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(106, 34)
			Me.button1.TabIndex = 12
			Me.button1.Text = "Soap Serialize"
			Me.button1.UseVisualStyle = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' buttonAdv1
			' 
			Me.buttonAdv1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220))))))
			Me.buttonAdv1.BeforeTouchSize = New System.Drawing.Size(101, 34)
			Me.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.buttonAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv1.ForeColor = System.Drawing.Color.White
			Me.buttonAdv1.IsBackStageButton = False
			Me.buttonAdv1.Location = New System.Drawing.Point(132, 6)
			Me.buttonAdv1.Name = "buttonAdv1"
			Me.buttonAdv1.Size = New System.Drawing.Size(101, 34)
			Me.buttonAdv1.TabIndex = 13
			Me.buttonAdv1.Text = "Soap Deserialize"
			Me.buttonAdv1.UseVisualStyle = True
'			Me.buttonAdv1.Click += New System.EventHandler(Me.buttonAdv1_Click)
			' 
			' buttonAdv2
			' 
			Me.buttonAdv2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220))))))
			Me.buttonAdv2.BeforeTouchSize = New System.Drawing.Size(107, 34)
			Me.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.buttonAdv2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv2.ForeColor = System.Drawing.Color.White
			Me.buttonAdv2.IsBackStageButton = False
			Me.buttonAdv2.Location = New System.Drawing.Point(254, 6)
			Me.buttonAdv2.Name = "buttonAdv2"
			Me.buttonAdv2.Size = New System.Drawing.Size(107, 34)
			Me.buttonAdv2.TabIndex = 14
			Me.buttonAdv2.Text = "Binary Serialize"
			Me.buttonAdv2.UseVisualStyle = True
'			Me.buttonAdv2.Click += New System.EventHandler(Me.buttonAdv2_Click)
			' 
			' buttonAdv3
			' 
			Me.buttonAdv3.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220))))))
			Me.buttonAdv3.BeforeTouchSize = New System.Drawing.Size(116, 34)
			Me.buttonAdv3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.buttonAdv3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv3.ForeColor = System.Drawing.Color.White
			Me.buttonAdv3.IsBackStageButton = False
			Me.buttonAdv3.Location = New System.Drawing.Point(379, 6)
			Me.buttonAdv3.Name = "buttonAdv3"
			Me.buttonAdv3.Size = New System.Drawing.Size(116, 34)
			Me.buttonAdv3.TabIndex = 15
			Me.buttonAdv3.Text = "Binary Deserialize"
			Me.buttonAdv3.UseVisualStyle = True
'			Me.buttonAdv3.Click += New System.EventHandler(Me.buttonAdv3_Click)
			' 
			' buttonAdv4
			' 
			Me.buttonAdv4.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220))))))
			Me.buttonAdv4.BeforeTouchSize = New System.Drawing.Size(118, 34)
			Me.buttonAdv4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.buttonAdv4.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv4.ForeColor = System.Drawing.Color.White
			Me.buttonAdv4.IsBackStageButton = False
			Me.buttonAdv4.Location = New System.Drawing.Point(513, 6)
			Me.buttonAdv4.Name = "buttonAdv4"
			Me.buttonAdv4.Size = New System.Drawing.Size(118, 34)
			Me.buttonAdv4.TabIndex = 16
			Me.buttonAdv4.Text = "Save XML Schema"
			Me.buttonAdv4.UseVisualStyle = True
'			Me.buttonAdv4.Click += New System.EventHandler(Me.buttonAdv4_Click)
			' 
			' buttonAdv5
			' 
			Me.buttonAdv5.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220))))))
			Me.buttonAdv5.BeforeTouchSize = New System.Drawing.Size(114, 34)
			Me.buttonAdv5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.buttonAdv5.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv5.ForeColor = System.Drawing.Color.White
			Me.buttonAdv5.IsBackStageButton = False
			Me.buttonAdv5.Location = New System.Drawing.Point(649, 6)
			Me.buttonAdv5.Name = "buttonAdv5"
			Me.buttonAdv5.Size = New System.Drawing.Size(114, 34)
			Me.buttonAdv5.TabIndex = 17
			Me.buttonAdv5.Text = "Load XML Schema"
			Me.buttonAdv5.UseVisualStyle = True
'			Me.buttonAdv5.Click += New System.EventHandler(Me.buttonAdv5_Click)
			' 
			' buttonAdv6
			' 
			Me.buttonAdv6.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.buttonAdv6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv6.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220))))))
			Me.buttonAdv6.BeforeTouchSize = New System.Drawing.Size(87, 34)
			Me.buttonAdv6.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.buttonAdv6.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv6.ForeColor = System.Drawing.Color.White
			Me.buttonAdv6.IsBackStageButton = False
			Me.buttonAdv6.Location = New System.Drawing.Point(782, 6)
			Me.buttonAdv6.Name = "buttonAdv6"
			Me.buttonAdv6.Size = New System.Drawing.Size(87, 34)
			Me.buttonAdv6.TabIndex = 18
			Me.buttonAdv6.Text = "Reset Grid"
			Me.buttonAdv6.UseVisualStyle = True
'			Me.buttonAdv6.Click += New System.EventHandler(Me.buttonAdv6_Click)
			' 
			' panel1
			' 
			Me.panel1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel1.Controls.Add(Me.buttonAdv4)
			Me.panel1.Controls.Add(Me.buttonAdv6)
			Me.panel1.Controls.Add(Me.button1)
			Me.panel1.Controls.Add(Me.buttonAdv5)
			Me.panel1.Controls.Add(Me.buttonAdv1)
			Me.panel1.Controls.Add(Me.buttonAdv2)
			Me.panel1.Controls.Add(Me.buttonAdv3)
			Me.panel1.Location = New System.Drawing.Point(23, 443)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(879, 51)
			Me.panel1.TabIndex = 19
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.ClientSize = New System.Drawing.Size(914, 495)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.gridControl1)
			Me.MinimumSize = New System.Drawing.Size(900, 500)
			Me.Name = "Form1"
			Me.Text = "Serialize Grid Control"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
        <STAThread()> _
  Shared Sub Main()
            Application.Run(New Form1())
        End Sub
		#End Region

		#Region "Button Click Event handlers"
		''' <summary>
		''' Serializing the grid to SOAP format. 
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Serialization using Soap Formatter
			Dim dlg As FileDialog = New SaveFileDialog()
			dlg.Filter = "Soap files (*.soap)|*.soap|All files (*.*)|*.*"
			If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Try
					Me.Cursor = Cursors.WaitCursor
					'Save the grid model object to a stream in SOAP format
					Me.gridControl1.Model.SaveSoap(dlg.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.ToString())
				Finally
					Me.Cursor = Cursors.Default
				End Try
			End If


		End Sub
		''' <summary>
		''' Deserializing the SOAP format to grid
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.Click
			'Deserialization using Soap Formatter
			Dim dlg As FileDialog = New OpenFileDialog()
			dlg.Filter = "Soap files (*.soap)|*.soap|All files (*.*)|*.*"
			If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Try
					Me.Cursor = Cursors.WaitCursor
					'Recreates a grid model object from a strem with data in SOAP format
					Me.gridControl1.Model = GridModel.LoadSoap(dlg.FileName)
					Me.gridControl1.Refresh()
				Catch ex As Exception
					MessageBox.Show(ex.ToString())
				Finally
					Me.Cursor = Cursors.Default
				End Try
			End If
		End Sub
		''' <summary>
		''' Serializing the grid to Binary format
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub buttonAdv2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv2.Click
			'Serialization using Binary Formatter
			Dim dlg As FileDialog = New SaveFileDialog()
			dlg.Filter = "Binary files (*.egt)|*.egt|All files (*.*)|*.*"
			If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Try
					Me.Cursor = Cursors.WaitCursor
					'Save the grid model object to a stream in Binary format
					Me.gridControl1.Model.SaveBinary(dlg.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.ToString())
				Finally
					Me.Cursor = Cursors.Default
				End Try
			End If
		End Sub

		''' <summary>
		''' Deserializing the binary format to Grid. 
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub buttonAdv3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv3.Click
			'Deserialization using Binary Formatter
			Dim dlg As FileDialog = New OpenFileDialog()
			dlg.Filter = "Binary files (*.egt)|*.egt|All files (*.*)|*.*"
			If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Try
					Me.Cursor = Cursors.WaitCursor
					'Recreates a grid model object from a strem with data in Binary format
					Me.gridControl1.Model = GridModel.LoadBinary(dlg.FileName)
					Me.gridControl1.Refresh()
				Catch ex As Exception
					MessageBox.Show(ex.ToString())
				Finally
					Me.Cursor = Cursors.Default
				End Try
			End If
		End Sub

		''' <summary>
		''' Serializing the grid to XML format. 
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub buttonAdv4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv4.Click
			'Xml Serialization
			Dim dlg As FileDialog = New SaveFileDialog()
			dlg.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*"
			If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Dim s As Stream = Nothing

				Try
					Me.Cursor = Cursors.WaitCursor
					Me.gridControl1.SaveXml(dlg.FileName)
				Catch ex As Exception
					s.Close()
					MessageBox.Show(ex.ToString())
				Finally
					Me.Cursor = Cursors.Default
				End Try
			End If
		End Sub

		''' <summary>
		''' Deserializing the XML format to grid. 
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub buttonAdv5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv5.Click
			'Xml Deserialization
			Dim dlg As FileDialog = New OpenFileDialog()
			dlg.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*"
			If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Dim s As Stream = Nothing
				Try
					Me.Cursor = Cursors.WaitCursor
					Me.gridControl1.InitializeFromXml(dlg.FileName)
					Me.gridControl1.Refresh()
				Catch ex As Exception
					s.Close()
					MessageBox.Show(ex.ToString())
				Finally
					Me.Cursor = Cursors.Default
				End Try
			End If
		End Sub

		Private Sub buttonAdv6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv6.Click
			Me.gridControl1.ResetRangeStyles()
			Me.gridControl1.GridVisualStyles = GridVisualStyles.SystemTheme
		End Sub
#End Region
	End Class
End Namespace
