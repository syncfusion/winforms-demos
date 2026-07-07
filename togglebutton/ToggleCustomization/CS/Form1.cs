using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing.Drawing2D;

namespace ToggleCustomizationDemo
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            SetRenderer();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void SetRenderer()
        {
            StyledRenderer styleRenderer1 = new StyledRenderer();
            toggleButton9.Renderer = styleRenderer1;
            StyledRenderer styleRenderer2 = new StyledRenderer();
            toggleButton10.Renderer = styleRenderer2;
            StyledRenderer styleRenderer3 = new StyledRenderer();
            toggleButton11.Renderer = styleRenderer3;
            StyledRenderer styleRenderer4 = new StyledRenderer();
            toggleButton12.Renderer = styleRenderer4;
        }
    }
    
}
