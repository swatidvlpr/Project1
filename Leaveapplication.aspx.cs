using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;

public partial class Hr_Leaveapplication : System.Web.UI.Page
{
    BharatmotordbEntities bh = new BharatmotordbEntities();
    global gl = new global();
    string day_count;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                if (!IsPostBack)
                {

                    //  ddlleavetype.DataSource =bb. CoffeeContext.tblProductTypes.ToList();
                    //ddlleavetype.DataTextField = "Description";
                    //ddlleavetype.DataValueField = "ProductType";
                    //ddlleavetype.DataBind();
                    gl.query("select leave_id,Leavenm from Leavetype");
                    //ddlleavetype.DataSource = bh.Leavetypes.ToList();
                    ddlleavetype.DataSource = gl.ds;
                    ddlleavetype.DataTextField = "Leavenm";
                    ddlleavetype.DataValueField = "leave_id";
                    ddlleavetype.DataBind();
                    ddlleavetype.Items.Insert(0, new ListItem("Select", "NA"));



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
            if (Button1.Text == "Update")
            {
                DateTime crnttimefrmdt = Convert.ToDateTime(txtfromdate.Text);
                TimeZoneInfo tzn = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime IndianTmefrmdt = TimeZoneInfo.ConvertTime(crnttimefrmdt, tzn);
                string frmdt = IndianTmefrmdt.ToString("M/dd/yyyy");

                DateTime crnttimetodt = Convert.ToDateTime(txttodate.Text);
                TimeZoneInfo tzn1 = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime IndianTmetodt = TimeZoneInfo.ConvertTime(crnttimetodt, tzn1);
                string todt = IndianTmetodt.ToString("M/dd/yyyy");


                DateTime startdate;
                DateTime startdate1;
                DateTime enddate;
                TimeSpan remaindate;

                startdate = DateTime.Parse(txtfromdate.Text).Date;
                startdate1 = startdate.AddDays(-1);


                enddate = DateTime.Parse(txttodate.Text).Date;
                remaindate = enddate - startdate1;

                int Status_hod = 0;
                int Status_hr = 0;
                string idd = Convert.ToInt32(GridView1.SelectedValue).ToString();
                using (SqlCommand cmd = new SqlCommand("update Leave_application set From_date=@From_date, To_date=@To_date, Leave_type=@Leave_type, Leave_Duration=@Leave_Duration, Reason=@Reason, Contact_during_Leave=@Contact_during_Leave, totalday_leave=@totalday_leave, Status_hod=@Status_hod, Status_hr=@Status_hr where leaveapplication_id=@leaveapplication_id", gl.con))
                {
                    cmd.Parameters.AddWithValue("@leaveapplication_id", idd);
                    cmd.Parameters.AddWithValue("@Employee_Code", txtecode.Text);
                    cmd.Parameters.AddWithValue("@From_date", frmdt);
                    cmd.Parameters.AddWithValue("@To_date", todt);
                    cmd.Parameters.AddWithValue("@Leave_type", ddlleavetype.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Leave_Duration", ddlleaveduration.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Reason", txtreason.Text);
                    cmd.Parameters.AddWithValue("@Contact_during_Leave", txtContact.Text);
                    //double day = Convert.ToDouble(remaindate);
                    cmd.Parameters.AddWithValue("@totalday_leave", remaindate.ToString());
                    cmd.Parameters.AddWithValue("@Status_hod", Status_hod);
                    cmd.Parameters.AddWithValue("@Status_hr", Status_hr);
                    gl.con.Open();
                    cmd.ExecuteNonQuery();
                    gl.con.Close();
                    gl.displaycond("Leave_application", "Employee_Code", "'" + txtecode.Text + "'", GridView1);
                    //...
                }

            }
            else
            {
                DateTime crnttimefrmdt = Convert.ToDateTime(txtfromdate.Text);
                TimeZoneInfo tzn = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime IndianTmefrmdt = TimeZoneInfo.ConvertTime(crnttimefrmdt, tzn);
                string frmdt = IndianTmefrmdt.ToString("M/dd/yyyy");

                DateTime crnttimetodt = Convert.ToDateTime(txttodate.Text);
                TimeZoneInfo tzn1 = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime IndianTmetodt = TimeZoneInfo.ConvertTime(crnttimetodt, tzn1);
                string todt = IndianTmetodt.ToString("M/dd/yyyy");


                DateTime startdate;
                DateTime startdate1;
                DateTime enddate;
                TimeSpan remaindate;

                startdate = DateTime.Parse(txtfromdate.Text).Date;
                startdate1 = startdate.AddDays(-1);


                enddate = DateTime.Parse(txttodate.Text).Date;
                remaindate = enddate - startdate1;

                int Status_hod = 0;
                int Status_hr = 0;
                if(ddlleaveduration.SelectedItem.Text=="Full Day")
                {              
                day_count=remaindate.ToString();
                }
                else
                {
              day_count="0.5";

                }
                using (SqlCommand cmd = new SqlCommand("insert into Leave_application(Employee_Code, From_date, To_date, Leave_type, Leave_Duration, Reason, Contact_during_Leave, totalday_leave, Status_hod, Status_hr,day_count) values(@Employee_Code,@From_date,@To_date,@Leave_type,@Leave_Duration,@Reason,@Contact_during_Leave,@totalday_leave,@Status_hod,@Status_hr,@day_count)", gl.con))
                {
                    // cmd.Parameters.AddWithValue("@text1", "mother's love");
                    cmd.Parameters.AddWithValue("@Employee_Code", txtecode.Text);
                    cmd.Parameters.AddWithValue("@From_date", frmdt);
                    cmd.Parameters.AddWithValue("@To_date", todt);
                    cmd.Parameters.AddWithValue("@Leave_type", ddlleavetype.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Leave_Duration", ddlleaveduration.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Reason", txtreason.Text);
                    cmd.Parameters.AddWithValue("@Contact_during_Leave", txtContact.Text);
                    //double day = Convert.ToDouble(remaindate);
                    cmd.Parameters.AddWithValue("@totalday_leave", remaindate.ToString());
                    cmd.Parameters.AddWithValue("@Status_hod", Status_hod);
                    cmd.Parameters.AddWithValue("@Status_hr", Status_hr);
                    cmd.Parameters.AddWithValue("@day_count", day_count);
                    gl.con.Open();
                    cmd.ExecuteNonQuery();
                    gl.con.Close();
                    gl.displaycond("Leave_application", "Employee_Code", "'" + txtecode.Text + "'", GridView1);
                    //...
                }


            }
        }
        catch
        { 
        
        }

        
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Leaveapplication.aspx");
    }
    protected void txtecode_TextChanged(object sender, EventArgs e)
    {
        try
        {
            gl.query("select * from Employee_Reg where EmployeeCode='" + txtecode.Text + "'");
            if (gl.ds.Tables[0].Rows.Count == 0)
            {


            }
            else
            {
                txtecode.ReadOnly = true;
                gl.displaycond("Leave_application", "Employee_Code", "'" + txtecode.Text + "'", GridView1);
            }
        }
        catch
        { 
        
        }

    }
    protected void txtfromdate_TextChanged(object sender, EventArgs e)
    {
        try
        {
            gl.query("select * from Leave_application where Employee_Code='" + txtecode.Text + "' and From_date='" + txtfromdate.Text + "'");
            if (gl.ds.Tables[0].Rows.Count == 0)
            {


            }
            else
            {
                // Response.Write("<script>alert('Already employee leaved.')</script>");
                Label1.Text = "Already employee leaved.";
            }
        }
        catch
        { 
        
        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int idd = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            gl.delete("Leave_application", "leaveapplication_id", "'" + idd + "'");
            gl.displaycond("Leave_application", "Employee_Code", "'" + txtecode.Text + "'", GridView1);
        }
        catch
        {       
        
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string idd = Convert.ToInt32(GridView1.SelectedValue).ToString();
            gl.query("select * from Leave_application where leaveapplication_id='" + idd + "'");
            txtfromdate.Text = gl.ds.Tables[0].Rows[0]["From_date"].ToString();
            txttodate.Text = gl.ds.Tables[0].Rows[0]["To_date"].ToString();
            string Leave_type = gl.ds.Tables[0].Rows[0]["Leave_type"].ToString();
            ddlleavetype.ClearSelection();
            ddlleavetype.Items.FindByText(Leave_type).Selected = true;
            string leave_duration = gl.ds.Tables[0].Rows[0]["Leave_Duration"].ToString();
            ddlleaveduration.ClearSelection();
            ddlleaveduration.Items.FindByText(leave_duration).Selected = true;
            txtreason.Text = gl.ds.Tables[0].Rows[0]["Reason"].ToString();
            txtContact.Text = gl.ds.Tables[0].Rows[0]["Contact_during_Leave"].ToString();
            Button1.Text = "Update";
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
                Button btn = (e.Row.FindControl("Button3") as Button);
                Button btn1 = (e.Row.FindControl("Button4") as Button);

                //e.Row.Cells[9].Text).ToString() =="0"
                HiddenField hd1 = (e.Row.FindControl("HiddenField1") as HiddenField);
                HiddenField hd2 = (e.Row.FindControl("HiddenField2") as HiddenField);
                if (hd1.Value == "0")
                {
                    // btn.Enabled = true;
                    btn.Text = "Panding";

                    btn.BackColor = Color.Red;
                }
                else
                {
                    // btn.Enabled = "Approve";
                    btn.Text = "Approve";
                    btn.BackColor = Color.Green;
                }

                if (hd2.Value == "0")
                {
                    // btn.Enabled = true;
                    btn1.Text = "Panding";

                    btn1.BackColor = Color.Red;
                }
                else
                {
                    // btn.Enabled = "Approve";
                    btn1.Text = "Approve";
                    btn1.BackColor = Color.Gray;
                }
            }
        }
        catch
        { 
        
        }
    }
}