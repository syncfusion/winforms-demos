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
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.Controls;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;
using Syncfusion.Documentation;
using Syncfusion.Runtime.InteropServices.WinAPI;


using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;

namespace Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool
{
    class MyDiagram : Syncfusion.Windows.Forms.Diagram.Controls.Diagram
    {

        public override Syncfusion.Windows.Forms.Diagram.View CreateView()
        {
            return new MyView();
        }
    }
    [Serializable()]
    public class MyView : Syncfusion.Windows.Forms.Diagram.View, ISerializable, IDeserializationCallback, IPropertyContainer
    {
        #region Fields
        ///// <summary>
        ///// Horizontal resolution of the device.
        /// </summary>
        private float dpiX;
        /// <summary>
        /// Vertical resolution of the device.
        /// </summary>
        private float dpiY;      
        /// <summary>
        /// Object that renders grid.
        /// </summary>
        private LayoutGrid m_grid;
       
        /// Magnification value.
        /// </summary>
        private float m_fMagnification;
        /// <summary>
        ///  Page border style.
        /// </summary>
        private PageBorderStyle m_stylePageBorder;
        /// <summary>
        /// Color to clear the background with.
        /// </summary>
        private Color backgroundColor;
      
        #endregion

        public MyView()
        {

        }

        /// <summary>
        /// Serialization constructor for views.
        /// </summary>
        /// <param name="info">Serialization state information.</param>
        /// <param name="context">Streaming context information.</param>
        protected MyView(SerializationInfo info, StreamingContext context)
        {
            this.dpiX = 96;
            this.dpiY = 96;
            m_ptOrigin = (PointF)info.GetValue("origin", typeof(PointF));
            m_fMagnification = info.GetSingle("magnification");
            m_stylePageBorder = (PageBorderStyle)info.GetValue("pageborderstyle", typeof(PageBorderStyle));
            m_grid = (LayoutGrid)info.GetValue("m_grid", typeof(LayoutGrid));

            try
            {
                backgroundColor = (Color)info.GetValue("backcolor", typeof(Color));
            }
            catch (SerializationException)
            {
                ResetBackgroundColor();
                m_grid.Visible = false;
            }

            if (m_grid != null)
            {
                m_grid.ContainerView = this;
                m_grid.UpdateServiceReferences(this);
            }
        }
         private void ResetBackgroundColor()
        {
            this.backgroundColor = Color.DarkGray;
        }

        #region Serialization
        /// <summary>
        /// Populates a SerializationInfo with the data needed to
        /// serialize the target object.
        /// </summary>
        /// <param name="info">SerializationInfo object to populate.</param>
        /// <param name="context">Destination streaming context.</param>
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            this.GetObjectData(info, context);
        }

        /// <summary>
        /// Called when deserialization is complete.
        /// </summary>
        /// <param name="sender">Object performing the deserialization.</param>
        void IDeserializationCallback.OnDeserialization(object sender)
        {
            this.OnDeserialization(sender);
        }

        /// <summary>
        /// Populates a SerializationInfo with the data needed to
        /// serialize the target object.
        /// </summary>
        /// <param name="info">SerializationInfo object to populate.</param>
        /// <param name="context">Destination streaming context.</param>
        protected override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("origin", m_ptOrigin);
            info.AddValue("magnification", m_fMagnification);
            info.AddValue("pageborderstyle", m_stylePageBorder);
            info.AddValue("m_grid", this.Grid);
            info.AddValue("backcolor", backgroundColor);
        }

        /// <summary>
        /// Called when deserialization is complete.
        /// </summary>
        /// <param name="sender">Object performing the deserialization.</param>
        protected virtual void OnDeserialization(object sender)
        { }

        #endregion

        # region DrawHandles

        protected override void DrawHandles(System.Drawing.Graphics grfx, NodeCollection nodesSelected)
        {
            // Draw handles around nodes in selection list.
            if (nodesSelected != null && nodesSelected.Count > 0)
            {
                foreach (Node nodeCur in nodesSelected)
                {
                    if (nodeCur.Visible)
                    {
                        HandleEditMode resultHandleEditMode = nodeCur.EditStyle.DefaultHandleEditMode;

                        // get cur node parent's transformations 
                        Matrix matrixParentsTransorm = GetParentsTransform(nodeCur);
                        // save graphics state
                        GraphicsState stateSave = grfx.Save();
                        // append parents transforms on given graphics
                        grfx.MultiplyTransform(matrixParentsTransorm);

                        switch (resultHandleEditMode)
                        {
                            case HandleEditMode.Resize:
                                if (nodeCur is IEndPointContainer)
                                {
                                    HandleRenderer.DrawEndPoints(grfx, nodeCur);
                                    MyHandleRenderer.MyOutlineBoundingRectangle(grfx, nodeCur);
                                }
                                else
                                {
                                    // This method is used to Draw a custom Bounding outline 
                                    MyHandleRenderer.MyOutlineBoundingRectangle(grfx, nodeCur);
                                    HandleRenderer.DrawRotationHandles(grfx, nodeCur);
                                    //This method is used to customize the selection point colors.
                                    MyHandleRenderer.DrawMySelectionHandles(grfx, nodeCur);
                                }
                                break;
                            case HandleEditMode.Vertex:
                                PathNode pathNode = nodeCur as PathNode;
                                if (nodeCur is IEndPointContainer)
                                {
                                    HandleRenderer.DrawEndPoints(grfx, nodeCur);
                                    MyHandleRenderer.MyOutlineBoundingRectangle(grfx, nodeCur);

                                    if (pathNode.CanDrawControlPoints())
                                    {
                                        pathNode.DrawControlPoints(grfx);
                                    }
                                }
                                else if (pathNode != null && (pathNode.CanChangePath || pathNode.IsVertexEditable))
                                {
                                    MyHandleRenderer.MyOutlineBoundingRectangle(grfx, pathNode);

                                    // Draw control points if can.
                                    if (pathNode.CanDrawControlPoints())
                                    {
                                        pathNode.DrawControlPoints(grfx);
                                    }
                                    else
                                    {
                                        HandleRenderer.DrawVertexHandles(grfx, pathNode);
                                    }
                                }
                                break;
                        }

                        // restore graphics state
                        grfx.Restore(stateSave);
                    }
                }
            }
        }

        private Matrix GetParentsTransform(Node node)
        {
            // return unitary matrix
            if (node is PseudoGroup) return new Matrix();

            if (node == null || node.Parent == null)
                throw new ArgumentNullException("node + parent");

            Matrix matrixToReturn = new Matrix();
            Matrix matrixTemp;
            ICompositeNode nodeParent = node.Parent;

            // iterate through given node parents multiplying their transformations
            while (!(nodeParent is Model))
            {
                matrixTemp = ((Node)nodeParent).GetTransformations();
                ((Node)nodeParent).AppendFlipTransforms(matrixTemp);
                matrixToReturn.Multiply(matrixTemp, MatrixOrder.Append);

                nodeParent = ((Node)nodeParent).Parent;
            }

            return matrixToReturn;
        }
        # endregion
    }

    public class MyHandleRenderer : HandleRenderer
    {
        private static SolidBrush m_sbrushHandle = new SolidBrush(Color.GreenYellow);
        private static Pen m_spenHandleOutline = new Pen(Color.Black, 0f);

        # region Custom Handles

        public static void MyOutlineBoundingRectangle(Graphics gfx, Node node)
        {
            // 1 - Save Graphics state
            GraphicsState save = gfx.Save();
            gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;
            gfx.SmoothingMode = SmoothingMode.AntiAlias;

            // 2 - append parent's transformations on given graphics - WITHOUT ROTATIONS
            Matrix matrixTemp = node.GetTransformations();
            // append flip transforms
            node.AppendFlipTransforms(matrixTemp);
            // apply transform matrix
            gfx.MultiplyTransform(matrixTemp);

            // 4 - Outline shape's bounding rectangle
            SizeF szUnitIndependent = ((IUnitIndependent)node).GetSize(MeasureUnits.Pixel);

            // static pen is not used here as OutOfMemoryExceptions might occur some times
            using (Pen pen = new Pen(Color.Gray, 1f / gfx.PageScale))
            {
                pen.DashStyle = DashStyle.Solid;
                gfx.DrawRectangle(pen, 0, 0, szUnitIndependent.Width, szUnitIndependent.Height);
            }

            // 5 - Restore graphics state
            gfx.Restore(save);
        }

        public static void DrawMySelectionHandles(Graphics gfx, Node node)
        {
            // Save Graphics state
            GraphicsState save = gfx.Save();
            gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;
            gfx.SmoothingMode = SmoothingMode.AntiAlias;

            // apply node transformations to graphics
            Matrix matrixTemp = CreateParentMatrix(node);
            gfx.MultiplyTransform(matrixTemp);

            // get node local transformations
            Matrix matrixLocalTransform = node.GetLocalTransformations();
            node.AppendLocalFlipTransforms(matrixLocalTransform);

            // reset matrix
            matrixTemp.Reset();
            // append node local transformations               
            matrixTemp.Multiply(matrixLocalTransform);

            DrawMyResizeHandles(gfx, node, matrixTemp);

            // Restore graphics state
            gfx.Restore(save);
        }
        private static Matrix CreateParentMatrix(Node node)
        {
            // get node's dimensions in unit independent values
            PointF ptUnitIndependentPinPoint = ((IUnitIndependent)node).GetPinPoint(MeasureUnits.Pixel);
            SizeF szUnitIndependentPinOffset = ((IUnitIndependent)node).GetPinPointOffset(MeasureUnits.Pixel);
            SizeF sztransf = new SizeF(ptUnitIndependentPinPoint.X - szUnitIndependentPinOffset.Width,
                ptUnitIndependentPinPoint.Y - szUnitIndependentPinOffset.Height);

            // Create matrix.
            Matrix matrixTemp = new Matrix();

            // Translate to pinPoint.
            matrixTemp.Translate(sztransf.Width, sztransf.Height);

            return matrixTemp;
        }
        private static void DrawMyResizeHandles(Graphics gfx, Node node, Matrix matrixTransform)
        {
            // Handles are immutable to scale
            float fPageScale = gfx.PageScale;
            float fHandleSize = CommonUsedValues.RESIZE_HANDLE_SIZE / fPageScale;

            // Draw handles
            Array handles = Enum.GetValues(typeof(BoxPosition));
            RectangleF rectHandle;
            // PointF array for transforming.
            PointF[] pts = new PointF[1];
            Matrix matrixParentRotate;
            float fParentsRotation = HandlesHitTesting.GetParentsRotation(node);


            foreach (BoxPosition handle in handles)
            {
                if (handle != BoxPosition.Center)
                {
                    // Get handle position
                    pts[0] = GetHandlePosition(handle, node);

                    // Transform points
                    matrixTransform.TransformPoints(pts);

                    // Create handle's bounding rectangle.
                    rectHandle = Geometry.CreateRect(pts[0], new SizeF(fHandleSize + 1, fHandleSize + 1));

                    matrixParentRotate = new Matrix();
                    matrixParentRotate.RotateAt(-fParentsRotation, pts[0]);

                    GraphicsState stateSave = gfx.Save();
                    gfx.MultiplyTransform(matrixParentRotate, MatrixOrder.Prepend);

                    DrawResizeHandle(gfx, handle, node, rectHandle);

                    gfx.Restore(stateSave);
                }
            }
        }
        private static void DrawResizeHandle(Graphics gfx, BoxPosition handle, Node node, RectangleF rectHandle)
        {

            m_spenHandleOutline.Width = 1f / gfx.PageScale;
            m_spenHandleOutline.DashStyle = DashStyle.Solid;
            m_spenHandleOutline.Color = Color.Gray;

            // Check handle state
            if (!Enabled(handle, node))
                m_sbrushHandle.Color = Color.Gray;

            // Customizing Square BoxPosition handles.
            else if (handle == BoxPosition.BottomCenter || handle == BoxPosition.TopCenter || handle == BoxPosition.MiddleLeft || handle == BoxPosition.MiddleRight)
            {
                gfx.DrawRectangle(m_spenHandleOutline, rectHandle.X, rectHandle.Y, rectHandle.Width, rectHandle.Height);
                gfx.FillRectangle(m_sbrushHandle, rectHandle);
            }

           // Customizing Round BoxPosition handles.
            else
            {
                if (m_sbrushHandle.Color != Color.Gray)
                    m_sbrushHandle.Color = Color.FromArgb(209, 248, 250);

                // Fill handle interiors
                gfx.DrawEllipse(m_spenHandleOutline, rectHandle.X, rectHandle.Y, rectHandle.Width, rectHandle.Height);
                gfx.FillEllipse(m_sbrushHandle, rectHandle);
            }
        }
        private static bool Enabled(BoxPosition handle, Node node)
        {
            bool bValueToReturn = true;
            switch (handle)
            {
                case BoxPosition.TopLeft:
                case BoxPosition.TopRight:
                case BoxPosition.BottomLeft:
                case BoxPosition.BottomRight:
                    bValueToReturn = EditStyle.CanChangeWidth(node) && EditStyle.CanChangeHeight(node);
                    break;
                case BoxPosition.MiddleLeft:
                case BoxPosition.MiddleRight:
                    bValueToReturn = EditStyle.CanChangeWidth(node);
                    break;
                case BoxPosition.TopCenter:
                case BoxPosition.BottomCenter:
                    bValueToReturn = EditStyle.CanChangeHeight(node);
                    break;
            }
            return bValueToReturn;
        }

        # endregion
    }
}