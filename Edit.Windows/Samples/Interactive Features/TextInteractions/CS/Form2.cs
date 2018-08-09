using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace SelectionMarginDemo
{
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
        }

        void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.richTextBox1.Text = string.Empty;
            richTextBox1.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Focus();
        }
        public new Button AcceptButton
        {
            get
            {
                return this.button1;
            }
        }

        public new Button CancelButton
        {
            get
            {
                return this.button2;
            }
        }

        public string InputString
        {
            get
            {
                return this.richTextBox1.Text;
            }
        }
    }
}
