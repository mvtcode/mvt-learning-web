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


public class Adv
{
    SqlConnection sqlConnection;
    public Adv()
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
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Adv", sqlConnection);
        DataTable dt = new DataTable("getAll");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }


    public DataTable getByCategoryID(int nCat)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select top 1 * from Adv where CategoryLv1=" + nCat, sqlConnection);
        DataTable dt = new DataTable("getByCategoryID");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }


    public DataTable getByID(int ID)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Adv where AdvID=" + ID, sqlConnection);
        DataTable dt = new DataTable("getAll");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public int delete(int AdminID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Delete Adv Where AdvID=@AdvID", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@AdvID", SqlDbType.Int));
        cmd.Parameters["@AdvID"].Value = AdminID;
        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int insert(string Description, string Url, string Images, int CategoryLv1)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Insert into Adv (Description ,Url, Images, CategoryLv1)values( @Description, @Url, @Images, @CategoryLv1)", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Url", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Images", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@CategoryLv1", SqlDbType.Int));


        cmd.Parameters["@Description"].Value = Description;
        cmd.Parameters["@Url"].Value = Url;
        cmd.Parameters["@Images"].Value = Images;
        cmd.Parameters["@CategoryLv1"].Value = CategoryLv1;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int update(int AdvID, string Description, string Url, string Images, int CategoryLv1)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Update Adv Set Description=@Description, Url=@Url, Images=@Images,CategoryLv1=@CategoryLv1 Where AdvID=@AdvID", sqlConnection);

        cmd.Parameters.Add(new SqlParameter("@AdvID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Url", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@Images", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@CategoryLv1", SqlDbType.Int));

        cmd.Parameters["@AdvID"].Value = AdvID;
        cmd.Parameters["@Description"].Value = Description;
        cmd.Parameters["@Url"].Value = Url;
        cmd.Parameters["@Images"].Value = Images;
        cmd.Parameters["@CategoryLv1"].Value = CategoryLv1;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }


}