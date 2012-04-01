<%@ Page Title="Choose Product" Language="C#" MasterPageFile="~/Site.master"  AutoEventWireup="true" CodeFile="PersonalInfo.aspx.cs" Inherits="PersonalInfo" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style2
    {
        width: 8%;
    }
    .style3
    {
        width: 11%;
    }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
        <asp:Label ID="lblPersonalInfo" runat="server" Text="Tell us more about yourself." CssClass="directions"></asp:Label>
        <p>&nbsp;</p>
        <table style="width:100%;">
            <tr>
            <td class="style3"></td>
                <td class="style2">
                    First Name</td>
                <td width="40%">
                    <asp:TextBox ID="txtFirstName" runat="server" style="margin-left: 0px"></asp:TextBox>
                </td>
             
            </tr>
            <tr>
            <td class="style3"></td>
                <td class="style2">
                    Last Name</td>
                <td width="40%">
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
            
            </tr>
            <tr>
            <td class="style3"></td>
                <td class="style2">
                    SSN</td>
                <td width="40%">
                    <asp:TextBox ID="txtSSN" runat="server"></asp:TextBox>
                </td>
         
                
            </tr>
            <tr>
            <td class="style3"></td>
                <td class="style2">
                Email
                </td>
                <td width="40%">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td> 
                </tr>
                <tr>  
                <td></td>  
                <td></td> 
                <td width="40%"><asp:Button ID="btnPersInf" runat="server" Text="Next" onclick="btn_PersInfClick" /></td>
            </tr>
        </table>
    
    </div>
    
 </asp:Content>
