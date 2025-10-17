#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using System.Drawing;
using System.Windows.Forms;

namespace RealTimeUpdates
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
                //Disposing events
                sfDataGrid.DrawCell -= SfDataGrid_DrawCell;
                startTimerBtn.Click -= ButtonClick_Click;
                frequencySlider.Scroll -= FrequencySlider_Scroll;
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
            this.optionLabel = new System.Windows.Forms.Label();
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.frequencyLbl = new System.Windows.Forms.Label();
            this.timerStatusLbl = new System.Windows.Forms.Label();
            this.frequencyRangeLbl = new System.Windows.Forms.Label();
            this.maxfrequency = new System.Windows.Forms.Label();
            this.numOfUpdate = new System.Windows.Forms.Label();
            this.frequencySlider = new System.Windows.Forms.TrackBar();
            this.startTimerBtn = new System.Windows.Forms.Button();
            this.frequencyChanging = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySlider)).BeginInit();
            this.SuspendLayout();
            // 
            // optionLabel
            // 
            this.optionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.optionLabel.Location = new System.Drawing.Point(814, 22);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(100, 33);
            this.optionLabel.TabIndex = 4;
            this.optionLabel.Text = "Options:";
            // 
            // sfDataGrid
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.AllowEditing = false;
            this.sfDataGrid.AllowGrouping = false;
            this.sfDataGrid.AllowSorting = false;
            this.sfDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid.BackColor = System.Drawing.SystemColors.Window;
            this.sfDataGrid.Location = new System.Drawing.Point(10, 5);
            this.sfDataGrid.Name = "sfDataGrid";
			this.sfDataGrid.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid.Size = new System.Drawing.Size(787, 578);
            this.sfDataGrid.TabIndex = 0;
            // 
            // frequencyLbl
            // 
            this.frequencyLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.frequencyLbl.Location = new System.Drawing.Point(842, 55);
            this.frequencyLbl.Name = "frequencyLbl";
            this.frequencyLbl.Size = new System.Drawing.Size(141, 29);
            this.frequencyLbl.TabIndex = 5;
            this.frequencyLbl.Text = "Timer Frequency:";
            // 
            // timerStatusLbl
            // 
            this.timerStatusLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timerStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.timerStatusLbl.Location = new System.Drawing.Point(842, 162);
            this.timerStatusLbl.Name = "timerStatusLbl";
            this.timerStatusLbl.Size = new System.Drawing.Size(100, 23);
            this.timerStatusLbl.TabIndex = 3;
            this.timerStatusLbl.Text = "Start /Stop Timer";
            // 
            // frequencyRangeLbl
            // 
            this.frequencyRangeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.frequencyRangeLbl.Location = new System.Drawing.Point(21, 9);
            this.frequencyRangeLbl.Name = "frequencyRangeLbl";
            this.frequencyRangeLbl.Size = new System.Drawing.Size(125, 20);
            this.frequencyRangeLbl.TabIndex = 6;
            this.frequencyRangeLbl.Text = "Timer Frequency :";
            // 
            // maxfrequency
            // 
            this.maxfrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.maxfrequency.Location = new System.Drawing.Point(415, 9);
            this.maxfrequency.Name = "maxfrequency";
            this.maxfrequency.Size = new System.Drawing.Size(200, 20);
            this.maxfrequency.TabIndex = 7;
            this.maxfrequency.Text = "1000";
            // 
            // numOfUpdate
            // 
            this.numOfUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numOfUpdate.Location = new System.Drawing.Point(299, 9);
            this.numOfUpdate.Name = "numOfUpdate";
            this.numOfUpdate.Size = new System.Drawing.Size(110, 20);
            this.numOfUpdate.TabIndex = 8;
            this.numOfUpdate.Text = "No Of Updates :";
            // 
            // frequencySlider
            // 
            this.frequencySlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencySlider.LargeChange = 100;
            this.frequencySlider.Location = new System.Drawing.Point(845, 97);
            this.frequencySlider.Maximum = 1000;
            this.frequencySlider.Minimum = 100;
            this.frequencySlider.Name = "frequencySlider";
            this.frequencySlider.Size = new System.Drawing.Size(104, 45);
            this.frequencySlider.TabIndex = 2;
            this.frequencySlider.TickFrequency = 200;
            this.frequencySlider.Value = 100;
            this.frequencySlider.Scroll += new System.EventHandler(this.FrequencySlider_Scroll);
            // 
            // startTimerBtn
            // 
            this.startTimerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startTimerBtn.Location = new System.Drawing.Point(845, 206);
            this.startTimerBtn.Name = "startTimerBtn";
            this.startTimerBtn.Size = new System.Drawing.Size(100, 33);
            this.startTimerBtn.TabIndex = 1;
            this.startTimerBtn.Text = "Stop Timer";
            this.startTimerBtn.Click += new System.EventHandler(this.ButtonClick_Click);
            // 
            // frequencyChanging
            // 
            this.frequencyChanging.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.frequencyChanging.Location = new System.Drawing.Point(152, 9);
            this.frequencyChanging.Name = "frequencyChanging";
            this.frequencyChanging.Size = new System.Drawing.Size(150, 20);
            this.frequencyChanging.TabIndex = 9;
            this.frequencyChanging.Text = "100 ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1006, 593);
            this.Controls.Add(this.sfDataGrid);
            this.Controls.Add(this.startTimerBtn);
            this.Controls.Add(this.frequencySlider);
            this.Controls.Add(this.timerStatusLbl);
            this.Controls.Add(this.optionLabel);
            this.Controls.Add(this.frequencyLbl);
            this.Controls.Add(this.frequencyRangeLbl);
            this.Controls.Add(this.maxfrequency);
            this.Controls.Add(this.numOfUpdate);
            this.Controls.Add(this.frequencyChanging);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real -Time Update";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Private members

        private SfDataGrid sfDataGrid;
        private Label optionLabel;
        private Label frequencyLbl;
        private Label frequencyRangeLbl;
        private Button startTimerBtn;
        private TrackBar frequencySlider;
        private Label timerStatusLbl;
        private Label maxfrequency;
        private Label numOfUpdate;
        private Label frequencyChanging;
        private StocksDataCollection collection;
        #endregion
    }
}

