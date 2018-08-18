using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
public partial class Hr_leave_register : System.Web.UI.Page
{
    public int curyeartot;
    public int curryr;
    global gl = new global();
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
    protected void submit_Click(object sender, EventArgs e)
    {
        try
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                if (DropDownList2.SelectedIndex == 0)
                {

                }
                else
                {
                    gl.query("select * from Leave_application WHERE YEAR(From_date) ='" + DropDownList2.SelectedValue + "' ");
                    GridView1.DataSource = gl.ds;
                    GridView1.DataBind();

                }
            }
            else
            {
                // gl.query("select * from Leave_application WHERE MONTH(From_date) = MONTH(dateadd(dd, -1, GetDate()))");


            }
        }
        catch
        { 
        
        }


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("leave_register.aspx");
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
                //HiddenField hd2 = (e.Row.FindControl("HiddenField2") as HiddenField);
                if (hd1.Value == "0")
                {
                    btn.Visible = false;
                    //btn2.Visible = false;
                    btn.Text = "Pending";
                    btn.BackColor = Color.Red;
                    btn2.Text = "Approve";
                    btn2.BackColor = Color.Orange;
                    btn.Enabled = false;
                    btn2.Enabled = false;
                }
                else
                {

                    //btn.Text = "Approve";
                    //btn.BackColor = Color.Gray;
                    btn.Visible = false;
                    btn2.Text = "Approved";
                    btn2.BackColor = Color.Green;
                    btn.Enabled = false;
                    btn2.Enabled = false;
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
}