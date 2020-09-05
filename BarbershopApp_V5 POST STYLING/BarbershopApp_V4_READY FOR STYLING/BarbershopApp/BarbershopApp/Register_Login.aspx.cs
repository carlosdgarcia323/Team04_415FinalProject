using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Homework_SemesterProj_Register_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //checks to see if the user is logged in so the app can hide the buttons 
        //and change the announcement upon load
        string userLoggedIn = getLoggedInUser();

        //if the user is logged in, hide buttons and inform them that they are 
        //already logged in!
        if (userLoggedIn != "")
        {
            btnLogin.Visible = false;
            btnRegister.Visible = false;
            lblAnnouncement.Text = "You are already logged in!";
        }
        //else, make the buttons visible and tell them to log in or register
        else
        {
            btnLogin.Visible = true;
            btnRegister.Visible = true;
            lblAnnouncement.Text = "Please login if you already have an account or register to create a new account";
        }

    }
    //this method retreives the logged in user, this value is used to control the display of the buttons
    //and label as mentioned above
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
}