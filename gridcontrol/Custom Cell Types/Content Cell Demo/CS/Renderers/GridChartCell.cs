#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Security.Permissions;
using System.ComponentModel;

using Syncfusion.Diagnostics;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Styles;
using Syncfusion.Drawing;

namespace ContentCellDemo
{
	#region ChartCellModel class
	[Serializable]
	public class GridChartCellModel : GridStaticCellModel
	{

		public GridChartCellModel(GridModel grid)
			: base(grid)
		{
			this.cellvalueGridRangeInfo = new GridRangeInfo();
			this.chartareaGridRangeInfo = new GridRangeInfo();
		}

		protected GridChartCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		/// <override/>
		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new GridChartCellRenderer(control, this);			
		}

		public void InitializeChartProperties(ChartControl chart, GridStyleInfo style)
		{
			chart.BeginUpdate();

			

			//if(chart.Series.Count == 1)
			{
				GridRangeInfo range = this.cellvalueGridRangeInfo;
			
				chart.Series.Clear();
				for(int i = 0; i < range.Width; i++)
				{
                    ChartSeries series = new ChartSeries(string.Format("Team {0}", i + 1));//,csp.ChartType);
					//series = chart.Model.NewSeries(string.Format("Team {0}", i));
                    series.Text = series.Name;
					series.SeriesModel = new ChartGridSeriesModel(this.Grid, range, i);
					chart.Series.Add(series);
				}
			}

			ChartStyleProperties csp=new ChartStyleProperties(style);
			chart.Text=csp.TitleText;
			chart.TextAlignment=csp.TitleAlignment;
			//chart.TextPosition=csp.TitlePostion;
			chart.Palette=csp.ColorPalette;
            if(csp.ChartBackColor !=  Color.Transparent)
			    chart.BackColor=csp.ChartBackColor;
			chart.ChartArea.BackInterior=csp.ChartAreaBackInterior;
			//chart.Legend.Visible=true;
			//chart.ShowLegend=csp.ShowLegend;
			//chart.LegendPosition=csp.LegendPosition;
			chart.Series3D=csp.Series3D;
			chart.PrimaryXAxis.DrawGrid=csp.XAxisGridLines;
			chart.PrimaryYAxis.DrawGrid=csp.YAxisGridLines;
			chart.PrimaryXAxis.Title=csp.XAxisTitle;
			chart.PrimaryYAxis.Title=csp.YAxisTitle;
			foreach(ChartSeries ss in chart.Series)
				ss.Type=csp.ChartType;
			chart.EndUpdate();
		}

		private GridRangeInfo cellvalueGridRangeInfo;
		private GridRangeInfo chartareaGridRangeInfo;

		public GridRangeInfo ChartAreaRangeInfo
		{
			get
			{
				return this.chartareaGridRangeInfo;
			}
			set
			{
				this.chartareaGridRangeInfo = value;
			}
		}

		public GridRangeInfo CellValueRangeInfo
		{
			get
			{
				return this.cellvalueGridRangeInfo;
			}
			set
			{
				this.cellvalueGridRangeInfo = value;
			}
		}
	}
	#endregion

	#region ChartCellRenderer class
	public class GridChartCellRenderer : GridStaticCellRenderer
	{
		private GridChartControl chartControl;		
		private Bitmap bmp;

		public GridChartCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
		{
			chartControl = new GridChartControl(this);	
		}

		void FixParent(GridChartControl chart)
		{
			if (this.chartControl.Parent != Grid)
			{
				this.chartControl.Visible = true;
				this.chartControl.Location = new Point(10000, 10000);
				this.chartControl.CausesValidation = false;
				Grid.Controls.Add(chartControl);
				this.chartControl.Visible = false;
			}
		}

		protected override void OnDraw(Graphics g, Rectangle clientRectangle, int rowIndex, int colIndex, GridStyleInfo style)
		{
			// Get the client bounds taking floated cells into consideration.
			Rectangle bounds = GetCellClientRectangle(rowIndex, colIndex, style, true);
			this.chartControl.Location = bounds.Location;
			this.chartControl.BackColor = Color.FromArgb(255, Grid.GetBackColor(style.Interior.BackColor));
			//this.chartControl.Legend.Visible=true;

			GridChartCellModel model = this.Model as GridChartCellModel;
			
			model.InitializeChartProperties(this.chartControl,style);

			FixParent(this.chartControl);		
			
			if(bmp == null)
				bmp = new Bitmap(bounds.Width, bounds.Height);
			
			chartControl.Draw(bmp);
			
			g.DrawImage(bmp, bounds);
		}

    }
    #endregion

    #region GridChartControl class
    [
	ToolboxItem(false)
	]
	public class GridChartControl : ChartControl
	{
		GridChartCellRenderer parent;
		
		public GridChartControl(GridChartCellRenderer parent)
		{
			this.parent = parent;			
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public GridChartCellRenderer ParentCell
		{
			get
			{
				return this.parent;
			} 
		}
	}	
	#endregion

	#region ChartStyleProperties class
	/// <summary>
	/// Provides custom properties specific for slider control. All properties
	/// support the style inheritance mechanism. You can change these propeties
	/// in the property grid.
	/// </summary>
	public class ChartStyleProperties : GridStyleInfoCustomProperties
	{
		// static initialization of property descriptors
		static Type t = typeof(ChartStyleProperties);

		readonly static StyleInfoProperty ChartTypeProperty = CreateStyleInfoProperty(t, "ChartType");
		readonly static StyleInfoProperty TitleTextProperty = CreateStyleInfoProperty(t, "TitleText");
		readonly static StyleInfoProperty TitleAlignmentProperty = CreateStyleInfoProperty(t, "TitleAlignment");
		//readonly static StyleInfoProperty TitlePositionProperty = CreateStyleInfoProperty(t, "TitlePosition");
		readonly static StyleInfoProperty ColorPaletteProperty = CreateStyleInfoProperty(t, "ColorPalette");
		readonly static StyleInfoProperty ChartBackColorProperty = CreateStyleInfoProperty(t, "ChartBackColor");
		//readonly static StyleInfoProperty ShowLegendProperty = CreateStyleInfoProperty(t, "ShowLegend");
		//readonly static StyleInfoProperty LegendPositionProperty = CreateStyleInfoProperty(t, "LegendPosition");
		readonly static StyleInfoProperty ChartAreaBackInteriorProperty = CreateStyleInfoProperty(t, "ChartAreaBackInterior");
		readonly static StyleInfoProperty Series3DProperty = CreateStyleInfoProperty(t, "Series3D");
		readonly static StyleInfoProperty XAxisGridLinesProperty = CreateStyleInfoProperty(t, "XAxisGridLines");
		readonly static StyleInfoProperty YAxisGridLinesProperty = CreateStyleInfoProperty(t, "YAxisGridLines");
		readonly static StyleInfoProperty XAxisTitleProperty = CreateStyleInfoProperty(t, "XAxisTitle");
		readonly static StyleInfoProperty YAxisTitleProperty = CreateStyleInfoProperty(t, "YAxisTitle");
		
		// default settings for all properties this object holds
		static ChartStyleProperties defaultObject;

		// initialize default settings for all properties in static ctor
		static ChartStyleProperties ()
		{
			// all properties must be initialized for the Default property
			defaultObject = new ChartStyleProperties(GridStyleInfo.Default);
			ChartControl chartCtrl = new ChartControl();
			defaultObject.ChartType=ChartSeriesType.Column;
			defaultObject.TitleText=chartCtrl.Text;
			defaultObject.ColorPalette=chartCtrl.Palette;
			defaultObject.ChartBackColor=chartCtrl.BackColor;
			defaultObject.ChartAreaBackInterior=chartCtrl.ChartArea.BackInterior;
			//defaultObject.ShowLegend=chartCtrl.ShowLegend;
			//defaultObject.TitlePostion=chartCtrl.TextPosition;
			defaultObject.TitleAlignment=chartCtrl.TextAlignment;
			//defaultObject.LegendPosition=chartCtrl.LegendPosition;
			defaultObject.Series3D=chartCtrl.Series3D;
			defaultObject.XAxisGridLines=chartCtrl.PrimaryXAxis.DrawGrid;
			defaultObject.YAxisGridLines=chartCtrl.PrimaryYAxis.DrawGrid;
			defaultObject.XAxisTitle=chartCtrl.PrimaryXAxis.Title;
			defaultObject.YAxisTitle=chartCtrl.PrimaryYAxis.Title;
		}

		/// <summary>
		/// Provides access to default values for this type
		/// </summary>
		public static ChartStyleProperties Default
		{
			get
			{
				return defaultObject;
			}
		}

		/// <summary>
		/// Force static ctor being called at least once
		/// </summary>
		public static void Initialize()
		{
		}

		// explicit cast from GridStyleInfo to ChartStyleProperties
		// (Note: this will only work for C#, Visual Basic does not support dynamic casts)

		/// <summary>
		/// Explicit cast from GridStyleInfo to this custom propety object
		/// </summary>
		/// <returns>A new custom properties object.</returns>
		public static explicit operator ChartStyleProperties(GridStyleInfo style)
		{
			return new ChartStyleProperties(style);
		}

		/// <summary>
		/// Initializes a ChartStyleProperties object with a style object that holds all data
		/// </summary>
		public ChartStyleProperties(GridStyleInfo style)
			: base(style)
		{
		}

		/// <summary>
		/// Initializes a ChartStyleProperties object with an empty style object. Design
		/// time environment will use this ctor and later copy the values to a style object
		/// by calling style.CustomProperties.Add(gridExcelTipStyleProperties1)
		/// </summary>
		public ChartStyleProperties()
			: base()
		{
		}

		/// <summary>
		/// Gets or sets Chart Type
		/// </summary>
		[
		Description("Provides the chart type for this cell"),
		Browsable(true),
		Category("Chart")
		]
		public ChartSeriesType ChartType
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (ChartSeriesType) style.GetValue(ChartTypeProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(ChartTypeProperty, value);
			}
		}
				
		/// <summary>
		/// Gets or sets Title Text of the chart
		/// </summary>
		[
		Description("Provides the Text for this cell"),
		Browsable(true),
		Category("Chart")
		]
		public string TitleText
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (string) style.GetValue(TitleTextProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(TitleTextProperty, value);
			}
		}

		/// <summary>
		/// Specifies the Horizontal Alignment of TitleText of the chart
		/// </summary>
		[
		Description("Provides the Alignment for TitleText of the chart cell"),
		Browsable(true),
		Category("Chart")
		]
		public StringAlignment TitleAlignment
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (StringAlignment) style.GetValue(TitleAlignmentProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(TitleAlignmentProperty, value);
			}
		}

//		/// <summary>
//		/// Specifies the position of the TitleText of the chart
//		/// </summary>
//		[
//		Description("Provides the TitlePosition of the chart cell"),
//		Browsable(true),
//		Category("Chart")
//		]
//		public ChartTextPosition TitlePostion
//		{
//			get
//			{
//				//TraceUtil.TraceCurrentMethodInfo();
//				return (ChartTextPosition) style.GetValue(TitlePositionProperty);
//			}
//			set
//			{
//				//TraceUtil.TraceCurrentMethodInfo(value);
//				style.SetValue(TitlePositionProperty, value);
//			}
//		}

//		/// <summary>
//		/// Specifies whether the Legend should be displayed or not
//		/// </summary>
//		[
//		Description("Specifies whether the Legend should be displayed or not"),
//		Browsable(true),
//		Category("Chart")
//		]
//		public bool ShowLegend
//		{
//			get
//			{
//				//TraceUtil.TraceCurrentMethodInfo();
//				return (bool) style.GetValue(ShowLegendProperty);
//			}
//			set
//			{
//				//TraceUtil.TraceCurrentMethodInfo(value);
//				style.SetValue(ShowLegendProperty, value);
//			}
//		}
//
//		/// <summary>
//		/// Specifies the LegendPosition of the chart
//		/// </summary>
//		[
//		Description("Provides the LegendPosition for the chart cell"),
//		Browsable(true),
//		Category("Chart")
//		]
//		public ChartDock LegendPosition
//		{
//			get
//			{
//				//TraceUtil.TraceCurrentMethodInfo();
//				return (ChartDock) style.GetValue(LegendPositionProperty);
//			}
//			set
//			{
//				//TraceUtil.TraceCurrentMethodInfo(value);
//				style.SetValue(LegendPositionProperty, value);
//			}
//		}

		/// <summary>
		/// Gets or sets Color Palette of the chart
		/// </summary>
		[
		Description("Provides the Color Palette for the chart"),
		Browsable(true),
		Category("Chart")
		]
		public ChartColorPalette ColorPalette
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (ChartColorPalette) style.GetValue(ColorPaletteProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(ColorPaletteProperty, value);
			}
		}
		
		/// <summary>
		/// Gets or sets BackColor
		/// </summary>
		[
		Description("Provides the BackColor for this cell"),
		Browsable(true),
		Category("Chart")
		]
		public Color ChartBackColor
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (Color) style.GetValue(ChartBackColorProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(ChartBackColorProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets Interior of the ChartArea
		/// </summary>
		[
		Description("Provides the Interior for the ChartArea of this cell"),
		Browsable(true),
		Category("Chart")
		]
		public BrushInfo ChartAreaBackInterior
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (BrushInfo) style.GetValue(ChartAreaBackInteriorProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(ChartAreaBackInteriorProperty, value);
			}
		}

		/// <summary>
		/// Allows 3DStyle
		/// </summary>
		[
		Description("Allows 3D style"),
		Browsable(true),
		Category("Chart")
		]
		public bool Series3D
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (bool) style.GetValue(Series3DProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(Series3DProperty, value);
			}
		}

		/// <summary>
		/// Specifies whether to display grid lines along the Primary X-Axis or not
		/// </summary>
		[
		Description("Specifies whether to display grid lines along the Primary X-Axis or not"),
		Browsable(true),
		Category("Chart")
		]
		public bool XAxisGridLines
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (bool) style.GetValue(XAxisGridLinesProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(XAxisGridLinesProperty, value);
			}
		}

		/// <summary>
		/// Specifies whether to display grid lines along the Primary Y-Axis or not
		/// </summary>
		[
		Description("Specifies whether to display grid lines along the Primary Y-Axis or not"),
		Browsable(true),
		Category("Chart")
		]
		public bool YAxisGridLines
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (bool) style.GetValue(YAxisGridLinesProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(YAxisGridLinesProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the title of the x-axis
		/// </summary>
		[
		Description("Privides the Title for Primary X-Axis"),
		Browsable(true),
		Category("Chart")
		]
		public string XAxisTitle
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (string) style.GetValue(XAxisTitleProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(XAxisTitleProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the title of the y-axis
		/// </summary>
		[
		Description("Privides the Title for Primary Y-Axis"),
		Browsable(true),
		Category("Chart")
		]
		public string YAxisTitle
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (string) style.GetValue(YAxisTitleProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(YAxisTitleProperty, value);
			}
		}
	}
	#endregion
}
