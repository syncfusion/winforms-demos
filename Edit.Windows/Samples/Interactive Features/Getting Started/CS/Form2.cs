using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace ActionGroupingDemo
{
    public partial class Form2 : MetroForm
    {
        public Form2(Form1 form1)
        {
            //
            // Required for Windows Form Designer support
            //
            Mainform = form1;
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


        public int startLine
        {
            get
            {
                int result;
                if (int.TryParse(textBox1.Text, out result))
                    return result = Convert.ToInt32(textBox1.Text);
                else
                    return 1;
            }
        }

        public int endLine
        {
            get
            {
                int result;
                if (int.TryParse(textBox3.Text, out result))
                    return result = Convert.ToInt32(textBox3.Text);
                else
                    return 1;
            }
        }
        public int startColumn
        {
            get
            {
                int result;
                if (int.TryParse(textBox2.Text, out result))
                    return result = Convert.ToInt32(textBox2.Text);
                else
                    return 2;
            }
        }
        public int endColumn
        {
            get
            {
                int result;
                if (int.TryParse(textBox4.Text, out result))
                    return result = Convert.ToInt32(textBox4.Text);
                else
                    return 1;
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();

        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            this.textBox1.Focus();
        }
    }
}
