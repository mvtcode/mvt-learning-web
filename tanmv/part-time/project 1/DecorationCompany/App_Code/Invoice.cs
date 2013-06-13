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


public class Invoice
{
    SqlConnection sqlConnection;
	public Invoice()
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

    public DataTable ReportByDate(string sDateFrom,string sDateTo)
    {
        string sQuery = "select * from Invoice as i left join Products as p on p.ProductID=i.ProductID "+
							" left join ProductCategory as c on c.ProductCategoryID=p.ProductCategoryID"+
							" where i.DateBuy >= convert(datetime, '"+sDateFrom+"', 101) "+
						    " and i.DateBuy <= convert(datetime, '"+sDateTo+"', 101) ";
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter(sQuery, sqlConnection);
        DataTable dt = new DataTable("getAll");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getAll()
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("select * from Invoice as i left join Products as p on p.ProductID=i.ProductID", sqlConnection);
        DataTable dt = new DataTable("getAll");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getMultipleID(string sID)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("select * from Invoice as i left join Products as p on p.ProductID=i.ProductID left join ProductCategory as c on c.ProductCategoryID=p.ProductCategoryID where i.InvoiceID in  (" + sID + ")", sqlConnection);
        DataTable dt = new DataTable("getAll");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getReport_Product_Details(string sDateFrom,string sDateTo)
    {
        string sQuery = " select i.ProductID as ProductID,sum(i.Number )as Number from Invoice as i  " +
                            " left join Products as p on p.ProductID=i.ProductID  " +
                            " left join ProductCategory as c on c.ProductCategoryID=p.ProductCategoryID  " +
                            " where DateBuy>='"+sDateFrom+"' AND DateBuy<='"+sDateTo+"' " +
                            " group by i.ProductID ";
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter(sQuery, sqlConnection);
        DataTable dt = new DataTable("getReport_Product_Details");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }


    public DataTable getReport_Product_Details_2(string sDateFrom, string sDateTo)
    {
        string sQuery = " select * from (select  ProductCategory.ProductCategoryID,ProductCategory.ProductCategoryName, sum(Number) as Number from  Invoice"+ 
                          " inner join Products  on Invoice.ProductID=Products.ProductID "+ 
                          " inner join ProductCategory on ProductCategory.ProductCategoryID=Products.ProductCategoryID "+ 
                          " where DateBuy>='"+sDateFrom+"' AND DateBuy<='"+sDateTo+"'"+
                           "group by  ProductCategory.ProductCategoryID,ProductCategory.ProductCategoryName)a where Number<=2";
                          

        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter(sQuery, sqlConnection);
        DataTable dt = new DataTable("getReport_Product_Details");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }


    public DataTable getReport_Product_Details_3(string sDateFrom, string sDateTo)
    {
        string sQuery = " select top 3 i.ProductID as ProductID,sum(i.Number )as Number from Invoice as i  " +
                            " left join Products as p on p.ProductID=i.ProductID  " +
                            " left join ProductCategory as c on c.ProductCategoryID=p.ProductCategoryID  " +
                            " where DateBuy>='" + sDateFrom + "' AND DateBuy<='" + sDateTo + "' and Stock<=2" +
                            " group by i.ProductID order by Number desc";
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter(sQuery, sqlConnection);
        DataTable dt = new DataTable("getReport_Product_Details");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }


    public DataTable getReport_Category_Details(string sDateFrom, string sDateTo)
    {
        string sQuery = " select c.ProductCategoryID as ProductCategoryID,sum(i.Number )as Number from Invoice as i  " +
                            " left join Products as p on p.ProductID=i.ProductID  " +
                            " left join ProductCategory as c on c.ProductCategoryID=p.ProductCategoryID  " +
                            " where DateBuy>='" + sDateFrom + "' AND DateBuy<='" + sDateTo + "'  " +
                            " group by c.ProductCategoryID ";
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter(sQuery, sqlConnection);
        DataTable dt = new DataTable("getReport_Product_Details");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getReport_Category_Details_3(string sDateFrom, string sDateTo)
    {
        string sQuery = " select top 3 c.ProductCategoryID as ProductCategoryID,sum(i.Number )as Number from Invoice as i  " +
                            " left join Products as p on p.ProductID=i.ProductID  " +
                            " left join ProductCategory as c on c.ProductCategoryID=p.ProductCategoryID  " +
                            " where DateBuy>='" + sDateFrom + "' AND DateBuy<='" + sDateTo + "'  " +
                            " group by c.ProductCategoryID ";
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter(sQuery, sqlConnection);
        DataTable dt = new DataTable("getReport_Product_Details");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getReport_Category_Details_2(string sDateFrom, string sDateTo)
    {
        string sQuery = " select c.ProductCategoryID as ProductCategoryID,sum(i.Number )as Number from Invoice as i  " +
                            " left join Products as p on p.ProductID=i.ProductID  " +
                            " left join ProductCategory as c on c.ProductCategoryID=p.ProductCategoryID  and Stock<=2 " +
                            " where DateBuy>='" + sDateFrom + "' AND DateBuy<='" + sDateTo + "' " +
                            " group by c.ProductCategoryID ";
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter(sQuery, sqlConnection);
        DataTable dt = new DataTable("getReport_Product_Details");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }


    public DataTable getNumberMultipleID(string sID)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("select Sum(i.Number) as Number from Invoice as i left join Products as p on p.ProductID=i.ProductID left join ProductCategory as c on c.ProductCategoryID=p.ProductCategoryID where i.InvoiceID in  (" + sID + ")", sqlConnection);
        DataTable dt = new DataTable("getNumberMultipleID");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getByProductID(int ProductID, string DateBuy)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Invoice where ProductID=" + ProductID + " and DateBuy='" + DateBuy + "'", sqlConnection);
        DataTable dt = new DataTable("getByProductID");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public int insertInvoice(int ProductID, string DateBuy, int Number, float Total, int Status)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Insert into Invoice(ProductID, DateBuy, Number, Total, Status) values (@ProductID, @DateBuy, @Number, @Total, @Status)", sqlConnection);

        cmd.Parameters.Add(new SqlParameter("@ProductID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@DateBuy", SqlDbType.VarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Number", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@Total", SqlDbType.Float));
        cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Int));



        cmd.Parameters["@ProductID"].Value = ProductID;
        cmd.Parameters["@DateBuy"].Value = DateBuy;
        cmd.Parameters["@Number"].Value = Number;
        cmd.Parameters["@Total"].Value = Total;
        cmd.Parameters["@Status"].Value = Status;



        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }


    public int delete(int InvoiceID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Delete Invoice Where InvoiceID=@InvoiceID", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@InvoiceID", SqlDbType.Int));
        cmd.Parameters["@InvoiceID"].Value = InvoiceID;
        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }
}