using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Web.UI;


public class global
{
    public SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Conn"].ToString());
    public SqlDataAdapter da = new SqlDataAdapter();
    public DataSet ds = new DataSet();
    public string cid;
    public SqlCommand cmd = new SqlCommand();
    public void insert(string tbnm, string val)
    {
        da = new SqlDataAdapter("insert into " + tbnm + " values(" + val + ")", con);
        da.Fill(ds);
    }
    public void insert1(string tbnm, string col, string val)
    {
        da = new SqlDataAdapter("insert into " + tbnm + "(" + col + ") values(" + val + ")", con);
        da.Fill(ds);
    }

    public void display(string tbnm, GridView gv)
    {
        ds.Reset();
        da = new SqlDataAdapter("select * from " + tbnm + "", con);
        da.Fill(ds);
        gv.DataSource = ds;
        gv.DataBind();
    }

    public void displaycond(string tbnm, string cond, string condval, GridView gv)
    {
        ds.Clear();
        da = new SqlDataAdapter("select * from " + tbnm + " where " + cond + "=" + condval + "", con);
        da.Fill(ds);
        gv.DataSource = ds;
        gv.DataBind();
    }
    public void displaycond2(string tbnm, string cond, string condval, string cond1, string condval1, GridView gv)
    {
        ds.Clear();
        da = new SqlDataAdapter("select * from " + tbnm + " where " + cond + "=" + condval + " and " + cond1 + "=" + condval1 + "", con);
        da.Fill(ds);
        gv.DataSource = ds;
        gv.DataBind();
    }
    public void displaycond3(string tbnm, string cond, string condval, string cond1, string condval1,string cond2, string condval2, GridView gv)
    {


        da = new SqlDataAdapter("select * from " + tbnm + " where " + cond + "=" + condval + " and " + cond1 + "=" + condval1 + " and " + cond2 + " = " + condval2 + " ", con);
        da.Fill(ds);
        gv.DataSource = ds;
        gv.DataBind();
    }
    public void returncol(string tbnm, string cond, string condval)
    {
        da = new SqlDataAdapter("select * from " + tbnm + " where " + cond + "=" + condval + "", con);
        da.Fill(ds);
    }

    public void returncol2(string tbnm, string cond, string condval, string cond1, string condval1)
    {
        da = new SqlDataAdapter("select * from " + tbnm + " where " + cond + "=" + condval + "and "+cond1+"="+condval1+"", con);
        da.Fill(ds);
    }


    public void usepro(string pronm, string val)
    {

        ds.Reset();
        con.Open();
        da = new SqlDataAdapter(pronm + val, con);
        da.Fill(ds);
        con.Close();

    }
    public void update(string tbnm, string colnm, string cond, string condval)
    {
        ds.Clear();
        da = new SqlDataAdapter("update " + tbnm + " set " + colnm + " where " + cond + " = " + condval + "", con);
        da.Fill(ds);
    }
    public void ddl(string tbnm, string txtfld, string valfld, DropDownList ddl)
    {
        ds.Clear();
        da = new SqlDataAdapter("select * from " + tbnm + "", con);
        da.Fill(ds);
        ddl.DataSource = ds;
        ddl.DataTextField = txtfld;
        ddl.DataValueField = valfld;
        ddl.DataBind();
    }
    public void auto(string tbnm, string col, string ss)
    {
        string getstr;
        int getval;
        getstr = "select isnull(max(convert(int,(substring(" + col + ",4,9)))),0)+1 from " + tbnm + "";
        SqlCommand objcommand = new SqlCommand(getstr, con);
        con.Open();
        getval = Convert.ToInt16(objcommand.ExecuteScalar());
        cid = "" + ss + "" + Convert.ToInt16(getval);
        con.Close();
    }


    public void ddlcond(string tbnm, string txtfld, string valfld, string colnm, string val, DropDownList ddl)
    {
        da = new SqlDataAdapter("select * from " + tbnm + " where " + colnm + "=" + val + "", con);
        da.Fill(ds);
        ddl.DataSource = ds;
        ddl.DataTextField = txtfld;
        ddl.DataValueField = valfld;
        ddl.DataBind();
    }
    public void auto1(string tbnm, string col, string ss)
    {
        string getstr;
        int getval;
        getstr = "select isnull(max(convert(int,(substring(" + col + ",2,9)))),0)+1 from " + tbnm + "";
        SqlCommand objcommand = new SqlCommand(getstr, con);
        con.Open();
        getval = Convert.ToInt16(objcommand.ExecuteScalar());
        cid = "" + ss + "" + Convert.ToInt16(getval);
        con.Close();
    }
    public void auto0(string tbnm, string col, string ss)
    {

        string getstr;
        int getval;
        getstr = "select isnull(max(convert(int,(substring(" + col + ",3,9)))),0)+1 from " + tbnm + "";
        SqlCommand objcommand = new SqlCommand(getstr, con);
        con.Open();
        getval = Convert.ToInt16(objcommand.ExecuteScalar());
        cid = "" + ss + "" + Convert.ToInt16(getval);
        con.Close();
    }
    public void detail(string tbnm, string colnm, string val, DetailsView dtl)
    {
        da = new SqlDataAdapter("select * from " + tbnm + " where " + colnm + "=" + val + "", con);
        da.Fill(ds);
        dtl.DataSource = ds;
        dtl.DataBind();
    }
    public void auto2(string tbnm, string col, string ss)
    {
        string getstr;
        int getval;
        getstr = "select isnull(max(convert(int,(substring(" + col + ",5,9)))),0)+1 from " + tbnm + "";
        SqlCommand objcommand = new SqlCommand(getstr, con);
        con.Open();
        getval = Convert.ToInt16(objcommand.ExecuteScalar());
        cid = "" + ss + "" + Convert.ToInt16(getval);
        con.Close();
    }
    public void datalist(string tbnm, DataList dl)
    {
        da = new SqlDataAdapter("select * from " + tbnm + "", con);
        da.Fill(ds);
        dl.DataSource = ds;
        dl.DataBind();


    }
    public void formview(string tbnm, string colnm, string val, FormView fv)
    {
        da = new SqlDataAdapter("select * from " + tbnm + " where " + colnm + "=" + val + "", con);
        da.Fill(ds);
        fv.DataSource = ds;
        fv.DataBind();

    }
    public void auto3(string tbnm, string col, string ss)
    {
        string getstr;
        int getval;
        getstr = "select isnull(max(convert(int,(substring(" + col + ",6,9)))),0)+1 from " + tbnm + "";
        SqlCommand objcommand = new SqlCommand(getstr, con);
        con.Open();
        getval = Convert.ToInt16(objcommand.ExecuteScalar());
        cid = "" + ss + "" + Convert.ToInt16(getval);
        con.Close();
    }
    public void auto5(string tbnm, string col, string ss)
    {
        string getstr;
        int getval;
        getstr = "select isnull(max(convert(int,(substring(" + col + ",7,9)))),0)+1 from " + tbnm + "";
        SqlCommand objcommand = new SqlCommand(getstr, con);
        con.Open();
        getval = Convert.ToInt16(objcommand.ExecuteScalar());
        cid = "" + ss + "" + Convert.ToInt16(getval);
        con.Close();
    }
    public void auto4(string tbnm, string col, string ss)
    {
        string getstr;
        int getval;
        getstr = "select isnull(max(convert(int,(substring(" + col + ",4,9)))),0)+1 from " + tbnm + "";
        SqlCommand objcommand = new SqlCommand(getstr, con);
        con.Open();
        getval = Convert.ToInt16(objcommand.ExecuteScalar());
        cid = "" + ss + "" + Convert.ToInt16(getval);
        con.Close();
    }


    public void delete(string tbn, string cond, string condval)
    {
        ds.Reset();
        da = new SqlDataAdapter("delete from " + tbn + " where " + cond + "=" + condval + "", con);
        da.Fill(ds);


    }
    public void query(string str)
    {
        ds.Reset();
        da = new SqlDataAdapter(str,con);
        da.Fill(ds);


    }
    public void read(string pronm,string val)
    {

        ds.Reset();
        con.Open();
        da = new SqlDataAdapter(pronm + val, con);
        da.Fill(ds);
        con.Close();
    
    }
    public void ddl_select(string tbnm, string col, string txtfld, string valfld, string col1, string selcol, DropDownList ddl)
    {
        ds.Reset();
        da = new SqlDataAdapter("select " + col + " from " + tbnm + " union select " + col1 + "," + selcol + "", con);
        da.Fill(ds);
        ddl.DataSource = ds;
        ddl.DataTextField = txtfld;
        ddl.DataValueField = valfld;
        ddl.DataBind();
    }

    
    public void return3(string tbnm, string cond, string condval)
    {
        da = new SqlDataAdapter("select * from " + tbnm + " where " + cond + " = " + condval + "", con);
        da.Fill(ds);
    }

    public void read1(string tbnm, string cond, string condval)
    {

        da = new SqlDataAdapter("select * from " + tbnm + " where " + cond + "=" + condval + "", con);
        da.Fill(ds);
    }

    public void formviewcond(string tbnm, string cond, string condval, FormView fv)
    {
        da = new SqlDataAdapter("select * from " + tbnm + " where " + cond + "=" + condval + "", con);
        da.Fill(ds);
        fv.DataSource = ds;
        fv.DataBind();
    }


}