using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // this program will read two numbers, then show the sum
            // of those numbers

            // input 
            // To DO: 
            //1. Add validation 
            //2. make methods. 

            int Input1;
            int Input2;

            Console.WriteLine("Please enter a number (only integers!)");
            Input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another number (only integers!)");
            Input2 = int.Parse(Console.ReadLine());


            // processing

            int Result = Input1 + Input2;

            // output 

            Console.WriteLine($"The result of adding {Input1} and {Input2} is {Result}");

            //Console.WriteLine("The result of adding "+Input1+" and "+ Input2 +" is "+Result);






        }




    }



}
