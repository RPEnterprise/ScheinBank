<%@ Page Title="Login Info" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="LoginInfo.aspx.cs" Inherits="LoginInfo" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style2
        {
            width: 8%;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
        <asp:Label ID="lblChooseLogin" runat="server" Text="Choose Your Login Info." CssClass="directions"></asp:Label>
        <p>&nbsp;</p>
        <table style="width:100%;">
            <tr>
            <td width="20%"></td>
                <td class="style2">
                
                    Username</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr> 
            <td width="20%"></td>
                <td class="style2">
                    Password</td>
                <td width="40%">
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnLoginInfo" runat="server" Text="Next" onclick="btnLoginInfo_Click" />
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
</asp:Content>