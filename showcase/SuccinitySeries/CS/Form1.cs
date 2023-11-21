#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.Threading;
using Syncfusion.WinForms.Controls;

namespace SuccinitySeries
{
    public partial class Form1 : SfForm
    {
        int i = 0;
        Dictionary<Image, string> filePath;
        Image SelectedImage;
        public Form1()
        {
            InitializeComponent();
            Rectangle rect = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            this.MinimumSize = new Size(rect.Width * 2 / 3, rect.Height * (3 / 2));
            this.Location = new Point(rect.Width / 6, 0);
            try
            {
#if NETCORE
            System.Drawing.Icon ico = new System.Drawing.Icon("../../../grid.ico");
#else
            System.Drawing.Icon ico = new System.Drawing.Icon("../../grid.ico");
#endif
                this.Icon = ico;
#if NETCORE
            this.carousel1.BackgroundImage = new Bitmap("../../../Images/Background-image.png");
#else
            this.carousel1.BackgroundImage = new Bitmap("../../Images/Background-image.png");
#endif
                carousel1.BackgroundImageLayout = ImageLayout.Stretch;
                carousel1.UseOriginalImageinPreview = false;
            }
            catch { }

            filePath = new Dictionary<Image, string>();

            foreach (var item in carousel1.ImageListCollection)
            {
                filePath.Add(item.ItemImage, "file" + i++);
            }
            this.carousel1.TransitionSpeed = 5;
        }
        #region event
        private void carousel1_OnCarouselItemFocused(object sender, CarouselItemFocusedArgs e)
        {

          if(e.FocusedImage==SelectedImage)
          {
              if (filePath.ContainsKey(e.FocusedImage))
              {
                  string fileName = filePath[e.FocusedImage];
                  Viewer view = new Viewer();
                  if (fileName == "file0")
                  {
                      fileName = "jQuery_Succinctly.pdf";
                  }
                  else if (fileName == "file1")
                  {
                      fileName = "GIS Succinctly.pdf";
                  }
                  else if (fileName == "file2")
                  {
                      fileName = "WindowsStoreApps_Succinctly.pdf";
                  }
                  else if (fileName == "file3")
                  {
                      fileName = "HTTP_Succinctly.pdf";
                  }
                  else if (fileName == "file4")
                  {
                      fileName = "JavaScript_Succinctly.pdf";
                  }
                  else if (fileName == "file5")
                  {
                      fileName = "LightSwitch_Succinctly.pdf";
                  }
                  else if (fileName == "file6")
                  {
                      fileName = "aspnetmvc4_Succinctly.pdf";
                  }
                  else if (fileName == "file7")
                  {
                      fileName = "iOS_Succinctly.pdf";
                  }
                  else if (fileName == "file8")
                  {
                      fileName = "Fsharp_Succinctly.pdf";
                  }
                  view.Show();
                  view.LoadPdf("PDF/" + fileName);
                  view.Text = fileName;
              }

            }
        #endregion


        }

        private void carousel1_OnCarouselItemSelectionChanging(object sender, CarouselItemSelectionChangingArgs e)
        {
            SelectedImage = e.SelectedImage;
        }

        private void carousel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Gray), e.ClipRectangle);
        }


    }
}
