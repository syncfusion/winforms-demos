using Syncfusion.WinForms.DataGrid.Enums;
using System.Windows.Forms;
namespace Selection
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
            this.allowSelectionPointerPressed = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowFiltering = true;
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(10, 5);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.ShowGroupDropArea = true;
            this.sfDataGrid1.Size = new System.Drawing.Size(708, 590);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SelectionMode:";
            // 
            // selectionModeComboBox
            // 
            this.selectionModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionModeComboBox.FormattingEnabled = true;
            this.selectionModeComboBox.Items.AddRange(new object[] {
            "None",
            "Single",
            "SingleDeselect",
            "Multiple",
            "Extended"});
            this.selectionModeComboBox.Location = new System.Drawing.Point(746, 66);
            this.selectionModeComboBox.Name = "selectionModeComboBox";
            this.selectionModeComboBox.Size = new System.Drawing.Size(151, 21);
            this.selectionModeComboBox.TabIndex = 1;
            this.selectionModeComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectionModeComboBox_SelectedIndexChanged);
            // 
            // allowSelectionPointerPressed
            // 
            this.allowSelectionPointerPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allowSelectionPointerPressed.Location = new System.Drawing.Point(746, 95);
            this.allowSelectionPointerPressed.Name = "allowSelectionPointerPressed";
            this.allowSelectionPointerPressed.Size = new System.Drawing.Size(250, 50);
            this.allowSelectionPointerPressed.TabIndex = 3;
            this.allowSelectionPointerPressed.Text = "AllowSelectionOnPointerPressed";
            this.allowSelectionPointerPressed.CheckedChanged += new System.EventHandler(this.allowSelectionPointerPressed_CheckedChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.selectionModeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sfDataGrid1);
            this.Controls.Add(this.allowSelectionPointerPressed);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Text = "Selection";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectionModeComboBox;
        CheckBox allowSelectionPointerPressed;

    }
}