using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssociationJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();

            Employee e2 = new Employee();

            e1.HomeAddress.StreetName = "Woodward";

            Console.WriteLine(e1.HomeAddress.StreetName);
        }


    }
}
