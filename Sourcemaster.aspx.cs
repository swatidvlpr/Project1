using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class DSR_Sourcemaster : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            display();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (Button1.Text == "Update")
            {
                string id1 = Convert.ToInt32(GridView1.SelectedValue).ToString();
                using (gl.cmd = new SqlCommand("update Sourcemaster set Sourcename=@Sourcename where Source_id=@Source_id", gl.con))
                {
                    gl.cmd.Parameters.AddWithValue("@Source_id", id1);
                    gl.cmd.Parameters.AddWithValue("@Sourcename", txtSource.Text);
                    gl.con.Open();
                    gl.cmd.ExecuteNonQuery();
                    gl.con.Close();
                    display();
                    Label1.Text = "Sucessfully updated";
                    txtSource.Text = "";
                }

            }
            else
            {
                using (gl.cmd = new SqlCommand("insert into Sourcemaster values(@Sourcename)", gl.con))
                {


                    gl.cmd.Parameters.AddWithValue("@Sourcename", txtSource.Text);
                    gl.con.Open();
                    gl.cmd.ExecuteNonQuery();
                    gl.con.Close();
                    display();
                    Label1.Text = "Sucessfully submitted";
                    txtSource.Text = "";
                }
            }
        }
        catch { }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Modelmaster.aspx");
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int idd = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            gl.delete("Sourcemaster", "Source_id", "'" + idd + "'");
            display();
        }
        catch { }

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string id1 = Convert.ToInt32(GridView1.SelectedValue).ToString();
            gl.query("SELECT * from  Sourcemaster where Source_id ='" + id1 + "'");
            txtSource.Text = gl.ds.Tables[0].Rows[0]["Sourcename"].ToString();
            Button1.Text = "Update";
        }
        catch { }
    }

    public void display()
    {
        try
        {
            gl.query("select * from Sourcemaster");
            GridView1.DataSource = gl.ds;
            GridView1.DataBind();
        }
        catch { }
    }
}