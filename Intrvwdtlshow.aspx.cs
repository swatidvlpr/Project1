using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hr_Intrvwdtlshow : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Request.QueryString["id"] != null)
            {
                string idd = Request.QueryString["id"].ToString();
                gl.formviewcond("Interview_sheet", "interview_id", "'" + idd + "'", FormView1);
            }
        }
        catch
        { 
        
        }
        
    }
    protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
    {

    }
}