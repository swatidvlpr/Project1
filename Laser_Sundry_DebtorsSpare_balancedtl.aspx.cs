using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DSR_Laser_Sundry_DebtorsSpare_balancedtl : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    string idd = Request.QueryString["id"].ToString();
                    gl.query("select * from Laser_Sundry_DebtorsSpare_balance where Lasser_spare_id='" + idd + "'");
                    DetailsView1.DataSource = gl.ds;
                    DetailsView1.DataBind();
                }
            }
        }
        catch { }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Laser_Sundry_DebtorsSpare_balance.aspx");
    }
}