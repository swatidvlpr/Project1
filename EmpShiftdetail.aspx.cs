using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Web;


public partial class Hr_Shiftdetail : System.Web.UI.Page
{
   // public SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bmconn"].ToString());
    public SqlDataAdapter da = new SqlDataAdapter();
    public DataSet ds = new DataSet();
    public string cid;
    public SqlCommand cmd = new SqlCommand();
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
          //  gl.display("Employee_Reg", GridView1);
            if (Request.QueryString["id"] != null)
            {
                string idd = Request.QueryString["id"].ToString();
                gl.read1("Employee_Reg", "EmployeeCode", "'" + idd + "'");
                
            }
            gl.ddl_select("companymaster", "company_id,companyname", "companyname", "company_id", "'0'", "'Select'", ddlcompany);
            gl.ddl_select("Departmentmaster", "Depart_id,Departmentnm", "Departmentnm", "Depart_id", "'0'", "'Select'", ddldepartment);
        }  
    }  
  
  
    protected void Button1_Click(object sender, EventArgs e)
    {
        //for (int i = 0; i < GridView1.Rows.Count; i++)
        //{
        //    CheckBox ch = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
        //    Label lb = (Label)GridView1.Rows[i].FindControl("lbllcode");
        //    if (ch.Checked == true)
        //    {
        //        ListBox1.Items.Add(lb.Text.ToString());
        //    }
        //}
        //ListBox1.Visible =false;
   
        //foreach (GridViewRow gvrow in GridView1.Rows)
        //{
        //        var checkbox = gvrow.FindControl("CheckBox1") as CheckBox;
        //        if (checkbox.Checked==true)
        //        {

        //            var lblcode = gvrow.FindControl("Label1") as Label;
        //            var lblname = gvrow.FindControl("Label2") as Label;
        //            var lblqual = gvrow.FindControl("Label3") as Label;

        //            da = new SqlDataAdapter("insert into shiftdtl(EmployeeCode,name,qualification) values(@EmployeeCode,@name,@qualification)", con);
        //            da.SelectCommand.Parameters.AddWithValue("EmployeeCode", lblcode);
        //            da.SelectCommand.Parameters.AddWithValue("name", lblname);
        //            da.SelectCommand.Parameters.AddWithValue("qualification", lblqual);

        //            con.Open();
        //            int i = cmd.ExecuteNonQuery();
        //            con.Close();
        //            refreshdata();

        //        }

            
        //}

        foreach (GridViewRow gvrow in GridView1.Rows)
        {
            //Finiding checkbox control in gridview for particular row
            CheckBox chkdelete = (CheckBox)gvrow.FindControl("chkSelect");
            //Condition to check checkbox selected or not
            if (chkdelete.Checked)
            {
                //Getting UserId of particular row using datakey value
                int usrid = Convert.ToInt32(GridView1.DataKeys[gvrow.RowIndex].Value);

                Label lblempcode = (Label)gvrow.FindControl("lbllcode");
                Label lblname = (Label)gvrow.FindControl("lblname");
                Label lblcompany = (Label)gvrow.FindControl("lblcompany");
                Label lbldepart = (Label)gvrow.FindControl("lbldepart");

                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Conn"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("insert into shiftdtl(EmployeeCode, shiftname, companyname, Departmentnm, name) values(@EmployeeCode,@shiftname,@companyname,@Departmentnm,@name)", gl.con))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeCode", lblempcode.Text);
                        cmd.Parameters.AddWithValue("@shiftname", DropDownList1.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@companyname",lblcompany.Text);
                        cmd.Parameters.AddWithValue("@Departmentnm", lbldepart.Text);
                        cmd.Parameters.AddWithValue("@name",lblname.Text);
                       
                        gl.con.Open();
                        cmd.ExecuteNonQuery();
                        gl.con.Close();
                        //...
                    }

                }
            }
        }
        BindUserDetails();
    }
  
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //gl.displaycond2("Employee_Reg", "companyname", "'" + ddlcompany.SelectedItem.Text + "'", "Departmentnm", "'"+ddldepartment.SelectedItem.Text+"'", GridView1);
        BindUserDetails();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

    }



    protected void btnDelete_Click(object sender, EventArgs e)
    {
       
    }

    protected void BindUserDetails()
    {
        DataTable dt = new DataTable();
        using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Conn"].ToString()))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Employee_Reg where companyname='" + ddlcompany.SelectedItem.Text + "' and Departmentnm='"+ddldepartment.SelectedItem.Text+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    




}