using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp73
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            string base64 =

@"AAEAAAD/////AQAAAAAAAAAEAQAAABZTeXN0ZW0uSU8uTWVtb3J5U3RyZWFtCgAAAAdfYnVmZmVyB19v

cmlnaW4JX3Bvc2l0aW9uB19sZW5ndGgJX2NhcGFjaXR5C19leHBhbmRhYmxlCV93cml0YWJsZQpfZXhw

b3NhYmxlB19pc09wZW4dTWFyc2hhbEJ5UmVmT2JqZWN0K19faWRlbnRpdHkHAAAAAAAAAAACAggICAgB

AQEBCQIAAAAAAAAAXQYAAF0GAAAACAAAAQEBAQoPAgAAAAAIAAACAAEAAAD/////AQAAAAAAAAAMAgAA

AGFTeW5jZnVzaW9uLlRvb2xzLldpbmRvd3MsIFZlcnNpb249MTMuMjAwNDYuMC4yOSwgQ3VsdHVyZT1u

ZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj0zZDY3ZWQxZjg3ZDQ0Yzg5BQEAAAA6U3luY2Z1c2lvbi5XaW5k

b3dzLkZvcm1zLlRvb2xzLkNCQ3RybHJTZXJpYWxpemF0aW9uV3JhcHBlcgIAAAAIY2JCb3JkZXINaHRD

QmFyV3JhcHBlcgQDM1N5bmNmdXNpb24uV2luZG93cy5Gb3Jtcy5Ub29scy5Db21tYW5kQmFyRG9ja0Jv

cmRlcgIAAAAcU3lzdGVtLkNvbGxlY3Rpb25zLkhhc2h0YWJsZQIAAAAF/f///zNTeW5jZnVzaW9uLldp

bmRvd3MuRm9ybXMuVG9vbHMuQ29tbWFuZEJhckRvY2tCb3JkZXIBAAAAB3ZhbHVlX18ACAIAAAAPAAAA

CQQAAAAEBAAAABxTeXN0ZW0uQ29sbGVjdGlvbnMuSGFzaHRhYmxlBwAAAApMb2FkRmFjdG9yB1ZlcnNp

b24IQ29tcGFyZXIQSGFzaENvZGVQcm92aWRlcghIYXNoU2l6ZQRLZXlzBlZhbHVlcwAAAwMABQULCBxT

eXN0ZW0uQ29sbGVjdGlvbnMuSUNvbXBhcmVyJFN5c3RlbS5Db2xsZWN0aW9ucy5JSGFzaENvZGVQcm92

aWRlcgjsUTg/BgAAAAoKBwAAAAkFAAAACQYAAAAQBQAAAAUAAAAGBwAAABdUb29sYmFySG9zdF9UZXh0

X0VkaXRvcgYIAAAAC2NvbnRyb2xCYXIyBgkAAAAQVG9vbGJhckhvc3RfTWVudQYKAAAAC2NvbnRyb2xC

YXIxBgsAAAARVG9vbGJhckhvc3RfSWNvbnMQBgAAAAUAAAAJDAAAAAkNAAAACQ4AAAAJDwAAAAkQAAAA

DBEAAABRU3lzdGVtLkRyYXdpbmcsIFZlcnNpb249NC4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJs

aWNLZXlUb2tlbj1iMDNmNWY3ZjExZDUwYTNhBQwAAAA+U3luY2Z1c2lvbi5XaW5kb3dzLkZvcm1zLlRv

b2xzLlhQTWVudXMuQ29tbWFuZEJhckV4dFNlcmlhbGl6ZXIIAAAACU1heExlbmd0aAlNaW5MZW5ndGgT

Q29tbWFuZEJhckRvY2tTdGF0ZQxSb3dPZmZzZXREaXIHUkNJbmRleAtSQ0NvdW50RHJhZw1GbG9hdExv

Y2F0aW9uCUZsb2F0U2l6ZQAABAAAAAQECAgyU3luY2Z1c2lvbi5XaW5kb3dzLkZvcm1zLlRvb2xzLkNv

bW1hbmRCYXJEb2NrU3RhdGUCAAAACAgIFFN5c3RlbS5EcmF3aW5nLlBvaW50EQAAABNTeXN0ZW0uRHJh

d2luZy5TaXplEQAAAAIAAADdAAAAMAAAAAXu////MlN5bmNmdXNpb24uV2luZG93cy5Gb3Jtcy5Ub29s

cy5Db21tYW5kQmFyRG9ja1N0YXRlAQAAAAd2YWx1ZV9fAAgCAAAAAQAAAAAAAAABAAAAAAAAAAXt////";


            byte[] bytes = Convert.FromBase64String(

                base64.Replace("\r", "")

                      .Replace("\n", "")

            );
            MemoryStream stream = new MemoryStream(bytes);
            stream.Position = 0;
            mainFrameBarManager1.BarPositionInfo = stream;
#if NETCORE
            this.Icon = new System.Drawing.Icon(@"..\\..\\..\\\sficon.ico");
#else
            this.Icon = new System.Drawing.Icon(@"..\\..\\\sficon.ico");
#endif
            this.BorderColor = ColorTranslator.FromHtml("#d6dbe9");
            this.MetroColor = ColorTranslator.FromHtml("#d6dbe9");
            this.bar1.BarStyle = Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible;
            this.controlBar1.Width = 282;
            this.controlBar2.Width = 282;
            this.controlBar1.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left;
            this.controlBar2.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right;
            VS2005Colors.BarItemHighlightDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            VS2005Colors.BarItemHighlightLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            VS2005Colors.CommandBarLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            VS2005Colors.CommandBarDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.controlBar1.ForeColor = Color.White;
            this.controlBar2.ForeColor = Color.White;
            this.treeViewAdv1.ForeColor = Color.Black;
            this.treeViewAdv2.ForeColor = Color.Black;
            this.treeViewAdv1.BorderStyle = BorderStyle.None;
            this.barItem1.Click += BarItem1_Click;
            this.barItem2.Click += BarItem2_Click;
            this.barItem3.Click += BarItem3_Click;
            this.barItem4.Click += BarItem4_Click;
            this.barItem5.Click += BarItem5_Click;
            this.barItem6.Click += BarItem6_Click;
        }

        private void BarItem6_Click(object sender, System.EventArgs e)
        {
            this.controlBar1.Hide();
            this.treeViewAdv1.Hide();
            this.textBoxExt1.Hide();
            this.gradientPanel.Hide();
        }

        private void BarItem5_Click(object sender, System.EventArgs e)
        {
            this.controlBar1.DisableFloating = true;
            this.controlBar1.DisableDocking = false;
            this.controlBar1.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right;
        }

        private void BarItem4_Click(object sender, System.EventArgs e)
        {
            this.controlBar1.DisableFloating = true;
            this.controlBar1.DisableDocking = false;
            this.controlBar1.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left;
        }

        private void BarItem3_Click(object sender, System.EventArgs e)
        {
            this.controlBar1.DisableFloating = true;
            this.controlBar1.DisableDocking = false;
            this.controlBar1.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Bottom;
        }

        private void BarItem2_Click(object sender, System.EventArgs e)
        {
            this.controlBar1.DisableFloating = true;
            this.controlBar1.DisableDocking = false;
            this.controlBar1.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top;
        }
        
        private void BarItem1_Click(object sender, System.EventArgs e)
        {
            this.controlBar1.DisableFloating = false;
            this.controlBar1.DisableDocking = true;
        }
    }
}
