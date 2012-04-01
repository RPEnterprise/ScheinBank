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
    public class ApplicationDA
    {
        public string InsertApplication(IApplication app)
        {

            string appid = "";
            try
            {
                Database db = DatabaseFactory.CreateDatabase();

                DbCommand dbCommand = db.GetStoredProcCommand("usp_SNB_InsertApplication");

                db.AddInParameter(dbCommand, "@first_name", DbType.String, app.FirstName);
                db.AddInParameter(dbCommand, "@last_name", DbType.String, app.LastName);
                db.AddInParameter(dbCommand, "@ssn", DbType.String, app.Ssn);
                db.AddInParameter(dbCommand, "@email", DbType.String, app.Email);



                //DataSet ds = db.ExecuteDataSet(dbCommand);
                appid = db.ExecuteScalar(dbCommand).ToString();

                dbCommand.Connection.Close();
                dbCommand.Connection.Dispose();
                dbCommand.Dispose();

            }

            catch (Exception ex)
            {

            }


            return appid;

        }


        public void UpdateApplicationLoginInfo(string appid, string uname, string pword)
        {

           
            try  

            {
                Database db = DatabaseFactory.CreateDatabase();

                DbCommand dbCommand = db.GetStoredProcCommand("usp_SNB_UpdateApplicationLoginInfo");

                db.AddInParameter(dbCommand, "@application_id", DbType.Int32, Convert.ToInt32(appid));
                db.AddInParameter(dbCommand, "@username", DbType.String, uname);
                db.AddInParameter(dbCommand, "@password", DbType.String, pword);


                db.ExecuteScalar(dbCommand);

                dbCommand.Connection.Close();
                dbCommand.Connection.Dispose();
                dbCommand.Dispose();

            }

            catch (Exception ex)
            {

            }


          

        }

        public void InsertApplicationProducts(string appid, string prodtypeid)
        {


            try
            {
                Database db = DatabaseFactory.CreateDatabase();

                DbCommand dbCommand = db.GetStoredProcCommand("usp_SNB_InsertApplicationProducts");

                db.AddInParameter(dbCommand, "@applicationid", DbType.Int32, Convert.ToInt32(appid));
                db.AddInParameter(dbCommand, "@prodtypeid", DbType.Int32, prodtypeid);
   


                db.ExecuteScalar(dbCommand);

                dbCommand.Connection.Close();
                dbCommand.Connection.Dispose();
                dbCommand.Dispose();

            }

            catch (Exception ex)
            {

            }




        }


        public void UpdateApplicationStatus(string appid, int appstatusid)
        {


            try
            {
                Database db = DatabaseFactory.CreateDatabase();

                DbCommand dbCommand = db.GetStoredProcCommand("usp_SNB_UpdateApplicationStatus");

                db.AddInParameter(dbCommand, "@application_id", DbType.Int32, Convert.ToInt32(appid));
                db.AddInParameter(dbCommand, "@appstatusid", DbType.Int32, appstatusid);

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
