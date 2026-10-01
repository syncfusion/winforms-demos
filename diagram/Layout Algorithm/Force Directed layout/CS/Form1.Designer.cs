using System.Windows.Forms;

namespace ForceDirectedlayout
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.RepulsionStrength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.AttractionStrength = new System.Windows.Forms.NumericUpDown();
            this.MaxIteration = new System.Windows.Forms.NumericUpDown();
            this.lytProp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            this.tMarigin = new System.Windows.Forms.Label();
            this.chkAutoLayout = new System.Windows.Forms.CheckBox();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepulsionStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttractionStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.RepulsionStrength);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.AttractionStrength);
            this.panel2.Controls.Add(this.MaxIteration);
            this.panel2.Controls.Add(this.lytProp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.apply);
            this.panel2.Controls.Add(this.tMarigin);
            this.panel2.Controls.Add(this.chkAutoLayout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(622, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel2.Size = new System.Drawing.Size(359, 721);
            this.panel2.TabIndex = 1;
            // 
            // RepulsionStrength
            // 
            this.RepulsionStrength.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.RepulsionStrength.Location = new System.Drawing.Point(205, 149);
            this.RepulsionStrength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RepulsionStrength.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.RepulsionStrength.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RepulsionStrength.Name = "RepulsionStrength";
            this.RepulsionStrength.Size = new System.Drawing.Size(132, 22);
            this.RepulsionStrength.TabIndex = 45;
            this.RepulsionStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RepulsionStrength.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RepulsionStrength.ValueChanged += new System.EventHandler(this.RepulsionStrength_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Repulsion Strength";
            // 
            // AttractionStrength
            // 
            this.AttractionStrength.DecimalPlaces = 1;
            this.AttractionStrength.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AttractionStrength.Location = new System.Drawing.Point(205, 106);
            this.AttractionStrength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AttractionStrength.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.AttractionStrength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AttractionStrength.Name = "AttractionStrength";
            this.AttractionStrength.Size = new System.Drawing.Size(132, 22);
            this.AttractionStrength.TabIndex = 43;
            this.AttractionStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AttractionStrength.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AttractionStrength.ValueChanged += new System.EventHandler(this.AttractionStrength_ValueChanged);
            // 
            // MaxIteration
            // 
            this.MaxIteration.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.MaxIteration.Location = new System.Drawing.Point(205, 59);
            this.MaxIteration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaxIteration.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.MaxIteration.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.MaxIteration.Name = "MaxIteration";
            this.MaxIteration.Size = new System.Drawing.Size(132, 22);
            this.MaxIteration.TabIndex = 42;
            this.MaxIteration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxIteration.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.MaxIteration.ValueChanged += new System.EventHandler(this.MaxIteration_ValueChanged);
            // 
            // lytProp
            // 
            this.lytProp.AutoEllipsis = true;
            this.lytProp.BackColor = System.Drawing.Color.White;
            this.lytProp.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lytProp.Location = new System.Drawing.Point(16, 14);
            this.lytProp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lytProp.Name = "lytProp";
            this.lytProp.Size = new System.Drawing.Size(132, 25);
            this.lytProp.TabIndex = 39;
            this.lytProp.Text = "Properties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Attraction Strength";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Auto Layout";
            // 
            // apply
            // 
            this.apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.apply.FlatAppearance.BorderSize = 0;
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply.ForeColor = System.Drawing.Color.White;
            this.apply.Location = new System.Drawing.Point(107, 248);
            this.apply.Margin = new System.Windows.Forms.Padding(4);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(142, 29);
            this.apply.TabIndex = 33;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // tMarigin
            // 
            this.tMarigin.AutoSize = true;
            this.tMarigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMarigin.Location = new System.Drawing.Point(15, 60);
            this.tMarigin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tMarigin.Name = "tMarigin";
            this.tMarigin.Size = new System.Drawing.Size(135, 20);
            this.tMarigin.TabIndex = 23;
            this.tMarigin.Text = "Maximum Iteration";
            // 
            // chkAutoLayout
            // 
            this.chkAutoLayout.FlatAppearance.BorderSize = 0;
            this.chkAutoLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAutoLayout.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoLayout.Location = new System.Drawing.Point(205, 201);
            this.chkAutoLayout.Margin = new System.Windows.Forms.Padding(4);
            this.chkAutoLayout.Name = "chkAutoLayout";
            this.chkAutoLayout.Size = new System.Drawing.Size(14, 14);
            this.chkAutoLayout.TabIndex = 26;
            this.chkAutoLayout.UseVisualStyleBackColor = true;
            // 
            // diagram1
            // 
            this.diagram1.Controller.Constraint = Syncfusion.Windows.Forms.Diagram.Constraints.PageEditable;
            this.diagram1.Controller.DefaultConnectorTool = Syncfusion.Windows.Forms.Diagram.ConnectorTool.OrgLineConnectorTool;
            this.diagram1.Controller.Nodes = null;
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.EnableTouchMode = false;
            this.diagram1.HScroll = true;
            this.diagram1.Location = new System.Drawing.Point(3, 2);
            this.diagram1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diagram1.MetroScrollBars = true;
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.Size = new System.Drawing.Size(619, 721);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 2;
            this.diagram1.Text = "diagram1";
            this.diagram1.TouchMode = false;
            // 
            // 
            // 
            this.diagram1.View.Grid.MinPixelSpacing = 4F;
            this.diagram1.View.Grid.Visible = false;
            this.diagram1.View.Magnification = 100F;
            this.diagram1.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center;
            this.diagram1.VisualStyle = Syncfusion.Windows.Forms.Diagram.Controls.DiagramStyle.Default;
            this.diagram1.VScroll = true;
            // 
            // model1
            // 
            this.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model1.CustomUnitValue = 0.5F;
            this.model1.DocumentScale.DisplayName = "No Scale";
            this.model1.DocumentScale.Height = 1F;
            this.model1.DocumentScale.Width = 1F;
            this.model1.DocumentSize.Height = 1169F;
            this.model1.DocumentSize.Width = 1000F;
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LineStyle.LineWidth = 0F;
            this.model1.LogicalSize = new System.Drawing.SizeF(1000F, 1169F);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 725);
            this.Controls.Add(this.diagram1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepulsionStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttractionStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion   

        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Syncfusion.Windows.Forms.Diagram.Model model1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.CheckBox chkAutoLayout;
        private System.Windows.Forms.Label tMarigin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lytProp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AttractionStrength;
        private System.Windows.Forms.NumericUpDown MaxIteration;
        private System.Windows.Forms.NumericUpDown RepulsionStrength;
    }
}