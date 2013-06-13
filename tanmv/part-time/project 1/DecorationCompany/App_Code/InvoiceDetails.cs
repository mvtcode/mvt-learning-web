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


public class InvoiceDetails
{
    SqlConnection sqlConnection;
	public InvoiceDetails()
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


    public DataTable ReportbyDate(string sDateFrom,string sDateTo)
    {
        string sQuery = " select * from InvoiceDetails as i left join Users as u on u.UserID=i.UserID  "+
                            " where Status=1 and convert(datetime,i.Date_Create, 101) >= convert(datetime, '" + sDateFrom + "', 101) " +
                            " and convert(datetime,i.Date_Create, 101) <= convert(datetime, '" + sDateTo + "', 101) ";
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter(sQuery, sqlConnection);
        DataTable dt = new DataTable("getAll");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }
    public DataTable ReportbyDate_2(string sDateFrom, string sDateTo)
    {
        string sQuery = " select top 3 * from InvoiceDetails as i left join Users as u on u.UserID=i.UserID  " +
                            " where Status=1 and i.Date_Create >= convert(datetime, '" + sDateFrom + "', 101) " +
                            " and i.Date_Create <= convert(datetime, '" + sDateTo + "', 101) ";
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter(sQuery, sqlConnection);
        DataTable dt = new DataTable("getAll");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable ReportbyDateChart(string sMonth, int nStatus)
    {
        string sStatus = "";
        if (nStatus > 0)
        {  sStatus = "Status=1 and "; }
        else {  sStatus = ""; }
        string sQuery = " select * from InvoiceDetails " +
                            " where " + sStatus + " Date_Create >= convert(datetime, '" + sMonth + "/01/2013', 101) " +
                            " and Date_Create <= convert(datetime, '" + sMonth + "/28/2013', 101) ";
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter(sQuery, sqlConnection);
        DataTable dt = new DataTable("ReportbyDateChart");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }


    public DataTable getAll()
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("select * from InvoiceDetails as i left join Users as u on u.UserID=i.UserID ", sqlConnection);
        DataTable dt = new DataTable("getAll");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getAllByStatus()
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("select * from InvoiceDetails as i left join Users as u on u.UserID=i.UserID where Status=1 ", sqlConnection);
        DataTable dt = new DataTable("getAllByStatus");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getByID(int ID)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("select * from InvoiceDetails as i left join Users as u on u.UserID=i.UserID where i.InvoiceDetailsID =" + ID, sqlConnection);
        DataTable dt = new DataTable("getAll");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }
    public int updateStatus(int InvoiceDetailsID, int Status)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Update InvoiceDetails Set Status=@Status Where InvoiceDetailsID=@InvoiceDetailsID", sqlConnection);

        cmd.Parameters.Add(new SqlParameter("@InvoiceDetailsID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Int));

        cmd.Parameters["@InvoiceDetailsID"].Value = InvoiceDetailsID;
        cmd.Parameters["@Status"].Value = Status;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }
    public int insert(string InvoiceID, string Date_Create, int Status, int UserID, string Requirements)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Insert into InvoiceDetails(InvoiceID, Date_Create,  Status,UserID,Requirements) values (@InvoiceID, @Date_Create, @Status, @UserID,@Requirements)", sqlConnection);

        cmd.Parameters.Add(new SqlParameter("@InvoiceID", SqlDbType.VarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Date_Create", SqlDbType.VarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@Requirements", SqlDbType.VarChar, 4000));


        cmd.Parameters["@InvoiceID"].Value = InvoiceID;
        cmd.Parameters["@Date_Create"].Value = Date_Create;
        cmd.Parameters["@Status"].Value = Status;
        cmd.Parameters["@UserID"].Value = UserID;
        cmd.Parameters["@Requirements"].Value = Requirements;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }


    public int delete(int InvoiceDetailsID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Delete InvoiceDetails Where InvoiceDetailsID=@InvoiceDetailsID", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@InvoiceDetailsID", SqlDbType.Int));
        cmd.Parameters["@InvoiceDetailsID"].Value = InvoiceDetailsID;
        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }
}