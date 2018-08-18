using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hr_Viewemployee : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            for (int i = 2016; i <= 2050; i++)
            {
                DropDownList2.Items.Add(i.ToString());


            }
            gl.ddl_select("companymaster", "company_id,companyname", "companyname", "company_id", "'0'", "'Select'", ddlcompany);

            gl.query("select * from Employee_Reg WHERE MONTH(date) = MONTH(dateadd(dd, -1, GetDate()))  order by Category_id");
            GridView1.DataSource = gl.ds;
            GridView1.DataBind();
        }
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        try
        {
        if (DropDownList2.SelectedIndex == 0)
        {
            if (txtempcode.Text == "")
            {
                if (TextBox1.Text == "")
                {
                    if (ddlcompany.SelectedIndex == 0)
                    {
                        gl.query("select * from Employee_Reg WHERE companyname ='" + ddlcompany.SelectedItem.Text + "'");
                        GridView1.DataSource = gl.ds;
                        GridView1.DataBind();
                    }
                    else
                    {                       

                        if (ddlcompany.SelectedIndex == 0 && ddllocation.SelectedIndex == 0)
                        {
                            if (ddlcompany.SelectedIndex == 0 && ddllocation.SelectedIndex == 0 && ddlCategory.SelectedIndex == 0)
                            {

                            }
                            else
                            {
                                gl.query("select * from Employee_Reg WHERE companyname ='" + ddlcompany.SelectedItem.Text + "' and location_id='" + ddllocation.SelectedValue + "' and Category_id='" + ddlCategory.SelectedValue + "'");
                                GridView1.DataSource = gl.ds;
                                GridView1.DataBind();
                            }
                            
                        }
                        else
                        {
                            gl.query("select * from Employee_Reg WHERE companyname ='" + ddlcompany.SelectedItem.Text + "' and location_id='" + ddllocation.SelectedValue + "'");
                            GridView1.DataSource = gl.ds;
                            GridView1.DataBind();
                        }
                        
                        
                    }                   

                }
                else
                {
                    gl.displaycond("Employee_Reg", "Name", "'" + TextBox1.Text + "'", GridView1); 
                
                }
            }
            else
            {
                //gl.displaycond("Employee_Reg", "EmployeeCode", "'" + txtempcode.Text + "'", GridView1);                
                gl.query("select * from Employee_Reg WHERE EmployeeCode ='" + txtempcode.Text + "'");
                GridView1.DataSource = gl.ds;
                GridView1.DataBind();
            }
        }
        else
        {
            if (DropDownList1.SelectedIndex == 0)
            {
               // gl.displaycond("Employee_Reg", "year", "'" + DropDownList2.SelectedValue + "'", GridView1);
                gl.query("select * from Employee_Reg WHERE YEAR(Date) ='" + DropDownList2.SelectedValue + "'");
                GridView1.DataSource = gl.ds;
                GridView1.DataBind();

            }
            else
            {
               // gl.displaycond2("Employee_Reg", "month", "'"+DropDownList1.SelectedValue+"'", "year", "'" + DropDownList2.SelectedValue + "'", GridView1);
                gl.query("select * from Employee_Reg WHERE YEAR(Date) ='" + DropDownList2.SelectedValue + "' and MONTH(Date)='" + DropDownList1.SelectedValue + "'");
                GridView1.DataSource = gl.ds;
                GridView1.DataBind();
            }
        
        }
        }
        catch
        { }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id11 = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

        gl.returncol("Employee_Reg", "Emp_id", "'" + id11 + "'");
        string rrid = gl.ds.Tables[0].Rows[0]["EmployeeCode"].ToString();

        gl.delete("Employee_Reg", "Emp_id", "'" + id11 + "'");       
        gl.delete("employee_Attachmentfile", "EmployeeCode", "'" + rrid + "'");

        if (DropDownList2.SelectedIndex == 0)
        {
            if (txtempcode.Text == "")
            {
                if (TextBox1.Text == "")
                {
                    gl.query("select * from Employee_Reg WHERE MONTH(date) = MONTH(dateadd(dd, -1, GetDate()))  order by Category_id");
                    GridView1.DataSource = gl.ds;
                    GridView1.DataBind();
                }
                else
                {
                    gl.displaycond("Employee_Reg", "Name", "'" + TextBox1.Text + "'", GridView1);

                }
            }
            else
            {
                gl.displaycond("Employee_Reg", "EmployeeCode", "'" + txtempcode.Text + "'", GridView1);


            }
        }
        else
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                gl.displaycond("Employee_Reg", "year", "'" + DropDownList2.SelectedValue + "'", GridView1);
            }
            else
            {
                gl.displaycond2("Employee_Reg", "month", "'" + DropDownList1.SelectedValue + "'", "year", "'" + DropDownList2.SelectedValue + "'", GridView1);

            }

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Viewemployee.aspx");
    }
    protected void ddlcompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            gl.ddlcond("locationmaster", "Location_name", "location_id", "Company_id", "'" + ddlcompany.SelectedValue + "'", ddllocation);
            //gl.query("Select location_id,Company_id,Location_name,Locationshtct from locationmaster where Company_id='" + ddlcompany.SelectedValue + "'");
            //ddllocation.DataSource = gl.ds;
            //ddllocation.DataTextField = "Location_name";
            //ddllocation.DataValueField = "location_id";
            //ddllocation.DataBind();
            ddllocation.SelectedIndex = 0;
        }
        catch
        {
        }
    }
    protected void ddllocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            //gl.ddlcond("Categorymaster", "Categorynm", "Category_id", "location_id", "'" + ddllocation.SelectedValue + "'", ddlCategory);
            gl.query("Select * from Categorymaster where location_id='" + ddllocation.SelectedValue + "' and companyid='" + ddlcompany.SelectedValue + "'");
            ddlCategory.DataSource = gl.ds;
            ddlCategory.DataTextField = "Categorynm";
            ddlCategory.DataValueField = "Category_id";
            ddlCategory.DataBind();
            ddlCategory.SelectedIndex = 0;
        }
        catch
        {
        }
    }
    protected void ddllocation_DataBound(object sender, EventArgs e)
    {
        Convert.ToInt32(ddllocation.SelectedValue);
        ddllocation.Items.Insert(0, new ListItem("-Select-", "-Select-")); 
    }
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ddlCategory_DataBound(object sender, EventArgs e)
    {
        ddlCategory.Items.Insert(0, new ListItem("-Select-", "-Select-")); 
    }
}