using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWhileLoopJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {




            //string userChoice;
            //do
            //{
            //    // body of the code 
            //    // we want to run the code at least once 
            //    // body of your code 
            //    Console.WriteLine("Hi C# class!");
            //    // 


            //    Console.WriteLine("do you want to continue (y/n)?");
            //    userChoice = Console.ReadLine();
            //} while (userChoice.ToLower()=="y");




            //// while loop
            //string userChoice = "y";
            //while (userChoice.ToLower() == "y")
            //{

            //    // body of the code 
            //    Console.WriteLine("Hi C# class!");
            //    Console.WriteLine("do you want to continue \"(y/n)\"?");
            //    userChoice = Console.ReadLine();
            //}

            //string userChoice;

            //while (true)
            //{
            //    // body of the code 
            //    Console.WriteLine("Hi C# class!");


            //    Console.WriteLine("do you want to continue \"(y/n)\"?");
            //    userChoice = Console.ReadLine();

            //    if (userChoice.ToLower() == "no")
            //    {
            //        break; // exit the while loop
            //    }

            //}




            // using while loops to do validation 

            int userInput = int.Parse(Console.ReadLine());

            // write a while loop to check if a number is between 1 and 100

            // while the number is out of range, ask the user for a new number
            while (userInput<0 || userInput>100)
            {

                Console.WriteLine("Please, enter a number between 1 and 100, like now!");
                userInput= int.Parse(Console.ReadLine());

            }




        }
    }
}
