using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestDebuggingJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid zip code:");
            string input = Console.ReadLine();

            if (Regex.IsMatch(@"^\d{5}$", input))
            {

                Console.WriteLine("Valid input!");

            }
            else
            {
                Console.WriteLine("Input not valid!");

            }


        }
    }
}
