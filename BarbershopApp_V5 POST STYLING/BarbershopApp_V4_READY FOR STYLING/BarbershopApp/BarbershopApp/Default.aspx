<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <link href="Styleesheets/Default_StyleSheet.css" rel="stylesheet" />
    <form id="form1" runat="server">
      <div id="page">
        <div id="header">
            <a href="Register_Login.aspx"><asp:Label ID="lblCustomerLogin" runat="server" Text="Customer Login"></asp:Label></a> <br />
            <asp:Button ID="btnLogout" runat="server" Text="Logout" Visible="false" OnClick="btnLogout_Click" />

            <img src="images/logo.jpg" />
        </div>

        <div id="nav">
             <ul>
      <li><a href="#">Home</a></li>
      <li><a href="About_Us.aspx">About Us</a></li>
      <li><a href="Services.aspx">Services</a></li>
      <li><a href="Employee_Login.aspx">Employee Login</a></li>
    </ul>
        </div>

        <div id="section">
          <a id="btnAppt" href="Customer_Information.aspx" class="appt">Make Appointment</a>
        </div>

          <div id="section2">
         
        </div>
        <div id="footer">
            <br />
            <br />
          <hr />
            <ul>
                <li><h1>Legal</h1><br /> 
            <p> Aggie Elite Cuts™ <br /><br />  All rights reserved.</p></li>

                  <li><h1>Location</h1><br /> 
            <p> 234 George Bush Dr. <br /><br />  College Station, TX<br /> <br /> 77840</p></li>

                  <li><h1>Contact Us:</h1><br /> 
            <p> Email: AggieEliteCuts@barber.com <br /> <br /> Phone: (979)-243-2352<br /> <br /> Fax: (979)-243-3521</p></li>
            </ul>
        </div>
          </div>
    </form>
</body>
</html>
