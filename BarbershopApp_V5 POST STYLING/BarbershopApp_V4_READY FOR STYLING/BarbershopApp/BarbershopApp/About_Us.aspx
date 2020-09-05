<%@ Page Language="C#" AutoEventWireup="true" CodeFile="About_Us.aspx.cs" Inherits="About_Us" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <link href="Styleesheets/AboutUs_StyleSheet.css" rel="stylesheet" />
        <div>
            <div id="HeaderLogo">
            <a id="return" href="Default.aspx">Return Home</a>
            </div>
            <div id="header">
                <br />
                <br /> <br />
                <h1 id="aboutUs">About Us</h1>  
                <p>Elite Aggie Cuts is a premier barbershop that has been providing quality<br />
                    Service since 2018. We are a local aggie owned and operated barbershop.<br />
                    We provide a multitude of services ranging from simple cuts to complex<br />
                    hair coloring services. Please feel free to come before an interview,<br />
                    birthday prom. Whatever your needs may be we got you covered. We strive<br />
                    to provide superior customer service while providing fast and convinient<br />
                    hair services. We take pride in our excellence of staff ranging with<br />
                    experience. Our barbers are licensed professionals in the state of <br />
                    Texas and are ready at your service. Please read up on our staff and<br />
                    their information provided below<br />
                    <br />
                   <strong> -Elite Aggie Cuts</strong>
                </p>
                <img id="intro" src="images/haircut2.jpg" />

            </div>
            <div id="section"> <br />
                <h1>Meet Our Barbers:</h1>
                 <br />
                <ul>
               <li> <img class="barber" src="images/barber1.jpg" /><br />
                <asp:Label ID="lblCarlos" runat="server" Text="Label"></asp:Label><br />
                <asp:Label ID="lblCarlosHometown" runat="server" Text="Label"></asp:Label><br />
                <asp:Label ID="lblCarlosStartDate" runat="server" Text="Label"></asp:Label><br />
                </li>
                    <li>
                <img class="barber" src="images/barber2.jpg" /><br />
                 
              <asp:Label ID="lblFarrukh" runat="server" Text="Label"></asp:Label><br />
                <asp:Label ID="lblFarrukhHometown" runat="server" Text="Label"></asp:Label><br />
                <asp:Label ID="lblFarrukhStartDate" runat="server" Text="Label"></asp:Label><br />
                   </li>
                     <li>
                <img class="barber" src="images/barber3.jpg" /><br />
                
               <asp:Label ID="lblJames" runat="server" Text="Label"></asp:Label><br />
                <asp:Label ID="lblJamesHometown" runat="server" Text="Label"></asp:Label><br />
                <asp:Label ID="lblJamesStartDate" runat="server" Text="Label"></asp:Label><br />
                    </li>
</ul>

            </div>
        </div>
    </form>
</body>
</html>
