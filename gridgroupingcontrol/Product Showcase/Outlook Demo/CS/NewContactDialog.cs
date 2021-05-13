using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace OutlookDemo
{
	/// <summary>
	/// Summary description for NewContactDialog.
	/// </summary>
	public class NewContactDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public NewContactDialog()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public string ContactID
		{
			get 
			{
				return textBox1.Text;
			}
		}
		public string CompName
		{
			get 
			{
				return textBox2.Text;
			}
		}
		public string ContactTitle
		{
			get 
			{
				return textBox3.Text;
			}
		}
		public string Address
		{
			get 
			{
				return textBox4.Text;
			}
		}
		public string City
		{
			get 
			{
				return textBox5.Text;
			}

		}
		public string Phone
		{
			get 
			{
				return textBox6.Text;
			}
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "ContactID";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 32);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "CompanyName";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(248, 8);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "ContactTitle";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(0, 56);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "Address";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(0, 80);
			this.label5.Name = "label5";
			this.label5.TabIndex = 4;
			this.label5.Text = "City";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(0, 112);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Phone";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(104, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(136, 20);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(104, 32);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(368, 20);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(352, 8);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(120, 20);
			this.textBox3.TabIndex = 8;
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(104, 56);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(368, 20);
			this.textBox4.TabIndex = 9;
			this.textBox4.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(104, 80);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(208, 20);
			this.textBox5.TabIndex = 10;
			this.textBox5.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(104, 112);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(208, 20);
			this.textBox6.TabIndex = 11;
			this.textBox6.Text = "";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(320, 112);
			this.button1.Name = "button1";
			this.button1.TabIndex = 12;
			this.button1.Text = "OK";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.Control;
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(400, 112);
			this.button2.Name = "button2";
			this.button2.TabIndex = 13;
			this.button2.Text = "Cancel";
			// 
			// NewContactDialog
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(209)), ((System.Byte)(209)), ((System.Byte)(223)));
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(480, 142);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewContactDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Contact";
			this.ResumeLayout(false);

		}
		#endregion

	}
}
