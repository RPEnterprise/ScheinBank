using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using ScheinyNickelBank.Business;

public partial class Approve : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnApprove_Click(object sender, EventArgs e)
    {
        String customerid;
        String appid=Session["ApplicationId"].ToString();
        
        ApplicationBL abl = new ApplicationBL();
        CustomerBL cbl = new CustomerBL();
        AccountBL acbl = new AccountBL();

        abl.UpdateApplicationStatus(appid, 3);
        customerid= cbl.InsertCustomer(appid);
        acbl.InsertAccount(appid, customerid);


        Response.Redirect("/ScheinyNickelBank.WebUI/ApplicationConfirm.aspx");
    }
}