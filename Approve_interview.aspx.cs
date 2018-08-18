using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
public partial class Hr_Approve_interview : System.Web.UI.Page
{
    global gl = new global();

    public int curyeartot;
    public int curryr;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                string currentdt = DateTime.Now.ToString("yyyy");
                int curryr = Convert.ToInt32(currentdt);
                int curryr1 = Convert.ToInt32(currentdt);
                if (curryr == curryr1)
                {
                    curyeartot = curryr + 5;
                }

                for (int i = 2017; i <= curyeartot; i++)
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
                Button btn = (e.Row.FindControl("Button3") as Button);
                Button btn1 = (e.Row.FindControl("Button4") as Button);
                Button btn2 = (e.Row.FindControl("Button5") as Button);

                //e.Row.Cells[9].Text).ToString() =="0"
                HiddenField hd1 = (e.Row.FindControl("HiddenField1") as HiddenField);

                if (hd1.Value == "0")
                {

                    btn.Text = "Pending";
                    btn.BackColor = Color.Orange;
                    btn2.Text = "Approve";
                    btn2.BackColor = Color.Orange;
                    btn1.Text = "Rejecte";
                    btn1.BackColor = Color.Red;
                }
                else if (hd1.Value == "2")
                {
                    btn.Visible = false;
                    btn2.Visible = false;
                    btn1.Text = "Rejected";
                    btn1.BackColor = Color.Red;

                }
                else
                {

                    //btn.Text = "Approve";
                    //btn.BackColor = Color.Gray;
                    btn1.Visible = false;
                    btn.Visible = false;
                    btn2.Text = "Selected";
                    btn2.BackColor = Color.Green;
                }

                //if (hd2.Value == "0")
                //{

                //    btn1.Text = "Pending";

                //    btn1.BackColor = Color.Red;
                //    btn1.Enabled = false;

                //}
                //else
                //{

                //    btn1.Text = "Approved";
                //    btn1.BackColor = Color.Green;
                //    btn1.Enabled = false;

                //}
            }
        }
        catch
        { 
        
        }


    }
    protected void submit_Click(object sender, EventArgs e)
    {
        try
        {
            //gl.query("select * from tour_mgmnt WHERE MONTH(Out_Date) = MONTH(dateadd(dd, -1, GetDate()))");
            //GridView1.DataSource = gl.ds;
            //GridView1.DataBind();

            if (DropDownList1.SelectedIndex == 0)
            {
                if (DropDownList2.SelectedIndex == 0)
                {
                    if (TextBox1.Text == "")
                    { }
                    else
                    {
                        gl.query("select * from Interview_sheet WHERE Date_of_interview='" + TextBox1.Text + "'");
                        GridView1.DataSource = gl.ds;
                        GridView1.DataBind();
                    }
                }
                else
                {
                    gl.query("select * from Interview_sheet WHERE Year='" + DropDownList2.SelectedValue + "'");
                    GridView1.DataSource = gl.ds;
                    GridView1.DataBind();

                }
            }
            else
            {
                gl.query("select * from Interview_sheet WHERE Month ='" + DropDownList1.SelectedValue + "' and Year='" + DropDownList2.SelectedValue + "'");
                GridView1.DataSource = gl.ds;
                GridView1.DataBind();

            }
        }
        catch
        {
        
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        try
        {
            Button btn = sender as Button;
            GridViewRow row = btn.NamingContainer as GridViewRow;
            string pk = GridView1.DataKeys[row.RowIndex].Values[0].ToString();
            gl.update("Interview_sheet", "Status_hr=1", "interview_id", "'" + pk + "'");
            if (DropDownList1.SelectedIndex == 0)
            {
                if (DropDownList2.SelectedIndex == 0)
                {

                }
                else
                {
                    gl.query("select * from Interview_sheet WHERE Year='" + DropDownList2.SelectedValue + "'");
                    GridView1.DataSource = gl.ds;
                    GridView1.DataBind();

                }
            }
            else
            {
                gl.query("select * from Interview_sheet WHERE Month ='" + DropDownList1.SelectedValue + "' and Year='" + DropDownList2.SelectedValue + "'");
                GridView1.DataSource = gl.ds;
                GridView1.DataBind();

            }
        }
        catch 
        {
        
        }


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Approve_interview.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        try
        {
            Button btn = sender as Button;
            GridViewRow row = btn.NamingContainer as GridViewRow;
            string pk = GridView1.DataKeys[row.RowIndex].Values[0].ToString();
            gl.update("Interview_sheet", "Status_hr=2", "interview_id", "'" + pk + "'");
            if (DropDownList1.SelectedIndex == 0)
            {
                if (DropDownList2.SelectedIndex == 0)
                {

                }
                else
                {
                    gl.query("select * from Interview_sheet WHERE Year='" + DropDownList2.SelectedValue + "'");
                    GridView1.DataSource = gl.ds;
                    GridView1.DataBind();

                }
            }
            else
            {
                gl.query("select * from Interview_sheet WHERE Month ='" + DropDownList1.SelectedValue + "' and Year='" + DropDownList2.SelectedValue + "'");
                GridView1.DataSource = gl.ds;
                GridView1.DataBind();

            }
        }
        catch
        { 
        
        }

    }
}