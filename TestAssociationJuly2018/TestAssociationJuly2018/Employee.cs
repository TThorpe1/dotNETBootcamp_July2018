using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssociationJuly2018
{
    class Employee
    {
        public string FullName { set; get;  }
        public Address HomeAddress { set; get; }

        public Employee()
        {
            HomeAddress = new Address("", "", "");
            FullName = "Not assigned";
        }
    }
}
