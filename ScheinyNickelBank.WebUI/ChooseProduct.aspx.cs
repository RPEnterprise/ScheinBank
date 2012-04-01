using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChooseProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnChooseProduct_click(object sender, EventArgs e)
    {
         List<String> prods = new List<String>();

          for (int i = 0; i < CheckBoxList1.Items.Count; i++)
          {
              if (CheckBoxList1.Items[i].Selected)
                  prods.Add(CheckBoxList1.Items[i].Value);
          }
        
        /*
        string product = "";

        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected)
                product = CheckBoxList1.Items[i].Value;
        }
        */
        Session["Products"] = prods;
       Response.Redirect("/ScheinyNickelBank.WebUI/PersonalInfo.aspx");
    }
}