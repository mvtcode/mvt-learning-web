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

public class ProductCategory
{
    SqlConnection sqlConnection;
	public ProductCategory()
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


    public DataTable GetAllProductCat()
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from ProductCategory", sqlConnection);
        DataTable dt = new DataTable("ProductCategory");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }


    public DataTable getByID(int ID)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from ProductCategory where ProductCategoryID=" + ID, sqlConnection);
        DataTable dt = new DataTable("getByID");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public int delete(int ProductCategoryID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Delete ProductCategory Where ProductCategoryID=@ProductCategoryID", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@ProductCategoryID", SqlDbType.Int));
        cmd.Parameters["@ProductCategoryID"].Value = ProductCategoryID;
        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int insert(string ProductCategoryName)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Insert into ProductCategory (ProductCategoryName)values( @ProductCategoryName)", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@ProductCategoryName", SqlDbType.NVarChar, 250));



        cmd.Parameters["@ProductCategoryName"].Value = ProductCategoryName;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int update(int ProductCategoryID, string ProductCategoryName)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Update ProductCategory Set ProductCategoryName=@ProductCategoryName Where ProductCategoryID=@ProductCategoryID", sqlConnection);

        cmd.Parameters.Add(new SqlParameter("@ProductCategoryID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@ProductCategoryName", SqlDbType.NVarChar, 250));

        cmd.Parameters["@ProductCategoryID"].Value = ProductCategoryID;
        cmd.Parameters["@ProductCategoryName"].Value = ProductCategoryName;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }
}