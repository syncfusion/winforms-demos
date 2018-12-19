using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.ComponentModel;

using Syncfusion.Diagnostics;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Styles;


namespace InteractiveCellDemo
{
	# region CustomProperties_with expandable objects

	/// <summary>
	/// Provides custom properties for button edit cell. All properties
	/// support the style inheritance mechanism. You can change these propeties
	/// in the property grid.
	/// </summary>
	/// 

	public class ButtonEditStyleProperties : GridStyleInfoCustomProperties
	{
		// static initialization of property descriptors
		static Type t = typeof(ButtonEditStyleProperties);

		readonly static StyleInfoProperty ButtonEditInfoProperty = CreateStyleInfoProperty(t, "ButtonEditInfo");
		
		// default settings for all properties this object holds
		static ButtonEditStyleProperties defaultObject;

		// initialize default settings for all properties in static ctor
		static ButtonEditStyleProperties ()
		{
			// all properties must be initialized for the Default property
			defaultObject = new ButtonEditStyleProperties(GridStyleInfo.Default);
			defaultObject.ButtonEditInfo = ButtonEditInfo.Default;
		}
			
		/// <summary>
		/// Provides access to default values for this type
		/// </summary>
		public static ButtonEditStyleProperties Default
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

	
		/// <summary>
		/// Explicit cast from GridStyleInfo to this custom propety object
		/// </summary>
		/// <returns>A new custom properties object.</returns>
		public static explicit operator ButtonEditStyleProperties(GridStyleInfo style)
		{
			return new ButtonEditStyleProperties(style);
		}

		/// <summary>
		/// Initializes a ButtonEditStyleProperties object with a style object that holds all data
		/// </summary>
		public ButtonEditStyleProperties(GridStyleInfo style)
			: base(style)
		{
		}

		/// <summary>
		/// Initializes a ButtonEditStyleProperties object with an empty style object. Design
		/// time environment will use this ctor and later copy the values to a style object
		/// by calling style.CustomProperties.Add(gridExcelTipStyleProperties1)
		/// </summary>
		public ButtonEditStyleProperties()
			: base()
		{
		}

		/// <summary>
		/// Specifies whether button should be shown at the left of textbox
		/// </summary>
		///
		[
		Description("Button Edit properties"),
		Browsable(true),
		Category("Custom")
		]
		public ButtonEditInfo ButtonEditInfo
		{
			get
			{
				return (ButtonEditInfo)style.GetValue(ButtonEditInfoProperty);
			}
			set
			{
				style.SetValue(ButtonEditInfoProperty, value);
			}
		}
	}
	/// <summary>
	/// Specifies the image for the ButtonEdit CellType
	/// </summary>
	public enum ButtonType 
	{
		None = 0,
		Browse = 1,
		Check = 2,
		Down = 3,
		Left = 4,
		Leftend = 5,
		Redo = 6,
		Right = 7,
		Rightend = 8,
		Undo = 9,
		Up = 10,
		Image = 11
	}
	#endregion

	/// <summary>
	/// Implements the data store for the <see cref="ButtonEditInfo"/> object.
	/// </summary>
	/// <seealso cref="StyleInfoStore"/>
	[
	Serializable,
	StaticDataField("sd")
	]
	public class ButtonEditInfoStore: StyleInfoStore
	{
		static StaticData sd = new StaticData(typeof(ButtonEditInfoStore), typeof(ButtonEditInfo), true);
		
		/// <summary>
		/// Provides information about the <see cref="ButtonEditInfo.IsLeft"/> property
		/// </summary>
		public readonly static StyleInfoProperty ButtonEditIsLeftProperty = sd.CreateStyleInfoProperty(typeof(bool), "ButtonEditIsLeft");

		/// <summary>
		/// Provides information about the <see cref="ButtonEditInfo.ButtonType"/> property
		/// </summary>
		public readonly static StyleInfoProperty ButtonEditTypeProperty = sd.CreateStyleInfoProperty(typeof(int), "ButtonEditType");

		/// <summary>
		/// Provides information about the <see cref="ButtonEditInfo.Width"/> property
		/// </summary>
		public readonly static StyleInfoProperty ButtonEditWidthProperty = sd.CreateStyleInfoProperty(typeof(int), "ButtonEditWidth");

		/// <summary>
		/// Provides information about the <see cref="ButtonEditInfo.Text"/> property
		/// </summary>
		public readonly static StyleInfoProperty ButtonEditTextProperty = sd.CreateStyleInfoProperty(typeof(string), "ButtonEditText");

		/// <summary>
		/// Provides information about the <see cref="ButtonEditInfo.TextColor"/> property
		/// </summary>
		public readonly static StyleInfoProperty ButtonEditTextColorProperty = sd.CreateStyleInfoProperty(typeof(System.Drawing.Color), "ButtonEditTextColor");

		/// <summary>
		/// Provides information about the <see cref="ButtonEditInfo.BackColor"/> property
		/// </summary>
		public readonly static StyleInfoProperty ButtonEditBackColorProperty = sd.CreateStyleInfoProperty(typeof(System.Drawing.Color), "ButtonEditBackColor");

		/// <summary>
		/// Provides information about the <see cref="ButtonEditInfo.Enabled"/> property
		/// </summary>
		public readonly static StyleInfoProperty ButtonEditEnabledProperty = sd.CreateStyleInfoProperty(typeof(bool), "ButtonEditEnabled");

		/// <summary>
		/// Provides information about the <see cref="ButtonEditInfo.Image"/> property
		/// </summary>
		public readonly static StyleInfoProperty ButtonEditImageProperty = sd.CreateStyleInfoProperty(typeof(Image), "ButtonEditImage");


		/// <summary>
		/// Provides information about the <see cref="ButtonEditInfo.ForceBackColor"></see>
		/// </summary>
		public readonly static StyleInfoProperty ButtonEditForceBackColorProperty = sd.CreateStyleInfoProperty(typeof(bool), "ButtonEditForceBackColor");
		

		/// <summary>
		/// Provides information about the <see cref="ButtonEditInfo.HorizontalAlignment"/> property.
		/// </summary>
		public readonly static StyleInfoProperty ButtonEditTextHorizontalAlignmentProperty = sd.CreateStyleInfoProperty(typeof(GridHorizontalAlignment), "HorizontalAlignment", 3, true);

		/// <summary>
		/// Provides information about the <see cref="ButtonEditInfo.VerticalAlignment"/> property.
		/// </summary>
		public readonly static StyleInfoProperty ButtonEditTextVerticalAlignmentProperty = sd.CreateStyleInfoProperty(typeof(GridVerticalAlignment), "VerticalAlignment", 3, true);


		/// <override/>
		protected override StaticData StaticDataStore
		{
			get { return sd; }
		}

		/// <overload>
		/// Initializes a <see cref="ButtonEditInfoStore"/>
		/// </overload>
		/// <summary>
		/// Initializes an empty <see cref="ButtonEditInfoStore"/>.
		/// </summary>
		public ButtonEditInfoStore()
		{
		}

		/// <summary>
		/// Initializes a new <see cref="ButtonEditInfoStore"/> from a serialization stream.
		/// </summary>
		/// <param name="info">An object that holds all the data needed to serialize or deserialize this instance.</param>
		/// <param name="context">Describes the source and destination of the serialized stream specified by info. </param>
		private ButtonEditInfoStore(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
			
		// Base class implementation of this method calls Activator.CreateInstance to achieve the same result.
		// I assume calling new directly is more efficient. Otherwise this override is obsolete.
		/// <override/>
		public override object Clone()
		{
			StyleInfoStore target = new ButtonEditInfoStore();
			CopyTo(target);
			return target;
		}
	}

	/// <summary>
	/// provides a <see cref="GridStyleInfoSubObject"/> object for button edit properties in a cell.
	/// <para/>Each property in this sub object can be configured individually. Properties that
	/// have not been initialized will inherit default values from a base style.
	/// </summary>
	[TypeConverter(typeof(StyleInfoBaseConverter))]
	public class ButtonEditInfo: GridStyleInfoSubObject
	{
		// Static Fields
		private static ButtonEditInfo defaultButtonEditInfo;

		internal static object CreateObject(StyleInfoSubObjectIdentity identity, object store)
		{
			if (store != null)
				return new ButtonEditInfo(identity, store as ButtonEditInfoStore);
			return new ButtonEditInfo(identity);
		}

		/// <summary>
		/// Releases the all resources used by the Component.
		/// </summary>
		public override void Dispose()
		{
			base.Dispose();
		}

		// Constructors
		/// <overload>
		/// Initializes a <see cref="ButtonEditInfo"/>
		/// </overload>
		/// <summary>
		/// Initializes a <see cref="ButtonEditInfo"/>
		/// </summary>
		[DebuggerStepThrough()] public ButtonEditInfo()
			: base(new ButtonEditInfoStore())
		{
		}

		/// <summary>
		/// Initalizes a new <see cref="ButtonEditInfo"/>  object and associates it with an existing <see cref="GridStyleInfoSubObjectIdentity"/>.
		/// </summary>
		/// <param name="identity">A <see cref="GridStyleInfoSubObjectIdentity"/> that holds the indentity for this <see cref="ButtonEditInfo"/>.
		/// </param>
		[DebuggerStepThrough()] public ButtonEditInfo(StyleInfoSubObjectIdentity identity)
			: base(identity, new ButtonEditInfoStore())
		{
			
		}

		/// <summary>
		/// Initalizes a new <see cref="ButtonEditInfo"/>  object and associates it with an existing <see cref="GridStyleInfoSubObjectIdentity"/>.
		/// </summary>
		/// <param name="identity">A <see cref="GridStyleInfoSubObjectIdentity"/> that holds the indentity for this <see cref="GridFontInfo"/>.
		/// <param name="store">A <see cref="ButtonEditInfoStore"/> that holds data for this <see cref="GridFontInfo"/>.
		/// All changes in this style object will saved in the <see cref="ButtonEditInfoStore"/> object.</param>
		/// </param>
		[DebuggerStepThrough()] public ButtonEditInfo(StyleInfoSubObjectIdentity identity, ButtonEditInfoStore store)
			: base(identity, store)
		{
		}

		/// <summary>
		/// Initalizes a new <see cref="ButtonEditInfo"/>  object and initializes its IsLeft, ButtonEditType, Width, Text, TextColor, Enabled and
		/// BackColor properties
		/// </summary>
		[DebuggerStepThrough()] 
		public ButtonEditInfo(Font font)
			: base(new ButtonEditInfoStore())
		{
			IsLeft = false;
            ButtonEditType = InteractiveCellDemo.ButtonType.Browse;
			Width = 20;
			Text = null;
			TextColor = Color.Black;
			Enabled = true;
			BackColor = Control.DefaultBackColor;	
			Image = null;
			HorizontalAlignment = GridHorizontalAlignment.Center;
			VerticalAlignment = GridVerticalAlignment.Middle;
		}

		// Base class implementation of this method calls Activator.CreateInstance to achieve the same result.
		// I assume calling new directly is more efficient. Otherwise this override is obsolete.

		/// <override/>
		[DebuggerStepThrough()] public override IStyleInfoSubObject MakeCopy(StyleInfoBase newOwner, StyleInfoProperty sip)
		{
			return new ButtonEditInfo(newOwner.CreateSubObjectIdentity(sip), (ButtonEditInfoStore) Store.Clone());
		}

		/// <summary>
		/// Returns a default <see cref="ButtonEditInfo"/> to be used with a default style.
		/// </summary>
		/// <remarks>
		///	<para/>
		///	Default settings are:<para/>
		///	<list type="table">
		///	<listheader><term>Property</term><description>Value</description></listheader>
		///	<item><term><see cref="IsLeft"/></term><description>False</description></item>
		///	<item><term><see cref="ButtonEditType"/></term><description>ButtonEditType.Browse</description></item>
		///	<item><term><see cref="Width"/></term><description>20</description></item>
		///	<item><term><see cref="Text"/></term><description>""</description></item>
		///	<item><term><see cref="TextColor"/></term><description>Color.Black</description></item>
		///	<item><term><see cref="BackColor"/></term><description>Control.DefaultBackColor</description></item>
		///	<item><term><see cref="Enabled"/></term><description>True</description></item>
		///	<item><term><see cref="Image"/></term><description>null</description></item>
		///	</list>
		/// </remarks>
		public static ButtonEditInfo Default
		{
			[DebuggerStepThrough()] 
			get
			{
				if (defaultButtonEditInfo == null)
				{
					defaultButtonEditInfo = new ButtonEditInfo();
					defaultButtonEditInfo.IsLeft = false;
                    defaultButtonEditInfo.ButtonEditType = InteractiveCellDemo.ButtonType.Browse;
					defaultButtonEditInfo.Width = 20;
					defaultButtonEditInfo.Text = null;
					defaultButtonEditInfo.TextColor = Color.Black;
					defaultButtonEditInfo.Enabled = true;
					defaultButtonEditInfo.BackColor = Control.DefaultBackColor;					
					defaultButtonEditInfo.Image = null;

					//If the themes are enabled, setting this forces to draw the button color
					defaultButtonEditInfo.ForceBackColor = false;

					defaultButtonEditInfo.HorizontalAlignment = GridHorizontalAlignment.Center;
					defaultButtonEditInfo.VerticalAlignment = GridVerticalAlignment.Middle;					
				}
				return defaultButtonEditInfo;
			}
		}

		/// <override/>
		protected override void OnStyleChanged(StyleInfoProperty sip)
		{
			base.OnStyleChanged(sip);
		}
			
		/// <override/>
		protected override StyleInfoBase GetDefaultStyle()
		{
			return Default;
		}


		//Properties
		#region IsLeft
		/// <summary>
		/// This Property specifies whether the button should be positioned in the left side of the cell
		/// </summary>
		/// 
		[Description("specifies if the button should be positioned to the left."),
		Browsable(true),
		Category("Custom"),
		NotifyParentProperty(true)
		]
		public bool IsLeft
		{
			get 
			{
				return (bool) GetValue(ButtonEditInfoStore.ButtonEditIsLeftProperty);
			}
			set 
			{
				SetValue(ButtonEditInfoStore.ButtonEditIsLeftProperty, value);
			}
		}
		#endregion

		#region ButtonEditType
		/// <summary>
		/// This property specifies the type of the Image to be drawn in the button
		/// </summary>
		/// 
		[Description("Specifies the type of the Image to be drawn in the button."),
		Browsable(true),
		Category("Custom"),
		NotifyParentProperty(true)
		]
		public ButtonType ButtonEditType
		{
			get
			{
				return (ButtonType)GetValue(ButtonEditInfoStore.ButtonEditTypeProperty);
			}
			set
			{
				SetValue(ButtonEditInfoStore.ButtonEditTypeProperty, value);

				if(ButtonEditType != ButtonType.Image)
					Image = null;
			}
		}
#endregion

		#region Width
		/// <summary>
		///This property specifies the width of the button
		/// </summary>
		[Description("Specifies the width of the button"),
		Browsable(true),
		Category("Custom"),
		NotifyParentProperty(true)
		]
		public int Width
		{
			get
			{
				return (int)GetValue(ButtonEditInfoStore.ButtonEditWidthProperty);
			}
			set
			{
				SetValue(ButtonEditInfoStore.ButtonEditWidthProperty, value);
			}
		}
		#endregion

		#region Text
		/// <summary>
		/// This property specifies the text to be shown in the button
		/// </summary>
		[Description("Specifies the text to be shown in the button"),
		Browsable(true),
		Category("Custom"),
		NotifyParentProperty(true)
		]
		public string Text
		{
			get
			{
				return (string)GetValue(ButtonEditInfoStore.ButtonEditTextProperty);
			}
			set
			{
				SetValue(ButtonEditInfoStore.ButtonEditTextProperty, value);
			}
		}
		#endregion

		#region TextColor
		/// <summary>
		/// This property specifies the text color
		/// </summary>
		[Description("Specifies the text color"),
		Browsable(true),
		Category("Custom"),
		NotifyParentProperty(true)
		]
		public Color TextColor
		{
			get
			{
				return (Color)GetValue(ButtonEditInfoStore.ButtonEditTextColorProperty);
			}
			set
			{
				SetValue(ButtonEditInfoStore.ButtonEditTextColorProperty, value);
			}
		}
		#endregion

		#region Enabled
		/// <summary>
		/// This property specifies if the button should be enabled
		/// </summary>
		[Description("Specifies if the button should be enabled"),
		Browsable(true),
		Category("Custom"),
		NotifyParentProperty(true)
		]
		public bool Enabled
		{
			get
			{
				return (bool)GetValue(ButtonEditInfoStore.ButtonEditEnabledProperty);
			}
			set
			{
				SetValue(ButtonEditInfoStore.ButtonEditEnabledProperty, value);
			}
		}
		#endregion

		#region BackColor
		/// <summary>
		/// This property specifies the BackColor of the button
		/// </summary>
		[Description("Specifies the BackColor of the button"),
		Browsable(true),
		Category("Custom"),
		NotifyParentProperty(true)
		]
		public Color BackColor
		{
			get
			{
				return (Color)GetValue(ButtonEditInfoStore.ButtonEditBackColorProperty);
			}
			set
			{
				SetValue(ButtonEditInfoStore.ButtonEditBackColorProperty, value);
			}
		}
		#endregion

		#region Image
		/// <summary>
		/// This property specifies the Image to be displayed in the button
		/// </summary>
		[Description("Specifies the image to be displayed in the button"),
		Browsable(true),
		Category("Custom"),
		NotifyParentProperty(true)
		]
		public Image Image
		{
			get
			{
				return (Image)GetValue(ButtonEditInfoStore.ButtonEditImageProperty);
			}
			set
			{
				if(this.ButtonEditType == ButtonType.Image)
				{
					SetValue(ButtonEditInfoStore.ButtonEditImageProperty, value);
				}
			}
		}
		#endregion

		#region ForceBackColor
		/// <summary>
		/// This Property specifies whether the button should be colored with the <see cref="ButtonEditInfo.BackColor"></see> 
		/// if themes are enabled
		/// </summary>
		/// 
		[Description("specifies whether the button should be colored neglecting the themes"),
		Browsable(true),
		Category("Custom"),
		NotifyParentProperty(true)
		]
		public bool ForceBackColor
		{
			get 
			{
				return (bool) GetValue(ButtonEditInfoStore.ButtonEditForceBackColorProperty);
			}
			set 
			{
				SetValue(ButtonEditInfoStore.ButtonEditForceBackColorProperty, value);
			}
		}
		#endregion

		#region VerticalAlignment
		[
		Description("Specifies vertical alignment of text in the Button."),
		Browsable(true),
		Category("Custom")
		]
		[NotifyParentProperty(true)]
		public GridVerticalAlignment VerticalAlignment
		{
			get
			{
				return (GridVerticalAlignment) GetShortValue(ButtonEditInfoStore.ButtonEditTextVerticalAlignmentProperty);
			}
			set
			{
				SetValue(ButtonEditInfoStore.ButtonEditTextVerticalAlignmentProperty, (short) value);
			}
		}
		#endregion

		#region HorizontalAlignment
		[
		Description("Specifies horizontal alignment of text in the Button."),
		Browsable(true),
		Category("Custom")
		]
		[NotifyParentProperty(true)]
		public GridHorizontalAlignment HorizontalAlignment
		{
			get
			{
				return (GridHorizontalAlignment) GetShortValue(ButtonEditInfoStore.ButtonEditTextHorizontalAlignmentProperty);
			}
			set
			{
				SetValue(ButtonEditInfoStore.ButtonEditTextHorizontalAlignmentProperty, (short) value);
			}
		}
		#endregion
	}
}