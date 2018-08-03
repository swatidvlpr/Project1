using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class DSR_Purchaseplanmaster : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                gl.display("Purchaseplanmaster", GridView1);

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
                int idd = Convert.ToInt32(GridView1.SelectedValue);
                using (SqlCommand cmd1 = new SqlCommand("Update Purchaseplanmaster set Purchaseplan=@Purchaseplan where Purchaseplan_id=@Purchaseplan_id", gl.con))
                {
                    cmd1.Parameters.AddWithValue("@Purchaseplan_id", idd);
                    cmd1.Parameters.AddWithValue("@Purchaseplan", txtPurchaseplan.Text);
                    gl.con.Open();
                    cmd1.ExecuteNonQuery();
                    gl.con.Close();
                    Label1.Text = "Updatted Sucessfully";
                    //...
                }
            }
            else
            {

                using (SqlCommand cmd1 = new SqlCommand("insert into Purchaseplanmaster(Purchaseplan) values(@Purchaseplan)", gl.con))
                {
                    cmd1.Parameters.AddWithValue("@Purchaseplan", txtPurchaseplan.Text);
                    gl.con.Open();
                    cmd1.ExecuteNonQuery();
                    gl.con.Close();
                    Label1.Text = "Submitted Sucessfully";
                    //...
                }
            }
            gl.display("Purchaseplanmaster", GridView1);

            txtPurchaseplan.Text = "";
        }
        catch
        {
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Purchaseplanmaster.aspx");
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int idd = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            gl.delete("Purchaseplanmaster", "Purchaseplan_id", "'" + idd + "'");
            gl.display("Purchaseplanmaster", GridView1);
        }
        catch { }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            int id = Convert.ToInt32(GridView1.SelectedValue);
            gl.read1("Purchaseplanmaster", "Purchaseplan_id", "'" + id + "'");
            txtPurchaseplan.Text = gl.ds.Tables[0].Rows[0]["Purchaseplan"].ToString();
            Button1.Text = "Update";
        }
        catch
        {


        }
    }
}