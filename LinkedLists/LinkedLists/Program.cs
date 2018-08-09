using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {


            TheMostAwesomeList MAL_EVER = new TheMostAwesomeList();
            MAL_EVER.Add("James");
            MAL_EVER.Add("Jackson");
            MAL_EVER.Add("Mike");
            Console.WriteLine(MAL_EVER.Count);

            for (int i = 0; i < MAL_EVER.Count; i++)
            {
                Console.WriteLine(MAL_EVER.GetNode(i).Data);
            }

            
        }
    }
}
