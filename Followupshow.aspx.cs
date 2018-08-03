using System;
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

public partial class DSR_Followupshow : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                //gl.query("select * from Nextmonthplanning WHERE MONTH(date) = MONTH(dateadd(dd, -1, GetDate()))");
                //gl.usepro("return_followupmaster", "'" + id1 + "'");
                gl.query("Select * from report_followup where MONTH(Date) = MONTH(dateadd(dd, -1, GetDate()))");

                GridView1.DataSource = gl.ds;
                GridView1.DataBind();

                for (int i = 2018; i <= 2045; i++)
                {
                    DropDownList2.Items.Add(i.ToString());
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
            if (DropDownList1.SelectedIndex == 0)
            {

                if (TextBox1.Text == "")
                {
                    if (DropDownList2.SelectedIndex == 0)
                    {

                    }
                    else
                    {
                        gl.query("select * from report_followup WHERE YEAR(Date) ='" + DropDownList2.SelectedValue + "'");
                        GridView1.DataSource = gl.ds;
                        GridView1.DataBind();
                    }
                }
                else
                {
                    gl.query("Select * from report_followup WHERE Date ='" + TextBox1.Text + "'");
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
                    gl.query("select * from report_followup WHERE MONTH(Date)='" + DropDownList1.SelectedValue + "' and YEAR(Date) ='" + DropDownList2.SelectedValue + "'");
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
        Response.Redirect("Followupshow.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Clear();
        Response.Buffer = true;
        string FileName = "Followup Show" + DateTime.Now + ".xls";
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
            string FileName = "Next Month Plane" + DateTime.Now + ".xls";
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
}