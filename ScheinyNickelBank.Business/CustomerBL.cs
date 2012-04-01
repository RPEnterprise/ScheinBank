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
    public class CustomerBL: ICustomer
    {

        private Int32 customer_id;
        private String first_name;
        private String last_name;
        private String email; 

        public string VerifyLoginInfo(String username, String password)
        {
            try
            {
                CustomerDA cda = new CustomerDA();
                return cda.VerifyLoginInfo(username,password);

            }
            catch (Exception ex)
            {

            }
            return null;
        }


        public string InsertCustomer(string appid)
        {
            try
            {
                CustomerDA cda = new CustomerDA();
                return cda.InsertCustomer(appid);
                
             
            }
            catch (Exception ex)
            {

            }
            return "";
        }


        public DataSet GetCustomer(string customerid)
        {
            try
            {
                CustomerDA cda = new CustomerDA();
                return cda.GetCustomer(customerid);

            }
            catch (Exception ex)
            {

            }

            return null;
        }


        public bool checkExistingCustomer()
        {
            try
            {
                CustomerDA cda = new CustomerDA();
                DataSet ds = cda.CheckExistingCustomer();
       

                foreach (DataTable DT in ds.Tables)
                {

                    foreach (DataRow DR in DT.Rows)
                    {
                        if (Convert.ToBoolean(DR[1].ToString()))
                            return true;

                    }
                }


                
            }
            catch (Exception ex)
            {

            }
            return false;

        }

        public Int32 CustomerID
        {
            get { return customer_id; }
            set { customer_id = value; }
        }

        public String FirstName
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public String LastName
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
