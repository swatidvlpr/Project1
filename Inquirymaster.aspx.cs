using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Inquirymaster : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gl.display("Inquirymaster", GridView1);
        
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        {
        
        }
        else
        {
            gl.insert1("Inquirymaster", "Inquiry_type", "'" + TextBox1.Text + "'");
            gl.display("Inquirymaster", GridView1);
            TextBox1.Text = "";
        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
        gl.delete("Inquirymaster", "Inquiry_id", "'"+id+"'");
        gl.display("Inquirymaster", GridView1);
    }
}