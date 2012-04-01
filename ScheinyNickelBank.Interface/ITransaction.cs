using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScheinyNickelBank.Interface
{
    public interface ITransaction
    {
        Int32 TransactionID { get; set; }
        String TransactionAmount { get; set; }
        String TransactionType { get; set; }
        String AccountNumber { get; set; }
    }
}
