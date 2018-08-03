using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class DSR_Followupstatusmaster_aspx : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                gl.display("Followup_statusmaster", GridView1);

            }
        }
        catch
        {

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //try
        //{

        if (Button1.Text == "Update")
        {
            int idd = Convert.ToInt32(GridView1.SelectedValue);
            using (SqlCommand cmd1 = new SqlCommand("Update Followup_statusmaster set Followup_status=@Followup_status where Followupstatus_id=@Followupstatus_id", gl.con))
            {
                cmd1.Parameters.AddWithValue("@Followupstatus_id", idd);
                cmd1.Parameters.AddWithValue("@Followup_status", txtfollowstatus.Text);
                gl.con.Open();
                cmd1.ExecuteNonQuery();
                gl.con.Close();
                Label1.Text = "Updatted Sucessfully";
                //...
            }
        }
        else
        {

            using (SqlCommand cmd1 = new SqlCommand("insert into Followup_statusmaster(Followup_status) values(@Followup_status)", gl.con))
            {
                cmd1.Parameters.AddWithValue("@Followup_status", txtfollowstatus.Text);
                gl.con.Open();
                cmd1.ExecuteNonQuery();
                gl.con.Close();
                Label1.Text = "Submitted Sucessfully";
                //...
            }
        }
        gl.display("Followup_statusmaster", GridView1);

        txtfollowstatus.Text = "";
        //}
        //catch
        //{
        //}
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Followupstatusmaster.aspx");
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int idd = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            gl.delete("Followup_statusmaster", "Followupstatus_id", "'" + idd + "'");
            gl.display("Followup_statusmaster", GridView1);
        }
        catch { }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            int id = Convert.ToInt32(GridView1.SelectedValue);
            gl.read1("Followup_statusmaster", "Followupstatus_id", "'" + id + "'");
            txtfollowstatus.Text = gl.ds.Tables[0].Rows[0]["Followup_status"].ToString();
            Button1.Text = "Update";
        }
        catch
        {


        }
    }
}