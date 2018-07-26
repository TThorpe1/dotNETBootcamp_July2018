using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hashfunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string Hello = "Hello";

            Hashtable names = new Hashtable();

            names.Add(CalculateHash(Hello), Hello);
            names.Add(CalculateHash("James"), Hello);
            names.Add(CalculateHash("John"), Hello);


            string input = Console.ReadLine();

            if (names[CalculateHash(input)] != null)
            {
                Console.WriteLine($"Found {input}");
            }

            else
            {

                Console.WriteLine("Not found!");
            }

        }

        static UInt64 CalculateHash(string read)
        {
            UInt64 hashedValue = 3074457345618258791ul;
            for (int i = 0; i < read.Length; i++)
            {
                hashedValue += read[i];
                hashedValue *= 3074457345618258799ul;
            }
            return hashedValue;
        }
    }
}
