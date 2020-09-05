using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Employee_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //Upon button click, there is a validation check to see if the user is an employee.
    //the username used for employees is "admin" and the password is "password." If 
    //successful, employee is taken to the appointment management screen.
    protected void Button1_Click(object sender, EventArgs e)
    {
        //erros are erased with every click to start off fresh
        lblErrorPassword.Text = "";
        lblErrorUserName.Text = "";

        //if "admin" is in the the username textbox, checks to see if "password" is typed
        //as the password in the password textbox
        if (txtUserName.Text == "admin")
        {
            if (txtPassword.Text == "password")
            {
                //if "admin" and "password" are both typed, employee is directed to the appointment
                //managment screen
                Response.Redirect("~/Appointment_Management.aspx");
            }
            else
            {
                //error displayed if the password is incorrect
                lblErrorPassword.Text = "Please enter the correct password.";
            }
        }
        else
        {
            //error displayed if the username is incorrect
            lblErrorUserName.Text = "Please enter the correct admin username.";

            //error displayed if the password is incorrect
            if (txtPassword.Text != "password")
            {
                lblErrorPassword.Text = "Please enter the correct password.";
            }
        }
    }
}