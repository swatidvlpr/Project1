using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class DSR_Followupmaster : System.Web.UI.Page
{
    global gl = new global();
    public SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Conn"].ToString());
   
    public SqlDataAdapter da = new SqlDataAdapter();
    public DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{
       if (!IsPostBack)
            {
               //display();
                gl.query("select Emp_id,EmployeeCode,Departmentnm,Name from Employee_Reg where Departmentnm='Sale' union select 0,'0','0','Select' order by Emp_id");
                ddlsales.DataSource = gl.ds;
                ddlsales.DataTextField = "Name";
                ddlsales.DataValueField = "EmployeeCode";
                ddlsales.DataBind();
                gl.ddl_select("companymaster", "company_id,companyname", "companyname", "company_id", "0", "'Select'", ddlcompany);
                gl.ddl_select("Followuptypemaster","Followup_id,followuptype","followuptype","Followup_id","'0'","'Select'",ddlFollowuptype);
                gl.ddl_select("Followup_statusmaster", "Followupstatus_id,Followup_status", "Followup_status", "Followupstatus_id", "'0'", "'Select'", ddlfollowupstatus);
               // gl.ddl_select("Enquryform", "Enquryid,Customer_name", "Customer_name", "Enquryid", "'0'", "'Select'", ddlcustomer);Follow up
                gl.query("Select Enquryid,Status,Customer_name from Enquryform where Status='Follow up'");
                ddlcustomer.DataSource = gl.ds;
                ddlcustomer.DataTextField = "Customer_name";
                ddlcustomer.DataValueField = "Enquryid";
                ddlcustomer.DataBind();
                ddlcustomer.SelectedIndex = 0;
                


                gl.ddl_select("Branchmaster", "Branchid,branchname", "branchname", "Branchid", "0", "'Select'", ddlbranch);
                
            }
        //}
        //catch
        //{

        //}
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //try
        //{

        if (Button1.Text == "Update")
            {
                int idd = Convert.ToInt32(GridView1.SelectedValue);
                using (SqlCommand cmd1 = new SqlCommand("Update Followup_master set Saleman_id=@Saleman_id,Company_id=@Company_id, Category_id=@Category_id, Modelname=@Modelname, Modelno=@Modelno, Followup_type=@Followup_type, Followup_status=@Followup_status, Customer_comparing_price=@Customer_comparing_price,Date=@Date,Customer_id=@Customer_id,Branchid=@Branchid,Next_dt=@Next_dt where Follow_id=@Follow_id", gl.con))
                {
                    cmd1.Parameters.AddWithValue("@Follow_id", idd);
                    cmd1.Parameters.AddWithValue("@Saleman_id", ddlsales.SelectedValue);
                    cmd1.Parameters.AddWithValue("@Company_id", ddlcompany.SelectedValue);
                    cmd1.Parameters.AddWithValue("@Category_id", ddlCategory.SelectedValue);
                    cmd1.Parameters.AddWithValue("@Modelname", ddlmodelnm.SelectedValue);
                    cmd1.Parameters.AddWithValue("@Modelno", txtmodelno.Text);
                    cmd1.Parameters.AddWithValue("@Followup_type", ddlFollowuptype.SelectedItem.Text);
                    cmd1.Parameters.AddWithValue("@Followup_status", ddlfollowupstatus.SelectedItem.Text);
                    decimal price=Convert.ToDecimal(txtcustomercomparingprice.Text);
                    cmd1.Parameters.AddWithValue("@Customer_comparing_price", price);
                    cmd1.Parameters.AddWithValue("@Date", txtdate.Text);
                    cmd1.Parameters.AddWithValue("@Customer_id", ddlcustomer.SelectedValue);
                    cmd1.Parameters.AddWithValue("@Branchid", ddlbranch.SelectedValue);
                    cmd1.Parameters.AddWithValue("@Next_dt", txtnextfollowupdt.Text);
                    gl.con.Open();
                    cmd1.ExecuteNonQuery();
                    gl.con.Close();
                    Label2.Text = "Updatted Sucessfully";
                    //...
                }
            
            }
            else
            {

                using (SqlCommand cmd1 = new SqlCommand("insert into Followup_master(Saleman_id, Company_id, Category_id, Modelname, Modelno, Followup_type, Followup_status, Customer_comparing_price, Date, Customer_id,Branchid,Next_dt) values(@Saleman_id,@Company_id,@Category_id,@Modelname,@Modelno,@Followup_type,@Followup_status,@Customer_comparing_price,@Date,@Customer_id,@Branchid,@Next_dt)", gl.con))
                {
                    cmd1.Parameters.AddWithValue("@Saleman_id", ddlsales.SelectedValue);
                    cmd1.Parameters.AddWithValue("@Company_id", ddlcompany.SelectedValue);
                    cmd1.Parameters.AddWithValue("@Category_id",ddlCategory.SelectedValue);
                    cmd1.Parameters.AddWithValue("@Modelname", ddlmodelnm.SelectedValue);
                    cmd1.Parameters.AddWithValue("@Modelno",txtmodelno.Text);
                    cmd1.Parameters.AddWithValue("@Followup_type",ddlFollowuptype.SelectedItem.Text);
                    cmd1.Parameters.AddWithValue("@Followup_status", ddlfollowupstatus.SelectedItem.Text);
                    
                    double price=Convert.ToDouble(txtcustomercomparingprice.Text);
                    cmd1.Parameters.AddWithValue("@Customer_comparing_price", price);

                    cmd1.Parameters.AddWithValue("@Date", txtdate.Text);
                    cmd1.Parameters.AddWithValue("@Customer_id", ddlcustomer.SelectedValue);
                    cmd1.Parameters.AddWithValue("@Branchid", ddlbranch.SelectedValue);
                    cmd1.Parameters.AddWithValue("@Next_dt", txtnextfollowupdt.Text);
                    gl.con.Open();
                    cmd1.ExecuteNonQuery();
                    gl.con.Close();
                    Label2.Text = "Submitted Sucessfully";
                    //...
                }
            }
            display();
            
        //}
        //catch
        //{
        //}
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Followupmaster.aspx");
    }
    protected void ddlcompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            gl.ddlcond("Categorymaster", "Categorynm", "Category_id", "companyid", "'" + ddlcompany.SelectedValue + "'", ddlCategory);
            ddlCategory.SelectedIndex = 0;
        }
        catch
        {
        }
    }
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            gl.ddlcond("Modelmaster", "Modelnm", "Modelid", "Category_id", "'" + ddlCategory.SelectedValue + "'", ddlmodelnm);
            ddlmodelnm.SelectedIndex = 0;
        }
        catch
        {
        }
    }
    protected void ddlmodelnm_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            gl.query("select * from Modelmaster where Modelid='" + ddlmodelnm.SelectedValue + "'");
            txtmodelno.Text = gl.ds.Tables[0].Rows[0]["Modelno"].ToString();
        }
        catch
        {
        }
    }

    public void display()
    {
        gl.usepro("pro_followupmaster", "");
        GridView1.DataSource = gl.ds;
        GridView1.DataBind();
    
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int idd = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            gl.delete("Followup_master", "Follow_id", "'" + idd + "'");
            display();
        }
        catch { }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            gl.query("select Emp_id,EmployeeCode,Departmentnm,Name from Employee_Reg where Departmentnm='Sale' union select 0,'0','0','Select' order by Emp_id");
            ddlsales.DataSource = gl.ds;
            ddlsales.DataTextField = "Name";
            ddlsales.DataValueField = "EmployeeCode";
            ddlsales.DataBind();
            gl.ddl_select("companymaster", "company_id,companyname", "companyname", "company_id", "0", "'Select'", ddlcompany);
            gl.ddl_select("Followuptypemaster", "Followup_id,followuptype", "followuptype", "Followup_id", "'0'", "'Select'", ddlFollowuptype);
            gl.ddl_select("Followup_statusmaster", "Followupstatus_id,Followup_status", "Followup_status", "Followupstatus_id", "'0'", "'Select'", ddlfollowupstatus);
            gl.ddl_select("Enquryform", "Enquryid,Customer_name", "Customer_name", "Enquryid", "'0'", "'Select'", ddlcustomer);

            string id1 = Convert.ToInt32(GridView1.SelectedValue).ToString();
            gl.usepro("return_followupmaster", "'" + id1 + "'");

            string saleid = gl.ds.Tables[0].Rows[0]["Saleman_id"].ToString();
            string Customer_id1 = gl.ds.Tables[0].Rows[0]["Customer_id"].ToString();            
            txtdate.Text = gl.ds.Tables[0].Rows[0]["Date"].ToString();

            string Company_id1 = gl.ds.Tables[0].Rows[0]["Company_id"].ToString();
            string cid = gl.ds.Tables[0].Rows[0]["Category_id"].ToString();
            string Modelname1 = gl.ds.Tables[0].Rows[0]["Modelname"].ToString();
            string Followup_type1 = gl.ds.Tables[0].Rows[0]["Followup_type"].ToString();
            string Followup_status1 = gl.ds.Tables[0].Rows[0]["Followup_status"].ToString();
            string branchid = gl.ds.Tables[0].Rows[0]["Branchid"].ToString();

            for (int i = 0; i < ddlsales.Items.Count; i++)
            {
                if (ddlsales.Items[i].Value == saleid)
                {
                    ddlsales.Items[i].Selected = true;
                }
                else
                {
                    ddlsales.Items[i].Selected = false;                
                }
            }

            for (int i = 0; i < ddlcustomer.Items.Count; i++)
            {
                if (ddlcustomer.Items[i].Value == Customer_id1)
                {
                    ddlcustomer.Items[i].Selected = true;
                }
                else
                {
                    ddlcustomer.Items[i].Selected = false;
                }
            }

            for (int i = 0; i < ddlcompany.Items.Count; i++)
            {
                if (ddlcompany.Items[i].Value == Company_id1)
                {
                    ddlcompany.Items[i].Selected = true;
                    da = new SqlDataAdapter("select Category_id,Categorynm,companyid from Categorymaster where companyid='" + Company_id1 + "'", con);
                    da.Fill(ds);
                    ddlCategory.DataSource = ds;
                    ddlCategory.DataTextField = "Categorynm";
                    ddlCategory.DataValueField = "Category_id";
                    ddlCategory.DataBind();

                }
                else
                {
                    ddlcompany.Items[i].Selected = false;
                }
            }     
            
            for (int i = 0; i < ddlCategory.Items.Count; i++)
            {
                if (ddlCategory.Items[i].Value == cid)
                {
                    ddlCategory.Items[i].Selected = true;
                    ds.Reset();
                    da = new SqlDataAdapter("select Modelid,Modelnm,Category_id from Modelmaster where Category_id='" + cid + "'", con);
                    da.Fill(ds);
                    ddlmodelnm.DataSource = ds;
                    ddlmodelnm.DataTextField = "Modelnm";
                    ddlmodelnm.DataValueField = "Modelid";
                    ddlmodelnm.DataBind();
                }
                else
                {
                    ddlCategory.Items[i].Selected = false;
                }

            }


            for (int i = 0; i < ddlmodelnm.Items.Count; i++)
            {
                if (ddlmodelnm.Items[i].Value == Modelname1)
                {
                    ddlmodelnm.Items[i].Selected = true;
                }
                else
                {
                    ddlmodelnm.Items[i].Selected = false;
                }

            }

            for (int i = 0; i < ddlFollowuptype.Items.Count; i++)
            {
                if (ddlFollowuptype.Items[i].Text == Followup_type1)
                {
                    ddlFollowuptype.Items[i].Selected = true;
                }
                else
                {
                    ddlFollowuptype.Items[i].Selected = false;
                }

            }

            for (int i = 0; i < ddlfollowupstatus.Items.Count; i++)
            {
                if (ddlfollowupstatus.Items[i].Text == Followup_status1)
                {
                    ddlfollowupstatus.Items[i].Selected = true;
                }
                else
                {
                    ddlfollowupstatus.Items[i].Selected = false;
                }            
            }


            for (int i = 0; i < ddlbranch.Items.Count; i++)
            {
                if (ddlbranch.Items[i].Value == branchid)
                {
                    ddlbranch.Items[i].Selected = true;
                }
                else
                {
                    ddlbranch.Items[i].Selected = false;
                }

            }
            txtmodelno.Text = gl.ds.Tables[0].Rows[0]["Modelno"].ToString();
            string rate = gl.ds.Tables[0].Rows[0]["Customer_comparing_price"].ToString();
            txtcustomercomparingprice.Text = Convert.ToDecimal(rate).ToString("N");
            txtnextfollowupdt.Text = gl.ds.Tables[0].Rows[0]["Next_dt"].ToString();
            Button1.Text = "Update";
        }
        catch { }
    }

    protected void ddlcustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
      //  gl.query("Select * from Enquryform where Customer_name='" + ddlcustomer.SelectedItem.Text + "' and EmployeeCode='"+ddlsales.SelectedValue+"'");
        gl.query("Select * from Enquryform where Enquryid='" + ddlcustomer.SelectedValue + "'");
        if (gl.ds.Tables[0].Rows.Count != 0)
        {
        
        string Company_id1 = gl.ds.Tables[0].Rows[0]["Company_id"].ToString();
        string cid = gl.ds.Tables[0].Rows[0]["Category_id"].ToString();
        string Modelname1 = gl.ds.Tables[0].Rows[0]["Modelname"].ToString();
        string branch_id = gl.ds.Tables[0].Rows[0]["Branchid"].ToString();
        for (int i = 0; i < ddlcompany.Items.Count; i++)
        {
            if (ddlcompany.Items[i].Value == Company_id1)
            {
                ddlcompany.Items[i].Selected = true;
                da = new SqlDataAdapter("select Category_id,Categorynm,companyid from Categorymaster where companyid='" + Company_id1 + "'", con);
                da.Fill(ds);
                ddlCategory.DataSource = ds;
                ddlCategory.DataTextField = "Categorynm";
                ddlCategory.DataValueField = "Category_id";
                ddlCategory.DataBind();

            }
            else
            {
                ddlcompany.Items[i].Selected = false;
            }
        }

        for (int i = 0; i < ddlCategory.Items.Count; i++)
        {
            if (ddlCategory.Items[i].Value == cid)
            {
                ddlCategory.Items[i].Selected = true;
                ds.Reset();
                da = new SqlDataAdapter("select Modelid,Modelnm,Category_id from Modelmaster where Category_id='" + cid + "'", con);
                da.Fill(ds);
                ddlmodelnm.DataSource = ds;
                ddlmodelnm.DataTextField = "Modelnm";
                ddlmodelnm.DataValueField = "Modelid";
                ddlmodelnm.DataBind();
            }
            else
            {
                ddlCategory.Items[i].Selected = false;
            }

        }


        for (int i = 0; i < ddlmodelnm.Items.Count; i++)
        {
            if (ddlmodelnm.Items[i].Text == Modelname1)
            {
                ddlmodelnm.Items[i].Selected = true;
            }
            else
            {
                ddlmodelnm.Items[i].Selected = false;
            }

        }

        for (int i = 0; i < ddlbranch.Items.Count; i++)
        {
            if (ddlbranch.Items[i].Value == branch_id)
            {
                ddlbranch.Items[i].Selected = true;
            }
            else
            {
                ddlbranch.Items[i].Selected = false;
            }

        }

        txtmodelno.Text = gl.ds.Tables[0].Rows[0]["Modelno"].ToString();
        }
    }
    protected void ddlCategory_DataBound(object sender, EventArgs e)
    {
        Convert.ToInt32(ddlCategory.SelectedValue);
        ddlCategory.Items.Insert(0, new ListItem("-Select-", "-Select-")); 
    }
    protected void ddlmodelnm_DataBound(object sender, EventArgs e)
    {
        Convert.ToInt32(ddlmodelnm.SelectedValue);
        ddlmodelnm.Items.Insert(0, new ListItem("-Select-", "-Select-")); 
    }
    protected void ddlcustomer_DataBound(object sender, EventArgs e)
    {
       
        Convert.ToInt32(ddlcustomer.SelectedValue);
        ddlcustomer.Items.Insert(0, new ListItem("-Select-", "-Select-")); 
    }
    protected void ddlsales_SelectedIndexChanged(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("pro_followupmaster_cond'" + ddlsales.SelectedValue + "'", con);
        da.Fill(ds);
        //gl.usepro("pro_followupmaster_cond", "'" + ddlsales.SelectedValue+ "'");
        if(ds.Tables[0].Rows.Count==0)
        {
        display();
        }
        else{
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
       
    }
}