using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOPAbstractClasses
{
    abstract class Shape
    {
        // private string name;

        public string Name
        { set; get;  }

        // every abstract method is a virtual method. 
        public abstract double CalculateArea();
        public abstract void Draw();

        public void PrintName()
        {
            Console.WriteLine($"This shape is a {Name}");
        }

    }
}
