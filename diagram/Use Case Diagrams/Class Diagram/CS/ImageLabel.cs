using System;
using System.Collections.Generic;

using System.Web;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing;
using System.Runtime.Serialization;

/// <summary>
/// Summary description for ImageLabel
/// </summary>
[Serializable]
public class ImageLabel :Label
{
    #region Class Properties
    private System.Drawing.Image textImage = null;
    public System.Drawing.Image TextImage 
    {
        get { return textImage; }
        set
        {
            textImage = value;
            OnPropertyChanged("image");
        } 
    }

    private float imageOffsetX = 0;
    public float ImageOffsetX
    {
        get { return imageOffsetX; }
        set { imageOffsetX = value; }
    }

    private float imageOffsetY = 0;
    public float ImageOffsetY
    {
        get { return imageOffsetY; }
        set { imageOffsetY = value; }
    }

    private bool drawImage = false;
    public bool DrawImage 
    {
        get { return drawImage; }
        set { drawImage = value; }
    }
    #endregion

    #region Class Initialize Methods
    /// <summary>
    /// Create a new instance of ImageLabel
    /// </summary>
    /// <param name="Container">Container of the label</param>
    /// <param name="LabelText">Text of the Label</param>
    public ImageLabel(Node Container, string LabelText)
    {
        this.Text = LabelText;
        this.Container = Container;
    }

    /// <summary>
    /// Copy constructor.
    /// </summary>
    /// <param name="src">ImageLabel source</param>
    public ImageLabel(ImageLabel src)
        : base(src)
    {
        textImage = src.textImage;
    }

    /// <summary>
    /// Serialization constructor for the ImageLabel class.
    /// </summary>
    /// <param name="info">Serialization state information</param>
    /// <param name="context">Streaming context information</param>
    protected ImageLabel(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
        textImage = (Image)info.GetValue("image", typeof(Image));
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

        info.AddValue("image", textImage);
    }
    #endregion

    #region Class Override Methods
    protected override void Render(System.Drawing.Graphics gfx)
    {
        base.Render(gfx);
        System.Drawing.Drawing2D.GraphicsState graph = gfx.Save();
        if (TextImage != null && DrawImage)
        {
            gfx.DrawImage(TextImage, ImageOffsetX, ImageOffsetY, 17.5f, 17.5f);
            gfx.Restore(graph);
        }
    }
    #endregion
}