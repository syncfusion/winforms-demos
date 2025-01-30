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
using System.ComponentModel;
using System.Diagnostics;

namespace RecursiveNestedCollection
{
    #region PropertyDescriptor for BaseClass
    class BaseClassDescriptor : CustomTypeDescriptor
    {
        private BaseClass instance;

        public BaseClassDescriptor(BaseClass instance)
            : base()
        {
            this.instance = instance;
            if (this.instance == null)
            {
                throw new ArgumentException("instance null!!!");
            }
        }

        public override PropertyDescriptorCollection GetProperties()
        {
            return GetProperties(null);
        }

        public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            List<PropertyDescriptor> retProperties = new List<PropertyDescriptor>();

            // Data
            foreach (KeyValuePair<string, MyData> attr in instance.Data)
            {
                retProperties.Add(new BaseClassMyDataPropertyDescriptor(attr.Key));
            }

            // Children
            foreach (KeyValuePair<string, List<BaseClass>> child in instance.ChildTables)
            {
                retProperties.Add(new BaseClassChildrenPropertyDescriptor(child.Key));
            }

            return new PropertyDescriptorCollection(retProperties.ToArray());
        }
    }

    class BaseClassDescriptorProvider : TypeDescriptionProvider
    {
        public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
        {
            Debug.Print("BaseClassDescriptorProvider.GetExtendedTypeDescriptor( {0} )", ((BaseClass)instance).fieldStr);
            return new BaseClassDescriptor(instance as BaseClass);
        }
    }
    #endregion

    #region PropertyDescriptor for ChildTables
    class BaseClassChildrenPropertyDescriptor : PropertyDescriptor
    {
        public BaseClassChildrenPropertyDescriptor(string name)
            : base(name, new Attribute[0])
        {
        }

        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override Type ComponentType
        {
            get { return typeof(BaseClass); }
        }

        public override bool IsReadOnly
        {
            get { return false; }
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }

        public override void ResetValue(object component)
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }

        public override Type PropertyType
        {
            get { return typeof(List<BaseClass>); }
        }

        public override object GetValue(object component)
        {
            List<BaseClass> retVal;

            if (((BaseClass)component).ChildTables.ContainsKey(Name))
            {
                retVal = ((BaseClass)component).ChildTables[Name];
            }
            else
            {
                retVal = new List<BaseClass>();
            }


            return retVal;
        }

        public override void SetValue(object component, object value)
        {
            ((BaseClass)component).Data[Name] = (MyData)value;
        }
    }

    #endregion

    #region PropertyDescriptor for Data
    class BaseClassMyDataPropertyDescriptor : PropertyDescriptor
    {
        public BaseClassMyDataPropertyDescriptor(string name)
            : base(name, new Attribute[0])
        {
        }

        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override Type ComponentType
        {
            get { return typeof(BaseClass); }
        }

        public override bool IsReadOnly
        {
            get { return false; }
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }

        public override void ResetValue(object component)
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }

        public override Type PropertyType
        {
            get { return typeof(string); }
        }

        public override object GetValue(object component)
        {
            return ((BaseClass)component).Data[Name].Value;
        }


        public override void SetValue(object component, object value)
        {
            if (value is string)
                ((BaseClass)component).Data[Name].Value = value.ToString();
            else
                ((BaseClass)component).ChildTables[Name] = value as List<BaseClass>;
        }
    }

    #endregion
}
