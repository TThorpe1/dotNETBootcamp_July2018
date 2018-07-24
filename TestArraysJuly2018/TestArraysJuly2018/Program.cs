using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArraysJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // create arrays

            int numberOfStudents = 5;

            // create an array that has 15 elements that are initialized to 0s
            int[] ages = new int[numberOfStudents];

            // initialize an array
            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine("Please enter the next Age:");
                // access array elements 
                ages[i] = int.Parse(Console.ReadLine());
            }


            // create and initialize 
            //double[] interestRates = { 12.3, 16.7, 20.1 };  

            // double[] interestRates =new double[] { 12.3, 16.7, 20.1 };

            float sum = 0;
            for (int i = 0; i < ages.Length; i++)
            {

                sum = sum + ages[i];

            }

            Console.WriteLine($"Average = {sum/ages.Length}");

            // find the max in the array 


            int max = ages[0]; //assume that the max is the first element
            int min = ages[0];
            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] > max)// compare the next element to the max 
                {
                    max = ages[i];

                }
                if (ages[i] < min)// compare the next element to the min 
                {
                    min = ages[i];

                }

            }


            


        }
    }
}
