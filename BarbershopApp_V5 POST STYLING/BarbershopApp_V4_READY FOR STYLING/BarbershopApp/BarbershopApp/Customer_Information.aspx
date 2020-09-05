
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customer_Information.aspx.cs" Inherits="Customer_Information" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styleesheets/Appointment_StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="page">
        <h1>Customer Information</h1>
            <p>Please fill out all fields to book your appointment.</p>
            <p id="message">*You must be logged in to book an appointment.</p>
            &nbsp
            <table>

            <tr>
                <td><asp:Label ID="lblFName" runat="server" Text="First Name:"></asp:Label></td>
                <td><asp:TextBox ID="txtFName" runat="server" ReadOnly="True"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFName" ForeColor="Red" ErrorMessage="Required Field!"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                <td><asp:Label ID="lblLName" runat="server" Text="Last Name:"></asp:Label></td>
                <td><asp:TextBox ID="txtLName" runat="server" ReadOnly="True"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLName" ForeColor="Red" ErrorMessage="Required Field!"></asp:RequiredFieldValidator></td>

            </tr>

                <tr>
                    <td><asp:Label ID="lblPhone" runat="server" Text="Phone Number: (XXX-XXX-XXXX)"></asp:Label></td>
                    <td><asp:TextBox ID="txtPhone" runat="server" ReadOnly="True"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPhone" ForeColor="Red" ErrorMessage="Required Field!"></asp:RequiredFieldValidator></td>
                </tr>
            

                </table>
        <table>
            <tr>
                <td><h3>Services</h3></td>
            </tr>
            <tr><td>
                <asp:RadioButtonList ID="rdoServices" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True">Beard Trim</asp:ListItem>
                    <asp:ListItem>Hair Dye</asp:ListItem>
                    <asp:ListItem>Fading</asp:ListItem>
                    <asp:ListItem>Hair Cut</asp:ListItem>
                     <asp:ListItem>Touch up</asp:ListItem>
                </asp:RadioButtonList>
                </td>
                </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAppointmentDetails" runat="server" Text="Appointment Details: "></asp:Label>
                    <asp:TextBox ID="txtAppointmentDetails" runat="server" Height="84px" TextMode="MultiLine" Width="319px"></asp:TextBox>

                </td>
            </tr>
            <tr>
              <td> <asp:Calendar ID="calDatePicker"  SelectedDate="<%# DateTime.Today %>"   runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px" OnSelectionChanged="calDatePicker_SelectionChanged">
                  <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                  <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                  <OtherMonthDayStyle ForeColor="#999999" />
                  <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                  <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                  <TodayDayStyle BackColor="#CCCCCC" />
                  </asp:Calendar>
              </td>
                </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="Red" ControlToValidate="txtDate" runat="server" ErrorMessage="Please select a date from the calender!"></asp:RequiredFieldValidator>
                </td>
             </tr>
            <tr>
                <td>
                    <asp:Label ID="lblFriendlyMessage" ForeColor="Red" Visible="false" runat="server" Text="^ Don't forget to pick your time as well!"></asp:Label>
                </td>
            </tr>
            &nbsp
            <tr>
                <td><br /><h3>Barbers</h3></td>
            </tr>
            <tr>
                <td><asp:DropDownList ID="ddlBarbers" runat="server">
                    <asp:ListItem Value= "0" Selected="True" >Select your barber...</asp:ListItem>
                    <asp:ListItem Value="Farrukh Botirzoda">Farrukh Botirzoda</asp:ListItem>
                    <asp:ListItem Value="James Mobley">James Mobley</asp:ListItem>
                    <asp:ListItem Value="Carlos Garcia">Carlos Garcia</asp:ListItem>

                     </asp:DropDownList><asp:CompareValidator ControlToValidate="ddlBarbers" 
                         ID="CompareValidator1" ErrorMessage="Please select a Barber!"
                        runat="server" Display="Dynamic" 
                        Operator="NotEqual" ValueToCompare="0" ForeColor="Red"></asp:CompareValidator></td>
            </tr>
            </table>
            <table>
            <tr>
               <td><img src="images/barber1.jpg"  height="150"; width="200";/></td>
               <td><img src="images/barber2.jpg" height="150"; width="200";/></td>
               <td><img src="images/barber3.jpg" height="150"; width="200";/></td>
            </tr>
            <tr id="barbers">
                <th>Carlos</th>
                <th>Farrukh</th>
                <th>James</th>
            </tr>
        </table>
        <br />
            <div id="buttons">
        <asp:Button Width="100px" Height="30px" ID="Button2" runat="server" CausesValidation="true" Text="Confirm" OnClick="Button2_Click" />   &nbsp
        <asp:Button Width="100px" Height="30px" ID="Button1" runat="server" CausesValidation="false" PostBackUrl="~/Default.aspx" Text="Return Home" />
                </div>
        </div>
    </form>
</body>
</html>
