using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ScheinyNickelBank.Business;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        btnLogin.Focus();
    }
  
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        CustomerBL cbl = new CustomerBL();
        String customer_id = cbl.VerifyLoginInfo(txtUser.Text, txtPassword.Text);

        if (customer_id == String.Empty)
        {
            lblLoginMsg.Text = "Username and Password doesn't match.";
        }
        else
        {
            Session["CustomerId"] = customer_id;
            Response.Redirect("/ScheinyNickelBank.WebUI/Customer.aspx");
        }

    }
    protected void imgbtnOpenAcct_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("/ScheinyNickelBank.WebUI/ChooseProduct.aspx");
    }
}
