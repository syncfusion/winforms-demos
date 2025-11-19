#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing.Imaging;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Diagram.Controls;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using Syncfusion.SVG.IO;
using System.Xml;
using System.Collections;


namespace BusinessObjectBinding
{
    public partial class Form1 : MetroForm
    {
        #region Members
        private long m_x, m_y;
        public long x { get { return m_x; } set { m_x = value; } }
        public long y { get { return m_y; } set { m_y = value; } }
        Syncfusion.Windows.Forms.Diagram.OrthogonalConnector lineconnector;
        Syncfusion.Windows.Forms.Diagram.OrthogonalConnector orthogoanlConnector;
        #endregion

        #region Form Initialization
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diagram1.BeginUpdate();
            x = y = 0;
            this.diagram1.Model.SizeToContent = true;
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            DiagramAppearance();
            GenerateList("b1");
            CreateDiagram("b1");
            this.diagram1.View.SelectionList.Clear();
            diagram1.EndUpdate();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Change's the appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.Model.LineStyle.LineColor = Color.LightGray;           
            this.diagram1.View.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;            
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.View.BackgroundColor = Color.White;
        }
        #endregion

        #region Initialization of Diagram
        /// <summary>
        /// Generation of content for the diagram.
        /// </summary>
        /// <param name="businessType">Type of the Business object</param>
        /// <returns></returns>
        private List<HoshinKanriListItem> GenerateList(string businessType)
        {
            List<HoshinKanriListItem> hoshinList = new List<HoshinKanriListItem>();          

            string[] Content = { "  Goal1",  "  Goal2",  "  Goal3",  "  Goal4",  "  Goal5" };
            string[] Content1 = {  "  Objective1",  "  Objective2",  "  Objective3",  "  Objective4",  "  Objective5" };
            string[] SubContent = {  "  Key Task1" + "\r\n" +  "  Key Task2",  "  Key Task1" + "\r\n" +  "  Key Task2" + "\r\n" +  "  Key Task3",  "  Key Task1",  "  Key Task1",  "  Key Task1" };
            string[] IsOuterRectangle = { "false \r\n true", "false \r\n false \r\n true", "false", "false", "true" };
            string[] Leader = { "Tom Ray \r\n Tom Ray ,N Wayman", "Don Gabil \r\n Tom Ray \r\n Mariesa", "Tom Ray", "Tom Ray", "Tom Ray" };
            string[] Investor = {  "  Resource1" + "\r\n" +  "  Resource2",  "  Resource1" + "\r\n" +  "  Resource2" + "\r\n" +  "  Resource3",  "  Resource1",  "  Resource1",  "  Resource1" };
            string[] comments = {  "  Comments1" + "\r\n" +  "  Comments2",  "  Comments1" + "\r\n" +  "  Comments2" + "\r\n" +  "  Comments3",  "  Comments1",  "  Comments1",  "  Comments1" };
            string[] costSaving = { "$0.00 \r\n $0.00", "$0.00 \r\n $0.00 \r\n $0.00", "$0.00", "$0.00", "$0.00" };
            string[] toolTip = {  "  Tooltip1" + "\r\n" +  "  Tooltip2",  "  Tooltip1" + "\r\n" +  "  Tooltip2" + "\r\n" +  "  Tooltip3",  "  Tooltip1",  "  Tooltip1",  "  Tooltip1" };

            List<string[]> plan = new List<string[]>();
            List<string[]> actual = new List<string[]>();
            int listIndex = 0;
            plan.Add(new string[] { "", "", "P-1", "", "", "P-1", "P-2", "", "", "", "", "" });
            plan.Add(new string[] { "P-0", "P-1", "", "", "P-1", "P-1", "", "P-1", "P-2", "", "", "" });
            plan.Add(new string[] { "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-4", "P-0" });
            plan.Add(new string[] { "P-0", "P-0", "P-1", "", "P-2", "P-1", "P-4", "P-3", "P-2", "", "P-2", "P-0" });
            plan.Add(new string[] { "P-1", "", "", "", "", "P-1", "P-1", "", "", "P-1", "P-4", "P-0" });
            plan.Add(new string[] { "", "", "P-0", "P-1", "", "", "P-0", "P-4", "", "", "P-4", "" });
            plan.Add(new string[] { "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-4", "P-0" });
            plan.Add(new string[] { "P-0", "P-0", "P-1", "P-1", "", "", "P-1", "P-2", "", "", "", "P-0" });

            actual.Add(new string[] { "", "A-0", "A-0", "A-0", "A-0", "A-1", "A-1", "", "", "", "", "" });
            actual.Add(new string[] { "A-0", "A-0", "A-0", "A-0", "A-0", "A-0", "A-0", "", "", "", "", "" });
            actual.Add(new string[] { "A-0", "A-0", "A-0", "A-0", "A-0", "A-0", "A-0", "", "", "", "", "A-0" });
            actual.Add(new string[] { "A-0", "A-0", "A-1", "A-1", "A-1", "A-1", "A-2", "A-3", "", "", "", "" });
            actual.Add(new string[] { "", "", "", "", "", "", "", "", "", "", "", "" });
            actual.Add(new string[] { "", "", "", "A-0", "A-0", "A-1", "A-1", "", "", "", "", "" });
            actual.Add(new string[] { "A-0", "A-0", "A-0", "A-0", "A-0", "A-0", "A-0", "", "", "", "", "A-0" });
            actual.Add(new string[] { "A-0", "A-0", "A-1", "A-1", "A-1", "A-1", "A-2", "", "", "", "", "A-0" });


            for (int i = 0; i < Content.Length; i++)
            {
                HoshinKanriListItem hoshinItem = new HoshinKanriListItem();
                hoshinItem.Content = Content[i];
                hoshinItem.Content1 = Content1[i];
                if (SubContent[i].Contains("\r\n"))
                {
                    string[] subContent1 = SubContent[i].Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    string[] leader1 = Leader[i].Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    string[] Investor1 = Investor[i].Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    string[] comments1 = comments[i].Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    string[] costSaving1 = costSaving[i].Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    string[] toolTip1 = toolTip[i].Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    string[] isOuterRectangle1 = IsOuterRectangle[i].Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    for (int j = 0; j < subContent1.Length; j++)
                    {
                        hoshinItem.SubContent.Add(subContent1[j]);
                        hoshinItem.Leader.Add(leader1[j]);
                        hoshinItem.Resources.Add(Investor1[j]);
                        hoshinItem.Comments.Add(comments1[j]);
                        hoshinItem.CostSavings.Add(costSaving1[j]);
                        hoshinItem.ToolTip.Add(toolTip1[j]);
                        hoshinItem.Plan.Add(plan[listIndex]);
                        hoshinItem.Actual.Add(actual[listIndex]);
                        hoshinItem.IsOuterRectangle.Add(Convert.ToBoolean(isOuterRectangle1[j]));
                        listIndex++;
                    }
                }
                else
                {
                    hoshinItem.SubContent.Add(SubContent[i]);
                    hoshinItem.Leader.Add(Leader[i]);
                    hoshinItem.Resources.Add(Investor[i]);
                    hoshinItem.Comments.Add(comments[i]);
                    hoshinItem.CostSavings.Add(costSaving[i]);
                    hoshinItem.ToolTip.Add(toolTip[i]);
                    hoshinItem.Plan.Add(plan[listIndex]);
                    hoshinItem.Actual.Add(actual[listIndex]);
                    hoshinItem.IsOuterRectangle.Add(Convert.ToBoolean(IsOuterRectangle[i]));
                    listIndex++;
                }
                hoshinList.Add(hoshinItem);
            }
            return hoshinList;
        }

        /// <summary>
        /// Creates the daigram 
        /// </summary>
        /// <param name="businessType">Type of the List to be added</param>
        private void CreateDiagram(string businessType)
        {

            RectangleF rect = new RectangleF(10, 10, 1400, 60);
            TextNode nodeRectHeader = new TextNode("Safety", rect);
            nodeRectHeader.BackgroundStyle.Color = Color.FromArgb(84, 167, 167);
            nodeRectHeader.LineStyle.LineWidth = 1;
            nodeRectHeader.FontStyle.Size = 32;
            nodeRectHeader.FontStyle.Bold = true;
            nodeRectHeader.FontStyle.Italic = true;
            nodeRectHeader.FontColorStyle.Color = Color.White;
            nodeRectHeader.ReadOnly = true;
            nodeRectHeader.HorizontalAlignment = StringAlignment.Near;
            nodeRectHeader.VerticalAlignment = StringAlignment.Center;
            nodeRectHeader.EditStyle.AllowSelect = false;
            //FY10 goal is to  provide a safe working environment for our employees.Achieve this through improvement in the key categorie of severity and frequency rates.
            EllipseRectGroup erg = new EllipseRectGroup(1, "Vision", "Vision-1", Color.Red, Color.Black, Color.LightBlue, Color.White);
            GridGroup gg = new GridGroup();

            HeaderandEllipse he1 = new HeaderandEllipse(2, "Goals", Color.Red, Color.LightBlue, 13);
            HeaderandEllipse he2 = new HeaderandEllipse(3, "Objectives", Color.Red, Color.LightBlue, 13);
            HeaderandEllipse he3 = new HeaderandEllipse(4, "Key Tasks", Color.Red, Color.LightBlue, 12);

            SplitContent spc = new SplitContent("Who \n(leader)", "Resources Investor", Color.LightBlue, true, 12, true);
            GridGroupShapesandNumber ggsn = new GridGroupShapesandNumber("Schedule(Month)", Color.LightBlue);
            SplitContent spc2 = new SplitContent("Comments", "Cost Savings", Color.LightBlue, true, 12, true);

            int nameIndex = 0;
            List<HoshinKanriListItem> hoshinList = GenerateList(businessType);
            float contentPinPointY = 400, splitContentPinpointY = 400, gridSymbolPinpointY = 390, subContentPinPointY = 400;
            for (int i = 0; i < hoshinList.Count; i++)
            {
                ContentRectangle content = new ContentRectangle(hoshinList[i].Content, Color.Black, Color.LightGreen, false, 13, true);
                content.PinPoint = new PointF(10 + content.BoundingRectangle.Width / 2, contentPinPointY + content.BoundingRectangle.Height / 2);
                diagram1.Model.AppendChild(content);

                ContentRectangle content1 = new ContentRectangle(hoshinList[i].Content1, Color.Black, Color.LightGreen, false, 10, true);
                content1.PinPoint = new PointF(230 + content1.BoundingRectangle.Width / 2, contentPinPointY + content1.BoundingRectangle.Height / 2);
                diagram1.Model.AppendChild(content1);

                lineconnector = getLineConnectorOrdinary(content.PinPoint, content1.PinPoint);
                content.CentralPort.TryConnect(lineconnector.HeadEndPoint);
                content1.CentralPort.TryConnect(lineconnector.TailEndPoint);
                this.diagram1.Model.AppendChild(lineconnector);

                for (int j = 0; j < hoshinList[i].Leader.Count; j++)
                {
                    SplitContent splitContent = new SplitContent(hoshinList[i].Leader[j], hoshinList[i].Resources[j], Color.Gray, false, 10, false);
                    splitContent.Name = "splitContent" + (nameIndex + 1);
                    splitContent.PinPoint = new PointF(690 + splitContent.BoundingRectangle.Width / 2, splitContentPinpointY + splitContent.BoundingRectangle.Height / 2);
                    diagram1.Model.AppendChild(splitContent);

                    GridSymbols gridSymbol = new GridSymbols(hoshinList[i].Plan[j], hoshinList[i].Actual[j], hoshinList[i].ToolTip[j]);
                    gridSymbol.Name = "gridSymbol" + (nameIndex + 1);
                    gridSymbol.PinPoint = new PointF(920 + gridSymbol.BoundingRectangle.Width / 2, 2+gridSymbolPinpointY + gridSymbol.BoundingRectangle.Height / 2);
                    diagram1.Model.AppendChild(gridSymbol);

                    SplitContent splitContent1 = new SplitContent(hoshinList[i].Comments[j], hoshinList[i].CostSavings[j], Color.LightGray, false, 10, false);
                    splitContent1.Name = "splitContent1" + (nameIndex + 1);
                    splitContent1.PinPoint = new PointF(1160 + splitContent1.BoundingRectangle.Width / 2, splitContentPinpointY + splitContent1.BoundingRectangle.Height / 2);
                    diagram1.Model.AppendChild(splitContent1);

                    if (!hoshinList[i].IsOuterRectangle[j])
                    {
                        ContentRectangle subContent = new ContentRectangle(hoshinList[i].SubContent[j], Color.Black, Color.LightGreen, false, 10, true);
                        subContent.PinPoint = new PointF(460 + subContent.BoundingRectangle.Width / 2, subContentPinPointY + subContent.BoundingRectangle.Height / 2);
                        diagram1.Model.AppendChild(subContent);

                        lineconnector = getLineConnectorOrdinary(content1.PinPoint, subContent.PinPoint);
                        content1.CentralPort.TryConnect(lineconnector.TailEndPoint);
                        subContent.CentralPort.TryConnect(lineconnector.HeadEndPoint);
                        this.diagram1.Model.AppendChild(lineconnector);

                        lineconnector = getLineConnectorOrdinary(subContent.PinPoint, splitContent.PinPoint);
                        splitContent.CentralPort.TryConnect(lineconnector.TailEndPoint);
                        subContent.CentralPort.TryConnect(lineconnector.HeadEndPoint);
                        this.diagram1.Model.AppendChild(lineconnector);
                    }
                    else
                    {

                        ContentWithOuterRectangle subContent1 = new ContentWithOuterRectangle(hoshinList[i].SubContent[j], "A3", Color.LightGreen, Color.Pink);
                        subContent1.PinPoint = new PointF(460 + subContent1.BoundingRectangle.Width / 2, subContentPinPointY + subContent1.BoundingRectangle.Height / 2 - 20);
                        diagram1.Model.AppendChild(subContent1);

                        orthogoanlConnector = getOrthogonalConnector(content1.PinPoint, subContent1.PinPoint);
                        content1.CentralPort.TryConnect(orthogoanlConnector.TailEndPoint);
                        subContent1.CentralPort.TryConnect(orthogoanlConnector.HeadEndPoint);
                        this.diagram1.Model.AppendChild(orthogoanlConnector);

                        lineconnector = getLineConnectorOrdinary(subContent1.PinPoint, splitContent.PinPoint);
                        splitContent.CentralPort.TryConnect(lineconnector.TailEndPoint);
                        subContent1.CentralPort.TryConnect(lineconnector.HeadEndPoint);
                        this.diagram1.Model.AppendChild(lineconnector);
                    }
                    nameIndex++;
                    //if (!hoshinList[i].IsOuterRectangle[j])
                    //{
                    //    contentPinPointY += 65;
                    //    splitContentPinpointY += 65; gridSymbolPinpointY += 65; subContentPinPointY += 65;
                    //}
                    //else
                    //{

                    //}
                    contentPinPointY += 85;
                    splitContentPinpointY += 85; gridSymbolPinpointY += 85; subContentPinPointY += 85;
                    //if (j < hoshinList[i].Leader.Count)
                    //{
                    //    if (hoshinList[i].IsOuterRectangle[j])
                    //    {
                    //        contentPinPointY += (120-85);
                    //        splitContentPinpointY += (130 - 85); gridSymbolPinpointY += (130 - 85); subContentPinPointY += (120 - 85);
                    //    }
                    //}
                }
            }

            HeaderRectangleActual actualrect = new HeaderRectangleActual();
            HeaderRectanglePlan planrect = new HeaderRectanglePlan();

            erg.PinPoint = new PointF(10 + erg.BoundingRectangle.Width / 2, erg.BoundingRectangle.Height / 2 + 120);
            erg.CentralPort.OffsetX = he1.PinPoint.X;
            he1.PinPoint = new PointF(10 + he1.BoundingRectangle.Width / 2, 330 + he1.BoundingRectangle.Height / 2);
            he2.PinPoint = new PointF(230 + he2.BoundingRectangle.Width / 2, 330 + he2.BoundingRectangle.Height / 2);
            he3.PinPoint = new PointF(460 + he3.BoundingRectangle.Width / 2, 330 + he3.BoundingRectangle.Height / 2);
            spc.PinPoint = new PointF(690 + spc.BoundingRectangle.Width / 2, 330 + spc.BoundingRectangle.Height / 2);
            ggsn.PinPoint = new PointF(920 + ggsn.BoundingRectangle.Width / 2, 330 + ggsn.BoundingRectangle.Height / 2);
            spc2.PinPoint = new PointF(1160 + spc2.BoundingRectangle.Width / 2, 330 + spc2.BoundingRectangle.Height / 2);
            actualrect.PinPoint = new PointF(630 + actualrect.BoundingRectangle.Width / 2, actualrect.BoundingRectangle.Height / 2 + 103);
            planrect.PinPoint = new PointF(400 + planrect.BoundingRectangle.Width / 2, planrect.BoundingRectangle.Height / 2 + 103);
            gg.PinPoint = new PointF(900 + gg.BoundingRectangle.Width / 2, gg.BoundingRectangle.Height / 2 + 143);

            this.diagram1.Model.AppendChild(erg);
            this.diagram1.Model.AppendChild(gg);
            this.diagram1.Model.AppendChild(ggsn);
            this.diagram1.Model.AppendChild(he1);
            this.diagram1.Model.AppendChild(he2);
            this.diagram1.Model.AppendChild(he3);
            this.diagram1.Model.AppendChild(spc);
            this.diagram1.Model.AppendChild(spc2);

            this.diagram1.Model.AppendChild(planrect);
            this.diagram1.Model.AppendChild(actualrect);

            this.diagram1.Model.AppendChild(nodeRectHeader);

            lineconnector = getLineConnector(erg.PinPoint, he1.PinPoint);
            erg.CentralPort.TryConnect(lineconnector.TailEndPoint);
            he1.CentralPort.TryConnect(lineconnector.HeadEndPoint);

            this.diagram1.Model.AppendChild(lineconnector);

            lineconnector = getLineConnector(he1.PinPoint, he2.PinPoint);
            he1.CentralPort.TryConnect(lineconnector.TailEndPoint);
            he2.CentralPort.TryConnect(lineconnector.HeadEndPoint);
            this.diagram1.Model.AppendChild(lineconnector);

            lineconnector = getLineConnector(he2.PinPoint, he3.PinPoint);
            he2.CentralPort.TryConnect(lineconnector.TailEndPoint);
            he3.CentralPort.TryConnect(lineconnector.HeadEndPoint);
            this.diagram1.Model.AppendChild(lineconnector);

            lineconnector = getLineConnector(he3.PinPoint, spc.PinPoint);
            he3.CentralPort.TryConnect(lineconnector.TailEndPoint);
            spc.CentralPort.TryConnect(lineconnector.HeadEndPoint);
            this.diagram1.Model.AppendChild(lineconnector);

        }

        /// <summary>
        /// Returns the Line Connector with Decorator.
        /// </summary>
        /// <param name="p1">Start Point</param>
        /// <param name="p2">End Point</param>
        /// <returns></returns>
        private Syncfusion.Windows.Forms.Diagram.OrthogonalConnector getLineConnector(PointF p1, PointF p2)
        {
            Syncfusion.Windows.Forms.Diagram.OrthogonalConnector lineconnector = new Syncfusion.Windows.Forms.Diagram.OrthogonalConnector(p1, p2);
            lineconnector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            lineconnector.LineStyle.LineColor = Color.Black;
            lineconnector.HeadDecorator.FillStyle.Color = Color.Black;
            lineconnector.HeadDecorator.Size = new SizeF(10, 10);
            return lineconnector;
        }

        /// <summary>
        /// Returns the Line Connector
        /// </summary>
        /// <param name="p1">Start Point</param>
        /// <param name="p2">End Point</param>
        /// <returns></returns>
        private Syncfusion.Windows.Forms.Diagram.OrthogonalConnector getLineConnectorOrdinary(PointF p1, PointF p2)
        {
            Syncfusion.Windows.Forms.Diagram.OrthogonalConnector lineconnector = new Syncfusion.Windows.Forms.Diagram.OrthogonalConnector(p1, p2);
            lineconnector.LineStyle.LineColor = Color.Black;
            return lineconnector;
        }

        /// <summary>
        /// Returns the Orthogonal Connector
        /// </summary>
        /// <param name="p1">Start Point</param>
        /// <param name="p2">End Point</param>
        /// <returns></returns>
        private Syncfusion.Windows.Forms.Diagram.OrthogonalConnector getOrthogonalConnector(PointF p1, PointF p2)
        {
            Syncfusion.Windows.Forms.Diagram.OrthogonalConnector lineconnector = new Syncfusion.Windows.Forms.Diagram.OrthogonalConnector(p1, p2);
            lineconnector.LineStyle.LineColor = Color.Black;
            return lineconnector;
        }
        #endregion        
                
    }
   
}
