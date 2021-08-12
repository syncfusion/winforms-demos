#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
#if !NETCORE
using System.Data.SqlServerCe;
#endif
using System.Drawing;
using System.Windows.Forms;

using Syncfusion.Windows.Forms.Tools;

namespace ComboTest
{
    /// <summary>
    /// Summary description for MultiColumnComboBoxSampleControl.
    /// </summary>
    public class MultiColumnComboBoxSampleControl : System.Windows.Forms.UserControl, IChildSampleControls
    {
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        internal Syncfusion.Windows.Forms.Tools.MultiColumnComboBox multiColumnBoundCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.PropertyGrid propertyGrid1;
        internal TextBox textLog;

        public MultiColumnComboBoxSampleControl()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
            this.propertyGrid1.PropertyValueChanged += new PropertyValueChangedEventHandler(propertyGrid1_PropertyValueChanged);
        }

        void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            this.Refresh();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {

            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.MetroColorTable metroColorTabel1 = new Syncfusion.Windows.Forms.MetroColorTable();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.multiColumnBoundCombo = new Syncfusion.Windows.Forms.Tools.MultiColumnComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnBoundCombo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.multiColumnBoundCombo);
            this.groupBox2.Location = new System.Drawing.Point(3, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 288);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataBound MultiColumnComboBox";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "This MultiColumnComboBox is bound to the Customers Table in the Northwind.mdb";
            // 
            // multiColumnBoundCombo
            // 
            this.multiColumnBoundCombo.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(42)))), ((int)(((byte)(191)))), ((int)(((byte)(241)))));
            this.multiColumnBoundCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multiColumnBoundCombo.BackColor = System.Drawing.Color.White;
            this.multiColumnBoundCombo.DisplayMember = "ContactName";
            this.multiColumnBoundCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.multiColumnBoundCombo.Location = new System.Drawing.Point(16, 96);
            this.multiColumnBoundCombo.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(191)))), ((int)(((byte)(241)))));
            this.multiColumnBoundCombo.Name = "multiColumnBoundCombo";
            metroColorTabel1.ArrowChecked = System.Drawing.Color.Black;
            metroColorTabel1.ArrowNormal = System.Drawing.Color.White;
            metroColorTabel1.ArrowNormal = System.Drawing.Color.Gray;
            metroColorTabel1.ArrowPushed = System.Drawing.Color.Black;
            metroColorTabel1.ScrollerBackground = System.Drawing.Color.White;
            metroColorTabel1.ThumbChecked = System.Drawing.Color.Black;
            metroColorTabel1.ThumbNormal = System.Drawing.Color.White;
            metroColorTabel1.ThumbNormal = System.Drawing.Color.Gray;
            metroColorTabel1.ThumbPushed = System.Drawing.Color.Black;
            this.multiColumnBoundCombo.ScrollMetroColorTable = metroColorTabel1;
            this.multiColumnBoundCombo.Size = new System.Drawing.Size(229, 21);
            this.multiColumnBoundCombo.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.multiColumnBoundCombo.TabIndex = 0;
            this.multiColumnBoundCombo.ValueMember = "CompanyName";
            this.multiColumnBoundCombo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            this.multiColumnBoundCombo.SelectionChangeCommitted += new System.EventHandler(this.combo_SelectionChangeCommitted);
            this.multiColumnBoundCombo.Validated += new System.EventHandler(this.combo_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.propertyGrid1);
            this.groupBox1.Location = new System.Drawing.Point(264, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 288);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MultiColumnComboBox Properties";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 16);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(194, 269);
            this.propertyGrid1.TabIndex = 0;
            // 
            // MultiColumnComboBoxSampleControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MultiColumnComboBoxSampleControl";
            this.Size = new System.Drawing.Size(472, 304);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnBoundCombo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        public Control GetPrimaryItem()
        {
            return this.multiColumnBoundCombo;
        }
        
        #region TRACE_NOTIFICATIONS
        private void combo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.textLog == null)
                return;
            ComboBoxBaseDataBound c = sender as ComboBoxBaseDataBound;
            this.textLog.Text += c.Name + "'s SelectedIndexChanged to:" + c.SelectedIndex + "\r\n";
        }

        private void combo_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            if (this.textLog == null)
                return;
            ComboBoxBaseDataBound c = sender as ComboBoxBaseDataBound;
            this.textLog.Text += c.Name + "'s SelectionChangeCommitted. New index is:" + c.SelectedIndex + "\r\n";
        }

        private void combo_Validated(object sender, System.EventArgs e)
        {
            if (this.textLog == null)
                return;

            ComboBoxBaseDataBound c = sender as ComboBoxBaseDataBound;
            if (c.SelectedItem != null)
                this.textLog.Text += c.Name + "has validated the new entry. New entry is:" + c.SelectedItem.ToString() + "\r\n";
            else
                this.textLog.Text += c.Name + "has validated the new entry. New entry is:" + c.Text + "\r\n";
        }

        private void combo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.textLog == null)
                return;
            ComboBoxBaseDataBound c = sender as ComboBoxBaseDataBound;
            if (c.SelectedItem != null)
                this.textLog.Text += c.Name + "is validating the new entry:" + c.SelectedItem.ToString() + "\r\n";
            else
                this.textLog.Text += c.Name + "is validating the new entry:" + c.Text + "\r\n";
        }
        #endregion TRACE_NOTIFICATIONS
    }
}
