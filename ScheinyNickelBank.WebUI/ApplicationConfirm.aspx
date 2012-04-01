<%@ Page Title="Account Creation Complete" Language="C#" MasterPageFile="~/Site.master"  AutoEventWireup="true" CodeFile="ApplicationConfirm.aspx.cs" Inherits="ApplicationConfirmation" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 96px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
        <asp:Label ID="lblConfirmation" runat="server" Text="Welcome to Schein Bank. You made it." CssClass="directions"></asp:Label>
    <p>
        <asp:Button ID="btnGoToLogin" runat="server" Text="Login To Account" 
            onclick="btnGoToLogin_Click" />
     <br />
    </p>

    </div>
</asp:Content>
