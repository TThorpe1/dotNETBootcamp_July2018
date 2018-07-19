using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSwitchJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // build a program for a small shop 
            // The program will have a menu, and it will ask the user for selection

            // Show the menu
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to GC Shop!");
            Console.WriteLine("Please select an option");
            Console.WriteLine("1. Coke");
            Console.WriteLine("2. Water");
            Console.WriteLine("3. Kit Kat");
            Console.WriteLine("4. M&Ms");
            

            // Input
            int selection = int.Parse(Console.ReadLine());
            // switch
            switch(selection)
            {
                case 1: // if (selection == 1 )

                    Console.WriteLine("make a selection:");
                    Console.WriteLine("1. 12 OZ");
                    Console.WriteLine("2. 16 Oz");
                    int sizeSelection = int.Parse(Console.ReadLine());

                    if (sizeSelection == 1)
                    {
                        Console.WriteLine("Here is your 12 OZ coke!");
                    }
                    else if (sizeSelection == 2)
                    {
                        Console.WriteLine("Here is your 16 OZ coke!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong selection! ");
                    }


                    break;
                case 2:
                    Console.WriteLine("Healthy option! Water is good.");
                    break;
                case 3:
                    Console.WriteLine("Enjoy ur Kit Kat!");
                    break;
                case 4:
                    Console.WriteLine("Good choice!");
                    break;
                default:
                    Console.Beep();
                    Console.WriteLine("Wrong Selection!");
                    break;
            }


        }
    }
}
