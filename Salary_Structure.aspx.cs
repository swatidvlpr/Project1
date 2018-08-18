using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Currency;
public partial class AdminZone_Salary_Structure : System.Web.UI.Page
{
    Currencytowordconvert mycurrency = new Currencytowordconvert();
    Class1 sa = new Class1(); 
    public string i;
    public int j;
    string RCid;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Panel2.Visible = false; 
            Panel3.Visible = false; 
            Panel1.Visible = false;
            Panel5.Visible = false;
            sa.usepro("req_name", "");
            ddlemployee.DataSource = sa.ds;
            ddlemployee.DataTextField = "Name";
            ddlemployee.DataValueField = "EmployeeCode";
            ddlemployee.DataBind();


            sa.ds.Clear();

            sa.usepro("req_name", "");
            ddlemp.DataSource = sa.ds;
            ddlemp.DataTextField = "Name";
            ddlemp.DataValueField = "EmployeeCode";
            ddlemp.DataBind();

            //string[] ii = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            //foreach (string ss in ii)
            //{
            //    ddlmonth.Items.Add(ss.ToString());


            //}

            sa.ds.Clear();

            sa.usepro("req_name", "");
            DropDownList1.DataSource = sa.ds;
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "EmployeeCode";
            DropDownList1.DataBind();


            sa.ds.Clear();

            sa.usepro("req_name", "");
            DropDownList2.DataSource = sa.ds;
            DropDownList2.DataTextField = "Name";
            DropDownList2.DataValueField = "EmployeeCode";
            DropDownList2.DataBind();


            for (j = 1; j <= 12; j++)
            {
                ddlmonth.Items.Add(j.ToString());
            }

            for (j = 2010; j <= 2050; j++)
            {
                ddlyear.Items.Add(j.ToString());
            }
            //Set current Date, Month, Year
            //ddlmonth.Text = DateTime.Now.Month.ToString();
            //ddlyear.Text = DateTime.Now.Year.ToString();


            for (j = 1; j <= 12; j++)
            {
                ddlmonth0.Items.Add(j.ToString());
            }
            for (j = 2010; j <= 2050; j++)
            {
                ddlyear0.Items.Add(j.ToString());
            }
            //ddlmonth0.Text = DateTime.Now.Month.ToString();
            //ddlyear0.Text = DateTime.Now.Year.ToString();

        }
        Button1.Visible = false;
        Label6.Visible = false;
        Button4.Visible = false;

        Panel4.Visible = false;
        Panel1.Visible = false;
        //Panel2.Visible = false;
        //Panel3.Visible = false;

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            //Label6.Visible = true;
            ////Emp_id,                       Basic,               HRA,                    Travel_Allowance,  Other_Allowances,        Bonus,              Mobile_Reimbursement, Fixed_Allowances,    Total_Salarry,              cmonth,                             cyear,                                           date,                               name
           // sa.usepro("add_salary_structure", "'" + ddlemployee.SelectedValue + "','" + txtbasic.Text + "','" + txthra.Text + "','" + txtTA.Text + "','" + txtOA.Text + "','" + txtbonus.Text + "','" + txtMR.Text + "','" + txtFA.Text + "','" + txtF_Total.Text + "','" + ddlmonth0.SelectedItem.Text + "','" + ddlyear0.SelectedItem.Text + "','" + System.DateTime.Now.ToString("dd/MM/yyyy") + "','" + TextBox2.Text + "'");
                                                            //Emp_id,                           Basic,                 HRA,                 Medical_Allowance,      Conveyance_Allowance,           C_C_A_Allowance,        Washing_Allowance,    Arrear_Pay_Allowance, Misc_Earning_Narration_Amount,Leave_Encash,                               EPF,                FPF,             VPF,               ESI,              Medical_Advance,       Festival_Advance,      Personal_Advance,       Vehicle_Advance,  MISC_Narration_Advance, Total_Salarry,                                                                                   cmonth,                        cyear, previous_sal, date, name

            sa.usepro("bha_add_salary_structure", "'" + ddlemployee.SelectedValue + "','" + txtbasic.Text + "','" + txthra.Text + "','" + txtmedical.Text + "','" + txtConveyance.Text + "','" + txtC_C_Allowance.Text + "','" + txtWashing.Text + "','" + txtarrear_Pay_All.Text + "','" + txtmisc_earning_narration.Text + "','" + txtLeave_encash.Text + "','" + txtEPF.Text + "','" + txtFPF.Text + "','" + txtVPF.Text + "','" + txtESI.Text + "','" + txtMedical_Adv.Text + "','" + txtFestival.Text + "','" + txtPersonal.Text + "','" + txtVehicle.Text + "','" + txtMISC_Narration_Advance.Text + "','" + txtF_Total.Text + "','" + ddlmonth0.SelectedValue + "','" + ddlyear0.SelectedValue + "','','" + System.DateTime.Now.ToString("dd/MM/yyyy") + "','" + TextBox2.Text + "','" + txtgross_earning.Text + "','" + txtotaldeduction.Text + "','" + txtF_Total.Text+ "'");
           Label1.Text = "Submitted Successfully....";
             Panel1.Visible = true;
            txtbasic.Text = "00.00";
            txthra.Text = "00.00";
            txtmedical.Text = "00.00";
            txtConveyance.Text = "00.00";
            txtC_C_Allowance.Text = "00.00";
            txtWashing.Text = "00.00";
            txtarrear_Pay_All.Text = "00.00";
            txtmisc_earning_narration.Text = "00.00";
            txtLeave_encash.Text = "00.00";
            txtEPF.Text = "00.00";
            txtFPF.Text = "00.00";
            txtVPF.Text = "00.00";
            txtESI.Text = "00.00";
            txtMedical_Adv.Text = "00.00";
            txtFestival.Text = "00.00";
            txtPersonal.Text = "00.00";
            txtVehicle.Text = "00.00";
            txtMISC_Narration_Advance.Text = "00.00";
            txtF_Total.Text = "00.00";
            TextBox2.Text = "";
            txtgross_earning.Text = "";
            txtotaldeduction.Text = "00.00";
            //txtTA.Text = "00.00";
            //txtOA.Text = "00.00";
            //txtbonus.Text = "00.00";
            //txtMR.Text = "00.00";
            //txtFA.Text = "00.00";
            //txtF_Total.Text = "00.00";
            //TextBox6.Text = "00.00";
            //sa.ds.Clear();
        }
        catch
        { 
        
        }
    }
    
   

    protected void ddlemployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            sa.usepro("Bha_req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
            if (sa.ds.Tables[0].Rows.Count == 0)
            {
                sa.query("Select * from Employee_Reg where EmployeeCode='"+ddlemployee.SelectedValue.ToString()+"'");
                TextBox2.Text = sa.ds.Tables[0].Rows[0]["Name"].ToString();
                txtbasic.Text = "00.00";
                txthra.Text = "00.00";
                txtmedical.Text = "00.00";
                txtConveyance.Text = "00.00";
                txtC_C_Allowance.Text = "00.00";
                txtWashing.Text = "00.00";
                txtarrear_Pay_All.Text = "00.00";
                txtmisc_earning_narration.Text = "00.00";
                txtLeave_encash.Text = "00.00";
                txtEPF.Text = "00.00";
                txtFPF.Text = "00.00";
                txtVPF.Text = "00.00";
                txtESI.Text = "00.00";
                txtMedical_Adv.Text = "00.00";
                txtFestival.Text = "00.00";
                txtPersonal.Text = "00.00";
                txtVehicle.Text = "00.00";
                txtMISC_Narration_Advance.Text = "00.00";
                txtF_Total.Text = "00.00";
                TextBox6.Text = "00.00";
                btnsave.Visible = true;
                Button1.Visible = false;
                Panel1.Visible = true;
            }
            else
            {

                string basic = sa.ds.Tables[0].Rows[0]["Basic"].ToString();
                txtbasic.Text = Convert.ToDecimal(basic).ToString("N");
                string HRA1 = sa.ds.Tables[0].Rows[0]["HRA"].ToString();
                txthra.Text = Convert.ToDecimal(HRA1).ToString("N");

                string MA = sa.ds.Tables[0].Rows[0]["Medical_Allowance"].ToString();
                txtmedical.Text = Convert.ToDecimal(MA).ToString("N");
                string CA = sa.ds.Tables[0].Rows[0]["Conveyance_Allowance"].ToString();
                txtConveyance.Text = Convert.ToDecimal(CA).ToString("N");
                string C_C_A_Allowance = sa.ds.Tables[0].Rows[0]["C_C_A_Allowance"].ToString();
                txtC_C_Allowance.Text = Convert.ToDecimal(C_C_A_Allowance).ToString("N");
                string WA = sa.ds.Tables[0].Rows[0]["Washing_Allowance"].ToString();
                txtWashing.Text = Convert.ToDecimal(WA).ToString("N");
                string APA = sa.ds.Tables[0].Rows[0]["Arrear_Pay_Allowance"].ToString();
                txtarrear_Pay_All.Text = Convert.ToDecimal(APA).ToString("N");
                string MENA = sa.ds.Tables[0].Rows[0]["Misc_Earning_Narration_Amount"].ToString();
                txtmisc_earning_narration.Text = Convert.ToDecimal(MENA).ToString("N");
                string Leave_Encash = sa.ds.Tables[0].Rows[0]["Leave_Encash"].ToString();
                txtLeave_encash.Text = Convert.ToDecimal(Leave_Encash).ToString("N");
                string EPF = sa.ds.Tables[0].Rows[0]["EPF"].ToString();
                txtEPF.Text = Convert.ToDecimal(EPF).ToString("N");
                string FPF = sa.ds.Tables[0].Rows[0]["FPF"].ToString();
                txtFPF.Text = Convert.ToDecimal(FPF).ToString("N");
                string VPF = sa.ds.Tables[0].Rows[0]["VPF"].ToString();
                txtVPF.Text = Convert.ToDecimal(VPF).ToString("N");

                string ESI = sa.ds.Tables[0].Rows[0]["ESI"].ToString();
                txtESI.Text = Convert.ToDecimal(ESI).ToString("N");

                string Medical_Adv = sa.ds.Tables[0].Rows[0]["Medical_Advance"].ToString();
                txtMedical_Adv.Text = Convert.ToDecimal(Medical_Adv).ToString("N");

                string Festival_Adv = sa.ds.Tables[0].Rows[0]["Festival_Advance"].ToString();
                txtFestival.Text = Convert.ToDecimal(Festival_Adv).ToString("N");

                string Personal_Adv = sa.ds.Tables[0].Rows[0]["Personal_Advance"].ToString();
                txtPersonal.Text = Convert.ToDecimal(Personal_Adv).ToString("N");

                string Vehicle_Adv = sa.ds.Tables[0].Rows[0]["Vehicle_Advance"].ToString();
                txtVehicle.Text = Convert.ToDecimal(Vehicle_Adv).ToString("N");

                string MISC_Narration_Advance = sa.ds.Tables[0].Rows[0]["MISC_Narration_Advance"].ToString();
                txtMISC_Narration_Advance.Text = Convert.ToDecimal(MISC_Narration_Advance).ToString("N");

                string Total_Salarry = sa.ds.Tables[0].Rows[0]["Total_Salarry"].ToString();
                txtF_Total.Text = Convert.ToDecimal(Total_Salarry).ToString("N");
                string gross_earning = sa.ds.Tables[0].Rows[0]["GROSS_EARNING"].ToString();
                txtgross_earning.Text = Convert.ToDecimal(gross_earning).ToString("N");
                string total_deduction = sa.ds.Tables[0].Rows[0]["Total_Deduction"].ToString();
                txtotaldeduction.Text = Convert.ToDecimal(total_deduction).ToString("N");
                string g_total = sa.ds.Tables[0].Rows[0]["Grand_total"].ToString();
                txtF_Total.Text = Convert.ToDecimal(g_total).ToString("N");
                //txthra.Text = "00.00";               
                //txtF_Total.Text = "00.00";
                //Button1.Visible = true;
                //btnsave.Visible = false;
                btnsave.Visible = true;
                Button1.Visible = false;
                Panel1.Visible = true;
            }
            sa.ds.Clear();
            sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
            GridView1.DataSource = sa.ds;
            GridView1.DataBind();
            sa.ds.Clear();
            sa.query("SELECT Emp_Reg_ID, Emp_Name FROM  dbo.Employee_Registration where Emp_Reg_ID='" + ddlemployee.SelectedValue + "'");
            TextBox2.Text = sa.ds.Tables[0].Rows[0]["Emp_Name"].ToString();
        }
        catch
        { 
        
        
        }

    }
    protected void txtFA_TextChanged(object sender, EventArgs e)
    {
        try
        {
            sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
            if (sa.ds.Tables[0].Rows.Count == 0)
            {
                decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
                decimal hra = Convert.ToDecimal(txthra.Text.ToString());
               // decimal TA = Convert.ToDecimal(txtTA.Text.ToString());
                //decimal OA = Convert.ToDecimal(txtOA.Text.ToString());
                //decimal bonus = Convert.ToDecimal(txtbonus.Text.ToString());
                //decimal MR = Convert.ToDecimal(txtMR.Text.ToString());
                //decimal FA = Convert.ToDecimal(txtFA.Text.ToString());
                //decimal total = basic + hra + TA + OA + bonus + MR + FA;
                //txtF_Total.Text = Convert.ToDecimal(total).ToString("N");

                Button1.Visible = false;
                btnsave.Visible = true;
            }
            else
            {
                decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
                decimal hra = Convert.ToDecimal(txthra.Text.ToString());
                //decimal TA = Convert.ToDecimal(txtTA.Text.ToString());
                //decimal OA = Convert.ToDecimal(txtOA.Text.ToString());
                //decimal bonus = Convert.ToDecimal(txtbonus.Text.ToString());
                //decimal MR = Convert.ToDecimal(txtMR.Text.ToString());
                //decimal FA = Convert.ToDecimal(txtFA.Text.ToString());
                //decimal total = basic + hra + TA + OA + bonus + MR + FA;
                //txtF_Total.Text = Convert.ToDecimal(total).ToString("N");

                //Button1.Visible = true;
                //btnsave.Visible = false;

            }
            Panel1.Visible = true;
        }
        catch
        {
        
        }
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            //sa.display("Emp_Salary_Structure", GridView1);
            sa.ds.Clear();
            sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
            GridView1.DataSource = sa.ds;
            GridView1.DataBind();
            //Button1.Visible = false;
            //btnsave.Visible =true;
        }
        catch
        { 
        
        }
    }
    //protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    string id = GridView1.SelectedValue.ToString();
    //    sa.usepro("req_Sal_Structure", "'" +id+ "'");
    //    string basic = sa.ds.Tables[0].Rows[0]["Basic"].ToString();
    //    txtbasic.Text = Convert.ToDecimal(basic).ToString("N");
    //    string HRA1 = sa.ds.Tables[0].Rows[0]["HRA"].ToString();
    //    txthra.Text = Convert.ToDecimal(HRA1).ToString("N");
    //    string TA = sa.ds.Tables[0].Rows[0]["Travel_Allowance"].ToString();
    //    txtTA.Text = Convert.ToDecimal(TA).ToString("N");
    //    string OA = sa.ds.Tables[0].Rows[0]["Other_Allowances"].ToString();
    //    txtOA.Text = Convert.ToDecimal(OA).ToString("N");
    //    string Bonus1 = sa.ds.Tables[0].Rows[0]["Bonus"].ToString();
    //    txtbonus.Text = Convert.ToDecimal(Bonus1).ToString("N");
    //    string MR = sa.ds.Tables[0].Rows[0]["Mobile_Reimbursement"].ToString();
    //    txtMR.Text = Convert.ToDecimal(MR).ToString("N");

    //    string FA = sa.ds.Tables[0].Rows[0]["Fixed_Allowances"].ToString();
    //    txtFA.Text = Convert.ToDecimal(FA).ToString("N");

    //    string TS = sa.ds.Tables[0].Rows[0]["Total_Salarry"].ToString();
    //    txtF_Total.Text = Convert.ToDecimal(TS).ToString("N");

    //    Button1.Visible = true;
    //    btnsave.Visible = false;

    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            //string id = GridView1.SelectedValue.ToString();                                          @previous_sal money,@date varchar(300),@name varchar(250)
            //sa.usepro("sp_updt_Sal_Structure", "'" + ddlemployee.SelectedValue + "','" + Convert.ToDecimal(txtbasic.Text).ToString("N") + "','" + Convert.ToDecimal(txthra.Text).ToString("N") + "','" + Convert.ToDecimal(txtTA.Text).ToString("N") + "','" + Convert.ToDecimal(txtOA.Text).ToString("N") + "','" + Convert.ToDecimal(txtbonus.Text).ToString("N") + "','" + Convert.ToDecimal(txtMR.Text).ToString("N") + "','" + Convert.ToDecimal(txtFA.Text).ToString("N") + "','" + Convert.ToDecimal(txtF_Total.Text).ToString("N") + "','" + TextBox3.Text + "','" + System.DateTime.Now.ToString("dd/MM/yyyy") + "','" + TextBox2.Text + "'");

            //sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue + "'");
            //GridView1.DataSource = sa.ds;
            //GridView1.DataBind();
            //Button1.Visible = true;
        }
        catch
        { 
        
        
        }

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string idd = GridView1.DataKeys[e.RowIndex].Value.ToString();
        sa.delete("Emp_Salary_Structure", "Emp_id", "'"+idd+"'");
        sa.usepro("req_Sal_Structure", "'" + idd + "'");
        GridView1.DataSource = sa.ds;
        GridView1.DataBind();
        Button1.Visible = false;
    }
    protected void ddlemp_SelectedIndexChanged(object sender, EventArgs e)
    {
        //try
        //{
        //    sa.read("show_adv_salary", "'" + ddlemp.SelectedValue + "'");
        //    string sal = sa.ds.Tables[0].Rows[0]["Total_Salarry"].ToString();
        //    txtsalary.Text = Convert.ToDecimal(sal).ToString("N");
        //    string adv = sa.ds.Tables[0].Rows[0]["Advance"].ToString();
        //    TextBox6.Text = Convert.ToDecimal(adv).ToString("N");

        //    sa.ds.Clear();


        //    sa.query("select * from Payment_Salary where Emp_id='" + ddlemp.SelectedValue + "' order by date desc");
        //    string prious_due = sa.ds.Tables[0].Rows[0]["due_sal"].ToString();
        //    TextBox3.Text =Convert.ToDecimal(prious_due).ToString("N");
        //    Panel3.Visible = true;
        //    Panel2.Visible = true;
        //}
        //catch (Exception)
        //{
        //    //
        //}
        Panel3.Visible = true;
        Panel2.Visible = true;
        
    }
    protected void txtbleaves_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            int mnthk = Convert.ToInt32(ddlmonth.SelectedValue);
            int mnthk1 = mnthk - 1;
           // sa.auto2("sending_Transtions", "income_id", "OTHE");
            RCid = sa.cid;
            string sal_month = ddlmonth.SelectedValue + "-" + ddlyear.SelectedValue;
            // Emp_id,                     Salary,                 Salary_month,           total_working,               working_for,               total_leavs,            unpaid_leavs,           Adv,                    other, leavs_price, total_deduct_sal, Sub_total, Sub_total_words, month, year, income_id
            //Emp_id, Salary, Salary_month, total_working, working_for, total_leavs, unpaid_leavs, Adv, other, leavs_price, total_deduct_sal, Sub_total,Sub_total_words, month, year
            //@eid,                         @Salary,            @Salary_month,          @total_working              ,@working_for,                  @total_leavs,       @unpaid_leavs,              @Adv,                @other,                                @leavs_price,                                       @total_deduct_sal,                                      @Sub_total,                 @Sub_total_words,                   @month,                                                         @year
            sa.read("add_saldetails", "'" + ddlemp.SelectedValue + "','" + txtsalary.Text + "','" + sal_month + "','" + txttotalworking.Text + "','" + txtWorkedfor.Text + "','" + txtbleaves.Text + "','" + TextBox1.Text + "','" + txtAdv.Text + "','" + txtother.Text + "','" + Convert.ToDecimal(txtlvesprice.Text).ToString("N") + "','" + Convert.ToDecimal(HiddenField1.Value).ToString("N") + "','" + txt_total.Text + "','" + txt_sub_tot_word.Text + "','" + ddlmonth.SelectedValue + "','" + ddlyear.SelectedValue + "','" + TextBox3.Text + "','" + TextBox4.Text + "'");

            //sa.insert1("deductions_salary", "Emp_id,Salary,Salary_month,total_working,working_for,total_leavs,unpaid_leavs,Adv,other,leavs_price,total_deduct_sal,Sub_total,Sub_total_words,month, year,income_id", "'" + ddlemp.SelectedValue + "','" + txtsalary.Text + "','" + sal_month + "','" + txttotalworking.Text + "','" + txtWorkedfor.Text + "','" + txtbleaves.Text + "','" + TextBox1.Text + "','" + txtAdv.Text + "','" + txtother.Text + "','" + Convert.ToDecimal(txtlvesprice.Text).ToString("N") + "','" + Convert.ToDecimal(HiddenField1.Value).ToString("N") + "','" + txt_total.Text + "','" + txt_sub_tot_word.Text + "','" + System.DateTime.Now.ToString("MM") + "','" + System.DateTime.Now.ToString("yyyy") + "','" + RCid + "'");
            Label20.Text = "Submitted Successfully....";



            //cl.insert1("Income_Transtions", "type_trans,total,month, year, date,income_id", "'Otherincome','" + txt_total.Text + "','" + Convert.ToDateTime(System.DateTime.Now.ToString()).ToString("MM") + "','" + Convert.ToDateTime(System.DateTime.Now.ToString()).ToString("yyyy") + "','" + Convert.ToDateTime(System.DateTime.Now.ToString()).ToString("dd/MM/yyyy") + "','" + RCid + "'");
            sa.insert1("Advance", "Emp_id, advance, month, year, date, total_adv,status,grandtotal", "'" + ddlemp.SelectedValue + "','" + txtAdv.Text + "','" + mnthk1 + "','" + ddlyear.SelectedValue + "','" + System.DateTime.Now.ToString("dd/MM/yyyy") + "','" + TextBox6.Text + "','','" + HiddenField3.Value + "'");

            //sa.insert1("sending_Transtions", "type_trans,total,month, year, date,income_id,name", "'Salary','" + txt_total.Text + "','" + Convert.ToDateTime(System.DateTime.Now.ToString()).ToString("MM") + "','" + Convert.ToDateTime(System.DateTime.Now.ToString()).ToString("yyyy") + "','" + Convert.ToDateTime(System.DateTime.Now.ToString()).ToString("dd/MM/yyyy") + "','" + RCid + "','" + ddlemp.SelectedItem.Text+ "'");

            sa.usepro("sp_disp_deduction_gv", "'" + ddlemp.SelectedValue + "','" + sal_month + "'");
            GridView2.DataSource = sa.ds;
            GridView2.DataBind();
            Panel1.Visible = true;
            Panel1.Visible = false;
        }
        catch
        { 
        
        
        }


    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        try
        {
            //sa.display("deductions_salary", GridView2);
            sa.usepro("sp_disp_deduction_gv", "'" + ddlemp.SelectedValue + "'");
            GridView2.DataSource = sa.ds;
            GridView2.DataBind();
        }
        catch
        { 
        
        
        }
    }
    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string empid = GridView2.DataKeys[e.RowIndex].Value.ToString();
        sa.delete("deductions_salary", "Emp_id", "'"+empid+"'");
        //sa.display("deductions_salary", GridView2);
        sa.usepro("sp_disp_deduction_gv", "'" + ddlemp.SelectedValue + "'");
        GridView2.DataSource = sa.ds;
        GridView2.DataBind();
    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        //sa.display("deductions_salary", GridView2);
        sa.usepro("sp_disp_deduction_gv", "'" + ddlemp.SelectedValue + "'");
        GridView2.DataSource = sa.ds;
        GridView2.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        sa.display("Emp_Salary_Structure", GridView1);
        Button1.Visible = false;
    }
    //protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    string emp_id = GridView2.SelectedValue.ToString();
    //}

    protected void txthra_TextChanged(object sender, EventArgs e)
    {
        try
        {

            sa.usepro("Bha_req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
            if (sa.ds.Tables[0].Rows.Count == 0)
            {
                decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
                decimal hra = Convert.ToDecimal(txthra.Text.ToString());
                double basic1 = Convert.ToDouble(basic);
                double pf = basic1 * 12 / 100;
                txtEPF.Text = pf.ToString("N");
                double gross = basic1 + Convert.ToDouble(hra);
                txtgross_earning.Text = gross.ToString("N");
                double ESIC = gross - Convert.ToDouble(txtWashing.Text) * 1.75 / 100;
                txtESI.Text = ESIC.ToString("N");


               // decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
               // decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
               // decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
               // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
               //// decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
               // decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
               // decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
               // decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
               // decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
               // decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

               // decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
                
               
                //decimal total = basic + hra + TA + OA + bonus + MR + FA;
                //txtF_Total.Text = Convert.ToDecimal(total).ToString("N");

                Button1.Visible = false;
                btnsave.Visible = true;
            }
            else
            {
                //decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
                //decimal hra = Convert.ToDecimal(txthra.Text.ToString());
                //double basic1 = Convert.ToDouble(basic);
                //double pf = basic1 * 12 / 100;
                //txtEPF.Text = pf.ToString("N");
               // decimal TA = Convert.ToDecimal(txtTA.Text.ToString());
                //decimal OA = Convert.ToDecimal(txtOA.Text.ToString());
                //decimal bonus = Convert.ToDecimal(txtbonus.Text.ToString());
                //decimal MR = Convert.ToDecimal(txtMR.Text.ToString());
                //decimal FA = Convert.ToDecimal(txtFA.Text.ToString());
                //decimal total = basic + hra + TA + OA + bonus + MR + FA;
                //txtF_Total.Text = Convert.ToDecimal(total).ToString("N");

                //Button1.Visible = true;
                //btnsave.Visible = false;

            }

            Panel1.Visible = true;
        }
        catch
        { 
        
        
        
        }

    }
    //protected void txtTA_TextChanged(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
    //        if (sa.ds.Tables[0].Rows.Count == 0)
    //        {
    //            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
    //            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
    //            decimal TA = Convert.ToDecimal(txtTA.Text.ToString());
    //            //decimal OA = Convert.ToDecimal(txtOA.Text.ToString());
    //            //decimal bonus = Convert.ToDecimal(txtbonus.Text.ToString());
    //            //decimal MR = Convert.ToDecimal(txtMR.Text.ToString());
    //            //decimal FA = Convert.ToDecimal(txtFA.Text.ToString());
    //            //decimal total = basic + hra + TA + OA + bonus + MR + FA;
    //            //txtF_Total.Text = Convert.ToDecimal(total).ToString("N");

    //            Button1.Visible = false;
    //            btnsave.Visible = true;
    //        }
    //        else
    //        {
    //            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
    //            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
    //            decimal TA = Convert.ToDecimal(txtTA.Text.ToString());
    //            //decimal OA = Convert.ToDecimal(txtOA.Text.ToString());
    //            //decimal bonus = Convert.ToDecimal(txtbonus.Text.ToString());
    //            //decimal MR = Convert.ToDecimal(txtMR.Text.ToString());
    //            //decimal FA = Convert.ToDecimal(txtFA.Text.ToString());
    //            //decimal total = basic + hra + TA + OA + bonus + MR + FA;
    //            //txtF_Total.Text = Convert.ToDecimal(total).ToString("N");

    //            //Button1.Visible = true;
    //            //btnsave.Visible = false;

    //        }
    //        Panel1.Visible = true;

    //    }
    //    catch
    //    { 
        
    //    }


    //}
    protected void txtOA_TextChanged(object sender, EventArgs e)
    {
        try
        {
            sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
            if (sa.ds.Tables[0].Rows.Count == 0)
            {
                decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
                decimal hra = Convert.ToDecimal(txthra.Text.ToString());
               // decimal TA = Convert.ToDecimal(txtTA.Text.ToString());
                //decimal OA = Convert.ToDecimal(txtOA.Text.ToString());
                //decimal bonus = Convert.ToDecimal(txtbonus.Text.ToString());
                //decimal MR = Convert.ToDecimal(txtMR.Text.ToString());
                //decimal FA = Convert.ToDecimal(txtFA.Text.ToString());
                //decimal total = basic + hra + TA + OA + bonus + MR + FA;
                //txtF_Total.Text = Convert.ToDecimal(total).ToString("N");

                Button1.Visible = false;
                btnsave.Visible = true;
            }
            else
            {
                decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
                decimal hra = Convert.ToDecimal(txthra.Text.ToString());
               // decimal TA = Convert.ToDecimal(txtTA.Text.ToString());
                //decimal OA = Convert.ToDecimal(txtOA.Text.ToString());
                //decimal bonus = Convert.ToDecimal(txtbonus.Text.ToString());
                //decimal MR = Convert.ToDecimal(txtMR.Text.ToString());
                //decimal FA = Convert.ToDecimal(txtFA.Text.ToString());
                //decimal total = basic + hra + TA + OA + bonus + MR + FA;
                //txtF_Total.Text = Convert.ToDecimal(total).ToString("N");

                //Button1.Visible = true;
                //btnsave.Visible = false;

            }

            Panel1.Visible = true;
        }
        catch
        {
        
        }

        
    }
    protected void txtbonus_TextChanged(object sender, EventArgs e)
    {
        try
        {
            sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
            if (sa.ds.Tables[0].Rows.Count == 0)
            {
                decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
                decimal hra = Convert.ToDecimal(txthra.Text.ToString());
               // decimal TA = Convert.ToDecimal(txtTA.Text.ToString());
                //decimal OA = Convert.ToDecimal(txtOA.Text.ToString());
                //decimal bonus = Convert.ToDecimal(txtbonus.Text.ToString());
                //decimal MR = Convert.ToDecimal(txtMR.Text.ToString());
                //decimal FA = Convert.ToDecimal(txtFA.Text.ToString());
                //decimal total = basic + hra + TA + OA + bonus + MR + FA;
                //txtF_Total.Text = Convert.ToDecimal(total).ToString("N");

                Button1.Visible = false;
                btnsave.Visible = true;
            }
            else
            {
                decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
                decimal hra = Convert.ToDecimal(txthra.Text.ToString());
               // decimal TA = Convert.ToDecimal(txtTA.Text.ToString());
                //decimal OA = Convert.ToDecimal(txtOA.Text.ToString());
                //decimal bonus = Convert.ToDecimal(txtbonus.Text.ToString());
                //decimal MR = Convert.ToDecimal(txtMR.Text.ToString());
                //decimal FA = Convert.ToDecimal(txtFA.Text.ToString());
                //decimal total = basic + hra + TA + OA + bonus + MR + FA;
                //txtF_Total.Text = Convert.ToDecimal(total).ToString("N");

                //Button1.Visible = true;
                //btnsave.Visible = false;

            }
            Panel1.Visible = true;
        }
        catch
        { 
        
        
        }
    }
    protected void txtMR_TextChanged(object sender, EventArgs e)
    {
        try
        {
            sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
            if (sa.ds.Tables[0].Rows.Count == 0)
            {
                decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
                decimal hra = Convert.ToDecimal(txthra.Text.ToString());
                //decimal TA = Convert.ToDecimal(txtTA.Text.ToString());
                //decimal OA = Convert.ToDecimal(txtOA.Text.ToString());
                //decimal bonus = Convert.ToDecimal(txtbonus.Text.ToString());
                //decimal MR = Convert.ToDecimal(txtMR.Text.ToString());
                //decimal FA = Convert.ToDecimal(txtFA.Text.ToString());
                //decimal total = basic + hra + TA + OA + bonus + MR + FA;
                //txtF_Total.Text = Convert.ToDecimal(total).ToString("N");

                Button1.Visible = false;
                btnsave.Visible = true;
            }
            else
            {
                decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
                decimal hra = Convert.ToDecimal(txthra.Text.ToString());
               // decimal TA = Convert.ToDecimal(txtTA.Text.ToString());
                //decimal OA = Convert.ToDecimal(txtOA.Text.ToString());
                //decimal bonus = Convert.ToDecimal(txtbonus.Text.ToString());
                //decimal MR = Convert.ToDecimal(txtMR.Text.ToString());
                //decimal FA = Convert.ToDecimal(txtFA.Text.ToString());
                //decimal total = basic + hra + TA + OA + bonus + MR + FA;
                //txtF_Total.Text = Convert.ToDecimal(total).ToString("N");

                //Button1.Visible = true;
                //btnsave.Visible = false;

            }
            Panel1.Visible = true;
        }
        catch
        { 
        
        
        }
    }
    protected void txtbasic_TextChanged(object sender, EventArgs e)
    {
        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            double basic1 = Convert.ToDouble(basic);
            double pf = basic1 * 12 / 100;
            txtEPF.Text = pf.ToString("N");


           // decimal TA = Convert.ToDecimal(txtTA.Text.ToString());
            //decimal OA = Convert.ToDecimal(txtOA.Text.ToString());
            //decimal bonus = Convert.ToDecimal(txtbonus.Text.ToString());
            //decimal MR = Convert.ToDecimal(txtMR.Text.ToString());
            //decimal FA = Convert.ToDecimal(txtFA.Text.ToString());
            //decimal total = basic + hra + TA + OA + bonus + MR + FA;
            //txtF_Total.Text = Convert.ToDecimal(total).ToString("N");

            //Button1.Visible = false;
            //btnsave.Visible = true;
        }
        else
        {
            //decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            //decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            //double basic1 = Convert.ToDouble(basic);
            //double pf = basic1 * 12 / 100;
            //txtEPF.Text = pf.ToString("N");
            //decimal TA = Convert.ToDecimal(txtTA.Text.ToString());
            //decimal OA = Convert.ToDecimal(txtOA.Text.ToString());
            //decimal bonus = Convert.ToDecimal(txtbonus.Text.ToString());
            //decimal MR = Convert.ToDecimal(txtMR.Text.ToString());
            //decimal FA = Convert.ToDecimal(txtFA.Text.ToString());
            //decimal total = basic + hra + TA + OA + bonus + MR + FA;
            //txtF_Total.Text = Convert.ToDecimal(total).ToString("N");

            //Button1.Visible =true ;
            //btnsave.Visible = false;
        
        }
        Panel1.Visible = true;
        
    }
 
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        
        //int working_day = Convert.ToInt32(txttotalworking.Text) - Convert.ToInt32(txtbleaves.Text);
        //txtWorkedfor.Text = working_day.ToString();

        //decimal gdsal = Convert.ToDecimal(txtsalary.Text) / Convert.ToDecimal(txttotalworking.Text);

        //decimal leaves = Convert.ToDecimal(gdsal) * Convert.ToInt32(txtbleaves.Text);
        //HiddenField2.Value = leaves.ToString();

        ////decimal totalsal = Convert.ToDecimal(gdsal) * Convert.ToDecimal(txtWorkedfor.Text);

        ////HiddenField1.Value = totalsal.ToString();

        //decimal deduct_sal = Convert.ToDecimal(txtprofessionaltax.Text) + Convert.ToDecimal(txtTDS.Text) + Convert.ToDecimal(txtPF.Text) + Convert.ToDecimal(txtAdv.Text) + Convert.ToDecimal(txtother.Text) + Convert.ToDecimal(HiddenField2.Value);
        //HiddenField1.Value = deduct_sal.ToString();
        ////decimal sub_total = Convert.ToDecimal(HiddenField1.Value) - Convert.ToDecimal(deduct_sal);

        //decimal sub_total = Convert.ToDecimal(txtsalary.Text) - Convert.ToDecimal(deduct_sal);
        //txt_total.Text = Convert.ToDecimal(sub_total).ToString("N");

    }

    protected void txtsalary_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {
        try
        {
            Panel2.Visible = true;

            try
            {
                sa.read("show_adv_salary", "'" + ddlemp.SelectedValue + "'");
                string sal = sa.ds.Tables[0].Rows[0]["Salary"].ToString();
                txtsalary.Text = Convert.ToDecimal(sal).ToString("N");
                string adv = sa.ds.Tables[0].Rows[0]["Advance"].ToString();
                TextBox6.Text = Convert.ToDecimal(adv).ToString("N");
                Panel3.Visible = true;
                Panel2.Visible = true;
            }
            catch (Exception)
            {
                //
            }


            string sal_month = ddlmonth.SelectedValue + "-" + ddlyear.SelectedValue;
            sa.usepro("sp_disp_deduction", "'" + ddlemp.SelectedValue + "','" + sal_month + "'");
            if (sa.ds.Tables[0].Rows.Count == 0)
            {
                decimal leav = Convert.ToDecimal(txtbleaves.Text);
                decimal freeleve = Convert.ToDecimal(TextBox1.Text);
                decimal totalleve = leav - freeleve;
                txtbleaves.Text = totalleve.ToString();


                //decimal gdsal = Convert.ToDecimal(txtsalary.Text) / Convert.ToDecimal(txttotalworking.Text);
                double gdsal = Convert.ToDouble(txtsalary.Text) / Convert.ToDouble(TextBox4.Text);


                double leaves = Convert.ToDouble(gdsal) * Convert.ToDouble(txtbleaves.Text);
                //decimal leaves = Convert.ToDecimal(gdsal) * Convert.ToInt32();

                //decimal leaveprice=Convert.ToDecimal(gdsal) * Convert.ToInt32(
                txtlvesprice.Text = leaves.ToString("N");




                ///-------
                HiddenField2.Value = leaves.ToString("N");

                //decimal totalsal = Convert.ToDecimal(gdsal) * Convert.ToDecimal(txtWorkedfor.Text);

                //HiddenField1.Value = totalsal.ToString();

                decimal deduct_sal = Convert.ToDecimal(txtAdv.Text) + Convert.ToDecimal(txtother.Text) + Convert.ToDecimal(HiddenField2.Value);
                HiddenField1.Value = deduct_sal.ToString();
                //decimal sub_total = Convert.ToDecimal(HiddenField1.Value) - Convert.ToDecimal(deduct_sal);

                decimal sub_total = Convert.ToDecimal(txtsalary.Text) - Convert.ToDecimal(deduct_sal);

                //decimal previous_due = Convert.ToDecimal(TextBox3.Text);
                //decimal gtotal = sub_total + previous_due;
                txt_total.Text = Convert.ToDecimal(sub_total).ToString("N");
                HiddenField4.Value = Convert.ToDecimal(sub_total).ToString("N");
            }
            else
            {
                decimal leav = Convert.ToDecimal(txtbleaves.Text);
                decimal freeleve = Convert.ToDecimal(TextBox1.Text);
                decimal totalleve = leav - freeleve;
                txtbleaves.Text = totalleve.ToString();


                //decimal gdsal = Convert.ToDecimal(txtsalary.Text) / Convert.ToDecimal(txttotalworking.Text);

                decimal gdsal = Convert.ToDecimal(txtsalary.Text) / Convert.ToDecimal(TextBox4.Text);

                //decimal leaves = Convert.ToDecimal(gdsal) * Convert.ToInt32(txtbleaves.Text);

                double leaves = Convert.ToDouble(gdsal) * Convert.ToDouble(txtbleaves.Text);
                //decimal leaves = Convert.ToDecimal(gdsal) * Convert.ToInt32(txtbleaves.Text);
                //decimal leaveprice=Convert.ToDecimal(gdsal) * Convert.ToInt32(
                txtlvesprice.Text = leaves.ToString("N");
                Button4.Visible = true;



                ////------------------------

                HiddenField2.Value = leaves.ToString();

                //decimal totalsal = Convert.ToDecimal(gdsal) * Convert.ToDecimal(txtWorkedfor.Text);

                //HiddenField1.Value = totalsal.ToString();

                decimal deduct_sal = Convert.ToDecimal(txtAdv.Text) + Convert.ToDecimal(txtother.Text) + Convert.ToDecimal(HiddenField2.Value);
                HiddenField1.Value = deduct_sal.ToString();
                //decimal sub_total = Convert.ToDecimal(HiddenField1.Value) - Convert.ToDecimal(deduct_sal);

                decimal sub_total = Convert.ToDecimal(txtsalary.Text) - Convert.ToDecimal(deduct_sal);




                //decimal previous_due = Convert.ToDecimal(TextBox3.Text);
                //decimal gtotal = sub_total + previous_due;
                //txt_total.Text = Convert.ToDecimal(gtotal).ToString("N");
                //HiddenField4.Value = Convert.ToDecimal(gtotal).ToString("N");

                HiddenField4.Value = Convert.ToDecimal(sub_total).ToString("N");
                txt_total.Text = Convert.ToDecimal(sub_total).ToString("N");

                Panel3.Visible = true;
                Panel2.Visible = true;


            }




            //int working_day = Convert.ToInt32(txttotalworking.Text) - Convert.ToInt32(txtbleaves.Text);
            //txtWorkedfor.Text = working_day.ToString();

            //decimal gdsal = Convert.ToDecimal(txtsalary.Text) / Convert.ToDecimal(txttotalworking.Text);

            //decimal leaves = Convert.ToDecimal(gdsal) * Convert.ToInt32(txtbleaves.Text);


            Panel3.Visible = true;
            Panel2.Visible = true;

        }
        catch
        { }





    }
    protected void txtother_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        //    sa.read("show_adv_salary", "'" + ddlemp.SelectedValue + "'");
        //    string sal = sa.ds.Tables[0].Rows[0]["Salary"].ToString();
        //    txtsalary.Text = Convert.ToDecimal(sal).ToString("N");
        //    string adv = sa.ds.Tables[0].Rows[0]["Advance"].ToString();
        //    TextBox6.Text = Convert.ToDecimal(adv).ToString("N");
        //    Panel3.Visible = true;
        //    Panel2.Visible = true;
        //}
        //catch (Exception)
        //{
        //    //
        //}

        ////try
        ////{
        ////    sa.read("show_adv_salary", "'" + ddlemp.SelectedValue + "'");
        ////    string sal = sa.ds.Tables[0].Rows[0]["Salary"].ToString();
        ////    txtsalary.Text = Convert.ToDecimal(sal).ToString("N");
        ////    string adv = sa.ds.Tables[0].Rows[0]["Advance"].ToString();
        ////    TextBox6.Text = Convert.ToDecimal(adv).ToString("N");
        ////    Panel3.Visible = true;
        ////    Panel2.Visible = true;
        ////}
        ////catch (Exception)
        ////{
        ////    //
        ////}
        


        
        //  string sal_month=ddlmonth.SelectedValue+"-"+ddlyear.SelectedValue;
        //sa.usepro("sp_disp_deduction", "'"+ddlemp.SelectedValue+"','"+sal_month+"'");
        //if (sa.ds.Tables[0].Rows.Count == 0)
        //{
        //   // decimal deduct_sal = Convert.ToDecimal(txtprofessionaltax.Text) + Convert.ToDecimal(txtTDS.Text) + Convert.ToDecimal(txtPF.Text) + Convert.ToDecimal(txtAdv.Text) + Convert.ToDecimal(txtother.Text) + Convert.ToDecimal(txtlvesprice.Text);
        //   // HiddenField1.Value = deduct_sal.ToString();
        //   // decimal sub_total = Convert.ToDecimal(txtsalary.Text) - Convert.ToDecimal(deduct_sal);
        //    //txt_total.Text = sub_total.ToString("N");
        //    decimal rupee = Convert.ToDecimal(txt_total.Text);
        //    txt_sub_tot_word.Text = Convert.ToString(mycurrency.currencyToword(Convert.ToDouble((rupee))));
        //}
        //else
        //{
        //    //decimal deduct_sal = Convert.ToDecimal(txtprofessionaltax.Text) + Convert.ToDecimal(txtTDS.Text) + Convert.ToDecimal(txtPF.Text) + Convert.ToDecimal(txtAdv.Text) + Convert.ToDecimal(txtother.Text) + Convert.ToDecimal(txtlvesprice.Text);
        //  //  HiddenField1.Value = deduct_sal.ToString();
        //   // decimal sub_total = Convert.ToDecimal(txtsalary.Text) - Convert.ToDecimal(deduct_sal);
        //  //  txt_total.Text = sub_total.ToString("N");
        //    Button4.Visible = true;
        //    decimal rupee = Convert.ToDecimal(txt_total.Text);
        //    txt_sub_tot_word.Text = Convert.ToString(mycurrency.currencyToword(Convert.ToDouble((rupee))));
        
        
        
        //}

        try
        {
            decimal sall = Convert.ToDecimal(txtsalary.Text.ToString());
            decimal adeducttt = Convert.ToDecimal(txtAdv.Text.ToString());
            decimal levdayprice = Convert.ToDecimal(txtlvesprice.Text.ToString());
            decimal other = Convert.ToDecimal(txtother.Text.ToString());
            decimal deduct = adeducttt + levdayprice + other;
            decimal paid = sall - deduct;
            txtspaid.Text = Convert.ToDecimal(paid).ToString("N");


            decimal previous_due = Convert.ToDecimal(TextBox3.Text);
            decimal gtotal = paid + previous_due;
            txt_total.Text = Convert.ToDecimal(gtotal).ToString("N");
            HiddenField4.Value = Convert.ToDecimal(gtotal).ToString("N");
            //txt_total.Text = txtspaid.Text;

            txt_total.Text = txt_total.Text;
        }
        catch
        { 
        
        
        }




    }
    protected void txtlvesprice_TextChanged(object sender, EventArgs e)
    {
        try
        {
            string sal_month = ddlmonth.SelectedValue + "-" + ddlyear.SelectedValue;
            sa.usepro("sp_disp_deduction", "'" + ddlemp.SelectedValue + "','" + sal_month + "'");
            if (sa.ds.Tables[0].Rows.Count == 0)
            {
                //decimal deduct_sal = Convert.ToDecimal(txtprofessionaltax.Text) + Convert.ToDecimal(txtTDS.Text) + Convert.ToDecimal(txtPF.Text) + Convert.ToDecimal(txtAdv.Text) + Convert.ToDecimal(txtother.Text) + Convert.ToDecimal(txtlvesprice.Text);
                // HiddenField1.Value = deduct_sal.ToString();
                //decimal sub_total = Convert.ToDecimal(txtsalary.Text) - Convert.ToDecimal(deduct_sal);
                //txt_total.Text = sub_total.ToString("N");
                decimal rupee = Convert.ToDecimal(txt_total.Text);
                txt_sub_tot_word.Text = Convert.ToString(mycurrency.currencyToword(Convert.ToDouble((rupee))));
            }
            else
            {
                //decimal deduct_sal = Convert.ToDecimal(txtprofessionaltax.Text) + Convert.ToDecimal(txtTDS.Text) + Convert.ToDecimal(txtPF.Text) + Convert.ToDecimal(txtAdv.Text) + Convert.ToDecimal(txtother.Text) + Convert.ToDecimal(txtlvesprice.Text);
                //HiddenField1.Value = deduct_sal.ToString();
                //decimal sub_total = Convert.ToDecimal(txtsalary.Text) - Convert.ToDecimal(deduct_sal);
                //txt_total.Text = sub_total.ToString("N");
                Button4.Visible = true;
                //decimal rupee = Convert.ToDecimal(txt_total.Text);
                //txt_sub_tot_word.Text = Convert.ToString(mycurrency.currencyToword(Convert.ToDouble((rupee))));

            }

            try
            {
                sa.read("show_adv_salary", "'" + ddlemp.SelectedValue + "'");
                string sal = sa.ds.Tables[0].Rows[0]["Salary"].ToString();
                txtsalary.Text = Convert.ToDecimal(sal).ToString("N");
                string adv = sa.ds.Tables[0].Rows[0]["Advance"].ToString();
                TextBox6.Text = Convert.ToDecimal(adv).ToString("N");
                Panel3.Visible = true;
                Panel2.Visible = true;
            }
            catch (Exception)
            {
                //
            }

        }
        catch
        { 
        
        
        }


    }
    protected void txtAdv_TextChanged(object sender, EventArgs e)
    {
        //int mnth = Convert.ToInt32(ddlmonth.SelectedValue) - 1;
        // // string sal_month=ddlmonth.SelectedValue+"-"+ddlyear.SelectedValue;

        //string sal_month = mnth + "-" + ddlyear.SelectedValue;

        //sa.usepro("sp_disp_deduction", "'"+ddlemp.SelectedValue+"','"+sal_month+"'");
        //if (sa.ds.Tables[0].Rows.Count == 0)
        //{
        //    //decimal deduct_sal = Convert.ToDecimal(txtprofessionaltax.Text) + Convert.ToDecimal(txtTDS.Text) + Convert.ToDecimal(txtPF.Text) + Convert.ToDecimal(txtAdv.Text) + Convert.ToDecimal(txtother.Text) + Convert.ToDecimal(txtlvesprice.Text);
        //    //HiddenField1.Value = deduct_sal.ToString();
        //    //decimal sub_total = Convert.ToDecimal(txtsalary.Text) - Convert.ToDecimal(deduct_sal);
        //  //  txt_total.Text = sub_total.ToString("N");
        //    decimal adv = Convert.ToDecimal(txtAdv.Text);
        //    decimal ruppe = Convert.ToDecimal(txt_total.Text);

        //    decimal rupee =ruppe - adv;
        //    txt_total.Text=rupee.ToString("N");
        //    txt_sub_tot_word.Text = Convert.ToString(mycurrency.currencyToword(Convert.ToDouble((rupee))));

        //    double totalamt = Convert.ToDouble(TextBox6.Text);
        //    double totalamtadv = Convert.ToDouble(txtAdv.Text);
        //    double gtotal = totalamt - totalamtadv;
        //    HiddenField3.Value = gtotal.ToString();
            
        //}
        //else
        //{
        //   // decimal deduct_sal = Convert.ToDecimal(txtprofessionaltax.Text) + Convert.ToDecimal(txtTDS.Text) + Convert.ToDecimal(txtPF.Text) + Convert.ToDecimal(txtAdv.Text) + Convert.ToDecimal(txtother.Text) + Convert.ToDecimal(txtlvesprice.Text);
        //  //  HiddenField1.Value = deduct_sal.ToString();
        //    //decimal sub_total = Convert.ToDecimal(txtsalary.Text) - Convert.ToDecimal(deduct_sal);
        //   // txt_total.Text = sub_total.ToString("N");
        //    double totalamt = Convert.ToDouble(TextBox6.Text);
        //    double totalamtadv = Convert.ToDouble(txtAdv.Text);
        //    double gtotal = totalamt - totalamtadv;
        //    HiddenField3.Value = gtotal.ToString();


        //    Button4.Visible = true;
        //    decimal adv = Convert.ToDecimal(txtAdv.Text);
        //    decimal ruppe = Convert.ToDecimal(txt_total.Text);

        //    decimal rupee = ruppe - adv;
        //    txt_total.Text = rupee.ToString("N");
        //    //decimal rupee = Convert.ToDecimal(txt_total.Text);
        //    txt_sub_tot_word.Text = Convert.ToString(mycurrency.currencyToword(Convert.ToDouble((rupee))));
        
        //}


        try
        {
            decimal advtake = Convert.ToDecimal(TextBox6.Text.ToString());
            decimal adeductt = Convert.ToDecimal(txtAdv.Text.ToString());

            if (advtake < adeductt)
            {
                lblmsg.Text = "advance deduction not more than advance taken";
                txtAdv.Text = "";
                txtAdv.Focus();
            }
            else
            {
                decimal sall = Convert.ToDecimal(txtsalary.Text.ToString());
                decimal adeducttt = Convert.ToDecimal(txtAdv.Text.ToString());
                decimal levdayprice = Convert.ToDecimal(txtlvesprice.Text.ToString());
                decimal deduct = adeductt + levdayprice;
                decimal paid = sall - deduct;
                txtspaid.Text = Convert.ToDecimal(paid).ToString("N");

                //previous due
                decimal previous_due = Convert.ToDecimal(TextBox3.Text);
                decimal gtotal = paid + previous_due;
                txt_total.Text = Convert.ToDecimal(gtotal).ToString("N");
                HiddenField4.Value = Convert.ToDecimal(gtotal).ToString("N");



                ////txt_total.Text = Convert.ToDecimal(paid).ToString("N");
                ////HiddenField4.Value = Convert.ToDecimal(paid).ToString("N");


                // txt_total.Text = txtspaid.Text;




                //decimal totalsal = Convert.ToDecimal(paid)-Convert.ToDecimal(txtlvesprice.Text);

            }
            //decimal totalt = Convert.ToDecimal(HiddenField4.Value) - Convert.ToDecimal(txtAdv.Text);
            ////HiddenField4.Value = Convert.ToDecimal(sub_total).ToString("N");
            //txt_total.Text = Convert.ToDecimal(totalt).ToString("N");

        }
        catch
        { 

        }


        Panel2.Visible = true;
        Panel3.Visible = true;
    }
    protected void txtPF_TextChanged(object sender, EventArgs e)
    {
        string sal_month=ddlmonth.SelectedValue+"-"+ddlyear.SelectedValue;
        sa.usepro("sp_disp_deduction", "'"+ddlemp.SelectedValue+"','"+sal_month+"'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {

           // decimal deduct_sal = Convert.ToDecimal(txtprofessionaltax.Text) + Convert.ToDecimal(txtTDS.Text) + Convert.ToDecimal(txtPF.Text) + Convert.ToDecimal(txtAdv.Text) + Convert.ToDecimal(txtother.Text) + Convert.ToDecimal(txtlvesprice.Text);
            //HiddenField1.Value = deduct_sal.ToString();
            //decimal sub_total = Convert.ToDecimal(txtsalary.Text) - Convert.ToDecimal(deduct_sal);
           // txt_total.Text = sub_total.ToString("N");
            decimal rupee = Convert.ToDecimal(txt_total.Text);
            txt_sub_tot_word.Text = Convert.ToString(mycurrency.currencyToword(Convert.ToDouble((rupee))));
        }
        else
        {
           // decimal deduct_sal = Convert.ToDecimal(txtprofessionaltax.Text) + Convert.ToDecimal(txtTDS.Text) + Convert.ToDecimal(txtPF.Text) + Convert.ToDecimal(txtAdv.Text) + Convert.ToDecimal(txtother.Text) + Convert.ToDecimal(txtlvesprice.Text);
           // HiddenField1.Value = deduct_sal.ToString();
          //  decimal sub_total = Convert.ToDecimal(txtsalary.Text) - Convert.ToDecimal(deduct_sal);
           // txt_total.Text = sub_total.ToString("N");
            Button4.Visible = true;
            decimal rupee = Convert.ToDecimal(txt_total.Text);
            txt_sub_tot_word.Text = Convert.ToString(mycurrency.currencyToword(Convert.ToDouble((rupee))));
        
        }
    }
    protected void txtTDS_TextChanged(object sender, EventArgs e)
    {
        string sal_month=ddlmonth.SelectedValue+"-"+ddlyear.SelectedValue;
        sa.usepro("sp_disp_deduction", "'"+ddlemp.SelectedValue+"','"+sal_month+"'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
           // decimal deduct_sal = Convert.ToDecimal(txtprofessionaltax.Text) + Convert.ToDecimal(txtTDS.Text) + Convert.ToDecimal(txtPF.Text) + Convert.ToDecimal(txtAdv.Text) + Convert.ToDecimal(txtother.Text) + Convert.ToDecimal(txtlvesprice.Text);
            //HiddenField1.Value = deduct_sal.ToString();
           // decimal sub_total = Convert.ToDecimal(txtsalary.Text) - Convert.ToDecimal(deduct_sal);
           // txt_total.Text = sub_total.ToString("N");
            decimal rupee = Convert.ToDecimal(txt_total.Text);
            txt_sub_tot_word.Text = Convert.ToString(mycurrency.currencyToword(Convert.ToDouble((rupee))));
        }
        else
        {
           // decimal deduct_sal = Convert.ToDecimal(txtprofessionaltax.Text) + Convert.ToDecimal(txtTDS.Text) + Convert.ToDecimal(txtPF.Text) + Convert.ToDecimal(txtAdv.Text) + Convert.ToDecimal(txtother.Text) + Convert.ToDecimal(txtlvesprice.Text);
           // HiddenField1.Value = deduct_sal.ToString();
           // decimal sub_total = Convert.ToDecimal(txtsalary.Text) - Convert.ToDecimal(deduct_sal);
           // txt_total.Text = sub_total.ToString("N");
            Button4.Visible = true;
            decimal rupee = Convert.ToDecimal(txt_total.Text);
            txt_sub_tot_word.Text = Convert.ToString(mycurrency.currencyToword(Convert.ToDouble((rupee))));
        }
    }
    protected void txtprofessionaltax_TextChanged(object sender, EventArgs e)
    {
        string sal_month=ddlmonth.SelectedValue+"-"+ddlyear.SelectedValue;
        sa.usepro("sp_disp_deduction", "'"+ddlemp.SelectedValue+"','"+sal_month+"'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {

           // decimal deduct_sal = Convert.ToDecimal(txtprofessionaltax.Text) + Convert.ToDecimal(txtTDS.Text) + Convert.ToDecimal(txtPF.Text) + Convert.ToDecimal(txtAdv.Text) + Convert.ToDecimal(txtother.Text) + Convert.ToDecimal(txtlvesprice.Text);
            //HiddenField1.Value = deduct_sal.ToString();
            //decimal sub_total = Convert.ToDecimal(txtsalary.Text) - Convert.ToDecimal(deduct_sal);
            //txt_total.Text = sub_total.ToString("N");
            decimal rupee = Convert.ToDecimal(txt_total.Text);
            txt_sub_tot_word.Text = Convert.ToString(mycurrency.currencyToword(Convert.ToDouble((rupee))));
        }
        else
        {
          //  decimal deduct_sal = Convert.ToDecimal() + Convert.ToDecimal(txtTDS.Text) + Convert.ToDecimal(txtPF.Text) + Convert.ToDecimal(txtAdv.Text) + Convert.ToDecimal(txtother.Text) + Convert.ToDecimal(txtlvesprice.Text);
           // HiddenField1.Value = deduct_sal.ToString();
           // decimal sub_total = Convert.ToDecimal(txtsalary.Text) - Convert.ToDecimal(deduct_sal);
            //txt_total.Text = sub_total.ToString("N");
            Button4.Visible = true;
            decimal rupee = Convert.ToDecimal(txt_total.Text);
            txt_sub_tot_word.Text = Convert.ToString(mycurrency.currencyToword(Convert.ToDouble((rupee))));
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        try
        {
            string sal_month = ddlmonth.SelectedValue + "-" + ddlyear.SelectedValue;
            //sa.update("deductions_salary", "Salary='" + txtsalary.Text + "', Salary_month='" + sal_month + "', total_working='" + txttotalworking.Text + "', working_for='" + txtWorkedfor.Text + "', total_leavs='" + txtbleaves.Text + "', unpaid_leavs='" + TextBox1.Text + "', professional_tax='" + Convert.ToDecimal(txtprofessionaltax.Text).ToString("N") + "', TDS='" + Convert.ToDecimal(txtTDS.Text).ToString("N") + "', PF='" + Convert.ToDecimal(txtPF.Text).ToString("N") + "', Adv='" + Convert.ToDecimal(txtAdv.Text).ToString("N") + "', other='" + Convert.ToDecimal(txtother.Text).ToString("N") + "', leavs_price='" + Convert.ToDecimal(txtlvesprice.Text).ToString("N") + "',total_deduct_sal='" + Convert.ToDecimal(HiddenField1.Value).ToString("N") + "', Sub_total='" + Convert.ToDecimal(txt_total.Text).ToString("N") + "', Sub_total_words='" + txt_sub_tot_word.Text + "'", "Emp_id", "'" + ddlemp.SelectedValue + "'");
            sa.ds.Clear();
            sa.usepro("sp_disp_deduction_gv", "'" + ddlemp.SelectedValue + "'");
            GridView2.DataSource = sa.ds;
            GridView2.DataBind();
            Button4.Visible = true;
        }
        catch
        { 
        
        }
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedValue == "EARNINGS")
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
        }


        if (RadioButtonList1.SelectedValue == "DEDUCTIONS")
        {
            Panel2.Visible = true;
            Panel3.Visible = true;
            Panel1.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;


        }


        if (RadioButtonList1.SelectedValue == "ADVANCE")
        {
            //Panel2.Visible = true;
            //Panel3.Visible = true;
            //Panel1.Visible = false;
            Panel4.Visible = true;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel5.Visible = false;


        }

        if (RadioButtonList1.SelectedValue == "PAYMENT")
        {
            Panel5.Visible = true;
            Panel4.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
        }
        else
        { 
        
        
        
        }
    }
    protected void txttotalworking_TextChanged(object sender, EventArgs e)
    {
        try
        {
            decimal totalworkingday = Convert.ToDecimal(txttotalworking.Text);
            decimal workedfor = Convert.ToDecimal(txtWorkedfor.Text);
            decimal absent = totalworkingday - workedfor;
            txtbleaves.Text = absent.ToString();
            TextBox5.Text = absent.ToString();



            try
            {
                sa.read("show_adv_salary", "'" + ddlemp.SelectedValue + "'");
                string sal = sa.ds.Tables[0].Rows[0]["Salary"].ToString();
                txtsalary.Text = Convert.ToDecimal(sal).ToString("N");
                string adv = sa.ds.Tables[0].Rows[0]["Advance"].ToString();
                TextBox6.Text = Convert.ToDecimal(adv).ToString("N");
                Panel3.Visible = true;
                Panel2.Visible = true;
            }
            catch (Exception)
            {
                //
            }

        }
        catch
        { 
        }



    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtWorkedfor_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ddlyear0_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        try
        {

            sa.usepro("Bha_req_Sal_Structure_mnth", "'" + ddlemployee.SelectedValue.ToString() + "','" + ddlmonth0.SelectedValue + "','" + ddlyear0.SelectedValue + "'");
            if (sa.ds.Tables[0].Rows.Count == 0)
            {
                sa.query("Select * from Employee_Reg where EmployeeCode='" + ddlemployee.SelectedValue.ToString() + "'");
                TextBox2.Text = sa.ds.Tables[0].Rows[0]["Name"].ToString();

                txtbasic.Text = "00.00";
                txthra.Text = "00.00";
               // txtTA.Text = "00.00";
                //txtOA.Text = "00.00";
                //txtbonus.Text = "00.00";
                //txtMR.Text = "00.00";
                //txtFA.Text = "00.00";
                txtF_Total.Text = "00.00";
                btnsave.Visible = true;
                Button1.Visible = false;
            }
            else
            {
                string basic = sa.ds.Tables[0].Rows[0]["Basic"].ToString();
                txtbasic.Text = Convert.ToDecimal(basic).ToString("N");
                string HRA1 = sa.ds.Tables[0].Rows[0]["HRA"].ToString();
                txthra.Text = Convert.ToDecimal(HRA1).ToString("N");

                string MA = sa.ds.Tables[0].Rows[0]["Medical_Allowance"].ToString();
                txtmedical.Text = Convert.ToDecimal(MA).ToString("N");
                string CA = sa.ds.Tables[0].Rows[0]["Conveyance_Allowance"].ToString();
                txtConveyance.Text = Convert.ToDecimal(CA).ToString("N");
                string C_C_A_Allowance = sa.ds.Tables[0].Rows[0]["C_C_A_Allowance"].ToString();
                txtC_C_Allowance.Text = Convert.ToDecimal(C_C_A_Allowance).ToString("N");
                string WA = sa.ds.Tables[0].Rows[0]["Washing_Allowance"].ToString();
                txtWashing.Text = Convert.ToDecimal(WA).ToString("N");
                string APA = sa.ds.Tables[0].Rows[0]["Arrear_Pay_Allowance"].ToString();
                txtarrear_Pay_All.Text = Convert.ToDecimal(APA).ToString("N");
                string MENA = sa.ds.Tables[0].Rows[0]["Misc_Earning_Narration_Amount"].ToString();
                txtmisc_earning_narration.Text = Convert.ToDecimal(MENA).ToString("N");
                string Leave_Encash = sa.ds.Tables[0].Rows[0]["Leave_Encash"].ToString();
                txtLeave_encash.Text = Convert.ToDecimal(Leave_Encash).ToString("N");
                string EPF = sa.ds.Tables[0].Rows[0]["EPF"].ToString();
                txtEPF.Text = Convert.ToDecimal(EPF).ToString("N");
                string FPF = sa.ds.Tables[0].Rows[0]["FPF"].ToString();
                txtFPF.Text = Convert.ToDecimal(FPF).ToString("N");
                string VPF = sa.ds.Tables[0].Rows[0]["VPF"].ToString();
                txtVPF.Text = Convert.ToDecimal(VPF).ToString("N");

                string ESI = sa.ds.Tables[0].Rows[0]["ESI"].ToString();
                txtESI.Text = Convert.ToDecimal(ESI).ToString("N");

                string Medical_Adv = sa.ds.Tables[0].Rows[0]["Medical_Advance"].ToString();
                txtMedical_Adv.Text = Convert.ToDecimal(Medical_Adv).ToString("N");

                string Festival_Adv = sa.ds.Tables[0].Rows[0]["Festival_Advance"].ToString();
                txtFestival.Text = Convert.ToDecimal(Festival_Adv).ToString("N");

                string Personal_Adv = sa.ds.Tables[0].Rows[0]["Personal_Advance"].ToString();
                txtPersonal.Text = Convert.ToDecimal(Personal_Adv).ToString("N");

                string Vehicle_Adv = sa.ds.Tables[0].Rows[0]["Vehicle_Advance"].ToString();
                txtVehicle.Text = Convert.ToDecimal(Vehicle_Adv).ToString("N");

                string MISC_Narration_Advance = sa.ds.Tables[0].Rows[0]["MISC_Narration_Advance"].ToString();
                txtMISC_Narration_Advance.Text = Convert.ToDecimal(MISC_Narration_Advance).ToString("N");

                string Total_Salarry = sa.ds.Tables[0].Rows[0]["Total_Salarry"].ToString();
                txtF_Total.Text = Convert.ToDecimal(Total_Salarry).ToString("N");
                string gross_earning = sa.ds.Tables[0].Rows[0]["GROSS_EARNING"].ToString();
                txtgross_earning.Text = Convert.ToDecimal(gross_earning).ToString("N");
                string total_deduction = sa.ds.Tables[0].Rows[0]["Total_Deduction"].ToString();
                txtotaldeduction.Text = Convert.ToDecimal(total_deduction).ToString("N");

                string g_total = sa.ds.Tables[0].Rows[0]["Grand_total"].ToString();
                txtF_Total.Text = Convert.ToDecimal(g_total).ToString("N");


                //txthra.Text = "00.00";
                //txtF_Total.Text = "00.00";
                //Button1.Visible = true;
                //btnsave.Visible = false;
                btnsave.Visible = true;
                Button1.Visible = false;
                Panel1.Visible = true;
 

            }

           
        }
        catch
        {
        
        
        }



    }
    protected void ddlyear_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Panel2.Visible = true;
        try
        {
            sa.read("show_adv_salary", "'" + ddlemp.SelectedValue + "'");
            string sal = sa.ds.Tables[0].Rows[0]["Total_Salarry"].ToString();
            txtsalary.Text = Convert.ToDecimal(sal).ToString("N");
            string adv = sa.ds.Tables[0].Rows[0]["Advance"].ToString();
            TextBox6.Text = Convert.ToDecimal(adv).ToString("N");

            sa.ds.Clear();


            sa.query("select * from Payment_Salary where Emp_id='" + ddlemp.SelectedValue + "' order by date desc");
            string prious_due = sa.ds.Tables[0].Rows[0]["due_sal"].ToString();
            TextBox3.Text = Convert.ToDecimal(prious_due).ToString("N");
            Panel3.Visible = true;
            Panel2.Visible = true;
        }
        catch (Exception)
        {
            //
        }
        //DateTime d = DateTime.Now;
        //d = d.AddMonths(-1);
        //for (j = 1; j <= 12; j++)
        //{
        //    ddlmonth.Items.Add(j.ToString());
        //}
       

        int year1 = Convert.ToInt32(ddlyear.SelectedValue);

        int monthc = Convert.ToInt32(ddlmonth.SelectedValue);

       
        //int monthc1 = monthc - 1;


        string dyasInMonth = DateTime.DaysInMonth(year1, monthc).ToString();

        //Label1.Text = "Today " + DateTime.Now.ToLongDateString();
        //Label1.Text += "<br />Days In Month?: " + dyasInMonth;
        TextBox4.Text = dyasInMonth.ToString();



        //int year1 = DateTime.Now.Year;
        //int monthc = DateTime.Now.Month;



        //string sal_month = ddlmonth.SelectedValue + "-" + ddlyear.SelectedValue;
        // string mnth = sal_month - 1;
       
       int mnthk = Convert.ToInt32(ddlmonth.SelectedValue);


        

        //int mnthk1 = Convert.ToInt32(ddlmonth.SelectedValue);

       // string mnthk = Convert.ToString2(ddlmonth.SelectedValue);
        //string mnth = ddlmonth.SelectedValue.ToString();
                   //DateTime d = DateTime.Parse(mnthk.ToString());

                    //d = d.AddMonths(-1);
                    //string mnthk = d.ToString();
                    //int mnthk1 = mnthk - 1;

        sa.usepro("sp_disp_deduction", "'" + ddlemp.SelectedValue + "','" + mnthk + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            //int month1;
            int i = Convert.ToInt32(mnthk);
            int NumLen = i.ToString().Length;
            if (NumLen == 2)
            {
                string smnth = mnthk.ToString();


                sa.usepro("sp_sal_retrive", "'" + ddlemp.SelectedValue + "','" + mnthk + "','" + ddlyear.SelectedValue + "'");
                if (sa.ds.Tables[0].Rows.Count == 0)
                {
                    Response.Write("<script>al('Do not have attaince ?')</script>");
                }
                else
                {
                    string salary = sa.ds.Tables[0].Rows[0]["Total_Salarry"].ToString();
                    txtsalary.Text = Convert.ToDecimal(salary).ToString("N");



                    //string date1 = sa.ds.Tables[0].Rows[0]["Crt_date"].ToString();
                    ////string formatted = date1.ToString("dd-MM-yyyy");
                    //string[] split = date1.Split('/');
                    //string dd = split[0];
                    //string month = split[1];
                    //string year = split[2];


                    //for (int i = 01; i < 12; i++)
                    //{
                    //    int mnth = i;

                    //    int mnt = Convert.ToInt32(ddlmonth.Text) - 1;
                    //    if (mnth == mnt)
                    //    {
                    //        if (mnth == 01)
                    //        {
                    //            month1 = 31;

                    //            txttotalworking.Text = month1.ToString();

                    //        }
                    //        if (mnth == 02)
                    //        {
                    //            month1 = 28;
                    //            txttotalworking.Text = month1.ToString();


                    //        }

                    //        if (mnth == 03)
                    //        {
                    //            month1 = 31;
                    //            txttotalworking.Text = month1.ToString();


                    //        }

                    //        if (mnth == 04)
                    //        {
                    //            month1 = 30;
                    //            txttotalworking.Text = month1.ToString();


                    //        }

                    //        if (mnth == 05)
                    //        {
                    //            month1 = 31;
                    //            txttotalworking.Text = month1.ToString();


                    //        }
                    //        if (mnth == 06)
                    //        {
                    //            month1 = 30;

                    //            txttotalworking.Text = month1.ToString();

                    //        }
                    //        if (mnth == 07)
                    //        {
                    //            month1 = 31;
                    //            txttotalworking.Text = month1.ToString();


                    //        }
                    //        if (mnth == 08)
                    //        {
                    //            month1 = 31;
                    //            txttotalworking.Text = month1.ToString();


                    //        }

                    //        if (mnth == 09)
                    //        {
                    //            month1 = 30;

                    //            txttotalworking.Text = month1.ToString();

                    //        }
                    //        if (mnth == 10)
                    //        {
                    //            month1 = 31;
                    //            txttotalworking.Text = month1.ToString();


                    //        }
                    //        if (mnth == 11)
                    //        {
                    //            month1 = 30;

                    //            txttotalworking.Text = month1.ToString();

                    //        }

                    //        if (mnth == 12)
                    //        {
                    //            month1 = 31;
                    //            txttotalworking.Text = month1.ToString();


                    //        }


                    //    }

                    //}

                    sa.ds.Clear();

                    //int i = Convert.ToInt32(mnthk);
                    //int NumLen = i.ToString().Length;
                    //if (NumLen == 2)
                    //{
                    //    string smnth = mnthk.ToString();
                    //    sa.usepro("sp_workingday", "'" + ddlemp.SelectedValue + "','" + smnth + "'");
                    //    txtWorkedfor.Text = sa.ds.Tables[0].Rows[0]["Status1"].ToString();
                    //}
                    //else
                    //{
                    //    string smnth = mnthk.ToString();
                    //    sa.usepro("sp_workingday", "'" + ddlemp.SelectedValue + "','" + 0+smnth + "'");
                    //    txtWorkedfor.Text = sa.ds.Tables[0].Rows[0]["Status1"].ToString();
                    //}

                    //int mnth = mnthk.ToString().Length;

                    //mnthk.ToString().Length;

                    sa.usepro("sp_workingday", "'" + ddlemp.SelectedValue + "','" + mnthk + "'");
                    txtWorkedfor.Text = sa.ds.Tables[0].Rows[0]["Status1"].ToString();

                    //decimal totalworkingday = Convert.ToDecimal(txttotalworking.Text);
                    // decimal workedfor = Convert.ToDecimal(txtWorkedfor.Text);
                    // decimal absent = totalworkingday - workedfor;

                    //decimal absent=Convert.ToDecimal(txttotalworking.Text) - Convert.ToDecimal(txtWorkedfor.Text);
                    //txtbleaves.Text = absent.ToString();

                }




            }
            else
            {
                //string r;
                //r = "something" + 0;

                string mnthk2 = 0 + "" + mnthk + "";





                sa.usepro("sp_sal_retrive", "'" + ddlemp.SelectedValue + "','" + mnthk2 + "','" + ddlyear.SelectedValue + "'");
                if (sa.ds.Tables[0].Rows.Count == 0)
                {
                    Response.Write("<script>al('Do not have attaince ?')</script>");
                }
                else
                {
                    string salary = sa.ds.Tables[0].Rows[0]["Total_Salarry"].ToString();
                    txtsalary.Text = Convert.ToDecimal(salary).ToString("N");



                    //string date1 = sa.ds.Tables[0].Rows[0]["Crt_date"].ToString();
                    ////string formatted = date1.ToString("dd-MM-yyyy");
                    //string[] split = date1.Split('/');
                    //string dd = split[0];
                    //string month = split[1];
                    //string year = split[2];


                    //for (int i = 01; i < 12; i++)
                    //{
                    //    int mnth = i;

                    //    int mnt = Convert.ToInt32(ddlmonth.Text) - 1;
                    //    if (mnth == mnt)
                    //    {
                    //        if (mnth == 01)
                    //        {
                    //            month1 = 31;

                    //            txttotalworking.Text = month1.ToString();

                    //        }
                    //        if (mnth == 02)
                    //        {
                    //            month1 = 28;
                    //            txttotalworking.Text = month1.ToString();


                    //        }

                    //        if (mnth == 03)
                    //        {
                    //            month1 = 31;
                    //            txttotalworking.Text = month1.ToString();


                    //        }

                    //        if (mnth == 04)
                    //        {
                    //            month1 = 30;
                    //            txttotalworking.Text = month1.ToString();


                    //        }

                    //        if (mnth == 05)
                    //        {
                    //            month1 = 31;
                    //            txttotalworking.Text = month1.ToString();


                    //        }
                    //        if (mnth == 06)
                    //        {
                    //            month1 = 30;

                    //            txttotalworking.Text = month1.ToString();

                    //        }
                    //        if (mnth == 07)
                    //        {
                    //            month1 = 31;
                    //            txttotalworking.Text = month1.ToString();


                    //        }
                    //        if (mnth == 08)
                    //        {
                    //            month1 = 31;
                    //            txttotalworking.Text = month1.ToString();


                    //        }

                    //        if (mnth == 09)
                    //        {
                    //            month1 = 30;

                    //            txttotalworking.Text = month1.ToString();

                    //        }
                    //        if (mnth == 10)
                    //        {
                    //            month1 = 31;
                    //            txttotalworking.Text = month1.ToString();


                    //        }
                    //        if (mnth == 11)
                    //        {
                    //            month1 = 30;

                    //            txttotalworking.Text = month1.ToString();

                    //        }

                    //        if (mnth == 12)
                    //        {
                    //            month1 = 31;
                    //            txttotalworking.Text = month1.ToString();


                    //        }


                    //    }

                    //}

                    sa.ds.Clear();

                    //int i = Convert.ToInt32(mnthk);
                    //int NumLen = i.ToString().Length;
                    //if (NumLen == 2)
                    //{
                    //    string smnth = mnthk.ToString();
                    //    sa.usepro("sp_workingday", "'" + ddlemp.SelectedValue + "','" + smnth + "'");
                    //    txtWorkedfor.Text = sa.ds.Tables[0].Rows[0]["Status1"].ToString();
                    //}
                    //else
                    //{
                    //    string smnth = mnthk.ToString();
                    //    sa.usepro("sp_workingday", "'" + ddlemp.SelectedValue + "','" + 0+smnth + "'");
                    //    txtWorkedfor.Text = sa.ds.Tables[0].Rows[0]["Status1"].ToString();
                    //}

                    //int mnth = mnthk.ToString().Length;

                    //mnthk.ToString().Length;

                    sa.usepro("sp_workingday", "'" + ddlemp.SelectedValue + "','" + mnthk2 + "'");
                    txtWorkedfor.Text = sa.ds.Tables[0].Rows[0]["Status1"].ToString();

                    //decimal totalworkingday = Convert.ToDecimal(txttotalworking.Text);
                    // decimal workedfor = Convert.ToDecimal(txtWorkedfor.Text);
                    // decimal absent = totalworkingday - workedfor;

                    //decimal absent=Convert.ToDecimal(txttotalworking.Text) - Convert.ToDecimal(txtWorkedfor.Text);
                    //txtbleaves.Text = absent.ToString();

                }

                
            }


            //txtprofessionaltax.Text = "00.00";
            // txtTDS.Text = "00.00";
            //txtPF.Text = "00.00";
            txtAdv.Text = "00.00";
            txtother.Text = "00.00";
            txt_total.Text = "00.00";
            txt_sub_tot_word.Text = "";
            txtlvesprice.Text = "00.00";
            sa.ds.Clear();

             string sal_month = ddlmonth.SelectedValue + "-" + ddlyear.SelectedValue;
             sa.usepro("sp_deduct", "'" + ddlemp.SelectedItem.Text + "','" + sal_month + "'");
            GridView2.DataSource = sa.ds;
            GridView2.DataBind();
            Button3.Visible = true;

            //int mnthk1 = Convert.ToInt32(ddlmonth.SelectedValue);
            //int mnthk2 = mnthk1 - 1;
            //sa.query("select * from Advance where Emp_id='" + ddlemp.SelectedValue + "' and month='" + mnthk1 + "' and year='" + ddlyear.SelectedValue + "'");
            sa.query("select TOP 1 * from Advance where Emp_id='" + ddlemp.SelectedValue + "' ORDER BY date DESC");
            if (sa.ds.Tables[0].Rows.Count == 0)
            {

            }
            else
            {
                //if (HiddenField3.Value == "00.00")
                //{
                //    string adv = sa.ds.Tables[0].Rows[0]["advance"].ToString();
                //    //string gadv = sa.ds.Tables[0].Rows[0]["grandtotal"].ToString();

                //    TextBox6.Text = Convert.ToDecimal(adv).ToString("N");
                
                //}
                //else
                //{
                //    //string adv = sa.ds.Tables[0].Rows[0]["advance"].ToString();
                string gadv = sa.ds.Tables[0].Rows[0]["grandtotal"].ToString();

                TextBox6.Text = Convert.ToDecimal(gadv).ToString("N");
                
                //}
               

            }

        }


        else
        {

            string MONTH = sa.ds.Tables[0].Rows[0]["Salary_month"].ToString();
            //string formatted = date1.ToString("dd-MM-yyyy");
            string[] split = MONTH.Split('-');
            string month = split[0];
            string year = split[1];
            ddlmonth.SelectedItem.Text = month.ToString();
            ddlyear.SelectedItem.Text = year.ToString();

            string salary = sa.ds.Tables[0].Rows[0]["Salary"].ToString();
            txtsalary.Text = Convert.ToDecimal(salary).ToString("N");



            txttotalworking.Text = sa.ds.Tables[0].Rows[0]["total_working"].ToString();

            txtWorkedfor.Text = sa.ds.Tables[0].Rows[0]["working_for"].ToString();
            txtbleaves.Text = sa.ds.Tables[0].Rows[0]["total_leavs"].ToString();
            TextBox1.Text = sa.ds.Tables[0].Rows[0]["unpaid_leavs"].ToString();
            decimal professional_tax = Convert.ToDecimal(sa.ds.Tables[0].Rows[0]["professional_tax"].ToString());
            //txtprofessionaltax.Text = Convert.ToDecimal(professional_tax).ToString("N");
            decimal TDS = Convert.ToDecimal(sa.ds.Tables[0].Rows[0]["TDS"].ToString());
            //txtTDS.Text = Convert.ToDecimal(TDS).ToString("N");
            decimal PF = Convert.ToDecimal(sa.ds.Tables[0].Rows[0]["PF"].ToString());
            //txtPF.Text =Convert.ToDecimal(PF).ToString("N");
            decimal Adv = Convert.ToDecimal(sa.ds.Tables[0].Rows[0]["Adv"].ToString());
            txtAdv.Text = Convert.ToDecimal(Adv).ToString("N");
            decimal leavs_price = Convert.ToDecimal(sa.ds.Tables[0].Rows[0]["leavs_price"].ToString());
            txtlvesprice.Text = Convert.ToDecimal(leavs_price).ToString("N");
            decimal other = Convert.ToDecimal(sa.ds.Tables[0].Rows[0]["other"].ToString());
            txtother.Text = Convert.ToDecimal(other).ToString("N");
            decimal subtotal = Convert.ToDecimal(sa.ds.Tables[0].Rows[0]["Sub_total"].ToString());
            txt_total.Text = Convert.ToDecimal(subtotal).ToString("N");
            txt_sub_tot_word.Text = sa.ds.Tables[0].Rows[0]["Sub_total_words"].ToString();
            decimal total_deduct_sal = Convert.ToDecimal(sa.ds.Tables[0].Rows[0]["total_deduct_sal"].ToString());
            HiddenField1.Value = Convert.ToDecimal(total_deduct_sal).ToString("N");
            Button3.Visible = false;
            Button4.Visible = true;

            //sa.query("select TOP 1 * from Advance where Emp_id='" + ddlemp.SelectedValue + "' ORDER BY Emp_id DESC");
            sa.query("select TOP 1 * from Advance where Emp_id='" + ddlemp.SelectedValue + "' ORDER BY date DESC");
            if (sa.ds.Tables[0].Rows.Count == 0)
            {
            }
            else
            {
                if (sa.ds.Tables[0].Rows[0]["grandtotal"] == "00.00")
                {
                    string adv = sa.ds.Tables[0].Rows[0]["advance"].ToString();
                    //string gadv = sa.ds.Tables[0].Rows[0]["grandtotal"].ToString();

                    TextBox6.Text = Convert.ToDecimal(adv).ToString("N");

                }
                else
                {
                    //string adv = sa.ds.Tables[0].Rows[0]["advance"].ToString();
                    string gadv = sa.ds.Tables[0].Rows[0]["grandtotal"].ToString();

                    TextBox6.Text = Convert.ToDecimal(gadv).ToString("N");

                }


            }



        }



        try
        {
            sa.read("show_adv_salary", "'" + ddlemp.SelectedValue + "'");
            string sal = sa.ds.Tables[0].Rows[0]["Total_Salarry"].ToString();
            txtsalary.Text = Convert.ToDecimal(sal).ToString("N");
            string adv = sa.ds.Tables[0].Rows[0]["Advance"].ToString();
            TextBox6.Text = Convert.ToDecimal(adv).ToString("N");
            Panel3.Visible = true;
            Panel2.Visible = true;
        }
        catch (Exception)
        {
            //
        }
        





        Panel2.Visible = true;
        Panel3.Visible = true;



    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {
        try
        {
            sa.read("show_adv_salary", "'" + ddlemp.SelectedValue + "'");
            string sal = sa.ds.Tables[0].Rows[0]["Total_Salarry"].ToString();
            txtsalary.Text = Convert.ToDecimal(sal).ToString("N");
            string adv = sa.ds.Tables[0].Rows[0]["Advance"].ToString();
            TextBox6.Text = Convert.ToDecimal(adv).ToString("N");
            Panel3.Visible = true;
            Panel2.Visible = true;
        }
        catch (Exception)
        {
            //
        }
        

        //decimal adv = Convert.ToDecimal(TextBox6.Text);
        //decimal ruppe = Convert.ToDecimal(txt_total.Text);

        //decimal rupee = ruppe + adv;
        //txt_total.Text = rupee.ToString("N");
        //txt_sub_tot_word.Text = Convert.ToString(mycurrency.currencyToword(Convert.ToDouble((rupee))));
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        try
        {
            sa.read("add_adv", "'" + DropDownList1.SelectedValue + "','" + txtadv1.Text + "','" +txtcdt.Text+ "','" + txtremark1.Text + "'");
            show_record();
            GridView1.DataSource = sa.ds;
            GridView1.DataBind();
            msg.Text = "Submitted Successfully....";
            txtadv1.Text = "";
            txtremark1.Text = "";
            Panel4.Visible = true;

        }
        catch (Exception)
        {
            msg.Text = "Error occur try again...";

        }
    }


    public void show_record()
    {
        sa.read("req_adv", "'" +DropDownList1.SelectedValue + "'");
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            show_record();

            if (sa.ds.Tables[0].Rows.Count == 0)
            {
                msg.Text = "No Advance taken yet...";
                GridView3.Visible = false;
                Panel4.Visible = true;
            }
            else
            {
                GridView3.Visible = true;
                GridView3.DataSource = sa.ds;
                GridView3.DataBind();
                Panel4.Visible = true;
            }

        }
        catch
        { 
        
        
        }
    }
    protected void txtspaid_TextChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            //sa.query("select * from deductions_salary where Emp_id='"+DropDownList2.SelectedValue+"'");
            sa.query("select * from deductions_salary where Emp_id='" + DropDownList2.SelectedValue + "' ORDER BY month DESC, year DESC");

            if (sa.ds.Tables[0].Rows.Count == 0)
            {
                TextBox7.Text = "00.00";
            }
            else
            {
                string total_sal = sa.ds.Tables[0].Rows[0]["Sub_total"].ToString();
                TextBox7.Text = Convert.ToDecimal(total_sal).ToString("N");
            }
            //sa.ds.Clear();
            //sa.query("select * from Payment_Salary where Emp_id='" + DropDownList2.SelectedValue + "' ORDER BY payment_sal_id DESC,month DESC, year DESC");
            //string prev_due = sa.ds.Tables[0].Rows[0]["due_sal"].ToString();
            //TextBox11.Text = Convert.ToDecimal(prev_due).ToString("N");

            //double totalbalance = Convert.ToDouble(TextBox7.Text) + Convert.ToDouble(TextBox11.Text);
            //TextBox12.Text = totalbalance.ToString("N");
        }
        catch
        {
        
        
        }
    }
    protected void TextBox8_TextChanged(object sender, EventArgs e)
    {
        try
        {
            decimal sal = Convert.ToDecimal(TextBox7.Text);
            decimal payment = Convert.ToDecimal(TextBox8.Text);
            decimal duee = sal - payment;
            TextBox9.Text = duee.ToString("N");
        }
        catch
        { 
        
        }
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        try
        {
            sa.insert1("Payment_Salary", " Emp_id, salary, payment_sal, due_sal, date, month, year", "'" + DropDownList2.SelectedValue + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + Convert.ToDateTime(TextBox10.Text).ToString("MM") + "','" + Convert.ToDateTime(TextBox10.Text).ToString("yyyy") + "'");
            Label32.Text = "Submitted Successfully....";

            sa.insert1("sending_Transtions", "type_trans,total,month, year, date,income_id,name", "'Salary','" + TextBox8.Text + "','" + Convert.ToDateTime(TextBox10.Text).ToString("MM") + "','" + Convert.ToDateTime(TextBox10.Text).ToString("yyyy") + "','" + Convert.ToDateTime(TextBox10.Text).ToString("dd/MM/yyyy") + "','" + RCid + "','" + DropDownList2.SelectedItem.Text + "'");
        }
        catch
        {
        
        
        }
    }
    protected void TextBox9_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnrest_Click(object sender, EventArgs e)
    {
        CleartextBoxes(this);
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
    }

    public void CleartextBoxes(Control parent)
    {

        foreach (Control c in parent.Controls)
        {
            if ((c.GetType() == typeof(TextBox)))
            {

                ((TextBox)(c)).Text = "";
            }

            if ((c.GetType() == typeof(DropDownList)))
            {
                ((DropDownList)c).SelectedIndex = -1;
                //((DropDownList)c).Items.Clear();
            }

            if (c.HasControls())
            {
                CleartextBoxes(c);
            }
        }
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        CleartextBoxes(this);
        Panel2.Visible = true;
        Panel3.Visible = true;
        Panel1.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        TextBox3.Text = "00.00";
        TextBox6.Text = "00.00";
        txtspaid.Text = "00.00";
        txtother.Text = "00.00";
    }
    protected void btnrestt_Click(object sender, EventArgs e)
    {
        CleartextBoxes(this);

        Panel4.Visible = true;
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel5.Visible = false;

        txtadv1.Text = "00.00";

    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        CleartextBoxes(this);
        Panel5.Visible = true;
        Panel4.Visible = false;
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        TextBox7.Text = "00.00";
        TextBox8.Text = "00.00";
        TextBox9.Text = "00.00";
    }
    protected void txtmedical_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
            sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
            if (sa.ds.Tables[0].Rows.Count == 0)
            {
                decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
                decimal hra = Convert.ToDecimal(txthra.Text.ToString());
                double basic1 = Convert.ToDouble(basic);
                double pf = basic1 * 12 / 100;
                txtEPF.Text = pf.ToString("N");
                decimal medicalallanc = Convert.ToDecimal(txtmedical.Text.ToString());

                double gross = basic1 + Convert.ToDouble(hra) + Convert.ToDouble(medicalallanc);
                txtgross_earning.Text = gross.ToString("N");


                decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
                decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
                decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
                decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
                // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
                decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
                decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
                decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
                decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
                decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

                decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
                txtotaldeduction.Text = total.ToString("N");
                double grand_total = gross - Convert.ToDouble(total);
                txtF_Total.Text = grand_total.ToString("N");

                Button1.Visible = false;
                btnsave.Visible = true;
            }
            else
            {
             

                //Button1.Visible = true;
                //btnsave.Visible = false;

            }

            Panel1.Visible = true;
        //}
        //catch
        //{



        //}
    }
    protected void txtC_C_Allowance_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            double basic1 = Convert.ToDouble(basic);
            double pf = basic1 * 12 / 100;
            txtEPF.Text = pf.ToString("N");
            decimal medicalallanc = Convert.ToDecimal(txtmedical.Text.ToString());
            decimal Conveyance_All = Convert.ToDecimal(txtConveyance.Text.ToString());
            decimal C_C_Allowance = Convert.ToDecimal(txtC_C_Allowance.Text.ToString());



            double gross = basic1 + Convert.ToDouble(hra) + Convert.ToDouble(medicalallanc) + Convert.ToDouble(Conveyance_All) + Convert.ToDouble(C_C_Allowance);

            txtgross_earning.Text = gross.ToString("N");
            //double ESIC = gross - Convert.ToDouble(txtWashing.Text) * 1.75 / 100;
            //txtESI.Text = ESIC.ToString("N");

            decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
            decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
            decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
            decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
            decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
            decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
            decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
            decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

            decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
            txtotaldeduction.Text = total.ToString("N");
            double grand_total = gross - Convert.ToDouble(total);
            txtF_Total.Text = grand_total.ToString("N");


            Button1.Visible = false;
            btnsave.Visible = true;
        }
        else
        {


            //Button1.Visible = true;
            //btnsave.Visible = false;

        }

        Panel1.Visible = true;
        //}
        //catch
        //{



        //}
    }
    protected void txtConveyance_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            double basic1 = Convert.ToDouble(basic);
            double pf = basic1 * 12 / 100;
            txtEPF.Text = pf.ToString("N");
            decimal medicalallanc = Convert.ToDecimal(txtmedical.Text.ToString());
            decimal Conveyance_All = Convert.ToDecimal(txtConveyance.Text.ToString());

            double gross = basic1 + Convert.ToDouble(hra) + Convert.ToDouble(medicalallanc) + Convert.ToDouble(Conveyance_All);

            txtgross_earning.Text = gross.ToString("N");

            //double ESIC = gross - Convert.ToDouble(txtWashing.Text) * 1.75 / 100;
            //txtESI.Text = ESIC.ToString("N");


            decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
            decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
            decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
            decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
            decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
            decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
            decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
            decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

            decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
            txtotaldeduction.Text = total.ToString("N");
            double grand_total = gross - Convert.ToDouble(total);
            txtF_Total.Text = grand_total.ToString("N");


            Button1.Visible = false;
            btnsave.Visible = true;
        }
        else
        {


            //Button1.Visible = true;
            //btnsave.Visible = false;

        }

        Panel1.Visible = true;
        //}
        //catch
        //{



        //}
    }
    protected void txtWashing_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            double basic1 = Convert.ToDouble(basic);
            double pf = basic1 * 12 / 100;
            txtEPF.Text = pf.ToString("N");
            decimal medicalallanc = Convert.ToDecimal(txtmedical.Text.ToString());
            decimal Conveyance_All = Convert.ToDecimal(txtConveyance.Text.ToString());
            decimal C_C_Allowance = Convert.ToDecimal(txtC_C_Allowance.Text.ToString());
            decimal Washing = Convert.ToDecimal(txtWashing.Text.ToString());


            double gross = basic1 + Convert.ToDouble(hra) + Convert.ToDouble(medicalallanc) + Convert.ToDouble(Conveyance_All) + Convert.ToDouble(C_C_Allowance) + Convert.ToDouble(Washing);

            txtgross_earning.Text = gross.ToString("N");
            double ESIC1 = gross - Convert.ToDouble(txtWashing.Text);
            double ESIC = ESIC1 * 1.75 / 100;
            
            txtESI.Text = ESIC.ToString("N");

            decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
            decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
            decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
            decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
            decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
            decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
            decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
            decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

            decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
            txtotaldeduction.Text = total.ToString("N");
            double grand_total = gross - Convert.ToDouble(total);
            txtF_Total.Text = grand_total.ToString("N");



            Button1.Visible = false;
            btnsave.Visible = true;
        }
        else
        {


            //Button1.Visible = true;
            //btnsave.Visible = false;

        }

        Panel1.Visible = true;
        //}
        //catch
        //{



        //}
    }
    
   
    protected void txtEPF_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            double basic1 = Convert.ToDouble(basic);
            double pf = basic1 * 12 / 100;
            txtEPF.Text = pf.ToString("N");
            decimal medicalallanc = Convert.ToDecimal(txtmedical.Text.ToString());
            decimal Conveyance_All = Convert.ToDecimal(txtConveyance.Text.ToString());
            decimal C_C_Allowance = Convert.ToDecimal(txtC_C_Allowance.Text.ToString());
            decimal Washing = Convert.ToDecimal(txtWashing.Text.ToString());


            double gross = basic1 + Convert.ToDouble(hra) + Convert.ToDouble(medicalallanc) + Convert.ToDouble(Conveyance_All) + Convert.ToDouble(C_C_Allowance) + Convert.ToDouble(Washing);

            txtgross_earning.Text = gross.ToString("N");
            double ESIC1 = gross - Convert.ToDouble(txtWashing.Text);
            double ESIC = ESIC1 * 1.75 / 100;

            txtESI.Text = ESIC.ToString("N");

            decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
            decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
            decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
            decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
            decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
            decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
            decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
            decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

            decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
            txtotaldeduction.Text = total.ToString("N");
            double grand_total = gross - Convert.ToDouble(total);
            txtF_Total.Text = grand_total.ToString("N");



            Button1.Visible = false;
            btnsave.Visible = true;
        }
        else
        {


            //Button1.Visible = true;
            //btnsave.Visible = false;

        }

        Panel1.Visible = true;
        //}
        //catch
        //{



        //}

    }
    protected void txtFPF_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            double basic1 = Convert.ToDouble(basic);
            double pf = basic1 * 12 / 100;
            txtEPF.Text = pf.ToString("N");
            decimal medicalallanc = Convert.ToDecimal(txtmedical.Text.ToString());
            decimal Conveyance_All = Convert.ToDecimal(txtConveyance.Text.ToString());
            decimal C_C_Allowance = Convert.ToDecimal(txtC_C_Allowance.Text.ToString());
            decimal Washing = Convert.ToDecimal(txtWashing.Text.ToString());


            double gross = basic1 + Convert.ToDouble(hra) + Convert.ToDouble(medicalallanc) + Convert.ToDouble(Conveyance_All) + Convert.ToDouble(C_C_Allowance) + Convert.ToDouble(Washing);

            txtgross_earning.Text = gross.ToString("N");
            double ESIC1 = gross - Convert.ToDouble(txtWashing.Text);
            double ESIC = ESIC1 * 1.75 / 100;

            txtESI.Text = ESIC.ToString("N");

            decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
            decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
            decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
            decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
            decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
            decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
            decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
            decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

            decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
            txtotaldeduction.Text = total.ToString("N");
            double grand_total = gross - Convert.ToDouble(total);
            txtF_Total.Text = grand_total.ToString("N");



            Button1.Visible = false;
            btnsave.Visible = true;
        }
        else
        {


            //Button1.Visible = true;
            //btnsave.Visible = false;

        }

        Panel1.Visible = true;
        //}
        //catch
        //{



        //}
    }
    protected void txtVPF_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            double basic1 = Convert.ToDouble(basic);
            double pf = basic1 * 12 / 100;
            txtEPF.Text = pf.ToString("N");
            decimal medicalallanc = Convert.ToDecimal(txtmedical.Text.ToString());
            decimal Conveyance_All = Convert.ToDecimal(txtConveyance.Text.ToString());
            decimal C_C_Allowance = Convert.ToDecimal(txtC_C_Allowance.Text.ToString());
            decimal Washing = Convert.ToDecimal(txtWashing.Text.ToString());


            double gross = basic1 + Convert.ToDouble(hra) + Convert.ToDouble(medicalallanc) + Convert.ToDouble(Conveyance_All) + Convert.ToDouble(C_C_Allowance) + Convert.ToDouble(Washing);

            txtgross_earning.Text = gross.ToString("N");
            double ESIC1 = gross - Convert.ToDouble(txtWashing.Text);
            double ESIC = ESIC1 * 1.75 / 100;

            txtESI.Text = ESIC.ToString("N");

            decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
            decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
            decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
            decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
            decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
            decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
            decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
            decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

            decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
            txtotaldeduction.Text = total.ToString("N");
            double grand_total = gross - Convert.ToDouble(total);
            txtF_Total.Text = grand_total.ToString("N");



            Button1.Visible = false;
            btnsave.Visible = true;
        }
        else
        {


            //Button1.Visible = true;
            //btnsave.Visible = false;

        }

        Panel1.Visible = true;
        //}
        //catch
        //{



        //}
    }
    protected void txtESI_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            double basic1 = Convert.ToDouble(basic);
            double pf = basic1 * 12 / 100;
            txtEPF.Text = pf.ToString("N");
            decimal medicalallanc = Convert.ToDecimal(txtmedical.Text.ToString());
            decimal Conveyance_All = Convert.ToDecimal(txtConveyance.Text.ToString());
            decimal C_C_Allowance = Convert.ToDecimal(txtC_C_Allowance.Text.ToString());
            decimal Washing = Convert.ToDecimal(txtWashing.Text.ToString());


            double gross = basic1 + Convert.ToDouble(hra) + Convert.ToDouble(medicalallanc) + Convert.ToDouble(Conveyance_All) + Convert.ToDouble(C_C_Allowance) + Convert.ToDouble(Washing);

            txtgross_earning.Text = gross.ToString("N");
            double ESIC1 = gross - Convert.ToDouble(txtWashing.Text);
            double ESIC = ESIC1 * 1.75 / 100;

            txtESI.Text = ESIC.ToString("N");

            decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
            decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
            decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
            decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
            decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
            decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
            decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
            decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

            decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
            txtotaldeduction.Text = total.ToString("N");
            double grand_total = gross - Convert.ToDouble(total);
            txtF_Total.Text = grand_total.ToString("N");



            Button1.Visible = false;
            btnsave.Visible = true;
        }
        else
        {


            //Button1.Visible = true;
            //btnsave.Visible = false;

        }

        Panel1.Visible = true;
        //}
        //catch
        //{



        //}
    }
    protected void txtMedical_Adv_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            double basic1 = Convert.ToDouble(basic);
            double pf = basic1 * 12 / 100;
            txtEPF.Text = pf.ToString("N");
            decimal medicalallanc = Convert.ToDecimal(txtmedical.Text.ToString());
            decimal Conveyance_All = Convert.ToDecimal(txtConveyance.Text.ToString());
            decimal C_C_Allowance = Convert.ToDecimal(txtC_C_Allowance.Text.ToString());
            decimal Washing = Convert.ToDecimal(txtWashing.Text.ToString());


            double gross = basic1 + Convert.ToDouble(hra) + Convert.ToDouble(medicalallanc) + Convert.ToDouble(Conveyance_All) + Convert.ToDouble(C_C_Allowance) + Convert.ToDouble(Washing);

            txtgross_earning.Text = gross.ToString("N");
            double ESIC1 = gross - Convert.ToDouble(txtWashing.Text);
            double ESIC = ESIC1 * 1.75 / 100;

            txtESI.Text = ESIC.ToString("N");

            decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
            decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
            decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
            decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
            decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
            decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
            decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
            decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

            decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
            txtotaldeduction.Text = total.ToString("N");
            double grand_total = gross - Convert.ToDouble(total);
            txtF_Total.Text = grand_total.ToString("N");



            Button1.Visible = false;
            btnsave.Visible = true;
        }
        else
        {


            //Button1.Visible = true;
            //btnsave.Visible = false;

        }

        Panel1.Visible = true;
        //}
        //catch
        //{



        //}
    }
    protected void txtFestival_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            double basic1 = Convert.ToDouble(basic);
            double pf = basic1 * 12 / 100;
            txtEPF.Text = pf.ToString("N");
            decimal medicalallanc = Convert.ToDecimal(txtmedical.Text.ToString());
            decimal Conveyance_All = Convert.ToDecimal(txtConveyance.Text.ToString());
            decimal C_C_Allowance = Convert.ToDecimal(txtC_C_Allowance.Text.ToString());
            decimal Washing = Convert.ToDecimal(txtWashing.Text.ToString());


            double gross = basic1 + Convert.ToDouble(hra) + Convert.ToDouble(medicalallanc) + Convert.ToDouble(Conveyance_All) + Convert.ToDouble(C_C_Allowance) + Convert.ToDouble(Washing);

            txtgross_earning.Text = gross.ToString("N");
            double ESIC1 = gross - Convert.ToDouble(txtWashing.Text);
            double ESIC = ESIC1 * 1.75 / 100;

            txtESI.Text = ESIC.ToString("N");

            decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
            decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
            decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
            decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
            decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
            decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
            decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
            decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

            decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
            txtotaldeduction.Text = total.ToString("N");
            double grand_total = gross - Convert.ToDouble(total);
            txtF_Total.Text = grand_total.ToString("N");



            Button1.Visible = false;
            btnsave.Visible = true;
        }
        else
        {


            //Button1.Visible = true;
            //btnsave.Visible = false;

        }

        Panel1.Visible = true;
        //}
        //catch
        //{



        //}
    }
    protected void txtPersonal_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            double basic1 = Convert.ToDouble(basic);
            double pf = basic1 * 12 / 100;
            txtEPF.Text = pf.ToString("N");
            decimal medicalallanc = Convert.ToDecimal(txtmedical.Text.ToString());
            decimal Conveyance_All = Convert.ToDecimal(txtConveyance.Text.ToString());
            decimal C_C_Allowance = Convert.ToDecimal(txtC_C_Allowance.Text.ToString());
            decimal Washing = Convert.ToDecimal(txtWashing.Text.ToString());


            double gross = basic1 + Convert.ToDouble(hra) + Convert.ToDouble(medicalallanc) + Convert.ToDouble(Conveyance_All) + Convert.ToDouble(C_C_Allowance) + Convert.ToDouble(Washing);

            txtgross_earning.Text = gross.ToString("N");
            double ESIC1 = gross - Convert.ToDouble(txtWashing.Text);
            double ESIC = ESIC1 * 1.75 / 100;

            txtESI.Text = ESIC.ToString("N");

            decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
            decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
            decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
            decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
            decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
            decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
            decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
            decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

            decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
            txtotaldeduction.Text = total.ToString("N");
            double grand_total = gross - Convert.ToDouble(total);
            txtF_Total.Text = grand_total.ToString("N");



            Button1.Visible = false;
            btnsave.Visible = true;
        }
        else
        {


            //Button1.Visible = true;
            //btnsave.Visible = false;

        }

        Panel1.Visible = true;
        //}
        //catch
        //{



        //}
    }
    protected void txtVehicle_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            double basic1 = Convert.ToDouble(basic);
            double pf = basic1 * 12 / 100;
            txtEPF.Text = pf.ToString("N");
            decimal medicalallanc = Convert.ToDecimal(txtmedical.Text.ToString());
            decimal Conveyance_All = Convert.ToDecimal(txtConveyance.Text.ToString());
            decimal C_C_Allowance = Convert.ToDecimal(txtC_C_Allowance.Text.ToString());
            decimal Washing = Convert.ToDecimal(txtWashing.Text.ToString());


            double gross = basic1 + Convert.ToDouble(hra) + Convert.ToDouble(medicalallanc) + Convert.ToDouble(Conveyance_All) + Convert.ToDouble(C_C_Allowance) + Convert.ToDouble(Washing);

            txtgross_earning.Text = gross.ToString("N");
            double ESIC1 = gross - Convert.ToDouble(txtWashing.Text);
            double ESIC = ESIC1 * 1.75 / 100;

            txtESI.Text = ESIC.ToString("N");

            decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
            decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
            decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
            decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
            decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
            decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
            decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
            decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

            decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
            txtotaldeduction.Text = total.ToString("N");
            double grand_total = gross - Convert.ToDouble(total);
            txtF_Total.Text = grand_total.ToString("N");



            Button1.Visible = false;
            btnsave.Visible = true;
        }
        else
        {


            //Button1.Visible = true;
            //btnsave.Visible = false;

        }

        Panel1.Visible = true;
        //}
        //catch
        //{



        //}
    }
    protected void txtMISC_Narration_Advance_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            double basic1 = Convert.ToDouble(basic);
            double pf = basic1 * 12 / 100;
            txtEPF.Text = pf.ToString("N");
            decimal medicalallanc = Convert.ToDecimal(txtmedical.Text.ToString());
            decimal Conveyance_All = Convert.ToDecimal(txtConveyance.Text.ToString());
            decimal C_C_Allowance = Convert.ToDecimal(txtC_C_Allowance.Text.ToString());
            decimal Washing = Convert.ToDecimal(txtWashing.Text.ToString());


            double gross = basic1 + Convert.ToDouble(hra) + Convert.ToDouble(medicalallanc) + Convert.ToDouble(Conveyance_All) + Convert.ToDouble(C_C_Allowance) + Convert.ToDouble(Washing);

            txtgross_earning.Text = gross.ToString("N");
            double ESIC1 = gross - Convert.ToDouble(txtWashing.Text);
            double ESIC = ESIC1 * 1.75 / 100;

            txtESI.Text = ESIC.ToString("N");

            decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
            decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
            decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
            decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
            decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
            decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
            decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
            decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

            decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
            txtotaldeduction.Text = total.ToString("N");
            double grand_total = gross - Convert.ToDouble(total);
            txtF_Total.Text = grand_total.ToString("N");



            Button1.Visible = false;
            btnsave.Visible = true;
        }
        else
        {


            //Button1.Visible = true;
            //btnsave.Visible = false;

        }

        Panel1.Visible = true;
        //}
        //catch
        //{



        //}
    }
    protected void txtIncomeTax_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtarrear_pay_all_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            double basic1 = Convert.ToDouble(basic);
            double pf = basic1 * 12 / 100;
            txtEPF.Text = pf.ToString("N");
            decimal medicalallanc = Convert.ToDecimal(txtmedical.Text.ToString());
            decimal Conveyance_All = Convert.ToDecimal(txtConveyance.Text.ToString());
            decimal C_C_Allowance = Convert.ToDecimal(txtC_C_Allowance.Text.ToString());
            decimal Washing = Convert.ToDecimal(txtWashing.Text.ToString());
            decimal arrear_Pay_All = Convert.ToDecimal(txtarrear_Pay_All.Text.ToString());

            double gross = basic1 + Convert.ToDouble(hra) + Convert.ToDouble(medicalallanc) + Convert.ToDouble(Conveyance_All) + Convert.ToDouble(C_C_Allowance) + Convert.ToDouble(Washing) + Convert.ToDouble(arrear_Pay_All);

            txtgross_earning.Text = gross.ToString("N");


            decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
            decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
            decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
            decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
            decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
            decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
            decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
            decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

            decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
            txtotaldeduction.Text = total.ToString("N");
            double grand_total = gross - Convert.ToDouble(total);
            txtF_Total.Text = grand_total.ToString("N");

            //double ESIC = gross - Convert.ToDouble(txtWashing.Text) * 1.75 / 100;
            //txtESI.Text = ESIC.ToString("N");
            Button1.Visible = false;
            btnsave.Visible = true;
        }
        else
        {


            //Button1.Visible = true;
            //btnsave.Visible = false;

        }

        Panel1.Visible = true;
        //}
        //catch
        //{



        //}
    }
    protected void txtmisc_earning_narration_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            double basic1 = Convert.ToDouble(basic);
            double pf = basic1 * 12 / 100;
            txtEPF.Text = pf.ToString("N");
            decimal medicalallanc = Convert.ToDecimal(txtmedical.Text.ToString());
            decimal Conveyance_All = Convert.ToDecimal(txtConveyance.Text.ToString());
            decimal C_C_Allowance = Convert.ToDecimal(txtC_C_Allowance.Text.ToString());
            decimal Washing = Convert.ToDecimal(txtWashing.Text.ToString());
            decimal arrear_Pay_All = Convert.ToDecimal(txtarrear_Pay_All.Text.ToString());
            decimal misc_earning_narration = Convert.ToDecimal(txtmisc_earning_narration.ToString());


            double gross = basic1 + Convert.ToDouble(hra) + Convert.ToDouble(medicalallanc) + Convert.ToDouble(Conveyance_All) + Convert.ToDouble(C_C_Allowance) + Convert.ToDouble(Washing) + Convert.ToDouble(arrear_Pay_All) + Convert.ToDouble(misc_earning_narration);

            txtgross_earning.Text = gross.ToString("N");
            //double ESIC = gross - Convert.ToDouble(txtWashing.Text) * 1.75 / 100;
            //txtESI.Text = ESIC.ToString("N");

            decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
            decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
            decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
            decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
            decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
            decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
            decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
            decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

            decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
            txtotaldeduction.Text = total.ToString("N");
            double grand_total = gross - Convert.ToDouble(total);
            txtF_Total.Text = grand_total.ToString("N");
            Button1.Visible = false;
            btnsave.Visible = true;
        }
        else
        {


            //Button1.Visible = true;
            //btnsave.Visible = false;

        }

        Panel1.Visible = true;
        //}
        //catch
        //{



        //}
    }
    protected void txtLeave_encash_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        sa.usepro("req_Sal_Structure", "'" + ddlemployee.SelectedValue.ToString() + "'");
        if (sa.ds.Tables[0].Rows.Count == 0)
        {
            decimal basic = Convert.ToDecimal(txtbasic.Text.ToString());
            decimal hra = Convert.ToDecimal(txthra.Text.ToString());
            double basic1 = Convert.ToDouble(basic);
            double pf = basic1 * 12 / 100;
            txtEPF.Text = pf.ToString("N");
            decimal medicalallanc = Convert.ToDecimal(txtmedical.Text.ToString());
            decimal Conveyance_All = Convert.ToDecimal(txtConveyance.Text.ToString());
            decimal C_C_Allowance = Convert.ToDecimal(txtC_C_Allowance.Text.ToString());
            decimal Washing = Convert.ToDecimal(txtWashing.Text.ToString());
            decimal arrear_Pay_All = Convert.ToDecimal(txtarrear_Pay_All.Text.ToString());
            decimal misc_earning_narration = Convert.ToDecimal(txtmisc_earning_narration.ToString());
            decimal Leave_encash = Convert.ToDecimal(txtLeave_encash.ToString());

            double gross = basic1 + Convert.ToDouble(hra) + Convert.ToDouble(medicalallanc) + Convert.ToDouble(Conveyance_All) + Convert.ToDouble(C_C_Allowance) + Convert.ToDouble(Washing) + Convert.ToDouble(arrear_Pay_All) + Convert.ToDouble(misc_earning_narration) + Convert.ToDouble(Leave_encash);

            txtgross_earning.Text = gross.ToString("N");
            decimal Epf = Convert.ToDecimal(txtEPF.Text.ToString());
            decimal FPF = Convert.ToDecimal(txtFPF.Text.ToString());
            decimal VPF = Convert.ToDecimal(txtVPF.Text.ToString());
            decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            // decimal ESI = Convert.ToDecimal(txtESI.Text.ToString());
            decimal Medical_Adv = Convert.ToDecimal(txtMedical_Adv.Text.ToString());
            decimal Festival = Convert.ToDecimal(txtFestival.Text.ToString());
            decimal Personal = Convert.ToDecimal(txtPersonal.Text.ToString());
            decimal Vehicle = Convert.ToDecimal(txtVehicle.Text.ToString());
            decimal MISC_Narration_Advance = Convert.ToDecimal(txtMISC_Narration_Advance.Text.ToString());

            decimal total = Epf + FPF + VPF + ESI + Medical_Adv + Festival + Personal + Vehicle + MISC_Narration_Advance;
            txtotaldeduction.Text = total.ToString("N");
            double grand_total = gross - Convert.ToDouble(total);
            txtF_Total.Text = grand_total.ToString("N");

            //double ESIC = gross - Convert.ToDouble(txtWashing.Text) * 1.75 / 100;
            //txtESI.Text = ESIC.ToString("N");
            Button1.Visible = false;
            btnsave.Visible = true;
        }
        else
        {


            //Button1.Visible = true;
            //btnsave.Visible = false;

        }

        Panel1.Visible = true;
        //}
        //catch
        //{



        //}
    }
}
