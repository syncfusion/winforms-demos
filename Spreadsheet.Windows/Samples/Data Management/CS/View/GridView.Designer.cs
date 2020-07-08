#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Grid;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace ImportDataTable.View
{
    public partial class GridView
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

        //GridGroupingControl to Export the Data from the spreadsheet.
        internal GridGroupingControl gridGroupingControl;
        private Panel panel;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridGroupingControl = new GridGroupingControl();
            this.panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridGroupingControl
            // 
            this.gridGroupingControl.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.gridGroupingControl.BackColor = Color.White;
            this.gridGroupingControl.BrowseOnly = true;
            this.gridGroupingControl.ForeColor = Color.Black;
            this.gridGroupingControl.Location = new Point(0, 0);
            this.gridGroupingControl.MinimumSize = new Size(584, 376);
            this.gridGroupingControl.Name = "gridGroupingControl";
            this.gridGroupingControl.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.HideAlways;
            this.gridGroupingControl.ShowRowHeaders = false;
            this.gridGroupingControl.Size = new Size(779, 431);
            this.gridGroupingControl.TabIndex = 1;
            this.gridGroupingControl.TableDescriptor.AllowEdit = false;
            this.gridGroupingControl.Text = "GridGroupingControl";
            this.gridGroupingControl.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl.UseRightToLeftCompatibleTextBox = true;
            this.gridGroupingControl.VersionInfo = "15.2460.0.46";
            // 
            // panel
            // 
            this.panel.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.panel.BackColor = Color.White;
            this.panel.BorderStyle = BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.gridGroupingControl);
            this.panel.ForeColor = Color.DarkGray;
            this.panel.Location = new Point(12, 0);
            this.panel.MinimumSize = new Size(584, 376);
            this.panel.Name = "panel";
            this.panel.Size = new Size(781, 431);
            this.panel.TabIndex = 0;
            // 
            // GridView Layout
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(805, 443);
            this.Controls.Add(this.panel);
            this.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new Size(600, 500);
            this.Name = "GridView";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = string.Empty;
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

    }
}