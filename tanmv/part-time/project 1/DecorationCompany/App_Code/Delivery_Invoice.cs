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


public class Delivery_Invoice
{
    SqlConnection sqlConnection;
    public Delivery_Invoice()
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



    public DataTable getAll()
    {
        string sQuery = "Select d.Delivery_InvoiceID,d.StaffID,d.Date,d.InvoiceDetailsID,d.Status as Delivery_Status,"+
		                "i.InvoiceID,i.Date_Create,i.Status as InvoiceDetails_Status,i.UserID,i.Requirements,"+
		                "s.StaffID,s.FullName as Staff_Name,s.Address as Staff_Address,s.Phone as Staff_Phone,"+
		                "u.Username,u.Password,u.Email,u.FullName,u.Sex,u.Phone,u.Address,u.CMT,u.BirthDay,u.RoleID "+
	                            "from Delivery_Invoice as d "+
	                                    "left join Staff as s on s.StaffID = d.StaffID "+
	                                    "left join InvoiceDetails as  i on i.InvoiceDetailsID = d.InvoiceDetailsID "+
	                                    "left join Users as u on u.UserID = i.UserID ";
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter(sQuery, sqlConnection);
        DataTable dt = new DataTable("getAll");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getByID(int ID)
    {
        string sQuery = "Select d.Delivery_InvoiceID,d.StaffID,d.Date,d.InvoiceDetailsID,d.Status as Delivery_Status," +
                        "i.InvoiceID,i.Date_Create,i.Status as InvoiceDetails_Status,i.UserID,i.Requirements," +
                        "s.StaffID,s.FullName as Staff_Name,s.Address as Staff_Address,s.Phone as Staff_Phone," +
                        "u.Username,u.Password,u.Email,u.FullName,u.Sex,u.Phone,u.Address,u.CMT,u.BirthDay,u.RoleID " +
                                "from Delivery_Invoice as d " +
                                        "left join Staff as s on s.StaffID = d.StaffID " +
                                        "left join InvoiceDetails as  i on i.InvoiceDetailsID = d.InvoiceDetailsID " +
                                        "left join Users as u on u.UserID = i.UserID where d.Delivery_InvoiceID=";
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter(sQuery + ID, sqlConnection);
        DataTable dt = new DataTable("getByID");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }
    public DataTable getByIDInvoiceDetails(int ID)
    {
        string sQuery = "Select d.Delivery_InvoiceID,d.StaffID,d.Date,d.InvoiceDetailsID,d.Status as Delivery_Status," +
                        "i.InvoiceID,i.Date_Create,i.Status as InvoiceDetails_Status,i.UserID,i.Requirements," +
                        "s.StaffID,s.FullName as Staff_Name,s.Address as Staff_Address,s.Phone as Staff_Phone," +
                        "u.Username,u.Password,u.Email,u.FullName,u.Sex,u.Phone,u.Address,u.CMT,u.BirthDay,u.RoleID " +
                                "from Delivery_Invoice as d " +
                                        "left join Staff as s on s.StaffID = d.StaffID " +
                                        "left join InvoiceDetails as  i on i.InvoiceDetailsID = d.InvoiceDetailsID " +
                                        "left join Users as u on u.UserID = i.UserID where d.InvoiceDetailsID=";
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter(sQuery + ID, sqlConnection);
        DataTable dt = new DataTable("getByID");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable ReportbyDate(string sDateFrom , string sDateTo)
    {
        string sQuery = "Select d.Delivery_InvoiceID,d.StaffID,d.Date,d.InvoiceDetailsID,d.Status as Delivery_Status," +
                        "i.InvoiceID,i.Date_Create,i.Status as InvoiceDetails_Status,i.UserID,i.Requirements," +
                        "s.StaffID,s.FullName as Staff_Name,s.Address as Staff_Address,s.Phone as Staff_Phone," +
                        "u.Username,u.Password,u.Email,u.FullName,u.Sex,u.Phone,u.Address,u.CMT,u.BirthDay,u.RoleID " +
                                "from Delivery_Invoice as d " +
                                        "left join Staff as s on s.StaffID = d.StaffID " +
                                        "left join InvoiceDetails as  i on i.InvoiceDetailsID = d.InvoiceDetailsID " +
                                        "left join Users as u on u.UserID = i.UserID "+
                                         " where i.Status=1 and i.Date_Create >= convert(datetime, '" + sDateFrom + "', 101) " +
                            " and i.Date_Create <= convert(datetime, '" + sDateTo + "', 101) ";
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter(sQuery, sqlConnection);
        DataTable dt = new DataTable("ReportbyDate");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }
    public int delete(int Delivery_InvoiceID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Delete Delivery_Invoice Where Delivery_InvoiceID=@Delivery_InvoiceID", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@Delivery_InvoiceID", SqlDbType.Int));
        cmd.Parameters["@Delivery_InvoiceID"].Value = Delivery_InvoiceID;
        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int insert(int StaffID, string Date, int InvoiceDetailsID,int Status)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Insert into Delivery_Invoice (StaffID ,Date, InvoiceDetailsID, Status)values( @StaffID, @Date, @InvoiceDetailsID, @Status)", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@Date", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@InvoiceDetailsID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Int));


        cmd.Parameters["@StaffID"].Value = StaffID;
        cmd.Parameters["@Date"].Value = Date;
        cmd.Parameters["@InvoiceDetailsID"].Value = InvoiceDetailsID;
        cmd.Parameters["@Status"].Value = Status;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }
    public int updateStatus(int Delivery_InvoiceID, int StaffID,int Status)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Update Delivery_Invoice Set StaffID=@StaffID, Status=@Status Where Delivery_InvoiceID=@Delivery_InvoiceID", sqlConnection);

        cmd.Parameters.Add(new SqlParameter("@Delivery_InvoiceID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Int));

        cmd.Parameters["@Delivery_InvoiceID"].Value = Delivery_InvoiceID;
        cmd.Parameters["@StaffID"].Value = StaffID;
        cmd.Parameters["@Status"].Value = Status;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

}