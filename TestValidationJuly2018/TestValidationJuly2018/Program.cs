using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestValidationJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // write a program that validates zip codes 
            Console.WriteLine("Please enter a valid zip code");
            string input = Console.ReadLine();

            //if (Regex.IsMatch(input, @"^\d{5}$"))
            //{
            //    Console.WriteLine("You entered a valid zip code!");
            //}
            //else
            //{
            //    Console.WriteLine("Nice try! next time please do it right!");
            //}

            while (!Regex.IsMatch(input, @"^\d{5}$"))
            {
                Console.WriteLine("Nice try! next time please do it right!");
                input = Console.ReadLine();

            }

            Console.WriteLine("You entered a valid zip code!");


        }
    }
}
