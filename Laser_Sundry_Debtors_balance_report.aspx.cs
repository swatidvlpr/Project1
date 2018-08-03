﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Threading;
using System.Configuration;
using System.Text;
using System.Drawing;

using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

public partial class DSR_Laser_Sundry_Debtors_balance_report : System.Web.UI.Page
{    global gl = new global();
    public int total = 0;
    decimal totalPrice = 0M;
    decimal totalPrice1 = 0M;
    decimal totalPrice2 = 0M;
    decimal totalPrice3 = 0M;
    decimal totalPrice4 = 0M;
    decimal totalPrice5 = 0M;
    decimal totalPrice6 = 0M;
    decimal totalPrice7 = 0M;


    int totalItems = 0;
    int totalItems1 = 0;
    int totalItems2 = 0;
    int totalItems3 = 0;
    int totalItems4 = 0;
    int totalItems5 = 0;
    int totalItems6 = 0;
    int totalItems7 = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                gl.query("select * from  Laser_Sundry_DebtorsSpare_balance WHERE MONTH(Current_dt) = MONTH(dateadd(dd, -1, GetDate()))");
                GridView1.DataSource = gl.ds;
                GridView1.DataBind();

                for (int i = 2018; i <= 2045; i++)
                {
                    DropDownList2.Items.Add(i.ToString());
                }
                gl.ddl_select("Branchmaster", "Branchid,branchname", "branchname", "Branchid", "0", "'Select'", ddlbranch);

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
            if (DropDownList1.SelectedIndex == 0)
            {

                if (TextBox1.Text == "")
                {
                    if (DropDownList2.SelectedIndex == 0)
                    {
                        if (ddlbranch.SelectedIndex == 0)
                        {

                        }
                        else
                        {
                            gl.query("select * from Laser_Sundry_DebtorsSpare_balance WHERE Branchname ='" + ddlbranch.SelectedItem.Text + "'");
                            GridView1.DataSource = gl.ds;
                            GridView1.DataBind();
                        
                        }

                    }
                    else
                    {
                        gl.query("select * from Laser_Sundry_DebtorsSpare_balance WHERE YEAR(Current_dt) ='" + DropDownList2.SelectedValue + "'");
                        GridView1.DataSource = gl.ds;
                        GridView1.DataBind();
                    }
                }
                else
                {
                    gl.query("Select * from Laser_Sundry_DebtorsSpare_balance WHERE Current_dt ='" + TextBox1.Text + "'");
                    GridView1.DataSource = gl.ds;
                    GridView1.DataBind();
                }

            }
            else
            {
                if (DropDownList1.SelectedIndex == 0 && DropDownList2.SelectedIndex == 0)
                {

                }
                else
                {
                    gl.query("select * from Laser_Sundry_DebtorsSpare_balance WHERE MONTH(Current_dt)='" + DropDownList1.SelectedValue + "' and YEAR(Current_dt) ='" + DropDownList2.SelectedValue + "'");
                    GridView1.DataSource = gl.ds;
                    GridView1.DataBind();

                }

            }
        }
        catch
        {

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Laser_Sundry_Debtors_balance_report.aspx");
    }
    private void ExportGridToExcel()
    {
        try
        {
            // GridView1.Columns[0].Visible = false;
            Response.Clear();
            Response.Buffer = true;
            Response.ClearContent();
            Response.ClearHeaders();
            Response.Charset = "";
            string FileName = "Laser Sundry Debtors balance" + DateTime.Now + ".xls";
            StringWriter strwritter = new StringWriter();
            HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
            // GridView1.AllowPaging = false;
            // GridView1.Columns.RemoveAt(0);
            GridView1.GridLines = GridLines.Both;
            GridView1.HeaderStyle.Font.Bold = true;
            GridView1.RenderControl(htmltextwrtter);

            GridView1.DataBind();
            Response.Write(strwritter.ToString());
            Response.End();
        }
        catch { }
    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Verifies that the control is rendered */
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
      //  ExportGridToExcel();

        Response.Clear();
        Response.Buffer = true;
        string FileName = "Monthly Vehicle Search" + DateTime.Now + ".xls";
        Response.AddHeader("content-disposition", "attachment;filename=" + FileName);
        Response.Charset = "";
        Response.ContentType = "application/vnd.ms-excel";
        using (StringWriter sw = new StringWriter())
        {
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            Panel1.RenderControl(hw);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Label lblPrice = (Label)e.Row.FindControl("paidmoney");

                Label lblPrice = (Label)e.Row.FindControl("Label1");
                decimal price = Decimal.Parse(lblPrice.Text);
                totalPrice += price;
                totalItems += 1;

                Label lblPrice1 = (Label)e.Row.FindControl("Label2");
                decimal price1 = Decimal.Parse(lblPrice1.Text);
                totalPrice1 += price1;
                totalItems1 += 1;

                Label lblPrice2 = (Label)e.Row.FindControl("Label3");
                decimal price2 = Decimal.Parse(lblPrice2.Text);
                totalPrice2 += price2;
                totalItems2 += 1;

                Label lblPrice3 = (Label)e.Row.FindControl("Label4");
                decimal price3 = Decimal.Parse(lblPrice3.Text);
                totalPrice3 += price3;
                totalItems3 += 1;

                Label lblPrice4 = (Label)e.Row.FindControl("Label5");
                decimal price4 = Decimal.Parse(lblPrice4.Text);
                totalPrice4 += price4;
                totalItems4 += 1;

                Label lblPrice5 = (Label)e.Row.FindControl("Label6");
                decimal price5 = Decimal.Parse(lblPrice5.Text);
                totalPrice5 += price5;
                totalItems5 += 1;

                Label lblPrice6 = (Label)e.Row.FindControl("Label7");
                decimal price6 = Decimal.Parse(lblPrice6.Text);
                totalPrice6 += price6;
                totalItems6 += 1;

            }

            if (e.Row.RowType == DataControlRowType.Footer)
            {
                Label lblTotalPrice = (Label)e.Row.FindControl("lbltotal1");
                lblTotalPrice.Text = totalPrice.ToString();

                Label lblTotalPrice1 = (Label)e.Row.FindControl("lbltotal2");
                lblTotalPrice1.Text = totalPrice1.ToString();

                Label lblTotalPrice3 = (Label)e.Row.FindControl("lbltotal3");
                lblTotalPrice3.Text = totalPrice2.ToString();

                Label lblTotalPrice4 = (Label)e.Row.FindControl("lbltotal4");
                lblTotalPrice4.Text = totalPrice3.ToString();

                Label lblTotalPrice5 = (Label)e.Row.FindControl("lbltotal5");
                lblTotalPrice5.Text = totalPrice4.ToString();

                Label lblTotalPrice6 = (Label)e.Row.FindControl("lbltotal6");
                lblTotalPrice6.Text = totalPrice5.ToString();

                Label lblTotalPrice7 = (Label)e.Row.FindControl("lbltotal7");
                lblTotalPrice7.Text = totalPrice6.ToString();


            }
        }
        catch { }
    }
  
}