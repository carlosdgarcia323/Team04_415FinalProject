using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Customer_Information : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        //gathering information from database when user logs in and pre-populating
        //their information on the appointment page
        Customer customer1 = getLoggedInUser();
        string firstName = customer1.custFirstName;
        string lastName = customer1.custLastName;
        string phone = customer1.custPhoneNumber;
        if (firstName != null)
        {
            txtFName.Text = firstName;
            txtLName.Text = lastName;
            txtPhone.Text = phone;
        }
    }



    //this method inserts appointment information into Appointment table
    protected void SaveAppointment(int CustomerID, DateTime Date, string EmployeeID)
    {
            
            string connetionString = null;
            string sql = null;
            connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BarberBooks.mdf;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                sql = "insert into Appointment ([CustomerID]," +
                      "[DateTime], [EmployeeID])" +
                      " values(@CustomerID, @Date," +
                      "@EmployeeID)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    cmd.ExecuteNonQuery();
                }
                cnn.Close();
            }
        
    }


    //this method inserts appointment details into the associative entity
    //AppointmentDetail
    protected void SaveAppointmentDetails(string ServiceID, string AppointmentID, string AppointmentDetails)
    {

        string connetionString = null;
        string sql = null;
        connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BarberBooks.mdf;Integrated Security=True";
        using (SqlConnection cnn = new SqlConnection(connetionString))
        {
            sql = "insert into AppointmentDetail ([ServiceID]," +
                  "[AppointmentID], [appointmentDetails])" +
                  " values(@ServiceID, @AppointmentID," +
                  "@appointmentDetails)";
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@ServiceID", ServiceID);
                cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                cmd.Parameters.AddWithValue("@appointmentDetails", AppointmentDetails);
                cmd.ExecuteNonQuery();
            }
            cnn.Close();

            Response.Redirect("Confirm_Appointment.aspx");
        }

    }










    //this method retrieves the the User that is logged in and their information
    public Customer getLoggedInUser()
    {
        Customer customer1 = new Customer();
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
                  customer1.custFirstName  = oReader["custFirstName"].ToString();
                  customer1.custLastName  = oReader["custLastName"].ToString();
                  customer1.custPhoneNumber  = oReader["custPhoneNumber"].ToString();
                  customer1.CustomerID = Convert.ToInt32(oReader["CustomerID"]);
                }

                myConnection.Close();
            }
        }
        return customer1;
    }


    protected void Button2_Click(object sender, EventArgs e)
    { //before making the appointment the the described methods above are called and their
        //values are stored in  variable
        Customer customer2 = getLoggedInUser();
        string serviceid = getServiveID(rdoServices.SelectedValue);
        string employeeid = getBarberID(ddlBarbers.SelectedValue);
        DateTime apptDate = Convert.ToDateTime(txtDate.Text);
        SaveAppointment(customer2.CustomerID, apptDate, employeeid);
        string AppointmentID = getAppointmentID();
        string AppointmentDetails = txtAppointmentDetails.Text;
        SaveAppointmentDetails(serviceid, AppointmentID, AppointmentDetails);

    }
    //This method retrieves ServiceID based on selected service by the user
    //this value is later used to make an appointment
    public string getServiveID(string serviceName)
    {
        string connectionString =
       "Data Source=(LocalDB)\\MSSQLLocalDB;" +
       "Integrated Security=True;" +
       "AttachDbFilename=|DataDirectory|\\BarberBooks.mdf";
        using (SqlConnection myConnection = new SqlConnection(connectionString))
        {
            string oString = "Select * from Service where ServiceName='"+ serviceName + "'";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            myConnection.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                   return oReader["ServiceID"].ToString();
                }

                myConnection.Close();
            }
        }
        return "";
    }
    //this method retreieves BarberID based on selected barber name
    //this value is later used to make an appointment
    public string getBarberID(string barberName)
    {
        string connectionString =
       "Data Source=(LocalDB)\\MSSQLLocalDB;" +
       "Integrated Security=True;" +
       "AttachDbFilename=|DataDirectory|\\BarberBooks.mdf";
        using (SqlConnection myConnection = new SqlConnection(connectionString))
        {
            string oString = "Select * from Employee where empName='" + barberName + "'";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            myConnection.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    return oReader["EmployeeID"].ToString();
                }

                myConnection.Close();
            }
        }
        return "";
    }
    //retreieves AppointmentID of the most recent appointment, to be populatedin
    //the associative table AppointmentDetail
    public string getAppointmentID()
    {
        string connectionString =
       "Data Source=(LocalDB)\\MSSQLLocalDB;" +
       "Integrated Security=True;" +
       "AttachDbFilename=|DataDirectory|\\BarberBooks.mdf";
        using (SqlConnection myConnection = new SqlConnection(connectionString))
        {
            string oString = "Select TOP 1 * FROM dbo.Appointment  ORDER BY AppointmentID DESC;";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            myConnection.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    return oReader["AppointmentID"].ToString();
                }

                myConnection.Close();
            }
        }
        return "";
    }

    protected void calDatePicker_SelectionChanged(object sender, EventArgs e)
    {
        txtDate.Text = calDatePicker.SelectedDate.ToString();
        lblFriendlyMessage.Visible = true;
    }
}