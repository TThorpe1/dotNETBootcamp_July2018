using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMethods3July2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1,2,3));
            Console.WriteLine(Add(1,2,4,5,6,8,23,3));

            //Console.WriteLine(Add());// 0

            Console.WriteLine(Add(2.3,2.3,3.6));
        }

        public static int Add(params int[] input)
        {
            int sum = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return sum;
        }

        public static double Add(params double[] input)
        {
            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return sum;
        }



    }
}
