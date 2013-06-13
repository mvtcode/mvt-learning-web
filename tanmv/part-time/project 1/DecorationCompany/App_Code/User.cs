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


public class User
{
    SqlConnection sqlConnection;
    public User()
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
            SqlCommand cmd = new SqlCommand("Select Count(*) from Users Where Username=@Username And Password=@Password and RoleID < 3", sqlConnection);
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
        SqlDataAdapter da = new SqlDataAdapter("Select * from Users Where Username=N'" + Username + "'", sqlConnection);
        DataTable dt = new DataTable("getAccountByUsername");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getByID(int ID)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Users Where UserID=" + ID, sqlConnection);
        DataTable dt = new DataTable("getAccountByID");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getAll()
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Users", sqlConnection);
        DataTable dt = new DataTable("getAllAdmin");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    


    public DataTable GetAllAdminByName(string Name)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Users Where FullName like'%" + Name + "%' and RoleID < 3", sqlConnection);
        DataTable dt = new DataTable("GetAllAdminByName");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable GetAllAdminByUserName(string UserName)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Users Where Username like'%" + UserName + "%' and RoleID < 3", sqlConnection);
        DataTable dt = new DataTable("GetAllAdminByUserName");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public int deleteAdmin(int UserID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Delete Users Where UserID=@UserID", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int));
        cmd.Parameters["@UserID"].Value = UserID;
        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int deleteAllAdmin(string ID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Delete Users Where UserID in (" + ID + ") and RoleID < 3", sqlConnection);
        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }


    public int checkUser(string Username)
    {
        OpenConnection();
        try
        {
            SqlCommand cmd = new SqlCommand("Select Count(*) from Users Where Username=@Username and RoleID < 3", sqlConnection);
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

    public int insertUser(string Username, string Password, string Email, string FullName, int Sex, string Phone, string Address, string CMT, string AddressCMT, int RoleID, string BirthDay, string CMTDate)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Insert into Users (Username ,Password, Email, FullName, Sex, Phone, Address, CMT,AddressCMT,RoleID,BirthDay,CMTDate)values( @Username, @Password, @Email, @FullName, @Sex, @Phone, @Address,@CMT,@AddressCMT,@RoleID,@BirthDay,@CMTDate)", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@FullName", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Sex", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar,2000));
        cmd.Parameters.Add(new SqlParameter("@CMT", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@AddressCMT", SqlDbType.NVarChar, 2000));
        cmd.Parameters.Add(new SqlParameter("@RoleID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@BirthDay", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@CMTDate", SqlDbType.NVarChar, 250));

        cmd.Parameters["@Username"].Value = Username;
        cmd.Parameters["@Password"].Value = Password;
        cmd.Parameters["@Email"].Value = Email;
        cmd.Parameters["@FullName"].Value = FullName;
        cmd.Parameters["@Sex"].Value = Sex;
        cmd.Parameters["@Phone"].Value = Phone;
        cmd.Parameters["@Address"].Value = Address;
        cmd.Parameters["@CMT"].Value = CMT;
        cmd.Parameters["@AddressCMT"].Value = AddressCMT;
        cmd.Parameters["@RoleID"].Value = RoleID;
        cmd.Parameters["@BirthDay"].Value = BirthDay;
        cmd.Parameters["@CMTDate"].Value = CMTDate;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int updateAdmin(int UserID, string Username, string Password, string Email, string FullName, int Sex, string Phone, string Address, int RoleID, string BirthDay, string CMTDate)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Update Users Set Username=@Username, Password=@Password, Email=@Email,FullName=@FullName, Sex=@Sex ,Phone  = @Phone,Address =@Address,RoleID=@RoleID,BirthDay=@BirthDay,CMTDate = @CMTDate Where UserID=@UserID", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@FullName", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Sex", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 2000));
       
        cmd.Parameters.Add(new SqlParameter("@RoleID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@BirthDay", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@CMTDate", SqlDbType.NVarChar, 250));

        cmd.Parameters["@UserID"].Value = UserID;
        cmd.Parameters["@Username"].Value = Username;
        cmd.Parameters["@Password"].Value = Password;
        cmd.Parameters["@Email"].Value = Email;
        cmd.Parameters["@FullName"].Value = FullName;
        cmd.Parameters["@Sex"].Value = Sex;
        cmd.Parameters["@Phone"].Value = Phone;
        cmd.Parameters["@Address"].Value = Address;
       
        cmd.Parameters["@RoleID"].Value = RoleID;
        cmd.Parameters["@BirthDay"].Value = BirthDay;
        cmd.Parameters["@CMTDate"].Value = CMTDate;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }


    public int checkEmail(string Email)
    {
        OpenConnection();
        try
        {
            SqlCommand cmd = new SqlCommand("Select Count(*) from Users Where Email=@Email and RoleID < 3", sqlConnection);
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

    public int CreateNewAccount(string Username, string Password, string Email, string FullName, int Sex, string Phone, string Address, string CMT,int RoleID, string BirthDay)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Insert into Users (Username ,Password, Email, FullName, Sex, Phone, Address,CMT,RoleID,BirthDay)values(@Username ,@Password, @Email,@FullName, @Sex, @Phone, @Address,@CMT,@RoleID,@BirthDay)", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@FullName", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Sex", SqlDbType.Int, 4));
        cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@CMT", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@RoleID", SqlDbType.Int, 4));
        cmd.Parameters.Add(new SqlParameter("@BirthDay", SqlDbType.NVarChar, 250));
  

        cmd.Parameters["@Username"].Value = Username;
        cmd.Parameters["@Password"].Value = Password;
        cmd.Parameters["@Email"].Value = Email;
        cmd.Parameters["@FullName"].Value = FullName;
        cmd.Parameters["@Sex"].Value = Sex;
        cmd.Parameters["@Phone"].Value = Phone;
        cmd.Parameters["@Address"].Value = Address;
        cmd.Parameters["@CMT"].Value = CMT;
        cmd.Parameters["@RoleID"].Value = RoleID;
        cmd.Parameters["@BirthDay"].Value = BirthDay;


        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }
}