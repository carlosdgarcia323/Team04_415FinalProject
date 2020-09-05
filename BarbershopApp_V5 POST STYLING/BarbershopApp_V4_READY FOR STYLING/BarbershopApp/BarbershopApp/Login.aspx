<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Homework_SemesterProj_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
    <link href="Styleesheets/Login_StyleSheet.css" rel="stylesheet" />
</head>
   
<body>
     <div id="page">
    <form id="form1" runat="server">
        
        <div id="login">
             <section>
     <h1>Login</h1>
       

            <p> Please use your credentials to login to your account.
            </p>

            <br />

            <asp:Label ID="lblErrorMessage" runat="server" Text=""></asp:Label>
            <table>

                <tr>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text="Email Address: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                     <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtEmail" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>

                    <td>
                        <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                     <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtPassword" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                   
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    </td>
                </tr>


            </table>
             <a href="Default.aspx">Return to Main Page</a><br />
        </section>
            </div>
    </form>
         </div>>
</body>
</html>
