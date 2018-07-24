using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            string input1 = GetValidInput(@"^[A-Z]{1}[a-zA-Z]{0,29}$");

            string input2 = GetValidInput(@"^[a-zA-Z\d]{1,30}\@[a-zA-Z\d]{5,30}\.[a-z]{2,3}$", "Please enter a valid email: ",
                "Sorry, email is not valid!");


            string phoneNumberInput = GetValidInput(@"^\d{3}\-\d{3}\-\d{4}$", "Please enter a valid phone number: ",
               "Sorry, phone number is not valid!");

            Console.WriteLine("Phone number is valid: " + phoneNumberInput);


            string dateInput = GetValidInput(@"^\d{2}\/\d{2}\/\d{4}$", "Please enter a valid date: ",
               "Sorry, date is not valid!");

            string zipCode = GetValidInput(@"^\d{5}$", "Please enter a valid Zip code!",
                "Come on! , can't u just put a valid zip code! ");



        }


        public static string GetValidInput(string pattern,string userMessage="Please enter a valid input:", string errorMessage="Error in input!")
        {
            Console.WriteLine(userMessage);
            string userInput = Console.ReadLine();


            while (!Regex.IsMatch( userInput,pattern))
            //escape sequence; so that you can do and "@" or print "quotes" ( \n \t \'' \\ )
            //the @ first turns off all escape sequences
            {
                Console.WriteLine(errorMessage);
                userInput = Console.ReadLine(); //loops back through the original prompt until valid input
            }

            return userInput; 

        }
    }
}