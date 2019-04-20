<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bookingcomplete.aspx.cs" Inherits="OnlineMovies.bookingcomplete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Ticket Information</h4>
    
    <table class="nav-justified">
        <tr>
            <td class="text-center">Name:</td>
            <td><asp:Label ID="Label1" runat="server" ></asp:Label></td>
        </tr>
        <tr>
            <td class="text-center">Mobile Number:</td>
            <td><asp:Label ID="Label2" runat="server" ></asp:Label></td>
        </tr>
        <tr>
            <td class="text-center">Movie Name</td>
            <td><asp:Label ID="Label3" runat="server" ></asp:Label></td>
        </tr>
        <tr>
            <td class="text-center">Seat Numbers:</td>
            <td><asp:Label ID="Label4" runat="server" ></asp:Label></td>
        </tr>
    </table>
    
</asp:Content>
