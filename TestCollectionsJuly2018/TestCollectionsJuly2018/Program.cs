using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollectionsJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {
            


            List<string> studentNames = new List<string>();

            studentNames.Add("Jesse");
            studentNames.Add("Chris");
            studentNames.Add("Zac");
            studentNames.Add("Ash");

            // remove 


            studentNames.Remove("Zac");
            studentNames.RemoveAt(0);


            // insert 

            studentNames.Insert(1, "Kristen");

            // access list elements 

            //Console.WriteLine(studentNames[1]);

            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine(studentNames[i]);
            }

            foreach (string name in studentNames)
            {
                Console.WriteLine(name);
            }



            Stack<string> names = new Stack<string>();

            names.Push("James");
            names.Push("Jacob");


            Queue<int> q1 = new Queue<int>();

            q1.Enqueue(1);
            q1.Enqueue(2);


        }
    }
}
