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


public class Staff
{
    SqlConnection sqlConnection;
    public Staff()
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
        SqlDataAdapter da = new SqlDataAdapter("Select * from Staff", sqlConnection);
        DataTable dt = new DataTable("Staff");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getByID(int ID)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Staff where StaffID=" + ID, sqlConnection);
        DataTable dt = new DataTable("getByID");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public int delete(int StaffID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Delete Staff Where StaffID=@StaffID", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.Int));
        cmd.Parameters["@StaffID"].Value = StaffID;
        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int insert(string FullName, string Address, string Phone)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Insert into Staff (FullName,Address,Phone)values( @FullName,@Address,@Phone)", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@FullName", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 2000));
        cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 250));

        cmd.Parameters["@FullName"].Value = FullName;
        cmd.Parameters["@Address"].Value = Phone;
        cmd.Parameters["@Phone"].Value = FullName;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int update(int StaffID, string FullName, string Address, string Phone)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Update Staff Set FullName=@FullName,Address=@Address,Phone=@Phone Where StaffID=@StaffID", sqlConnection);

        cmd.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@FullName", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 2000));
        cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 250));

        cmd.Parameters["@StaffID"].Value = StaffID;
        cmd.Parameters["@FullName"].Value = FullName;
        cmd.Parameters["@Address"].Value = Address;
        cmd.Parameters["@Phone"].Value = Phone;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }
}