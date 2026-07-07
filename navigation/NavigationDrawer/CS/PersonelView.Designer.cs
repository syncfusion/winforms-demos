namespace NavigationDrawer_2010
{
    partial class PersonelView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.TextItem textItem1 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem2 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem3 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem4 = new Syncfusion.Windows.Forms.Tools.TextItem();
            this.hubTile1 = new Syncfusion.Windows.Forms.Tools.HubTile();
            //this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hubTile1
            // 
            this.hubTile1.Anchor = System.Windows.Forms.AnchorStyles.None;
            textItem1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem1.HubTile = this.hubTile1;
            this.hubTile1.Banner = textItem1;
            textItem2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem2.HubTile = this.hubTile1;
            this.hubTile1.Body = textItem2;
            this.hubTile1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem3.HubTile = this.hubTile1;
            this.hubTile1.Footer = textItem3;
            this.hubTile1.Location = new System.Drawing.Point(12, 10);
            this.hubTile1.Margin = new System.Windows.Forms.Padding(1);
            this.hubTile1.MinimumSize = new System.Drawing.Size(100, 100);
            this.hubTile1.Name = "hubTile1";
            this.hubTile1.Size = new System.Drawing.Size(115, 109);
            this.hubTile1.TabIndex = 0;
            textItem4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem4.HubTile = this.hubTile1;
            this.hubTile1.Title = textItem4;
            // 
            // label1
            // 
            //this.label1.AutoSize = true;
            //this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.label1.Location = new System.Drawing.Point(47, 126);
            //this.label1.Name = "label1";
            //this.label1.Size = new System.Drawing.Size(43, 17);
            //this.label1.TabIndex = 1;
            //this.label1.Text = "label1";
            // 
            // PersonelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.Controls.Add(this.label1);
            this.Controls.Add(this.hubTile1);
            this.Name = "PersonelView";
            this.Size = new System.Drawing.Size(140, 157);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Syncfusion.Windows.Forms.Tools.HubTile hubTile1;
        //public System.Windows.Forms.Label label1;
    }
}
