using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hr_govtforms : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                gl.display("Govtform", GridView1);
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
            if (FileUpload1.HasFile)
            {
                string ss = "Govtform" + "/" + FileUpload1.FileName;
                FileUpload1.SaveAs(Server.MapPath(ss));
                gl.insert1("Govtform", "govtform,Govt_name", "'" + ss + "','" + TextBox1.Text + "'");
                gl.display("Govtform", GridView1);
            }
        }
        catch
        { 
        
        
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("govtforms.aspx");
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
}