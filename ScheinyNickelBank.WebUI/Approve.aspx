<%@ Page Title="Terms and Conditions" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Approve.aspx.cs" Inherits="Approve" %>

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
     <asp:Label ID="lblChooseProduct" runat="server" Text="You are almost there." CssClass="directions"></asp:Label>
        <p>&nbsp;</p>
        <textarea id="TextArea1" cols="40" rows="5">Online Banking Terms and ConditionsPrint Contact Us INTRODUCTION
This Agreement governs your use of the Capital One Online Banking and Bill Payment Services (the “Services”, as further defined below). Use of the Services is expressly conditioned on your acceptance of this Agreement. By using the Services, you acknowledge that you have read and agree to abide by the terms and conditions of this Agreement. If you decide not to agree to the terms and conditions discussed herein, you may not use the Services.

This Agreement is hereby made a part of the Terms and Conditions for capitalone.com and the Terms and Conditions for capitalonebank.com, and all such Terms and Conditions apply to your use of the Services on this Web site (the “Online Banking Site”).

In addition to this document, in connection with your use of the Services, you may be subject to, and/or required to agree to, various guidelines, rules, schedules, disclosures, disclaimers and other terms that we may post on the Online Banking Site or any other Capital One Site (as defined below) or otherwise provide or make available to you from time to time. Furthermore, if you use certain features, products or services available on or through the Services, you will be subject to, and/or required to agree to, separate user agreements, customer agreements or similar agreements governing or relating to such features, products or services. All such guidelines, rules, disclosures, disclaimers, user agreements or similar agreements, and other terms and conditions (collectively, “Additional Agreements”) are hereby incorporated by reference into this Agreement. Additional Agreements shall include, without limitation, agreements, rules or other terms governing any checking, savings or other deposit accounts, loan, line of credit and credit card accounts, investment accounts and any other accounts that you may view, modify or otherwise access while using the Services; fee schedules; our electronic funds transfer agreement and disclosures; our Online Bill Payment Authorization and Agreement; and your signature card.

If the terms and conditions of this Agreement conflict with the terms and conditions contained in any Additional Agreement solely as they apply to online banking and online bill payment services, this Agreement controls; provided, that the terms and conditions of this Agreement are not intended to modify any disclosures or other terms that are required by law and that are provided by Capital One in an Additional Agreement.

This Agreement shall apply regardless of the means by which the Services are accessed, including, but not limited to, through the URL address http://www.capitalone.com, http://www.capitalonebank.com, electronic mail, or links from another Web site via a computer, mobile device, or any other means of access.

DEFINITIONS
The Parties

Online Banking offers both automated security alerts and opt-in alerts. Security alerts are sent to your primary e-mail address automatically for fraud reasons when certain changes to your account occur, such as the addition of a new bill payee(s), password and user ID updates, or changes in your physical or primary email address. These alerts are part of the Online Banking service and are not optional.

In addition to security alerts, you may choose to receive additional alerts regarding other online banking and account activity delivered by telephone or e-mail. You will be asked to select from contact options when you sign up for the alert. By signing up to receive any opt-in alerts, you consent to delivery of such alerts in the format selected (such as text or prerecorded voice) to the contact telephone numbers or email addresses you identify. You are responsible for notifying us of any changes to your e-mail, mobile device, and telephone contacts to which alerts are sent. To stop receiving any optional alerts, log into Online Banking and change your selections from the Set Alerts page or contact Customer Service at 1-877-442-3764.

Your full account number will not be included in any alert. However, alerts may contain our name and information about your accounts. Depending upon the alert, information pertaining to loan and checking account balances, checks written, or insufficient funds may be included. Anyone with access to your e-mail, mobile device(s), and telephone or telephone answering machine(s) or service(s) may be able to access the contents of the alerts. It is your responsibility to secure these devices, protect your user name(s) and password(s), and provide timely information about telephone or e-mail contact changes in order to protect the confidentiality of this information. You consent to any disclosures by Capital One which may occur if you do not take appropriate steps to prevent access to your information by unauthorized persons.

own professional advisor on such matters. Information about products and services which you do not already have with Capital One is provided for informational purposes only and should not be considered as an offer to make those products and services available to you.

SEVERABILITY
If any provision of this Agreement is void or unenforceable in any jurisdiction, such ineffectiveness or unenforceability shall not affect the validity or enforceability of such provision in another jurisdiction or any other provision in that or any other jurisdiction.

AREA OF SERVICE
Unless otherwise agreed by Capital One, the Services described in this Agreement are solely offered to citizens of the United States of America.

The United States Export Control laws prohibit the export of certain technical data and software to certain territories. No contents from the Online Banking Site or any other Capital One Site may be downloaded or otherwise exported in violation of United States Law.

COLLECTION EXPENSES
If we have to file a lawsuit to collect whatever you owe us, you will pay our reasonable expenses, including attorneys' fees and court costs.

GOVERNING LAW
This Agreement is governed by and interpreted in accordance with all applicable federal laws and regulations and, as this Agreement applies to each individual account that you may access using the Services, by the state laws and regulations governing such account or the account agreement for such account.
</textarea>
<p>&nbsp;</p>
        <asp:Label ID="lblApprove" runat="server" Text="Do you agree to our terms and conditions?"></asp:Label>
    </div>
    <asp:Button ID="btnApprove" runat="server" Text="Agree" 
        onclick="btnApprove_Click" />
</asp:Content>
