using System;

using System.Collections.Generic;

using System.Data.Common;

using System.Data.OleDb;

using System.Data.SqlClient;

using System.Linq;

using System.Web;

using System.Web.UI;

using System.Web.UI.WebControls;
public partial class Hr_importtxt : System.Web.UI.Page
{
    global gl = new global();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {       
                //try

                //{
                    string path = string.Concat(Server.MapPath("~/Uploaded Folder/" + FileUpload1.FileName)); 

                    FileUpload1.SaveAs(path);
 

                    // Connection String to Excel Workbook

                   string excelConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", path);
                   // string excelConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", path);


                    OleDbConnection connection = new OleDbConnection();

                    connection.ConnectionString = excelConnectionString;

                    OleDbCommand command = new OleDbCommand("select * from [Sheet1$]", connection);

                    connection.Open();

                    // Create DbDataReader to Data Worksheet

                    DbDataReader dr = command.ExecuteReader();

 

                    // SQL Server Connection String

                    string sqlConnectionString = @"Data Source=KAMAL-PC;Initial Catalog=Bharatmotordb;User ID=sa;Password=Tips";

                   // gl.query("delete from attendance");

                   // Bulk Copy to SQL Server 

                    SqlBulkCopy bulkInsert = new SqlBulkCopy(sqlConnectionString);

                    bulkInsert.DestinationTableName = "Daily_attendance";

                    bulkInsert.WriteToServer(dr);

                    Label1.Text = "Ho Gaya";

                //}

                //catch(Exception ex)

                //{

                //    Label1.Text = ex.Message; 

                //}

            

        
    }
}