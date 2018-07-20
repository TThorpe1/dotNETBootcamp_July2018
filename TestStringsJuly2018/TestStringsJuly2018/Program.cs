using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStringsJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "Hello world";

            //string str2 = new string('*', 10);

            //Console.WriteLine(str2);

            //for (int i = 1; i <= 10; i++)
            //{
            //    string s = new string('*',i);
            //    Console.WriteLine(s);

            //}

            //Console.WriteLine(str[0]);// print the first char
            //Console.WriteLine(str.Length);
            //Console.WriteLine(str[str.Length-1]);// print the last char 

            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}

            string str3 = "Please do not cross the street from this point!";

            Console.WriteLine(str3.IndexOf("hello"));// -1

            Console.WriteLine(str3.Contains("Hello"));// false


            Console.WriteLine(str3.Substring(0,6));// Please 
            Console.WriteLine(str3.Substring(6));// will start at index 6 all the way to the end of the string 

            // str[0] = 'p'; can't be done! Because strings are immutable 
            str3 = str3.Replace("do not", "don't");
            Console.WriteLine(str3);






        }
    }
}
