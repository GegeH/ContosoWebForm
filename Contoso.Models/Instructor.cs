using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Instructor : Person
    {    
        public DateTime? HireDate { get; set; }
        public decimal Salary { get; set; }
    }
}
