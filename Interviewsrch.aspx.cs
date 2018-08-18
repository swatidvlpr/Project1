using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hr_Interviewdtl : System.Web.UI.Page
{
    public int curyeartot;
    public int curryr;
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        try {        

        if (!IsPostBack)
        {
            string currentdt = DateTime.Now.ToString("yyyy");
            int curryr = Convert.ToInt32(currentdt);
            int curryr1 = Convert.ToInt32(currentdt);
            if (curryr == curryr1)
            {
                curyeartot = curryr + 5;
            }

            for (int i = 2017; i <= curyeartot; i++)
            {

                DropDownList2.Items.Add(i.ToString());

            }
        }

        }
        catch
        { }
    }



    protected void submit_Click(object sender, EventArgs e)
    {
        try
        {
        if (DropDownList2.SelectedIndex == 0)
        {
            

        }
        else
        {
            if (DropDownList1.SelectedIndex == 0)
            {
               // gl.displaycond("Interview_sheet", "Year", "'" + DropDownList2.SelectedValue + "'", GridView1);
                gl.displaycond("Interview_sheet", "Year", "'" + DropDownList2.SelectedValue + "'", GridView1);
            }
            else
            {
                gl.displaycond2("Interview_sheet", "Month", "'" + DropDownList1.SelectedValue + "'", "Year", "'" + DropDownList2.SelectedValue + "'", GridView1);

            }

        }
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
            gl.delete("Interview_sheet", "interview_id", "'" + id1 + "'");
            gl.display("Interview_sheet", GridView1);
        }
        catch
        { 
        
        }
       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Interviewsrch.aspx");
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("Interviewsrch.aspx");
    }
}