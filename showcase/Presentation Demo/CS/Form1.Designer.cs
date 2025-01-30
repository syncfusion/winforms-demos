#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace PowerPointViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.centerSlideLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.centerSlidePictureBox = new System.Windows.Forms.PictureBox();
            this.loadingIndicatorPictureBox = new System.Windows.Forms.Label();
            this.operationsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.openIconPictureBox = new System.Windows.Forms.PictureBox();
            this.pdfConvertIconPictureBox = new System.Windows.Forms.PictureBox();
            this.printIconPictureBox = new System.Windows.Forms.PictureBox();
            this.previousIconPictureBox = new System.Windows.Forms.PictureBox();
            this.lblpageDisplay = new System.Windows.Forms.Label();
            this.NextIconPictureBox = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.centerSlideLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerSlidePictureBox)).BeginInit();
            this.centerSlidePictureBox.SuspendLayout();
            this.operationsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfConvertIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.00782F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.6F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.centerSlideLayoutPanel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.operationsTableLayoutPanel, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.166667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.83334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.53846F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(240, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 594);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // centerSlideLayoutPanel
            // 
            this.centerSlideLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.centerSlideLayoutPanel, 5);
            this.centerSlideLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.centerSlideLayoutPanel.Controls.Add(this.centerSlidePictureBox);
            this.centerSlideLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerSlideLayoutPanel.Location = new System.Drawing.Point(255, 22);
            this.centerSlideLayoutPanel.Name = "centerSlideLayoutPanel";
            this.centerSlideLayoutPanel.RowCount = 1;
            this.centerSlideLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.centerSlideLayoutPanel.Size = new System.Drawing.Size(896, 485);
            this.centerSlideLayoutPanel.TabIndex = 9;
            // 
            // centerSlidePictureBox
            // 
            this.centerSlideLayoutPanel.SetColumnSpan(this.centerSlidePictureBox, 5);
            this.centerSlidePictureBox.Controls.Add(this.loadingIndicatorPictureBox);
            this.centerSlidePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerSlidePictureBox.Location = new System.Drawing.Point(3, 3);
            this.centerSlidePictureBox.Name = "centerSlidePictureBox";
            this.centerSlidePictureBox.Padding = new System.Windows.Forms.Padding(10);
            this.centerSlidePictureBox.Size = new System.Drawing.Size(890, 479);
            this.centerSlidePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.centerSlidePictureBox.TabIndex = 5;
            this.centerSlidePictureBox.TabStop = false;
            // 
            // loadingIndicatorPictureBox
            // 
            this.loadingIndicatorPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.loadingIndicatorPictureBox.Image = global::PowerPointViewer.Properties.Resources.Animation;
            this.loadingIndicatorPictureBox.Location = new System.Drawing.Point(84, 42);
            this.loadingIndicatorPictureBox.Name = "loadingIndicatorPictureBox";
            this.loadingIndicatorPictureBox.Padding = new System.Windows.Forms.Padding(10);
            this.loadingIndicatorPictureBox.Size = new System.Drawing.Size(63, 74);
            this.loadingIndicatorPictureBox.TabIndex = 1;
            // 
            // operationsTableLayoutPanel
            // 
            this.operationsTableLayoutPanel.ColumnCount = 8;
            this.operationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.37464F));
            this.operationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.83661F));
            this.operationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.12341F));
            this.operationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.operationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.2843F));
            this.operationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0616F));
            this.operationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.98973F));
            this.operationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.12341F));
            this.operationsTableLayoutPanel.Controls.Add(this.openIconPictureBox, 0, 0);
            this.operationsTableLayoutPanel.Controls.Add(this.pdfConvertIconPictureBox, 2, 0);
            this.operationsTableLayoutPanel.Controls.Add(this.printIconPictureBox, 1, 0);
            this.operationsTableLayoutPanel.Controls.Add(this.previousIconPictureBox, 5, 0);
            this.operationsTableLayoutPanel.Controls.Add(this.lblpageDisplay, 6, 0);
            this.operationsTableLayoutPanel.Controls.Add(this.NextIconPictureBox, 7, 0);
            this.operationsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationsTableLayoutPanel.Location = new System.Drawing.Point(339, 533);
            this.operationsTableLayoutPanel.Name = "operationsTableLayoutPanel";
            this.operationsTableLayoutPanel.RowCount = 1;
            this.operationsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.operationsTableLayoutPanel.Size = new System.Drawing.Size(778, 64);
            this.operationsTableLayoutPanel.TabIndex = 7;
            // 
            // openIconPictureBox
            // 
            this.openIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("openIconPictureBox.Image")));
            this.openIconPictureBox.Location = new System.Drawing.Point(3, 3);
            this.openIconPictureBox.Name = "openIconPictureBox";
            this.openIconPictureBox.Size = new System.Drawing.Size(32, 32);
            this.openIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.openIconPictureBox.TabIndex = 4;
            this.openIconPictureBox.TabStop = false;
            this.openIconPictureBox.Click += new System.EventHandler(this.Folder_Click);
            this.openIconPictureBox.MouseLeave += new System.EventHandler(this.openIconPictureBox_Leave);
            this.openIconPictureBox.MouseHover += new System.EventHandler(this.openIconPictureBox_MouseOver);
            // 
            // pdfConvertIconPictureBox
            // 
            this.pdfConvertIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pdfConvertIconPictureBox.Image")));
            this.pdfConvertIconPictureBox.Location = new System.Drawing.Point(120, 3);
            this.pdfConvertIconPictureBox.Name = "pdfConvertIconPictureBox";
            this.pdfConvertIconPictureBox.Size = new System.Drawing.Size(34, 58);
            this.pdfConvertIconPictureBox.TabIndex = 6;
            this.pdfConvertIconPictureBox.TabStop = false;
            this.pdfConvertIconPictureBox.Click += new System.EventHandler(this.pdfConvertIconPictureBox_Click);
            this.pdfConvertIconPictureBox.MouseLeave += new System.EventHandler(this.pdfConvertIconPictureBox_Leave);
            this.pdfConvertIconPictureBox.MouseHover += new System.EventHandler(this.pdfConvertIconPictureBox_MouseOver);
            // 
            // printIconPictureBox
            // 
            this.printIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("printIconPictureBox.Image")));
            this.printIconPictureBox.Location = new System.Drawing.Point(63, 3);
            this.printIconPictureBox.Name = "printIconPictureBox";
            this.printIconPictureBox.Size = new System.Drawing.Size(33, 58);
            this.printIconPictureBox.TabIndex = 5;
            this.printIconPictureBox.TabStop = false;
            this.printIconPictureBox.Click += new System.EventHandler(this.Print_Click);
            this.printIconPictureBox.MouseLeave += new System.EventHandler(this.printIconPictureBox_Leave);
            this.printIconPictureBox.MouseHover += new System.EventHandler(this.printIconPictureBox_MouseOver);
            // 
            // previousIconPictureBox
            // 
            this.previousIconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previousIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("previousIconPictureBox.Image")));
            this.previousIconPictureBox.Location = new System.Drawing.Point(598, 3);
            this.previousIconPictureBox.Name = "previousIconPictureBox";
            this.previousIconPictureBox.Size = new System.Drawing.Size(34, 58);
            this.previousIconPictureBox.TabIndex = 3;
            this.previousIconPictureBox.TabStop = false;
            this.previousIconPictureBox.Click += new System.EventHandler(this.Previous_Click);
            this.previousIconPictureBox.MouseLeave += new System.EventHandler(this.PreviousIconPictureBox_MouseLeave);
            this.previousIconPictureBox.MouseEnter += PreviousIconPictureBox_MouseHover;
            // 
            // lblpageDisplay
            // 
            this.lblpageDisplay.AutoSize = true;
            this.lblpageDisplay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblpageDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblpageDisplay.Location = new System.Drawing.Point(644, 5);
            this.lblpageDisplay.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblpageDisplay.Name = "lblpageDisplay";
            this.lblpageDisplay.Size = new System.Drawing.Size(0, 25);
            this.lblpageDisplay.TabIndex = 0;
            // 
            // NextIconPictureBox
            // 
            this.NextIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("NextIconPictureBox.Image")));
            this.NextIconPictureBox.Location = new System.Drawing.Point(720, 3);
            this.NextIconPictureBox.Name = "NextIconPictureBox";
            this.NextIconPictureBox.Size = new System.Drawing.Size(32, 32);
            this.NextIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.NextIconPictureBox.TabIndex = 0;
            this.NextIconPictureBox.TabStop = false;
            this.NextIconPictureBox.Click += new System.EventHandler(this.Next_Click);
            this.NextIconPictureBox.MouseLeave += new System.EventHandler(this.NextIconPictureBox_MouseLeave);
            this.NextIconPictureBox.MouseEnter += NextIconPictureBox_MouseHover;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 3);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1238, 599);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = global::PowerPointViewer.Properties.Resources.ppt__logo_WF;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1212, 656);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style.ForeColor = System.Drawing.Color.Transparent;
            this.Style.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(71)))), ((int)(((byte)(38)))));
            this.Style.TitleBar.CloseButtonForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Style.TitleBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Style.TitleBar.Height = 50;
            this.Style.TitleBar.MaximizeButtonForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.MinimizeButtonForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.TextHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text = "Presentation viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.centerSlideLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.centerSlidePictureBox)).EndInit();
            this.centerSlidePictureBox.ResumeLayout(false);
            this.operationsTableLayoutPanel.ResumeLayout(false);
            this.operationsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfConvertIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextIconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        private void printIconPictureBox_Leave(object sender, System.EventArgs e)
        {
            this.printIconPictureBox.Image = Properties.Resources.ppt__Print;
        }

        private void openIconPictureBox_Leave(object sender, System.EventArgs e)
        {
            this.openIconPictureBox.Image = Properties.Resources.ppt__open;
        }

        private void pdfConvertIconPictureBox_Leave(object sender, System.EventArgs e)
        {
            this.pdfConvertIconPictureBox.Image = Properties.Resources.ppt_pdf;
        }

        private void openIconPictureBox_MouseOver(object sender, System.EventArgs e)
        {
            this.openIconPictureBox.Image = Properties.Resources.ppt__open_copy;
        }

        private void printIconPictureBox_MouseOver(object sender, System.EventArgs e)
        {
            this.printIconPictureBox.Image = Properties.Resources.ppt__Print_copy;
        }

        private void pdfConvertIconPictureBox_MouseOver(object sender, System.EventArgs e)
        {
            this.pdfConvertIconPictureBox.Image = Properties.Resources.ppt_pdf_copy;
        }

        private void PreviousIconPictureBox_MouseHover(object sender, System.EventArgs e)
        {
            this.previousIconPictureBox.Image = Properties.Resources.ppt__back_copy;
        }

        private void NextIconPictureBox_MouseHover(object sender, System.EventArgs e)
        {
            this.NextIconPictureBox.Image = Properties.Resources.ppt__for_copy;
        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox centerSlidePictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox printIconPictureBox;
        private System.Windows.Forms.PictureBox openIconPictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pdfConvertIconPictureBox;
        private System.Windows.Forms.TableLayoutPanel operationsTableLayoutPanel;
        private System.Windows.Forms.PictureBox previousIconPictureBox;
        private System.Windows.Forms.Label lblpageDisplay;
        private System.Windows.Forms.Label loadingIndicatorPictureBox;
        private System.Windows.Forms.TableLayoutPanel centerSlideLayoutPanel;
        private System.Windows.Forms.PictureBox NextIconPictureBox;
    }
}

