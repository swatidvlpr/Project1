using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Hr_Employee_Reg : System.Web.UI.Page
{
    global gl = new global();
    public SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Conn"].ToString());
    public SqlDataAdapter da = new SqlDataAdapter();
    public DataSet ds = new DataSet();
    string newid;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
           // submit.Attributes.Add("Onclick", "return chkvalidation();");
        if (!IsPostBack)
        {
            Image1.Visible = false;
            if (Request.QueryString["id"] != null)
            {
               // gl.ddl_select("companymaster", "company_id,companyname", "companyname", "company_id", "'0'", "'Select'", ddlcompany);
                gl.ddl_select("companymaster", "company_id,companyname", "companyname", "company_id", "'0'", "'Select'", ddlcompany);
                gl.ddl_select("Departmentmaster", "Depart_id,Departmentnm", "Departmentnm", "Depart_id", "'0'", "'Select'", ddldepartment);

                string idd = Request.QueryString["id"].ToString();
                gl.ds.Clear();
                gl.query("select * from Employee_Reg where Emp_id ='" + idd + "'");

                string Company_id = gl.ds.Tables[0].Rows[0]["Company_id"].ToString();

                for (int i = 0; i < ddlcompany.Items.Count; i++)
                {
                    if (ddlcompany.Items[i].Value == Company_id)
                    {
                        ddlcompany.Items[i].Selected = true;
                        da = new SqlDataAdapter("select location_id,Location_name,Company_id from locationmaster where Company_id='" + Company_id + "'", con);
                        da.Fill(ds);
                        ddllocation.DataSource = ds;
                        ddllocation.DataTextField = "Location_name";
                        ddllocation.DataValueField = "location_id";
                        ddllocation.DataBind();

                    }
                    else
                    {
                        ddlcompany.Items[i].Selected = false;
                    }
                }


                string location_id = gl.ds.Tables[0].Rows[0]["location_id"].ToString();

                for (int i = 0; i < ddllocation.Items.Count; i++)
                {
                    if (ddllocation.Items[i].Value == location_id)
                    {
                        ddllocation.Items[i].Selected = true;
                        ds.Clear();
                        da = new SqlDataAdapter("select Category_id,Categorynm,location_id from Categorymaster where location_id='" + location_id + "'", con);
                        da.Fill(ds);
                        ddlCategory.DataSource = ds;
                        ddlCategory.DataTextField = "Categorynm";
                        ddlCategory.DataValueField = "Category_id";
                        ddlCategory.DataBind();

                    }
                    else
                    {
                        ddllocation.Items[i].Selected = false;
                    }
                }


                string cte_name = gl.ds.Tables[0].Rows[0]["Category_id"].ToString();
                for (int ii = 0; ii < ddlCategory.Items.Count; ii++)
                {
                    if (ddlCategory.Items[ii].Value == cte_name)
                    {
                        ddlCategory.Items[ii].Selected = true;
                        //ds.Reset();
                        //da = new SqlDataAdapter("select Modelid,Modelnm,Category_id from Modelmaster where Category_id='" + cte_name + "'", con);
                        //da.Fill(ds);
                        //ddlmodelnm.DataSource = ds;
                        //ddlmodelnm.DataTextField = "Modelnm";
                        //ddlmodelnm.DataValueField = "Modelid";
                        //ddlmodelnm.DataBind();

                    }
                    else
                    {
                        ddlCategory.Items[ii].Selected = false;
                    }
                }


                txtempcode.Text = gl.ds.Tables[0].Rows[0]["EmployeeCode"].ToString();
                txtname.Text = gl.ds.Tables[0].Rows[0]["Name"].ToString();
                string gend= gl.ds.Tables[0].Rows[0]["Sex"].ToString();
               for(int i=0;i<DropDownList2.Items.Count;i++)
                {
                    if (DropDownList2.Items[i].Text == gend)
                    {
                        DropDownList2.Items[i].Selected = true;

                    }
                    else
                    {
                        DropDownList2.Items[i].Selected = false;
                    }
                }
               string M_status = gl.ds.Tables[0].Rows[0]["Marital_status"].ToString();
               for (int i = 0; i < DropDownList3.Items.Count; i++)
               {
                   if (DropDownList3.Items[i].Text == M_status)
                   {
                       DropDownList3.Items[i].Selected = true;

                   }
                   else
                   {
                       DropDownList3.Items[i].Selected = false;
                   }
               }

               string Blooad_group = gl.ds.Tables[0].Rows[0]["Blooad_group"].ToString();
               for (int i = 0; i < DropDownList4.Items.Count; i++)
               {
                   if (DropDownList4.Items[i].Text == Blooad_group)
                   {
                       DropDownList4.Items[i].Selected = true;

                   }
                   else
                   {
                       DropDownList4.Items[i].Selected = false;
                   }
               }
               string caste = gl.ds.Tables[0].Rows[0]["Caste"].ToString();
               for (int i = 0; i < DropDownList5.Items.Count; i++)
               {
                   if (DropDownList5.Items[i].Text == caste)
                   {
                       DropDownList5.Items[i].Selected = true;

                   }
                   else
                   {
                       DropDownList5.Items[i].Selected = false;
                   }
               }
               TextBox5.Text = gl.ds.Tables[0].Rows[0]["Urban_Rural"].ToString();
               TextBox6.Text = gl.ds.Tables[0].Rows[0]["Address"].ToString();
               TextBox7.Text = gl.ds.Tables[0].Rows[0]["Pincode"].ToString();
               TextBox8.Text = gl.ds.Tables[0].Rows[0]["Mobileno"].ToString();
               TextBox9.Text = gl.ds.Tables[0].Rows[0]["Alternate_mob"].ToString();
               TextBox10.Text = gl.ds.Tables[0].Rows[0]["father_name"].ToString();
               TextBox11.Text = gl.ds.Tables[0].Rows[0]["mother_name"].ToString();
               TextBox12.Text = gl.ds.Tables[0].Rows[0]["father_occupation"].ToString();
               TextBox13.Text = gl.ds.Tables[0].Rows[0]["emailid"].ToString();
               TextBox14.Text = gl.ds.Tables[0].Rows[0]["DOB"].ToString();

              
               TextBox18.Text = gl.ds.Tables[0].Rows[0]["phone_no"].ToString();
               TextBox15.Text = gl.ds.Tables[0].Rows[0]["Qualification"].ToString();
               TextBox16.Text = gl.ds.Tables[0].Rows[0]["Post_applied_for"].ToString();
               TextBox21.Text = gl.ds.Tables[0].Rows[0]["Reference"].ToString();
               TextBox22.Text = gl.ds.Tables[0].Rows[0]["Final_Intv_Date"].ToString();
               TextBox25.Text = gl.ds.Tables[0].Rows[0]["Interviewee"].ToString();
               string Exptd_Salary = gl.ds.Tables[0].Rows[0]["Exptd_Salary"].ToString();
               TextBox26.Text = Convert.ToDecimal(Exptd_Salary).ToString("N");
               TextBox27.Text = gl.ds.Tables[0].Rows[0]["date"].ToString();
               if (gl.ds.Tables[0].Rows[0]["photo"] != "")
               {
                   Image1.Visible = true;
               string imagepath = gl.ds.Tables[0].Rows[0]["photo"].ToString();
               Image1.ImageUrl = imagepath.ToString();
               }
               string companyname = gl.ds.Tables[0].Rows[0]["companyname"].ToString();
               ddlcompany.ClearSelection();
               ddlcompany.Items.FindByText(companyname).Selected = true;

               string Departmentnm = gl.ds.Tables[0].Rows[0]["Departmentnm"].ToString();
               ddldepartment.ClearSelection();
               ddldepartment.Items.FindByText(Departmentnm).Selected = true;
               string Depart_id = gl.ds.Tables[0].Rows[0]["Depart_id"].ToString();

               if (gl.ds.Tables[0].Rows[0]["Depart_id"] == "")
               {

               }
               else
               {
              

              // string Depart_id = gl.ds.Tables[0].Rows[0]["Depart_id"].ToString();
               DataSet ds1 = new DataSet();
               //ds.Clear();

               da = new SqlDataAdapter("select Designation_id,Designationnm,Depart_id from Designation where Depart_id='" + Depart_id + "'", con);
               da.Fill(ds1);
               ddlDesignation.DataSource = ds1;
               ddlDesignation.DataTextField = "Designationnm";
               ddlDesignation.DataValueField = "Designation_id";
               ddlDesignation.DataBind();

               string Designation_id = gl.ds.Tables[0].Rows[0]["Designation_id"].ToString();

               for (int i = 0; i < ddlDesignation.Items.Count; i++)
               {
                   if (ddlDesignation.Items[i].Value == Designation_id)
                   {

                       ddlDesignation.Items[i].Selected = true;
                   }
                   else
                   {
                       ddlDesignation.Items[i].Selected = false;
                   }
               }
               }


               //string Religion = gl.ds.Tables[0].Rows[0]["Religion"].ToString();
               //for (int i = 0; i < DropDownList6.Items.Count; i++)
               //{
               //    if (DropDownList6.Items[i].Text == Religion)
               //    {
               //        DropDownList6.Items[i].Selected = true;

               //    }
               //    else
               //    {
               //        DropDownList6.Items[i].Selected = false;
               //    }
               //}
               



               if (DropDownList6.Items.FindByValue("Religion") != null)
               {
                   DropDownList6.Items.FindByValue("Religion").Selected = true;
               }


             

               txtempcode.ReadOnly = true;
               DataTable dt = new DataTable();
               dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Attachmentfilename"), new DataColumn("Attach_file"), new DataColumn("EmployeeCode"), new DataColumn("Emp_id") });
               gl.da = new SqlDataAdapter("select * from employee_Attachmentfile where EmployeeCode='" + txtempcode.Text + "'", gl.con);
               gl.da.Fill(dt);
               ViewState["Attachment"] = dt;
               GridView1.DataSource = (DataTable)ViewState["Attachment"];
               GridView1.DataBind();
               submit.Text = "Update";
            }
            else
            {
                gl.ddl_select("companymaster", "company_id,companyname", "companyname", "company_id","'0'","'Select'",ddlcompany);
                gl.ddl_select("Departmentmaster", "Depart_id,Departmentnm", "Departmentnm", "Depart_id", "'0'", "'Select'", ddldepartment);

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Attachmentfilename"), new DataColumn("Attach_file"), new DataColumn("EmployeeCode"), new DataColumn("Emp_id") });
            ViewState["Attachment"] = dt;
            this.BindGrid();
            }
           
        }


        }
        catch
        {
        }

    }
    protected void submit_Click(object sender, EventArgs e)
    {

        try
        {
        if (submit.Text == "Update")
            {
                string idd = Request.QueryString["id"].ToString();
                //DateTime crnttime = Convert.ToDateTime(TextBox27.Text);
                //TimeZoneInfo tzn = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                //DateTime IndianTme = TimeZoneInfo.ConvertTime(crnttime, tzn);
                //string time1 = IndianTme.ToString("dd/MM/yyyy");
                //string mnth1 = IndianTme.ToString("MM");
                //string year1 = IndianTme.ToString("yyyy");

                if (FileUpload2.HasFile)
                {
                    string ss = "photo" + "/" + FileUpload2.FileName;
                    FileUpload2.SaveAs(Server.MapPath(ss));

                    // Read the file and convert it to Byte Array
                    string filePath = FileUpload2.PostedFile.FileName;
                    //string filename = Path.GetFileName(filePath);
                    // string ext = Path.GetExtension(filename);
                    string contenttype = String.Empty;

                    //Set the contenttype based on File Extension

                    //if (contenttype != String.Empty)
                    //{
                    //using (SqlCommand cmd = new SqlCommand("insert into Employee_Reg(EmployeeCode, Name, Sex, Marital_status, Caste, Blooad_group, Urban_Rural, Address, Pincode, Mobileno, Alternate_mob,father_name, mother_name,father_occupation, emailid, DOB, Religion, phone_no, Qualification, Post_applied_for, Reference, Final_Intv_Date, Interviewee, Exptd_Salary, date,photo,month,year) values(@EmployeeCode,@Name,@Sex,@Marital_status,@Caste,@Blooad_group,@Urban_Rural,@Address,@Pincode,@Mobileno,@Alternate_mob,@father_name,@mother_name,@father_occupation,@emailid,@DOB,@Religion,@phone_no,@Qualification,@Post_applied_for,@Reference,@Final_Intv_Date,@Interviewee,@Exptd_Salary,@date,@photo,@month,@year)", gl.con))
                    //{
                    using (SqlCommand cmd = new SqlCommand("update Employee_Reg set Name=@Name, Sex=@Sex, Marital_status=@Marital_status, Caste=@Caste, Blooad_group=@Blooad_group, Urban_Rural=@Urban_Rural, Address=@Address, Pincode=@Pincode, Mobileno=@Mobileno, Alternate_mob=@Alternate_mob,father_name=@father_name, mother_name=@mother_name,father_occupation=@father_occupation, emailid=@emailid, DOB=@DOB, Religion=@Religion, phone_no=@phone_no, Qualification=@Qualification, Post_applied_for=@Post_applied_for, Reference=@Reference, Final_Intv_Date=@Final_Intv_Date, Interviewee=@Interviewee, Exptd_Salary=@Exptd_Salary,photo=@photo,companyname=@companyname,Departmentnm=@Departmentnm,company_id=@company_id,location_id=@location_id,Category_id=@Category_id,Designation_id=@Designation_id,Depart_id=@Depart_id where Emp_id=@Emp_id", gl.con))
                    {
                        // cmd.Parameters.AddWithValue("@text1", "mother's love");
                        cmd.Parameters.AddWithValue("@Emp_id", idd);
                        cmd.Parameters.AddWithValue("@Name", txtname.Text);
                        cmd.Parameters.AddWithValue("@Sex", DropDownList2.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Marital_status", DropDownList3.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Caste", DropDownList5.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Blooad_group", DropDownList4.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Urban_Rural", TextBox5.Text);
                        cmd.Parameters.AddWithValue("@Address", TextBox6.Text);
                        cmd.Parameters.AddWithValue("@Pincode", TextBox7.Text);
                        cmd.Parameters.AddWithValue("@Mobileno", TextBox8.Text);
                        cmd.Parameters.AddWithValue("@Alternate_mob", TextBox9.Text);
                        cmd.Parameters.AddWithValue("@father_name", TextBox10.Text);
                        cmd.Parameters.AddWithValue("@mother_name", TextBox11.Text);
                        cmd.Parameters.AddWithValue("@father_occupation", TextBox12.Text);
                        cmd.Parameters.AddWithValue("@emailid", TextBox13.Text);
                        cmd.Parameters.AddWithValue("@DOB", TextBox14.Text);
                        cmd.Parameters.AddWithValue("@Religion", DropDownList6.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@phone_no", TextBox18.Text);
                        cmd.Parameters.AddWithValue("@Qualification", TextBox15.Text);
                        cmd.Parameters.AddWithValue("@Post_applied_for", TextBox16.Text);
                        cmd.Parameters.AddWithValue("@Reference", TextBox21.Text);
                        cmd.Parameters.AddWithValue("@Final_Intv_Date", TextBox25.Text);
                        cmd.Parameters.AddWithValue("@Interviewee", TextBox25.Text);
                        decimal sal = Convert.ToDecimal(TextBox26.Text);
                        cmd.Parameters.AddWithValue("@Exptd_Salary", sal);
                        cmd.Parameters.AddWithValue("@photo", ss);
                        cmd.Parameters.AddWithValue("@companyname", ddlcompany.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Departmentnm", ddldepartment.SelectedItem.Text);

                        //cmd.Parameters.AddWithValue("@id", HiddenField2.Value);
                        cmd.Parameters.AddWithValue("@company_id", ddlcompany.SelectedValue);
                        cmd.Parameters.AddWithValue("@location_id", ddllocation.SelectedValue);
                        cmd.Parameters.AddWithValue("@Category_id", ddlCategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@Designation_id", ddlDesignation.SelectedValue);
                        cmd.Parameters.AddWithValue("@Depart_id", ddldepartment.SelectedValue);
                        gl.con.Open();
                        cmd.ExecuteNonQuery();
                        gl.con.Close();
                        //...
                    }

                    DataTable dt = (DataTable)ViewState["Attachment"];
                    ViewState["Attachment"] = dt;



                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string Attachmentfilename = dt.Rows[i]["Attachmentfilename"].ToString();
                        string Attach_file = dt.Rows[i]["Attach_file"].ToString();
                        //string EmployeeCode = dt.Rows[i]["EmployeeCode"].ToString();
                        string EmployeeCode = txtempcode.Text;
                        gl.query("select * from employee_Attachmentfile where Attachmentfilename='" + Attachmentfilename + "' and EmployeeCode='" + txtempcode.Text + "'");
                        if (gl.ds.Tables[0].Rows.Count !=0)
                        {

                        }
                        else
                        {
                            using (SqlCommand cmd = new SqlCommand("insert into employee_Attachmentfile(Attachmentfilename, Attach_file, EmployeeCode) values(@Attachmentfilename,@Attach_file,@EmployeeCode)", gl.con))
                            {
                                // cmd.Parameters.AddWithValue("@text1", "mother's love");
                                cmd.Parameters.AddWithValue("@Attachmentfilename", Attachmentfilename);
                                cmd.Parameters.AddWithValue("@Attach_file", Attach_file);
                                cmd.Parameters.AddWithValue("@EmployeeCode", txtempcode.Text);
                                gl.con.Open();
                                cmd.ExecuteNonQuery();
                                gl.con.Close();
                            }

                        }

                    }
                    Label1.ForeColor = System.Drawing.Color.Green;
                    Label1.Text = "Update sucessfully";
                    Response.Write("<script>alert('Update sucessfully')</script>");
                    //}
                }
                else
                {

                    using (SqlCommand cmd = new SqlCommand("update Employee_Reg set Name=@Name, Sex=@Sex, Marital_status=@Marital_status, Caste=@Caste, Blooad_group=@Blooad_group, Urban_Rural=@Urban_Rural, Address=@Address, Pincode=@Pincode, Mobileno=@Mobileno, Alternate_mob=@Alternate_mob,father_name=@father_name, mother_name=@mother_name,father_occupation=@father_occupation, emailid=@emailid, DOB=@DOB, Religion=@Religion, phone_no=@phone_no, Qualification=@Qualification, Post_applied_for=@Post_applied_for, Reference=@Reference, Final_Intv_Date=@Final_Intv_Date, Interviewee=@Interviewee, Exptd_Salary=@Exptd_Salary,companyname=@companyname,Departmentnm=@Departmentnm,company_id=@company_id,location_id=@location_id,Category_id=@Category_id,Designation_id=@Designation_id,Depart_id=@Depart_id where Emp_id=@Emp_id", gl.con))
                    {
                        // cmd.Parameters.AddWithValue("@text1", "mother's love");
                        cmd.Parameters.AddWithValue("@Emp_id", idd);
                        cmd.Parameters.AddWithValue("@Name", txtname.Text);
                        cmd.Parameters.AddWithValue("@Sex", DropDownList2.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Marital_status", DropDownList3.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Caste", DropDownList5.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Blooad_group", DropDownList4.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Urban_Rural", TextBox5.Text);
                        cmd.Parameters.AddWithValue("@Address", TextBox6.Text);
                        cmd.Parameters.AddWithValue("@Pincode", TextBox7.Text);
                        cmd.Parameters.AddWithValue("@Mobileno", TextBox8.Text);
                        cmd.Parameters.AddWithValue("@Alternate_mob", TextBox9.Text);
                        cmd.Parameters.AddWithValue("@father_name", TextBox10.Text);
                        cmd.Parameters.AddWithValue("@mother_name", TextBox11.Text);
                        cmd.Parameters.AddWithValue("@father_occupation", TextBox12.Text);
                        cmd.Parameters.AddWithValue("@emailid", TextBox13.Text);
                        cmd.Parameters.AddWithValue("@DOB", TextBox14.Text);
                        cmd.Parameters.AddWithValue("@Religion", DropDownList6.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@phone_no", TextBox18.Text);
                        cmd.Parameters.AddWithValue("@Qualification", TextBox15.Text);
                        cmd.Parameters.AddWithValue("@Post_applied_for", TextBox16.Text);
                        cmd.Parameters.AddWithValue("@Reference", TextBox21.Text);
                        cmd.Parameters.AddWithValue("@Final_Intv_Date", TextBox25.Text);
                        cmd.Parameters.AddWithValue("@Interviewee", TextBox25.Text);
                        decimal sal = Convert.ToDecimal(TextBox26.Text);
                        cmd.Parameters.AddWithValue("@Exptd_Salary", sal);
                        cmd.Parameters.AddWithValue("@companyname", ddlcompany.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Departmentnm", ddldepartment.SelectedItem.Text);
                        //cmd.Parameters.AddWithValue("@date", TextBox27.Text);
                        //cmd.Parameters.AddWithValue("@month", mnth1);
                        //cmd.Parameters.AddWithValue("@year", year1);

                      //  cmd.Parameters.AddWithValue("@id", HiddenField2.Value);
                        cmd.Parameters.AddWithValue("@company_id", ddlcompany.SelectedValue);
                        cmd.Parameters.AddWithValue("@location_id", ddllocation.SelectedValue);
                        cmd.Parameters.AddWithValue("@Category_id", ddlCategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@Designation_id", ddlDesignation.SelectedValue);
                        cmd.Parameters.AddWithValue("@Depart_id", ddldepartment.SelectedValue);
                        gl.con.Open();
                        cmd.ExecuteNonQuery();
                        gl.con.Close();
                        //...
                    }

                    DataTable dt = (DataTable)ViewState["Attachment"];
                    ViewState["Attachment"] = dt;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string Attachmentfilename = dt.Rows[i]["Attachmentfilename"].ToString();
                        string Attach_file = dt.Rows[i]["Attach_file"].ToString();
                        //string EmployeeCode = dt.Rows[i]["EmployeeCode"].ToString();
                        string EmployeeCode = txtempcode.Text;
                        gl.query("select * from employee_Attachmentfile where Attachmentfilename='" + Attachmentfilename + "' and EmployeeCode='" + txtempcode.Text + "'");
                        if (gl.ds.Tables[0].Rows.Count !=0)
                        {

                        }
                        else
                        {
                            using (SqlCommand cmd = new SqlCommand("insert into employee_Attachmentfile(Attachmentfilename, Attach_file, EmployeeCode) values(@Attachmentfilename,@Attach_file,@EmployeeCode)", gl.con))
                            {
                                // cmd.Parameters.AddWithValue("@text1", "mother's love");
                                cmd.Parameters.AddWithValue("@Attachmentfilename", Attachmentfilename);
                                cmd.Parameters.AddWithValue("@Attach_file", Attach_file);
                                cmd.Parameters.AddWithValue("@EmployeeCode", txtempcode.Text);
                                gl.con.Open();
                                cmd.ExecuteNonQuery();
                                gl.con.Close();
                            }

                        }

                    }
                    Label1.ForeColor = System.Drawing.Color.Green;
                   // Label1.Text = "Update sucessfully";
                    Response.Write("<script>alert('Update sucessfully')</script>");

                }
            
            }
            else
            {

                //DateTime crnttime = Convert.ToDateTime(TextBox27.Text);
                //TimeZoneInfo tzn = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                //DateTime IndianTme = TimeZoneInfo.ConvertTime(crnttime, tzn);
                //string time1 = IndianTme.ToString("dd/MM/yyyy");
                //string mnth1 = IndianTme.ToString("MM");
                //string year1 = IndianTme.ToString("yyyy");

                if (FileUpload2.HasFile)
                {
                    string ss = "photo" + "/" + FileUpload2.FileName;
                    FileUpload2.SaveAs(Server.MapPath(ss));

                    // Read the file and convert it to Byte Array
                    string filePath = FileUpload2.PostedFile.FileName;
                    //string filename = Path.GetFileName(filePath);
                    // string ext = Path.GetExtension(filename);
                    string contenttype = String.Empty;

                    //Set the contenttype based on File Extension

                    //if (contenttype != String.Empty)
                    //{
                    using (SqlCommand cmd = new SqlCommand("insert into Employee_Reg(EmployeeCode, Name, Sex, Marital_status, Caste, Blooad_group, Urban_Rural, Address, Pincode, Mobileno, Alternate_mob,father_name, mother_name,father_occupation, emailid, DOB, Religion, phone_no, Qualification, Post_applied_for, Reference, Final_Intv_Date, Interviewee, Exptd_Salary, date,photo,companyname,Departmentnm,id,company_id, location_id, Category_id,Designation_id,Depart_id) values(@EmployeeCode,@Name,@Sex,@Marital_status,@Caste,@Blooad_group,@Urban_Rural,@Address,@Pincode,@Mobileno,@Alternate_mob,@father_name,@mother_name,@father_occupation,@emailid,@DOB,@Religion,@phone_no,@Qualification,@Post_applied_for,@Reference,@Final_Intv_Date,@Interviewee,@Exptd_Salary,@date,@photo,@companyname,@Departmentnm,@id,@company_id,@location_id,@Category_id,@Designation_id,@Depart_id)", gl.con))
                    {
                        // cmd.Parameters.AddWithValue("@text1", "mother's love");
                        cmd.Parameters.AddWithValue("@EmployeeCode", txtempcode.Text);
                        cmd.Parameters.AddWithValue("@Name", txtname.Text);
                        cmd.Parameters.AddWithValue("@Sex", DropDownList2.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Marital_status", DropDownList3.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Caste", DropDownList5.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Blooad_group", DropDownList4.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Urban_Rural", TextBox5.Text);
                        cmd.Parameters.AddWithValue("@Address", TextBox6.Text);
                        cmd.Parameters.AddWithValue("@Pincode", TextBox7.Text);
                        cmd.Parameters.AddWithValue("@Mobileno", TextBox8.Text);
                        cmd.Parameters.AddWithValue("@Alternate_mob", TextBox9.Text);
                        cmd.Parameters.AddWithValue("@father_name", TextBox10.Text);
                        cmd.Parameters.AddWithValue("@mother_name", TextBox11.Text);
                        cmd.Parameters.AddWithValue("@father_occupation", TextBox12.Text);
                        cmd.Parameters.AddWithValue("@emailid", TextBox13.Text);
                        cmd.Parameters.AddWithValue("@DOB", TextBox14.Text);
                        cmd.Parameters.AddWithValue("@Religion", DropDownList6.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@phone_no", TextBox18.Text);
                        cmd.Parameters.AddWithValue("@Qualification", TextBox15.Text);
                        cmd.Parameters.AddWithValue("@Post_applied_for", TextBox16.Text);
                        cmd.Parameters.AddWithValue("@Reference", TextBox21.Text);
                        cmd.Parameters.AddWithValue("@Final_Intv_Date", TextBox25.Text);
                        cmd.Parameters.AddWithValue("@Interviewee", TextBox25.Text);
                        decimal sal = Convert.ToDecimal(TextBox26.Text);
                        cmd.Parameters.AddWithValue("@Exptd_Salary", sal);
                        cmd.Parameters.AddWithValue("@date", TextBox27.Text);
                        cmd.Parameters.AddWithValue("@photo", ss);
                        //cmd.Parameters.AddWithValue("@month", mnth1);
                        //cmd.Parameters.AddWithValue("@year", year1);
                        cmd.Parameters.AddWithValue("@companyname",ddlcompany.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Departmentnm",ddldepartment.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@id",HiddenField2.Value);
                        
                        cmd.Parameters.AddWithValue("@company_id", ddlcompany.SelectedValue);
                        cmd.Parameters.AddWithValue("@location_id",ddllocation.SelectedValue);
                        cmd.Parameters.AddWithValue("@Category_id",ddlCategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@Designation_id",ddlDesignation.SelectedValue);
                        cmd.Parameters.AddWithValue("@Depart_id", ddldepartment.SelectedValue);
                        gl.con.Open();
                        cmd.ExecuteNonQuery();
                        gl.con.Close();
                        //...
                    }

                    DataTable dt = (DataTable)ViewState["Attachment"];
                    ViewState["Attachment"] = dt;



                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string Attachmentfilename = dt.Rows[i]["Attachmentfilename"].ToString();
                        string Attach_file = dt.Rows[i]["Attach_file"].ToString();
                        //string EmployeeCode = dt.Rows[i]["EmployeeCode"].ToString();
                        string EmployeeCode = txtempcode.Text;
                        using (SqlCommand cmd = new SqlCommand("insert into employee_Attachmentfile(Attachmentfilename, Attach_file, EmployeeCode) values(@Attachmentfilename,@Attach_file,@EmployeeCode)", gl.con))
                        {
                            // cmd.Parameters.AddWithValue("@text1", "mother's love");
                            cmd.Parameters.AddWithValue("@Attachmentfilename", Attachmentfilename);
                            cmd.Parameters.AddWithValue("@Attach_file", Attach_file);
                            cmd.Parameters.AddWithValue("@EmployeeCode", txtempcode.Text);
                            gl.con.Open();
                            cmd.ExecuteNonQuery();
                            gl.con.Close();
                        }



                    }
                    Label1.ForeColor = System.Drawing.Color.Green;
                    //Label1.Text = "Submitted sucessfully";
                    Response.Write("<script>alert('Submitted sucessfully')</script>");
                    //}
                }
                else
                {

                    using (SqlCommand cmd = new SqlCommand("insert into Employee_Reg(EmployeeCode, Name, Sex, Marital_status, Caste, Blooad_group, Urban_Rural, Address, Pincode, Mobileno, Alternate_mob,father_name, mother_name,father_occupation, emailid, DOB, Religion, phone_no, Qualification, Post_applied_for, Reference, Final_Intv_Date, Interviewee, Exptd_Salary, date,companyname,Departmentnm,id,company_id, location_id, Category_id,Designation_id,Depart_id) values(@EmployeeCode,@Name,@Sex,@Marital_status,@Caste,@Blooad_group,@Urban_Rural,@Address,@Pincode,@Mobileno,@Alternate_mob,@father_name,@mother_name,@father_occupation,@emailid,@DOB,@Religion,@phone_no,@Qualification,@Post_applied_for,@Reference,@Final_Intv_Date,@Interviewee,@Exptd_Salary,@date,@companyname,@Departmentnm,@id,@company_id,@location_id,@Category_id,@Designation_id,@Depart_id)", gl.con))
                    {
                        // cmd.Parameters.AddWithValue("@text1", "mother's love");
                        cmd.Parameters.AddWithValue("@EmployeeCode", txtempcode.Text);
                        cmd.Parameters.AddWithValue("@Name", txtname.Text);
                        cmd.Parameters.AddWithValue("@Sex", DropDownList2.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Marital_status", DropDownList3.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Caste", DropDownList5.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Blooad_group", DropDownList4.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Urban_Rural", TextBox5.Text);
                        cmd.Parameters.AddWithValue("@Address", TextBox6.Text);
                        cmd.Parameters.AddWithValue("@Pincode", TextBox7.Text);
                        cmd.Parameters.AddWithValue("@Mobileno", TextBox8.Text);
                        cmd.Parameters.AddWithValue("@Alternate_mob", TextBox9.Text);
                        cmd.Parameters.AddWithValue("@father_name", TextBox10.Text);
                        cmd.Parameters.AddWithValue("@mother_name", TextBox11.Text);
                        cmd.Parameters.AddWithValue("@father_occupation", TextBox12.Text);
                        cmd.Parameters.AddWithValue("@emailid", TextBox13.Text);
                        cmd.Parameters.AddWithValue("@DOB", TextBox14.Text);
                        cmd.Parameters.AddWithValue("@Religion", DropDownList6.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@phone_no", TextBox18.Text);
                        cmd.Parameters.AddWithValue("@Qualification", TextBox15.Text);
                        cmd.Parameters.AddWithValue("@Post_applied_for", TextBox16.Text);
                        cmd.Parameters.AddWithValue("@Reference", TextBox21.Text);
                        cmd.Parameters.AddWithValue("@Final_Intv_Date", TextBox25.Text);
                        cmd.Parameters.AddWithValue("@Interviewee", TextBox25.Text);
                        decimal sal = Convert.ToDecimal(TextBox26.Text);
                        cmd.Parameters.AddWithValue("@Exptd_Salary", sal);
                        cmd.Parameters.AddWithValue("@date", TextBox27.Text);
                        //cmd.Parameters.AddWithValue("@month", mnth1);
                        //cmd.Parameters.AddWithValue("@year", year1);
                        cmd.Parameters.AddWithValue("@companyname", ddlcompany.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@Departmentnm", ddldepartment.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@id", HiddenField2.Value);
                        cmd.Parameters.AddWithValue("@company_id", ddlcompany.SelectedValue);
                        cmd.Parameters.AddWithValue("@location_id", ddllocation.SelectedValue);
                        cmd.Parameters.AddWithValue("@Category_id", ddlCategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@Designation_id", ddlDesignation.SelectedValue);
                        cmd.Parameters.AddWithValue("@Depart_id", ddldepartment.SelectedValue);
                     
                        gl.con.Open();
                        cmd.ExecuteNonQuery();
                        gl.con.Close();
                        //...
                    }

                    DataTable dt = (DataTable)ViewState["Attachment"];
                    ViewState["Attachment"] = dt;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string Attachmentfilename = dt.Rows[i]["Attachmentfilename"].ToString();
                        string Attach_file = dt.Rows[i]["Attach_file"].ToString();
                        //string EmployeeCode = dt.Rows[i]["EmployeeCode"].ToString();
                        string EmployeeCode = txtempcode.Text;
                        using (SqlCommand cmd = new SqlCommand("insert into employee_Attachmentfile(Attachmentfilename, Attach_file, EmployeeCode) values(@Attachmentfilename,@Attach_file,@EmployeeCode)", gl.con))
                        {
                            // cmd.Parameters.AddWithValue("@text1", "mother's love");
                            cmd.Parameters.AddWithValue("@Attachmentfilename", Attachmentfilename);
                            cmd.Parameters.AddWithValue("@Attach_file", Attach_file);
                            cmd.Parameters.AddWithValue("@EmployeeCode", txtempcode.Text);
                            gl.con.Open();
                            cmd.ExecuteNonQuery();
                            gl.con.Close();
                        }



                    }
                    Label1.ForeColor = System.Drawing.Color.Green;
                    //Label1.Text = "Submitted sucessfully";
                    Response.Write("<script>alert('Submitted sucessfully')</script>");

                }
            }

        clear();


        }
        catch
        { }

    }
    public void clear()
    {
        txtname.Text = "";
        txtempcode.Text = "";
        DropDownList2.SelectedIndex = 0;
        DropDownList3.SelectedIndex = 0;
        DropDownList4.SelectedIndex = 0;
        DropDownList5.SelectedIndex = 0;
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
        TextBox11.Text = "";
        TextBox12.Text = "";
        TextBox13.Text = "";
        TextBox14.Text = "";
        DropDownList6.SelectedIndex = 0;
        TextBox18.Text = "";
        TextBox15.Text = "";
        TextBox16.Text = "";
        TextBox21.Text = "";
        TextBox22.Text = "";
        TextBox25.Text = "";
        TextBox26.Text = "00.00";
        
        ddldepartment.SelectedIndex = 0;
        ddlDesignation.SelectedIndex = 0;
        TextBox27.Text = "";
        DropDownList1.SelectedIndex = 0;
        DataTable dt =(DataTable)ViewState["Attachment"];
        dt.Clear();
        GridView1.DataSource = null;
        GridView1.DataBind();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string ss = "attachment" + "/" + FileUpload1.FileName;
        FileUpload1.SaveAs(Server.MapPath(ss));
        HiddenField1.Value = ss;

        DataTable dt = (DataTable)ViewState["Attachment"];
        dt.Rows.Add(DropDownList1.SelectedItem.Text, HiddenField1.Value);
        ViewState["Attachment"] = dt;
        this.BindGrid();
        //txtdescription.Text = string.Empty;
        //txthsn.Text = string.Empty;
        //DropDownList1.SelectedIndex = 0;
        //txtall_quantity.Text = string.Empty;
        //ddltype.SelectedIndex = 0;
        //txtquantity.Text = string.Empty;
        //ddlquanty.SelectedIndex = 0;
        //txtxrate.Text = string.Empty;
        //txtper.Text = string.Empty;
        //txt_amt.Text = string.Empty;
        //txt_totalgst.Text = string.Empty;
    }
    protected void BindGrid()
    {
        GridView1.DataSource = (DataTable)ViewState["Attachment"];
        GridView1.DataBind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string id1 = GridView1.DataKeys[e.RowIndex].Value.ToString();
        if (id1 != "")
        {
            int idd = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            gl.delete("employee_Attachmentfile", "Emp_id", "'" + idd + "'");
        }
        else
        {

        }
        int index = Convert.ToInt32(e.RowIndex);
        DataTable dt = ViewState["Attachment"] as DataTable;
        dt.Rows[index].Delete();
        ViewState["Attachment"] = dt;    

        
       


        //for (int i = 0; i < dt.Rows.Count; i++)
        //{
        //    string Attachmentfilename = dt.Rows[i]["Attachmentfilename"].ToString();
        //    //string Attach_file = dt.Rows[i]["Attach_file"].ToString();
        //    string indexid = dt.Rows[i]["Emp_id"].ToString();
        //    //string EmployeeCode = dt.Rows[i]["EmployeeCode"].ToString();
        //    string EmployeeCode = txtempcode.Text;
        //    gl.query("select * from employee_Attachmentfile where Attachmentfilename='" + Attachmentfilename + "' and Emp_id='" + index + "'");
        //    if (gl.ds.Tables[0].Rows.Count != 0)
        //    {
        //        gl.delete("employee_Attachmentfile", "Emp_id", "'" + index + "'");
        //    }
        //    else
        //    {
        //        //using (SqlCommand cmd = new SqlCommand("insert into employee_Attachmentfile(Attachmentfilename, Attach_file, EmployeeCode) values(@Attachmentfilename,@Attach_file,@EmployeeCode)", gl.con))
        //        //{
        //        //    // cmd.Parameters.AddWithValue("@text1", "mother's love");
        //        //    cmd.Parameters.AddWithValue("@Attachmentfilename", Attachmentfilename);
        //        //    cmd.Parameters.AddWithValue("@Attach_file", Attach_file);
        //        //    cmd.Parameters.AddWithValue("@EmployeeCode", txtempcode.Text);
        //        //    gl.con.Open();
        //        //    cmd.ExecuteNonQuery();
        //        //    gl.con.Close();
        //        //}

        //    }

        //}


        BindGrid();
            //txtdescription.Text = string.Empty;
            //txthsn.Text = string.Empty;
            //DropDownList1.SelectedIndex = 0;
            //txtall_quantity.Text = string.Empty;
            //ddltype.SelectedIndex = 0;
            //txtquantity.Text = string.Empty;
            //ddlquanty.SelectedIndex = 0;
            //txtxrate.Text = string.Empty;
            //txtper.Text = string.Empty;
            //txt_amt.Text = string.Empty;
            //txt_totalgst.Text = string.Empty;
            //Hidden_uom.Value = TextBox10.Text;
            //TextBox10.Text = string.Empty;
        
    }
    protected void TextBox22_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Employee_Reg.aspx");
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
    protected void ddllocation_DataBound(object sender, EventArgs e)
    {
        Convert.ToInt32(ddllocation.SelectedValue);
       
        ddllocation.Items.Insert(0, new ListItem("-Select-", "-Select-")); 
    }
    protected void ddllocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            //gl.ddlcond("Categorymaster", "Categorynm", "Category_id", "location_id", "'" + ddllocation.SelectedValue + "'", ddlCategory);
            gl.query("Select * from Categorymaster where location_id='" + ddllocation.SelectedValue + "' and companyid='"+ddlcompany.SelectedValue+"'");
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
    protected void ddlCategory_DataBound(object sender, EventArgs e)
    {
        ddlCategory.Items.Insert(0, new ListItem("-Select-", "-Select-")); 
    }
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        //gl.returncol("companymaster", "company_id", "'"+ddlcompany.SelectedValue+"'");
        //string companyshort = gl.ds.Tables[0].Rows[0]["companyshtct"].ToString();
        //gl.returncol2("locationmaster", "Company_id", "'" + ddlcompany.SelectedValue + "'", "location_id", "'"+ddllocation.SelectedValue+"'");
        //string locationshort = gl.ds.Tables[0].Rows[0]["Locationshtct"].ToString();

        //string Row = "";
        //for (int i = 1; i <= 1230; i++)
        //{
        //    Row += "st" + i.ToString("000") + System.Environment.NewLine;
        //}
        //Label1.Text = Row;
    }
    protected void txtname_TextChanged(object sender, EventArgs e)
    {
        //try { 
       
        gl.returncol("companymaster", "company_id", "'" + ddlcompany.SelectedValue + "'");
        string companyshort = gl.ds.Tables[0].Rows[0]["companyshtct"].ToString();
        gl.returncol2("locationmaster", "Company_id", "'" + ddlcompany.SelectedValue + "'", "location_id", "'" + ddllocation.SelectedValue + "'");
        string locationshort = gl.ds.Tables[0].Rows[0]["Locationshtct"].ToString();
        // gl.query("Categorymaster", "companyid", "'" + ddlcompany.SelectedValue + "'", "location_id", "'" + ddllocation.SelectedValue + "'");
        gl.query("Select * from Categorymaster where companyid='" + ddlcompany.SelectedValue + "' and location_id='" + ddllocation.SelectedValue + "' and Category_id='" + ddlCategory.SelectedValue + "'");
        string Categorysrt = gl.ds.Tables[0].Rows[0]["Categoryshtct"].ToString();
        string ss = companyshort + "/" + locationshort + "/" + Categorysrt + "";
        string Row = "";
        con.Open();
        if (txtempcode.Text == "")
        {
            SqlCommand cmd;
            int getval;
            string getstr;
           // //getstr="select isnull(max(convert(int,(substring(id,1,1)))),0)+1 from txt";
          //  getstr = "select isnull(max(id),0)+1 from Employee_Reg";
            getstr = "select isnull(max(id),0)+1 from Employee_Reg where company_id='" + ddlcompany.SelectedValue + "' and location_id='" + ddllocation.SelectedValue + "' and Category_id='" + ddlCategory.SelectedValue + "'";
            cmd = new SqlCommand(getstr, con);
            getval = Convert.ToInt16(cmd.ExecuteScalar());
            //Row += "st" + getval.ToString("000");
            Row += "" + ss + "" + getval.ToString("0000");
            //gl.insert1("txt", "EmployeeCode,id", "'" + Row + "','" + getval + "'");
           // Label1.Text = Row;
            txtempcode.Text = Row;
            HiddenField2.Value = Convert.ToInt32(getval).ToString();
        }
        else
        { 
        
        }

        //}
        //catch
        //{ }
    }
    protected void txtempcode_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ddldepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            gl.ddlcond("Designation", "Designationnm", "Designation_id", "Depart_id", "'" + ddldepartment.SelectedValue + "'", ddlDesignation);
            //gl.query("Select location_id,Company_id,Location_name,Locationshtct from locationmaster where Company_id='" + ddlcompany.SelectedValue + "'");
            //ddllocation.DataSource = gl.ds;
            //ddllocation.DataTextField = "Location_name";
            //ddllocation.DataValueField = "location_id";
            //ddllocation.DataBind();
            //ddlDesignation.SelectedIndex = 0;
        }
        catch
        {
        }
    }
    protected void ddlDesignation_DataBound(object sender, EventArgs e)
    {
        //Convert.ToInt32(ddlDesignation.SelectedValue);
        ddlDesignation.Items.Insert(0, new ListItem("-Select-", "-Select-")); 
    }
}