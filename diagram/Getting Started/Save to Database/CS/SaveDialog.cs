#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlServerCe;

namespace SaveDiagramAsBinary
{
    public partial class SaveDialog : MetroForm
    {
        string strCon;

        public SaveDialog()
        {          
            InitializeComponent();

            txtName.GotFocus += new EventHandler(txtName_GotFocus);

            //Get connection string.
            strCon = @"Data Source=..\..\..\..\..\..\common\Data\Diagram\db\Diagram.sdf";
           
        }

        void txtName_GotFocus(object sender, EventArgs e)
        {
            lblResult.Text = string.Empty;
        }        

        public string DiagramName
        {
            get
            {
                return txtName.Text;
            }
        }

        private void SaveDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
                return;

            //Validation
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblResult.Text = "Please enter a name for the diagram";
                e.Cancel = true;
                return;
            }

            //Create an instance of connection and command object.
            SqlCeConnection con = new SqlCeConnection(strCon);
            SqlCeCommand cmd = new SqlCeCommand("SELECT CASE WHEN EXISTS (SELECT * FROM DiagramContent  WHERE DiagramName = @DiagramName) " +
                "THEN 1 ELSE 0 END AS result", con);

            //Set parameter value
            cmd.Parameters.AddWithValue("@DiagramName", txtName.Text);

            //Execute the command.
            con.Open();
            int result = (int)cmd.ExecuteScalar();
            con.Close();

            if (result == 1)
            {
                lblResult.Text = "The name already exist";
                e.Cancel = true;                
            }
        }
    }
}
