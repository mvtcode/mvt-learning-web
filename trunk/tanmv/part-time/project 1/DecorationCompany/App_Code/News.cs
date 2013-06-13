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


public class News
{
    SqlConnection sqlConnection;
    public News()
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
        SqlDataAdapter da = new SqlDataAdapter("Select * from News as n left join CategoryLv2 as c on c.CategoryLv2ID = n.CategoryLv2ID ", sqlConnection);
        DataTable dt = new DataTable("getAll");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public DataTable getByID(int ID)
    {
        OpenConnection();
        SqlDataAdapter da = new SqlDataAdapter("Select * from News where NewID=" + ID, sqlConnection);
        DataTable dt = new DataTable("getAll");
        da.Fill(dt);
        CloseConnection();
        return dt;
    }

    public int delete(int NewID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Delete News Where NewID=@NewID", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@NewID", SqlDbType.Int));
        cmd.Parameters["@NewID"].Value = NewID;
        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int insert(string Name, string InitContent, string Content, string Images, int CategoryLv2ID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Insert into News (Name ,InitContent, Content, Images,CategoryLv2ID)values( @Name, @InitContent, @Content, @Images,@CategoryLv2ID)", sqlConnection);
        cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@InitContent", SqlDbType.NVarChar, 2000));
        cmd.Parameters.Add(new SqlParameter("@Content", SqlDbType.NVarChar, 4000));
        cmd.Parameters.Add(new SqlParameter("@Images", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@CategoryLv2ID", SqlDbType.Int));


        cmd.Parameters["@Name"].Value = Name;
        cmd.Parameters["@InitContent"].Value = InitContent;
        cmd.Parameters["@Content"].Value = Content;
        cmd.Parameters["@Images"].Value = Images;
        cmd.Parameters["@CategoryLv2ID"].Value = CategoryLv2ID;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }

    public int update(int NewID,string Name, string InitContent, string Content, string Images, int CategoryLv2ID)
    {
        OpenConnection();
        SqlCommand cmd = new SqlCommand("Update News Set Name=@Name, InitContent=@InitContent, Content=@Content,Images=@Images,CategoryLv2ID=@CategoryLv2ID Where NewID=@NewID", sqlConnection);

        cmd.Parameters.Add(new SqlParameter("@NewID", SqlDbType.Int));
        cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@InitContent", SqlDbType.NVarChar, 2000));
        cmd.Parameters.Add(new SqlParameter("@Content", SqlDbType.NVarChar, 4000));
        cmd.Parameters.Add(new SqlParameter("@Images", SqlDbType.NVarChar, 250));
        cmd.Parameters.Add(new SqlParameter("@CategoryLv2ID", SqlDbType.Int));

        cmd.Parameters["@NewID"].Value = NewID;
        cmd.Parameters["@Name"].Value = Name;
        cmd.Parameters["@InitContent"].Value = InitContent;
        cmd.Parameters["@Content"].Value = Content;
        cmd.Parameters["@Images"].Value = Images;
        cmd.Parameters["@CategoryLv2ID"].Value = CategoryLv2ID;

        int result = cmd.ExecuteNonQuery();
        CloseConnection();
        return result;
    }


}