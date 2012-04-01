using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security; 
using System.Web.Services; 
using System.Web.UI;
using System.Web.UI.WebControls;
using ScheinyNickelBank.Business;

public partial class LoginInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static bool DoesUserExist(string username)
    {
        CustomerBL cbl = new CustomerBL();
        return cbl.checkExistingCustomer();
        
    }

    protected void btnLoginInfo_Click(object sender, EventArgs e)
    {
        ApplicationBL abl = new ApplicationBL();
        abl.UpdateApplicationLoginInfo(Session["ApplicationId"].ToString(), txtUserName.Text, txtPassword.Text);
        Response.Redirect("/ScheinyNickelBank.WebUI/Approve.aspx");
        
    }
}