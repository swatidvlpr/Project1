using System;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using AjaxControlToolkit;


[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string[] Auto(string prefixText)
    {

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Conn"].ToString());
        //string sql = "select * from Food_product_master where Food_Product_name like '" + prefixText + "%'";
        string sql = "select * from Inquirymaster where Inquiry_type like '" + prefixText + "%'"; 
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        da.Fill(dt);
        List<string> l = new List<string>();
        foreach (DataRow dr in dt.Rows)
        {
            l.Add(dr[1].ToString());
        }
        return l.ToArray();
    }
    //[WebMethod]
    //public string[] Auto1(string prefixText)
    //{

    //    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ABC"].ToString());
    //    string sql = "select * from imagesearch where IMGNAME like '" + prefixText + "%'";
    //    DataTable dt = new DataTable();
    //    SqlDataAdapter da = new SqlDataAdapter(sql, con);
    //    da.Fill(dt);
    //    List<string> l = new List<string>();
    //    foreach (DataRow dr in dt.Rows)
    //    {
    //        l.Add(dr[1].ToString());
    //    }
    //    return l.ToArray();
    //}


    //[WebMethod]
    //public CascadingDropDownNameValue[] GetCountries(string knownCategoryValues)
    //{
    //    string query = "SELECT Food_Product_name, Food_Product_name FROM Food_product_master";
    //    List<CascadingDropDownNameValue> countries = GetData(query);
    //    return countries.ToArray();
    //}

    //private List<CascadingDropDownNameValue> GetData(string query)
    //{
    //    string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
    //    SqlCommand cmd = new SqlCommand(query);
    //    List<CascadingDropDownNameValue> values = new List<CascadingDropDownNameValue>();
    //    using (SqlConnection con = new SqlConnection(conString))
    //    {
    //        con.Open();
    //        cmd.Connection = con;
    //        using (SqlDataReader reader = cmd.ExecuteReader())
    //        {
    //            while (reader.Read())
    //            {
    //                values.Add(new CascadingDropDownNameValue
    //                {
    //                    name = reader[0].ToString(),
    //                    value = reader[1].ToString()
    //                });
    //            }
    //            reader.Close();
    //            con.Close();
    //            return values;
    //        }
    //    }
    //}
}
