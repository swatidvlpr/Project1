using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hr_Attendanceshow : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                gl.query("Select E_Code,Name,Category,Department,Shift, InTime,OutTime,Work_Dur,RIGHT(CONVERT(VARCHAR, InTime, 100),11) as InTime1,RIGHT(CONVERT(VARCHAR, OutTime, 100),11) as OutTime1,RIGHT(CONVERT(VARCHAR, Work_Dur, 100),11) as Work_Dur1,RIGHT(CONVERT(VARCHAR, Tot_Dur, 100),11) as Tot_Dur1,CONVERT(varchar, CAST(Date AS datetime), 103) as date,Status From Daily_attendance WHERE MONTH(Date) = MONTH(dateadd(dd, -1, GetDate()))");
                GridView1.DataSource = gl.ds;
                GridView1.DataBind();

                for (int i = 2018; i <= 2045; i++)
                {
                    DropDownList2.Items.Add(i.ToString());
                }

            }
        }
        catch
        { 
        
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //TableCell statusCell = e.Row.Cells[5].Text;
                string ecode = e.Row.Cells[0].Text;
                string ename = e.Row.Cells[1].Text;
                string ecategory = e.Row.Cells[2].Text;
                string edept = e.Row.Cells[3].Text;
                string date = e.Row.Cells[9].Text;
                DateTime crntdt = Convert.ToDateTime(date);
                TimeZoneInfo tzn1 = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime IndianTmetodt = TimeZoneInfo.ConvertTime(crntdt, tzn1);
                string dt = IndianTmetodt.ToString("M/dd/yyyy");



                string intime = e.Row.Cells[5].Text;

                DateTime t1 = Convert.ToDateTime((intime));
                DateTime t2 = Convert.ToDateTime(("09:45 AM"));

                string outtime = e.Row.Cells[6].Text;
                DateTime tout = Convert.ToDateTime((outtime));
                DateTime tout2 = Convert.ToDateTime(("06:00 PM"));

                DateTime helf = Convert.ToDateTime(("12:00 PM"));

                if (t1.TimeOfDay.Ticks > t2.TimeOfDay.Ticks || tout.TimeOfDay.Ticks < tout2.TimeOfDay.Ticks)
                {

                    if (t1.TimeOfDay.Ticks > helf.TimeOfDay.Ticks)
                    {
                        gl.insert1("Total_attendance", "E_Code, name, Category, Department, Present, Absent, halfday, onethirdday, date", "'" + ecode + "','" + ename + "','" + ecategory + "','" + edept + "',0,0,1,'0','" + dt + "'");
                    }
                    else
                    {
                        if (t1.TimeOfDay.Ticks == 0 || tout.TimeOfDay.Ticks == 0)
                        {
                            gl.insert1("Total_attendance", "E_Code, name, Category, Department, Present, Absent, halfday, onethirdday, date", "'" + ecode + "','" + ename + "','" + ecategory + "','" + edept + "',0,1,0,'0','" + dt + "'");
                        }
                        else
                        {
                            string ss = "Late";
                            Button btn = (e.Row.FindControl("Button4") as Button);
                            btn.Text = "Late";
                            //E_Code, name, Category, Department, Present, Absent, halfday, onethirdday, date
                            gl.insert1("Total_attendance", "E_Code, name, Category, Department, Present, Absent, halfday, onethirdday, date", "'" + ecode + "','" + ename + "','" + ecategory + "','" + edept + "',0,0,0,'1','" + dt + "'");
                        }
                    }
                }
                else
                {
                    Button btn = (e.Row.FindControl("Button4") as Button);
                    btn.Text = "Ok";
                    gl.insert1("Total_attendance", "E_Code, name, Category, Department, Present, Absent, halfday, onethirdday, date", "'" + ecode + "','" + ename + "','" + ecategory + "','" + edept + "',1,0,0,'0','" + dt + "'");
                }



            }
        }
        catch
        { 
        
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                if (DropDownList2.SelectedIndex == 0)
                {
                    if (TextBox1.Text == "")
                    {
                        if (DropDownList3.SelectedIndex == 0)
                        {

                        }
                        else
                        {
                            if (TextBox2.Text == "")
                            {
                                gl.query("Select E_Code,Name,Category,Department,Shift, InTime,OutTime,Work_Dur,RIGHT(CONVERT(VARCHAR, InTime, 100),11) as InTime1,RIGHT(CONVERT(VARCHAR, OutTime, 100),11) as OutTime1,RIGHT(CONVERT(VARCHAR, Work_Dur, 100),11) as Work_Dur1,RIGHT(CONVERT(VARCHAR, Tot_Dur, 100),11) as Tot_Dur1,CONVERT(varchar, CAST(Date AS datetime), 103) as date,Status From Daily_attendance WHERE Status ='" + DropDownList3.SelectedItem.Text + "'");
                                GridView1.DataSource = gl.ds;
                                GridView1.DataBind();
                            }
                            else
                            {
                                gl.query("Select E_Code,Name,Category,Department,Shift, InTime,OutTime,Work_Dur,RIGHT(CONVERT(VARCHAR, InTime, 100),11) as InTime1,RIGHT(CONVERT(VARCHAR, OutTime, 100),11) as OutTime1,RIGHT(CONVERT(VARCHAR, Work_Dur, 100),11) as Work_Dur1,RIGHT(CONVERT(VARCHAR, Tot_Dur, 100),11) as Tot_Dur1,CONVERT(varchar, CAST(Date AS datetime), 103) as date,Status From Daily_attendance WHERE Status ='" + DropDownList3.SelectedItem.Text + "' and E_Code='" + TextBox2.Text + "'");
                                GridView1.DataSource = gl.ds;
                                GridView1.DataBind();
                            }
                        }
                    }
                    else
                    {
                        if (TextBox2.Text == "")
                        {
                            gl.query("Select E_Code,Name,Category,Department,Shift, InTime,OutTime,Work_Dur,RIGHT(CONVERT(VARCHAR, InTime, 100),11) as InTime1,RIGHT(CONVERT(VARCHAR, OutTime, 100),11) as OutTime1,RIGHT(CONVERT(VARCHAR, Work_Dur, 100),11) as Work_Dur1,RIGHT(CONVERT(VARCHAR, Tot_Dur, 100),11) as Tot_Dur1,CONVERT(varchar, CAST(Date AS datetime), 103) as date,Status From Daily_attendance WHERE CONVERT(varchar, CAST(Date AS datetime), 103) ='" + TextBox1.Text + "'");
                            GridView1.DataSource = gl.ds;
                            GridView1.DataBind();

                        }
                        else
                        {

                            gl.query("Select E_Code,Name,Category,Department,Shift, InTime,OutTime,Work_Dur,RIGHT(CONVERT(VARCHAR, InTime, 100),11) as InTime1,RIGHT(CONVERT(VARCHAR, OutTime, 100),11) as OutTime1,RIGHT(CONVERT(VARCHAR, Work_Dur, 100),11) as Work_Dur1,RIGHT(CONVERT(VARCHAR, Tot_Dur, 100),11) as Tot_Dur1,CONVERT(varchar, CAST(Date AS datetime), 103) as date,Status From Daily_attendance WHERE CONVERT(varchar, CAST(Date AS datetime), 103) ='" + TextBox1.Text + "' and E_Code='" + TextBox2.Text + "'");
                            GridView1.DataSource = gl.ds;
                            GridView1.DataBind();


                        }

                    }

                }
                else
                {
                    gl.query("Select E_Code,Name,Category,Department,Shift, InTime,OutTime,Work_Dur,RIGHT(CONVERT(VARCHAR, InTime, 100),11) as InTime1,RIGHT(CONVERT(VARCHAR, OutTime, 100),11) as OutTime1,RIGHT(CONVERT(VARCHAR, Work_Dur, 100),11) as Work_Dur1,RIGHT(CONVERT(VARCHAR, Tot_Dur, 100),11) as Tot_Dur1,CONVERT(varchar, CAST(Date AS datetime), 103) as date,Status From Daily_attendance WHERE Year(Date) ='" + DropDownList2.SelectedValue + "'");
                    GridView1.DataSource = gl.ds;
                    GridView1.DataBind();
                }

            }
            else
            {
                if (TextBox2.Text == "")
                {
                    gl.query("Select E_Code,Name,Category,Department,Shift, InTime,OutTime,Work_Dur,RIGHT(CONVERT(VARCHAR, InTime, 100),11) as InTime1,RIGHT(CONVERT(VARCHAR, OutTime, 100),11) as OutTime1,RIGHT(CONVERT(VARCHAR, Work_Dur, 100),11) as Work_Dur1,RIGHT(CONVERT(VARCHAR, Tot_Dur, 100),11) as Tot_Dur1,CONVERT(varchar, CAST(Date AS datetime), 103) as date,Status From Daily_attendance WHERE Month(Date) ='" + DropDownList1.SelectedValue + "' and Year(Date) ='" + DropDownList2.SelectedValue + "'");
                    GridView1.DataSource = gl.ds;
                    GridView1.DataBind();
                }
                else
                {
                    gl.query("Select E_Code,Name,Category,Department,Shift, InTime,OutTime,Work_Dur,RIGHT(CONVERT(VARCHAR, InTime, 100),11) as InTime1,RIGHT(CONVERT(VARCHAR, OutTime, 100),11) as OutTime1,RIGHT(CONVERT(VARCHAR, Work_Dur, 100),11) as Work_Dur1,RIGHT(CONVERT(VARCHAR, Tot_Dur, 100),11) as Tot_Dur1,CONVERT(varchar, CAST(Date AS datetime), 103) as date,Status From Daily_attendance WHERE Month(Date) ='" + DropDownList1.SelectedValue + "' and Year(Date) ='" + DropDownList2.SelectedValue + "' and E_Code='" + TextBox2.Text + "'");
                    GridView1.DataSource = gl.ds;
                    GridView1.DataBind();
                }
            }
        }
        catch
        { 
        
        
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Attendanceshow.aspx");
    }
}