#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using System.Drawing;
namespace CalcEngine.Showcase_2010
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
            this.gridPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.formulaPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.syntaxtitle = new System.Windows.Forms.Label();
            this.syntaxLable = new System.Windows.Forms.Label();
            this.descrLable = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.functionCountLable = new System.Windows.Forms.Label();
            this.descTitle = new System.Windows.Forms.Label();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.formlabel = new System.Windows.Forms.Label();
            this.formulaCombo = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.resultLable = new System.Windows.Forms.Label();
            this.resulttile = new System.Windows.Forms.Label();
            this.gridPanel.SuspendLayout();
            this.formulaPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formulaCombo)).BeginInit();
            this.resultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPanel
            // 
            this.gridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.gridPanel.Controls.Add(this.label1);
            this.gridPanel.Location = new System.Drawing.Point(6, 5);
            this.gridPanel.Margin = new System.Windows.Forms.Padding(4, 5, 50, 50);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(873, 840);
            this.gridPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(76, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(938, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sample Data Set";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formulaPanel
            // 
            
            this.formulaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.formulaPanel.Controls.Add(this.tableLayoutPanel1);
            this.formulaPanel.Controls.Add(this.textBox1);
            this.formulaPanel.Controls.Add(this.functionCountLable);
            this.formulaPanel.Controls.Add(this.descTitle);
            this.formulaPanel.Controls.Add(this.buttonAdv1);
            this.formulaPanel.Controls.Add(this.formlabel);
            this.formulaPanel.Controls.Add(this.formulaCombo);
            this.formulaPanel.Location = new System.Drawing.Point(1109, 43);
            this.formulaPanel.Margin = new System.Windows.Forms.Padding(4, 5, 75, 5);
            this.formulaPanel.Name = "formulaPanel";
            this.formulaPanel.Size = new System.Drawing.Size(570, 706);
            this.formulaPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.syntaxtitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.syntaxLable, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.descrLable, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 255);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, (int)DpiAware.LogicalToDeviceUnits(45.0f)));
            //this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            //this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(326, 426);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // syntaxtitle
            // 
            this.syntaxtitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syntaxtitle.ForeColor = System.Drawing.Color.White;
            this.syntaxtitle.Location = new System.Drawing.Point(4, 208);
            this.syntaxtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.syntaxtitle.Name = "syntaxtitle";
            this.syntaxtitle.Size = new System.Drawing.Size(150, 30);
            this.syntaxtitle.TabIndex = 6;
            this.syntaxtitle.Text = "SYNTAX";
            this.syntaxtitle.Click += new System.EventHandler(this.Form1_Click);
            // 
            // syntaxLable
            // 
            this.syntaxLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syntaxLable.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.syntaxLable.Location = new System.Drawing.Point(26, 238);
            this.syntaxLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.syntaxLable.Name = "syntaxLable";
            this.syntaxLable.Size = new System.Drawing.Size(474, 188);
            this.syntaxLable.TabIndex = 7;
            this.syntaxLable.Click += new System.EventHandler(this.Form1_Click);
            // 
            // descrLable
            // 
            this.descrLable.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.descrLable.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.descrLable.Location = new System.Drawing.Point(42, 0);
            this.descrLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descrLable.Name = "descrLable";
            this.descrLable.Size = new System.Drawing.Size(480, 200);
            this.descrLable.TabIndex = 3;
            this.descrLable.Click += new System.EventHandler(this.Form1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(190, 72);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // functionCountLable
            // 
            this.functionCountLable.AutoSize = true;
            this.functionCountLable.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionCountLable.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.functionCountLable.Location = new System.Drawing.Point(10, 15);
            this.functionCountLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.functionCountLable.Name = "functionCountLable";
            this.functionCountLable.Size = new System.Drawing.Size(173, 21);
            this.functionCountLable.TabIndex = 6;
            this.functionCountLable.Text = "It Supports 407 formulas";
            this.functionCountLable.Click += new System.EventHandler(this.Form1_Click);
            // 
            // descTitle
            // 
            this.descTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descTitle.ForeColor = System.Drawing.Color.White;
            this.descTitle.Location = new System.Drawing.Point(27, 237);
            this.descTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descTitle.Name = "descTitle";
            this.descTitle.Size = new System.Drawing.Size(200, 226);
            this.descTitle.TabIndex = 3;
            this.descTitle.Text = "DESCRIPTION";
            this.descTitle.Click += new System.EventHandler(this.Form1_Click);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(126)))), ((int)(((byte)(156)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(213, 51);
            this.buttonAdv1.FlatAppearance.BorderSize = 0;
            this.buttonAdv1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold);
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv1.Location = new System.Drawing.Point(22, 139);
            this.buttonAdv1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Text = "Calculate";
            this.buttonAdv1.Size = new System.Drawing.Size(150, 31);
            this.buttonAdv1.TabIndex = 7;
            this.buttonAdv1.Text = "Calculate";
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // formlabel
            // 
            this.formlabel.ForeColor = System.Drawing.Color.White;
            this.formlabel.Location = new System.Drawing.Point(15, -38);
            this.formlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formlabel.Name = "formlabel";
            this.formlabel.Size = new System.Drawing.Size(150, 18);
            this.formlabel.TabIndex = 1;
            this.formlabel.Text = "Choose Formula";
            // 
            // formulaCombo
            // 
            this.formulaCombo.AllowNewText = false;
            this.formulaCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.formulaCombo.BeforeTouchSize = new System.Drawing.Size(214, 27);
            this.formulaCombo.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.formulaCombo.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(100)))));
            this.formulaCombo.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.formulaCombo.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulaCombo.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.formulaCombo.Location = new System.Drawing.Point(21, 72);
            this.formulaCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formulaCombo.MaxDropDownItems = 5;
            this.formulaCombo.Name = "formulaCombo";
            this.formulaCombo.Padding = new System.Windows.Forms.Padding(64, 68, 64, 68);
            this.formulaCombo.Size = new System.Drawing.Size(154, 27);
            this.formulaCombo.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.formulaCombo.TabIndex = 0;
            this.formulaCombo.ThemeName = "Metro";
            this.formulaCombo.UseBackColor = true;
            // 
            // resultPanel
            // 
            this.resultPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.resultPanel.Controls.Add(this.resultLable);
            this.resultPanel.Controls.Add(this.resulttile);
            this.resultPanel.Location = new System.Drawing.Point(1109, 759);
            this.resultPanel.Margin = new System.Windows.Forms.Padding(4, 5, 10, 10);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(570, 125);
            this.resultPanel.TabIndex = 3;
            // 
            // resultLable
            // 
            this.resultLable.BackColor = System.Drawing.Color.Transparent;
            this.resultLable.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLable.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.resultLable.Location = new System.Drawing.Point(0, 42);
            this.resultLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(496, 68);
            this.resultLable.TabIndex = 6;
            this.resultLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultLable.Click += new System.EventHandler(this.Form1_Click);
            // 
            // resulttile
            // 
            this.resulttile.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.resulttile.ForeColor = System.Drawing.Color.White;
            this.resulttile.Location = new System.Drawing.Point(14, 15);
            this.resulttile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resulttile.Name = "resulttile";
            this.resulttile.Size = new System.Drawing.Size(150, 28);
            this.resulttile.TabIndex = 5;
            this.resulttile.Text = "RESULT";
            this.resulttile.Click += new System.EventHandler(this.Form1_Click);
            //
            // panle1
            //
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Size = new System.Drawing.Size(1370, 527);
            // 
            // Form1
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(1370, 527);
            this.panel1.Controls.Add(this.resultPanel);
            this.panel1.Controls.Add(this.formulaPanel);
            this.panel1.Controls.Add(this.gridPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(123)))));
            this.Style.InactiveShadowOpacity = ((byte)(0));
            //this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            //this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Style.ShadowOpacity = ((byte)(0));
            this.Style.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(123)))));
            this.Style.TitleBar.CaptionImage = ((System.Drawing.Image)(resources.GetObject("resource.CaptionImage")));
            this.Style.TitleBar.CaptionImageLocation = new System.Drawing.Point(12, 23);
            this.Style.TitleBar.CloseButtonForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Style.TitleBar.ForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.Height = 75;
            this.Style.TitleBar.MaximizeButtonForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.MinimizeButtonForeColor = System.Drawing.Color.White;
            this.Text = "Essential Calculate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gridPanel.ResumeLayout(false);
            this.formulaPanel.ResumeLayout(false);
            this.formulaPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formulaCombo)).EndInit();
            this.resultPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel formulaPanel;
        private System.Windows.Forms.Label formlabel;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv formulaCombo;
        private System.Windows.Forms.Label descrLable;
        private System.Windows.Forms.Label descTitle;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.Label resulttile;
        private System.Windows.Forms.Label functionCountLable;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private System.Windows.Forms.Label syntaxLable;
        private System.Windows.Forms.Label syntaxtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

