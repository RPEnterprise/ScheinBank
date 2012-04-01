using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System.Data.Common;
using ScheinyNickelBank.Interface;
namespace ScheinyNickelBank.DataAccess
{
    public class AccountDA
    {

        public void InsertAccount(String appid, String customerid)
        {

            try
            {
                Database db = DatabaseFactory.CreateDatabase();

                DbCommand dbCommand = db.GetStoredProcCommand("usp_SNB_InsertAccount");

                db.AddInParameter(dbCommand, "@appid", DbType.String, appid);
                db.AddInParameter(dbCommand, "@customer_id", DbType.String, customerid);
       

                //DataSet ds = db.ExecuteDataSet(dbCommand);
                db.ExecuteScalar(dbCommand).ToString();

                dbCommand.Connection.Close();
                dbCommand.Connection.Dispose();
                dbCommand.Dispose();

            }

            catch (Exception ex)
            {
                //
            }
        }


        public DataSet GetAccount(String customerid)
        {

            try
            {
                Database db = DatabaseFactory.CreateDatabase();

                DbCommand dbCommand = db.GetStoredProcCommand("usp_SNB_GetAccount");

                db.AddInParameter(dbCommand, "@customerid", DbType.String, customerid);


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
