using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRecursionJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(4));

            Console.WriteLine();

        }

        public static int Fact(int n)
        {
            if (n == 1)
            { return 1; }
            else
            { return Fact(n - 1) * n; }


        }

        public static int Sum(int input)
        {
            int numberSum = 0;
            for (int i = 0; i <= input; i++)
            {

                numberSum = i + numberSum; 

            }

            return numberSum; 

        }

        public static int RecursiveSum(int input)
        {
            if (input == 0)
            {
                return 0;
            }
            else
            {
                return RecursiveSum(input - 1) + input;
            }


        }


    }
}
