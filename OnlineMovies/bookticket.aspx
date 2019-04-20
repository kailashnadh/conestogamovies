<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bookticket.aspx.cs" Inherits="OnlineMovies.bookticket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [seats_available]"></asp:SqlDataSource>
        <div class="row">
            <div class="col-md-7">

                 <table class="nav-justified">
                    <tr>
                        <td class="text-center"><asp:Label ID="Label1" runat="server" Text="Enter Your Name"></asp:Label></td>
                        <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Name" Font-Bold="True" ValidationGroup="buttons" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="text-center">  <asp:Label ID="Label2" runat="server" Text="Enter Your Mobile Number"></asp:Label></td>
                        <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Phone Number" Font-Bold="True" ValidationGroup="buttons" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    </tr>
                   
                     <tr>
                         <td class="text-center"><asp:Button ID="Button17" CssClass="button" runat="server" Text="Book Ticket" OnClick="Button17_Click" ValidationGroup="buttons" /></td>
                     </tr>
                    
                </table>
            </div>
            <div class="col-sm-5">
                    
                <table border="1" class="nav-justified">
                    <tr>
                        <td class="text-center"><asp:Button ID="Button1" runat="server" Text="1" OnClick="Button1_Click1" /></td>                        
                        <td class="text-center"><asp:Button ID="Button2" runat="server" Text="2" OnClick="Button2_Click" /></td>
                        <td class="text-center"><asp:Button ID="Button3" runat="server" Text="3" OnClick="Button3_Click" /></td>
                        <td class="text-center"><asp:Button ID="Button4" runat="server" Text="4" OnClick="Button4_Click" /></td>
                    </tr>
                    <tr>
                        <td class="text-center"><asp:Button ID="Button5" runat="server" Text="5" OnClick="Button5_Click" /></td>
                        <td class="text-center"><asp:Button ID="Button6" runat="server" Text="6" OnClick="Button6_Click" /></td>
                        <td class="text-center"><asp:Button ID="Button7" runat="server" Text="7" OnClick="Button7_Click" Width="22px" /></td>
                        <td class="text-center"><asp:Button ID="Button8" runat="server" Text="8" OnClick="Button8_Click" Width="20px" /></td>
                    </tr>
                    <tr>
                        <td class="text-center"><asp:Button ID="Button9" runat="server" Text="9" OnClick="Button9_Click" /></td>
                        <td class="text-center"><asp:Button ID="Button10" runat="server" Text="10" OnClick="Button10_Click" /></td>
                        <td class="text-center"><asp:Button ID="Button11" runat="server" Text="11" OnClick="Button11_Click" /></td>
                        <td class="text-center"><asp:Button ID="Button12" runat="server" Text="12" OnClick="Button12_Click" /></td>
                    </tr>
                    <tr>
                        <td class="text-center"><asp:Button ID="Button13" runat="server" Text="13" OnClick="Button13_Click" /></td>
                        <td class="text-center"><asp:Button ID="Button14" runat="server" Text="14" OnClick="Button14_Click" /></td>
                        <td class="text-center"><asp:Button ID="Button15" runat="server" Text="15" OnClick="Button15_Click" /></td>
                        <td class="text-center"><asp:Button ID="Button16" runat="server" Text="16" OnClick="Button16_Click" /></td>
                    </tr>
                   
                    <asp:Label ID="Label3" runat="server" Text="Please select a seat" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
                </table>
                    
           </div>
            
        </div>

    </div>
</asp:Content>
