using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Hr_Emp_sal : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    
    {
        if (!IsPostBack)
        {
            gl.ddl_select("Departmentmaster", "Depart_id,Departmentnm", "Departmentnm", "Depart_id","0","'Select'",ddldepartment);
            DateTime crnttime =DateTime.Now;
            TimeZoneInfo tzn = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime IndianTme = TimeZoneInfo.ConvertTime(crnttime, tzn);
          
            string year1 = IndianTme.ToString("yyyy");
            int year = Convert.ToInt32(year1);
            int yr = year + 5;
            for (int i = 2017; i <= yr; i++)
            {
                ddlyear.Items.Add(i.ToString());


            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int year=Convert.ToInt32(ddlyear.SelectedValue);
        int month=Convert.ToInt32(ddlmonth.SelectedValue);
        Response.Write(SundaysInMonth(new DateTime(year, month, 1)));
        int ii = SundaysInMonth(new DateTime(year, month, 1));
        txtno_of_sunday.Text = ii.ToString();
    }

    
    public static int SundaysInMonth(DateTime thisMonth)
{
    int sundays = 0;
    int month = thisMonth.Month;
    int year = thisMonth.Year;
    int daysThisMonth = DateTime.DaysInMonth(year, month);
    DateTime beginingOfThisMonth = new DateTime(year, month, 1);
    for (int i = 0; i < daysThisMonth; i++)
        if (beginingOfThisMonth.AddDays(i).DayOfWeek == DayOfWeek.Sunday)
            sundays++;
    return sundays;
}
}