using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSelectionStatementsJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {
            //// input 
            //Console.WriteLine("Please enter your age:");
            //int input1 = int.Parse(Console.ReadLine());

            //if (input1 >= 21)
            //{
            //    Console.WriteLine("You can buy Beer!");
            //}
            //else
            //{
            //    Console.WriteLine("Please leave now!");
            //}


            // decide if a user can drive or not 
            // Input 
            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());

            //if (age >= 18)
            //{
            //    Console.WriteLine("Yes, you can drive!");
            //}
            //else
            //{
            //    if (age >= 16)
            //    {
            //        Console.WriteLine("Yes, but have someone with a valid driver licence beside you!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No, ride a bike for now!");
            //    }

            //}


            if (age >= 18)
            {
                Console.WriteLine("Yes, you can drive!");
            }
            else if (age >= 16)
            {
                Console.WriteLine("Yes, but have someone with a valid driver licence beside you!");
            }
            else
            {
                Console.WriteLine("No, ride a bike for now!");
            }
        }
        }
}
