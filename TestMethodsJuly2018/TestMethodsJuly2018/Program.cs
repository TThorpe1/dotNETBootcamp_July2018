using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMethodsJuly2018
{
    class Program
    {

        static void Main(string[] args)
        {
            // write a method that reads and returns an integer! The method will 
            // take the prompt as input 
            // int x = ReadInteger("Please enter a number");
            // int y = ReadInteger("Please enter another number");


            Console.WriteLine("Please enter a number:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another number:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(Sum(x,y));
           Console.WriteLine("Bye Bye!");

        }
        static int Sum(int number1, int number2)
        {
            int result = number1 + number1;

            return result; 

        }



    }
}
