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

    public partial class SelectedDateControl : Panel
    {
        #region Variables

        /// <summary>
        /// Variable to hold Container
        /// </summary>
        private System.Windows.Forms.Panel container;
        /// <summary>
        /// Variable to hold Appointment
        /// </summary>
        public System.Windows.Forms.Label SelectedDateLabel;

        #endregion

        #region Constructor

        public SelectedDateControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        #endregion

        #region Functions

        private void InitializeComponent()
        {
            this.container = new System.Windows.Forms.Panel();
            this.SelectedDateLabel = new System.Windows.Forms.Label();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.container.Controls.Add(this.SelectedDateLabel);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "panel1";
            this.container.Size = new System.Drawing.Size(472, 35);
            this.container.TabIndex = 1;
            // 
            // FullDayLbl
            // 
            this.SelectedDateLabel.AutoSize = true;
            this.SelectedDateLabel.Location = new System.Drawing.Point(0, 14);
            this.SelectedDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedDateLabel.Name = "FullDayLbl";
            this.SelectedDateLabel.Size = new System.Drawing.Size(61, 25);
            this.SelectedDateLabel.TabIndex = 0;
            this.SelectedDateLabel.Text = "Start Time";
            // 
            // FullDayAppointmentControl
            // 
            this.Controls.Add(this.container);
            this.Name = "FullDayAppointmentControl";
            this.Size = new System.Drawing.Size(472, 35);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }

    public partial class NoAppointmentControl : Panel
    {
        #region Variables

        /// <summary>
        /// Variable to hold Container
        /// </summary>
        private System.Windows.Forms.Panel container;
        /// <summary>
        /// Variable to hold Appointment
        /// </summary>
        public System.Windows.Forms.Label NoAppointmentLabel;

        #endregion

        #region Constructor

        public NoAppointmentControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        #endregion

        #region Functions

        private void InitializeComponent()
        {
            this.container = new System.Windows.Forms.Panel();
            this.NoAppointmentLabel = new System.Windows.Forms.Label();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.container.Controls.Add(this.NoAppointmentLabel);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "panel1";
            this.container.Size = new System.Drawing.Size(472, 67);
            this.container.TabIndex = 1;
            // 
            // FullDayLbl
            // 
            this.NoAppointmentLabel.AutoSize = true;
            this.NoAppointmentLabel.Location = new System.Drawing.Point(0, 18);
            this.NoAppointmentLabel.Name = "FullDayLbl";
            this.NoAppointmentLabel.Size = new System.Drawing.Size(61, 15);
            this.NoAppointmentLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoAppointmentLabel.TabIndex = 0;
            this.NoAppointmentLabel.Text = "Start Time";
            // 
            // FullDayAppointmentControl
            // 
            this.Controls.Add(this.container);
            this.Name = "FullDayAppointmentControl";
            this.Size = new System.Drawing.Size(472, 67);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
