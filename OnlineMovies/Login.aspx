<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineMovies.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
    <table class="nav-justified">
        <tr>
            <td class="text-center"><asp:Label ID="Label1" runat="server" Text="Enter Your Name"></asp:Label></td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="text-center">  <asp:Label ID="Label2" runat="server" Text="Enter Your Password"></asp:Label></td>
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" class="text-center"> <asp:Label ID="Label3" runat="server" Text="Please Enter Valid Credential" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label></td>           
        </tr>
        <tr>
            <td class="text-center"><asp:Button ID="Button1" CssClass="button" runat="server" Text="Login" OnClick="Button1_Click"/></td>
            <td>&nbsp;</td>
        </tr>
    </table>
        
   
        
</asp:Content>
