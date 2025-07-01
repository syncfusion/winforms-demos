#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace I58680b
{
    public class StatusConverter:EnumConverter
    {
        public StatusConverter(Type propertyType)
            : base(propertyType)
        {
            
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))               
            {
                return true;
            }


            return base.CanConvertFrom(context, sourceType);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                return true;
            }

            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {

            if (value is string)
            {
                return ConvertFromString(context, culture, value);
            }

            return base.ConvertFrom(context, culture, value);
        }

        private object ConvertFromString(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            switch ((string)value)
            {
                case "geschieden":
                    return Status.Divorced;
                case "verheiratet":
                    return Status.Married;
                case "Ledig":
                    return Status.Single;
                case "Verwitwet":
                    return Status.Widow;
                default:
                    return null;
            }
        }
        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {

            if (destinationType == typeof(string))
            {
                return ConverToString(context,culture, value);
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }

        public object ConverToString(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            switch ((Status)value)
            {
                case Status.Divorced:
                    return "geschieden";
                case Status.Married:
                    return "verheiratet";
                case Status.Single:
                    return "Ledig";
                case Status.Widow:
                    return "Verwitwet";
                default:
                    return string.Empty;
            }
        }


        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            if (context != null &&
                context.Instance != null && 
                context.Instance is Employee)
            {
                var employeeContext = ((Employee)context.Instance).Context;
                return new StandardValuesCollection(GetContextualCollection(employeeContext)); 
            }
            return base.GetStandardValues(context);
        }

        private System.Collections.ICollection GetContextualCollection(Context employeeContext)
        {
            switch (employeeContext)
            {
                case Context.Employed:
                    return new Collection<Status>{ Status.Married, Status.Single, Status.Widow };
                case Context.OnVacation:
                    return new Collection<Status>{ Status.Married };
                case Context.Retired:
                    return new Collection<Status>{ Status.Single, Status.Divorced };
                case Context.Sick:
                    return new Collection<Status>{ Status.Widow};
                default:
                    return new Collection<Status>{ Status.Married, Status.Single, Status.Widow, Status.Divorced };
            }
        }

    }
}
