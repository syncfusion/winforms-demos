#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Calculate;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace FirstSample
{
    /// <summary>
    /// Summary description for AngleForm.
    /// </summary>
    public class AngleForm : GridDemoForm
    {
        #region API Definitions
        private System.Windows.Forms.TextBox Angle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cosTB;
        private System.Windows.Forms.TextBox sinTB;
        private ButtonAdv button1;
        private System.Windows.Forms.Label label4;
        CalcQuick calculator = null;
        #endregion
        private Panel panel1;
        private IContainer components;


        public AngleForm()
        {
            //
            // Required for Windows Form Designer support.
            //
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
       
        #region Windows Form Designer stuffs
        /// <summary>
        /// Required method for Designer support; do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Angle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cosTB = new System.Windows.Forms.TextBox();
            this.sinTB = new System.Windows.Forms.TextBox();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Angle
            // 
            this.Angle.Location = new System.Drawing.Point(137, 90);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(56, 20);
            this.Angle.TabIndex = 0;
            this.Angle.Text = "30";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "angle in degrees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "cosine of angle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "sine of angle";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cosTB
            // 
            this.cosTB.Location = new System.Drawing.Point(137, 130);
            this.cosTB.Name = "cosTB";
            this.cosTB.Size = new System.Drawing.Size(136, 20);
            this.cosTB.TabIndex = 4;
            this.cosTB.Text = "= sin([Angle] * pi() / 180) ";
            // 
            // sinTB
            // 
            this.sinTB.Location = new System.Drawing.Point(137, 170);
            this.sinTB.Name = "sinTB";
            this.sinTB.Size = new System.Drawing.Size(136, 20);
            this.sinTB.TabIndex = 5;
            this.sinTB.Text = "= cos([Angle] * pi() / 180) ";
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(112, 23);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(89, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyle = true;
            this.button1.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter an angle and press the Compute button.";
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sinTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cosTB);
            this.panel1.Controls.Add(this.Angle);
            this.panel1.Location = new System.Drawing.Point(9, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 204);
            this.panel1.TabIndex = 8;
            // 
            // AngleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 18F);
            this.ClientSize = new System.Drawing.Size(324, 213);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(336, 244);
            this.Name = "AngleForm";
            this.Text = "Angle Form ";
            this.Load += new System.EventHandler(this.AngleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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

        #endregion


        private void AngleForm_Load(object sender, System.EventArgs e)
        {
            //TextBox Angle = new TextBox();
            this.Angle.Name = "Angle";
            this.Angle.Text = "30";

            //cosTB = new TextBox();
            this.cosTB.Name = "cosTB";
            this.cosTB.Text = "= cos([Angle] * pi() / 180) ";

            //sinTB = new TextBox();
            this.sinTB.Name = "sinTB";
            this.sinTB.Text = "= sin([Angle] * pi() / 180) ";

            //Instantiate the CalcQuick object:
            this.calculator = new CalcQuick();
        }

        #region [ComputeButton_Click Event handler]
        //Perform a manual calculation:
        private void ComputeButton_Click(object sender, System.EventArgs e)
        {
            //Let the calculator know the values / formulas 
            //by using an indexer on the calculator object.
            //Here we are using the text box names as the indexer keys
            //provided to the calculator object. This is not required.
            //The only restrictions for the indexer key values are that they 
            //unique nonempty strings.
            this.calculator["Angle"] = this.Angle.Text;
            this.calculator["cosTB"] = this.cosTB.Text;
            this.calculator["sinTB"] = this.sinTB.Text;

            //Mark the calculator dirty:
            this.calculator.SetDirty();

            //Now as the values are retrieved from the calculator, they
            //will be the newly calculated values.
            this.cosTB.Text = this.calculator["cosTB"];
            this.sinTB.Text = this.calculator["sinTB"];
        }
        #endregion
    }
}
