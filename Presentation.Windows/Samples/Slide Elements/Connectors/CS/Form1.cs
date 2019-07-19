#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Presentation;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.Reflection;

namespace Connectors
{
    public partial class Form1 : MetroForm
    {
        #region Private Members
        private System.Windows.Forms.Button btnCreatePresn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;

        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #endregion

        # region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //            
            InitializeComponent();
            this.MinimizeBox = true;
            Application.EnableVisualStyles();
        }
        /// <summary>
        /// Helper method to find a syncfusion license key from the Common folder
        /// </summary>
        /// <param name="fileName">File name of the syncfusion license key</param>
        /// <returns></returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreatePresn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePresn
            // 
            this.btnCreatePresn.Location = new System.Drawing.Point(268, 152);
            this.btnCreatePresn.Name = "btnCreatePresn";
            this.btnCreatePresn.Size = new System.Drawing.Size(113, 27);
            this.btnCreatePresn.TabIndex = 0;
            this.btnCreatePresn.Text = "Create Presentation";
            this.btnCreatePresn.UseVisualStyleBackColor = true;
            this.btnCreatePresn.Click += new System.EventHandler(this.btnCreatePresn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 97);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "Click the button to view a presentation generated by Essential Presentation.\r\nPle" +
    "ase note that Microsoft PowerPoint viewer is required to view the \r\nresultant Presentation.\r" +
    "\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreatePresn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connectors";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.Run(new Form1());
        }

        #endregion

        private void btnCreatePresn_Click(object sender, EventArgs e)
        {
            //Create an instance for PowerPoint
            IPresentation presentation = Presentation.Create();

            //Add a blank slide to Presentation
            ISlide slide = presentation.Slides.Add(SlideLayoutType.Blank);

            //Add header shape
            IShape headerTextBox = slide.Shapes.AddTextBox(58.44, 53.85, 221.93, 81.20);
            //Add a paragraph into the text box
            IParagraph paragraph = headerTextBox.TextBody.AddParagraph("Flow chart with ");
            //Add a textPart
            ITextPart textPart = paragraph.AddTextPart("Connector");
            //Change the color of the font
            textPart.Font.Color = ColorObject.FromArgb(44, 115, 230);
            //Make the textpart bold
            textPart.Font.Bold = true;
            //Set the font size of the paragraph
            paragraph.Font.FontSize = 28;

            //Add start shape to slide
            IShape startShape = slide.Shapes.AddShape(AutoShapeType.FlowChartTerminator, 420.45, 36.35, 133.93, 50.39);
            //Add a paragraph into the start shape text body
            AddParagraph(startShape, "Start", ColorObject.FromArgb(255, 149, 34));

            //Add alarm shape to slide
            IShape alarmShape = slide.Shapes.AddShape(AutoShapeType.FlowChartProcess, 420.45, 126.72, 133.93, 50.39);
            //Add a paragraph into the alarm shape text body
            AddParagraph(alarmShape, "Alarm Rings", ColorObject.FromArgb(255, 149, 34));

            //Add condition shape to slide
            IShape conditionShape = slide.Shapes.AddShape(AutoShapeType.FlowChartDecision, 420.45, 222.42, 133.93, 97.77);
            //Add a paragraph into the condition shape text body
            AddParagraph(conditionShape, "Ready to Get Up ?", ColorObject.FromArgb(44, 115, 213));

            //Add wake up shape to slide
            IShape wakeUpShape = slide.Shapes.AddShape(AutoShapeType.FlowChartProcess, 420.45, 361.52, 133.93, 50.39);
            //Add a paragraph into the wake up shape text body
            AddParagraph(wakeUpShape, "Wake Up", ColorObject.FromArgb(44, 115, 213));

            //Add end shape to slide
            IShape endShape = slide.Shapes.AddShape(AutoShapeType.FlowChartTerminator, 420.45, 453.27, 133.93, 50.39);
            //Add a paragraph into the end shape text body
            AddParagraph(endShape, "End", ColorObject.FromArgb(44, 115, 213));

            //Add snooze shape to slide
            IShape snoozeShape = slide.Shapes.AddShape(AutoShapeType.FlowChartProcess, 624.85, 245.79, 159.76, 50.02);
            //Add a paragraph into the snooze shape text body
            AddParagraph(snoozeShape, "Hit Snooze button", ColorObject.FromArgb(255, 149, 34));

            //Add relay shape to slide
            IShape relayShape = slide.Shapes.AddShape(AutoShapeType.FlowChartDelay, 624.85, 127.12, 159.76, 49.59);
            //Add a paragraph into the relay shape text body
            AddParagraph(relayShape, "Relay", ColorObject.FromArgb(255, 149, 34));

            //Connect the start shape with alarm shape using connector
            IConnector connector1 = slide.Shapes.AddConnector(ConnectorType.Straight, startShape, 2, alarmShape, 0);
            //Set the arrow style for the connector
            connector1.LineFormat.EndArrowheadStyle = ArrowheadStyle.Arrow;

            //Connect the alarm shape with condition shape using connector
            IConnector connector2 = slide.Shapes.AddConnector(ConnectorType.Straight, alarmShape, 2, conditionShape, 0);
            //Set the arrow style for the connector
            connector2.LineFormat.EndArrowheadStyle = ArrowheadStyle.Arrow;

            //Connect the condition shape with snooze shape using connector
            IConnector connector3 = slide.Shapes.AddConnector(ConnectorType.Straight, conditionShape, 3, snoozeShape, 1);
            //Set the arrow style for the connector
            connector3.LineFormat.EndArrowheadStyle = ArrowheadStyle.Arrow;

            //Connect the snooze shape with relay shape using connector
            IConnector connector4 = slide.Shapes.AddConnector(ConnectorType.Straight, snoozeShape, 0, relayShape, 2);
            //Set the arrow style for the connector
            connector4.LineFormat.EndArrowheadStyle = ArrowheadStyle.Arrow;

            //Connect the relay shape with alarm shape using connector
            IConnector connector5 = slide.Shapes.AddConnector(ConnectorType.Straight, relayShape, 1, alarmShape, 3);
            //Set the arrow style for the connector
            connector5.LineFormat.EndArrowheadStyle = ArrowheadStyle.Arrow;

            //Connect the condition shape with wake up shape using connector
            IConnector connector6 = slide.Shapes.AddConnector(ConnectorType.Straight, conditionShape, 2, wakeUpShape, 0);
            //Set the arrow style for the connector
            connector6.LineFormat.EndArrowheadStyle = ArrowheadStyle.Arrow;

            //Connect the wake up shape with end shape using connector
            IConnector connector7 = slide.Shapes.AddConnector(ConnectorType.Straight, wakeUpShape, 2, endShape, 0);
            //Set the arrow style for the connector
            connector7.LineFormat.EndArrowheadStyle = ArrowheadStyle.Arrow;

            //Add No textbox to slide
            IShape noTextBox = slide.Shapes.AddTextBox(564.02, 245.43, 51.32, 26.22);
            //Add a paragraph into the text box
            noTextBox.TextBody.AddParagraph("No");

            //Add Yes textbox to slide
            IShape yesTextBox = slide.Shapes.AddTextBox(487.21, 327.99, 50.09, 26.23);
            //Add a paragraph into the text box
            yesTextBox.TextBody.AddParagraph("Yes");

            //Saves the presentation
            presentation.Save("ConnectorSample.pptx");

            if (MessageBox.Show("Do you want to view the generated Presentation?", "Presentation Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                System.Diagnostics.Process.Start("ConnectorSample.pptx");
                this.Close();
            }
        }

        /// <summary>
        /// Add a paragraph into the specified shape with specified text
        /// </summary>
        /// <param name="shape">Represent the shape</param>
        /// <param name="text">Represent the text to be added</param>
        /// <param name="fillColor">Represent the color to fill the shape</param>
        private void AddParagraph(IShape shape, string text, IColor fillColor)
        {
            //set the fill type as solid
            shape.Fill.FillType = FillType.Solid;
            //Set the color of the solid fill
            shape.Fill.SolidFill.Color = fillColor;
            //set the fill type of line format as solid
            shape.LineFormat.Fill.FillType = FillType.Solid;
            //set the fill color of line format
            if (fillColor.R == 255)
                shape.LineFormat.Fill.SolidFill.Color = ColorObject.FromArgb(190, 100, 39);            
            else
                shape.LineFormat.Fill.SolidFill.Color = ColorObject.FromArgb(54, 91, 157);
            //Add a paragraph into the specified shape with specified text
            IParagraph paragraph = shape.TextBody.AddParagraph(text);
            //Set the vertical alignment as center
            shape.TextBody.VerticalAlignment = VerticalAlignmentType.Middle;
            //Set horizontal alignment as center
            paragraph.HorizontalAlignment = HorizontalAlignmentType.Center;
            //Set font color as white
            paragraph.Font.Color = ColorObject.White;
            //Change the font size
            paragraph.Font.FontSize = 16;
        }
    }
}
