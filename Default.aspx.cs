using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    public SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Conn"].ToString());
    public SqlDataReader dr;
    public bool auth;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from login where userid='" + Username.Text + "'", con);

        dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            if (dr["password"].ToString() == Password.Value)
            {
                auth = true;
            }

            else
            {
                //errorlbl.Visible = true;
                auth = false;
                Response.Write("<script>alert('userid and password are incorrect')</script>");
                //errorlbl.Text = "Incorrect Password";
            }
        }
        else
        {
            //errorlbl.Visible = true;
            auth = false;
            Response.Write("<script>alert('userid and password are incorrect')</script>");
            //errorlbl.Text = "Incorrect User ID";
        }

        if (auth == true)
        {
            //sa.read("add_logbook", "'" + TextBox1.Text + "','" + System.DateTime.Now.ToString() + "'");
            //sa.read("req_logbook", " '" + TextBox1.Text + "' ");
            //Response.Cookies["nm"]["lid"] = sa.ds.Tables[0].Rows[0]["Logbook_ID"].ToString();
            //Session["id"] = TextBox1.Text;
            Session["userid"] = dr["userid"].ToString();


            Session["uname"] = dr["usernm"].ToString();
            //Session["bid"] = ddlbranch.SelectedValue;
            //Session["branch"] = ddlbranch.SelectedItem.Text;
            Response.Redirect("Home.aspx");
        }
        else
        {
            //this.Response.Cookies.Remove("abc");
            // this.Session.RemoveAll();
        }
        con.Close();


    }
}