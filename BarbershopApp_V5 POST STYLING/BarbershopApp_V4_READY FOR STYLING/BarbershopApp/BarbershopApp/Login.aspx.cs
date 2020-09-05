using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Homework_SemesterProj_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }

    //calls the method to begin the process of logging in
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        getLoggedInUser(txtEmail.Text);
    }
    //method to allow the user to login using email
    //checks to see if the email is in database, shows a error message if not found
    public void getLoggedInUser(string email)
    {
        bool found = false;
        string connectionString =
       "Data Source=(LocalDB)\\MSSQLLocalDB;" +
       "Integrated Security=True;" +
       "AttachDbFilename=|DataDirectory|\\BarberBooks.mdf";
        String userLoggedIn = "";
        using (SqlConnection myConnection = new SqlConnection(connectionString))
        {
            string oString = "Select * from Customer where custEmailAddress='" 
                +email + "'";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            myConnection.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    found = true;
                    SqlConnection myConnection2 = new SqlConnection(connectionString);
                    myConnection2.Open();
                    //opens the connection again and then tries to check the password
                    string passwordCheckQuery = "select custPassword from Customer where custEmailAddress='" + txtEmail.Text + "'";
                    SqlCommand passComm = new SqlCommand(passwordCheckQuery, myConnection2);

                    //removes spaces to make sure the password is checked correctly
                    string password = passComm.ExecuteScalar().ToString().Replace(" ", "");

                    //if the entries were not valid, this error is thrown, otherwise, the customer returns to default.aspx
                    if (password != txtPassword.Text)
                    {
                        lblErrorMessage.Text = "Invalid Login Credentials. Please try another email/password.";
                    }
                    else
                    {
                        LogOutAll();
                        logUserIn(email);
                        userLoggedIn = oReader["custFirstName"].ToString();
                        Response.Redirect("Default.aspx");
                    }
                    myConnection2.Close();
                }
                
                myConnection.Close();
            }
        }
    }

    //method to Login the user
    protected void logUserIn(string email)
    {
        string connetionString = null;
        string sql = null;
        connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BarberBooks.mdf;Integrated Security=True";
        using (SqlConnection cnn = new SqlConnection(connetionString))
        {
            sql = "update Customer set isLoggedIn = 'T'" +
                " where custEmailAddress = '" + email + "'";

            cnn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.ExecuteNonQuery();
            }
        }


    }
    //Log out users
    protected void LogOutAll()
    {
        string connetionString = null;
        string sql = null;
        connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BarberBooks.mdf;Integrated Security=True";
        using (SqlConnection cnn = new SqlConnection(connetionString))
        {
            sql = "update Customer set isLoggedIn = 'F'";

            cnn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.ExecuteNonQuery();
            }
        }


    }
}