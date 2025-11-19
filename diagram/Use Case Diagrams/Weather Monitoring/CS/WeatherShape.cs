#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Drawing;

namespace Syncfusion.Windows.Forms.Diagram.Samples
{
    /// <summary>
    /// Renders a weather node
    /// </summary>
    [Serializable]
    public class WeatherNode : Group
    {
        #region Members
        private WeatherCondition m_weatherCondition;
        private decimal m_fTemperature;
        private string m_strState;
        private BitmapNode m_imageNode;
        #endregion

        #region Initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherNode"/> class.
        /// </summary>        
        public WeatherNode()
            : base()
        {
            m_imageNode = new BitmapNode(new Bitmap(Image.FromFile(@"..\..\..\..\..\..\Common\Images\Diagram\Weather Monitoring\Sunny.png")));
            m_imageNode.Size = new SizeF(32, 32);
            m_imageNode.LineStyle.LineWidth = 0;
            this.EditStyle.AllowSelect = false;
            this.AppendChild(m_imageNode);
            Label lbl = new Label();
            lbl.FontStyle.Family = "Arial";
            lbl.Position = Position.TopCenter;
            lbl.FontColorStyle.Color = Color.White;
            this.Labels.Add(lbl);
            lbl = new Label();
            lbl.FontStyle.Family = "Arial";
            lbl.Position = Position.MiddleRight;
            lbl.FontColorStyle.Color = Color.White;
            this.Labels.Add(lbl);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherNode"/> class.
        /// </summary>
        /// <param name="src">Object to copy.</param>
        public WeatherNode(WeatherNode src)
            : base(src)
        {
            m_weatherCondition = src.m_weatherCondition;
            m_strState = src.m_strState;
            m_fTemperature = src.m_fTemperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherNode"/> class.
        /// </summary>
        /// <param name="info">Serialization state information.</param>
        /// <param name="context">Streaming context information.</param>
        public WeatherNode(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            foreach (SerializationEntry entry in info)
            {
                switch (entry.Name)
                {
                    case "state":
                        m_strState = entry.Value.ToString();
                        break;
                    case "temperature":
                        m_fTemperature = (decimal)entry.Value;
                        break;
                    case "weatherCondition":
                        m_weatherCondition = (WeatherCondition)entry.Value;
                        break;
                }
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the weather condition.
        /// </summary>        
        public WeatherCondition WeatherCondition
        {
            get
            {
                return m_weatherCondition;
            }
            set
            {
                if (value != m_weatherCondition)
                {
                    m_weatherCondition = value;
                    if (value == WeatherCondition.Rain)
                        m_imageNode.Image = (Bitmap)Image.FromFile(@"..\..\..\..\..\..\Common\Images\Diagram\Weather Monitoring\Rain.png");
                    else if (value == WeatherCondition.ThunderStorm)
                        m_imageNode.Image = (Bitmap)Image.FromFile(@"..\..\..\..\..\..\Common\Images\Diagram\Weather Monitoring\Thunder.png");
                    else if (value == WeatherCondition.Snow)
                        m_imageNode.Image = (Bitmap)Image.FromFile(@"..\..\..\..\..\..\Common\Images\Diagram\Weather Monitoring\Snow.png");
                    else if (value == WeatherCondition.None)
                        m_imageNode.Image = (Bitmap)Image.FromFile(@"..\..\..\..\..\..\Common\Images\Diagram\Weather Monitoring\Sunny.png");
                    OnPropertyChanged(this.FullContainerName, "WeatherCondition");
                }
            }
        }

        /// <summary>
        /// Gets or sets the temperature.
        /// </summary>
        public decimal Temperature
        {
            get
            {
                return m_fTemperature;
            }
            set
            {
                if (value != m_fTemperature)
                {
                    m_fTemperature = value;
                    this.Labels[0].Text = value + " F";
                    OnPropertyChanged(this.FullContainerName, "Temperature");
                }
            }
        }

        /// <summary>
        /// Gets or sets state name.
        /// </summary>
        public string State
        {
            get
            {
                return m_strState;
            }
            set
            {
                if (value != m_strState)
                {
                    m_strState = value;
                    this.Labels[1].Text = value + "";
                    OnPropertyChanged(this.FullContainerName, "State");
                }
            }
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>Copy of the object this method is invoked against.</returns>
        public override object Clone()
        {
            return new WeatherNode(this);
        }

        /// <summary>
        /// Populates a SerializationInfo with the data needed to
        /// serialize the target object.
        /// </summary>
        /// <param name="info">SerializationInfo object to populate.</param>
        /// <param name="context">Destination streaming context.</param>
        protected override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("state", m_strState);
            info.AddValue("temperature", m_fTemperature);
            info.AddValue("weatherCondition", m_weatherCondition);
        }
        #endregion

        #region Helper methods
        #endregion
    }

    /// <summary>
    /// Specifies the weather condition
    /// </summary>
    public enum WeatherCondition
    {
        None,
        Rain,
        Snow,
        ThunderStorm
    }

    /// <summary>
    /// State class which holds its name, latitude and longitude
    /// </summary>
    public class State
    {
        private decimal dLatitude;
        private decimal dLongitude;
        private string strName;
        public decimal Latitude
        {
            get
            {
                return dLatitude;
            }           
        }

        public decimal Longitude 
        {
            get
            {
                return dLongitude;
            }           
        }

        public string Name
        {
            get
            {
                return strName;
            }           
        }

        public State(string name, decimal latitude, decimal longtitude)
        {
            dLatitude = latitude;
            dLongitude = longtitude;
            strName = name;
        }
    }
}
