using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;


namespace ScheinyNickelBank.DataAccess
{
    public class CustomerDA
    {
        public String VerifyLoginInfo(String username, String password)
        {
            String cid = "";
            try
            {
                Database db = DatabaseFactory.CreateDatabase();

                DbCommand dbCommand = db.GetStoredProcCommand("usp_SNB_VerifyLoginInfo");

                db.AddInParameter(dbCommand, "@username", DbType.String, username);
                db.AddInParameter(dbCommand, "@password", DbType.String, password);
              

                cid = db.ExecuteScalar(dbCommand).ToString();

                dbCommand.Connection.Close();
                dbCommand.Connection.Dispose();
                dbCommand.Dispose();

                
 

            }

            catch (Exception ex)
            {

            }


            return cid;

        }

        public String InsertCustomer(string appid)
        {
            string customerid = "";
            try
            {
                Database db = DatabaseFactory.CreateDatabase();

                DbCommand dbCommand = db.GetStoredProcCommand("usp_SNB_InsertCustomer");

                db.AddInParameter(dbCommand, "@appid", DbType.Int32, appid);


                customerid = db.ExecuteScalar(dbCommand).ToString();

                dbCommand.Connection.Close();
                dbCommand.Connection.Dispose();
                dbCommand.Dispose();

                


            }

            catch (Exception ex)
            {

            }


            return customerid;

        }


        public DataSet GetCustomer(string customerid)
        {
            

            try
            {
                Database db = DatabaseFactory.CreateDatabase();

                DbCommand dbCommand = db.GetStoredProcCommand("usp_SNB_GetCustomer");

                db.AddInParameter(dbCommand, "@customerid", DbType.Int32, customerid);


                DataSet ds = db.ExecuteDataSet(dbCommand);

                dbCommand.Connection.Close();
                dbCommand.Connection.Dispose();
                dbCommand.Dispose();

                return ds;


            }

            catch (Exception ex)
            {

            }

            return null;
            

        }

        public DataSet CheckExistingCustomer()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase();

                DbCommand dbCommand = db.GetStoredProcCommand("usp_SNB_GetExistingCustomer");

                db.AddInParameter(dbCommand, "@ssn", DbType.Int32, "222220000");


                DataSet ds = db.ExecuteDataSet(dbCommand);

                dbCommand.Connection.Close();
                dbCommand.Connection.Dispose();
                dbCommand.Dispose();

                return ds;


            }

            catch (Exception ex)
            {

            }


            return null;

        }


    }
}
