using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;

namespace OutlookDemo
{
	/// <summary>
	/// Summary description for FormatColumnsDialog.
	/// </summary>
	public class FormatColumnsDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
		private Syncfusion.Windows.Forms.Tools.XPTaskBar xpTaskBar1;
		private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox1;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
		private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton2;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		GridGroupingControl groupingGrid;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnDelete;
		GridColumnDescriptorCollection descColl;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormatColumnsDialog(GridGroupingControl grid)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.groupingGrid=grid;
			descColl=new GridColumnDescriptorCollection();
			for (int i = 1; i < this.groupingGrid.TableDescriptor.VisibleColumns.Count; i++)
			{
				GridVisibleColumnDescriptor col = this.groupingGrid.TableDescriptor.VisibleColumns[i];
				if (col != null)
				{
					this.comboBox1.Items.Add(col.Name);
				}
			}
			this.listBox1.SelectedIndexChanged+=new EventHandler(listBox1_SelectedIndexChanged);
            this.colorPickerButton1.ColorSelected+=new EventHandler(colorPickerButton1_ColorSelected);
			this.colorPickerButton2.ColorSelected+=new EventHandler(colorPickerButton2_ColorSelected);

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xpTaskBar1 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.xpTaskBarBox1 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).BeginInit();
            this.xpTaskBar1.SuspendLayout();
            this.xpTaskBarBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select  Field:";
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Left";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(80, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 16);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Center";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(152, 16);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(56, 16);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.Text = "Right";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.tabControlAdv1.BackColor = System.Drawing.Color.White;
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(256, 104);
            this.tabControlAdv1.TabIndex = 8;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2003);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.tabPageAdv1.Controls.Add(this.groupBox1);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 32);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.Size = new System.Drawing.Size(254, 71);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Font";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 48);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Style";
            // 
            // checkBox3
            // 
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(128, 16);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Underline";
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(72, 16);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(56, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Italic";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(8, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Bold";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.tabPageAdv2.Controls.Add(this.colorPickerButton2);
            this.tabPageAdv2.Controls.Add(this.colorPickerButton1);
            this.tabPageAdv2.Controls.Add(this.label7);
            this.tabPageAdv2.Controls.Add(this.label6);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 32);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.Size = new System.Drawing.Size(254, 71);
            this.tabPageAdv2.TabIndex = 1;
            this.tabPageAdv2.Text = "Color";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.BackColor = System.Drawing.SystemColors.Control;
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton2.Location = new System.Drawing.Point(96, 40);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton2.Size = new System.Drawing.Size(152, 24);
            this.colorPickerButton2.TabIndex = 3;
            this.colorPickerButton2.Text = "None";
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.SystemColors.Control;
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton1.Location = new System.Drawing.Point(96, 8);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton1.Size = new System.Drawing.Size(152, 24);
            this.colorPickerButton1.TabIndex = 2;
            this.colorPickerButton1.Text = "None";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Background:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Text:";
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.tabPageAdv3.Controls.Add(this.groupBox2);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 32);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.Size = new System.Drawing.Size(254, 71);
            this.tabPageAdv3.TabIndex = 2;
            this.tabPageAdv3.Text = "Alignment";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 48);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Align";
            // 
            // xpTaskBar1
            // 
            this.xpTaskBar1.AutoPersistStates = true;
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox1);
            this.xpTaskBar1.Enabled = false;
            this.xpTaskBar1.Location = new System.Drawing.Point(8, 56);
            this.xpTaskBar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar1.Name = "xpTaskBar1";
            this.xpTaskBar1.Size = new System.Drawing.Size(264, 136);
            this.xpTaskBar1.TabIndex = 8;
            // 
            // xpTaskBarBox1
            // 
            this.xpTaskBarBox1.Controls.Add(this.gradientPanel1);
            this.xpTaskBarBox1.HeaderBackColor = System.Drawing.Color.Silver;
            this.xpTaskBarBox1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.xpTaskBarBox1.HeaderImageIndex = -1;
            this.xpTaskBarBox1.HitTaskBoxArea = false;
            this.xpTaskBarBox1.ItemBackColor = System.Drawing.Color.AliceBlue;
            this.xpTaskBarBox1.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBarBox1.Name = "xpTaskBarBox1";
            this.xpTaskBarBox1.PreferredChildPanelHeight = 110;
            this.xpTaskBarBox1.Size = new System.Drawing.Size(264, 140);
            this.xpTaskBarBox1.TabIndex = 0;
            this.xpTaskBarBox1.Text = "Appearance";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
            this.gradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.gradientPanel1.Controls.Add(this.tabControlAdv1);
            this.gradientPanel1.Location = new System.Drawing.Point(2, 28);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(260, 110);
            this.gradientPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.xpTaskBar1);
            this.groupBox3.Location = new System.Drawing.Point(144, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 200);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(104, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "(none)";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Formats Created";
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(8, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 199);
            this.listBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(272, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(360, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 240);
            this.panel1.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(224, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNew.Location = new System.Drawing.Point(144, 8);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FormatColumnsDialog
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(450, 288);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormatColumnsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Format Columns";
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPageAdv2.ResumeLayout(false);
            this.tabPageAdv3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).EndInit();
            this.xpTaskBar1.ResumeLayout(false);
            this.xpTaskBarBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.listBox1.SelectedItem != null)
			{
				this.xpTaskBar1.Enabled=true;
				foreach(GridColumnDescriptor des in descColl)
				{
					if(des.Name.CompareTo(this.listBox1.SelectedItem.ToString())==0)
					{
						if(des!=null)
						{
							this.checkBox1.Checked=des.Appearance.AnyRecordFieldCell.Font.Bold;
							this.checkBox2.Checked=des.Appearance.AnyRecordFieldCell.Font.Italic;
							this.checkBox3.Checked=des.Appearance.AnyRecordFieldCell.Font.Underline;

							this.colorPickerButton1.SelectedColor=des.Appearance.AnyRecordFieldCell.TextColor;
							this.colorPickerButton2.SelectedColor=des.Appearance.AnyRecordFieldCell.BackColor;

							if(des.Appearance.AnyRecordFieldCell.HorizontalAlignment==GridHorizontalAlignment.Left)
								this.radioButton1.Checked=true;
							else if(des.Appearance.AnyRecordFieldCell.HorizontalAlignment==GridHorizontalAlignment.Center)
								this.radioButton2.Checked=true;
							else
								this.radioButton3.Checked=true;
						}
					}
				}
			}
			else
				this.xpTaskBar1.Enabled=false;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			foreach(GridColumnDescriptor des in descColl)
			{
				if(des!=null)
				{
					GridColumnDescriptor temp=groupingGrid.TableDescriptor.Columns.FindByMappingName(des.Name);
					temp.Appearance.AnyRecordFieldCell=des.Appearance.AnyRecordFieldCell;
				}
			}
		}
		

		private void btnNew_Click(object sender, System.EventArgs e)
		{
			if(this.comboBox1.SelectedItem==null)
				MessageBox.Show("Select a field");
			else
			{
				string descName=this.comboBox1.SelectedItem.ToString();
				bool flag=false;
				foreach(GridColumnDescriptor des in descColl)
				{
					if(des.Name.CompareTo(descName)==0)
					{
						flag=true;
						break;
					}
				}
				if(!flag)
				{
					GridColumnDescriptor desc1=new GridColumnDescriptor(descName);
					descColl.Add(desc1);
					this.listBox1.Items.Add(desc1.Name);
				}
				else
				{
					MessageBox.Show("Selected Field has already been added");
				}
			}
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if(this.listBox1.SelectedItem!=null)
			{
				string temp=this.listBox1.SelectedItem.ToString();
				foreach(GridColumnDescriptor des in descColl)
				{
					if(des.Name.CompareTo(temp)==0)
					{
						descColl.Remove(temp);
						break;
					}
				}
				this.listBox1.Items.Remove(temp);
			}
			else
				MessageBox.Show("Select a field");
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.listBox1.SelectedItem!=null)
			{
				string temp=this.listBox1.SelectedItem.ToString();
				GridColumnDescriptor tDesc=descColl[temp];
				if(checkBox1.Checked)
					tDesc.Appearance.AnyRecordFieldCell.Font.Bold=true;
				else
					tDesc.Appearance.AnyRecordFieldCell.Font.Bold=false;
			}
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.listBox1.SelectedItem!=null)
			{
				string temp=this.listBox1.SelectedItem.ToString();
				GridColumnDescriptor tDesc=descColl[temp];
				if(checkBox2.Checked)
					tDesc.Appearance.AnyRecordFieldCell.Font.Italic=true;
				else
					tDesc.Appearance.AnyRecordFieldCell.Font.Italic=false;
			}
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.listBox1.SelectedItem!=null)
			{
				string temp=this.listBox1.SelectedItem.ToString();
				GridColumnDescriptor tDesc=descColl[temp];
				if(checkBox3.Checked)
					tDesc.Appearance.AnyRecordFieldCell.Font.Underline=true;
				else
					tDesc.Appearance.AnyRecordFieldCell.Font.Underline=false;
			}
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.listBox1.SelectedItem!=null)
			{
				string temp=this.listBox1.SelectedItem.ToString();
				GridColumnDescriptor tDesc=descColl[temp];
				if(radioButton1.Checked)
					tDesc.Appearance.AnyRecordFieldCell.HorizontalAlignment=GridHorizontalAlignment.Left;
			}
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.listBox1.SelectedItem!=null)
			{
				string temp=this.listBox1.SelectedItem.ToString();
				GridColumnDescriptor tDesc=descColl[temp];
				if(radioButton2.Checked)
					tDesc.Appearance.AnyRecordFieldCell.HorizontalAlignment=GridHorizontalAlignment.Center;
			}
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.listBox1.SelectedItem!=null)
			{
				string temp=this.listBox1.SelectedItem.ToString();
				GridColumnDescriptor tDesc=descColl[temp];
				if(radioButton3.Checked)
					tDesc.Appearance.AnyRecordFieldCell.HorizontalAlignment=GridHorizontalAlignment.Right;
			}
		}

		private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
		{
            this.colorPickerButton1.SelectedAsText = true;
			if(this.listBox1.SelectedItem!=null)
			{
                string temp=this.listBox1.SelectedItem.ToString();
				descColl[temp].Appearance.AnyRecordFieldCell.TextColor=this.colorPickerButton1.SelectedColor;
			}
		}

		private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
		{
            this.colorPickerButton2.SelectedAsText = true;
			if(this.listBox1.SelectedItem!=null)
			{
				string temp=this.listBox1.SelectedItem.ToString();
				descColl[temp].Appearance.AnyRecordFieldCell.TextColor=this.colorPickerButton1.SelectedColor;
			}
		}
	}
}
