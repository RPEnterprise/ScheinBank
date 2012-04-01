using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ScheinyNickelBank.Business;

public partial class PersonalInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_PersInfClick(object sender, EventArgs e)
    {
   

    
            ApplicationBL abl = new ApplicationBL();
            abl.FirstName = txtFirstName.Text;
            abl.LastName = txtLastName.Text;
            abl.Ssn = txtSSN.Text;
            abl.Email = txtEmail.Text;


            //abl.ProductType = Session["Products"].ToString();

            abl.InsertApplication();
            Session["ApplicationId"] = abl.ApplicationID;

            List<String> prods = Session["Products"] as List<String>;

            foreach(String prod in prods)
            {
                abl.InsertApplicationProducts(abl.ApplicationID.ToString(), prod);

            }



        Response.Redirect("/ScheinyNickelBank.WebUI/LoginInfo.aspx");
    }
}