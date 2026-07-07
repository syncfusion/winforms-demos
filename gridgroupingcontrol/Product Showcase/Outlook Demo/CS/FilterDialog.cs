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
	/// Summary description for FilterDialog.
	/// </summary>
	public class FilterDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.TextBox txtValue;
		private System.Windows.Forms.Label lblFields;
		private System.Windows.Forms.Label lblCond;
		private System.Windows.Forms.Label lblValue;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		GridGroupingControl groupingGrid;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FilterDialog(GridGroupingControl grid)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			groupingGrid=grid;
			for (int i = 0; i < this.groupingGrid.TableDescriptor.VisibleColumns.Count; i++)
			{
				GridVisibleColumnDescriptor col = this.groupingGrid.TableDescriptor.VisibleColumns[i];
				if (col != null)
				{
					this.comboBox1.Items.Add(col.Name);
				}
			}
			if(this.groupingGrid.TableDescriptor.RecordFilters.Count>0)
			{
				foreach(RecordFilterDescriptor filter in groupingGrid.TableDescriptor.RecordFilters)
				{
					if(filter!=null)
					{
						foreach(FilterCondition cond in filter.Conditions)
							listBox1.Items.Add(cond.FilterDescriptor.FieldDescriptor.Name+" "+cond.CompareOperator.ToString()+" "+cond.CompareValue.ToString());
					}
				}
			}
			this.comboBox1.SelectedIndexChanged+=new EventHandler(comboBox1_SelectedIndexChanged);
			this.listBox1.SelectedIndexChanged+=new EventHandler(listBox1_SelectedIndexChanged);
			this.txtValue.TextChanged+=new EventHandler(txtValue_TextChanged);

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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRemove = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblValue = new System.Windows.Forms.Label();
			this.lblCond = new System.Windows.Forms.Label();
			this.lblFields = new System.Windows.Forms.Label();
			this.txtValue = new System.Windows.Forms.TextBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(0, 24);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(456, 82);
			this.listBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Find items that match these criteria:";
			// 
			// btnRemove
			// 
			this.btnRemove.BackColor = System.Drawing.SystemColors.Control;
			this.btnRemove.Enabled = false;
			this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnRemove.Location = new System.Drawing.Point(376, 112);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.TabIndex = 2;
			this.btnRemove.Text = "Remove";
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.lblValue);
			this.groupBox1.Controls.Add(this.lblCond);
			this.groupBox1.Controls.Add(this.lblFields);
			this.groupBox1.Controls.Add(this.txtValue);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Location = new System.Drawing.Point(8, 136);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(448, 96);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Define criteria:";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
			this.btnAdd.Enabled = false;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAdd.Location = new System.Drawing.Point(360, 64);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Add to List";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblValue
			// 
			this.lblValue.Enabled = false;
			this.lblValue.Location = new System.Drawing.Point(304, 16);
			this.lblValue.Name = "lblValue";
			this.lblValue.TabIndex = 5;
			this.lblValue.Text = "Value";
			// 
			// lblCond
			// 
			this.lblCond.Enabled = false;
			this.lblCond.Location = new System.Drawing.Point(176, 16);
			this.lblCond.Name = "lblCond";
			this.lblCond.Size = new System.Drawing.Size(100, 16);
			this.lblCond.TabIndex = 4;
			this.lblCond.Text = "Condition";
			// 
			// lblFields
			// 
			this.lblFields.Location = new System.Drawing.Point(8, 16);
			this.lblFields.Name = "lblFields";
			this.lblFields.Size = new System.Drawing.Size(100, 16);
			this.lblFields.TabIndex = 3;
			this.lblFields.Text = "Fields";
			// 
			// txtValue
			// 
			this.txtValue.Enabled = false;
			this.txtValue.Location = new System.Drawing.Point(304, 40);
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(136, 20);
			this.txtValue.TabIndex = 2;
			this.txtValue.Text = "";
			// 
			// comboBox2
			// 
			this.comboBox2.Enabled = false;
			this.comboBox2.Items.AddRange(new object[] {
														   "Equals",
														   "Greater Than",
														   "Greater ThanOrEqualTo",
														   "Less Than",
														   "Less ThanOrEqualTo",
														   "Like",
														   "NotEquals"});
			this.comboBox2.Location = new System.Drawing.Point(176, 40);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 1;
			this.comboBox2.Text = "(Condition)";
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(8, 40);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(152, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "(Select Fields)";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(296, 240);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.Control;
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(376, 240);
			this.button2.Name = "button2";
			this.button2.TabIndex = 5;
			this.button2.Text = "Cancel";
			// 
			// FilterDialog
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(209)), ((System.Byte)(209)), ((System.Byte)(223)));
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(464, 272);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FilterDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Filter";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.comboBox1.SelectedItem!=null)
			{
				this.comboBox2.Enabled=true;
				this.txtValue.Enabled=true;
				this.lblCond.Enabled=true;
				this.lblValue.Enabled=true;
			}
			else
			{
				this.comboBox2.Enabled=false;
				this.txtValue.Enabled=false;
				this.lblCond.Enabled=false;
				this.lblValue.Enabled=false;
			}
		}

		private void txtValue_TextChanged(object sender, EventArgs e)
		{
			if(txtValue.TextLength>0)
				this.btnAdd.Enabled=true;
			else
				this.btnAdd.Enabled=false;
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			if(this.comboBox1.SelectedItem != null && this.comboBox2.SelectedItem!=null && this.txtValue.TextLength!=0)
			{
				this.listBox1.Items.Add(this.comboBox1.SelectedItem.ToString()+"\t"+this.comboBox2.SelectedItem.ToString()+"\t"+this.txtValue.Text);
				this.comboBox1.Text="(Select Fields)";
				this.comboBox2.Text="(Condition)";
				this.txtValue.Text="";
				this.comboBox2.Enabled=false;
				this.lblCond.Enabled=false;
				this.lblValue.Enabled=false;
				this.txtValue.Enabled=false;
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.listBox1.SelectedItem != null)
				this.btnRemove.Enabled=true;
			else
				this.btnRemove.Enabled=false;
		}

		private void btnRemove_Click(object sender, System.EventArgs e)
		{
			if((this.listBox1.Items.Count>0) && (this.listBox1.SelectedItem != null))
				this.listBox1.Items.Remove(this.listBox1.SelectedItem);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			System.Text.StringBuilder criteria=new System.Text.StringBuilder();
			this.groupingGrid.TableDescriptor.RecordFilters.Clear();
			if(this.listBox1.Items.Count>0)
			{
				string[] str=new string[3];
				str=this.listBox1.Items[0].ToString().Split('\t');
				groupingGrid.TableDescriptor.RecordFilters.Add(str[0],CompareOp(str[1]),str[2]);
			}
		}

		FilterCompareOperator CompareOp(string s)
		{
			if(s.CompareTo("Equals")==0)
				return FilterCompareOperator.Equals;
			else if(s.CompareTo("Greater Than")==0)
				return FilterCompareOperator.GreaterThan;
			else if(s.CompareTo("Greater ThanOrEqualTo")==0)
				return FilterCompareOperator.GreaterThanOrEqualTo;
			else if(s.CompareTo("Less Than")==0)
				return FilterCompareOperator.LessThan;
			else if(s.CompareTo("Less ThanOrEqualTo")==0)
				return FilterCompareOperator.LessThanOrEqualTo;
			else if(s.CompareTo("Like")==0)
				return FilterCompareOperator.Like;
			else
				return FilterCompareOperator.NotEquals;
		}
	}
}
