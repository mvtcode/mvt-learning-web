using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Login : System.Web.UI.Page
{
    SqlConnection sqlConnection;
    protected void Page_Load(object sender, EventArgs e)
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

    public int[] checkLogin(string Username, string Password)
    {
        int[] i = new int[2];

        OpenConnection();
        try
        {
            SqlCommand cmd = new SqlCommand("Select Count(*) from Users Where Username=@Username And Password=@Password ", sqlConnection);
            cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar));
            cmd.Parameters["@Username"].Value = Username;
            cmd.Parameters["@Password"].Value = Password;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {

                i[0] = sqlDataReader.GetInt32(0);
                //i[1]= (int)sqlDataReader[1];
            }
            return i;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
            //return -1;

        }
        CloseConnection();
    }

    protected void lbtLogin_Click(object sender, EventArgs e)
    {
        Session["Username"] = "";
        string Username = txtAccount.Text;
        string Password = txtPassword.Text;
        int[] i = new int[2];
        i = checkLogin(Username, Password);
        if (i[0] > 0)
        {

            Session["Username"] = Username;
            Response.Redirect("~/Default.aspx");
        }
        else
        {
            lblWarning.Visible = true;
        }
    }
}