#region Copyright Syncfusion Inc. 2001 - 2013
//
//  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using Syncfusion.Windows.Forms.Tools;

namespace ComboTest
{
	/// <summary>
	/// Summary description for ComboBoxAdvSampleControl.
	/// </summary>
	public class ComboBoxAdvSampleControl : System.Windows.Forms.UserControl, IChildSampleControls
	{
		private ComboTest.DataSet2 dataSet21;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private ComboTest.DataSet1 dataSet11;
		private System.Windows.Forms.GroupBox groupBox3;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv unboundCombo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv boundCombo;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		internal TextBox textLog;

		public ComboBoxAdvSampleControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

			string mdbFile = Form1.FindFile("ComboBoxDataBinding.mdb");
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbFile;
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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComboBoxAdvSampleControl));
            this.dataSet21 = new ComboTest.DataSet2();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.dataSet11 = new ComboTest.DataSet1();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.unboundCombo = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boundCombo = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unboundCombo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boundCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerName", "CustomerName"),
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Sex", "Sex")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM Customers WHERE (ID = ?) AND (CustomerName = ? OR ? IS NULL AND Custo" +
                "merName IS NULL) AND (Sex = ? OR ? IS NULL AND Sex IS NULL)";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CustomerName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sex", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sex", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sex1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sex", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO Customers(CustomerName, Sex) VALUES (?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerName"),
            new System.Data.OleDb.OleDbParameter("Sex", System.Data.OleDb.OleDbType.VarWChar, 50, "Sex")});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT CustomerName, ID, Sex FROM Customers";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE Customers SET CustomerName = ?, Sex = ? WHERE (ID = ?) AND (CustomerName =" +
                " ? OR ? IS NULL AND CustomerName IS NULL) AND (Sex = ? OR ? IS NULL AND Sex IS N" +
                "ULL)";
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerName"),
            new System.Data.OleDb.OleDbParameter("Sex", System.Data.OleDb.OleDbType.VarWChar, 50, "Sex"),
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CustomerName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sex", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sex", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sex1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sex", System.Data.DataRowVersion.Original, null)});
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.unboundCombo);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(328, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 240);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unbound ComboBoxAdv:";
            // 
            // unboundCombo
            // 
            this.unboundCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.unboundCombo.IgnoreThemeBackground = true;
            this.unboundCombo.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.unboundCombo.Location = new System.Drawing.Point(24, 40);
            this.unboundCombo.Name = "unboundCombo";
            this.unboundCombo.Size = new System.Drawing.Size(136, 21);
            this.unboundCombo.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.unboundCombo.SuppressDropDownEvent = false;
            this.unboundCombo.TabIndex = 0;
            this.unboundCombo.Validated += new System.EventHandler(this.combo_Validated);
            this.unboundCombo.SelectionChangeCommitted += new System.EventHandler(this.combo_SelectionChangeCommitted);
            this.unboundCombo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.boundCombo);
            this.groupBox2.Controls.Add(this.dataGrid1);
            this.groupBox2.Location = new System.Drawing.Point(3, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 240);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataBound ComboBoxAdv";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Databinding for this combo initialized in code. Change the Sex in the current row" +
                " in the grid below and see the values change here and vice-versa.";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Databound Grid:";
            // 
            // boundCombo
            // 
            this.boundCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.boundCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.boundCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boundCombo.IgnoreThemeBackground = true;
            this.boundCombo.Location = new System.Drawing.Point(16, 80);
            this.boundCombo.Name = "boundCombo";
            this.boundCombo.Size = new System.Drawing.Size(285, 21);
            this.boundCombo.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.boundCombo.SuppressDropDownEvent = false;
            this.boundCombo.TabIndex = 0;
            this.boundCombo.Validated += new System.EventHandler(this.combo_Validated);
            this.boundCombo.SelectionChangeCommitted += new System.EventHandler(this.combo_SelectionChangeCommitted);
            this.boundCombo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            // 
            // dataGrid1
            // 
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(219)))));
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.DataSource = this.dataSet11.Customers;
            this.dataGrid1.FlatMode = true;
            this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dataGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.LinkColor = System.Drawing.Color.Teal;
            this.dataGrid1.Location = new System.Drawing.Point(8, 128);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.Size = new System.Drawing.Size(301, 104);
            this.dataGrid1.TabIndex = 1;
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
            this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Sex_Description", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description")})});
            this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = "DELETE FROM Sex_Description WHERE (ID = ?) AND (Description = ? OR ? IS NULL AND " +
                "Description IS NULL)";
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO Sex_Description(Description) VALUES (?)";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 50, "Description")});
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT Description, ID FROM Sex_Description";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = "UPDATE Sex_Description SET Description = ? WHERE (ID = ?) AND (Description = ? OR" +
                " ? IS NULL AND Description IS NULL)";
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 50, "Description"),
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null)});
            // 
            // ComboBoxAdvSampleControl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(219)))));
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "ComboBoxAdvSampleControl";
            this.Size = new System.Drawing.Size(504, 264);
            this.Load += new System.EventHandler(this.ComboBoxAdvSampleControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unboundCombo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boundCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void ComboBoxAdvSampleControl_Load(object sender, System.EventArgs e)
		{
			this.oleDbDataAdapter1.Fill(this.dataSet11);
			this.oleDbDataAdapter2.Fill(this.dataSet21);

			this.boundCombo.DataSource = this.dataSet21.Sex_Description;
			this.boundCombo.DisplayMember = "Description";
			this.boundCombo.ValueMember = "ID";

			this.boundCombo.DataBindings.Add("SelectedValue", this.dataSet11.Customers, "Sex");	
		}

		public Control GetPrimaryItem()
		{
			return this.boundCombo;
		}
		#region TRACE_NOTIFICATIONS
		private void combo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.textLog == null)
				return;
			ComboBoxBaseDataBound c = sender as ComboBoxBaseDataBound;
			this.textLog.Text += c.Name + "'s SelectedIndexChanged to:" + c.SelectedIndex + "\r\n";
		}

		private void combo_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			if(this.textLog == null)
				return;
			ComboBoxBaseDataBound c = sender as ComboBoxBaseDataBound;
			this.textLog.Text += c.Name + "'s SelectionChangeCommitted. New index is:" + c.SelectedIndex  + "\r\n";
		}

		private void combo_Validated(object sender, System.EventArgs e)
		{
			if(this.textLog == null)
				return;

			ComboBoxBaseDataBound c = sender as ComboBoxBaseDataBound;
			if(c.SelectedItem != null)
				this.textLog.Text += c.Name + "has validated the new entry. New entry is:" + c.SelectedItem.ToString()  + "\r\n";
			else
				this.textLog.Text += c.Name + "has validated the new entry. New entry is:" + c.Text + "\r\n";
		}

		private void combo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(this.textLog == null)
				return;
			ComboBoxBaseDataBound c = sender as ComboBoxBaseDataBound;
			if(c.SelectedItem != null)
				this.textLog.Text += c.Name + "is validating the new entry:" + c.SelectedItem.ToString() + "\r\n";
			else
				this.textLog.Text += c.Name + "is validating the new entry:" + c.Text + "\r\n";
		}
		#endregion TRACE_NOTIFICATIONS

	}
}
