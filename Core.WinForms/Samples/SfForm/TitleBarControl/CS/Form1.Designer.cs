using Syncfusion.WinForms.DataGrid.Enums;
using System.Drawing;
using System.Windows.Forms;

namespace TitleBarControl
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    partial class Form1
    {

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
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.Location = new System.Drawing.Point(28, 65);
            this.sfDataGrid1.Name = "sfDataGrid";
            this.sfDataGrid1.Size = new System.Drawing.Size(970, 570);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            this.sfDataGrid1.AutoGenerateColumns = true;
            this.sfDataGrid1.SearchController.AllowFiltering = true;
            this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            // 
            // Form1
            // 
            this.Size = new System.Drawing.Size(1024, 640);
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.sfDataGrid1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Style.Border.Color = ColorTranslator.FromHtml("#0AA2E6");
            this.Style.InactiveBorder.Color = ColorTranslator.FromHtml("#0AA2E6");
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.BackColor = System.Drawing.SystemColors.Window;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.IContainer components;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
    }
}

