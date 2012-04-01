using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScheinyNickelBank.Interface
{
    public interface IApplication
    {
        Int32 ApplicationID { get; set; }
        String FirstName { get; set; }
        String LastName { get; set; }
        String Email { get; set; }
        String Ssn { get; set; }
        String ProductType { get; set; }
        String ApplicationStatus { get; set; }
    }
}
