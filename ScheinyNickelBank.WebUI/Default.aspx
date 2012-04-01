<%@ Page Title="Schein Bank" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 96px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

<table width="100%">
<tr>
    <td>    
        <asp:Label ID="lblStartBanking" runat="server" Text="Start Banking. Login or " CssClass="directions"></asp:Label>
    <br />
     <a href="ChooseProduct.aspx"> <img border="0" src="images/btnOpenAccount.jpg" /></a>
            
    <table style="width: 100%;">
        <tr>
            <td class="style1">
                UserName
            </td>
            <td>
                <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style1">
                Password
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;
                
            </td>
            <td><asp:Button ID="btnLogin" runat="server" Text="Login" 
                    onclick="btnLogin_Click" TabIndex="1" />
                &nbsp;
                <asp:Label ID="lblLoginMsg" runat="server" ForeColor="#FF3300" Text=""></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
  
    </table>
  </td>
  <td>
  <img src="images/landing_page_graphic.jpg" />
  
  </td>
  </tr>
  </table>


</asp:Content>
