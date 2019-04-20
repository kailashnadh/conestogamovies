<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="OnlineMovies.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                 <div class="col-md-4">
                     <div class="Image">
                          <asp:Image ID="image1" runat="server" ImageUrl="~/Images/aquaman.jpg" />
                          <asp:Button ID="aquaman" CssClass="button" runat="server" Text="Book Ticket" OnClick="aquaman_Click" />
                     </div>                  
                </div>
                <div class="col-md-4">
                    <div class="Image">
                         <asp:Image ID="image2" runat="server" ImageUrl="~/Images/bats.jpg" />
                         <asp:Button ID="batman" runat="server" Text="Book Ticket" CssClass="button" OnClick="batman_Click" />
                    </div>                 
                </div>  
                 <div class="col-md-4">
                    <div class="Image">
                        <asp:Image ID="image3" runat="server" ImageUrl="~/Images/captainameraica.jpg" />
                         <asp:Button ID="captain" runat="server" Text="Book Ticket" CssClass="button" OnClick="captain_Click" />
                    </div>                 
                </div> 
            </div>         
        </div>
          <div class="row">
            <div class="col-md-12">
                 <div class="col-md-4">
                     <div class="Image">
                         <asp:Image ID="image4" runat="server" ImageUrl="~/Images/game.jpg" />
                         <asp:Button ID="got" runat="server" Text="Book Ticket" CssClass="button" OnClick="got_Click" />
                     </div>                   
                </div>
                <div class="col-md-4">
                    <div class="Image">
                        <asp:Image ID="image5" runat="server" ImageUrl="~/Images/marvel.jpg" />
                        <asp:Button ID="marvel" runat="server" Text="Book Ticket" CssClass="button" OnClick="marvel_Click" />
                    </div>
                </div>         
                <div class="col-md-4">
                    <div class="Image">
                         <asp:Image ID="image6" runat="server" ImageUrl="~/Images/wonderwomn.jpg" />
                        <asp:Button ID="wonderwoman" runat="server" Text="Book Ticket" CssClass="button" OnClick="wonderwoman_Click" />
                    </div>                  
                </div>    
            </div>         
        </div>
    </div>
</asp:Content>
