using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._7
{
    public abstract class Employee
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string GetFullName() => FirstName + " " + LastName;
    }
}
