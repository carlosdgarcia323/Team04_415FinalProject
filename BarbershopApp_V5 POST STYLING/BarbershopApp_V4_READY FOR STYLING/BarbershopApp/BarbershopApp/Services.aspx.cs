using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Services : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //converts labels to the first services  and displays it

        Service services = getService();
        string serviceName = services.ServiceName;
        string servicePrice = (services.ServPrice);

        {
            lblBeardTrim.Text = serviceName; // places what is found in the query for the serviceName into the label
            lblBreadTrimPrice.Text = "$" + servicePrice.Remove(servicePrice.Length - 2, 2); // this is the label for price. Much did not change except for the servicePrice
        }

        Service services2 = getService2();   // calls the second method, most of the code is similar except this line had to be different
        string serviceName2 = services2.ServiceName; // in order to retrieve different data
        string servicePrice2 = services2.ServPrice;

        {

            lblHairDye.Text = serviceName2; // places what is found in the query for the serviceName2 into the label
            lblHairDyePrice.Text = "$" + servicePrice2.Remove(servicePrice2.Length - 2, 2);
        }

        Service services3 = getService3();
        string servicename3 = services3.ServiceName;
        string servicePrice3 = services3.ServPrice;
        {
            lblFade.Text = servicename3; // places what is found in the query for the serviceName3 into the label
            lblFadePrice.Text = "$" + servicePrice3.Remove(servicePrice3.Length - 2, 2);
        }

        Service services4 = getService4();
        string servicename4 = services4.ServiceName;
        string servicePrice4 = services4.ServPrice;
        {
            lblHaircut.Text = servicename4; // places what is found in the query for the serviceName 4into the label
            lblHaircutPrice.Text = "$" + servicePrice4.Remove(servicePrice4.Length - 2, 2); 
        }
        Service services5 = getService5();
        string servicename5 = services5.ServiceName;
        string servicePrice5 = services5.ServPrice;
        {
            lblTouchUp.Text = servicename5; // places what is found in the query for the serviceName5 into the label
            lblTouchUpPrice.Text = "$" + servicePrice5.Remove(servicePrice5.Length - 2, 2);
        }


    }
    //this method retrieves the name and the price for the service in the query. The query asks specifically for 
    // the service with the ID of 1 . It opens a connection to the database
    public Service getService()
    {
        Service serviceID = new Service();
        string connectionString =
       "Data Source=(LocalDB)\\MSSQLLocalDB;" +
       "Integrated Security=True;" +
       "AttachDbFilename=|DataDirectory|\\BarberBooks.mdf";
        using (SqlConnection myConnection = new SqlConnection(connectionString))
        {
            string oString = "Select * from Service WHERE ServiceID = '1'  ";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            myConnection.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    serviceID.ServiceName = oReader["ServiceName"].ToString(); //looks for servicename column
                    serviceID.ServPrice = oReader["ServPrice"].ToString();      //looks for service price column
                }

                myConnection.Close();
            }
        }
        return serviceID;
    }

    //this method retrieves the name and the price for the service in the query. The query asks specifically for 
    // the service with the ID of 2 . It opens a connection to the database

    public Service getService2() //this is the second method. We used different methods although there were other perhaps
                                 //more difficult way to do this
    {
        Service serviceID2 = new Service();
        string connectionString =
       "Data Source=(LocalDB)\\MSSQLLocalDB;" +
       "Integrated Security=True;" +
       "AttachDbFilename=|DataDirectory|\\BarberBooks.mdf";
        using (SqlConnection myConnection = new SqlConnection(connectionString))
        {
            string oString = "Select * from Service WHERE ServiceID = '2'  ";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            myConnection.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    serviceID2.ServiceName = oReader["ServiceName"].ToString();
                    serviceID2.ServPrice = oReader["ServPrice"].ToString();
                }

                myConnection.Close();
            }
        }
        return serviceID2;
    }
    //this method retrieves the name and the price for the service in the query. The query asks specifically for 
    // the service with the ID of 3 . It opens a connection to the database

    public Service getService3()
    {
        Service serviceID3 = new Service(); // for the most part the code for methods are similar except for for these lines
        string connectionString =
       "Data Source=(LocalDB)\\MSSQLLocalDB;" +
       "Integrated Security=True;" +
       "AttachDbFilename=|DataDirectory|\\BarberBooks.mdf";
        using (SqlConnection myConnection = new SqlConnection(connectionString))
        {
            string oString = "Select * from Service WHERE ServiceID = '3'  ";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            myConnection.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    serviceID3.ServiceName = oReader["ServiceName"].ToString(); //this line and below look for the column name
                    serviceID3.ServPrice = oReader["ServPrice"].ToString();
                }

                myConnection.Close();
            }
        }
        return serviceID3;


    }
    //this method retrieves the name and the price for the service in the query. The query asks specifically for 
    // the service with the ID of 4 . It opens a connection to the database
    public Service getService4()
    {
        Service serviceID4 = new Service();
        string connectionString =
       "Data Source=(LocalDB)\\MSSQLLocalDB;" +
       "Integrated Security=True;" +
       "AttachDbFilename=|DataDirectory|\\BarberBooks.mdf";
        using (SqlConnection myConnection = new SqlConnection(connectionString))
        {
            string oString = "Select * from Service WHERE ServiceID = '4'  ";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            myConnection.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    serviceID4.ServiceName = oReader["ServiceName"].ToString();
                    serviceID4.ServPrice = oReader["ServPrice"].ToString();
                }

                myConnection.Close();
            }
        }
        return serviceID4;


    }
    //this method retrieves the name and the price for the service in the query. The query asks specifically for 
    // the service with the ID of 5 . It opens a connection to the database
    public Service getService5()
    {
        Service serviceID5 = new Service();
        string connectionString =
       "Data Source=(LocalDB)\\MSSQLLocalDB;" +
       "Integrated Security=True;" +
       "AttachDbFilename=|DataDirectory|\\BarberBooks.mdf";
        using (SqlConnection myConnection = new SqlConnection(connectionString))
        {
            string oString = "Select * from Service WHERE ServiceID = '5'  ";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            myConnection.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    serviceID5.ServiceName = oReader["ServiceName"].ToString();
                    serviceID5.ServPrice = oReader["ServPrice"].ToString();
                }

                myConnection.Close();
            }
        }
        return serviceID5;


    }
}
