using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class DSR_Laser_Sundry_DebtorsSpare_balance : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {


                gl.ddl_select("Branchmaster", "Branchid,branchname", "branchname", "Branchid", "0", "'Select'", ddlbranch);
                display();

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

            if (Button1.Text == "update")
            {
                int idd = Convert.ToInt32(GridView1.SelectedValue);
                gl.update("Laser_Sundry_DebtorsSpare_balance", "Branchname='" + ddlbranch.SelectedItem.Text + "', Customername='" + txtcustomernm.Text + "', Balanceamt='" + txtbalanceamt.Text + "', Balancedate='" + txtbaldt.Text + "', Add_bill_during_amt='" + txtadd_bill_during_amt.Text + "', Add_bill__during_dt='" + txtadd_bill_during.Text + "', Less_payment_received='" + txtLess_payment_received.Text + "', Less_payment_receiveddt='" + txtLess_payment_receiveddt.Text + "',Balance1_amt='" + txtbalance1_amt.Text + "', Balance1date='" + txtbalance1_amtdt.Text + "', Less_payment_received1='" + txtLess_payment_received1.Text + "', Less_payment_receiveddt1='" + txtless_payment_receiveddt1.Text + "', Net_Balance='" + txtnet_balance.Text + "', Net_Balancedt='" + txtnet_balancedt.Text + "', Expected_date_of_Collection='" + txtexpected_date_of_Collection.Text + "', MR_No='" + txtMR_No.Text + "', Date='" + txtdate.Text + "',Mode_of_payment='" + DropDownList1.SelectedItem.Text + "', Remarks='" + txtremark.Text + "', Current_dt='" + System.DateTime.Now.ToString() + "'","Lasser_spare_id","'"+idd+"'");
            }
            else
            { 
                                                                                                                                                                                                                                                                                                                                                                                                                // Branchname,                       Customername,               Balanceamt,                  Balancedate,            Add_bill_during_amt,                  Add_bill__during_dt,              Less_payment_received,                     Less_payment_receiveddt,               Balance1_amt,               Balance1date,                Less_payment_received1,             Less_payment_receiveddt1,                Net_Balance,              Net_Balancedt,              Expected_date_of_Collection,               MR_No,              Date,            Mode_of_payment,                        Remarks               , Current_dt 
                gl.insert1("Laser_Sundry_DebtorsSpare_balance", "Branchname, Customername, Balanceamt, Balancedate, Add_bill_during_amt, Add_bill__during_dt, Less_payment_received, Less_payment_receiveddt,Balance1_amt, Balance1date, Less_payment_received1, Less_payment_receiveddt1, Net_Balance, Net_Balancedt, Expected_date_of_Collection, MR_No, Date,Mode_of_payment, Remarks, Current_dt", "'" + ddlbranch.SelectedItem.Text + "','" + txtcustomernm.Text + "','" + txtbalanceamt.Text + "','" + txtbaldt.Text + "','" + txtadd_bill_during_amt.Text + "','" + txtadd_bill_during.Text + "','" + txtLess_payment_received.Text + "','" + txtLess_payment_receiveddt.Text + "','" + txtbalance1_amt.Text+ "','"+txtbalance1_amtdt.Text+"','"+txtLess_payment_received1.Text+"','"+txtless_payment_receiveddt1.Text+"','"+txtnet_balance.Text+"','"+txtnet_balancedt.Text+"','"+txtexpected_date_of_Collection.Text+"','"+txtMR_No.Text+"','"+txtdate.Text+"','"+DropDownList1.SelectedItem.Text+"','"+txtremark.Text+"','"+System.DateTime.Now.ToString()+"'");

            }
            display();
            //ddlfinancier.SelectedIndex = 0;
            //ddlmodel.SelectedIndex = 0;
            //txtSaleQty.Text = "0";
            //txttotal.Text = "0";
            //txtT_S_In_Hand.Text = "0";
            //txtTotal_T_Sheet.Text = "0";
            //txtdate.Text = "";



        }
        catch
        {       
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Laser_Sundry_DebtorsSpare_balance.aspx");
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int idd = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            gl.delete("Laser_Sundry_DebtorsSpare_balance", "Lasser_spare_id", "'" + idd + "'");
            display();
        }
        catch { }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            int id = Convert.ToInt32(GridView1.SelectedValue);
            gl.read1("Laser_Sundry_DebtorsSpare_balance", "Lasser_spare_id", "'" + id + "'");

            string Branchname = gl.ds.Tables[0].Rows[0]["Branchname"].ToString();

            for (int i = 0; i < ddlbranch.Items.Count; i++)
            {
                if (ddlbranch.Items[i].Text == Branchname)
                {
                    ddlbranch.Items[i].Selected = true;
                }
                else
                {
                    ddlbranch.Items[i].Selected = false;
                }
            }

            txtcustomernm.Text = gl.ds.Tables[0].Rows[0]["Customername"].ToString();
            string Balanceamt = gl.ds.Tables[0].Rows[0]["Balanceamt"].ToString();
            txtbalanceamt.Text = Convert.ToDecimal(Balanceamt).ToString("N");
            txtbaldt.Text = gl.ds.Tables[0].Rows[0]["Balancedate"].ToString();
            string Add_bill_during_amt = gl.ds.Tables[0].Rows[0]["Add_bill_during_amt"].ToString();
            txtadd_bill_during_amt.Text = Convert.ToDecimal(Add_bill_during_amt).ToString("N"); 
            txtadd_bill_during.Text = gl.ds.Tables[0].Rows[0]["Add_bill__during_dt"].ToString();

            string Less_payment_received = gl.ds.Tables[0].Rows[0]["Less_payment_received"].ToString();
            txtLess_payment_received.Text = Convert.ToDecimal(Less_payment_received).ToString("N");
            txtLess_payment_receiveddt.Text = gl.ds.Tables[0].Rows[0]["Less_payment_receiveddt"].ToString();
            string Balance1_amt = gl.ds.Tables[0].Rows[0]["Balance1_amt"].ToString();
            txtbalance1_amt.Text = Convert.ToDecimal(Balance1_amt).ToString("N");
            txtbalance1_amtdt.Text = gl.ds.Tables[0].Rows[0]["Balance1date"].ToString();
            string Less_payment_received1 = gl.ds.Tables[0].Rows[0]["Less_payment_received1"].ToString();
            txtLess_payment_received1.Text = Convert.ToDecimal(Less_payment_received1).ToString("N");
            txtless_payment_receiveddt1.Text = gl.ds.Tables[0].Rows[0]["Less_payment_receiveddt1"].ToString();
            string Net_Balance = gl.ds.Tables[0].Rows[0]["Net_Balance"].ToString();
            txtnet_balance.Text = Convert.ToDecimal(Net_Balance).ToString("N");
            txtnet_balancedt.Text = gl.ds.Tables[0].Rows[0]["Net_Balancedt"].ToString();
            txtexpected_date_of_Collection.Text = gl.ds.Tables[0].Rows[0]["Expected_date_of_Collection"].ToString();
            txtMR_No.Text = gl.ds.Tables[0].Rows[0]["MR_No"].ToString();
            txtdate.Text = gl.ds.Tables[0].Rows[0]["Date"].ToString();

            string mode_of_payment = gl.ds.Tables[0].Rows[0]["Mode_of_payment"].ToString();
            for (int i = 0; i < DropDownList1.Items.Count; i++)
            {
                if (DropDownList1.Items[i].Text == mode_of_payment)
                {
                    DropDownList1.Items[i].Selected = true;
                }
                else
                {
                    DropDownList1.Items[i].Selected = false;
                }
            }
            txtremark.Text = gl.ds.Tables[0].Rows[0]["Remarks"].ToString();

            Button1.Text = "update";
        }
        catch { }
    }
    protected void txtadd_bill_during_amt_TextChanged(object sender, EventArgs e)
    {
        


    }
    protected void txtLess_payment_received_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double bal1 = Convert.ToDouble(txtbalanceamt.Text);
            double addbillduring = Convert.ToDouble(txtadd_bill_during_amt.Text);
            double totalbal1 = bal1 + addbillduring;
            double lesspayment_received = Convert.ToDouble(txtLess_payment_received.Text);
            double totalbalanceon = totalbal1 - lesspayment_received;
            txtbalance1_amt.Text = totalbalanceon.ToString("N");
        }
        catch { }
    }
    protected void txtnet_balance_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtLess_payment_receiveddt_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtbalance1_amt_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double balanceamt1 = Convert.ToDouble(txtbalance1_amt.Text);
            double Less_payment_received1 = Convert.ToDouble(txtLess_payment_received1.Text);
            double net_balanceamt1 = balanceamt1 - Less_payment_received1;
            txtnet_balance.Text = net_balanceamt1.ToString("N");
        }
        catch { }
    }
    protected void txtLess_payment_received1_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double balanceamt1 = Convert.ToDouble(txtbalance1_amt.Text);
            double Less_payment_received1 = Convert.ToDouble(txtLess_payment_received1.Text);
            double net_balanceamt1 = balanceamt1 - Less_payment_received1;
            txtnet_balance.Text = net_balanceamt1.ToString("N");
        }
        catch { }
    }

    public void display()
    {
        try
        {
            gl.query("Select * from Laser_Sundry_DebtorsSpare_balance");
            GridView1.DataSource = gl.ds;
            GridView1.DataBind();
        }
        catch { }
    }
}