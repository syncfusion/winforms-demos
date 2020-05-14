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
using System.Windows.Forms;

namespace AppointmentDemo
{
    public partial class EventHeaderControl : Panel
    {
        private System.Windows.Forms.Panel container;
        public System.Windows.Forms.Label EventHeaderLabel;

        public EventHeaderControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void InitializeComponent()
        {
            this.container = new System.Windows.Forms.Panel();
            this.EventHeaderLabel = new System.Windows.Forms.Label();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.container.Controls.Add(this.EventHeaderLabel);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "panel1";
            this.container.Size = new System.Drawing.Size(472, 40);
            this.container.TabIndex = 1;
            // 
            // FullDayLbl
            // 
            this.EventHeaderLabel.AutoSize = true;
            this.EventHeaderLabel.Location = new System.Drawing.Point(0, 20);
            this.EventHeaderLabel.Name = "FullDayLbl";
            this.EventHeaderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventHeaderLabel.Size = new System.Drawing.Size(61, 15);
            this.EventHeaderLabel.TabIndex = 0;
            this.EventHeaderLabel.Text = "Start Time";
            // 
            // FullDayAppointmentControl
            // 
            this.Controls.Add(this.container);
            this.Name = "FullDayAppointmentControl";
            this.Size = new System.Drawing.Size(472, 40);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
