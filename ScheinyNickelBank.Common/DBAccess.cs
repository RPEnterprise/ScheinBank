using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace ScheinyNickelBank.Common
{
    public class DBAccess
    {
        public static Database dbConn = DatabaseFactory.CreateDatabase();
    }
}
