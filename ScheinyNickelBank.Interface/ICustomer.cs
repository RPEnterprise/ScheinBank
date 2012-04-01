using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScheinyNickelBank.Interface
{
    public interface ICustomer
    {
        Int32 CustomerID { get; set; }
        String FirstName { get; set; }
        String LastName { get; set; }
        String Email { get; set; }
    }
}
