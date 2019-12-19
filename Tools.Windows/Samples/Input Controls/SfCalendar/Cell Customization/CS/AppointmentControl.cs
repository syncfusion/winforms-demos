#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentDemo
{
    public partial class AppointmentControl : Panel
    {

        public System.Windows.Forms.Label DescriptionLbl;
        public System.Windows.Forms.Label TimeLbl;

        public AppointmentControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(0, 18);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(43, 15);
            this.DescriptionLbl.TabIndex = 0;
            this.DescriptionLbl.Text = "label1";
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TimeLbl.Location = new System.Drawing.Point(0, 56);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(43, 15);
            this.TimeLbl.TabIndex = 1;
            this.TimeLbl.Text = "label2";
            // 
            // AppointmentControl
            // 
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.DescriptionLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AppointmentControl";
            this.Size = new System.Drawing.Size(450, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
