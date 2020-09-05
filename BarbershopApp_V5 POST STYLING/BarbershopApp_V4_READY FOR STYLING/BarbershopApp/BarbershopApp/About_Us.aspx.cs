using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class About_Us : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //converts labels to the first barbers info and displays it
        Employee employee = GetEmployee1();
        DateTime date = Convert.ToDateTime(employee.empStartDate);
        string empName = employee.empName;
        string empCity = employee.empCity;
        string empStartDate = employee.empStartDate;

        lblCarlos.Text = "Name: " + empName;
        lblCarlosHometown.Text = "From: " + empCity;
        lblCarlosStartDate.Text = "Working Since: " + Convert.ToString(date.Year);

        //converts labels to the second barbers info and displays it

        Employee employee2 = GetEmployee2();
        DateTime date2 = Convert.ToDateTime(employee2.empStartDate);
        string empName2 = employee2.empName;
        string empCity2 = employee2.empCity;
        string empStartDate2 = employee2.empStartDate;

        lblFarrukh.Text = "Name: " + empName2;
        lblFarrukhHometown.Text = "From: " + empCity2;
        lblFarrukhStartDate.Text = "Working Since: " + Convert.ToString(date2.Year);

        //converts labels to the third barbers info and displays 
        Employee employee3 = GetEmployee3();
        DateTime date3 = Convert.ToDateTime(employee3.empStartDate);
        string empName3 = employee3.empName;
        string empCity3 = employee3.empCity;
        string empStartDate3 = employee3.empStartDate;

        lblJames.Text = "Name: " + empName3;
        lblJamesHometown.Text = "From: " + empCity3;
        lblJamesStartDate.Text = "Working Since: " + Convert.ToString(date3.Year);
    }
    //method to retrieve the first barbers information
    public Employee GetEmployee1()
    {
        Employee employee = new Employee();
        string connectionString =
       "Data Source=(LocalDB)\\MSSQLLocalDB;" +
       "Integrated Security=True;" +
       "AttachDbFilename=|DataDirectory|\\BarberBooks.mdf";
        using (SqlConnection myConnection = new SqlConnection(connectionString))
        {
            string oString = "Select * from Employee WHERE employeeID = '1' ";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            myConnection.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    employee.empName = oReader["empName"].ToString();
                    employee.empCity = oReader["empCity"].ToString();
                    employee.empStartDate = oReader["empStartDate"].ToString();
                }


                myConnection.Close();
            }
        }
        return employee;
    }
    //method to retrieve the seconds barbers information
    public Employee GetEmployee2()
    {
        Employee employee2 = new Employee();
        string connectionString =
       "Data Source=(LocalDB)\\MSSQLLocalDB;" +
       "Integrated Security=True;" +
       "AttachDbFilename=|DataDirectory|\\BarberBooks.mdf";
        using (SqlConnection myConnection = new SqlConnection(connectionString))
        {
            string oString = "Select * from Employee WHERE employeeID = '2'";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            myConnection.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    employee2.empName = oReader["empName"].ToString();
                    employee2.empCity = oReader["empCity"].ToString();
                    employee2.empStartDate = oReader["empStartDate"].ToString();
                }


                myConnection.Close();
            }
        }
        return employee2;
    }

    //method to retrieve the third barbers information
    public Employee GetEmployee3()
    {
        Employee employee3 = new Employee();
        string connectionString =
       "Data Source=(LocalDB)\\MSSQLLocalDB;" +
       "Integrated Security=True;" +
       "AttachDbFilename=|DataDirectory|\\BarberBooks.mdf";
        using (SqlConnection myConnection = new SqlConnection(connectionString))
        {
            string oString = "Select * from Employee where employeeID = '3'";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            myConnection.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    employee3.empName = oReader["empName"].ToString();
                    employee3.empCity = oReader["empCity"].ToString();
                    employee3.empStartDate = oReader["empStartDate"].ToString();
                }


                myConnection.Close();
            }
        }
        return employee3;
    }

}