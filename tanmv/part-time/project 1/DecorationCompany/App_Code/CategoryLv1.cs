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

public class CategoryLv1
{
    SqlConnection sqlConnection;
	public CategoryLv1()
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
        SqlDataAdapter da = new SqlDataAdapter("Select * from CategoryLv1", sqlConnection);
        DataTable dt = new DataTable("CategoryLv1");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getByID(int ID)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from CategoryLv1 where CategoryLv1=" + ID, sqlConnection);
        DataTable dt = new DataTable("getByID");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public int delete(int CategoryLv1)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Delete CategoryLv1 Where CategoryLv1=@CategoryLv1", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@CategoryLv1", SqlDbType.Int));
        cmd.Parameters["@CategoryLv1"].Value = CategoryLv1;
        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int insert(string Description)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Insert into CategoryLv1 (Description)values( @Description)", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 250));



        cmd.Parameters["@Description"].Value = Description;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int update(int CategoryLv1, string Description)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Update CategoryLv1 Set Description=@Description Where CategoryLv1=@CategoryLv1", sqlConnection);

        cmd.Parameters.Add(new SqlParameter("@CategoryLv1", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 250));

        cmd.Parameters["@CategoryLv1"].Value = CategoryLv1;
        cmd.Parameters["@Description"].Value = Description;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }
}