using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace GaugeDemo
{
    public partial class Form1 : MetroForm
    {
        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);

        Timer timer = new Timer();
        Syncfusion.Windows.Forms.Gauge.Range range1 = new Syncfusion.Windows.Forms.Gauge.Range();
        Syncfusion.Windows.Forms.Gauge.Range range2 = new Syncfusion.Windows.Forms.Gauge.Range();
        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.radialGauge1.Ranges.Clear();
            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            range1.Color = System.Drawing.ColorTranslator.FromHtml("#0CBDF4");
            range1.EndValue = 120F;
            range1.Height = 70;
            range1.InRange = false;
            range1.Name = "Normal range";
            range1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range1.StartValue = 0F;
            range2.Color = System.Drawing.ColorTranslator.FromHtml("#E8E8E8");
            range2.EndValue = 120F;
            range2.Height = 70;
            range2.InRange = false;
            range2.Name = "Normal range";
            range2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range2.StartValue = 0F;
            this.radialGauge1.Ranges.Add(range1);
            this.radialGauge1.Ranges.Add(range2);
            this.trackBar1.ValueChanged += new EventHandler(trackBar1_ValueChanged);
            this.radialGauge1.ValueChanged += new EventHandler(radialGauge1_ValueChanged);
            using (Graphics g = this.CreateGraphics())
            {
                if (g.DpiX > 96)
                {
                    this.label1.Location = new System.Drawing.Point(191, 323);
                    this.label1.Size = new System.Drawing.Size(39, 25);
                    this.label2.Location = new System.Drawing.Point(591, 323);
                    this.label2.Size = new System.Drawing.Size(59, 25);
                    this.panel2.Location = new System.Drawing.Point(35, 265);
                    this.panel2.Margin = new System.Windows.Forms.Padding(4);
                    this.panel2.Size = new System.Drawing.Size(136, 12);
                    this.panel3.Location = new System.Drawing.Point(436, 264);
                    this.panel3.Margin = new System.Windows.Forms.Padding(4);
                    this.panel3.Size = new System.Drawing.Size(136, 12);
                    this.label3.Location = new System.Drawing.Point(372, 271);
                    this.label3.Size = new System.Drawing.Size(82, 28);
                    this.label4.Location = new System.Drawing.Point(336, 222);
                    this.label4.Size = new System.Drawing.Size(149, 46);
                    this.MetroColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.radialGauge1.Location = new System.Drawing.Point(35, 4);
                    this.radialGauge1.Margin = new System.Windows.Forms.Padding(4);
                    this.radialGauge1.Size = new System.Drawing.Size(537, 358);
                    this.panel1.Location = new System.Drawing.Point(103, 52);
                    this.panel1.Size = new System.Drawing.Size(624, 369);
                    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                }
                else
                {
                    this.label1.Location = new System.Drawing.Point(143, 246);
                    this.label2.Location = new System.Drawing.Point(449, 247);
                    this.panel2.Location = new System.Drawing.Point(25, 198);
                    this.panel3.Location = new System.Drawing.Point(338, 198);
                }
            }
            this.radialGauge1.MinorInnerLinesHeight = 0;
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
        void radialGauge1_ValueChanged(object sender, EventArgs e)
        {      

          
        }
        void trackBar1_ValueChanged(object sender, EventArgs e)
        {           
            this.radialGauge1.Value = this.trackBar1.Value;            
        }     
        int val = 0;
        bool inc = true ;
        void timer_Tick(object sender, EventArgs e)
        {            
          //  Random random = new Random();

            if (val == 110)
            {
                inc = false ;
            }

            if(val == 10)
            {
                inc = true;
            }
            if(inc)
            {
                this.label4.Text = "  $ " + val.ToString() ;
                      this.label3.Text = this.label4.Text;
                      this.trackBar1.Value = val;
                      range1.EndValue = this.radialGauge1.Value;

                      range1.StartValue = 0F;
                      this.radialGauge1.Ranges.Add(range1);
                      //this.radialGauge1.Value = val;
                      val = val + 2;
            }
            else
            {
                this.label4.Text = "  $ " + val.ToString();
                this.label3.Text = this.label4.Text;
                this.radialGauge1.Value =  val;
                range1.EndValue = this.radialGauge1.Value;
                range1.StartValue = 0F;
                this.radialGauge1.Ranges.Add(range1);
                val = val - 2;
            }
            this.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CaptionBarColor = Color.White;
            this.CaptionButtonColor = Color.Black;
            this.CaptionAlign = HorizontalAlignment.Left;
            this.radialGauge1.GaugeValueFont = new Font("Segon UI", 20F,FontStyle.Bold);            
            this.radialGauge1.GaugeLableColor = System.Drawing.ColorTranslator.FromHtml("#00A551");
           
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            this.panel1.Location = new Point(
            this.ClientSize.Width / 2 - this.panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - this.panel1.Size.Height / 2);
            this.panel1.Anchor = AnchorStyles.None;
        }

        private void radialGauge1_Click(object sender, EventArgs e)
        {

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
