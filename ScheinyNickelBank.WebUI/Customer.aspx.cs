using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ScheinyNickelBank.Business;
using System.Data;

public partial class Customer : System.Web.UI.Page
{
    private string customerid;

    protected void Page_Load(object sender, EventArgs e)
    {

        customerid = Session["CustomerId"].ToString();

        if (!Page.IsPostBack)
        {
            customerid = Session["CustomerId"].ToString();

            BindCustomerData();
            BindAccountData();
        }
   


    }


    public void BindCustomerData()
    {

        CustomerBL cbl = new CustomerBL();
        DataSet ds = cbl.GetCustomer(customerid);

        foreach (DataTable DT in ds.Tables)
        {

            foreach (DataRow DR in DT.Rows)
            {
                if (DR["first_name"].ToString() != String.Empty)
                    lblWelcome.Text = DR["first_name"].ToString();

            }
        }
    }



    public void BindAccountData()
    {

        AccountBL abl = new AccountBL();
        DataSet ads = abl.GetAccount(customerid);


        ddlAccountsTran.DataTextField = "account_number";
        ddlAccountsTran.DataSource = ads;
        ddlAccountsTran.DataBind();

        ddlAccountsDepWdwl.DataTextField = "account_number";
        ddlAccountsDepWdwl.DataSource = ads;
        ddlAccountsDepWdwl.DataBind();

        gvAccountSummary.DataSource = ads;
        gvAccountSummary.DataBind();
    }


    public void ddlAccountsTranIndex_Changed(Object sender, EventArgs e)
    {
       //caching needed
        TransactionBL tbl = new TransactionBL();
        DataSet ds = tbl.GetAllTransactions(ddlAccountsTran.SelectedValue);
        gvTransactions.DataSource = ds;
        gvTransactions.DataBind();

    }

    

   protected void btnDepositWithdrwal_Click(object sender, EventArgs e)
   {

       TransactionBL tbl = new TransactionBL();

       if (txtDepositAmount.Text != String.Empty)
       {
           tbl.InsertTransaction(ddlAccountsDepWdwl.SelectedValue, txtDepositAmount.Text, 1);
           txtDepositAmount.Text = "";
       }

       if (txtWithdrawlAmount.Text != String.Empty)
       {
           tbl.InsertTransaction(ddlAccountsDepWdwl.SelectedValue, txtWithdrawlAmount.Text, 2);
           txtWithdrawlAmount.Text = "";
       }
       BindCustomerData();
       BindAccountData();
       
       
   }

   protected void onPageIndexChanging(object sender, GridViewPageEventArgs e)
   {
       gvTransactions.PageIndex = e.NewPageIndex;
 
       BindCustomerData();
       BindAccountData();
   }
}