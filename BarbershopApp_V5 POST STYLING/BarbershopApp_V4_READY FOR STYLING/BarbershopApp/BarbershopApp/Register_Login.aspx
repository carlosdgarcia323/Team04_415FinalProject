<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register_Login.aspx.cs" Inherits="Homework_SemesterProj_Register_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register/Login</title>
    <link href="Styleesheets/Register_Login_StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       
        <section>
             <h1>Login or Register</h1>
            <asp:Label ID="lblAnnouncement" runat="server" Text="Please login if you already have an account or register to create a new account"></asp:Label>

            <br />


            <asp:Button ID="btnLogin" runat="server" PostBackUrl="Login.aspx" Text="Login" />

            &nbsp &nbsp

            <asp:Button ID="btnRegister" runat="server" PostBackUrl="Register.aspx" Text="Register" />
            <br />
             <a href="Default.aspx">Return to Main Page</a>
        </section>
    </form>
</body>
</html>
