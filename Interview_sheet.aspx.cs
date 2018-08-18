using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Hr_Interview_sheet : System.Web.UI.Page
{
    global gl = new global();
    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ToString());
  protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    string idd = Request.QueryString["id"].ToString();
                    gl.read1("Interview_sheet", "interview_id", "'" + idd + "'");
                    string Basic_qualification = gl.ds.Tables[0].Rows[0]["Basic_qualification"].ToString();
                    for (int i = 0; i < RadioButtonList6.Items.Count; i++)
                    {
                        if (RadioButtonList6.Items[i].Text == Basic_qualification)
                        {
                            RadioButtonList6.Items[i].Selected = true;

                        }
                        else
                        {
                            RadioButtonList6.Items[i].Selected = false;
                        }
                    }
                    string Professional_qualification = gl.ds.Tables[0].Rows[0]["Professional_qualification"].ToString();
                    for (int i = 0; i < DropDownList1.Items.Count; i++)
                    {
                        if (DropDownList1.Items[i].Text == Professional_qualification)
                        {
                            DropDownList1.Items[i].Selected = true;

                        }
                        else
                        {
                            DropDownList1.Items[i].Selected = false;
                        }
                    }
                    string Experience_details = gl.ds.Tables[0].Rows[0]["Experience_details"].ToString();
                    for (int i = 0; i < RadioButtonList1.Items.Count; i++)
                    {
                        if (RadioButtonList1.Items[i].Text == Experience_details)
                        {
                            RadioButtonList1.Items[i].Selected = true;

                        }
                        else
                        {
                            RadioButtonList1.Items[i].Selected = false;
                        }
                    }
                    string Communication_skill = gl.ds.Tables[0].Rows[0]["Communication_skill"].ToString();
                    for (int i = 0; i < RadioButtonList2.Items.Count; i++)
                    {
                        if (RadioButtonList2.Items[i].Text == Communication_skill)
                        {
                            RadioButtonList2.Items[i].Selected = true;

                        }
                        else
                        {
                            RadioButtonList2.Items[i].Selected = false;
                        }
                    }
                    string Personality = gl.ds.Tables[0].Rows[0]["Personality"].ToString();
                    for (int i = 0; i < RadioButtonList1.Items.Count; i++)
                    {
                        if (RadioButtonList3.Items[i].Text == Personality)
                        {
                            RadioButtonList3.Items[i].Selected = true;

                        }
                        else
                        {
                            RadioButtonList3.Items[i].Selected = false;
                        }
                    }
                    string Dependants = gl.ds.Tables[0].Rows[0]["Dependants"].ToString();
                    for (int i = 0; i < RadioButtonList4.Items.Count; i++)
                    {
                        if (RadioButtonList4.Items[i].Text == Dependants)
                        {
                            RadioButtonList4.Items[i].Selected = true;

                        }
                        else
                        {
                            RadioButtonList4.Items[i].Selected = false;
                        }
                    }
                    string Reffered_by_staff = gl.ds.Tables[0].Rows[0]["Reffered_by_staff"].ToString();
                    for (int i = 0; i < RadioButtonList5.Items.Count; i++)
                    {
                        if (RadioButtonList5.Items[i].Text == Reffered_by_staff)
                        {
                            RadioButtonList5.Items[i].Selected = true;

                        }
                        else
                        {
                            RadioButtonList5.Items[i].Selected = false;
                        }
                    }
                    TextBox1.Text = gl.ds.Tables[0].Rows[0]["Name_of_applicant"].ToString();
                    TextBox2.Text = gl.ds.Tables[0].Rows[0]["Position_applied_for"].ToString();
                    TextBox3.Text = gl.ds.Tables[0].Rows[0]["Center"].ToString();
                    TextBox4.Text = gl.ds.Tables[0].Rows[0]["Date_of_interview"].ToString();
                    TextBox5.Text = gl.ds.Tables[0].Rows[0]["Fathers_occupation"].ToString();
                    TextBox6.Text = gl.ds.Tables[0].Rows[0]["Mothers_occupation"].ToString();
                    TextBox7.Text = gl.ds.Tables[0].Rows[0]["Brother"].ToString();
                    TextBox8.Text = gl.ds.Tables[0].Rows[0]["Sister"].ToString();
                    TextBox9.Text = gl.ds.Tables[0].Rows[0]["Unit"].ToString();
                    TextBox10.Text = gl.ds.Tables[0].Rows[0]["Referee_center"].ToString();
                    string Salary_partclrs = gl.ds.Tables[0].Rows[0]["Salary_partclrs"].ToString();
                    TextBox11.Text = Convert.ToDecimal(Salary_partclrs).ToString("N");
                    string Salary_expctn = gl.ds.Tables[0].Rows[0]["Salary_expctn"].ToString();
                    TextBox12.Text = Convert.ToDecimal(Salary_expctn).ToString("N");
                    string Salary_offered = gl.ds.Tables[0].Rows[0]["Salary_offered"].ToString();
                    TextBox13.Text = Convert.ToDecimal(Salary_offered).ToString("N");
                    TextBox14.Text = gl.ds.Tables[0].Rows[0]["Date_of_joining"].ToString();
                    TextBox15.Text = gl.ds.Tables[0].Rows[0]["Comments"].ToString();
                    string mnth = gl.ds.Tables[0].Rows[0]["Month"].ToString();
                    string year = gl.ds.Tables[0].Rows[0]["Year"].ToString();
                    Button1.Text = "Update";
                }

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
            if (Button1.Text == "Update")
            {
                string idd = Request.QueryString["id"].ToString();
                DateTime crnttime = Convert.ToDateTime(TextBox4.Text);
                TimeZoneInfo tzn = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime IndianTme = TimeZoneInfo.ConvertTime(crnttime, tzn);
                string time = IndianTme.ToString("dd/MM/yyyy");
                string mnth = IndianTme.ToString("MM");
                string year = IndianTme.ToString("yyyy");

                con.Open();
                SqlCommand cmd = new SqlCommand("update Interview_sheet set Name_of_applicant=@Name_of_applicant,Position_applied_for=@Position_applied_for,Center=@Center,Date_of_interview=@Date_of_interview,Basic_qualification=@Basic_qualification,Professional_qualification=@Professional_qualification,Experience_details=@Experience_details,Communication_skill=@Communication_skill,Personality=@Personality,Fathers_occupation=@Fathers_occupation,Mothers_occupation=@Mothers_occupation,Brother=@Brother,Sister=@Sister,Dependants=@Dependants,Reffered_by_staff=@Reffered_by_staff,Unit=@Unit,Referee_center=@Referee_center,Salary_partclrs=@Salary_partclrs,Salary_expctn=@Salary_expctn,Salary_offered=@Salary_offered,Date_of_joining=@Date_of_joining,Comments=@Comments,Month=@Month,Year=@Year where interview_id=@interview_id", con);
                {
                    cmd.Parameters.AddWithValue("@interview_id", idd);
                    cmd.Parameters.AddWithValue("@Name_of_applicant", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Position_applied_for", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Center", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@Date_of_interview", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Basic_qualification", RadioButtonList6.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Professional_qualification", DropDownList1.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Experience_details", RadioButtonList1.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Communication_skill", RadioButtonList2.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Personality", RadioButtonList3.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Fathers_occupation", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@Mothers_occupation", TextBox6.Text);
                    cmd.Parameters.AddWithValue("@Brother", TextBox7.Text);
                    cmd.Parameters.AddWithValue("@Sister", TextBox8.Text);
                    cmd.Parameters.AddWithValue("@Dependants", RadioButtonList4.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Reffered_by_staff", RadioButtonList5.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Unit", TextBox9.Text);
                    cmd.Parameters.AddWithValue("@Referee_center", TextBox10.Text);
                    decimal Salary_partclrs = Convert.ToDecimal(TextBox11.Text);
                    cmd.Parameters.AddWithValue("@Salary_partclrs", TextBox11.Text);
                    decimal Salary_expctn = Convert.ToDecimal(TextBox12.Text);
                    cmd.Parameters.AddWithValue("@Salary_expctn", TextBox12.Text);
                    decimal Salary_offered = Convert.ToDecimal(TextBox13.Text);
                    cmd.Parameters.AddWithValue("@Salary_offered", TextBox13.Text);
                    cmd.Parameters.AddWithValue("@Date_of_joining", TextBox14.Text);
                    cmd.Parameters.AddWithValue("@Comments", TextBox15.Text);
                    cmd.Parameters.AddWithValue("@Month", mnth);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Label1.Text = "Updated Successfully";
                }
            }
            else
            {
                DateTime crnttime = Convert.ToDateTime(TextBox4.Text);
                TimeZoneInfo tzn = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime IndianTme = TimeZoneInfo.ConvertTime(crnttime, tzn);
                string time = IndianTme.ToString("dd/MM/yyyy");
                string mnth = IndianTme.ToString("MM");
                string year = IndianTme.ToString("yyyy");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Interview_sheet( Name_of_applicant, Position_applied_for, Center, Date_of_interview, Basic_qualification, Professional_qualification, Experience_details, Communication_skill,Personality, Fathers_occupation, Mothers_occupation, Brother, Sister, Dependants, Reffered_by_staff, Unit, Referee_center, Salary_partclrs, Salary_expctn, Salary_offered, Date_of_joining, Comments,Month,Year,Status_hr) values(@Name_of_applicant, @Position_applied_for, @Center, @Date_of_interview, @Basic_qualification, @Professional_qualification, @Experience_details, @Communication_skill,@Personality,@Fathers_occupation,@Mothers_occupation, @Brother, @Sister, @Dependants, @Reffered_by_staff, @Unit, @Referee_center, @Salary_partclrs, @Salary_expctn, @Salary_offered,@Date_of_joining, @Comments,@Month,@Year,@Status_hr)", con);
                {
                    cmd.Parameters.AddWithValue("@Name_of_applicant", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Position_applied_for", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Center", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@Date_of_interview", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Basic_qualification", RadioButtonList6.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Professional_qualification", DropDownList1.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Experience_details", RadioButtonList1.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Communication_skill", RadioButtonList2.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Personality", RadioButtonList3.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Fathers_occupation", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@Mothers_occupation", TextBox6.Text);
                    cmd.Parameters.AddWithValue("@Brother", TextBox7.Text);
                    cmd.Parameters.AddWithValue("@Sister", TextBox8.Text);
                    cmd.Parameters.AddWithValue("@Dependants", RadioButtonList4.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Reffered_by_staff", RadioButtonList5.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Unit", TextBox9.Text);
                    cmd.Parameters.AddWithValue("@Referee_center", TextBox10.Text);
                    decimal Salary_partclrs = Convert.ToDecimal(TextBox11.Text);
                    cmd.Parameters.AddWithValue("@Salary_partclrs", TextBox11.Text);
                    decimal Salary_expctn = Convert.ToDecimal(TextBox12.Text);
                    cmd.Parameters.AddWithValue("@Salary_expctn", TextBox12.Text);
                    decimal Salary_offered = Convert.ToDecimal(TextBox13.Text);
                    cmd.Parameters.AddWithValue("@Salary_offered", TextBox13.Text);
                    cmd.Parameters.AddWithValue("@Date_of_joining", TextBox14.Text);
                    cmd.Parameters.AddWithValue("@Comments", TextBox15.Text);
                    cmd.Parameters.AddWithValue("@Month", mnth);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Status_hr", 0);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Label1.Text = "Submitted Successfully";
                }
            }
        }
        catch
        {
        
        }
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Interview sheet.aspx");
    }
    protected void Button3_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Interviewdtl.aspx");
    }
}