using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScheinyNickelBank.DataAccess;
using ScheinyNickelBank.Interface;


namespace ScheinyNickelBank.Business
{
    public class ApplicationBL: IApplication
    {
        private Int32 application_id;
        private String first_name;
        private String last_name;
        private String email;
        private String ssn;
        private String product_type;
        private String application_status;
       

        public void InsertApplication()
        {
            try
            {
                ApplicationDA ada = new ApplicationDA();
                this.application_id= Convert.ToInt32(ada.InsertApplication(this));

            }
            catch (Exception ex)
            {

            }
        }

        public void UpdateApplicationLoginInfo(string appid, string uname, string pword)
        {
            try
            {
                ApplicationDA ada = new ApplicationDA();
                ada.UpdateApplicationLoginInfo(appid, uname, pword);

            }
            catch (Exception ex)
            {

            }
        }

        public void UpdateApplicationStatus(string appid, int appstatusid)
        {
            try
            {
                ApplicationDA ada = new ApplicationDA();
                ada.UpdateApplicationStatus(appid, appstatusid);

            }
            catch (Exception ex)
            {

            }
        }

        public void InsertApplicationProducts(string appid, string prodtypeid)
        {
            try
            {
                ApplicationDA ada = new ApplicationDA();
                ada.InsertApplicationProducts(appid, prodtypeid);

            }
            catch (Exception ex)
            {

            }
        }





        public Int32 ApplicationID { 

            get {return application_id; }
            set {application_id = value;}
        }

        public String FirstName {

            get { return first_name; }
            set { first_name = value; }
        }

        public String LastName {

            get { return last_name; }
            set { last_name=value;  } 
        }

        public String Email {

            get { return email; }
            set { email = value; } 
        }

        public String Ssn
        {

            get { return ssn; }
            set { ssn = value; }
        }

        public String ProductType {

            get { return product_type; }
            set { product_type = value; }
        }

        public String ApplicationStatus {

            get { return application_status; }
            set { application_status = value; }
        } 





    }
}
