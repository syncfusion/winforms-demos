#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.Controls.Enums;
using Syncfusion.Windows.Forms;

namespace GettingStarted
{
    public partial class Form1 : Form
    {
        #region Fields
        ToolTipInfo pictureBox1Info;
        ToolTipInfo pictureBox2Info;
        ToolTipInfo pictureBox3Info;
        ToolTipInfo pictureBox4Info;
        ToolTipInfo pictureBox5Info;
        ToolTipInfo pictureBox6Info;
        ToolTipInfo pictureBox7Info;
        ToolTipInfo pictureBox8Info;
        ToolTipInfo pictureBox9Info;
        ToolTipInfo pictureBox10Info;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="GettingStarted.Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            InitializePictureBoxToolTips();
        }
        #endregion

        #region InitializePictureBoxToolTips
        /// <summary>
        /// Initializes the picture boxes with the tooltip informations.
        /// </summary>
        public void InitializePictureBoxToolTips()
        {
            ToolTipInfo toolTipInfo1 = new ToolTipInfo();
            toolTipInfo1.MaxWidth = 1000;
            toolTipInfo1.ToolTipStyle = ToolTipStyle.Balloon;
            toolTipInfo1.BeakBackColor = ColorTranslator.FromHtml("#3D3D3D");
            toolTipInfo1.BorderColor = ColorTranslator.FromHtml("#1E1E1E");
            ToolTipItem toolTipItem1 = new ToolTipItem();
            toolTipItem1.Padding = new Padding(10);
            toolTipItem1.Style.BackColor = ColorTranslator.FromHtml("#3D3D3D");

            PictureBoxControl pictureBoxControl1 = new PictureBoxControl();

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = global::GettingStarted.Properties.Resources.Batman_Begins;
            pictureBox1.Size = new Size(214, 292);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxControl1.PictureBox = pictureBox1;

            RichTextBox richTextBox1 = new RichTextBox();
            richTextBox1.Margin = new Padding(0);
            richTextBox1.Location = new Point(239, 0);
            richTextBox1.Size = new Size(315, 292);
            richTextBox1.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            richTextBox1.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red245\\green245\\blue245;}\r\n\\viewkind4\\uc1\\pard\\cf1\\lang1033\\b0\\fs12\\par\r\n\\b\\f0\\fs30 Batman Begins\\b0\\f0\\fs4\\par\r\n\\par\r\n\\f0\\fs18 2005 - Thriller/Action\\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18 Batman Begins is a 2005 superhero film based \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 on the DC Comics character Batman, directed\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 by Christopher Nolanand written by Nolan.\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 The film reboots the Batman film series and \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 telling the origin story of Bruce Wayne.\\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18\\b Initial Release :\\b0  31, May 2005 (Sweden)\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18 Director :\\b0 Christopher Nolan\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18 Cast : \\b0 Bruce Willis\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18Budget : \\b0 92 million USD\\par\r\n}\r\n";
            richTextBox1.BorderStyle = BorderStyle.None;
            pictureBoxControl1.RichTextBox = richTextBox1;

            pictureBoxControl1.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            pictureBoxControl1.AddControls();
            pictureBoxControl1.Size = new Size(515, 292);
            toolTipItem1.Control = pictureBoxControl1;

            toolTipInfo1.Items.Add(toolTipItem1);

            this.sfToolTip1.SetToolTipInfo(this.pictureBox1, toolTipInfo1);

            ToolTipInfo toolTipInfo2 = new ToolTipInfo();
            toolTipInfo2.MaxWidth = 1000;
            toolTipInfo2.ToolTipStyle = ToolTipStyle.Balloon;
            toolTipInfo2.BeakBackColor = ColorTranslator.FromHtml("#3D3D3D");
            toolTipInfo2.BorderColor = ColorTranslator.FromHtml("#1E1E1E");
            ToolTipItem toolTipItem2 = new ToolTipItem();
            toolTipItem2.Padding = new Padding(10);
            toolTipItem2.Style.BackColor = ColorTranslator.FromHtml("#3D3D3D");

            PictureBoxControl pictureBoxControl2 = new PictureBoxControl();
            PictureBox pictureBox2 = new PictureBox();
            pictureBox2.Image = global::GettingStarted.Properties.Resources.Jurassic_World;
            pictureBox2.Size = new Size(214, 292);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxControl2.PictureBox = pictureBox2;

            RichTextBox richTextBox2 = new RichTextBox();
            richTextBox2.Location = new Point(239, 0);
            richTextBox2.Size = new Size(297, 292);
            richTextBox2.Margin = new Padding(0);
            richTextBox2.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            richTextBox2.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red245\\green245\\blue245;}\r\n\\viewkind4\\uc1\\pard\\cf1\\lang1033\\b0\\fs12\\par\r\n\\b\\f0\\fs30 The Jurassic World \\b0\\f0\\fs4\\par\r\n\\par\r\n\\f0\\fs18 (Story of Jurassic World) \\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18 Jurassic World is a 2015 American science fiction\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 adventure film and the fourth installment\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 of the Jurassic Park series, as well as the first film\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 in a planned Jurassic World trilogy.\\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18\\b Initial Release : \\b0 29 May 2015 (US)\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18 Director \\b0 : Colin Trevorrow\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18 Cast :\\b0  Dwayne Johnson\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18 Budget :\\b0  375.7 million USD\\par\r\n}\r\n";
            richTextBox2.BorderStyle = BorderStyle.None;
            pictureBoxControl2.RichTextBox = richTextBox2;

            pictureBoxControl2.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            pictureBoxControl2.AddControls();
            pictureBoxControl2.Size = new Size(497, 292);

            toolTipItem2.Control = pictureBoxControl2;
            toolTipInfo2.Items.Add(toolTipItem2);

            this.sfToolTip1.SetToolTipInfo(this.pictureBox2, toolTipInfo2);

            ToolTipInfo toolTipInfo3 = new ToolTipInfo();
            toolTipInfo3.MaxWidth = 1000;
            toolTipInfo3.ToolTipStyle = ToolTipStyle.Balloon;
            toolTipInfo3.BeakBackColor = ColorTranslator.FromHtml("#3D3D3D");
            toolTipInfo3.BorderColor = ColorTranslator.FromHtml("#1E1E1E");
            ToolTipItem toolTipItem3 = new ToolTipItem();
            toolTipItem3.Padding = new Padding(10);
            toolTipItem3.Style.BackColor = ColorTranslator.FromHtml("#3D3D3D");

            PictureBoxControl pictureBoxControl3 = new PictureBoxControl();

            PictureBox pictureBox3 = new PictureBox();
            pictureBox3.Image = global::GettingStarted.Properties.Resources.Minions;
            pictureBox3.Size = new Size(214, 292);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxControl3.PictureBox = pictureBox3;

            RichTextBox richTextBox3 = new RichTextBox();
            richTextBox3.Location = new Point(239, 0);
            richTextBox3.Size = new Size(302, 292);
            richTextBox3.Margin = new Padding(0);
            richTextBox3.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            richTextBox3.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red245\\green245\\blue245;}\r\n\\viewkind4\\uc1\\pard\\cf1\\lang1033\\b0\\fs12\\par\r\n\\b\\f0\\fs30 The Minions\\b0\\f0\\fs4\\par\r\n\\par\r\n\\f0\\fs18 Minions film(2015)\\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18 Minions is a 2015 American 3D computer\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 comedy film,serving as a prequel to the \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 Despicable Mefranchise. It was first \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 foreshadowed in the end credits of \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 Despicable Me 2 (2013), where Kevin, Stuart\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 and Bob, three of the Minions, are seen auditioning for the film.\\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18\\b Initial Release :\\b0  22 March 2015\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18 Directors \\b0 : Chris Sanders, Kirk DeMicco\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18Cast :\\b0  Nicolas Cage\\par\r\n}\r\n";
            richTextBox3.BorderStyle = BorderStyle.None;
            pictureBoxControl3.RichTextBox = richTextBox3;

            pictureBoxControl3.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            pictureBoxControl3.AddControls();
            pictureBoxControl3.Size = new Size(502, 292);

            toolTipItem3.Control = pictureBoxControl3;
            toolTipInfo3.Items.Add(toolTipItem3);

            this.sfToolTip1.SetToolTipInfo(this.pictureBox3, toolTipInfo3);

            ToolTipInfo toolTipInfo4 = new ToolTipInfo();
            toolTipInfo4.MaxWidth = 1000;
            toolTipInfo4.ToolTipStyle = ToolTipStyle.Balloon;
            toolTipInfo4.BeakBackColor = ColorTranslator.FromHtml("#3D3D3D");
            toolTipInfo4.BorderColor = ColorTranslator.FromHtml("#1E1E1E");
            ToolTipItem toolTipItem4 = new ToolTipItem();
            toolTipItem4.Padding = new Padding(10);
            toolTipItem4.Style.BackColor = ColorTranslator.FromHtml("#3D3D3D");

            PictureBoxControl pictureBoxControl4 = new PictureBoxControl();

            PictureBox pictureBox4 = new PictureBox();
            pictureBox4.Image = global::GettingStarted.Properties.Resources.Star_Wars;
            pictureBox4.Size = new Size(214, 292);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxControl4.PictureBox = pictureBox4;

            RichTextBox richTextBox4 = new RichTextBox();
            richTextBox4.Location = new Point(239, 0);
            richTextBox4.Size = new Size(314, 292);
            richTextBox4.Margin = new Padding(0);
            richTextBox4.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            richTextBox4.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red245\\green245\\blue245;}\r\n\\viewkind4\\uc1\\pard\\cf1\\lang1033\\b0\\fs12\\par\r\n\\b\\f0\\fs30 The Star War\\b0\\f0\\fs4\\par\r\n\\par\r\n\\f0\\fs18 Forces of Destiny (2017–present)\\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18 The Star Wars franchise takes place in a distant\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 unnamed fictional galaxy at an undetermined \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 point in the ancient past, where many species \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 of aliens (often humanoid) co-exist. People own \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 robotic droids, who assist them in their daily routines,\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 and space travel is common. \\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18\\b Initial Release :\\b0  December 14, 2017\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18 Director :\\b0  George Lucas\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18 Cast :\\b0  James Franco\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18Budget : \\b0 493.3 million USD\\par\r\n}\r\n";
            richTextBox4.BorderStyle = BorderStyle.None;
            pictureBoxControl4.RichTextBox = richTextBox4;

            pictureBoxControl4.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            pictureBoxControl4.AddControls();
            pictureBoxControl4.Size = new Size(514, 292);

            toolTipItem4.Control = pictureBoxControl4;
            toolTipInfo4.Items.Add(toolTipItem4);

            this.sfToolTip1.SetToolTipInfo(this.pictureBox10, toolTipInfo4);
          
            ToolTipInfo toolTipInfo5 = new ToolTipInfo();
            toolTipInfo5.MaxWidth = 1000;
            toolTipInfo5.ToolTipStyle = ToolTipStyle.Balloon;
            toolTipInfo5.BeakBackColor = ColorTranslator.FromHtml("#3D3D3D");
            toolTipInfo5.BorderColor = ColorTranslator.FromHtml("#1E1E1E");
            ToolTipItem toolTipItem5 = new ToolTipItem();
            toolTipItem5.Padding = new Padding(10);
            toolTipItem5.Style.BackColor = ColorTranslator.FromHtml("#3D3D3D");

            PictureBoxControl pictureBoxControl5 = new PictureBoxControl();

            PictureBox pictureBox5 = new PictureBox();
            pictureBox5.Image = global::GettingStarted.Properties.Resources.Ted;
            pictureBox5.Size = new Size(214, 292);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxControl5.PictureBox = pictureBox5;

            RichTextBox richTextBox5 = new RichTextBox();
            richTextBox5.Location = new Point(239, 0);
            richTextBox5.Size = new Size(310, 292);
            richTextBox5.Margin = new Padding(0);
            richTextBox5.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            richTextBox5.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red245\\green245\\blue245;}\r\n\\viewkind4\\uc1\\pard\\cf1\\lang1033\\b0\\fs12\\par\r\n\\b\\f0\\fs30 Teddy Bear\\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18 A teddy bear is a soft toy in the form of a bear.\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 Developed apparently simultaneously by toymaker \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 Morris Michtom in the U.S in the early years of the \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 20th century.Teddy bears are among the most \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 popular gifts for children and are often given \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 to adults to signify love, congratulations or etc.. \\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18\\b \\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18\\b Introduced :\\b0  November 1902 \\par\r\n}\r\n";
            richTextBox5.BorderStyle = BorderStyle.None;
            pictureBoxControl5.RichTextBox = richTextBox5;

            pictureBoxControl5.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            pictureBoxControl5.AddControls();
            pictureBoxControl5.Size = new Size(510, 292);

            toolTipItem5.Control = pictureBoxControl5;
            toolTipInfo5.Items.Add(toolTipItem5);

            this.sfToolTip1.SetToolTipInfo(this.pictureBox4, toolTipInfo5);

            ToolTipInfo toolTipInfo6 = new ToolTipInfo();
            toolTipInfo6.MaxWidth = 1000;
            toolTipInfo6.ToolTipStyle = ToolTipStyle.Balloon;
            toolTipInfo6.BeakBackColor = ColorTranslator.FromHtml("#3D3D3D");
            toolTipInfo6.BorderColor = ColorTranslator.FromHtml("#1E1E1E");
            ToolTipItem toolTipItem6 = new ToolTipItem();
            toolTipItem6.Padding = new Padding(10);
            toolTipItem6.Style.BackColor = ColorTranslator.FromHtml("#3D3D3D");

            PictureBoxControl pictureBoxControl6 = new PictureBoxControl();

            PictureBox pictureBox6 = new PictureBox();
            pictureBox6.Image = global::GettingStarted.Properties.Resources.Troy;
            pictureBox6.Size = new Size(214, 292);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxControl6.PictureBox = pictureBox6;

            RichTextBox richTextBox6 = new RichTextBox();
            richTextBox6.Location = new Point(239, 0);
            richTextBox6.Size = new Size(280, 292);
            richTextBox6.Margin = new Padding(0);
            richTextBox6.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            richTextBox6.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red245\\green245\\blue245;}\r\n\\viewkind4\\uc1\\pard\\cf1\\lang1033\\b0\\fs12\\par\r\n\\b\\f0\\fs30 Troy\\b0\\f0\\fs4\\par\r\n\\par\r\n\\f0\\fs18 2004 - War Film\\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18 Troy is a 2004 epic period war film written by \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 David Benioff, directed by Wolfgang Petersen \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 and co-produced by units in Malta, Mexico \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 and the U.K. Shepperton Studios. The film \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 features an ensemble cast led by Brad Pitt,\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 Eric Bana, and Orlando Bloom.\\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18\\b Initial Release :\\b0  May 14, 2004 (US)\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18 Director : \\b0 Wolfgang Petersen\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18 Cast : \\b0 Tom Cruise\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18Budget : \\b0 120 million USD\\par\r\n}\r\n";
            richTextBox6.BorderStyle = BorderStyle.None;
            pictureBoxControl6.RichTextBox = richTextBox6;

            pictureBoxControl6.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            pictureBoxControl6.AddControls();
            pictureBoxControl6.Size = new Size(480, 292);

            toolTipItem6.Control = pictureBoxControl6;
            toolTipInfo6.Items.Add(toolTipItem6);

            this.sfToolTip1.SetToolTipInfo(this.pictureBox6, toolTipInfo6);

            ToolTipInfo toolTipInfo7 = new ToolTipInfo();
            toolTipInfo7.MaxWidth = 1000;
            toolTipInfo7.ToolTipStyle = ToolTipStyle.Balloon;
            toolTipInfo7.BeakBackColor = ColorTranslator.FromHtml("#3D3D3D");
            toolTipInfo7.BorderColor = ColorTranslator.FromHtml("#1E1E1E");
            ToolTipItem toolTipItem7 = new ToolTipItem();
            toolTipItem7.Padding = new Padding(10);
            toolTipItem7.Style.BackColor = ColorTranslator.FromHtml("#3D3D3D");

            PictureBoxControl pictureBoxControl7 = new PictureBoxControl();

            PictureBox pictureBox7 = new PictureBox();
            pictureBox7.Image = global::GettingStarted.Properties.Resources.V_for_Vendetta;
            pictureBox7.Size = new Size(214, 292);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxControl7.PictureBox = pictureBox7;

            RichTextBox richTextBox7 = new RichTextBox();
            richTextBox7.Location = new Point(239, 0);
            richTextBox7.Size = new Size(305, 292);
            richTextBox7.Margin = new Padding(0);
            richTextBox7.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            richTextBox7.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red245\\green245\\blue245;}\r\n\\viewkind4\\uc1\\pard\\cf1\\lang1033\\b0\\fs12\\par\r\n\\b\\f0\\fs30 V for Vendetta \\b0\\f0\\fs4\\par\r\n\\par\r\n\\f0\\fs18 Political thriller film\\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18 V for Vendetta is a 2005 dystopian political thriller \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 film directed by James McTeigue and written by\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 the wachowski brothers, based on the 1988 \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 DC/Vertigo Comics limited series of the same \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 name by Alan Moore and David Lloyd.\\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18\\b Initial Release \\b0 : December 11,2005 \\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18 Director \\b0 : James McTeigue\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18 Cast \\b0 : Robert Downer, Jr\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18Budget : \\b0 1.215 billion USD\\par\r\n}\r\n";
            richTextBox7.BorderStyle = BorderStyle.None;
            pictureBoxControl7.RichTextBox = richTextBox7;

            pictureBoxControl7.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            pictureBoxControl7.AddControls();
            pictureBoxControl7.Size = new Size(505, 292);

            toolTipItem7.Control = pictureBoxControl7;
            toolTipInfo7.Items.Add(toolTipItem7);

            this.sfToolTip1.SetToolTipInfo(this.pictureBox7, toolTipInfo7);

            ToolTipInfo toolTipInfo8 = new ToolTipInfo();
            toolTipInfo8.MaxWidth = 1000;
            toolTipInfo8.ToolTipStyle = ToolTipStyle.Balloon;
            toolTipInfo8.BeakBackColor = ColorTranslator.FromHtml("#3D3D3D");
            toolTipInfo8.BorderColor = ColorTranslator.FromHtml("#1E1E1E");
            ToolTipItem toolTipItem8 = new ToolTipItem();
            toolTipItem8.Padding = new Padding(10);
            toolTipItem8.Style.BackColor = ColorTranslator.FromHtml("#3D3D3D");

            PictureBoxControl pictureBoxControl8 = new PictureBoxControl();

            PictureBox pictureBox8 = new PictureBox();
            pictureBox8.Image = global::GettingStarted.Properties.Resources.Wall_E;
            pictureBox8.Size = new Size(214, 292);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxControl8.PictureBox = pictureBox8;

            RichTextBox richTextBox8 = new RichTextBox();
            richTextBox8.Location = new Point(239, 0);
            richTextBox8.Size = new Size(305, 292);
            richTextBox8.Margin = new Padding(0);
            richTextBox8.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            richTextBox8.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red245\\green245\\blue245;}\r\n\\viewkind4\\uc1\\pard\\cf1\\lang1033\\b0\\fs12\\par\r\n\\b\\f0\\fs30 WALL-E\\b0\\f0\\fs4\\par\r\n\\par\r\n\\f0\\fs18 computer-animated science fiction film\\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18 WALL-E (stylized with an interpunct as WALL·E)\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 is a 2008 American computer-animated science \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 fiction film produced by Pixar Animation Studios.\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 It was directed and co-written by Andrew Stanton,\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 produced by Jim Morris, and co-written by \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 Jim Reardon. \\b0\\f0\\fs28\\par\r\n\\par\r\n\\f0\\fs18\\b Initial Release : \\b0 June 27, 2008(US)\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18 Director : \\b0 Andrew Stanton\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18 Cast :\\b0  Jason Bateman\\b0\\f0\\fs6\\par\r\n\\par\r\n\\b\\f0\\fs18Budget : \\b0 174 million USD\\par\r\n}\r\n";
            richTextBox8.BorderStyle = BorderStyle.None;
            pictureBoxControl8.RichTextBox = richTextBox8;

            pictureBoxControl8.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            pictureBoxControl8.AddControls();
            pictureBoxControl8.Size = new Size(505, 292);

            toolTipItem8.Control = pictureBoxControl8;
            toolTipInfo8.Items.Add(toolTipItem8);

            this.sfToolTip1.SetToolTipInfo(this.pictureBox5, toolTipInfo8);

            this.toolTipStyleComboBox.Text = "Balloon";
            this.toolTipLocationComboBox.Text = "TopCenter";
            this.sfToolTip1.InitialDelay = 50;
            this.initialDelayUpDown.Value = this.sfToolTip1.InitialDelay;
            this.autoPopupDelayUpDown.Value = this.sfToolTip1.AutoPopDelay;
            pictureBox3Info.ToolTipLocation = ToolTipLocation.BottomCenter;
            sfToolTip1.Show(pictureBox3Info, this.PointToScreen(new Point(panel1.Location.X + panel1.Width / 2, panel1.Location.Y + 150)), 5000);
        }
        #endregion

        #region Events
        /// <summary>
        /// Occurs when ToolTipStyle ComboBox's SelectedIndex is changed. To change the ToolTipStyle of the ToolTip.
        /// </summary>
        /// <param name="sender">The sender that contains the toolTipStyleComboBox.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void toolTipStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string toolTipStyle = this.toolTipStyleComboBox.GetItemText(this.toolTipStyleComboBox.SelectedItem);

            pictureBox1Info = this.sfToolTip1.GetToolTipInfo(this.pictureBox1);
            pictureBox2Info = this.sfToolTip1.GetToolTipInfo(this.pictureBox2);
            pictureBox3Info = this.sfToolTip1.GetToolTipInfo(this.pictureBox3);
            pictureBox4Info = this.sfToolTip1.GetToolTipInfo(this.pictureBox4);
            pictureBox5Info = this.sfToolTip1.GetToolTipInfo(this.pictureBox5);
            pictureBox6Info = this.sfToolTip1.GetToolTipInfo(this.pictureBox6);
            pictureBox7Info = this.sfToolTip1.GetToolTipInfo(this.pictureBox7);
            pictureBox10Info = this.sfToolTip1.GetToolTipInfo(this.pictureBox10);

            if (pictureBox1Info != null)
                switch (toolTipStyle)
                {
                    case "Regular":
                        pictureBox1Info.ToolTipStyle = ToolTipStyle.Regular;
                        pictureBox2Info.ToolTipStyle = ToolTipStyle.Regular;
                        pictureBox3Info.ToolTipStyle = ToolTipStyle.Regular;
                        pictureBox4Info.ToolTipStyle = ToolTipStyle.Regular;
                        pictureBox5Info.ToolTipStyle = ToolTipStyle.Regular;
                        pictureBox6Info.ToolTipStyle = ToolTipStyle.Regular;
                        pictureBox7Info.ToolTipStyle = ToolTipStyle.Regular;
                        pictureBox10Info.ToolTipStyle = ToolTipStyle.Regular;
                        break;

                    case "Balloon":
                        pictureBox1Info.ToolTipStyle = ToolTipStyle.Balloon;
                        pictureBox2Info.ToolTipStyle = ToolTipStyle.Balloon;
                        pictureBox3Info.ToolTipStyle = ToolTipStyle.Balloon;
                        pictureBox4Info.ToolTipStyle = ToolTipStyle.Balloon;
                        pictureBox5Info.ToolTipStyle = ToolTipStyle.Balloon;
                        pictureBox6Info.ToolTipStyle = ToolTipStyle.Balloon;
                        pictureBox7Info.ToolTipStyle = ToolTipStyle.Balloon;
                        pictureBox10Info.ToolTipStyle = ToolTipStyle.Balloon;
                        break;
                }

            SetToolTipInfo();
        }

        /// <summary>
        /// Sets the ToolTipInfo to the controls for ToolTip.
        /// </summary>
        void SetToolTipInfo()
        {
            this.sfToolTip1.SetToolTipInfo(this.pictureBox1, pictureBox1Info);
            this.sfToolTip1.SetToolTipInfo(this.pictureBox2, pictureBox2Info);
            this.sfToolTip1.SetToolTipInfo(this.pictureBox3, pictureBox3Info);
            this.sfToolTip1.SetToolTipInfo(this.pictureBox4, pictureBox4Info);
            this.sfToolTip1.SetToolTipInfo(this.pictureBox5, pictureBox5Info);
            this.sfToolTip1.SetToolTipInfo(this.pictureBox6, pictureBox6Info);
            this.sfToolTip1.SetToolTipInfo(this.pictureBox7, pictureBox7Info);
            this.sfToolTip1.SetToolTipInfo(this.pictureBox10, pictureBox10Info);
        }

        /// <summary>
        /// Occurs when ToolTipLocation ComboBox's SelectedIndex is changed. To change the ToolTipLocation of the ToolTip.
        /// </summary>
        /// <param name="sender">The sender that contains the toolTipLocationComboBox.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void toolTipLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = this.toolTipLocationComboBox.GetItemText(this.toolTipLocationComboBox.SelectedItem);

            pictureBox1Info = this.sfToolTip1.GetToolTipInfo(this.pictureBox1);
            pictureBox2Info = this.sfToolTip1.GetToolTipInfo(this.pictureBox2);
            pictureBox3Info = this.sfToolTip1.GetToolTipInfo(this.pictureBox3);
            pictureBox4Info = this.sfToolTip1.GetToolTipInfo(this.pictureBox4);
            pictureBox5Info = this.sfToolTip1.GetToolTipInfo(this.pictureBox5);
            pictureBox6Info = this.sfToolTip1.GetToolTipInfo(this.pictureBox6);
            pictureBox7Info = this.sfToolTip1.GetToolTipInfo(this.pictureBox7);
            pictureBox10Info = this.sfToolTip1.GetToolTipInfo(this.pictureBox10);

            switch (selectedValue)
            {
                case "TopLeft":
                    pictureBox1Info.ToolTipLocation = ToolTipLocation.TopLeft;
                    pictureBox2Info.ToolTipLocation = ToolTipLocation.TopLeft;
                    pictureBox3Info.ToolTipLocation = ToolTipLocation.TopLeft;
                    pictureBox4Info.ToolTipLocation = ToolTipLocation.TopLeft;
                    pictureBox5Info.ToolTipLocation = ToolTipLocation.TopLeft;
                    pictureBox6Info.ToolTipLocation = ToolTipLocation.TopLeft;
                    pictureBox7Info.ToolTipLocation = ToolTipLocation.TopLeft;
                    pictureBox10Info.ToolTipLocation = ToolTipLocation.TopLeft;
                    break;

                case "TopRight":
                    pictureBox1Info.ToolTipLocation = ToolTipLocation.TopRight;
                    pictureBox2Info.ToolTipLocation = ToolTipLocation.TopRight;
                    pictureBox3Info.ToolTipLocation = ToolTipLocation.TopRight;
                    pictureBox4Info.ToolTipLocation = ToolTipLocation.TopRight;
                    pictureBox5Info.ToolTipLocation = ToolTipLocation.TopRight;
                    pictureBox6Info.ToolTipLocation = ToolTipLocation.TopRight;
                    pictureBox7Info.ToolTipLocation = ToolTipLocation.TopRight;
                    pictureBox10Info.ToolTipLocation = ToolTipLocation.TopRight;
                    break;

                case "TopCenter":
                    pictureBox1Info.ToolTipLocation = ToolTipLocation.TopCenter;
                    pictureBox2Info.ToolTipLocation = ToolTipLocation.TopCenter;
                    pictureBox3Info.ToolTipLocation = ToolTipLocation.TopCenter;
                    pictureBox4Info.ToolTipLocation = ToolTipLocation.TopCenter;
                    pictureBox5Info.ToolTipLocation = ToolTipLocation.TopCenter;
                    pictureBox6Info.ToolTipLocation = ToolTipLocation.TopCenter;
                    pictureBox7Info.ToolTipLocation = ToolTipLocation.TopCenter;
                    pictureBox10Info.ToolTipLocation = ToolTipLocation.TopCenter;
                    break;

                case "BottomCenter":
                    pictureBox1Info.ToolTipLocation = ToolTipLocation.BottomCenter;
                    pictureBox2Info.ToolTipLocation = ToolTipLocation.BottomCenter;
                    pictureBox3Info.ToolTipLocation = ToolTipLocation.BottomCenter;
                    pictureBox4Info.ToolTipLocation = ToolTipLocation.BottomCenter;
                    pictureBox5Info.ToolTipLocation = ToolTipLocation.BottomCenter;
                    pictureBox6Info.ToolTipLocation = ToolTipLocation.BottomCenter;
                    pictureBox7Info.ToolTipLocation = ToolTipLocation.BottomCenter;
                    pictureBox10Info.ToolTipLocation = ToolTipLocation.BottomCenter;
                    break;

                case "BottomLeft":
                    pictureBox1Info.ToolTipLocation = ToolTipLocation.BottomLeft;
                    pictureBox2Info.ToolTipLocation = ToolTipLocation.BottomLeft;
                    pictureBox3Info.ToolTipLocation = ToolTipLocation.BottomLeft;
                    pictureBox4Info.ToolTipLocation = ToolTipLocation.BottomLeft;
                    pictureBox5Info.ToolTipLocation = ToolTipLocation.BottomLeft;
                    pictureBox6Info.ToolTipLocation = ToolTipLocation.BottomLeft;
                    pictureBox7Info.ToolTipLocation = ToolTipLocation.BottomLeft;
                    pictureBox10Info.ToolTipLocation = ToolTipLocation.BottomLeft;
                    break;

                case "BottomRight":
                    pictureBox1Info.ToolTipLocation = ToolTipLocation.BottomRight;
                    pictureBox2Info.ToolTipLocation = ToolTipLocation.BottomRight;
                    pictureBox3Info.ToolTipLocation = ToolTipLocation.BottomRight;
                    pictureBox4Info.ToolTipLocation = ToolTipLocation.BottomRight;
                    pictureBox5Info.ToolTipLocation = ToolTipLocation.BottomRight;
                    pictureBox6Info.ToolTipLocation = ToolTipLocation.BottomRight;
                    pictureBox7Info.ToolTipLocation = ToolTipLocation.BottomRight;
                    pictureBox10Info.ToolTipLocation = ToolTipLocation.BottomRight;
                    break;

                case "LeftCenter":
                    pictureBox1Info.ToolTipLocation = ToolTipLocation.LeftCenter;
                    pictureBox2Info.ToolTipLocation = ToolTipLocation.LeftCenter;
                    pictureBox3Info.ToolTipLocation = ToolTipLocation.LeftCenter;
                    pictureBox4Info.ToolTipLocation = ToolTipLocation.LeftCenter;
                    pictureBox5Info.ToolTipLocation = ToolTipLocation.LeftCenter;
                    pictureBox6Info.ToolTipLocation = ToolTipLocation.LeftCenter;
                    pictureBox7Info.ToolTipLocation = ToolTipLocation.LeftCenter;
                    pictureBox10Info.ToolTipLocation = ToolTipLocation.LeftCenter;
                    break;

                case "RightCenter":
                    pictureBox1Info.ToolTipLocation = ToolTipLocation.RightCenter;
                    pictureBox2Info.ToolTipLocation = ToolTipLocation.RightCenter;
                    pictureBox3Info.ToolTipLocation = ToolTipLocation.RightCenter;
                    pictureBox4Info.ToolTipLocation = ToolTipLocation.RightCenter;
                    pictureBox5Info.ToolTipLocation = ToolTipLocation.RightCenter;
                    pictureBox6Info.ToolTipLocation = ToolTipLocation.RightCenter;
                    pictureBox7Info.ToolTipLocation = ToolTipLocation.RightCenter;
                    pictureBox10Info.ToolTipLocation = ToolTipLocation.RightCenter;
                    break;

                case "Default":
                    pictureBox1Info.ToolTipLocation = ToolTipLocation.Default;
                    pictureBox2Info.ToolTipLocation = ToolTipLocation.Default;
                    pictureBox3Info.ToolTipLocation = ToolTipLocation.Default;
                    pictureBox4Info.ToolTipLocation = ToolTipLocation.Default;
                    pictureBox5Info.ToolTipLocation = ToolTipLocation.Default;
                    pictureBox6Info.ToolTipLocation = ToolTipLocation.Default;
                    pictureBox7Info.ToolTipLocation = ToolTipLocation.Default;
                    pictureBox10Info.ToolTipLocation = ToolTipLocation.Default;
                    break;
            }

            SetToolTipInfo();
        }

        /// <summary>
        /// Changes the InitialDelay of the SfToolTip.
        /// </summary>
        /// <param name="sender">The sender that contains the NumericUpdownControl.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void initialDelayUpDown_ValueChanged(object sender, EventArgs e)
        {
            sfToolTip1.InitialDelay = (int)this.initialDelayUpDown.Value;
        }

        /// <summary>
        /// Changes the AutoPopDelay of the SfToolTip.
        /// </summary>
        /// <param name="sender">The sender that contains the NumericUpdownControl.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains event data.</param>
        private void autoPopupDelayUpDown_ValueChanged(object sender, EventArgs e)
        {
            sfToolTip1.AutoPopDelay = (int)this.autoPopupDelayUpDown.Value;
        }

        #endregion
    }
}
