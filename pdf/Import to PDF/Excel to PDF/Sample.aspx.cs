using System;
using System.Web.UI;

public partial class ScheduleTemplteSample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Master != null)
        {
            SampleBrowser master = Page.Master as SampleBrowser;
            //master.TogglePanelTitle = "Excel to PDF";
            Image1.ImageUrl = "~/Import to PDF/Excel to PDF/Images/ExcelToPDF.png";           
        }
    }
}
