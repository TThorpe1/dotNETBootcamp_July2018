using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOPAbstractClasses
{
    class Square:Shape
    {
        private double Length { set; get; }

        public override double CalculateArea()
        {
            // return Math.Pow(Length, 2);
            return Length * Length; 
        }

        public override void Draw()
        {
            int SquareLength = (int)Math.Floor(Length);
            Console.WriteLine(new string('*',SquareLength ));
            for (int i = 1; i <= Length-2; i++)
            {
            Console.WriteLine("*" + new string (' ',SquareLength-2)+ "*");
            }
            Console.WriteLine(new string('*', SquareLength));
        }

        public Square(string name, double len)
        {
            Name = name;
            Length = len; 

        }

    }
}
