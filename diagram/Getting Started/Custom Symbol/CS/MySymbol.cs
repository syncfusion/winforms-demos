#region Copyright Syncfusion Inc. 2001 - 2012
//
//  Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.Serialization;

namespace Syncfusion.Windows.Forms.Diagram.Samples
{
	/// <summary>
	/// Specifically symbol class for CustomSymbol sample.
	/// </summary>
	[Serializable()]
	[TypeConverter(typeof(MySymbolConverter))]
	public class MySymbol : Group
	{
		#region Class members
		private int clickCount;
		#endregion

        #region Class Initialize/Finalize methods
        /// <summary>
        /// Default constructor.
        /// </summary>
        public MySymbol()
        {
			//////////////////////////////////////////////////////////////////
			// Add child nodes to the symbol programmatically
			//////////////////////////////////////////////////////////////////

            // Add an outer rectangle
            Rectangle outerRect = new Rectangle(100, 100, 96, 72);
            outerRect.Name = "Rectangle";
            outerRect.FillStyle.Type = FillStyleType.LinearGradient;
            outerRect.FillStyle.ForeColor = Color.GhostWhite;
            outerRect.FillStyle.Color = Color.LightSkyBlue ;
            outerRect.EditStyle.AllowSelect = false;
            this.AppendChild(outerRect);
			// Add a polygon
			PointF[] pts=
				{
					 new Point(6, 36),
                    new Point(48, 6),
                    new Point(90, 36),
                    new Point(48, 66)
					
				};

            Polygon polygon = new Polygon(pts);
            polygon.Name = "Polygon";
            polygon.FillStyle.Type = FillStyleType.LinearGradient;
            polygon.FillStyle.ForeColor = Color.DarkSeaGreen;
            polygon.FillStyle.Color = Color.White ;
            polygon.EditStyle.AllowSelect = false;
            this.AppendChild(polygon);
			
                  
        }

        /// <summary>
        /// Copy constructor.
        /// </summary>
        /// <param name="src"></param>
        public MySymbol(MySymbol src)
			: base(src)
        {}

        /// <summary>
        /// Serialization constructor for the MySymbol class.
        /// </summary>
        /// <param name="info">Serialization state information</param>
        /// <param name="context">Streaming context information</param>
        protected MySymbol(SerializationInfo info, StreamingContext context)
			: base(info, context)
        {
            // The Serialization constructor is invoked during deserialization or during a drag & drop operation.
            // If the MySymbol type has serializable members, then initialize them with the serialized data 
            // obtained from the SerializationInfo param
        }
        #endregion

		#region Class properties
		/// <summary>
		/// Get mouse click count.
		/// </summary>
		public int ClickCount
		{
			get { return clickCount; }
		}
		#endregion

        #region Class overrides
		/// <summary>
        /// Increase mouse click count.
        /// </summary>
        /// <param name="evtArgs"></param>
		[EventHandlerPriority(true)]
        protected override void OnMouseClick(EventArgs e)
        {
			clickCount = clickCount + 1;
        }
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>Copy of the object this method is invoked against</returns>
        public override object Clone()
        {
            return new MySymbol(this);
        }
        #endregion
    }

	/// <summary>
	/// Serialize helper class for MySymbol.
	/// </summary>
	public class MySymbolConverter : TypeConverter
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="context"></param>
		/// <param name="culture"></param>
		/// <param name="value"></param>
		/// <param name="destinationType"></param>
		/// <returns></returns>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) 
		{
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="context"></param>
		/// <param name="value"></param>
		/// <param name="attributes"></param>
		/// <returns></returns>
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			Attribute[] attrs = new Attribute[]
			{
				new BrowsableAttribute(true)
			};

			// This code returns only the specified properties. It can be used to filter out
			// properties that you do not wish to expose to in property grid.
			PropertyDescriptor[] props = new PropertyDescriptor[2];
			props[0] = TypeDescriptor.CreateProperty(typeof(MySymbol), "Name", typeof(string), attrs);
			props[1] = TypeDescriptor.CreateProperty(typeof(MySymbol), "ClickCount", typeof(int), attrs);
			return new PropertyDescriptorCollection(props);
		}
	}
}
