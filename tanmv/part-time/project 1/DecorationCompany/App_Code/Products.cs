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


public class Products
{
    SqlConnection sqlConnection;
	public Products()
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

    public DataTable GetTopProduct(int nTop)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select top " + nTop + " * from Products", sqlConnection);
        DataTable dt = new DataTable("ProductsTop");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }


    public DataTable GetByProductCat(int nCat)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Products as p left join ProductCategory as c on c.ProductCategoryID=p.ProductCategoryID where p.ProductCategoryID = " + nCat, sqlConnection);
        DataTable dt = new DataTable("ProductsByCat");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable GetByKeyword(string skeyword)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Products where ProductName like '%"+ skeyword+ "%'"  , sqlConnection);
        DataTable dt = new DataTable("GetByKeyword");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable GetProductRelated(int nCat)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select top 4 * from Products where ProductCategoryID = " + nCat, sqlConnection);
        DataTable dt = new DataTable("ProductsByCat");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable LoadByID(int nID)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Products Where ProductID=" + nID , sqlConnection);
        DataTable dt = new DataTable("LoadByID");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getAll()
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Products ", sqlConnection);
        DataTable dt = new DataTable("getAll");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    

    public DataTable getTop10()
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select top 12 * from Products ", sqlConnection);
        DataTable dt = new DataTable("getAll");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public int delete(int ProductID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Delete Products Where ProductID=@ProductID", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@ProductID", SqlDbType.Int));
        cmd.Parameters["@ProductID"].Value = ProductID;
        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int insert(string ProductName, double Price, string Images, int Stock, int ProductCategoryID, string InitContent, string MainContent)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Insert into Products (ProductName ,Price, Images, Stock,ProductCategoryID,InitContent,MainContent)values( @ProductName, @Price, @Images, @Stock,@ProductCategoryID,@InitContent,@MainContent)", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@ProductName", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.Float));
        cmd.Parameters.Add(new SqlParameter("@Images", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Stock", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@ProductCategoryID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@InitContent", SqlDbType.NVarChar, 2000));
        cmd.Parameters.Add(new SqlParameter("@MainContent", SqlDbType.NVarChar, 4000));

        cmd.Parameters["@ProductName"].Value = ProductName;
        cmd.Parameters["@Price"].Value = Price;
        cmd.Parameters["@Images"].Value = Images;
        cmd.Parameters["@Stock"].Value = Stock;
        cmd.Parameters["@ProductCategoryID"].Value = ProductCategoryID;
        cmd.Parameters["@InitContent"].Value = InitContent;
        cmd.Parameters["@MainContent"].Value = MainContent;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int update(int ProductID, string ProductName, double Price, string Images, int Stock, int ProductCategoryID, string InitContent, string MainContent)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Update Products Set ProductName=@ProductName, Price=@Price, Images=@Images,Stock=@Stock,ProductCategoryID=@ProductCategoryID,InitContent=@InitContent,MainContent=@MainContent Where ProductID=@ProductID", sqlConnection);

        cmd.Parameters.Add(new SqlParameter("@ProductID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@ProductName", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.Float));
        cmd.Parameters.Add(new SqlParameter("@Images", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Stock", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@ProductCategoryID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@InitContent", SqlDbType.NVarChar, 2000));
        cmd.Parameters.Add(new SqlParameter("@MainContent", SqlDbType.NVarChar, 4000));

        cmd.Parameters["@ProductID"].Value = ProductID;
        cmd.Parameters["@ProductName"].Value = ProductName;
        cmd.Parameters["@Price"].Value = Price;
        cmd.Parameters["@Images"].Value = Images;
        cmd.Parameters["@Stock"].Value = Stock;
        cmd.Parameters["@ProductCategoryID"].Value = ProductCategoryID;
        cmd.Parameters["@InitContent"].Value = InitContent;
        cmd.Parameters["@MainContent"].Value = MainContent;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }
}