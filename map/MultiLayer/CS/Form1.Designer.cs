#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Windows.Forms;
namespace MultiLayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.mapsControl1 = new Syncfusion.Windows.Forms.Maps.Maps();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mapsControl1
            // 
            this.mapsControl1.Dock = System.Windows.Forms.DockStyle.None;
            this.mapsControl1.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.mapsControl1.MapItemFont = null;
            this.mapsControl1.MapItemsShape = Syncfusion.Windows.Forms.Maps.MapItemShapes.Ellipse;
            this.mapsControl1.MapItemStroke = null;
            this.mapsControl1.Name = "mapsControl1";
            this.mapsControl1.Size = new System.Drawing.Size(880, 585);
            this.mapsControl1.TabIndex = 0;
            this.mapsControl1.Text = "mapsControl1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(150)))), ((int)(((byte)(205)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(880, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "This sample shows the multiple layers for displaying the temperature based on the country and its continent.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            Panel mapPanel = new Panel();
            mapPanel.Margin = new Padding(10);
            mapPanel.Padding = new Padding(10);
            mapPanel.Size = new System.Drawing.Size(880, 585);
            mapPanel.Controls.Add(mapsControl1);
            mapPanel.Dock = DockStyle.Fill;
            this.Controls.Add(mapPanel);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 585);
            this.Controls.Add(this.label1);
           // this.Controls.Add(this.mapsControl1);
            this.Name = "Form1";
            this.ShowIcon = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Layer Demo - World Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }
        #endregion

        private Syncfusion.Windows.Forms.Maps.Maps mapsControl1;
        private System.Windows.Forms.Label label1;
    }
}

