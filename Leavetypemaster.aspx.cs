using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hr_Leavetypemaster : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                gl.display("Leavetypemaster", GridView1);
                gl.ddl_select("Leavetype", "leave_id,Leavenm", "Leavenm", "leave_id", "0", "'Select'", ddlleavetype);

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
                string id1 = Convert.ToString(GridView1.SelectedValue).ToString();
                gl.update("Leavetypemaster", "employee_type='" + ddlemployee.SelectedItem.Text + "', leavenm='" + ddlleavetype.SelectedItem.Text + "', Total_year_leave='" + txtassighnleave.Text + "'", "typeleaveid", "'" + id1 + "'");
                gl.display("Leavetypemaster", GridView1);
                Label1.Text = "Updated successfully";
            }
            else
            {
                gl.insert1("Leavetypemaster", "employee_type, leavenm, Total_year_leave", "'" + ddlemployee.SelectedItem.Text + "','" + ddlleavetype.SelectedItem.Text + "','" + txtassighnleave.Text + "'");
                ddlemployee.SelectedIndex = 0;
                ddlleavetype.SelectedIndex = 0;
                txtassighnleave.Text = "";
                Label1.Text = "Submit successfully";
            }
            gl.display("Leavetypemaster", GridView1);
        }
        catch
        { 
        
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Leavetypemaster.aspx");
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string id1 = Convert.ToString(GridView1.SelectedValue).ToString();
            gl.query("select * from  Leavetypemaster where typeleaveid='" + id1 + "'");
            string ss = gl.ds.Tables[0].Rows[0]["employee_type"].ToString();

            ddlemployee.ClearSelection();
            ddlemployee.Items.FindByText(ss).Selected = true;

            string leavenm = gl.ds.Tables[0].Rows[0]["leavenm"].ToString();
            ddlleavetype.ClearSelection();
            ddlleavetype.Items.FindByText(leavenm).Selected = true;

            txtassighnleave.Text = gl.ds.Tables[0].Rows[0]["Total_year_leave"].ToString();
            Button1.Text = "Update";
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
            gl.delete("Leavetypemaster", "typeleaveid", "'" + idd + "'");
            gl.display("Leavetypemaster", GridView1);
        }
        catch
        { 
        }
    }
}