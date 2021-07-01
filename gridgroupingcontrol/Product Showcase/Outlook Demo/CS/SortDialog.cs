using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace OutlookDemo
{
	/// <summary>
	/// Summary description for SortDialog.
	/// </summary>
	public class SortDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		string[] sortByCols;
		ListSortDirection[] sortDir;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SortDialog(string[] vCols)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			sortByCols=new string[3];
			sortDir=new ListSortDirection[3];
			for(int i=0;i<vCols.Length;i++)
			{
				this.comboBox1.Items.Add(vCols[i]);
				this.comboBox2.Items.Add(vCols[i]);
				this.comboBox3.Items.Add(vCols[i]);
			}
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		public string[] SortByCols
		{
			get{return sortByCols;}
		}

		public ListSortDirection[] Direction
		{
			get{return sortDir;}
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(296, 64);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sort items by";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(168, 40);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 16);
			this.radioButton2.TabIndex = 5;
			this.radioButton2.Text = "Descending";
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(168, 16);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 16);
			this.radioButton1.TabIndex = 4;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Ascending";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
														   "(none)"});
			this.comboBox1.Location = new System.Drawing.Point(8, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(152, 21);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.Text = "(none)";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBox2);
			this.groupBox2.Controls.Add(this.radioButton4);
			this.groupBox2.Controls.Add(this.radioButton3);
			this.groupBox2.Location = new System.Drawing.Point(8, 80);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox2.Size = new System.Drawing.Size(296, 64);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Then by";
			// 
			// comboBox2
			// 
			this.comboBox2.Items.AddRange(new object[] {
														   "(none)"});
			this.comboBox2.Location = new System.Drawing.Point(8, 16);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(152, 21);
			this.comboBox2.TabIndex = 4;
			this.comboBox2.Text = "(none)";
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(168, 40);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(104, 16);
			this.radioButton4.TabIndex = 7;
			this.radioButton4.Text = "Descending";
			// 
			// radioButton3
			// 
			this.radioButton3.Checked = true;
			this.radioButton3.Location = new System.Drawing.Point(168, 16);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(104, 16);
			this.radioButton3.TabIndex = 6;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Ascending";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.comboBox3);
			this.groupBox3.Controls.Add(this.radioButton6);
			this.groupBox3.Controls.Add(this.radioButton5);
			this.groupBox3.Location = new System.Drawing.Point(8, 152);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(296, 64);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Then by";
			// 
			// comboBox3
			// 
			this.comboBox3.Items.AddRange(new object[] {
														   "(none)"});
			this.comboBox3.Location = new System.Drawing.Point(8, 16);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(152, 21);
			this.comboBox3.TabIndex = 5;
			this.comboBox3.Text = "(none)";
			// 
			// radioButton6
			// 
			this.radioButton6.Location = new System.Drawing.Point(168, 40);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(104, 16);
			this.radioButton6.TabIndex = 9;
			this.radioButton6.Text = "Descending";
			// 
			// radioButton5
			// 
			this.radioButton5.Checked = true;
			this.radioButton5.Location = new System.Drawing.Point(168, 16);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(104, 16);
			this.radioButton5.TabIndex = 8;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "Ascending";
			this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(312, 16);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.Control;
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(312, 48);
			this.button2.Name = "button2";
			this.button2.TabIndex = 4;
			this.button2.Text = "Cancel";
			// 
			// SortDialog
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(209)), ((System.Byte)(209)), ((System.Byte)(223)));
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(392, 222);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SortDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Sort";
			this.Load += new System.EventHandler(this.SortDialog_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void SortDialog_Load(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			sortByCols[0]=this.comboBox1.SelectedItem.ToString();
			sortByCols[1]=this.comboBox2.SelectedItem.ToString();
			sortByCols[2]=this.comboBox3.SelectedItem.ToString();
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton1.Checked)
				sortDir[0]=ListSortDirection.Ascending;
			else
				sortDir[0]=ListSortDirection.Descending;
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton3.Checked)
				sortDir[1]=ListSortDirection.Ascending;
			else
				sortDir[1]=ListSortDirection.Descending;
		}

		private void radioButton5_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton5.Checked)
				sortDir[2]=ListSortDirection.Ascending;
			else
				sortDir[2]=ListSortDirection.Descending;
		}
	}
}
