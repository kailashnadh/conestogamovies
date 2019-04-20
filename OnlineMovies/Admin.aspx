<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="OnlineMovies.Admin" %>
<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - My ASP.NET Application</title>

    <link href="Content/home.css" rel="stylesheet" />

    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

</head>
<body>
    <div class="jumbotron jumbotron-fluid">
        <div class="auto-style6">
            <h1 class="display-3">CONESTOGA MOVIES</h1>
            <p class="lead">Book Movies Online</p>
        </div>
    </div>
    <form id="form1" runat="server" class="form-horizontal">
          
        <div>
            <h4>Ticket Information</h4>
    <div class="row">
        <div class="col-md-12">
            <div class="col-md-9">

            </div>
            <div class="col-md-3">
                <asp:Button ID="Button1" runat="server" cssclass="button" Text="Logout" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
   
     <table class="nav-justified">
         <tr>
             <td class="text-center">Movie Name</td>
             <td>Total Seats</td>
             <td>Available Seats</td>
             <td>Booked Seats</td>
         </tr>
         <tr>
             <td class="text-center">Batman</td>
             <td><asp:Label ID="Label1" runat="server" Text="16"></asp:Label></td>
             <td><asp:Label ID="Label2" runat="server"></asp:Label></td>
             <td><asp:Label ID="Label3" runat="server"></asp:Label></td>
         </tr>
         <tr>
             <td class="text-center">Aquaman</td>
             <td><asp:Label ID="Label4" runat="server" Text="16"></asp:Label></td>
             <td><asp:Label ID="Label5" runat="server"></asp:Label></td>
             <td><asp:Label ID="Label6" runat="server"></asp:Label></td>
         </tr>
         <tr>
             <td class="text-center">GOT</td>
             <td><asp:Label ID="Label7" runat="server" Text="16"></asp:Label></td>
             <td><asp:Label ID="Label8" runat="server"></asp:Label></td>
             <td><asp:Label ID="Label9" runat="server"></asp:Label></td>
         </tr>
         <tr>
             <td class="text-center">Captain</td>
             <td><asp:Label ID="Label10" runat="server" Text="16"></asp:Label></td>
             <td><asp:Label ID="Label11" runat="server"></asp:Label></td>
             <td><asp:Label ID="Label12" runat="server"></asp:Label></td>
         </tr>
         <tr>
             <td class="text-center">WonderWoman</td>
             <td><asp:Label ID="Label13" runat="server" Text="16"></asp:Label></td>
             <td><asp:Label ID="Label14" runat="server"></asp:Label></td>
             <td><asp:Label ID="Label15" runat="server"></asp:Label></td>
         </tr>
         <tr>
             <td class="text-center">Marvel</td>
             <td><asp:Label ID="Label16" runat="server" Text="16"></asp:Label></td>
             <td><asp:Label ID="Label17" runat="server"></asp:Label></td>
             <td><asp:Label ID="Label18" runat="server"></asp:Label></td>
         </tr>
     </table>
        </div>
         <div class="modal-footer">
             <p>To contact us call us at 800-555-0400 or mail us at <a href = "mailto:sportspro@sportsprosoftware.com">sportspro@sportsprosoftware.com</a></p>
        </div>
    </form>
</body>
</html>







