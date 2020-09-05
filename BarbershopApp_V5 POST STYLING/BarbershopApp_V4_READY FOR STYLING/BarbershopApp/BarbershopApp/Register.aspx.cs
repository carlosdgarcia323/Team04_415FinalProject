using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Homework_SemesterProj_Register : System.Web.UI.Page
{
   public static string username = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

    }
    //registers user into database by collecting all pertinent information
    //parameters are used to capture information from textboxes
    //and store into database
    //as soon as user registers they are automatically loged in therefore before registering
    //the app makes sure any previous user is logged out for a new user to log in.
    //The logout method is declared at the very bottom of this code know as "updateUsers()"
    protected void btnRegister_Click(object sender, EventArgs e)
    { if (Page.IsValid)
        {
            updateUsers();
            string connetionString = null;
            string sql = null;
            connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BarberBooks.mdf;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                sql = "insert into Customer ([custAddress]," +
                      "[custCity], [custState] , [custZipCode], [custPhoneNumber]," +
                      "[custEmailAddress], [custPassword],[custFirstName], [custLastName]," +
                      "[isLoggedIn])" +
                      " values(@address, @city," +
                      "@state, @zip, @phone, @email, @password, @first, @last, @isloggedin)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@first", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@last", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@address", txtStreet.Text);
                    cmd.Parameters.AddWithValue("@city", txtCity.Text);
                    cmd.Parameters.AddWithValue("@state", txtState.Text);
                    cmd.Parameters.AddWithValue("@zip", txtZip.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@isloggedin", "T");
                    cmd.ExecuteNonQuery();
                }
                cnn.Close();
                lblValidationMessage.Text = "Account succesfully created!";
                Response.Redirect("Default.aspx");
            }
        }
    }

    //Logs out users before making a new account
    protected void updateUsers() {
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