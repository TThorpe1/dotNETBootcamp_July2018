using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOPJuly2018
{
    class Teacher : Employee
    {
        private float bonus;

        public float Bonus
        {
            set { bonus = value; }
            get { return bonus; }
        }

        public Teacher()
        {
            bonus = 2000;

        }

        public Teacher(string fn, string ln, float sal, string s, float b)
            :base(fn,ln,sal,s)
        {
         
            //FirstName = fn;
            //LastName = ln;
            //Salary = sal;
            //SSN = s;

            Bonus = b; 
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Bonus: {Bonus}");
        }

    }
}
