using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hr_Officetime_policiedetails : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {

                gl.display("Office_time_policies_details", GridView1);
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
            if (Button1.Text == "update")
            {
                int idd = Convert.ToInt32(GridView1.SelectedValue);
                gl.update("Office_time_policies_details", "Policies_type='" + DropDownList1.SelectedValue + "',Policies_title='" + TextBox1.Text + "',Description='" + TextBox2.Text + "'", "Policies_id", "'" + idd + "'");
                Label1.Text = "update successfully";
            }
            else
            {
                // Policies_type,               Policies_title,          Description
                gl.insert1("Office_time_policies_details", "Policies_type, Policies_title, Description", "'" + DropDownList1.SelectedValue + "','" + TextBox1.Text + "','" + TextBox2.Text + "'");
                Label1.Text = "submitted successfully";
            }

            gl.display("Office_time_policies_details", GridView1);

            TextBox1.Text = "";
            TextBox2.Text = "";
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
            gl.read1("Office_time_policies_details", "Policies_id", "'" + idd + "'");
            string Policies_type = gl.ds.Tables[0].Rows[0]["Policies_type"].ToString();
            for (int i = 0; i <= DropDownList1.Items.Count - 1; i++)
            {
                if (DropDownList1.Items[i].Value == Policies_type)
                {
                    DropDownList1.Items[i].Selected = true;
                }
                else
                {
                    DropDownList1.Items[i].Selected = false;
                }
            }
            TextBox1.Text = gl.ds.Tables[0].Rows[0]["Policies_title"].ToString();
            TextBox2.Text = gl.ds.Tables[0].Rows[0]["Description"].ToString();
            Button1.Text = "update";
        }
        catch
        { 
        
        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int id1 = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            gl.delete("Office_time_policies_details", "Policies_id", "'" + id1 + "'");
            gl.display("Office_time_policies_details", GridView1);
        }
        catch
        { 
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Officetime policiedetails.aspx");
    }
}