#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.IO;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Styles;


namespace InteractiveCellDemo
{
	public class SliderCellModel : GridGenericControlCellModel
	{
		public SliderCellModel(GridModel grid)
			: base(grid)
		{
			SliderStyleProperties.Initialize();
		}
	
		protected SliderCellModel(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public override GridCellRendererBase CreateRenderer(GridControlBase control)
		{
			return new SliderCellRenderer(control, this);
		}

		public Size trackBarControlSize = Size.Empty;

		protected override Size OnQueryPrefferedClientSize(Graphics g, int rowIndex, int colIndex, GridStyleInfo style, GridQueryBounds queryBounds)
		{
			if (trackBarControlSize.IsEmpty)
			{
				TrackBar drawSlider = new TrackBar();
				trackBarControlSize = drawSlider.Size;
				trackBarControlSize.Width += 24;
				trackBarControlSize.Height += 10;
			}
			return trackBarControlSize;
		}

		public static void InitializeSlider(TrackBar c, GridStyleInfo style)
		{
			SliderStyleProperties sp = new SliderStyleProperties(style);
			c.Minimum = sp.Minimum;
			c.Maximum = sp.Maximum;
			c.LargeChange = sp.LargeChange;
			c.SmallChange = sp.SmallChange;
			c.TickFrequency = sp.TickFrequency;
			c.TickStyle = sp.TickStyle;
			c.Orientation = sp.Orientation;
			c.AutoSize = false;
			c.BackColor = style.BackColor;
			InitializeSlider(c, style.CellValue);
		}

		public static void InitializeSlider(TrackBar c, object controlValue)
		{
			if (controlValue is int)
				c.Value = (int) controlValue;
			else if (controlValue is string && ((string) controlValue).Length > 0)
				c.Value = int.Parse((string) controlValue);
			else
				c.Value = c.Minimum;
		}

	}
	
	public class SliderCellRenderer: GridGenericControlCellRenderer
	{
		TrackBar drawSlider = new TrackBar();
		TrackBar editSlider = new TrackBar();
		SliderCellModel cm;
		
		public SliderCellRenderer(GridControlBase grid, GridCellModelBase cellModel)
			: base(grid, cellModel)
		{
			cm = (SliderCellModel) cellModel;
			SupportsFocusControl = true;
			FixControlParent(drawSlider);
			SetControl(editSlider);
			editSlider.AutoSize = false;
			editSlider.ValueChanged += new EventHandler(trackBar_ValueChanged);
			cm.trackBarControlSize = drawSlider.Size;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				editSlider.ValueChanged -= new EventHandler(trackBar_ValueChanged);
				editSlider.Dispose();
				editSlider = null;
				drawSlider.Dispose();
				drawSlider = null;
				cm = null;
			}

			base.Dispose (disposing);
		}

		protected /*internal*/ override bool OnSaveChanges()
		{
			this.Grid.Model[RowIndex, ColIndex].CellValue = editSlider.Value;
			return true;
		}

		protected override void OnDraw(Graphics g, Rectangle clientRectangle, int rowIndex, int colIndex, GridStyleInfo style)
		{
			if (this.ShouldDrawFocused(rowIndex, colIndex))
			{
				style.Control = editSlider;
			}
			else
			{
				style.Control = drawSlider;
				SliderCellModel.InitializeSlider(drawSlider, style);
			}
			base.OnDraw (g, clientRectangle, rowIndex, colIndex, style);
		}

		protected override void OnInitialize(int rowIndex, int colIndex)
		{
			SliderCellModel.InitializeSlider(editSlider, Grid.GetViewStyleInfo(rowIndex, colIndex));
		}

		protected override void InitializeControlText(object controlValue)
		{
			SliderCellModel.InitializeSlider(this.editSlider, controlValue);
		}

		protected override Rectangle OnLayout(int rowIndex, int colIndex, GridStyleInfo style, Rectangle innerBounds, Rectangle[] buttonsBounds)
		{
			Rectangle r = base.OnLayout (rowIndex, colIndex, style, innerBounds, buttonsBounds);

			r.Inflate(-2, -2);

			return r;
			
			// center windows forms trackBar inside cell.
			//return GridUtil.CenterInRect(r, cm.trackBarControlSize);
		}

		private void trackBar_ValueChanged(object sender, EventArgs e)
		{
			// Raise CurrentCellChanging event and set CurrentCell.Modified = true
			if (base.NotifyCurrentCellChanging())
			{
				ControlValue = editSlider.Value;
				base.NotifyCurrentCellChanged();
			}
		}
	}

	/// <summary>
	/// Provides custom properties specific for slider control. All properties
	/// support the style inheritance mechanism. You can change these propeties
	/// in the property grid.
	/// </summary>
	public class SliderStyleProperties : GridStyleInfoCustomProperties
	{
		// static initialization of property descriptors
		static Type t = typeof(SliderStyleProperties);

		readonly static StyleInfoProperty MinimumProperty = CreateStyleInfoProperty(t, "Minimum");
		readonly static StyleInfoProperty MaximumProperty = CreateStyleInfoProperty(t, "Maximum");
		readonly static StyleInfoProperty SmallChangeProperty = CreateStyleInfoProperty(t, "SmallChange");
		readonly static StyleInfoProperty LargeChangeProperty = CreateStyleInfoProperty(t, "LargeChange");
		readonly static StyleInfoProperty OrientationProperty = CreateStyleInfoProperty(t, "Orientation");
		readonly static StyleInfoProperty TickFrequencyProperty = CreateStyleInfoProperty(t, "TickFrequency");
		readonly static StyleInfoProperty TickStyleProperty = CreateStyleInfoProperty(t, "TickStyle");
		
		// default settings for all properties this object holds
		static SliderStyleProperties defaultObject;

		// initialize default settings for all properties in static ctor
		static SliderStyleProperties ()
		{
			// all properties must be initialized for the Default property
			defaultObject = new SliderStyleProperties(GridStyleInfo.Default);
			TrackBar tb = new TrackBar();
			defaultObject.Minimum = tb.Minimum;
			defaultObject.Maximum = tb.Maximum;
			defaultObject.SmallChange = tb.SmallChange;
			defaultObject.LargeChange = tb.LargeChange;
			defaultObject.TickFrequency = tb.TickFrequency;
			defaultObject.TickStyle = tb.TickStyle;
			defaultObject.Orientation = tb.Orientation;
		}

		/// <summary>
		/// Provides access to default values for this type
		/// </summary>
		public static SliderStyleProperties Default
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

		// explicit cast from GridStyleInfo to SliderStyleProperties
		// (Note: this will only work for C#, Visual Basic does not support dynamic casts)

		/// <summary>
		/// Explicit cast from GridStyleInfo to this custom propety object
		/// </summary>
		/// <returns>A new custom properties object.</returns>
		public static explicit operator SliderStyleProperties(GridStyleInfo style)
		{
			return new SliderStyleProperties(style);
		}

		/// <summary>
		/// Initializes a SliderStyleProperties object with a style object that holds all data
		/// </summary>
		public SliderStyleProperties(GridStyleInfo style)
			: base(style)
		{
		}

		/// <summary>
		/// Initializes a SliderStyleProperties object with an empty style object. Design
		/// time environment will use this ctor and later copy the values to a style object
		/// by calling style.CustomProperties.Add(gridExcelTipStyleProperties1)
		/// </summary>
		public SliderStyleProperties()
			: base()
		{
		}

		/// <summary>
		/// Gets or sets Minimum state
		/// </summary>
		[
		Description("Provides the Minimum for this cell"),
		Browsable(true),
		Category("Slider")
		]
		public int Minimum
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (int) style.GetValue(MinimumProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(MinimumProperty, value);
			}
		}
		/// <summary>
		/// Resets Minimum state
		/// </summary>
		public void ResetMinimum()
		{
			style.ResetValue(MinimumProperty);
		}
		[EditorBrowsableAttribute(EditorBrowsableState.Never)]
		private bool ShouldSerializeMinimum()
		{
			return style.HasValue(MinimumProperty);
		}
		/// <summary>
		/// Gets if Minimum state has been initialized for the current object.
		/// </summary>
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool HasMinimum
		{
			get
			{
				return style.HasValue(MinimumProperty);
			}
		}		
		/// <summary>
		/// Gets or sets Maximum state
		/// </summary>
		[
		Description("Provides the Maximum for this cell"),
		Browsable(true),
		Category("Slider")
		]
		public int Maximum
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (int) style.GetValue(MaximumProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(MaximumProperty, value);
			}
		}
		/// <summary>
		/// Resets Maximum state
		/// </summary>
		public void ResetMaximum()
		{
			style.ResetValue(MaximumProperty);
		}
		[EditorBrowsableAttribute(EditorBrowsableState.Never)]
		private bool ShouldSerializeMaximum()
		{
			return style.HasValue(MaximumProperty);
		}
		/// <summary>
		/// Gets if Maximum state has been initialized for the current object.
		/// </summary>
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool HasMaximum
		{
			get
			{
				return style.HasValue(MaximumProperty);
			}
		}		
		/// <summary>
		/// Gets or sets SmallChange state
		/// </summary>
		[
		Description("Provides the SmallChange for this cell"),
		Browsable(true),
		Category("Slider")
		]
		public int SmallChange
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (int) style.GetValue(SmallChangeProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(SmallChangeProperty, value);
			}
		}
		/// <summary>
		/// Resets SmallChange state
		/// </summary>
		public void ResetSmallChange()
		{
			style.ResetValue(SmallChangeProperty);
		}
		[EditorBrowsableAttribute(EditorBrowsableState.Never)]
		private bool ShouldSerializeSmallChange()
		{
			return style.HasValue(SmallChangeProperty);
		}
		/// <summary>
		/// Gets if SmallChange state has been initialized for the current object.
		/// </summary>
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool HasSmallChange
		{
			get
			{
				return style.HasValue(SmallChangeProperty);
			}
		}		
		/// <summary>
		/// Gets or sets LargeChange state
		/// </summary>
		[
		Description("Provides the LargeChange for this cell"),
		Browsable(true),
		Category("Slider")
		]
		public int LargeChange
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (int) style.GetValue(LargeChangeProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(LargeChangeProperty, value);
			}
		}
		/// <summary>
		/// Resets LargeChange state
		/// </summary>
		public void ResetLargeChange()
		{
			style.ResetValue(LargeChangeProperty);
		}
		[EditorBrowsableAttribute(EditorBrowsableState.Never)]
		private bool ShouldSerializeLargeChange()
		{
			return style.HasValue(LargeChangeProperty);
		}
		/// <summary>
		/// Gets if LargeChange state has been initialized for the current object.
		/// </summary>
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool HasLargeChange
		{
			get
			{
				return style.HasValue(LargeChangeProperty);
			}
		}		
		/// <summary>
		/// Gets or sets Orientation state
		/// </summary>
		[
		Description("Provides the Orientation for this cell"),
		Browsable(true),
		Category("Slider")
		]
		public Orientation Orientation
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (Orientation) style.GetValue(OrientationProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(OrientationProperty, value);
			}
		}
		/// <summary>
		/// Resets Orientation state
		/// </summary>
		public void ResetOrientation()
		{
			style.ResetValue(OrientationProperty);
		}
		[EditorBrowsableAttribute(EditorBrowsableState.Never)]
		private bool ShouldSerializeOrientation()
		{
			return style.HasValue(OrientationProperty);
		}
		/// <summary>
		/// Gets if Orientation state has been initialized for the current object.
		/// </summary>
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool HasOrientation
		{
			get
			{
				return style.HasValue(OrientationProperty);
			}
		}		
		/// <summary>
		/// Gets or sets TickFrequency state
		/// </summary>
		[
		Description("Provides the TickFrequency for this cell"),
		Browsable(true),
		Category("Slider")
		]
		public int TickFrequency
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (int) style.GetValue(TickFrequencyProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(TickFrequencyProperty, value);
			}
		}
		/// <summary>
		/// Resets TickFrequency state
		/// </summary>
		public void ResetTickFrequency()
		{
			style.ResetValue(TickFrequencyProperty);
		}
		[EditorBrowsableAttribute(EditorBrowsableState.Never)]
		private bool ShouldSerializeTickFrequency()
		{
			return style.HasValue(TickFrequencyProperty);
		}
		/// <summary>
		/// Gets if TickFrequency state has been initialized for the current object.
		/// </summary>
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool HasTickFrequency
		{
			get
			{
				return style.HasValue(TickFrequencyProperty);
			}
		}		
		/// <summary>
		/// Gets or sets TickStyle state
		/// </summary>
		[
		Description("Provides the TickStyle for this cell"),
		Browsable(true),
		Category("Slider")
		]
		public TickStyle TickStyle
		{
			get
			{
				//TraceUtil.TraceCurrentMethodInfo();
				return (TickStyle) style.GetValue(TickStyleProperty);
			}
			set
			{
				//TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(TickStyleProperty, value);
			}
		}
		/// <summary>
		/// Resets TickStyle state
		/// </summary>
		public void ResetTickStyle()
		{
			style.ResetValue(TickStyleProperty);
		}
		[EditorBrowsableAttribute(EditorBrowsableState.Never)]
		private bool ShouldSerializeTickStyle()
		{
			return style.HasValue(TickStyleProperty);
		}
		/// <summary>
		/// Gets if TickStyle state has been initialized for the current object.
		/// </summary>
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool HasTickStyle
		{
			get
			{
				return style.HasValue(TickStyleProperty);
			}
		}		
	}
}
