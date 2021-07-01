using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Windows.Forms;
namespace CheckBoxSelectorColumnDemo
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
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.selectionModeComboBox = new System.Windows.Forms.ComboBox();            
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";            
            this.sfDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(10, 5);
            this.sfDataGrid1.Name = "sfDataGrid1";
			this.sfDataGrid1.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid1.AutoGenerateColumns = false;
            this.sfDataGrid1.Size = new System.Drawing.Size(816, 621);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "SelectionMode:";
            // 
            // selectionModeComboBox
            // 
            this.selectionModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionModeComboBox.FormattingEnabled = true;
            this.selectionModeComboBox.Items.AddRange(new object[] {            
            "Single",            
            "Multiple",
            "Extended",
            "None"});
            this.selectionModeComboBox.Location = new System.Drawing.Point(15, 60);
            this.selectionModeComboBox.Name = "selectionModeComboBox";
            this.selectionModeComboBox.Size = new System.Drawing.Size(151, 24);
            this.selectionModeComboBox.TabIndex = 1;
            this.selectionModeComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectionModeComboBox_SelectedIndexChanged);            
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 84);
            this.label1.TabIndex = 4;
            this.label1.Text = "Options";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1380, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1050);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(1020, 636);
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1020, 636);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(this.sfDataGrid1);
            this.Controls.Add(this.panel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.selectionModeComboBox);
            this.panel1.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(5);            
            this.Name = "Form1";
            this.Text = "CheckBox Selector Column";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectionModeComboBox;        
        private Label label1;
        private Panel panel1;

    }
}