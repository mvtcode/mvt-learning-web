using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Web.Configuration;


public class RoleUser
{
    SqlConnection sqlConnection;
	public RoleUser()
	{
        sqlConnection = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ToString());
	}
    private void OpenConnection()
    {
        if (sqlConnection.State == ConnectionState.Closed)
        {
            sqlConnection.Open();
        }
    }

    private void CloseConnection()
    {
        if (sqlConnection.State == ConnectionState.Open)
        {
            sqlConnection.Close();
        }
    }

    public DataTable GetAll()
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from RoleUser where RoleID < 3", sqlConnection);
        DataTable dt = new DataTable("GetAll");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }


}