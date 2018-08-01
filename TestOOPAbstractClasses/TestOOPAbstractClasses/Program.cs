using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOPAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square("The most awesome square ever!", 6);

            s.Draw();
            Console.WriteLine(s.CalculateArea());
            // you cannot make objects from abstract classes
            // Shape s2 = new Shape(); 

            Shape p = new Square("square",3); // polymorphism 

          

        }
    }
}
