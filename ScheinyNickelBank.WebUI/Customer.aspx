<%@ Page Title="Manage Account" Language="C#" MasterPageFile="~/Site.master"  AutoEventWireup="true" CodeFile="Customer.aspx.cs" Inherits="Customer" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style2
        {
        font-size: 14px;
        color: #000000;
        width: 127px;
    }
        .style3
        {
            width: 127px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <table border="0" width="100%">
<tr>
 <td width="60%">
    <div>
        Welcome <asp:Label ID="lblWelcome" runat="server" Text=""></asp:Label>
    </div>
    <asp:GridView ID="gvAccountSummary" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField HeaderText="Account Type" 
                DataField="product_type_description" />
            <asp:BoundField HeaderText="Account Number" DataField="account_number" />
            <asp:BoundField HeaderText="Current Balance" DataField="balance" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#498E35" Font-Bold="False" ForeColor="White" 
            Font-Size="Medium" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <br />
    <asp:Label ID="lblTransactions" runat="server" CssClass="customer" Text="View Transactions By Account"></asp:Label>

    <asp:DropDownList ID="ddlAccountsTran" runat="server" 
        OnSelectedIndexChanged="ddlAccountsTranIndex_Changed" AutoPostBack="True" 
        Height="35px" Width="124px" OnLoad="ddlAccountsTranIndex_Changed">
    </asp:DropDownList>
    <asp:GridView ID="gvTransactions" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#336666" BorderStyle="Double" 
        BorderWidth="3px" CellPadding="4" GridLines="Horizontal" 
        OnPageIndexChanging="onPageIndexChanging">
        <Columns>
            <asp:BoundField DataField="transaction_amount" 
                HeaderText="Transaction Amount" />
            <asp:BoundField DataField="transaction_date" HeaderText="Transaction Date" />
            <asp:BoundField DataField="transaction_type_description" 
                HeaderText="Transaction Type" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#498E35" Font-Bold="False" ForeColor="White" 
            Font-Size="Medium" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>
</td>
<td valign="top" width="40%">
    <p>
    <asp:Label ID="lblDepositWithdraw" runat="server" Text="Deposit/Withdraw Funds" CssClass="customer"></asp:Label>
        <asp:DropDownList ID="ddlAccountsDepWdwl" runat="server" Height="35px" 
            Width="124px">
        </asp:DropDownList>
    </p>
    
    <table style="width: 100%;">
        <tr>
            <td class="style2">
             
                Deposit Amount</td>
            <td>
                <asp:TextBox ID="txtDepositAmount" runat="server"></asp:TextBox>
                
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style2">
                
                Withdrawl Amount</td>
            <td>
                <asp:TextBox ID="txtWithdrawlAmount" runat="server"></asp:TextBox>
                
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style3">
                
                
            </td>
            <td>
                <asp:Button ID="btnDepositWithdrwal" runat="server" Text="Process" 
                    onclick="btnDepositWithdrwal_Click" PostBackUrl="~/Customer.aspx" />
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>

</td>
</tr>
</table>
</asp:Content>
