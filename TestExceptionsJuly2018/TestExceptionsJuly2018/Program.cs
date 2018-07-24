using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExceptionsJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int Input1;
                int Input2;

                Input1 = ReadInteger("Please enter the first number");

                Input2 = ReadInteger("If you are still alive, please enter the 2nd number");


                // processing

                int Result = Input1 / Input2;

                // output 

                Console.WriteLine($"The result of adding {Input1} and {Input2} is {Result}");

                //Console.WriteLine("The result of adding "+Input1+" and "+ Input2 +" is "+Result);

            }
            catch (OverflowException ex)
            {


            }

            catch (FormatException ex)
            {



            }

            catch (DivideByZeroException ex)
            {




            }
            catch (Exception ex) // ex is a variable that will store the info about the exception 
            {
                Console.WriteLine(ex.ToString()); // save this to a file! 
                Console.WriteLine("Sorry! The code is not working now! Please call 313-433-4454.");

            }


            Console.WriteLine("Hey, I am still working here! ");

        }

        public static int ReadInteger(string message)
        {
            Console.WriteLine(message);
            int input = int.Parse(Console.ReadLine());
            return input;

        }



    }
    }

