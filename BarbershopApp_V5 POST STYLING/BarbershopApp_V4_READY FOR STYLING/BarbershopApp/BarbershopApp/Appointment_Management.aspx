<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Appointment_Management.aspx.cs" Inherits="Appointment_Management" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <link href="Styleesheets/Appt_MGMT_StyleSheet.css" rel="stylesheet" />
        <div>
            <div id="notebooks">
                <h1>Appointments</h1>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    SelectCommand="SELECT Appointment.AppointmentID, Customer.custFirstName, Customer.custLastName, Employee.empName, Appointment.DateTime, AppointmentDetail.appointmentDetails, Service.ServiceName FROM Service INNER JOIN AppointmentDetail ON Service.ServiceID = AppointmentDetail.ServiceID RIGHT OUTER JOIN Appointment INNER JOIN Customer ON Appointment.CustomerID = Customer.CustomerID INNER JOIN Employee ON Appointment.EmployeeID = Employee.EmployeeID ON AppointmentDetail.AppointmentID = Appointment.AppointmentID"
                    UpdateCommand="UPDATE [Appointment] SET [DateTime] = @DateTime"
                    DeleteCommand="DELETE FROM [Appointment] WHERE AppointmentID = @AppointmentID">
                    <DeleteParameters>
                        <asp:Parameter Name="AppointmentID" />
                    </DeleteParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="DateTime" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="209px" Width="322px" DataSourceID="SqlDataSource1" AllowPaging="True" PageSize="3" DataKeyNames="AppointmentID" AllowSorting="True" OnRowUpdated="GridView1_RowUpdated">
                    <Columns>
                        <asp:BoundField DataField="AppointmentID" HeaderText="Appointment ID" InsertVisible="False" ReadOnly="true" SortExpression="AppointmentID" />
                        <asp:BoundField DataField="custFirstName" ReadOnly="true" HeaderText="Customer First Name" SortExpression="custFirstName" />
                        <asp:BoundField DataField="custLastName" ReadOnly="true" HeaderText="Customer Last Name" SortExpression="custLastName" />
                        <asp:BoundField DataField="empName" ReadOnly="true" HeaderText="Barber Assigned" SortExpression="empName" />
                        <asp:BoundField DataField="DateTime" HeaderText="Time Booked" SortExpression="DateTime" />
                        <asp:BoundField DataField="serviceName" ReadOnly="true" HeaderText="Service" SortExpression="Service" />
                        <asp:BoundField DataField="appointmentDetails" ReadOnly="true" HeaderText="Appointment Details" SortExpression="appointmentDetails" />
                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
  
 <br />
                <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
 <br />
  <asp:Button ID="Button1" runat="server" PostBackUrl="~/Default.aspx" Text="Return Home" />
</div>
        </div>
    </form>
</body>
</html>
