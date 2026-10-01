//[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
namespace ComboboxCells
{
    partial class EventTracer : System.Windows.Forms.UserControl
    {

        //UserControl overrides dispose to clean up the component list.
       
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components = null;
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.output = new Syncfusion.Windows.Forms.Grid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.output)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right |  System.Windows.Forms.AnchorStyles.Bottom)));
            this.output.Location = new System.Drawing.Point(2, 2);
            this.output.Name = "output";
            this.output.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.output.Size = new System.Drawing.Size(519, 147);
            this.output.SmartSizeBox = false;
            this.output.TabIndex = 0;
            this.output.Text = "GridControl1";
            this.output.UseRightToLeftCompatibleTextBox = true;
            // 
            // EventTracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.output);
            this.Name = "EventTracer";
            this.Size = new System.Drawing.Size(521, 150);
            ((System.ComponentModel.ISupportInitialize)(this.output)).EndInit();
            this.ResumeLayout(false);

        }
        public Syncfusion.Windows.Forms.Grid.GridControl output;

    }
}