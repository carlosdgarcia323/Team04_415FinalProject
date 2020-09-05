<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Employee_Login.aspx.cs" Inherits="Employee_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="border: 2px solid red; display: inline-block; padding: 5px;">
            <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <asp:Label ID="lblErrorUserName" ForeColor="Red" runat="server" Text=""></asp:Label>
            <br />
             <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="lblErrorPassword" ForeColor="Red" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Log In" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
