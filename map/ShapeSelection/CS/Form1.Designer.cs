using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Maps;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace ShapeSelectionDemo
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

       
    
        private void InitializeComponent()
        {

            this.ClientSize = new System.Drawing.Size(1198, 585);
            this.Name = "Form1";
            this.ShowIcon = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShapeSelection";
            this.label1 = new System.Windows.Forms.Label();
          //  this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            //
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(150)))), ((int)(((byte)(205)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(880, (int)DpiAware.LogicalToDeviceUnits(40));
            this.label1.TabIndex = 4;
            this.label1.Text = "This sample demonstrates how to select specific shape in the map.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.label1);
        }

        //private Syncfusion.Windows.Forms.Maps.Maps mapsControl1;
        private System.Windows.Forms.Label label1;
        
      
    }      
}

