#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace ChartTemplate_2005
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdv9 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Savebutton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.buttonAdv8 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv6 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv7 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv10 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.Columnbutton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Areabutton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Loadbutton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Piebutton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Templatebutton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAdv12 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv11 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.copyToolStripMenuItem.Text = "Copy File Path to clipboard";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(12, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 51);
            this.label1.TabIndex = 11;
            this.label1.Text = "Make changes to the \r\nchart and save your\r\ntemplate";
            // 
            // buttonAdv9
            // /
            this.buttonAdv9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdv9.Enabled = false;
            this.buttonAdv9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.buttonAdv9.Location = new System.Drawing.Point(6, 339);
            this.buttonAdv9.Name = "buttonAdv9";
            this.buttonAdv9.Size = new System.Drawing.Size(136, 31);
            this.buttonAdv9.TabIndex = 10;
            this.buttonAdv9.Text = "Save Template";
            this.buttonAdv9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.Gray;
            this.Savebutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.ForeColor = System.Drawing.Color.White;
            this.Savebutton.Location = new System.Drawing.Point(60, 520);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(56, 29);
            this.Savebutton.TabIndex = 6;
            this.Savebutton.Text = "SAVE";
            this.Savebutton.Click += new System.EventHandler(this.SaveTemplate_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.propertyGrid1.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.WhiteSmoke;
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.propertyGrid1.CommandsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.WhiteSmoke;
            this.propertyGrid1.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.propertyGrid1.LineColor = System.Drawing.Color.WhiteSmoke;
            this.propertyGrid1.Location = new System.Drawing.Point(5, 54);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(192, 275);
            this.propertyGrid1.TabIndex = 7;
            this.propertyGrid1.ViewBackColor = System.Drawing.Color.WhiteSmoke;
            this.propertyGrid1.ViewForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            // 
            // buttonAdv8
            // 
            this.buttonAdv8.BackColor = System.Drawing.Color.White;
            this.buttonAdv8.Enabled = false;
            this.buttonAdv8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv8.Location = new System.Drawing.Point(1, 13);
            this.buttonAdv8.Name = "buttonAdv8";
            this.buttonAdv8.Size = new System.Drawing.Size(137, 31);
            this.buttonAdv8.TabIndex = 9;
            this.buttonAdv8.Text = "Edit Template";
            this.buttonAdv8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.BackColor = System.Drawing.Color.White;
            this.buttonAdv1.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonAdv1.Enabled = false;
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv1.Image")));

            this.buttonAdv1.Location = new System.Drawing.Point(13, 83);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(76, 76);
            this.buttonAdv1.TabIndex = 0;
            this.buttonAdv1.Tag = "Check";
            this.toolTip1.SetToolTip(this.buttonAdv1, "Loads Column Chart");
            this.buttonAdv1.Click += new System.EventHandler(this.ChartType_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.BackColor = System.Drawing.Color.White;
            this.buttonAdv2.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonAdv2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv2.ForeColor = System.Drawing.Color.White;
            this.buttonAdv2.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv2.Image")));
            this.buttonAdv2.Location = new System.Drawing.Point(110, 83);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(76, 76);
            this.buttonAdv2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonAdv2, "Loads 3D Column Chart");
            this.buttonAdv2.Click += new System.EventHandler(this.ChartType_Click);
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.BackColor = System.Drawing.Color.White;
            this.buttonAdv3.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonAdv3.ForeColor = System.Drawing.Color.White;
            this.buttonAdv3.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv3.Image")));

            this.buttonAdv3.Location = new System.Drawing.Point(13, 195);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(76, 76);
            this.buttonAdv3.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonAdv3, "Loads Area Chart");
            this.buttonAdv3.Click += new System.EventHandler(this.ChartType_Click);
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.BackColor = System.Drawing.Color.White;
            this.buttonAdv4.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonAdv4.ForeColor = System.Drawing.Color.White;
            this.buttonAdv4.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv4.Image")));

            this.buttonAdv4.Location = new System.Drawing.Point(111, 195);
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(76, 76);
            this.buttonAdv4.TabIndex = 4;
            this.toolTip1.SetToolTip(this.buttonAdv4, "Loads 3D Area Chart");
            this.buttonAdv4.Click += new System.EventHandler(this.ChartType_Click);
            // 
            // buttonAdv5
            // 
            this.buttonAdv5.BackColor = System.Drawing.Color.White;
            this.buttonAdv5.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonAdv5.ForeColor = System.Drawing.Color.White;
            this.buttonAdv5.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv5.Image")));

            this.buttonAdv5.Location = new System.Drawing.Point(13, 307);
            this.buttonAdv5.Name = "buttonAdv5";
            this.buttonAdv5.Size = new System.Drawing.Size(76, 76);
            this.buttonAdv5.TabIndex = 8;
            this.toolTip1.SetToolTip(this.buttonAdv5, "Loads Line Chart");
            this.buttonAdv5.Click += new System.EventHandler(this.ChartType_Click);
            // 
            // buttonAdv6
            // 
            this.buttonAdv6.BackColor = System.Drawing.Color.White;
            this.buttonAdv6.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonAdv6.ForeColor = System.Drawing.Color.White;
            this.buttonAdv6.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv6.Image")));

            this.buttonAdv6.Location = new System.Drawing.Point(111, 307);
            this.buttonAdv6.Name = "buttonAdv6";
            this.buttonAdv6.Size = new System.Drawing.Size(76, 76);
            this.buttonAdv6.TabIndex = 9;
            this.toolTip1.SetToolTip(this.buttonAdv6, "Loads 3D Line Chart");
            this.buttonAdv6.Click += new System.EventHandler(this.ChartType_Click);
            // 
            // buttonAdv7
            // 
            this.buttonAdv7.BackColor = System.Drawing.Color.White;
            this.buttonAdv7.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonAdv7.ForeColor = System.Drawing.Color.White;
            this.buttonAdv7.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv7.Image")));

            this.buttonAdv7.Location = new System.Drawing.Point(13, 450);
            this.buttonAdv7.Name = "buttonAdv7";
            this.buttonAdv7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAdv7.Size = new System.Drawing.Size(76, 76);
            this.buttonAdv7.TabIndex = 10;
            this.toolTip1.SetToolTip(this.buttonAdv7, "Loads User Template2");
            this.buttonAdv7.Visible = false;
            this.buttonAdv7.Click += new System.EventHandler(this.ChartType_Click);
            // 
            // buttonAdv10
            // 
            this.buttonAdv10.BackColor = System.Drawing.Color.White;
            this.buttonAdv10.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonAdv10.ForeColor = System.Drawing.Color.White;
            this.buttonAdv10.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv10.Image")));

            this.buttonAdv10.Location = new System.Drawing.Point(110, 450);
            this.buttonAdv10.Name = "buttonAdv10";
            this.buttonAdv10.Size = new System.Drawing.Size(76, 76);
            this.buttonAdv10.TabIndex = 11;
            this.toolTip1.SetToolTip(this.buttonAdv10, "Loads User Template2");
            this.buttonAdv10.Visible = false;
            this.buttonAdv10.Click += new System.EventHandler(this.ChartType_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(958, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.White);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.White);
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Legend.Location = new System.Drawing.Point(445, 70);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(200, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(560, 580);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // Columnbutton
            // 
            this.Columnbutton.AutoSize = true;
            this.Columnbutton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Columnbutton.Enabled = false;
            this.Columnbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Columnbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));

            this.Columnbutton.Location = new System.Drawing.Point(6, 50);
            this.Columnbutton.Name = "Columnbutton";
            this.Columnbutton.Size = new System.Drawing.Size(75, 31);
            this.Columnbutton.TabIndex = 2;
            this.Columnbutton.Text = "Column";
            this.Columnbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Areabutton
            this.Areabutton.AutoSize = true;
            this.Areabutton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Areabutton.Enabled = false;
            this.Areabutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Areabutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));

            this.Areabutton.Location = new System.Drawing.Point(6, 162);
            this.Areabutton.Name = "Areabutton";
            this.Areabutton.Size = new System.Drawing.Size(52, 31);
            this.Areabutton.TabIndex = 5;
            this.Areabutton.Text = "Area";
            this.Areabutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Loadbutton
            // 
            this.Loadbutton.AutoSize = true;
            this.Loadbutton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Loadbutton.Enabled = false;
            this.Loadbutton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Loadbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));

            this.Loadbutton.Location = new System.Drawing.Point(7, 20);
            this.Loadbutton.Name = "Loadbutton";
            this.Loadbutton.Size = new System.Drawing.Size(146, 35);
            this.Loadbutton.TabIndex = 6;
            this.Loadbutton.Text = "Load Template";
            this.Loadbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Piebutton
            // 
            this.Piebutton.AutoSize = true;
            this.Piebutton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Piebutton.Enabled = false;
            this.Piebutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Piebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));

            this.Piebutton.Location = new System.Drawing.Point(6, 274);
            this.Piebutton.Name = "Piebutton";
            this.Piebutton.Size = new System.Drawing.Size(49, 31);
            this.Piebutton.TabIndex = 7;
            this.Piebutton.Text = "Line";
            this.Piebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Templatebutton
            this.Templatebutton.AutoSize = true;
            this.Templatebutton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Templatebutton.Enabled = false;
            this.Templatebutton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Templatebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));

            this.Templatebutton.Location = new System.Drawing.Point(6, 411);
            this.Templatebutton.Name = "Templatebutton";
            this.Templatebutton.Size = new System.Drawing.Size(131, 35);
            this.Templatebutton.TabIndex = 2;
            this.Templatebutton.Text = "My Template";
            this.Templatebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Templatebutton.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.buttonAdv12);
            this.panel3.Controls.Add(this.buttonAdv11);
            this.panel3.Controls.Add(this.Loadbutton);
            this.panel3.Controls.Add(this.buttonAdv10);
            this.panel3.Controls.Add(this.buttonAdv7);
            this.panel3.Controls.Add(this.buttonAdv1);
            this.panel3.Controls.Add(this.buttonAdv6);
            this.panel3.Controls.Add(this.buttonAdv2);
            this.panel3.Controls.Add(this.Templatebutton);
            this.panel3.Controls.Add(this.Columnbutton);
            this.panel3.Controls.Add(this.buttonAdv5);
            this.panel3.Controls.Add(this.buttonAdv3);
            this.panel3.Controls.Add(this.Piebutton);
            this.panel3.Controls.Add(this.buttonAdv4);
            this.panel3.Controls.Add(this.Areabutton);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 585);
            this.panel3.TabIndex = 8;
            // 
            // buttonAdv12
            // 
            this.buttonAdv12.AutoSize = true;
            this.buttonAdv12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdv12.Enabled = false;
            this.buttonAdv12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonAdv12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
  
            this.buttonAdv12.Location = new System.Drawing.Point(103, 528);
            this.buttonAdv12.Name = "buttonAdv12";
            this.buttonAdv12.Size = new System.Drawing.Size(90, 31);
            this.buttonAdv12.TabIndex = 17;
            this.buttonAdv12.Text = "My Template 2";
            this.buttonAdv12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv12.Visible = false;
            // 
            // buttonAdv11
            this.buttonAdv11.AutoSize = true;
            this.buttonAdv11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdv11.Enabled = false;
            this.buttonAdv11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonAdv11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));

            this.buttonAdv11.Location = new System.Drawing.Point(7, 528);
            this.buttonAdv11.Name = "buttonAdv11";
            this.buttonAdv11.Size = new System.Drawing.Size(90, 31);
            this.buttonAdv11.TabIndex = 16;
            this.buttonAdv11.Text = "My Template 1";
            this.buttonAdv11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv11.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.Savebutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonAdv8);
            this.panel1.Controls.Add(this.buttonAdv9);
            this.panel1.Controls.Add(this.propertyGrid1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Location = new System.Drawing.Point(760, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 584);
            this.panel1.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox1.Location = new System.Drawing.Point(14, 430);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(186, 32);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Store Chart Appearance";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox2.Location = new System.Drawing.Point(14, 455);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 32);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Store Series Data";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox3.Location = new System.Drawing.Point(14, 480);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 32);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Store Series Styles";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(823, 443);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading from Template";
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonAdv8;
        private System.Windows.Forms.Button buttonAdv9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Button buttonAdv1;
        private System.Windows.Forms.Button buttonAdv2;
        private System.Windows.Forms.Button Columnbutton;
        private System.Windows.Forms.Button buttonAdv3;
        private System.Windows.Forms.Button buttonAdv4;
        private System.Windows.Forms.Button Areabutton;
        private System.Windows.Forms.Button Loadbutton;
        private System.Windows.Forms.Button Piebutton;
        private System.Windows.Forms.Button buttonAdv5;
        private System.Windows.Forms.Button Templatebutton;
        private System.Windows.Forms.Button buttonAdv6;
        private System.Windows.Forms.Button buttonAdv7;
        private System.Windows.Forms.Button buttonAdv10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdv12;
        private System.Windows.Forms.Button buttonAdv11;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

