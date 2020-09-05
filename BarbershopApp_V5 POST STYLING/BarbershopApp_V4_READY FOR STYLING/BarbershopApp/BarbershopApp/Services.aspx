<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Services.aspx.cs" Inherits="Services" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <link href="Styleesheets/Services_StyleSheet.css" rel="stylesheet" />
        <div id="HeaderLogo">
            <a id="return" href="Default.aspx">Return Home</a>
        </div>
         <div id="section">
             <br />
             <h1>Our Services:</h1>
             <ul>
                 <li>
                 <br />
             <img class="service" src="images/fade_model.jpg" />
                 <br />
                 <p><asp:Label ID="lblBeardTrim" runat="server" Text=""></asp:Label></p>
                <p><asp:Label ID="lblBreadTrimPrice" runat="server" Text=""></asp:Label></p>
                 </li>
                  <li>
                   <br />

               <img class="service" src="images/color_model.jpg" />


                 <br />

                <p><asp:Label ID="lblHairDye" runat="server" Text=""></asp:Label></p>
             <p><asp:Label ID="lblHairDyePrice" runat="server" Text=""></asp:Label></p>
                    </li>
                  <li>
                   <br />

             <img class="service" src="images/fadecut.jpg" />

                 <br />

                <p><asp:Label ID="lblFade" runat="server" Text=""></asp:Label></p>
             <p><asp:Label ID="lblFadePrice" runat="server" Text=""></asp:Label></p>
                 </li>
                  <li>
                   <br />
             <img class="service" src="images/haircut.jpg" />
             <br />

             <p><asp:Label ID="lblHaircut" runat="server" Text=""></asp:Label></p>
             <p><asp:Label ID="lblHaircutPrice" runat="server" Text=""></asp:Label></p>
                     </li>
                  <li>
             <br />
             <img class="service" src="images/touchup.jpg" />
             <br />

             <p><asp:Label ID="lblTouchUp" runat="server" Text=""></asp:Label></p>
             <p><asp:Label ID="lblTouchUpPrice" runat="server" Text=""></asp:Label></p>
                       </li>
                 </ul>
             </div>
    </form>
</body>
</html>
