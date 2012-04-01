using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System.Data.Common;

namespace ScheinyNickelBank.DataAccess
{
    public class TransactionDA
    {

        public DataSet GetAllTransactions(String accountnumber)
        {

            try
            {
                Database db = DatabaseFactory.CreateDatabase();

                DbCommand dbCommand = db.GetStoredProcCommand("usp_SNB_GetAllTransactions");

                db.AddInParameter(dbCommand, "@accountnumber", DbType.String, accountnumber);


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

        public void InsertTransaction(String accountnumber, string amount, int transtype)
        {

            try
            {
                Database db = DatabaseFactory.CreateDatabase();

                DbCommand dbCommand = db.GetStoredProcCommand("usp_SNB_InsertTransaction");

                db.AddInParameter(dbCommand, "@accountnumber", DbType.String, accountnumber);
                db.AddInParameter(dbCommand, "@amount", DbType.String, amount);
                db.AddInParameter(dbCommand, "@transtype", DbType.Int32, transtype);

                db.ExecuteScalar(dbCommand);

                dbCommand.Connection.Close();
                dbCommand.Connection.Dispose();
                dbCommand.Dispose();

                


            }

            catch (Exception ex)
            {

            }

            

        }
    }
}
