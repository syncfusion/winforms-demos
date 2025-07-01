#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.ComponentModel;
using System.Collections;
using System.Xml.Linq;
using System.Reflection;

namespace DynamicObjectBinding_Demo
{
    public class DynamicObjectWrapper : DynamicObject
    {
        XElement node;
        public DynamicObjectWrapper(XElement node)
        {
            this.node = node;
        }
    
        public DynamicObjectWrapper()
        {
        }

        public DynamicObjectWrapper(String name)
        {
            node = new XElement(name);
        }
    
        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            XElement setNode;
            if (node == null)
                node = new XElement(binder.Name);
            setNode = node.Element(binder.Name);

            if (setNode != null)
                setNode.SetValue(value);
            else
            {
                if (value.GetType() == typeof(DynamicObjectWrapper))
                    node.Add(new XElement(binder.Name));
                else
                    node.Add(new XElement(binder.Name, value));
            }
            return true;
        }
    
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            XElement getNode = node.Element(binder.Name);
            if (getNode != null)
            {
                result = new DynamicObjectWrapper(getNode);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        public override bool TryConvert(ConvertBinder binder, out object result)
        {
            if (binder.Type == typeof(String))
            {
                result = node.Value;
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            Type xmlType = typeof(XElement);
            try
            {
                result = xmlType.InvokeMember(
                          binder.Name,
                          BindingFlags.InvokeMethod |
                          BindingFlags.Public |
                          BindingFlags.Instance,
                          null, node, args);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }
    }
}