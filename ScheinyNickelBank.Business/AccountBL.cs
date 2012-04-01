using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using ScheinyNickelBank.DataAccess;
using ScheinyNickelBank.Interface;


namespace ScheinyNickelBank.Business
{
   public class AccountBL: IAccount
    {
       private Int32 account_number;
       private Decimal balance;
       private String product_type;
       private DateTime open_date;
       private DateTime close_date;
       private String account_status;

       public void InsertAccount(String appid, String customerid)
       {

           try
           {
               AccountDA cda = new AccountDA();
               cda.InsertAccount(appid,customerid);
      

           }
           catch (Exception ex)
           {

           }
           
       }



       public DataSet GetAccount(String customerid)
       {

           try
           {
               AccountDA cda = new AccountDA();
               return cda.GetAccount(customerid);

           }
           catch (Exception ex)
           {

           }

           return null;


       }



       public Int32 AccountNumber { 

           get { return account_number;  }
           set { account_number = value; }
       }

       public Decimal Balance {
           get { return balance; }
           set { balance = value; } 
       }

       public String ProductType {
           get { return product_type; }
           set { product_type = value; } 
       }

       public DateTime OpenDate {
           get { return open_date; }
           set { open_date = value; }
       }

       public DateTime CloseDate {
           get { return close_date; }
           set { close_date = value; }
       }

       public String AccountStatus {
           get { return account_status; }
           set { account_status = value; }
       }


    }
}
