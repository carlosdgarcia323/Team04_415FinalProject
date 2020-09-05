using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Appointment_Management : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        //removes errors after another page load
        lblError.Text = "";
    }

    //When the DateTime column for a row is updated, this method is called to see if an exception is thrown.
    //If an exception is thrown, then the database isn't updated, and user is shown error message.
    protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        //SQL error
        if (e.Exception != null)
        {
            lblError.Text = "A database error has occured. " + "Message: " + e.Exception.Message;
            e.ExceptionHandled = true;
            e.KeepInEditMode = true;
        }
        //Concurrency error
        else if (e.AffectedRows == 0)
        {
            lblError.Text = "Another user may have updated that category. " + "Please try again.";
        }
    }
}
