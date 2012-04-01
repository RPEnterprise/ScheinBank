<%@ Page Title="Choose Product" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ChooseProduct.aspx.cs" Inherits="ChooseProduct" %>


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
        <asp:Label ID="lblChooseProduct" runat="server" Text="Decide how you want to bank with us." CssClass="directions"></asp:Label>
        <p>&nbsp;</p>
        <table width="100%">
        <tr>
            <td width="20%"></td>
            <td with="80%">
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem Value="1">Checking</asp:ListItem>
                <asp:ListItem Value="2">Savings</asp:ListItem>
            </asp:CheckBoxList>
            </td>
            </tr>
            <tr>
            <td></td>
            <td>
            <asp:Button ID="btnChooseProduct" runat="server" Text="Next" 
            onclick="btnChooseProduct_click" />
            </td>
        </tr>
    </table>
    </div>
  
</asp:Content>
