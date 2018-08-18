using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Hr_Employeedtl : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            string idd = Request.QueryString["id"].ToString();
            gl.formviewcond("Employee_Reg", "EmployeeCode", "'" + idd + "'", FormView1);
        }
        
    }
    protected void FormView1_DataBound(object sender, EventArgs e)
    {
       // DataRowView dataRow = ((DataRowView)FormView1.DataItem);
        if (Convert.ToInt32(FormView1.SelectedValue) != 0)
        {
            string rid = FormView1.SelectedValue.ToString();
            //Label lbl = (Label)FormView1.FindControl("lblStock");
            GridView gv = (GridView)FormView1.FindControl("GridView1");
            gl.query("select * from employee_Attachmentfile where EmployeeCode='" + rid + "'");
            gv.DataSource = gl.ds;
            gv.DataBind();
           
        }
    }
}