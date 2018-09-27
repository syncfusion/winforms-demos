using System.Drawing;
using System.Windows.Forms;

namespace GettingStarted
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
            this.components = new System.ComponentModel.Container();
            this.trackBarEx1 = new Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 10);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBorderColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonBottom = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonMiddle = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonTop = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRight = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonCenter = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonLeft = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCaptionButtonForeColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnCaptionButtonBackColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnCaptionForeColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.btnCaptionBackColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxHelpButton = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxIcon = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonTop)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonLeft)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxHelpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarEx1
            // 
            this.trackBarEx1.BackColor = System.Drawing.Color.White;
            this.trackBarEx1.BeforeTouchSize = new System.Drawing.Size(134, 20);
            this.trackBarEx1.DecreaseButtonSize = new System.Drawing.Size(0, 0);
            this.trackBarEx1.IncreaseButtonSize = new System.Drawing.Size(0, 0);
            this.trackBarEx1.Location = new System.Drawing.Point(25, 81);
            this.trackBarEx1.Name = "trackBarEx1";
            this.trackBarEx1.ShowButtons = false;
            this.trackBarEx1.Size = new System.Drawing.Size(134, 20);
            this.trackBarEx1.SmallChange = 2;
            this.trackBarEx1.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro;
            this.trackBarEx1.TabIndex = 0;
            this.trackBarEx1.Text = "trackBarEx1";
            this.trackBarEx1.TimerInterval = 100;
            this.trackBarEx1.Value = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBorderColor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBarEx1);
            this.panel1.Location = new System.Drawing.Point(484, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 191);
            this.panel1.TabIndex = 1;
            // 
            // btnBorderColor
            // 
            this.btnBorderColor.BeforeTouchSize = new System.Drawing.Size(134, 36);
            this.btnBorderColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnBorderColor.IsBackStageButton = false;
            this.btnBorderColor.Location = new System.Drawing.Point(25, 119);
            this.btnBorderColor.Name = "btnBorderColor";
            this.btnBorderColor.Size = new System.Drawing.Size(134, 36);
            this.btnBorderColor.TabIndex = 3;
            this.btnBorderColor.Text = "Border Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thickness";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Border customization";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnCaptionButtonForeColor);
            this.panel2.Controls.Add(this.btnCaptionButtonBackColor);
            this.panel2.Controls.Add(this.btnCaptionForeColor);
            this.panel2.Controls.Add(this.btnCaptionBackColor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(49, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 324);
            this.panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonBottom);
            this.groupBox2.Controls.Add(this.radioButtonMiddle);
            this.groupBox2.Controls.Add(this.radioButtonTop);
            this.groupBox2.Location = new System.Drawing.Point(198, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 127);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vertical";
            // 
            // radioButtonBottom
            // 
            this.radioButtonBottom.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButtonBottom.DrawFocusRectangle = false;
            this.radioButtonBottom.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonBottom.Location = new System.Drawing.Point(8, 82);
            this.radioButtonBottom.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButtonBottom.Name = "radioButtonBottom";
            this.radioButtonBottom.Size = new System.Drawing.Size(150, 21);
            this.radioButtonBottom.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonBottom.TabIndex = 2;
            this.radioButtonBottom.TabStop = false;
            this.radioButtonBottom.Text = "Bottom";
            this.radioButtonBottom.ThemesEnabled = false;
            this.radioButtonBottom.CheckChanged += new System.EventHandler(this.radioButtonBottom_CheckChanged);
            // 
            // radioButtonMiddle
            // 
            this.radioButtonMiddle.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButtonMiddle.Checked = true;
            this.radioButtonMiddle.DrawFocusRectangle = false;
            this.radioButtonMiddle.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonMiddle.Location = new System.Drawing.Point(8, 55);
            this.radioButtonMiddle.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButtonMiddle.Name = "radioButtonMiddle";
            this.radioButtonMiddle.Size = new System.Drawing.Size(150, 21);
            this.radioButtonMiddle.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonMiddle.TabIndex = 1;
            this.radioButtonMiddle.Text = "Center";
            this.radioButtonMiddle.ThemesEnabled = false;
            this.radioButtonMiddle.CheckChanged += new System.EventHandler(this.radioButtonMiddle_CheckChanged);
            // 
            // radioButtonTop
            // 
            this.radioButtonTop.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButtonTop.DrawFocusRectangle = false;
            this.radioButtonTop.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonTop.Location = new System.Drawing.Point(8, 28);
            this.radioButtonTop.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButtonTop.Name = "radioButtonTop";
            this.radioButtonTop.Size = new System.Drawing.Size(150, 21);
            this.radioButtonTop.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonTop.TabIndex = 0;
            this.radioButtonTop.TabStop = false;
            this.radioButtonTop.Text = "Top";
            this.radioButtonTop.ThemesEnabled = false;
            this.radioButtonTop.CheckChanged += new System.EventHandler(this.radioButtonTop_CheckChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRight);
            this.groupBox1.Controls.Add(this.radioButtonCenter);
            this.groupBox1.Controls.Add(this.radioButtonLeft);
            this.groupBox1.Location = new System.Drawing.Point(16, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 127);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horizontal";
            // 
            // radioButtonRight
            // 
            this.radioButtonRight.BeforeTouchSize = new System.Drawing.Size(150, 27);
            this.radioButtonRight.DrawFocusRectangle = false;
            this.radioButtonRight.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonRight.Location = new System.Drawing.Point(6, 76);
            this.radioButtonRight.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.Size = new System.Drawing.Size(150, 27);
            this.radioButtonRight.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonRight.TabIndex = 10;
            this.radioButtonRight.TabStop = false;
            this.radioButtonRight.Text = "Right";
            this.radioButtonRight.ThemesEnabled = false;
            this.radioButtonRight.CheckChanged += new System.EventHandler(this.radioButtonRight_CheckChanged_1);
            // 
            // radioButtonCenter
            // 
            this.radioButtonCenter.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButtonCenter.DrawFocusRectangle = false;
            this.radioButtonCenter.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonCenter.Location = new System.Drawing.Point(6, 55);
            this.radioButtonCenter.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButtonCenter.Name = "radioButtonCenter";
            this.radioButtonCenter.Size = new System.Drawing.Size(150, 21);
            this.radioButtonCenter.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonCenter.TabIndex = 9;
            this.radioButtonCenter.TabStop = false;
            this.radioButtonCenter.Text = "Center";
            this.radioButtonCenter.ThemesEnabled = false;
            this.radioButtonCenter.CheckChanged += new System.EventHandler(this.radioButtonCenter_CheckChanged_1);
            // 
            // radioButtonLeft
            // 
            this.radioButtonLeft.BeforeTouchSize = new System.Drawing.Size(150, 31);
            this.radioButtonLeft.Checked = true;
            this.radioButtonLeft.DrawFocusRectangle = false;
            this.radioButtonLeft.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonLeft.Location = new System.Drawing.Point(6, 28);
            this.radioButtonLeft.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.Size = new System.Drawing.Size(150, 31);
            this.radioButtonLeft.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonLeft.TabIndex = 8;
            this.radioButtonLeft.Text = "Left";
            this.radioButtonLeft.ThemesEnabled = false;
            this.radioButtonLeft.CheckChanged += new System.EventHandler(this.radioButtonLeft_CheckChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Captio alignment";
            // 
            // btnCaptionButtonForeColor
            // 
            this.btnCaptionButtonForeColor.BeforeTouchSize = new System.Drawing.Size(189, 36);
            this.btnCaptionButtonForeColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnCaptionButtonForeColor.IsBackStageButton = false;
            this.btnCaptionButtonForeColor.Location = new System.Drawing.Point(167, 96);
            this.btnCaptionButtonForeColor.Name = "btnCaptionButtonForeColor";
            this.btnCaptionButtonForeColor.Size = new System.Drawing.Size(189, 36);
            this.btnCaptionButtonForeColor.TabIndex = 4;
            this.btnCaptionButtonForeColor.Text = "Button ForeColor";
            // 
            // btnCaptionButtonBackColor
            // 
            this.btnCaptionButtonBackColor.BeforeTouchSize = new System.Drawing.Size(189, 36);
            this.btnCaptionButtonBackColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnCaptionButtonBackColor.IsBackStageButton = false;
            this.btnCaptionButtonBackColor.Location = new System.Drawing.Point(167, 55);
            this.btnCaptionButtonBackColor.Name = "btnCaptionButtonBackColor";
            this.btnCaptionButtonBackColor.Size = new System.Drawing.Size(189, 36);
            this.btnCaptionButtonBackColor.TabIndex = 3;
            this.btnCaptionButtonBackColor.Text = "Button HoverBackColor";
            // 
            // btnCaptionForeColor
            // 
            this.btnCaptionForeColor.BeforeTouchSize = new System.Drawing.Size(143, 36);
            this.btnCaptionForeColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnCaptionForeColor.IsBackStageButton = false;
            this.btnCaptionForeColor.Location = new System.Drawing.Point(7, 96);
            this.btnCaptionForeColor.Name = "btnCaptionForeColor";
            this.btnCaptionForeColor.Size = new System.Drawing.Size(143, 36);
            this.btnCaptionForeColor.TabIndex = 2;
            this.btnCaptionForeColor.Text = "ForeColor";
            // 
            // btnCaptionBackColor
            // 
            this.btnCaptionBackColor.BeforeTouchSize = new System.Drawing.Size(143, 36);
            this.btnCaptionBackColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.btnCaptionBackColor.IsBackStageButton = false;
            this.btnCaptionBackColor.Location = new System.Drawing.Point(7, 55);
            this.btnCaptionBackColor.Name = "btnCaptionBackColor";
            this.btnCaptionBackColor.Size = new System.Drawing.Size(143, 36);
            this.btnCaptionBackColor.TabIndex = 1;
            this.btnCaptionBackColor.Text = "BackColor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title bar customization";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.checkBoxHelpButton);
            this.panel3.Controls.Add(this.checkBoxIcon);
            this.panel3.Location = new System.Drawing.Point(484, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 116);
            this.panel3.TabIndex = 3;
            // 
            // checkBoxHelpButton
            // 
            this.checkBoxHelpButton.BeforeTouchSize = new System.Drawing.Size(175, 21);
            this.checkBoxHelpButton.Checked = true;
            this.checkBoxHelpButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHelpButton.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBoxHelpButton.Location = new System.Drawing.Point(25, 64);
            this.checkBoxHelpButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxHelpButton.Name = "checkBoxHelpButton";
            this.checkBoxHelpButton.Size = new System.Drawing.Size(175, 21);
            this.checkBoxHelpButton.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxHelpButton.TabIndex = 2;
            this.checkBoxHelpButton.Text = "Show help button";
            this.checkBoxHelpButton.ThemesEnabled = false;
            this.checkBoxHelpButton.CheckStateChanged += new System.EventHandler(this.checkBoxHelpButton_CheckStateChanged);
            // 
            // checkBoxIcon
            // 
            this.checkBoxIcon.BeforeTouchSize = new System.Drawing.Size(231, 21);
            this.checkBoxIcon.Checked = true;
            this.checkBoxIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIcon.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBoxIcon.Location = new System.Drawing.Point(25, 26);
            this.checkBoxIcon.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxIcon.Name = "checkBoxIcon";
            this.checkBoxIcon.Size = new System.Drawing.Size(231, 21);
            this.checkBoxIcon.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxIcon.TabIndex = 1;
            this.checkBoxIcon.Text = "Show form icon in title bar";
            this.checkBoxIcon.ThemesEnabled = false;
            this.checkBoxIcon.CheckStateChanged += new System.EventHandler(this.checkBoxIcon_CheckStateChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(559, 61);
            this.label5.TabIndex = 6;
            this.label5.Text = "SfForm provides options to customize the appearance of each elements of the form " +
    "such as TitlBar and Border. This sample showcases some basic customizations.";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(827, 540);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Style.Border.Width = 3;
            this.Style.Border.Color = ColorTranslator.FromHtml("#0AA2E6");
            this.Style.InactiveBorder.Width = 3;
            this.Style.InactiveBorder.Color = ColorTranslator.FromHtml("#0AA2E6");
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(800, 525);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.BackColor = System.Drawing.SystemColors.Window;
            this.Text = "Getting Started";

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonTop)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonLeft)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxHelpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TrackBarEx trackBarEx1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Syncfusion.Windows.Forms.ColorPickerButton btnBorderColor;
        private System.ComponentModel.IContainer components;
        private Panel panel2;
        private Syncfusion.Windows.Forms.ColorPickerButton btnCaptionForeColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnCaptionBackColor;
        private Label label3;
        private Syncfusion.Windows.Forms.ColorPickerButton btnCaptionButtonBackColor;
        private Syncfusion.Windows.Forms.ColorPickerButton btnCaptionButtonForeColor;
        private Label label4;
        private GroupBox groupBox2;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonBottom;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonMiddle;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonTop;
        private GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonRight;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonCenter;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonLeft;
        private Panel panel3;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxIcon;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxHelpButton;
        private Label label5;
    }
}

