#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

using System.Web;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing;
using System.Runtime.Serialization;

/// <summary>
/// Summary description for ClassSymbol
/// </summary>
[Serializable]
public class CustomGroup :Group
{

    #region Class Initialize Methods
	private ClassList _lstClass;
    /// <summary>
    /// Create a new instance of CustomGroup
    /// </summary>
    /// <param name="classList">ClassList</param>
    public CustomGroup(ClassList classList)
    {

        _lstClass = classList;
        float Height = 60 ,PinPointY=0;
        //if (string.IsNullOrEmpty(classList.ObjectType))
        //    Height = 55;
        CustomRectangle customRect = new CustomRectangle(0,0, 220, Height);
        customRect.ClassName = classList.ClassName;
        customRect.ClassType = classList.ClassType;
        customRect.ObjectType = classList.ObjectType;
        customRect.TitleImage = Image.FromFile(@"..\..\..\..\..\..\Common\Images\Diagram\class diagram\5.png");
        customRect.FillStyle.Color = Color.Transparent;
        customRect.LineStyle.LineColor = Color.Transparent;
        this.AppendChild(customRect);

        PinPointY = customRect.PinPoint.Y + (customRect.Size.Height - customRect.PinPoint.Y);
        if (classList.PropertyList.Count > 0)
        {
            RowRectangle rect = new RowRectangle(0, PinPointY, 220, 25);
            rect.FillStyle.Color = Color.FromArgb(248, 249, 252);
            rect.LineStyle.LineColor = Color.Transparent;
            rect.Labels[0].OffsetX = 25;
            rect.RowText = "Properties";
            this.AppendChild(rect);
            PinPointY = rect.PinPoint.Y + 12.5f;
            for (int i = 0; i < classList.PropertyList.Count; i++)
            {
                RowRectangle rect1 = new RowRectangle(0, PinPointY, 220, 25);
                if (classList.PropertyList[i].PropertyType == PropertyType.Internal)
                    rect1.RowImage = Image.FromFile(@"..\..\..\..\..\..\Common\Images\Diagram\class diagram\6.png");
                else
                    rect1.RowImage = Image.FromFile(@"..\..\..\..\..\..\Common\Images\Diagram\class diagram\7.png");
                rect1.RowText = classList.PropertyList[i].PropertyName;
                rect1.FillStyle.Color = Color.White;
                rect1.LineStyle.LineColor = Color.Transparent;
                this.AppendChild(rect1);
                PinPointY += rect1.PinPoint.Y + (rect1.Size.Height - rect1.PinPoint.Y);
            }
        }
        
        if (classList.MethodList.Count > 0)
        {
            RowRectangle rect = new RowRectangle(0, PinPointY, 220, 25);
            rect.FillStyle.Color = Color.FromArgb(248, 249, 252);
            rect.LineStyle.LineColor = Color.Transparent;
            rect.RowText = "Methods";
            rect.Labels[0].OffsetX = 25;
            this.AppendChild(rect);
            PinPointY = rect.PinPoint.Y + 12.5f;
            for (int i = 0; i < classList.MethodList.Count; i++)
            {
                RowRectangle rect1 = new RowRectangle(0, PinPointY, 220, 25);
                if (classList.MethodList[i].MethodType == MethodType.Internal)
                    rect1.RowImage = Image.FromFile(@"..\..\..\..\..\..\Common\Images\Diagram\class diagram\1.png");
                else if (classList.MethodList[i].MethodType == MethodType.Protected)
                    rect1.RowImage = Image.FromFile(@"..\..\..\..\..\..\Common\Images\Diagram\class diagram\2.png");
                else if (classList.MethodList[i].MethodType == MethodType.Public)
                    rect1.RowImage = Image.FromFile(@"..\..\..\..\..\..\Common\Images\Diagram\class diagram\3.png");
                rect1.RowText = classList.MethodList[i].MethodName;
                rect1.FillStyle.Color = Color.White;
                rect1.LineStyle.LineColor = Color.Transparent;
                this.AppendChild(rect1);
                PinPointY += 25;
            }

        }

        RoundRect roundRect = new RoundRect(this.Nodes[0].PinPoint.X-110, this.Nodes[0].PinPoint.Y-30, this.Size.Width, this.Size.Height+10, MeasureUnits.Pixel);
        roundRect.FillStyle.Color = Color.White;
        roundRect.FillStyle.ForeColor = Color.FromArgb(236, 238, 247);
        roundRect.FillStyle.ForeColor = Color.FromArgb(222, 226, 241);
        roundRect.FillStyle.Type = FillStyleType.LinearGradient;
        roundRect.FillStyle.GradientAngle = 90;
        roundRect.FillStyle.GradientCenter = 1;
        roundRect.LineStyle.LineColor = Color.FromArgb(199, 205, 231);
        this.AppendChild(roundRect);
        this.SendToBack(roundRect);
    }

    /// <summary>
    /// Copy constructor.
    /// </summary>
    /// <param name="src">CustomGroup source</param>
    public CustomGroup(CustomGroup src)
        : base(src)
    {

    }

    /// <summary>
    /// Serialization constructor for the ImageLabel class.
    /// </summary>
    /// <param name="info">Serialization state information</param>
    /// <param name="context">Streaming context information</param>
    protected CustomGroup(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }

    /// <summary>
    /// Creates a new object that is a copy of the current instance.
    /// </summary>
    /// <returns>Copy of the object this method is invoked against</returns>
    public override object Clone()
    {
        return new CustomGroup(this);
    }

    #endregion

}