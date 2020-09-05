<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Homework_SemesterProj_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styleesheets/Register_Stylesheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
          <section>
      <h1>Register</h1>
      

            <p>Please fill out all of the required fields to create an account.
            </p>

            <br />

            <table>

                <tr>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text="Email Address: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                            ControlToValidate="txtEmail" 
                            runat="server" 
                            Display="Dynamic"
                            ErrorMessage="Required">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator 
                        ID="RegularExpressionValidator1"
                        ControlToValidate="txtEmail" 
                        runat="server" 
                        Display="Dynamic"
                        ErrorMessage="Email must be valid."
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                    </asp:RegularExpressionValidator>
                        
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblConfirmEmail" runat="server" Text="Confirm Email Address: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtConfirmEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                            ControlToValidate="txtConfirmEmail" 
                            runat="server" 
                            ErrorMessage="Required"
                            Display="Dynamic">
                        </asp:RequiredFieldValidator>
                          <asp:CompareValidator 
                        ID="CompareValidator1"
                        ControlToCompare="txtEmail" 
                        ControlToValidate="txtConfirmEmail" 
                        runat="server" 
                        ErrorMessage="Emails must match."></asp:CompareValidator>
                    </td>
                </tr>

                <tr>

                    <td>
                        <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </td>
                       <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                            ControlToValidate="txtPassword"
                            runat="server" 
                            ErrorMessage="Required">
                        </asp:RequiredFieldValidator>
                    </td>
                   
                </tr>

                <tr>

                    <td>
                        <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
                    </td>
                      <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                            display="Dynamic"
                            ControlToValidate="txtConfirmPassword" 
                            runat="server" 
                            ErrorMessage="Required">
                        </asp:RequiredFieldValidator>
                           <asp:CompareValidator 
                        ID="CompareValidator2"
                        ControlToCompare="txtPassword" 
                        ControlToValidate="txtConfirmPassword" 
                        runat="server" 
                        Display="Dynamic"
                        ErrorMessage="Password must match."></asp:CompareValidator>
                    </td>
                   
                </tr>

                <tr>

                    <td>
                        <asp:Label ID="lblFirstName" runat="server" Text="First Name: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </td>
                     <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtFirstName" runat="server" ErrorMessage="Required">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>

                    <td>
                        <asp:Label ID="lblLastName" runat="server" Text="Last Name: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    </td>
                     <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="txtLastName" runat="server" ErrorMessage="Required">
                        </asp:RequiredFieldValidator>
                    </td>
                   
                </tr>

                <tr>

                    <td>
                        <asp:Label ID="lblStreet" runat="server" Text="Street Address: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
                    </td>
                      <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="txtStreet" runat="server" ErrorMessage="Required">
                        </asp:RequiredFieldValidator>
                    </td>
                   
                </tr>

                <tr>

                    <td>
                        <asp:Label ID="lblCity" runat="server" Text="City: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="txtCity" runat="server" ErrorMessage="Required">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>

                    <td>
                        <asp:Label ID="lblState" runat="server" Text="State: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
                    </td>
                     <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ControlToValidate="txtState" runat="server" ErrorMessage="Required">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>

                    <td>
                        <asp:Label ID="lblZip" runat="server" Text="Zip: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
                    </td>
                      <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" ControlToValidate="txtZip" runat="server" ErrorMessage="Required">
                        </asp:RequiredFieldValidator>
                          <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ValidationExpression="\d{5}(-\d{4})?" runat="server" ControlToValidate="txtZip" ErrorMessage="Format:XXXXX"></asp:RegularExpressionValidator>
                    </td>
                </tr>

                <tr>

                    <td>
                        <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
                    </td>
                       <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" 
                            ControlToValidate="txtPhoneNumber" 
                            runat="server" 
                            Display="Dynamic"
                            ErrorMessage="Required">
                        </asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator 
                        ID="RegularExpressionValidator2"
                        ControlToValidate="txtPhoneNumber" 
                        runat="server" 
                        Display="Dynamic"
                        ErrorMessage="Must be in 999-999-9999 format." ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"
                       ></asp:RegularExpressionValidator>
                    </td>
                </tr>

                <tr>
                    <td>
                        <br />
                        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
                        <br />  <asp:Label ID="lblValidationMessage" runat="server" Text=""></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td>  <a href="Default.aspx">Return to Main Page</a></td>
                </tr>
              
            </table>
        </section>
               
    </form>
</body>
</html>
