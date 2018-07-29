using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PowerRecursion(2, 5));
        }

        public static long Power(int x, int y)
        {
            long result = 1;
            for (int i = 1; i <= y; i++)
            {
                result = result * x;
            }
            return result;
        }

        public static long PowerRecursion(int x, int y)
        {
            if (y == 0)
            {
                return 1;
            }

            return PowerRecursion(x, y - 1) * x;

        }
    }
}
