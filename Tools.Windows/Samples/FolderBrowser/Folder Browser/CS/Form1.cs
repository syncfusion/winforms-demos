using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Syncfusion.Licensing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace FolderBrowserDemo
{
	public class frmFolderBrowser : MetroForm
	{
		private Syncfusion.Windows.Forms.FolderBrowser folderBrowser1;
		private System.Windows.Forms.Panel groupBox1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox1;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusBar statusBar1;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbShowShares;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbBrowseForEverything;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbBrowseForPrinter;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbBrowseForComputer;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbAllowUrls;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbNewDialogStyle;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbValidate;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbShowTextBox;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbRestrictToSubfolders;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbRestrictToDomain;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv cbRestrictToFilesystem;
		private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel groupBox3;
		private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private Label label5;
        private Label label6;
		private System.ComponentModel.IContainer components;

		public frmFolderBrowser()
		{
			InitializeComponent();		
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }


		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }


		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolderBrowser));
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.cbRestrictToFilesystem = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbRestrictToDomain = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbRestrictToSubfolders = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbShowTextBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbValidate = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbNewDialogStyle = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbAllowUrls = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbBrowseForComputer = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbBrowseForPrinter = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbBrowseForEverything = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbShowShares = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBox3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRestrictToFilesystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRestrictToDomain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRestrictToSubfolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbValidate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNewDialogStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAllowUrls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBrowseForComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBrowseForPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBrowseForEverything)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowShares)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
        
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Brown;
            this.groupBox1.Location = new System.Drawing.Point(37, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "Set Start Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Set Start Location:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Location:";
            // 
            // checkBox1
            // 
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(16, 72);
            this.checkBox1.MetroColor = System.Drawing.Color.Gray;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 16);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Custom Start Location";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.Location = new System.Drawing.Point(117, 40);
            this.comboBox1.MaxDropDownItems = 10;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(117, 101);
            this.textBox1.Metrocolor = System.Drawing.Color.Gray;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 21);
            this.textBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Custom Location:";
            this.label2.Visible = false;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(20, 553);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(766, 24);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 2;
            this.statusBar1.Text = "Folder Browser Demo";
            // 
            // cbRestrictToFilesystem
            // 
            this.cbRestrictToFilesystem.DrawFocusRectangle = false;
            this.cbRestrictToFilesystem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRestrictToFilesystem.ForeColor = System.Drawing.Color.Black;
            this.cbRestrictToFilesystem.Location = new System.Drawing.Point(62, 208);
            this.cbRestrictToFilesystem.MetroColor = System.Drawing.Color.Gray;
            this.cbRestrictToFilesystem.Name = "cbRestrictToFilesystem";
            this.cbRestrictToFilesystem.Size = new System.Drawing.Size(149, 17);
            this.cbRestrictToFilesystem.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbRestrictToFilesystem.TabIndex = 10;
            this.cbRestrictToFilesystem.Text = "Restrict To File System";
            this.cbRestrictToFilesystem.ThemesEnabled = false;
            this.cbRestrictToFilesystem.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbRestrictToDomain
            // 
            this.cbRestrictToDomain.DrawFocusRectangle = false;
            this.cbRestrictToDomain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRestrictToDomain.ForeColor = System.Drawing.Color.Black;
            this.cbRestrictToDomain.Location = new System.Drawing.Point(62, 148);
            this.cbRestrictToDomain.MetroColor = System.Drawing.Color.Gray;
            this.cbRestrictToDomain.Name = "cbRestrictToDomain";
            this.cbRestrictToDomain.Size = new System.Drawing.Size(130, 17);
            this.cbRestrictToDomain.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbRestrictToDomain.TabIndex = 9;
            this.cbRestrictToDomain.Text = "Restrict To Domain";
            this.cbRestrictToDomain.ThemesEnabled = false;
            this.cbRestrictToDomain.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbRestrictToSubfolders
            // 
            this.cbRestrictToSubfolders.DrawFocusRectangle = false;
            this.cbRestrictToSubfolders.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRestrictToSubfolders.ForeColor = System.Drawing.Color.Black;
            this.cbRestrictToSubfolders.Location = new System.Drawing.Point(62, 118);
            this.cbRestrictToSubfolders.MetroColor = System.Drawing.Color.Gray;
            this.cbRestrictToSubfolders.Name = "cbRestrictToSubfolders";
            this.cbRestrictToSubfolders.Size = new System.Drawing.Size(146, 17);
            this.cbRestrictToSubfolders.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbRestrictToSubfolders.TabIndex = 8;
            this.cbRestrictToSubfolders.Text = "Restrict To Subfolders";
            this.cbRestrictToSubfolders.ThemesEnabled = false;
            this.cbRestrictToSubfolders.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbShowTextBox
            // 
            this.cbShowTextBox.DrawFocusRectangle = false;
            this.cbShowTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowTextBox.ForeColor = System.Drawing.Color.Black;
            this.cbShowTextBox.Location = new System.Drawing.Point(62, 240);
            this.cbShowTextBox.MetroColor = System.Drawing.Color.Gray;
            this.cbShowTextBox.Name = "cbShowTextBox";
            this.cbShowTextBox.Size = new System.Drawing.Size(109, 17);
            this.cbShowTextBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbShowTextBox.TabIndex = 7;
            this.cbShowTextBox.Text = "Show TextBox";
            this.cbShowTextBox.ThemesEnabled = false;
            this.cbShowTextBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbValidate
            // 
            this.cbValidate.DrawFocusRectangle = false;
            this.cbValidate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbValidate.ForeColor = System.Drawing.Color.Black;
            this.cbValidate.Location = new System.Drawing.Point(62, 367);
            this.cbValidate.MetroColor = System.Drawing.Color.Gray;
            this.cbValidate.Name = "cbValidate";
            this.cbValidate.Size = new System.Drawing.Size(78, 17);
            this.cbValidate.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbValidate.TabIndex = 6;
            this.cbValidate.Text = "Validate";
            this.cbValidate.ThemesEnabled = false;
            this.cbValidate.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbNewDialogStyle
            // 
            this.cbNewDialogStyle.DrawFocusRectangle = false;
            this.cbNewDialogStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNewDialogStyle.ForeColor = System.Drawing.Color.Black;
            this.cbNewDialogStyle.Location = new System.Drawing.Point(62, 272);
            this.cbNewDialogStyle.MetroColor = System.Drawing.Color.Gray;
            this.cbNewDialogStyle.Name = "cbNewDialogStyle";
            this.cbNewDialogStyle.Size = new System.Drawing.Size(120, 17);
            this.cbNewDialogStyle.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbNewDialogStyle.TabIndex = 5;
            this.cbNewDialogStyle.Text = "New Dialog Style";
            this.cbNewDialogStyle.ThemesEnabled = false;
            this.cbNewDialogStyle.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbAllowUrls
            // 
            this.cbAllowUrls.DrawFocusRectangle = false;
            this.cbAllowUrls.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllowUrls.ForeColor = System.Drawing.Color.Black;
            this.cbAllowUrls.Location = new System.Drawing.Point(62, 336);
            this.cbAllowUrls.MetroColor = System.Drawing.Color.Gray;
            this.cbAllowUrls.Name = "cbAllowUrls";
            this.cbAllowUrls.Size = new System.Drawing.Size(86, 17);
            this.cbAllowUrls.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbAllowUrls.TabIndex = 4;
            this.cbAllowUrls.Text = "Allow Urls";
            this.cbAllowUrls.ThemesEnabled = false;
            this.cbAllowUrls.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbBrowseForComputer
            // 
            this.cbBrowseForComputer.DrawFocusRectangle = false;
            this.cbBrowseForComputer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrowseForComputer.ForeColor = System.Drawing.Color.Black;
            this.cbBrowseForComputer.Location = new System.Drawing.Point(62, 88);
            this.cbBrowseForComputer.MetroColor = System.Drawing.Color.Gray;
            this.cbBrowseForComputer.Name = "cbBrowseForComputer";
            this.cbBrowseForComputer.Size = new System.Drawing.Size(158, 17);
            this.cbBrowseForComputer.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbBrowseForComputer.TabIndex = 3;
            this.cbBrowseForComputer.Text = "Browse For Computer";
            this.cbBrowseForComputer.ThemesEnabled = false;
            this.cbBrowseForComputer.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbBrowseForPrinter
            // 
            this.cbBrowseForPrinter.DrawFocusRectangle = false;
            this.cbBrowseForPrinter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrowseForPrinter.ForeColor = System.Drawing.Color.Black;
            this.cbBrowseForPrinter.Location = new System.Drawing.Point(62, 305);
            this.cbBrowseForPrinter.MetroColor = System.Drawing.Color.Gray;
            this.cbBrowseForPrinter.Name = "cbBrowseForPrinter";
            this.cbBrowseForPrinter.Size = new System.Drawing.Size(129, 17);
            this.cbBrowseForPrinter.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbBrowseForPrinter.TabIndex = 2;
            this.cbBrowseForPrinter.Text = "Browse For Printer";
            this.cbBrowseForPrinter.ThemesEnabled = false;
            this.cbBrowseForPrinter.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbBrowseForEverything
            // 
            this.cbBrowseForEverything.DrawFocusRectangle = false;
            this.cbBrowseForEverything.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrowseForEverything.ForeColor = System.Drawing.Color.Black;
            this.cbBrowseForEverything.Location = new System.Drawing.Point(62, 178);
            this.cbBrowseForEverything.MetroColor = System.Drawing.Color.Gray;
            this.cbBrowseForEverything.Name = "cbBrowseForEverything";
            this.cbBrowseForEverything.Size = new System.Drawing.Size(149, 17);
            this.cbBrowseForEverything.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbBrowseForEverything.TabIndex = 1;
            this.cbBrowseForEverything.Text = "Browse For Everything";
            this.cbBrowseForEverything.ThemesEnabled = false;
            this.cbBrowseForEverything.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbShowShares
            // 
            this.cbShowShares.DrawFocusRectangle = false;
            this.cbShowShares.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowShares.ForeColor = System.Drawing.Color.Black;
            this.cbShowShares.Location = new System.Drawing.Point(62, 60);
            this.cbShowShares.MetroColor = System.Drawing.Color.Gray;
            this.cbShowShares.Name = "cbShowShares";
            this.cbShowShares.Size = new System.Drawing.Size(146, 17);
            this.cbShowShares.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbShowShares.TabIndex = 0;
            this.cbShowShares.Text = "Show Admin Shares";
            this.cbShowShares.ThemesEnabled = false;
            this.cbShowShares.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonAdv1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Brown;
            this.groupBox3.Location = new System.Drawing.Point(37, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 183);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.Text = "Folder Browser";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "The Folder Browser is intended to provide a convinient browsing to files and fold" +
    "ers";
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.Black;
            this.buttonAdv1.Location = new System.Drawing.Point(137, 107);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(128, 21);
            this.buttonAdv1.TabIndex = 0;
            this.buttonAdv1.Text = "Show FolderBrowser";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.cmdShowBrowser_Click);
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.IsSplitterFixed = true;
            this.splitContainerAdv1.Location = new System.Drawing.Point(20, 13);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.label6);
            this.splitContainerAdv1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerAdv1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.AutoSize = true;
            this.splitContainerAdv1.Panel2.Controls.Add(this.label5);
            this.splitContainerAdv1.Panel2.Controls.Add(this.cbRestrictToFilesystem);
            this.splitContainerAdv1.Panel2.Controls.Add(this.cbShowShares);
            this.splitContainerAdv1.Panel2.Controls.Add(this.cbAllowUrls);
            this.splitContainerAdv1.Panel2.Controls.Add(this.cbRestrictToDomain);
            this.splitContainerAdv1.Panel2.Controls.Add(this.cbBrowseForComputer);
            this.splitContainerAdv1.Panel2.Controls.Add(this.cbNewDialogStyle);
            this.splitContainerAdv1.Panel2.Controls.Add(this.cbRestrictToSubfolders);
            this.splitContainerAdv1.Panel2.Controls.Add(this.cbBrowseForPrinter);
            this.splitContainerAdv1.Panel2.Controls.Add(this.cbValidate);
            this.splitContainerAdv1.Panel2.Controls.Add(this.cbShowTextBox);
            this.splitContainerAdv1.Panel2.Controls.Add(this.cbBrowseForEverything);
            this.splitContainerAdv1.Panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerAdv1.Size = new System.Drawing.Size(766, 542);
            this.splitContainerAdv1.SplitterDistance = 493;
            this.splitContainerAdv1.TabIndex = 7;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(491, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sample";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Properties";
            // 
            // frmFolderBrowser
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 597);
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.statusBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(818, 629);
            this.Name = "frmFolderBrowser";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Browser Demo";
            this.Load += new System.EventHandler(this.frmFolderBrowser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRestrictToFilesystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRestrictToDomain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRestrictToSubfolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbValidate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNewDialogStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAllowUrls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBrowseForComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBrowseForPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBrowseForEverything)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowShares)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.splitContainerAdv1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new frmFolderBrowser());
		}

		private void frmFolderBrowser_Load(object sender, System.EventArgs e)
		{
            this.folderBrowser1 = new Syncfusion.Windows.Forms.FolderBrowser(this.components);
            // folderBrowser1
            // 
            this.folderBrowser1.FolderBrowserCallback += new Syncfusion.Windows.Forms.FolderBrowserCallbackEventHandler(this.folderBrowser1_FolderBrowserCallback);
            // 
			// To Populate the ComboxBox1 with the Folder Path.
			this.comboBox1.Items.AddRange(new string[] {
														   "Desktop Directory", "My Computer", "My Documents", "Desktop", "Internet", "Programs", "Control Panel",
														   "Printers", "Personal","Favorites","Startup", "Recent", "Send To", "Recycle Bin", "Start Menu", "My Music",
														   "My Video", "Network Neighborhood", "NetHood", "Fonts", "Templates", "My Pictures", "Common Documents", 
														   "Common Admin Tools", "Net And DialUp Connections", "Common Music", "Common Pictures", 
														   "Common Video", "Resources", "CD Burn Area", "Computers Near Me"});
			
			this.folderBrowser1.StartLocation = Syncfusion.Windows.Forms.FolderBrowserFolder.Desktop;
			this.folderBrowser1.Description = "This is the Demo of Syncfusion FolderBrowser Control.";
			this.comboBox1.SelectedIndex = 3;
		}

		private void cmdShowBrowser_Click(object sender, System.EventArgs e)
		{
			if(textBox1.Visible == true || textBox1.Text.Trim().Length>0)
			{
				//If this check is omitted FolderBrowser will display its own Error Message.
				if(!Directory.Exists(textBox1.Text.Trim()))
				{
					MessageBox.Show("Kindly Check the Path.");
					return;
				}
				this.folderBrowser1.CustomStartLocation = textBox1.Text;
				this.folderBrowser1.StartLocation = FolderBrowserFolder.CustomStartLocation;
			}

			// To reset the StartLocation after using CustomStartLocation.
			if(checkBox1.Checked == false)
				comboBox1_SelectionChangeCommitted(sender,e);

			if( folderBrowser1.ShowDialog()== DialogResult.OK)
				this.statusBar1.Text = folderBrowser1.DirectoryPath;
		}

		private void comboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			#region Set Folder Browser StartLocation
			switch(comboBox1.Items[comboBox1.SelectedIndex].ToString())
			{
				case "Recycle Bin":
					folderBrowser1.StartLocation = FolderBrowserFolder.BitBucket;
					break;
				case "CD Burn Area":
					folderBrowser1.StartLocation = FolderBrowserFolder.CDBurnArea;
					break;
				case "Common Admin Tools":
					folderBrowser1.StartLocation = FolderBrowserFolder.CommonAdminTools;
					break;
				case "Common Documents":
					folderBrowser1.StartLocation = FolderBrowserFolder.CommonDocuments;
					break;	
				case "Common Music":
					folderBrowser1.StartLocation = FolderBrowserFolder.CommonMusic;
					break;	
				case "Common Pictures":
					folderBrowser1.StartLocation = FolderBrowserFolder.CommonPictures ;
					break;
				case "Common Video":
					folderBrowser1.StartLocation = FolderBrowserFolder.CommonVideo;
					break;
				case "Computers Near Me":
					folderBrowser1.StartLocation = FolderBrowserFolder.ComputersNearMe;
					break;
				case "Control Panel":
					folderBrowser1.StartLocation = FolderBrowserFolder.Controls;
					break;
				case "Desktop":
					folderBrowser1.StartLocation = FolderBrowserFolder.Desktop;
					break;
				case "Desktop Directory":
					folderBrowser1.StartLocation = FolderBrowserFolder.DesktopDirectory;
					break;
				case "Favorites":
					folderBrowser1.StartLocation = FolderBrowserFolder.Favorites;
					break;
				case "Fonts":
					folderBrowser1.StartLocation = FolderBrowserFolder.Fonts;
					break;
				case "Internet":
					folderBrowser1.StartLocation = FolderBrowserFolder.Internet;
					break;
				case "My Computer":
					folderBrowser1.StartLocation = FolderBrowserFolder.MyComputer;
					break;
				case "My Documents":
					folderBrowser1.StartLocation = FolderBrowserFolder.MyDocuments;
					break;
				case "My Music":
					folderBrowser1.StartLocation = FolderBrowserFolder.MyMusic;
					break;
				case "My Pictures":
					folderBrowser1.StartLocation = FolderBrowserFolder.MyPictures;
					break;
				case "My Video":
					folderBrowser1.StartLocation = FolderBrowserFolder.MyVideo;
					break;
				case "Net And DialUp Connections":
					folderBrowser1.StartLocation = FolderBrowserFolder.NetAndDialUpConnections;
					break;
				case "Net Hood":
					folderBrowser1.StartLocation = FolderBrowserFolder.NetHood;
					break;
				case "Network Neighborhood":
					folderBrowser1.StartLocation = FolderBrowserFolder.NetworkNeighborhood;
					break;
				case "Personal":
					folderBrowser1.StartLocation = FolderBrowserFolder.Personal;
					break;
				case "Printers":
					folderBrowser1.StartLocation = FolderBrowserFolder.Printers;
					break;
				case "Programs":
					folderBrowser1.StartLocation = FolderBrowserFolder.Programs;
					break;
				case "Recent":
					folderBrowser1.StartLocation = FolderBrowserFolder.Recent;
					break;
				case "Resources":
					folderBrowser1.StartLocation = FolderBrowserFolder.Resources;
					break;
				case "Send To":
					folderBrowser1.StartLocation = FolderBrowserFolder.SendTo;
					break;
				case "Start Menu":
					folderBrowser1.StartLocation = FolderBrowserFolder.StartMenu;
					break;
				case "Startup":
					folderBrowser1.StartLocation = FolderBrowserFolder.Startup;
					break;
				case "Templates":
					folderBrowser1.StartLocation = FolderBrowserFolder.Templates;
					break;
			}
			#endregion
		}

		// Event handler for the FolderBrowser.FolderBrowserCallback validation event.
		// This handler is functionally equivalent of the Win32 BrowseCallbackProc callback function.
		private void folderBrowser1_FolderBrowserCallback(object sender, Syncfusion.Windows.Forms.FolderBrowserCallbackEventArgs e)
		{
			this.statusBar1.Text = String.Format("Event: {0}, Path: {1}", e.FolderBrowserMessage, e.Path);
			if (e.FolderBrowserMessage == FolderBrowserMessage.ValidateFailed)
			{
				e.Dismiss = e.Path != "NONE";
			}
		}

		private void checkBox_CheckedChanged(object sender, System.EventArgs e)
		{
			this.SetFolderBrowserStyles(sender as CheckBoxAdv);		
		}

		private void SetFolderBrowserStyles(CheckBoxAdv cbselected)
		{
			#region Apply FolderBrowserStyles
			switch(cbselected.Text)
			{
				case "Restrict To File System":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.RestrictToFilesystem;
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.RestrictToFilesystem;
					break;
				case "Restrict To Domain":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.RestrictToDomain;
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.RestrictToDomain;
					break;
				case "Restrict To Subfolders":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.RestrictToSubfolders;
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.RestrictToSubfolders;
					break;
				case "Show TextBox":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.ShowTextBox;
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.ShowTextBox;
					break;
				case "Validate":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.Validate;
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.Validate;
					break;
				case "New Dialog Style":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.NewDialogStyle;
					else
					{
						this.folderBrowser1.Style &= ~FolderBrowserStyles.AllowUrls;
						this.cbAllowUrls.Checked = false;
						this.folderBrowser1.Style &= ~FolderBrowserStyles.ShowAdministrativeShares;
						this.cbShowShares.Checked = false;
						this.folderBrowser1.Style &= ~FolderBrowserStyles.NewDialogStyle;
						
					}
					break;
				case "Allow Urls":
					if(cbselected.Checked == true)
					{
						this.folderBrowser1.Style |= FolderBrowserStyles.AllowUrls|FolderBrowserStyles.NewDialogStyle;
						this.cbNewDialogStyle.Checked = true;
					}
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.AllowUrls;
					break;
				case "Browse For Computer":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.BrowseForComputer;
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.BrowseForComputer;
					break;
				case "Browse For Printer":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.BrowseForPrinter;
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.BrowseForPrinter;
					break;
				case "Browse For Everything":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.BrowseForEverything;
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.BrowseForEverything;
					break;
				case "Show Admin Shares":
					if(cbselected.Checked == true)
					{
						this.folderBrowser1.Style |= FolderBrowserStyles.ShowAdministrativeShares|FolderBrowserStyles.NewDialogStyle;
						this.cbNewDialogStyle.Checked = true;
					}
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.ShowAdministrativeShares;
					break;
			}
		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
            textBox1.Text = string.Empty;
			textBox1.Visible = checkBox1.Checked;
			label2.Visible = checkBox1.Checked;

			comboBox1.Enabled = ! checkBox1.Checked;
			textBox1.Focus();
		}
	}

    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {
        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }

}
