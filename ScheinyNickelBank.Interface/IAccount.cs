using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScheinyNickelBank.Interface
{
    public interface IAccount
    {
        Int32 AccountNumber { get; set; }
        Decimal Balance { get; set; }
        String ProductType { get; set; }
        DateTime OpenDate { get; set; }
        DateTime CloseDate { get; set; }
        String AccountStatus { get; set; }
    
    }
}
