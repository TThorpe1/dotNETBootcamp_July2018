using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPalindromeJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //string reverse="";// empty string 

            //for(int i=input.Length-1; i>=0;i--)
            //{
            //    reverse = reverse + input[i];// concat 

            //}

            //if (input.ToLower() == reverse.ToLower())
            //{
            //    Console.WriteLine("Input is palindrome!");
            //}
            //else
            //{
            //    Console.WriteLine("The Input is not palindrome!");
            //}

            bool isPalindrome = true;
            input = input.Replace(" ", "");
            for (int i = 0; i < input.Length/2; i++)
            {
                if (char.ToLower(input[i]) != char.ToLower(input[input.Length - i - 1]))
                {
                    //Console.WriteLine("The input is not palindrome!");
                    isPalindrome = false; 
                    break; 
                }
            }
            if (isPalindrome == true)
            {
                Console.WriteLine("The input is palindrome!");
            }
            else
            {
                Console.WriteLine("The input is not palindrome!");
            }



        }
    }
}
