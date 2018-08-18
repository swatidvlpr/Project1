﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
public partial class Hod_Leave_approve : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {        
        if (!IsPostBack)
        {
          // gl.display("Leave_application", GridView1);
          gl.query("select * from Leave_application WHERE MONTH(From_date) = MONTH(dateadd(dd, -1, GetDate()))");
          GridView1.DataSource = gl.ds;
          GridView1.DataBind();
          for (int i = 2018; i <= 2045; i++)
          {
              DropDownList2.Items.Add(i.ToString());
          }
        
        }
        }
        catch
        { }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Button btn = (e.Row.FindControl("Button3") as Button);
                Button btn1 = (e.Row.FindControl("Button4") as Button);
                Button btn2 = (e.Row.FindControl("Button5") as Button);

                //e.Row.Cells[9].Text).ToString() =="0"
                HiddenField hd1 = (e.Row.FindControl("HiddenField1") as HiddenField);
                HiddenField hd2 = (e.Row.FindControl("HiddenField2") as HiddenField);
                if (hd1.Value == "0")
                {

                    btn.Text = "Pending";
                    btn.BackColor = Color.Red;
                    btn2.Text = "Approve";
                    btn2.BackColor = Color.Orange;
                }
                else
                {

                    //btn.Text = "Approve";
                    //btn.BackColor = Color.Gray;
                    btn.Visible = false;
                    btn2.Text = "Approved";
                    btn2.BackColor = Color.Green;
                }

                if (hd2.Value == "0")
                {

                    btn1.Text = "Pending";

                    btn1.BackColor = Color.Red;
                    btn1.Enabled = false;

                }
                else
                {

                    btn1.Text = "Approved";
                    btn1.BackColor = Color.Green;
                    btn1.Enabled = false;

                }
            }
        }
        catch
        { 
        
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        try
        {
            Button btn = sender as Button;
            GridViewRow row = btn.NamingContainer as GridViewRow;
            string pk = GridView1.DataKeys[row.RowIndex].Values[0].ToString();
            gl.update("Leave_application", "Status_hr=1", "leaveapplication_id", "'" + pk + "'");
            gl.query("select * from Leave_application WHERE MONTH(From_date) = MONTH(dateadd(dd, -1, GetDate()))");
            GridView1.DataSource = gl.ds;
            GridView1.DataBind();
        }
        catch
        { 
        
        }
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        try
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                if (DropDownList2.SelectedIndex == 0)
                {
                    if (TextBox1.Text == "")
                    {

                    }
                    else
                    {
                        gl.query("select * from Leave_application WHERE From_date ='" + TextBox1.Text + "'");
                        GridView1.DataSource = gl.ds;
                        GridView1.DataBind();

                    }
                }
                else
                {
                    gl.query("select * from Leave_application WHERE YEAR(From_date) ='" + DropDownList2.SelectedValue + "'");
                    GridView1.DataSource = gl.ds;
                    GridView1.DataBind();
                }
            }
            else
            {
                gl.query("select * from Leave_application WHERE MONTH(From_date) ='" + DropDownList1.SelectedValue + "' and YEAR(From_date) ='" + DropDownList2.SelectedValue + "'");
                GridView1.DataSource = gl.ds;
                GridView1.DataBind();

            }
        }
        catch
        { 
        
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Leave_approve.aspx");
    }
}