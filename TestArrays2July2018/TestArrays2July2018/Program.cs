using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrays2July2018
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] ar = { 12,1,0,9,23,4,7,8,9};

            // lambda expression used along with LINQ 
             //Console.WriteLine (ar.Where(x => x % 2 == 1).Count());


            // int[] copy = ar; // possible logical error
           
            // making a clone 
            int[] copy = new int[ar.Length];// make an empty array with the same size
            Array.Copy(ar, copy, ar.Length);


            Array.Sort(copy);
            Array.Reverse(copy);

            //foreach (int item in copy)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("======================");
            //foreach (int item in ar)
            //{
            //    Console.WriteLine(item);
            //}


            Console.WriteLine(Array.IndexOf(ar,20));
          

        }
    }
}
