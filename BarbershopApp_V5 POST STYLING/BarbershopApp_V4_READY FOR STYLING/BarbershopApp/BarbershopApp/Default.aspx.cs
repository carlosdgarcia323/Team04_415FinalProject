using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //checks to see if the user is logged in so the app can display their name on the top
        //right of the screen i.e. Welcome, James
        string userLoggedIn = getLoggedInUser();

        if (userLoggedIn != "")
        {
            lblCustomerLogin.Text = "Welcome, " + userLoggedIn + "!";
            btnLogout.Visible = true;
        }

    }
    //this method retreives the loged in user, this value is used to display their name on 
    //home page as mentioned above
 public string getLoggedInUser()
    {
         string connectionString =
        "Data Source=(LocalDB)\\MSSQLLocalDB;" +
        "Integrated Security=True;" +
        "AttachDbFilename=|DataDirectory|\\BarberBooks.mdf";
        String userLoggedIn = "";
        using (SqlConnection myConnection = new SqlConnection(connectionString))
        {
            string oString = "Select * from Customer where isLoggedIn='T'";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            myConnection.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    userLoggedIn = oReader["custFirstName"].ToString();
                }

                myConnection.Close();
            }
        }
        return userLoggedIn;
    }

    //Method to log out all users
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
    //Button to log out that calls the method to logout, the method stores the logic, 
    //the button calls the logic to be executed.
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        lblCustomerLogin.Text = "Customer Login";
        LogOutAll();
        btnLogout.Visible = false;
    }
}