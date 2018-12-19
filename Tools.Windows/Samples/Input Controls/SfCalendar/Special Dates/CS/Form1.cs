using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Syncfusion.WinForms.Input;
using Syncfusion.WinForms.Input.Events;

namespace SfCalendar_2015
{
    public partial class Form1 : MetroForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Functions

        /// <summary>
        /// Method to Make panel Center
        /// </summary>
        public void MakePanelCenter()
        {
            this.borderPanel1.Location = new Point(this.ClientSize.Width / 2 - borderPanel1.Size.Width / 2, this.ClientSize.Height / 2 - borderPanel1.Size.Height / 2);
        }

        #endregion

        #region Events

        /// <summary>
        /// To make the panel center on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            MakePanelCenter();
            ConfigureSpecialDate();
            this.sfCalendar.ShowToolTip = true;
            this.sfCalendar.ToolTipOpening += SfCalendar_ToolTipOpening;
        }

        /// <summary>
        /// Event raise to handle the ToolTip for cell in calender
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfCalendar_ToolTipOpening(SfCalendar sender, ToolTipOpeningEventArgs e)
        {
            if(e.ViewType == Syncfusion.WinForms.Input.Enums.CalendarViewType.Month && !e.IsSpecialDate)
            {
                e.Handled = true;
            }
            if (e.ViewType == Syncfusion.WinForms.Input.Enums.CalendarViewType.Year)
            {
                e.Handled = true;
            }
            if (e.ViewType == Syncfusion.WinForms.Input.Enums.CalendarViewType.Decade)
            {
                e.Handled = true;
            }
            if (e.ViewType == Syncfusion.WinForms.Input.Enums.CalendarViewType.Century)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Make the panel center on form resize
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            MakePanelCenter();
            base.OnSizeChanged(e);
        }

        /// <summary>
        /// Calender Selection Change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfCalendar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bool isspecialdate = false;
            foreach(SpecialDate specialdate in sfCalendar.SpecialDates)
            {
                if(specialdate.Value == this.sfCalendar.SelectedDate)
                {
                    this.label3.Text = specialdate.Value.ToLongDateString() + " ( " + specialdate.Description + " )";
                    isspecialdate = true;
                    break;
                }
            }
            
            if(!isspecialdate)
            {
                this.label3.Text = this.sfCalendar.SelectedDate.Value.ToLongDateString();
            }
        }
        #endregion

        #region Special Date

        /// <summary>
        /// Method to configure SpecialDate
        /// </summary>
        public void ConfigureSpecialDate()
        {
            SpecialDate specialDate1 = new SpecialDate();
            SpecialDate specialDate2 = new SpecialDate();
            SpecialDate specialDate3 = new SpecialDate();
            SpecialDate specialDate4 = new SpecialDate();
            SpecialDate specialDate5 = new SpecialDate();
            SpecialDate specialDate6 = new SpecialDate();
            SpecialDate specialDate7 = new SpecialDate();
            SpecialDate specialDate8 = new SpecialDate();
            SpecialDate specialDate9 = new SpecialDate();
            SpecialDate specialDate10 = new SpecialDate();
            SpecialDate specialDate11 = new SpecialDate();
            SpecialDate specialDate12 = new SpecialDate();
            SpecialDate specialDate13 = new SpecialDate();
            SpecialDate specialDate14 = new SpecialDate();
            SpecialDate specialDate15 = new SpecialDate();
            SpecialDate specialDate16 = new SpecialDate();
            SpecialDate specialDate17 = new SpecialDate();
            SpecialDate specialDate18 = new SpecialDate();
            SpecialDate specialDate19 = new SpecialDate();
            SpecialDate specialDate20 = new SpecialDate();
            SpecialDate specialDate21 = new SpecialDate();
            SpecialDate specialDate22 = new SpecialDate();
            SpecialDate specialDate23 = new SpecialDate();
            SpecialDate specialDate24 = new SpecialDate();
            SpecialDate specialDate25 = new SpecialDate();
            SpecialDate specialDate26 = new SpecialDate();
            SpecialDate specialDate27 = new SpecialDate();
            SpecialDate specialDate28 = new SpecialDate();
            List<SpecialDate> SpecialDates = new List<SpecialDate>();
            specialDate1.BackColor = System.Drawing.Color.White;
            specialDate1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate1.ForeColor = System.Drawing.Color.Magenta;
            specialDate1.Image = Properties.Resources.Icon_National_Youth_day;
            specialDate1.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate1.IsDateVisible = false;
            specialDate1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate1.Value = new System.DateTime(2018, 1, 12, 0, 0, 0, 0);
            specialDate1.Description = "National Youth Day";
            //
            specialDate2.BackColor = System.Drawing.Color.White;
            specialDate2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate2.ForeColor = System.Drawing.Color.Magenta;
            specialDate2.Image = Properties.Resources.Icon_Army_day;
            specialDate2.Description = "Army Day";
            specialDate2.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate2.IsDateVisible = false;
            specialDate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate2.Value = new System.DateTime(2018, 1, 15, 0, 0, 0, 0); specialDate1.BackColor = System.Drawing.Color.White;
            //
            specialDate3.BackColor = System.Drawing.Color.White;
            specialDate3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate3.ForeColor = System.Drawing.Color.Magenta;
            specialDate3.Image = Properties.Resources.Icon_Cancer_day;
            specialDate3.Description = "World Cancer Day";
            specialDate3.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate3.IsDateVisible = false;
            specialDate3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate3.Value = new System.DateTime(2018, 2, 4, 0, 0, 0, 0);
            //
            specialDate4.BackColor = System.Drawing.Color.White;
            specialDate4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate4.ForeColor = System.Drawing.Color.Magenta;
            specialDate4.Image = Properties.Resources.Valentine_day;
            specialDate4.Description = "Valentine Day";
            specialDate4.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate4.IsDateVisible = false;
            specialDate4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate4.Value = new System.DateTime(2018, 2, 14, 0, 0, 0, 0);
            //
            specialDate5.BackColor = System.Drawing.Color.White;
            specialDate5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate5.ForeColor = System.Drawing.Color.Magenta;
            specialDate5.Image = Properties.Resources.Icon_Pollution_day;
            specialDate5.Description = "Pollution Prevention Day";
            specialDate5.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate5.IsDateVisible = false;
            specialDate5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate5.Value = new System.DateTime(2018, 12, 2, 0, 0, 0, 0);
            //
            specialDate6.BackColor = System.Drawing.Color.White;
            specialDate6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate6.ForeColor = System.Drawing.Color.Magenta;
            specialDate6.Image = Properties.Resources.icons_Womens_day;
            specialDate6.Description = "International Women’s Day";
            specialDate6.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate6.IsDateVisible = false;
            specialDate6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate6.Value = new System.DateTime(2018, 3, 8, 0, 0, 0, 0);
            //
            specialDate7.BackColor = System.Drawing.Color.White;
            specialDate7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate7.ForeColor = System.Drawing.Color.Magenta;
            specialDate7.Description = "World Forestry Day";
            specialDate7.Image = Properties.Resources.Icon_World_Forestry_Day;
            specialDate7.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate7.IsDateVisible = false;
            specialDate7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate7.Value = new System.DateTime(2018, 3, 21, 0, 0, 0, 0);
            //
            specialDate8.BackColor = System.Drawing.Color.White;
            specialDate8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate8.ForeColor = System.Drawing.Color.Magenta;
            specialDate8.Image = Properties.Resources.Icon_Water_day;
            specialDate8.Description = "World Day for Water";
            specialDate8.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate8.IsDateVisible = false;
            specialDate8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate8.Value = new System.DateTime(2018, 3, 24, 0, 0, 0, 0);
            //
            specialDate9.BackColor = System.Drawing.Color.White;
            specialDate9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate9.ForeColor = System.Drawing.Color.Magenta;
            specialDate9.Image = Properties.Resources.Icon_Healthy_day;
            specialDate9.Description = "World Health Day";
            specialDate9.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate9.IsDateVisible = false;
            specialDate9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate9.Value = new System.DateTime(2018, 4, 7, 0, 0, 0, 0);
            //
            specialDate10.BackColor = System.Drawing.Color.White;
            specialDate10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate10.ForeColor = System.Drawing.Color.Magenta;
            specialDate10.Image = Properties.Resources.Icon_Earth_day;
            specialDate10.Description = "Earth Day";
            specialDate10.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate10.IsDateVisible = false;
            specialDate10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate10.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate10.Value = new System.DateTime(2018, 4, 22, 0, 0, 0, 0);
            //
            specialDate11.BackColor = System.Drawing.Color.White;
            specialDate11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate11.ForeColor = System.Drawing.Color.Magenta;
            specialDate11.Image = Properties.Resources.Icon_Workers_day;
            specialDate11.Description = "Workers’ Day";
            specialDate11.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate11.IsDateVisible = false;
            specialDate11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate11.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate11.Value = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            //

            specialDate26.BackColor = System.Drawing.Color.White;
            specialDate26.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate26.ForeColor = System.Drawing.Color.Magenta;
            specialDate26.Image = Properties.Resources.Icon_Anti_tobacco;
            specialDate26.Description = "Anti-tobacco Day";
            specialDate26.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate26.IsDateVisible = false;
            specialDate26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate26.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate26.Value = new System.DateTime(2018, 5, 31, 0, 0, 0, 0);
            //

            specialDate12.BackColor = System.Drawing.Color.White;
            specialDate12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate12.ForeColor = System.Drawing.Color.Magenta;
            specialDate12.Image = Properties.Resources.Icon_Environmental_day;
            specialDate12.Description = "World Environment Day";
            specialDate12.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate12.IsDateVisible = false;
            specialDate12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate12.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate12.Value = new System.DateTime(2018, 6, 5, 0, 0, 0, 0);

            //
            specialDate13.BackColor = System.Drawing.Color.White;
            specialDate13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate13.ForeColor = System.Drawing.Color.Magenta;
            specialDate13.Image = Properties.Resources.Icon_Blood_donar_day;
            specialDate13.Description = "World Blood Donor Day";
            specialDate13.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate13.IsDateVisible = false;
            specialDate13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate13.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate13.Value = new System.DateTime(2018, 6, 14, 0, 0, 0, 0);
            //
            specialDate14.BackColor = System.Drawing.Color.White;
            specialDate14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate14.ForeColor = System.Drawing.Color.Magenta;
            specialDate14.Image = Properties.Resources.Icon_Yoga_day;
            specialDate14.Description = "International day of yoga";
            specialDate14.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate14.IsDateVisible = false;
            specialDate14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate14.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate14.Value = new System.DateTime(2018, 6, 21, 0, 0, 0, 0);
            //
            specialDate15.BackColor = System.Drawing.Color.White;
            specialDate15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate15.ForeColor = System.Drawing.Color.Magenta;
            specialDate15.Image = Properties.Resources.Icon_Doctor_day;
            specialDate15.Description = "Doctor’s Day";
            specialDate15.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate15.IsDateVisible = false;
            specialDate15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate15.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate15.Value = new System.DateTime(2018, 7, 1, 0, 0, 0, 0);
            //
            specialDate16.BackColor = System.Drawing.Color.White;
            specialDate16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate16.ForeColor = System.Drawing.Color.Magenta;
            specialDate16.Image = Properties.Resources.Icon_Hiroshima_day;
            specialDate16.Description = "Hiroshima Day";
            specialDate16.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate16.IsDateVisible = false;
            specialDate16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate16.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate16.Value = new System.DateTime(2018, 8, 6, 0, 0, 0, 0);
            //
            specialDate16.BackColor = System.Drawing.Color.White;
            specialDate16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate16.ForeColor = System.Drawing.Color.Magenta;
            specialDate16.Image = Properties.Resources.Icon_Photography_day;
            specialDate16.Description = "Photography Day";
            specialDate16.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate16.IsDateVisible = false;
            specialDate16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate16.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate16.Value = new System.DateTime(2018, 8, 19, 0, 0, 0, 0);
            //
            specialDate17.BackColor = System.Drawing.Color.White;
            specialDate17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate17.ForeColor = System.Drawing.Color.Magenta;
            specialDate17.Image = Properties.Resources.Icon_Sports_day;
            specialDate17.Description = "National Sports Day";
            specialDate17.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate17.IsDateVisible = false;
            specialDate17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate17.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate17.Value = new System.DateTime(2018, 8, 29, 0, 0, 0, 0);
            //
            specialDate18.BackColor = System.Drawing.Color.White;
            specialDate18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate18.ForeColor = System.Drawing.Color.Magenta;
            specialDate18.Image = Properties.Resources.Icon_Engineer_day;
            specialDate18.Description = "Engineer's Day";
            specialDate18.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate18.IsDateVisible = false;
            specialDate18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate18.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate18.Value = new System.DateTime(2018, 9, 15, 0, 0, 0, 0);
            //
            //
            specialDate27.BackColor = System.Drawing.Color.White;
            specialDate27.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate27.ForeColor = System.Drawing.Color.Magenta;
            specialDate27.Image = Properties.Resources.Icon_Ozone_day;
            specialDate27.Description = "World Ozone Day";
            specialDate27.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate27.IsDateVisible = false;
            specialDate27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate27.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate27.Value = new System.DateTime(2018, 9, 16, 0, 0, 0, 0);
            //
            specialDate19.BackColor = System.Drawing.Color.White;
            specialDate19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate19.ForeColor = System.Drawing.Color.Magenta;
            specialDate19.Image = Properties.Resources.Icon_Tourism;
            specialDate19.Description = "World Tourism Day";
            specialDate19.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate19.IsDateVisible = false;
            specialDate19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate19.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate19.Value = new System.DateTime(2018, 9, 27, 0, 0, 0, 0);

            //
            specialDate28.BackColor = System.Drawing.Color.White;
            specialDate28.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate28.ForeColor = System.Drawing.Color.Magenta;
            specialDate28.Image = Properties.Resources.Icon_Post;
            specialDate28.Description = "World Post Office Day";
            specialDate28.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate28.IsDateVisible = false;
            specialDate28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate28.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate28.Value = new System.DateTime(2018, 10, 9, 0, 0, 0, 0);
            //
            //
            specialDate20.BackColor = System.Drawing.Color.White;
            specialDate20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate20.ForeColor = System.Drawing.Color.Magenta;
            specialDate20.Image = Properties.Resources.Icon_Food_day;
            specialDate20.Description = "World Food Day";
            specialDate20.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate20.IsDateVisible = false;
            specialDate20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate20.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate20.Value = new System.DateTime(2018, 10, 16, 0, 0, 0, 0);
            //
            //
            specialDate21.BackColor = System.Drawing.Color.White;
            specialDate21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate21.ForeColor = System.Drawing.Color.Magenta;
            specialDate21.Image = Properties.Resources.Icon_Tsunami;
            specialDate21.Description = "World Tsunami Day";
            specialDate21.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate21.IsDateVisible = false;
            specialDate21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate21.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate21.Value = new System.DateTime(2018, 11, 5, 0, 0, 0, 0);
            //
            specialDate22.BackColor = System.Drawing.Color.White;
            specialDate22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate22.ForeColor = System.Drawing.Color.Magenta;
            specialDate22.Image = Properties.Resources.Icon_Childrens_day;
            specialDate22.Description = "Children’s Day";
            specialDate22.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate22.IsDateVisible = false;
            specialDate22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate22.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate22.Value = new System.DateTime(2018, 11, 14, 0, 0, 0, 0);
            //
            specialDate23.BackColor = System.Drawing.Color.White;
            specialDate23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate23.ForeColor = System.Drawing.Color.Magenta;
            specialDate23.Image = Properties.Resources.Icon_AIDS_day;
            specialDate23.Description = "World AIDS Day";
            specialDate23.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate23.IsDateVisible = false;
            specialDate23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate23.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate23.Value = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            //
            specialDate24.BackColor = System.Drawing.Color.White;
            specialDate24.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate24.ForeColor = System.Drawing.Color.Magenta;
            specialDate24.Image = Properties.Resources.Icon_Mathematics_day;
            specialDate24.Description = "National Mathematics Day";
            specialDate24.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate24.IsDateVisible = false;
            specialDate24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate24.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate24.Value = new System.DateTime(2018, 12, 22, 0, 0, 0, 0);
            //
            specialDate25.BackColor = System.Drawing.Color.White;
            specialDate25.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate25.ForeColor = System.Drawing.Color.Magenta;
            specialDate25.Image = Properties.Resources.Icon_Christmas_day;
            specialDate25.Description = "Christmas";
            specialDate25.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate25.IsDateVisible = false;
            specialDate25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            specialDate25.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            specialDate25.Value = new System.DateTime(2018, 12, 25, 0, 0, 0, 0);

            this.sfCalendar.SpecialDates = SpecialDates;
            SpecialDates.Add(specialDate1);
            SpecialDates.Add(specialDate2);
            SpecialDates.Add(specialDate3);
            SpecialDates.Add(specialDate4);
            SpecialDates.Add(specialDate5);
            SpecialDates.Add(specialDate6);
            SpecialDates.Add(specialDate7);
            SpecialDates.Add(specialDate8);
            SpecialDates.Add(specialDate9);
            SpecialDates.Add(specialDate10);
            SpecialDates.Add(specialDate11);
            SpecialDates.Add(specialDate12);
            SpecialDates.Add(specialDate13);
            SpecialDates.Add(specialDate14);
            SpecialDates.Add(specialDate15);
            SpecialDates.Add(specialDate16);
            SpecialDates.Add(specialDate17);
            SpecialDates.Add(specialDate18);
            SpecialDates.Add(specialDate19);
            SpecialDates.Add(specialDate20);
            SpecialDates.Add(specialDate21);
            SpecialDates.Add(specialDate22);
            SpecialDates.Add(specialDate23);
            SpecialDates.Add(specialDate24);
            SpecialDates.Add(specialDate25);
            SpecialDates.Add(specialDate26);
            SpecialDates.Add(specialDate27);
            SpecialDates.Add(specialDate28);
            this.sfCalendar.SelectedDate = (new DateTime(2018, 01, 12));
        }
            #endregion

        }
}
