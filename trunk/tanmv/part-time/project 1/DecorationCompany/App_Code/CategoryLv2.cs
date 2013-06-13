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

public class CategoryLv2
{
    SqlConnection sqlConnection;
	public CategoryLv2()
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
        SqlDataAdapter da = new SqlDataAdapter("Select * from CategoryLv2", sqlConnection);
        DataTable dt = new DataTable("CategoryLv2");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getByID(int ID)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from CategoryLv2 where CategoryLv2ID=" + ID, sqlConnection);
        DataTable dt = new DataTable("getByID");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public int delete(int CategoryLv2ID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Delete CategoryLv2 Where CategoryLv2ID=@CategoryLv2ID", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@CategoryLv2ID", SqlDbType.Int));
        cmd.Parameters["@CategoryLv2ID"].Value = CategoryLv2ID;
        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int insert(string Description)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Insert into CategoryLv2 (Description)values( @Description)", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 250));



        cmd.Parameters["@Description"].Value = Description;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int update(int CategoryLv2ID, string Description)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Update CategoryLv2 Set Description=@Description Where CategoryLv2ID=@CategoryLv2ID", sqlConnection);

        cmd.Parameters.Add(new SqlParameter("@CategoryLv2ID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 250));

        cmd.Parameters["@CategoryLv2ID"].Value = CategoryLv2ID;
        cmd.Parameters["@Description"].Value = Description;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }
}