using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysCodeChallengeJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {
           // string[] names = {"Drew","Jacob" };

            int[] ar = { 23,25,50,40,30,13,11};

           

            int odd = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] % 2 == 1)
                {
                    odd++;
                }
            }

            foreach (int element in ar)
            {
                if (element % 2 == 1)
                {
                    odd++;
                }

            }

            Console.WriteLine($"Number of odds = {odd}, even numbers = {ar.Length-odd}");

           


        }
    }
}
