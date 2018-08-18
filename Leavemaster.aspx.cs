using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hr_Leavemaster : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                gl.display("Leavetype", GridView1);
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
                string idd = Convert.ToInt32(GridView1.SelectedValue).ToString();
                gl.update("Leavetype", "Leavenm='" + TextBox1.Text + "'", "leave_id", "'" + idd + "'");

            }
            else
            {

                if (TextBox1.Text == "")
                {

                }
                else
                {
                    gl.insert1("Leavetype", "Leavenm", "'" + TextBox1.Text + "'");
                    TextBox1.Text = "";

                }
            }
            gl.display("Leavetype", GridView1);
        }
        catch
        { }
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Leavemaster.aspx");
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            gl.delete("Leavetype", "leave_id", "'" + id + "'");
            gl.display("Leavetype", GridView1);
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
            gl.query("select * from Leavetype where leave_id='" + idd + "'");
            TextBox1.Text = gl.ds.Tables[0].Rows[0]["Leavenm"].ToString();
            Button1.Text = "Update";
        }
        catch
        { 
        }
    }
}