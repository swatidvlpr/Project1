using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hr_Attendancesearch : System.Web.UI.Page
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
                gl.ddl_select("companymaster", "company_id,companyname", "companyname", "company_id", "'0'", "'--Select--'", DropDownList1);
                gl.ddl_select("Departmentmaster", "Depart_id,Departmentnm", "Departmentnm", "Depart_id", "'0'", "'--Select--'", DropDownList2);
                gl.ddl_select("Shiftmaster", "Shiftid,shiftname", "shiftname", "Shiftid", "'0'", "'--Select--'", DropDownList3);
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
                    if (DropDownList3.SelectedIndex == 0)
                    {

                    }
                    else
                    {
                        gl.query("Select E_Code,Name,Category,Department,Shift, InTime,OutTime,Work_Dur,RIGHT(CONVERT(VARCHAR, InTime, 100),11) as InTime1,RIGHT(CONVERT(VARCHAR, OutTime, 100),11) as OutTime1,RIGHT(CONVERT(VARCHAR, Work_Dur, 100),11) as Work_Dur1,RIGHT(CONVERT(VARCHAR, Tot_Dur, 100),11) as Tot_Dur1,CONVERT(varchar, CAST(Date AS datetime), 103) as date,Status From Daily_attendance WHERE Shift ='" + DropDownList3.SelectedItem.Text + "'");
                        GridView1.DataSource = gl.ds;
                        GridView1.DataBind();

                    }
                }
                else
                {
                    gl.query("Select E_Code,Name,Category,Department,Shift, InTime,OutTime,Work_Dur,RIGHT(CONVERT(VARCHAR, InTime, 100),11) as InTime1,RIGHT(CONVERT(VARCHAR, OutTime, 100),11) as OutTime1,RIGHT(CONVERT(VARCHAR, Work_Dur, 100),11) as Work_Dur1,RIGHT(CONVERT(VARCHAR, Tot_Dur, 100),11) as Tot_Dur1,CONVERT(varchar, CAST(Date AS datetime), 103) as date,Status From Daily_attendance WHERE Department ='" + DropDownList2.SelectedItem.Text + "'");
                    GridView1.DataSource = gl.ds;
                    GridView1.DataBind();

                }
            }
            else
            {
                if (DropDownList2.SelectedIndex == 0 && DropDownList3.SelectedIndex == 0)
                {
                    gl.query("Select E_Code,Name,Category,Department,Shift, InTime,OutTime,Work_Dur,RIGHT(CONVERT(VARCHAR, InTime, 100),11) as InTime1,RIGHT(CONVERT(VARCHAR, OutTime, 100),11) as OutTime1,RIGHT(CONVERT(VARCHAR, Work_Dur, 100),11) as Work_Dur1,RIGHT(CONVERT(VARCHAR, Tot_Dur, 100),11) as Tot_Dur1,CONVERT(varchar, CAST(Date AS datetime), 103) as date,Status From Daily_attendance WHERE Category ='" + DropDownList1.SelectedItem.Text + "'");
                    GridView1.DataSource = gl.ds;
                    GridView1.DataBind();
                }
                else
                {
                    if (DropDownList2.SelectedIndex == 0 && DropDownList3.SelectedIndex == 0 && DropDownList1.SelectedIndex == 0)
                    {

                    }
                    else
                    {
                        gl.query("Select E_Code,Name,Category,Department,Shift, InTime,OutTime,Work_Dur,RIGHT(CONVERT(VARCHAR, InTime, 100),11) as InTime1,RIGHT(CONVERT(VARCHAR, OutTime, 100),11) as OutTime1,RIGHT(CONVERT(VARCHAR, Work_Dur, 100),11) as Work_Dur1,RIGHT(CONVERT(VARCHAR, Tot_Dur, 100),11) as Tot_Dur1,CONVERT(varchar, CAST(Date AS datetime), 103) as date,Status From Daily_attendance WHERE Category ='" + DropDownList1.SelectedItem.Text + "' and Department='" + DropDownList2.SelectedItem.Text + "' and Shift='" + DropDownList3.SelectedItem.Text + "'");
                        GridView1.DataSource = gl.ds;
                        GridView1.DataBind();
                    }

                }
            }
        }
        catch
        { 
        
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Attendancesearch.aspx");
    }
}