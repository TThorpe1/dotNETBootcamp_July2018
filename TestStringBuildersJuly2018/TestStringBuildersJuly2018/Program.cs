using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStringBuildersJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // GC.Collect();// don't do it! 

            string str = "Hello";// immutable 

            // str[0] = 'h';

           str= "h" + str.Substring(1);

            StringBuilder str2 = new StringBuilder("Hello");// mutable string 
            str2[0] = 'h';

           

        }
    }
}
