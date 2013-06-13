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


public class Administrator
{
    SqlConnection sqlConnection;
    public Administrator()
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



    public int checkLoginAdmin(string Username, string Password)
    {
        OpenConnection();
        try
        {
            SqlCommand cmd = new SqlCommand("Select Count(*) from Administrator Where Username=@Username And Password=@Password", sqlConnection);
            cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar));
            cmd.Parameters["@Username"].Value = Username;
            cmd.Parameters["@Password"].Value = Password;
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
            return -1;

        }
        CloseConnection();

    }


    public DataTable getAccountByUsername(string Username)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Administrator Where Username=N'" + Username + "'", sqlConnection);
        DataTable dt = new DataTable("getAccountByUsername");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getAccountByID(int ID)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Administrator Where AdminID=" + ID, sqlConnection);
        DataTable dt = new DataTable("getAccountByID");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getAllAdmin()
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Administrator where RoleID < 3", sqlConnection);
        DataTable dt = new DataTable("getAllAdmin");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getAllAdminbyID(int ID)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Administrator where AdminID=" + ID + " and RoleID < 3", sqlConnection);
        DataTable dt = new DataTable("getAllAdmin");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }


    public DataTable GetAllAdminByName(string Name)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Administrator Where Name like'%" + Name + "%' and RoleID < 3", sqlConnection);
        DataTable dt = new DataTable("GetAllAdminByName");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable GetAllAdminByUserName(string UserName)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Administrator Where Username like'%" + UserName + "%' and RoleID < 3", sqlConnection);
        DataTable dt = new DataTable("GetAllAdminByUserName");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public int deleteAdmin(int AdminID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Delete Administrator Where AdminID=@AdminID", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@AdminID", SqlDbType.Int));
        cmd.Parameters["@AdminID"].Value = AdminID;
        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int deleteAllAdmin(string ID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Delete Administrator Where AdminID in (" + ID + ") and RoleID < 3", sqlConnection);
        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }


    public int checkUser(string Username)
    {
        OpenConnection();
        try
        {
            SqlCommand cmd = new SqlCommand("Select Count(*) from Administrator Where Username=@Username and RoleID < 3", sqlConnection);
            cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 250));
            cmd.Parameters["@Username"].Value = Username;
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
            return -1;

        }
        CloseConnection();
    }

    public int insertAdministrator(string Username, string Password, string Name, string Email, string Phone, string Address, int RoleID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Insert into Administrator (Username ,Password, Name, Email, Phone, Address, RoleID)values( @Username, @Password, @Name, @Email, @Phone, @Address, @RoleID)", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@RoleID", SqlDbType.Int));
       

        cmd.Parameters["@Username"].Value = Username;
        cmd.Parameters["@Password"].Value = Password;
        cmd.Parameters["@Name"].Value = Name;
        cmd.Parameters["@Email"].Value = Email;
        cmd.Parameters["@Phone"].Value = Phone;
        cmd.Parameters["@Address"].Value = Address;
        cmd.Parameters["@RoleID"].Value = RoleID;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int updateAdmin(int AdminID, string Username, string Password, string Name, string Email, string Phone, string Address, int RoleID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Update Administrator Set Username=@Username, Password=@Password, Name=@Name,Email=@Email, Phone=@Phone ,Address = @Address,RoleID =@RoleID Where AdminID=@AdminID", sqlConnection);

        cmd.Parameters.Add(new SqlParameter("@AdminID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@RoleID", SqlDbType.Int));
        

        cmd.Parameters["@AdminID"].Value = AdminID;
        cmd.Parameters["@Username"].Value = Username;
        cmd.Parameters["@Password"].Value = Password;
        cmd.Parameters["@Email"].Value = Email;
        cmd.Parameters["@Name"].Value = Name;
        cmd.Parameters["@Phone"].Value = Phone;
        cmd.Parameters["@Address"].Value = Address;
        cmd.Parameters["@RoleID"].Value = RoleID;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }


    public int checkEmail(string Email)
    {
        OpenConnection();
        try
        {
            SqlCommand cmd = new SqlCommand("Select Count(*) from Administrator Where Email=@Email and RoleID < 3", sqlConnection);
            cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 250));
            cmd.Parameters["@Email"].Value = Email;
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
            return -1;

        }
        CloseConnection();

    }
}